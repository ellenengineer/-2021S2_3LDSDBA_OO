using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    abstract class Animal: IAnimal
    {
        public int QtdPatas { get; set; }
        public string Nome { get; set; }

        public string RacaTipo { get; set; }

        public TipoOlhos TpOlhos { get; set; }

        public Animal(int _patas)
        {

        }

        public string Andar(int _patas)
        {
            return ("caminhando com " + _patas + " patas!");
        }
    }
}
