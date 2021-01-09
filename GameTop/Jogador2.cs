using System;

namespace GameTop
{
    public class Jogador2 : IJogador
    {
        //Chuta
        public string Chuta()
        {
            return $"Maradona está Chutando";
        }
        //Corre
        public string Corre()
        {
            return $"Maradona está Correndo";
        }
        //Passe
        public string Passe()
        {
            return $"Maradona está Passando";
        }
    }
}
