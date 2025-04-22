using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualisFeladat
{
    class Tamadas
    {

        private List<string> szotar;
        
        private Rejtjelez rejtjelez;

        public Tamadas()
        {
            szotar = new List<string>(File.ReadAllLines("words.txt"));
            rejtjelez = new Rejtjelez();
        }

        
        public string KulcsReszlet(string kodolt, string uzenetresz)
        {
            char[] kulcs = new char[uzenetresz.Length];
            for (int i = 0; i < uzenetresz.Length; i++)
            {
                int kodoltKod = rejtjelez.KarakterKod(kodolt[i]);
                int uzenetKod = rejtjelez.KarakterKod(uzenetresz[i]);
                int kulcsKod = (kodoltKod - uzenetKod + 27) % 27;
                kulcs[i] = rejtjelez.KodKarakter(kulcsKod);
            }
            return new string(kulcs);
        }

        
        public string VisszafejtKulccsal(string kodolt, string kulcs)
        {
            if (kulcs.Length < kodolt.Length)
            {
                kulcs += new string('a', kodolt.Length - kulcs.Length);
            }
            else if (kulcs.Length > kodolt.Length)
            {
                kulcs = kulcs.Substring(0, kodolt.Length);
            }

            return rejtjelez.Visszafejt(kodolt, kulcs);
        }

        // Szótöredék keresése a szótárban
        public string Szokereso(string visszafejtett, int szohossz)
        {
            foreach (string szo in szotar)
            {
                string szoPlusz = szo + " ";
                if (szo.StartsWith(visszafejtett.Substring(0, szohossz)))
                {
                    return szoPlusz;
                }
            }
            return null;
        }

        
        public List<string> InditottTamadas(string kodolt1, string kodolt2, string feltetelezettSzo)
        {
            int nagyobb = Math.Max(kodolt1.Length, kodolt2.Length);
            List<string> osszesKulcs = new List<string>();
           
                //while (kulcs.Length < nagyobb)
                //{

                //}
            //string szo;

            //string kulcsresz0 = KulcsReszlet(kodolt1, feltetelezettSzo);
            //string visszafejt0 = VisszafejtKulccsal(kodolt2, kulcsresz0);

            //Console.WriteLine("Kulcsrészlet: " + kulcsresz0);
            //Console.WriteLine("Visszafejtett kodolt2 üzenet eleje: " + visszafejt0.Substring(0, feltetelezettSzo.Length));

            //string megtalaltszo0 = Szokereso(visszafejt0, feltetelezettSzo.Length);
            //if (megtalaltszo0 != null)
            //{
            //    string kulcsresz1 = KulcsReszlet(kodolt2, megtalaltszo0);
            //    string visszafejt1 = VisszafejtKulccsal(kodolt1, kulcsresz1);

            //    Console.WriteLine("Talált szó: " + megtalaltszo0);
            //    Console.WriteLine("Visszafejtett kodolt1 teljes üzenet eleje: " + visszafejt1.Substring(0, kulcsresz1.Length));


            //    
            //}
            //else
            //{
            //    Console.WriteLine("Nem található megfelelő szó a szótárban.");
            //}
            /*public List<string> InditottTamadas(string kodolt1, string kodolt2, string feltetelezettSzo)
        {
            int nagyobb = Math.Max(kodolt1.Length, kodolt2.Length);
            List<string> osszesKulcs = new List<string>();
            string kulcsReszlet1 = KulcsReszlet(kodolt1, feltetelezettSzo);
            string visszafejtettUzenet2 = VisszafejtKulccsal(kodolt2, kulcsReszlet1);

            
            string megtalaltSzo = Szokereso(visszafejtettUzenet2, feltetelezettSzo.Length);
            if (megtalaltSzo != null)
            {
                string kulcsReszlet2 = KulcsReszlet(kodolt2, megtalaltSzo);
                string visszafejtettUzenet1 = VisszafejtKulccsal(kodolt1, kulcsReszlet2);

               
                if (visszafejtettUzenet1.StartsWith(feltetelezettSzo))
                {
                    osszesKulcs.Add(kulcsReszlet1 + kulcsReszlet2);  // Az első és a második kulcs összevonása
                }
            }

            
            for (int i = 0; i < szotar.Count; i++)
            {
                string szo = szotar[i];
                string kulcsReszletPróbálkozás = KulcsReszlet(kodolt1, szo);
                string visszafejtett2 = VisszafejtKulccsal(kodolt2, kulcsReszletPróbálkozás);

               
                string szotomeg = Szokereso(visszafejtett2, szo.Length);
                if (szotomeg != null)
                {
                    string kulcs2 = KulcsReszlet(kodolt2, szotomeg);
                    string visszafejtett1Próbálkozás = VisszafejtKulccsal(kodolt1, kulcs2);

                  
                    if (visszafejtett1Próbálkozás.StartsWith(szo))
                    {
                        osszesKulcs.Add(kulcsReszletPróbálkozás + kulcs2);  
                    }
                }
            }

            return osszesKulcs;
        }*/
            return osszesKulcs;
        }

    }
}
