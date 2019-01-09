using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {

        Hashtable wordsInMagazine = new Hashtable();
        foreach(var magWord in magazine)
        {
            if (wordsInMagazine.ContainsKey(magWord))
            {
                wordsInMagazine[magWord] = (int)wordsInMagazine[magWord] + 1;
            }
            else
            {
                wordsInMagazine.Add(magWord, 1);
            }
        }
        bool allAvailable = true;
        foreach(var noteWord in note)
        {
            if(!wordsInMagazine.Contains(noteWord))
            {
                allAvailable = false;
            }
            else
            {
                if ((int)wordsInMagazine[noteWord] == 1)
                {
                    wordsInMagazine.Remove(noteWord);
                }
                else
                {
                    wordsInMagazine[noteWord] = (int)wordsInMagazine[noteWord] - 1;
                }
            }

        }
        Console.WriteLine(allAvailable ? "Yes" : "No");

    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
