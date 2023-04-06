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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            beteg_felvetel_panel.Visible = true;
            diagnozis_panel.Visible = true;
        }


        private void beteg_felvetel_gomb_Click(object sender, EventArgs e)
        {
            beteg_felvetel_gomb.BackColor = Color.Green;
            diagnozis.BackColor = Color.Black;
            beteg_elozmeny.BackColor = Color.Black;
            korhaz_informacioi.BackColor = Color.Black;

            beteg_felvetel_panel.Visible = true;
            diagnozis_panel.Visible = false;


        }

        private void diagnozis_Click(object sender, EventArgs e)
        {
            beteg_felvetel_gomb.BackColor = Color.Black;
            diagnozis.BackColor = Color.Green;
            beteg_elozmeny.BackColor = Color.Black;
            korhaz_informacioi.BackColor = Color.Black;

            beteg_felvetel_panel.Visible = false;
            diagnozis_panel.Visible = true;
        }

        private void beteg_elozmeny_Click(object sender, EventArgs e)
        {

            Form2 ds = new Form2();
            ds.Show();
        }



        private void korhaz_informacioi_Click(object sender, EventArgs e)
        {
            Form3 ds = new Form3();
            ds.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String Name = name.Text;
                String Adress = adress.Text;
                Int64 Contact = Convert.ToInt64(phone.Text);
                int Age = Convert.ToInt32(age.Text);
                String Gender = gender.Text;
                String Blood = blood.Text;
                String any = majordisase.Text;
                int ID = Convert.ToInt32(id.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into AddPatient values ('" + Name + "','" + Adress + "','" + Contact + "','" + Age + "','" + Gender + "','" + Blood + "','" + any + "','" + ID + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("sikkerult ");
            }
            catch (Exception ex) {
                MessageBox.Show(" nem sikkerult ");
            }
            
            name.Clear();
            adress.Clear();
            phone.Clear();
            age.Clear();
            gender.ResetText();
            blood.ResetText();
            majordisase.Clear();
            id.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {
            textBox1_TabIndexChanged(sender, e, dataGridView1);
        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e, DataGridView dataGridView1)
        {
            if (textBox1.Text != "") { 
                int pid = Convert.ToInt32(textBox1.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS; database =hospital;integradet security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet5.aszisztensek' table. You can move, or remove it, as needed.
            this.aszisztensekTableAdapter1.Fill(this.hospitalDataSet5.aszisztensek);
            // TODO: This line of code loads data into the 'hospitalDataSet4.beszallitok' table. You can move, or remove it, as needed.
            this.beszallitokTableAdapter.Fill(this.hospitalDataSet4.beszallitok);
            // TODO: This line of code loads data into the 'hospitalDataSet3.aszisztensek' table. You can move, or remove it, as needed.
            this.aszisztensekTableAdapter.Fill(this.hospitalDataSet3.aszisztensek);
            // TODO: This line of code loads data into the 'hospitalDataSet2.orvosok' table. You can move, or remove it, as needed.
            this.orvosokTableAdapter.Fill(this.hospitalDataSet2.orvosok);
            // TODO: This line of code loads data into the 'hospitalDataSet11.AddPatient' table. You can move, or remove it, as needed.
            this.addPatientTableAdapter1.Fill(this.hospitalDataSet11.AddPatient);
            // TODO: This line of code loads data into the 'hospitalDataSet.AddPatient' table. You can move, or remove it, as needed.
            //this.addPatientTableAdapter.Fill(this.hospitalDataSet.AddPatient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ipd = Convert.ToInt32(textBox1.Text);
                String sympt = textBox2.Text;
                String diag = textBox3.Text;
                String medicine = textBox4.Text;
                String ward = comboBox1.Text;
                String wardType = comboBox2.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True";

                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore values ('" + ipd + "','" + sympt + "','" + diag + "','" + medicine + "','" + ward + "','" + wardType + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("sikerult");
            }
            catch (Exception xp) {
                MessageBox.Show("Not working");
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }
    }
}
