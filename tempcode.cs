using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // The original string
        var originalString = "Hello, this is a test. This function will replace certain words.";

        // Dictionary with old values as keys and new values as replacements
        var replacements = new Dictionary<string, string>
        {
            {"Hello", "Hi"},
            {"test", "demo"},
            {"function", "method"},
            {"certain", "specific"}
        };

        // Replace the values based on the dictionary
        var resultString = ReplaceValues(originalString, replacements);

        // Output the result
        Console.WriteLine(resultString);
    }

    static string ReplaceValues(string input, Dictionary<string, string> replacements)
    {
        foreach (var pair in replacements)
        {
            input = input.Replace(pair.Key, pair.Value);
        }
        return input;
    }
}
