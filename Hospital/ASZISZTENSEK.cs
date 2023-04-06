using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class ASZISZTENSEK : Form
    {
        public ASZISZTENSEK()
        {
            InitializeComponent();
        }

        private void ASZISZTENSEK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet8.aszisztensek' table. You can move, or remove it, as needed.
            this.aszisztensekTableAdapter.Fill(this.hospitalDataSet8.aszisztensek);
            panel1.Hide();
            panel2.Hide();

        }

        private void felvetel_btn_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM aszisztensek WHERE  aszisztens_id ='" + id + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            dataGridView2.DataSource = DS.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM aszisztensek WHERE aszisztens_id='" + id + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sikeres törlés");
            panel1.Hide();
            panel2.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                var aszisztens_id = Convert.ToInt32(textBox7.Text);
                String nev = textBox3.Text;
                String specializacio = textBox2.Text;
                String telefonszam = textBox4.Text;
                String email = textBox5.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into aszisztensek values ('" + aszisztens_id + "','" + nev + "','" + specializacio + "','" + telefonszam + "','" + email + "')";



                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("sikkerult ");


                textBox6.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                dataGridView1.Refresh();

                panel1.Hide();
                panel2.Hide();

            }
            catch (Exception xp)
            {
                MessageBox.Show("Not working");
            }
            panel1.Hide();
        }
    }
}
