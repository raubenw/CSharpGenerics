using System;
using System.Collections.Generic;

namespace CSharpGenerics {

    class Employee {

        public string mName;
        public int mSalary;

        public Employee(string name, int salary) {

            mName = name;
            mSalary = salary;
        }
    } // End Class Employee

    class Program {

        static void Main(string[] args) {

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee("Werner", 100000));
            empList.Add(new Employee("Alistair", 90000));
            empList.Add(new Employee("Jafran", 80000));
            empList.Add(new Employee("Jannie", 70000));
            empList.Add(new Employee("Koos", 60000));

            Console.WriteLine("empList Capacity is {0}", empList.Capacity);
            Console.WriteLine("empList Count is {0}", empList.Count);
        
            if(empList.Exists(HighPay)) {
                Console.WriteLine("Highly paid employee found!");
            }

            Employee e = empList.Find(x => x.mName.StartsWith("W"));
            if(e != null) {
                Console.WriteLine("Employee name that starts with 'W' = {0}", e.mName);
            }

            empList.ForEach(TotalSalaries);
            Console.WriteLine("The total salaries for all employees = {0}", total);
        }

        static int total = 0;
        static void TotalSalaries(Employee e) {
            total += e.mSalary;
        }


        //Delegate funtion to use in the Exists method
        static Boolean HighPay(Employee emp) {
            return emp.mSalary >= 85000;
        }
    }
}