{
string input = "палатка";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
static bool IsPalindrome(string str)
{
string normalized = new
String(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse());
}
