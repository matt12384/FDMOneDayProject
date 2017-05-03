﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneDayProjectMvc.BasketItemServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BasketItemServiceReference.IBasketItemService")]
    public interface IBasketItemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketItemService/PopulateBasketAndProductKeys", ReplyAction="http://tempuri.org/IBasketItemService/PopulateBasketAndProductKeysResponse")]
        void PopulateBasketAndProductKeys(int basketId, int productId, ModelPoco.BasketItem basketItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketItemService/PopulateBasketAndProductKeys", ReplyAction="http://tempuri.org/IBasketItemService/PopulateBasketAndProductKeysResponse")]
        System.Threading.Tasks.Task PopulateBasketAndProductKeysAsync(int basketId, int productId, ModelPoco.BasketItem basketItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketItemService/RemoveItemFromBasket", ReplyAction="http://tempuri.org/IBasketItemService/RemoveItemFromBasketResponse")]
        void RemoveItemFromBasket(int basketId, int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketItemService/RemoveItemFromBasket", ReplyAction="http://tempuri.org/IBasketItemService/RemoveItemFromBasketResponse")]
        System.Threading.Tasks.Task RemoveItemFromBasketAsync(int basketId, int productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBasketItemServiceChannel : OneDayProjectMvc.BasketItemServiceReference.IBasketItemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BasketItemServiceClient : System.ServiceModel.ClientBase<OneDayProjectMvc.BasketItemServiceReference.IBasketItemService>, OneDayProjectMvc.BasketItemServiceReference.IBasketItemService {
        
        public BasketItemServiceClient() {
        }
        
        public BasketItemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BasketItemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasketItemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasketItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void PopulateBasketAndProductKeys(int basketId, int productId, ModelPoco.BasketItem basketItem) {
            base.Channel.PopulateBasketAndProductKeys(basketId, productId, basketItem);
        }
        
        public System.Threading.Tasks.Task PopulateBasketAndProductKeysAsync(int basketId, int productId, ModelPoco.BasketItem basketItem) {
            return base.Channel.PopulateBasketAndProductKeysAsync(basketId, productId, basketItem);
        }
        
        public void RemoveItemFromBasket(int basketId, int productId) {
            base.Channel.RemoveItemFromBasket(basketId, productId);
        }
        
        public System.Threading.Tasks.Task RemoveItemFromBasketAsync(int basketId, int productId) {
            return base.Channel.RemoveItemFromBasketAsync(basketId, productId);
        }
    }
}
