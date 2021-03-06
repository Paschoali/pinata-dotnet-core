﻿
namespace PinataCore.Data
{
    public static class Provider
    {
        private const string MSSQLServerClient = "System.Data.SqlClient";
        private const string MySqlClient = "MySql.Data.MySqlClient";

        public static string MSSQLServer
        {
            get { return MSSQLServerClient; }
        }

        public static string MySQL
        {
            get { return MySqlClient; }
        }

        public enum Type
        {
            MySQL = 1,
            //SQLServer,
            MongoDB
        }
    }
}