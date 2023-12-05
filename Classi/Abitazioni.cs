using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Abitazioni : Immobili
    {
        // attributi
        protected int _numVani;

        // metodi accessor
        public int NumVani
        {
            get { return _numVani; }
            set { _numVani = value; }
        }

        // costruttore
        public Abitazioni(double _superficie, int _particella, int _categoria, int _numVani) : base(_superficie, _particella, _categoria)
        {
            NumVani = _numVani;
        }

        // metodi
        public double RenditaAbitazioni()
        {
            double renditaBase = base.RenditaBase();
            return renditaBase * NumVani;
        }
        public override string ToString()
        {
            return $"ABITAZIONI: Superficie: {Superficie}, Particella: {Particella}, Categoria: {Categoria}, Numero Vani: {NumVani}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Abitazioni abitazioni2 = (Abitazioni)obj;
            return NumVani == abitazioni2.NumVani;
        }
    }
}
