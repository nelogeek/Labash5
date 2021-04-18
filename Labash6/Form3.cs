using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labash6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Height = 469;
            this.Width = 774;
            this.Text = "Дочерняя форма";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = "400";//подсказка
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "400";//подсказка
            textBox2.ForeColor = Color.Gray;
        }
        private void textBox1_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }
        private void textBox2_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = Convert.ToInt32(textBox1.Text);
            this.Height = Convert.ToInt32(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Width = Convert.ToInt32(textBox1.Text);
            Owner.Height = Convert.ToInt32(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
