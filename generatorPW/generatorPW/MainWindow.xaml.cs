using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace generatorPW
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string TickValue { get; private set; }
        public string Password { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            tb_length.DataContext = TickValue;
            tb_pw.DataContext = Password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Password = CreatePW.Create(int.Parse(TickValue));
            tb_pw.DataContext = null;
            tb_pw.DataContext = Password;

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TickValue = slider.Value.ToString();
            tb_length.DataContext = null;
            tb_length.DataContext = TickValue;
        }
    }
}
