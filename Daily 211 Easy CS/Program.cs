using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_211_Easy_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { "Nick", "Billy", "Arnold", "Mary" };

            var vowels = "aeiou";
            var tmpl =
            @"{0}, {0} bo{1},
Bonana fanna fo{2},
Fee fy mo{3},
{0}!";

            foreach (var name in args)
            {
                var nameRhyme = (vowels.Contains(name.ToLower()[0])) ? name.ToLower() : name.Substring(1, name.Length - 1);
                var bName = (name.ToLower()[0] != 'b') ? String.Format(" B{0}", nameRhyme) : String.Format("-{0}", nameRhyme);
                var fName = (name.ToLower()[0] != 'f') ? String.Format(" F{0}", nameRhyme) : String.Format("-{0}", nameRhyme);
                var mName = (name.ToLower()[0] != 'm') ? String.Format(" M{0}", nameRhyme) : String.Format("-{0}", nameRhyme);
                var final = String.Format(tmpl, name, bName, fName, mName);
                Console.WriteLine(final);
            }

            // Suspend the screen.
            Console.ReadKey();
        }
    }
}
