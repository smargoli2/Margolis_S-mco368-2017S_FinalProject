namespace SalesTracking
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            this.orderGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new SalesTracking.SalesDataSet();
            this.ordersTableAdapter = new SalesTracking.SalesDataSetTableAdapters.OrdersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lowdate = new System.Windows.Forms.TextBox();
            this.highdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lowprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.highprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filterByDate = new System.Windows.Forms.Button();
            this.FilterByPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView1
            // 
            this.orderGridView1.AllowUserToAddRows = false;
            this.orderGridView1.AutoGenerateColumns = false;
            this.orderGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.totalPaidDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.orderGridView1.DataSource = this.ordersBindingSource;
            this.orderGridView1.Location = new System.Drawing.Point(12, 132);
            this.orderGridView1.Name = "orderGridView1";
            this.orderGridView1.Size = new System.Drawing.Size(805, 150);
            this.orderGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // totalPaidDataGridViewTextBoxColumn
            // 
            this.totalPaidDataGridViewTextBoxColumn.DataPropertyName = "TotalPaid";
            this.totalPaidDataGridViewTextBoxColumn.HeaderText = "TotalPaid";
            this.totalPaidDataGridViewTextBoxColumn.Name = "totalPaidDataGridViewTextBoxColumn";
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "paid";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.salesDataSet;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "SalesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter by date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter by total";
            // 
            // lowdate
            // 
            this.lowdate.Location = new System.Drawing.Point(122, 40);
            this.lowdate.Name = "lowdate";
            this.lowdate.Size = new System.Drawing.Size(100, 20);
            this.lowdate.TabIndex = 4;
            // 
            // highdate
            // 
            this.highdate.Location = new System.Drawing.Point(250, 40);
            this.highdate.Name = "highdate";
            this.highdate.Size = new System.Drawing.Size(100, 20);
            this.highdate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "to";
            // 
            // lowprice
            // 
            this.lowprice.Location = new System.Drawing.Point(122, 83);
            this.lowprice.Name = "lowprice";
            this.lowprice.Size = new System.Drawing.Size(100, 20);
            this.lowprice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "to";
            // 
            // highprice
            // 
            this.highprice.Location = new System.Drawing.Point(252, 83);
            this.highprice.Name = "highprice";
            this.highprice.Size = new System.Drawing.Size(100, 20);
            this.highprice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "or";
            // 
            // filterByDate
            // 
            this.filterByDate.Location = new System.Drawing.Point(394, 38);
            this.filterByDate.Name = "filterByDate";
            this.filterByDate.Size = new System.Drawing.Size(75, 23);
            this.filterByDate.TabIndex = 11;
            this.filterByDate.Text = "Filter";
            this.filterByDate.UseVisualStyleBackColor = true;
            this.filterByDate.Click += new System.EventHandler(this.filterByDate_Click);
            // 
            // FilterByPrice
            // 
            this.FilterByPrice.Location = new System.Drawing.Point(394, 81);
            this.FilterByPrice.Name = "FilterByPrice";
            this.FilterByPrice.Size = new System.Drawing.Size(75, 23);
            this.FilterByPrice.TabIndex = 12;
            this.FilterByPrice.Text = "Filter";
            this.FilterByPrice.UseVisualStyleBackColor = true;
            this.FilterByPrice.Click += new System.EventHandler(this.FilterByPrice_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 432);
            this.Controls.Add(this.FilterByPrice);
            this.Controls.Add(this.filterByDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.highprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lowprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.highdate);
            this.Controls.Add(this.lowdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderGridView1);
            this.Name = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGridView1;
        private SalesDataSet salesDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SalesDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lowdate;
        private System.Windows.Forms.TextBox highdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lowprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox highprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filterByDate;
        private System.Windows.Forms.Button FilterByPrice;
    }
}