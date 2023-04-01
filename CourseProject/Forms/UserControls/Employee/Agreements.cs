using CourseProject.DAL;
using CourseProject.DAL.DAL.EmployeeDal;
using CourseProject.DTO;
using CourseProject.Forms.EmployeeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.UserControls.User
{
    public partial class Agreements : UserControl
    {
        public UserDto User { get; set; }
        public Agreements(UserDto user)
        {
            InitializeComponent();
            User = user;
            labelUser.Text = user.Display;
        }

        private void listBoxAgreements_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private async void buttonAddAgreement_Click(object sender, EventArgs e)
        {
            var add = new AddAgreement();
            if (add.ShowDialog() == DialogResult.OK)
            {
                add.Agreement.UserId = User.Id;
                var db = new EcoparkDbContext();
                var dal = new AgreementDal(db);
                try
                {
                    await dal.AddAgreement(add.Agreement.MapToOrm());
                    Agreements_Load(sender, e);
                    textBoxFilterName_TextChanged(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка бронирования!", "Ошибка");
                }
            }
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            listBoxAgreements.DataSource = new BindingList<AgreementDto>(User.Agreements.Where(i => i.Id.ToString().Contains(textBoxFilterName.Text)).ToList());

        }

        private void Agreements_Load(object sender, EventArgs e)
        {
            textBoxFilterName.Enabled = false;
            listBoxAgreements.DataSource = new BindingList<AgreementDto>(User.Agreements.ToList());
            textBoxFilterName.Enabled = true;    
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            var edit = new AddAgreement((AgreementDto)listBoxAgreements.SelectedItem);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                var db = new EcoparkDbContext();
                var dal = new AgreementDal(db);
                try
                {
                    await dal.UpdateAgreement(edit.Agreement.MapToOrm());
                    Agreements_Load(sender, e);
                    textBoxFilterName_TextChanged(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка бронирования!", "Ошибка");
                }
            }
        }
    }
}
