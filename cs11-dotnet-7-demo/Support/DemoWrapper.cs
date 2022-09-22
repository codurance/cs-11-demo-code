namespace cs11_dotnet_7_demo.Support;

public class DemoWrapper
{
	private readonly IRunnableDemo _demo;
	public DemoWrapper(IRunnableDemo demo) => _demo = demo;

	public virtual void Run()
	{
		Console.Clear();
		Console.WriteLine($"Demo: {_demo.GetType().Name}");
		Console.WriteLine("========================================");
		_demo.Run();
		Console.WriteLine("========================================");
		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();
		Console.Clear();
	}
}
