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

namespace TencentCloud.Apigateway.V20180808
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apigateway.V20180808.Models;

   public class ApigatewayClient : AbstractClient{

       private const string endpoint = "apigateway.tencentcloudapi.com";
       private const string version = "2018-08-08";
       private const string sdkVersion = "SDK_NET_3.0.958";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApigatewayClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApigatewayClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind a plugin to an API.
        /// </summary>
        /// <param name="req"><see cref="AttachPluginRequest"/></param>
        /// <returns><see cref="AttachPluginResponse"/></returns>
        public Task<AttachPluginResponse> AttachPlugin(AttachPluginRequest req)
        {
            return InternalRequestAsync<AttachPluginResponse>(req, "AttachPlugin");
        }

        /// <summary>
        /// This API is used to bind a plugin to an API.
        /// </summary>
        /// <param name="req"><see cref="AttachPluginRequest"/></param>
        /// <returns><see cref="AttachPluginResponse"/></returns>
        public AttachPluginResponse AttachPluginSync(AttachPluginRequest req)
        {
            return InternalRequestAsync<AttachPluginResponse>(req, "AttachPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an application to an API.
        /// </summary>
        /// <param name="req"><see cref="BindApiAppRequest"/></param>
        /// <returns><see cref="BindApiAppResponse"/></returns>
        public Task<BindApiAppResponse> BindApiApp(BindApiAppRequest req)
        {
            return InternalRequestAsync<BindApiAppResponse>(req, "BindApiApp");
        }

        /// <summary>
        /// This API is used to bind an application to an API.
        /// </summary>
        /// <param name="req"><see cref="BindApiAppRequest"/></param>
        /// <returns><see cref="BindApiAppResponse"/></returns>
        public BindApiAppResponse BindApiAppSync(BindApiAppRequest req)
        {
            return InternalRequestAsync<BindApiAppResponse>(req, "BindApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a usage plan to a service or API.
        /// After you publish a service to an environment, if the API requires authentication and can be called only when it is bound to a usage plan, you can use this API to bind a usage plan to the specified environment.
        /// Currently, a usage plan can be bound to an API; however, under the same service, usage plans bound to a service and usage plans bound to an API cannot coexist. Therefore, in an environment to which a service-level usage plan has already been bound, please use the `DemoteServiceUsagePlan` API to degrade it.
        /// </summary>
        /// <param name="req"><see cref="BindEnvironmentRequest"/></param>
        /// <returns><see cref="BindEnvironmentResponse"/></returns>
        public Task<BindEnvironmentResponse> BindEnvironment(BindEnvironmentRequest req)
        {
            return InternalRequestAsync<BindEnvironmentResponse>(req, "BindEnvironment");
        }

        /// <summary>
        /// This API is used to bind a usage plan to a service or API.
        /// After you publish a service to an environment, if the API requires authentication and can be called only when it is bound to a usage plan, you can use this API to bind a usage plan to the specified environment.
        /// Currently, a usage plan can be bound to an API; however, under the same service, usage plans bound to a service and usage plans bound to an API cannot coexist. Therefore, in an environment to which a service-level usage plan has already been bound, please use the `DemoteServiceUsagePlan` API to degrade it.
        /// </summary>
        /// <param name="req"><see cref="BindEnvironmentRequest"/></param>
        /// <returns><see cref="BindEnvironmentResponse"/></returns>
        public BindEnvironmentResponse BindEnvironmentSync(BindEnvironmentRequest req)
        {
            return InternalRequestAsync<BindEnvironmentResponse>(req, "BindEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an IP policy to an API.
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public Task<BindIPStrategyResponse> BindIPStrategy(BindIPStrategyRequest req)
        {
            return InternalRequestAsync<BindIPStrategyResponse>(req, "BindIPStrategy");
        }

        /// <summary>
        /// This API is used to bind an IP policy to an API.
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public BindIPStrategyResponse BindIPStrategySync(BindIPStrategyRequest req)
        {
            return InternalRequestAsync<BindIPStrategyResponse>(req, "BindIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a key to a usage plan.
        /// You can bind a key to a usage plan and bind the usage plan to an environment where a service is published, so that callers can use the key to call APIs in the service. You can use this API to bind a key to a usage plan.
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public Task<BindSecretIdsResponse> BindSecretIds(BindSecretIdsRequest req)
        {
            return InternalRequestAsync<BindSecretIdsResponse>(req, "BindSecretIds");
        }

        /// <summary>
        /// This API is used to bind a key to a usage plan.
        /// You can bind a key to a usage plan and bind the usage plan to an environment where a service is published, so that callers can use the key to call APIs in the service. You can use this API to bind a key to a usage plan.
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public BindSecretIdsResponse BindSecretIdsSync(BindSecretIdsRequest req)
        {
            return InternalRequestAsync<BindSecretIdsResponse>(req, "BindSecretIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a custom domain name to a service.
        /// Each service in API Gateway provides a default domain name for users to call. If you want to use your own domain name, you can bind a custom domain name to the target service. After getting the ICP filing and configuring the CNAME record between the custom and default domain names, you can directly call the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public Task<BindSubDomainResponse> BindSubDomain(BindSubDomainRequest req)
        {
            return InternalRequestAsync<BindSubDomainResponse>(req, "BindSubDomain");
        }

        /// <summary>
        /// This API is used to bind a custom domain name to a service.
        /// Each service in API Gateway provides a default domain name for users to call. If you want to use your own domain name, you can bind a custom domain name to the target service. After getting the ICP filing and configuring the CNAME record between the custom and default domain names, you can directly call the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public BindSubDomainResponse BindSubDomainSync(BindSubDomainRequest req)
        {
            return InternalRequestAsync<BindSubDomainResponse>(req, "BindSubDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to build an API document.
        /// </summary>
        /// <param name="req"><see cref="BuildAPIDocRequest"/></param>
        /// <returns><see cref="BuildAPIDocResponse"/></returns>
        public Task<BuildAPIDocResponse> BuildAPIDoc(BuildAPIDocRequest req)
        {
            return InternalRequestAsync<BuildAPIDocResponse>(req, "BuildAPIDoc");
        }

        /// <summary>
        /// This API is used to build an API document.
        /// </summary>
        /// <param name="req"><see cref="BuildAPIDocRequest"/></param>
        /// <returns><see cref="BuildAPIDocResponse"/></returns>
        public BuildAPIDocResponse BuildAPIDocSync(BuildAPIDocRequest req)
        {
            return InternalRequestAsync<BuildAPIDocResponse>(req, "BuildAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an API document.
        /// </summary>
        /// <param name="req"><see cref="CreateAPIDocRequest"/></param>
        /// <returns><see cref="CreateAPIDocResponse"/></returns>
        public Task<CreateAPIDocResponse> CreateAPIDoc(CreateAPIDocRequest req)
        {
            return InternalRequestAsync<CreateAPIDocResponse>(req, "CreateAPIDoc");
        }

        /// <summary>
        /// This API is used to create an API document.
        /// </summary>
        /// <param name="req"><see cref="CreateAPIDocRequest"/></param>
        /// <returns><see cref="CreateAPIDocResponse"/></returns>
        public CreateAPIDocResponse CreateAPIDocSync(CreateAPIDocRequest req)
        {
            return InternalRequestAsync<CreateAPIDocResponse>(req, "CreateAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an API. Before creating an API, you need to create a service, as each API belongs to a certain service.
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public Task<CreateApiResponse> CreateApi(CreateApiRequest req)
        {
            return InternalRequestAsync<CreateApiResponse>(req, "CreateApi");
        }

        /// <summary>
        /// This API is used to create an API. Before creating an API, you need to create a service, as each API belongs to a certain service.
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public CreateApiResponse CreateApiSync(CreateApiRequest req)
        {
            return InternalRequestAsync<CreateApiResponse>(req, "CreateApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApiAppRequest"/></param>
        /// <returns><see cref="CreateApiAppResponse"/></returns>
        public Task<CreateApiAppResponse> CreateApiApp(CreateApiAppRequest req)
        {
            return InternalRequestAsync<CreateApiAppResponse>(req, "CreateApiApp");
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApiAppRequest"/></param>
        /// <returns><see cref="CreateApiAppResponse"/></returns>
        public CreateApiAppResponse CreateApiAppSync(CreateApiAppRequest req)
        {
            return InternalRequestAsync<CreateApiAppResponse>(req, "CreateApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an API key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public Task<CreateApiKeyResponse> CreateApiKey(CreateApiKeyRequest req)
        {
            return InternalRequestAsync<CreateApiKeyResponse>(req, "CreateApiKey");
        }

        /// <summary>
        /// This API is used to create an API key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public CreateApiKeyResponse CreateApiKeySync(CreateApiKeyRequest req)
        {
            return InternalRequestAsync<CreateApiKeyResponse>(req, "CreateApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public Task<CreateIPStrategyResponse> CreateIPStrategy(CreateIPStrategyRequest req)
        {
            return InternalRequestAsync<CreateIPStrategyResponse>(req, "CreateIPStrategy");
        }

        /// <summary>
        /// This API is used to create a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public CreateIPStrategyResponse CreateIPStrategySync(CreateIPStrategyRequest req)
        {
            return InternalRequestAsync<CreateIPStrategyResponse>(req, "CreateIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public Task<CreatePluginResponse> CreatePlugin(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin");
        }

        /// <summary>
        /// This API is used to create an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public CreatePluginResponse CreatePluginSync(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a service.
        /// A service is the biggest usage unit in API Gateway. Each service can contain multiple APIs and one default domain name for invocation. You can also bind your own custom domain name to a service. 
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public Task<CreateServiceResponse> CreateService(CreateServiceRequest req)
        {
            return InternalRequestAsync<CreateServiceResponse>(req, "CreateService");
        }

        /// <summary>
        /// This API is used to create a service.
        /// A service is the biggest usage unit in API Gateway. Each service can contain multiple APIs and one default domain name for invocation. You can also bind your own custom domain name to a service. 
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public CreateServiceResponse CreateServiceSync(CreateServiceRequest req)
        {
            return InternalRequestAsync<CreateServiceResponse>(req, "CreateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an upstream.
        /// </summary>
        /// <param name="req"><see cref="CreateUpstreamRequest"/></param>
        /// <returns><see cref="CreateUpstreamResponse"/></returns>
        public Task<CreateUpstreamResponse> CreateUpstream(CreateUpstreamRequest req)
        {
            return InternalRequestAsync<CreateUpstreamResponse>(req, "CreateUpstream");
        }

        /// <summary>
        /// This API is used to create an upstream.
        /// </summary>
        /// <param name="req"><see cref="CreateUpstreamRequest"/></param>
        /// <returns><see cref="CreateUpstreamResponse"/></returns>
        public CreateUpstreamResponse CreateUpstreamSync(CreateUpstreamRequest req)
        {
            return InternalRequestAsync<CreateUpstreamResponse>(req, "CreateUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a usage plan.
        /// To use API Gateway, you need to create a usage plan and bind it to a service environment.
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public Task<CreateUsagePlanResponse> CreateUsagePlan(CreateUsagePlanRequest req)
        {
            return InternalRequestAsync<CreateUsagePlanResponse>(req, "CreateUsagePlan");
        }

        /// <summary>
        /// This API is used to create a usage plan.
        /// To use API Gateway, you need to create a usage plan and bind it to a service environment.
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public CreateUsagePlanResponse CreateUsagePlanSync(CreateUsagePlanRequest req)
        {
            return InternalRequestAsync<CreateUsagePlanResponse>(req, "CreateUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an API document.
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIDocRequest"/></param>
        /// <returns><see cref="DeleteAPIDocResponse"/></returns>
        public Task<DeleteAPIDocResponse> DeleteAPIDoc(DeleteAPIDocRequest req)
        {
            return InternalRequestAsync<DeleteAPIDocResponse>(req, "DeleteAPIDoc");
        }

        /// <summary>
        /// This API is used to delete an API document.
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIDocRequest"/></param>
        /// <returns><see cref="DeleteAPIDocResponse"/></returns>
        public DeleteAPIDocResponse DeleteAPIDocSync(DeleteAPIDocRequest req)
        {
            return InternalRequestAsync<DeleteAPIDocResponse>(req, "DeleteAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a created API.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public Task<DeleteApiResponse> DeleteApi(DeleteApiRequest req)
        {
            return InternalRequestAsync<DeleteApiResponse>(req, "DeleteApi");
        }

        /// <summary>
        /// This API is used to delete a created API.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public DeleteApiResponse DeleteApiSync(DeleteApiRequest req)
        {
            return InternalRequestAsync<DeleteApiResponse>(req, "DeleteApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a created application.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiAppRequest"/></param>
        /// <returns><see cref="DeleteApiAppResponse"/></returns>
        public Task<DeleteApiAppResponse> DeleteApiApp(DeleteApiAppRequest req)
        {
            return InternalRequestAsync<DeleteApiAppResponse>(req, "DeleteApiApp");
        }

        /// <summary>
        /// This API is used to delete a created application.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiAppRequest"/></param>
        /// <returns><see cref="DeleteApiAppResponse"/></returns>
        public DeleteApiAppResponse DeleteApiAppSync(DeleteApiAppRequest req)
        {
            return InternalRequestAsync<DeleteApiAppResponse>(req, "DeleteApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an API key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public Task<DeleteApiKeyResponse> DeleteApiKey(DeleteApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteApiKeyResponse>(req, "DeleteApiKey");
        }

        /// <summary>
        /// This API is used to delete an API key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public DeleteApiKeyResponse DeleteApiKeySync(DeleteApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteApiKeyResponse>(req, "DeleteApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public Task<DeleteIPStrategyResponse> DeleteIPStrategy(DeleteIPStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIPStrategyResponse>(req, "DeleteIPStrategy");
        }

        /// <summary>
        /// This API is used to delete a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public DeleteIPStrategyResponse DeleteIPStrategySync(DeleteIPStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIPStrategyResponse>(req, "DeleteIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public Task<DeletePluginResponse> DeletePlugin(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin");
        }

        /// <summary>
        /// This API is used to delete an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public DeletePluginResponse DeletePluginSync(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a service in API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public Task<DeleteServiceResponse> DeleteService(DeleteServiceRequest req)
        {
            return InternalRequestAsync<DeleteServiceResponse>(req, "DeleteService");
        }

        /// <summary>
        /// This API is used to delete a service in API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public DeleteServiceResponse DeleteServiceSync(DeleteServiceRequest req)
        {
            return InternalRequestAsync<DeleteServiceResponse>(req, "DeleteService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom domain name mapping in a service environment.
        /// You can use this API if you use a custom domain name and custom mapping. Please note that if you delete all mappings in all environments, a failure will be returned when this API is called.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public Task<DeleteServiceSubDomainMappingResponse> DeleteServiceSubDomainMapping(DeleteServiceSubDomainMappingRequest req)
        {
            return InternalRequestAsync<DeleteServiceSubDomainMappingResponse>(req, "DeleteServiceSubDomainMapping");
        }

        /// <summary>
        /// This API is used to delete a custom domain name mapping in a service environment.
        /// You can use this API if you use a custom domain name and custom mapping. Please note that if you delete all mappings in all environments, a failure will be returned when this API is called.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public DeleteServiceSubDomainMappingResponse DeleteServiceSubDomainMappingSync(DeleteServiceSubDomainMappingRequest req)
        {
            return InternalRequestAsync<DeleteServiceSubDomainMappingResponse>(req, "DeleteServiceSubDomainMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an upstream. Note that you can only delete an upstream when it’s not bound with any APIs.
        /// </summary>
        /// <param name="req"><see cref="DeleteUpstreamRequest"/></param>
        /// <returns><see cref="DeleteUpstreamResponse"/></returns>
        public Task<DeleteUpstreamResponse> DeleteUpstream(DeleteUpstreamRequest req)
        {
            return InternalRequestAsync<DeleteUpstreamResponse>(req, "DeleteUpstream");
        }

        /// <summary>
        /// This API is used to delete an upstream. Note that you can only delete an upstream when it’s not bound with any APIs.
        /// </summary>
        /// <param name="req"><see cref="DeleteUpstreamRequest"/></param>
        /// <returns><see cref="DeleteUpstreamResponse"/></returns>
        public DeleteUpstreamResponse DeleteUpstreamSync(DeleteUpstreamRequest req)
        {
            return InternalRequestAsync<DeleteUpstreamResponse>(req, "DeleteUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a usage plan.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public Task<DeleteUsagePlanResponse> DeleteUsagePlan(DeleteUsagePlanRequest req)
        {
            return InternalRequestAsync<DeleteUsagePlanResponse>(req, "DeleteUsagePlan");
        }

        /// <summary>
        /// This API is used to delete a usage plan.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public DeleteUsagePlanResponse DeleteUsagePlanSync(DeleteUsagePlanRequest req)
        {
            return InternalRequestAsync<DeleteUsagePlanResponse>(req, "DeleteUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to degrade a usage plan of a service in an environment to the API level.
        /// This operation will be denied if there are no APIs under the service.
        /// This operation will also be denied if the current environment has not been published.
        /// </summary>
        /// <param name="req"><see cref="DemoteServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DemoteServiceUsagePlanResponse"/></returns>
        public Task<DemoteServiceUsagePlanResponse> DemoteServiceUsagePlan(DemoteServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DemoteServiceUsagePlanResponse>(req, "DemoteServiceUsagePlan");
        }

        /// <summary>
        /// This API is used to degrade a usage plan of a service in an environment to the API level.
        /// This operation will be denied if there are no APIs under the service.
        /// This operation will also be denied if the current environment has not been published.
        /// </summary>
        /// <param name="req"><see cref="DemoteServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DemoteServiceUsagePlanResponse"/></returns>
        public DemoteServiceUsagePlanResponse DemoteServiceUsagePlanSync(DemoteServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DemoteServiceUsagePlanResponse>(req, "DemoteServiceUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an API document.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocDetailRequest"/></param>
        /// <returns><see cref="DescribeAPIDocDetailResponse"/></returns>
        public Task<DescribeAPIDocDetailResponse> DescribeAPIDocDetail(DescribeAPIDocDetailRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocDetailResponse>(req, "DescribeAPIDocDetail");
        }

        /// <summary>
        /// This API is used to query the details of an API document.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocDetailRequest"/></param>
        /// <returns><see cref="DescribeAPIDocDetailResponse"/></returns>
        public DescribeAPIDocDetailResponse DescribeAPIDocDetailSync(DescribeAPIDocDetailRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocDetailResponse>(req, "DescribeAPIDocDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of API documents.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocsRequest"/></param>
        /// <returns><see cref="DescribeAPIDocsResponse"/></returns>
        public Task<DescribeAPIDocsResponse> DescribeAPIDocs(DescribeAPIDocsRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocsResponse>(req, "DescribeAPIDocs");
        }

        /// <summary>
        /// This API is used to query the list of API documents.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocsRequest"/></param>
        /// <returns><see cref="DescribeAPIDocsResponse"/></returns>
        public DescribeAPIDocsResponse DescribeAPIDocsSync(DescribeAPIDocsRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocsResponse>(req, "DescribeAPIDocs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all APIs that can use this plugin, no matter whether the API is bound with the plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllPluginApisRequest"/></param>
        /// <returns><see cref="DescribeAllPluginApisResponse"/></returns>
        public Task<DescribeAllPluginApisResponse> DescribeAllPluginApis(DescribeAllPluginApisRequest req)
        {
            return InternalRequestAsync<DescribeAllPluginApisResponse>(req, "DescribeAllPluginApis");
        }

        /// <summary>
        /// This API is used to list all APIs that can use this plugin, no matter whether the API is bound with the plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllPluginApisRequest"/></param>
        /// <returns><see cref="DescribeAllPluginApisResponse"/></returns>
        public DescribeAllPluginApisResponse DescribeAllPluginApisSync(DescribeAllPluginApisRequest req)
        {
            return InternalRequestAsync<DescribeAllPluginApisResponse>(req, "DescribeAllPluginApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (`DescribeApi`) is used to query the details of the APIs users manage via Tencent Cloud API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public Task<DescribeApiResponse> DescribeApi(DescribeApiRequest req)
        {
            return InternalRequestAsync<DescribeApiResponse>(req, "DescribeApi");
        }

        /// <summary>
        /// This API (`DescribeApi`) is used to query the details of the APIs users manage via Tencent Cloud API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public DescribeApiResponse DescribeApiSync(DescribeApiRequest req)
        {
            return InternalRequestAsync<DescribeApiResponse>(req, "DescribeApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for an application by application ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiAppResponse"/></returns>
        public Task<DescribeApiAppResponse> DescribeApiApp(DescribeApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiAppResponse>(req, "DescribeApiApp");
        }

        /// <summary>
        /// This API is used to search for an application by application ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiAppResponse"/></returns>
        public DescribeApiAppResponse DescribeApiAppSync(DescribeApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiAppResponse>(req, "DescribeApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of APIs bound to an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppBindApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppBindApisStatusResponse"/></returns>
        public Task<DescribeApiAppBindApisStatusResponse> DescribeApiAppBindApisStatus(DescribeApiAppBindApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppBindApisStatusResponse>(req, "DescribeApiAppBindApisStatus");
        }

        /// <summary>
        /// This API is used to query the list of APIs bound to an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppBindApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppBindApisStatusResponse"/></returns>
        public DescribeApiAppBindApisStatusResponse DescribeApiAppBindApisStatusSync(DescribeApiAppBindApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppBindApisStatusResponse>(req, "DescribeApiAppBindApisStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppsStatusResponse"/></returns>
        public Task<DescribeApiAppsStatusResponse> DescribeApiAppsStatus(DescribeApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppsStatusResponse>(req, "DescribeApiAppsStatus");
        }

        /// <summary>
        /// This API is used to query the application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppsStatusResponse"/></returns>
        public DescribeApiAppsStatusResponse DescribeApiAppsStatusSync(DescribeApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppsStatusResponse>(req, "DescribeApiAppsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of applications bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiBindApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiBindApiAppsStatusResponse"/></returns>
        public Task<DescribeApiBindApiAppsStatusResponse> DescribeApiBindApiAppsStatus(DescribeApiBindApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiBindApiAppsStatusResponse>(req, "DescribeApiBindApiAppsStatus");
        }

        /// <summary>
        /// This API is used to query the list of applications bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiBindApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiBindApiAppsStatusResponse"/></returns>
        public DescribeApiBindApiAppsStatusResponse DescribeApiBindApiAppsStatusSync(DescribeApiBindApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiBindApiAppsStatusResponse>(req, "DescribeApiBindApiAppsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display the throttling policies bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public Task<DescribeApiEnvironmentStrategyResponse> DescribeApiEnvironmentStrategy(DescribeApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeApiEnvironmentStrategyResponse>(req, "DescribeApiEnvironmentStrategy");
        }

        /// <summary>
        /// This API is used to display the throttling policies bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public DescribeApiEnvironmentStrategyResponse DescribeApiEnvironmentStrategySync(DescribeApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeApiEnvironmentStrategyResponse>(req, "DescribeApiEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an API deployed at API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiForApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiForApiAppResponse"/></returns>
        public Task<DescribeApiForApiAppResponse> DescribeApiForApiApp(DescribeApiForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiForApiAppResponse>(req, "DescribeApiForApiApp");
        }

        /// <summary>
        /// This API is used to query the details of an API deployed at API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiForApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiForApiAppResponse"/></returns>
        public DescribeApiForApiAppResponse DescribeApiForApiAppSync(DescribeApiForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiForApiAppResponse>(req, "DescribeApiForApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a key.
        /// After creating an API key, you can query its details by using this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public Task<DescribeApiKeyResponse> DescribeApiKey(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey");
        }

        /// <summary>
        /// This API is used to query the details of a key.
        /// After creating an API key, you can query its details by using this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public DescribeApiKeyResponse DescribeApiKeySync(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of one or more API keys.
        ///  
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public Task<DescribeApiKeysStatusResponse> DescribeApiKeysStatus(DescribeApiKeysStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiKeysStatusResponse>(req, "DescribeApiKeysStatus");
        }

        /// <summary>
        /// This API is used to query the information of one or more API keys.
        ///  
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public DescribeApiKeysStatusResponse DescribeApiKeysStatusSync(DescribeApiKeysStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiKeysStatusResponse>(req, "DescribeApiKeysStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of API usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service and APIs under it.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public Task<DescribeApiUsagePlanResponse> DescribeApiUsagePlan(DescribeApiUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeApiUsagePlanResponse>(req, "DescribeApiUsagePlan");
        }

        /// <summary>
        /// This API is used to query the details of API usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service and APIs under it.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public DescribeApiUsagePlanResponse DescribeApiUsagePlanSync(DescribeApiUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeApiUsagePlanResponse>(req, "DescribeApiUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view a certain API or the list of all APIs under a service and relevant information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public Task<DescribeApisStatusResponse> DescribeApisStatus(DescribeApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApisStatusResponse>(req, "DescribeApisStatus");
        }

        /// <summary>
        /// This API is used to view a certain API or the list of all APIs under a service and relevant information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public DescribeApisStatusResponse DescribeApisStatusSync(DescribeApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApisStatusResponse>(req, "DescribeApisStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query IP policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public Task<DescribeIPStrategyResponse> DescribeIPStrategy(DescribeIPStrategyRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyResponse>(req, "DescribeIPStrategy");
        }

        /// <summary>
        /// This API is used to query IP policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public DescribeIPStrategyResponse DescribeIPStrategySync(DescribeIPStrategyRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyResponse>(req, "DescribeIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of APIs to which an IP policy can be bound, i.e., the difference set between all APIs under the service and the APIs already bound to the policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public Task<DescribeIPStrategyApisStatusResponse> DescribeIPStrategyApisStatus(DescribeIPStrategyApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyApisStatusResponse>(req, "DescribeIPStrategyApisStatus");
        }

        /// <summary>
        /// This API is used to query the list of APIs to which an IP policy can be bound, i.e., the difference set between all APIs under the service and the APIs already bound to the policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public DescribeIPStrategyApisStatusResponse DescribeIPStrategyApisStatusSync(DescribeIPStrategyApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyApisStatusResponse>(req, "DescribeIPStrategyApisStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of service IP policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public Task<DescribeIPStrategysStatusResponse> DescribeIPStrategysStatus(DescribeIPStrategysStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategysStatusResponse>(req, "DescribeIPStrategysStatus");
        }

        /// <summary>
        /// This API is used to query the list of service IP policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public DescribeIPStrategysStatusResponse DescribeIPStrategysStatusSync(DescribeIPStrategysStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategysStatusResponse>(req, "DescribeIPStrategysStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public Task<DescribeLogSearchResponse> DescribeLogSearch(DescribeLogSearchRequest req)
        {
            return InternalRequestAsync<DescribeLogSearchResponse>(req, "DescribeLogSearch");
        }

        /// <summary>
        /// This API is used to search for logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public DescribeLogSearchResponse DescribeLogSearchSync(DescribeLogSearchRequest req)
        {
            return InternalRequestAsync<DescribeLogSearchResponse>(req, "DescribeLogSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the plugin details by plugin ID.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public Task<DescribePluginResponse> DescribePlugin(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin");
        }

        /// <summary>
        /// This API is used to query the plugin details by plugin ID.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public DescribePluginResponse DescribePluginSync(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query APIs bound with a specified plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginApisRequest"/></param>
        /// <returns><see cref="DescribePluginApisResponse"/></returns>
        public Task<DescribePluginApisResponse> DescribePluginApis(DescribePluginApisRequest req)
        {
            return InternalRequestAsync<DescribePluginApisResponse>(req, "DescribePluginApis");
        }

        /// <summary>
        /// This API is used to query APIs bound with a specified plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginApisRequest"/></param>
        /// <returns><see cref="DescribePluginApisResponse"/></returns>
        public DescribePluginApisResponse DescribePluginApisSync(DescribePluginApisRequest req)
        {
            return InternalRequestAsync<DescribePluginApisResponse>(req, "DescribePluginApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all plug-ins bound with the API.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginsByApiRequest"/></param>
        /// <returns><see cref="DescribePluginsByApiResponse"/></returns>
        public Task<DescribePluginsByApiResponse> DescribePluginsByApi(DescribePluginsByApiRequest req)
        {
            return InternalRequestAsync<DescribePluginsByApiResponse>(req, "DescribePluginsByApi");
        }

        /// <summary>
        /// This API is used to query all plug-ins bound with the API.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginsByApiRequest"/></param>
        /// <returns><see cref="DescribePluginsByApiResponse"/></returns>
        public DescribePluginsByApiResponse DescribePluginsByApiSync(DescribePluginsByApiRequest req)
        {
            return InternalRequestAsync<DescribePluginsByApiResponse>(req, "DescribePluginsByApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, protocol, creation time, and releases.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public Task<DescribeServiceResponse> DescribeService(DescribeServiceRequest req)
        {
            return InternalRequestAsync<DescribeServiceResponse>(req, "DescribeService");
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, protocol, creation time, and releases.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public DescribeServiceResponse DescribeServiceSync(DescribeServiceRequest req)
        {
            return InternalRequestAsync<DescribeServiceResponse>(req, "DescribeService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of environments under a service. All environments and their statuses under the queried service will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public Task<DescribeServiceEnvironmentListResponse> DescribeServiceEnvironmentList(DescribeServiceEnvironmentListRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentListResponse>(req, "DescribeServiceEnvironmentList");
        }

        /// <summary>
        /// This API is used to query the list of environments under a service. All environments and their statuses under the queried service will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public DescribeServiceEnvironmentListResponse DescribeServiceEnvironmentListSync(DescribeServiceEnvironmentListRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentListResponse>(req, "DescribeServiceEnvironmentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the release history in a service environment.
        /// A service can only be used when it is published to an environment after creation. This API is used to query the release history in an environment under a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public Task<DescribeServiceEnvironmentReleaseHistoryResponse> DescribeServiceEnvironmentReleaseHistory(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentReleaseHistoryResponse>(req, "DescribeServiceEnvironmentReleaseHistory");
        }

        /// <summary>
        /// This API is used to query the release history in a service environment.
        /// A service can only be used when it is published to an environment after creation. This API is used to query the release history in an environment under a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public DescribeServiceEnvironmentReleaseHistoryResponse DescribeServiceEnvironmentReleaseHistorySync(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentReleaseHistoryResponse>(req, "DescribeServiceEnvironmentReleaseHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public Task<DescribeServiceEnvironmentStrategyResponse> DescribeServiceEnvironmentStrategy(DescribeServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentStrategyResponse>(req, "DescribeServiceEnvironmentStrategy");
        }

        /// <summary>
        /// This API is used to display a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public DescribeServiceEnvironmentStrategyResponse DescribeServiceEnvironmentStrategySync(DescribeServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentStrategyResponse>(req, "DescribeServiceEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, and protocol.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceForApiAppRequest"/></param>
        /// <returns><see cref="DescribeServiceForApiAppResponse"/></returns>
        public Task<DescribeServiceForApiAppResponse> DescribeServiceForApiApp(DescribeServiceForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeServiceForApiAppResponse>(req, "DescribeServiceForApiApp");
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, and protocol.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceForApiAppRequest"/></param>
        /// <returns><see cref="DescribeServiceForApiAppResponse"/></returns>
        public DescribeServiceForApiAppResponse DescribeServiceForApiAppSync(DescribeServiceForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeServiceForApiAppResponse>(req, "DescribeServiceForApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of all published versions under a service.
        /// A service is generally published on several versions. This API can be used to query the published versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public Task<DescribeServiceReleaseVersionResponse> DescribeServiceReleaseVersion(DescribeServiceReleaseVersionRequest req)
        {
            return InternalRequestAsync<DescribeServiceReleaseVersionResponse>(req, "DescribeServiceReleaseVersion");
        }

        /// <summary>
        /// This API is used to query the list of all published versions under a service.
        /// A service is generally published on several versions. This API can be used to query the published versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public DescribeServiceReleaseVersionResponse DescribeServiceReleaseVersionSync(DescribeServiceReleaseVersionRequest req)
        {
            return InternalRequestAsync<DescribeServiceReleaseVersionResponse>(req, "DescribeServiceReleaseVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the path mappings of a custom domain name.
        /// In API Gateway, you can bind a custom domain name to a service and map its paths. You can customize different path mappings to up to 3 environments under the service. This API is used to query the list of path mappings of a custom domain name bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public Task<DescribeServiceSubDomainMappingsResponse> DescribeServiceSubDomainMappings(DescribeServiceSubDomainMappingsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainMappingsResponse>(req, "DescribeServiceSubDomainMappings");
        }

        /// <summary>
        /// This API is used to query the path mappings of a custom domain name.
        /// In API Gateway, you can bind a custom domain name to a service and map its paths. You can customize different path mappings to up to 3 environments under the service. This API is used to query the list of path mappings of a custom domain name bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public DescribeServiceSubDomainMappingsResponse DescribeServiceSubDomainMappingsSync(DescribeServiceSubDomainMappingsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainMappingsResponse>(req, "DescribeServiceSubDomainMappings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of custom domain names.
        /// In API Gateway, you can bind custom domain names to a service for service call. This API is used to query the list of custom domain names bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public Task<DescribeServiceSubDomainsResponse> DescribeServiceSubDomains(DescribeServiceSubDomainsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainsResponse>(req, "DescribeServiceSubDomains");
        }

        /// <summary>
        /// This API is used to query the list of custom domain names.
        /// In API Gateway, you can bind custom domain names to a service for service call. This API is used to query the list of custom domain names bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public DescribeServiceSubDomainsResponse DescribeServiceSubDomainsSync(DescribeServiceSubDomainsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainsResponse>(req, "DescribeServiceSubDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public Task<DescribeServiceUsagePlanResponse> DescribeServiceUsagePlan(DescribeServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeServiceUsagePlanResponse>(req, "DescribeServiceUsagePlan");
        }

        /// <summary>
        /// This API is used to query the details of usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public DescribeServiceUsagePlanResponse DescribeServiceUsagePlanSync(DescribeServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeServiceUsagePlanResponse>(req, "DescribeServiceUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of one or more services and return relevant domain name, time, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public Task<DescribeServicesStatusResponse> DescribeServicesStatus(DescribeServicesStatusRequest req)
        {
            return InternalRequestAsync<DescribeServicesStatusResponse>(req, "DescribeServicesStatus");
        }

        /// <summary>
        /// This API is used to query the list of one or more services and return relevant domain name, time, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public DescribeServicesStatusResponse DescribeServicesStatusSync(DescribeServicesStatusRequest req)
        {
            return InternalRequestAsync<DescribeServicesStatusResponse>(req, "DescribeServicesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query APIs bound with an upstream.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamBindApisRequest"/></param>
        /// <returns><see cref="DescribeUpstreamBindApisResponse"/></returns>
        public Task<DescribeUpstreamBindApisResponse> DescribeUpstreamBindApis(DescribeUpstreamBindApisRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamBindApisResponse>(req, "DescribeUpstreamBindApis");
        }

        /// <summary>
        /// This API is used to query APIs bound with an upstream.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamBindApisRequest"/></param>
        /// <returns><see cref="DescribeUpstreamBindApisResponse"/></returns>
        public DescribeUpstreamBindApisResponse DescribeUpstreamBindApisSync(DescribeUpstreamBindApisRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamBindApisResponse>(req, "DescribeUpstreamBindApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of upstreams under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamsRequest"/></param>
        /// <returns><see cref="DescribeUpstreamsResponse"/></returns>
        public Task<DescribeUpstreamsResponse> DescribeUpstreams(DescribeUpstreamsRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamsResponse>(req, "DescribeUpstreams");
        }

        /// <summary>
        /// This API is used to query details of upstreams under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamsRequest"/></param>
        /// <returns><see cref="DescribeUpstreamsResponse"/></returns>
        public DescribeUpstreamsResponse DescribeUpstreamsSync(DescribeUpstreamsRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamsResponse>(req, "DescribeUpstreams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a usage plan, such as its name, QPS, creation time, and bound environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public Task<DescribeUsagePlanResponse> DescribeUsagePlan(DescribeUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanResponse>(req, "DescribeUsagePlan");
        }

        /// <summary>
        /// This API is used to query the details of a usage plan, such as its name, QPS, creation time, and bound environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public DescribeUsagePlanResponse DescribeUsagePlanSync(DescribeUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanResponse>(req, "DescribeUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of environments bound to a usage plan.
        /// After binding a usage plan to environments, you can use this API to query all service environments bound to the usage plan.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public Task<DescribeUsagePlanEnvironmentsResponse> DescribeUsagePlanEnvironments(DescribeUsagePlanEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanEnvironmentsResponse>(req, "DescribeUsagePlanEnvironments");
        }

        /// <summary>
        /// This API is used to query the list of environments bound to a usage plan.
        /// After binding a usage plan to environments, you can use this API to query all service environments bound to the usage plan.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public DescribeUsagePlanEnvironmentsResponse DescribeUsagePlanEnvironmentsSync(DescribeUsagePlanEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanEnvironmentsResponse>(req, "DescribeUsagePlanEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of keys bound to a usage plan.
        /// In API Gateway, a usage plan can be bound to multiple key pairs. You can use this API to query the list of keys bound to it.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public Task<DescribeUsagePlanSecretIdsResponse> DescribeUsagePlanSecretIds(DescribeUsagePlanSecretIdsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanSecretIdsResponse>(req, "DescribeUsagePlanSecretIds");
        }

        /// <summary>
        /// This API is used to query the list of keys bound to a usage plan.
        /// In API Gateway, a usage plan can be bound to multiple key pairs. You can use this API to query the list of keys bound to it.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public DescribeUsagePlanSecretIdsResponse DescribeUsagePlanSecretIdsSync(DescribeUsagePlanSecretIdsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanSecretIdsResponse>(req, "DescribeUsagePlanSecretIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of usage plans.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public Task<DescribeUsagePlansStatusResponse> DescribeUsagePlansStatus(DescribeUsagePlansStatusRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlansStatusResponse>(req, "DescribeUsagePlansStatus");
        }

        /// <summary>
        /// This API is used to query the list of usage plans.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public DescribeUsagePlansStatusResponse DescribeUsagePlansStatusSync(DescribeUsagePlansStatusRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlansStatusResponse>(req, "DescribeUsagePlansStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an API from the plugin.
        /// </summary>
        /// <param name="req"><see cref="DetachPluginRequest"/></param>
        /// <returns><see cref="DetachPluginResponse"/></returns>
        public Task<DetachPluginResponse> DetachPlugin(DetachPluginRequest req)
        {
            return InternalRequestAsync<DetachPluginResponse>(req, "DetachPlugin");
        }

        /// <summary>
        /// This API is used to unbind an API from the plugin.
        /// </summary>
        /// <param name="req"><see cref="DetachPluginRequest"/></param>
        /// <returns><see cref="DetachPluginResponse"/></returns>
        public DetachPluginResponse DetachPluginSync(DetachPluginRequest req)
        {
            return InternalRequestAsync<DetachPluginResponse>(req, "DetachPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable an API key.
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public Task<DisableApiKeyResponse> DisableApiKey(DisableApiKeyRequest req)
        {
            return InternalRequestAsync<DisableApiKeyResponse>(req, "DisableApiKey");
        }

        /// <summary>
        /// This API is used to disable an API key.
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public DisableApiKeyResponse DisableApiKeySync(DisableApiKeyRequest req)
        {
            return InternalRequestAsync<DisableApiKeyResponse>(req, "DisableApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a disabled API key.
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public Task<EnableApiKeyResponse> EnableApiKey(EnableApiKeyRequest req)
        {
            return InternalRequestAsync<EnableApiKeyResponse>(req, "EnableApiKey");
        }

        /// <summary>
        /// This API is used to enable a disabled API key.
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public EnableApiKeyResponse EnableApiKeySync(EnableApiKeyRequest req)
        {
            return InternalRequestAsync<EnableApiKeyResponse>(req, "EnableApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import an OpenAPI to API gateway. 
        /// </summary>
        /// <param name="req"><see cref="ImportOpenApiRequest"/></param>
        /// <returns><see cref="ImportOpenApiResponse"/></returns>
        public Task<ImportOpenApiResponse> ImportOpenApi(ImportOpenApiRequest req)
        {
            return InternalRequestAsync<ImportOpenApiResponse>(req, "ImportOpenApi");
        }

        /// <summary>
        /// This API is used to import an OpenAPI to API gateway. 
        /// </summary>
        /// <param name="req"><see cref="ImportOpenApiRequest"/></param>
        /// <returns><see cref="ImportOpenApiResponse"/></returns>
        public ImportOpenApiResponse ImportOpenApiSync(ImportOpenApiRequest req)
        {
            return InternalRequestAsync<ImportOpenApiResponse>(req, "ImportOpenApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an API document.
        /// </summary>
        /// <param name="req"><see cref="ModifyAPIDocRequest"/></param>
        /// <returns><see cref="ModifyAPIDocResponse"/></returns>
        public Task<ModifyAPIDocResponse> ModifyAPIDoc(ModifyAPIDocRequest req)
        {
            return InternalRequestAsync<ModifyAPIDocResponse>(req, "ModifyAPIDoc");
        }

        /// <summary>
        /// This API is used to modify an API document.
        /// </summary>
        /// <param name="req"><see cref="ModifyAPIDocRequest"/></param>
        /// <returns><see cref="ModifyAPIDocResponse"/></returns>
        public ModifyAPIDocResponse ModifyAPIDocSync(ModifyAPIDocRequest req)
        {
            return InternalRequestAsync<ModifyAPIDocResponse>(req, "ModifyAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an API. You can call this API to edit/modify a configured API. The modified API takes effect only after its service is published to the corresponding environment again.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public Task<ModifyApiResponse> ModifyApi(ModifyApiRequest req)
        {
            return InternalRequestAsync<ModifyApiResponse>(req, "ModifyApi");
        }

        /// <summary>
        /// This API is used to modify an API. You can call this API to edit/modify a configured API. The modified API takes effect only after its service is published to the corresponding environment again.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public ModifyApiResponse ModifyApiSync(ModifyApiRequest req)
        {
            return InternalRequestAsync<ModifyApiResponse>(req, "ModifyApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a created API.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAppRequest"/></param>
        /// <returns><see cref="ModifyApiAppResponse"/></returns>
        public Task<ModifyApiAppResponse> ModifyApiApp(ModifyApiAppRequest req)
        {
            return InternalRequestAsync<ModifyApiAppResponse>(req, "ModifyApiApp");
        }

        /// <summary>
        /// This API is used to modify a created API.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAppRequest"/></param>
        /// <returns><see cref="ModifyApiAppResponse"/></returns>
        public ModifyApiAppResponse ModifyApiAppSync(ModifyApiAppRequest req)
        {
            return InternalRequestAsync<ModifyApiAppResponse>(req, "ModifyApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an API throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public Task<ModifyApiEnvironmentStrategyResponse> ModifyApiEnvironmentStrategy(ModifyApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyApiEnvironmentStrategyResponse>(req, "ModifyApiEnvironmentStrategy");
        }

        /// <summary>
        /// This API is used to modify an API throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public ModifyApiEnvironmentStrategyResponse ModifyApiEnvironmentStrategySync(ModifyApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyApiEnvironmentStrategyResponse>(req, "ModifyApiEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to incrementally update an API and mainly called by programs (different from `ModifyApi`, which requires that full API parameters be passed in and is suitable for use in the console).
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public Task<ModifyApiIncrementResponse> ModifyApiIncrement(ModifyApiIncrementRequest req)
        {
            return InternalRequestAsync<ModifyApiIncrementResponse>(req, "ModifyApiIncrement");
        }

        /// <summary>
        /// This API is used to incrementally update an API and mainly called by programs (different from `ModifyApi`, which requires that full API parameters be passed in and is suitable for use in the console).
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public ModifyApiIncrementResponse ModifyApiIncrementSync(ModifyApiIncrementRequest req)
        {
            return InternalRequestAsync<ModifyApiIncrementResponse>(req, "ModifyApiIncrement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public Task<ModifyIPStrategyResponse> ModifyIPStrategy(ModifyIPStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIPStrategyResponse>(req, "ModifyIPStrategy");
        }

        /// <summary>
        /// This API is used to modify a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public ModifyIPStrategyResponse ModifyIPStrategySync(ModifyIPStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIPStrategyResponse>(req, "ModifyIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a plugin.
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public Task<ModifyPluginResponse> ModifyPlugin(ModifyPluginRequest req)
        {
            return InternalRequestAsync<ModifyPluginResponse>(req, "ModifyPlugin");
        }

        /// <summary>
        /// This API is used to modify a plugin.
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public ModifyPluginResponse ModifyPluginSync(ModifyPluginRequest req)
        {
            return InternalRequestAsync<ModifyPluginResponse>(req, "ModifyPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the relevant information of a service. After a service is created, its name, description, and service type can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public Task<ModifyServiceResponse> ModifyService(ModifyServiceRequest req)
        {
            return InternalRequestAsync<ModifyServiceResponse>(req, "ModifyService");
        }

        /// <summary>
        /// This API is used to modify the relevant information of a service. After a service is created, its name, description, and service type can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public ModifyServiceResponse ModifyServiceSync(ModifyServiceRequest req)
        {
            return InternalRequestAsync<ModifyServiceResponse>(req, "ModifyService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public Task<ModifyServiceEnvironmentStrategyResponse> ModifyServiceEnvironmentStrategy(ModifyServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyServiceEnvironmentStrategyResponse>(req, "ModifyServiceEnvironmentStrategy");
        }

        /// <summary>
        /// This API is used to modify a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public ModifyServiceEnvironmentStrategyResponse ModifyServiceEnvironmentStrategySync(ModifyServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyServiceEnvironmentStrategyResponse>(req, "ModifyServiceEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the path mapping in the custom domain name settings of a service. The path mapping rule can be modified before it is bound to the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public Task<ModifySubDomainResponse> ModifySubDomain(ModifySubDomainRequest req)
        {
            return InternalRequestAsync<ModifySubDomainResponse>(req, "ModifySubDomain");
        }

        /// <summary>
        /// This API is used to modify the path mapping in the custom domain name settings of a service. The path mapping rule can be modified before it is bound to the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public ModifySubDomainResponse ModifySubDomainSync(ModifySubDomainRequest req)
        {
            return InternalRequestAsync<ModifySubDomainResponse>(req, "ModifySubDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an upstream.
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamRequest"/></param>
        /// <returns><see cref="ModifyUpstreamResponse"/></returns>
        public Task<ModifyUpstreamResponse> ModifyUpstream(ModifyUpstreamRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamResponse>(req, "ModifyUpstream");
        }

        /// <summary>
        /// This API is used to modify an upstream.
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamRequest"/></param>
        /// <returns><see cref="ModifyUpstreamResponse"/></returns>
        public ModifyUpstreamResponse ModifyUpstreamSync(ModifyUpstreamRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamResponse>(req, "ModifyUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the name, description, and QPS of a usage plan.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public Task<ModifyUsagePlanResponse> ModifyUsagePlan(ModifyUsagePlanRequest req)
        {
            return InternalRequestAsync<ModifyUsagePlanResponse>(req, "ModifyUsagePlan");
        }

        /// <summary>
        /// This API is used to modify the name, description, and QPS of a usage plan.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public ModifyUsagePlanResponse ModifyUsagePlanSync(ModifyUsagePlanRequest req)
        {
            return InternalRequestAsync<ModifyUsagePlanResponse>(req, "ModifyUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to publish a service.
        /// An API Gateway service can only be called when it is published to an environment and takes effect after creation. This API is used to publish a service to an environment such as the `release` environment.
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public Task<ReleaseServiceResponse> ReleaseService(ReleaseServiceRequest req)
        {
            return InternalRequestAsync<ReleaseServiceResponse>(req, "ReleaseService");
        }

        /// <summary>
        /// This API is used to publish a service.
        /// An API Gateway service can only be called when it is published to an environment and takes effect after creation. This API is used to publish a service to an environment such as the `release` environment.
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public ReleaseServiceResponse ReleaseServiceSync(ReleaseServiceRequest req)
        {
            return InternalRequestAsync<ReleaseServiceResponse>(req, "ReleaseService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the password of an API document.
        /// </summary>
        /// <param name="req"><see cref="ResetAPIDocPasswordRequest"/></param>
        /// <returns><see cref="ResetAPIDocPasswordResponse"/></returns>
        public Task<ResetAPIDocPasswordResponse> ResetAPIDocPassword(ResetAPIDocPasswordRequest req)
        {
            return InternalRequestAsync<ResetAPIDocPasswordResponse>(req, "ResetAPIDocPassword");
        }

        /// <summary>
        /// This API is used to reset the password of an API document.
        /// </summary>
        /// <param name="req"><see cref="ResetAPIDocPasswordRequest"/></param>
        /// <returns><see cref="ResetAPIDocPasswordResponse"/></returns>
        public ResetAPIDocPasswordResponse ResetAPIDocPasswordSync(ResetAPIDocPasswordRequest req)
        {
            return InternalRequestAsync<ResetAPIDocPasswordResponse>(req, "ResetAPIDocPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a usage plan from a specified environment.
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public Task<UnBindEnvironmentResponse> UnBindEnvironment(UnBindEnvironmentRequest req)
        {
            return InternalRequestAsync<UnBindEnvironmentResponse>(req, "UnBindEnvironment");
        }

        /// <summary>
        /// This API is used to unbind a usage plan from a specified environment.
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public UnBindEnvironmentResponse UnBindEnvironmentSync(UnBindEnvironmentRequest req)
        {
            return InternalRequestAsync<UnBindEnvironmentResponse>(req, "UnBindEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an IP policy from a service.
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public Task<UnBindIPStrategyResponse> UnBindIPStrategy(UnBindIPStrategyRequest req)
        {
            return InternalRequestAsync<UnBindIPStrategyResponse>(req, "UnBindIPStrategy");
        }

        /// <summary>
        /// This API is used to unbind an IP policy from a service.
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public UnBindIPStrategyResponse UnBindIPStrategySync(UnBindIPStrategyRequest req)
        {
            return InternalRequestAsync<UnBindIPStrategyResponse>(req, "UnBindIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a key from a usage plan.
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public Task<UnBindSecretIdsResponse> UnBindSecretIds(UnBindSecretIdsRequest req)
        {
            return InternalRequestAsync<UnBindSecretIdsResponse>(req, "UnBindSecretIds");
        }

        /// <summary>
        /// This API is used to unbind a key from a usage plan.
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public UnBindSecretIdsResponse UnBindSecretIdsSync(UnBindSecretIdsRequest req)
        {
            return InternalRequestAsync<UnBindSecretIdsResponse>(req, "UnBindSecretIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a custom domain name.
        /// After binding a custom domain name to a service by using API Gateway, you can use this API to unbind it.
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public Task<UnBindSubDomainResponse> UnBindSubDomain(UnBindSubDomainRequest req)
        {
            return InternalRequestAsync<UnBindSubDomainResponse>(req, "UnBindSubDomain");
        }

        /// <summary>
        /// This API is used to unbind a custom domain name.
        /// After binding a custom domain name to a service by using API Gateway, you can use this API to unbind it.
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public UnBindSubDomainResponse UnBindSubDomainSync(UnBindSubDomainRequest req)
        {
            return InternalRequestAsync<UnBindSubDomainResponse>(req, "UnBindSubDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deactivate a service.
        /// Only after a service is published to an environment can its APIs be called. You can call this API to deactivate a service in the release environment. Once deactivated, the service cannot be called.
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public Task<UnReleaseServiceResponse> UnReleaseService(UnReleaseServiceRequest req)
        {
            return InternalRequestAsync<UnReleaseServiceResponse>(req, "UnReleaseService");
        }

        /// <summary>
        /// This API is used to deactivate a service.
        /// Only after a service is published to an environment can its APIs be called. You can call this API to deactivate a service in the release environment. Once deactivated, the service cannot be called.
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public UnReleaseServiceResponse UnReleaseServiceSync(UnReleaseServiceRequest req)
        {
            return InternalRequestAsync<UnReleaseServiceResponse>(req, "UnReleaseService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an application from an API.
        /// </summary>
        /// <param name="req"><see cref="UnbindApiAppRequest"/></param>
        /// <returns><see cref="UnbindApiAppResponse"/></returns>
        public Task<UnbindApiAppResponse> UnbindApiApp(UnbindApiAppRequest req)
        {
            return InternalRequestAsync<UnbindApiAppResponse>(req, "UnbindApiApp");
        }

        /// <summary>
        /// This API is used to unbind an application from an API.
        /// </summary>
        /// <param name="req"><see cref="UnbindApiAppRequest"/></param>
        /// <returns><see cref="UnbindApiAppResponse"/></returns>
        public UnbindApiAppResponse UnbindApiAppSync(UnbindApiAppRequest req)
        {
            return InternalRequestAsync<UnbindApiAppResponse>(req, "UnbindApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an application key.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiAppKeyRequest"/></param>
        /// <returns><see cref="UpdateApiAppKeyResponse"/></returns>
        public Task<UpdateApiAppKeyResponse> UpdateApiAppKey(UpdateApiAppKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiAppKeyResponse>(req, "UpdateApiAppKey");
        }

        /// <summary>
        /// This API is used to update an application key.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiAppKeyRequest"/></param>
        /// <returns><see cref="UpdateApiAppKeyResponse"/></returns>
        public UpdateApiAppKeyResponse UpdateApiAppKeySync(UpdateApiAppKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiAppKeyResponse>(req, "UpdateApiAppKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a created API key pair.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public Task<UpdateApiKeyResponse> UpdateApiKey(UpdateApiKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiKeyResponse>(req, "UpdateApiKey");
        }

        /// <summary>
        /// This API is used to update a created API key pair.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public UpdateApiKeyResponse UpdateApiKeySync(UpdateApiKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiKeyResponse>(req, "UpdateApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch the running version of a service published in an environment to a specified version. After you create a service by using API Gateway and publish it to an environment, multiple versions will be generated during development. In this case, you can call this API to switch versions.
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public Task<UpdateServiceResponse> UpdateService(UpdateServiceRequest req)
        {
            return InternalRequestAsync<UpdateServiceResponse>(req, "UpdateService");
        }

        /// <summary>
        /// This API is used to switch the running version of a service published in an environment to a specified version. After you create a service by using API Gateway and publish it to an environment, multiple versions will be generated during development. In this case, you can call this API to switch versions.
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public UpdateServiceResponse UpdateServiceSync(UpdateServiceRequest req)
        {
            return InternalRequestAsync<UpdateServiceResponse>(req, "UpdateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
