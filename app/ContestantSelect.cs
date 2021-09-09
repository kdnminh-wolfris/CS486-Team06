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
    public partial class ContestantSelect : Form
    {
        public String connectString = @"Data Source=DESKTOP-QR2SNM9;Initial Catalog=CS486_Team06_DB;Integrated Security=True";
        public int selectedID;
        public ContestantSelect()
        {
            InitializeComponent();
        }

        public void LoadTrainer()
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();


                String sql = "Select * From dbo.fn_getAllTrainers() order by TRAINER_ID asc";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                connect.Close();
                if (dataSet.Tables.Count > 0)
                {
                    cbTrainers.DataSource = dataSet.Tables[0];
                    cbTrainers.DisplayMember = "TRAINER_NAME";
                    cbTrainers.ValueMember = "TRAINER_ID";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ContestantSelect_Load(object sender, EventArgs e)
        {
            LoadTrainer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            String performanceID = Perform.performanceID.ToString(), trainerID = cbTrainers.SelectedValue.ToString();
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();

                String sql = "Exec dbo.sp_chooseTrainer " + trainerID + ", " + performanceID;
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                this.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cbTrainers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedID = Int32.Parse(cbTrainers.SelectedValue.ToString());
            if (!Perform.select[selectedID - 1])
            {
                MessageBox.Show("Please choose a chosen trainer");
            }
        }

        private void cbTrainers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
