
namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?: ");
            int n = int.Parse(Console.ReadLine());

            Dados[] vect = new Dados[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                vect[i] = new Dados { Id = id, Name = name, Salary = salary };
            }

            List<int> ids = new List<int> { };

            Console.WriteLine();
            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Dados emp = Array.Find(vect, x => x.Id == searchId);

            if (emp != null)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("This ID does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Dados d in vect)
            {
                Console.WriteLine(d);
            }
        }
    }
}