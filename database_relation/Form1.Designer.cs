namespace database_relation
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
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版商DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版商位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版者BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new database_relation.Database1DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.書號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.定價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書商編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版者書目BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.書名DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.來源DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.簡介DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書目內容簡介BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.出版者TableAdapter = new database_relation.Database1DataSetTableAdapters.出版者TableAdapter();
            this.書目TableAdapter = new database_relation.Database1DataSetTableAdapters.書目TableAdapter();
            this.內容簡介TableAdapter = new database_relation.Database1DataSetTableAdapters.內容簡介TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者書目BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書目內容簡介BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.出版商DataGridViewTextBoxColumn,
            this.出版商位置DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.出版者BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            // 
            // 出版商DataGridViewTextBoxColumn
            // 
            this.出版商DataGridViewTextBoxColumn.DataPropertyName = "出版商";
            this.出版商DataGridViewTextBoxColumn.HeaderText = "出版商";
            this.出版商DataGridViewTextBoxColumn.Name = "出版商DataGridViewTextBoxColumn";
            // 
            // 出版商位置DataGridViewTextBoxColumn
            // 
            this.出版商位置DataGridViewTextBoxColumn.DataPropertyName = "出版商位置";
            this.出版商位置DataGridViewTextBoxColumn.HeaderText = "出版商位置";
            this.出版商位置DataGridViewTextBoxColumn.Name = "出版商位置DataGridViewTextBoxColumn";
            // 
            // 出版者BindingSource
            // 
            this.出版者BindingSource.DataMember = "出版者";
            this.出版者BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書號DataGridViewTextBoxColumn,
            this.書名DataGridViewTextBoxColumn,
            this.作者DataGridViewTextBoxColumn,
            this.定價DataGridViewTextBoxColumn,
            this.書商編號DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.出版者書目BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 175);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(854, 157);
            this.dataGridView2.TabIndex = 1;
            // 
            // 書號DataGridViewTextBoxColumn
            // 
            this.書號DataGridViewTextBoxColumn.DataPropertyName = "書號";
            this.書號DataGridViewTextBoxColumn.HeaderText = "書號";
            this.書號DataGridViewTextBoxColumn.Name = "書號DataGridViewTextBoxColumn";
            // 
            // 書名DataGridViewTextBoxColumn
            // 
            this.書名DataGridViewTextBoxColumn.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn.Name = "書名DataGridViewTextBoxColumn";
            // 
            // 作者DataGridViewTextBoxColumn
            // 
            this.作者DataGridViewTextBoxColumn.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn";
            // 
            // 定價DataGridViewTextBoxColumn
            // 
            this.定價DataGridViewTextBoxColumn.DataPropertyName = "定價";
            this.定價DataGridViewTextBoxColumn.HeaderText = "定價";
            this.定價DataGridViewTextBoxColumn.Name = "定價DataGridViewTextBoxColumn";
            // 
            // 書商編號DataGridViewTextBoxColumn
            // 
            this.書商編號DataGridViewTextBoxColumn.DataPropertyName = "書商編號";
            this.書商編號DataGridViewTextBoxColumn.HeaderText = "書商編號";
            this.書商編號DataGridViewTextBoxColumn.Name = "書商編號DataGridViewTextBoxColumn";
            // 
            // 出版者書目BindingSource
            // 
            this.出版者書目BindingSource.DataMember = "出版者_書目";
            this.出版者書目BindingSource.DataSource = this.出版者BindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書名DataGridViewTextBoxColumn1,
            this.作者DataGridViewTextBoxColumn1,
            this.來源DataGridViewTextBoxColumn,
            this.簡介DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.書目內容簡介BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 338);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(854, 157);
            this.dataGridView3.TabIndex = 2;
            // 
            // 書名DataGridViewTextBoxColumn1
            // 
            this.書名DataGridViewTextBoxColumn1.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn1.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn1.Name = "書名DataGridViewTextBoxColumn1";
            // 
            // 作者DataGridViewTextBoxColumn1
            // 
            this.作者DataGridViewTextBoxColumn1.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn1.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn1.Name = "作者DataGridViewTextBoxColumn1";
            // 
            // 來源DataGridViewTextBoxColumn
            // 
            this.來源DataGridViewTextBoxColumn.DataPropertyName = "來源";
            this.來源DataGridViewTextBoxColumn.HeaderText = "來源";
            this.來源DataGridViewTextBoxColumn.Name = "來源DataGridViewTextBoxColumn";
            // 
            // 簡介DataGridViewTextBoxColumn
            // 
            this.簡介DataGridViewTextBoxColumn.DataPropertyName = "簡介";
            this.簡介DataGridViewTextBoxColumn.HeaderText = "簡介";
            this.簡介DataGridViewTextBoxColumn.Name = "簡介DataGridViewTextBoxColumn";
            // 
            // 書目內容簡介BindingSource
            // 
            this.書目內容簡介BindingSource.DataMember = "書目_內容簡介";
            this.書目內容簡介BindingSource.DataSource = this.出版者書目BindingSource;
            // 
            // 出版者TableAdapter
            // 
            this.出版者TableAdapter.ClearBeforeFill = true;
            // 
            // 書目TableAdapter
            // 
            this.書目TableAdapter.ClearBeforeFill = true;
            // 
            // 內容簡介TableAdapter
            // 
            this.內容簡介TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 508);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者書目BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書目內容簡介BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource 出版者BindingSource;
        private Database1DataSetTableAdapters.出版者TableAdapter 出版者TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版商DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版商位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 出版者書目BindingSource;
        private Database1DataSetTableAdapters.書目TableAdapter 書目TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 定價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書商編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 書目內容簡介BindingSource;
        private Database1DataSetTableAdapters.內容簡介TableAdapter 內容簡介TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 來源DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 簡介DataGridViewTextBoxColumn;
    }
}

