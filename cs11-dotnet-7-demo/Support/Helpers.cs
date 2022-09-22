namespace cs11_dotnet_7_demo.Support;

public static class Helpers
{
	public static int PromptAndGetSelection(string prompt)
	{
		Console.WriteLine(prompt);
		string entry = Console.ReadLine()   ?? String.Empty;
		if (int.TryParse(entry, out int result))
		{
			return result;
		}
		return -1;
	}
	
}
