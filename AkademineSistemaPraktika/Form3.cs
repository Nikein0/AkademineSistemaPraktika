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
using static AkademineSistemaPraktika.Class1;
namespace AkademineSistemaPraktika
{
    public partial class Form3 : Form
    {
        //Class1 klase = new Class1();
        private int dalykass;
        public void SetDalykas(int dalykas)
        {
            dalykass = dalykas;
        }
        public int GetDalykas()
        {
            return dalykass;
        }
        public Form3(int dalykas)
        {
            SetDalykas(dalykas);
            InitializeComponent();
        }
        private MySqlConnection GetCon()
        {
            string constr = "SERVER=localhost;DATABASE=ak.sistema;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();

            return con;
        }
        private void Vesti_pazymi_Click(object sender, EventArgs e)
        {
            //label1.Text = GetDalykas().ToString();
            
            string sql = "SELECT * from studentai";
            
            MySqlCommand cmd1 = new MySqlCommand(sql, GetCon());
            MySqlDataReader reader = cmd1.ExecuteReader();
            string addStud = "insert into pažymiai(Pažimys, dalykas_FK, studentas_FK) values("+textBoxStudPazimys.Text+","+GetDalykas()+","+textBoxStudID.Text+")";
            MySqlCommand cmd = new MySqlCommand(addStud, GetCon());

            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Keisti_paz_Click(object sender, EventArgs e)
        {
            
        }
    }
}
