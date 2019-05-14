// string manipulation
// What happens if we pretend strings can use math?

Console.WriteLine("Hello World");
Console.WriteLine("Hello" + "World"); // HelloWorld?
Console.WriteLine("Hello" + 2); // HelloHello? Hello2? --> Hello2
Console.WriteLine("Hello" + 2 / 2 + "World"); // Hello1World? --> Hello1World
Console.WriteLine("Hello" + 2 + 2 + "World"); // What happened? Hello22World? Hello4World? --> Hello22World
// "Hello" + 2 --> "Hello2"
// "Hello2" + 2 --> "Hello22"
// "Hello22" + "World" --> "Hello22World"
// Behind the scenes, this gets turned into ((("Hello" + 2) + 2) + "World")
Console.WriteLine("Hello" + (2 + 2) + "World"); // Hello4World
// The difference between lines 18 and 19 is order of operations.
Console.WriteLine(2 + "Hello"); // 2Hello? --> 2Hello
Console.ReadLine();

/*
* How does C# decide what things can automatically turn into other things?
*
* integers can go to doubles, but not vice-versa
* everything can turn into a string.
*
* Casts that require fudging cannot be done implicitly. 2 -> "2" requires no fudging. But what number is "twos"?
*/

// Turns out we don't need to pretend
// What else can strings do?

Console.WriteLine("Hello World".Length);
Console.WriteLine("Hello World".ToUpper());
// even though .length lives inside of String, it gives back an Integer that can be mathed like an integer.
Console.WriteLine("Hello".Length + "A long sentence.".Length);
Console.WriteLine(Math.PI * (4 * 2)); // diameter of a circle with a radius of 4
Console.WriteLine("Hello WorldWorldWorld".Replace("World", "Universe")); //Hello UniverseUniverseUniverse?
// Hello UniverseWorldWorld?
// --> Hello UniverseUniverseUniverse