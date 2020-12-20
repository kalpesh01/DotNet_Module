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
using System.Windows.Shapes;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int t1=0, t2=0;
            try
            {
                t1 = Convert.ToInt32(txtNum1.Text);
                t2 = Convert.ToInt32(txtNum2.Text);
                t1 = t1 + t2;
                txtSum.Text = Convert.ToString(t1);
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int t1 = 0, t2 = 0;
            try
            {
                //t1 = Convert.ToInt32(txtNum1.Text);
                //t2 = Convert.ToInt32(txtNum2.Text);
                t1 = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
                txtSum.Text = Convert.ToString(t1);
            }catch(Exception ex)
            {
               
            }
        }

        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            // lblTemp.Content =txtNum1.Text.ToString();
          // lblTemp.Content=KeyInterop.VirtualKeyFromKey(e.Key).ToString();
          string str = KeyInterop.VirtualKeyFromKey(e.Key).ToString();
            int temp = Convert.ToInt32(str);
            if(temp>=48 && temp<=57)
            {
                
            }
            else
            {
                txtNum1.Text = "";
                MessageBox.Show("only numeric values allowed");
                txtNum1.Text = "";

            }
        }


    }
}
