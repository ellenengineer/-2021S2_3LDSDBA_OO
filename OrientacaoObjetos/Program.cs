using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            Leao objLeao = new Leao();
            Felino f = objLeao;

            if (objLeao is Felino)
            {
                objLeao.EntrarNaCaixa();
            }

        }


    }



}
