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
       private const string sdkVersion = "SDK_NET_3.0.934";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ScfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
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
        public Task<CopyFunctionResponse> CopyFunction(CopyFunctionRequest req)
        {
            return InternalRequestAsync<CopyFunctionResponse>(req, "CopyFunction");
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
            return InternalRequestAsync<CopyFunctionResponse>(req, "CopyFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an alias for a function version. You can use the alias to mark a specific function version such as DEV/RELEASE. You can also modify the version pointed to by the alias at any time.
        /// An alias must point to a master version and can point to an additional version at the same time. If you specify an alias when invoking a function, the request will be sent to the versions pointed to by the alias. You can configure the ratio between the master version and additional version during request sending.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public Task<CreateAliasResponse> CreateAlias(CreateAliasRequest req)
        {
            return InternalRequestAsync<CreateAliasResponse>(req, "CreateAlias");
        }

        /// <summary>
        /// This API is used to create an alias for a function version. You can use the alias to mark a specific function version such as DEV/RELEASE. You can also modify the version pointed to by the alias at any time.
        /// An alias must point to a master version and can point to an additional version at the same time. If you specify an alias when invoking a function, the request will be sent to the versions pointed to by the alias. You can configure the ratio between the master version and additional version during request sending.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public CreateAliasResponse CreateAliasSync(CreateAliasRequest req)
        {
            return InternalRequestAsync<CreateAliasResponse>(req, "CreateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a namespace based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace");
        }

        /// <summary>
        /// This API is used to create a namespace based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public Task<CreateTriggerResponse> CreateTrigger(CreateTriggerRequest req)
        {
            return InternalRequestAsync<CreateTriggerResponse>(req, "CreateTrigger");
        }

        /// <summary>
        /// This API is used to create a trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public CreateTriggerResponse CreateTriggerSync(CreateTriggerRequest req)
        {
            return InternalRequestAsync<CreateTriggerResponse>(req, "CreateTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alias of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public Task<DeleteAliasResponse> DeleteAlias(DeleteAliasRequest req)
        {
            return InternalRequestAsync<DeleteAliasResponse>(req, "DeleteAlias");
        }

        /// <summary>
        /// This API is used to delete an alias of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public DeleteAliasResponse DeleteAliasSync(DeleteAliasRequest req)
        {
            return InternalRequestAsync<DeleteAliasResponse>(req, "DeleteAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a function based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction");
        }

        /// <summary>
        /// This API is used to delete a function based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public DeleteFunctionResponse DeleteFunctionSync(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a specified version of a specified layer. The deleted version cannot be associated with a function, but the deletion does not affect functions that are referencing this layer.
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public Task<DeleteLayerVersionResponse> DeleteLayerVersion(DeleteLayerVersionRequest req)
        {
            return InternalRequestAsync<DeleteLayerVersionResponse>(req, "DeleteLayerVersion");
        }

        /// <summary>
        /// This API is used to delete a specified version of a specified layer. The deleted version cannot be associated with a function, but the deletion does not affect functions that are referencing this layer.
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public DeleteLayerVersionResponse DeleteLayerVersionSync(DeleteLayerVersionRequest req)
        {
            return InternalRequestAsync<DeleteLayerVersionResponse>(req, "DeleteLayerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the specific namespace according to the parameters passed in.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace");
        }

        /// <summary>
        /// This API is used to delete the specific namespace according to the parameters passed in.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the provisioned concurrency configuration of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public Task<DeleteProvisionedConcurrencyConfigResponse> DeleteProvisionedConcurrencyConfig(DeleteProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteProvisionedConcurrencyConfigResponse>(req, "DeleteProvisionedConcurrencyConfig");
        }

        /// <summary>
        /// This API is used to delete the provisioned concurrency configuration of a function version.
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public DeleteProvisionedConcurrencyConfigResponse DeleteProvisionedConcurrencyConfigSync(DeleteProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteProvisionedConcurrencyConfigResponse>(req, "DeleteProvisionedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the configuration of reserved quota.
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public Task<DeleteReservedConcurrencyConfigResponse> DeleteReservedConcurrencyConfig(DeleteReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteReservedConcurrencyConfigResponse>(req, "DeleteReservedConcurrencyConfig");
        }

        /// <summary>
        /// This API is used to delete the configuration of reserved quota.
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public DeleteReservedConcurrencyConfigResponse DeleteReservedConcurrencyConfigSync(DeleteReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteReservedConcurrencyConfigResponse>(req, "DeleteReservedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an existing trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public Task<DeleteTriggerResponse> DeleteTrigger(DeleteTriggerRequest req)
        {
            return InternalRequestAsync<DeleteTriggerResponse>(req, "DeleteTrigger");
        }

        /// <summary>
        /// This API is used to delete an existing trigger based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public DeleteTriggerResponse DeleteTriggerSync(DeleteTriggerRequest req)
        {
            return InternalRequestAsync<DeleteTriggerResponse>(req, "DeleteTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the account information.
        /// </summary>
        /// <param name="req"><see cref="GetAccountRequest"/></param>
        /// <returns><see cref="GetAccountResponse"/></returns>
        public Task<GetAccountResponse> GetAccount(GetAccountRequest req)
        {
            return InternalRequestAsync<GetAccountResponse>(req, "GetAccount");
        }

        /// <summary>
        /// This API is used to get the account information.
        /// </summary>
        /// <param name="req"><see cref="GetAccountRequest"/></param>
        /// <returns><see cref="GetAccountResponse"/></returns>
        public GetAccountResponse GetAccountSync(GetAccountRequest req)
        {
            return InternalRequestAsync<GetAccountResponse>(req, "GetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the alias details such as the name, description, version, and routing information.
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public Task<GetAliasResponse> GetAlias(GetAliasRequest req)
        {
            return InternalRequestAsync<GetAliasResponse>(req, "GetAlias");
        }

        /// <summary>
        /// This API is used to get the alias details such as the name, description, version, and routing information.
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public GetAliasResponse GetAliasSync(GetAliasRequest req)
        {
            return InternalRequestAsync<GetAliasResponse>(req, "GetAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the status of an async function execution event. The event status is retained for 3*24 hours, counting from the completion of the event.
        /// </summary>
        /// <param name="req"><see cref="GetAsyncEventStatusRequest"/></param>
        /// <returns><see cref="GetAsyncEventStatusResponse"/></returns>
        public Task<GetAsyncEventStatusResponse> GetAsyncEventStatus(GetAsyncEventStatusRequest req)
        {
            return InternalRequestAsync<GetAsyncEventStatusResponse>(req, "GetAsyncEventStatus");
        }

        /// <summary>
        /// This API is used to get the status of an async function execution event. The event status is retained for 3*24 hours, counting from the completion of the event.
        /// </summary>
        /// <param name="req"><see cref="GetAsyncEventStatusRequest"/></param>
        /// <returns><see cref="GetAsyncEventStatusResponse"/></returns>
        public GetAsyncEventStatusResponse GetAsyncEventStatusSync(GetAsyncEventStatusRequest req)
        {
            return InternalRequestAsync<GetAsyncEventStatusResponse>(req, "GetAsyncEventStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the download address of the function code package.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public Task<GetFunctionAddressResponse> GetFunctionAddress(GetFunctionAddressRequest req)
        {
            return InternalRequestAsync<GetFunctionAddressResponse>(req, "GetFunctionAddress");
        }

        /// <summary>
        /// This API is used to obtain the download address of the function code package.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public GetFunctionAddressResponse GetFunctionAddressSync(GetFunctionAddressRequest req)
        {
            return InternalRequestAsync<GetFunctionAddressResponse>(req, "GetFunctionAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the async retry configuration of a function, including the number of retry attempts and message retention period.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="GetFunctionEventInvokeConfigResponse"/></returns>
        public Task<GetFunctionEventInvokeConfigResponse> GetFunctionEventInvokeConfig(GetFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<GetFunctionEventInvokeConfigResponse>(req, "GetFunctionEventInvokeConfig");
        }

        /// <summary>
        /// This API is used to get the async retry configuration of a function, including the number of retry attempts and message retention period.
        /// </summary>
        /// <param name="req"><see cref="GetFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="GetFunctionEventInvokeConfigResponse"/></returns>
        public GetFunctionEventInvokeConfigResponse GetFunctionEventInvokeConfigSync(GetFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<GetFunctionEventInvokeConfigResponse>(req, "GetFunctionEventInvokeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API returns function running logs according to the specified conditions. Note that this API has been disused. You can use [GetRequestStatus](https://intl.cloud.tencent.com/document/product/583/65348?from_cn_redirect=1) instead. See also [Retrieving Logs](https://intl.cloud.tencent.com/document/product/583/52637?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public Task<GetFunctionLogsResponse> GetFunctionLogs(GetFunctionLogsRequest req)
        {
            return InternalRequestAsync<GetFunctionLogsResponse>(req, "GetFunctionLogs");
        }

        /// <summary>
        /// This API returns function running logs according to the specified conditions. Note that this API has been disused. You can use [GetRequestStatus](https://intl.cloud.tencent.com/document/product/583/65348?from_cn_redirect=1) instead. See also [Retrieving Logs](https://intl.cloud.tencent.com/document/product/583/52637?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public GetFunctionLogsResponse GetFunctionLogsSync(GetFunctionLogsRequest req)
        {
            return InternalRequestAsync<GetFunctionLogsResponse>(req, "GetFunctionLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the layer version details, including links used to download files in the layer.
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public Task<GetLayerVersionResponse> GetLayerVersion(GetLayerVersionRequest req)
        {
            return InternalRequestAsync<GetLayerVersionResponse>(req, "GetLayerVersion");
        }

        /// <summary>
        /// This API is used to get the layer version details, including links used to download files in the layer.
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public GetLayerVersionResponse GetLayerVersionSync(GetLayerVersionRequest req)
        {
            return InternalRequestAsync<GetLayerVersionResponse>(req, "GetLayerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the provisioned concurrency details of a function or its specified version.
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public Task<GetProvisionedConcurrencyConfigResponse> GetProvisionedConcurrencyConfig(GetProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetProvisionedConcurrencyConfigResponse>(req, "GetProvisionedConcurrencyConfig");
        }

        /// <summary>
        /// This API is used to get the provisioned concurrency details of a function or its specified version.
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public GetProvisionedConcurrencyConfigResponse GetProvisionedConcurrencyConfigSync(GetProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetProvisionedConcurrencyConfigResponse>(req, "GetProvisionedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of a single function request.
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatusRequest"/></param>
        /// <returns><see cref="GetRequestStatusResponse"/></returns>
        public Task<GetRequestStatusResponse> GetRequestStatus(GetRequestStatusRequest req)
        {
            return InternalRequestAsync<GetRequestStatusResponse>(req, "GetRequestStatus");
        }

        /// <summary>
        /// This API is used to query the status of a single function request.
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatusRequest"/></param>
        /// <returns><see cref="GetRequestStatusResponse"/></returns>
        public GetRequestStatusResponse GetRequestStatusSync(GetRequestStatusRequest req)
        {
            return InternalRequestAsync<GetRequestStatusResponse>(req, "GetRequestStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the reserved quota details of a function. 
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public Task<GetReservedConcurrencyConfigResponse> GetReservedConcurrencyConfig(GetReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetReservedConcurrencyConfigResponse>(req, "GetReservedConcurrencyConfig");
        }

        /// <summary>
        /// This API is used to obtain the reserved quota details of a function. 
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public GetReservedConcurrencyConfigResponse GetReservedConcurrencyConfigSync(GetReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetReservedConcurrencyConfigResponse>(req, "GetReservedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to run a function.
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public Task<InvokeResponse> Invoke(InvokeRequest req)
        {
            return InternalRequestAsync<InvokeResponse>(req, "Invoke");
        }

        /// <summary>
        /// This API is used to run a function.
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public InvokeResponse InvokeSync(InvokeRequest req)
        {
            return InternalRequestAsync<InvokeResponse>(req, "Invoke")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to invoke functions synchronously.
        /// </summary>
        /// <param name="req"><see cref="InvokeFunctionRequest"/></param>
        /// <returns><see cref="InvokeFunctionResponse"/></returns>
        public Task<InvokeFunctionResponse> InvokeFunction(InvokeFunctionRequest req)
        {
            return InternalRequestAsync<InvokeFunctionResponse>(req, "InvokeFunction");
        }

        /// <summary>
        ///  This API is used to invoke functions synchronously.
        /// </summary>
        /// <param name="req"><see cref="InvokeFunctionRequest"/></param>
        /// <returns><see cref="InvokeFunctionResponse"/></returns>
        public InvokeFunctionResponse InvokeFunctionSync(InvokeFunctionRequest req)
        {
            return InternalRequestAsync<InvokeFunctionResponse>(req, "InvokeFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the list of all aliases under a function. You can filter them by the specific function version.
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public Task<ListAliasesResponse> ListAliases(ListAliasesRequest req)
        {
            return InternalRequestAsync<ListAliasesResponse>(req, "ListAliases");
        }

        /// <summary>
        /// This API is used to return the list of all aliases under a function. You can filter them by the specific function version.
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public ListAliasesResponse ListAliasesSync(ListAliasesRequest req)
        {
            return InternalRequestAsync<ListAliasesResponse>(req, "ListAliases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull the list of async function events.
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public Task<ListAsyncEventsResponse> ListAsyncEvents(ListAsyncEventsRequest req)
        {
            return InternalRequestAsync<ListAsyncEventsResponse>(req, "ListAsyncEvents");
        }

        /// <summary>
        /// This API is used to pull the list of async function events.
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public ListAsyncEventsResponse ListAsyncEventsSync(ListAsyncEventsRequest req)
        {
            return InternalRequestAsync<ListAsyncEventsResponse>(req, "ListAsyncEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return relevant function information based on the input query parameters.
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public Task<ListFunctionsResponse> ListFunctions(ListFunctionsRequest req)
        {
            return InternalRequestAsync<ListFunctionsResponse>(req, "ListFunctions");
        }

        /// <summary>
        /// This API is used to return relevant function information based on the input query parameters.
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public ListFunctionsResponse ListFunctionsSync(ListFunctionsRequest req)
        {
            return InternalRequestAsync<ListFunctionsResponse>(req, "ListFunctions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of all versions of a specified layer.
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public Task<ListLayerVersionsResponse> ListLayerVersions(ListLayerVersionsRequest req)
        {
            return InternalRequestAsync<ListLayerVersionsResponse>(req, "ListLayerVersions");
        }

        /// <summary>
        /// This API is used to get the information of all versions of a specified layer.
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public ListLayerVersionsResponse ListLayerVersionsSync(ListLayerVersionsRequest req)
        {
            return InternalRequestAsync<ListLayerVersionsResponse>(req, "ListLayerVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the list of all layers, including the information of the latest version of each layer. You can filter them by the compatible runtime.
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public Task<ListLayersResponse> ListLayers(ListLayersRequest req)
        {
            return InternalRequestAsync<ListLayersResponse>(req, "ListLayers");
        }

        /// <summary>
        /// This API is used to return the list of all layers, including the information of the latest version of each layer. You can filter them by the compatible runtime.
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public ListLayersResponse ListLayersSync(ListLayersRequest req)
        {
            return InternalRequestAsync<ListLayersResponse>(req, "ListLayers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display a namespace list.
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public Task<ListNamespacesResponse> ListNamespaces(ListNamespacesRequest req)
        {
            return InternalRequestAsync<ListNamespacesResponse>(req, "ListNamespaces");
        }

        /// <summary>
        /// This API is used to display a namespace list.
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public ListNamespacesResponse ListNamespacesSync(ListNamespacesRequest req)
        {
            return InternalRequestAsync<ListNamespacesResponse>(req, "ListNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the function trigger list.
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public Task<ListTriggersResponse> ListTriggers(ListTriggersRequest req)
        {
            return InternalRequestAsync<ListTriggersResponse>(req, "ListTriggers");
        }

        /// <summary>
        /// This API is used to get the function trigger list.
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public ListTriggersResponse ListTriggersSync(ListTriggersRequest req)
        {
            return InternalRequestAsync<ListTriggersResponse>(req, "ListTriggers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the function version based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public Task<ListVersionByFunctionResponse> ListVersionByFunction(ListVersionByFunctionRequest req)
        {
            return InternalRequestAsync<ListVersionByFunctionResponse>(req, "ListVersionByFunction");
        }

        /// <summary>
        /// This API is used to query the function version based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public ListVersionByFunctionResponse ListVersionByFunctionSync(ListVersionByFunctionRequest req)
        {
            return InternalRequestAsync<ListVersionByFunctionResponse>(req, "ListVersionByFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a version for a layer by using the given .zip file or COS object. Each time this API is called with the same layer name, a new version will be generated.
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public Task<PublishLayerVersionResponse> PublishLayerVersion(PublishLayerVersionRequest req)
        {
            return InternalRequestAsync<PublishLayerVersionResponse>(req, "PublishLayerVersion");
        }

        /// <summary>
        /// This API is used to create a version for a layer by using the given .zip file or COS object. Each time this API is called with the same layer name, a new version will be generated.
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public PublishLayerVersionResponse PublishLayerVersionSync(PublishLayerVersionRequest req)
        {
            return InternalRequestAsync<PublishLayerVersionResponse>(req, "PublishLayerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for users to release a new version of the function.
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public Task<PublishVersionResponse> PublishVersion(PublishVersionRequest req)
        {
            return InternalRequestAsync<PublishVersionResponse>(req, "PublishVersion");
        }

        /// <summary>
        /// This API is used for users to release a new version of the function.
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public PublishVersionResponse PublishVersionSync(PublishVersionRequest req)
        {
            return InternalRequestAsync<PublishVersionResponse>(req, "PublishVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the provisioned concurrency of a non-$LATEST version of a function.
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public Task<PutProvisionedConcurrencyConfigResponse> PutProvisionedConcurrencyConfig(PutProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutProvisionedConcurrencyConfigResponse>(req, "PutProvisionedConcurrencyConfig");
        }

        /// <summary>
        /// This API is used to set the provisioned concurrency of a non-$LATEST version of a function.
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public PutProvisionedConcurrencyConfigResponse PutProvisionedConcurrencyConfigSync(PutProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutProvisionedConcurrencyConfigResponse>(req, "PutProvisionedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the reserved quota of a function.
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public Task<PutReservedConcurrencyConfigResponse> PutReservedConcurrencyConfig(PutReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutReservedConcurrencyConfigResponse>(req, "PutReservedConcurrencyConfig");
        }

        /// <summary>
        /// This API is used to configure the reserved quota of a function.
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public PutReservedConcurrencyConfigResponse PutReservedConcurrencyConfigSync(PutReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutReservedConcurrencyConfigResponse>(req, "PutReservedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the account concurrency quota.
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public Task<PutTotalConcurrencyConfigResponse> PutTotalConcurrencyConfig(PutTotalConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutTotalConcurrencyConfigResponse>(req, "PutTotalConcurrencyConfig");
        }

        /// <summary>
        /// This API is used to modify the account concurrency quota.
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public PutTotalConcurrencyConfigResponse PutTotalConcurrencyConfigSync(PutTotalConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutTotalConcurrencyConfigResponse>(req, "PutTotalConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a running async function event.
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public Task<TerminateAsyncEventResponse> TerminateAsyncEvent(TerminateAsyncEventRequest req)
        {
            return InternalRequestAsync<TerminateAsyncEventResponse>(req, "TerminateAsyncEvent");
        }

        /// <summary>
        /// This API is used to terminate a running async function event.
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public TerminateAsyncEventResponse TerminateAsyncEventSync(TerminateAsyncEventRequest req)
        {
            return InternalRequestAsync<TerminateAsyncEventResponse>(req, "TerminateAsyncEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the configuration of an alias.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias");
        }

        /// <summary>
        /// This API is used to update the configuration of an alias.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the function code based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public Task<UpdateFunctionCodeResponse> UpdateFunctionCode(UpdateFunctionCodeRequest req)
        {
            return InternalRequestAsync<UpdateFunctionCodeResponse>(req, "UpdateFunctionCode");
        }

        /// <summary>
        /// This API is used to update the function code based on the input parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public UpdateFunctionCodeResponse UpdateFunctionCodeSync(UpdateFunctionCodeRequest req)
        {
            return InternalRequestAsync<UpdateFunctionCodeResponse>(req, "UpdateFunctionCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the async retry configuration of a function, including the number of retry attempts and message retention period.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="UpdateFunctionEventInvokeConfigResponse"/></returns>
        public Task<UpdateFunctionEventInvokeConfigResponse> UpdateFunctionEventInvokeConfig(UpdateFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<UpdateFunctionEventInvokeConfigResponse>(req, "UpdateFunctionEventInvokeConfig");
        }

        /// <summary>
        /// This API is used to update the async retry configuration of a function, including the number of retry attempts and message retention period.
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="UpdateFunctionEventInvokeConfigResponse"/></returns>
        public UpdateFunctionEventInvokeConfigResponse UpdateFunctionEventInvokeConfigSync(UpdateFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<UpdateFunctionEventInvokeConfigResponse>(req, "UpdateFunctionEventInvokeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a namespace.
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public Task<UpdateNamespaceResponse> UpdateNamespace(UpdateNamespaceRequest req)
        {
            return InternalRequestAsync<UpdateNamespaceResponse>(req, "UpdateNamespace");
        }

        /// <summary>
        /// This API is used to update a namespace.
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public UpdateNamespaceResponse UpdateNamespaceSync(UpdateNamespaceRequest req)
        {
            return InternalRequestAsync<UpdateNamespaceResponse>(req, "UpdateNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the trigger status.
        /// </summary>
        /// <param name="req"><see cref="UpdateTriggerStatusRequest"/></param>
        /// <returns><see cref="UpdateTriggerStatusResponse"/></returns>
        public Task<UpdateTriggerStatusResponse> UpdateTriggerStatus(UpdateTriggerStatusRequest req)
        {
            return InternalRequestAsync<UpdateTriggerStatusResponse>(req, "UpdateTriggerStatus");
        }

        /// <summary>
        /// This API is used to update the trigger status.
        /// </summary>
        /// <param name="req"><see cref="UpdateTriggerStatusRequest"/></param>
        /// <returns><see cref="UpdateTriggerStatusResponse"/></returns>
        public UpdateTriggerStatusResponse UpdateTriggerStatusSync(UpdateTriggerStatusRequest req)
        {
            return InternalRequestAsync<UpdateTriggerStatusResponse>(req, "UpdateTriggerStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
