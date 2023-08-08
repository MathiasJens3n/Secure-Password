using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using Npgsql;

namespace Secure_Password
{
    internal class DatabaseManager
    {
        User _user;
        public DatabaseManager(User user)
        {
            _user = user;
        }
        const string connString = "Server=127.0.0.1;Port=5432;Database=Encryption;User Id=postgres;Password=Kwm28pbe!;";
        public string SaveUserToDatabase(string userName,string hash,string salt)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    Debug.WriteLine("Db Conn Open");
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (userid,hash,salt) VALUES (@userid,@hash,@salt)", conn))
                    {
                        cmd.Parameters.AddWithValue("userid", userName);
                        cmd.Parameters.AddWithValue("hash", hash);
                        cmd.Parameters.AddWithValue("salt", salt);

                        cmd.ExecuteNonQuery();

                        Debug.WriteLine($"user: {userName}, {hash}, {salt} added");
                        return $"user: {userName}, {hash}, {salt} added";
                    }
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
        public void GetUserFromDatabase(string username)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    Debug.WriteLine("Db Conn Open");
                    using (NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM users WHERE userid = '{username}'", conn))
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //Gets username
                            _user.UserName = reader.GetString(0);
                            //Gets hash
                            _user.Hash = reader.GetString(1);
                            //Gets salt
                            _user.Salt = reader.GetString(2);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

        }

    }
}
