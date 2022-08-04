using System.Drawing;
using System.Data;
using System.Data.OleDb;

namespace PruebaConexionDBF
{
    public partial class Form : System.Windows.Forms.Form
    {
     
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = nameTabla.Text;
                //string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\;Extended Properties=dBASE IV;User ID=Admin;Password=;";
                using (OleDbConnection con = new OleDbConnection(@$"Provider=VFPOLEDB.1;Data Source=C:\Users\hp\Documents\Visual FoxPro Projects\CONTPAQi Factura electronica\270722 PRUEBA 4\Prueba dia 15\{tabla}.dbf"))
                {
                    var sql = $"select * from {tabla}.dbf";
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    con.Open();
                    DataSet ds = new DataSet(); ;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0];
                }

            }
            catch(OleDbException exp)
            {
                MessageBox.Show("Error: "+ exp.Message);
            }



        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void labelMensaje_Click(object sender, EventArgs e)
        {

        }

        private void nameTable_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}