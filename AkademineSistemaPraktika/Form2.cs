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
    public partial class Form2 : Form
    {

        
        string uid = "root";
        string password = "";
       
        public Form2()
        {
            InitializeComponent();
        }
        private MySqlConnection GetCon()
        {
            string constr = "SERVER=localhost;DATABASE=ak.sistema;UID=" + uid + ";PASSWORD=" + password + ";";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();

            return con;
        }      

        
        private void AddGrupe_Click(object sender, EventArgs e)
        {
            string createGrupe = "insert into grupes(grupe_pav) values('"+textBoxGrupe.Text+"')";
            MySqlCommand cmd = new MySqlCommand(createGrupe, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Del_grupe_Click(object sender, EventArgs e)
        {
            string deleteGrupe = "Delete from grupes where grupe_ID = "+textBoxTGrupe.Text+"";
            MySqlCommand cmd = new MySqlCommand(deleteGrupe, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Add_dalyka_Click(object sender, EventArgs e)
        {
            string addDalykas = "insert into dalykai(dalykas, grupe_FK) values('"+textBoxDalykasName.Text+"', "+textBoxDalykasAssign.Text+")";
            MySqlCommand cmd = new MySqlCommand(addDalykas, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Del_dalyka_Click(object sender, EventArgs e)
        {
            string delDalykas = "Delete from dalykai where dalyko_ID = "+textBoxDelDalykas.Text+"";
            MySqlCommand cmd = new MySqlCommand(delDalykas, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Dest_Add_Click(object sender, EventArgs e)
        {
            string addDest = "insert into destytojai(Vardas, Pavarde, Telefonas, dalyko_FK) values('"+textBoxDestName.Text+"', '"+textBoxDestPavarde.Text+"', '"+textBoxDestTel.Text+"', "+textBoxDestAssign.Text+")";
            MySqlCommand cmd = new MySqlCommand(addDest, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Dest_del_Click(object sender, EventArgs e)
        {
            string delDest = "Delete from destytojai where dest_ID = "+textBoxDelDest.Text+"";
            MySqlCommand cmd = new MySqlCommand(delDest, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Add_stud_Click(object sender, EventArgs e)
        {
            string addStud = "insert into studentai(Vardas, Pavarde, grupe_FK) values('"+textBoxStudVardas.Text+"', '"+textBoxStudPavarde.Text+"', "+textBoxStudAssign.Text+")";
            MySqlCommand cmd = new MySqlCommand(addStud, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void Del_stud_Click(object sender, EventArgs e)
        {
            string delDalykas = "Delete from studentai where ID = "+textBoxDelStud.Text+"";
            MySqlCommand cmd = new MySqlCommand(delDalykas, GetCon());
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }
    }
}
