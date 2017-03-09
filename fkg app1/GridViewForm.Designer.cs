namespace fkg_app1
{
    partial class GridViewForm
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
            this.girlsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girlsDataSet = new fkg_app1.girlsDataSet();
            this.girlsDataSet1 = new fkg_app1.girlsDataSet();
            this.girlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girlsTableAdapter = new fkg_app1.girlsDataSetTableAdapters.GirlsTableAdapter();
            this.tableAdapterManager = new fkg_app1.girlsDataSetTableAdapters.TableAdapterManager();
            this.girlsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // girlsDataSetBindingSource
            // 
            this.girlsDataSetBindingSource.DataSource = this.girlsDataSet;
            this.girlsDataSetBindingSource.Position = 0;
            // 
            // girlsDataSet
            // 
            this.girlsDataSet.DataSetName = "girlsDataSet";
            this.girlsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // girlsDataSet1
            // 
            this.girlsDataSet1.DataSetName = "girlsDataSet";
            this.girlsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // girlsBindingSource
            // 
            this.girlsBindingSource.DataMember = "Girls";
            this.girlsBindingSource.DataSource = this.girlsDataSet;
            // 
            // girlsTableAdapter
            // 
            this.girlsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GirlsTableAdapter = this.girlsTableAdapter;
            this.tableAdapterManager.UpdateOrder = fkg_app1.girlsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // girlsDataGridView
            // 
            this.girlsDataGridView.AutoGenerateColumns = false;
            this.girlsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girlsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.girlsDataGridView.DataSource = this.girlsBindingSource;
            this.girlsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.girlsDataGridView.Name = "girlsDataGridView";
            this.girlsDataGridView.Size = new System.Drawing.Size(878, 376);
            this.girlsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NormalHp";
            this.dataGridViewTextBoxColumn4.HeaderText = "NormalHp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NormalAtk";
            this.dataGridViewTextBoxColumn5.HeaderText = "NormalAtk";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NormalDef";
            this.dataGridViewTextBoxColumn6.HeaderText = "NormalDef";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AwakeHp";
            this.dataGridViewTextBoxColumn7.HeaderText = "AwakeHp";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AwakeAtk";
            this.dataGridViewTextBoxColumn8.HeaderText = "AwakeAtk";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AwakeDef";
            this.dataGridViewTextBoxColumn9.HeaderText = "AwakeDef";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Steps";
            this.dataGridViewTextBoxColumn10.HeaderText = "Steps";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "BloomAvailable";
            this.dataGridViewCheckBoxColumn1.HeaderText = "BloomAvailable";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // GridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 400);
            this.Controls.Add(this.girlsDataGridView);
            this.Name = "GridViewForm";
            this.Text = "GridViewForm";
            this.Load += new System.EventHandler(this.GridViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource girlsDataSetBindingSource;
        private girlsDataSet girlsDataSet;
        private girlsDataSet girlsDataSet1;
        private System.Windows.Forms.BindingSource girlsBindingSource;
        private girlsDataSetTableAdapters.GirlsTableAdapter girlsTableAdapter;
        private girlsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView girlsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}