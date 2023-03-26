using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Guards
{
    internal interface IHashable
    {
        string Hash(string password);

        bool VerifyPassword(string password, string hashedPassword);
    }
}
