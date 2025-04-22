namespace DualisFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rejtjelez rejtjelez = new Rejtjelez();

            //string uzenet = "helloworld";
            //string kulcs = "abcdefgijkl";

            //// Rejtjelezés
            //string kodolt = rejtjelez.Rejtjelezes(uzenet, kulcs);
            //Console.WriteLine("Eredeti üzenet: " + uzenet);
            //Console.WriteLine("Kulcs: " + kulcs);
            //Console.WriteLine("Rejtjelezett üzenet: " + kodolt);

            //// Visszafejtés
            //string visszafejtett = rejtjelez.Visszafejt(kodolt, kulcs);
            //Console.WriteLine("Visszafejtett üzenet: " + visszafejtett);

            

            Rejtjelez r = new Rejtjelez();

            string uzenet1 = "curiosity killed the cat";
            string uzenet2 = "early bird catches the worm";
            string kulcs = "qwertyuiopasdfghjklzxcvbnmq"; 

            string kodolt1 = r.Rejtjelezes(uzenet1, kulcs);
            string kodolt2 = r.Rejtjelezes(uzenet2, kulcs);

            //Tamadas tamadas = new Tamadas();

            //Console.WriteLine("== Indított támadás ==");
            //tamadas.InditottTamadas(kodolt2, kodolt1, "early ");
            Tamadas tamadas = new Tamadas();
            List<string> kulcsok = tamadas.InditottTamadas(kodolt1, kodolt2, "early ");
            foreach (string kulcss in kulcsok)
            {
                Console.WriteLine("Talált kulcs: " + kulcss);
            }



        }
    }
}
