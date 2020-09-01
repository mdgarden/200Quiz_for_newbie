using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace A160_WPF_SimpleCalc
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool newButton;
        private double savedValue;
        private char myOperator;

        public MainWindow()
        {
            private void btn_Click(object sender, RoutedEventArgs e)
            {
                Button btn = sender as Button;
                string number = btn.Content.ToString();
                if (MaskedTextResultHint.Text == "0" || newButton == true)
                {
                    txtResult.Text = number;
                    newButton = false
                }
                else
                    txtResult.Text = txtResult.Text + number;
            }
            ///InitializeComponent();
        }
    }
}
