using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
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
        public IEnumerable<Shift> MyProperty { get; set; }
        public Shifts()
        {
            InitializeComponent();
        }

        private void Shifts_Load(object sender, EventArgs e)
        {
            var db = new EcoparkDbContext();

            var shiftDal = new ShiftDal(db);
        }
    }
}
