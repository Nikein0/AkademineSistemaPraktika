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
    public partial class Form1 : Form
    {
        Class1 klase = new Class1();
        /*private int choice;
        private int destdalykas;

        public void setDalykas(int dalykas)
        {
            destdalykas = dalykas;
        }
        public int GetDalykas()
        {
            return destdalykas;
        }
        public void SetChoice(int Choice)
        {
            choice = Choice;
        }
        public int GetChoice()
        {
            return choice;
        }*/
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void OpenSecondForm(int choice)
        {
            if (choice == 0)
            {
                this.Hide();
                Form form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            else if (choice == 1)
            {
                this.Hide();
                Form form3 = new Form3(klase.GetDalykas());
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Form form4 = new Form4(klase.GetStudID());
                form4.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) //Login
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool wronglogin = false;
            if (klase.GetChoice() == 1)
            {
                try
                {
                    string constr = "SERVER=localhost;DATABASE=ak.sistema;UID=" + username + ";PASSWORD=" + password + ";";

                    MySqlConnection con = new MySqlConnection(constr);
                    con.Open();
                    string query = "select * from grupes";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                }
                catch
                {
                    label1.Visible = true;
                    wronglogin = true;
                }
            }
            else if(klase.GetChoice() == 2)
            {
                try
                {
                    string sql = "SELECT * from destytojai";
                    string constr1 = "SERVER=localhost;DATABASE=ak.sistema;UID=root;PASSWORD=;";
                    MySqlConnection con = new MySqlConnection(constr1);
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (textBox1.Text == reader.GetString("Vardas") && textBox2.Text == reader.GetString("Pavarde"))
                        {
                            klase.setDalykas(reader.GetInt16("dalyko_FK"));
                            wronglogin = false;
                            break;
                        }
                        else
                        {
                            wronglogin=true;
                        }
                    }
                }
                catch
                {
                    label1.Visible = true;
                    wronglogin = true;
                }
            }
            else
            {
                string sql = "SELECT * from studentai";
                string constr1 = "SERVER=localhost;DATABASE=ak.sistema;UID=root;PASSWORD=;";
                MySqlConnection con = new MySqlConnection(constr1);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (textBox1.Text == reader.GetString("Vardas") && textBox2.Text == reader.GetString("Pavarde"))
                    {
                        klase.setStudID(reader.GetInt16("ID"));
                        wronglogin = false;
                        break;
                    }
                    else
                    {
                        wronglogin = true;
                    }
                }
            }
            if (wronglogin == false)
            {
                if (klase.GetChoice() == 1)
                {
                    //for (int i = 0; i < ; i++)
                    //{

                    //}
                    OpenSecondForm(0);
                }
                else if (klase.GetChoice() == 2)
                {
                    OpenSecondForm(1);
                }
                else
                {
                    OpenSecondForm(2);
                }
            }
            
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Login_Button.Visible = true;
            
            klase.SetChoice(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Login_Button.Visible = true;
            
            klase.SetChoice(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Login_Button.Visible = true;
            
            klase.SetChoice(3);
        }
    }
}
