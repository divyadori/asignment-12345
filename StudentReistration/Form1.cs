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
using System.IO;

namespace StudentReistration
{
    public partial class Form1 : Form
    {
        string imgPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgPath = @"C:\Users\RICHA\Pictures\Athai Parna" + openFileDialog1.SafeFileName;
                imgStudent.Image = Image.FromFile(openFileDialog1.FileName);
                //MessageBox.Show(imgPath);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dotNet\P6-master\StudentReistration\Database1.mdf;Integrated Security=True";
            string select = "select count(*) from tblStudent";
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            //int i = Convert.ToInt16(cmd.ExecuteScalar());
            //int pkStudent = i + 1;

            string insert = "insert into tblStudent (fName,dob, imgStudent) values ('"+txtFname.Text+"','"+dateDob.Value.Date +"','" + (imgPath==null?"":imgPath) +"' )";
            cmd = new SqlCommand(insert,conn);
            
            //i = cmd.ExecuteNonQuery();
            if(imgPath!=null)
                imgStudent.Image.Save(imgPath);
            MessageBox.Show("You are Done!!!");
            InitializeComponent();
        }
    }
}
