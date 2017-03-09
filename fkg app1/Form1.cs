using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace fkg_app1
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private SqlDataAdapter adapter;
        private DataSet dsGirls;

        private bool collapsed;

        public Form1()
        {
            InitializeComponent();

            //name of connection string from app.config file
            connectionString = ConfigurationManager.ConnectionStrings["fkg_app1.Properties.Settings.girlsConnectionString"].ConnectionString;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void BGrid_Click(object sender, EventArgs e)
        {
            GridViewForm grid = new GridViewForm();
            grid.Show();
        }


        //populates datagridview on form based on sql command specified
        //needs some cleaning up, will probably move some of the initialization code into the 'load' method
        private void GetData()
        {
            //connecting to database and populating datagridview
            try
            {
                dsGirls = new DataSet();

                string query = @"SELECT Girls.Name, Types.Type, 
                    Girls.NormalHp, Girls.NormalAtk, Girls.NormalDef, Girls.TotalPow, 
                    Girls.AwakeHp, Girls.AwakeAtk, Girls.AwakeDef, Girls.AwakeTotalPow, 
                    Girls.Steps, Girls.BloomAvailable 
                    FROM Girls 
                    INNER JOIN Types ON Girls.Type = Types.Id";

                adapter = new SqlDataAdapter(query, connectionString);

                adapter.Fill(dsGirls, "Girls");

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dsGirls.Tables["Girls"];

                dataGridView1.DataSource = bSource;
                dataGridView1.AutoGenerateColumns = true;

                //set default value for collapsed display mode
                collapsed = true;
                ToggleCollapsed(collapsed);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExpandCollapse_Click(object sender, EventArgs e)
        {
            collapsed = !collapsed;
            ToggleCollapsed(collapsed);
        }

        //called on load and on expand/collapse button click
        //toggles visibility of extra columns
        private void ToggleCollapsed(bool c)
        {
            if (c)
            {
                dataGridView1.Columns["NormalHp"].Visible = false;
                dataGridView1.Columns["NormalAtk"].Visible = false;
                dataGridView1.Columns["NormalDef"].Visible = false;
                dataGridView1.Columns["AwakeHp"].Visible = false;
                dataGridView1.Columns["AwakeAtk"].Visible = false;
                dataGridView1.Columns["AwakeDef"].Visible = false;

                btnExpandCollapse.Text = "Expand";
            }
            else
            {
                dataGridView1.Columns["NormalHp"].Visible = true;
                dataGridView1.Columns["NormalAtk"].Visible = true;
                dataGridView1.Columns["NormalDef"].Visible = true;
                dataGridView1.Columns["AwakeHp"].Visible = true;
                dataGridView1.Columns["AwakeAtk"].Visible = true;
                dataGridView1.Columns["AwakeDef"].Visible = true;

                btnExpandCollapse.Text = "Collapse";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(connectionString, this);
            af.Show();
        }

        public void UpdateTable()
        {
            //calling this method doesn't update datagridview
            //adapter.Update(dsGirls, "Girls");

            //calling this method does
            GetData();
        }
    }
}
