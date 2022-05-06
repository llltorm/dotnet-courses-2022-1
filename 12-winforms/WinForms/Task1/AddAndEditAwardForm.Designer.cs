
namespace Task1
{
    partial class AddAndEditAwardForm
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
            this.btnSaveAward = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderAward = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAward)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveAward
            // 
            this.btnSaveAward.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveAward.Location = new System.Drawing.Point(221, 197);
            this.btnSaveAward.Name = "btnSaveAward";
            this.btnSaveAward.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAward.TabIndex = 13;
            this.btnSaveAward.Text = "сохранить";
            this.btnSaveAward.UseVisualStyleBackColor = true;
            this.btnSaveAward.Click += new System.EventHandler(this.btnSaveAward_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(148, 63);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(280, 128);
            this.tbDescription.TabIndex = 12;
            this.tbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescription_KeyPress);
            this.tbDescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescription_Validating);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(148, 34);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(280, 20);
            this.tbTitle.TabIndex = 11;
            this.tbTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitle_KeyPress);
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование:";
            // 
            // errorProviderAward
            // 
            this.errorProviderAward.ContainerControl = this;
            // 
            // AddAndEditAwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 232);
            this.Controls.Add(this.btnSaveAward);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAndEditAwardForm";
            this.Text = "AddAndEditAwardForm";
            this.Load += new System.EventHandler(this.AddAndEditAwardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAward;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderAward;
    }
}