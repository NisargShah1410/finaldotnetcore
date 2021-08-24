using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySampleWebApp
{
    public class Calculator
    {
        public const string DefaultCertificatePassword = "C0mpl1c4t3d";
        public string GetPassword()
        {   
            string password ;
            password = DefaultCertificatePassword ;
            return password;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return b - a;
        }
    }
}
