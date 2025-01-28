using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayApp
{
    public class GeneratePass
    {
        public string GeneratePassword()
        {
            Random rand = new Random();

            string Lowercase = "abcdefghijklmnopqrstuvwxyz";
            string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
           
            
            string SpeChar = "!@#$%^&*()";
            
            string randpasss = "";

            int small = rand.Next(Lowercase.Length);
            randpasss += Lowercase[small];

            int caps = rand.Next(Uppercase.Length);
            randpasss += Uppercase[caps];

            int num = rand.Next(0,9);
            randpasss += num;

            int spechar = rand.Next(SpeChar.Length);
            randpasss += SpeChar[spechar];

            return randpasss;

        }
        
    }
}
