using System;

namespace hometask02._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            User us = new User();
            us.Email = "tamerlan@mail.ru";
            us.FullName = "Tamerlan Alimardanli";
            us.Password = "asdada";
            us.ShowInfo();
            Console.WriteLine(us.PasswordChecker());
        }
    }
    public interface IAccaunt 
    {
        public abstract bool PasswordChecker();
        public abstract void ShowInfo();
    
    }
}
