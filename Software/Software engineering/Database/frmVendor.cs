using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class frmVendor : Form
    {
        public string companyname;
        public string companywebsite;
        public string companyreviewDate;
        public frmVendor()
        {
            InitializeComponent();
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {
            //pass data to the repective label
            lblCompany.Text = companyname;
            lblWebsite.Text = companywebsite;
            lblReview.Text = companyreviewDate;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            //load website using default system browser
            System.Diagnostics.Process.Start(lblWebsite.Text);
        }
    }
}
