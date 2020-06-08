/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Unique ID of API's service.
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
        /// API type. Valid values: NORMAL (default value), TSF.
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// API authentication type. Valid values: SECRET, NONE (default), OAUTH.
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// Whether signature authentication is required. `True` indicates yes while `False` indicates no. This parameter is to be disused.
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
        /// Whether to enable CORS. `True` indicates yes while `False` indicates no.
        /// </summary>
        [JsonProperty("EnableCORS")]
        public bool? EnableCORS{ get; set; }

        /// <summary>
        /// Constant parameters.
        /// </summary>
        [JsonProperty("ConstantParameters")]
        public ConstantParameter[] ConstantParameters{ get; set; }

        /// <summary>
        /// Frontend request parameters.
        /// </summary>
        [JsonProperty("RequestParameters")]
        public ReqParameter[] RequestParameters{ get; set; }

        /// <summary>
        /// This field takes effect when `AuthType` is `OAUTH`. NORMAL: business API. OAUTH: authorization API.
        /// </summary>
        [JsonProperty("ApiBusinessType")]
        public string ApiBusinessType{ get; set; }

        /// <summary>
        /// Returned information of API backend mocking. This parameter is required when `ServiceType` is `Mock`.
        /// </summary>
        [JsonProperty("ServiceMockReturnMessage")]
        public string ServiceMockReturnMessage{ get; set; }

        /// <summary>
        /// List of microservices bound to API.
        /// </summary>
        [JsonProperty("MicroServices")]
        public MicroServiceReq[] MicroServices{ get; set; }

        /// <summary>
        /// Microservice load balancing configuration.
        /// </summary>
        [JsonProperty("ServiceTsfLoadBalanceConf")]
        public TsfLoadBalanceConfResp ServiceTsfLoadBalanceConf{ get; set; }

        /// <summary>
        /// Microservice health check configuration.
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
        /// SCF function name. This parameter takes effect when the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfFunctionName")]
        public string ServiceScfFunctionName{ get; set; }

        /// <summary>
        /// SCF WebSocket registration function. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionName")]
        public string ServiceWebsocketRegisterFunctionName{ get; set; }

        /// <summary>
        /// SCF WebSocket cleanup function. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionName")]
        public string ServiceWebsocketCleanupFunctionName{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionName")]
        public string ServiceWebsocketTransportFunctionName{ get; set; }

        /// <summary>
        /// SCF function namespace. This parameter takes effect when the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfFunctionNamespace")]
        public string ServiceScfFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF function version. This parameter takes effect when the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfFunctionQualifier")]
        public string ServiceScfFunctionQualifier{ get; set; }

        /// <summary>
        /// SCF WebSocket registration function namespace. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionNamespace")]
        public string ServiceWebsocketRegisterFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function version. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionQualifier")]
        public string ServiceWebsocketRegisterFunctionQualifier{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function namespace. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionNamespace")]
        public string ServiceWebsocketTransportFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF WebSocket transfer function version. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionQualifier")]
        public string ServiceWebsocketTransportFunctionQualifier{ get; set; }

        /// <summary>
        /// SCF WebSocket cleanup function namespace. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionNamespace")]
        public string ServiceWebsocketCleanupFunctionNamespace{ get; set; }

        /// <summary>
        /// SCF WebSocket cleanup function version. This parameter takes effect when the frontend type is `WEBSOCKET` and the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionQualifier")]
        public string ServiceWebsocketCleanupFunctionQualifier{ get; set; }

        /// <summary>
        /// Whether to enable response integration. This parameter takes effect when the backend type is `SCF`.
        /// </summary>
        [JsonProperty("ServiceScfIsIntegratedResponse")]
        public bool? ServiceScfIsIntegratedResponse{ get; set; }

        /// <summary>
        /// Billing after debugging starts (reserved for marketplace).
        /// </summary>
        [JsonProperty("IsDebugAfterCharge")]
        public bool? IsDebugAfterCharge{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("TagSpecifications")]
        public Tag TagSpecifications{ get; set; }

        /// <summary>
        /// Whether to delete the custom response configuration error codes. If the value is left empty or `False`, the error codes will not be deleted. If the value is `True`, all custom response configuration error codes of the API will be deleted.
        /// </summary>
        [JsonProperty("IsDeleteResponseErrorCodes")]
        public bool? IsDeleteResponseErrorCodes{ get; set; }

        /// <summary>
        /// Return type.
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// Successful response sample of custom response configuration.
        /// </summary>
        [JsonProperty("ResponseSuccessExample")]
        public string ResponseSuccessExample{ get; set; }

        /// <summary>
        /// Response failure sample of custom response configuration.
        /// </summary>
        [JsonProperty("ResponseFailExample")]
        public string ResponseFailExample{ get; set; }

        /// <summary>
        /// API backend service configuration.
        /// </summary>
        [JsonProperty("ServiceConfig")]
        public ServiceConfig ServiceConfig{ get; set; }

        /// <summary>
        /// Unique ID of associated authorization API. This parameter takes effect only when `AuthType` is `OAUTH` and `ApiBusinessType` is `NORMAL`. It is the unique ID of the OAuth 2.0 authorization API bound to the business API.
        /// </summary>
        [JsonProperty("AuthRelationApiId")]
        public string AuthRelationApiId{ get; set; }

        /// <summary>
        /// API backend service parameters.
        /// </summary>
        [JsonProperty("ServiceParameters")]
        public ServiceParameter[] ServiceParameters{ get; set; }

        /// <summary>
        /// OAuth configuration. This parameter takes effect when `AuthType` is `OAUTH`.
        /// </summary>
        [JsonProperty("OauthConfig")]
        public OauthConfig OauthConfig{ get; set; }

        /// <summary>
        /// Custom error code configuration.
        /// </summary>
        [JsonProperty("ResponseErrorCodes")]
        public ResponseErrorCodeReq[] ResponseErrorCodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

