using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _46_47_48_49_50_ToanLop3.Phan4.DTO
{
    public class So5ChuSoDTO
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }


        public So5ChuSoDTO(string text, int number) {
            this.number = number;
            this.text = text;
        }

        public So5ChuSoDTO() { }

    }
}
