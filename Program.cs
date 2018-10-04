using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Mars" };
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");
            List<string> lastPlanets = new List<string> () { "Uranus", "Neptune" };
            planetList.AddRange (lastPlanets);
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            planetList.Add ("Pluto");
            List<string> rockyPlanets = planetList.GetRange (0, 4);
            planetList.Remove ("Pluto");
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>> ();
            Dictionary<string, string> firstProbe = new Dictionary<string, string> ();
            firstProbe["Mars"] = "Viking";
            probes.Add (firstProbe);
            Dictionary<string, string> secondProbe = new Dictionary<string, string> ();
            secondProbe["Mercury"] = "Messenger";
            probes.Add (secondProbe);
            Dictionary<string, string> thirdProbe = new Dictionary<string, string> ();
            thirdProbe["Venus"] = "Pioneer";
            probes.Add (thirdProbe);

            foreach (string planet in planetList) // iterate planets
            {
                List<string> matchingProbes = new List<string> ();

                foreach (Dictionary<string, string> probe in probes) // iterate probes
                {
                    /*
                        Does the current Dictionary contain the key of
                        the current planet? Investigate the ContainsKey()
                        method on a Dictionary.

                        If so, add the current spacecraft to `matchingProbes`.
                    */
                    if (probe.ContainsKey (planet)) {
                        matchingProbes.Add (probe[planet]);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */

                Console.WriteLine($"{planet}: {String.Join(",", matchingProbes)}");
            }
        }
    }
}