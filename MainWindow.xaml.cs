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

namespace Calculator_01
{
    ///
    /// 
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        string formula_01 = ""; //左辺
        string formula_02 = ""; //右辺
        float result = 0.0f;  //解

        public enum Type_Calculate
        {
            None, 
            Addition, 
            Subtraction, 
            Multiplication, 
            Division
        }
        public Type_Calculate CurrentCalculate = Type_Calculate.None;

        public enum Type_Status
        {
            None,
            Calculating,
            Solved
        }
        public Type_Status Current_Status = Type_Status.None;

        void Reset()
        {
            formula_01 = "";
            formula_02 = "";
            result = 0.0f;

            Display_Left.Text = "";
            Display_Right.Text = "";
            SubDisplay_01.Text = "";
        }

        void Error(string About_Error)
        {
            if(About_Error == "")
            {
                About_Error = "Error";
            }
            
            MessageBox.Show("Error",About_Error);
        }
        void Calculate()
        {
            switch(CurrentCalculate)
            {
                case Type_Calculate.None:
                    Error("Selected_None");
                    break;

                case Type_Calculate.Addition:
                    if(Current_Status == Type_Status.None | Current_Status == Type_Status.Calculating)
                    {
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_02 = Display_Right.Text;
                                result = float.Parse(formula_01) + float.Parse(formula_02);
                                formula_01 = result.ToString();
                                formula_02 = "";
                                Display_Left.Text = result.ToString();
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "＋";
                            }
                            else
                            {
                                SubDisplay_01.Text = "＋";
                            }

                        }
                        else
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_01 = Display_Right.Text;
                                Display_Right.Text = "";
                                Display_Left.Text = formula_01;
                                SubDisplay_01.Text = "＋";
                            }
                            else
                            {

                            }

                        }
                    }
                    else
                    {
                        SubDisplay_01.Text = "";
                        formula_01 = Display_Right.Text;
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                Display_Left.Text = Display_Right.Text;
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "＋";

                            }
                            else
                            {
                                SubDisplay_01.Text = "＋";
                            }

                        }
                    }

                    
                    break;

                case Type_Calculate.Subtraction:
                    if (Current_Status == Type_Status.None | Current_Status == Type_Status.Calculating)
                    {
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_02 = Display_Right.Text;
                                result = float.Parse(formula_01) - float.Parse(formula_02);
                                formula_01 = result.ToString();
                                formula_02 = "";
                                Display_Left.Text = result.ToString();
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "－";
                            }
                            else
                            {
                                SubDisplay_01.Text = "－";
                            }

                        }
                        else
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_01 = Display_Right.Text;
                                Display_Right.Text = "";
                                Display_Left.Text = formula_01;
                                SubDisplay_01.Text = "－";
                            }
                            else
                            {

                            }

                        }
                    }
                    else
                    {
                        SubDisplay_01.Text = "";
                        formula_01 = Display_Right.Text;
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                Display_Left.Text = Display_Right.Text;
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "－";

                                
                            }
                            else
                            {
                                SubDisplay_01.Text = "－";
                            }

                        }
                    }
                    break;

                case Type_Calculate.Multiplication:
                    if (Current_Status == Type_Status.None | Current_Status == Type_Status.Calculating)
                    {
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_02 = Display_Right.Text;
                                result = float.Parse(formula_01) * float.Parse(formula_02);
                                formula_01 = result.ToString();
                                formula_02 = "";
                                Display_Left.Text = result.ToString();
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "×";
                            }
                            else
                            {
                                SubDisplay_01.Text = "×";
                            }

                        }
                        else
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_01 = Display_Right.Text;
                                Display_Right.Text = "";
                                Display_Left.Text = formula_01;
                                SubDisplay_01.Text = "×";
                            }
                            else
                            {

                            }

                        }
                    }
                    else
                    {
                        SubDisplay_01.Text = "";
                        formula_01 = Display_Right.Text;
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                Display_Left.Text = Display_Right.Text;
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "×";

                            }
                            else
                            {
                                SubDisplay_01.Text = "×";
                            }

                        }
                    }
                    break;

                case Type_Calculate.Division:
                    if (Current_Status == Type_Status.None | Current_Status == Type_Status.Calculating)
                    {
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_02 = Display_Right.Text;
                                result = float.Parse(formula_01) / float.Parse(formula_02);
                                formula_01 = result.ToString();
                                formula_02 = "";
                                Display_Left.Text = result.ToString();
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "÷";
                            }
                            else
                            {
                                SubDisplay_01.Text = "÷";
                            }

                        }
                        else
                        {
                            if (Display_Right.Text != "")
                            {
                                formula_01 = Display_Right.Text;
                                Display_Right.Text = "";
                                Display_Left.Text = formula_01;
                                SubDisplay_01.Text = "÷";
                            }
                            else
                            {

                            }

                        }
                    }
                    else
                    {
                        SubDisplay_01.Text = "";
                        formula_01 = Display_Right.Text;
                        if (formula_01 != "")
                        {
                            if (Display_Right.Text != "")
                            {
                                Display_Left.Text = Display_Right.Text;
                                Display_Right.Text = "";
                                SubDisplay_01.Text = "÷";

                            }
                            else
                            {
                                SubDisplay_01.Text = "÷";
                            }

                        }
                    }
                    break;

                default:
                    Error("Not Selected");
                    break;




            }
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button clicked_button = (Button)sender;
            Display_Right.Text = Display_Right.Text + clicked_button.Content;
        }

        private void Addition(object sender, RoutedEventArgs e)
        {
            CurrentCalculate = Type_Calculate.Addition;
            Calculate();
            Current_Status = Type_Status.Calculating;

        }

        private void Subtraction(object sender, RoutedEventArgs e)
        {
            CurrentCalculate = Type_Calculate.Subtraction;
            Calculate();
            Current_Status = Type_Status.Calculating;
        }

        private void Multiplication(object sender, RoutedEventArgs e)
        {
            CurrentCalculate = Type_Calculate.Multiplication;
            Calculate();
            Current_Status = Type_Status.Calculating;
        }

        private void Division(object sender, RoutedEventArgs e)
        {
            CurrentCalculate = Type_Calculate.Division;
            Calculate();
            Current_Status = Type_Status.Calculating;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Reset();
            Current_Status = Type_Status.None;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                Display_Right.Text = Display_Right.Text.Remove(Display_Right.Text.Length - 1, 1);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            
        }

        private void Equal(object sender, RoutedEventArgs e)
        {
            if(Display_Right.Text != "")
            {
                Calculate();
                formula_01 = "";
                formula_02 = "";
                Display_Right.Text = result.ToString();
                Display_Left.Text = "";
                SubDisplay_01.Text = "＝";
                Current_Status = Type_Status.Solved;
            }
            else
            {
                if(Display_Left.Text != "")
                {
                    formula_01 = "";
                    formula_02 = "";
                    Display_Right.Text = result.ToString();
                    Display_Left.Text = "";
                    SubDisplay_01.Text = "＝";
                    Current_Status = Type_Status.Solved;
                }
                else
                {
                    Reset();
                    Current_Status = Type_Status.None;
                }
                
            }
        }
    }
}
