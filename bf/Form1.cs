using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bf
{
    
    public partial class Form1 : Form
    {
        data data1 = new data();
        public Form1()
        {
         
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!data1.exists(input.Text))
            {
                data1.create(input.Text);
            }
            else
            {
                MessageBox.Show("Error the file exist's");
            }

            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(data1,this);
            f2.Show();
            this.Hide();
        }

        private void list_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(data1,this);
            f3.Show();
            this.Hide();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(data1,this);
            f4.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
