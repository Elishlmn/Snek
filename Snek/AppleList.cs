using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace Snek
{
    [Serializable]
    public class AppleList
    {
        public SortedList List;

        public AppleList() 
        {
            List = new SortedList();
            List[List.Count] = new Apple();
        }

        public Apple this[int index]
        {
            get
            {
                if (index >= List.Count)
                    return (Apple)null;
                return (Apple)List.GetByIndex(index);
            }
            set
            {
                if (index <= List.Count)
                    List[index] = value;		
            }
        }

        public void Remove(int element)
        {
            if (element >= 0 && element < List.Count)
            {
                for (int i = element; i < List.Count - 1; i++)
                    List[i] = List[i + 1];
                List.RemoveAt(List.Count - 1);
            }
        }
    }
}
