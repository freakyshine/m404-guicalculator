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
namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //lokale Variablen
        private long displayValue = 0;
        private long result = 0;
        private char operation = '+';
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmd0_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10;
            SetDisplay();
        }
        private void cmd1_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 1;
            SetDisplay();
        }
        private void cmd2_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 2;
            SetDisplay();
        }
        private void cmd3_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 3;
            SetDisplay();
        }
        private void cmd4_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 4;
            SetDisplay();
        }
        private void cmd5_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 5;
            SetDisplay();
        }
        private void cmd6_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 6;
            SetDisplay();
        }
        private void cmd7_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 7;
            SetDisplay();
        }
        private void cmd8_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 8;
            SetDisplay();
        }
        private void cmd9_Click(object sender, RoutedEventArgs e)
        {
            displayValue = displayValue * 10 + 9;
            SetDisplay();
        }
        private void cmdClr_Click(object sender, RoutedEventArgs e)
        {
            displayValue = 0;
            SetDisplay();
        }
        private void cmdAdd_Click(object sender, RoutedEventArgs e)
        {
            result = displayValue;
            operation = '+';
            displayValue = 0;
            SetDisplay();
        }
        private void cmdSub_Click(object sender, RoutedEventArgs e)
        {
            result = displayValue;
            operation = '‐';
            displayValue = 0;
            SetDisplay();
        }
        private void cmdMul_Click(object sender, RoutedEventArgs e)
        {
            result = displayValue;
            operation = '*';
            displayValue = 0;
            SetDisplay();
        }
        private void cmdDiv_Click(object sender, RoutedEventArgs e)
        {
            result = displayValue;
            operation = '/';
            displayValue = 0;
            SetDisplay();
        }
        private void cmdRes_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case '+':
                    {
                        result += displayValue;
                        break;
                    }
                case '‐':
                    {
                        result -= displayValue;
                        break;
                    }
                case '*':
                    {
                        result *= displayValue;
                        break;
                    }
                case '/':
                    {
                        if (displayValue == 0)
                        {
                            MessageBox.Show("Achtung: Division duch 0 ist nicht erlaubt!");
                        }
                        else
                        {
                            result /= displayValue;
                        }
                        break;
                    }
            }
            displayValue = result;
            SetDisplay();
        }
        private void SetDisplay() {
            display.Text = displayValue.ToString();
    }
  }
}