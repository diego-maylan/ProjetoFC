﻿using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        
        void Insert(Fornecedor fornecedor);
        [OperationContract]
        void Update(Fornecedor fornecedor);
        [OperationContract]
        void Delete(Fornecedor fornecedor);
        [OperationContract]
        bool VerificarDuplicidade(Fornecedor fornecedor);
        [OperationContract]
        List<Fornecedor> Select(Fornecedor filtro);


        #region ações Produto
        [OperationContract]
        void Insert(Produto produto);
        [OperationContract]
        void Update(Produto produto);
        [OperationContract]
        void Delete(Produto produto);
        [OperationContract]
        bool VerificarDuplicidade(Produto produto);
        [OperationContract]
        List<Produto> Select(Produto filtro);
        #endregion


        #region ações Materia Prima
        [OperationContract]
        void Insert(MateriaPrima materiaprima);
        [OperationContract]
        void Update(MateriaPrima materiaprima);
        [OperationContract]
        void Delete(MateriaPrima materiaprima);
        [OperationContract]
        bool VerificarDuplicidade(MateriaPrima materiaprima);
        [OperationContract]
        List<MateriaPrima> Select(MateriaPrima filtro);
        #endregion

        void CadastrarFormula(Produto p);
        Produto SelectFormula(Produto filtro);

        void Insert(Compra compra);
        void Update(Compra compra);
        void Delete(Compra compra);
        bool VerificarDuplicidade(Compra compra);
        List<Compra> Select(Compra compra);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}