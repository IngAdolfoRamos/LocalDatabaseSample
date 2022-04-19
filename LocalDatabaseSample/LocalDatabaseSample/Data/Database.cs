using LocalDatabaseSample.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDatabaseSample.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection database;

        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Stall>().Wait();
        }
    }
}
