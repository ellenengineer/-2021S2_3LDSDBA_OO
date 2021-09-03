using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{

    enum TipoOlhos
    {
        SemOlho,pequeno, grande, normal
    }
    interface IAnimal
    {
        public int QtdPatas { get; set; }
        public TipoOlhos TpOlhos { get; set; }

        string Andar(int _qtdPatas);

    }
}
