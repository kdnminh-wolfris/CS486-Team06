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
    public partial class Perform : Form
    {
        public String connectString = @"Data Source=DESKTOP-QR2SNM9;Initial Catalog=CS486_Team06_DB;Integrated Security=True";
        public static String performanceID;
        public static Boolean[] select = new Boolean[4];
        public Perform()
        {
            InitializeComponent();
        }

        public void LoadPerformance()
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();


                String sql = "Select * From dbo.fn_getAllPerFormances()";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                connect.Close();
                if (dataSet.Tables.Count > 0)
                {
                    cbPerformance.DataSource = dataSet.Tables[0];
                    cbPerformance.DisplayMember = "PERFORMANCE_INFO";
                    cbPerformance.ValueMember = "PERFORMANCE_ID";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void LoadTrainer()
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();


                String sql = "Select name from Trainer order by id asc";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                connect.Close();
                if (dataSet.Tables.Count > 0)
                {
                    cbTrainer1.Text = dataSet.Tables[0].Rows[0].Field<String>(0);
                    cbTrainer2.Text = dataSet.Tables[0].Rows[1].Field<String>(0);
                    cbTrainer3.Text = dataSet.Tables[0].Rows[2].Field<String>(0);
                    cbTrainer4.Text = dataSet.Tables[0].Rows[3].Field<String>(0);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void addFeedback(int ID, String feedBack, Boolean isSelect)
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = connectString;
                connect.Open();
                if (feedBack == null) feedBack = " asd ";
                int select = 0;
                if (isSelect) select = 1;
                String sql = "Exec dbo.sp_addFeedback " + performanceID + ", " + ID.ToString() + ", '" + feedBack + "', " + select.ToString();
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void Perform_Load(object sender, EventArgs e)
        {
            LoadPerformance();
            LoadTrainer();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            addFeedback(1, rtbFeedback1.Text, cbTrainer1.Checked);
            select[0] = cbTrainer1.Checked;
            addFeedback(2, rtbFeedback2.Text, cbTrainer2.Checked);
            select[1] = cbTrainer2.Checked;
            addFeedback(3, rtbFeedback3.Text, cbTrainer3.Checked);
            select[2] = cbTrainer3.Checked;
            addFeedback(4, rtbFeedback4.Text, cbTrainer4.Checked);
            select[3] = cbTrainer4.Checked;
            ContestantSelect contestantSelect = new ContestantSelect();
            contestantSelect.Show();
        }

        private void cbPerformance_SelectionChangeCommitted(object sender, EventArgs e)
        {
            performanceID = cbPerformance.SelectedValue.ToString();
        }
    }
}
