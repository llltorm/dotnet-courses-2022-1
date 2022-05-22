
namespace PLWinForm
{
    partial class AwardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderAward = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnSaveAward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAward)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименолвание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание:";
            // 
            // errorProviderAward
            // 
            this.errorProviderAward.ContainerControl = this;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(129, 19);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(307, 23);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitle_KeyPress);
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(129, 58);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(307, 135);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescription_KeyPress);
            this.tbDescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescription_Validating);
            // 
            // btnSaveAward
            // 
            this.btnSaveAward.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveAward.Location = new System.Drawing.Point(199, 199);
            this.btnSaveAward.Name = "btnSaveAward";
            this.btnSaveAward.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAward.TabIndex = 4;
            this.btnSaveAward.Text = "сохранить";
            this.btnSaveAward.UseVisualStyleBackColor = true;
            this.btnSaveAward.Click += new System.EventHandler(this.btnSaveAward_Click);
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 232);
            this.Controls.Add(this.btnSaveAward);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AwardForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AwardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderAward;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnSaveAward;
    }
}