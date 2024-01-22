// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduzca el número x: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i <= x; i++)
{
    Console.WriteLine(CardinalToOrdinal(i));
}

static string CardinalToOrdinal(int cardinal)

{
    string ordinal = cardinal.ToString();

    if (cardinal % 10 == 1)
    {
        ordinal += "st";
    }
    else if (cardinal % 10 == 2)
    {
        ordinal += "nd";
    }
    else if (cardinal % 10 == 3)
    {
        ordinal += "rd";
    }
    else
    {
        ordinal += "th";
    }

    return ordinal;
}
