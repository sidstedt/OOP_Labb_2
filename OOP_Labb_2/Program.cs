using System.Reflection;
namespace OOP_Labb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciating the child-classes of Animal and giving them values
            Dog dog1 = new Dog("Lennart", 10, 45.5m, true, "male", false, true, "Bone");
            Chihuahua test = new Chihuahua();
            Chihuahua chihuahua1 = new Chihuahua("Rambo", 3, 0.890m, false, "male", true, true, "Humping Legs", true);
            Rottweiler rottweiler1 = new Rottweiler("Flisan", 8, 50.0m, true, "female", false, true, "Chihuahuas", true);
            Cat cat1 = new Cat("Pelle", 1, 5.4m, true, "male", false, true, true);
            Horse horse1 = new Horse("Gösta", 14, 523.8m, true, "male", false, true, true);
            Horse horse2 = new Horse("Camelot", 20, 320.1m, false, "male", true, false, false);
            Human human1 = new Human("Lars-Gunnar", 45, 85.5m, false, "male", true, true, true, "Zoo-keeper");
            Snake snake1 = new Snake("Voldemort", 71, 78.47m, false, "male", true, true, false);
            NeedleTree nTree1 = new NeedleTree("Pine", 25, true);
            BroadLeafTree bTree1 = new BroadLeafTree("Oak", 15, true);
            // storing the objects as a list that are child classes to the animal class
            var theList = new List<Animal> { dog1, chihuahua1, rottweiler1, cat1, horse1, horse2, human1, snake1};
            foreach (var animals in theList)
            {
                Console.WriteLine($"{animals.MakeSound()}\n");
            }
            // writing out the objects  
            Console.WriteLine($"\n{nTree1.Photosynthesize()}");
            Console.WriteLine($"\n{bTree1.Photosynthesize()}");
            Console.ReadKey();
        }
    }
}
