using LaboClasses.Models;
using System.Text;

namespace LaboClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voornaam: ");
            string firstName = Console.ReadLine();

            Console.Write("Achternaam: ");
            string lastName = Console.ReadLine();

            Console.Write("Geboortedatum: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Salaris: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            //Voorbeeld voor constructor zonder parameters
            Employee me = new Employee();
            me.FirstName = firstName;
            me.LastName = lastName;
            me.BirthDay = birthDate;
            me.Salary = (double)salary;

            //Voorbeeld voor constructor met parameters
            me = new Employee(firstName, lastName);
            me.BirthDay = birthDate;
            me.Salary = (double)salary;

            Console.WriteLine(me.ToString());
            Console.WriteLine(ShowDetails(me));

            int percentage;
            Console.WriteLine("Geef een percentage in van nul tot tien opslag");
            while (!(int.TryParse(Console.ReadLine(), out percentage) && (percentage >= 0 && percentage <= 10)))
            {
                Console.WriteLine("Ongeldige input");
            }
            me.IncreaseSalary(percentage);
            
            Console.WriteLine (ShowDetails(me));



        }
        private static string ShowDetails(Employee me)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----------------------------------------------");
            sb.AppendLine($"Werknemer:{me.FirstName} {me.LastName}");
            sb.AppendLine($"Geboortedatum: {me.BirthDay.ToLongDateString()} ({me.Age})");
            sb.AppendLine($"Salaris: {me.Salary}");
            sb.AppendLine($"----------------------------------------------");
            sb.AppendLine($"Samenvatting: {me.FirstName} {me.LastName} - {me.Age} - {me.Salary}");
            sb.AppendLine($"--------------------------------------------------");
            return sb.ToString();
        }
    }
}
