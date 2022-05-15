
namespace Extensibility
{
    public class App
    {
        public static void Main()
        {
            // var person = new Person { MiddleName = "Percival", LastName = "Dumbledore" }; //no firstName
            // person.Initials = "APD";

            // Console.WriteLine(person.ShortName);
            // Console.ReadLine();

            // var human = new Human(firstName: "Albus", middleName: "Percival ", lastName: "Dumbledore");

            // Console.WriteLine(human.Initials);
            // Console.ReadLine();

            //var ch = new CulturedHuman(); cannot instantiate an abstract class
            // var culturedCoder = new CulturedCoder(firstName: "Albus", middleName: "Percival ", lastName: "Dumbledore");

            // Console.WriteLine(culturedCoder.Title); //all coders are hokages \o/
            // Console.WriteLine(((CulturedHuman)culturedCoder).Title); //downgraded to normies :(
            // Console.ReadLine();

            //composition
            var composedCoder = new CulturedDotNetCoder("c#", 20, "6.0", "Albus", "Dumbledore", "Percival", JobPosition.Junior);
            Console.WriteLine(composedCoder.Title);
            Console.ReadLine();
        }
    }
}