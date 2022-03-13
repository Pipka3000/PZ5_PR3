using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_PR3
{
    public class Spinka:Taburet
    {
        protected int Height_Spinka;

        public void SetHeight_Spinka(int Height_Spinka)
        {
            if (Height_Spinka >= Height * 0.5 && Height_Spinka <= Height)
            {
                this.Height_Spinka = Height_Spinka;
                
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }
        }
        
        public override void PrintObject()
        {
            Console.WriteLine("Высота седушки: " + Height + "| Кол-во ножек: " + Leg + "| Материал изделия: " + Material + "| Высота спинка: " + Height_Spinka);
        }
    }
}
