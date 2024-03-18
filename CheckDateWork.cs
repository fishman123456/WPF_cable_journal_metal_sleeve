
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_cable_journal_metal_sleeve;


namespace WPF_cable_journal_metal_sleeve
{
    // класс для проверки текущей даты
    public static class CheckDateWork
    {
        public static void CheckDate()
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("20/08/2024");
            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Time is over 20/08/2024");
                // Выход из проложения добавил 01-01-2024. Чтобы порядок был....
                var mainWindow = (Application.Current.MainWindow as MainWindow);
                if (mainWindow != null)
                {
                    
                    mainWindow.Close();
                }
            }
            else
            {
                //MessageBox.Show("Работайте до   " + dt2.ToString());
            }
        }
    }
}
