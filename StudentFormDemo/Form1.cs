using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblScores_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string major = "TBD";
            if (rbProgramming.Checked)
            {
                major = rbProgramming.Text;
            }
            else if (rbWebDesign.Checked)
            {
                major = rbWebDesign.Text;
            }
            else if (rbIT.Checked)
            {
                major = rbIT.Text;
            }
            Student st = new Student(txbStudentID.Text,
                                     txbFirstName.Text,
                                     txbLastName.Text,
                                     major);
            st.StudentNumber = txbStudentID.Text;

            int count = 0;
            if (cbxCIS101.Checked)
            {
                count++;
            }
            if (cbxCIS102.Checked)
            {
                count++;
            }
            if (cbxCIS103.Checked)
            {
                count++;
            }
            if (cbxCIS104.Checked)
            {
                count++;
            }

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cbxCIS101.Checked)
            {
                courses[index] = cbxCIS101.Text;
                scores[index++] = Convert.ToInt32(txbScore1.Text);
            }
            if (cbxCIS102.Checked)
            {
                courses[index] = cbxCIS102.Text;
                scores[index++] = Convert.ToInt32(txbScore2.Text);
            }
            if (cbxCIS103.Checked)
            {
                courses[index] = cbxCIS103.Text;
                scores[index++] = Convert.ToInt32(txbScore3.Text);
            }
            if (cbxCIS104.Checked)
            {
                courses[index] = cbxCIS104.Text;
                scores[index++] = Convert.ToInt32(txbScore4.Text);
            }

            st.Scores = scores;
            st.Courses = courses;

            string summary =
                "Student's Major is " + st.Major +
                "\nStudent's First Name is " + st.FirstName +
                "\nStudent's Last Name is" + st.LastName +
                "\nStudent's Average is " + st.Average +
                "\nCourses: ";
            foreach (string course in courses)
            {
                summary += "\n" + st.course;
            }
            txbResult.Text = summary;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbxScore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxScore2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxScore3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxScore4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore","http://www.course.com");
                linkLabel1.LinkVisited = true;
        }
    }
}
