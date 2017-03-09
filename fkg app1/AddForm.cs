using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fkg_app1
{
    public partial class AddForm : Form
    {
        private string connectionString;    //connection to sql database


        //used in validating user inputs on form once 'add' button is clicked
        private StringBuilder errorMsg;
        private bool recordValid;

        private Form1 parentForm;

        public AddForm()
        {
            InitializeComponent();
        }

        //taking conn string as a constructor argument helps keep it defined in only one place
        public AddForm(string conn, Form1 parent)
            :this()
        {
            connectionString = conn;
            parentForm = parent;
            //parentForm = (Form1)this.Owner;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            //sets up the 'types' combobox using the 'Types' table in database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Types", connection);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        comboType.Items.Add(rdr["Type"]);
                        comboType.ValueMember = rdr["Id"].ToString();
                        comboType.DisplayMember = rdr["Type"].ToString();
                    }

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //remove 'none' option from box as that is just for error prevention
            comboType.Items.RemoveAt(0);
        }

        //remove this event handler later
        private void lblNDef_Click(object sender, EventArgs e)
        {

        }

        //calculate totalPow stat from user inputs
        private void UpdateTotals()
        {
            //catch exceptions from parsing if user inputs gibberish
            try
            {
                int Hp;
                if (string.IsNullOrWhiteSpace(textNHp.Text)){Hp = 0;}
                else{Hp = Int32.Parse(textNHp.Text);}


                int Atk;
                if(string.IsNullOrWhiteSpace(textNAtk.Text)){Atk = 0;}
                else{Atk = Int32.Parse(textNAtk.Text);}

                int Def;
                if(string.IsNullOrWhiteSpace(textNDef.Text)){Def = 0;}
                else{Def = Int32.Parse(textNDef.Text);}

                int Total = Hp + Atk + Def;

                lblNPow.Text = Total.ToString();
            }
            catch
            {
                lblNPow.Text = "???";
            }

            try
            {
                int Hp;
                if (string.IsNullOrWhiteSpace(textAHp.Text)) { Hp = 0; }
                else { Hp = Int32.Parse(textAHp.Text); }


                int Atk;
                if (string.IsNullOrWhiteSpace(textAAtk.Text)) { Atk = 0; }
                else { Atk = Int32.Parse(textAAtk.Text); }

                int Def;
                if (string.IsNullOrWhiteSpace(textADef.Text)) { Def = 0; }
                else { Def = Int32.Parse(textADef.Text); }

                int Total = Hp + Atk + Def;

                lblAPow.Text = Total.ToString();
            }
            catch
            {
                lblAPow.Text = "???";
            }
        }


        //refreshes 'totalPow' field everytime user leaves textbox
        #region 'Totals' Event Handlers
        private void textNHp_Leave(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void textNAtk_Leave(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void textNDef_Leave(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void textAHp_Leave(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void textAAtk_Leave(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void textADef_Leave(object sender, EventArgs e)
        {
            UpdateTotals();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check validity of entries, insert new record into table


            //check validity of user inputs
            recordValid = true;

            errorMsg = new StringBuilder("Please check these entries:");

            //check 'name' field
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                recordValid = false;
                errorMsg.Append("\nName");
            }

            //check if user selected an option in combobox
            if(comboType.SelectedIndex == -1)
            {
                recordValid = false;
                errorMsg.Append("\nType");
            }


            //stores parsed user inputs
            //will use again during insert
            int NHp, NAtk, NDef, AHp, AAtk, ADef, Steps;

            //check stat entries
            parseInput(textNHp.Text, "\nNormal Hp", out NHp);
            parseInput(textNAtk.Text, "\nNormal Atk", out NAtk);
            parseInput(textNDef.Text, "\nNormal Def", out NDef);
            parseInput(textAHp.Text, "\nAwakened Hp", out AHp);
            parseInput(textAAtk.Text, "\nAwakened Atk", out AAtk);
            parseInput(textADef.Text, "\nAwakened Def", out ADef);
            parseInput(textSteps.Text, "\nSteps", out Steps);


            //insert new record into table
            if (recordValid)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(
                            @"INSERT INTO Girls (
                            Name, Type, NormalHp, NormalAtk, NormalDef, AwakeHp, AwakeAtk, AwakeDef, Steps, BloomAvailable)
                            VALUES (
                            @Name, @Type, @NHp, @NAtk, @NDef, @AHp, @AAtk, @ADef, @Steps, @BloomAvail)", connection);



                        //add parameter values to command
                        cmd.Parameters.Add(new SqlParameter("@Name", textName.Text));
                        cmd.Parameters.Add(new SqlParameter("@Type", comboType.SelectedIndex));
                        cmd.Parameters.Add(new SqlParameter("@NHp", NHp));
                        cmd.Parameters.Add(new SqlParameter("@NAtk", NAtk));
                        cmd.Parameters.Add(new SqlParameter("@NDef", NDef));
                        cmd.Parameters.Add(new SqlParameter("@AHp", AHp));
                        cmd.Parameters.Add(new SqlParameter("@AAtk", AAtk));
                        cmd.Parameters.Add(new SqlParameter("@ADef", ADef));
                        cmd.Parameters.Add(new SqlParameter("@Steps", Steps));
                        cmd.Parameters.Add(new SqlParameter("@BloomAvail", CBoxBloom.Checked));

                        //execute insert command
                        cmd.ExecuteNonQuery();

                        //close window
                        parentForm.UpdateTable();
                        MessageBox.Show("List Updated");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //notify user that one or more entries is not valid
                MessageBox.Show(errorMsg.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close form w/o saving
            this.Close();
        }


        //used during validity checking
        //checks validity of fields that require numbers and appends error message if necessary
        private void parseInput(string source, string message, out int value)
        {
            if(!Int32.TryParse(source, out value))
            {
                recordValid = false;
                errorMsg.Append(message);
            }
        }
    }
}
