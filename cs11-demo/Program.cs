using cs11_demo.Support;
using Microsoft.Extensions.DependencyInjection;

namespace cs11_demo;


public static class Program
{
	public static void Main()
	{
		IServiceProvider services = Bootstrapper.Up();
		
		List<IRunnableDemo> demos = services.GetServices<IRunnableDemo>().OrderBy(s => s.Index).ToList();

		do
		{
			for (int i = 0; i < demos.Count; i++)
			{
				Console.WriteLine($"{i}: {demos[i].Name}");
			}

			int selection = Helpers.PromptAndGetSelection("Please pick your demo... (-1 exits)");
			if (selection == -1) break;
			
			new DemoWrapper(demos[selection]).Run();
		}
		while (true);
	}
}
