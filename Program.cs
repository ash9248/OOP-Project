using System.Text.RegularExpressions;

namespace Project_OOP
{//OOP Project Muhammad Ashhad Naeem 4389
    class SalarySlip
    {// Salary slip class
        public double salary;
        public double medicalallowences;
        public double fuel;
        public SalarySlip(double salary = 0.0, double medicalallowences = 0.0, double fuel = 0)//constructor for salary slip
        {
            this.salary = salary;
            this.medicalallowences = medicalallowences;
            this.fuel = fuel;
        }
    }
    class Manager : SalarySlip //Child Class for Manager 
    {
        private double tax;
        public Manager(double tax = 0.0, double salary = 0.0, double med = 0.0, double fuel = 0)
        {
            this.salary = salary;
            this.medicalallowences = med;
            this.fuel = fuel;
            this.tax = tax;
        }

        public void ManagerSalary()// Constructor for manager class
        {
            Console.WriteLine("The Gross Salary of Manager is: ");
            Console.WriteLine("Base Salary: " + salary);
            Console.WriteLine("Fuel Allowance: " + fuel);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Medical Allowance: " + medicalallowences);
            double total = -tax + salary + fuel + medicalallowences;
            Console.WriteLine("Gross Salary: " + total);
        }
    }
    class HR : SalarySlip//Child Class for HR 
    {
        public double telephoneallowence;

        public HR(double tel = 0.0, double salary = 0.0, double med = 0.0, double fuel = 0)
        {
            this.telephoneallowence = tel;
            this.salary = salary;
            this.medicalallowences = med;
            this.fuel = fuel;
        }
        public void HRSalary()//Constructor for HR
        {
            Console.WriteLine("Base Salary: " + salary);
            Console.WriteLine("Fuel Allowance: " + fuel);
            Console.WriteLine("Phone Allowance: " + telephoneallowence);
            Console.WriteLine("Medical Allowance: " + medicalallowences);
            double total = telephoneallowence + salary + fuel + medicalallowences;
            Console.WriteLine("Gross Salary: " + total);
        }

    }
    class Engineer : SalarySlip//Child Class for Engineer
    {
        public Engineer(double salary, double total)
        {
            this.salary = salary;
            this.medicalallowences = (total / 12) * 0.5;
            this.fuel = (total / 12) * 0.5;
        }
        public void EnineerSalary()//Constructor for Engineer
        {
            Console.WriteLine("Base Salary: " + salary);
            Console.WriteLine("Fuel Allowance: " + fuel);
            Console.WriteLine("Medical Allowance: " + medicalallowences);
            double total = salary + fuel + medicalallowences;
            Console.WriteLine("Gross Salary: " + total);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input for cheking salary (1 for HR,2 for Engineer,3 for Manager)");
            int input;
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                HR hr = new HR(95, 1500, 800, 150);//Object for HR
                hr.HRSalary();
            }
            if (input == 2)
            {
                Engineer eng = new Engineer(1500, 7000);//Object for Engineer
                eng.EnineerSalary();
            }
            if (input == 3)//Object for Manager
            {
                Manager manager = new Manager(467.5, 1500, 1000, 250);
                manager.ManagerSalary();
            }
            Console.ReadLine();
        }
    }
}