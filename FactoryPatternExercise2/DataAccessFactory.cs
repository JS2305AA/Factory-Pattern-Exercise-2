﻿using FactoryPatternExercise2;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2ConsoleUI
{
   public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                case "regular":
                    return new ListDataAccess();

                case "mysql":
                case "sql":
                case "my":
                    return new MySQLDataAccess();

                case "mongodb":
                case "mongo":
                    return new MongoDataAccess();

                default:
                    return new ListDataAccess();
            }
        }
    }
}