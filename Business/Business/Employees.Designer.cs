namespace Business
{
    partial class EmployeesCatalog
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
            this.listEmployees = new System.Windows.Forms.ListBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblMarriage = new System.Windows.Forms.Label();
            this.lblPostalIndex = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHireType = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.gboxEmployeesCard = new System.Windows.Forms.GroupBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.cmbHireType = new System.Windows.Forms.ComboBox();
            this.cmbMarriage = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPostalIndex = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboxEmployeesCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEmployees
            // 
            this.listEmployees.FormattingEnabled = true;
            this.listEmployees.Location = new System.Drawing.Point(12, 10);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(363, 342);
            this.listEmployees.TabIndex = 0;
            this.listEmployees.SelectedIndexChanged += new System.EventHandler(this.listProducts_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(21, 85);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(54, 13);
            this.lblFatherName.TabIndex = 3;
            this.lblFatherName.Text = "Отчество";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(21, 117);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(27, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Пол";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(22, 148);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(86, 13);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Дата рождения";
            // 
            // lblMarriage
            // 
            this.lblMarriage.AutoSize = true;
            this.lblMarriage.Location = new System.Drawing.Point(23, 178);
            this.lblMarriage.Name = "lblMarriage";
            this.lblMarriage.Size = new System.Drawing.Size(93, 13);
            this.lblMarriage.TabIndex = 6;
            this.lblMarriage.Text = "Статус \"в браке\"";
            // 
            // lblPostalIndex
            // 
            this.lblPostalIndex.AutoSize = true;
            this.lblPostalIndex.Location = new System.Drawing.Point(23, 207);
            this.lblPostalIndex.Name = "lblPostalIndex";
            this.lblPostalIndex.Size = new System.Drawing.Size(96, 13);
            this.lblPostalIndex.TabIndex = 7;
            this.lblPostalIndex.Text = "Почтовый индекс";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(24, 236);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Адрес";
            // 
            // lblHireType
            // 
            this.lblHireType.AutoSize = true;
            this.lblHireType.Location = new System.Drawing.Point(24, 266);
            this.lblHireType.Name = "lblHireType";
            this.lblHireType.Size = new System.Drawing.Size(61, 13);
            this.lblHireType.TabIndex = 9;
            this.lblHireType.Text = "Тип найма";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(26, 294);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(70, 13);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "Примечание";
            // 
            // gboxEmployeesCard
            // 
            this.gboxEmployeesCard.Controls.Add(this.txtBirthDate);
            this.gboxEmployeesCard.Controls.Add(this.cmbHireType);
            this.gboxEmployeesCard.Controls.Add(this.cmbMarriage);
            this.gboxEmployeesCard.Controls.Add(this.cmbGender);
            this.gboxEmployeesCard.Controls.Add(this.txtNotes);
            this.gboxEmployeesCard.Controls.Add(this.txtAddress);
            this.gboxEmployeesCard.Controls.Add(this.txtPostalIndex);
            this.gboxEmployeesCard.Controls.Add(this.txtFatherName);
            this.gboxEmployeesCard.Controls.Add(this.txtLastName);
            this.gboxEmployeesCard.Controls.Add(this.txtFirstName);
            this.gboxEmployeesCard.Controls.Add(this.btnDelete);
            this.gboxEmployeesCard.Controls.Add(this.btnSave);
            this.gboxEmployeesCard.Controls.Add(this.lblFirstName);
            this.gboxEmployeesCard.Controls.Add(this.lblNotes);
            this.gboxEmployeesCard.Controls.Add(this.lblLastName);
            this.gboxEmployeesCard.Controls.Add(this.lblHireType);
            this.gboxEmployeesCard.Controls.Add(this.lblFatherName);
            this.gboxEmployeesCard.Controls.Add(this.lblAddress);
            this.gboxEmployeesCard.Controls.Add(this.lblGender);
            this.gboxEmployeesCard.Controls.Add(this.lblPostalIndex);
            this.gboxEmployeesCard.Controls.Add(this.lblBirthDate);
            this.gboxEmployeesCard.Controls.Add(this.lblMarriage);
            this.gboxEmployeesCard.Location = new System.Drawing.Point(381, 10);
            this.gboxEmployeesCard.Name = "gboxEmployeesCard";
            this.gboxEmployeesCard.Size = new System.Drawing.Size(342, 382);
            this.gboxEmployeesCard.TabIndex = 11;
            this.gboxEmployeesCard.TabStop = false;
            this.gboxEmployeesCard.Text = "Карточка сотрудника";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(173, 148);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(121, 20);
            this.txtBirthDate.TabIndex = 22;
            // 
            // cmbHireType
            // 
            this.cmbHireType.FormattingEnabled = true;
            this.cmbHireType.Location = new System.Drawing.Point(173, 267);
            this.cmbHireType.Name = "cmbHireType";
            this.cmbHireType.Size = new System.Drawing.Size(121, 21);
            this.cmbHireType.TabIndex = 21;
            // 
            // cmbMarriage
            // 
            this.cmbMarriage.FormattingEnabled = true;
            this.cmbMarriage.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.cmbMarriage.Location = new System.Drawing.Point(173, 178);
            this.cmbMarriage.Name = "cmbMarriage";
            this.cmbMarriage.Size = new System.Drawing.Size(121, 21);
            this.cmbMarriage.TabIndex = 20;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.cmbGender.Location = new System.Drawing.Point(173, 117);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 19;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(173, 294);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(121, 20);
            this.txtNotes.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(173, 236);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 17;
            // 
            // txtPostalIndex
            // 
            this.txtPostalIndex.Location = new System.Drawing.Point(173, 205);
            this.txtPostalIndex.Name = "txtPostalIndex";
            this.txtPostalIndex.Size = new System.Drawing.Size(121, 20);
            this.txtPostalIndex.TabIndex = 16;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(173, 85);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(121, 20);
            this.txtFatherName.TabIndex = 15;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(173, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(173, 18);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 358);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EmployeesCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 400);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gboxEmployeesCard);
            this.Controls.Add(this.listEmployees);
            this.Name = "EmployeesCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник сотрудников";
            this.Load += new System.EventHandler(this.ProductCatalog_Load);
            this.gboxEmployeesCard.ResumeLayout(false);
            this.gboxEmployeesCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listEmployees;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblMarriage;
        private System.Windows.Forms.Label lblPostalIndex;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHireType;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox gboxEmployeesCard;
        private System.Windows.Forms.ComboBox cmbMarriage;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPostalIndex;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbHireType;
        private System.Windows.Forms.TextBox txtBirthDate;
    }
}