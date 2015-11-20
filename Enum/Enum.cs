using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum
{
    public partial class frmEnum : Form
    {
        // global variables
        enum DAYS
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
         
        public frmEnum()
        {
            InitializeComponent();
        }

        private void frmEnum_Load(object sender, EventArgs e)
        {

        }
        private void lstWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            // say what item you selected
            string selectValue;

            selectValue = Convert.ToString(lstWeek.SelectedItem);

            MessageBox.Show("Your favourite day of the week is " + selectValue);
        }
    }
}
