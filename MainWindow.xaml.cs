using Autocad_Wpf_Autolip_Pipe_12_02_2024;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_cable_journal_metal_sleeve
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            textboxCopyToExcel.Text = string.Empty;
            textboxForExcel.Text = string.Empty;
        }

        private void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.textone.Text = TextHelp.stringHelp();

        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            // закрытие программы
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Save_as_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.saveFileMetod(textboxForExcel.Text);
        }

        private void Button_bild_Click(object sender, RoutedEventArgs e)
        {
            StringParse stringParse = new StringParse();
            textboxForExcel.Text = stringParse.strParse(textboxCopyToExcel.Text);
        }

        private void Button_test_Click(object sender, RoutedEventArgs e)
        {
            textboxCopyToExcel.Text = "20х2,8" + "\n" + "25х2,8" + "\n" +
                "40х3,0" + "\n" + "50х3,0" + "\n" + "65х3,2"
                + "\n" + "80х3,5";
        }
    }
}