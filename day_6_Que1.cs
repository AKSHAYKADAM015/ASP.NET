using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Q1
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> dic = new Dictionary<int, Employee>();
            char choice = 'y';
            while (choice == 'y')
            {
                Employee.insertEmployee(dic);
                Console.Write("Do you Want to continue type (y/n) : ");
                choice = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine();

            Employee.empSearch(dic);

            Console.WriteLine();
            Console.WriteLine();

            Employee.highSalary(dic);

            Console.WriteLine();
            Console.WriteLine();

            Employee.nthEmpSearch(dic);


            Console.ReadLine();

        }

    }


    class Employee
    {
        private int empId;

        private string empName;
        private decimal empSal;
        public static int empKey = 0;
        public int EmpId
        {
            set
            {
                if (value > 0)
                    empId = value;
                else
                    Console.WriteLine("Enter Valid empId");
            }

            get
            {
                return empId;
            }
        }
        public string EmpName
        {
            set
            {
                if
                    (value == null)
                    Console.WriteLine("Enter Valid empName");
                else
                    empName = value;
            }
            get
            {
                return empName;
            }
        }
        public decimal EmpSal
        {
            set
            {
                if (value < 10000)
                    Console.WriteLine("Enter valid Emp sal ");
                else
                    empSal = value;
            }
            get
            {
                return empSal;
            }
        }

        public Employee(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }

        public static void insertEmployee(Dictionary<int, Employee> dic)
        {


            Console.Write("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            string empName = Console.ReadLine();
            Console.Write("Enter Employee Sal : ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());
            dic.Add(++empKey, new Employee(empId, empName, empSal));
        }

        public static void highSalary(Dictionary<int, Employee> dic)
        {

            decimal max = 0;
            foreach (KeyValuePair<int, Employee> kp1 in dic)
            {
                if (kp1.Value.empSal > max)
                {
                    max = kp1.Value.empSal;
                }

            }
            Console.WriteLine("highest salary =" + max);


            foreach (KeyValuePair<int, Employee> kp2 in dic)
            {

                if (kp2.Value.empSal == max)
                {
                    Console.WriteLine(kp2.Key + " :==> " + kp2.Value.EmpId + "  " + "  " + kp2.Value.EmpName + "  " + kp2.Value.EmpSal);
                }
            }
        }
        public static void empSearch(Dictionary<int, Employee> dic)
        {
            Console.Write("Enter the Employee Number to search : ");
            int Searchid = Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<int, Employee> kp in dic)
            {
                if (Searchid == kp.Value.EmpId)
                    Console.WriteLine(kp.Key + " :==> " + kp.Value.EmpId + "  " + "  " + kp.Value.EmpName + "  " + kp.Value.EmpSal);

            }
        }

        public static void nthEmpSearch(Dictionary<int, Employee> dic)
        {
            Console.WriteLine("Enter the nth no of employee:");
            int SearchNth = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            foreach (KeyValuePair<int, Employee> kp3 in dic)
            {
                if (SearchNth == count)
                {
                    Console.WriteLine(kp3.Key + " :==> " + kp3.Value.EmpId + "  " + "  " + kp3.Value.EmpName + "  " + kp3.Value.EmpSal);
                }
                count++;
            }
        }
    }
}