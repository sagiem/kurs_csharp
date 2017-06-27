namespace Business
{
    partial class MainMenu
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
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnProductGroups = new System.Windows.Forms.Button();
            this.gboxManuCatalogs = new System.Windows.Forms.GroupBox();
            this.btnClientCatalog = new System.Windows.Forms.Button();
            this.gboxManuCatalogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(20, 29);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 23);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Товары";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(20, 58);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 23);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // btnProductGroups
            // 
            this.btnProductGroups.Location = new System.Drawing.Point(20, 87);
            this.btnProductGroups.Name = "btnProductGroups";
            this.btnProductGroups.Size = new System.Drawing.Size(120, 23);
            this.btnProductGroups.TabIndex = 3;
            this.btnProductGroups.Text = "Группы товаров";
            this.btnProductGroups.UseVisualStyleBackColor = true;
            this.btnProductGroups.Click += new System.EventHandler(this.btnProductGroups_Click_1);
            // 
            // gboxManuCatalogs
            // 
            this.gboxManuCatalogs.Controls.Add(this.btnClientCatalog);
            this.gboxManuCatalogs.Controls.Add(this.btnProducts);
            this.gboxManuCatalogs.Controls.Add(this.btnProductGroups);
            this.gboxManuCatalogs.Controls.Add(this.btnEmployees);
            this.gboxManuCatalogs.Location = new System.Drawing.Point(12, 12);
            this.gboxManuCatalogs.Name = "gboxManuCatalogs";
            this.gboxManuCatalogs.Size = new System.Drawing.Size(156, 159);
            this.gboxManuCatalogs.TabIndex = 0;
            this.gboxManuCatalogs.TabStop = false;
            this.gboxManuCatalogs.Text = "Справочники";
            // 
            // btnClientCatalog
            // 
            this.btnClientCatalog.Location = new System.Drawing.Point(20, 117);
            this.btnClientCatalog.Name = "btnClientCatalog";
            this.btnClientCatalog.Size = new System.Drawing.Size(120, 23);
            this.btnClientCatalog.TabIndex = 4;
            this.btnClientCatalog.Text = "Клиенты";
            this.btnClientCatalog.UseVisualStyleBackColor = true;
            this.btnClientCatalog.Click += new System.EventHandler(this.btnClientCatalog_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 182);
            this.Controls.Add(this.gboxManuCatalogs);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.gboxManuCatalogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnProductGroups;
        private System.Windows.Forms.GroupBox gboxManuCatalogs;
        private System.Windows.Forms.Button btnClientCatalog;
    }
}