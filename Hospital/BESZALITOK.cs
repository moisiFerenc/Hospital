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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class BESZALITOK : Form
    {
        public BESZALITOK()
        {
            InitializeComponent();
        }

        private void BESZALITOK_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'hospitalDataSet11.beszallitok' table. You can move, or remove it, as needed.
            this.beszallitokTableAdapter1.Fill(this.hospitalDataSet11.beszallitok);
            // TODO: This line of code loads data into the 'hospitalDataSet10.beszallitok' table. You can move, or remove it, as needed.
            this.beszallitokTableAdapter.Fill(this.hospitalDataSet10.beszallitok);

            panel1.Hide();
            panel2.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var beszalito_id = Convert.ToInt32(textBox7.Text);
                String nev = textBox3.Text;
                String cim = textBox2.Text;
                String telefonszam = textBox4.Text;
                String email = textBox5.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into beszallitok values ('" + beszalito_id + "','" + nev + "','" + cim + "','" + telefonszam + "','" + email + "')";



                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("sikkerult ");


                textBox7.Clear();
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM beszallitok WHERE beszallito_id='" + id + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM beszallitok WHERE beszallito_id='" + id + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sikeres törlés");
            panel2.Hide();
            panel1.Hide();
        }
    }
}
