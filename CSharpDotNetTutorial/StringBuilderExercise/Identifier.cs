﻿using System.Text;

namespace CSharpDotNetTutorial.SqueakyClean;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier.Length == 0)
            return String.Empty;

        var parseString = new StringBuilder(identifier);

        parseString.Replace(' ', '_');

        for (var i = 0; i < parseString.Length; i++)
        {
            var currentChar = parseString.ToString()[i];

            if (char.IsControl(currentChar)) // for checking control characters
            {
                parseString.Remove(i, 1);
                parseString.Insert(i, "CTRL");
                i += 3;
            }
            else if (currentChar == '-') // for switching camel to pascal case
            {
                var tempString = Char.ToUpper(parseString.ToString()[i + 1]);
                parseString.Remove(i, 2);
                parseString.Insert(i, tempString);
            }
            else if (!char.IsLetter(currentChar) && currentChar != '_' ||
                 (currentChar >= 'α' && currentChar <= 'ω')) // for filtering lowercase greek letters
            {
                parseString.Remove(i, 1);
                i--;
            }
        }

        return parseString.ToString();
    }
}
