namespace fkg_app1
{
    partial class AddForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNHp = new System.Windows.Forms.Label();
            this.GrpBoxNormalStats = new System.Windows.Forms.GroupBox();
            this.lblNPow = new System.Windows.Forms.Label();
            this.textNDef = new System.Windows.Forms.TextBox();
            this.textNAtk = new System.Windows.Forms.TextBox();
            this.textNHp = new System.Windows.Forms.TextBox();
            this.lblNTotal = new System.Windows.Forms.Label();
            this.lblNDef = new System.Windows.Forms.Label();
            this.lblNAtk = new System.Windows.Forms.Label();
            this.GrpBoxAwakenedStats = new System.Windows.Forms.GroupBox();
            this.lblAPow = new System.Windows.Forms.Label();
            this.textADef = new System.Windows.Forms.TextBox();
            this.textAAtk = new System.Windows.Forms.TextBox();
            this.textAHp = new System.Windows.Forms.TextBox();
            this.lblATotal = new System.Windows.Forms.Label();
            this.lblADef = new System.Windows.Forms.Label();
            this.lblAAtk = new System.Windows.Forms.Label();
            this.lblAHp = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSteps = new System.Windows.Forms.TextBox();
            this.CBoxBloom = new System.Windows.Forms.CheckBox();
            this.GrpBoxNormalStats.SuspendLayout();
            this.GrpBoxAwakenedStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(5, 39);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type: ";
            // 
            // lblNHp
            // 
            this.lblNHp.AutoSize = true;
            this.lblNHp.Location = new System.Drawing.Point(6, 23);
            this.lblNHp.Name = "lblNHp";
            this.lblNHp.Size = new System.Drawing.Size(22, 13);
            this.lblNHp.TabIndex = 4;
            this.lblNHp.Text = "HP";
            // 
            // GrpBoxNormalStats
            // 
            this.GrpBoxNormalStats.Controls.Add(this.lblNPow);
            this.GrpBoxNormalStats.Controls.Add(this.textNDef);
            this.GrpBoxNormalStats.Controls.Add(this.textNAtk);
            this.GrpBoxNormalStats.Controls.Add(this.textNHp);
            this.GrpBoxNormalStats.Controls.Add(this.lblNTotal);
            this.GrpBoxNormalStats.Controls.Add(this.lblNDef);
            this.GrpBoxNormalStats.Controls.Add(this.lblNAtk);
            this.GrpBoxNormalStats.Controls.Add(this.lblNHp);
            this.GrpBoxNormalStats.Location = new System.Drawing.Point(12, 72);
            this.GrpBoxNormalStats.Name = "GrpBoxNormalStats";
            this.GrpBoxNormalStats.Size = new System.Drawing.Size(119, 148);
            this.GrpBoxNormalStats.TabIndex = 5;
            this.GrpBoxNormalStats.TabStop = false;
            this.GrpBoxNormalStats.Text = "Normal";
            // 
            // lblNPow
            // 
            this.lblNPow.AutoSize = true;
            this.lblNPow.Location = new System.Drawing.Point(43, 113);
            this.lblNPow.Name = "lblNPow";
            this.lblNPow.Size = new System.Drawing.Size(13, 13);
            this.lblNPow.TabIndex = 11;
            this.lblNPow.Text = "0";
            // 
            // textNDef
            // 
            this.textNDef.Location = new System.Drawing.Point(34, 77);
            this.textNDef.Name = "textNDef";
            this.textNDef.Size = new System.Drawing.Size(79, 20);
            this.textNDef.TabIndex = 10;
            this.textNDef.Leave += new System.EventHandler(this.textNDef_Leave);
            // 
            // textNAtk
            // 
            this.textNAtk.Location = new System.Drawing.Point(34, 47);
            this.textNAtk.Name = "textNAtk";
            this.textNAtk.Size = new System.Drawing.Size(79, 20);
            this.textNAtk.TabIndex = 9;
            this.textNAtk.Leave += new System.EventHandler(this.textNAtk_Leave);
            // 
            // textNHp
            // 
            this.textNHp.Location = new System.Drawing.Point(35, 19);
            this.textNHp.Name = "textNHp";
            this.textNHp.Size = new System.Drawing.Size(78, 20);
            this.textNHp.TabIndex = 8;
            this.textNHp.Leave += new System.EventHandler(this.textNHp_Leave);
            // 
            // lblNTotal
            // 
            this.lblNTotal.AutoSize = true;
            this.lblNTotal.Location = new System.Drawing.Point(3, 113);
            this.lblNTotal.Name = "lblNTotal";
            this.lblNTotal.Size = new System.Drawing.Size(34, 13);
            this.lblNTotal.TabIndex = 7;
            this.lblNTotal.Text = "Total:";
            // 
            // lblNDef
            // 
            this.lblNDef.AutoSize = true;
            this.lblNDef.Location = new System.Drawing.Point(4, 77);
            this.lblNDef.Name = "lblNDef";
            this.lblNDef.Size = new System.Drawing.Size(24, 13);
            this.lblNDef.TabIndex = 6;
            this.lblNDef.Text = "Def";
            this.lblNDef.Click += new System.EventHandler(this.lblNDef_Click);
            // 
            // lblNAtk
            // 
            this.lblNAtk.AutoSize = true;
            this.lblNAtk.Location = new System.Drawing.Point(4, 50);
            this.lblNAtk.Name = "lblNAtk";
            this.lblNAtk.Size = new System.Drawing.Size(23, 13);
            this.lblNAtk.TabIndex = 5;
            this.lblNAtk.Text = "Atk";
            // 
            // GrpBoxAwakenedStats
            // 
            this.GrpBoxAwakenedStats.Controls.Add(this.lblAPow);
            this.GrpBoxAwakenedStats.Controls.Add(this.textADef);
            this.GrpBoxAwakenedStats.Controls.Add(this.textAAtk);
            this.GrpBoxAwakenedStats.Controls.Add(this.textAHp);
            this.GrpBoxAwakenedStats.Controls.Add(this.lblATotal);
            this.GrpBoxAwakenedStats.Controls.Add(this.lblADef);
            this.GrpBoxAwakenedStats.Controls.Add(this.lblAAtk);
            this.GrpBoxAwakenedStats.Controls.Add(this.lblAHp);
            this.GrpBoxAwakenedStats.Location = new System.Drawing.Point(138, 72);
            this.GrpBoxAwakenedStats.Name = "GrpBoxAwakenedStats";
            this.GrpBoxAwakenedStats.Size = new System.Drawing.Size(134, 148);
            this.GrpBoxAwakenedStats.TabIndex = 6;
            this.GrpBoxAwakenedStats.TabStop = false;
            this.GrpBoxAwakenedStats.Text = "Awakened";
            // 
            // lblAPow
            // 
            this.lblAPow.AutoSize = true;
            this.lblAPow.Location = new System.Drawing.Point(45, 113);
            this.lblAPow.Name = "lblAPow";
            this.lblAPow.Size = new System.Drawing.Size(13, 13);
            this.lblAPow.TabIndex = 15;
            this.lblAPow.Text = "0";
            // 
            // textADef
            // 
            this.textADef.Location = new System.Drawing.Point(34, 77);
            this.textADef.Name = "textADef";
            this.textADef.Size = new System.Drawing.Size(79, 20);
            this.textADef.TabIndex = 14;
            this.textADef.Leave += new System.EventHandler(this.textADef_Leave);
            // 
            // textAAtk
            // 
            this.textAAtk.Location = new System.Drawing.Point(34, 47);
            this.textAAtk.Name = "textAAtk";
            this.textAAtk.Size = new System.Drawing.Size(79, 20);
            this.textAAtk.TabIndex = 13;
            this.textAAtk.Leave += new System.EventHandler(this.textAAtk_Leave);
            // 
            // textAHp
            // 
            this.textAHp.Location = new System.Drawing.Point(35, 19);
            this.textAHp.Name = "textAHp";
            this.textAHp.Size = new System.Drawing.Size(78, 20);
            this.textAHp.TabIndex = 12;
            this.textAHp.Leave += new System.EventHandler(this.textAHp_Leave);
            // 
            // lblATotal
            // 
            this.lblATotal.AutoSize = true;
            this.lblATotal.Location = new System.Drawing.Point(5, 113);
            this.lblATotal.Name = "lblATotal";
            this.lblATotal.Size = new System.Drawing.Size(34, 13);
            this.lblATotal.TabIndex = 11;
            this.lblATotal.Text = "Total:";
            // 
            // lblADef
            // 
            this.lblADef.AutoSize = true;
            this.lblADef.Location = new System.Drawing.Point(4, 77);
            this.lblADef.Name = "lblADef";
            this.lblADef.Size = new System.Drawing.Size(24, 13);
            this.lblADef.TabIndex = 10;
            this.lblADef.Text = "Def";
            // 
            // lblAAtk
            // 
            this.lblAAtk.AutoSize = true;
            this.lblAAtk.Location = new System.Drawing.Point(5, 47);
            this.lblAAtk.Name = "lblAAtk";
            this.lblAAtk.Size = new System.Drawing.Size(23, 13);
            this.lblAAtk.TabIndex = 9;
            this.lblAAtk.Text = "Atk";
            // 
            // lblAHp
            // 
            this.lblAHp.AutoSize = true;
            this.lblAHp.Location = new System.Drawing.Point(5, 19);
            this.lblAHp.Name = "lblAHp";
            this.lblAHp.Size = new System.Drawing.Size(22, 13);
            this.lblAHp.TabIndex = 8;
            this.lblAHp.Text = "HP";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(9, 238);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(40, 13);
            this.lblSteps.TabIndex = 7;
            this.lblSteps.Text = "Steps: ";
            // 
            // comboType
            // 
            this.comboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(41, 36);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(41, 10);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(216, 20);
            this.textName.TabIndex = 9;
            // 
            // textSteps
            // 
            this.textSteps.Location = new System.Drawing.Point(46, 235);
            this.textSteps.Name = "textSteps";
            this.textSteps.Size = new System.Drawing.Size(100, 20);
            this.textSteps.TabIndex = 10;
            // 
            // CBoxBloom
            // 
            this.CBoxBloom.AutoSize = true;
            this.CBoxBloom.Location = new System.Drawing.Point(8, 280);
            this.CBoxBloom.Name = "CBoxBloom";
            this.CBoxBloom.Size = new System.Drawing.Size(101, 17);
            this.CBoxBloom.TabIndex = 11;
            this.CBoxBloom.Text = "Bloom Available";
            this.CBoxBloom.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.CBoxBloom);
            this.Controls.Add(this.textSteps);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.GrpBoxAwakenedStats);
            this.Controls.Add(this.GrpBoxNormalStats);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.GrpBoxNormalStats.ResumeLayout(false);
            this.GrpBoxNormalStats.PerformLayout();
            this.GrpBoxAwakenedStats.ResumeLayout(false);
            this.GrpBoxAwakenedStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNHp;
        private System.Windows.Forms.GroupBox GrpBoxNormalStats;
        private System.Windows.Forms.Label lblNTotal;
        private System.Windows.Forms.Label lblNDef;
        private System.Windows.Forms.Label lblNAtk;
        private System.Windows.Forms.GroupBox GrpBoxAwakenedStats;
        private System.Windows.Forms.Label lblATotal;
        private System.Windows.Forms.Label lblADef;
        private System.Windows.Forms.Label lblAAtk;
        private System.Windows.Forms.Label lblAHp;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.TextBox textNDef;
        private System.Windows.Forms.TextBox textNAtk;
        private System.Windows.Forms.TextBox textNHp;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSteps;
        private System.Windows.Forms.CheckBox CBoxBloom;
        private System.Windows.Forms.TextBox textADef;
        private System.Windows.Forms.TextBox textAAtk;
        private System.Windows.Forms.TextBox textAHp;
        private System.Windows.Forms.Label lblNPow;
        private System.Windows.Forms.Label lblAPow;
    }
}