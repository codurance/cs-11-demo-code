using cs11_dotnet_7_demo.Support;

namespace cs11_dotnet_7_demo.CSharp11;

/*
 * Old way to do literals
 * New raw strings
 * Can be inlined properly (not left-justified)
 * Can be used in interpolated strings
 * What about if we want triple back ticks in our text?
 * Or braces
 * Okay... Well what if I want extra whitespace at the start?
 */
public class RawStrings: IRunnableDemo
{
	private const string OldJsonLiteral =@"
{
    ""glossary"": {
	""title"": ""example glossary"",
	""GlossDiv"": {
		""title"": ""S"",
		""GlossList"": {
			""GlossEntry"": {
				""ID"": ""SGML"",
				""SortAs"": ""SGML"",
				""GlossTerm"": ""Standard Generalized Markup Language"",
				""Acronym"": ""SGML"",
				""Abbrev"": ""ISO 8879:1986"",
				""GlossDef"": {
					""para"": ""A meta-markup language, used to create markup languages such as DocBook. {metaTag}"",
					""GlossSeeAlso"": [""GML"", ""XML""]
				},
				""GlossSee"": ""markup""
			}
		}
	}
}
}
";
	
	/*private const string JsonBlob = """
	{
	    "glossary": {
	        "title": "example glossary",
			"GlossDiv": {
	            "title": "S",
				"GlossList": {
	                "GlossEntry": {
	                    "ID": "SGML",
						"SortAs": "SGML",
						"GlossTerm": "Standard Generalized Markup Language",
						"Acronym": "SGML",
						"Abbrev": "ISO 8879:1986",
						"GlossDef": {
	                        "para": "A meta-markup language, used to create markup languages such as DocBook.",
							"GlossSeeAlso": ["GML", "XML"]
	                    },
						"GlossSee": "markup"
	                }
	            }
	        }
	    }
	}
	""";*/
	

	public void Run()
	{
		Console.WriteLine(OldJsonLiteral);
		//Console.WriteLine(JsonBlob);
	}

	public string   Name     => "Raw Strings";
	public int      Index    => 10;
	public Category Category => Category.CSharp11;
}
