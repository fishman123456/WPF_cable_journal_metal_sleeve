using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_cable_journal_metal_sleeve
{
    public class StringParse
    {
        public StringParse() { }
        public StringParse(string s) { }

        public string strParse(string s)
        {
            // список для разделенных по \n \r строк 
            List<string> list = new List<string>();
            // создаём строку для сборки диаметров металлрукава и трубы
            StringBuilder sb = new StringBuilder();
            // строка по которой будем разбивать текстбокс
            // расделителем может служить один символ, поэтому строку создаём, т е массив символов
            string[] separator = { "\n", "\r" };
            string[] mass_textBox_Lay_name = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            // проверяем металл-рукав по трубе
            foreach (string item in mass_textBox_Lay_name)
            {
                if (string.IsNullOrEmpty(item)) continue;
                list.Add(item);
                switch (item)
                {
                    case "0": list.Add(  "" + "\n"); break;
                    case "20х2,8": list.Add("\n" + "15" + "\n"); break;
                    case "25х2,8": list.Add("\n" + "20" + "\n"); break;
                    case "32х2,8": list.Add("\n" + "25" + "\n"); break;
                    case "40х3,0": list.Add("\n" + "32" + "\n"); break;
                    case "50х3,0": list.Add("\n" + "38" + "\n"); break;
                    case "65х3,2": list.Add("\n" + "50" + "\n"); break;
                    case "80х3,5": list.Add("\n" + "60" + "\n"); break;
                }
            }
            foreach(string item in list)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
