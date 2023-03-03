namespace PizzaHut
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
            this.label1 = new System.Windows.Forms.Label();
            this.Slice = new System.Windows.Forms.Label();
            this.AfterTax = new System.Windows.Forms.Label();
            this.IMPUT = new System.Windows.Forms.TextBox();
            this.Sald = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cookie = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pretax = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.receiptBox = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-88, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1002, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "                               THE PIZZA PLACE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Slice
            // 
            this.Slice.AutoSize = true;
            this.Slice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slice.Location = new System.Drawing.Point(21, 52);
            this.Slice.Name = "Slice";
            this.Slice.Size = new System.Drawing.Size(169, 29);
            this.Slice.TabIndex = 1;
            this.Slice.Text = "Slices $9.00 :";
            // 
            // AfterTax
            // 
            this.AfterTax.AutoSize = true;
            this.AfterTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterTax.Location = new System.Drawing.Point(22, 267);
            this.AfterTax.Name = "AfterTax";
            this.AfterTax.Size = new System.Drawing.Size(152, 29);
            this.AfterTax.TabIndex = 2;
            this.AfterTax.Text = "After Tax : $";
            // 
            // IMPUT
            // 
            this.IMPUT.Location = new System.Drawing.Point(201, 61);
            this.IMPUT.Name = "IMPUT";
            this.IMPUT.Size = new System.Drawing.Size(319, 20);
            this.IMPUT.TabIndex = 3;
            // 
            // Sald
            // 
            this.Sald.AutoSize = true;
            this.Sald.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sald.Location = new System.Drawing.Point(21, 96);
            this.Sald.Name = "Sald";
            this.Sald.Size = new System.Drawing.Size(164, 29);
            this.Sald.TabIndex = 6;
            this.Sald.Text = "Salad $6.00 :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Cookie
            // 
            this.Cookie.AutoSize = true;
            this.Cookie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cookie.Location = new System.Drawing.Point(21, 136);
            this.Cookie.Name = "Cookie";
            this.Cookie.Size = new System.Drawing.Size(180, 29);
            this.Cookie.TabIndex = 8;
            this.Cookie.Text = "Cookie $3.00 :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pretax
            // 
            this.pretax.AutoSize = true;
            this.pretax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretax.Location = new System.Drawing.Point(22, 224);
            this.pretax.Name = "pretax";
            this.pretax.Size = new System.Drawing.Size(161, 29);
            this.pretax.TabIndex = 10;
            this.pretax.Text = "Sub Total : $";
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(235, 181);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(204, 29);
            this.Calculate.TabIndex = 13;
            this.Calculate.Text = "calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // receiptBox
            // 
            this.receiptBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptBox.Location = new System.Drawing.Point(536, 145);
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.Size = new System.Drawing.Size(313, 430);
            this.receiptBox.TabIndex = 14;
            this.receiptBox.Text = "Awaiting order";
            this.receiptBox.Click += new System.EventHandler(this.receiptBox_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(551, 593);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(287, 23);
            this.PrintButton.TabIndex = 15;
            this.PrintButton.Text = "Print Receipt ";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 710);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.receiptBox);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.pretax);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Cookie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sald);
            this.Controls.Add(this.IMPUT);
            this.Controls.Add(this.AfterTax);
            this.Controls.Add(this.Slice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Place!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Slice;
        private System.Windows.Forms.Label AfterTax;
        private System.Windows.Forms.TextBox IMPUT;
        private System.Windows.Forms.Label Sald;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Cookie;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label pretax;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label receiptBox;
        private System.Windows.Forms.Button PrintButton;
    }
}

