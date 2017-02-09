using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 小组项目
{
    class DBHelper
    {
        //链接字符串
        static string sqlstr = "Data Source=.;Initial Catalog=ktv结业项目;User ID=sa;Password=sa";

        public const string information = "温馨提示";
        /// <summary>
        /// 连接对象  sqlconnetction对象
        /// </summary>
        private static SqlConnection _conn;

        public static SqlConnection Conn
        {
            get
            {
                return _conn=new SqlConnection(sqlstr);
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

        /// <summary>
        /// Scalar方法，返回object类型，是有参方法，插入Sql语句 使用时先判断是否为 null 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>如果等于 null 则查询失败</returns>
        public static object scalar(string sql)
        {

            open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                {
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        /// <summary>
        /// NonQuery方法，返回受影响的行数，Int类型  使用时先判断是否为 -1
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>查询失败，返回—1</returns>
        public static int nonquery(string sql)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Conn))
                {
                    //执行sql语句命令并返回结果
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Reader读取方法 返回读取对象，SQLDataReader类型  使用时先判断是否为Null
        /// </summary>
        /// <param name="sql"></param>
        /// <returns> 执行失败返回null</returns>
        public static SqlDataReader read(string sql)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Conn))
                {
                    return cmd.ExecuteReader();
                }
            }
            catch (Exception)
            {
                return null;
            }

        }



    }
}
