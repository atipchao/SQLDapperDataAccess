using SQLDapperDataAccess.Data;
using SQLDapperDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDapperDataAccess
{
    public partial class DashBoard : Form
    {
        List<Customer> customers = new List<Customer>();
        public DashBoard()
        {
            InitializeComponent();
            CustListBox.DataSource = customers;  // Basically we say.. DataSource = the list.
            CustListBox.DisplayMember = "FullInfo";
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            DataAccess _db = new DataAccess();
            customers =  _db.GetCusts(LastNameText.Text);
            CustListBox.DataSource = customers;  // Basically we say.. DataSource = the list.
            CustListBox.DisplayMember = "FullInfo";

        }
    }
}
