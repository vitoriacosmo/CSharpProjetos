using System;

namespace Exercicio06
{
    internal class Notas
    {
        public string Nome;
        public double NotaUm;
        public double NotaDois;
        public double NotaTres;

        public double Media()
        {
            return NotaUm + NotaDois + NotaTres;
        }

    }
}