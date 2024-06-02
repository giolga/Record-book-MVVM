using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Book_MVVM.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> DatabaseUser = new ObservableCollection<User>()
        {
            new User() {Name = "Giorgi", Email = "giolga@gmail.com"},
            new User() {Name = "Kumi", Email = "kumi@gmail.com"},
            new User() {Name = "Dustin", Email = "dustin@gmail.com"},
            new User() {Name = "Tony", Email = "tont@gmail.com"},
            new User() {Name = "Charles", Email = "charles@gmail.com"},
            new User() {Name = "Max", Email = "max@gmail.com"},
            new User() {Name = "Alex", Email = "alex@gmail.com"},
            new User() {Name = "John", Email = "john@gmail.com"},
            new User() {Name = "Francis", Email = "francis@gmail.com"}
        };

        public static ObservableCollection<User> GetUsers()
        {
            return DatabaseUser;
        }

        public static void Add(User user)
        {
            DatabaseUser.Add(user);
        }
    }
}
