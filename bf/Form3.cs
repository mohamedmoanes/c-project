using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bf
{
    public partial class Form3 : Form
    {
        Form1 f1ref;
        data dref;
        int record_index = 0;
        List<string> record_field = new List<string>();
        public Form3(data d,Form1 f)
        {
            f1ref = f;
            dref = d;
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
          
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongTimeString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            f1ref.Show();
            this.Close();
        }
        void fill_read_fields()
        {
            dref.read(filename.Text, record_field, record_index);
            name.Text = record_field[0];
            phone.Text = record_field[1];
            age.Text = record_field[2];
            gender.Text = record_field[3];
            rec_num.Text = dref.numofrecords(filename.Text).ToString();
            rec_no.Text =  (record_index + 1).ToString();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (record_index > 0)
            record_index--;
            fill_read_fields();
        }

        private void next_Click(object sender, EventArgs e)
        {
            long x = dref.numofrecords(filename.Text);
            if ((long)record_index < x - 1)
            record_index++;
            fill_read_fields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill_read_fields();
            
        }
    }
}
