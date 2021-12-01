using System.Text;
using System;

class ChristmasPresentRecipientRandomizer
{
    public static void Main(String[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Input list of names delimited by a comma");
            return;
        }

        var randomizer = new ChristmasPresentRecipientRandomizer();
        Console.WriteLine(randomizer.Print(randomizer.Shuffle(args[0])));
    }

    private String[] Shuffle(String values)
    {
        var buffer = "";
        var random = new Random();
        var randomIndex = 0;
        var array = values.Replace(" ", String.Empty).Split(',');
        var max = array.Length;
        var lastIndex = array.Length - 1;



        while (lastIndex > 0)
        {
            randomIndex = random.Next(0, lastIndex);
            buffer = array[lastIndex];
            array[lastIndex] = array[randomIndex];
            array[randomIndex] = buffer;
            lastIndex--;
        }

        return array;
    }

    /**
    private void Pair(String[] values)
    {
        String lastElement = "";
        if (values.Length % 2 != 0)
        {
            lastElement = values[values.Length - 1];
            values = values.Take(values.Length - 1).ToArray();
        }
        for (int i = 0; i < values.Length; i = i + 2)
        {
            Console.WriteLine($"{values[i]} -> {values[i + 1]}");

        }
        if (!String.IsNullOrEmpty(lastElement))
        {
            Console.WriteLine("{0}", lastElement);
        }
    }
    **/

    public String Print(String[] array)
    {
        var sb = new StringBuilder("");
        
        for(int i=0;i<array.Length;i++)
        {
            if(i==array.Length-1)
            {
                sb.Append($"{array[i]} -> {array[0]}");
            }
            else 
            {
                sb.Append($"{array[i]} -> ");
            }
        }

        return sb.ToString();
    }
}
