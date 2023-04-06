using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class ORVOSOK : Form
    {
        public ORVOSOK()
        {
            InitializeComponent();
        }

        private void ORVOSOK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet7.orvosok' table. You can move, or remove it, as needed.
            this.orvosokTableAdapter.Fill(this.hospitalDataSet7.orvosok);
            panel1.Hide();
            panel2.Hide();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            try
            {
                var orvos_id = Convert.ToInt32(textBox3.Text);
                String nev = textBox1.Text;
                String specializacio = textBox2.Text;
                String telefonszam = textBox4.Text;
                String email = textBox5.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into orvosok values ('" + orvos_id + "','" + nev + "','" + specializacio + "','" + telefonszam + "','" + email + "')";



                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("sikkerult ");


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                dataGridView1.Refresh();
                panel2.Hide();
                panel1.Hide();

            }
            catch (Exception xp)
            {
                MessageBox.Show("Not working");
            }
            panel1.Hide();
        }

        private void felvetel_btn_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox6.Text);



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM orvosok WHERE orvos_id='" + id + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sikeres törlés");
            panel2.Hide();
            panel1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM orvosok WHERE orvos_id='" + id + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];


        }
    }
}
