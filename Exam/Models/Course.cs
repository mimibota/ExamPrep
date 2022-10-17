using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Models
{
    internal class Course
    {

        //fields

        private String _tableName = "dbo.Courses";
        private SqlDataAdapter _adapter;
        private SqlConnection _connection;
        public DataSet Courses;


        //constructor
        public Course(SqlConnection conn)
        {
            _connection = conn;
        }


        //methods
        public void FillDataSet(DataSet ds)
        {
            if (ds.Tables.Contains(_tableName))
            {
                ds.Tables.Remove(_tableName);
            }
            else 
            {
                _connection.Open();
                CreateDataAdapter().Fill(ds, _tableName);
                _connection.Close();
            }
            
        }

        public void UpdateDataSet(DataSet ds)
        {

        }

        private SqlDataAdapter CreateDataAdapter()
        {
            _adapter = new SqlDataAdapter();


            _adapter.SelectCommand = new SqlCommand($"SELECT * FROM {_tableName}", _connection);
            /*_adapter.InsertCommand = new SqlCommand($"INSERT INTO {_tableName} VALUES(@courseCode,@name, @description, @dateCreated, @dateUpdated, @dateDeleted)", _connection);
            _adapter.UpdateCommand = new SqlCommand($"UPDATE TABLE {_tableName}",_connection);
            _adapter.DeleteCommand = new SqlCommand($"DROP {_tableName}", _connection);

            _adapter.InsertCommand.Parameters.Add("@courseCode", SqlDbType.Int, 4, "courseCode");*/
            
            return _adapter;        
        } 

    }
}

