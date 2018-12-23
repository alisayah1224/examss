using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlConTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sqlShamsDataSet1.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter1.Fill(this.sqlShamsDataSet1.team);
            // TODO: This line of code loads data into the 'sqlShamsDataSet.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.sqlShamsDataSet.team);
            // TODO: This line of code loads data into the 'sqlShamsDataSet.card' table. You can move, or remove it, as needed.
            this.cardTableAdapter.Fill(this.sqlShamsDataSet.card);
            SqlConnection SqlCon = new SqlConnection("Data Source=DESKTOP-NVL8DKT;Initial Catalog=SqlShams;Integrated Security=True");
            SqlCon.Open();
            string QString = ("Select * from team ");
            SqlCommand SqlCom = new SqlCommand(QString, SqlCon);
            SqlDataReader sqlR = SqlCom.ExecuteReader();
            SqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection("Data Source=DESKTOP-NVL8DKT;Initial Catalog=SqlShams;Integrated Security=True");
            SqlCon.Open();
            string QString = "Insert Into team(name,cover_color) Values('" + TxName.Text + "','" + TxCoverColor.Text + "')";
            SqlCommand SqlCom = new SqlCommand(QString, SqlCon);
            SqlCom.ExecuteNonQuery();
            SqlCon.Close();
        }
    }
}
