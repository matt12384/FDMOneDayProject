﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneDayProjectMvc.BasketServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BasketServiceReference.IBasketService")]
    public interface IBasketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketService/CreateBasket", ReplyAction="http://tempuri.org/IBasketService/CreateBasketResponse")]
        void CreateBasket(int userId, ModelPoco.Basket basket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketService/CreateBasket", ReplyAction="http://tempuri.org/IBasketService/CreateBasketResponse")]
        System.Threading.Tasks.Task CreateBasketAsync(int userId, ModelPoco.Basket basket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketService/GetCurrentBasketIdFromUsername", ReplyAction="http://tempuri.org/IBasketService/GetCurrentBasketIdFromUsernameResponse")]
        int GetCurrentBasketIdFromUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketService/GetCurrentBasketIdFromUsername", ReplyAction="http://tempuri.org/IBasketService/GetCurrentBasketIdFromUsernameResponse")]
        System.Threading.Tasks.Task<int> GetCurrentBasketIdFromUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketService/GetProductsInCurrentBasket", ReplyAction="http://tempuri.org/IBasketService/GetProductsInCurrentBasketResponse")]
        System.Collections.Generic.List<ModelPoco.Product> GetProductsInCurrentBasket(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketService/GetProductsInCurrentBasket", ReplyAction="http://tempuri.org/IBasketService/GetProductsInCurrentBasketResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ModelPoco.Product>> GetProductsInCurrentBasketAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBasketServiceChannel : OneDayProjectMvc.BasketServiceReference.IBasketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BasketServiceClient : System.ServiceModel.ClientBase<OneDayProjectMvc.BasketServiceReference.IBasketService>, OneDayProjectMvc.BasketServiceReference.IBasketService {
        
        public BasketServiceClient() {
        }
        
        public BasketServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BasketServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasketServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateBasket(int userId, ModelPoco.Basket basket) {
            base.Channel.CreateBasket(userId, basket);
        }
        
        public System.Threading.Tasks.Task CreateBasketAsync(int userId, ModelPoco.Basket basket) {
            return base.Channel.CreateBasketAsync(userId, basket);
        }
        
        public int GetCurrentBasketIdFromUsername(string username) {
            return base.Channel.GetCurrentBasketIdFromUsername(username);
        }
        
        public System.Threading.Tasks.Task<int> GetCurrentBasketIdFromUsernameAsync(string username) {
            return base.Channel.GetCurrentBasketIdFromUsernameAsync(username);
        }
        
        public System.Collections.Generic.List<ModelPoco.Product> GetProductsInCurrentBasket(string username) {
            return base.Channel.GetProductsInCurrentBasket(username);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ModelPoco.Product>> GetProductsInCurrentBasketAsync(string username) {
            return base.Channel.GetProductsInCurrentBasketAsync(username);
        }
    }
}