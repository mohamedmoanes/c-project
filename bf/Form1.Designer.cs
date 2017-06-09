namespace bf
{
    partial class Form1
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
            this.stat = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Location = new System.Drawing.Point(331, 60);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(0, 13);
            this.stat.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(170, 38);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(155, 20);
            this.input.TabIndex = 2;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(12, 12);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 3;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(12, 57);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 4;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(12, 100);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(75, 23);
            this.list.TabIndex = 5;
            this.list.Text = "list";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(12, 140);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 6;
            this.modify.Text = "modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(375, 140);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.list);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.create);
            this.Controls.Add(this.input);
            this.Controls.Add(this.stat);
            this.Name = "Form1";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}

