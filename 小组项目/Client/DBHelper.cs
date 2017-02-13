using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Client
{
    public  class DBHelper
    {
        //链接字符串
        static string sqlstr = "Data Source=.;Initial Catalog=MyKTV;Integrated Security=True";

        public const string information = "温馨提示";
        /// <summary>
        /// 连接对象  sqlconnetction对象
        /// </summary>
        private static SqlConnection _conn;

        public static SqlConnection Conn
        {
            get
            {
                return _conn = new SqlConnection(sqlstr);
            }
        }

        /// <summary>
        /// 打开数据库
        /// </summary>
        public static void open()
        {
            if (_conn == null)
            {
                _conn = new SqlConnection(sqlstr);
                _conn.Open();
            }
            else if (_conn.State == ConnectionState.Broken)
            {
                _conn.Close();
                _conn.Open();
            }
            else
            {
                _conn.Open();
            }
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        public static void Close()
        {
            if (_conn.State != ConnectionState.Closed)
            {
                _conn.Close();
            }

        }

    }
}
