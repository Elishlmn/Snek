namespace Snek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Scoretxt = new System.Windows.Forms.Label();
            this.HighScoretxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Newbtn = new System.Windows.Forms.Button();
            this.Pausebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Snapbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GoldenTimer = new System.Windows.Forms.Timer(this.components);
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Colorbtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.GameOvertxt = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Instructionsbtn = new System.Windows.Forms.Button();
            this.Instructionstxt = new System.Windows.Forms.Label();
            this.CloseInstbtn = new System.Windows.Forms.Button();
            this.BackColorbtn = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Soundbtn = new System.Windows.Forms.Button();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.Optionsbtn = new System.Windows.Forms.Button();
            this.CloseInstbtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scoretxt
            // 
            this.Scoretxt.AutoSize = true;
            this.Scoretxt.BackColor = System.Drawing.Color.White;
            this.Scoretxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Scoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretxt.Location = new System.Drawing.Point(12, 69);
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.Size = new System.Drawing.Size(77, 22);
            this.Scoretxt.TabIndex = 0;
            this.Scoretxt.Text = "Score:     ";
            // 
            // HighScoretxt
            // 
            this.HighScoretxt.AutoSize = true;
            this.HighScoretxt.BackColor = System.Drawing.Color.White;
            this.HighScoretxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighScoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoretxt.Location = new System.Drawing.Point(119, 69);
            this.HighScoretxt.Name = "HighScoretxt";
            this.HighScoretxt.Size = new System.Drawing.Size(118, 22);
            this.HighScoretxt.TabIndex = 1;
            this.HighScoretxt.Text = "HighScore:       ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 580);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Newbtn
            // 
            this.Newbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Newbtn.Enabled = false;
            this.Newbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Newbtn.Location = new System.Drawing.Point(12, 12);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(90, 30);
            this.Newbtn.TabIndex = 3;
            this.Newbtn.TabStop = false;
            this.Newbtn.Text = "New";
            this.Newbtn.UseVisualStyleBackColor = false;
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // Pausebtn
            // 
            this.Pausebtn.BackColor = System.Drawing.SystemColors.Control;
            this.Pausebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Pausebtn.Enabled = false;
            this.Pausebtn.Location = new System.Drawing.Point(108, 12);
            this.Pausebtn.Name = "Pausebtn";
            this.Pausebtn.Size = new System.Drawing.Size(90, 30);
            this.Pausebtn.TabIndex = 4;
            this.Pausebtn.TabStop = false;
            this.Pausebtn.Text = "Pause";
            this.Pausebtn.UseVisualStyleBackColor = false;
            this.Pausebtn.Click += new System.EventHandler(this.Pausebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.Control;
            this.Savebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Savebtn.Enabled = false;
            this.Savebtn.Location = new System.Drawing.Point(358, 12);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(90, 30);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.TabStop = false;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Snapbtn
            // 
            this.Snapbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Snapbtn.Location = new System.Drawing.Point(548, 12);
            this.Snapbtn.Name = "Snapbtn";
            this.Snapbtn.Size = new System.Drawing.Size(110, 30);
            this.Snapbtn.TabIndex = 6;
            this.Snapbtn.TabStop = false;
            this.Snapbtn.Text = "ScreenShot";
            this.Snapbtn.UseVisualStyleBackColor = false;
            this.Snapbtn.Click += new System.EventHandler(this.Snapbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // GoldenTimer
            // 
            this.GoldenTimer.Interval = 5000;
            this.GoldenTimer.Tick += new System.EventHandler(this.GoldenTimerTick);
            // 
            // Loadbtn
            // 
            this.Loadbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Loadbtn.Location = new System.Drawing.Point(454, 12);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(90, 30);
            this.Loadbtn.TabIndex = 7;
            this.Loadbtn.TabStop = false;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = false;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Colorbtn
            // 
            this.Colorbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Colorbtn.Enabled = false;
            this.Colorbtn.Location = new System.Drawing.Point(8, 44);
            this.Colorbtn.Name = "Colorbtn";
            this.Colorbtn.Size = new System.Drawing.Size(110, 30);
            this.Colorbtn.TabIndex = 8;
            this.Colorbtn.TabStop = false;
            this.Colorbtn.Text = "Snake color";
            this.Colorbtn.UseVisualStyleBackColor = false;
            this.Colorbtn.Click += new System.EventHandler(this.Colorbtn_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Press [esc] to\r\nPause/Resume\r\n";
            // 
            // GameOvertxt
            // 
            this.GameOvertxt.AutoSize = true;
            this.GameOvertxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameOvertxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameOvertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOvertxt.ForeColor = System.Drawing.Color.Red;
            this.GameOvertxt.Location = new System.Drawing.Point(136, 327);
            this.GameOvertxt.Name = "GameOvertxt";
            this.GameOvertxt.Size = new System.Drawing.Size(404, 71);
            this.GameOvertxt.TabIndex = 10;
            this.GameOvertxt.Text = "GAME OVER";
            this.GameOvertxt.Visible = false;
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Startbtn.Location = new System.Drawing.Point(204, 12);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(90, 30);
            this.Startbtn.TabIndex = 11;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = false;
            this.Startbtn.Click += new System.EventHandler(this.Stratbtn_Click);
            // 
            // Instructionsbtn
            // 
            this.Instructionsbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Instructionsbtn.Location = new System.Drawing.Point(8, 80);
            this.Instructionsbtn.Name = "Instructionsbtn";
            this.Instructionsbtn.Size = new System.Drawing.Size(45, 30);
            this.Instructionsbtn.TabIndex = 12;
            this.Instructionsbtn.Text = "?";
            this.Instructionsbtn.UseVisualStyleBackColor = false;
            this.Instructionsbtn.Click += new System.EventHandler(this.Instructionsbtn_Click);
            // 
            // Instructionstxt
            // 
            this.Instructionstxt.AutoSize = true;
            this.Instructionstxt.BackColor = System.Drawing.SystemColors.Control;
            this.Instructionstxt.Location = new System.Drawing.Point(60, 125);
            this.Instructionstxt.Name = "Instructionstxt";
            this.Instructionstxt.Size = new System.Drawing.Size(550, 440);
            this.Instructionstxt.TabIndex = 13;
            this.Instructionstxt.Text = resources.GetString("Instructionstxt.Text");
            this.Instructionstxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Instructionstxt.Visible = false;
            // 
            // CloseInstbtn
            // 
            this.CloseInstbtn.Enabled = false;
            this.CloseInstbtn.Location = new System.Drawing.Point(588, 125);
            this.CloseInstbtn.Name = "CloseInstbtn";
            this.CloseInstbtn.Size = new System.Drawing.Size(22, 30);
            this.CloseInstbtn.TabIndex = 14;
            this.CloseInstbtn.Text = "X";
            this.CloseInstbtn.UseVisualStyleBackColor = true;
            this.CloseInstbtn.Visible = false;
            this.CloseInstbtn.Click += new System.EventHandler(this.CloseInstbtn_Click);
            // 
            // BackColorbtn
            // 
            this.BackColorbtn.BackColor = System.Drawing.SystemColors.Control;
            this.BackColorbtn.Location = new System.Drawing.Point(8, 8);
            this.BackColorbtn.Name = "BackColorbtn";
            this.BackColorbtn.Size = new System.Drawing.Size(110, 30);
            this.BackColorbtn.TabIndex = 15;
            this.BackColorbtn.Text = "Back color";
            this.BackColorbtn.UseVisualStyleBackColor = false;
            this.BackColorbtn.Click += new System.EventHandler(this.BackColorbtn_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.FullOpen = true;
            // 
            // Soundbtn
            // 
            this.Soundbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Soundbtn.Location = new System.Drawing.Point(78, 80);
            this.Soundbtn.Name = "Soundbtn";
            this.Soundbtn.Size = new System.Drawing.Size(45, 30);
            this.Soundbtn.TabIndex = 16;
            this.Soundbtn.Text = "<))";
            this.Soundbtn.UseVisualStyleBackColor = false;
            this.Soundbtn.Click += new System.EventHandler(this.Soundbtn_Click);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.BackColorbtn);
            this.OptionsPanel.Controls.Add(this.Soundbtn);
            this.OptionsPanel.Controls.Add(this.Colorbtn);
            this.OptionsPanel.Controls.Add(this.Instructionsbtn);
            this.OptionsPanel.Location = new System.Drawing.Point(534, 105);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(128, 120);
            this.OptionsPanel.TabIndex = 18;
            this.OptionsPanel.Visible = false;
            // 
            // Optionsbtn
            // 
            this.Optionsbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Optionsbtn.Location = new System.Drawing.Point(548, 64);
            this.Optionsbtn.Name = "Optionsbtn";
            this.Optionsbtn.Size = new System.Drawing.Size(110, 35);
            this.Optionsbtn.TabIndex = 19;
            this.Optionsbtn.TabStop = false;
            this.Optionsbtn.Text = "Options";
            this.Optionsbtn.UseVisualStyleBackColor = false;
            this.Optionsbtn.Click += new System.EventHandler(this.Optionsbtn_Click);
            // 
            // CloseInstbtn2
            // 
            this.CloseInstbtn2.Enabled = false;
            this.CloseInstbtn2.Location = new System.Drawing.Point(60, 125);
            this.CloseInstbtn2.Name = "CloseInstbtn2";
            this.CloseInstbtn2.Size = new System.Drawing.Size(22, 30);
            this.CloseInstbtn2.TabIndex = 20;
            this.CloseInstbtn2.Text = "X";
            this.CloseInstbtn2.UseVisualStyleBackColor = true;
            this.CloseInstbtn2.Visible = false;
            this.CloseInstbtn2.Click += new System.EventHandler(this.CloseInstbtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.Pausebtn;
            this.ClientSize = new System.Drawing.Size(674, 700);
            this.Controls.Add(this.CloseInstbtn2);
            this.Controls.Add(this.Optionsbtn);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.CloseInstbtn);
            this.Controls.Add(this.Instructionstxt);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.GameOvertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Snapbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Pausebtn);
            this.Controls.Add(this.Newbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HighScoretxt);
            this.Controls.Add(this.Scoretxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 760);
            this.MinimumSize = new System.Drawing.Size(700, 760);
            this.Name = "Form1";
            this.Text = "Snek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Newbtn;
        private System.Windows.Forms.Button Pausebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Snapbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer GoldenTimer;
        public System.Windows.Forms.Label Scoretxt;
        public System.Windows.Forms.Label HighScoretxt;
        private System.Windows.Forms.Button Loadbtn;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Colorbtn;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameOvertxt;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Instructionsbtn;
        private System.Windows.Forms.Label Instructionstxt;
        public System.Windows.Forms.Button CloseInstbtn;
        private System.Windows.Forms.Button BackColorbtn;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button Soundbtn;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Button Optionsbtn;
        public System.Windows.Forms.Button CloseInstbtn2;
    }
}

