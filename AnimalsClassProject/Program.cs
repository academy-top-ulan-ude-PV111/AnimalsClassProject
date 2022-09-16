namespace AnimalsClassProject
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract void Voice();
        //{
        //    Console.WriteLine("...");
        //}
    }

    class Cat : Animal
    {
        string name;
        public override string Name
        {
            get { return name; }
            set { name = value + "ska"; }
        }
        public override void Voice()
        {
            Console.WriteLine("Myau");
        }
    }

    class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Gav");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Voice();

            Dog dog = new Dog();
            dog.Voice();
        }
    }
}