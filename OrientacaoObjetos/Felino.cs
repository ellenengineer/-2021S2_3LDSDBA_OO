using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    abstract class Felino : Animal
    {
        private static int _patas;

        public string Andar()
        {
           return  base.Andar(4);
        }

        public Felino(int bigode):base(_patas)
        {
            this.QtdPatas = _patas;
        }

        public abstract string EntrarNaCaixa();


    }
}
