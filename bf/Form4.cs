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
    public partial class Form4 : Form
    {
        Form1 f1ref;
        data dref;
        int record_index;
        List<string> record_field = new List<string>();
        public Form4(data d,Form1 f)
        {
            f1ref = f;
            dref = d;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            f1ref.Show();
            this.Close();
        }

        private void get_Click(object sender, EventArgs e)
        {
            int return_value = dref.get(name_io.Text.PadRight(15), filename.Text, record_field);

            if (return_value != -1)
            {
                record_index = return_value;
                name_io.Text = record_field[0];
                num_io.Text = record_field[1];
                age_in.Text = record_field[2];
                gender_io.Text = record_field[3];
            } 
            else
                MessageBox.Show("file not found!!");
        }

        private void save_Click(object sender, EventArgs e)
        {
            record_field.Clear();
            record_field.Add(name_io.Text.PadRight(15));
            record_field.Add(num_io.Text.PadRight(11));
            record_field.Add(age_in.Text.PadRight(2));
            record_field.Add(gender_io.Text.PadRight(6));
            dref.modify(filename.Text, record_index, record_field);
        }
    }
}
