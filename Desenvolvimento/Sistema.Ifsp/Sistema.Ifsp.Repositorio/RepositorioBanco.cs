﻿using Sistema.Ifsp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Classe responsável pela aplicação do SINGLETON na classe contexto
    de maneira que apenas uma instância do classe BancoContexto exista na memoria Ram
*/
namespace Sistema.Ifsp.Repositorio
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