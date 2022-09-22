using System.Numerics;
using System.Reflection;
using AutoFixture;
using AutoFixture.Kernel;
using cs11_demo.Support;

namespace cs11_demo.CSharp11;

/*
  -  Static abstract and static virtual members in interfaces
  -  Relaxed right-shift requirements
  -  Unsigned right shift operator
  -  Numeric IntPtr
 */

public class GenericMaths: IRunnableDemo
{
	private readonly Fixture _fixture = new();
	private readonly List<Type>  _numericTypes = typeof(Type).Assembly.GetTypes().Where(t => t.IsAssignableTo(typeof(INumber<>)) && !t.IsInterface && t != typeof(IntPtr)).ToList();
	public void Run()
	{
		Console.WriteLine("The following numeric types exist:");
		
		for (int i = 0; i < _numericTypes.Count; i++)
		{
			Console.WriteLine($"{i}: {_numericTypes[i].Name}");
		}

		int selection = Helpers.PromptAndGetSelection("Select one... (-1 is all)");

		if (selection == -1)
		{
			_numericTypes.ForEach(ReflectionMagicPythagorasWrapper);
			return;
		}
		
		ReflectionMagicPythagorasWrapper(_numericTypes[selection]);
	}

	private void DoPythagoras<T>(T a, T b) where T : INumber<T>
	{
		T c = a * a + b * b;
		Console.WriteLine($"The Type is:{typeof(T).Name}\nProvided arguments were:\na:{a}\nb:{b}\nTherefore the hypoteneuse is: {c}\n");
	}
	
	// Extra stuff below, interesting stuff above ^^^^^^^
	
	
	
	
	
	// I'm not implementing this... It's an absolutely huge interface
	/*private class MyFancyNewNumericType : INumber<MyFancyNewNumericType>
	{

		public int CompareTo(object? obj) => throw new NotImplementedException();

		public int CompareTo(MyFancyNewNumericType? other) => throw new NotImplementedException();

		public bool Equals(MyFancyNewNumericType? other) => throw new NotImplementedException();

		public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => throw new NotImplementedException();

		public static MyFancyNewNumericType Parse(string s, IFormatProvider? provider) => throw new NotImplementedException();

		public static bool TryParse(string? s, IFormatProvider? provider, out MyFancyNewNumericType result) => throw new NotImplementedException();

		public static MyFancyNewNumericType Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => throw new NotImplementedException();

		public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out MyFancyNewNumericType result) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator +(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static MyFancyNewNumericType AdditiveIdentity                                    { get; }
		public static bool operator ==(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static bool operator !=(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static bool operator >(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static bool operator >=(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static bool operator <(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static bool operator <=(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator --(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator /(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator ++(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator %(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static MyFancyNewNumericType MultiplicativeIdentity                                              { get; }
		public static MyFancyNewNumericType operator *(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator -(MyFancyNewNumericType left, MyFancyNewNumericType right) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator -(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static MyFancyNewNumericType operator +(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static MyFancyNewNumericType Abs(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsCanonical(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsComplexNumber(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsEvenInteger(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsFinite(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsImaginaryNumber(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsInfinity(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsInteger(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsNaN(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsNegative(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsNegativeInfinity(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsNormal(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsOddInteger(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsPositive(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsPositiveInfinity(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsRealNumber(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsSubnormal(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static bool IsZero(MyFancyNewNumericType value) => throw new NotImplementedException();

		public static MyFancyNewNumericType MaxMagnitude(MyFancyNewNumericType x, MyFancyNewNumericType y) => throw new NotImplementedException();

		public static MyFancyNewNumericType MaxMagnitudeNumber(MyFancyNewNumericType x, MyFancyNewNumericType y) => throw new NotImplementedException();

		public static MyFancyNewNumericType MinMagnitude(MyFancyNewNumericType x, MyFancyNewNumericType y) => throw new NotImplementedException();

		public static MyFancyNewNumericType MinMagnitudeNumber(MyFancyNewNumericType x, MyFancyNewNumericType y) => throw new NotImplementedException();

		public static MyFancyNewNumericType Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => throw new NotImplementedException();

		public static MyFancyNewNumericType Parse(string s, NumberStyles style, IFormatProvider? provider) => throw new NotImplementedException();

		static bool INumberBase<MyFancyNewNumericType>.TryConvertFromChecked<TOther>(TOther value, out MyFancyNewNumericType? result) => throw new NotImplementedException();

		static bool INumberBase<MyFancyNewNumericType>.TryConvertFromSaturating<TOther>(TOther value, out MyFancyNewNumericType? result) => throw new NotImplementedException();

		static bool INumberBase<MyFancyNewNumericType>.TryConvertFromTruncating<TOther>(TOther value, out MyFancyNewNumericType? result) => throw new NotImplementedException();

		static bool INumberBase<MyFancyNewNumericType>.TryConvertToChecked<TOther>(MyFancyNewNumericType value, out TOther? result) where TOther : default => throw new NotImplementedException();

		static bool INumberBase<MyFancyNewNumericType>.TryConvertToSaturating<TOther>(MyFancyNewNumericType value, out TOther? result) where TOther : default => throw new NotImplementedException();

		static bool INumberBase<MyFancyNewNumericType>.TryConvertToTruncating<TOther>(MyFancyNewNumericType value, out TOther? result) where TOther : default => throw new NotImplementedException();

		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out MyFancyNewNumericType result) => throw new NotImplementedException();

		public static bool TryParse(string? s, NumberStyles style, IFormatProvider? provider, out MyFancyNewNumericType result) => throw new NotImplementedException();

		public static MyFancyNewNumericType One   { get; }
		public static int                   Radix { get; }
		public static MyFancyNewNumericType Zero  { get; }
	}*/
	
	private void ReflectionMagicPythagorasWrapper(Type t)
	{
		object   a    = new SpecimenContext(_fixture).Resolve(t);
		object   b    = new SpecimenContext(_fixture).Resolve(t);
		object[] args = {a, b};
		
		MethodInfo method = typeof(GenericMaths).GetMethod(nameof(DoPythagoras), BindingFlags.NonPublic | BindingFlags.Instance)!;
		method = method.MakeGenericMethod(t);
		method.Invoke(this, args);
	}
	
	public string   Name     => "Generic Maths";
	public int      Index    => 0;
	public Category Category => Category.CSharp11;
}
