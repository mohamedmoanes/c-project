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
    public partial class Form2 : Form
    {
        Form1 f1ref;
        data dref;
        List<string> record_field=new List<string>();
        int record_index = 0;
        public Form2(data d,Form1 f)
        {
            f1ref = f;
            dref = d;
            InitializeComponent();
            
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            f1ref.Show();
            this.Close();
        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            record_field.Add(name_in.Text.PadRight(15));
            record_field.Add(num_in.Text.PadRight(11));
            record_field.Add(age_in.Text.PadRight(2));
            record_field.Add(gender_in.Text.PadRight(6));
            dref.write_record(input.Text,record_field);
           
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            long x= dref.numofrecords(input.Text);
            if ((long)record_index <x-1)
            record_index++;
            fill_read_fields();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
              
        }
        void fill_read_fields()
        {
            dref.read(input.Text, record_field, record_index);
            name_out.Text = record_field[0];
            num_out.Text = record_field[1];
            age_out.Text = record_field[2];
            gender_out.Text = record_field[3];
            rec_no.Text = (dref.numofrecords(input.Text)+" | " +(record_index + 1)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(record_index>0)
            record_index--;
            fill_read_fields();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fill_read_fields();
        }

        

        
    }

}
