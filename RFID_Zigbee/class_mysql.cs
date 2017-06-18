using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace RFID_Zigbee
{
    class class_mysql
    {
        string dbhost, dbname, dbpass, dbuser, dbchar, connstr;
        MySqlConnection conn;

        //資料庫初始化設定
        public MySqlConnection Initialize(string host, string database, string user, string pwd)
        {
            dbhost = host;//host位址
            dbuser = user;//帳號
            dbpass = pwd;//密碼
            dbname = database;//資料庫
            dbchar = "utf8";//編碼格式

            connstr = "server=" + dbhost + ";uid=" + dbuser + ";pwd=" + dbpass + ";database=" + dbname + ";CharSet=" + dbchar;
            return conn = new MySqlConnection(connstr);
        }

        //連接
        public int mysql_connect()
        {
            try
            {
                conn.Open();
                return 1;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        return 0;
                    case 1045:
                        return 1045;
                    case 1042:
                        return 1042;
                    default:
                        return 9999;
                }
            }
        }

        //中斷
        public string mysql_disconnect()
        {
            try
            {
                conn.Close();
                return "1";
            }
            catch (MySqlException ex)
            {
                return ex.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //查詢客戶資料
        public ListView select_customer(MySqlConnection conn, ListView listView_customer)
        {
            string sql = "SELECT * FROM oc_customer";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            Form1 F1 = new Form1();
            ListViewItem item;
            listView_customer.Clear();
            da.Fill(ds);
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                listView_customer.Columns.Add(dt.Columns[i].Caption.ToString());
            }

            foreach (DataRow dr in dt.Rows)
            {
                item = listView_customer.Items.Add(dr[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
            }
            listView_customer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_customer.TopItem = listView_customer.Items[listView_customer.Items.Count - 1];
            return listView_customer;
        }

        //查詢客戶活動
        public ListView select_customer_activity(MySqlConnection conn, ListView listView_customer_activity)
        {
            string sql = "SELECT * FROM oc_customer_activity";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            ListViewItem item;
            listView_customer_activity.Clear();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                listView_customer_activity.Columns.Add(dt.Columns[i].Caption.ToString());
            }

            foreach (DataRow dr in dt.Rows)
            {
                item = listView_customer_activity.Items.Add(dr[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
            }
            //header 自動resize
            listView_customer_activity.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //自動置底
            listView_customer_activity.TopItem = listView_customer_activity.Items[listView_customer_activity.Items.Count - 1];
            return listView_customer_activity;
        }

        //新增客戶活動
        public void insert_customer_activity(MySqlConnection conn, string key, string card_id, int state)
        {
            string sql = "INSERT INTO oc_customer_activity (`key`, `card_id`, `state`, `date_added` ) VALUES ('" + key + "', '" + card_id + "', '" + state + "', NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        //查詢刷卡
        public DataTable select_customer_swipe(MySqlConnection conn, string card_id)
        {
            string sql = "SELECT * FROM oc_customer WHERE oc_customer.card_id =  '" + card_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            da.Fill(ds);
            dt = ds.Tables[0];

            return dt;
        }

        //新增客戶
        public void insert_customer_added(MySqlConnection conn, string name, string card_id, int permission, int state, string image)
        {
            string sql = "INSERT INTO oc_customer (`name`, `card_id`, `permission`, `state`, `image`, `join_time`) VALUES ('" + name + "', '" + card_id + "', '" + permission + "', '" + state + "', '"+ image +".png', NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        //更改客戶資料
        public void update_customer(MySqlConnection conn, string name, string card_id, int permission, int state, string image)
        {
            string sql = "UPDATE oc_customer SET name = '" + name + "', permission = '" + permission + "', state = '" + state + "', image = '" + image + ".png' WHERE card_id = '" + image + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        //刪除客戶
        public void delete_customer(MySqlConnection conn, string card_id)
        {
            string sql = "DELETE FROM oc_customer WHERE card_id = '" + card_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
