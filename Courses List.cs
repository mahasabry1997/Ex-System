using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Exam_App
{
    public partial class Courses_List : Form
    {
        private int studentID;
        public Courses_List(int id)
        {
            InitializeComponent();
            this.studentID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentDashbord dashbord = new StudentDashbord(studentID);
            dashbord.Show();
        }

        private void Courses_List_Load(object sender, EventArgs e)
        {
            OnlineExam ent = new OnlineExam();
            var student = (from s in ent.Students
                           where s.Sid == studentID
                           select s).First();

            var list = ent.getCoursesByDeptID(student.DeptId).ToList();

            dataGridView1.DataSource = list;
        }
    }
}
