using ConsoleApp1;


class Program
{
    static void Main(string[] args)
    {
        IComponent<string> component = new ConcreteComponent();
        Console.WriteLine(component.GetText());

        IComponent<string> plainDecorator = new PlainDecorator(component);
        Console.WriteLine(plainDecorator.GetText());

        IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
        Console.WriteLine(upperCaseDecorator.GetText());

        IComponent<string> colorDecorator = new ColorDecorator(component);
        Console.WriteLine(colorDecorator.GetText());
    }
}

