using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fkg_app1
{
    public partial class GridViewForm : Form
    {
        public GridViewForm()
        {
            InitializeComponent();
        }

        private void GridViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'girlsDataSet.Girls' table. You can move, or remove it, as needed.
            this.girlsTableAdapter.Fill(this.girlsDataSet.Girls);

        }
    }
}
