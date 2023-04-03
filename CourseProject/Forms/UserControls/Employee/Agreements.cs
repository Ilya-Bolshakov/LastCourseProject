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
        public BindingList<AgreementDto> Binding { get; set; }
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
                    var agr = add.Agreement.MapToOrm();
                    agr.House = db.House.Where(h => h.IDHouse == add.Agreement.HouseId).ToList();
                    await dal.AddAgreement(agr);
                    User.Agreements.Add(add.Agreement);
                    Binding.Add(add.Agreement);
                    listBoxAgreements.Refresh();
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
            var q = new BindingList<AgreementDto>(User.Agreements.Where(a => a.HouseId != null).ToList());
            Binding = new BindingList<AgreementDto>(q.Where(i => i.Id.ToString().Contains(textBoxFilterName.Text)).ToList());
            listBoxAgreements.DataSource = Binding;

        }

        private void Agreements_Load(object sender, EventArgs e)
        {
            textBoxFilterName.Enabled = false;
            Binding = new BindingList<AgreementDto>(User.Agreements.Where(a => a.HouseId != null).ToList());
            listBoxAgreements.DataSource = Binding;
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
                    var item = Binding.First(b => b.Id == edit.Agreement.Id);
                    item.Start = edit.Agreement.Start;
                    item.Finish = edit.Agreement.Finish;
                    item.Price = edit.Agreement.Price;
                    item.HouseId = edit.Agreement.HouseId;
                    listBoxAgreements.Refresh();
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
