using System;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly Jogador _jogador;

        public JogoFoda(Jogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo()
        {
            _jogador.Corre();
            _jogador.Chuta();
            _jogador.Passe();
        }
    }

    public class Jogador
    {
        public readonly string Nome;

        public Jogador(string nome)
        {
            Nome = nome;
        }

        //Chuta
        public void Chuta()
        {
            Console.WriteLine($"{Nome} está Chutando");
        }
        //Corre
        public void Corre()
        {
            Console.WriteLine($"{Nome} está Correndo");
        }
        //Passe
        public void Passe()
        {
            Console.WriteLine($"{Nome} está Passando");
        }
    }
}
