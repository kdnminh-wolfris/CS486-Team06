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
    public partial class CurrentStatus : Form
    {
        public String connectString = @"Data Source=DESKTOP-QR2SNM9;Initial Catalog=CS486_Team06_DB;Integrated Security=True";
        public CurrentStatus()
        {
            InitializeComponent();
        }

        public void LoadContestant(int id)
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();


                String sql = "Select * From fn_getContestantsByTrainer(" + id.ToString() + ")";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                connect.Close();
                if (dataSet.Tables.Count > 0)
                {
                    switch (id)
                    {
                        case 1:
                            dgvTeam1.DataSource = dataSet.Tables[0];
                            break;
                        case 2:
                            dgvTeam2.DataSource = dataSet.Tables[0];
                            break;
                        case 3:
                            dgvTeam3.DataSource = dataSet.Tables[0];
                            break;
                        case 4:
                            dgvTeam4.DataSource = dataSet.Tables[0];
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CurrentStatus_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; ++i)
            {
                LoadContestant(i);
            }
        }
    }
}
