﻿using Microsoft.Data.Sqlite;

namespace Shop_products_Avalonia_V1.Models
{
    public class DatabaseConnection
    {
        public SqliteConnection ConDB()
        {
            using (var connection = new SqliteConnection("Data Source = shop.db"))
            {
                return connection;
            }
        }
    }
}