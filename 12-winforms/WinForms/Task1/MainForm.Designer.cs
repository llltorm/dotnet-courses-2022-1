
namespace Task1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageRewardingUsers = new System.Windows.Forms.TabPage();
            this.tabPageAward = new System.Windows.Forms.TabPage();
            this.dgvAwards = new System.Windows.Forms.DataGridView();
            this.btnAddAward = new System.Windows.Forms.Button();
            this.btnEditAward = new System.Windows.Forms.Button();
            this.btnDeleteAward = new System.Windows.Forms.Button();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dgvRewardingUsers = new System.Windows.Forms.DataGridView();
            this.tabPageRewardingUsers.SuspendLayout();
            this.tabPageAward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).BeginInit();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewardingUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageRewardingUsers
            // 
            this.tabPageRewardingUsers.Controls.Add(this.dgvRewardingUsers);
            this.tabPageRewardingUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageRewardingUsers.Name = "tabPageRewardingUsers";
            this.tabPageRewardingUsers.Size = new System.Drawing.Size(735, 415);
            this.tabPageRewardingUsers.TabIndex = 2;
            this.tabPageRewardingUsers.Text = "Награждение пользователей";
            this.tabPageRewardingUsers.UseVisualStyleBackColor = true;
            // 
            // tabPageAward
            // 
            this.tabPageAward.Controls.Add(this.btnDeleteAward);
            this.tabPageAward.Controls.Add(this.btnEditAward);
            this.tabPageAward.Controls.Add(this.btnAddAward);
            this.tabPageAward.Controls.Add(this.dgvAwards);
            this.tabPageAward.Location = new System.Drawing.Point(4, 22);
            this.tabPageAward.Name = "tabPageAward";
            this.tabPageAward.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAward.Size = new System.Drawing.Size(735, 415);
            this.tabPageAward.TabIndex = 1;
            this.tabPageAward.Text = "Награды";
            this.tabPageAward.UseVisualStyleBackColor = true;
            // 
            // dgvAwards
            // 
            this.dgvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwards.Location = new System.Drawing.Point(-4, 18);
            this.dgvAwards.Name = "dgvAwards";
            this.dgvAwards.Size = new System.Drawing.Size(743, 362);
            this.dgvAwards.TabIndex = 1;
            this.dgvAwards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnAddAward
            // 
            this.btnAddAward.Location = new System.Drawing.Point(5, 386);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(75, 23);
            this.btnAddAward.TabIndex = 4;
            this.btnAddAward.Text = "Добавить";
            this.btnAddAward.UseVisualStyleBackColor = true;
            this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);
            // 
            // btnEditAward
            // 
            this.btnEditAward.Location = new System.Drawing.Point(86, 386);
            this.btnEditAward.Name = "btnEditAward";
            this.btnEditAward.Size = new System.Drawing.Size(75, 23);
            this.btnEditAward.TabIndex = 5;
            this.btnEditAward.Text = "Изменить";
            this.btnEditAward.UseVisualStyleBackColor = true;
            this.btnEditAward.Click += new System.EventHandler(this.btnEditAward_Click);
            // 
            // btnDeleteAward
            // 
            this.btnDeleteAward.Location = new System.Drawing.Point(167, 386);
            this.btnDeleteAward.Name = "btnDeleteAward";
            this.btnDeleteAward.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAward.TabIndex = 6;
            this.btnDeleteAward.Text = "Удалить";
            this.btnDeleteAward.UseVisualStyleBackColor = true;
            this.btnDeleteAward.Click += new System.EventHandler(this.btnDeleteAward_Click);
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.btnDeleteUser);
            this.tabPageUser.Controls.Add(this.dgvUsers);
            this.tabPageUser.Controls.Add(this.btnAddUser);
            this.tabPageUser.Controls.Add(this.btnEditUser);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(735, 415);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "Пользователи";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(86, 386);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Изменить";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(5, 386);
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
            this.dgvUsers.Location = new System.Drawing.Point(-4, 19);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(739, 361);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_ColumnHeaderMouseClick);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(167, 386);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Удалить";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUser);
            this.tabControl.Controls.Add(this.tabPageAward);
            this.tabControl.Controls.Add(this.tabPageRewardingUsers);
            this.tabControl.Location = new System.Drawing.Point(12, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(743, 441);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // dgvRewardingUsers
            // 
            this.dgvRewardingUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRewardingUsers.Location = new System.Drawing.Point(5, 18);
            this.dgvRewardingUsers.Name = "dgvRewardingUsers";
            this.dgvRewardingUsers.Size = new System.Drawing.Size(528, 367);
            this.dgvRewardingUsers.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 497);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageRewardingUsers.ResumeLayout(false);
            this.tabPageAward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).EndInit();
            this.tabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewardingUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageRewardingUsers;
        private System.Windows.Forms.TabPage tabPageAward;
        private System.Windows.Forms.Button btnDeleteAward;
        private System.Windows.Forms.Button btnEditAward;
        private System.Windows.Forms.Button btnAddAward;
        private System.Windows.Forms.DataGridView dgvAwards;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView dgvRewardingUsers;
    }
}

