using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimePicker
{
    public partial class Form1 : Form
    {
        DateTime fecha_actual = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            lbl1.Text = fecha_actual.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DateTime fecha_adicionada = DateTime.Now.AddDays(100);
            lbl2.Text = fecha_adicionada.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DateTime fecha_restada = DateTime.Now.AddDays(-150);
            lbl3.Text = fecha_restada.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl4.Text = fecha_actual.DayOfWeek.ToString();
            lbl5.Text = fecha_actual.Month.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb1.Text))
            {
                MessageBox.Show("sirve la validadad");
            }
            else
            {
                int a = Convert.ToInt32(txb1.Text);
                int m = Convert.ToInt32(txb2.Text);
                lbl6.Text = DateTime.DaysInMonth(a, m).ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string formato = "ddd dd MMMM , yyyy // H:mm:ss ";
            lbl7.Text = fecha_actual.ToString(formato);
        }
    }
}
