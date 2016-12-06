namespace _1_WindowsApplication
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.my_DBDataSet = new _1_WindowsApplication.My_DBDataSet();
            this.t3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t3TableAdapter = new _1_WindowsApplication.My_DBDataSetTableAdapters.t3TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.my_DBDataSet1 = new _1_WindowsApplication.My_DBDataSet1();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new _1_WindowsApplication.My_DBDataSet1TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // my_DBDataSet
            // 
            this.my_DBDataSet.DataSetName = "My_DBDataSet";
            this.my_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t3BindingSource
            // 
            this.t3BindingSource.DataMember = "t3";
            this.t3BindingSource.DataSource = this.my_DBDataSet;
            // 
            // t3TableAdapter
            // 
            this.t3TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // my_DBDataSet1
            // 
            this.my_DBDataSet1.DataSetName = "My_DBDataSet1";
            this.my_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.my_DBDataSet1;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 372);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private My_DBDataSet my_DBDataSet;
        private System.Windows.Forms.BindingSource t3BindingSource;
        private My_DBDataSetTableAdapters.t3TableAdapter t3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private My_DBDataSet1 my_DBDataSet1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private My_DBDataSet1TableAdapters.BookTableAdapter bookTableAdapter;
    }
}

