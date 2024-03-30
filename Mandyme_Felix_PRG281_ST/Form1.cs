using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandyme_Felix_PRG281_ST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingSource study = new BindingSource();
        List<Student> myStudents = new List<Student>();

        private void button7_Click(object sender, EventArgs e)
        {
            study.MoveNext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<PartTime> parttimestudent = new List<PartTime>();
            foreach(Student item in myStudents)
            {
                if(item is PartTime)
                {
                    parttimestudent.Add(item as PartTime);
                }
            }

            study.DataSource = parttimestudent;
            dataGridView1.DataSource = study;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataHandler school = new DataHandler();

            myStudents = school.GetStudents();

            study.DataSource = myStudents;
            dataGridView1.DataSource = study;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<FullTime> fullTimes = new List<FullTime>();
            foreach(Student item in myStudents)
            {
                if(item is FullTime)
                {
                    fullTimes.Add(item as FullTime);
                }
            }

            study.DataSource = fullTimes;
            dataGridView1.DataSource = study;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            study.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            study.MoveFirst();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            study.MoveLast();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtSearch.Text);
            bool exits = false;

            foreach (Student search in myStudents)
            {
                if(input == search.StudNumber)
                {
                    label8.Text = search.StudName.ToString();
                    label9.Text = search.Average.ToString();
                    label10.Text = search.Results.ToString();
                    label11.Text = search.Fees.ToString();
                    label12.Text = search.Payment.ToString();
                }
            }

            if( exits = false)
            {
                MessageBox.Show("Student is not enrolled");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
