namespace ConsoleApp;

class ImplementationClassB : ISampleInterface
{

    //public piti lini partadir
    public void SampleMethod()
    //void ISampleInterface.SampleMethod() // sranov argelum enq classi objectov kanchel
    {
        Console.WriteLine("I'm from ImplementationClassB");
    }


}
