using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Lambda
    {
        static void Main()
        {
            Employee e = new Employee();

            Func<decimal, decimal, decimal, decimal> s1 = (P, N, R) => (P * R * N) / 100;
            Console.WriteLine("Simple Interest = " + s1(15000, 3, 5));

            Console.WriteLine();
            Console.WriteLine();

            Func<int, int, bool> b1 = (x, y) => (x > y);
            Console.WriteLine("IsGreater = " + b1(10, 20));

            Console.WriteLine();
            Console.WriteLine();

            Func<Employee, decimal> bs = e1 => e1.getBasic(e);
            Console.WriteLine("Basic Salary = " + bs(e));

            Console.WriteLine();
            Console.WriteLine();

            Predicate<int> even = num => num % 2 == 0;
            Console.WriteLine("IsEven = " + even(13));

            Console.WriteLine();
            Console.WriteLine();

            Predicate<Employee> greater = e2 => e2.IsGreaterThan10000(e);

            Console.WriteLine("IsGreater = " + greater(e));

            Console.ReadLine();
        }

        static decimal SimpleInterest(decimal P, decimal N, decimal R)
        {
            return (P * N * R) / 100;
        }

        static bool IsGreater(int x, int y)
        {
            return x > y;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }

    class Employee
    {
        public decimal basic = 15000;

        public decimal getBasic(Employee emp)
        {
            return emp.basic;
        }

        public bool IsGreaterThan10000(Employee emp1)
        {
            return emp1.basic > 10000;
        }
    }