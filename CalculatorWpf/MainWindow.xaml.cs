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

namespace CalculatorWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Tb.Text += b.Content.ToString();
        }

      





   

        private void result()
        {
            String op;
            int iOp = 0;
            if (Tb.Text.Contains("+"))
            {
                iOp = Tb.Text.IndexOf("+");
            }
            else if (Tb.Text.Contains("-"))
            {
                iOp = Tb.Text.IndexOf("-");
            }
            else if (Tb.Text.Contains("*"))
            {
                iOp = Tb.Text.IndexOf("*");
            }
            else if (Tb.Text.Contains("/"))
            {
                iOp = Tb.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = Tb.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(Tb.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(Tb.Text.Substring(iOp + 1, Tb.Text.Length - iOp - 1));

            if (op == "+")
            {
                Tb.Text = (op1 + op2).ToString();
            }
            else if (op == "-")
            {
                Tb.Text = (op1 - op2).ToString();
            }
            else if (op == "*")
            {
                Tb.Text = (op1 * op2).ToString();
            }
            else
            {
                Tb.Text = (op1 / op2).ToString();
            }
        }
        private void EquallyBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                result();
            }
            catch (Exception exc)
            {
                Tb.Text = "Error!";
            }
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            Tb.Text = "";
        }

        private void RBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Tb.Text.Length > 0)
            {
                Tb.Text = Tb.Text.Substring(0, Tb.Text.Length - 1);
            }
        }

        private void Offbtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
