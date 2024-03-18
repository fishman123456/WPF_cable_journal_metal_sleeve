using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_cable_journal_metal_sleeve
{
    public static class TextHelp
    {
        public static string stringHelp()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Копируем из кабельного журнала" + "\n" +
                "Столбец Труба (обозначение)" + "\n" +
                "Соответственно металл рукав копируется тоже" + "\n" +
                "По диаметру трубы выбираем диаметр металлрукава  " + "\n" +
                "Копируем из второго текстбокса полученные данные " + " \n" +
                "Пустые строки не допускаются, " + " \n" +
                "допишите в заголовки 0 - или что то другое, удалять вам" +"\n"+
                "Дата изготовления 18.03.2024 13:00:00 " + " \n" +
                "Текущая дата          " + DateTime.Now.ToString() + " \n");
            return sb.ToString();
        }
    }
}
