namespace Sistema.Ifsp.DAL
{
    public class AcessoContexto
    {
        private static Contexto instance;
        public static Contexto GetInstance()
        {
            if (instance == null)
            {
                instance = new Contexto();
            }
            return instance;
        }
    }
}
