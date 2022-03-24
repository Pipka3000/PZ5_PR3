using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_PR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taburet seccond = new Taburet();
            Spinka first = new Spinka();
            first.SetHeight(40);
            first.SetLeg(4);
            first.SetHeight_Spinka(21);
            first.PrintObject();
            
            seccond._Material = Material.Дерево;
        }
    }
}
