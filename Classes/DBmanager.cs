using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace The_Database_Project
{
    public class DBmanager
    {
        #region Variables
        SQLiteConnection myContection;
        bool fileOpen = false;
        DataTable dt;
        #endregion

        #region Constructor
        public void DBManager()
        {
        }
        #endregion

        #region UPDATE DATAG RID
        public DataTable UpdateDataGrid(SQLiteConnection conn)
        {
            myContection = conn;
            SQLiteCommand myCommand = new SQLiteCommand(myContection);
            SQLiteDataAdapter adapter;
            dt = new DataTable();
                myContection.Open();
                myCommand.CommandText = "SELECT * FROM movies";
                adapter = new SQLiteDataAdapter(myCommand);
                adapter.Fill(dt);
                myContection.Close();
            return dt;
        }
        #endregion

        #region UPDATE DATA
        public void UpdateData(string[] m, string[] table, string SQL, SQLiteConnection conn)
        {
            SQLiteTransaction trans;
            if (fileOpen)
            {
                conn.Close();
            }
            SQLiteCommand myCommand = new SQLiteCommand(SQL);
            for (int i = 0; i < table.Length; i++)
            {
                myCommand.Parameters.AddWithValue(m[i],table[i]);
            }
            myCommand.Connection = conn;
            conn.Open();
            fileOpen = true;
            trans = conn.BeginTransaction();

            myCommand.ExecuteNonQuery();

            trans.Commit();
            myCommand.Dispose();
            conn.Close();
            fileOpen = false;
        }
        #endregion

        #region ADD DATA
        public void AddData(string[] m, string[] table, string SQL, SQLiteConnection conn)
        {
            SQLiteTransaction trans;
            if (fileOpen)
            {
                conn.Close();
            }
            SQLiteCommand myCommand = new SQLiteCommand(SQL);
            for (int i = 0; i < table.Length; i++)
            {
                myCommand.Parameters.AddWithValue(m[i], table[i]);
            }
            myCommand.Connection = conn;
            conn.Open();
            fileOpen = true;
            trans = conn.BeginTransaction();
            myCommand.ExecuteNonQuery();
            trans.Commit();
            myCommand.Dispose();
            conn.Close();
            fileOpen = false;
        }
        #endregion

        #region DELETE DATA
        public void DeleteData(string id, SQLiteConnection conn)
        {
            SQLiteTransaction trans;
            if (fileOpen)
            {
                conn.Close();
            }
            string SQL = "DELETE FROM MOVIES WHERE ID = @mID";
            SQLiteCommand myCommand = new SQLiteCommand(SQL);
            myCommand.Parameters.AddWithValue("@mID", id);
            myCommand.Connection = conn;
            conn.Open();
            fileOpen = true;
            trans = conn.BeginTransaction();
            myCommand.ExecuteNonQuery();
            trans.Commit();
            myCommand.Dispose();
            conn.Close();
            fileOpen = false;
        }
        #endregion
    }
}
