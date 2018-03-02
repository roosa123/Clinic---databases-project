using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            new DetailedAppointmentForm().Show();
            new AppointmentsForm().Show();
            new PatientForm().Show();
            new ExaminationForm().Show();
            new DetailedLaboratoryForm().Show();
            new LaboratoryForm().Show();
            new UsersForm().Show();
            new DetailedUserForm().Show();
        }
    }
}
