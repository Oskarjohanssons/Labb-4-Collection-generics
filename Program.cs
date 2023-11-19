using System.Runtime.Intrinsics.X86;

namespace Labb_4___Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack();
            List();
        }

        private static void Stack()
        {
            Employee Pär = new Employee("Pär", "Male", 50000);
            Employee Oskar = new Employee("Oskar", "Male", 12000);
            Employee Ludde = new Employee("Ludwig", "Male", 10000);
            Employee Fia = new Employee("Fia", "Female", 35000);
            Employee Britta = new Employee("Britta", "Female", 28000);
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(Pär);
            stack.Push(Oskar);
            stack.Push(Ludde);
            stack.Push(Fia);
            stack.Push(Britta);
            foreach (Employee employee in stack)
            {
                employee.DisplayInfo();
                Console.WriteLine("Employees left in the stack: {0}", stack.Count);
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Retrieve using pop method");
            while (stack.Count > 0)
            {
                Employee employee = stack.Pop();
                employee.DisplayInfo();
                Console.WriteLine("Employees left in the stack: {0}", stack.Count);
            }
            stack.Push(Pär);
            stack.Push(Oskar);
            stack.Push(Ludde);
            stack.Push(Fia);
            stack.Push(Britta);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Retrieve using peek method");
            Employee emp1 = stack.Peek();
            emp1.DisplayInfo();
            Employee emp2 = stack.Peek();
            emp2.DisplayInfo();
            if (stack.Contains(Ludde))
            {
                Console.WriteLine("Ludde is in the stack");
            }
            else
            {
                Console.WriteLine("Ludde is not in the stack");
            }
        }
        private static void List()
        {
            Console.WriteLine("--------------------------------------------------------");
            Employee Pär = new Employee("Pär", "Male", 50000);
            Employee Oskar = new Employee("Oskar", "Male", 12000);
            Employee Ludde = new Employee("Ludwig", "Male", 10000);
            Employee Fia = new Employee("Fia", "Female", 35000);
            Employee Britta = new Employee("Britta", "Female", 28000);
            List<Employee> employeeList = new List<Employee>() { Pär, Oskar, Ludde, Fia, Britta };
            if (employeeList.Contains(Fia))
            {
                Console.WriteLine("Fia exist in the list");
            }
            else
            {
                Console.WriteLine("Fia do not exist in the list");
            }
            Employee result = employeeList.Find(e => e.Gender == "Male");
            if (result != null)
            {
                result.DisplayInfo();
            }
            else 
            {
                Console.WriteLine("Fuck off lad");
            }
            List<Employee> results = employeeList.FindAll(e => e.Gender == "Male");
            foreach (Employee e in results)
            {
                e.DisplayInfo();
            }
        
        }
    }
}