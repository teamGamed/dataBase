using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string PhotoUrl { get; set; }

        public string Type { get; set; }

        public string Sex { get; set; }

        public User(string username)
        {
            var user = dbUser.get(username);
            Copy(user);
        }

        public User()
        {

        }

        public bool CheckLogIn(string username, string password)
        {
            return username == Username &&
                   Password == password;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Username == user.Username &&
                   Password == user.Password &&
                   Name == user.Name &&
                   Email == user.Email &&
                   Phone == user.Phone &&
                   Address == user.Address &&
                   PhotoUrl == user.PhotoUrl &&
                   Type == user.Type &&
                   Sex == user.Sex;
        }

        public string GenString()
        {
            return  $"{nameof(Username)} = {Username};\n" +
                    $"{nameof(Password)} = {Password};\n" +
                    $"{nameof(Name)} = {Name};\n" +
                    $"{nameof(Email)} = {Email};\n" +
                    $"{nameof(Phone)} = {Phone};\n" +
                    $"{nameof(Address)} = {Address};\n" +
                    $"{nameof(PhotoUrl)} = {PhotoUrl};\n" +
                    $"{nameof(Type)} = {Type};\n" +
                    $"{nameof(Sex)} = {Sex};\n";
        }

        // DB Functions
        public void UpdateDb()
        {
            dbUser.update(this);
        }

        public void SaveDb()
        {
            dbUser.create(this);
        }

        public void Copy(User user)
        {
            Username = user.Username;
            Password = user.Password;
            Name = user.Name;
            Email = user.Email;
            Phone = user.Phone;
            Address = user.Address;
            PhotoUrl = user.PhotoUrl;
            Type = user.Type;
            Sex = user.Sex;
        }

    }
}
