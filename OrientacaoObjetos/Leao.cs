using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    class Leao : Felino
    {
        private static int bigode;

        public Leao():base(bigode)
        {

        }

        public override string EntrarNaCaixa()
        {
            return ("O Leão entrou na caixa!");
        }


    }
}
