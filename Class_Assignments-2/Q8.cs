using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignments_2
{
    interface GovtRules
    {
        void EmployeePF();
        void LeaVeDetails();
        void gratuityAmount();

    }

    interface GovtRules1
    {
        void EmployeePF1();
        void LeaVeDetails1();
        void gratuityAmount1();

    }

    class TCS : GovtRules
    {
        int empid;
        float service_year;
        double basic_salary, GratuityAmount;
        string name, dept, desg;
        public void EmployeePF()
        {
            Console.WriteLine("The employee id is:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The name of employee:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The Departement of the employee:");
            dept = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The designation of the employee:");
            desg = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Write the Basic salary:");
            basic_salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The balance added to the Employee PF account: " + 0.24 * basic_salary);
            Console.ReadLine();
        }



        public void gratuityAmount()
        {
            Console.WriteLine("Write the service year:");
            service_year = Convert.ToInt32(Console.ReadLine());
            //basic_salary = Convert.ToInt32(Console.ReadLine());
            if (service_year > 5 || service_year > 30)
            {
                if (service_year > 10 || service_year <= 19 || service_year >= 6)
                {
                    GratuityAmount = 2 * basic_salary;
                    Console.WriteLine("The Gratutiy amount is :" + GratuityAmount);
                    //GratuityAmount = Convert.ToInt32(Console.ReadLine());
                }
                else if (service_year > 20)
                {
                    GratuityAmount = 3 * basic_salary;
                    Console.WriteLine("The Gratutiy amount is :" + GratuityAmount);
                    //GratuityAmount = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    GratuityAmount = 0;
                    Console.WriteLine("The Gratutiy amount is :" + GratuityAmount);
                    //GratuityAmount = Convert.ToInt32(Console.ReadLine());
                }

            }


        }



        public void LeaVeDetails()
        {
            Console.WriteLine("Leave Details for TCS is ");
            Console.WriteLine("2 day of Casual Leave per month");
            Console.WriteLine("5 days of Sick Leave per year");
            Console.WriteLine("5 days of Previlage Leave per year");
            Console.ReadLine();

        }

        class Accenture : GovtRules
        {
            int empid;
            float service_year;
            double basic_salary, GratuityAmount;
            string name, dept, desg;
            public void EmployeePF()
            {
                Console.WriteLine("The employee id is:");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The name of employee:");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("The Departement of the employee:");
                dept = Convert.ToString(Console.ReadLine());
                Console.WriteLine("The designation of the employee:");
                desg = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Write the Basic salary:");
                basic_salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The balance added to the Employee PF account: " + 0.24 * basic_salary);
                Console.ReadLine();
            }



            public void gratuityAmount()
            {
                Console.WriteLine("Write the service year:");
                service_year = Convert.ToInt32(Console.ReadLine());
                //basic_salary = Convert.ToInt32(Console.ReadLine());
                if (service_year > 5 || service_year > 30)
                {
                    if (service_year > 10 || service_year <= 19 || service_year >= 6)
                    {
                        GratuityAmount = 2 * basic_salary;
                        Console.WriteLine("The Gratutiy amount is :" + GratuityAmount);
                        //GratuityAmount = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (service_year > 20)
                    {
                        GratuityAmount = 3 * basic_salary;
                        Console.WriteLine("The Gratutiy amount is :" + GratuityAmount);
                        //GratuityAmount = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        GratuityAmount = 0;
                        Console.WriteLine("The Gratutiy amount is :" + GratuityAmount);
                        //GratuityAmount = Convert.ToInt32(Console.ReadLine());
                    }

                }


            }



            public void LeaVeDetails()
            {
                Console.WriteLine("Leave Details for Accenture is ");
                Console.WriteLine("2 day of Casual Leave per month");
                Console.WriteLine("5 days of Sick Leave per year");
                Console.WriteLine("5 days of Previlage Leave per year");
                Console.WriteLine("Gratuity amount : Not applicable");
                Console.ReadLine();

            }

            internal class Q8
            {
                public static void Main()
                {
                    TCS pte = new TCS();
                    pte.EmployeePF();
                    pte.gratuityAmount();
                    pte.LeaVeDetails();

                    Accenture ctc = new Accenture();
                    ctc.EmployeePF();
                    ctc.gratuityAmount();
                    ctc.LeaVeDetails();

                }
            }
        }
    }
}