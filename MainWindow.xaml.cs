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

namespace WPF_Rassokhin_PR4._1
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
        Random r;
        int x;
        private void Button_Click(object sender, EventArgs e)
        {
            r = new Random();
            x = r.Next(1, 100);
            TextBox3.Text = "Это число " + x;


        }
        int tic = 50;
        int count = 0;
        private void Button_Click_2(object sender, EventArgs e)
        {
            count++;
            int y = Convert.ToInt32(TextBox1.Text);
            if (y < x)
                TextBox3.Text = "Больше";
            else if (y > x)
                TextBox3.Text = "Меньше";
            else if (y == x)
            {
                TextBox3.Text = "Вы угадали!";
            }
        }

    }
}

    
        
    

