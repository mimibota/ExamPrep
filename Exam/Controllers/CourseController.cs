using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Models;
using Exam.Views;

namespace Exam.Controllers
{
    internal class CourseController
    {

        //fields
        private CoursesForm _cf;
        private DataSet _ds;
        private Course _c;


        //constructor

        public CourseController(SqlConnection sq, DataSet ds)
        {
            this._cf = new CoursesForm(this);
            _ds = ds;
            _c = new Course(sq);
        }

        //methods

        public void OpenCoursesDialogBox()
        {
            this._cf.ShowDialog();
        }

        public void CloseCoursesDialogBox()
        {
            this._cf.DialogResult = DialogResult.Cancel;
        }

        public void LoadCoursesData()
        {
            _c.FillDataSet(_ds);

            DataTable coursesTable = _ds.Tables["dbo.Courses"];

            _cf.BindTableToGridView(coursesTable);


        }
    }
}
