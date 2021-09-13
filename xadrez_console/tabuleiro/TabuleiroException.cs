using System;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        // Criando exceção personalizada
        public TabuleiroException(string msg) : base(msg)
        {}
    }
}
