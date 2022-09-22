using cs11_dotnet_7_demo.Support;

namespace cs11_dotnet_7_demo;

public interface IRunnableDemo
{
	public void     Run();
	public string   Name     { get; }
	public int      Index    {get;}
	public Category Category { get; }
}
