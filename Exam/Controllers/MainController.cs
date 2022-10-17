using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Views;

namespace Exam.Controllers
{
    internal class MainController
    {
        //fields
        private MainForm _mainForm;
        private DataSet _data;
        private SqlConnection _connection;
        private CourseController _cc;
       

        //constructor

        public MainController()
        {

            //these have to be the very first thing that get called.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _mainForm = new MainForm(this); //this creates a new object of programMainMenu

            _data = new DataSet();
            _connection = new SqlConnection("Server=.\\SQL2019EXPRESS;" +
                "Integrated security=true;" +
                "User ID=sa;" +
                "password=yourStrong(!)Password;" +
                "Database=db_demo1;");
            _cc = new CourseController(_connection, _data);
        }


        //methods

        public void OpenMainMenu()
        {

            Application.Run(new MainForm(this));
        }

        public void ExitProgram()
        {
            Application.Exit();
        }


        public void OpenCoursesWindow()
        {
            this._cc.OpenCoursesDialogBox();
        }
    }
}
