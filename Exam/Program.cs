using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Controllers;

namespace Exam
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        ///- </summary>
        [STAThread]
        static void Main()
        {
            new MainController().OpenMainMenu(); // we are creating an instance of the class ProgramManager
                                                 //even though there is no name for the object. in this way,
                                                 //memory is not reserved for the object, because we will use
                                                 //this object only once.
                                                 //this is like doing: ProgramManager x = new ProgramManager
                                                 //x.OpenMainMenu();       }
        }
    }
}
