namespace SalesTracking
{
    partial class ApplyCreditForm
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
            this.amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.thanks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount $";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(117, 138);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice";
            // 
            // invoice
            // 
            this.invoice.Location = new System.Drawing.Point(117, 49);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(100, 20);
            this.invoice.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(92, 183);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Apply Credit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // thanks
            // 
            this.thanks.AutoSize = true;
            this.thanks.Location = new System.Drawing.Point(92, 236);
            this.thanks.Name = "thanks";
            this.thanks.Size = new System.Drawing.Size(61, 13);
            this.thanks.TabIndex = 5;
            this.thanks.Text = "Thank you!";
            // 
            // ApplyCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.thanks);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Name = "ApplyCreditForm";
            this.Text = "ApplyCreditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoice;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label thanks;
    }
}