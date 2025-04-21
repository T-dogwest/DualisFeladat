using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualisFeladat
{
    class Rejtjelez
    {
        //: a = 0, b = 1, ... z = 25, ' ' (szóköz) = 26
        public int KarakterKod(char a)
        {
            return a == ' ' ? 26 : a - 'a';
        }
        public char KodKarakter(int kod)
        {
            return kod == 26 ? ' ' : (char)(kod + 'a');
        }

        public string Rejtjelezes(string uzenet, string kulcs)
        {
            if (kulcs.Length < uzenet.Length) throw new ArgumentException("a kulcsnak legalább akkorának kell lennie mint az üzenetnek");

            char[] kodolt = new char[uzenet.Length];

            for (int i = 0; i < uzenet.Length; i++)
            {//a rejtjelezett üzenet n. karaktere az üzenet n. karakter kódja + kulcs n. karakter kódja    
                int uzenetKod = KarakterKod(uzenet[i]);
                int kulcsKod = KarakterKod(kulcs[i]);
                int kodoltKod = uzenetKod + kulcsKod;
                kodoltKod = kodoltKod > 26 ? kodoltKod % 27 : kodoltKod;
                kodolt[i] = KodKarakter(kodoltKod);
            }

            return new string(kodolt);

        }

        public string Visszafejt(string kodolt, string kulcs)
        {
            if (kulcs.Length < kodolt.Length) throw new ArgumentException("a kulcsnak legalább akkorának kell lennie mint az üzenetnek");

            char[] visszafejtett = new char[kodolt.Length];

            for (int i = 0; i < kodolt.Length; i++)
            {
                int kodoltUzenetKod = KarakterKod(kodolt[i]);
                int kulcsKod = KarakterKod(kulcs[i]);
                int uzenetKod = (kodoltUzenetKod - kulcsKod + 27) % 27;
                visszafejtett[i] = KodKarakter(uzenetKod);
            }

            return new string(visszafejtett);

        }
    }
}
