using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConsoleApp4
{
    class BasvuruManager
    {
        public void Basvuru(IKrediManager krediManager)    //En önemli kısım!.
        {                                                  //Burada IKrediManager bütün Kredi başvurularının referansnını tutabildiği için                                                          
            krediManager.Hesapla();                        //hesapla metoduna gönderdiğimiz nesneye göre işlem yapacaktır.
        }      

        public void basvuruOnBilgilendirme(List<IKrediManager> listem)
        {
            foreach (var kredi in listem)
            {
                kredi.Hesapla();
            }
        }
    }
}
