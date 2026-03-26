using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data;

namespace Contact_Book
{
    public partial class Form1 : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        bool incorrectLength;
        int ContactNumber;
        string myConnectionString;
        string deletedContact;
        string ContactName;
        string ContactAddress;
        public Form1()
        {
            InitializeComponent();

            myConnectionString = "";// Was unaware of using .env at the creation of this application. 
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = NameBox;
            var number = NumberBox;
            var address = AddressBox;
            TextBox[] boxes = { name, number, address };
            incorrectLength = false;

            if (checkIsAlpha(number.Text))
            {
                number.Text = "Please don't enter any alphabetical characters.";
                number.ForeColor = Color.Red;
                return;
            }
            for (int i = 0; i < boxes.Length; i++)
            {
                checkLength(boxes[i]);
            }
            if (incorrectLength)
            {
                return;
            }
            MySql.Data.MySqlClient.MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = $"SELECT * From contacts WHERE (Contact_Name = \"{name.Text}\" AND Number = {Convert.ToInt32(number.Text)} AND Address = \"{address.Text}\")";
            var result = comm.ExecuteScalar() ?? 0;
            if (result.ToString().Length > 1)
            {
                ExistClose.Visible = true;
                ContactExists.Visible = true;
                ContactExists.Text = "Contact already exists.";
                ContactExistFrame.Visible = true;
            }
            else
            {
                comm.CommandText = $"INSERT INTO contacts VALUES(\"{name.Text.ToString()}\",{Convert.ToInt32(number.Text)},\"{address.Text}\")";
                comm.ExecuteNonQuery();
                ExistClose.Visible = true;
                ContactExists.Visible = true;
                ContactExists.Text = "Contact Created!";
                ContactExistFrame.Visible = true;
            }
        }

        public bool checkIsAlpha(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (Char.IsLetter(number[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public void checkLength(TextBox box)
        {
            if(box.TextLength < 2)
            {
                box.Text = "Please enter more than 2 characters.";
                box.ForeColor = Color.Red;
                incorrectLength = true;
            }
            return;
        }
        private void NumberBox_TextChanged(object sender, EventArgs e)
        {
            NumberBox.ForeColor = Color.Black;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameBox.ForeColor = Color.Black;
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            AddressBox.ForeColor = Color.Black;
        }

        private void NameClear_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
        }

        private void NumberClear_Click(object sender, EventArgs e)
        {
            NumberBox.Text = "";
        }

        private void AddressClear_Click(object sender, EventArgs e)
        {
            AddressBox.Text = "";
        }

        private void ExistClose_Click(object sender, EventArgs e)
        {
            ExistClose.Visible = false;
            ContactExists.Visible = false;
            ContactExists.Text = "Contact already exists.";
            ContactExistFrame.Visible = false;
        }

        private void CloseContactTab_Click(object sender, EventArgs e)
        {
            Contacts.Visible = false;
            RefreshBack.Visible = false;
            RefreshButton.Visible = false;
            ContactBar.Visible = false;
            ContactTab.Visible = false;
            ContactTabBack.Visible = false;
            ContactViewerBorder.Visible = false;
            ContactViewerMain.Visible = false;
            ContactViewerSplit.Visible = false;
            ContactXBack.Visible = false;
            CloseContactTab.Visible = false;
        }

        private void ContactViewer_Click(object sender, EventArgs e)
        {
            CloseContactTab.Visible = true;
            ContactXBack.Visible = true;
            RefreshButton.Visible = true;
            RefreshBack.Visible = true;
            ContactTab.Visible = true;
            ContactTabBack.Visible = true;
            ContactBar.Visible = true;
            ContactViewerSplit.Visible = true;
            Contacts.Visible = true;
            ContactViewerMain.Visible = true;
            ContactViewerBorder.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand read = conn.CreateCommand();
            read.CommandText = "SELECT * FROM contacts";
            MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(read);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Contacts.DataSource = dt;
        }

        private void Contacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            if(Contacts.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
            {
                return;
            }
            if (!String.IsNullOrEmpty(deletedContact))
            {
                if(deletedContact.Contains("Address"))
                {
                    return;
                }
            }
            DeleteContactBorder.BringToFront();
            DeleteContactMain.BringToFront();
            DeleteContactText.BringToFront();
            DeleteNo.BringToFront();
            DeleteYes.BringToFront();
            ContactString.BringToFront();
            ContactString.Visible = true;
            DeleteYes.Visible = true;
            DeleteNo.Visible = true;
            DeleteContactText.Visible = true;
            DeleteContactMain.Visible = true;
            DeleteContactBorder.Visible = true;
            for (int i = 0; i < Contacts.Rows[e.RowIndex].Cells.Count; i++)
            {
                string currentColumn = Contacts.Rows[e.RowIndex].Cells[i].OwningColumn.Name;
                try
                {
                    if (currentColumn == "Contact_Name")
                    {
                        ContactName = Contacts.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                    if (currentColumn == "Number")
                    {
                        ContactNumber = Convert.ToInt32(Contacts.Rows[e.RowIndex].Cells[i].Value);
                    }
                    if (currentColumn == "Address")
                    {
                        ContactAddress = Contacts.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                }
                catch
                {
                    continue;
                }
                deletedContact += $"{Contacts.Rows[e.RowIndex].Cells[i].OwningColumn.Name}: {Contacts.Rows[e.RowIndex].Cells[i].Value}\n";

            }
            ContactString.Text = deletedContact;
        }

        private void DeleteYes_MouseHover(object sender, EventArgs e)
        {
            DeleteYes.BackColor = Color.Red;

        }

        private void DeleteYes_MouseLeave(object sender, EventArgs e)
        {
            DeleteYes.BackColor = Color.DarkGray;
        }

        private void DeleteNo_MouseHover(object sender, EventArgs e)
        {
            DeleteNo.BackColor = Color.Red;
        }

        private void DeleteNo_MouseLeave(object sender, EventArgs e)
        {
            DeleteNo.BackColor = Color.DarkGray;
        }

        private void DeleteNo_Click(object sender, EventArgs e)
        {
            DeleteYes.Visible = false;
            DeleteNo.Visible = false;
            DeleteContactBorder.Visible = false;
            DeleteContactMain.Visible = false;
            DeleteContactText.Visible = false;
            ContactString.Visible = false;
            deletedContact = "";
        }

        private void DeleteYes_Click(object sender, EventArgs e)
        {
            DeleteYes.Visible = false;
            DeleteNo.Visible = false;
            DeleteContactBorder.Visible = false;
            DeleteContactMain.Visible = false;
            DeleteContactText.Visible = false;
            ContactString.Visible = false;
            deletedContact = "";
            if(ContactName is not null)
            {
                MySql.Data.MySqlClient.MySqlCommand delete = conn.CreateCommand();
                delete.CommandText = $"DELETE FROM contacts WHERE (Contact_Name = \"{ContactName}\" AND Number = {ContactNumber} AND Address = \"{ContactAddress}\")";
                delete.ExecuteNonQuery();
            }
        }
    }
}
