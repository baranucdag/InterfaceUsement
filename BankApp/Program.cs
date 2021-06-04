using System;
using System.Collections.Generic;

namespace newConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager taşıtkrediManager = new TaşıtkrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuru(konutKrediManager);
            basvuruManager.Basvuru(taşıtkrediManager);              //buradaki başvuru seçeneklerinde başvurular tek tek alınıyor.
            basvuruManager.Basvuru(ıhtiyacKrediManager);            //not: aşagıda yaşnan olayın gözlemlenmesi için burayı comment ler isek daha rahat görürüz

            
            List<IKrediManager> krediller = new List<IKrediManager>() { ıhtiyacKrediManager , taşıtkrediManager,konutKrediManager };  
            basvuruManager.basvuruOnBilgilendirme(krediller);       //buradaki başvurularda ise birden fazla başvuru alınıyor.

        }
    }
}
