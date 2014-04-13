namespace DunaHouseGombazo
{
    partial class UserViewForm
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
            System.Windows.Forms.Label canEditLabel;
            System.Windows.Forms.Label canExportLabel;
            System.Windows.Forms.Label canImportLabel;
            System.Windows.Forms.Label canViewLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label fullname;
            System.Windows.Forms.Label isAdminLabel;
            System.Windows.Forms.Label userNameLabel;
            this.canEditCheckBox = new System.Windows.Forms.CheckBox();
            this.canExportCheckBox = new System.Windows.Forms.CheckBox();
            this.canImportCheckBox = new System.Windows.Forms.CheckBox();
            this.canViewCheckBox = new System.Windows.Forms.CheckBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            canEditLabel = new System.Windows.Forms.Label();
            canExportLabel = new System.Windows.Forms.Label();
            canImportLabel = new System.Windows.Forms.Label();
            canViewLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            fullname = new System.Windows.Forms.Label();
            isAdminLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // canEditLabel
            // 
            canEditLabel.AutoSize = true;
            canEditLabel.Location = new System.Drawing.Point(40, 219);
            canEditLabel.Name = "canEditLabel";
            canEditLabel.Size = new System.Drawing.Size(50, 13);
            canEditLabel.TabIndex = 1;
            canEditLabel.Text = "Can Edit:";
            // 
            // canExportLabel
            // 
            canExportLabel.AutoSize = true;
            canExportLabel.Location = new System.Drawing.Point(40, 249);
            canExportLabel.Name = "canExportLabel";
            canExportLabel.Size = new System.Drawing.Size(62, 13);
            canExportLabel.TabIndex = 3;
            canExportLabel.Text = "Can Export:";
            // 
            // canImportLabel
            // 
            canImportLabel.AutoSize = true;
            canImportLabel.Location = new System.Drawing.Point(40, 279);
            canImportLabel.Name = "canImportLabel";
            canImportLabel.Size = new System.Drawing.Size(61, 13);
            canImportLabel.TabIndex = 5;
            canImportLabel.Text = "Can Import:";
            // 
            // canViewLabel
            // 
            canViewLabel.AutoSize = true;
            canViewLabel.Location = new System.Drawing.Point(40, 309);
            canViewLabel.Name = "canViewLabel";
            canViewLabel.Size = new System.Drawing.Size(55, 13);
            canViewLabel.TabIndex = 7;
            canViewLabel.Text = "Can View:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(40, 109);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 21;
            fullNameLabel.Text = "Full Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(40, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 23;
            idLabel.Text = "Id:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(40, 133);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 25;
            passwordLabel.Text = "Password:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(40, 181);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 27;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(40, 155);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "Email:";
            // 
            // fullname
            // 
            fullname.AutoEllipsis = true;
            fullname.AutoSize = true;
            fullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FullName", true));
            fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            fullname.Location = new System.Drawing.Point(25, 9);
            fullname.MinimumSize = new System.Drawing.Size(200, 13);
            fullname.Name = "fullname";
            fullname.Size = new System.Drawing.Size(200, 20);
            fullname.TabIndex = 21;
            // 
            // isAdminLabel
            // 
            isAdminLabel.AutoSize = true;
            isAdminLabel.Location = new System.Drawing.Point(40, 337);
            isAdminLabel.Name = "isAdminLabel";
            isAdminLabel.Size = new System.Drawing.Size(50, 13);
            isAdminLabel.TabIndex = 33;
            isAdminLabel.Text = "Is Admin:";
            // 
            // canEditCheckBox
            // 
            this.canEditCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "CanEdit", true));
            this.canEditCheckBox.Location = new System.Drawing.Point(109, 214);
            this.canEditCheckBox.Name = "canEditCheckBox";
            this.canEditCheckBox.Size = new System.Drawing.Size(104, 24);
            this.canEditCheckBox.TabIndex = 6;
            this.canEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // canExportCheckBox
            // 
            this.canExportCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "CanExport", true));
            this.canExportCheckBox.Location = new System.Drawing.Point(109, 244);
            this.canExportCheckBox.Name = "canExportCheckBox";
            this.canExportCheckBox.Size = new System.Drawing.Size(104, 24);
            this.canExportCheckBox.TabIndex = 7;
            this.canExportCheckBox.UseVisualStyleBackColor = true;
            // 
            // canImportCheckBox
            // 
            this.canImportCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "CanImport", true));
            this.canImportCheckBox.Location = new System.Drawing.Point(109, 274);
            this.canImportCheckBox.Name = "canImportCheckBox";
            this.canImportCheckBox.Size = new System.Drawing.Size(104, 24);
            this.canImportCheckBox.TabIndex = 8;
            this.canImportCheckBox.UseVisualStyleBackColor = true;
            // 
            // canViewCheckBox
            // 
            this.canViewCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "CanView", true));
            this.canViewCheckBox.Location = new System.Drawing.Point(109, 304);
            this.canViewCheckBox.Name = "canViewCheckBox";
            this.canViewCheckBox.Size = new System.Drawing.Size(104, 24);
            this.canViewCheckBox.TabIndex = 9;
            this.canViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(109, 106);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(109, 55);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(109, 130);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(104, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(109, 178);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(104, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(109, 152);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(104, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 109);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "IsAdmin", true));
            this.isAdminCheckBox.Location = new System.Drawing.Point(109, 332);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isAdminCheckBox.TabIndex = 10;
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(138, 337);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 26);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(40, 84);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 35;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(109, 81);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DunaHouseGombazo.User);
            // 
            // UserViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 394);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(isAdminLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(fullname);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(canEditLabel);
            this.Controls.Add(this.canEditCheckBox);
            this.Controls.Add(canExportLabel);
            this.Controls.Add(this.canExportCheckBox);
            this.Controls.Add(canImportLabel);
            this.Controls.Add(this.canImportCheckBox);
            this.Controls.Add(canViewLabel);
            this.Controls.Add(this.canViewCheckBox);
            this.Controls.Add(this.isAdminCheckBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.MaximumSize = new System.Drawing.Size(261, 433);
            this.MinimumSize = new System.Drawing.Size(261, 433);
            this.Name = "UserViewForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserViewForm";
            this.Load += new System.EventHandler(this.UserViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.CheckBox canEditCheckBox;
        private System.Windows.Forms.CheckBox canExportCheckBox;
        private System.Windows.Forms.CheckBox canImportCheckBox;
        private System.Windows.Forms.CheckBox canViewCheckBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox userNameTextBox;
    }
}