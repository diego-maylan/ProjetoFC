﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ProjetoFabricaCosmeticos.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerificarDuplicidadeOperationCompleted;
        
        private System.Threading.SendOrPostCallback SelectOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::ProjetoFabricaCosmeticos.Properties.Settings.Default.ProjetoFabricaCosmeticos_localhost_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event InsertCompletedEventHandler InsertCompleted;
        
        /// <remarks/>
        public event UpdateCompletedEventHandler UpdateCompleted;
        
        /// <remarks/>
        public event DeleteCompletedEventHandler DeleteCompleted;
        
        /// <remarks/>
        public event VerificarDuplicidadeCompletedEventHandler VerificarDuplicidadeCompleted;
        
        /// <remarks/>
        public event SelectCompletedEventHandler SelectCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/Insert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Insert([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Fornecedor fornecedor) {
            this.Invoke("Insert", new object[] {
                        fornecedor});
        }
        
        /// <remarks/>
        public void InsertAsync(Fornecedor fornecedor) {
            this.InsertAsync(fornecedor, null);
        }
        
        /// <remarks/>
        public void InsertAsync(Fornecedor fornecedor, object userState) {
            if ((this.InsertOperationCompleted == null)) {
                this.InsertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertOperationCompleted);
            }
            this.InvokeAsync("Insert", new object[] {
                        fornecedor}, this.InsertOperationCompleted, userState);
        }
        
        private void OnInsertOperationCompleted(object arg) {
            if ((this.InsertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/Update", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Update([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Fornecedor fornecedor) {
            this.Invoke("Update", new object[] {
                        fornecedor});
        }
        
        /// <remarks/>
        public void UpdateAsync(Fornecedor fornecedor) {
            this.UpdateAsync(fornecedor, null);
        }
        
        /// <remarks/>
        public void UpdateAsync(Fornecedor fornecedor, object userState) {
            if ((this.UpdateOperationCompleted == null)) {
                this.UpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateOperationCompleted);
            }
            this.InvokeAsync("Update", new object[] {
                        fornecedor}, this.UpdateOperationCompleted, userState);
        }
        
        private void OnUpdateOperationCompleted(object arg) {
            if ((this.UpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/Delete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Fornecedor fornecedor) {
            this.Invoke("Delete", new object[] {
                        fornecedor});
        }
        
        /// <remarks/>
        public void DeleteAsync(Fornecedor fornecedor) {
            this.DeleteAsync(fornecedor, null);
        }
        
        /// <remarks/>
        public void DeleteAsync(Fornecedor fornecedor, object userState) {
            if ((this.DeleteOperationCompleted == null)) {
                this.DeleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteOperationCompleted);
            }
            this.InvokeAsync("Delete", new object[] {
                        fornecedor}, this.DeleteOperationCompleted, userState);
        }
        
        private void OnDeleteOperationCompleted(object arg) {
            if ((this.DeleteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/VerificarDuplicidade", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VerificarDuplicidade([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Fornecedor fornecedor, out bool VerificarDuplicidadeResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool VerificarDuplicidadeResultSpecified) {
            object[] results = this.Invoke("VerificarDuplicidade", new object[] {
                        fornecedor});
            VerificarDuplicidadeResult = ((bool)(results[0]));
            VerificarDuplicidadeResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void VerificarDuplicidadeAsync(Fornecedor fornecedor) {
            this.VerificarDuplicidadeAsync(fornecedor, null);
        }
        
        /// <remarks/>
        public void VerificarDuplicidadeAsync(Fornecedor fornecedor, object userState) {
            if ((this.VerificarDuplicidadeOperationCompleted == null)) {
                this.VerificarDuplicidadeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerificarDuplicidadeOperationCompleted);
            }
            this.InvokeAsync("VerificarDuplicidade", new object[] {
                        fornecedor}, this.VerificarDuplicidadeOperationCompleted, userState);
        }
        
        private void OnVerificarDuplicidadeOperationCompleted(object arg) {
            if ((this.VerificarDuplicidadeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerificarDuplicidadeCompleted(this, new VerificarDuplicidadeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/Select", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.Classes_Basicas")]
        public Fornecedor[] Select([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Fornecedor filtro) {
            object[] results = this.Invoke("Select", new object[] {
                        filtro});
            return ((Fornecedor[])(results[0]));
        }
        
        /// <remarks/>
        public void SelectAsync(Fornecedor filtro) {
            this.SelectAsync(filtro, null);
        }
        
        /// <remarks/>
        public void SelectAsync(Fornecedor filtro, object userState) {
            if ((this.SelectOperationCompleted == null)) {
                this.SelectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectOperationCompleted);
            }
            this.InvokeAsync("Select", new object[] {
                        filtro}, this.SelectOperationCompleted, userState);
        }
        
        private void OnSelectOperationCompleted(object arg) {
            if ((this.SelectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectCompleted(this, new SelectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.Classes_Basicas")]
    public partial class Fornecedor {
        
        private string bairroField;
        
        private string cepField;
        
        private string cidadeField;
        
        private string cnpjField;
        
        private string complementoField;
        
        private Compra[] compraField;
        
        private string emailField;
        
        private string estadoField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string logradouroField;
        
        private string razaoSocialField;
        
        private string telefoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Bairro {
            get {
                return this.bairroField;
            }
            set {
                this.bairroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Cep {
            get {
                return this.cepField;
            }
            set {
                this.cepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Cidade {
            get {
                return this.cidadeField;
            }
            set {
                this.cidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Cnpj {
            get {
                return this.cnpjField;
            }
            set {
                this.cnpjField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Complemento {
            get {
                return this.complementoField;
            }
            set {
                this.complementoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Compra[] Compra {
            get {
                return this.compraField;
            }
            set {
                this.compraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Logradouro {
            get {
                return this.logradouroField;
            }
            set {
                this.logradouroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string RazaoSocial {
            get {
                return this.razaoSocialField;
            }
            set {
                this.razaoSocialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Telefone {
            get {
                return this.telefoneField;
            }
            set {
                this.telefoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.Classes_Basicas")]
    public partial class Compra {
        
        private Fornecedor fornecedorField;
        
        private Fornecedor fornecedor1Field;
        
        private Fornecedor fornecedor2Field;
        
        private MateriaPrima materiaPrimaField;
        
        private MateriaPrima materiaPrima1Field;
        
        private MateriaPrima materiaPrima2Field;
        
        private double precoField;
        
        private bool precoFieldSpecified;
        
        private int quantidadeField;
        
        private bool quantidadeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Fornecedor Fornecedor {
            get {
                return this.fornecedorField;
            }
            set {
                this.fornecedorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Fornecedor Fornecedor1 {
            get {
                return this.fornecedor1Field;
            }
            set {
                this.fornecedor1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Fornecedor Fornecedor2 {
            get {
                return this.fornecedor2Field;
            }
            set {
                this.fornecedor2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public MateriaPrima MateriaPrima {
            get {
                return this.materiaPrimaField;
            }
            set {
                this.materiaPrimaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public MateriaPrima MateriaPrima1 {
            get {
                return this.materiaPrima1Field;
            }
            set {
                this.materiaPrima1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public MateriaPrima MateriaPrima2 {
            get {
                return this.materiaPrima2Field;
            }
            set {
                this.materiaPrima2Field = value;
            }
        }
        
        /// <remarks/>
        public double Preco {
            get {
                return this.precoField;
            }
            set {
                this.precoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrecoSpecified {
            get {
                return this.precoFieldSpecified;
            }
            set {
                this.precoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Quantidade {
            get {
                return this.quantidadeField;
            }
            set {
                this.quantidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantidadeSpecified {
            get {
                return this.quantidadeFieldSpecified;
            }
            set {
                this.quantidadeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.Classes_Basicas")]
    public partial class MateriaPrima {
        
        private string descricaoField;
        
        private int estoqueAtualField;
        
        private bool estoqueAtualFieldSpecified;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string loteField;
        
        private string nomeField;
        
        private Produto[] produtoField;
        
        private Produto produto1Field;
        
        private System.DateTime validadeField;
        
        private bool validadeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        public int EstoqueAtual {
            get {
                return this.estoqueAtualField;
            }
            set {
                this.estoqueAtualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstoqueAtualSpecified {
            get {
                return this.estoqueAtualFieldSpecified;
            }
            set {
                this.estoqueAtualFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Lote {
            get {
                return this.loteField;
            }
            set {
                this.loteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Produto[] Produto {
            get {
                return this.produtoField;
            }
            set {
                this.produtoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Produto Produto1 {
            get {
                return this.produto1Field;
            }
            set {
                this.produto1Field = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Validade {
            get {
                return this.validadeField;
            }
            set {
                this.validadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidadeSpecified {
            get {
                return this.validadeFieldSpecified;
            }
            set {
                this.validadeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.Classes_Basicas")]
    public partial class Produto {
        
        private string descricaoField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private MateriaPrima[] materiaPrimaField;
        
        private string nomeField;
        
        private string unidadeFornecimentoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public MateriaPrima[] MateriaPrima {
            get {
                return this.materiaPrimaField;
            }
            set {
                this.materiaPrimaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UnidadeFornecimento {
            get {
                return this.unidadeFornecimentoField;
            }
            set {
                this.unidadeFornecimentoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void InsertCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void UpdateCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void DeleteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void VerificarDuplicidadeCompletedEventHandler(object sender, VerificarDuplicidadeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerificarDuplicidadeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerificarDuplicidadeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool VerificarDuplicidadeResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool VerificarDuplicidadeResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void SelectCompletedEventHandler(object sender, SelectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Fornecedor[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Fornecedor[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591