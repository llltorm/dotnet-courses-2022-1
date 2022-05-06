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
    public partial class MainForm : Form
    {
/*        enum SortOrder
        {
            Asc,
            Desc
        };

        SortOrder lastNameSort = SortOrder.Asc;*/
        private BindingSource _sourceUser = new BindingSource();
        private BindingSource _sourceAwards = new BindingSource();
        private BindingSource _rewardingUsers = new BindingSource();
        
        private IList<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Aleksandr", LastName = "Petrov", Birthdate =  DateTime.Now.AddYears(-18), Age = 18},
            new User { Id = 2, FirstName = "Oleg", LastName = "Nikitov", Birthdate = DateTime.Now.AddYears(-13),  Age = 13},
            new User { Id = 3, FirstName = "Aleksey", LastName = "Machnev", Birthdate = DateTime.Now.AddYears(-15),  Age = 15},
            new User { Id = 4, FirstName = "Ekaterina", LastName = "Nikolaeva", Birthdate = DateTime.Now.AddYears(-17),  Age = 17}    //new DateTime(2002, 29, 08)},
        };
        private readonly IList<Award> _awards = new List<Award>
        {
            new Award { Id = 1, Title = "diploma for academic success" , Description = "for academic success"},
            new Award { Id = 2, Title = "diploma for sports competitions" , Description = "for sports competitions"},
            new Award { Id = 3, Title = "diploma for activity" , Description = "for activity"},
        };



        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _sourceUser.DataSource = _users;
            _sourceAwards.DataSource = _awards;
            dgvUsers.DataSource = _sourceUser;
            dgvAwards.DataSource = _sourceAwards;

        IList<User> _usersTest = new List<User>
        {
            new User { Id = 1, FirstName = "Aleksandr", LastName = "Petrov", Birthdate =  DateTime.Now.AddYears(-18), Age = 18},
            new User { Id = 2, FirstName = "Oleg", LastName = "Nikitov", Birthdate = DateTime.Now.AddYears(-13),  Age = 13},
            new User { Id = 3, FirstName = "Aleksey", LastName = "Machnev", Birthdate = DateTime.Now.AddYears(-15),  Age = 15},
            new User { Id = 4, FirstName = "Ekaterina", LastName = "Nikolaeva", Birthdate = DateTime.Now.AddYears(-17),  Age = 17}
        };
            _rewardingUsers.DataSource = _usersTest;
            dgvRewardingUsers.DataSource = _rewardingUsers;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(_awards);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                var user = new User();
                user.Id = _users.Count + 1;
                user.FirstName = form.FirstName;
                user.LastName = form.LastName;
                user.Birthdate = form.Birthdate;
                user.Age = form.Age;
                user.Awards = form.Awards;
                _users.Add(user);
                _sourceUser.ResetBindings(false);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (_users.Count > 0)
            {
                var currentUser = _sourceUser.Current as User;
                AddUserForm form = new AddUserForm(currentUser, _awards);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    int localId = form.Id;
                    _users[localId - 1].FirstName = form.FirstName;
                    _users[localId - 1].LastName = form.LastName;
                    _users[localId - 1].Birthdate = form.Birthdate;
                    _users[localId - 1].Age = form.Age;
                    _users[localId - 1].Awards = form.Awards;
                    _sourceUser.ResetBindings(false);
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
/*            if (lastNameSort == SortOrder.Asc)
            {
                lastNameSort = SortOrder.Desc;
                _users = new BindingList<User>(_users.OrderByDescending(u => u.LastName).ToList());
            }
            else
            {
                _users = new BindingList<User>(_users.OrderBy(u => u.LastName).ToList());
                lastNameSort = SortOrder.Asc;
            }
            //ctlGrid.DataSource = list;
            //dgvUsers.DataSource = _sourceUser;
            _sourceUser.ResetBindings(false);
*/
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (_users.Count > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var currentUser = _sourceUser.Current as User;
                    _users.Remove(currentUser);
                    for (int i = currentUser.Id - 1; i < _users.Count; i++)
                    {
                        _users[i].Id--;
                    }
                    _sourceUser.ResetBindings(false);
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            AddAndEditAwardForm form = new AddAndEditAwardForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                var award = new Award();
                award.Id = _awards.Count + 1;
                award.Title = form.Title;
                award.Description = form.Description;
                _awards.Add(award);
                _sourceAwards.ResetBindings(false);
            }
        }

        private void btnEditAward_Click(object sender, EventArgs e)
        {
            if (_awards.Count > 0)
            {
                var currentAward = _sourceAwards.Current as Award;
                AddAndEditAwardForm form = new AddAndEditAwardForm(currentAward);
                string changedName = currentAward.Title;
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    int localId = form.Id;
                    _awards[localId - 1].Title = form.Title;
                    _awards[localId - 1].Description = form.Description;
                    foreach (var item in _users)
                    {
                        if (item.Awards.IndexOf(changedName) != -1)
                        {
                            item.Awards.Remove(changedName);
                            item.Awards.Add(form.Title);
                        }
                    }
                    _sourceAwards.ResetBindings(false);
                }
            }
        }

        private void btnDeleteAward_Click(object sender, EventArgs e)
        {
            if (_awards.Count > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var currentAward = _sourceAwards.Current as Award;
                    foreach (var item in _users)
                    { 
                        item.Awards.Remove(currentAward.Title); 
                    }
                    _awards.Remove(currentAward);
                    for (int i = currentAward.Id - 1; i < _awards.Count; i++)
                    {
                        _awards[i].Id--;
                    }
                    _sourceAwards.ResetBindings(false);
                }
            }
        }
    }
}
