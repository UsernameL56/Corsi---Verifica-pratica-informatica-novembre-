using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Attici : Abitazioni
    {
        // attributi
        public double _superficieTerrazzo;

        // metodi accessor
        public double SuperficieTerrazzo
        {
            get { return _superficieTerrazzo; }
            set { _superficieTerrazzo = value; }
        }

        // costruttore
        public Attici(double _superficie, int _particella, int _categoria, int _numVani, double _superficieTerrazzo) : base(_superficie, _particella, _categoria, _numVani)
        {
            SuperficieTerrazzo = _superficieTerrazzo;
        }

        // metodi
        public override double RenditaBase()
        {
            double renditaAttici;
            double renditaBase = base.RenditaBase();
            renditaAttici = (renditaBase * (_superficieTerrazzo * 2))/100;
            return renditaBase + renditaAttici;
        }
        public override string ToString()
        {
            return $"ATTICI: Superficie: {Superficie}, Particella: {Particella}, Categoria: {Categoria}, Numero Vani: {NumVani}, Superficie Terrazzo: {SuperficieTerrazzo}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Attici attici2 = (Attici)obj;
            return SuperficieTerrazzo == attici2.SuperficieTerrazzo;
        }
    }
}
