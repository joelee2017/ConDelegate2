using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDelegate2
{
    delegate double Darea(int d1, int d2);//委派


    class Program
    {
        public static double RecA(int L, int W)//呼叫方法
        { return L * W; }

        public static void GetArea(int x, int y,Darea tv)
        {
            double area = tv(x, y);
            Console.WriteLine($"高：{x}，底：{y}，面積：{area}");
        }

        static void Main(string[] args)
        {

            int d1 = 20, d2 = 10;
            Darea dv;
            dv = delegate (int H, int B)//連結匿名方法的委派方式
            { return (H * B) / 2; };
            Console.WriteLine("1.三角形");
            GetArea(d1, d2, dv);
            Console.WriteLine("2.矩形");
            GetArea(d1, d2, new Darea(RecA));
            Console.Read();

        }
    }
}
