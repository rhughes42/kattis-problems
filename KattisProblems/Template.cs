using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyansTemplate
{
    /// <summary>
    /// A simple template structure for solving C# problems on Kattis.
    /// </summary>
    internal class Template
    {
        /// <summary>
        /// Program entry point and args.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static int Main(string[] args)
        {
            return Solve(Console.OpenStandardInput(), Console.OpenStandardOutput());
        }

        /// <summary>
        /// Our main solve instance.
        /// </summary>
        /// <param name="in"></param>
        /// <param name="out"></param>
        /// <returns></returns>
        public static int Solve(Stream @in, Stream @out)
        {
            var reader = new StreamReader(@in);
            var writer = new StreamWriter(@out);

            var input = reader.ReadLine();
            if (input != null) Debug.WriteLine($"Got {input} as input string.");

            // Insert solution here.
            var answer = String.Empty;

            if (answer != null || answer != String.Empty)
            {
                writer.WriteLine(answer);
            }
            else Debug.WriteLine("Invalid answer data.");
            writer.Flush();

            return 0;
        }
    }
}
