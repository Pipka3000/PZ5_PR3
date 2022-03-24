using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_PR3
{
    public enum Material
    {
        Дерево = 0,
        Пластик = 1,
        Металл = 2
    }

    public class Taburet
    {
       

        protected int Height;
        protected int Leg;

        Material Material;

        public Taburet(int Height, int Leg, Material Material)
        {
            if (Height >= 20 && Height <= 60)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }

            if (Leg == 1 || Leg == 2 || Leg == 4)
            {
                this.Leg = Leg;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }

            
        }

        //Высота сидушки
        public void SetHeight(int Height)
        {
            if (Height >= 20 && Height <= 60)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }
        }
        
        //Количество ножек
        public void SetLeg(int Leg)
        {
            if (Leg == 1 || Leg == 3 || Leg == 4)
            {
                this.Leg = Leg;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }
        }
        
        //Вид материала изделия
        public Material _Material
        {
            get { return Material; }
            set
            {
                Material = value;
            }
        }


        //Вывод всех данных
        public virtual void PrintObject()
        {
            Console.WriteLine("Высота седушки: " + Height + "| Кол-во ножек: " + Leg + "| Материал изделия: " + Material);
        }
        
        
        
        public Taburet()
        {

        }
    }
}
