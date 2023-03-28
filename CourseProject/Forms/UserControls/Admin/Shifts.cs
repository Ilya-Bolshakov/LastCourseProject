using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
using CourseProject.DTO;
using CourseProject.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.UserControls.Admin
{
    public partial class Shifts : UserControl
    {
        public IList<ShiftDto> AllShifts { get; set; }
        public BindingList<ShiftDto> CurShifts { get; set; }
        public Shifts()
        {
            InitializeComponent();
        }

        private async void Shifts_Load(object sender, EventArgs e)
        {         
            var task = Task.Run(() =>
            {
                var db = new EcoparkDbContext();
                var shiftDal = new ShiftDal(db);

                AllShifts = shiftDal.GetShifts().Select(u => new ShiftDto(u)).ToList();
                db.Dispose();
                CurShifts = new BindingList<ShiftDto>(AllShifts);
            });
            await task;
            listBoxShifts.DataSource = CurShifts;
            dateTimePicker.Enabled = true;
            buttonEdit.Enabled = true;
        }


        private async void buttonAddShift_Click(object sender, EventArgs e)
        {
            var form = new AddShift();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var db = new EcoparkDbContext();
                var dal = new ShiftDal(db);
                await dal.AddShiftAsync(form.Shift.MapToOrm());
                Shifts_Load(this, e);
                dateTimePicker_ValueChanged(this, e);
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            var form = new AddShift((ShiftDto)listBoxShifts.SelectedItem);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var db = new EcoparkDbContext();
                var dal = new ShiftDal(db);
                await dal.UpdateShiftAsync(form.Shift.MapToOrm());
                Shifts_Load(this, e);
                dateTimePicker_ValueChanged(this, e);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Filter(dateTimePicker.Value);
            
        }

        private void Filter(DateTime dateTime)
        {
            CurShifts = new BindingList<ShiftDto>(AllShifts.Where(u => u.ShiftDate.ToShortDateString() == dateTime.ToShortDateString()).ToList());
            listBoxShifts.DataSource = CurShifts;
        }
    }
}
