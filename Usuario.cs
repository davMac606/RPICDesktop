using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPIC
{
    internal class Usuario
    {
        private int _id;
        private string _name;
        private string _username;
        private string _password;
        private int _age;


        public int Id
        {
            get => _id;
            set
            {
                _id = value;

            }

        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;

            }

        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;

            }

        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;

            }

        }

        public int Age
        {
            get => _age;
            set
            {
                _age = value;

            }

        }

        public Usuario(string name, string username, string password, int age)
        {
            Name = name;
            Username = username;
            Password = password;
            Age = age;
        }

        public Usuario(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Usuario()
        {

        }

        public bool cadastroUsuario()
        {
            bool cad = false;
            try
            {
                Dao_Conexao.con.Open();
                MySqlCommand cadastro = new MySqlCommand("INSERT INTO UserRPIC (userName, userUsername, userPassword, userAge) VALUES ('" + Name + "','" + Username + "','" + Password + "','" + Age + "')", Dao_Conexao.con);
                cadastro.ExecuteNonQuery();
                cad = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Dao_Conexao.con.Close();
            }
            return cad;
        }

        public bool loginUsuario()
        {
            bool log = false;
            try
            {
                Dao_Conexao.con.Open();
                MySqlCommand login = new MySqlCommand("SELECT userUsername, userPassword FROM UserRPIC WHERE userUsername = '" + Username + "' AND userPassword = '" + Password + "'", Dao_Conexao.con);
                MySqlDataReader dr = login.ExecuteReader();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Dao_Conexao.con.Close();
            }
            return log;

        }
    }
}
