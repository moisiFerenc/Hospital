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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // Adatbázis kapcsolat beállítása
            SqlConnection conn = new SqlConnection("data source = DESKTOP-7P2NQMC\\SQLEXPRESS;database = hospital;integrated security=True");

            // SQL lekérdezés futtatása
            string query = "SELECT nev, email, telefonszam, 'alkalmazott' AS pozicio FROM alkalmazottak " +
                           "UNION " +
                           "SELECT nev, email, telefonszam, 'orvos' AS pozicio FROM orvosok " +
                           "UNION " +
                           "SELECT nev, email, telefonszam, 'aszisztens' AS pozicio FROM aszisztensek";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            // DataGridView feltöltése adatokkal
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void ORVOS_felvetel_gomb_Click(object sender, EventArgs e)
        {
            ORVOSOK oRVOSOK = new ORVOSOK();
            oRVOSOK.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BESZALITOK bESZALITOK = new BESZALITOK();
            bESZALITOK.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASZISZTENSEK aSZISZTENSEK = new ASZISZTENSEK();
            aSZISZTENSEK.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet15.alkalmazottak' table. You can move, or remove it, as needed.
            this.alkalmazottakTableAdapter.Fill(this.hospitalDataSet15.alkalmazottak);

        }
    }
}
