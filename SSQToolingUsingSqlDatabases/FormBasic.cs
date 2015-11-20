using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace SSQToolingUsingSqlite
{
    public partial class FormBasic : Form
    {
        public FormBasic()
        {
            InitializeComponent();
        }

        private void textBoxFileOpen_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //new一个方法

            //"(*.et;*.xls;*.xlsx)|*.et;*.xls;*.xlsx|all|*.*"---------------如果要多种选择
            ofd.Filter = "Sqlite数据库文件|*";//删选、设定文件显示类型
            ofd.ShowDialog(); //显示打开文件的窗口
            this.textBoxFileOpen.Text = ofd.FileName; //获得选择的文件路径
        }

        private void buttonTablesAll_Click_old(object sender, EventArgs e)
        {
            /*
             * 目前本程序调试不起来，因为引用的DLL不匹配或其它原因。？？？？
             * */
            try
            {
                SqliteBasicMethod.connectToDatabase(this.textBoxFileOpen.Text);
                SQLiteDataReader reader = SqliteBasicMethod.sqliteReaderQueryResult("show tables");

                while (reader.Read())
                    Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
                Console.ReadLine();
            }
            catch (Exception err)
            {
                MessageBox.Show("数据库连接失败!失败原因：" + err.Message, "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonTablesAll_Click(object sender, EventArgs e)
        {
            /*
             * 采用Mysql的库获取相关的数据，以上面的方法略微不同。
             * */
            try
            {
                MysqlBasicMethod.getMysqlCom(this.textBoxFileOpen.Text);
                MySqlDataReader reader = MysqlBasicMethod.getmysqlread("show tables");

                while (reader.Read())
                    Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
                Console.ReadLine();
            }
            catch (Exception err)
            {
                MessageBox.Show("数据库连接失败!失败原因：" + err.Message, "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
