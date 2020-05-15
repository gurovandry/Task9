using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task9.Forms
{
    public partial class Form2 : Form
    {
        private Form1 MainForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            MainForm = form1;
            Values();
            Search();
            Print_Numbers();
        }
        int from_val;
        int to_val;
        int int_val;
        List<int>[] res;
        private void Values()
        {
            from_val = MainForm.from_data;
            to_val = MainForm.to_data;
            int_val = MainForm.intervals;
        }
        private void Search()
        {
            res = Tasks_Tools.Split_Find(from_val, to_val, int_val);
        }
        private void Print_Numbers()
        {
            int count_null = 0;
            foreach (var it in res)
            {
                if (it != null)
                {
                    foreach (int num in it)
                    {
                        listBox1.Items.Add(num);
                    }
                }
                if (it.Count() == 0)
                    count_null++;
            }
            if (count_null == res.Count())
                listBox1.Items.Add("Nun");

        }
    }
}
