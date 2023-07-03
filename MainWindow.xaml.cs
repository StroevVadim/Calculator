using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Button bt0 = this.FindName("Bt0") as Button;
            //bt0.Content = "hyo";
            foreach (var el in Gr0.Children) 
            {
                if(el is Button)
                    ((Button)el).Click += Button_Click;
            }
        }
        void Button_Click(object sender, RoutedEventArgs e) 
        {
            string s = (string)((Button)e.OriginalSource).Content;
            if (s == "=")
                Lb0.Content = Convert.ToString(new DataTable().Compute((string)Lb0.Content, null));
            else if (s == "CE")
                Lb0.Content = "";
            else
                Lb0.Content += s;
        }
    }
}
