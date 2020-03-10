using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kangsy

{
    public interface IShape
    {
        void initialize(); 
        decimal getPerimeter();
        decimal getArea();
    }
    public interface IDisplayresult
    {
        void show();
    }
    public class Square : IShape, IDisplayresult  
    {
        public decimal sidelength;          
        public void initialize() 
        {

            Console.WriteLine("请输入正方形边长:");
            do
            {
                sidelength = decimal.Parse(Console.ReadLine());
                if (sidelength <= 0)
                {
                    Console.WriteLine("输入数据错误，请重新输入：");
                }
            }
            while (sidelength <= 0);
        }
        public decimal getPerimeter()    
        {
            return 4 * sidelength;
        }
        public decimal getArea()        
        {
            return sidelength * sidelength;
        }
        public void show()          
        {
            Console.WriteLine("正方形周长：{0}", getPerimeter());
            Console.WriteLine("正方形面积:{0}", getArea());
        }
    }                        
    public class Circle : IShape, IDisplayresult  
    {
        decimal radius; const decimal pai = 3.14M;
        public void initialize() 
        {
            Console.WriteLine("请输入圆形边长:");
            do
            {
                radius = decimal.Parse(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.WriteLine("输入数据错误，请重新输入：");
                }
            }
            while (radius <= 0);
        }
        public decimal getPerimeter()    
        {

            return 2 * pai * radius;       
        }
        public decimal getArea()        
        {
            return pai * radius * radius;
        }
        public void show()      
        {
            Console.WriteLine("圆形周长：{0}", getPerimeter());
            Console.WriteLine("圆形面积:{0}", getArea());
        }
    }
    public class Oblong : IShape, IDisplayresult
    {
        public decimal height ; public decimal width;     
        public void initialize() 
        {
            Console.WriteLine("请输入长方形长:");
            do
            {
                height = decimal.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("输入数据错误，请重新输入：");
                }
            } while (height <= 0);
            Console.WriteLine("请输入长方形宽:");
            do
            {   width = decimal.Parse(Console.ReadLine());
                if (width <= 0)
                {
                    Console.WriteLine("输入数据错误，请重新输入：");
                }
            }
            while (width <= 0);
        }
        public decimal getPerimeter()  
        {
            return (height + width)* 2;
        }
        public decimal getArea()       
        {
            return height * width;
        }
        public void show()          
        {
            Console.WriteLine("长方形周长：{0}", getPerimeter());
            Console.WriteLine("长方形面积:{0}", getArea());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Square sq = new Square(); Circle cir = new Circle(); Oblong ob = new Oblong();
            int i;
            Console.WriteLine("计算正方形、圆形、长方形周长面积系统");
            do
            {
                Console.WriteLine("菜单：");
                Console.WriteLine("1.正方形2.圆形3.长方形4.退出");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        sq.initialize();         
                        sq.show();               
                        break;
                    case 2:
                        cir.initialize();        
                        cir.show();          
                        break;
                    case 3:
                        ob.initialize();       
                        ob.show();               
                        break;
                    case 4:
                        Console.WriteLine("欢迎下次使用！！！");
                        break;
                    default: Console.WriteLine("输入错误！！！"); 
                        break;
                }
            } while (i != 4);
        }
    }

}
