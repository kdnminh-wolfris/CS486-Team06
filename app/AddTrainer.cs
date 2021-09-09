using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TVVN01_CS486_Team06
{
    public partial class AddTrainer : Form
    {
        public String connectString = @"Data Source=DESKTOP-QR2SNM9;Initial Catalog=CS486_Team06_DB;Integrated Security=True";
        public AddTrainer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();
                String name = tbName.Text;
                String sql = "Exec sp_addTrainer '" + name +  "'";
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AddTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
