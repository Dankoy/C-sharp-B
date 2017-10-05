namespace Task5_ADO_NEW
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
            this.mydbDataSet1 = new Task5_ADO_NEW.MydbDataSet1();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new Task5_ADO_NEW.MydbDataSet1TableAdapters.Table_1TableAdapter();
            this.f1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f1DataGridViewTextBoxColumn,
            this.f2DataGridViewTextBoxColumn,
            this.f3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // mydbDataSet1
            // 
            this.mydbDataSet1.DataSetName = "MydbDataSet1";
            this.mydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.mydbDataSet1;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // f1DataGridViewTextBoxColumn
            // 
            this.f1DataGridViewTextBoxColumn.DataPropertyName = "f1";
            this.f1DataGridViewTextBoxColumn.HeaderText = "Field f1";
            this.f1DataGridViewTextBoxColumn.Name = "f1DataGridViewTextBoxColumn";
            this.f1DataGridViewTextBoxColumn.ToolTipText = "The help 1";
            // 
            // f2DataGridViewTextBoxColumn
            // 
            this.f2DataGridViewTextBoxColumn.DataPropertyName = "f2";
            this.f2DataGridViewTextBoxColumn.HeaderText = "Field f2";
            this.f2DataGridViewTextBoxColumn.Name = "f2DataGridViewTextBoxColumn";
            this.f2DataGridViewTextBoxColumn.ToolTipText = "The help 2";
            // 
            // f3DataGridViewTextBoxColumn
            // 
            this.f3DataGridViewTextBoxColumn.DataPropertyName = "f3";
            this.f3DataGridViewTextBoxColumn.HeaderText = "Firld f3";
            this.f3DataGridViewTextBoxColumn.Name = "f3DataGridViewTextBoxColumn";
            this.f3DataGridViewTextBoxColumn.ToolTipText = "The help 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 424);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MydbDataSet1 mydbDataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private MydbDataSet1TableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f3DataGridViewTextBoxColumn;
    }
}

