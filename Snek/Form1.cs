using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;



namespace Snek
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public int score = 0;
        public int highscore = 0;

        public Snake snake;
        public AppleList Apples;
        public GoldenApple Golden;
        public Apple hover;
        public Random rand;

        public Direction SnakeDir;
        bool gaming = false;
        bool Hover = false;
        int MouseIndex = -1;
        Color bcolor = Color.DarkGray;
        Color scolor = Color.Green;

        System.Media.SoundPlayer BackgroundMusic = new System.Media.SoundPlayer(Directory.GetCurrentDirectory() + @"\Snake Game - Theme Song.wav");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pausebtn_Click(object sender, EventArgs e) // Click pause / resume button
        {
            if (Pausebtn.Text == "Resume") // Click Resume
            {
                Pausebtn.Text = "Pause";
                timer1.Start();
                GoldenTimer.Start();
                Newbtn.Enabled = false;
                Startbtn.Enabled = false;
                Pausebtn.Enabled = true;
                Snapbtn.Enabled = false;
                Loadbtn.Enabled = false;
                Savebtn.Enabled = false;
                Colorbtn.Enabled = false;
                BackColorbtn.Enabled = false;
                Instructionsbtn.Enabled = false;
                if (OptionsPanel.Visible == true)
                {
                    Optionsbtn_Click(sender, e);
                }
            }
            else // Click Pause
            {
                timer1.Stop();
                GoldenTimer.Stop();
                Pausebtn.Text = "Resume";
                Newbtn.Enabled = true;
                Startbtn.Enabled = true;
                Savebtn.Enabled = true;
                Snapbtn.Enabled = true;
                Loadbtn.Enabled = true;
                Colorbtn.Enabled = true;
                BackColorbtn.Enabled = true;
                Instructionsbtn.Enabled = true;
                Optionsbtn.Enabled = true;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e) // Save game
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\Saves";
            saveFileDialog1.FileName = "Score= " + score + "  HighScore= " + highscore;
            saveFileDialog1.Filter = "snek files (*.snk)|*.snk|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, Apples);
                    formatter.Serialize(stream, snake);
                    formatter.Serialize(stream, score);
                    formatter.Serialize(stream, highscore);
                    formatter.Serialize(stream, gaming);
                    formatter.Serialize(stream, Golden);
                    formatter.Serialize(stream, bcolor);
                    formatter.Serialize(stream, scolor);
                    formatter.Serialize(stream, SnakeDir);
                }
            }
        } 

        private void Snapbtn_Click(object sender, EventArgs e) // Take snapshot
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\Screenshots";
            dialog.FileName = "Score= " + score + "  HighScore= " + highscore;
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                Bitmap bmp = new Bitmap(width, height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!gaming)
            {
                return;
            }
            Graphics g = e.Graphics;
            int i;
            for (i = 0; i < snake.snake.Count; i++)
            {
                if (i < snake.snake.Count - 1)
                {
                    snake[i].Draw(g, snake.Color);
                }
                else
                {
                    snake[i].DrawHead(g, snake.Color, snake.Dir);
                }
            }
            for (i = 0; i < Apples.List.Count; i++)
            {
                Apples[i].Draw(g, Color.Red);
            }
            if (Golden.exist)
            {
                Golden.Draw(g, Color.Yellow);
            }
            if (Hover)
            {
                hover.DrawHover(g, Color.Red);
            }
            pictureBox1.BackColor = bcolor;
        }

        private void GoldenTimerTick(object sender, EventArgs e) // Golden timer tick
        {
            if (Golden.exist)
            {
                Golden.Opacity = 255;
                Golden.exist = false;
            }
            if (rand.Next(0, 2) == 1)
            {
                bool isnoton = false;
                while (!isnoton)
                {
                    Golden.X = rand.Next(5, 400) - (Golden.X % 10) + 5;
                    Golden.Y = rand.Next(5, 350) - (Golden.Y % 10) + 5;
                    int i;
                    for (i = 0; i < snake.snake.Count; i++)
                    {
                        if (snake[i].IsOn(Golden))
                        {
                            Golden.X = rand.Next(5, 400) - (Golden.X % 10) + 5;
                            Golden.Y = rand.Next(5, 350) - (Golden.Y % 10) + 5;
                            break;
                        }
                    }
                    for (i = 0; i < Apples.List.Count; i++)
                    {
                        if (Apples[i].IsOn(Golden))
                        {
                            Golden.X = rand.Next(5, 400) - (Golden.X % 10) + 5;
                            Golden.Y = rand.Next(5, 350) - (Golden.Y % 10) + 5;
                            break;
                        }
                    }
                    isnoton = true;
                }
                Golden.exist = true;
            }
            pictureBox1.Invalidate();
        }

        private void TimerTick(object sender, EventArgs e) // Timer tick
        {
            Scoretxt.BackColor = Color.White;
            snake.Dir = SnakeDir;;
            snake.Move();
            snake.CheckWalls();
            if (snake.IsHitTail())
            {
                GameOver();
            }
            if (Golden.exist && snake[snake.snake.Count - 1].IsOn(Golden))//is on Golden apple
            {
                Scoretxt.BackColor = Color.Gold;
                Golden.Eat(ref score);
            }
            else
            {
                int i;
                for (i = 0; i < Apples.List.Count; i++)
                {
                    if (snake[snake.snake.Count - 1].IsOn(Apples[i]))//is on apple
                    {
                        snake.grow();
                        Apples[i].Eat(ref score);
                        Apples.Remove(i);
                        if (Apples.List.Count == 0)
                        {
                            Apples[0] = new Apple();
                            bool CanPlace = false;
                            while (!CanPlace)
                            {
                                Apples[0].X = rand.Next(5, 400);
                                Apples[0].X = Apples[0].X - (Apples[0].X % 10) + 5;
                                Apples[0].Y = rand.Next(5, 350);
                                Apples[0].Y = Apples[0].Y - (Apples[0].Y % 10) + 5;
                                for (i = 0; i < snake.snake.Count; i++)
                                {
                                    if (snake[i].IsOn(Apples[0]))
                                    {
                                        Apples[0].X = rand.Next(5, 400);
                                        Apples[0].X = Apples[0].X - (Apples[0].X % 10) + 5;
                                        Apples[0].Y = rand.Next(5, 350);
                                        Apples[0].Y = Apples[0].Y - (Apples[0].Y % 10) + 5;
                                        break;
                                    }
                                }
                                if (Golden.exist)
                                {
                                    if (Golden.IsOn(Apples[0]))
                                    {
                                        Apples[0].X = rand.Next(5, 400);
                                        Apples[0].X = Apples[0].X - (Apples[0].X % 10) + 5;
                                        Apples[0].Y = rand.Next(5, 350);
                                        Apples[0].Y = Apples[0].Y - (Apples[0].Y % 10) + 5;
                                        break;
                                    }
                                }
                                CanPlace = true;
                            }
                        }
                    }
                }
            }
            if (Golden.Opacity >= 3)
            {
                Golden.Opacity -= 3;
            }
            Scoretxt.Text = "Score: " + score;
            pictureBox1.Invalidate();
        }

        private void Loadbtn_Click(object sender, EventArgs e) // Load a game
        {
            if (!gaming)
            {
                Stratbtn_Click(sender, e);
                Pausebtn_Click(sender, e);
                Soundbtn_Click(sender, e);
            }    
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\Saves";
            openFileDialog1.Filter = "snek files (*.snk)|*.snk|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Apples = (AppleList)binaryFormatter.Deserialize(stream);
                snake = (Snake)binaryFormatter.Deserialize(stream);
                score = (int)binaryFormatter.Deserialize(stream);
                highscore = (int)binaryFormatter.Deserialize(stream);
                gaming = (bool)binaryFormatter.Deserialize(stream);
                Golden = (GoldenApple)binaryFormatter.Deserialize(stream);
                bcolor = (Color)binaryFormatter.Deserialize(stream);
                scolor = (Color)binaryFormatter.Deserialize(stream);
                SnakeDir = (Direction)binaryFormatter.Deserialize(stream);
                Scoretxt.Text = "Score: " + score;
                HighScoretxt.Text = "HighScore: " + highscore;
                pictureBox1.Invalidate();
            }
        }

        private void GameOver() // Game over (snake hit tail)
        {
            gaming = false;
            timer1.Stop();
            GoldenTimer.Stop();
            Pausebtn.Enabled = false;
            Newbtn.Enabled = true;
            Startbtn.Enabled = true;
            Savebtn.Enabled = true;
            Snapbtn.Enabled = true;
            Loadbtn.Enabled = true;
            Colorbtn.Enabled = true;
            BackColorbtn.Enabled = true;
            GameOvertxt.Visible = true;
            Instructionsbtn.Enabled = true;
            BackgroundMusic.Stop();
            
            if (score > highscore)
            {
                highscore = score;
                HighScoretxt.Text = "New HighScore: " + highscore.ToString();
                HighScoretxt.BackColor = Color.Yellow;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) // Mouse buttom down
        {
            if (!gaming)
            {
                return;
            }
            MouseIndex = -1;
            int i;
            for (i = 0; i < Apples.List.Count; i++)
            {
                if (e.X > Apples[i].X - 5 && e.X < Apples[i].X + 5 && e.Y > Apples[i].Y - 5 && e.Y < Apples[i].Y + 5)
                {
                    MouseIndex = i;
                    if (e.Button == MouseButtons.Right && Apples.List.Count > 1)
                    {
                        Apples.Remove(MouseIndex);
                        MouseIndex = -1;
                        pictureBox1.Invalidate();
                        return;
                    }
                    break;
                }
            }
            if (MouseIndex == -1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    bool ison  =false;
                    for (i = 0; i < snake.snake.Count; i++)
                    {
                        if (e.X > snake[i].X - 8 && e.X < snake[i].X + 8 && e.Y > snake[i].Y - 8 && e.Y < snake[i].Y + 8)
                        {
                            ison = true;
                        }
                    }
                    for (i = 0; i < Apples.List.Count; i++)
                    {
                        if (e.X > Apples[i].X - 8 && e.X < Apples[i].X + 8 && e.Y > Apples[i].Y - 8 && e.Y < Apples[i].Y + 8)
                        {
                            ison = true;
                        }
                    }
                    if (Golden.exist && e.X > Golden.X - 8 && e.X < Golden.X + 8 && e.Y > Golden.Y - 8 && e.Y < Golden.Y + 8)
                    {
                        ison = true;
                    }
                    if (!ison)
                    {
                        Apples[Apples.List.Count] = new Apple(e.X, e.Y);
                        MouseIndex = Apples.List.Count - 1;
                    }
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) // Mouse move
        {
            if (gaming)
            {
                int i;
                bool ison = false;
                for (i = 0; i < snake.snake.Count; i++)
                {
                    if (e.X > snake[i].X - 8 && e.X < snake[i].X + 8 && e.Y > snake[i].Y - 8 && e.Y < snake[i].Y + 8)
                    {
                        return;
                    }
                }
                for (i = 0; i < Apples.List.Count; i++)
                {
                    if (e.X > Apples[i].X - 8 && e.X < Apples[i].X + 8 && e.Y > Apples[i].Y - 8 && e.Y < Apples[i].Y + 8)
                    {
                        return;
                    }
                }
                if (Golden.exist && e.X > Golden.X - 8 && e.X < Golden.X + 8 && e.Y > Golden.Y - 8 && e.Y < Golden.Y + 8)
                {
                    return;
                }
                if (e.X <= 0 || e.Y <= 0 || e.X >= 430 || e.Y >= 370)
                {
                    return;
                }
                if (!ison)
                {
                    if (MouseIndex != -1)
                    {
                        Apples[MouseIndex].X = e.X - (e.X % 10) + 5;
                        Apples[MouseIndex].Y = e.Y - (e.Y % 10) + 5;
                    }
                    if (Hover)
                    {
                        hover.X = e.X - (e.X % 10) + 5;
                        hover.Y = e.Y - (e.Y % 10) + 5;
                    }
                }
            }
            pictureBox1.Invalidate();
        }

        private void Newbtn_Click(object sender, EventArgs e) // Start new game file
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                     "New game",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                confirmResult = MessageBox.Show("Would you like to save?",
                                     "New game",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Savebtn_Click(sender, e);
                }
            }
            else return;

            Newbtn.Enabled = true;
            Pausebtn.Enabled = false;
            Snapbtn.Enabled = true;
            Loadbtn.Enabled = true;
            Savebtn.Enabled = true;
            Colorbtn.Enabled = false;
            Optionsbtn.Enabled = true;
            pictureBox1.BackColor = Color.DarkGray;
            bcolor = Color.DarkGray;
            scolor = Color.Green;
            score = 0;
            highscore = 0;
            Scoretxt.Text = "Score: " + score;
            HighScoretxt.Text = "HighScore: " + highscore;
            HighScoretxt.BackColor = Color.White;
            gaming = false;
            Pausebtn.Text = "Pause";
            Startbtn.Text = "Start";
            GameOvertxt.Visible = false;
            pictureBox1.Invalidate();
        }

        private void Stratbtn_Click(object sender, EventArgs e) // Start new round
        {
            timer1.Start();
            GoldenTimer.Start();
            Newbtn.Enabled = false;
            Startbtn.Enabled = false;
            timer1.Enabled = true;
            GoldenTimer.Enabled = true;
            Pausebtn.Enabled = true;
            Snapbtn.Enabled = false;
            Loadbtn.Enabled = false;
            Savebtn.Enabled = false;
            Colorbtn.Enabled = false;
            Instructionsbtn.Enabled = false;
            BackColorbtn.Enabled = false;

            snake = new Snake();
            int i;
            for (i = 0; i < 10; i++)
            {
                snake.snake.Add(new BodyPart());
                snake[snake.snake.Count - 1].X -= 5;
            }
            Apples = new AppleList();
            Golden = new GoldenApple();
            hover = new Apple();
            rand = new Random();

            score = 0;
            Scoretxt.Text = "Score: " + score;
            HighScoretxt.Text = "HighScore: " + highscore;
            HighScoretxt.BackColor = Color.White;
            snake.Color = scolor;
            gaming = true;
            Pausebtn.Text = "Pause";
            GameOvertxt.Visible = false;
            BackgroundMusic.PlayLooping();
            pictureBox1.Invalidate();
        }

        private void Instructionsbtn_Click(object sender, EventArgs e) // Open instructions panel
        {
            CloseInstbtn.Visible = true;
            CloseInstbtn.Enabled = true;
            CloseInstbtn2.Visible = true;
            CloseInstbtn2.Enabled = true;
            Instructionstxt.Visible = true;
            timer1.Stop();
            GoldenTimer.Stop();
            Newbtn.Enabled = true;
            Startbtn.Enabled = true;
            Savebtn.Enabled = true;
            Snapbtn.Enabled = true;
            Loadbtn.Enabled = true;
            timer1.Enabled = false;
            GoldenTimer.Enabled = false;
            Colorbtn.Enabled = true;

        }

        private void CloseInstbtn_Click(object sender, EventArgs e) // Close instructions panel
        {
            Instructionstxt.Visible = false;
            CloseInstbtn.Visible = false;
            CloseInstbtn.Enabled = false;
            CloseInstbtn2.Visible = false;
            CloseInstbtn2.Enabled = false;
        }

        private void Form1_Resize(object sender, EventArgs e) // Minimize window
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Pausebtn_Click(sender, e);
            }
        }

        private void BackColorbtn_Click(object sender, EventArgs e) // Open Background color panel
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = false;
            MyDialog.Color = pictureBox1.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                bcolor = MyDialog.Color;
            }
            pictureBox1.Invalidate();
        }

        private void Optionsbtn_Click(object sender, EventArgs e) // Open options panel
        {
            if (OptionsPanel.Visible)
            {
                OptionsPanel.Visible = false;
            }
            else
            {
                OptionsPanel.Visible = true;
            }
        }

        private void Soundbtn_Click(object sender, EventArgs e) // Sound button click
        {
            if (Soundbtn.Text == "<))")
            {
                BackgroundMusic.Stop();
                Soundbtn.Text = "<X";
            }
            else if(gaming)
            {
                BackgroundMusic.Play();
                Soundbtn.Text = "<))";
            }
        }

        private void CloseInstbtn2_Click(object sender, EventArgs e) // Close instructions panel
        {
            Instructionstxt.Visible = false;
            CloseInstbtn.Visible = false;
            CloseInstbtn.Enabled = false;
            CloseInstbtn2.Visible = false;
            CloseInstbtn2.Enabled = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) // Mouse enters picturebox
        {
            if (gaming)
            {
                Hover = true;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) // Mouse exits picturebox
        {
            Hover = false;
        }

        private void Colorbtn_Click(object sender, EventArgs e) // Open snake color panel
        {
            if (!gaming)
            {
                return;
            }
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = false;
            MyDialog.Color = snake.Color;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                snake.Color = MyDialog.Color;
                scolor = snake.Color;
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) // Mouse button up
        {
            MouseIndex = -1;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // Process arrow keys 
        {
            if (!gaming)
            {
                return false;
            }
            if (keyData == Keys.Up && snake.Dir != Direction.Down)
            {
                SnakeDir = Direction.Up;
            }
            if (keyData == Keys.Down && snake.Dir != Direction.Up)
            {
                SnakeDir = Direction.Down;
            }
            if (keyData == Keys.Left && snake.Dir != Direction.Right)
            {
                SnakeDir = Direction.Left;
            }
            if (keyData == Keys.Right && snake.Dir != Direction.Left)
            {
                SnakeDir = Direction.Right;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
