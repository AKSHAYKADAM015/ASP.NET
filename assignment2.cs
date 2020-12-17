using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assignment_no_2
{
    public abstract class Employee {
        #region properties
        private string name;//varable
        public string Name
        {
            set
            {
                if (value == "" )//"             "
                {
                    name = "employee name";
                }
                else
                {
                    name = value;

                }
            }
            get
            {
                return name;
            }
        }
        private static int empno1 = 0;//dummy variable
        private int empno;// data memeber
        public int Empno
        {
            get
            {
                return empno;
            }
        }
       protected  decimal basic;//
        abstract public decimal Basic
        {

            set;

            get;
        }
        private short deptno;//1
        public short Deptno
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("assigned to dept no 1");
                    deptno = 1;
                }
                else
                    deptno = value;
            }
            get
            {
                return deptno;
            }
        }
        #endregion properties

        #region abstract methods

       public abstract decimal CalcNetSalary();// by default access specifier private 
        #endregion abstract methods

        #region constructor
        public Employee(string Name = "",  short Deptno = 0)
        {
            empno1++;//dummy varia
            empno = empno1;
            this.Name = Name;
           
            this.Deptno = Deptno;
        }
        #endregion constructor
    }
    public class Manager : Employee
    {
        #region properties
        private string designation;
        public string Designation {
            set {
                if (value == "")
                {
                    designation = "Trainee";

                }
                else
                    designation = value;
            }
            get {
                return designation;
            }
        }

        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set {
                if (value < 2000)
                {
                    basic = 2000;
                }
                else
                    basic = value;
            }
        }
        #endregion properties


        #region methods
        public override decimal CalcNetSalary()
        {
            throw new NotImplementedException();
        }
        #endregion methods

        #region constructor
        public Manager(string Name , decimal Basic,short Deptno, string Designation) : base(Name,Deptno) {
            this.Basic = Basic;
            this.Designation = Designation;
        }
        #endregion constructor
    }

    public class GeneralManager : Manager
    {
        #region propertirs
        protected string perks;
        public string Perks {
            set;
            get;
        }
        #endregion properties


        #region Constructor
        public GeneralManager(string Name, decimal Basic, short Deptno, string Designation, string Perks) : base(Name, Basic, Deptno, Designation) {
            this.Perks = Perks;
        }
        #endregion Constructor
    }

    public class CEO : Employee
    {
        #region properties
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value < 2000)
                {
                    basic = 2000;
                }
                else
                    basic = value;
            }
        }
        #endregion properties

        #region method
        public sealed override decimal CalcNetSalary()
        {
            Console.WriteLine(" method in Ceo class");
            decimal salary = Basic + (Basic * 0.01M);
            return salary;
        }
        #endregion method

        #region constructor
        public CEO(string Name, decimal Basic, short Deptno) : base(Name,Deptno) {
            this.Basic = Basic;
        }
        #endregion constructor
    }
    class Program
    {
        static void Main(string[] args)
        {
            CEO obj = new CEO("Laxman", 50000, 2);//
            Console.WriteLine(obj.CalcNetSalary());
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Deptno);


            Manager obj1 = new GeneralManager("Laxman patil", 50000, 2, "Software developer", "delta clearence");
            Console.WriteLine(obj1.Basic);
            Console.WriteLine(obj1.Name);

            Console.WriteLine(obj1.Deptno); 
            Console.WriteLine(obj1.Designation);

            Console.WriteLine("end line");

        }
    }
}