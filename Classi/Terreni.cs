using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Terreni : Immobili
    {
        // attributi
        public bool _fabbricabile;

        // metodi accessor
        public bool Fabbricabile
        {
            get { return _fabbricabile;}
            set { _fabbricabile = value;}
        }

        // costruttore
        public Terreni(double _superficie, int _particella, int _categoria, bool _fabbricabile) : base(_superficie, _particella, _categoria)
        {
            Fabbricabile = _fabbricabile;
        }

        // metodi
        public double RenditaTerreni()
        {
            double renditaTerreni;
            double renditaBase = base.RenditaBase();
            if(Fabbricabile)
            {
                renditaTerreni = (renditaBase * 30) / 100;
                return renditaBase += renditaTerreni;
            }
            else
            {
                renditaTerreni = (renditaBase * 10) / 100;
                return renditaBase -= renditaTerreni;
            }
        }
        public override string ToString()
        {
            return $"TERRENI: Superficie: {Superficie}, Particella: {Particella}, Categoria: {Categoria}, Fabbricabile: {Fabbricabile}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Terreni terreni2 = (Terreni)obj;
            return Fabbricabile == terreni2.Fabbricabile;
        }
    }
}
