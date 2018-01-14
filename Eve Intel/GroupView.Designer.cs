namespace Eve_Intel
{
    partial class GroupView
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
            this.LstItems = new System.Windows.Forms.ListBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Location = new System.Drawing.Point(12, 12);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(202, 446);
            this.LstItems.TabIndex = 0;
            this.LstItems.SelectedIndexChanged += new System.EventHandler(this.LstItems_SelectedIndexChanged);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(12, 465);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 494);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(202, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(220, 12);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(441, 446);
            this.TxtInfo.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(311, 465);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(350, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(93, 468);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(121, 20);
            this.TxtName.TabIndex = 5;
            // 
            // GroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 521);
            this.ControlBox = false;
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LstItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GroupView";
            this.Load += new System.EventHandler(this.GroupView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtName;
    }
}