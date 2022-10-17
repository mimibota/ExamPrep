using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Controllers;

namespace Exam.Views
{
    partial class MainForm : Form
    {


        //fields
        private MainController _mc;





        //constructor
        public MainForm(MainController programManager)
        {
            _mc = programManager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mc.ExitProgram();
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            _mc.OpenCoursesWindow();
        }
    }
}
