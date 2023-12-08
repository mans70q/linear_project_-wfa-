namespace linear_project_win
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
            this.matrix = new System.Windows.Forms.RichTextBox();
            this.m_num_m = new System.Windows.Forms.Button();
            this.m_num_p = new System.Windows.Forms.Button();
            this.n_num_m = new System.Windows.Forms.Button();
            this.n_num_p = new System.Windows.Forms.Button();
            this.m_num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.n_num = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.steps = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.matrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrix.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrix.Location = new System.Drawing.Point(234, 146);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(433, 190);
            this.matrix.TabIndex = 0;
            this.matrix.Text = "";
            // 
            // m_num_m
            // 
            this.m_num_m.Location = new System.Drawing.Point(139, 90);
            this.m_num_m.Name = "m_num_m";
            this.m_num_m.Size = new System.Drawing.Size(28, 23);
            this.m_num_m.TabIndex = 1;
            this.m_num_m.Text = "-";
            this.m_num_m.UseVisualStyleBackColor = true;
            this.m_num_m.Click += new System.EventHandler(this.m_num_m_Click);
            // 
            // m_num_p
            // 
            this.m_num_p.Location = new System.Drawing.Point(173, 90);
            this.m_num_p.Name = "m_num_p";
            this.m_num_p.Size = new System.Drawing.Size(25, 23);
            this.m_num_p.TabIndex = 2;
            this.m_num_p.Text = "+";
            this.m_num_p.UseVisualStyleBackColor = true;
            this.m_num_p.Click += new System.EventHandler(this.m_num_p_Click);
            // 
            // n_num_m
            // 
            this.n_num_m.Location = new System.Drawing.Point(394, 90);
            this.n_num_m.Name = "n_num_m";
            this.n_num_m.Size = new System.Drawing.Size(28, 23);
            this.n_num_m.TabIndex = 3;
            this.n_num_m.Text = "-";
            this.n_num_m.UseVisualStyleBackColor = true;
            this.n_num_m.Click += new System.EventHandler(this.n_num_m_Click);
            // 
            // n_num_p
            // 
            this.n_num_p.Location = new System.Drawing.Point(428, 90);
            this.n_num_p.Name = "n_num_p";
            this.n_num_p.Size = new System.Drawing.Size(25, 23);
            this.n_num_p.TabIndex = 4;
            this.n_num_p.Text = "++";
            this.n_num_p.UseVisualStyleBackColor = true;
            this.n_num_p.Click += new System.EventHandler(this.n_num_p_Click);
            // 
            // m_num
            // 
            this.m_num.AutoSize = true;
            this.m_num.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_num.Location = new System.Drawing.Point(158, 65);
            this.m_num.MaximumSize = new System.Drawing.Size(50, 50);
            this.m_num.Name = "m_num";
            this.m_num.Size = new System.Drawing.Size(23, 24);
            this.m_num.TabIndex = 5;
            this.m_num.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "n";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(687, 67);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(27, 28);
            this.lbl_size.TabIndex = 9;
            this.lbl_size.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(720, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "m";
            // 
            // n_num
            // 
            this.n_num.AutoSize = true;
            this.n_num.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_num.Location = new System.Drawing.Point(412, 65);
            this.n_num.Name = "n_num";
            this.n_num.Size = new System.Drawing.Size(23, 24);
            this.n_num.TabIndex = 7;
            this.n_num.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(673, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 50);
            this.button6.TabIndex = 17;
            this.button6.Text = "submit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter The Elements Sequentially ⬇";
            // 
            // steps
            // 
            this.steps.BackColor = System.Drawing.Color.White;
            this.steps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.steps.Location = new System.Drawing.Point(31, 146);
            this.steps.Name = "steps";
            this.steps.ReadOnly = true;
            this.steps.Size = new System.Drawing.Size(186, 381);
            this.steps.TabIndex = 19;
            this.steps.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 539);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.n_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_num);
            this.Controls.Add(this.n_num_p);
            this.Controls.Add(this.n_num_m);
            this.Controls.Add(this.m_num_p);
            this.Controls.Add(this.m_num_m);
            this.Controls.Add(this.matrix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox matrix;
        public System.Windows.Forms.Button m_num_m;
        public System.Windows.Forms.Button m_num_p;
        public System.Windows.Forms.Button n_num_m;
        public System.Windows.Forms.Button n_num_p;
        public System.Windows.Forms.Label m_num;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_size;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label n_num;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox steps;
    }
}

