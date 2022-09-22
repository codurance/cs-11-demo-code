using cs11_demo.CSharp11;
using Microsoft.Extensions.DependencyInjection;

namespace cs11_demo.Support;

public static class Bootstrapper
{
	public static IServiceProvider Up()
	{
		IServiceCollection services = new ServiceCollection()
									 .AddSingleton<IRunnableDemo, GenericMaths>()
									 .AddSingleton<IRunnableDemo, ImprovedInitialization>()
									 .AddSingleton<IRunnableDemo, NameOfExpansion>()
									 .AddSingleton<IRunnableDemo, RawStrings>();

		return services.BuildServiceProvider();
	}
}
