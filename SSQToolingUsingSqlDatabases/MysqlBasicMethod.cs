using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace SSQToolingUsingSqlite
{
    class MysqlBasicMethod
    {
        /**
         * 首先要从Mysql官网下载用于C#的引用库包，即DLL后缀文件。
         * http://dev.mysql.com/downloads/connector/net/
         * ？并不是精确地址。
         * http://blog.sina.com.cn/s/blog_43eb83b90100mb08.html
         * */


        #region  建立MySql数据库连接
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回MySqlConnection对象</returns>
        public static MySqlConnection getmysqlcon(string M_str_sqlcon)
        {
            //"Database=test;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
            MySqlConnection myCon = new MySqlConnection(M_str_sqlcon);
            return myCon;
        }
        #endregion


        #region  执行MySqlCommand命令
        /// <summary>
        /// 执行MySqlCommand
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        public static void getMysqlCom(string M_str_sqlstr)
        {
            MySqlConnection mysqlcon = getmysqlcon(M_str_sqlstr);
            mysqlcon.Open();
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcom.ExecuteNonQuery();
            mysqlcom.Dispose();
            mysqlcon.Close();
            mysqlcon.Dispose();
        }
        #endregion


        #region  创建MySqlDataReader对象
        /// <summary>
        /// 创建一个MySqlDataReader对象
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        /// <returns>返回MySqlDataReader对象</returns>
        public static MySqlDataReader getmysqlread(string M_str_sqlstr)
        {
            MySqlConnection mysqlcon = getmysqlcon(M_str_sqlstr);
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcon.Open();
            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return mysqlread;
        }
        #endregion


        /// <summary>
        /// 拼全一段M_str_sqlcon字符串，形成MySqlConnection需要的标准格式的字符串
        /// </summary>
        /// <param name="source">服务器地址，如localhost、192.168.0.1:3306、www.woaidashuju.com</param>
        /// <param name="database">数据库名称，如"show databases"</param>
        /// <param name="userId">该数据库登陆的用户名</param>
        /// <param name="password">该用户的密码</param>
        /// <returns>返回完整的拼接string字符串</returns>
        public static string getMysqlStringConnection(string source, string database, string userId, string password)
        {
            //"Database=test;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
            string M_str_sqlcon = "";
            M_str_sqlcon = "server=" + source + ";user id=" + userId
                                + ";password=" + password + ";database=" + database + ";";
            
            //Default adding string;
            M_str_sqlcon = M_str_sqlcon + "pooling=false;CharSet=utf8;port=3306";

            return M_str_sqlcon;
        }


    }
}
