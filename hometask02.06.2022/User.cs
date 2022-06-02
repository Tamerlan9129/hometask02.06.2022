using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask02._06._2022
{
    class User:IAccaunt
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public  bool PasswordChecker( ) 
        {
            int digitcoun = 0;
            int charUpCoun = 0;
            int charLoCoun = 0;
            for (int i = 0; i < Password.Length; i++)
            {
                if (Password.Length > 7)
                {
                    if (char.IsLower(Password[i]))
                    {

                        charLoCoun++;

                    }
                    else if (char.IsUpper(Password[i]))
                    {
                        charUpCoun++;
                    }
                    else if (char.IsDigit(Password[i]))
                    {
                        digitcoun++;

                    }
                    if (charLoCoun > 0 && charUpCoun > 0 && digitcoun > 0) 
                    {
                        return true;
                    }
                }
            }
            return false;
             
            
            

        }
        public void ShowInfo() 
        {
            Console.WriteLine($"Fullname :{FullName}" + $"Email : {Email}");
        }

       
    }
}
