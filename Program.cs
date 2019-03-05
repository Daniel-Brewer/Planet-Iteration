using System;
using System.Collections.Generic;

namespace Planet_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>()
            {

                new Dictionary<string, string>() { { "Mars", "Explorer" } },
                new Dictionary<string, string>() { { "Jupiter", "Discover" } },
                new Dictionary<string, string>() { { "Saturn", "Challenger" } },
                new Dictionary<string, string>() { { "Neptune", "Bold" } },
                new Dictionary<string, string>() { { "Mars", "Trekker" } },
                new Dictionary<string, string>() { { "Venus", "Falcon" } }
            };

            foreach (string planet in planetList) // iterate planets
            {
                List<string> matchingProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probes) // iterate probes
                {
                    /*
                        Does the current Dictionary contain the key of
                        the current planet? Investigate the ContainsKey()
                        method on a Dictionary. 

                        If so, add the current spacecraft to `matchingProbes`.
                    */
                    if (probe.ContainsKey(planet))
                    {
                        matchingProbes.Add(probe[planet]);
                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                        Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
                    }
                }

            }
        }
    }
}
