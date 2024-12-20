﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace _045_mesa_tuala_F1db
{
    public class Database
    {
        // Generic Connection string
        private string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        // Get all drivers
        private OleDbCommand command;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;

        // Datatable

        private DataTable dt;


        public Database(string file_path)
        {
            string conn_str = provider + file_path;
            connection = new OleDbConnection(conn_str);
        }

        public OleDbConnection Connection
        {
            get { return connection; }
        }

        public void OpenConnection()
        {
            if (this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }

        }

        public void CloseConnection()
        {
            if (this.Connection.State != ConnectionState.Closed)
            {
                this.Connection.Close();
            }

        }


        // Query functions

        public DataTable query_all()
        {
            string query = "SELECT model.model_desc as [MODEL DESCRIPTION], brand.brand as [BRAND], model.price as [PRICE] " +
                           "FROM model INNER JOIN brand on model.brandid = brand.brandid";

            using (command = new OleDbCommand(query, this.Connection))
            {
                adapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable query_brand_table()
        {
            string query = "SELECT * FROM brand";

            this.OpenConnection();

            using (command = new OleDbCommand(query, this.Connection))
            {
                adapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
            }

            this.CloseConnection();
            return dt;
        }

        public DataTable search_by_all(string keyword, string brand, int low, int high)
        {
            string query = "SELECT model.model_desc as [MODEL DESCRIPTION], brand.brand as [BRAND], model.price as [PRICE] " +
                           "FROM model INNER JOIN brand on model.brandid = brand.brandid " +
                           "WHERE model_desc LIKE @keyword and brand=@brand and price BETWEEN @low and @high";
            this.OpenConnection();
            using (command = new OleDbCommand(query, this.Connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@low", low);
                command.Parameters.AddWithValue("@high", high);
                adapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                this.CloseConnection();
                return dt;
            }
        }

        public DataTable search_by_keyword(string keyword)
        {
            string query = "SELECT model.model_desc as [MODEL DESCRIPTION], brand.brand as [BRAND], model.price as [PRICE] " +
                           "FROM model INNER JOIN brand on model.brandid = brand.brandid " +
                           "WHERE model_desc LIKE @keyword";
            this.OpenConnection();
            using (command = new OleDbCommand(query, this.Connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                adapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                this.CloseConnection();
                return dt;
            }
        }

        public DataTable search_by_brand(string brand)
        {
            string query = "SELECT model.model_desc as [MODEL DESCRIPTION], brand.brand as [BRAND], model.price as [PRICE] " +
                           "FROM model INNER JOIN brand on model.brandid = brand.brandid " +
                           "WHERE brand.brand=@brand";
            this.OpenConnection();
            using (command = new OleDbCommand(query, this.Connection))
            {
                command.Parameters.AddWithValue("@brand", brand);
                adapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                this.CloseConnection();
                return dt;
            }
        }

        public DataTable search_by_price_range(int low, int high)
        {
            string query = "SELECT model.model_desc as [MODEL DESCRIPTION], brand.brand as [BRAND], model.price as [PRICE] " +
                           "FROM model INNER JOIN brand on model.brandid = brand.brandid " +
                           "WHERE price BETWEEN @low and @high";
            this.OpenConnection();
            using (command = new OleDbCommand(query, this.Connection))
            {
                command.Parameters.AddWithValue("@low", low);
                command.Parameters.AddWithValue("@high", high);
                adapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                this.CloseConnection();
                return dt;
            }
        }

        public int add_record(string model_desc, double price, int brand_id)
        {
            string query = "INSERT INTO model (model_desc, price, brandid) VALUES (@model_desc, @price, @brand_id)";
            this.OpenConnection();
            using (command = new OleDbCommand(query, this.Connection))
            {
                command.Parameters.AddWithValue("@model_desc", model_desc);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@brand_id", brand_id);
                int rows_afffected = command.ExecuteNonQuery();
                this.CloseConnection();
                return rows_afffected;
            }
        }


        public int update_record(string curr_model_desc, string new_model_desc, double new_price, int new_brandid)
        {
            string query = "UPDATE model SET model_desc = @new_model_desc, price = @new_price, brandid = @new_brandid WHERE model_desc = @curr_model_desc";

            this.OpenConnection();

            using (command = new OleDbCommand(query, this.Connection))
            {
                command.Parameters.AddWithValue("@new_model_desc", new_model_desc);
                command.Parameters.AddWithValue("@new_price", new_price);
                command.Parameters.AddWithValue("@new_brandid", new_brandid);
                command.Parameters.AddWithValue("@curr_model_desc", curr_model_desc);
                int rows_afffected = command.ExecuteNonQuery();
                this.CloseConnection();
                return rows_afffected;
            }
        }

        public int delete_record(string model_desc)
        {
            string query = "DELETE FROM model WHERE model_desc = @model_desc";
            this.OpenConnection();
            using (command = new OleDbCommand(query, this.Connection))
            {
                command.Parameters.AddWithValue("@model_desc", model_desc);
                int rows_afffected = command.ExecuteNonQuery();
                this.CloseConnection();
                return rows_afffected;
            }

        }
    }
}
