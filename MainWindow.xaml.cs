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
using MaterialDesignThemes.Wpf;

namespace Calculator1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int primeiro;
        int segundo;
        char op;


        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            tx_1.Text += button.Content.ToString();
            segundo = Int32.Parse(tx_1.Text);
            tx_2.Text = tx_1.Text;
            tx_3.Text = tx_2.Text;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            segundo = Int32.Parse(tx_1.Text);
            int resultado =0;

            if (op == '+')
            {
                resultado = primeiro + segundo;
                
            }
            if (op == '-')
            {
                resultado = primeiro - segundo;
                
            }
            if (op == '*')
            {
                resultado = primeiro * segundo;
                
            }
            if (op == '/')
            {
                resultado = primeiro / segundo;
                
            }
            if(tx_1.Text == "0")
            {
                tx_1.Text = "";
                tx_2.Text = tx_1.Text;
                tx_3.Text = tx_2.Text;
            }
            tx_1.Text = resultado.ToString();
            tx_2.Text = tx_1.Text;
            tx_3.Text = tx_2.Text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

           primeiro = Int32.Parse(tx_1.Text);
            op = '+';
            tx_1.Text = "";
            tx_2.Text = tx_1.Text;
            tx_3.Text = tx_2.Text;

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            primeiro = Int32.Parse(tx_1.Text);
            op = '-';
            tx_1.Text = "";
            tx_2.Text = tx_1.Text;
            tx_3.Text = tx_2.Text;



        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            primeiro = Int32.Parse(tx_1.Text);
            op = '*';
            tx_1.Text = "";
            tx_2.Text = tx_1.Text;
            tx_3.Text = tx_2.Text;


        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            primeiro = Int32.Parse(tx_1.Text);
            op = '/';
            tx_1.Text = "";
            tx_2.Text = tx_1.Text;
            tx_3.Text = tx_2.Text;


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (tx_1.Text.Length != 0)
            {
                tx_1.Text = tx_1.Text.Remove(tx_1.Text.Length - 1);
                //tx_2.Text = tx_2.Text.Remove(tx_2.Text.Length - 1);
                tx_2.Text = tx_1.Text;
                tx_3.Text = tx_2.Text;
            }


        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (tx_1.Text.Contains(",") == false)
            {
                tx_1.Text += ",";
            }
              
            tx_1.Text = tx_2.Text;
            tx_3.Text = tx_2.Text;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
