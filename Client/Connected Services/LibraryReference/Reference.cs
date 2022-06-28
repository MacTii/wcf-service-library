﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.LibraryReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.LibraryReference.Author[] AuthorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.LibraryReference.Author[] Authors {
            get {
                return this.AuthorsField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorsField, value) != true)) {
                    this.AuthorsField = value;
                    this.RaisePropertyChanged("Authors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((this.BookIdField.Equals(value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorHandler", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ErrorHandler : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibraryReference.ILibrary")]
    public interface ILibrary {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/GetBookById", ReplyAction="http://tempuri.org/ILibrary/GetBookByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.LibraryReference.ErrorHandler), Action="http://tempuri.org/ILibrary/GetBookByIdErrorHandlerFault", Name="ErrorHandler", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
        Client.LibraryReference.Book GetBookById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/GetBookById", ReplyAction="http://tempuri.org/ILibrary/GetBookByIdResponse")]
        System.Threading.Tasks.Task<Client.LibraryReference.Book> GetBookByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/GetBookByTitle", ReplyAction="http://tempuri.org/ILibrary/GetBookByTitleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.LibraryReference.ErrorHandler), Action="http://tempuri.org/ILibrary/GetBookByTitleErrorHandlerFault", Name="ErrorHandler", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
        Client.LibraryReference.Book[] GetBookByTitle(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/GetBookByTitle", ReplyAction="http://tempuri.org/ILibrary/GetBookByTitleResponse")]
        System.Threading.Tasks.Task<Client.LibraryReference.Book[]> GetBookByTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/GetBookByAuthor", ReplyAction="http://tempuri.org/ILibrary/GetBookByAuthorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.LibraryReference.ErrorHandler), Action="http://tempuri.org/ILibrary/GetBookByAuthorErrorHandlerFault", Name="ErrorHandler", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
        Client.LibraryReference.Book[] GetBookByAuthor(string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/GetBookByAuthor", ReplyAction="http://tempuri.org/ILibrary/GetBookByAuthorResponse")]
        System.Threading.Tasks.Task<Client.LibraryReference.Book[]> GetBookByAuthorAsync(string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/Output", ReplyAction="http://tempuri.org/ILibrary/OutputResponse")]
        string Output(Client.LibraryReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibrary/Output", ReplyAction="http://tempuri.org/ILibrary/OutputResponse")]
        System.Threading.Tasks.Task<string> OutputAsync(Client.LibraryReference.Book book);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryChannel : Client.LibraryReference.ILibrary, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryClient : System.ServiceModel.ClientBase<Client.LibraryReference.ILibrary>, Client.LibraryReference.ILibrary {
        
        public LibraryClient() {
        }
        
        public LibraryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.LibraryReference.Book GetBookById(int id) {
            return base.Channel.GetBookById(id);
        }
        
        public System.Threading.Tasks.Task<Client.LibraryReference.Book> GetBookByIdAsync(int id) {
            return base.Channel.GetBookByIdAsync(id);
        }
        
        public Client.LibraryReference.Book[] GetBookByTitle(string title) {
            return base.Channel.GetBookByTitle(title);
        }
        
        public System.Threading.Tasks.Task<Client.LibraryReference.Book[]> GetBookByTitleAsync(string title) {
            return base.Channel.GetBookByTitleAsync(title);
        }
        
        public Client.LibraryReference.Book[] GetBookByAuthor(string author) {
            return base.Channel.GetBookByAuthor(author);
        }
        
        public System.Threading.Tasks.Task<Client.LibraryReference.Book[]> GetBookByAuthorAsync(string author) {
            return base.Channel.GetBookByAuthorAsync(author);
        }
        
        public string Output(Client.LibraryReference.Book book) {
            return base.Channel.Output(book);
        }
        
        public System.Threading.Tasks.Task<string> OutputAsync(Client.LibraryReference.Book book) {
            return base.Channel.OutputAsync(book);
        }
    }
}