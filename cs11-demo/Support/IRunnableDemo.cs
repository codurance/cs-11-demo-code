namespace cs11_demo.Support;

public interface IRunnableDemo
{
	public void     Run();
	public string   Name     { get; }
	public int      Index    {get;}
	public Category Category { get; }
}
