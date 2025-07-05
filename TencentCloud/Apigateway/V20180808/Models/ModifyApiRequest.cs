/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApiRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique service ID of API.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// API backend service type. Valid values: HTTP, MOCK, TSF, CLB, SCF, WEBSOCKET, TARGET (in beta test).
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Request frontend configuration.
        /// </summary>
        [JsonProperty("RequestConfig")]
        public RequestConfig RequestConfig{ get; set; }

        /// <summary>
        /// Unique API ID.
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// Custom API name.
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// Custom API description.
        /// </summary>
        [JsonProperty("ApiDesc")]
        public string ApiDesc{ get; set; }

        /// <summary>
        /// API type. Valid values: NORMAL, TSF. Default value: NORMAL.
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// API authentication type. Valid values: SECRET, NONE, OAUTH, APP. Default value: NONE.
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// Whether signature authentication is required. True: yes; False: no. This parameter is to be disused.
        /// </summary>
        [JsonProperty("AuthRequired")]
        public bool? AuthRequired{ get; set; }

        /// <summary>
        /// API backend service timeout period in seconds.
        /// </summary>
        [JsonProperty("ServiceTimeout")]
        public long? ServiceTimeout{ get; set; }

        /// <summary>
        /// API frontend request type, such as HTTP, HTTPS, or HTTP and HTTPS.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Whether to enable CORS. True: yes; False: no.
        /// </summary>
        [JsonProperty("EnableCORS")]
        public bool? EnableCORS{ get; set; }

        /// <summary>
        /// Constant parameter.
        /// </summary>
        [JsonProperty("ConstantParameters")]
        public ConstantParameter[] ConstantParameters{ get; set; }

        /// <summary>
        /// Frontend request parameter.
        /// </summary>
        [JsonProperty("RequestParameters")]
        public ReqParameter[] RequestParameters{ get; set; }

        /// <summary>
        /// This field is valid if `AuthType` is `OAUTH`. NORMAL: business API; OAUTH: authorization API.
        /// </summary>
        [JsonProperty("ApiBusinessType")]
        public string ApiBusinessType{ get; set; }

        /// <summary>
        /// Returned message of API backend Mock, which is required if `ServiceType` is `Mock`.
        /// </summary>
        [JsonProperty("ServiceMockReturnMessage")]
        public string ServiceMockReturnMessage{ get; set; }

        /// <summary>
        /// List of microservices bound to API.
        /// </summary>
        [JsonProperty("MicroServices")]
        public MicroServiceReq[] MicroServices{ get; set; }

        /// <summary>
        /// Load balancing configuration of microservice.
        /// </summary>
        [JsonProperty("ServiceTsfLoadBalanceConf")]
        public TsfLoadBalanceConfResp ServiceTsfLoadBalanceConf{ get; set; }

        /// <summary>
        /// Health check configuration of microservice.
        /// </summary>
        [JsonProperty("ServiceTsfHealthCheckConf")]
        public HealthCheckConf ServiceTsfHealthCheckConf{ get; set; }

        /// <summary>
        /// `target` type load balancing configuration (in beta test).
        /// </summary>
        [JsonProperty("TargetServicesLoadBalanceConf")]
        public long? TargetServicesLoadBalanceConf{ get; set; }

        /// <summary>
        /// `target` health check configuration (in beta test).
        /// </summary>
        [JsonProperty("TargetServicesHealthCheckConf")]
        public HealthCheckConf TargetServicesHealthCheckConf{ get; set; }

        /// <summary>
        /// SCF function name, which takes effect if the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfFunctionName")]
        public string ServiceScfFunctionName{ get; set; }

        /// <summary>
        /// SCF WebSocket registration function, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionName")]
        public string ServiceWebsocketRegisterFunctionName{ get; set; }

        /// <summary>
        /// SCF WebSocket cleanup function, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionName")]
        public string ServiceWebsocketCleanupFunctionName{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionName")]
        public string ServiceWebsocketTransportFunctionName{ get; set; }

        /// <summary>
        /// SCF function namespace, which takes effect if the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfFunctionNamespace")]
        public string ServiceScfFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF function version, which takes effect if the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfFunctionQualifier")]
        public string ServiceScfFunctionQualifier{ get; set; }

        /// <summary>
        /// SCF WebSocket registration function namespace, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionNamespace")]
        public string ServiceWebsocketRegisterFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function version, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionQualifier")]
        public string ServiceWebsocketRegisterFunctionQualifier{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function namespace, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionNamespace")]
        public string ServiceWebsocketTransportFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function version, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionQualifier")]
        public string ServiceWebsocketTransportFunctionQualifier{ get; set; }

        /// <summary>
        /// SCF WebSocket cleanup function namespace, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionNamespace")]
        public string ServiceWebsocketCleanupFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF WebSocket cleanup function version, which takes effect if the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionQualifier")]
        public string ServiceWebsocketCleanupFunctionQualifier{ get; set; }

        /// <summary>
        /// Whether to enable response integration, which takes effect if the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfIsIntegratedResponse")]
        public bool? ServiceScfIsIntegratedResponse{ get; set; }

        /// <summary>
        /// Billing after debugging starts (reserved field for marketplace).
        /// </summary>
        [JsonProperty("IsDebugAfterCharge")]
        public bool? IsDebugAfterCharge{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("TagSpecifications")]
        public Tag TagSpecifications{ get; set; }

        /// <summary>
        /// Whether to delete the error codes for custom response configuration. If the value is left empty or `False`, the error codes will not be deleted. If the value is `True`, all custom response configuration error codes of the API will be deleted.
        /// </summary>
        [JsonProperty("IsDeleteResponseErrorCodes")]
        public bool? IsDeleteResponseErrorCodes{ get; set; }

        /// <summary>
        /// Return type.
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// Sample response for successful custom response configuration.
        /// </summary>
        [JsonProperty("ResponseSuccessExample")]
        public string ResponseSuccessExample{ get; set; }

        /// <summary>
        /// Sample response for failed custom response configuration.
        /// </summary>
        [JsonProperty("ResponseFailExample")]
        public string ResponseFailExample{ get; set; }

        /// <summary>
        /// API backend service configuration.
        /// </summary>
        [JsonProperty("ServiceConfig")]
        public ServiceConfig ServiceConfig{ get; set; }

        /// <summary>
        /// Unique ID of associated authorization API, which takes effect only if `AuthType` is `OAUTH` and `ApiBusinessType` is `NORMAL`. It is the unique ID of the OAuth 2.0 authorization API bound to the business API.
        /// </summary>
        [JsonProperty("AuthRelationApiId")]
        public string AuthRelationApiId{ get; set; }

        /// <summary>
        /// API backend service parameter.
        /// </summary>
        [JsonProperty("ServiceParameters")]
        public ServiceParameter[] ServiceParameters{ get; set; }

        /// <summary>
        /// OAuth configuration, which takes effect if `AuthType` is `OAUTH`.
        /// </summary>
        [JsonProperty("OauthConfig")]
        public OauthConfig OauthConfig{ get; set; }

        /// <summary>
        /// Custom error code configuration.
        /// </summary>
        [JsonProperty("ResponseErrorCodes")]
        public ResponseErrorCodeReq[] ResponseErrorCodes{ get; set; }

        /// <summary>
        /// Whether to enable Base64 encoding. This parameter takes effect only when the backend is SCF.
        /// </summary>
        [JsonProperty("IsBase64Encoded")]
        public bool? IsBase64Encoded{ get; set; }

        /// <summary>
        /// Whether to trigger Base64 encoding by header. This parameter takes effect only when the backend is SCF.
        /// </summary>
        [JsonProperty("IsBase64Trigger")]
        public bool? IsBase64Trigger{ get; set; }

        /// <summary>
        /// Header trigger rules. The number of rules cannot exceed 10.
        /// </summary>
        [JsonProperty("Base64EncodedTriggerRules")]
        public Base64EncodedTriggerRule[] Base64EncodedTriggerRules{ get; set; }

        /// <summary>
        /// Event bus ID.
        /// </summary>
        [JsonProperty("EventBusId")]
        public string EventBusId{ get; set; }

        /// <summary>
        /// SCF function type, which takes effect when the backend type is `SCF`. Valid values: `EVENT` and `HTTP`.
        /// </summary>
        [JsonProperty("ServiceScfFunctionType")]
        public string ServiceScfFunctionType{ get; set; }

        /// <summary>
        /// EIAM application type.
        /// </summary>
        [JsonProperty("EIAMAppType")]
        public string EIAMAppType{ get; set; }

        /// <summary>
        /// EIAM application authentication type. Valid values: `AuthenticationOnly`, `Authentication`, `Authorization`.
        /// </summary>
        [JsonProperty("EIAMAuthType")]
        public string EIAMAuthType{ get; set; }

        /// <summary>
        /// Validity of the EIAM application token. Unit: second. Default value: `7200`.
        /// </summary>
        [JsonProperty("EIAMAppId")]
        public string EIAMAppId{ get; set; }

        /// <summary>
        /// EIAM application ID.
        /// </summary>
        [JsonProperty("TokenTimeout")]
        public long? TokenTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamObj(map, prefix + "RequestConfig.", this.RequestConfig);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "ApiDesc", this.ApiDesc);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AuthRequired", this.AuthRequired);
            this.SetParamSimple(map, prefix + "ServiceTimeout", this.ServiceTimeout);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "EnableCORS", this.EnableCORS);
            this.SetParamArrayObj(map, prefix + "ConstantParameters.", this.ConstantParameters);
            this.SetParamArrayObj(map, prefix + "RequestParameters.", this.RequestParameters);
            this.SetParamSimple(map, prefix + "ApiBusinessType", this.ApiBusinessType);
            this.SetParamSimple(map, prefix + "ServiceMockReturnMessage", this.ServiceMockReturnMessage);
            this.SetParamArrayObj(map, prefix + "MicroServices.", this.MicroServices);
            this.SetParamObj(map, prefix + "ServiceTsfLoadBalanceConf.", this.ServiceTsfLoadBalanceConf);
            this.SetParamObj(map, prefix + "ServiceTsfHealthCheckConf.", this.ServiceTsfHealthCheckConf);
            this.SetParamSimple(map, prefix + "TargetServicesLoadBalanceConf", this.TargetServicesLoadBalanceConf);
            this.SetParamObj(map, prefix + "TargetServicesHealthCheckConf.", this.TargetServicesHealthCheckConf);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionName", this.ServiceScfFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionName", this.ServiceWebsocketRegisterFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionName", this.ServiceWebsocketCleanupFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionName", this.ServiceWebsocketTransportFunctionName);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionNamespace", this.ServiceScfFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionQualifier", this.ServiceScfFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionNamespace", this.ServiceWebsocketRegisterFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionQualifier", this.ServiceWebsocketRegisterFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionNamespace", this.ServiceWebsocketTransportFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionQualifier", this.ServiceWebsocketTransportFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionNamespace", this.ServiceWebsocketCleanupFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionQualifier", this.ServiceWebsocketCleanupFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceScfIsIntegratedResponse", this.ServiceScfIsIntegratedResponse);
            this.SetParamSimple(map, prefix + "IsDebugAfterCharge", this.IsDebugAfterCharge);
            this.SetParamObj(map, prefix + "TagSpecifications.", this.TagSpecifications);
            this.SetParamSimple(map, prefix + "IsDeleteResponseErrorCodes", this.IsDeleteResponseErrorCodes);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "ResponseSuccessExample", this.ResponseSuccessExample);
            this.SetParamSimple(map, prefix + "ResponseFailExample", this.ResponseFailExample);
            this.SetParamObj(map, prefix + "ServiceConfig.", this.ServiceConfig);
            this.SetParamSimple(map, prefix + "AuthRelationApiId", this.AuthRelationApiId);
            this.SetParamArrayObj(map, prefix + "ServiceParameters.", this.ServiceParameters);
            this.SetParamObj(map, prefix + "OauthConfig.", this.OauthConfig);
            this.SetParamArrayObj(map, prefix + "ResponseErrorCodes.", this.ResponseErrorCodes);
            this.SetParamSimple(map, prefix + "IsBase64Encoded", this.IsBase64Encoded);
            this.SetParamSimple(map, prefix + "IsBase64Trigger", this.IsBase64Trigger);
            this.SetParamArrayObj(map, prefix + "Base64EncodedTriggerRules.", this.Base64EncodedTriggerRules);
            this.SetParamSimple(map, prefix + "EventBusId", this.EventBusId);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionType", this.ServiceScfFunctionType);
            this.SetParamSimple(map, prefix + "EIAMAppType", this.EIAMAppType);
            this.SetParamSimple(map, prefix + "EIAMAuthType", this.EIAMAuthType);
            this.SetParamSimple(map, prefix + "EIAMAppId", this.EIAMAppId);
            this.SetParamSimple(map, prefix + "TokenTimeout", this.TokenTimeout);
        }
    }
}

