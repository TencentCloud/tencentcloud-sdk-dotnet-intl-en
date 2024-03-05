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
       private const string sdkVersion = "SDK_NET_3.0.851";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GaapClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add the information of the origin server (server), which supports IP or the domain name.
        /// </summary>
        /// <param name="req"><see cref="AddRealServersRequest"/></param>
        /// <returns><see cref="AddRealServersResponse"/></returns>
        public Task<AddRealServersResponse> AddRealServers(AddRealServersRequest req)
        {
            return InternalRequestAsync<AddRealServersResponse>(req, "AddRealServers");
        }

        /// <summary>
        /// This API is used to add the information of the origin server (server), which supports IP or the domain name.
        /// </summary>
        /// <param name="req"><see cref="AddRealServersRequest"/></param>
        /// <returns><see cref="AddRealServersResponse"/></returns>
        public AddRealServersResponse AddRealServersSync(AddRealServersRequest req)
        {
            return InternalRequestAsync<AddRealServersResponse>(req, "AddRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (BindListenerRealServers) is used for the TCP/UDP listener to bind/unbind the origin server.
        /// Note: This API unbinds the previously bound origin servers, and binds the origin servers selected for this call. For example, the previously bound origin servers are A, B and C, and the origin servers selected for this call are C, D and E, then the origin servers bound after this call will be C, D and E.
        /// </summary>
        /// <param name="req"><see cref="BindListenerRealServersRequest"/></param>
        /// <returns><see cref="BindListenerRealServersResponse"/></returns>
        public Task<BindListenerRealServersResponse> BindListenerRealServers(BindListenerRealServersRequest req)
        {
            return InternalRequestAsync<BindListenerRealServersResponse>(req, "BindListenerRealServers");
        }

        /// <summary>
        /// This API (BindListenerRealServers) is used for the TCP/UDP listener to bind/unbind the origin server.
        /// Note: This API unbinds the previously bound origin servers, and binds the origin servers selected for this call. For example, the previously bound origin servers are A, B and C, and the origin servers selected for this call are C, D and E, then the origin servers bound after this call will be C, D and E.
        /// </summary>
        /// <param name="req"><see cref="BindListenerRealServersRequest"/></param>
        /// <returns><see cref="BindListenerRealServersResponse"/></returns>
        public BindListenerRealServersResponse BindListenerRealServersSync(BindListenerRealServersRequest req)
        {
            return InternalRequestAsync<BindListenerRealServersResponse>(req, "BindListenerRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an origin server to the forwarding rules of layer-7 listeners. Note: This API unbinds all previously bound origin servers before binding those selected.
        /// </summary>
        /// <param name="req"><see cref="BindRuleRealServersRequest"/></param>
        /// <returns><see cref="BindRuleRealServersResponse"/></returns>
        public Task<BindRuleRealServersResponse> BindRuleRealServers(BindRuleRealServersRequest req)
        {
            return InternalRequestAsync<BindRuleRealServersResponse>(req, "BindRuleRealServers");
        }

        /// <summary>
        /// This API is used to bind an origin server to the forwarding rules of layer-7 listeners. Note: This API unbinds all previously bound origin servers before binding those selected.
        /// </summary>
        /// <param name="req"><see cref="BindRuleRealServersRequest"/></param>
        /// <returns><see cref="BindRuleRealServersResponse"/></returns>
        public BindRuleRealServersResponse BindRuleRealServersSync(BindRuleRealServersRequest req)
        {
            return InternalRequestAsync<BindRuleRealServersResponse>(req, "BindRuleRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CheckProxyCreate) is used to query whether an acceleration connection with the specified configuration can be created.
        /// </summary>
        /// <param name="req"><see cref="CheckProxyCreateRequest"/></param>
        /// <returns><see cref="CheckProxyCreateResponse"/></returns>
        public Task<CheckProxyCreateResponse> CheckProxyCreate(CheckProxyCreateRequest req)
        {
            return InternalRequestAsync<CheckProxyCreateResponse>(req, "CheckProxyCreate");
        }

        /// <summary>
        /// This API (CheckProxyCreate) is used to query whether an acceleration connection with the specified configuration can be created.
        /// </summary>
        /// <param name="req"><see cref="CheckProxyCreateRequest"/></param>
        /// <returns><see cref="CheckProxyCreateResponse"/></returns>
        public CheckProxyCreateResponse CheckProxyCreateSync(CheckProxyCreateRequest req)
        {
            return InternalRequestAsync<CheckProxyCreateResponse>(req, "CheckProxyCreate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CloseProxies) is used to disable connections. If disabled, no traffic will be generated, but the basic configuration fee will still be incurred.
        /// </summary>
        /// <param name="req"><see cref="CloseProxiesRequest"/></param>
        /// <returns><see cref="CloseProxiesResponse"/></returns>
        public Task<CloseProxiesResponse> CloseProxies(CloseProxiesRequest req)
        {
            return InternalRequestAsync<CloseProxiesResponse>(req, "CloseProxies");
        }

        /// <summary>
        /// This API (CloseProxies) is used to disable connections. If disabled, no traffic will be generated, but the basic configuration fee will still be incurred.
        /// </summary>
        /// <param name="req"><see cref="CloseProxiesRequest"/></param>
        /// <returns><see cref="CloseProxiesResponse"/></returns>
        public CloseProxiesResponse CloseProxiesSync(CloseProxiesRequest req)
        {
            return InternalRequestAsync<CloseProxiesResponse>(req, "CloseProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a connection group. Once disabled, the connection group will no longer generate traffic, but the basic connection configuration fees will still be incurred every day.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyGroupRequest"/></param>
        /// <returns><see cref="CloseProxyGroupResponse"/></returns>
        public Task<CloseProxyGroupResponse> CloseProxyGroup(CloseProxyGroupRequest req)
        {
            return InternalRequestAsync<CloseProxyGroupResponse>(req, "CloseProxyGroup");
        }

        /// <summary>
        /// This API is used to disable a connection group. Once disabled, the connection group will no longer generate traffic, but the basic connection configuration fees will still be incurred every day.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyGroupRequest"/></param>
        /// <returns><see cref="CloseProxyGroupResponse"/></returns>
        public CloseProxyGroupResponse CloseProxyGroupSync(CloseProxyGroupRequest req)
        {
            return InternalRequestAsync<CloseProxyGroupResponse>(req, "CloseProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a security policy.
        /// </summary>
        /// <param name="req"><see cref="CloseSecurityPolicyRequest"/></param>
        /// <returns><see cref="CloseSecurityPolicyResponse"/></returns>
        public Task<CloseSecurityPolicyResponse> CloseSecurityPolicy(CloseSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CloseSecurityPolicyResponse>(req, "CloseSecurityPolicy");
        }

        /// <summary>
        /// This API is used to disable a security policy.
        /// </summary>
        /// <param name="req"><see cref="CloseSecurityPolicyRequest"/></param>
        /// <returns><see cref="CloseSecurityPolicyResponse"/></returns>
        public CloseSecurityPolicyResponse CloseSecurityPolicySync(CloseSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CloseSecurityPolicyResponse>(req, "CloseSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateCertificate) is used to create the GAAP certificates and configuration files, including basic authentication configuration files, client CA certificates, server SSL certificates, GAAP SSL certificates, and origin server CA certificates.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate");
        }

        /// <summary>
        /// This API (CreateCertificate) is used to create the GAAP certificates and configuration files, including basic authentication configuration files, client CA certificates, server SSL certificates, GAAP SSL certificates, and origin server CA certificates.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public CreateCertificateResponse CreateCertificateSync(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom header of the HTTP/HTTPS listener. When client requests reach the listener, they will be forwarded to the origin with this custom hearer.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomHeaderRequest"/></param>
        /// <returns><see cref="CreateCustomHeaderResponse"/></returns>
        public Task<CreateCustomHeaderResponse> CreateCustomHeader(CreateCustomHeaderRequest req)
        {
            return InternalRequestAsync<CreateCustomHeaderResponse>(req, "CreateCustomHeader");
        }

        /// <summary>
        /// This API is used to create a custom header of the HTTP/HTTPS listener. When client requests reach the listener, they will be forwarded to the origin with this custom hearer.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomHeaderRequest"/></param>
        /// <returns><see cref="CreateCustomHeaderResponse"/></returns>
        public CreateCustomHeaderResponse CreateCustomHeaderSync(CreateCustomHeaderRequest req)
        {
            return InternalRequestAsync<CreateCustomHeaderResponse>(req, "CreateCustomHeader")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateDomain) is used to create the access domain name for the HTTP/HTTPS listener. Clients request the backend data by accessing this domain.
        /// This API only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain");
        }

        /// <summary>
        /// This API (CreateDomain) is used to create the access domain name for the HTTP/HTTPS listener. Clients request the backend data by accessing this domain.
        /// This API only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to customize the error code of an error response to the specified domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="CreateDomainErrorPageInfoResponse"/></returns>
        public Task<CreateDomainErrorPageInfoResponse> CreateDomainErrorPageInfo(CreateDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<CreateDomainErrorPageInfoResponse>(req, "CreateDomainErrorPageInfo");
        }

        /// <summary>
        /// This API is used to customize the error code of an error response to the specified domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="CreateDomainErrorPageInfoResponse"/></returns>
        public CreateDomainErrorPageInfoResponse CreateDomainErrorPageInfoSync(CreateDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<CreateDomainErrorPageInfoResponse>(req, "CreateDomainErrorPageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTP listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPListenerResponse"/></returns>
        public Task<CreateHTTPListenerResponse> CreateHTTPListener(CreateHTTPListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPListenerResponse>(req, "CreateHTTPListener");
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTP listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPListenerResponse"/></returns>
        public CreateHTTPListenerResponse CreateHTTPListenerSync(CreateHTTPListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPListenerResponse>(req, "CreateHTTPListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTPS listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPSListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPSListenerResponse"/></returns>
        public Task<CreateHTTPSListenerResponse> CreateHTTPSListener(CreateHTTPSListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPSListenerResponse>(req, "CreateHTTPSListener");
        }

        /// <summary>
        /// This API (CreateHTTPListener) is used to create an HTTPS listener in the connection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPSListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPSListenerResponse"/></returns>
        public CreateHTTPSListenerResponse CreateHTTPSListenerSync(CreateHTTPSListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPSListenerResponse>(req, "CreateHTTPSListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create/replicate an acceleration connection with the specified configuration. To replicate a connection, the basic configuration parameters need to be set for the new connection, and `ClonedProxyId` is needed to identify the replicated connection.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public Task<CreateProxyResponse> CreateProxy(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy");
        }

        /// <summary>
        /// This API is used to create/replicate an acceleration connection with the specified configuration. To replicate a connection, the basic configuration parameters need to be set for the new connection, and `ClonedProxyId` is needed to identify the replicated connection.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public CreateProxyResponse CreateProxySync(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateProxyGroup) is used to create a connection group.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupRequest"/></param>
        /// <returns><see cref="CreateProxyGroupResponse"/></returns>
        public Task<CreateProxyGroupResponse> CreateProxyGroup(CreateProxyGroupRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupResponse>(req, "CreateProxyGroup");
        }

        /// <summary>
        /// This API (CreateProxyGroup) is used to create a connection group.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupRequest"/></param>
        /// <returns><see cref="CreateProxyGroupResponse"/></returns>
        public CreateProxyGroupResponse CreateProxyGroupSync(CreateProxyGroupRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupResponse>(req, "CreateProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateProxyGroupDomain) is used to create the connection group domain name, and enable the domain name resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupDomainRequest"/></param>
        /// <returns><see cref="CreateProxyGroupDomainResponse"/></returns>
        public Task<CreateProxyGroupDomainResponse> CreateProxyGroupDomain(CreateProxyGroupDomainRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupDomainResponse>(req, "CreateProxyGroupDomain");
        }

        /// <summary>
        /// This API (CreateProxyGroupDomain) is used to create the connection group domain name, and enable the domain name resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupDomainRequest"/></param>
        /// <returns><see cref="CreateProxyGroupDomainResponse"/></returns>
        public CreateProxyGroupDomainResponse CreateProxyGroupDomainSync(CreateProxyGroupDomainRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupDomainResponse>(req, "CreateProxyGroupDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateRule) is used to create the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// This API (CreateRule) is used to create the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create security policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy");
        }

        /// <summary>
        /// This API is used to create security policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add security policy rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityRulesResponse"/></returns>
        public Task<CreateSecurityRulesResponse> CreateSecurityRules(CreateSecurityRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityRulesResponse>(req, "CreateSecurityRules");
        }

        /// <summary>
        /// This API is used to add security policy rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityRulesResponse"/></returns>
        public CreateSecurityRulesResponse CreateSecurityRulesSync(CreateSecurityRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityRulesResponse>(req, "CreateSecurityRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create TCP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateTCPListenersRequest"/></param>
        /// <returns><see cref="CreateTCPListenersResponse"/></returns>
        public Task<CreateTCPListenersResponse> CreateTCPListeners(CreateTCPListenersRequest req)
        {
            return InternalRequestAsync<CreateTCPListenersResponse>(req, "CreateTCPListeners");
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create TCP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateTCPListenersRequest"/></param>
        /// <returns><see cref="CreateTCPListenersResponse"/></returns>
        public CreateTCPListenersResponse CreateTCPListenersSync(CreateTCPListenersRequest req)
        {
            return InternalRequestAsync<CreateTCPListenersResponse>(req, "CreateTCPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create UDP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateUDPListenersRequest"/></param>
        /// <returns><see cref="CreateUDPListenersResponse"/></returns>
        public Task<CreateUDPListenersResponse> CreateUDPListeners(CreateUDPListenersRequest req)
        {
            return InternalRequestAsync<CreateUDPListenersResponse>(req, "CreateUDPListeners");
        }

        /// <summary>
        /// This API (CreateTCPListeners) is used to batch create UDP listeners of single connections or connection groups.
        /// </summary>
        /// <param name="req"><see cref="CreateUDPListenersRequest"/></param>
        /// <returns><see cref="CreateUDPListenersResponse"/></returns>
        public CreateUDPListenersResponse CreateUDPListenersSync(CreateUDPListenersRequest req)
        {
            return InternalRequestAsync<CreateUDPListenersResponse>(req, "CreateUDPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate");
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public DeleteCertificateResponse DeleteCertificateSync(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteDomain) is only applicable to layer-7 listeners. It is used to delete the domain names of this listener, and all the rules under the domain name. All rules bound to the origin server are unbound automatically.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain");
        }

        /// <summary>
        /// This API (DeleteDomain) is only applicable to layer-7 listeners. It is used to delete the domain names of this listener, and all the rules under the domain name. All rules bound to the origin server are unbound automatically.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom error code for a domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DeleteDomainErrorPageInfoResponse"/></returns>
        public Task<DeleteDomainErrorPageInfoResponse> DeleteDomainErrorPageInfo(DeleteDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DeleteDomainErrorPageInfoResponse>(req, "DeleteDomainErrorPageInfo");
        }

        /// <summary>
        /// This API is used to delete a custom error code for a domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DeleteDomainErrorPageInfoResponse"/></returns>
        public DeleteDomainErrorPageInfoResponse DeleteDomainErrorPageInfoSync(DeleteDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DeleteDomainErrorPageInfoResponse>(req, "DeleteDomainErrorPageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteListeners) is used to batch delete the listeners of a connection or connection group, including layer-4/7 listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public Task<DeleteListenersResponse> DeleteListeners(DeleteListenersRequest req)
        {
            return InternalRequestAsync<DeleteListenersResponse>(req, "DeleteListeners");
        }

        /// <summary>
        /// This API (DeleteListeners) is used to batch delete the listeners of a connection or connection group, including layer-4/7 listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public DeleteListenersResponse DeleteListenersSync(DeleteListenersRequest req)
        {
            return InternalRequestAsync<DeleteListenersResponse>(req, "DeleteListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteProxyGroup) is used to delete a connection group.
        /// </summary>
        /// <param name="req"><see cref="DeleteProxyGroupRequest"/></param>
        /// <returns><see cref="DeleteProxyGroupResponse"/></returns>
        public Task<DeleteProxyGroupResponse> DeleteProxyGroup(DeleteProxyGroupRequest req)
        {
            return InternalRequestAsync<DeleteProxyGroupResponse>(req, "DeleteProxyGroup");
        }

        /// <summary>
        /// This API (DeleteProxyGroup) is used to delete a connection group.
        /// </summary>
        /// <param name="req"><see cref="DeleteProxyGroupRequest"/></param>
        /// <returns><see cref="DeleteProxyGroupResponse"/></returns>
        public DeleteProxyGroupResponse DeleteProxyGroupSync(DeleteProxyGroupRequest req)
        {
            return InternalRequestAsync<DeleteProxyGroupResponse>(req, "DeleteProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete the forwarding rules of HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a security policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy");
        }

        /// <summary>
        /// This API is used to delete a security policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete security policy rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityRulesRequest"/></param>
        /// <returns><see cref="DeleteSecurityRulesResponse"/></returns>
        public Task<DeleteSecurityRulesResponse> DeleteSecurityRules(DeleteSecurityRulesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityRulesResponse>(req, "DeleteSecurityRules");
        }

        /// <summary>
        /// This API is used to delete security policy rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityRulesRequest"/></param>
        /// <returns><see cref="DeleteSecurityRulesResponse"/></returns>
        public DeleteSecurityRulesResponse DeleteSecurityRulesSync(DeleteSecurityRulesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityRulesResponse>(req, "DeleteSecurityRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAccessRegions) is used to query acceleration region (client access region).
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsResponse"/></returns>
        public Task<DescribeAccessRegionsResponse> DescribeAccessRegions(DescribeAccessRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsResponse>(req, "DescribeAccessRegions");
        }

        /// <summary>
        /// This API (DescribeAccessRegions) is used to query acceleration region (client access region).
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsResponse"/></returns>
        public DescribeAccessRegionsResponse DescribeAccessRegionsSync(DescribeAccessRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsResponse>(req, "DescribeAccessRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the available accelerator region based on the origin server region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsByDestRegionRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsByDestRegionResponse"/></returns>
        public Task<DescribeAccessRegionsByDestRegionResponse> DescribeAccessRegionsByDestRegion(DescribeAccessRegionsByDestRegionRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsByDestRegionResponse>(req, "DescribeAccessRegionsByDestRegion");
        }

        /// <summary>
        /// This API is used to query the available accelerator region based on the origin server region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsByDestRegionRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsByDestRegionResponse"/></returns>
        public DescribeAccessRegionsByDestRegionResponse DescribeAccessRegionsByDestRegionSync(DescribeAccessRegionsByDestRegionRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsByDestRegionResponse>(req, "DescribeAccessRegionsByDestRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a request signature that can prevent parameter tampering in the process of triggering orders, getting quotes, or activating subscription services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthSignatureRequest"/></param>
        /// <returns><see cref="DescribeAuthSignatureResponse"/></returns>
        public Task<DescribeAuthSignatureResponse> DescribeAuthSignature(DescribeAuthSignatureRequest req)
        {
            return InternalRequestAsync<DescribeAuthSignatureResponse>(req, "DescribeAuthSignature");
        }

        /// <summary>
        /// This API is used to get a request signature that can prevent parameter tampering in the process of triggering orders, getting quotes, or activating subscription services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthSignatureRequest"/></param>
        /// <returns><see cref="DescribeAuthSignatureResponse"/></returns>
        public DescribeAuthSignatureResponse DescribeAuthSignatureSync(DescribeAuthSignatureRequest req)
        {
            return InternalRequestAsync<DescribeAuthSignatureResponse>(req, "DescribeAuthSignature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query names of blocked custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackHeaderRequest"/></param>
        /// <returns><see cref="DescribeBlackHeaderResponse"/></returns>
        public Task<DescribeBlackHeaderResponse> DescribeBlackHeader(DescribeBlackHeaderRequest req)
        {
            return InternalRequestAsync<DescribeBlackHeaderResponse>(req, "DescribeBlackHeader");
        }

        /// <summary>
        /// This API is used to query names of blocked custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackHeaderRequest"/></param>
        /// <returns><see cref="DescribeBlackHeaderResponse"/></returns>
        public DescribeBlackHeaderResponse DescribeBlackHeaderSync(DescribeBlackHeaderRequest req)
        {
            return InternalRequestAsync<DescribeBlackHeaderResponse>(req, "DescribeBlackHeader")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCertificateDetail) is used to query certificate details, including the certificate ID, name, type, content, key, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail");
        }

        /// <summary>
        /// This API (DescribeCertificateDetail) is used to query certificate details, including the certificate ID, name, type, content, key, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public DescribeCertificateDetailResponse DescribeCertificateDetailSync(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCertificates) is used to query the list of available certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates");
        }

        /// <summary>
        /// This API (DescribeCertificates) is used to query the list of available certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public DescribeCertificatesResponse DescribeCertificatesSync(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCountryAreaMapping) is used to obtain the country/region code mapping table.
        /// </summary>
        /// <param name="req"><see cref="DescribeCountryAreaMappingRequest"/></param>
        /// <returns><see cref="DescribeCountryAreaMappingResponse"/></returns>
        public Task<DescribeCountryAreaMappingResponse> DescribeCountryAreaMapping(DescribeCountryAreaMappingRequest req)
        {
            return InternalRequestAsync<DescribeCountryAreaMappingResponse>(req, "DescribeCountryAreaMapping");
        }

        /// <summary>
        /// This API (DescribeCountryAreaMapping) is used to obtain the country/region code mapping table.
        /// </summary>
        /// <param name="req"><see cref="DescribeCountryAreaMappingRequest"/></param>
        /// <returns><see cref="DescribeCountryAreaMappingResponse"/></returns>
        public DescribeCountryAreaMappingResponse DescribeCountryAreaMappingSync(DescribeCountryAreaMappingRequest req)
        {
            return InternalRequestAsync<DescribeCountryAreaMappingResponse>(req, "DescribeCountryAreaMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomHeaderRequest"/></param>
        /// <returns><see cref="DescribeCustomHeaderResponse"/></returns>
        public Task<DescribeCustomHeaderResponse> DescribeCustomHeader(DescribeCustomHeaderRequest req)
        {
            return InternalRequestAsync<DescribeCustomHeaderResponse>(req, "DescribeCustomHeader");
        }

        /// <summary>
        /// This API is used to query the list of custom headers.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomHeaderRequest"/></param>
        /// <returns><see cref="DescribeCustomHeaderResponse"/></returns>
        public DescribeCustomHeaderResponse DescribeCustomHeaderSync(DescribeCustomHeaderRequest req)
        {
            return InternalRequestAsync<DescribeCustomHeaderResponse>(req, "DescribeCustomHeader")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDestRegions) is used to query an origin server region (i.e., the region in which the origin server locates).
        /// </summary>
        /// <param name="req"><see cref="DescribeDestRegionsRequest"/></param>
        /// <returns><see cref="DescribeDestRegionsResponse"/></returns>
        public Task<DescribeDestRegionsResponse> DescribeDestRegions(DescribeDestRegionsRequest req)
        {
            return InternalRequestAsync<DescribeDestRegionsResponse>(req, "DescribeDestRegions");
        }

        /// <summary>
        /// This API (DescribeDestRegions) is used to query an origin server region (i.e., the region in which the origin server locates).
        /// </summary>
        /// <param name="req"><see cref="DescribeDestRegionsRequest"/></param>
        /// <returns><see cref="DescribeDestRegionsResponse"/></returns>
        public DescribeDestRegionsResponse DescribeDestRegionsSync(DescribeDestRegionsRequest req)
        {
            return InternalRequestAsync<DescribeDestRegionsResponse>(req, "DescribeDestRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the custom error response to a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoResponse"/></returns>
        public Task<DescribeDomainErrorPageInfoResponse> DescribeDomainErrorPageInfo(DescribeDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoResponse>(req, "DescribeDomainErrorPageInfo");
        }

        /// <summary>
        /// This API is used to query the custom error response to a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoResponse"/></returns>
        public DescribeDomainErrorPageInfoResponse DescribeDomainErrorPageInfoSync(DescribeDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoResponse>(req, "DescribeDomainErrorPageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the corresponding error response by a custom error ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoByIdsRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoByIdsResponse"/></returns>
        public Task<DescribeDomainErrorPageInfoByIdsResponse> DescribeDomainErrorPageInfoByIds(DescribeDomainErrorPageInfoByIdsRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoByIdsResponse>(req, "DescribeDomainErrorPageInfoByIds");
        }

        /// <summary>
        /// This API is used to query the corresponding error response by a custom error ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoByIdsRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoByIdsResponse"/></returns>
        public DescribeDomainErrorPageInfoByIdsResponse DescribeDomainErrorPageInfoByIdsSync(DescribeDomainErrorPageInfoByIdsRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoByIdsResponse>(req, "DescribeDomainErrorPageInfoByIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and connection groups from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAndStatisticsProxyRequest"/></param>
        /// <returns><see cref="DescribeGroupAndStatisticsProxyResponse"/></returns>
        public Task<DescribeGroupAndStatisticsProxyResponse> DescribeGroupAndStatisticsProxy(DescribeGroupAndStatisticsProxyRequest req)
        {
            return InternalRequestAsync<DescribeGroupAndStatisticsProxyResponse>(req, "DescribeGroupAndStatisticsProxy");
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and connection groups from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAndStatisticsProxyRequest"/></param>
        /// <returns><see cref="DescribeGroupAndStatisticsProxyResponse"/></returns>
        public DescribeGroupAndStatisticsProxyResponse DescribeGroupAndStatisticsProxySync(DescribeGroupAndStatisticsProxyRequest req)
        {
            return InternalRequestAsync<DescribeGroupAndStatisticsProxyResponse>(req, "DescribeGroupAndStatisticsProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeGroupDomainConfig) is used to obtain the domain name resolution configuration details of a connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDomainConfigRequest"/></param>
        /// <returns><see cref="DescribeGroupDomainConfigResponse"/></returns>
        public Task<DescribeGroupDomainConfigResponse> DescribeGroupDomainConfig(DescribeGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<DescribeGroupDomainConfigResponse>(req, "DescribeGroupDomainConfig");
        }

        /// <summary>
        /// This API (DescribeGroupDomainConfig) is used to obtain the domain name resolution configuration details of a connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDomainConfigRequest"/></param>
        /// <returns><see cref="DescribeGroupDomainConfigResponse"/></returns>
        public DescribeGroupDomainConfigResponse DescribeGroupDomainConfigSync(DescribeGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<DescribeGroupDomainConfigResponse>(req, "DescribeGroupDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeHTTPListeners) is used to query HTTP listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPListenersResponse"/></returns>
        public Task<DescribeHTTPListenersResponse> DescribeHTTPListeners(DescribeHTTPListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPListenersResponse>(req, "DescribeHTTPListeners");
        }

        /// <summary>
        /// This API (DescribeHTTPListeners) is used to query HTTP listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPListenersResponse"/></returns>
        public DescribeHTTPListenersResponse DescribeHTTPListenersSync(DescribeHTTPListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPListenersResponse>(req, "DescribeHTTPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeHTTPSListeners) is used to query HTTPS listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPSListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPSListenersResponse"/></returns>
        public Task<DescribeHTTPSListenersResponse> DescribeHTTPSListeners(DescribeHTTPSListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPSListenersResponse>(req, "DescribeHTTPSListeners");
        }

        /// <summary>
        /// This API (DescribeHTTPSListeners) is used to query HTTPS listener information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPSListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPSListenersResponse"/></returns>
        public DescribeHTTPSListenersResponse DescribeHTTPSListenersSync(DescribeHTTPSListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPSListenersResponse>(req, "DescribeHTTPSListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeListenerRealServers) is used to query the origin server list of TCP/UDP listeners, including the list of bound origin servers and origin servers that can be bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerRealServersRequest"/></param>
        /// <returns><see cref="DescribeListenerRealServersResponse"/></returns>
        public Task<DescribeListenerRealServersResponse> DescribeListenerRealServers(DescribeListenerRealServersRequest req)
        {
            return InternalRequestAsync<DescribeListenerRealServersResponse>(req, "DescribeListenerRealServers");
        }

        /// <summary>
        /// This API (DescribeListenerRealServers) is used to query the origin server list of TCP/UDP listeners, including the list of bound origin servers and origin servers that can be bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerRealServersRequest"/></param>
        /// <returns><see cref="DescribeListenerRealServersResponse"/></returns>
        public DescribeListenerRealServersResponse DescribeListenerRealServersSync(DescribeListenerRealServersRequest req)
        {
            return InternalRequestAsync<DescribeListenerRealServersResponse>(req, "DescribeListenerRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeListenerStatisticsResponse"/></returns>
        public Task<DescribeListenerStatisticsResponse> DescribeListenerStatistics(DescribeListenerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeListenerStatisticsResponse>(req, "DescribeListenerStatistics");
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeListenerStatisticsResponse"/></returns>
        public DescribeListenerStatisticsResponse DescribeListenerStatisticsSync(DescribeListenerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeListenerStatisticsResponse>(req, "DescribeListenerStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeProxies) is used to query the connection instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public Task<DescribeProxiesResponse> DescribeProxies(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies");
        }

        /// <summary>
        /// This API (DescribeProxies) is used to query the connection instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public DescribeProxiesResponse DescribeProxiesSync(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeProxiesStatus) is used to query the connection status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesStatusRequest"/></param>
        /// <returns><see cref="DescribeProxiesStatusResponse"/></returns>
        public Task<DescribeProxiesStatusResponse> DescribeProxiesStatus(DescribeProxiesStatusRequest req)
        {
            return InternalRequestAsync<DescribeProxiesStatusResponse>(req, "DescribeProxiesStatus");
        }

        /// <summary>
        /// This API (DescribeProxiesStatus) is used to query the connection status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesStatusRequest"/></param>
        /// <returns><see cref="DescribeProxiesStatusResponse"/></returns>
        public DescribeProxiesStatusResponse DescribeProxiesStatusSync(DescribeProxiesStatusRequest req)
        {
            return InternalRequestAsync<DescribeProxiesStatusResponse>(req, "DescribeProxiesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and listeners from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyAndStatisticsListenersRequest"/></param>
        /// <returns><see cref="DescribeProxyAndStatisticsListenersResponse"/></returns>
        public Task<DescribeProxyAndStatisticsListenersResponse> DescribeProxyAndStatisticsListeners(DescribeProxyAndStatisticsListenersRequest req)
        {
            return InternalRequestAsync<DescribeProxyAndStatisticsListenersResponse>(req, "DescribeProxyAndStatisticsListeners");
        }

        /// <summary>
        /// This is an internal API. It is used to query the information of connections and listeners from which the statistics can be derived.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyAndStatisticsListenersRequest"/></param>
        /// <returns><see cref="DescribeProxyAndStatisticsListenersResponse"/></returns>
        public DescribeProxyAndStatisticsListenersResponse DescribeProxyAndStatisticsListenersSync(DescribeProxyAndStatisticsListenersRequest req)
        {
            return InternalRequestAsync<DescribeProxyAndStatisticsListenersResponse>(req, "DescribeProxyAndStatisticsListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeProxyDetail) is used to query connection details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeProxyDetailResponse"/></returns>
        public Task<DescribeProxyDetailResponse> DescribeProxyDetail(DescribeProxyDetailRequest req)
        {
            return InternalRequestAsync<DescribeProxyDetailResponse>(req, "DescribeProxyDetail");
        }

        /// <summary>
        /// This API (DescribeProxyDetail) is used to query connection details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeProxyDetailResponse"/></returns>
        public DescribeProxyDetailResponse DescribeProxyDetailSync(DescribeProxyDetailRequest req)
        {
            return InternalRequestAsync<DescribeProxyDetailResponse>(req, "DescribeProxyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeProxyGroupDetails) is used to query connection group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupDetailsResponse"/></returns>
        public Task<DescribeProxyGroupDetailsResponse> DescribeProxyGroupDetails(DescribeProxyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupDetailsResponse>(req, "DescribeProxyGroupDetails");
        }

        /// <summary>
        /// This API (DescribeProxyGroupDetails) is used to query connection group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupDetailsResponse"/></returns>
        public DescribeProxyGroupDetailsResponse DescribeProxyGroupDetailsSync(DescribeProxyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupDetailsResponse>(req, "DescribeProxyGroupDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeProxyGroupList) is used to pull the list of connection groups and the basic information of each connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupListRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupListResponse"/></returns>
        public Task<DescribeProxyGroupListResponse> DescribeProxyGroupList(DescribeProxyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupListResponse>(req, "DescribeProxyGroupList");
        }

        /// <summary>
        /// This API (DescribeProxyGroupList) is used to pull the list of connection groups and the basic information of each connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupListRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupListResponse"/></returns>
        public DescribeProxyGroupListResponse DescribeProxyGroupListSync(DescribeProxyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupListResponse>(req, "DescribeProxyGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupStatisticsResponse"/></returns>
        public Task<DescribeProxyGroupStatisticsResponse> DescribeProxyGroupStatistics(DescribeProxyGroupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupStatisticsResponse>(req, "DescribeProxyGroupStatistics");
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, and concurrence data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupStatisticsResponse"/></returns>
        public DescribeProxyGroupStatisticsResponse DescribeProxyGroupStatisticsSync(DescribeProxyGroupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupStatisticsResponse>(req, "DescribeProxyGroupStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, concurrence, packet loss, and latency data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyStatisticsResponse"/></returns>
        public Task<DescribeProxyStatisticsResponse> DescribeProxyStatistics(DescribeProxyStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyStatisticsResponse>(req, "DescribeProxyStatistics");
        }

        /// <summary>
        /// This API is used to query listener statistics, including inbound/outbound bandwidth, inbound/outbound packets, concurrence, packet loss, and latency data. It supports granularities of 300, 3,600, and 86,400. Default value is the highest within the granularity range.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyStatisticsResponse"/></returns>
        public DescribeProxyStatisticsResponse DescribeProxyStatisticsSync(DescribeProxyStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyStatisticsResponse>(req, "DescribeProxyStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the statistics of an origin server's health check results. Origin server status is displayed as 1 (normal) or 0 (exceptional). The queried origin server must be bound to a listener or rule, and the ID of the bound listener or rule must be specified for the query. This API supports displaying origin server status statistics at a 1-minute granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRealServerStatisticsResponse"/></returns>
        public Task<DescribeRealServerStatisticsResponse> DescribeRealServerStatistics(DescribeRealServerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRealServerStatisticsResponse>(req, "DescribeRealServerStatistics");
        }

        /// <summary>
        /// This API is used to query the statistics of an origin server's health check results. Origin server status is displayed as 1 (normal) or 0 (exceptional). The queried origin server must be bound to a listener or rule, and the ID of the bound listener or rule must be specified for the query. This API supports displaying origin server status statistics at a 1-minute granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRealServerStatisticsResponse"/></returns>
        public DescribeRealServerStatisticsResponse DescribeRealServerStatisticsSync(DescribeRealServerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRealServerStatisticsResponse>(req, "DescribeRealServerStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query origin server information. It can query all origin servers under the specified project name, and supports fuzzy query by specified IPs or domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersRequest"/></param>
        /// <returns><see cref="DescribeRealServersResponse"/></returns>
        public Task<DescribeRealServersResponse> DescribeRealServers(DescribeRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRealServersResponse>(req, "DescribeRealServers");
        }

        /// <summary>
        /// This API is used to query origin server information. It can query all origin servers under the specified project name, and supports fuzzy query by specified IPs or domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersRequest"/></param>
        /// <returns><see cref="DescribeRealServersResponse"/></returns>
        public DescribeRealServersResponse DescribeRealServersSync(DescribeRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRealServersResponse>(req, "DescribeRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRealServersStatus) is used to query whether an origin server has been bound to a rule or listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersStatusRequest"/></param>
        /// <returns><see cref="DescribeRealServersStatusResponse"/></returns>
        public Task<DescribeRealServersStatusResponse> DescribeRealServersStatus(DescribeRealServersStatusRequest req)
        {
            return InternalRequestAsync<DescribeRealServersStatusResponse>(req, "DescribeRealServersStatus");
        }

        /// <summary>
        /// This API (DescribeRealServersStatus) is used to query whether an origin server has been bound to a rule or listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersStatusRequest"/></param>
        /// <returns><see cref="DescribeRealServersStatusResponse"/></returns>
        public DescribeRealServersStatusResponse DescribeRealServersStatusSync(DescribeRealServersStatusRequest req)
        {
            return InternalRequestAsync<DescribeRealServersStatusResponse>(req, "DescribeRealServersStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRegionAndPrice) is used to obtain the origin server regions and the bandwidth price gradient.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionAndPriceRequest"/></param>
        /// <returns><see cref="DescribeRegionAndPriceResponse"/></returns>
        public Task<DescribeRegionAndPriceResponse> DescribeRegionAndPrice(DescribeRegionAndPriceRequest req)
        {
            return InternalRequestAsync<DescribeRegionAndPriceResponse>(req, "DescribeRegionAndPrice");
        }

        /// <summary>
        /// This API (DescribeRegionAndPrice) is used to obtain the origin server regions and the bandwidth price gradient.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionAndPriceRequest"/></param>
        /// <returns><see cref="DescribeRegionAndPriceResponse"/></returns>
        public DescribeRegionAndPriceResponse DescribeRegionAndPriceSync(DescribeRegionAndPriceRequest req)
        {
            return InternalRequestAsync<DescribeRegionAndPriceResponse>(req, "DescribeRegionAndPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeResourcesByTag) is used to query corresponding resource information by tags, including connection, connection group, and origin server.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagResponse"/></returns>
        public Task<DescribeResourcesByTagResponse> DescribeResourcesByTag(DescribeResourcesByTagRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagResponse>(req, "DescribeResourcesByTag");
        }

        /// <summary>
        /// This API (DescribeResourcesByTag) is used to query corresponding resource information by tags, including connection, connection group, and origin server.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagResponse"/></returns>
        public DescribeResourcesByTagResponse DescribeResourcesByTagSync(DescribeResourcesByTagRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagResponse>(req, "DescribeResourcesByTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRuleRealServers) is used to query forwarding rules-related origin server information, including information of origin servers that can be bound and have been bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRealServersRequest"/></param>
        /// <returns><see cref="DescribeRuleRealServersResponse"/></returns>
        public Task<DescribeRuleRealServersResponse> DescribeRuleRealServers(DescribeRuleRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRuleRealServersResponse>(req, "DescribeRuleRealServers");
        }

        /// <summary>
        /// This API (DescribeRuleRealServers) is used to query forwarding rules-related origin server information, including information of origin servers that can be bound and have been bound.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRealServersRequest"/></param>
        /// <returns><see cref="DescribeRuleRealServersResponse"/></returns>
        public DescribeRuleRealServersResponse DescribeRuleRealServersSync(DescribeRuleRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRuleRealServersResponse>(req, "DescribeRuleRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRules) is used to query all rule information of a listener, including the domain names, paths, and list of bound origin servers. For version 3.0 connections, this API returns the advanced authentication configuration information of the domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// This API (DescribeRules) is used to query all rule information of a listener, including the domain names, paths, and list of bound origin servers. For version 3.0 connections, this API returns the advanced authentication configuration information of the domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull the list of rules based on rule ID. It supports pulling 1 to 10 rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByRuleIdsRequest"/></param>
        /// <returns><see cref="DescribeRulesByRuleIdsResponse"/></returns>
        public Task<DescribeRulesByRuleIdsResponse> DescribeRulesByRuleIds(DescribeRulesByRuleIdsRequest req)
        {
            return InternalRequestAsync<DescribeRulesByRuleIdsResponse>(req, "DescribeRulesByRuleIds");
        }

        /// <summary>
        /// This API is used to pull the list of rules based on rule ID. It supports pulling 1 to 10 rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByRuleIdsRequest"/></param>
        /// <returns><see cref="DescribeRulesByRuleIdsResponse"/></returns>
        public DescribeRulesByRuleIdsResponse DescribeRulesByRuleIdsSync(DescribeRulesByRuleIdsRequest req)
        {
            return InternalRequestAsync<DescribeRulesByRuleIdsResponse>(req, "DescribeRulesByRuleIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain security policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyDetailResponse"/></returns>
        public Task<DescribeSecurityPolicyDetailResponse> DescribeSecurityPolicyDetail(DescribeSecurityPolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyDetailResponse>(req, "DescribeSecurityPolicyDetail");
        }

        /// <summary>
        /// This API is used to obtain security policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyDetailResponse"/></returns>
        public DescribeSecurityPolicyDetailResponse DescribeSecurityPolicyDetailSync(DescribeSecurityPolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyDetailResponse>(req, "DescribeSecurityPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of security rules based on security rule ID. It supports querying 1 to 20 security rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityRulesResponse"/></returns>
        public Task<DescribeSecurityRulesResponse> DescribeSecurityRules(DescribeSecurityRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRulesResponse>(req, "DescribeSecurityRules");
        }

        /// <summary>
        /// This API is used to query the list of security rules based on security rule ID. It supports querying 1 to 20 security rules at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityRulesResponse"/></returns>
        public DescribeSecurityRulesResponse DescribeSecurityRulesSync(DescribeSecurityRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRulesResponse>(req, "DescribeSecurityRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeTCPListeners) is used to query the TCP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTCPListenersRequest"/></param>
        /// <returns><see cref="DescribeTCPListenersResponse"/></returns>
        public Task<DescribeTCPListenersResponse> DescribeTCPListeners(DescribeTCPListenersRequest req)
        {
            return InternalRequestAsync<DescribeTCPListenersResponse>(req, "DescribeTCPListeners");
        }

        /// <summary>
        /// This API (DescribeTCPListeners) is used to query the TCP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTCPListenersRequest"/></param>
        /// <returns><see cref="DescribeTCPListenersResponse"/></returns>
        public DescribeTCPListenersResponse DescribeTCPListenersSync(DescribeTCPListenersRequest req)
        {
            return InternalRequestAsync<DescribeTCPListenersResponse>(req, "DescribeTCPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeUDPListeners) is used to query the UDP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUDPListenersRequest"/></param>
        /// <returns><see cref="DescribeUDPListenersResponse"/></returns>
        public Task<DescribeUDPListenersResponse> DescribeUDPListeners(DescribeUDPListenersRequest req)
        {
            return InternalRequestAsync<DescribeUDPListenersResponse>(req, "DescribeUDPListeners");
        }

        /// <summary>
        /// This API (DescribeUDPListeners) is used to query the UDP listener information of a single connection or connection group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUDPListenersRequest"/></param>
        /// <returns><see cref="DescribeUDPListenersResponse"/></returns>
        public DescribeUDPListenersResponse DescribeUDPListenersSync(DescribeUDPListenersRequest req)
        {
            return InternalRequestAsync<DescribeUDPListenersResponse>(req, "DescribeUDPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DestroyProxies) is used to terminate a connection. If terminated, no fees will be incurred.
        /// </summary>
        /// <param name="req"><see cref="DestroyProxiesRequest"/></param>
        /// <returns><see cref="DestroyProxiesResponse"/></returns>
        public Task<DestroyProxiesResponse> DestroyProxies(DestroyProxiesRequest req)
        {
            return InternalRequestAsync<DestroyProxiesResponse>(req, "DestroyProxies");
        }

        /// <summary>
        /// This API (DestroyProxies) is used to terminate a connection. If terminated, no fees will be incurred.
        /// </summary>
        /// <param name="req"><see cref="DestroyProxiesRequest"/></param>
        /// <returns><see cref="DestroyProxiesResponse"/></returns>
        public DestroyProxiesResponse DestroyProxiesSync(DestroyProxiesRequest req)
        {
            return InternalRequestAsync<DestroyProxiesResponse>(req, "DestroyProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (InquiryPriceCreateProxy) is used to create the price inquiries of acceleration connections.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateProxyRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateProxyResponse"/></returns>
        public Task<InquiryPriceCreateProxyResponse> InquiryPriceCreateProxy(InquiryPriceCreateProxyRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateProxyResponse>(req, "InquiryPriceCreateProxy");
        }

        /// <summary>
        /// This API (InquiryPriceCreateProxy) is used to create the price inquiries of acceleration connections.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateProxyRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateProxyResponse"/></returns>
        public InquiryPriceCreateProxyResponse InquiryPriceCreateProxySync(InquiryPriceCreateProxyRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateProxyResponse>(req, "InquiryPriceCreateProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyCertificate) is used to modify a domain name certificate of a listener. domain name certificate. This API is only applicable to connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateRequest"/></param>
        /// <returns><see cref="ModifyCertificateResponse"/></returns>
        public Task<ModifyCertificateResponse> ModifyCertificate(ModifyCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResponse>(req, "ModifyCertificate");
        }

        /// <summary>
        /// This API (ModifyCertificate) is used to modify a domain name certificate of a listener. domain name certificate. This API is only applicable to connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateRequest"/></param>
        /// <returns><see cref="ModifyCertificateResponse"/></returns>
        public ModifyCertificateResponse ModifyCertificateSync(ModifyCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResponse>(req, "ModifyCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify certificate name and content.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAttributesRequest"/></param>
        /// <returns><see cref="ModifyCertificateAttributesResponse"/></returns>
        public Task<ModifyCertificateAttributesResponse> ModifyCertificateAttributes(ModifyCertificateAttributesRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAttributesResponse>(req, "ModifyCertificateAttributes");
        }

        /// <summary>
        /// This API is used to modify certificate name and content.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAttributesRequest"/></param>
        /// <returns><see cref="ModifyCertificateAttributesResponse"/></returns>
        public ModifyCertificateAttributesResponse ModifyCertificateAttributesSync(ModifyCertificateAttributesRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAttributesResponse>(req, "ModifyCertificateAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify domain names of listeners. For connections of version 3.0, it supports modifying certificates of the domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain");
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify domain names of listeners. For connections of version 3.0, it supports modifying certificates of the domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyGroupDomainConfig) is used to configure the nearest access domain name of a connection group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyGroupDomainConfigResponse"/></returns>
        public Task<ModifyGroupDomainConfigResponse> ModifyGroupDomainConfig(ModifyGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyGroupDomainConfigResponse>(req, "ModifyGroupDomainConfig");
        }

        /// <summary>
        /// This API (ModifyGroupDomainConfig) is used to configure the nearest access domain name of a connection group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyGroupDomainConfigResponse"/></returns>
        public ModifyGroupDomainConfigResponse ModifyGroupDomainConfigSync(ModifyGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyGroupDomainConfigResponse>(req, "ModifyGroupDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyHTTPListenerAttribute) is used to modify the HTTP listener configuration information of a connection. Currently only supports modifying listener name.
        /// Note: Grouped connections currently do not support HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPListenerAttributeResponse"/></returns>
        public Task<ModifyHTTPListenerAttributeResponse> ModifyHTTPListenerAttribute(ModifyHTTPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPListenerAttributeResponse>(req, "ModifyHTTPListenerAttribute");
        }

        /// <summary>
        /// This API (ModifyHTTPListenerAttribute) is used to modify the HTTP listener configuration information of a connection. Currently only supports modifying listener name.
        /// Note: Grouped connections currently do not support HTTP/HTTPS listeners.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPListenerAttributeResponse"/></returns>
        public ModifyHTTPListenerAttributeResponse ModifyHTTPListenerAttributeSync(ModifyHTTPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPListenerAttributeResponse>(req, "ModifyHTTPListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyHTTPSListenerAttribute) is used to modify HTTPS listener configurations. It currently do not support connection groups and connections of version 1.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPSListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPSListenerAttributeResponse"/></returns>
        public Task<ModifyHTTPSListenerAttributeResponse> ModifyHTTPSListenerAttribute(ModifyHTTPSListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPSListenerAttributeResponse>(req, "ModifyHTTPSListenerAttribute");
        }

        /// <summary>
        /// This API (ModifyHTTPSListenerAttribute) is used to modify HTTPS listener configurations. It currently do not support connection groups and connections of version 1.0.
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPSListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPSListenerAttributeResponse"/></returns>
        public ModifyHTTPSListenerAttributeResponse ModifyHTTPSListenerAttributeSync(ModifyHTTPSListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPSListenerAttributeResponse>(req, "ModifyHTTPSListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyProxiesAttribute) is used to modify instance attributes (currently only supports modifying connection name).
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxiesAttributeResponse"/></returns>
        public Task<ModifyProxiesAttributeResponse> ModifyProxiesAttribute(ModifyProxiesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxiesAttributeResponse>(req, "ModifyProxiesAttribute");
        }

        /// <summary>
        /// This API (ModifyProxiesAttribute) is used to modify instance attributes (currently only supports modifying connection name).
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxiesAttributeResponse"/></returns>
        public ModifyProxiesAttributeResponse ModifyProxiesAttributeSync(ModifyProxiesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxiesAttributeResponse>(req, "ModifyProxiesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyProxiesProject) is used to modify the project to which a connection belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesProjectRequest"/></param>
        /// <returns><see cref="ModifyProxiesProjectResponse"/></returns>
        public Task<ModifyProxiesProjectResponse> ModifyProxiesProject(ModifyProxiesProjectRequest req)
        {
            return InternalRequestAsync<ModifyProxiesProjectResponse>(req, "ModifyProxiesProject");
        }

        /// <summary>
        /// This API (ModifyProxiesProject) is used to modify the project to which a connection belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesProjectRequest"/></param>
        /// <returns><see cref="ModifyProxiesProjectResponse"/></returns>
        public ModifyProxiesProjectResponse ModifyProxiesProjectSync(ModifyProxiesProjectRequest req)
        {
            return InternalRequestAsync<ModifyProxiesProjectResponse>(req, "ModifyProxiesProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyProxyConfiguration) is used to modify connection configurations. You can expand or reduce the capacity based on current business requirements. It only supports connections with a Scalarable of 1. Scalarable can be obtained via DescribeProxies API.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyConfigurationRequest"/></param>
        /// <returns><see cref="ModifyProxyConfigurationResponse"/></returns>
        public Task<ModifyProxyConfigurationResponse> ModifyProxyConfiguration(ModifyProxyConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyProxyConfigurationResponse>(req, "ModifyProxyConfiguration");
        }

        /// <summary>
        /// This API (ModifyProxyConfiguration) is used to modify connection configurations. You can expand or reduce the capacity based on current business requirements. It only supports connections with a Scalarable of 1. Scalarable can be obtained via DescribeProxies API.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyConfigurationRequest"/></param>
        /// <returns><see cref="ModifyProxyConfigurationResponse"/></returns>
        public ModifyProxyConfigurationResponse ModifyProxyConfigurationSync(ModifyProxyConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyProxyConfigurationResponse>(req, "ModifyProxyConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyProxyGroupAttribute) is used to modify connection group attributes. It currently only supports modifying connection group name.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxyGroupAttributeResponse"/></returns>
        public Task<ModifyProxyGroupAttributeResponse> ModifyProxyGroupAttribute(ModifyProxyGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxyGroupAttributeResponse>(req, "ModifyProxyGroupAttribute");
        }

        /// <summary>
        /// This API (ModifyProxyGroupAttribute) is used to modify connection group attributes. It currently only supports modifying connection group name.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxyGroupAttributeResponse"/></returns>
        public ModifyProxyGroupAttributeResponse ModifyProxyGroupAttributeSync(ModifyProxyGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxyGroupAttributeResponse>(req, "ModifyProxyGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyRealServerName) is used to modify origin server names.
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerNameRequest"/></param>
        /// <returns><see cref="ModifyRealServerNameResponse"/></returns>
        public Task<ModifyRealServerNameResponse> ModifyRealServerName(ModifyRealServerNameRequest req)
        {
            return InternalRequestAsync<ModifyRealServerNameResponse>(req, "ModifyRealServerName");
        }

        /// <summary>
        /// This API (ModifyRealServerName) is used to modify origin server names.
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerNameRequest"/></param>
        /// <returns><see cref="ModifyRealServerNameResponse"/></returns>
        public ModifyRealServerNameResponse ModifyRealServerNameSync(ModifyRealServerNameRequest req)
        {
            return InternalRequestAsync<ModifyRealServerNameResponse>(req, "ModifyRealServerName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyRuleAttribute) is used to modify forwarding rule information, including health check configuration and forwarding policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleAttributeRequest"/></param>
        /// <returns><see cref="ModifyRuleAttributeResponse"/></returns>
        public Task<ModifyRuleAttributeResponse> ModifyRuleAttribute(ModifyRuleAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRuleAttributeResponse>(req, "ModifyRuleAttribute");
        }

        /// <summary>
        /// This API (ModifyRuleAttribute) is used to modify forwarding rule information, including health check configuration and forwarding policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleAttributeRequest"/></param>
        /// <returns><see cref="ModifyRuleAttributeResponse"/></returns>
        public ModifyRuleAttributeResponse ModifyRuleAttributeSync(ModifyRuleAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRuleAttributeResponse>(req, "ModifyRuleAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify security policy rule names.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityRuleResponse"/></returns>
        public Task<ModifySecurityRuleResponse> ModifySecurityRule(ModifySecurityRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityRuleResponse>(req, "ModifySecurityRule");
        }

        /// <summary>
        /// This API is used to modify security policy rule names.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityRuleResponse"/></returns>
        public ModifySecurityRuleResponse ModifySecurityRuleSync(ModifySecurityRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityRuleResponse>(req, "ModifySecurityRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyTCPListenerAttribute) is used to modify the TCP listener configuration of a connection instance, including health check configuration and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyTCPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyTCPListenerAttributeResponse"/></returns>
        public Task<ModifyTCPListenerAttributeResponse> ModifyTCPListenerAttribute(ModifyTCPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTCPListenerAttributeResponse>(req, "ModifyTCPListenerAttribute");
        }

        /// <summary>
        /// This API (ModifyTCPListenerAttribute) is used to modify the TCP listener configuration of a connection instance, including health check configuration and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyTCPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyTCPListenerAttributeResponse"/></returns>
        public ModifyTCPListenerAttributeResponse ModifyTCPListenerAttributeSync(ModifyTCPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTCPListenerAttributeResponse>(req, "ModifyTCPListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyUDPListenerAttribute) is used to modify the UDP listener configuration of a connection instance, including modification of listener names and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyUDPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyUDPListenerAttributeResponse"/></returns>
        public Task<ModifyUDPListenerAttributeResponse> ModifyUDPListenerAttribute(ModifyUDPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyUDPListenerAttributeResponse>(req, "ModifyUDPListenerAttribute");
        }

        /// <summary>
        /// This API (ModifyUDPListenerAttribute) is used to modify the UDP listener configuration of a connection instance, including modification of listener names and scheduling policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyUDPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyUDPListenerAttributeResponse"/></returns>
        public ModifyUDPListenerAttributeResponse ModifyUDPListenerAttributeSync(ModifyUDPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyUDPListenerAttributeResponse>(req, "ModifyUDPListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (OpenProxies) is used to enable one or more connections.
        /// </summary>
        /// <param name="req"><see cref="OpenProxiesRequest"/></param>
        /// <returns><see cref="OpenProxiesResponse"/></returns>
        public Task<OpenProxiesResponse> OpenProxies(OpenProxiesRequest req)
        {
            return InternalRequestAsync<OpenProxiesResponse>(req, "OpenProxies");
        }

        /// <summary>
        /// This API (OpenProxies) is used to enable one or more connections.
        /// </summary>
        /// <param name="req"><see cref="OpenProxiesRequest"/></param>
        /// <returns><see cref="OpenProxiesResponse"/></returns>
        public OpenProxiesResponse OpenProxiesSync(OpenProxiesRequest req)
        {
            return InternalRequestAsync<OpenProxiesResponse>(req, "OpenProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable all connections in a connection group.
        /// </summary>
        /// <param name="req"><see cref="OpenProxyGroupRequest"/></param>
        /// <returns><see cref="OpenProxyGroupResponse"/></returns>
        public Task<OpenProxyGroupResponse> OpenProxyGroup(OpenProxyGroupRequest req)
        {
            return InternalRequestAsync<OpenProxyGroupResponse>(req, "OpenProxyGroup");
        }

        /// <summary>
        /// This API is used to enable all connections in a connection group.
        /// </summary>
        /// <param name="req"><see cref="OpenProxyGroupRequest"/></param>
        /// <returns><see cref="OpenProxyGroupResponse"/></returns>
        public OpenProxyGroupResponse OpenProxyGroupSync(OpenProxyGroupRequest req)
        {
            return InternalRequestAsync<OpenProxyGroupResponse>(req, "OpenProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a security policy.
        /// </summary>
        /// <param name="req"><see cref="OpenSecurityPolicyRequest"/></param>
        /// <returns><see cref="OpenSecurityPolicyResponse"/></returns>
        public Task<OpenSecurityPolicyResponse> OpenSecurityPolicy(OpenSecurityPolicyRequest req)
        {
            return InternalRequestAsync<OpenSecurityPolicyResponse>(req, "OpenSecurityPolicy");
        }

        /// <summary>
        /// This API is used to enable a security policy.
        /// </summary>
        /// <param name="req"><see cref="OpenSecurityPolicyRequest"/></param>
        /// <returns><see cref="OpenSecurityPolicyResponse"/></returns>
        public OpenSecurityPolicyResponse OpenSecurityPolicySync(OpenSecurityPolicyRequest req)
        {
            return InternalRequestAsync<OpenSecurityPolicyResponse>(req, "OpenSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the added origin server (server) IP or domain name.
        /// </summary>
        /// <param name="req"><see cref="RemoveRealServersRequest"/></param>
        /// <returns><see cref="RemoveRealServersResponse"/></returns>
        public Task<RemoveRealServersResponse> RemoveRealServers(RemoveRealServersRequest req)
        {
            return InternalRequestAsync<RemoveRealServersResponse>(req, "RemoveRealServers");
        }

        /// <summary>
        /// This API is used to delete the added origin server (server) IP or domain name.
        /// </summary>
        /// <param name="req"><see cref="RemoveRealServersRequest"/></param>
        /// <returns><see cref="RemoveRealServersResponse"/></returns>
        public RemoveRealServersResponse RemoveRealServersSync(RemoveRealServersRequest req)
        {
            return InternalRequestAsync<RemoveRealServersResponse>(req, "RemoveRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (SetAuthentication) is used for the advanced authentication configuration of connections, including authentication methods and their certificates. If only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="SetAuthenticationRequest"/></param>
        /// <returns><see cref="SetAuthenticationResponse"/></returns>
        public Task<SetAuthenticationResponse> SetAuthentication(SetAuthenticationRequest req)
        {
            return InternalRequestAsync<SetAuthenticationResponse>(req, "SetAuthentication");
        }

        /// <summary>
        /// This API (SetAuthentication) is used for the advanced authentication configuration of connections, including authentication methods and their certificates. If only supports connections of version 3.0.
        /// </summary>
        /// <param name="req"><see cref="SetAuthenticationRequest"/></param>
        /// <returns><see cref="SetAuthenticationResponse"/></returns>
        public SetAuthenticationResponse SetAuthenticationSync(SetAuthenticationRequest req)
        {
            return InternalRequestAsync<SetAuthenticationResponse>(req, "SetAuthentication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
