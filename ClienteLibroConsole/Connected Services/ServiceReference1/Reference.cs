﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteLibroConsole.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Libro", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Libro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        private int AñoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Año {
            get {
                return this.AñoField;
            }
            set {
                if ((this.AñoField.Equals(value) != true)) {
                    this.AñoField = value;
                    this.RaisePropertyChanged("Año");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.LibroServiceSoap")]
    public interface LibroServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento titulo del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CrearLibro", ReplyAction="*")]
        ClienteLibroConsole.ServiceReference1.CrearLibroResponse CrearLibro(ClienteLibroConsole.ServiceReference1.CrearLibroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CrearLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.CrearLibroResponse> CrearLibroAsync(ClienteLibroConsole.ServiceReference1.CrearLibroRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento LeerLibrosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LeerLibros", ReplyAction="*")]
        ClienteLibroConsole.ServiceReference1.LeerLibrosResponse LeerLibros(ClienteLibroConsole.ServiceReference1.LeerLibrosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LeerLibros", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.LeerLibrosResponse> LeerLibrosAsync(ClienteLibroConsole.ServiceReference1.LeerLibrosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento titulo del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarLibro", ReplyAction="*")]
        ClienteLibroConsole.ServiceReference1.ActualizarLibroResponse ActualizarLibro(ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.ActualizarLibroResponse> ActualizarLibroAsync(ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento EliminarLibroResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarLibro", ReplyAction="*")]
        ClienteLibroConsole.ServiceReference1.EliminarLibroResponse EliminarLibro(ClienteLibroConsole.ServiceReference1.EliminarLibroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.EliminarLibroResponse> EliminarLibroAsync(ClienteLibroConsole.ServiceReference1.EliminarLibroRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearLibroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearLibro", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.CrearLibroRequestBody Body;
        
        public CrearLibroRequest() {
        }
        
        public CrearLibroRequest(ClienteLibroConsole.ServiceReference1.CrearLibroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CrearLibroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string titulo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string autor;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string isbn;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int año;
        
        public CrearLibroRequestBody() {
        }
        
        public CrearLibroRequestBody(string titulo, string autor, string isbn, int año) {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.año = año;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearLibroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearLibroResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.CrearLibroResponseBody Body;
        
        public CrearLibroResponse() {
        }
        
        public CrearLibroResponse(ClienteLibroConsole.ServiceReference1.CrearLibroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CrearLibroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CrearLibroResult;
        
        public CrearLibroResponseBody() {
        }
        
        public CrearLibroResponseBody(string CrearLibroResult) {
            this.CrearLibroResult = CrearLibroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LeerLibrosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LeerLibros", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.LeerLibrosRequestBody Body;
        
        public LeerLibrosRequest() {
        }
        
        public LeerLibrosRequest(ClienteLibroConsole.ServiceReference1.LeerLibrosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class LeerLibrosRequestBody {
        
        public LeerLibrosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LeerLibrosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LeerLibrosResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.LeerLibrosResponseBody Body;
        
        public LeerLibrosResponse() {
        }
        
        public LeerLibrosResponse(ClienteLibroConsole.ServiceReference1.LeerLibrosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LeerLibrosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClienteLibroConsole.ServiceReference1.Libro[] LeerLibrosResult;
        
        public LeerLibrosResponseBody() {
        }
        
        public LeerLibrosResponseBody(ClienteLibroConsole.ServiceReference1.Libro[] LeerLibrosResult) {
            this.LeerLibrosResult = LeerLibrosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarLibroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizarLibro", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.ActualizarLibroRequestBody Body;
        
        public ActualizarLibroRequest() {
        }
        
        public ActualizarLibroRequest(ClienteLibroConsole.ServiceReference1.ActualizarLibroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ActualizarLibroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string titulo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string autor;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string isbn;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int año;
        
        public ActualizarLibroRequestBody() {
        }
        
        public ActualizarLibroRequestBody(int id, string titulo, string autor, string isbn, int año) {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.año = año;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarLibroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizarLibroResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.ActualizarLibroResponseBody Body;
        
        public ActualizarLibroResponse() {
        }
        
        public ActualizarLibroResponse(ClienteLibroConsole.ServiceReference1.ActualizarLibroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ActualizarLibroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ActualizarLibroResult;
        
        public ActualizarLibroResponseBody() {
        }
        
        public ActualizarLibroResponseBody(string ActualizarLibroResult) {
            this.ActualizarLibroResult = ActualizarLibroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarLibroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarLibro", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.EliminarLibroRequestBody Body;
        
        public EliminarLibroRequest() {
        }
        
        public EliminarLibroRequest(ClienteLibroConsole.ServiceReference1.EliminarLibroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarLibroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public EliminarLibroRequestBody() {
        }
        
        public EliminarLibroRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarLibroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarLibroResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteLibroConsole.ServiceReference1.EliminarLibroResponseBody Body;
        
        public EliminarLibroResponse() {
        }
        
        public EliminarLibroResponse(ClienteLibroConsole.ServiceReference1.EliminarLibroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarLibroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EliminarLibroResult;
        
        public EliminarLibroResponseBody() {
        }
        
        public EliminarLibroResponseBody(string EliminarLibroResult) {
            this.EliminarLibroResult = EliminarLibroResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LibroServiceSoapChannel : ClienteLibroConsole.ServiceReference1.LibroServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibroServiceSoapClient : System.ServiceModel.ClientBase<ClienteLibroConsole.ServiceReference1.LibroServiceSoap>, ClienteLibroConsole.ServiceReference1.LibroServiceSoap {
        
        public LibroServiceSoapClient() {
        }
        
        public LibroServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibroServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibroServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibroServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteLibroConsole.ServiceReference1.CrearLibroResponse ClienteLibroConsole.ServiceReference1.LibroServiceSoap.CrearLibro(ClienteLibroConsole.ServiceReference1.CrearLibroRequest request) {
            return base.Channel.CrearLibro(request);
        }
        
        public string CrearLibro(string titulo, string autor, string isbn, int año) {
            ClienteLibroConsole.ServiceReference1.CrearLibroRequest inValue = new ClienteLibroConsole.ServiceReference1.CrearLibroRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.CrearLibroRequestBody();
            inValue.Body.titulo = titulo;
            inValue.Body.autor = autor;
            inValue.Body.isbn = isbn;
            inValue.Body.año = año;
            ClienteLibroConsole.ServiceReference1.CrearLibroResponse retVal = ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).CrearLibro(inValue);
            return retVal.Body.CrearLibroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.CrearLibroResponse> ClienteLibroConsole.ServiceReference1.LibroServiceSoap.CrearLibroAsync(ClienteLibroConsole.ServiceReference1.CrearLibroRequest request) {
            return base.Channel.CrearLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.CrearLibroResponse> CrearLibroAsync(string titulo, string autor, string isbn, int año) {
            ClienteLibroConsole.ServiceReference1.CrearLibroRequest inValue = new ClienteLibroConsole.ServiceReference1.CrearLibroRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.CrearLibroRequestBody();
            inValue.Body.titulo = titulo;
            inValue.Body.autor = autor;
            inValue.Body.isbn = isbn;
            inValue.Body.año = año;
            return ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).CrearLibroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteLibroConsole.ServiceReference1.LeerLibrosResponse ClienteLibroConsole.ServiceReference1.LibroServiceSoap.LeerLibros(ClienteLibroConsole.ServiceReference1.LeerLibrosRequest request) {
            return base.Channel.LeerLibros(request);
        }
        
        public ClienteLibroConsole.ServiceReference1.Libro[] LeerLibros() {
            ClienteLibroConsole.ServiceReference1.LeerLibrosRequest inValue = new ClienteLibroConsole.ServiceReference1.LeerLibrosRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.LeerLibrosRequestBody();
            ClienteLibroConsole.ServiceReference1.LeerLibrosResponse retVal = ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).LeerLibros(inValue);
            return retVal.Body.LeerLibrosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.LeerLibrosResponse> ClienteLibroConsole.ServiceReference1.LibroServiceSoap.LeerLibrosAsync(ClienteLibroConsole.ServiceReference1.LeerLibrosRequest request) {
            return base.Channel.LeerLibrosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.LeerLibrosResponse> LeerLibrosAsync() {
            ClienteLibroConsole.ServiceReference1.LeerLibrosRequest inValue = new ClienteLibroConsole.ServiceReference1.LeerLibrosRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.LeerLibrosRequestBody();
            return ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).LeerLibrosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteLibroConsole.ServiceReference1.ActualizarLibroResponse ClienteLibroConsole.ServiceReference1.LibroServiceSoap.ActualizarLibro(ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest request) {
            return base.Channel.ActualizarLibro(request);
        }
        
        public string ActualizarLibro(int id, string titulo, string autor, string isbn, int año) {
            ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest inValue = new ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.ActualizarLibroRequestBody();
            inValue.Body.id = id;
            inValue.Body.titulo = titulo;
            inValue.Body.autor = autor;
            inValue.Body.isbn = isbn;
            inValue.Body.año = año;
            ClienteLibroConsole.ServiceReference1.ActualizarLibroResponse retVal = ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).ActualizarLibro(inValue);
            return retVal.Body.ActualizarLibroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.ActualizarLibroResponse> ClienteLibroConsole.ServiceReference1.LibroServiceSoap.ActualizarLibroAsync(ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest request) {
            return base.Channel.ActualizarLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.ActualizarLibroResponse> ActualizarLibroAsync(int id, string titulo, string autor, string isbn, int año) {
            ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest inValue = new ClienteLibroConsole.ServiceReference1.ActualizarLibroRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.ActualizarLibroRequestBody();
            inValue.Body.id = id;
            inValue.Body.titulo = titulo;
            inValue.Body.autor = autor;
            inValue.Body.isbn = isbn;
            inValue.Body.año = año;
            return ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).ActualizarLibroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteLibroConsole.ServiceReference1.EliminarLibroResponse ClienteLibroConsole.ServiceReference1.LibroServiceSoap.EliminarLibro(ClienteLibroConsole.ServiceReference1.EliminarLibroRequest request) {
            return base.Channel.EliminarLibro(request);
        }
        
        public string EliminarLibro(int id) {
            ClienteLibroConsole.ServiceReference1.EliminarLibroRequest inValue = new ClienteLibroConsole.ServiceReference1.EliminarLibroRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.EliminarLibroRequestBody();
            inValue.Body.id = id;
            ClienteLibroConsole.ServiceReference1.EliminarLibroResponse retVal = ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).EliminarLibro(inValue);
            return retVal.Body.EliminarLibroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.EliminarLibroResponse> ClienteLibroConsole.ServiceReference1.LibroServiceSoap.EliminarLibroAsync(ClienteLibroConsole.ServiceReference1.EliminarLibroRequest request) {
            return base.Channel.EliminarLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteLibroConsole.ServiceReference1.EliminarLibroResponse> EliminarLibroAsync(int id) {
            ClienteLibroConsole.ServiceReference1.EliminarLibroRequest inValue = new ClienteLibroConsole.ServiceReference1.EliminarLibroRequest();
            inValue.Body = new ClienteLibroConsole.ServiceReference1.EliminarLibroRequestBody();
            inValue.Body.id = id;
            return ((ClienteLibroConsole.ServiceReference1.LibroServiceSoap)(this)).EliminarLibroAsync(inValue);
        }
    }
}
