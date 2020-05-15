using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task9.Forms;

namespace Task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int from_data;
        public int to_data;
        public int intervals;
        bool flag;

        private void button_search_Click(object sender, EventArgs e)
        {
            Data_oper();
            if (!flag)
            {
                MessageBox.Show("Incorrect data");
            }
            else
            {
                var form2 = new Forms.Form2(this);
                form2.Show();
                textBox_from.Clear();
                textBox_to.Clear();
                textBox_intervals.Clear();
            }
        }

        private void Data_oper()
        {
            flag = true;
            try
            {
                from_data = Convert.ToInt32(textBox_from.Text);
                to_data = Convert.ToInt32(textBox_to.Text);
                intervals = Convert.ToInt32(textBox_intervals.Text);
            }
            catch (Exception exp)
            {
                flag = false;
            }
            if (flag)
            {
                if ((from_data <= to_data) & (intervals > 0) & (intervals <= to_data - from_data + 1))
                {

                }
                else
                {
                    flag = false;
                }
            }
        }
    }
}
