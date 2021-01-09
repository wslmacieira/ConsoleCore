using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : IJogador
    {
        public Jogador3()
        {

        }
        public string Chuta()
        {
            return "Jogador Chuta";
        }

        public string Corre()
        {
            return "Jogador Corre";
        }

        public string Passe()
        {
            return "Jogador Passe";
        }
    }
}
