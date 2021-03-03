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

namespace TencentCloud.Scf.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Scf.V20180416.Models;

   public class ScfClient : AbstractClient{

       private const string endpoint = "scf.tencentcloudapi.com";
       private const string version = "2018-04-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ScfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ScfClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to replicate a function. You can store the replicated function in a specified Region and Namespace.
        /// Note: This API **does not** replicate the following objects or attributes of the function:
        /// 1. Function trigger
        /// 2. Versions other than $LATEST
        /// 3. CLS target of the logs configured in the function
        /// 
        /// You can manually configure the function after replication as required.
        /// </summary>
        /// <param name="req"><see cref="CopyFunctionRequest"/></param>
        /// <returns><see cref="CopyFunctionResponse"/></returns>
        public async Task<CopyFunctionResponse> CopyFunction(CopyFunctionRequest req)
        {
             JsonResponseModel<CopyFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to replicate a function. You can store the replicated function in a specified Region and Namespace.
        /// Note: This API **does not** replicate the following objects or attributes of the function:
        /// 1. Function trigger
        /// 2. Versions other than $LATEST
        /// 3. CLS target of the logs configured in the function
        /// 
        /// You can manually configure the function after replication as required.
        /// </summary>
        /// <param name="req"><see cref="CopyFunctionRequest"/></param>
        /// <returns><see cref="CopyFunctionResponse"/></returns>
        public CopyFunctionResponse CopyFunctionSync(CopyFunctionRequest req)
        {
             JsonResponseModel<CopyFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alias for a function version. You can use the alias to mark a specific function version such as DEV/RELEASE. You can also modify the version pointed to by the alias at any time.
        /// An alias must point to a master version and can point to an additional version at the same time. If you specify an alias when invoking a function, the request will be sent to the versions pointed to by the alias. You can configure the ratio between the master version and additional version during request sending.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public async Task<CreateAliasResponse> CreateAlias(CreateAliasRequest req)
        {
             JsonResponseModel<CreateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alias for a function version. You can use the alias to mark a specific function version such as DEV/RELEASE. You can also modify the version pointed to by the alias at any time.
        /// An alias must point to a master version and can point to an additional version at the same time. If you specify an alias when invoking a function, the request will be sent to the versions pointed to by the alias. You can configure the ratio between the master version and additional version during request sending.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public CreateAliasResponse CreateAliasSync(CreateAliasRequest req)
        {
             JsonResponseModel<CreateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a function based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public async Task<CreateFunctionResponse> CreateFunction(CreateFunctionRequest req)
        {
             JsonResponseModel<CreateFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a function based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public CreateFunctionResponse CreateFunctionSync(CreateFunctionRequest req)
        {
             JsonResponseModel<CreateFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a namespace based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a namespace based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public async Task<CreateTriggerResponse> CreateTrigger(CreateTriggerRequest req)
        {
             JsonResponseModel<CreateTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public CreateTriggerResponse CreateTriggerSync(CreateTriggerRequest req)
        {
             JsonResponseModel<CreateTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alias of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public async Task<DeleteAliasResponse> DeleteAlias(DeleteAliasRequest req)
        {
             JsonResponseModel<DeleteAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alias of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public DeleteAliasResponse DeleteAliasSync(DeleteAliasRequest req)
        {
             JsonResponseModel<DeleteAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a function based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public async Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
             JsonResponseModel<DeleteFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a function based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public DeleteFunctionResponse DeleteFunctionSync(DeleteFunctionRequest req)
        {
             JsonResponseModel<DeleteFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a specified version of a specified layer. The deleted version cannot be associated with a function, but the deletion does not affect functions that are referencing this layer.
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public async Task<DeleteLayerVersionResponse> DeleteLayerVersion(DeleteLayerVersionRequest req)
        {
             JsonResponseModel<DeleteLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a specified version of a specified layer. The deleted version cannot be associated with a function, but the deletion does not affect functions that are referencing this layer.
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public DeleteLayerVersionResponse DeleteLayerVersionSync(DeleteLayerVersionRequest req)
        {
             JsonResponseModel<DeleteLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a namespace based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a namespace based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the provisioned concurrency configuration of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public async Task<DeleteProvisionedConcurrencyConfigResponse> DeleteProvisionedConcurrencyConfig(DeleteProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the provisioned concurrency configuration of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public DeleteProvisionedConcurrencyConfigResponse DeleteProvisionedConcurrencyConfigSync(DeleteProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the reserved concurrency configuration of a function.
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public async Task<DeleteReservedConcurrencyConfigResponse> DeleteReservedConcurrencyConfig(DeleteReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the reserved concurrency configuration of a function.
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public DeleteReservedConcurrencyConfigResponse DeleteReservedConcurrencyConfigSync(DeleteReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an existing trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public async Task<DeleteTriggerResponse> DeleteTrigger(DeleteTriggerRequest req)
        {
             JsonResponseModel<DeleteTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an existing trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public DeleteTriggerResponse DeleteTriggerSync(DeleteTriggerRequest req)
        {
             JsonResponseModel<DeleteTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the alias details such as the name, description, version, and routing information.
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public async Task<GetAliasResponse> GetAlias(GetAliasRequest req)
        {
             JsonResponseModel<GetAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the alias details such as the name, description, version, and routing information.
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public GetAliasResponse GetAliasSync(GetAliasRequest req)
        {
             JsonResponseModel<GetAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain function details, such as name, code, handler, associated trigger, and timeout.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionRequest"/></param>
        /// <returns><see cref="GetFunctionResponse"/></returns>
        public async Task<GetFunctionResponse> GetFunction(GetFunctionRequest req)
        {
             JsonResponseModel<GetFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain function details, such as name, code, handler, associated trigger, and timeout.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionRequest"/></param>
        /// <returns><see cref="GetFunctionResponse"/></returns>
        public GetFunctionResponse GetFunctionSync(GetFunctionRequest req)
        {
             JsonResponseModel<GetFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the download address of the function code package.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public async Task<GetFunctionAddressResponse> GetFunctionAddress(GetFunctionAddressRequest req)
        {
             JsonResponseModel<GetFunctionAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunctionAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the download address of the function code package.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public GetFunctionAddressResponse GetFunctionAddressSync(GetFunctionAddressRequest req)
        {
             JsonResponseModel<GetFunctionAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFunctionAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return function running logs according to the specified log query criteria.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public async Task<GetFunctionLogsResponse> GetFunctionLogs(GetFunctionLogsRequest req)
        {
             JsonResponseModel<GetFunctionLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunctionLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return function running logs according to the specified log query criteria.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public GetFunctionLogsResponse GetFunctionLogsSync(GetFunctionLogsRequest req)
        {
             JsonResponseModel<GetFunctionLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFunctionLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the layer version details, including links used to download files in the layer.
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public async Task<GetLayerVersionResponse> GetLayerVersion(GetLayerVersionRequest req)
        {
             JsonResponseModel<GetLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the layer version details, including links used to download files in the layer.
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public GetLayerVersionResponse GetLayerVersionSync(GetLayerVersionRequest req)
        {
             JsonResponseModel<GetLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the provisioned concurrency details of a function or its specified version.
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public async Task<GetProvisionedConcurrencyConfigResponse> GetProvisionedConcurrencyConfig(GetProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the provisioned concurrency details of a function or its specified version.
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public GetProvisionedConcurrencyConfigResponse GetProvisionedConcurrencyConfigSync(GetProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the reserved concurrency details of a function.
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public async Task<GetReservedConcurrencyConfigResponse> GetReservedConcurrencyConfig(GetReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the reserved concurrency details of a function.
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public GetReservedConcurrencyConfigResponse GetReservedConcurrencyConfigSync(GetReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to run a function.
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public async Task<InvokeResponse> Invoke(InvokeRequest req)
        {
             JsonResponseModel<InvokeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Invoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to run a function.
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public InvokeResponse InvokeSync(InvokeRequest req)
        {
             JsonResponseModel<InvokeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Invoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of all aliases under a function. You can filter them by the specific function version.
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public async Task<ListAliasesResponse> ListAliases(ListAliasesRequest req)
        {
             JsonResponseModel<ListAliasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAliases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAliasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of all aliases under a function. You can filter them by the specific function version.
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public ListAliasesResponse ListAliasesSync(ListAliasesRequest req)
        {
             JsonResponseModel<ListAliasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAliases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAliasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull the list of async function events.
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public async Task<ListAsyncEventsResponse> ListAsyncEvents(ListAsyncEventsRequest req)
        {
             JsonResponseModel<ListAsyncEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAsyncEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAsyncEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull the list of async function events.
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public ListAsyncEventsResponse ListAsyncEventsSync(ListAsyncEventsRequest req)
        {
             JsonResponseModel<ListAsyncEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAsyncEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAsyncEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return relevant function information based on the input query parameters.
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public async Task<ListFunctionsResponse> ListFunctions(ListFunctionsRequest req)
        {
             JsonResponseModel<ListFunctionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListFunctions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFunctionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return relevant function information based on the input query parameters.
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public ListFunctionsResponse ListFunctionsSync(ListFunctionsRequest req)
        {
             JsonResponseModel<ListFunctionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListFunctions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFunctionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of all versions of a specified layer.
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public async Task<ListLayerVersionsResponse> ListLayerVersions(ListLayerVersionsRequest req)
        {
             JsonResponseModel<ListLayerVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListLayerVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayerVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of all versions of a specified layer.
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public ListLayerVersionsResponse ListLayerVersionsSync(ListLayerVersionsRequest req)
        {
             JsonResponseModel<ListLayerVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListLayerVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayerVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of all layers, including the information of the latest version of each layer. You can filter them by the compatible runtime.
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public async Task<ListLayersResponse> ListLayers(ListLayersRequest req)
        {
             JsonResponseModel<ListLayersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListLayers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of all layers, including the information of the latest version of each layer. You can filter them by the compatible runtime.
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public ListLayersResponse ListLayersSync(ListLayersRequest req)
        {
             JsonResponseModel<ListLayersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListLayers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display a namespace list.
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public async Task<ListNamespacesResponse> ListNamespaces(ListNamespacesRequest req)
        {
             JsonResponseModel<ListNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display a namespace list.
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public ListNamespacesResponse ListNamespacesSync(ListNamespacesRequest req)
        {
             JsonResponseModel<ListNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the function trigger list.
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public async Task<ListTriggersResponse> ListTriggers(ListTriggersRequest req)
        {
             JsonResponseModel<ListTriggersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTriggers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTriggersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the function trigger list.
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public ListTriggersResponse ListTriggersSync(ListTriggersRequest req)
        {
             JsonResponseModel<ListTriggersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTriggers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTriggersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the function version based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public async Task<ListVersionByFunctionResponse> ListVersionByFunction(ListVersionByFunctionRequest req)
        {
             JsonResponseModel<ListVersionByFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListVersionByFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListVersionByFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the function version based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public ListVersionByFunctionResponse ListVersionByFunctionSync(ListVersionByFunctionRequest req)
        {
             JsonResponseModel<ListVersionByFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListVersionByFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListVersionByFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a version for a layer by using the given .zip file or COS object. Each time this API is called with the same layer name, a new version will be generated.
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public async Task<PublishLayerVersionResponse> PublishLayerVersion(PublishLayerVersionRequest req)
        {
             JsonResponseModel<PublishLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a version for a layer by using the given .zip file or COS object. Each time this API is called with the same layer name, a new version will be generated.
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public PublishLayerVersionResponse PublishLayerVersionSync(PublishLayerVersionRequest req)
        {
             JsonResponseModel<PublishLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for users to release a new version of the function.
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public async Task<PublishVersionResponse> PublishVersion(PublishVersionRequest req)
        {
             JsonResponseModel<PublishVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for users to release a new version of the function.
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public PublishVersionResponse PublishVersionSync(PublishVersionRequest req)
        {
             JsonResponseModel<PublishVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the provisioned concurrency of a non-$LATEST version of a function.
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public async Task<PutProvisionedConcurrencyConfigResponse> PutProvisionedConcurrencyConfig(PutProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the provisioned concurrency of a non-$LATEST version of a function.
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public PutProvisionedConcurrencyConfigResponse PutProvisionedConcurrencyConfigSync(PutProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the reserved concurrency of a function.
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public async Task<PutReservedConcurrencyConfigResponse> PutReservedConcurrencyConfig(PutReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the reserved concurrency of a function.
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public PutReservedConcurrencyConfigResponse PutReservedConcurrencyConfigSync(PutReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the account concurrency quota.
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public async Task<PutTotalConcurrencyConfigResponse> PutTotalConcurrencyConfig(PutTotalConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutTotalConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutTotalConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutTotalConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the account concurrency quota.
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public PutTotalConcurrencyConfigResponse PutTotalConcurrencyConfigSync(PutTotalConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutTotalConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutTotalConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutTotalConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a running async function event.
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public async Task<TerminateAsyncEventResponse> TerminateAsyncEvent(TerminateAsyncEventRequest req)
        {
             JsonResponseModel<TerminateAsyncEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateAsyncEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateAsyncEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a running async function event.
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public TerminateAsyncEventResponse TerminateAsyncEventSync(TerminateAsyncEventRequest req)
        {
             JsonResponseModel<TerminateAsyncEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateAsyncEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateAsyncEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the configuration of an alias.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public async Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the configuration of an alias.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the function code based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public async Task<UpdateFunctionCodeResponse> UpdateFunctionCode(UpdateFunctionCodeRequest req)
        {
             JsonResponseModel<UpdateFunctionCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFunctionCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the function code based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public UpdateFunctionCodeResponse UpdateFunctionCodeSync(UpdateFunctionCodeRequest req)
        {
             JsonResponseModel<UpdateFunctionCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFunctionCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the function configuration based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionConfigurationRequest"/></param>
        /// <returns><see cref="UpdateFunctionConfigurationResponse"/></returns>
        public async Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest req)
        {
             JsonResponseModel<UpdateFunctionConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFunctionConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the function configuration based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionConfigurationRequest"/></param>
        /// <returns><see cref="UpdateFunctionConfigurationResponse"/></returns>
        public UpdateFunctionConfigurationResponse UpdateFunctionConfigurationSync(UpdateFunctionConfigurationRequest req)
        {
             JsonResponseModel<UpdateFunctionConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFunctionConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a namespace.
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespace(UpdateNamespaceRequest req)
        {
             JsonResponseModel<UpdateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a namespace.
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public UpdateNamespaceResponse UpdateNamespaceSync(UpdateNamespaceRequest req)
        {
             JsonResponseModel<UpdateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
