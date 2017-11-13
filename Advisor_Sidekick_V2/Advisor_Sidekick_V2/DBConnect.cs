using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Advisor_Sidekick_V2
{
    internal class DbConnect
    {
        private MySqlConnection _connection;
        private string _database;
        private string _password;
        private string _server;
        private string _uid;

        //Constructor
        public DbConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            _server = "kolschdatabase.cathmby3fo68.us-east-1.rds.amazonaws.com";
            _database = "advisorsidekick";
            _uid = "kolsch";
            _password = "teamkolsch";
            var connectionString = "Server=" + _server + ";" + "User=" +
                                   _uid + ";" + "Database=" + _database + ";Port=3306;" + "Password=" + _password +
                                   ";charset=utf8";

            _connection = new MySqlConnection(connectionString);

            //for connection testing on initialization instead of during operation
            //_connection.Open();
            //_connection.Close();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Insert a User
        public void InsertNewUser(string username, string password, string firstName, string lastName,
            string address, string phoneNumber, string highSchool, string email)
        {
            var query =
                "INSERT INTO USER(USERNAME, PASSWORD, FIRSTNAME, LASTNAME, ADDRESS, PHONENUMBER, HIGHSCHOOL, EMAIL) VALUES('" +
                username + "', '"
                + password + "', '"
                + firstName + "', '"
                + lastName + "', '"
                + address + "', '"
                + phoneNumber + "', '"
                + highSchool + "', '"
                + email + "');";

            //open connection
            if (!OpenConnection()) return;

            //create command and assign the query and connection from the constructor
            var cmd = new MySqlCommand(query, _connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            CloseConnection();
        }

        public string VerifyPass(string username)
        {
            if (!OpenConnection()) return "";

            var password = "";
            var query = "SELECT PASSWORD FROM USER WHERE USERNAME='" + username + "';";

            var cmd = new MySqlCommand(query, _connection);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
                password = dr["PASSWORD"] + "";


            //close connection
            CloseConnection();

            return password;
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
            return null;
        }

        //Count statement
        public int Count()
        {
            return 0;
        }
    }
}