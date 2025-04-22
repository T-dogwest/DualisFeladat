using DualisFeladat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DualisTest
{
    class RejtjelezTest
    {
        Rejtjelez rejtjelez = new Rejtjelez();
        
        [Test]
        public void Rejtjelezes_Test()
        {
            string uzenet = "helloworld";
            string kulcs = "abcdefgijkl";
            string vartKodolt = "hfnosauzun";

            string kodolt = rejtjelez.Rejtjelezes(uzenet, kulcs);

            Assert.AreEqual(vartKodolt, kodolt, "A rejtjelezett üzenet nem megfelelő.");
        }

        [Test]
        public void Visszafejt_Test()
        {
            string kodolt = "hfnosauzun";
            string kulcs = "abcdefgijkl";
            string vartUzenet = "helloworld";

            string visszafejtett = rejtjelez.Visszafejt(kodolt, kulcs);

            Assert.AreEqual(vartUzenet, visszafejtett, "A visszafejtett üzenet nem egyezik az eredetivel.");
        }

    }
}
