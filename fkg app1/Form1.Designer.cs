namespace fkg_app1
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
            this.BGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.girlsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girlsDataSet = new fkg_app1.girlsDataSet();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.btnExpandCollapse = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BGrid
            // 
            this.BGrid.Location = new System.Drawing.Point(551, 12);
            this.BGrid.Name = "BGrid";
            this.BGrid.Size = new System.Drawing.Size(75, 23);
            this.BGrid.TabIndex = 0;
            this.BGrid.Text = "Grid View";
            this.BGrid.UseVisualStyleBackColor = true;
            this.BGrid.Click += new System.EventHandler(this.BGrid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.girlsDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 265);
            this.dataGridView1.TabIndex = 1;
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
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(9, 134);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(44, 13);
            this.SearchLbl.TabIndex = 2;
            this.SearchLbl.Text = "Search:";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(50, 134);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(149, 20);
            this.SearchTxtBox.TabIndex = 3;
            // 
            // btnExpandCollapse
            // 
            this.btnExpandCollapse.Location = new System.Drawing.Point(597, 435);
            this.btnExpandCollapse.Name = "btnExpandCollapse";
            this.btnExpandCollapse.Size = new System.Drawing.Size(75, 23);
            this.btnExpandCollapse.TabIndex = 4;
            this.btnExpandCollapse.Text = "Expand";
            this.btnExpandCollapse.UseVisualStyleBackColor = true;
            this.btnExpandCollapse.Click += new System.EventHandler(this.btnExpandCollapse_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 435);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 470);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExpandCollapse);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource girlsDataSetBindingSource;
        private girlsDataSet girlsDataSet;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Button btnExpandCollapse;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}

