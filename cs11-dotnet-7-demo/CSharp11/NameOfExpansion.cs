using System.Diagnostics.CodeAnalysis;
using cs11_dotnet_7_demo.Support;

namespace cs11_dotnet_7_demo.CSharp11;

/*
 * nameof can now be used on method parameters
 * which means you can use it in attributes
 */

public class NameOfExpansion: IRunnableDemo
{
	public void Run()
	{
		object notNull = Echo(new object());
		object isNull  = Echo(null);
		
		Console.WriteLine("Nothing to see here I'm afraid...");
	}
	
	//[return: NotNullIfNotNull(nameof(input))]
	public object? Echo(object? input) => input;

	public string   Name     => "nameof() Expansion";
	public int      Index    => 30;
	public Category Category => Category.CSharp11;
}
