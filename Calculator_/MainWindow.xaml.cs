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

namespace Calculator_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //strListの長さの上限を6としたい
        int num = 0;
        decimal num1 = 0;
        decimal num2 = 0;
        List<string> strList = new List<string>();
        string str = "";
        string ope = "";
        public MainWindow()
        {
            InitializeComponent();
            view.Text = num.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            num = 1;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            num = 2;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            num = 3;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            num = 4;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            num = 5;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            num = 6;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            num = 7;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            num = 8;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            num = 9;
            strList.Add(num.ToString());
            str = string.Join("", strList);
            view.Text = str;
            
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            num = 0;
            strList.Add(num.ToString());
            if (strList[0] == "0")
            {
                strList.Clear();
                view.Text = "0";
            }
            else
            {
                str = string.Join("", strList);
                view.Text = str;
            }
            
        }

        private void Button_Click_clear(object sender, RoutedEventArgs e)
        {
            strList.Clear();
            str = 0.ToString();
            view.Text = str;
            ope = "";
            IsOperate(ope);
            equal.IsEnabled = true;
            dot.IsEnabled = true;

        }

        private void Button_Click_equal(object sender, RoutedEventArgs e)
        {
            if (str != "")
            {
                num2 = Convert.ToDecimal(str);
            }
            Caluculator cal = new Caluculator(num1,num2);
            switch (ope)
            {
                case "add":
                    str = cal.Add();
                    view.Text = str;
                    break;
                case "sub":
                    str = cal.Sub();
                    view.Text = str;
                    break;
                case "mul":
                    str = cal.Mul();
                    view.Text = str;
                    break;
                case "div":
                    str = cal.Div();
                    view.Text = str;
                    if(str == "NaN")
                    {
                        num1 = 0;
                        num2 = 0;
                        str = 0.ToString();
                    }
                    break;
                default:
                    num1 = Convert.ToDecimal(str);
                    view.Text = str;
                    break;
            }
            strList.Clear();
            str = "";
            equal.IsEnabled = false;

        }

        private void Button_Click_dot(object sender, RoutedEventArgs e)
        {
            if (num == 0)
            {
                strList.Add("0".ToString());
            }
            
            strList.Add(".");
            if(strList[0] == ".")
            {
                strList.Clear();
                strList.Add("0");
                strList.Add(".");
            }
            str = string.Join("", strList);
            view.Text = str;
            dot.IsEnabled = false;
        }

        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            if(str != "")
            {
                num1 = Convert.ToDecimal(str);
            }
            ope = "add";
            IsOperate(ope);
            strList.Clear();
            str = "";
            dot.IsEnabled = true;
        }

        private void Button_Click_sub(object sender, RoutedEventArgs e)
        {
            if (str != "")
            {
                num1 = Convert.ToDecimal(str);
            }
            ope = "sub";
            IsOperate(ope);
            strList.Clear();
            str = "";
            dot.IsEnabled = true;
        }

        private void Button_Click_mul(object sender, RoutedEventArgs e)
        {
            if (str != "")
            {
                num1 = Convert.ToDecimal(str);
            }
            ope = "mul";
            IsOperate(ope);
            strList.Clear();
            str = "";
            dot.IsEnabled = true;
        }

        private void Button_Click_div(object sender, RoutedEventArgs e)
        {
            if (str != "")
            {
                num1 = Convert.ToDecimal(str);
            }
            ope = "div";
            IsOperate(ope);
            strList.Clear();
            str = "";
            dot.IsEnabled = true;
        }

        private void IsOperate(string ope)
        {
            if(ope != "")
            {
                add.IsEnabled = false;
                subtraction.IsEnabled = false;
                multiplication.IsEnabled = false;
                division.IsEnabled = false;
            }
            else
            {
                add.IsEnabled = true;
                subtraction.IsEnabled = true;
                multiplication.IsEnabled = true;
                division.IsEnabled = true;
            }

        }
    }

    class Caluculator
    {
        private decimal num1;
        private decimal num2;

        //Constractor:
        public Caluculator(decimal num1, decimal num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public string Add()
        {
            return (num1 + num2).ToString();
        }

        public string Sub()
        {
            return (num1 - num2).ToString();
        }

        public string Mul()
        {
            return (num1 * num2).ToString();
        }

        public string Div()
        {
            if(num2 == 0)
            {
                return "NaN";
            }
            else
            {
                return (num1 / num2).ToString();
            }
        }
    }

}
