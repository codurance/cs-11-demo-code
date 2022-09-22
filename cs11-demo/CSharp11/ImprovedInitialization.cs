using cs11_demo.Support;

namespace cs11_demo.CSharp11;

/*
 * Init only or readonly properties generate warnings about not being initialised when not-null
 * This is often a problem when defining models that will be deserialised
 * As the values aren't actually nullable, but the compiler doesn't know that
 * So let's tell it!
 */

public class ImprovedInitialization: IRunnableDemo
{

	public void Run()
	{
		KnightWhoSaysNi[] knights = {
										new()
										{
											FavouriteWord       = SecretWord.Peng,
											NumberOfShrubberies = 4,
											CrimesCommitted = new[]
															  {
																  Crime.BeingAnAsshole,
																  Crime.SayingNiAggressively
															  }
										},
										new()
										{
											FavouriteWord = SecretWord.NeeWom,
											NumberOfShrubberies = 78,
											CrimesCommitted = new []
															  {
																  Crime.SayingNiAggressively,
																  Crime.InterferingWithTheKingsQuest
															  }
										}
									};

		Console.WriteLine("On your mystical quest to find the Holy Grail, you meet the following knights:");
		
		foreach (KnightWhoSaysNi knight in knights)
		{
			Console.WriteLine(knight);
		}
	}


	private class KnightWhoSaysNi
	{
		public SecretWord FavouriteWord       { get; init; }
		public int        NumberOfShrubberies { get; init; }
		public Crime[]    CrimesCommitted     { get; init; }

		public override string ToString() => $"Knight of Ni who guards {FavouriteWord}, has {NumberOfShrubberies} shrubberies and is wanted for {string.Join(", ", CrimesCommitted)}";
	}


	private enum SecretWord
	{
		Ni,
		Peng,
		NeeWom
	}
	
	private enum Crime
	{
		SayingNiAggressively,
		InterferingWithTheKingsQuest,
		BeingAnAsshole
	}

	public string   Name     => "Improved Initialization";
	public int      Index    => 20;
	public Category Category => Category.CSharp11;
}
