namespace Business
{
    partial class ProductGroups
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
            this.listProductGroups = new System.Windows.Forms.ListBox();
            this.gboxProductGroups = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboxProductGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProductGroups
            // 
            this.listProductGroups.FormattingEnabled = true;
            this.listProductGroups.Location = new System.Drawing.Point(13, 13);
            this.listProductGroups.Name = "listProductGroups";
            this.listProductGroups.Size = new System.Drawing.Size(229, 121);
            this.listProductGroups.TabIndex = 1;
            this.listProductGroups.SelectedIndexChanged += new System.EventHandler(this.listProducts_SelectedIndexChanged);
            // 
            // gboxProductGroups
            // 
            this.gboxProductGroups.Controls.Add(this.txtName);
            this.gboxProductGroups.Controls.Add(this.lblName);
            this.gboxProductGroups.Controls.Add(this.btnDelete);
            this.gboxProductGroups.Controls.Add(this.btnSave);
            this.gboxProductGroups.Location = new System.Drawing.Point(249, 13);
            this.gboxProductGroups.Name = "gboxProductGroups";
            this.gboxProductGroups.Size = new System.Drawing.Size(212, 164);
            this.gboxProductGroups.TabIndex = 2;
            this.gboxProductGroups.TabStop = false;
            this.gboxProductGroups.Text = "Карточка группы товара";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Наименование";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 140);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ProductGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 183);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gboxProductGroups);
            this.Controls.Add(this.listProductGroups);
            this.Name = "ProductGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник групп товаров";
            this.Load += new System.EventHandler(this.ProductCatalog_Load);
            this.gboxProductGroups.ResumeLayout(false);
            this.gboxProductGroups.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProductGroups;
        private System.Windows.Forms.GroupBox gboxProductGroups;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
    }
}