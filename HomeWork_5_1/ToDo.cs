using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_5_1
{
    public class ToDo
    {
        public int Number { get; }
        public string TitleName { get; }
        public bool Flag { get; set; }

        public ToDo(int number ,string titleName, bool flag)
        {
            Number = number;
            TitleName = titleName;
            Flag = flag;
        }

        public ToDo()
        {

        }

    }
}
