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

namespace TencentCloud.Gaap.V20180529
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gaap.V20180529.Models;

   public class GaapClient : AbstractClient{

       private const string endpoint = "gaap.tencentcloudapi.com";
       private const string version = "2018-05-29";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GaapClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GaapClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to add the information of the origin server (server), which supports IP or the domain name.
        /// </summary>
        /// <param name="req"><see cref="AddRealServersRequest"/></param>
        /// <returns><see cref="AddRealServersResponse"/></returns>
        public async Task<AddRealServersResponse> AddRealServers(AddRealServersRequest req)
        {
             JsonResponseModel<AddRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add the information of the origin server (server), which supports IP or the domain name.
        /// </summary>
        /// <param name="req"><see cref="AddRealServersRequest"/></param>
        /// <returns><see cref="AddRealServersResponse"/></returns>
        public AddRealServersResponse AddRealServersSync(AddRealServersRequest req)
        {
             JsonResponseModel<AddRealServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (BindListenerRealServers) is used for the TCP/UDP listener to bind/unbind the origin server.
        /// Note: This API unbinds the previously bound origin servers, and binds the origin servers selected for this call. For example, the previously bound origin servers are A, B and C, and the origin servers selected for this call are C, D and E, then the origin servers bound after this call will be C, D and E.
        /// </summary>
        /// <param name="req"><see cref="BindListenerRealServersRequest"/></param>
        /// <returns><see cref="BindListenerRealServersResponse"/></returns>
        public async Task<BindListenerRealServersResponse> BindListenerRealServers(BindListenerRealServersRequest req)
        {
             JsonResponseModel<BindListenerRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindListenerRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindListenerRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (BindListenerRealServers) is used for the TCP/UDP listener to bind/unbind the origin server.
        /// Note: This API unbinds the previously bound origin servers, and binds the origin servers selected for this call. For example, the previously bound origin servers are A, B and C, and the origin servers selected for this call are C, D and E, then the origin servers bound after this call will be C, D and E.
        /// </summary>
        /// <param name="req"><see cref="BindListenerRealServersRequest"/></param>
        /// <returns><see cref="BindListenerRealServersResponse"/></returns>
        public BindListenerRealServersResponse BindListenerRealServersSync(BindListenerRealServersRequest req)
        {
             JsonResponseModel<BindListenerRealServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindListenerRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindListenerRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an origin server to the forwarding rules of layer-7 listeners. Note: This API unbinds all previously bound origin servers before binding those selected.
        /// </summary>
        /// <param name="req"><see cref="BindRuleRealServersRequest"/></param>
        /// <returns><see cref="BindRuleRealServersResponse"/></returns>
        public async Task<BindRuleRealServersResponse> BindRuleRealServers(BindRuleRealServersRequest req)
        {
             JsonResponseModel<BindRuleRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindRuleRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRuleRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an origin server to the forwarding rules of layer-7 listeners. Note: This API unbinds all previously bound origin servers before binding those selected.
        /// </summary>
        /// <param name="req"><see cref="BindRuleRealServersRequest"/></param>
        /// <returns><see cref="BindRuleRealServersResponse"/></returns>
        public BindRuleRealServersResponse BindRuleRealServersSync(BindRuleRealServersRequest req)
        {
             JsonResponseModel<BindRuleRealServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindRuleRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRuleRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CheckProxyCreate) is used to query whether an acceleration connection with the specified configuration can be created.
        /// </summary>
        /// <param name="req"><see cref="CheckProxyCreateRequest"/></param>
        /// <returns><see cref="CheckProxyCreateResponse"/></returns>
        public async Task<CheckProxyCreateResponse> CheckProxyCreate(CheckProxyCreateRequest req)
        {
             JsonResponseModel<CheckProxyCreateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckProxyCreate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckProxyCreateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CheckProxyCreate) is used to query whether an acceleration connection with the specified configuration can be created.
        /// </summary>
        /// <param name="req"><see cref="CheckProxyCreateRequest"/></param>
        /// <returns><see cref="CheckProxyCreateResponse"/></returns>
        public CheckProxyCreateResponse CheckProxyCreateSync(CheckProxyCreateRequest req)
        {
             JsonResponseModel<CheckProxyCreateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckProxyCreate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckProxyCreateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CloseProxies) is used to disable connections. If disabled, no traffic will be generated, but the basic configuration fee will still be incurred.
        /// </summary>
        /// <param name="req"><see cref="CloseProxiesRequest"/></param>
        /// <returns><see cref="CloseProxiesResponse"/></returns>
        public async Task<CloseProxiesResponse> CloseProxies(CloseProxiesRequest req)
        {
             JsonResponseModel<CloseProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CloseProxies) is used to disable connections. If disabled, no traffic will be generated, but the basic configuration fee will still be incurred.
        /// </summary>
        /// <param name="req"><see cref="CloseProxiesRequest"/></param>
        /// <returns><see cref="CloseProxiesResponse"/></returns>
        public CloseProxiesResponse CloseProxiesSync(CloseProxiesRequest req)
        {
             JsonResponseModel<CloseProxiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a connection group. Once disabled, the connection group will no longer generate traffic, but the basic connection configuration fees will still be incurred every day.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyGroupRequest"/></param>
        /// <returns><see cref="CloseProxyGroupResponse"/></returns>
        public async Task<CloseProxyGroupResponse> CloseProxyGroup(CloseProxyGroupRequest req)
        {
             JsonResponseModel<CloseProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a connection group. Once disabled, the connection group will no longer generate traffic, but the basic connection configuration fees will still be incurred every day.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyGroupRequest"/></param>
        /// <returns><see cref="CloseProxyGroupResponse"/></returns>
        public CloseProxyGroupResponse CloseProxyGroupSync(CloseProxyGroupRequest req)
        {
             JsonResponseModel<CloseProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a security policy.
        /// </summary>
        /// <param name="req"><see cref="CloseSecurityPolicyRequest"/></param>
        /// <returns><see cref="CloseSecurityPolicyResponse"/></returns>
        public async Task<CloseSecurityPolicyResponse> CloseSecurityPolicy(CloseSecurityPolicyRequest req)
        {
             JsonResponseModel<CloseSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a security policy.
        /// </summary>
        /// <param name="req"><see cref="CloseSecurityPolicyRequest"/></param>
        /// <returns><see cref="CloseSecurityPolicyResponse"/></returns>
        public CloseSecurityPolicyResponse CloseSecurityPolicySync(CloseSecurityPolicyRequest req)
        {
             JsonResponseModel<CloseSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateCertificate) is used to create the GAAP certificates and configuration files, including basic authentication configuration files, client CA certificates, server SSL certificates, GAAP SSL certificates, and origin server CA certificates.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public async Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
             JsonResponseModel<CreateCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateCertificate) is used to create the GAAP certificates and configuration files, including basic authentication configuration files, client CA certificates, server SSL certificates, GAAP SSL certificates, and origin server CA certificates.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public CreateCertificateResponse CreateCertificateSync(CreateCertificateRequest req)
        {
             JsonResponseModel<CreateCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom header of the HTTP/HTTPS listener. When client requests reach the listener, they will be forwarded to the origin with this custom hearer.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomHeaderRequest"/></param>
        /// <returns><see cref="CreateCustomHeaderResponse"/></returns>
        public async Task<CreateCustomHeaderResponse> CreateCustomHeader(CreateCustomHeaderRequest req)
        {
             JsonResponseModel<CreateCustomHeaderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomHeader");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomHeaderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom header of the HTTP/HTTPS listener. When client requests reach the listener, they will be forwarded to the origin with this custom hearer.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomHeaderRequest"/></param>
        /// <returns><see cref="CreateCustomHeaderResponse"/></returns>
        public CreateCustomHeaderResponse CreateCustomHeaderSync(CreateCustomHeaderRequest req)
        {
             JsonResponseModel<CreateCustomHeaderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomHeader");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomHeaderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateDomain) is used to create the access domain name for the HTTP/HTTPS listener. Clients request the backend data by accessing this domain.
        /// This API only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public async Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateDomain) is used to create the access domain name for the HTTP/HTTPS listener. Clients request the backend data by accessing this domain.
        /// This API only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to customize the error code of an error response to the specified domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="CreateDomainErrorPageInfoResponse"/></returns>
        public async Task<CreateDomainErrorPageInfoResponse> CreateDomainErrorPageInfo(CreateDomainErrorPageInfoRequest req)
        {
             JsonResponseModel<CreateDomainErrorPageInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomainErrorPageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainErrorPageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to customize the error code of an error response to the specified domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="CreateDomainErrorPageInfoResponse"/></returns>
        public CreateDomainErrorPageInfoResponse CreateDomainErrorPageInfoSync(CreateDomainErrorPageInfoRequest req)
        {
             JsonResponseModel<CreateDomainErrorPageInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomainErrorPageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainErrorPageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTP listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPListenerResponse"/></returns>
        public async Task<CreateHTTPListenerResponse> CreateHTTPListener(CreateHTTPListenerRequest req)
        {
             JsonResponseModel<CreateHTTPListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHTTPListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHTTPListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTP listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPListenerResponse"/></returns>
        public CreateHTTPListenerResponse CreateHTTPListenerSync(CreateHTTPListenerRequest req)
        {
             JsonResponseModel<CreateHTTPListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHTTPListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHTTPListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTPS listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPSListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPSListenerResponse"/></returns>
        public async Task<CreateHTTPSListenerResponse> CreateHTTPSListener(CreateHTTPSListenerRequest req)
        {
             JsonResponseModel<CreateHTTPSListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHTTPSListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHTTPSListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTPS listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPSListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPSListenerResponse"/></returns>
        public CreateHTTPSListenerResponse CreateHTTPSListenerSync(CreateHTTPSListenerRequest req)
        {
             JsonResponseModel<CreateHTTPSListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHTTPSListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHTTPSListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateProxy) is used to create an acceleration connection with specified configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public async Task<CreateProxyResponse> CreateProxy(CreateProxyRequest req)
        {
             JsonResponseModel<CreateProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateProxy) is used to create an acceleration connection with specified configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public CreateProxyResponse CreateProxySync(CreateProxyRequest req)
        {
             JsonResponseModel<CreateProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateProxyGroup) is used to create a connection group.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupRequest"/></param>
        /// <returns><see cref="CreateProxyGroupResponse"/></returns>
        public async Task<CreateProxyGroupResponse> CreateProxyGroup(CreateProxyGroupRequest req)
        {
             JsonResponseModel<CreateProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateProxyGroup) is used to create a connection group.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupRequest"/></param>
        /// <returns><see cref="CreateProxyGroupResponse"/></returns>
        public CreateProxyGroupResponse CreateProxyGroupSync(CreateProxyGroupRequest req)
        {
             JsonResponseModel<CreateProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateProxyGroupDomain) is used to create the connection group domain name, and enable the domain name resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupDomainRequest"/></param>
        /// <returns><see cref="CreateProxyGroupDomainResponse"/></returns>
        public async Task<CreateProxyGroupDomainResponse> CreateProxyGroupDomain(CreateProxyGroupDomainRequest req)
        {
             JsonResponseModel<CreateProxyGroupDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProxyGroupDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyGroupDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateProxyGroupDomain) is used to create the connection group domain name, and enable the domain name resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupDomainRequest"/></param>
        /// <returns><see cref="CreateProxyGroupDomainResponse"/></returns>
        public CreateProxyGroupDomainResponse CreateProxyGroupDomainSync(CreateProxyGroupDomainRequest req)
        {
             JsonResponseModel<CreateProxyGroupDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProxyGroupDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxyGroupDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateRule) is used to create the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateRule) is used to create the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create security policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create security policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add security policy rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityRulesResponse"/></returns>
        public async Task<CreateSecurityRulesResponse> CreateSecurityRules(CreateSecurityRulesRequest req)
        {
             JsonResponseModel<CreateSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add security policy rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityRulesResponse"/></returns>
        public CreateSecurityRulesResponse CreateSecurityRulesSync(CreateSecurityRulesRequest req)
        {
             JsonResponseModel<CreateSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create TCP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateTCPListenersRequest"/></param>
        /// <returns><see cref="CreateTCPListenersResponse"/></returns>
        public async Task<CreateTCPListenersResponse> CreateTCPListeners(CreateTCPListenersRequest req)
        {
             JsonResponseModel<CreateTCPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTCPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTCPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create TCP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateTCPListenersRequest"/></param>
        /// <returns><see cref="CreateTCPListenersResponse"/></returns>
        public CreateTCPListenersResponse CreateTCPListenersSync(CreateTCPListenersRequest req)
        {
             JsonResponseModel<CreateTCPListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTCPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTCPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create UDP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateUDPListenersRequest"/></param>
        /// <returns><see cref="CreateUDPListenersResponse"/></returns>
        public async Task<CreateUDPListenersResponse> CreateUDPListeners(CreateUDPListenersRequest req)
        {
             JsonResponseModel<CreateUDPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUDPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUDPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create UDP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateUDPListenersRequest"/></param>
        /// <returns><see cref="CreateUDPListenersResponse"/></returns>
        public CreateUDPListenersResponse CreateUDPListenersSync(CreateUDPListenersRequest req)
        {
             JsonResponseModel<CreateUDPListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUDPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUDPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public async Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
             JsonResponseModel<DeleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public DeleteCertificateResponse DeleteCertificateSync(DeleteCertificateRequest req)
        {
             JsonResponseModel<DeleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteDomain) is only applicable to layer-7 listeners. It is used to delete the domain names of this listener, and all the rules under the domain name. All rules bound to the origin server are unbound automatically.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public async Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteDomain) is only applicable to layer-7 listeners. It is used to delete the domain names of this listener, and all the rules under the domain name. All rules bound to the origin server are unbound automatically.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom error code for a domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DeleteDomainErrorPageInfoResponse"/></returns>
        public async Task<DeleteDomainErrorPageInfoResponse> DeleteDomainErrorPageInfo(DeleteDomainErrorPageInfoRequest req)
        {
             JsonResponseModel<DeleteDomainErrorPageInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomainErrorPageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainErrorPageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom error code for a domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DeleteDomainErrorPageInfoResponse"/></returns>
        public DeleteDomainErrorPageInfoResponse DeleteDomainErrorPageInfoSync(DeleteDomainErrorPageInfoRequest req)
        {
             JsonResponseModel<DeleteDomainErrorPageInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomainErrorPageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainErrorPageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteListeners) is used to batch delete the listeners of a connection or connection group, including layer-4/7 listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public async Task<DeleteListenersResponse> DeleteListeners(DeleteListenersRequest req)
        {
             JsonResponseModel<DeleteListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteListeners) is used to batch delete the listeners of a connection or connection group, including layer-4/7 listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public DeleteListenersResponse DeleteListenersSync(DeleteListenersRequest req)
        {
             JsonResponseModel<DeleteListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteProxyGroup) is used to delete a connection group.
        /// </summary>
        /// <param name="req"><see cref="DeleteProxyGroupRequest"/></param>
        /// <returns><see cref="DeleteProxyGroupResponse"/></returns>
        public async Task<DeleteProxyGroupResponse> DeleteProxyGroup(DeleteProxyGroupRequest req)
        {
             JsonResponseModel<DeleteProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteProxyGroup) is used to delete a connection group.
        /// </summary>
        /// <param name="req"><see cref="DeleteProxyGroupRequest"/></param>
        /// <returns><see cref="DeleteProxyGroupResponse"/></returns>
        public DeleteProxyGroupResponse DeleteProxyGroupSync(DeleteProxyGroupRequest req)
        {
             JsonResponseModel<DeleteProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a security policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a security policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete security policy rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityRulesRequest"/></param>
        /// <returns><see cref="DeleteSecurityRulesResponse"/></returns>
        public async Task<DeleteSecurityRulesResponse> DeleteSecurityRules(DeleteSecurityRulesRequest req)
        {
             JsonResponseModel<DeleteSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete security policy rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityRulesRequest"/></param>
        /// <returns><see cref="DeleteSecurityRulesResponse"/></returns>
        public DeleteSecurityRulesResponse DeleteSecurityRulesSync(DeleteSecurityRulesRequest req)
        {
             JsonResponseModel<DeleteSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccessRegions) is used to query acceleration region (client access region).
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsResponse"/></returns>
        public async Task<DescribeAccessRegionsResponse> DescribeAccessRegions(DescribeAccessRegionsRequest req)
        {
             JsonResponseModel<DescribeAccessRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccessRegions) is used to query acceleration region (client access region).
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsResponse"/></returns>
        public DescribeAccessRegionsResponse DescribeAccessRegionsSync(DescribeAccessRegionsRequest req)
        {
             JsonResponseModel<DescribeAccessRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the available accelerator region based on the origin server region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsByDestRegionRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsByDestRegionResponse"/></returns>
        public async Task<DescribeAccessRegionsByDestRegionResponse> DescribeAccessRegionsByDestRegion(DescribeAccessRegionsByDestRegionRequest req)
        {
             JsonResponseModel<DescribeAccessRegionsByDestRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessRegionsByDestRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRegionsByDestRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the available accelerator region based on the origin server region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsByDestRegionRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsByDestRegionResponse"/></returns>
        public DescribeAccessRegionsByDestRegionResponse DescribeAccessRegionsByDestRegionSync(DescribeAccessRegionsByDestRegionRequest req)
        {
             JsonResponseModel<DescribeAccessRegionsByDestRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessRegionsByDestRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRegionsByDestRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query names of blocked custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackHeaderRequest"/></param>
        /// <returns><see cref="DescribeBlackHeaderResponse"/></returns>
        public async Task<DescribeBlackHeaderResponse> DescribeBlackHeader(DescribeBlackHeaderRequest req)
        {
             JsonResponseModel<DescribeBlackHeaderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlackHeader");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackHeaderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query names of blocked custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackHeaderRequest"/></param>
        /// <returns><see cref="DescribeBlackHeaderResponse"/></returns>
        public DescribeBlackHeaderResponse DescribeBlackHeaderSync(DescribeBlackHeaderRequest req)
        {
             JsonResponseModel<DescribeBlackHeaderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlackHeader");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackHeaderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCertificateDetail) is used to query certificate details, including the certificate ID, name, type, content, key, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public async Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCertificateDetail) is used to query certificate details, including the certificate ID, name, type, content, key, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public DescribeCertificateDetailResponse DescribeCertificateDetailSync(DescribeCertificateDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCertificates) is used to query the list of available certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public async Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
             JsonResponseModel<DescribeCertificatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCertificates) is used to query the list of available certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public DescribeCertificatesResponse DescribeCertificatesSync(DescribeCertificatesRequest req)
        {
             JsonResponseModel<DescribeCertificatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCountryAreaMapping) is used to obtain the country/region code mapping table.
        /// </summary>
        /// <param name="req"><see cref="DescribeCountryAreaMappingRequest"/></param>
        /// <returns><see cref="DescribeCountryAreaMappingResponse"/></returns>
        public async Task<DescribeCountryAreaMappingResponse> DescribeCountryAreaMapping(DescribeCountryAreaMappingRequest req)
        {
             JsonResponseModel<DescribeCountryAreaMappingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCountryAreaMapping");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCountryAreaMappingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCountryAreaMapping) is used to obtain the country/region code mapping table.
        /// </summary>
        /// <param name="req"><see cref="DescribeCountryAreaMappingRequest"/></param>
        /// <returns><see cref="DescribeCountryAreaMappingResponse"/></returns>
        public DescribeCountryAreaMappingResponse DescribeCountryAreaMappingSync(DescribeCountryAreaMappingRequest req)
        {
             JsonResponseModel<DescribeCountryAreaMappingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCountryAreaMapping");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCountryAreaMappingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomHeaderRequest"/></param>
        /// <returns><see cref="DescribeCustomHeaderResponse"/></returns>
        public async Task<DescribeCustomHeaderResponse> DescribeCustomHeader(DescribeCustomHeaderRequest req)
        {
             JsonResponseModel<DescribeCustomHeaderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomHeader");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomHeaderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomHeaderRequest"/></param>
        /// <returns><see cref="DescribeCustomHeaderResponse"/></returns>
        public DescribeCustomHeaderResponse DescribeCustomHeaderSync(DescribeCustomHeaderRequest req)
        {
             JsonResponseModel<DescribeCustomHeaderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomHeader");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomHeaderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDestRegions) is used to query an origin server region (i.e., the region in which the origin server locates).
        /// </summary>
        /// <param name="req"><see cref="DescribeDestRegionsRequest"/></param>
        /// <returns><see cref="DescribeDestRegionsResponse"/></returns>
        public async Task<DescribeDestRegionsResponse> DescribeDestRegions(DescribeDestRegionsRequest req)
        {
             JsonResponseModel<DescribeDestRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDestRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDestRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDestRegions) is used to query an origin server region (i.e., the region in which the origin server locates).
        /// </summary>
        /// <param name="req"><see cref="DescribeDestRegionsRequest"/></param>
        /// <returns><see cref="DescribeDestRegionsResponse"/></returns>
        public DescribeDestRegionsResponse DescribeDestRegionsSync(DescribeDestRegionsRequest req)
        {
             JsonResponseModel<DescribeDestRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDestRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDestRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the custom error response to a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoResponse"/></returns>
        public async Task<DescribeDomainErrorPageInfoResponse> DescribeDomainErrorPageInfo(DescribeDomainErrorPageInfoRequest req)
        {
             JsonResponseModel<DescribeDomainErrorPageInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainErrorPageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainErrorPageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the custom error response to a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoResponse"/></returns>
        public DescribeDomainErrorPageInfoResponse DescribeDomainErrorPageInfoSync(DescribeDomainErrorPageInfoRequest req)
        {
             JsonResponseModel<DescribeDomainErrorPageInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainErrorPageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainErrorPageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the corresponding error response by a custom error ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoByIdsRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoByIdsResponse"/></returns>
        public async Task<DescribeDomainErrorPageInfoByIdsResponse> DescribeDomainErrorPageInfoByIds(DescribeDomainErrorPageInfoByIdsRequest req)
        {
             JsonResponseModel<DescribeDomainErrorPageInfoByIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainErrorPageInfoByIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainErrorPageInfoByIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the corresponding error response by a custom error ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoByIdsRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoByIdsResponse"/></returns>
        public DescribeDomainErrorPageInfoByIdsResponse DescribeDomainErrorPageInfoByIdsSync(DescribeDomainErrorPageInfoByIdsRequest req)
        {
             JsonResponseModel<DescribeDomainErrorPageInfoByIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainErrorPageInfoByIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainErrorPageInfoByIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and connection groups from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAndStatisticsProxyRequest"/></param>
        /// <returns><see cref="DescribeGroupAndStatisticsProxyResponse"/></returns>
        public async Task<DescribeGroupAndStatisticsProxyResponse> DescribeGroupAndStatisticsProxy(DescribeGroupAndStatisticsProxyRequest req)
        {
             JsonResponseModel<DescribeGroupAndStatisticsProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupAndStatisticsProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupAndStatisticsProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and connection groups from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAndStatisticsProxyRequest"/></param>
        /// <returns><see cref="DescribeGroupAndStatisticsProxyResponse"/></returns>
        public DescribeGroupAndStatisticsProxyResponse DescribeGroupAndStatisticsProxySync(DescribeGroupAndStatisticsProxyRequest req)
        {
             JsonResponseModel<DescribeGroupAndStatisticsProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupAndStatisticsProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupAndStatisticsProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeGroupDomainConfig) is used to obtain the domain name resolution configuration details of a connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDomainConfigRequest"/></param>
        /// <returns><see cref="DescribeGroupDomainConfigResponse"/></returns>
        public async Task<DescribeGroupDomainConfigResponse> DescribeGroupDomainConfig(DescribeGroupDomainConfigRequest req)
        {
             JsonResponseModel<DescribeGroupDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeGroupDomainConfig) is used to obtain the domain name resolution configuration details of a connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDomainConfigRequest"/></param>
        /// <returns><see cref="DescribeGroupDomainConfigResponse"/></returns>
        public DescribeGroupDomainConfigResponse DescribeGroupDomainConfigSync(DescribeGroupDomainConfigRequest req)
        {
             JsonResponseModel<DescribeGroupDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeHTTPListeners) is used to query HTTP listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPListenersResponse"/></returns>
        public async Task<DescribeHTTPListenersResponse> DescribeHTTPListeners(DescribeHTTPListenersRequest req)
        {
             JsonResponseModel<DescribeHTTPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHTTPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHTTPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeHTTPListeners) is used to query HTTP listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPListenersResponse"/></returns>
        public DescribeHTTPListenersResponse DescribeHTTPListenersSync(DescribeHTTPListenersRequest req)
        {
             JsonResponseModel<DescribeHTTPListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHTTPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHTTPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeHTTPSListeners) is used to query HTTPS listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPSListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPSListenersResponse"/></returns>
        public async Task<DescribeHTTPSListenersResponse> DescribeHTTPSListeners(DescribeHTTPSListenersRequest req)
        {
             JsonResponseModel<DescribeHTTPSListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHTTPSListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHTTPSListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeHTTPSListeners) is used to query HTTPS listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPSListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPSListenersResponse"/></returns>
        public DescribeHTTPSListenersResponse DescribeHTTPSListenersSync(DescribeHTTPSListenersRequest req)
        {
             JsonResponseModel<DescribeHTTPSListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHTTPSListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHTTPSListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeListenerRealServers) is used to query the origin server list of TCP/UDP listeners, including the list of bound origin servers and origin servers that can be bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerRealServersRequest"/></param>
        /// <returns><see cref="DescribeListenerRealServersResponse"/></returns>
        public async Task<DescribeListenerRealServersResponse> DescribeListenerRealServers(DescribeListenerRealServersRequest req)
        {
             JsonResponseModel<DescribeListenerRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListenerRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenerRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeListenerRealServers) is used to query the origin server list of TCP/UDP listeners, including the list of bound origin servers and origin servers that can be bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerRealServersRequest"/></param>
        /// <returns><see cref="DescribeListenerRealServersResponse"/></returns>
        public DescribeListenerRealServersResponse DescribeListenerRealServersSync(DescribeListenerRealServersRequest req)
        {
             JsonResponseModel<DescribeListenerRealServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListenerRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenerRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeListenerStatisticsResponse"/></returns>
        public async Task<DescribeListenerStatisticsResponse> DescribeListenerStatistics(DescribeListenerStatisticsRequest req)
        {
             JsonResponseModel<DescribeListenerStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListenerStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenerStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeListenerStatisticsResponse"/></returns>
        public DescribeListenerStatisticsResponse DescribeListenerStatisticsSync(DescribeListenerStatisticsRequest req)
        {
             JsonResponseModel<DescribeListenerStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListenerStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenerStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxies) is used to query the connection instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public async Task<DescribeProxiesResponse> DescribeProxies(DescribeProxiesRequest req)
        {
             JsonResponseModel<DescribeProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxies) is used to query the connection instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public DescribeProxiesResponse DescribeProxiesSync(DescribeProxiesRequest req)
        {
             JsonResponseModel<DescribeProxiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxiesStatus) is used to query the connection status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesStatusRequest"/></param>
        /// <returns><see cref="DescribeProxiesStatusResponse"/></returns>
        public async Task<DescribeProxiesStatusResponse> DescribeProxiesStatus(DescribeProxiesStatusRequest req)
        {
             JsonResponseModel<DescribeProxiesStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxiesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxiesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxiesStatus) is used to query the connection status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesStatusRequest"/></param>
        /// <returns><see cref="DescribeProxiesStatusResponse"/></returns>
        public DescribeProxiesStatusResponse DescribeProxiesStatusSync(DescribeProxiesStatusRequest req)
        {
             JsonResponseModel<DescribeProxiesStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxiesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxiesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and listeners from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyAndStatisticsListenersRequest"/></param>
        /// <returns><see cref="DescribeProxyAndStatisticsListenersResponse"/></returns>
        public async Task<DescribeProxyAndStatisticsListenersResponse> DescribeProxyAndStatisticsListeners(DescribeProxyAndStatisticsListenersRequest req)
        {
             JsonResponseModel<DescribeProxyAndStatisticsListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyAndStatisticsListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyAndStatisticsListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and listeners from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyAndStatisticsListenersRequest"/></param>
        /// <returns><see cref="DescribeProxyAndStatisticsListenersResponse"/></returns>
        public DescribeProxyAndStatisticsListenersResponse DescribeProxyAndStatisticsListenersSync(DescribeProxyAndStatisticsListenersRequest req)
        {
             JsonResponseModel<DescribeProxyAndStatisticsListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyAndStatisticsListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyAndStatisticsListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxyDetail) is used to query connection details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeProxyDetailResponse"/></returns>
        public async Task<DescribeProxyDetailResponse> DescribeProxyDetail(DescribeProxyDetailRequest req)
        {
             JsonResponseModel<DescribeProxyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxyDetail) is used to query connection details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeProxyDetailResponse"/></returns>
        public DescribeProxyDetailResponse DescribeProxyDetailSync(DescribeProxyDetailRequest req)
        {
             JsonResponseModel<DescribeProxyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxyGroupDetails) is used to query connection group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupDetailsResponse"/></returns>
        public async Task<DescribeProxyGroupDetailsResponse> DescribeProxyGroupDetails(DescribeProxyGroupDetailsRequest req)
        {
             JsonResponseModel<DescribeProxyGroupDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyGroupDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxyGroupDetails) is used to query connection group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupDetailsResponse"/></returns>
        public DescribeProxyGroupDetailsResponse DescribeProxyGroupDetailsSync(DescribeProxyGroupDetailsRequest req)
        {
             JsonResponseModel<DescribeProxyGroupDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyGroupDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxyGroupList) is used to pull the list of connection groups and the basic information of each connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupListRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupListResponse"/></returns>
        public async Task<DescribeProxyGroupListResponse> DescribeProxyGroupList(DescribeProxyGroupListRequest req)
        {
             JsonResponseModel<DescribeProxyGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProxyGroupList) is used to pull the list of connection groups and the basic information of each connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupListRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupListResponse"/></returns>
        public DescribeProxyGroupListResponse DescribeProxyGroupListSync(DescribeProxyGroupListRequest req)
        {
             JsonResponseModel<DescribeProxyGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupStatisticsResponse"/></returns>
        public async Task<DescribeProxyGroupStatisticsResponse> DescribeProxyGroupStatistics(DescribeProxyGroupStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyGroupStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyGroupStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupStatisticsResponse"/></returns>
        public DescribeProxyGroupStatisticsResponse DescribeProxyGroupStatisticsSync(DescribeProxyGroupStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyGroupStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyGroupStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyGroupStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, concurrence, packet loss, and latency data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyStatisticsResponse"/></returns>
        public async Task<DescribeProxyStatisticsResponse> DescribeProxyStatistics(DescribeProxyStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, concurrence, packet loss, and latency data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyStatisticsResponse"/></returns>
        public DescribeProxyStatisticsResponse DescribeProxyStatisticsSync(DescribeProxyStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the statistics of an origin server's health check results. Origin server status is displayed as 1 (normal) or 0 (exceptional). The queried origin server must be bound to a listener or rule, and the ID of the bound listener or rule must be specified for the query. This API supports displaying origin server status statistics at a 1-minute granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRealServerStatisticsResponse"/></returns>
        public async Task<DescribeRealServerStatisticsResponse> DescribeRealServerStatistics(DescribeRealServerStatisticsRequest req)
        {
             JsonResponseModel<DescribeRealServerStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealServerStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServerStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the statistics of an origin server's health check results. Origin server status is displayed as 1 (normal) or 0 (exceptional). The queried origin server must be bound to a listener or rule, and the ID of the bound listener or rule must be specified for the query. This API supports displaying origin server status statistics at a 1-minute granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRealServerStatisticsResponse"/></returns>
        public DescribeRealServerStatisticsResponse DescribeRealServerStatisticsSync(DescribeRealServerStatisticsRequest req)
        {
             JsonResponseModel<DescribeRealServerStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealServerStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServerStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query origin server information. It can query all origin servers under the specified project name, and supports fuzzy query by specified IPs or domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersRequest"/></param>
        /// <returns><see cref="DescribeRealServersResponse"/></returns>
        public async Task<DescribeRealServersResponse> DescribeRealServers(DescribeRealServersRequest req)
        {
             JsonResponseModel<DescribeRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query origin server information. It can query all origin servers under the specified project name, and supports fuzzy query by specified IPs or domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersRequest"/></param>
        /// <returns><see cref="DescribeRealServersResponse"/></returns>
        public DescribeRealServersResponse DescribeRealServersSync(DescribeRealServersRequest req)
        {
             JsonResponseModel<DescribeRealServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRealServersStatus) is used to query whether an origin server has been bound to a rule or listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersStatusRequest"/></param>
        /// <returns><see cref="DescribeRealServersStatusResponse"/></returns>
        public async Task<DescribeRealServersStatusResponse> DescribeRealServersStatus(DescribeRealServersStatusRequest req)
        {
             JsonResponseModel<DescribeRealServersStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealServersStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServersStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRealServersStatus) is used to query whether an origin server has been bound to a rule or listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersStatusRequest"/></param>
        /// <returns><see cref="DescribeRealServersStatusResponse"/></returns>
        public DescribeRealServersStatusResponse DescribeRealServersStatusSync(DescribeRealServersStatusRequest req)
        {
             JsonResponseModel<DescribeRealServersStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealServersStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealServersStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRegionAndPrice) is used to obtain the origin server regions and the bandwidth price gradient.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionAndPriceRequest"/></param>
        /// <returns><see cref="DescribeRegionAndPriceResponse"/></returns>
        public async Task<DescribeRegionAndPriceResponse> DescribeRegionAndPrice(DescribeRegionAndPriceRequest req)
        {
             JsonResponseModel<DescribeRegionAndPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegionAndPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionAndPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRegionAndPrice) is used to obtain the origin server regions and the bandwidth price gradient.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionAndPriceRequest"/></param>
        /// <returns><see cref="DescribeRegionAndPriceResponse"/></returns>
        public DescribeRegionAndPriceResponse DescribeRegionAndPriceSync(DescribeRegionAndPriceRequest req)
        {
             JsonResponseModel<DescribeRegionAndPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegionAndPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionAndPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeResourcesByTag) is used to query corresponding resource information by tags, including connection, connection group, and origin server.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagResponse"/></returns>
        public async Task<DescribeResourcesByTagResponse> DescribeResourcesByTag(DescribeResourcesByTagRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourcesByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeResourcesByTag) is used to query corresponding resource information by tags, including connection, connection group, and origin server.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagResponse"/></returns>
        public DescribeResourcesByTagResponse DescribeResourcesByTagSync(DescribeResourcesByTagRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourcesByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRuleRealServers) is used to query forwarding rules-related origin server information, including information of origin servers that can be bound and have been bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRealServersRequest"/></param>
        /// <returns><see cref="DescribeRuleRealServersResponse"/></returns>
        public async Task<DescribeRuleRealServersResponse> DescribeRuleRealServers(DescribeRuleRealServersRequest req)
        {
             JsonResponseModel<DescribeRuleRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRuleRealServers) is used to query forwarding rules-related origin server information, including information of origin servers that can be bound and have been bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRealServersRequest"/></param>
        /// <returns><see cref="DescribeRuleRealServersResponse"/></returns>
        public DescribeRuleRealServersResponse DescribeRuleRealServersSync(DescribeRuleRealServersRequest req)
        {
             JsonResponseModel<DescribeRuleRealServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRules) is used to query all rule information of a listener, including the domain names, paths, and list of bound origin servers. For version 3.0 connections, this API returns the advanced authentication configuration information of the domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public async Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRules) is used to query all rule information of a listener, including the domain names, paths, and list of bound origin servers. For version 3.0 connections, this API returns the advanced authentication configuration information of the domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull the list of rules based on rule ID. It supports pulling 1 to 10 rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByRuleIdsRequest"/></param>
        /// <returns><see cref="DescribeRulesByRuleIdsResponse"/></returns>
        public async Task<DescribeRulesByRuleIdsResponse> DescribeRulesByRuleIds(DescribeRulesByRuleIdsRequest req)
        {
             JsonResponseModel<DescribeRulesByRuleIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRulesByRuleIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesByRuleIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull the list of rules based on rule ID. It supports pulling 1 to 10 rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByRuleIdsRequest"/></param>
        /// <returns><see cref="DescribeRulesByRuleIdsResponse"/></returns>
        public DescribeRulesByRuleIdsResponse DescribeRulesByRuleIdsSync(DescribeRulesByRuleIdsRequest req)
        {
             JsonResponseModel<DescribeRulesByRuleIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRulesByRuleIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesByRuleIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain security policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyDetailResponse"/></returns>
        public async Task<DescribeSecurityPolicyDetailResponse> DescribeSecurityPolicyDetail(DescribeSecurityPolicyDetailRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain security policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyDetailResponse"/></returns>
        public DescribeSecurityPolicyDetailResponse DescribeSecurityPolicyDetailSync(DescribeSecurityPolicyDetailRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of security rules based on security rule ID. It supports querying 1 to 20 security rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityRulesResponse"/></returns>
        public async Task<DescribeSecurityRulesResponse> DescribeSecurityRules(DescribeSecurityRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of security rules based on security rule ID. It supports querying 1 to 20 security rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityRulesResponse"/></returns>
        public DescribeSecurityRulesResponse DescribeSecurityRulesSync(DescribeSecurityRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTCPListeners) is used to query the TCP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTCPListenersRequest"/></param>
        /// <returns><see cref="DescribeTCPListenersResponse"/></returns>
        public async Task<DescribeTCPListenersResponse> DescribeTCPListeners(DescribeTCPListenersRequest req)
        {
             JsonResponseModel<DescribeTCPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTCPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTCPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTCPListeners) is used to query the TCP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTCPListenersRequest"/></param>
        /// <returns><see cref="DescribeTCPListenersResponse"/></returns>
        public DescribeTCPListenersResponse DescribeTCPListenersSync(DescribeTCPListenersRequest req)
        {
             JsonResponseModel<DescribeTCPListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTCPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTCPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeUDPListeners) is used to query the UDP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUDPListenersRequest"/></param>
        /// <returns><see cref="DescribeUDPListenersResponse"/></returns>
        public async Task<DescribeUDPListenersResponse> DescribeUDPListeners(DescribeUDPListenersRequest req)
        {
             JsonResponseModel<DescribeUDPListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUDPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUDPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeUDPListeners) is used to query the UDP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUDPListenersRequest"/></param>
        /// <returns><see cref="DescribeUDPListenersResponse"/></returns>
        public DescribeUDPListenersResponse DescribeUDPListenersSync(DescribeUDPListenersRequest req)
        {
             JsonResponseModel<DescribeUDPListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUDPListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUDPListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DestroyProxies) is used to terminate a connection. If terminated, no fees will be incurred.
        /// </summary>
        /// <param name="req"><see cref="DestroyProxiesRequest"/></param>
        /// <returns><see cref="DestroyProxiesResponse"/></returns>
        public async Task<DestroyProxiesResponse> DestroyProxies(DestroyProxiesRequest req)
        {
             JsonResponseModel<DestroyProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DestroyProxies) is used to terminate a connection. If terminated, no fees will be incurred.
        /// </summary>
        /// <param name="req"><see cref="DestroyProxiesRequest"/></param>
        /// <returns><see cref="DestroyProxiesResponse"/></returns>
        public DestroyProxiesResponse DestroyProxiesSync(DestroyProxiesRequest req)
        {
             JsonResponseModel<DestroyProxiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceCreateProxy) is used to create the price inquiries of acceleration connections.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateProxyRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateProxyResponse"/></returns>
        public async Task<InquiryPriceCreateProxyResponse> InquiryPriceCreateProxy(InquiryPriceCreateProxyRequest req)
        {
             JsonResponseModel<InquiryPriceCreateProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceCreateProxy) is used to create the price inquiries of acceleration connections.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateProxyRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateProxyResponse"/></returns>
        public InquiryPriceCreateProxyResponse InquiryPriceCreateProxySync(InquiryPriceCreateProxyRequest req)
        {
             JsonResponseModel<InquiryPriceCreateProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyCertificate) is used to modify a domain name certificate of a listener. domain name certificate. This API is only applicable to connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateRequest"/></param>
        /// <returns><see cref="ModifyCertificateResponse"/></returns>
        public async Task<ModifyCertificateResponse> ModifyCertificate(ModifyCertificateRequest req)
        {
             JsonResponseModel<ModifyCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyCertificate) is used to modify a domain name certificate of a listener. domain name certificate. This API is only applicable to connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateRequest"/></param>
        /// <returns><see cref="ModifyCertificateResponse"/></returns>
        public ModifyCertificateResponse ModifyCertificateSync(ModifyCertificateRequest req)
        {
             JsonResponseModel<ModifyCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify certificate name and content.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAttributesRequest"/></param>
        /// <returns><see cref="ModifyCertificateAttributesResponse"/></returns>
        public async Task<ModifyCertificateAttributesResponse> ModifyCertificateAttributes(ModifyCertificateAttributesRequest req)
        {
             JsonResponseModel<ModifyCertificateAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificateAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify certificate name and content.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAttributesRequest"/></param>
        /// <returns><see cref="ModifyCertificateAttributesResponse"/></returns>
        public ModifyCertificateAttributesResponse ModifyCertificateAttributesSync(ModifyCertificateAttributesRequest req)
        {
             JsonResponseModel<ModifyCertificateAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCertificateAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify domain names of listeners. For connections of version 3.0, it supports modifying certificates of the domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public async Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify domain names of listeners. For connections of version 3.0, it supports modifying certificates of the domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyGroupDomainConfig) is used to configure the nearest access domain name of a connection group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyGroupDomainConfigResponse"/></returns>
        public async Task<ModifyGroupDomainConfigResponse> ModifyGroupDomainConfig(ModifyGroupDomainConfigRequest req)
        {
             JsonResponseModel<ModifyGroupDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroupDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyGroupDomainConfig) is used to configure the nearest access domain name of a connection group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyGroupDomainConfigResponse"/></returns>
        public ModifyGroupDomainConfigResponse ModifyGroupDomainConfigSync(ModifyGroupDomainConfigRequest req)
        {
             JsonResponseModel<ModifyGroupDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGroupDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyHTTPListenerAttribute) is used to modify the HTTP listener configuration information of a connection. Currently only supports modifying listener name.
        /// Note: Grouped connections currently do not support HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPListenerAttributeResponse"/></returns>
        public async Task<ModifyHTTPListenerAttributeResponse> ModifyHTTPListenerAttribute(ModifyHTTPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyHTTPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHTTPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHTTPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyHTTPListenerAttribute) is used to modify the HTTP listener configuration information of a connection. Currently only supports modifying listener name.
        /// Note: Grouped connections currently do not support HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPListenerAttributeResponse"/></returns>
        public ModifyHTTPListenerAttributeResponse ModifyHTTPListenerAttributeSync(ModifyHTTPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyHTTPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHTTPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHTTPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyHTTPSListenerAttribute) is used to modify HTTPS listener configurations. It currently do not support connection groups and connections of version 1.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPSListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPSListenerAttributeResponse"/></returns>
        public async Task<ModifyHTTPSListenerAttributeResponse> ModifyHTTPSListenerAttribute(ModifyHTTPSListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyHTTPSListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHTTPSListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHTTPSListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyHTTPSListenerAttribute) is used to modify HTTPS listener configurations. It currently do not support connection groups and connections of version 1.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPSListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPSListenerAttributeResponse"/></returns>
        public ModifyHTTPSListenerAttributeResponse ModifyHTTPSListenerAttributeSync(ModifyHTTPSListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyHTTPSListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHTTPSListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHTTPSListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxiesAttribute) is used to modify instance attributes (currently only supports modifying connection name).
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxiesAttributeResponse"/></returns>
        public async Task<ModifyProxiesAttributeResponse> ModifyProxiesAttribute(ModifyProxiesAttributeRequest req)
        {
             JsonResponseModel<ModifyProxiesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxiesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxiesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxiesAttribute) is used to modify instance attributes (currently only supports modifying connection name).
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxiesAttributeResponse"/></returns>
        public ModifyProxiesAttributeResponse ModifyProxiesAttributeSync(ModifyProxiesAttributeRequest req)
        {
             JsonResponseModel<ModifyProxiesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProxiesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxiesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxiesProject) is used to modify the project to which a connection belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesProjectRequest"/></param>
        /// <returns><see cref="ModifyProxiesProjectResponse"/></returns>
        public async Task<ModifyProxiesProjectResponse> ModifyProxiesProject(ModifyProxiesProjectRequest req)
        {
             JsonResponseModel<ModifyProxiesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxiesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxiesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxiesProject) is used to modify the project to which a connection belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesProjectRequest"/></param>
        /// <returns><see cref="ModifyProxiesProjectResponse"/></returns>
        public ModifyProxiesProjectResponse ModifyProxiesProjectSync(ModifyProxiesProjectRequest req)
        {
             JsonResponseModel<ModifyProxiesProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProxiesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxiesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxyConfiguration) is used to modify connection configurations. You can expand or reduce the capacity based on current business requirements. It only supports connections with a Scalarable of 1. Scalarable can be obtained via DescribeProxies API.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyConfigurationRequest"/></param>
        /// <returns><see cref="ModifyProxyConfigurationResponse"/></returns>
        public async Task<ModifyProxyConfigurationResponse> ModifyProxyConfiguration(ModifyProxyConfigurationRequest req)
        {
             JsonResponseModel<ModifyProxyConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxyConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxyConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxyConfiguration) is used to modify connection configurations. You can expand or reduce the capacity based on current business requirements. It only supports connections with a Scalarable of 1. Scalarable can be obtained via DescribeProxies API.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyConfigurationRequest"/></param>
        /// <returns><see cref="ModifyProxyConfigurationResponse"/></returns>
        public ModifyProxyConfigurationResponse ModifyProxyConfigurationSync(ModifyProxyConfigurationRequest req)
        {
             JsonResponseModel<ModifyProxyConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProxyConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxyConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxyGroupAttribute) is used to modify connection group attributes. It currently only supports modifying connection group name.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxyGroupAttributeResponse"/></returns>
        public async Task<ModifyProxyGroupAttributeResponse> ModifyProxyGroupAttribute(ModifyProxyGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyProxyGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProxyGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxyGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyProxyGroupAttribute) is used to modify connection group attributes. It currently only supports modifying connection group name.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxyGroupAttributeResponse"/></returns>
        public ModifyProxyGroupAttributeResponse ModifyProxyGroupAttributeSync(ModifyProxyGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyProxyGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProxyGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProxyGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyRealServerName) is used to modify origin server names.
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerNameRequest"/></param>
        /// <returns><see cref="ModifyRealServerNameResponse"/></returns>
        public async Task<ModifyRealServerNameResponse> ModifyRealServerName(ModifyRealServerNameRequest req)
        {
             JsonResponseModel<ModifyRealServerNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRealServerName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRealServerNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyRealServerName) is used to modify origin server names.
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerNameRequest"/></param>
        /// <returns><see cref="ModifyRealServerNameResponse"/></returns>
        public ModifyRealServerNameResponse ModifyRealServerNameSync(ModifyRealServerNameRequest req)
        {
             JsonResponseModel<ModifyRealServerNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRealServerName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRealServerNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyRuleAttribute) is used to modify forwarding rule information, including health check configuration and forwarding policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleAttributeRequest"/></param>
        /// <returns><see cref="ModifyRuleAttributeResponse"/></returns>
        public async Task<ModifyRuleAttributeResponse> ModifyRuleAttribute(ModifyRuleAttributeRequest req)
        {
             JsonResponseModel<ModifyRuleAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRuleAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyRuleAttribute) is used to modify forwarding rule information, including health check configuration and forwarding policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleAttributeRequest"/></param>
        /// <returns><see cref="ModifyRuleAttributeResponse"/></returns>
        public ModifyRuleAttributeResponse ModifyRuleAttributeSync(ModifyRuleAttributeRequest req)
        {
             JsonResponseModel<ModifyRuleAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRuleAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify security policy rule names.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityRuleResponse"/></returns>
        public async Task<ModifySecurityRuleResponse> ModifySecurityRule(ModifySecurityRuleRequest req)
        {
             JsonResponseModel<ModifySecurityRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify security policy rule names.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityRuleResponse"/></returns>
        public ModifySecurityRuleResponse ModifySecurityRuleSync(ModifySecurityRuleRequest req)
        {
             JsonResponseModel<ModifySecurityRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTCPListenerAttribute) is used to modify the TCP listener configuration of a connection instance, including health check configuration and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyTCPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyTCPListenerAttributeResponse"/></returns>
        public async Task<ModifyTCPListenerAttributeResponse> ModifyTCPListenerAttribute(ModifyTCPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyTCPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTCPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTCPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTCPListenerAttribute) is used to modify the TCP listener configuration of a connection instance, including health check configuration and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyTCPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyTCPListenerAttributeResponse"/></returns>
        public ModifyTCPListenerAttributeResponse ModifyTCPListenerAttributeSync(ModifyTCPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyTCPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTCPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTCPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyUDPListenerAttribute) is used to modify the UDP listener configuration of a connection instance, including modification of listener names and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyUDPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyUDPListenerAttributeResponse"/></returns>
        public async Task<ModifyUDPListenerAttributeResponse> ModifyUDPListenerAttribute(ModifyUDPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyUDPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUDPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUDPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyUDPListenerAttribute) is used to modify the UDP listener configuration of a connection instance, including modification of listener names and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyUDPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyUDPListenerAttributeResponse"/></returns>
        public ModifyUDPListenerAttributeResponse ModifyUDPListenerAttributeSync(ModifyUDPListenerAttributeRequest req)
        {
             JsonResponseModel<ModifyUDPListenerAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUDPListenerAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUDPListenerAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OpenProxies) is used to enable one or more connections.
        /// </summary>
        /// <param name="req"><see cref="OpenProxiesRequest"/></param>
        /// <returns><see cref="OpenProxiesResponse"/></returns>
        public async Task<OpenProxiesResponse> OpenProxies(OpenProxiesRequest req)
        {
             JsonResponseModel<OpenProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OpenProxies) is used to enable one or more connections.
        /// </summary>
        /// <param name="req"><see cref="OpenProxiesRequest"/></param>
        /// <returns><see cref="OpenProxiesResponse"/></returns>
        public OpenProxiesResponse OpenProxiesSync(OpenProxiesRequest req)
        {
             JsonResponseModel<OpenProxiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable all connections in a connection group.
        /// </summary>
        /// <param name="req"><see cref="OpenProxyGroupRequest"/></param>
        /// <returns><see cref="OpenProxyGroupResponse"/></returns>
        public async Task<OpenProxyGroupResponse> OpenProxyGroup(OpenProxyGroupRequest req)
        {
             JsonResponseModel<OpenProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable all connections in a connection group.
        /// </summary>
        /// <param name="req"><see cref="OpenProxyGroupRequest"/></param>
        /// <returns><see cref="OpenProxyGroupResponse"/></returns>
        public OpenProxyGroupResponse OpenProxyGroupSync(OpenProxyGroupRequest req)
        {
             JsonResponseModel<OpenProxyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenProxyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProxyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a security policy.
        /// </summary>
        /// <param name="req"><see cref="OpenSecurityPolicyRequest"/></param>
        /// <returns><see cref="OpenSecurityPolicyResponse"/></returns>
        public async Task<OpenSecurityPolicyResponse> OpenSecurityPolicy(OpenSecurityPolicyRequest req)
        {
             JsonResponseModel<OpenSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a security policy.
        /// </summary>
        /// <param name="req"><see cref="OpenSecurityPolicyRequest"/></param>
        /// <returns><see cref="OpenSecurityPolicyResponse"/></returns>
        public OpenSecurityPolicyResponse OpenSecurityPolicySync(OpenSecurityPolicyRequest req)
        {
             JsonResponseModel<OpenSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the added origin server (server) IP or domain name.
        /// </summary>
        /// <param name="req"><see cref="RemoveRealServersRequest"/></param>
        /// <returns><see cref="RemoveRealServersResponse"/></returns>
        public async Task<RemoveRealServersResponse> RemoveRealServers(RemoveRealServersRequest req)
        {
             JsonResponseModel<RemoveRealServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the added origin server (server) IP or domain name.
        /// </summary>
        /// <param name="req"><see cref="RemoveRealServersRequest"/></param>
        /// <returns><see cref="RemoveRealServersResponse"/></returns>
        public RemoveRealServersResponse RemoveRealServersSync(RemoveRealServersRequest req)
        {
             JsonResponseModel<RemoveRealServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveRealServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveRealServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SetAuthentication) is used for the advanced authentication configuration of connections, including authentication methods and their certificates. If only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="SetAuthenticationRequest"/></param>
        /// <returns><see cref="SetAuthenticationResponse"/></returns>
        public async Task<SetAuthenticationResponse> SetAuthentication(SetAuthenticationRequest req)
        {
             JsonResponseModel<SetAuthenticationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAuthentication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAuthenticationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SetAuthentication) is used for the advanced authentication configuration of connections, including authentication methods and their certificates. If only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="SetAuthenticationRequest"/></param>
        /// <returns><see cref="SetAuthenticationResponse"/></returns>
        public SetAuthenticationResponse SetAuthenticationSync(SetAuthenticationRequest req)
        {
             JsonResponseModel<SetAuthenticationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAuthentication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAuthenticationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
