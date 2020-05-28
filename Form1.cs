using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX
{
    public partial class Taxcalculator : Form
    {
        public Taxcalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(เดือน.Text);
            int a = int.Parse(บ60.Text);
            int a1 = int.Parse(บ61.Text);
            int b = int.Parse(คลอด.Text);
            int c = int.Parse(textBox7.Text);
            int t,sum,tax;
            t = x * 12;
            if (a>=1)
            {
                a = a * 30000;

            }
            else 
            {
                if (a1 == 1)
                {
                    a1 = 30000;

                }
                if(a1 > 1)
                {
                    a1=((a1 - 1) * 60000) + 30000;
                }
                else
                {
                    a1 = 0;
                }
            }
            if (บิดา.Checked || มารดา.Checked || บิดา2.Checked || มารดา2.Checked)
            {       
                sum = t - 30000 - 60000 - (a * 30000) - a1 - b - (c * 60000);
            }
            else if (มารดา.Checked && บิดา.Checked || บิดา2.Checked && มารดา2.Checked || บิดา.Checked && มารดา2.Checked || บิดา.Checked && บิดา2.Checked || มารดา.Checked && บิดา2.Checked || มารดา.Checked && มารดา2.Checked)
            {
                sum = t - 60000 - 60000 - (a * 30000) - a1 - b - (c * 60000);
            }
            else if (มารดา.Checked && บิดา.Checked && บิดา2.Checked || มารดา.Checked && บิดา.Checked && มารดา2.Checked || มารดา2.Checked && บิดา2.Checked && บิดา.Checked || มารดา2.Checked && บิดา2.Checked && มารดา.Checked || มารดา.Checked && มารดา2.Checked && บิดา.Checked)
            {
                sum = t - 60000 - 60000 - 30000 - (a * 30000) - a1 - b - (c * 60000);
            }
            else if(มารดา.Checked&&บิดา.Checked&&มารดา2.Checked&&บิดา2.Checked)
            {
                sum = t - 60000 - 60000 - 60000 - (a * 30000) - a1 - b - (c * 60000);
            }
            else
            {
                sum = t - 60000 - (a * 30000) - a1 - b - (c * 60000);
            }
            if (t > 150000 && t <= 300000)
            {
                tax = sum * 5 / 100;
                ปี.Text = t.ToString();
                if(tax>0) 
                {
                    ภาษี.Text = tax.ToString();
                }
                else
                {
                    tax = 0;
                    ภาษี.Text = tax.ToString();
                }
            }
            else if(t>300000&&t<=500000)
            {
                tax = sum * 10 / 100;
                ปี.Text = t.ToString();
                if (tax > 0)
                {
                    ภาษี.Text = tax.ToString();
                }
                else
                {
                    tax = 0;
                    ภาษี.Text = tax.ToString();
                }
            }
            else if (t > 500000 && t <= 750000)
            {
                tax = sum * 15 / 100;
                ปี.Text = t.ToString();
                if (tax > 0)
                {
                    ภาษี.Text = tax.ToString();
                }
                else
                {
                    tax = 0;
                    ภาษี.Text = tax.ToString();
                }
            }
            else if (t > 750000 && t <= 1000000)
            {
                tax = sum * 20 / 100;
                ปี.Text = t.ToString();
                if (tax > 0)
                {
                    ภาษี.Text = tax.ToString();
                }
                else
                {
                    tax = 0;
                    ภาษี.Text = tax.ToString();
                }
            }
            else if (t > 1000000 && t <= 2000000)
            {
                tax = sum * 25 / 100;
                ปี.Text = t.ToString();
                if (tax > 0)
                {
                    ภาษี.Text = tax.ToString();
                }
                else
                {
                    tax = 0;
                    ภาษี.Text = tax.ToString();
                }
            }
            else if (t > 2000000 && t <= 5000000)
            {
                tax = sum * 30 / 100;
                ปี.Text = t.ToString();
                if (tax > 0)
                {
                    ภาษี.Text = tax.ToString();
                }
                else
                {
                    tax = 0;
                    ภาษี.Text = tax.ToString();
                }
            }
            else if (t > 5000000 )
            {
                tax = sum * 35 / 100;
                ปี.Text = t.ToString();
                if (tax > 0)
                {
                    ภาษี.Text = tax.ToString();
                }
                else
                {
                    tax = 0;
                    ภาษี.Text = tax.ToString();
                }
            }
            else
            {
                tax = 0;
                ปี.Text = t.ToString();
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
         