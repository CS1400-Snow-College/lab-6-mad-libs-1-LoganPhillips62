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
string answer = Console.ReadLine();
if (string.IsNullOrWhiteSpace(answer)) answer = "something";
string after = "";


