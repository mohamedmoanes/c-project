namespace bf
{
    partial class Form2
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
            this.filename = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.name_in = new System.Windows.Forms.TextBox();
            this.name_out = new System.Windows.Forms.TextBox();
            this.num_in = new System.Windows.Forms.TextBox();
            this.num_out = new System.Windows.Forms.TextBox();
            this.age_in = new System.Windows.Forms.TextBox();
            this.age_out = new System.Windows.Forms.TextBox();
            this.gender_in = new System.Windows.Forms.TextBox();
            this.gender_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rec_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(248, 36);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(54, 13);
            this.filename.TabIndex = 0;
            this.filename.Text = "File Name";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(347, 33);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 1;
            // 
            // name_in
            // 
            this.name_in.Location = new System.Drawing.Point(117, 125);
            this.name_in.MaxLength = 15;
            this.name_in.Name = "name_in";
            this.name_in.Size = new System.Drawing.Size(185, 20);
            this.name_in.TabIndex = 6;
            // 
            // name_out
            // 
            this.name_out.Location = new System.Drawing.Point(434, 122);
            this.name_out.Name = "name_out";
            this.name_out.Size = new System.Drawing.Size(188, 20);
            this.name_out.TabIndex = 7;
            // 
            // num_in
            // 
            this.num_in.Location = new System.Drawing.Point(117, 174);
            this.num_in.MaxLength = 11;
            this.num_in.Name = "num_in";
            this.num_in.Size = new System.Drawing.Size(100, 20);
            this.num_in.TabIndex = 10;
            // 
            // num_out
            // 
            this.num_out.Location = new System.Drawing.Point(434, 174);
            this.num_out.Name = "num_out";
            this.num_out.Size = new System.Drawing.Size(100, 20);
            this.num_out.TabIndex = 11;
            // 
            // age_in
            // 
            this.age_in.Location = new System.Drawing.Point(117, 221);
            this.age_in.MaxLength = 2;
            this.age_in.Name = "age_in";
            this.age_in.Size = new System.Drawing.Size(100, 20);
            this.age_in.TabIndex = 12;
            // 
            // age_out
            // 
            this.age_out.Location = new System.Drawing.Point(434, 221);
            this.age_out.Name = "age_out";
            this.age_out.Size = new System.Drawing.Size(100, 20);
            this.age_out.TabIndex = 13;
            // 
            // gender_in
            // 
            this.gender_in.Location = new System.Drawing.Point(117, 265);
            this.gender_in.MaxLength = 6;
            this.gender_in.Name = "gender_in";
            this.gender_in.Size = new System.Drawing.Size(100, 20);
            this.gender_in.TabIndex = 14;
            // 
            // gender_out
            // 
            this.gender_out.Location = new System.Drawing.Point(434, 265);
            this.gender_out.Name = "gender_out";
            this.gender_out.Size = new System.Drawing.Size(100, 20);
            this.gender_out.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gender";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(288, 338);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 21;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(117, 338);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 22;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rec_no
            // 
            this.rec_no.AutoSize = true;
            this.rec_no.Location = new System.Drawing.Point(520, 308);
            this.rec_no.Name = "rec_no";
            this.rec_no.Size = new System.Drawing.Size(0, 13);
            this.rec_no.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 395);
            this.Controls.Add(this.rec_no);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gender_out);
            this.Controls.Add(this.gender_in);
            this.Controls.Add(this.age_out);
            this.Controls.Add(this.age_in);
            this.Controls.Add(this.num_out);
            this.Controls.Add(this.num_in);
            this.Controls.Add(this.name_out);
            this.Controls.Add(this.name_in);
            this.Controls.Add(this.input);
            this.Controls.Add(this.filename);
            this.Name = "Form2";
            this.Text = "insert";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.TextBox name_out;
        private System.Windows.Forms.TextBox num_in;
        private System.Windows.Forms.TextBox num_out;
        private System.Windows.Forms.TextBox age_in;
        private System.Windows.Forms.TextBox age_out;
        private System.Windows.Forms.TextBox gender_in;
        private System.Windows.Forms.TextBox gender_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label rec_no;
    }
}