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
    public partial class TheVoice : Form
    {
        public String connectString = @"Data Source=DESKTOP-QR2SNM9;Initial Catalog=CS486_Team06_DB;Integrated Security=True";
        public int currentNumOfTrainer = 0;
        public TheVoice()
        {
            InitializeComponent();
        }

        private void Exit_Click()
        {
            DialogResult dialog =
                MessageBox.Show("Do you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void showCurrentMembersOfEachTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentStatus current = new CurrentStatus();
            current.Show();
        }

        private void addATrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentNumOfTrainer >=4)
            {
                MessageBox.Show("Only four trainers");
            }
            else
            {
                AddTrainer add = new AddTrainer();
                add.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit_Click();
        }

        private void TheVoice_Load(object sender, EventArgs e)
        {
            rtbInfo.Text = "This is an application to maintain database of The Voice 2021" +
                "You are allowed to add a trainer (maximun is 4 trainers), a performance" +
                "Start a performance :" +
                "- Select a performace to perform" +
                "- Each trainer can choose the performance and give feedbakc to the contestant" +
                "- The contestant can select the trainer";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Perform perform = new Perform();
            perform.Show();
        }

        private void addAPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerformance addPerformance = new AddPerformance();
            addPerformance.Show();
        }
    }
}
