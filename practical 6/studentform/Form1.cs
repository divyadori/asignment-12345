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

namespace studentform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // imgPath = @"C:\Users\Dell\Pictures\" + openFileDialog1.SafeFileName;
               // imgStudent.Image = Image.FromFile(openFileDialog1.FileName);
                //MessageBox.Show(imgPath);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //imgPath = @"C:\Users\Dell\Pictures\" + openFileDialog1.SafeFileName;
               // imgStudent.Image = Image.FromFile(openFileDialog1.FileName);
                //MessageBox.Show(imgPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string source = @"Data Source=Dell-\Database1.mdf;Initial Catalog=temp1;Integrated Security=True";
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\studentform\studentform\Database1.mdf;Integrated Security=True";
            string select = "select count(*) from [dbo].[Table]";
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            //int i = Convert.ToInt16(cmd.ExecuteScalar());
           // int pkStudent = i + 1;

            string insert = "insert into [dbo].[Table] (name, enrollment,gender,address,phoneno) values ( " + txtname.Text + ",'" + textBox2.Text + "','" +radioButton1.Text + "','" + richTextBox1.Text+ "','" + textBox3.Text+ "' )";
            cmd = new SqlCommand(insert, conn);

            // i = cmd.ExecuteNonQuery();
            //  if (imgPath != null)
            //    imgStudent.Image.Save(imgPath);
            Console.WriteLine(insert);
            Console.ReadLine();
            MessageBox.Show("You are Done!!!");
            MessageBox.Show((String)cmd);

            InitializeComponent();
        }
    }
}
