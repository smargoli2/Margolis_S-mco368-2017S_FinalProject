namespace SalesTracking
{
    partial class AccountForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.submitPayment = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Label();
            this.applyCredit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(30, 28);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(72, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Your Account";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(36, 77);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 2;
            this.address.Text = "Address";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(36, 122);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(46, 13);
            this.balance.TabIndex = 3;
            this.balance.Text = "Balance";
            // 
            // submitPayment
            // 
            this.submitPayment.AutoSize = true;
            this.submitPayment.Location = new System.Drawing.Point(187, 122);
            this.submitPayment.Name = "submitPayment";
            this.submitPayment.Size = new System.Drawing.Size(93, 23);
            this.submitPayment.TabIndex = 6;
            this.submitPayment.Text = "Make Payment";
            this.submitPayment.UseVisualStyleBackColor = true;
            this.submitPayment.Click += new System.EventHandler(this.submitPayment_Click);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(39, 170);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(34, 13);
            this.credit.TabIndex = 7;
            this.credit.Text = "Credit";
            // 
            // applyCredit
            // 
            this.applyCredit.AutoSize = true;
            this.applyCredit.Location = new System.Drawing.Point(170, 170);
            this.applyCredit.Name = "applyCredit";
            this.applyCredit.Size = new System.Drawing.Size(110, 23);
            this.applyCredit.TabIndex = 8;
            this.applyCredit.Text = "Apply Credit to a Bill";
            this.applyCredit.UseVisualStyleBackColor = true;
            this.applyCredit.Click += new System.EventHandler(this.applyCredit_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SalesTracking.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(302, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.applyCredit);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.submitPayment);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.address);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button submitPayment;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Button applyCredit;
        private System.Windows.Forms.Button button1;
    }
}