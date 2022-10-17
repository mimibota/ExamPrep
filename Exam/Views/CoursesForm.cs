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
using Exam.Controllers;

namespace Exam.Views
{
    partial class CoursesForm : Form
    {


        //fields
        private CourseController _cc;


        //constructor
        public CoursesForm(CourseController cc)
        {
            _cc = cc;
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _cc.CloseCoursesDialogBox();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _cc.LoadCoursesData();
        }

        public void BindTableToGridView(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
