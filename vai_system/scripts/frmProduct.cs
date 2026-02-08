using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Project
{
    public partial class frmProduct : Form
    {
        public string productName;
        public string productType;
        public string productDescription;
        public string productCompany;
        public string productRating;

        public string productURL;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            lblProduct.Text = productName;
            lblType.Text = productType;
            lblDescription.Text = productDescription;
            lblCompany.Text = productCompany;
            lblRating.Text = productRating;
            if (productURL == "") { btnopen.Visible = false; }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(productURL);
        }
    }
}
