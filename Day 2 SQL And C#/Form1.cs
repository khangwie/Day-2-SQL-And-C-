using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_2_SQL_And_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.MoveLast();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentDataSet.tbStudent' table. You can move, or remove it, as needed.
            this.tbStudentTableAdapter.Fill(this.dbStudentDataSet.tbStudent);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.EndEdit();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
