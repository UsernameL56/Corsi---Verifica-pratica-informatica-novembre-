using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Immobili
    {
        // attributi
        protected double _superficie;
        protected int _particella;
        protected int _categoria;

        // metodi accessor
        public double Superficie
        {
            get { return _superficie;}
            set { _superficie = value;}
        }
        public int Particella
        {
            get { return _particella;}
            set { _particella = value;}
        }
        public int Categoria
        {
            get { return _categoria;}
            set 
            { 
                if(value>0 && value <= 5)
                    _categoria = value;
            }
        }

        // costruttore
        public Immobili(double _superficie, int _particella, int _categoria)
        {
            Superficie = _superficie;
            Particella = _particella;
            Categoria = _categoria;
        }

        // metodi
        public virtual double RenditaBase()
        {
            return Superficie * Categoria;
        }
        public override string ToString()
        {
            return $"IMMOBILI: Superficie: {Superficie}, Particella: {Particella}, Categoria: {Categoria}";
        }
        public override bool Equals(object obj)
        {
           if(obj == null || GetType() != obj.GetType())
                return false;
            Immobili immobile2 = (Immobili)obj;
            return Categoria == immobile2.Categoria;
        }
    }
}
