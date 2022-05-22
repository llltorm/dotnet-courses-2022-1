
namespace PLWinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tabPageAward = new System.Windows.Forms.TabPage();
            this.btnDeleteAward = new System.Windows.Forms.Button();
            this.btnEditAward = new System.Windows.Forms.Button();
            this.btnAddAward = new System.Windows.Forms.Button();
            this.dgvAwards = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPageAward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUser);
            this.tabControl.Controls.Add(this.tabPageAward);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(733, 445);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.btnDeleteUser);
            this.tabPageUser.Controls.Add(this.btnEditUser);
            this.tabPageUser.Controls.Add(this.btnAddUser);
            this.tabPageUser.Controls.Add(this.dgvUsers);
            this.tabPageUser.Location = new System.Drawing.Point(4, 24);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(725, 417);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "Пользователи";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(183, 380);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Удалить";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(102, 380);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Изменить";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(21, 380);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(0, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(725, 371);
            this.dgvUsers.TabIndex = 0;
            // 
            // tabPageAward
            // 
            this.tabPageAward.Controls.Add(this.btnDeleteAward);
            this.tabPageAward.Controls.Add(this.btnEditAward);
            this.tabPageAward.Controls.Add(this.btnAddAward);
            this.tabPageAward.Controls.Add(this.dgvAwards);
            this.tabPageAward.Location = new System.Drawing.Point(4, 24);
            this.tabPageAward.Name = "tabPageAward";
            this.tabPageAward.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAward.Size = new System.Drawing.Size(725, 417);
            this.tabPageAward.TabIndex = 1;
            this.tabPageAward.Text = "Награды";
            this.tabPageAward.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAward
            // 
            this.btnDeleteAward.Location = new System.Drawing.Point(183, 380);
            this.btnDeleteAward.Name = "btnDeleteAward";
            this.btnDeleteAward.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAward.TabIndex = 6;
            this.btnDeleteAward.Text = "Удалить";
            this.btnDeleteAward.UseVisualStyleBackColor = true;
            this.btnDeleteAward.Click += new System.EventHandler(this.btnDeleteAward_Click);
            // 
            // btnEditAward
            // 
            this.btnEditAward.Location = new System.Drawing.Point(102, 380);
            this.btnEditAward.Name = "btnEditAward";
            this.btnEditAward.Size = new System.Drawing.Size(75, 23);
            this.btnEditAward.TabIndex = 5;
            this.btnEditAward.Text = "Изменить";
            this.btnEditAward.UseVisualStyleBackColor = true;
            this.btnEditAward.Click += new System.EventHandler(this.btnEditAward_Click);
            // 
            // btnAddAward
            // 
            this.btnAddAward.Location = new System.Drawing.Point(21, 380);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(75, 23);
            this.btnAddAward.TabIndex = 4;
            this.btnAddAward.Text = "Добавить";
            this.btnAddAward.UseVisualStyleBackColor = true;
            this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);
            // 
            // dgvAwards
            // 
            this.dgvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwards.Location = new System.Drawing.Point(0, 3);
            this.dgvAwards.Name = "dgvAwards";
            this.dgvAwards.RowTemplate.Height = 25;
            this.dgvAwards.Size = new System.Drawing.Size(725, 371);
            this.dgvAwards.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 484);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPageAward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tabPageAward;
        private System.Windows.Forms.DataGridView dgvAwards;
        private System.Windows.Forms.Button btnDeleteAward;
        private System.Windows.Forms.Button btnEditAward;
        private System.Windows.Forms.Button btnAddAward;
    }
}

