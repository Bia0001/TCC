/*
    Classe responsável pela aplicação do SINGLETON na classe contexto
    de maneira que apenas uma instância do classe BancoContexto exista na memoria Ram
*/
namespace Sistema.Acesso.Ifsp.DAL
{
    public class RepositorioBanco
    {
        private static BancoContexto instance;

        public static BancoContexto GetInstance()
        {
            if (instance == null)
            {
                instance = new BancoContexto();
            }
            return instance;
        }
    }
}
