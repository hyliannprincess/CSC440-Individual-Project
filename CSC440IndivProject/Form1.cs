using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using Excel = Microsoft.Office.Interop.Excel;


namespace CSC440IndivProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleCLick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void importGrades_Click(object sender, EventArgs e)
        {

        }


        private void addGrade_Click(object sender, EventArgs e)
        {
            panel1.Show();

        }
        private void submitNewGrade_Click(object sender, EventArgs e)
        {

        }


        private void editGrade_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void deleteGrade_Click(object sender, EventArgs e)
        {
            panel6.Show();
        }
        private void deleteGradeSubmit_Click(object sender, EventArgs e)
        {

        }

        private void printTranscript_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }




    }
}
