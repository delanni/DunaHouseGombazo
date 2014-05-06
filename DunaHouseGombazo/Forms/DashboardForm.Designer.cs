namespace DunaHouseGombazo
{
    partial class DashboardForm
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
            this.infoLabel = new System.Windows.Forms.LinkLabel();
            this.browseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nameLabelX = new System.Windows.Forms.LinkLabel();
            this.searchUsersButton = new System.Windows.Forms.Button();
            this.userSearchTextBox = new System.Windows.Forms.TextBox();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.userSearchLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoLabel.Location = new System.Drawing.Point(8, 641);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(142, 13);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.TabStop = true;
            this.infoLabel.Text = "About Duna House Shroomz";
            this.infoLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.infoLabel_LinkClicked);
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browseButton.Location = new System.Drawing.Point(117, 314);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 100);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(341, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportButton.Location = new System.Drawing.Point(789, 314);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 100);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.importButton.Location = new System.Drawing.Point(565, 314);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(100, 100);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(846, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 23);
            this.button4.TabIndex = 0;
            this.button4.TabStop = false;
            this.button4.Text = "Sign out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nameLabelX
            // 
            this.nameLabelX.AutoSize = true;
            this.nameLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabelX.Location = new System.Drawing.Point(697, 29);
            this.nameLabelX.MinimumSize = new System.Drawing.Size(300, 0);
            this.nameLabelX.Name = "nameLabelX";
            this.nameLabelX.Size = new System.Drawing.Size(300, 24);
            this.nameLabelX.TabIndex = 4;
            this.nameLabelX.Text = "NAME HERE";
            this.nameLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nameLabelX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nameLabel_LinkClicked);
            // 
            // searchUsersButton
            // 
            this.searchUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchUsersButton.Location = new System.Drawing.Point(117, 80);
            this.searchUsersButton.Name = "searchUsersButton";
            this.searchUsersButton.Size = new System.Drawing.Size(100, 100);
            this.searchUsersButton.TabIndex = 4;
            this.searchUsersButton.Text = "Search users";
            this.searchUsersButton.UseVisualStyleBackColor = true;
            this.searchUsersButton.Click += new System.EventHandler(this.browseUsersButton_Click);
            // 
            // userSearchTextBox
            // 
            this.userSearchTextBox.Location = new System.Drawing.Point(118, 220);
            this.userSearchTextBox.Name = "userSearchTextBox";
            this.userSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.userSearchTextBox.TabIndex = 5;
            this.userSearchTextBox.Visible = false;
            this.userSearchTextBox.TextChanged += new System.EventHandler(this.userSearchTextBox_TextChanged);
            // 
            // usersListBox
            // 
            this.usersListBox.DisplayMember = "FullName";
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(224, 80);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(120, 160);
            this.usersListBox.TabIndex = 7;
            this.usersListBox.ValueMember = "Id";
            this.usersListBox.Visible = false;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            this.usersListBox.DoubleClick += new System.EventHandler(this.usersListBox_DoubleClick);
            // 
            // userSearchLabel
            // 
            this.userSearchLabel.AutoSize = true;
            this.userSearchLabel.Location = new System.Drawing.Point(97, 204);
            this.userSearchLabel.Name = "userSearchLabel";
            this.userSearchLabel.Size = new System.Drawing.Size(121, 13);
            this.userSearchLabel.TabIndex = 8;
            this.userSearchLabel.Text = "Type name or username";
            this.userSearchLabel.Visible = false;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUserButton.Location = new System.Drawing.Point(565, 80);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 100);
            this.addUserButton.TabIndex = 6;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.userSearchLabel);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.userSearchTextBox);
            this.Controls.Add(this.nameLabelX);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.searchUsersButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.infoLabel);
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel infoLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel nameLabelX;
        private System.Windows.Forms.Button searchUsersButton;
        private System.Windows.Forms.TextBox userSearchTextBox;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label userSearchLabel;
        private System.Windows.Forms.Button addUserButton;
    }
}