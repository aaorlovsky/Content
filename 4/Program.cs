var numberOfSets = int.Parse(Console.ReadLine()!);
char[] vowels = { 'e', 'u', 'i', 'o', 'a', 'y', 'E', 'U', 'I', 'O', 'A', 'Y' };
var upper = false;
var lower = false;
var vowel = false;
var cons = false;


for (var i = 0; i < numberOfSets; i++)
{
    upper = false;
    lower = false;
    vowel = false;
    cons = false;
    var password = Console.ReadLine()!;

    if (!password.Any(char.IsDigit))
    {
        password += '0';
    }

    if (!password.Any(char.IsUpper))
    {
        upper = true;
    }

    if (!password.Any(char.IsLower))
    {
        lower = true;
    }

    if (password.All(ch => !vowels.Contains(ch)))
    {
        vowel = true;
    }

    if (!password.Any(ch => Char.IsLetter(ch) && !vowels.Contains(ch)))
    {
        cons = true;
    }

    if (upper)
    {
        if (vowel)
        {
            password += 'O';
            vowel = false;
        }
        else if (cons)
        {
            password += 'D';
            cons = false;
        }
        else
        {
            password += 'P';
        }
    }

    if (lower)
    {
        if (vowel)
        {
            password += 'a';
            vowel = false;
        }
        else if (cons)
        {
            password += 'l';
            cons = false;
        }
        else
        {
            password += 's';
        }
    }

    if (vowel)
    {
        password += 'e';
    }

    if (cons)
    {
        password += 'k';
    }

    Console.WriteLine(password);
}