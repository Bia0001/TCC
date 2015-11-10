using System;
using System.Security.Cryptography;
using System.Text;

namespace Sistema.Ifsp.Model
{
    public static class Cripitografia
    {
        public static string encripto(string textoOriginal)
        {
            byte[] byteSenhaOrigianal;
            byte[] codificar;
            MD5 md5;

            md5 = new MD5CryptoServiceProvider();
            byteSenhaOrigianal =  ASCIIEncoding.Default.GetBytes(textoOriginal);
            codificar = md5.ComputeHash(byteSenhaOrigianal);

            return Convert.ToBase64String(codificar);
        }
    }
}
