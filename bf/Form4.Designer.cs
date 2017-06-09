namespace bf
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_io = new System.Windows.Forms.TextBox();
            this.num_io = new System.Windows.Forms.TextBox();
            this.age_in = new System.Windows.Forms.TextBox();
            this.gender_io = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.get = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            // 
            // name_io
            // 
            this.name_io.Location = new System.Drawing.Point(97, 45);
            this.name_io.MaxLength = 15;
            this.name_io.Name = "name_io";
            this.name_io.Size = new System.Drawing.Size(100, 20);
            this.name_io.TabIndex = 9;
            // 
            // num_io
            // 
            this.num_io.Location = new System.Drawing.Point(97, 88);
            this.num_io.MaxLength = 11;
            this.num_io.Name = "num_io";
            this.num_io.Size = new System.Drawing.Size(101, 20);
            this.num_io.TabIndex = 10;
            // 
            // age_in
            // 
            this.age_in.Location = new System.Drawing.Point(95, 133);
            this.age_in.MaxLength = 2;
            this.age_in.Name = "age_in";
            this.age_in.Size = new System.Drawing.Size(102, 20);
            this.age_in.TabIndex = 12;
            // 
            // gender_io
            // 
            this.gender_io.Location = new System.Drawing.Point(97, 189);
            this.gender_io.MaxLength = 6;
            this.gender_io.Name = "gender_io";
            this.gender_io.Size = new System.Drawing.Size(104, 20);
            this.gender_io.TabIndex = 13;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(46, 265);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 14;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(241, 265);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(75, 23);
            this.get.TabIndex = 15;
            this.get.Text = "Get";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(432, 265);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 16;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(400, 45);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(107, 20);
            this.filename.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "file name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.save);
            this.Controls.Add(this.get);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gender_io);
            this.Controls.Add(this.age_in);
            this.Controls.Add(this.num_io);
            this.Controls.Add(this.name_io);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_io;
        private System.Windows.Forms.TextBox num_io;
        private System.Windows.Forms.TextBox age_in;
        private System.Windows.Forms.TextBox gender_io;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label label5;
    }
}