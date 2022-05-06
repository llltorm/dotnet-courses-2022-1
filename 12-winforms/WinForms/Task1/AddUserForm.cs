using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class AddUserForm : Form
    {
        private bool checkValidate = true;

        private readonly bool _createNew = true;

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age { get; set; }

        public List<String> Awards = new List<String>();

        //public User LocalUser { get; set; }

        public AddUserForm(IList<Award> award)
        {
            Birthdate = DateTime.Now;
            InitializeComponent();
            foreach (var item in award)
            {
                checkedListBox.Items.Add(item.Title);
            }
        }

        public AddUserForm(User user, IList<Award> award) 
        {
            InitializeComponent();
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Birthdate = user.Birthdate;
            Age = user.Age;
            _createNew = false;
            foreach (var item in award)
            {
                checkedListBox.Items.Add(item.Title);
            }
            foreach (var item in user.Awards)
            {
                if (user.Awards.IndexOf(item) != -1)
                {
                    checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf(item), true);
                }
            }
        }


private void btnSaveUser_Click(object sender, EventArgs e)
        {
            //DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            checkValidate = true;
            ValidateChildren();
            if (checkValidate)
                {
                FirstName = tbFirstName.Text;
                LastName = tbLastName.Text;
                Birthdate = dtpDateOfBirth.Value;
                Age = int.Parse(tbAge.Text);
                var massivAward = checkedListBox.CheckedItems;
                foreach (var index in massivAward)
                {
                    Awards.Add(index.ToString());
                }
                Close();
            }
            else 
            {
                DialogResult = DialogResult.None; 
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = FirstName;
            tbLastName.Text = LastName;
            dtpDateOfBirth.Value = Birthdate;
            tbAge.Text = MyFunction.CalculateAge(Birthdate).ToString();
            if (_createNew)
            {
                btnSaveUser.Text = "Создать";
            }
            else
            {
                btnSaveUser.Text = "Обновить";
            }
        }


        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            tbAge.Text = MyFunction.CalculateAge(dtpDateOfBirth.Value).ToString();
            dtpDateOfBirth.MinDate = new DateTime(1872, 6, 20);
            dtpDateOfBirth.MaxDate = DateTime.Today;
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
/*            if (tbFirstName.Text.Length > 50)
            {
                e.Handled = true;
            }*/
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text == string.Empty)
            {
                errorProviderUser.SetError(tbFirstName, "Нельзя оставить эту строчку пустой!");
                checkValidate = false;
            }
            else if (tbFirstName.Text.Length > 50)
            {
                errorProviderUser.SetError(tbFirstName, "Нельзя использовать больше 50 символов");
                checkValidate = false;
            }
            else
            {
                errorProviderUser.Dispose();
            }
        }
/*        private void Сommon_Validating(TextBox textBox, int countСharacters)
        {
            if (textBox.Text == string.Empty)
            {
                errorProvider.SetError(textBox, "Нельзя оставить эту строчку пустой!");
                checkValidate = false;
            }
            else if (textBox.Text.Length > countСharacters)
            {
                errorProvider.SetError(textBox, $"Нельзя использовать больше {countСharacters} символов");
                checkValidate = false;
            }
            else
            {
                errorProvider.Dispose();
            }
        }*/

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.Text == string.Empty)
            {
                errorProviderUser.SetError(tbLastName, "Нельзя оставить эту строчку пустой!");
                checkValidate = false;
            }
            else if (tbLastName.Text.Length > 50)
            {
                errorProviderUser.SetError(tbLastName, "Нельзя использовать больше 50 символов");
                checkValidate = false;
            }
            else
            {
                errorProviderUser.Dispose();
            }
        }

    }
}
