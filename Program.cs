// Logan Phillips
// 6/10/2024    
// Madlibs lab #6

Console.WriteLine("Hello! I will ask for words and make a short story.");
Console.WriteLine();
string originalStory ="I went to a (place) with my (adjective) friend. We saw a (noun) and played (game).";
string[] parts = originalStory.Split(' ');
 string newStory = "";
for (int i = 0; i < parts.Length; i++)
{
string token = parts[i];
int a = token.IndexOf('(');
int b = token.IndexOf(')');
if (a >= 0 && b > a)
{
string placeholder = token.Substring(a + 1, b - a - 1);
Console.Write("Enter " + placeholder + ": ");
string answer = Console.ReadLine() ?? "";
if (string.IsNullOrWhiteSpace(answer)) answer = "something";
string after = "";
if (b + 1 < token.Length) after = token.Substring(b + 1);
newStory += answer + after;
}
else
{
newStory += token;
}
if (i < parts.Length - 1) newStory += " ";
Console.WriteLine();
Console.WriteLine("Your story:");
Console.WriteLine(newStory);
Console.WriteLine("Press any key to continue.");
Console.ReadKey();
}

