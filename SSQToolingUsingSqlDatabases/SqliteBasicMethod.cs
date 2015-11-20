using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

/*
 * 目前本程序调试不起来，因为引用的DLL不匹配或其它原因。
 * */
namespace SSQToolingUsingSqlite
{
    class SqliteBasicMethod
    {
        //数据库连接
        public static SQLiteConnection m_dbConnection;

        public SqliteBasicMethod()
        {
            connectToDatabase("hehe");
        }


        /// <summary>
        /// SQLiteConnection组件的方法，连接指定的数据库。
        /// </summary>
        /// <param name="source">数据库档案的位置及名称</param>
        /// <returns></returns>
        public static void connectToDatabase(string source)
        {
            /*
             * Version 3.9.2 of SQLite is recommended for all new development. Date:20151116
             */
            string connectionString = "Data Source=" + source + ";Version=3;";
            m_dbConnection = new SQLiteConnection(connectionString);
            m_dbConnection.Open();
        }


        /// <summary>
        /// SQLiteConnection组件的方法，执行一条数据库语句，通常只要求知道执行操作有没有成功即可。
        /// </summary>
        /// <param name="sqlLangString">引用一条完整的数据库语句</param>
        /// <returns></returns>
        public static void fillMultiLineToTable(string sqlLangString)
        {
            SQLiteCommand command = new SQLiteCommand(sqlLangString, m_dbConnection);
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// SQLiteConnection组件的方法，执行一条数据库查询语句，并返回查询结果。
        /// </summary>
        /// <param name="sqlLangString">引用一条完整的数据库查询语句</param>
        /// <returns>SQLiteDataReader</returns>
        public static SQLiteDataReader sqliteReaderQueryResult(string sqlLangString)
        {
            //string sqlLangString = "select * from highscores order by score desc";
            SQLiteCommand command = new SQLiteCommand(sqlLangString, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }



    }
}