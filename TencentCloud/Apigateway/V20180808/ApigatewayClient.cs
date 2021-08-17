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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApigatewayClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to bind a plugin to an API.
        /// </summary>
        /// <param name="req"><see cref="AttachPluginRequest"/></param>
        /// <returns><see cref="AttachPluginResponse"/></returns>
        public async Task<AttachPluginResponse> AttachPlugin(AttachPluginRequest req)
        {
             JsonResponseModel<AttachPluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a plugin to an API.
        /// </summary>
        /// <param name="req"><see cref="AttachPluginRequest"/></param>
        /// <returns><see cref="AttachPluginResponse"/></returns>
        public AttachPluginResponse AttachPluginSync(AttachPluginRequest req)
        {
             JsonResponseModel<AttachPluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an application to an API.
        /// </summary>
        /// <param name="req"><see cref="BindApiAppRequest"/></param>
        /// <returns><see cref="BindApiAppResponse"/></returns>
        public async Task<BindApiAppResponse> BindApiApp(BindApiAppRequest req)
        {
             JsonResponseModel<BindApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an application to an API.
        /// </summary>
        /// <param name="req"><see cref="BindApiAppRequest"/></param>
        /// <returns><see cref="BindApiAppResponse"/></returns>
        public BindApiAppResponse BindApiAppSync(BindApiAppRequest req)
        {
             JsonResponseModel<BindApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a usage plan to a service or API.
        /// After you publish a service to an environment, if the API requires authentication and can be called only when it is bound to a usage plan, you can use this API to bind a usage plan to the specified environment.
        /// Currently, a usage plan can be bound to an API; however, under the same service, usage plans bound to a service and usage plans bound to an API cannot coexist. Therefore, in an environment to which a service-level usage plan has already been bound, please use the `DemoteServiceUsagePlan` API to degrade it.
        /// </summary>
        /// <param name="req"><see cref="BindEnvironmentRequest"/></param>
        /// <returns><see cref="BindEnvironmentResponse"/></returns>
        public async Task<BindEnvironmentResponse> BindEnvironment(BindEnvironmentRequest req)
        {
             JsonResponseModel<BindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<BindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an IP policy to an API.
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public async Task<BindIPStrategyResponse> BindIPStrategy(BindIPStrategyRequest req)
        {
             JsonResponseModel<BindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an IP policy to an API.
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public BindIPStrategyResponse BindIPStrategySync(BindIPStrategyRequest req)
        {
             JsonResponseModel<BindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a key to a usage plan.
        /// You can bind a key to a usage plan and bind the usage plan to an environment where a service is published, so that callers can use the key to call APIs in the service. You can use this API to bind a key to a usage plan.
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public async Task<BindSecretIdsResponse> BindSecretIds(BindSecretIdsRequest req)
        {
             JsonResponseModel<BindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a key to a usage plan.
        /// You can bind a key to a usage plan and bind the usage plan to an environment where a service is published, so that callers can use the key to call APIs in the service. You can use this API to bind a key to a usage plan.
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public BindSecretIdsResponse BindSecretIdsSync(BindSecretIdsRequest req)
        {
             JsonResponseModel<BindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a custom domain name to a service.
        /// Each service in API Gateway provides a default domain name for users to call. If you want to use your own domain name, you can bind a custom domain name to the target service. After getting the ICP filing and configuring the CNAME record between the custom and default domain names, you can directly call the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public async Task<BindSubDomainResponse> BindSubDomain(BindSubDomainRequest req)
        {
             JsonResponseModel<BindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a custom domain name to a service.
        /// Each service in API Gateway provides a default domain name for users to call. If you want to use your own domain name, you can bind a custom domain name to the target service. After getting the ICP filing and configuring the CNAME record between the custom and default domain names, you can directly call the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public BindSubDomainResponse BindSubDomainSync(BindSubDomainRequest req)
        {
             JsonResponseModel<BindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to build an API document.
        /// </summary>
        /// <param name="req"><see cref="BuildAPIDocRequest"/></param>
        /// <returns><see cref="BuildAPIDocResponse"/></returns>
        public async Task<BuildAPIDocResponse> BuildAPIDoc(BuildAPIDocRequest req)
        {
             JsonResponseModel<BuildAPIDocResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BuildAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BuildAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to build an API document.
        /// </summary>
        /// <param name="req"><see cref="BuildAPIDocRequest"/></param>
        /// <returns><see cref="BuildAPIDocResponse"/></returns>
        public BuildAPIDocResponse BuildAPIDocSync(BuildAPIDocRequest req)
        {
             JsonResponseModel<BuildAPIDocResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BuildAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BuildAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API document.
        /// </summary>
        /// <param name="req"><see cref="CreateAPIDocRequest"/></param>
        /// <returns><see cref="CreateAPIDocResponse"/></returns>
        public async Task<CreateAPIDocResponse> CreateAPIDoc(CreateAPIDocRequest req)
        {
             JsonResponseModel<CreateAPIDocResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API document.
        /// </summary>
        /// <param name="req"><see cref="CreateAPIDocRequest"/></param>
        /// <returns><see cref="CreateAPIDocResponse"/></returns>
        public CreateAPIDocResponse CreateAPIDocSync(CreateAPIDocRequest req)
        {
             JsonResponseModel<CreateAPIDocResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API. Before creating an API, you need to create a service, as each API belongs to a certain service.
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public async Task<CreateApiResponse> CreateApi(CreateApiRequest req)
        {
             JsonResponseModel<CreateApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API. Before creating an API, you need to create a service, as each API belongs to a certain service.
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public CreateApiResponse CreateApiSync(CreateApiRequest req)
        {
             JsonResponseModel<CreateApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApiAppRequest"/></param>
        /// <returns><see cref="CreateApiAppResponse"/></returns>
        public async Task<CreateApiAppResponse> CreateApiApp(CreateApiAppRequest req)
        {
             JsonResponseModel<CreateApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApiAppRequest"/></param>
        /// <returns><see cref="CreateApiAppResponse"/></returns>
        public CreateApiAppResponse CreateApiAppSync(CreateApiAppRequest req)
        {
             JsonResponseModel<CreateApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public async Task<CreateApiKeyResponse> CreateApiKey(CreateApiKeyRequest req)
        {
             JsonResponseModel<CreateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public CreateApiKeyResponse CreateApiKeySync(CreateApiKeyRequest req)
        {
             JsonResponseModel<CreateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public async Task<CreateIPStrategyResponse> CreateIPStrategy(CreateIPStrategyRequest req)
        {
             JsonResponseModel<CreateIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public CreateIPStrategyResponse CreateIPStrategySync(CreateIPStrategyRequest req)
        {
             JsonResponseModel<CreateIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public async Task<CreatePluginResponse> CreatePlugin(CreatePluginRequest req)
        {
             JsonResponseModel<CreatePluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public CreatePluginResponse CreatePluginSync(CreatePluginRequest req)
        {
             JsonResponseModel<CreatePluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a service.
        /// The maximum unit in API Gateway is service. Multiple APIs can be created in one service, and each service has a default domain name for users to call. You can also bind your own custom domain name to a service.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public async Task<CreateServiceResponse> CreateService(CreateServiceRequest req)
        {
             JsonResponseModel<CreateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a service.
        /// The maximum unit in API Gateway is service. Multiple APIs can be created in one service, and each service has a default domain name for users to call. You can also bind your own custom domain name to a service.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public CreateServiceResponse CreateServiceSync(CreateServiceRequest req)
        {
             JsonResponseModel<CreateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a usage plan.
        /// To use API Gateway, you need to create a usage plan and bind it to a service environment.
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public async Task<CreateUsagePlanResponse> CreateUsagePlan(CreateUsagePlanRequest req)
        {
             JsonResponseModel<CreateUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a usage plan.
        /// To use API Gateway, you need to create a usage plan and bind it to a service environment.
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public CreateUsagePlanResponse CreateUsagePlanSync(CreateUsagePlanRequest req)
        {
             JsonResponseModel<CreateUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an API document.
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIDocRequest"/></param>
        /// <returns><see cref="DeleteAPIDocResponse"/></returns>
        public async Task<DeleteAPIDocResponse> DeleteAPIDoc(DeleteAPIDocRequest req)
        {
             JsonResponseModel<DeleteAPIDocResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an API document.
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIDocRequest"/></param>
        /// <returns><see cref="DeleteAPIDocResponse"/></returns>
        public DeleteAPIDocResponse DeleteAPIDocSync(DeleteAPIDocRequest req)
        {
             JsonResponseModel<DeleteAPIDocResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a created API.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public async Task<DeleteApiResponse> DeleteApi(DeleteApiRequest req)
        {
             JsonResponseModel<DeleteApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a created API.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public DeleteApiResponse DeleteApiSync(DeleteApiRequest req)
        {
             JsonResponseModel<DeleteApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a created application.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiAppRequest"/></param>
        /// <returns><see cref="DeleteApiAppResponse"/></returns>
        public async Task<DeleteApiAppResponse> DeleteApiApp(DeleteApiAppRequest req)
        {
             JsonResponseModel<DeleteApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a created application.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiAppRequest"/></param>
        /// <returns><see cref="DeleteApiAppResponse"/></returns>
        public DeleteApiAppResponse DeleteApiAppSync(DeleteApiAppRequest req)
        {
             JsonResponseModel<DeleteApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an API key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public async Task<DeleteApiKeyResponse> DeleteApiKey(DeleteApiKeyRequest req)
        {
             JsonResponseModel<DeleteApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an API key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public DeleteApiKeyResponse DeleteApiKeySync(DeleteApiKeyRequest req)
        {
             JsonResponseModel<DeleteApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public async Task<DeleteIPStrategyResponse> DeleteIPStrategy(DeleteIPStrategyRequest req)
        {
             JsonResponseModel<DeleteIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public DeleteIPStrategyResponse DeleteIPStrategySync(DeleteIPStrategyRequest req)
        {
             JsonResponseModel<DeleteIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public async Task<DeletePluginResponse> DeletePlugin(DeletePluginRequest req)
        {
             JsonResponseModel<DeletePluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an API Gateway plugin.
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public DeletePluginResponse DeletePluginSync(DeletePluginRequest req)
        {
             JsonResponseModel<DeletePluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a service in API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public async Task<DeleteServiceResponse> DeleteService(DeleteServiceRequest req)
        {
             JsonResponseModel<DeleteServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a service in API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public DeleteServiceResponse DeleteServiceSync(DeleteServiceRequest req)
        {
             JsonResponseModel<DeleteServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom domain name mapping in a service environment.
        /// You can use this API if you use a custom domain name and custom mapping. Please note that if you delete all mappings in all environments, a failure will be returned when this API is called.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public async Task<DeleteServiceSubDomainMappingResponse> DeleteServiceSubDomainMapping(DeleteServiceSubDomainMappingRequest req)
        {
             JsonResponseModel<DeleteServiceSubDomainMappingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceSubDomainMapping");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceSubDomainMappingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom domain name mapping in a service environment.
        /// You can use this API if you use a custom domain name and custom mapping. Please note that if you delete all mappings in all environments, a failure will be returned when this API is called.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public DeleteServiceSubDomainMappingResponse DeleteServiceSubDomainMappingSync(DeleteServiceSubDomainMappingRequest req)
        {
             JsonResponseModel<DeleteServiceSubDomainMappingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceSubDomainMapping");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceSubDomainMappingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a usage plan.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public async Task<DeleteUsagePlanResponse> DeleteUsagePlan(DeleteUsagePlanRequest req)
        {
             JsonResponseModel<DeleteUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a usage plan.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public DeleteUsagePlanResponse DeleteUsagePlanSync(DeleteUsagePlanRequest req)
        {
             JsonResponseModel<DeleteUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to degrade a usage plan of a service in an environment to the API level.
        /// This operation will be denied if there are no APIs under the service.
        /// This operation will also be denied if the current environment has not been published.
        /// </summary>
        /// <param name="req"><see cref="DemoteServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DemoteServiceUsagePlanResponse"/></returns>
        public async Task<DemoteServiceUsagePlanResponse> DemoteServiceUsagePlan(DemoteServiceUsagePlanRequest req)
        {
             JsonResponseModel<DemoteServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DemoteServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DemoteServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DemoteServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DemoteServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DemoteServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of an API document.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocDetailRequest"/></param>
        /// <returns><see cref="DescribeAPIDocDetailResponse"/></returns>
        public async Task<DescribeAPIDocDetailResponse> DescribeAPIDocDetail(DescribeAPIDocDetailRequest req)
        {
             JsonResponseModel<DescribeAPIDocDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAPIDocDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIDocDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of an API document.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocDetailRequest"/></param>
        /// <returns><see cref="DescribeAPIDocDetailResponse"/></returns>
        public DescribeAPIDocDetailResponse DescribeAPIDocDetailSync(DescribeAPIDocDetailRequest req)
        {
             JsonResponseModel<DescribeAPIDocDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAPIDocDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIDocDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of API documents.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocsRequest"/></param>
        /// <returns><see cref="DescribeAPIDocsResponse"/></returns>
        public async Task<DescribeAPIDocsResponse> DescribeAPIDocs(DescribeAPIDocsRequest req)
        {
             JsonResponseModel<DescribeAPIDocsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAPIDocs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIDocsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of API documents.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocsRequest"/></param>
        /// <returns><see cref="DescribeAPIDocsResponse"/></returns>
        public DescribeAPIDocsResponse DescribeAPIDocsSync(DescribeAPIDocsRequest req)
        {
             JsonResponseModel<DescribeAPIDocsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAPIDocs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIDocsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all APIs that can use this plugin, no matter whether the API is bound with the plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllPluginApisRequest"/></param>
        /// <returns><see cref="DescribeAllPluginApisResponse"/></returns>
        public async Task<DescribeAllPluginApisResponse> DescribeAllPluginApis(DescribeAllPluginApisRequest req)
        {
             JsonResponseModel<DescribeAllPluginApisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllPluginApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllPluginApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all APIs that can use this plugin, no matter whether the API is bound with the plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllPluginApisRequest"/></param>
        /// <returns><see cref="DescribeAllPluginApisResponse"/></returns>
        public DescribeAllPluginApisResponse DescribeAllPluginApisSync(DescribeAllPluginApisRequest req)
        {
             JsonResponseModel<DescribeAllPluginApisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllPluginApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllPluginApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (`DescribeApi`) is used to query the details of the APIs users manage via Tencent Cloud API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public async Task<DescribeApiResponse> DescribeApi(DescribeApiRequest req)
        {
             JsonResponseModel<DescribeApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (`DescribeApi`) is used to query the details of the APIs users manage via Tencent Cloud API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public DescribeApiResponse DescribeApiSync(DescribeApiRequest req)
        {
             JsonResponseModel<DescribeApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for an application by application ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiAppResponse"/></returns>
        public async Task<DescribeApiAppResponse> DescribeApiApp(DescribeApiAppRequest req)
        {
             JsonResponseModel<DescribeApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for an application by application ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiAppResponse"/></returns>
        public DescribeApiAppResponse DescribeApiAppSync(DescribeApiAppRequest req)
        {
             JsonResponseModel<DescribeApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of APIs bound to an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppBindApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppBindApisStatusResponse"/></returns>
        public async Task<DescribeApiAppBindApisStatusResponse> DescribeApiAppBindApisStatus(DescribeApiAppBindApisStatusRequest req)
        {
             JsonResponseModel<DescribeApiAppBindApisStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiAppBindApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiAppBindApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of APIs bound to an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppBindApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppBindApisStatusResponse"/></returns>
        public DescribeApiAppBindApisStatusResponse DescribeApiAppBindApisStatusSync(DescribeApiAppBindApisStatusRequest req)
        {
             JsonResponseModel<DescribeApiAppBindApisStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiAppBindApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiAppBindApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppsStatusResponse"/></returns>
        public async Task<DescribeApiAppsStatusResponse> DescribeApiAppsStatus(DescribeApiAppsStatusRequest req)
        {
             JsonResponseModel<DescribeApiAppsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiAppsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiAppsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppsStatusResponse"/></returns>
        public DescribeApiAppsStatusResponse DescribeApiAppsStatusSync(DescribeApiAppsStatusRequest req)
        {
             JsonResponseModel<DescribeApiAppsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiAppsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiAppsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of applications bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiBindApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiBindApiAppsStatusResponse"/></returns>
        public async Task<DescribeApiBindApiAppsStatusResponse> DescribeApiBindApiAppsStatus(DescribeApiBindApiAppsStatusRequest req)
        {
             JsonResponseModel<DescribeApiBindApiAppsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiBindApiAppsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiBindApiAppsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of applications bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiBindApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiBindApiAppsStatusResponse"/></returns>
        public DescribeApiBindApiAppsStatusResponse DescribeApiBindApiAppsStatusSync(DescribeApiBindApiAppsStatusRequest req)
        {
             JsonResponseModel<DescribeApiBindApiAppsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiBindApiAppsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiBindApiAppsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the throttling policies bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public async Task<DescribeApiEnvironmentStrategyResponse> DescribeApiEnvironmentStrategy(DescribeApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the throttling policies bound to an API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public DescribeApiEnvironmentStrategyResponse DescribeApiEnvironmentStrategySync(DescribeApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of an API deployed at API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiForApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiForApiAppResponse"/></returns>
        public async Task<DescribeApiForApiAppResponse> DescribeApiForApiApp(DescribeApiForApiAppRequest req)
        {
             JsonResponseModel<DescribeApiForApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiForApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiForApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of an API deployed at API Gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiForApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiForApiAppResponse"/></returns>
        public DescribeApiForApiAppResponse DescribeApiForApiAppSync(DescribeApiForApiAppRequest req)
        {
             JsonResponseModel<DescribeApiForApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiForApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiForApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a key.
        /// After creating an API key, you can query its details by using this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public async Task<DescribeApiKeyResponse> DescribeApiKey(DescribeApiKeyRequest req)
        {
             JsonResponseModel<DescribeApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a key.
        /// After creating an API key, you can query its details by using this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public DescribeApiKeyResponse DescribeApiKeySync(DescribeApiKeyRequest req)
        {
             JsonResponseModel<DescribeApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of keys.
        /// If you have created multiple API key pairs, you can use this API to query the information of one or more keys. This API does not display the `secretKey`.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public async Task<DescribeApiKeysStatusResponse> DescribeApiKeysStatus(DescribeApiKeysStatusRequest req)
        {
             JsonResponseModel<DescribeApiKeysStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiKeysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of keys.
        /// If you have created multiple API key pairs, you can use this API to query the information of one or more keys. This API does not display the `secretKey`.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public DescribeApiKeysStatusResponse DescribeApiKeysStatusSync(DescribeApiKeysStatusRequest req)
        {
             JsonResponseModel<DescribeApiKeysStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiKeysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of API usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service and APIs under it.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public async Task<DescribeApiUsagePlanResponse> DescribeApiUsagePlan(DescribeApiUsagePlanRequest req)
        {
             JsonResponseModel<DescribeApiUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of API usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service and APIs under it.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public DescribeApiUsagePlanResponse DescribeApiUsagePlanSync(DescribeApiUsagePlanRequest req)
        {
             JsonResponseModel<DescribeApiUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view a certain API or the list of all APIs under a service and relevant information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public async Task<DescribeApisStatusResponse> DescribeApisStatus(DescribeApisStatusRequest req)
        {
             JsonResponseModel<DescribeApisStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view a certain API or the list of all APIs under a service and relevant information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public DescribeApisStatusResponse DescribeApisStatusSync(DescribeApisStatusRequest req)
        {
             JsonResponseModel<DescribeApisStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query IP policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public async Task<DescribeIPStrategyResponse> DescribeIPStrategy(DescribeIPStrategyRequest req)
        {
             JsonResponseModel<DescribeIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query IP policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public DescribeIPStrategyResponse DescribeIPStrategySync(DescribeIPStrategyRequest req)
        {
             JsonResponseModel<DescribeIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of APIs to which an IP policy can be bound, i.e., the difference set between all APIs under the service and the APIs already bound to the policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public async Task<DescribeIPStrategyApisStatusResponse> DescribeIPStrategyApisStatus(DescribeIPStrategyApisStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategyApisStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStrategyApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of APIs to which an IP policy can be bound, i.e., the difference set between all APIs under the service and the APIs already bound to the policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public DescribeIPStrategyApisStatusResponse DescribeIPStrategyApisStatusSync(DescribeIPStrategyApisStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategyApisStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStrategyApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of service IP policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public async Task<DescribeIPStrategysStatusResponse> DescribeIPStrategysStatus(DescribeIPStrategysStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategysStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStrategysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of service IP policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public DescribeIPStrategysStatusResponse DescribeIPStrategysStatusSync(DescribeIPStrategysStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategysStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStrategysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public async Task<DescribeLogSearchResponse> DescribeLogSearch(DescribeLogSearchRequest req)
        {
             JsonResponseModel<DescribeLogSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public DescribeLogSearchResponse DescribeLogSearchSync(DescribeLogSearchRequest req)
        {
             JsonResponseModel<DescribeLogSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the plugin details by plugin ID.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public async Task<DescribePluginResponse> DescribePlugin(DescribePluginRequest req)
        {
             JsonResponseModel<DescribePluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the plugin details by plugin ID.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public DescribePluginResponse DescribePluginSync(DescribePluginRequest req)
        {
             JsonResponseModel<DescribePluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query APIs bound with a specified plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginApisRequest"/></param>
        /// <returns><see cref="DescribePluginApisResponse"/></returns>
        public async Task<DescribePluginApisResponse> DescribePluginApis(DescribePluginApisRequest req)
        {
             JsonResponseModel<DescribePluginApisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePluginApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePluginApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query APIs bound with a specified plugin.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginApisRequest"/></param>
        /// <returns><see cref="DescribePluginApisResponse"/></returns>
        public DescribePluginApisResponse DescribePluginApisSync(DescribePluginApisRequest req)
        {
             JsonResponseModel<DescribePluginApisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePluginApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePluginApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, protocol, creation time, and releases.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public async Task<DescribeServiceResponse> DescribeService(DescribeServiceRequest req)
        {
             JsonResponseModel<DescribeServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, protocol, creation time, and releases.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public DescribeServiceResponse DescribeServiceSync(DescribeServiceRequest req)
        {
             JsonResponseModel<DescribeServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of environments under a service. All environments and their statuses under the queried service will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public async Task<DescribeServiceEnvironmentListResponse> DescribeServiceEnvironmentList(DescribeServiceEnvironmentListRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceEnvironmentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of environments under a service. All environments and their statuses under the queried service will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public DescribeServiceEnvironmentListResponse DescribeServiceEnvironmentListSync(DescribeServiceEnvironmentListRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceEnvironmentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the release history in a service environment.
        /// A service can only be used when it is published to an environment after creation. This API is used to query the release history in an environment under a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public async Task<DescribeServiceEnvironmentReleaseHistoryResponse> DescribeServiceEnvironmentReleaseHistory(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceEnvironmentReleaseHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the release history in a service environment.
        /// A service can only be used when it is published to an environment after creation. This API is used to query the release history in an environment under a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public DescribeServiceEnvironmentReleaseHistoryResponse DescribeServiceEnvironmentReleaseHistorySync(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceEnvironmentReleaseHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public async Task<DescribeServiceEnvironmentStrategyResponse> DescribeServiceEnvironmentStrategy(DescribeServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public DescribeServiceEnvironmentStrategyResponse DescribeServiceEnvironmentStrategySync(DescribeServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, and protocol.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceForApiAppRequest"/></param>
        /// <returns><see cref="DescribeServiceForApiAppResponse"/></returns>
        public async Task<DescribeServiceForApiAppResponse> DescribeServiceForApiApp(DescribeServiceForApiAppRequest req)
        {
             JsonResponseModel<DescribeServiceForApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceForApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceForApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a service, such as its description, domain name, and protocol.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceForApiAppRequest"/></param>
        /// <returns><see cref="DescribeServiceForApiAppResponse"/></returns>
        public DescribeServiceForApiAppResponse DescribeServiceForApiAppSync(DescribeServiceForApiAppRequest req)
        {
             JsonResponseModel<DescribeServiceForApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceForApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceForApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of all published versions under a service.
        /// A service is generally published on several versions. This API can be used to query the published versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public async Task<DescribeServiceReleaseVersionResponse> DescribeServiceReleaseVersion(DescribeServiceReleaseVersionRequest req)
        {
             JsonResponseModel<DescribeServiceReleaseVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceReleaseVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceReleaseVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of all published versions under a service.
        /// A service is generally published on several versions. This API can be used to query the published versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public DescribeServiceReleaseVersionResponse DescribeServiceReleaseVersionSync(DescribeServiceReleaseVersionRequest req)
        {
             JsonResponseModel<DescribeServiceReleaseVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceReleaseVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceReleaseVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the path mappings of a custom domain name.
        /// In API Gateway, you can bind a custom domain name to a service and map its paths. You can customize different path mappings to up to 3 environments under the service. This API is used to query the list of path mappings of a custom domain name bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public async Task<DescribeServiceSubDomainMappingsResponse> DescribeServiceSubDomainMappings(DescribeServiceSubDomainMappingsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainMappingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceSubDomainMappings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainMappingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the path mappings of a custom domain name.
        /// In API Gateway, you can bind a custom domain name to a service and map its paths. You can customize different path mappings to up to 3 environments under the service. This API is used to query the list of path mappings of a custom domain name bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public DescribeServiceSubDomainMappingsResponse DescribeServiceSubDomainMappingsSync(DescribeServiceSubDomainMappingsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainMappingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceSubDomainMappings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainMappingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of custom domain names.
        /// In API Gateway, you can bind custom domain names to a service for service call. This API is used to query the list of custom domain names bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public async Task<DescribeServiceSubDomainsResponse> DescribeServiceSubDomains(DescribeServiceSubDomainsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceSubDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of custom domain names.
        /// In API Gateway, you can bind custom domain names to a service for service call. This API is used to query the list of custom domain names bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public DescribeServiceSubDomainsResponse DescribeServiceSubDomainsSync(DescribeServiceSubDomainsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceSubDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public async Task<DescribeServiceUsagePlanResponse> DescribeServiceUsagePlan(DescribeServiceUsagePlanRequest req)
        {
             JsonResponseModel<DescribeServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of usage plans in a service.
        /// To make authentication and throttling for a service take effect, you need to bind a usage plan to it. This API is used to query all usage plans bound to a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public DescribeServiceUsagePlanResponse DescribeServiceUsagePlanSync(DescribeServiceUsagePlanRequest req)
        {
             JsonResponseModel<DescribeServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of one or more services and return relevant domain name, time, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public async Task<DescribeServicesStatusResponse> DescribeServicesStatus(DescribeServicesStatusRequest req)
        {
             JsonResponseModel<DescribeServicesStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServicesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServicesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of one or more services and return relevant domain name, time, and other information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public DescribeServicesStatusResponse DescribeServicesStatusSync(DescribeServicesStatusRequest req)
        {
             JsonResponseModel<DescribeServicesStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServicesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServicesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a usage plan, such as its name, QPS, creation time, and bound environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public async Task<DescribeUsagePlanResponse> DescribeUsagePlan(DescribeUsagePlanRequest req)
        {
             JsonResponseModel<DescribeUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a usage plan, such as its name, QPS, creation time, and bound environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public DescribeUsagePlanResponse DescribeUsagePlanSync(DescribeUsagePlanRequest req)
        {
             JsonResponseModel<DescribeUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of environments bound to a usage plan.
        /// After binding a usage plan to environments, you can use this API to query all service environments bound to the usage plan.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public async Task<DescribeUsagePlanEnvironmentsResponse> DescribeUsagePlanEnvironments(DescribeUsagePlanEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlanEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of environments bound to a usage plan.
        /// After binding a usage plan to environments, you can use this API to query all service environments bound to the usage plan.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public DescribeUsagePlanEnvironmentsResponse DescribeUsagePlanEnvironmentsSync(DescribeUsagePlanEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlanEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of keys bound to a usage plan.
        /// In API Gateway, a usage plan can be bound to multiple key pairs. You can use this API to query the list of keys bound to it.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public async Task<DescribeUsagePlanSecretIdsResponse> DescribeUsagePlanSecretIds(DescribeUsagePlanSecretIdsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlanSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of keys bound to a usage plan.
        /// In API Gateway, a usage plan can be bound to multiple key pairs. You can use this API to query the list of keys bound to it.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public DescribeUsagePlanSecretIdsResponse DescribeUsagePlanSecretIdsSync(DescribeUsagePlanSecretIdsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlanSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of usage plans.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public async Task<DescribeUsagePlansStatusResponse> DescribeUsagePlansStatus(DescribeUsagePlansStatusRequest req)
        {
             JsonResponseModel<DescribeUsagePlansStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlansStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlansStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of usage plans.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public DescribeUsagePlansStatusResponse DescribeUsagePlansStatusSync(DescribeUsagePlansStatusRequest req)
        {
             JsonResponseModel<DescribeUsagePlansStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlansStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlansStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an API from the plugin.
        /// </summary>
        /// <param name="req"><see cref="DetachPluginRequest"/></param>
        /// <returns><see cref="DetachPluginResponse"/></returns>
        public async Task<DetachPluginResponse> DetachPlugin(DetachPluginRequest req)
        {
             JsonResponseModel<DetachPluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an API from the plugin.
        /// </summary>
        /// <param name="req"><see cref="DetachPluginRequest"/></param>
        /// <returns><see cref="DetachPluginResponse"/></returns>
        public DetachPluginResponse DetachPluginSync(DetachPluginRequest req)
        {
             JsonResponseModel<DetachPluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an API key.
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public async Task<DisableApiKeyResponse> DisableApiKey(DisableApiKeyRequest req)
        {
             JsonResponseModel<DisableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an API key.
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public DisableApiKeyResponse DisableApiKeySync(DisableApiKeyRequest req)
        {
             JsonResponseModel<DisableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a disabled API key.
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public async Task<EnableApiKeyResponse> EnableApiKey(EnableApiKeyRequest req)
        {
             JsonResponseModel<EnableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a disabled API key.
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public EnableApiKeyResponse EnableApiKeySync(EnableApiKeyRequest req)
        {
             JsonResponseModel<EnableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to automatically generate API documents and SDKs. One document and one SDK will be generated for each environment under each service, respectively.
        /// </summary>
        /// <param name="req"><see cref="GenerateApiDocumentRequest"/></param>
        /// <returns><see cref="GenerateApiDocumentResponse"/></returns>
        public async Task<GenerateApiDocumentResponse> GenerateApiDocument(GenerateApiDocumentRequest req)
        {
             JsonResponseModel<GenerateApiDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateApiDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateApiDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to automatically generate API documents and SDKs. One document and one SDK will be generated for each environment under each service, respectively.
        /// </summary>
        /// <param name="req"><see cref="GenerateApiDocumentRequest"/></param>
        /// <returns><see cref="GenerateApiDocumentResponse"/></returns>
        public GenerateApiDocumentResponse GenerateApiDocumentSync(GenerateApiDocumentRequest req)
        {
             JsonResponseModel<GenerateApiDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateApiDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateApiDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an API document.
        /// </summary>
        /// <param name="req"><see cref="ModifyAPIDocRequest"/></param>
        /// <returns><see cref="ModifyAPIDocResponse"/></returns>
        public async Task<ModifyAPIDocResponse> ModifyAPIDoc(ModifyAPIDocRequest req)
        {
             JsonResponseModel<ModifyAPIDocResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an API document.
        /// </summary>
        /// <param name="req"><see cref="ModifyAPIDocRequest"/></param>
        /// <returns><see cref="ModifyAPIDocResponse"/></returns>
        public ModifyAPIDocResponse ModifyAPIDocSync(ModifyAPIDocRequest req)
        {
             JsonResponseModel<ModifyAPIDocResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAPIDoc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAPIDocResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an API. You can call this API to edit/modify a configured API. The modified API takes effect only after its service is published to the corresponding environment again.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public async Task<ModifyApiResponse> ModifyApi(ModifyApiRequest req)
        {
             JsonResponseModel<ModifyApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an API. You can call this API to edit/modify a configured API. The modified API takes effect only after its service is published to the corresponding environment again.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public ModifyApiResponse ModifyApiSync(ModifyApiRequest req)
        {
             JsonResponseModel<ModifyApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a created API.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAppRequest"/></param>
        /// <returns><see cref="ModifyApiAppResponse"/></returns>
        public async Task<ModifyApiAppResponse> ModifyApiApp(ModifyApiAppRequest req)
        {
             JsonResponseModel<ModifyApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a created API.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAppRequest"/></param>
        /// <returns><see cref="ModifyApiAppResponse"/></returns>
        public ModifyApiAppResponse ModifyApiAppSync(ModifyApiAppRequest req)
        {
             JsonResponseModel<ModifyApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an API throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public async Task<ModifyApiEnvironmentStrategyResponse> ModifyApiEnvironmentStrategy(ModifyApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an API throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public ModifyApiEnvironmentStrategyResponse ModifyApiEnvironmentStrategySync(ModifyApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to incrementally update an API and mainly called by programs (different from `ModifyApi`, which requires that full API parameters be passed in and is suitable for use in the console).
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public async Task<ModifyApiIncrementResponse> ModifyApiIncrement(ModifyApiIncrementRequest req)
        {
             JsonResponseModel<ModifyApiIncrementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApiIncrement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiIncrementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to incrementally update an API and mainly called by programs (different from `ModifyApi`, which requires that full API parameters be passed in and is suitable for use in the console).
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public ModifyApiIncrementResponse ModifyApiIncrementSync(ModifyApiIncrementRequest req)
        {
             JsonResponseModel<ModifyApiIncrementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApiIncrement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiIncrementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public async Task<ModifyIPStrategyResponse> ModifyIPStrategy(ModifyIPStrategyRequest req)
        {
             JsonResponseModel<ModifyIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a service IP policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public ModifyIPStrategyResponse ModifyIPStrategySync(ModifyIPStrategyRequest req)
        {
             JsonResponseModel<ModifyIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a plugin.
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public async Task<ModifyPluginResponse> ModifyPlugin(ModifyPluginRequest req)
        {
             JsonResponseModel<ModifyPluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a plugin.
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public ModifyPluginResponse ModifyPluginSync(ModifyPluginRequest req)
        {
             JsonResponseModel<ModifyPluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the relevant information of a service. After a service is created, its name, description, and service type can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public async Task<ModifyServiceResponse> ModifyService(ModifyServiceRequest req)
        {
             JsonResponseModel<ModifyServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the relevant information of a service. After a service is created, its name, description, and service type can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public ModifyServiceResponse ModifyServiceSync(ModifyServiceRequest req)
        {
             JsonResponseModel<ModifyServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public async Task<ModifyServiceEnvironmentStrategyResponse> ModifyServiceEnvironmentStrategy(ModifyServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a service throttling policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public ModifyServiceEnvironmentStrategyResponse ModifyServiceEnvironmentStrategySync(ModifyServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the path mapping in the custom domain name settings of a service. The path mapping rule can be modified before it is bound to the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public async Task<ModifySubDomainResponse> ModifySubDomain(ModifySubDomainRequest req)
        {
             JsonResponseModel<ModifySubDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the path mapping in the custom domain name settings of a service. The path mapping rule can be modified before it is bound to the custom domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public ModifySubDomainResponse ModifySubDomainSync(ModifySubDomainRequest req)
        {
             JsonResponseModel<ModifySubDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the name, description, and QPS of a usage plan.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public async Task<ModifyUsagePlanResponse> ModifyUsagePlan(ModifyUsagePlanRequest req)
        {
             JsonResponseModel<ModifyUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the name, description, and QPS of a usage plan.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public ModifyUsagePlanResponse ModifyUsagePlanSync(ModifyUsagePlanRequest req)
        {
             JsonResponseModel<ModifyUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to publish a service.
        /// An API Gateway service can only be called when it is published to an environment and takes effect after creation. This API is used to publish a service to an environment such as the `release` environment.
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public async Task<ReleaseServiceResponse> ReleaseService(ReleaseServiceRequest req)
        {
             JsonResponseModel<ReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to publish a service.
        /// An API Gateway service can only be called when it is published to an environment and takes effect after creation. This API is used to publish a service to an environment such as the `release` environment.
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public ReleaseServiceResponse ReleaseServiceSync(ReleaseServiceRequest req)
        {
             JsonResponseModel<ReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password of an API document.
        /// </summary>
        /// <param name="req"><see cref="ResetAPIDocPasswordRequest"/></param>
        /// <returns><see cref="ResetAPIDocPasswordResponse"/></returns>
        public async Task<ResetAPIDocPasswordResponse> ResetAPIDocPassword(ResetAPIDocPasswordRequest req)
        {
             JsonResponseModel<ResetAPIDocPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAPIDocPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAPIDocPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password of an API document.
        /// </summary>
        /// <param name="req"><see cref="ResetAPIDocPasswordRequest"/></param>
        /// <returns><see cref="ResetAPIDocPasswordResponse"/></returns>
        public ResetAPIDocPasswordResponse ResetAPIDocPasswordSync(ResetAPIDocPasswordRequest req)
        {
             JsonResponseModel<ResetAPIDocPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAPIDocPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAPIDocPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a usage plan from a specified environment.
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public async Task<UnBindEnvironmentResponse> UnBindEnvironment(UnBindEnvironmentRequest req)
        {
             JsonResponseModel<UnBindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a usage plan from a specified environment.
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public UnBindEnvironmentResponse UnBindEnvironmentSync(UnBindEnvironmentRequest req)
        {
             JsonResponseModel<UnBindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an IP policy from a service.
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public async Task<UnBindIPStrategyResponse> UnBindIPStrategy(UnBindIPStrategyRequest req)
        {
             JsonResponseModel<UnBindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an IP policy from a service.
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public UnBindIPStrategyResponse UnBindIPStrategySync(UnBindIPStrategyRequest req)
        {
             JsonResponseModel<UnBindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a key from a usage plan.
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public async Task<UnBindSecretIdsResponse> UnBindSecretIds(UnBindSecretIdsRequest req)
        {
             JsonResponseModel<UnBindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a key from a usage plan.
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public UnBindSecretIdsResponse UnBindSecretIdsSync(UnBindSecretIdsRequest req)
        {
             JsonResponseModel<UnBindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a custom domain name.
        /// After binding a custom domain name to a service by using API Gateway, you can use this API to unbind it.
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public async Task<UnBindSubDomainResponse> UnBindSubDomain(UnBindSubDomainRequest req)
        {
             JsonResponseModel<UnBindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a custom domain name.
        /// After binding a custom domain name to a service by using API Gateway, you can use this API to unbind it.
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public UnBindSubDomainResponse UnBindSubDomainSync(UnBindSubDomainRequest req)
        {
             JsonResponseModel<UnBindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deactivate a service.
        /// Only after a service is published to an environment can its APIs be called. You can call this API to deactivate a service in the release environment. Once deactivated, the service cannot be called.
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public async Task<UnReleaseServiceResponse> UnReleaseService(UnReleaseServiceRequest req)
        {
             JsonResponseModel<UnReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deactivate a service.
        /// Only after a service is published to an environment can its APIs be called. You can call this API to deactivate a service in the release environment. Once deactivated, the service cannot be called.
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public UnReleaseServiceResponse UnReleaseServiceSync(UnReleaseServiceRequest req)
        {
             JsonResponseModel<UnReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an application from an API.
        /// </summary>
        /// <param name="req"><see cref="UnbindApiAppRequest"/></param>
        /// <returns><see cref="UnbindApiAppResponse"/></returns>
        public async Task<UnbindApiAppResponse> UnbindApiApp(UnbindApiAppRequest req)
        {
             JsonResponseModel<UnbindApiAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an application from an API.
        /// </summary>
        /// <param name="req"><see cref="UnbindApiAppRequest"/></param>
        /// <returns><see cref="UnbindApiAppResponse"/></returns>
        public UnbindApiAppResponse UnbindApiAppSync(UnbindApiAppRequest req)
        {
             JsonResponseModel<UnbindApiAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindApiApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindApiAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update an application key.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiAppKeyRequest"/></param>
        /// <returns><see cref="UpdateApiAppKeyResponse"/></returns>
        public async Task<UpdateApiAppKeyResponse> UpdateApiAppKey(UpdateApiAppKeyRequest req)
        {
             JsonResponseModel<UpdateApiAppKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateApiAppKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiAppKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update an application key.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiAppKeyRequest"/></param>
        /// <returns><see cref="UpdateApiAppKeyResponse"/></returns>
        public UpdateApiAppKeyResponse UpdateApiAppKeySync(UpdateApiAppKeyRequest req)
        {
             JsonResponseModel<UpdateApiAppKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateApiAppKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiAppKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a created API key pair.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public async Task<UpdateApiKeyResponse> UpdateApiKey(UpdateApiKeyRequest req)
        {
             JsonResponseModel<UpdateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a created API key pair.
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public UpdateApiKeyResponse UpdateApiKeySync(UpdateApiKeyRequest req)
        {
             JsonResponseModel<UpdateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch the running version of a service published in an environment to a specified version. After you create a service by using API Gateway and publish it to an environment, multiple versions will be generated during development. In this case, you can call this API to switch versions.
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public async Task<UpdateServiceResponse> UpdateService(UpdateServiceRequest req)
        {
             JsonResponseModel<UpdateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch the running version of a service published in an environment to a specified version. After you create a service by using API Gateway and publish it to an environment, multiple versions will be generated during development. In this case, you can call this API to switch versions.
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public UpdateServiceResponse UpdateServiceSync(UpdateServiceRequest req)
        {
             JsonResponseModel<UpdateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
