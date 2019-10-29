using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            SymmetricMatrix sm = new SymmetricMatrix();

            sm.CheckIfSymmetricMatrix(new string[] { "5", "0", "4", "<>", "0", "5", "3", "<>", "2", "3", "2" });
        }
    }
}
