namespace SqlConTest
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxName = new System.Windows.Forms.TextBox();
            this.TxCoverColor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlShamsDataSet = new SqlConTest.SqlShamsDataSet();
            this.sqlShamsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardTableAdapter = new SqlConTest.SqlShamsDataSetTableAdapters.cardTableAdapter();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new SqlConTest.SqlShamsDataSetTableAdapters.teamTableAdapter();
            this.sqlShamsDataSet1 = new SqlConTest.SqlShamsDataSet1();
            this.teamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter1 = new SqlConTest.SqlShamsDataSet1TableAdapters.teamTableAdapter();
            this.sqlShamsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.covercolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxName
            // 
            this.TxName.Location = new System.Drawing.Point(68, 27);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(100, 22);
            this.TxName.TabIndex = 2;
            // 
            // TxCoverColor
            // 
            this.TxCoverColor.Location = new System.Drawing.Point(68, 76);
            this.TxCoverColor.Name = "TxCoverColor";
            this.TxCoverColor.Size = new System.Drawing.Size(100, 22);
            this.TxCoverColor.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.covercolorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // sqlShamsDataSet
            // 
            this.sqlShamsDataSet.DataSetName = "SqlShamsDataSet";
            this.sqlShamsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlShamsDataSetBindingSource
            // 
            this.sqlShamsDataSetBindingSource.DataSource = this.sqlShamsDataSet;
            this.sqlShamsDataSetBindingSource.Position = 0;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "card";
            this.cardBindingSource.DataSource = this.sqlShamsDataSetBindingSource;
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "team";
            this.teamBindingSource.DataSource = this.sqlShamsDataSetBindingSource;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // sqlShamsDataSet1
            // 
            this.sqlShamsDataSet1.DataSetName = "SqlShamsDataSet1";
            this.sqlShamsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamBindingSource1
            // 
            this.teamBindingSource1.DataMember = "team";
            this.teamBindingSource1.DataSource = this.sqlShamsDataSet1;
            // 
            // teamTableAdapter1
            // 
            this.teamTableAdapter1.ClearBeforeFill = true;
            // 
            // sqlShamsDataSet1BindingSource
            // 
            this.sqlShamsDataSet1BindingSource.DataSource = this.sqlShamsDataSet1;
            this.sqlShamsDataSet1BindingSource.Position = 0;
            // 
            // teamBindingSource2
            // 
            this.teamBindingSource2.DataMember = "team";
            this.teamBindingSource2.DataSource = this.sqlShamsDataSet1BindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // covercolorDataGridViewTextBoxColumn
            // 
            this.covercolorDataGridViewTextBoxColumn.DataPropertyName = "cover_color";
            this.covercolorDataGridViewTextBoxColumn.HeaderText = "cover_color";
            this.covercolorDataGridViewTextBoxColumn.Name = "covercolorDataGridViewTextBoxColumn";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 396);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxCoverColor);
            this.Controls.Add(this.TxName);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlShamsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxName;
        private System.Windows.Forms.TextBox TxCoverColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sqlShamsDataSetBindingSource;
        private SqlShamsDataSet sqlShamsDataSet;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private SqlShamsDataSetTableAdapters.cardTableAdapter cardTableAdapter;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private SqlShamsDataSetTableAdapters.teamTableAdapter teamTableAdapter;
        private SqlShamsDataSet1 sqlShamsDataSet1;
        private System.Windows.Forms.BindingSource teamBindingSource1;
        private SqlShamsDataSet1TableAdapters.teamTableAdapter teamTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn covercolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teamBindingSource2;
        private System.Windows.Forms.BindingSource sqlShamsDataSet1BindingSource;
    }
}