using System;
using System.Collections.Generic;

namespace Ejer_CSharp_No_41
{
    class Program
    {
        static void Main(string[] args)
        {
            var myUser = new User("Rene"); // publisher
            var subscriptor = new Subscriptor(); // subscriber
            myUser.Renamed += subscriptor.OnAddedUser;
            myUser.ADDUser("Rene");
            
        }

        public class Subscriptor
        {
            public void OnAddedUser(object source, EventArgs e)
            {
                Console.WriteLine("se ha agregado un usuario!");

            }
        }
        public class User
        {
            string name;
            List<User> users = new List<User>();
            public User(string n)
            {
                this.name = n;
            }
            public delegate void EventHandler<RenameEventArgs>(object source, EventArgs args);

            public event EventHandler Renamed;

            public void ADDUser(string name)
            {
                User user = new User(name);
                user.Renamed += (sender, args)=>
                {
                    Console.WriteLine("User {0} was renamed to {1}", users[0].name, users[1].name);
                    Console.WriteLine("Esto es el llamado del Evento Renamed!!!");
                };
                users.Add(user);
                OnAddedUser();
            }
            protected virtual void OnAddedUser()
            {
                if(Renamed != null)
                    Renamed(this, EventArgs.Empty);
            }
        }
    }
}
