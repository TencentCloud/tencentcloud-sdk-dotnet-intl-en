/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

       private const string endpoint = "es.intl.tencentcloudapi.com";
       private const string version = "2018-04-16";
       private const string sdkVersion = "SDK_NET_3.0.1409";

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
        /// This API is used to create an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="CreateAutoBackUpStrategyResponse"/></returns>
        public Task<CreateAutoBackUpStrategyResponse> CreateAutoBackUpStrategy(CreateAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<CreateAutoBackUpStrategyResponse>(req, "CreateAutoBackUpStrategy");
        }

        /// <summary>
        /// This API is used to create an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="CreateAutoBackUpStrategyResponse"/></returns>
        public CreateAutoBackUpStrategyResponse CreateAutoBackUpStrategySync(CreateAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<CreateAutoBackUpStrategyResponse>(req, "CreateAutoBackUpStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an index
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex");
        }

        /// <summary>
        /// Create an index
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an ES cluster instance with the specified specification.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// Create an ES cluster instance with the specified specification.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoBackUpStrategyResponse"/></returns>
        public Task<DeleteAutoBackUpStrategyResponse> DeleteAutoBackUpStrategy(DeleteAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoBackUpStrategyResponse>(req, "DeleteAutoBackUpStrategy");
        }

        /// <summary>
        /// This API is used to delete an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoBackUpStrategyResponse"/></returns>
        public DeleteAutoBackUpStrategyResponse DeleteAutoBackUpStrategySync(DeleteAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoBackUpStrategyResponse>(req, "DeleteAutoBackUpStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an index
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex");
        }

        /// <summary>
        /// Delete an index
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Terminate cluster instances
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// Terminate cluster instances
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="DescribeAutoBackUpStrategyResponse"/></returns>
        public Task<DescribeAutoBackUpStrategyResponse> DescribeAutoBackUpStrategy(DescribeAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackUpStrategyResponse>(req, "DescribeAutoBackUpStrategy");
        }

        /// <summary>
        /// This API is used to obtain an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="DescribeAutoBackUpStrategyResponse"/></returns>
        public DescribeAutoBackUpStrategyResponse DescribeAutoBackUpStrategySync(DescribeAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackUpStrategyResponse>(req, "DescribeAutoBackUpStrategy")
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
        /// This API is used to retrieve index metadata.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public Task<DescribeIndexMetaResponse> DescribeIndexMeta(DescribeIndexMetaRequest req)
        {
            return InternalRequestAsync<DescribeIndexMetaResponse>(req, "DescribeIndexMeta");
        }

        /// <summary>
        /// This API is used to retrieve index metadata.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public DescribeIndexMetaResponse DescribeIndexMetaSync(DescribeIndexMetaRequest req)
        {
            return InternalRequestAsync<DescribeIndexMetaResponse>(req, "DescribeIndexMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the logs of eligible ES clusters in that region for the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs");
        }

        /// <summary>
        /// Query the logs of eligible ES clusters in that region for the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the operation records of an instance under specified conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations");
        }

        /// <summary>
        /// Query the operation records of an instance under specified conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query all instances meeting conditions for the user in that region
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// Query all instances meeting conditions for the user in that region
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query view data of a cluster, including cluster-level, node, and Kibana dimensions.
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public Task<DescribeViewsResponse> DescribeViews(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews");
        }

        /// <summary>
        /// Query view data of a cluster, including cluster-level, node, and Kibana dimensions.
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public DescribeViewsResponse DescribeViewsSync(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the node type that receives client requests.
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public Task<GetRequestTargetNodeTypesResponse> GetRequestTargetNodeTypes(GetRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<GetRequestTargetNodeTypesResponse>(req, "GetRequestTargetNodeTypes");
        }

        /// <summary>
        /// Get the node type that receives client requests.
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public GetRequestTargetNodeTypesResponse GetRequestTargetNodeTypesSync(GetRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<GetRequestTargetNodeTypesResponse>(req, "GetRequestTargetNodeTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the common information of an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackUpCommonInfoRequest"/></param>
        /// <returns><see cref="ModifyAutoBackUpCommonInfoResponse"/></returns>
        public Task<ModifyAutoBackUpCommonInfoResponse> ModifyAutoBackUpCommonInfo(ModifyAutoBackUpCommonInfoRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackUpCommonInfoResponse>(req, "ModifyAutoBackUpCommonInfo");
        }

        /// <summary>
        /// This API is used to modify the common information of an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackUpCommonInfoRequest"/></param>
        /// <returns><see cref="ModifyAutoBackUpCommonInfoResponse"/></returns>
        public ModifyAutoBackUpCommonInfoResponse ModifyAutoBackUpCommonInfoSync(ModifyAutoBackUpCommonInfoRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackUpCommonInfoResponse>(req, "ModifyAutoBackUpCommonInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoBackUpStrategyResponse"/></returns>
        public Task<ModifyAutoBackUpStrategyResponse> ModifyAutoBackUpStrategy(ModifyAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackUpStrategyResponse>(req, "ModifyAutoBackUpStrategy");
        }

        /// <summary>
        /// This API is used to modify an auto backup snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackUpStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoBackUpStrategyResponse"/></returns>
        public ModifyAutoBackUpStrategyResponse ModifyAutoBackUpStrategySync(ModifyAutoBackUpStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackUpStrategyResponse>(req, "ModifyAutoBackUpStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Restart ES cluster instances for system version update.
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance");
        }

        /// <summary>
        /// Restart ES cluster instances for system version update.
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Restart Kibana
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public Task<RestartKibanaResponse> RestartKibana(RestartKibanaRequest req)
        {
            return InternalRequestAsync<RestartKibanaResponse>(req, "RestartKibana");
        }

        /// <summary>
        /// Restart Kibana
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public RestartKibanaResponse RestartKibanaSync(RestartKibanaRequest req)
        {
            return InternalRequestAsync<RestartKibanaResponse>(req, "RestartKibana")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to restart cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public Task<RestartNodesResponse> RestartNodes(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes");
        }

        /// <summary>
        /// Used to restart cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public RestartNodesResponse RestartNodesSync(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the ES cluster dictionary
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public Task<UpdateDictionariesResponse> UpdateDictionaries(UpdateDictionariesRequest req)
        {
            return InternalRequestAsync<UpdateDictionariesResponse>(req, "UpdateDictionaries");
        }

        /// <summary>
        /// Update the ES cluster dictionary
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public UpdateDictionariesResponse UpdateDictionariesSync(UpdateDictionariesRequest req)
        {
            return InternalRequestAsync<UpdateDictionariesResponse>(req, "UpdateDictionaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates an index
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public Task<UpdateIndexResponse> UpdateIndex(UpdateIndexRequest req)
        {
            return InternalRequestAsync<UpdateIndexResponse>(req, "UpdateIndex");
        }

        /// <summary>
        /// Updates an index
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public UpdateIndexResponse UpdateIndexSync(UpdateIndexRequest req)
        {
            return InternalRequestAsync<UpdateIndexResponse>(req, "UpdateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Perform operations on the cluster, such as node specification change, instance name modification, configuration modification, password resetting, and Kibana blocklist/allowlist addition. InstanceId is a required parameter, while ForceRestart is optional. The remaining parameter combinations and their meanings are as follows:
        /// - InstanceName: Modify the instance name (only used to identify the instance)
        /// -NodeInfoList: Modify node configuration (horizontally scale nodes, vertically scale nodes, add primary nodes, add cold nodes, etc.)
        /// -EsConfig: modify cluster configuration
        /// -Password: Modify the password of the default user elastic
        /// -EsAcl: Modify an ACL
        /// -CosBackUp: Set cluster COS auto backup information
        /// Only one of the above parameters can be passed. Passing more or fewer will cause request failure.
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public Task<UpdateInstanceResponse> UpdateInstance(UpdateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateInstanceResponse>(req, "UpdateInstance");
        }

        /// <summary>
        /// Perform operations on the cluster, such as node specification change, instance name modification, configuration modification, password resetting, and Kibana blocklist/allowlist addition. InstanceId is a required parameter, while ForceRestart is optional. The remaining parameter combinations and their meanings are as follows:
        /// - InstanceName: Modify the instance name (only used to identify the instance)
        /// -NodeInfoList: Modify node configuration (horizontally scale nodes, vertically scale nodes, add primary nodes, add cold nodes, etc.)
        /// -EsConfig: modify cluster configuration
        /// -Password: Modify the password of the default user elastic
        /// -EsAcl: Modify an ACL
        /// -CosBackUp: Set cluster COS auto backup information
        /// Only one of the above parameters can be passed. Passing more or fewer will cause request failure.
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public UpdateInstanceResponse UpdateInstanceSync(UpdateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateInstanceResponse>(req, "UpdateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the plug-in list
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public Task<UpdatePluginsResponse> UpdatePlugins(UpdatePluginsRequest req)
        {
            return InternalRequestAsync<UpdatePluginsResponse>(req, "UpdatePlugins");
        }

        /// <summary>
        /// Update the plug-in list
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public UpdatePluginsResponse UpdatePluginsSync(UpdatePluginsRequest req)
        {
            return InternalRequestAsync<UpdatePluginsResponse>(req, "UpdatePlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the node type that receives client requests.
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public Task<UpdateRequestTargetNodeTypesResponse> UpdateRequestTargetNodeTypes(UpdateRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<UpdateRequestTargetNodeTypesResponse>(req, "UpdateRequestTargetNodeTypes");
        }

        /// <summary>
        /// This API is used to update the node type that receives client requests.
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public UpdateRequestTargetNodeTypesResponse UpdateRequestTargetNodeTypesSync(UpdateRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<UpdateRequestTargetNodeTypesResponse>(req, "UpdateRequestTargetNodeTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Upgrades the edition of an ES cluster
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// Upgrades the edition of an ES cluster
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Upgrade ES commercial features
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public Task<UpgradeLicenseResponse> UpgradeLicense(UpgradeLicenseRequest req)
        {
            return InternalRequestAsync<UpgradeLicenseResponse>(req, "UpgradeLicense");
        }

        /// <summary>
        /// Upgrade ES commercial features
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
