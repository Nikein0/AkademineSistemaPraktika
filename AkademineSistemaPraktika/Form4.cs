using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistemaPraktika
{
    public partial class Form4 : Form
    {
        private int studID;
        public void setID(int studid)
        {
            studID = studid;
        }
        public int getID()
        {
            return studID;
        }
        public Form4(int studID)
        {
            setID(studID);
            InitializeComponent();
        }

        private void button_paz_Click(object sender, EventArgs e)
        {
            string constr1 = "SERVER=localhost;DATABASE=ak.sistema;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(constr1);
            con.Open();
            string seetable = "Select * from pažymiai where studentas_FK = "+getID()+"";
            MySqlCommand cmd = new MySqlCommand(seetable, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;



        }
    }
}
