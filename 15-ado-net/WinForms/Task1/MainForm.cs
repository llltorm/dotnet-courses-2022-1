using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Entities;
using Interfaces;

namespace PLWinForm
{
    public partial class MainForm : Form
    {

        private IUserBL _userBL;
        private IAwardBL _awardBL;

        private BindingSource _sourceUser = new BindingSource();
        private BindingSource _sourceAwards = new BindingSource();
        private BindingSource _rewardingUsers = new BindingSource();


        public MainForm(IUserBL userBL, IAwardBL awardBL)
        {
            _userBL = userBL;
            _awardBL = awardBL;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _sourceUser.DataSource = _userBL.GetAll();  //_users;
            _sourceAwards.DataSource = _awardBL.GetAll();
            dgvUsers.DataSource = _sourceUser;
            dgvAwards.DataSource = _sourceAwards;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm(_awardBL.GetAll());
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _userBL.AddUser(form.FirstName, form.LastName, form.Birthdate, form.Age, form.Awards);
                _sourceUser.ResetBindings(false);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (_userBL.CountUser() > 0)
            {
                var currentUser = _sourceUser.Current as User;
                UserForm form = new UserForm(currentUser, _awardBL.GetAll());
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    _userBL.EditUser(form.Id, form.FirstName, form.LastName, form.Birthdate, form.Age, form.Awards);
                    _sourceUser.ResetBindings(false);
                } 
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (_userBL.CountUser() > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var currentUser = _sourceUser.Current as User;
                    _userBL.DeleteUser(currentUser);
                    _sourceUser.ResetBindings(false);
                }
            }
        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            AwardForm form = new AwardForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _awardBL.AddAward(form.Title, form.Description);
                _sourceAwards.ResetBindings(false);
            }
        }

        private void btnEditAward_Click(object sender, EventArgs e)
        {
            if (_awardBL.CountAward() > 0)
            {
                var currentAward = _sourceAwards.Current as Award;
                AwardForm form = new AwardForm(currentAward);
                string changedName = currentAward.Title;
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    _awardBL.EditAward(form.Id, form.Title, form.Description);
                    _userBL.EditAwardFromUser(changedName, form.Title);
                    _sourceAwards.ResetBindings(false);
                    _sourceUser.ResetBindings(false);
                }
            }
        }

        private void btnDeleteAward_Click(object sender, EventArgs e)
        {
            if (_awardBL.CountAward() > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var currentAward = _sourceAwards.Current as Award;
                    _awardBL.DeleteAward(currentAward);
                    _userBL.DeleteAwardFromUser(currentAward.Title);
                    _sourceAwards.ResetBindings(false);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
