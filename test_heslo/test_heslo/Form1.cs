using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_heslo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int n = Int32.Parse(textBox1.Text);
                if (n > 35) { MessageBox.Show("Zadal jsi vysoký počet znaků!", "Error textboxu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    return;
                   
                }
                char[] pole = new char[n];
                for (int i = 0; i < n; i++)
                {
                    pole[i] = (char)rnd.Next(33, 126);
                    label2.Text = new String(pole);
                }
                listBox1.Items.Add(new String(pole));
            } 
            catch
            {
                textBox1.Text = "";
                MessageBox.Show("Zadal jsi špatnou hodnotu, zkus to znova :)", "Error textboxu", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }
    }
}
