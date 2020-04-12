using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string name;
        private string email;
        private string phone;
        private string address;
        private string photo_url;
        private string type;
        private string sex;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string PhotoUrl
        {
            get => photo_url;
            set => photo_url = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Sex
        {
            get => sex;
            set => sex = value;
        }
    }
}
