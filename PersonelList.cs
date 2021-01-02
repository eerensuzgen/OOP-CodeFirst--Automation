using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee
{
    class PersonelList
    {
        public List<Personel> personelInfos;
        public PersonelList()
        {
            personelInfos = new List<Personel>();
        }
        public void addPersonel(Personel p)
        {
            personelInfos.Add(p);

        }
        public void removePersonel(int pos)
        {
            personelInfos.RemoveAt(pos);
        }
        public void updatePersonel(int pos, Personel p)
        {
            personelInfos[pos] = p;
        }
        public Personel getKayit(int pos)
        {          
             return personelInfos[pos];          
        }
    }
}
