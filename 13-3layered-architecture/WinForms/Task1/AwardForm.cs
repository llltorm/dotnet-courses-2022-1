using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLWinForm
{
    public partial class AwardForm : Form
    {
        private bool checkValidate = true;

        private readonly bool _createNew = true;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public AwardForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public AwardForm(Award award)
        {
            InitializeComponent();
            Id = award.Id;
            Title = award.Title;
            Description = award.Description;
            _createNew = false;
        }

        private void btnSaveAward_Click(object sender, EventArgs e)
        {
            checkValidate = true;
            ValidateChildren();
            if (checkValidate)
            {
                Title = tbTitle.Text;
                Description = tbDescription.Text;
                Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void AwardForm_Load(object sender, EventArgs e)
        {
            tbTitle.Text = Title;
            tbDescription.Text = Description;
            if (_createNew)
            {
                btnSaveAward.Text = "Создать";
            }
            else
            {
                btnSaveAward.Text = "Обновить";
            }
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (tbTitle.Text == string.Empty)
            {
                errorProviderAward.SetError(tbTitle, "Нельзя оставить эту строчку пустой!");
                checkValidate = false;
            }
            else if (tbTitle.Text.Length > 50)
            {
                errorProviderAward.SetError(tbTitle, "Нельзя использовать больше 50 символов");
                checkValidate = false;
            }
            else
            {
                errorProviderAward.Dispose();
            }
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (tbDescription.Text == string.Empty)
            {
                errorProviderAward.SetError(tbDescription, "Нельзя оставить эту строчку пустой!");
                checkValidate = false;
            }
            else if (tbDescription.Text.Length > 250)
            {
                errorProviderAward.SetError(tbDescription, "Нельзя использовать больше 250 символов");
                checkValidate = false;
            }
            else
            {
                errorProviderAward.Dispose();
            }
        }
    }
}
