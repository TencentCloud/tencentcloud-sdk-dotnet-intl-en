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

namespace TencentCloud.Es.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Es.V20180416.Models;

   public class EsClient : AbstractClient{

       private const string endpoint = "es.tencentcloudapi.com";
       private const string version = "2018-04-16";
       private const string sdkVersion = "SDK_NET_3.0.970";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create indices.
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex");
        }

        /// <summary>
        /// This API is used to create indices.
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an ES cluster instance with the specified specification.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// This API is used to create an ES cluster instance with the specified specification.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete indices.
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex");
        }

        /// <summary>
        /// This API is used to delete indices.
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a cluster instance. 
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// This API is used to terminate a cluster instance. 
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the index list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public Task<DescribeIndexListResponse> DescribeIndexList(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList");
        }

        /// <summary>
        /// This API is used to obtain the index list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public DescribeIndexListResponse DescribeIndexListSync(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain index metadata.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public Task<DescribeIndexMetaResponse> DescribeIndexMeta(DescribeIndexMetaRequest req)
        {
            return InternalRequestAsync<DescribeIndexMetaResponse>(req, "DescribeIndexMeta");
        }

        /// <summary>
        /// This API is used to obtain index metadata.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public DescribeIndexMetaResponse DescribeIndexMetaSync(DescribeIndexMetaRequest req)
        {
            return InternalRequestAsync<DescribeIndexMetaResponse>(req, "DescribeIndexMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the eligible ES cluster logs in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs");
        }

        /// <summary>
        /// This API is used to query the eligible ES cluster logs in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the operation history of an instance by specified criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations");
        }

        /// <summary>
        /// This API is used to query the operation history of an instance by specified criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all eligible instances in the current region under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query all eligible instances in the current region under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query view data from three dimensions: cluster, node, and Kibana.
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public Task<DescribeViewsResponse> DescribeViews(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews");
        }

        /// <summary>
        /// This API is used to query view data from three dimensions: cluster, node, and Kibana.
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public DescribeViewsResponse DescribeViewsSync(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the node types used to receive client requests.
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public Task<GetRequestTargetNodeTypesResponse> GetRequestTargetNodeTypes(GetRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<GetRequestTargetNodeTypesResponse>(req, "GetRequestTargetNodeTypes");
        }

        /// <summary>
        /// This API is used to get the node types used to receive client requests.
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public GetRequestTargetNodeTypesResponse GetRequestTargetNodeTypesSync(GetRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<GetRequestTargetNodeTypesResponse>(req, "GetRequestTargetNodeTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart an ES cluster instance (for operations such as system update). 
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance");
        }

        /// <summary>
        /// This API is used to restart an ES cluster instance (for operations such as system update). 
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart Kibana. 
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public Task<RestartKibanaResponse> RestartKibana(RestartKibanaRequest req)
        {
            return InternalRequestAsync<RestartKibanaResponse>(req, "RestartKibana");
        }

        /// <summary>
        /// This API is used to restart Kibana. 
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public RestartKibanaResponse RestartKibanaSync(RestartKibanaRequest req)
        {
            return InternalRequestAsync<RestartKibanaResponse>(req, "RestartKibana")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public Task<RestartNodesResponse> RestartNodes(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes");
        }

        /// <summary>
        /// This API is used to restart cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public RestartNodesResponse RestartNodesSync(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update ES cluster dictionaries.
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public Task<UpdateDictionariesResponse> UpdateDictionaries(UpdateDictionariesRequest req)
        {
            return InternalRequestAsync<UpdateDictionariesResponse>(req, "UpdateDictionaries");
        }

        /// <summary>
        /// This API is used to update ES cluster dictionaries.
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public UpdateDictionariesResponse UpdateDictionariesSync(UpdateDictionariesRequest req)
        {
            return InternalRequestAsync<UpdateDictionariesResponse>(req, "UpdateDictionaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update indices.
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public Task<UpdateIndexResponse> UpdateIndex(UpdateIndexRequest req)
        {
            return InternalRequestAsync<UpdateIndexResponse>(req, "UpdateIndex");
        }

        /// <summary>
        /// This API is used to update indices.
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public UpdateIndexResponse UpdateIndexSync(UpdateIndexRequest req)
        {
            return InternalRequestAsync<UpdateIndexResponse>(req, "UpdateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for operations such as modifying node specification, renaming an instance, modifying configuration, resetting password, and setting Kibana blocklist/allowlist. `InstanceId` is required, while `ForceRestart` is optional. Other parameters or parameter combinations and their meanings are as follows:
        /// - InstanceName: renames an instance (only for instance identification)
        /// - NodeInfoList: modifies node configuration (horizontally scaling nodes, vertically scaling nodes, adding primary nodes, adding cold nodes, etc.)
        /// - EsConfig: modifies cluster configuration
        /// - Password: changes the password of the default user "elastic"
        /// - EsAcl: modifies the ACL
        /// - CosBackUp: sets auto-backup to COS for a cluster
        /// Only one of the parameters or parameter combinations above can be passed in at a time, while passing fewer or more ones will cause the request to fail.
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public Task<UpdateInstanceResponse> UpdateInstance(UpdateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateInstanceResponse>(req, "UpdateInstance");
        }

        /// <summary>
        /// This API is used for operations such as modifying node specification, renaming an instance, modifying configuration, resetting password, and setting Kibana blocklist/allowlist. `InstanceId` is required, while `ForceRestart` is optional. Other parameters or parameter combinations and their meanings are as follows:
        /// - InstanceName: renames an instance (only for instance identification)
        /// - NodeInfoList: modifies node configuration (horizontally scaling nodes, vertically scaling nodes, adding primary nodes, adding cold nodes, etc.)
        /// - EsConfig: modifies cluster configuration
        /// - Password: changes the password of the default user "elastic"
        /// - EsAcl: modifies the ACL
        /// - CosBackUp: sets auto-backup to COS for a cluster
        /// Only one of the parameters or parameter combinations above can be passed in at a time, while passing fewer or more ones will cause the request to fail.
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public UpdateInstanceResponse UpdateInstanceSync(UpdateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateInstanceResponse>(req, "UpdateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the list of plugins.
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public Task<UpdatePluginsResponse> UpdatePlugins(UpdatePluginsRequest req)
        {
            return InternalRequestAsync<UpdatePluginsResponse>(req, "UpdatePlugins");
        }

        /// <summary>
        /// This API is used to change the list of plugins.
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public UpdatePluginsResponse UpdatePluginsSync(UpdatePluginsRequest req)
        {
            return InternalRequestAsync<UpdatePluginsResponse>(req, "UpdatePlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the node types used to receive client requests.
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public Task<UpdateRequestTargetNodeTypesResponse> UpdateRequestTargetNodeTypes(UpdateRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<UpdateRequestTargetNodeTypesResponse>(req, "UpdateRequestTargetNodeTypes");
        }

        /// <summary>
        /// This API is used to update the node types used to receive client requests.
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public UpdateRequestTargetNodeTypesResponse UpdateRequestTargetNodeTypesSync(UpdateRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<UpdateRequestTargetNodeTypesResponse>(req, "UpdateRequestTargetNodeTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade ES cluster version
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// This API is used to upgrade ES cluster version
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade ES X-Pack.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public Task<UpgradeLicenseResponse> UpgradeLicense(UpgradeLicenseRequest req)
        {
            return InternalRequestAsync<UpgradeLicenseResponse>(req, "UpgradeLicense");
        }

        /// <summary>
        /// This API is used to upgrade ES X-Pack.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public UpgradeLicenseResponse UpgradeLicenseSync(UpgradeLicenseRequest req)
        {
            return InternalRequestAsync<UpgradeLicenseResponse>(req, "UpgradeLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
