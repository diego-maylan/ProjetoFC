﻿using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    interface InterfaceFormula
    {
        void CadastrarFormula(Produto produto);
        void DeleteFormula(Produto produto);
        bool VerificarDuplicidadeFormula(Produto produto);
        List<MateriaPrima> SelectFormula(Produto filtro);
    }
}
