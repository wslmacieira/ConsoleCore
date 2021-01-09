using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda("Ronaldo");
            jogo.IniciarJogo();
        }
    }

    class JogoFoda
    {
        private readonly string _NomeJogador;

        public JogoFoda(string nome)
        {
            _NomeJogador = nome;
        }
        public void IniciarJogo()
        {
            Console.WriteLine($"{_NomeJogador} deu um passe");
        }
    }
}
