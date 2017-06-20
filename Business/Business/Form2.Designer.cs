namespace Business
{
    partial class ClientCatalog
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCheckingAccount = new System.Windows.Forms.Label();
            this.lblINN = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCheckingAccount = new System.Windows.Forms.TextBox();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.gboxClientCard = new System.Windows.Forms.GroupBox();
            this.listClients = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboxClientCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование (юридического лица)";
            // 
            // lblCheckingAccount
            // 
            this.lblCheckingAccount.AutoSize = true;
            this.lblCheckingAccount.Location = new System.Drawing.Point(6, 55);
            this.lblCheckingAccount.Name = "lblCheckingAccount";
            this.lblCheckingAccount.Size = new System.Drawing.Size(87, 13);
            this.lblCheckingAccount.TabIndex = 1;
            this.lblCheckingAccount.Text = "Расчетный счет";
            // 
            // lblINN
            // 
            this.lblINN.AutoSize = true;
            this.lblINN.Location = new System.Drawing.Point(6, 77);
            this.lblINN.Name = "lblINN";
            this.lblINN.Size = new System.Drawing.Size(31, 13);
            this.lblINN.TabIndex = 2;
            this.lblINN.Text = "ИНН";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(207, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtCheckingAccount
            // 
            this.txtCheckingAccount.Location = new System.Drawing.Point(208, 55);
            this.txtCheckingAccount.Name = "txtCheckingAccount";
            this.txtCheckingAccount.Size = new System.Drawing.Size(129, 20);
            this.txtCheckingAccount.TabIndex = 4;
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(208, 81);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(129, 20);
            this.txtINN.TabIndex = 5;
            // 
            // gboxClientCard
            // 
            this.gboxClientCard.Controls.Add(this.btnDelete);
            this.gboxClientCard.Controls.Add(this.btnSave);
            this.gboxClientCard.Controls.Add(this.txtName);
            this.gboxClientCard.Controls.Add(this.txtINN);
            this.gboxClientCard.Controls.Add(this.lblName);
            this.gboxClientCard.Controls.Add(this.txtCheckingAccount);
            this.gboxClientCard.Controls.Add(this.lblCheckingAccount);
            this.gboxClientCard.Controls.Add(this.lblINN);
            this.gboxClientCard.Location = new System.Drawing.Point(215, 12);
            this.gboxClientCard.Name = "gboxClientCard";
            this.gboxClientCard.Size = new System.Drawing.Size(352, 227);
            this.gboxClientCard.TabIndex = 6;
            this.gboxClientCard.TabStop = false;
            this.gboxClientCard.Text = "Карточка клиента";
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.Location = new System.Drawing.Point(13, 13);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(196, 173);
            this.listClients.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(271, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ClientCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 245);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.gboxClientCard);
            this.Name = "ClientCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник клиентов";
            this.gboxClientCard.ResumeLayout(false);
            this.gboxClientCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCheckingAccount;
        private System.Windows.Forms.Label lblINN;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCheckingAccount;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.GroupBox gboxClientCard;
        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
    }
}