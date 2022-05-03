// See https://aka.ms/new-console-template for more information
//Reverse a string -Program 1
string mystring = "hello";
char[] c= mystring.ToCharArray();
string result = string.Empty;
for (int i = c.Length; i > 0; i--)
{
    result+=c[i-1].ToString();// as array index starts with zero hence i-1 would be 5th index
}

Console.WriteLine(result);