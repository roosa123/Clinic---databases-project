using DataLayer;
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
    public partial class ExaminationListForm : BaseForm
    {
        object examination;

        public ExaminationListForm(object examination)
        {
            InitializeComponent();
            this.examination = examination;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //TODO dowload data from DB
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (examination.GetType() == new PhysicalExamination().GetType())
                ;//TODO cast and fill in examination code
            else
                ;//TODO cast and fill in examination code
            Return();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
