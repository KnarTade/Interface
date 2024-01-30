namespace ConsoleApp;
internal static class Program
{

    internal static void Main()
    {
        // ImplementationClass obj = new ImplementationClass();
        //ISampleInterface objA = new ImplementationClassA();
        // objA.SampleMethod();

        // ISampleInterface objB = new ImplementationClassB();
        // objB.SampleMethod();


        ImplementationClassA obA = new ImplementationClassA();
        ImplementationClassB obB = new ImplementationClassB();

        ISampleInterface iOb = (ISampleInterface)obA; // = new ImplemanetationClassA() ; reference type a
        iOb.SampleMethod();

        iOb = (ISampleInterface)obB; // = new ImplemanetationClassA() ;
        iOb.SampleMethod();

        if (obA is ISampleInterface)

            Console.WriteLine("Class A is implementing of interface");
        else
            Console.WriteLine("Class A do no implemente any interface");



        ISampleInterface iObCheck = obA as ISampleInterface;
        if (iObCheck != null)
            Console.WriteLine("Class A is  implementing of interface");
        else
            Console.WriteLine("Class A do no implemente any interface");


        try
        {

            // ISampleInterface iObCheckTry = obA as ISampleInterface;
            iObCheck = (ISampleInterface)obA;
            Console.WriteLine("Class A is  implementing of interface");
        }

        catch (InvalidCastException e)
        {
            Console.WriteLine(e.Message);
        }


        //Tiger tiger = new Tiger();
        //tiger.Sound();

        //Dog dog = new Dog();
        //dog.Sound();


        //IAnimal animal = new Tiger();
        //animal.Sound();
        //animal = new Dog();
        //animal.Sound();


        //    List<IAnimal> animals = new List<IAnimal>()
        //    {
        //        new Tiger(),
        //        new Dog(),
        //};


        //foreach (IAnimal animal in animals)
        //    animal.Sound();


        static IAnimal GetAnimal()
        {
            IAnimal animal;
            Random random = new Random();

            int temp = random.Next(0, 2);

            if (temp == 0)
            {
                animal = new Tiger();
            }

            else
            {
                animal = new Dog();

            }
            return animal;
        }

        IAnimal animal = GetAnimal();
        animal.Sound();

        animal = GetAnimal();
        animal.Sound();

        static void MakeSound(IAnimal animal)
        {
            animal.Sound();

        }

        MakeSound(animal);

        animal = GetAnimal();
    }

   

}