using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Sample1 values('" + textBox1.Text + "','" + textBox2.Text + "','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
        }

        private void UPLOAD_Click(object sender, EventArgs e)
        {
            Byte[] mypic = File.ReadAllBytes(openFileDialog1.FileName);
            SqlCommand cmd1 = new SqlCommand("insert into storeimage(id,photo)values('1',@pic)", con);
            SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, mypic.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mypic);
            cmd1.Parameters.Add(prm);
            cmd1.ExecuteNonQuery();
            con.Close();
        }
    }
}
