using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (txtdot.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            textBox.Text = "";
            txtFunction.Text = "div";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (txtFunction.Text == "div")
            {
                if (txtdot.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txtValue.Text);
                    Decimal b = Convert.ToDecimal(textBox.Text);
                    textBox.Text = Convert.ToString(a / b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txtValue.Text);
                    Int16 b = Convert.ToInt16(textBox.Text);
                    textBox.Text = Convert.ToString(a / b);
                }
            }
            if (txtFunction.Text == "mul")
            {
                if (txtdot.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txtValue.Text);
                    Decimal b = Convert.ToDecimal(textBox.Text);
                    textBox.Text = Convert.ToString(a * b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txtValue.Text);
                    Int16 b = Convert.ToInt16(textBox.Text);
                    textBox.Text = Convert.ToString(a * b);
                }
            }
            if (txtFunction.Text == "sum")
            {
                if (txtdot.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txtValue.Text);
                    Decimal b = Convert.ToDecimal(textBox.Text);
                    textBox.Text = Convert.ToString(a + b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txtValue.Text);
                    Int16 b = Convert.ToInt16(textBox.Text);
                    textBox.Text = Convert.ToString(a + b);
                }
            }
            if (txtFunction.Text == "minus")
            {
                if (txtdot.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txtValue.Text);
                    Decimal b = Convert.ToDecimal(textBox.Text);
                    textBox.Text = Convert.ToString(a - b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txtValue.Text);
                    Int16 b = Convert.ToInt16(textBox.Text);
                    textBox.Text = Convert.ToString(a - b);
                }

            }
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (txtdot.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            textBox.Text = "";
            txtFunction.Text = "mul";
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            if (txtdot.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            textBox.Text = "";
            txtFunction.Text = "minus";
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            if (txtdot.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(textBox.Text);
                txtValue.Text = Convert.ToString(a);
            }
            textBox.Text = "+";
            txtFunction.Text = "sum";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ".";
            txtdot.Text = "dot";
        }
    }
}
