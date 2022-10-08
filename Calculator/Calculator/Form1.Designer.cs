namespace Calculator
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Rslt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(648, 212);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(195, 26);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "12";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(648, 267);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(195, 26);
            this.txt2.TabIndex = 1;
            // 
            // Rslt
            // 
            this.Rslt.Location = new System.Drawing.Point(648, 339);
            this.Rslt.Name = "Rslt";
            this.Rslt.Size = new System.Drawing.Size(195, 26);
            this.Rslt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "1st Value :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "2nd Value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer :";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(659, 300);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(39, 33);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.Location = new System.Drawing.Point(749, 300);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(39, 33);
            this.minus_btn.TabIndex = 7;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(704, 300);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(39, 33);
            this.btn_mul.TabIndex = 8;
            this.btn_mul.Text = "X";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rslt);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox Rslt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button button1;
    }
}

