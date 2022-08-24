using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignments_2
{
    internal class furniture
    {
        public int orderid;
        public int orderdate;
        string furnituretype;


        public string chairtype;
        public string chair1 = "wood";
        public string chair2 = "steel";
        public string chair3 = "plastic";
        public string purpose;
        public string woodtype;


        public string steeltype;



        public string plastictype;
        public double rate3 = 480;
        public double rate2 = 520;
        public double rate1 = 140;
        public string capacity;
        public double ratecot1;
        public double ratecot2;

        void GetData()
        {
            orderid = Convert.ToInt32(Console.ReadLine());
            orderdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter furniture type chair or cot");
            furnituretype = Console.ReadLine();
        }
        void ShowData()
        {
            Console.WriteLine("your order id is:{0}", orderid);
            Console.WriteLine("order date is:{0}", orderdate);
        }

    }
    class chair : furniture
    {

        public void ShowData()
        {
            Console.Write("enter chairtype wood steel or plastic");
            Console.WriteLine("enter purpose home or office");

        }
        public void GetData()
        {

            Console.WriteLine("enter purpose home or office");
            purpose = Console.ReadLine();
            Console.Write("enter chairtype wood steel or plastic");
            chairtype = Console.ReadLine();
            if (chairtype == chair1)
            {
                Console.WriteLine("enter wood type rose wood or teak wood");
                woodtype = Console.ReadLine();
                Console.WriteLine("cost of chair is{0}", rate1);

            }
            if (chairtype == chair2)
            {
                Console.WriteLine("enter type of steel gray green or brown");
                steeltype = Console.ReadLine();
                Console.WriteLine("cost of chair is {0}", rate2);

            }
            if (chairtype == chair3)
            {
                Console.WriteLine("enter colour of plastic green red blue or white");
                plastictype = Console.ReadLine();
                Console.WriteLine("cost of chair is {0}", rate3);
            }


        }
    }
    class cot : chair
    {
        public void GetData1()
        {
            Console.WriteLine("enter capacity of cot single or double");
            capacity = Console.ReadLine();
            if (capacity == "single")
            {
                ratecot1 = 202;

            }
            if (capacity == "double")
            {
                ratecot2 = 250;
            }
        }
        public void ShowData1()
        {
            Console.WriteLine("cot type is {0}", chairtype);
            Console.WriteLine("if capacity is single cost of cot is {0} and if double the rate of cot is {1}", ratecot1, ratecot2);


        }
    }

    public static class main
    {




        public static void Main()
        {
            chair obj = new chair();
            obj.GetData();
            obj.ShowData();
            cot obj1 = new cot();
            obj1.GetData1();
            obj1.ShowData1();

        }
    }
}
