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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Главная форма";
            this.Width = 500;
            this.Height = 440;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();
            temp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 temp = new Form3();
            temp.Show();
        }
        
    }
}
