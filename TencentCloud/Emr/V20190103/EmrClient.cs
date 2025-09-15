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

namespace TencentCloud.Emr.V20190103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Emr.V20190103.Models;

   public class EmrClient : AbstractClient{

       private const string endpoint = "emr.intl.tencentcloudapi.com";
       private const string version = "2019-01-03";
       private const string sdkVersion = "SDK_NET_3.0.1210";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EmrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EmrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add scaling rules by load and time.
        /// </summary>
        /// <param name="req"><see cref="AddMetricScaleStrategyRequest"/></param>
        /// <returns><see cref="AddMetricScaleStrategyResponse"/></returns>
        public Task<AddMetricScaleStrategyResponse> AddMetricScaleStrategy(AddMetricScaleStrategyRequest req)
        {
            return InternalRequestAsync<AddMetricScaleStrategyResponse>(req, "AddMetricScaleStrategy");
        }

        /// <summary>
        /// This API is used to add scaling rules by load and time.
        /// </summary>
        /// <param name="req"><see cref="AddMetricScaleStrategyRequest"/></param>
        /// <returns><see cref="AddMetricScaleStrategyResponse"/></returns>
        public AddMetricScaleStrategyResponse AddMetricScaleStrategySync(AddMetricScaleStrategyRequest req)
        {
            return InternalRequestAsync<AddMetricScaleStrategyResponse>(req, "AddMetricScaleStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add node specifications of the current cluster.
        /// </summary>
        /// <param name="req"><see cref="AddNodeResourceConfigRequest"/></param>
        /// <returns><see cref="AddNodeResourceConfigResponse"/></returns>
        public Task<AddNodeResourceConfigResponse> AddNodeResourceConfig(AddNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<AddNodeResourceConfigResponse>(req, "AddNodeResourceConfig");
        }

        /// <summary>
        /// This API is used to add node specifications of the current cluster.
        /// </summary>
        /// <param name="req"><see cref="AddNodeResourceConfigRequest"/></param>
        /// <returns><see cref="AddNodeResourceConfigResponse"/></returns>
        public AddNodeResourceConfigResponse AddNodeResourceConfigSync(AddNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<AddNodeResourceConfigResponse>(req, "AddNodeResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to add user lists (user management).
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public Task<AddUsersForUserManagerResponse> AddUsersForUserManager(AddUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<AddUsersForUserManagerResponse>(req, "AddUsersForUserManager");
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to add user lists (user management).
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public AddUsersForUserManagerResponse AddUsersForUserManagerSync(AddUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<AddUsersForUserManagerResponse>(req, "AddUsersForUserManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to mount cloud disks.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks");
        }

        /// <summary>
        /// This API is used to mount cloud disks.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to convert a monthly subscription cluster to a pay-as-you-go cluster (excluding cdb).
        /// </summary>
        /// <param name="req"><see cref="ConvertPreToPostClusterRequest"/></param>
        /// <returns><see cref="ConvertPreToPostClusterResponse"/></returns>
        public Task<ConvertPreToPostClusterResponse> ConvertPreToPostCluster(ConvertPreToPostClusterRequest req)
        {
            return InternalRequestAsync<ConvertPreToPostClusterResponse>(req, "ConvertPreToPostCluster");
        }

        /// <summary>
        /// This API is used to convert a monthly subscription cluster to a pay-as-you-go cluster (excluding cdb).
        /// </summary>
        /// <param name="req"><see cref="ConvertPreToPostClusterRequest"/></param>
        /// <returns><see cref="ConvertPreToPostClusterResponse"/></returns>
        public ConvertPreToPostClusterResponse ConvertPreToPostClusterSync(ConvertPreToPostClusterRequest req)
        {
            return InternalRequestAsync<ConvertPreToPostClusterResponse>(req, "ConvertPreToPostCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create user groups in batches under User Management.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupsSTDRequest"/></param>
        /// <returns><see cref="CreateGroupsSTDResponse"/></returns>
        public Task<CreateGroupsSTDResponse> CreateGroupsSTD(CreateGroupsSTDRequest req)
        {
            return InternalRequestAsync<CreateGroupsSTDResponse>(req, "CreateGroupsSTD");
        }

        /// <summary>
        /// This API is used to create user groups in batches under User Management.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupsSTDRequest"/></param>
        /// <returns><see cref="CreateGroupsSTDResponse"/></returns>
        public CreateGroupsSTDResponse CreateGroupsSTDSync(CreateGroupsSTDRequest req)
        {
            return InternalRequestAsync<CreateGroupsSTDResponse>(req, "CreateGroupsSTD")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Serverless HBase instance.- If the API call is successful, a Serverless HBase instance will be created. If the instance creation request is successful, the InstanceId of the created instance and the RequestID of the request will be returned.- This is an asynchronous API. The operation is not completed immediately when the API call returns. The instance operation result can be viewed by calling DescribeInstancesList to view the StatusDesc status of the current instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSLInstanceRequest"/></param>
        /// <returns><see cref="CreateSLInstanceResponse"/></returns>
        public Task<CreateSLInstanceResponse> CreateSLInstance(CreateSLInstanceRequest req)
        {
            return InternalRequestAsync<CreateSLInstanceResponse>(req, "CreateSLInstance");
        }

        /// <summary>
        /// This API is used to create a Serverless HBase instance.- If the API call is successful, a Serverless HBase instance will be created. If the instance creation request is successful, the InstanceId of the created instance and the RequestID of the request will be returned.- This is an asynchronous API. The operation is not completed immediately when the API call returns. The instance operation result can be viewed by calling DescribeInstancesList to view the StatusDesc status of the current instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSLInstanceRequest"/></param>
        /// <returns><see cref="CreateSLInstanceResponse"/></returns>
        public CreateSLInstanceResponse CreateSLInstanceSync(CreateSLInstanceRequest req)
        {
            return InternalRequestAsync<CreateSLInstanceResponse>(req, "CreateSLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete automatic scaling rules. Nodes scaled based on these rules are destroyed in the background.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScaleStrategyResponse"/></returns>
        public Task<DeleteAutoScaleStrategyResponse> DeleteAutoScaleStrategy(DeleteAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScaleStrategyResponse>(req, "DeleteAutoScaleStrategy");
        }

        /// <summary>
        /// This API is used to delete automatic scaling rules. Nodes scaled based on these rules are destroyed in the background.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScaleStrategyResponse"/></returns>
        public DeleteAutoScaleStrategyResponse DeleteAutoScaleStrategySync(DeleteAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScaleStrategyResponse>(req, "DeleteAutoScaleStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete user groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupsSTDRequest"/></param>
        /// <returns><see cref="DeleteGroupsSTDResponse"/></returns>
        public Task<DeleteGroupsSTDResponse> DeleteGroupsSTD(DeleteGroupsSTDRequest req)
        {
            return InternalRequestAsync<DeleteGroupsSTDResponse>(req, "DeleteGroupsSTD");
        }

        /// <summary>
        /// This API is used to delete user groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupsSTDRequest"/></param>
        /// <returns><see cref="DeleteGroupsSTDResponse"/></returns>
        public DeleteGroupsSTDResponse DeleteGroupsSTDSync(DeleteGroupsSTDRequest req)
        {
            return InternalRequestAsync<DeleteGroupsSTDResponse>(req, "DeleteGroupsSTD")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the node specifications of the current cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeResourceConfigRequest"/></param>
        /// <returns><see cref="DeleteNodeResourceConfigResponse"/></returns>
        public Task<DeleteNodeResourceConfigResponse> DeleteNodeResourceConfig(DeleteNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<DeleteNodeResourceConfigResponse>(req, "DeleteNodeResourceConfig");
        }

        /// <summary>
        /// This API is used to delete the node specifications of the current cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeResourceConfigRequest"/></param>
        /// <returns><see cref="DeleteNodeResourceConfigResponse"/></returns>
        public DeleteNodeResourceConfigResponse DeleteNodeResourceConfigSync(DeleteNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<DeleteNodeResourceConfigResponse>(req, "DeleteNodeResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bring the configuration into effect in YARN resource scheduling after deployment.
        /// </summary>
        /// <param name="req"><see cref="DeployYarnConfRequest"/></param>
        /// <returns><see cref="DeployYarnConfResponse"/></returns>
        public Task<DeployYarnConfResponse> DeployYarnConf(DeployYarnConfRequest req)
        {
            return InternalRequestAsync<DeployYarnConfResponse>(req, "DeployYarnConf");
        }

        /// <summary>
        /// This API is used to bring the configuration into effect in YARN resource scheduling after deployment.
        /// </summary>
        /// <param name="req"><see cref="DeployYarnConfRequest"/></param>
        /// <returns><see cref="DeployYarnConfResponse"/></returns>
        public DeployYarnConfResponse DeployYarnConfSync(DeployYarnConfRequest req)
        {
            return InternalRequestAsync<DeployYarnConfResponse>(req, "DeployYarnConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the global configuration of automatic scaling.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleGroupGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleGroupGlobalConfResponse"/></returns>
        public Task<DescribeAutoScaleGroupGlobalConfResponse> DescribeAutoScaleGroupGlobalConf(DescribeAutoScaleGroupGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleGroupGlobalConfResponse>(req, "DescribeAutoScaleGroupGlobalConf");
        }

        /// <summary>
        /// This API is used to access the global configuration of automatic scaling.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleGroupGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleGroupGlobalConfResponse"/></returns>
        public DescribeAutoScaleGroupGlobalConfResponse DescribeAutoScaleGroupGlobalConfSync(DescribeAutoScaleGroupGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleGroupGlobalConfResponse>(req, "DescribeAutoScaleGroupGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to inquiry detailed records of cluster autoscaling.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleRecordsRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleRecordsResponse"/></returns>
        public Task<DescribeAutoScaleRecordsResponse> DescribeAutoScaleRecords(DescribeAutoScaleRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleRecordsResponse>(req, "DescribeAutoScaleRecords");
        }

        /// <summary>
        /// This API is used to inquiry detailed records of cluster autoscaling.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleRecordsRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleRecordsResponse"/></returns>
        public DescribeAutoScaleRecordsResponse DescribeAutoScaleRecordsSync(DescribeAutoScaleRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleRecordsResponse>(req, "DescribeAutoScaleRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access automatic scaling rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleStrategiesResponse"/></returns>
        public Task<DescribeAutoScaleStrategiesResponse> DescribeAutoScaleStrategies(DescribeAutoScaleStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleStrategiesResponse>(req, "DescribeAutoScaleStrategies");
        }

        /// <summary>
        /// This API is used to access automatic scaling rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleStrategiesResponse"/></returns>
        public DescribeAutoScaleStrategiesResponse DescribeAutoScaleStrategiesSync(DescribeAutoScaleStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleStrategiesResponse>(req, "DescribeAutoScaleStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the EMR task running details status.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterFlowStatusDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterFlowStatusDetailResponse"/></returns>
        public Task<DescribeClusterFlowStatusDetailResponse> DescribeClusterFlowStatusDetail(DescribeClusterFlowStatusDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterFlowStatusDetailResponse>(req, "DescribeClusterFlowStatusDetail");
        }

        /// <summary>
        /// This API is used to query the EMR task running details status.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterFlowStatusDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterFlowStatusDetailResponse"/></returns>
        public DescribeClusterFlowStatusDetailResponse DescribeClusterFlowStatusDetailSync(DescribeClusterFlowStatusDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterFlowStatusDetailResponse>(req, "DescribeClusterFlowStatusDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public Task<DescribeClusterNodesResponse> DescribeClusterNodes(DescribeClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodesResponse>(req, "DescribeClusterNodes");
        }

        /// <summary>
        /// This API is used to query the information of nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public DescribeClusterNodesResponse DescribeClusterNodesSync(DescribeClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodesResponse>(req, "DescribeClusterNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DAG information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDAGInfoRequest"/></param>
        /// <returns><see cref="DescribeDAGInfoResponse"/></returns>
        public Task<DescribeDAGInfoResponse> DescribeDAGInfo(DescribeDAGInfoRequest req)
        {
            return InternalRequestAsync<DescribeDAGInfoResponse>(req, "DescribeDAGInfo");
        }

        /// <summary>
        /// This API is used to query DAG information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDAGInfoRequest"/></param>
        /// <returns><see cref="DescribeDAGInfoResponse"/></returns>
        public DescribeDAGInfoResponse DescribeDAGInfoSync(DescribeDAGInfoRequest req)
        {
            return InternalRequestAsync<DescribeDAGInfoResponse>(req, "DescribeDAGInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the YARN application statistics API.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public Task<DescribeEmrApplicationStaticsResponse> DescribeEmrApplicationStatics(DescribeEmrApplicationStaticsRequest req)
        {
            return InternalRequestAsync<DescribeEmrApplicationStaticsResponse>(req, "DescribeEmrApplicationStatics");
        }

        /// <summary>
        /// This API is used to query the YARN application statistics API.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public DescribeEmrApplicationStaticsResponse DescribeEmrApplicationStaticsSync(DescribeEmrApplicationStaticsRequest req)
        {
            return InternalRequestAsync<DescribeEmrApplicationStaticsResponse>(req, "DescribeEmrApplicationStatics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the metric data on the monitoring overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrOverviewMetricsRequest"/></param>
        /// <returns><see cref="DescribeEmrOverviewMetricsResponse"/></returns>
        public Task<DescribeEmrOverviewMetricsResponse> DescribeEmrOverviewMetrics(DescribeEmrOverviewMetricsRequest req)
        {
            return InternalRequestAsync<DescribeEmrOverviewMetricsResponse>(req, "DescribeEmrOverviewMetrics");
        }

        /// <summary>
        /// This API is used to query the metric data on the monitoring overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrOverviewMetricsRequest"/></param>
        /// <returns><see cref="DescribeEmrOverviewMetricsResponse"/></returns>
        public DescribeEmrOverviewMetricsResponse DescribeEmrOverviewMetricsSync(DescribeEmrOverviewMetricsRequest req)
        {
            return InternalRequestAsync<DescribeEmrOverviewMetricsResponse>(req, "DescribeEmrOverviewMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the global configurations of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribeGlobalConfigResponse"/></returns>
        public Task<DescribeGlobalConfigResponse> DescribeGlobalConfig(DescribeGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribeGlobalConfigResponse>(req, "DescribeGlobalConfig");
        }

        /// <summary>
        /// This API is used to query the global configurations of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribeGlobalConfigResponse"/></returns>
        public DescribeGlobalConfigResponse DescribeGlobalConfigSync(DescribeGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribeGlobalConfigResponse>(req, "DescribeGlobalConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a user group.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsSTDRequest"/></param>
        /// <returns><see cref="DescribeGroupsSTDResponse"/></returns>
        public Task<DescribeGroupsSTDResponse> DescribeGroupsSTD(DescribeGroupsSTDRequest req)
        {
            return InternalRequestAsync<DescribeGroupsSTDResponse>(req, "DescribeGroupsSTD");
        }

        /// <summary>
        /// This API is used to query a user group.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsSTDRequest"/></param>
        /// <returns><see cref="DescribeGroupsSTDResponse"/></returns>
        public DescribeGroupsSTDResponse DescribeGroupsSTDSync(DescribeGroupsSTDRequest req)
        {
            return InternalRequestAsync<DescribeGroupsSTDResponse>(req, "DescribeGroupsSTD")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the overview of HBase table-level monitoring data.
        /// </summary>
        /// <param name="req"><see cref="DescribeHBaseTableOverviewRequest"/></param>
        /// <returns><see cref="DescribeHBaseTableOverviewResponse"/></returns>
        public Task<DescribeHBaseTableOverviewResponse> DescribeHBaseTableOverview(DescribeHBaseTableOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHBaseTableOverviewResponse>(req, "DescribeHBaseTableOverview");
        }

        /// <summary>
        /// This API is used to access the overview of HBase table-level monitoring data.
        /// </summary>
        /// <param name="req"><see cref="DescribeHBaseTableOverviewRequest"/></param>
        /// <returns><see cref="DescribeHBaseTableOverviewResponse"/></returns>
        public DescribeHBaseTableOverviewResponse DescribeHBaseTableOverviewSync(DescribeHBaseTableOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHBaseTableOverviewResponse>(req, "DescribeHBaseTableOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information of file(s) stored in HDFS.
        /// </summary>
        /// <param name="req"><see cref="DescribeHDFSStorageInfoRequest"/></param>
        /// <returns><see cref="DescribeHDFSStorageInfoResponse"/></returns>
        public Task<DescribeHDFSStorageInfoResponse> DescribeHDFSStorageInfo(DescribeHDFSStorageInfoRequest req)
        {
            return InternalRequestAsync<DescribeHDFSStorageInfoResponse>(req, "DescribeHDFSStorageInfo");
        }

        /// <summary>
        /// This API is used to query information of file(s) stored in HDFS.
        /// </summary>
        /// <param name="req"><see cref="DescribeHDFSStorageInfoRequest"/></param>
        /// <returns><see cref="DescribeHDFSStorageInfoResponse"/></returns>
        public DescribeHDFSStorageInfoResponse DescribeHDFSStorageInfoSync(DescribeHDFSStorageInfoRequest req)
        {
            return InternalRequestAsync<DescribeHDFSStorageInfoResponse>(req, "DescribeHDFSStorageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to inquiry Hive query data.
        /// </summary>
        /// <param name="req"><see cref="DescribeHiveQueriesRequest"/></param>
        /// <returns><see cref="DescribeHiveQueriesResponse"/></returns>
        public Task<DescribeHiveQueriesResponse> DescribeHiveQueries(DescribeHiveQueriesRequest req)
        {
            return InternalRequestAsync<DescribeHiveQueriesResponse>(req, "DescribeHiveQueries");
        }

        /// <summary>
        /// This API is used to inquiry Hive query data.
        /// </summary>
        /// <param name="req"><see cref="DescribeHiveQueriesRequest"/></param>
        /// <returns><see cref="DescribeHiveQueriesResponse"/></returns>
        public DescribeHiveQueriesResponse DescribeHiveQueriesSync(DescribeHiveQueriesRequest req)
        {
            return InternalRequestAsync<DescribeHiveQueriesResponse>(req, "DescribeHiveQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain insight result information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInsightListRequest"/></param>
        /// <returns><see cref="DescribeInsightListResponse"/></returns>
        public Task<DescribeInsightListResponse> DescribeInsightList(DescribeInsightListRequest req)
        {
            return InternalRequestAsync<DescribeInsightListResponse>(req, "DescribeInsightList");
        }

        /// <summary>
        /// This API is used to obtain insight result information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInsightListRequest"/></param>
        /// <returns><see cref="DescribeInsightListResponse"/></returns>
        public DescribeInsightListResponse DescribeInsightListSync(DescribeInsightListRequest req)
        {
            return InternalRequestAsync<DescribeInsightListResponse>(req, "DescribeInsightList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the inspection task result list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInspectionTaskResultRequest"/></param>
        /// <returns><see cref="DescribeInspectionTaskResultResponse"/></returns>
        public Task<DescribeInspectionTaskResultResponse> DescribeInspectionTaskResult(DescribeInspectionTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeInspectionTaskResultResponse>(req, "DescribeInspectionTaskResult");
        }

        /// <summary>
        /// This API is used to obtain the inspection task result list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInspectionTaskResultRequest"/></param>
        /// <returns><see cref="DescribeInspectionTaskResultResponse"/></returns>
        public DescribeInspectionTaskResultResponse DescribeInspectionTaskResultSync(DescribeInspectionTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeInspectionTaskResultResponse>(req, "DescribeInspectionTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of instances in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query the information of instances in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public Task<DescribeInstancesListResponse> DescribeInstancesList(DescribeInstancesListRequest req)
        {
            return InternalRequestAsync<DescribeInstancesListResponse>(req, "DescribeInstancesList");
        }

        /// <summary>
        /// This API is used to query the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public DescribeInstancesListResponse DescribeInstancesListSync(DescribeInstancesListRequest req)
        {
            return InternalRequestAsync<DescribeInstancesListResponse>(req, "DescribeInstancesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Kyuubi query information.
        /// </summary>
        /// <param name="req"><see cref="DescribeKyuubiQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeKyuubiQueryInfoResponse"/></returns>
        public Task<DescribeKyuubiQueryInfoResponse> DescribeKyuubiQueryInfo(DescribeKyuubiQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeKyuubiQueryInfoResponse>(req, "DescribeKyuubiQueryInfo");
        }

        /// <summary>
        /// This API is used to query Kyuubi query information.
        /// </summary>
        /// <param name="req"><see cref="DescribeKyuubiQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeKyuubiQueryInfoResponse"/></returns>
        public DescribeKyuubiQueryInfoResponse DescribeKyuubiQueryInfoSync(DescribeKyuubiQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeKyuubiQueryInfoResponse>(req, "DescribeKyuubiQueryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query data disk information of nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeDataDisksRequest"/></param>
        /// <returns><see cref="DescribeNodeDataDisksResponse"/></returns>
        public Task<DescribeNodeDataDisksResponse> DescribeNodeDataDisks(DescribeNodeDataDisksRequest req)
        {
            return InternalRequestAsync<DescribeNodeDataDisksResponse>(req, "DescribeNodeDataDisks");
        }

        /// <summary>
        /// This API is used to query data disk information of nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeDataDisksRequest"/></param>
        /// <returns><see cref="DescribeNodeDataDisksResponse"/></returns>
        public DescribeNodeDataDisksResponse DescribeNodeDataDisksSync(DescribeNodeDataDisksRequest req)
        {
            return InternalRequestAsync<DescribeNodeDataDisksResponse>(req, "DescribeNodeDataDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to quickly obtain node specifications of the current cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeResourceConfigFastRequest"/></param>
        /// <returns><see cref="DescribeNodeResourceConfigFastResponse"/></returns>
        public Task<DescribeNodeResourceConfigFastResponse> DescribeNodeResourceConfigFast(DescribeNodeResourceConfigFastRequest req)
        {
            return InternalRequestAsync<DescribeNodeResourceConfigFastResponse>(req, "DescribeNodeResourceConfigFast");
        }

        /// <summary>
        /// This API is used to quickly obtain node specifications of the current cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeResourceConfigFastRequest"/></param>
        /// <returns><see cref="DescribeNodeResourceConfigFastResponse"/></returns>
        public DescribeNodeResourceConfigFastResponse DescribeNodeResourceConfigFastSync(DescribeNodeResourceConfigFastRequest req)
        {
            return InternalRequestAsync<DescribeNodeResourceConfigFastResponse>(req, "DescribeNodeResourceConfigFast")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query node specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeSpecRequest"/></param>
        /// <returns><see cref="DescribeNodeSpecResponse"/></returns>
        public Task<DescribeNodeSpecResponse> DescribeNodeSpec(DescribeNodeSpecRequest req)
        {
            return InternalRequestAsync<DescribeNodeSpecResponse>(req, "DescribeNodeSpec");
        }

        /// <summary>
        /// This API is used to query node specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeSpecRequest"/></param>
        /// <returns><see cref="DescribeNodeSpecResponse"/></returns>
        public DescribeNodeSpecResponse DescribeNodeSpecSync(DescribeNodeSpecRequest req)
        {
            return InternalRequestAsync<DescribeNodeSpecResponse>(req, "DescribeNodeSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query YARN resource scheduling information. It has been deprecated. You can use the DescribeYarnQueue API to query queue information.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public Task<DescribeResourceScheduleResponse> DescribeResourceSchedule(DescribeResourceScheduleRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleResponse>(req, "DescribeResourceSchedule");
        }

        /// <summary>
        /// This API is used to query YARN resource scheduling information. It has been deprecated. You can use the DescribeYarnQueue API to query queue information.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public DescribeResourceScheduleResponse DescribeResourceScheduleSync(DescribeResourceScheduleRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleResponse>(req, "DescribeResourceSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query change details in YARN resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleDiffDetailRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleDiffDetailResponse"/></returns>
        public Task<DescribeResourceScheduleDiffDetailResponse> DescribeResourceScheduleDiffDetail(DescribeResourceScheduleDiffDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleDiffDetailResponse>(req, "DescribeResourceScheduleDiffDetail");
        }

        /// <summary>
        /// This API is used to query change details in YARN resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleDiffDetailRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleDiffDetailResponse"/></returns>
        public DescribeResourceScheduleDiffDetailResponse DescribeResourceScheduleDiffDetailSync(DescribeResourceScheduleDiffDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleDiffDetailResponse>(req, "DescribeResourceScheduleDiffDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the basic information of Serverless HBase instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceResponse"/></returns>
        public Task<DescribeSLInstanceResponse> DescribeSLInstance(DescribeSLInstanceRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceResponse>(req, "DescribeSLInstance");
        }

        /// <summary>
        /// This API is used to query the basic information of Serverless HBase instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceResponse"/></returns>
        public DescribeSLInstanceResponse DescribeSLInstanceSync(DescribeSLInstanceRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceResponse>(req, "DescribeSLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the detailed information of the Serverless HBase instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceListResponse"/></returns>
        public Task<DescribeSLInstanceListResponse> DescribeSLInstanceList(DescribeSLInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceListResponse>(req, "DescribeSLInstanceList");
        }

        /// <summary>
        /// This API is used to query the detailed information of the Serverless HBase instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceListResponse"/></returns>
        public DescribeSLInstanceListResponse DescribeSLInstanceListSync(DescribeSLInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceListResponse>(req, "DescribeSLInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe service configuration group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceConfGroupInfosRequest"/></param>
        /// <returns><see cref="DescribeServiceConfGroupInfosResponse"/></returns>
        public Task<DescribeServiceConfGroupInfosResponse> DescribeServiceConfGroupInfos(DescribeServiceConfGroupInfosRequest req)
        {
            return InternalRequestAsync<DescribeServiceConfGroupInfosResponse>(req, "DescribeServiceConfGroupInfos");
        }

        /// <summary>
        /// This API is used to describe service configuration group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceConfGroupInfosRequest"/></param>
        /// <returns><see cref="DescribeServiceConfGroupInfosResponse"/></returns>
        public DescribeServiceConfGroupInfosResponse DescribeServiceConfGroupInfosSync(DescribeServiceConfGroupInfosRequest req)
        {
            return InternalRequestAsync<DescribeServiceConfGroupInfosResponse>(req, "DescribeServiceConfGroupInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query service process information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceNodeInfosRequest"/></param>
        /// <returns><see cref="DescribeServiceNodeInfosResponse"/></returns>
        public Task<DescribeServiceNodeInfosResponse> DescribeServiceNodeInfos(DescribeServiceNodeInfosRequest req)
        {
            return InternalRequestAsync<DescribeServiceNodeInfosResponse>(req, "DescribeServiceNodeInfos");
        }

        /// <summary>
        /// This API is used to query service process information.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceNodeInfosRequest"/></param>
        /// <returns><see cref="DescribeServiceNodeInfosResponse"/></returns>
        public DescribeServiceNodeInfosResponse DescribeServiceNodeInfosSync(DescribeServiceNodeInfosRequest req)
        {
            return InternalRequestAsync<DescribeServiceNodeInfosResponse>(req, "DescribeServiceNodeInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a Spark application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkApplicationsRequest"/></param>
        /// <returns><see cref="DescribeSparkApplicationsResponse"/></returns>
        public Task<DescribeSparkApplicationsResponse> DescribeSparkApplications(DescribeSparkApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeSparkApplicationsResponse>(req, "DescribeSparkApplications");
        }

        /// <summary>
        /// This API is used to obtain a Spark application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkApplicationsRequest"/></param>
        /// <returns><see cref="DescribeSparkApplicationsResponse"/></returns>
        public DescribeSparkApplicationsResponse DescribeSparkApplicationsSync(DescribeSparkApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeSparkApplicationsResponse>(req, "DescribeSparkApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Spark query information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkQueriesRequest"/></param>
        /// <returns><see cref="DescribeSparkQueriesResponse"/></returns>
        public Task<DescribeSparkQueriesResponse> DescribeSparkQueries(DescribeSparkQueriesRequest req)
        {
            return InternalRequestAsync<DescribeSparkQueriesResponse>(req, "DescribeSparkQueries");
        }

        /// <summary>
        /// This API is used to query the Spark query information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkQueriesRequest"/></param>
        /// <returns><see cref="DescribeSparkQueriesResponse"/></returns>
        public DescribeSparkQueriesResponse DescribeSparkQueriesSync(DescribeSparkQueriesRequest req)
        {
            return InternalRequestAsync<DescribeSparkQueriesResponse>(req, "DescribeSparkQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query StarRocks information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStarRocksQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeStarRocksQueryInfoResponse"/></returns>
        public Task<DescribeStarRocksQueryInfoResponse> DescribeStarRocksQueryInfo(DescribeStarRocksQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeStarRocksQueryInfoResponse>(req, "DescribeStarRocksQueryInfo");
        }

        /// <summary>
        /// This API is used to query StarRocks information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStarRocksQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeStarRocksQueryInfoResponse"/></returns>
        public DescribeStarRocksQueryInfoResponse DescribeStarRocksQueryInfoSync(DescribeStarRocksQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeStarRocksQueryInfoResponse>(req, "DescribeStarRocksQueryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Trino(PrestoSQL) query information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrinoQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeTrinoQueryInfoResponse"/></returns>
        public Task<DescribeTrinoQueryInfoResponse> DescribeTrinoQueryInfo(DescribeTrinoQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeTrinoQueryInfoResponse>(req, "DescribeTrinoQueryInfo");
        }

        /// <summary>
        /// This API is used to query Trino(PrestoSQL) query information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrinoQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeTrinoQueryInfoResponse"/></returns>
        public DescribeTrinoQueryInfoResponse DescribeTrinoQueryInfoSync(DescribeTrinoQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeTrinoQueryInfoResponse>(req, "DescribeTrinoQueryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to export users in batches. For a Kerberos cluster, set `NeedKeytabInfo` to `true` to obtain the download link of the Keytab file. If `SupportDownLoadKeyTab` is `true`, but `DownLoadKeyTabUrl` is null, the Keytab file is not ready yet (being generated) in the backend.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public Task<DescribeUsersForUserManagerResponse> DescribeUsersForUserManager(DescribeUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<DescribeUsersForUserManagerResponse>(req, "DescribeUsersForUserManager");
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to export users in batches. For a Kerberos cluster, set `NeedKeytabInfo` to `true` to obtain the download link of the Keytab file. If `SupportDownLoadKeyTab` is `true`, but `DownLoadKeyTabUrl` is null, the Keytab file is not ready yet (being generated) in the backend.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public DescribeUsersForUserManagerResponse DescribeUsersForUserManagerSync(DescribeUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<DescribeUsersForUserManagerResponse>(req, "DescribeUsersForUserManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain queue information in resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnQueueRequest"/></param>
        /// <returns><see cref="DescribeYarnQueueResponse"/></returns>
        public Task<DescribeYarnQueueResponse> DescribeYarnQueue(DescribeYarnQueueRequest req)
        {
            return InternalRequestAsync<DescribeYarnQueueResponse>(req, "DescribeYarnQueue");
        }

        /// <summary>
        /// This API is used to obtain queue information in resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnQueueRequest"/></param>
        /// <returns><see cref="DescribeYarnQueueResponse"/></returns>
        public DescribeYarnQueueResponse DescribeYarnQueueSync(DescribeYarnQueueRequest req)
        {
            return InternalRequestAsync<DescribeYarnQueueResponse>(req, "DescribeYarnQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the YARN resource scheduling history. It has been deprecated. You can use the Process Center to view the history records.
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnScheduleHistoryRequest"/></param>
        /// <returns><see cref="DescribeYarnScheduleHistoryResponse"/></returns>
        public Task<DescribeYarnScheduleHistoryResponse> DescribeYarnScheduleHistory(DescribeYarnScheduleHistoryRequest req)
        {
            return InternalRequestAsync<DescribeYarnScheduleHistoryResponse>(req, "DescribeYarnScheduleHistory");
        }

        /// <summary>
        /// This API is used to view the YARN resource scheduling history. It has been deprecated. You can use the Process Center to view the history records.
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnScheduleHistoryRequest"/></param>
        /// <returns><see cref="DescribeYarnScheduleHistoryResponse"/></returns>
        public DescribeYarnScheduleHistoryResponse DescribeYarnScheduleHistorySync(DescribeYarnScheduleHistoryRequest req)
        {
            return InternalRequestAsync<DescribeYarnScheduleHistoryResponse>(req, "DescribeYarnScheduleHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query price of instance creation.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance");
        }

        /// <summary>
        /// This API is used to query price of instance creation.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for renewal.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance");
        }

        /// <summary>
        /// This API is used to query the price for renewal.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public InquiryPriceRenewInstanceResponse InquiryPriceRenewInstanceSync(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query price of scale-out.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public Task<InquiryPriceScaleOutInstanceResponse> InquiryPriceScaleOutInstance(InquiryPriceScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceScaleOutInstanceResponse>(req, "InquiryPriceScaleOutInstance");
        }

        /// <summary>
        /// This API is used to query price of scale-out.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public InquiryPriceScaleOutInstanceResponse InquiryPriceScaleOutInstanceSync(InquiryPriceScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceScaleOutInstanceResponse>(req, "InquiryPriceScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query price of scaling.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public Task<InquiryPriceUpdateInstanceResponse> InquiryPriceUpdateInstance(InquiryPriceUpdateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpdateInstanceResponse>(req, "InquiryPriceUpdateInstance");
        }

        /// <summary>
        /// This API is used to query price of scaling.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public InquiryPriceUpdateInstanceResponse InquiryPriceUpdateInstanceSync(InquiryPriceUpdateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpdateInstanceResponse>(req, "InquiryPriceUpdateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to introduce the prerequisite prepaid clusters.
        /// This API is used to enable or disable automatic renewal at the resource level.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag");
        }

        /// <summary>
        /// This API is used to introduce the prerequisite prepaid clusters.
        /// This API is used to enable or disable automatic renewal at the resource level.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify automatic scaling rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScaleStrategyResponse"/></returns>
        public Task<ModifyAutoScaleStrategyResponse> ModifyAutoScaleStrategy(ModifyAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScaleStrategyResponse>(req, "ModifyAutoScaleStrategy");
        }

        /// <summary>
        /// This API is used to modify automatic scaling rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScaleStrategyResponse"/></returns>
        public ModifyAutoScaleStrategyResponse ModifyAutoScaleStrategySync(ModifyAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScaleStrategyResponse>(req, "ModifyAutoScaleStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the global configuration of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalConfigRequest"/></param>
        /// <returns><see cref="ModifyGlobalConfigResponse"/></returns>
        public Task<ModifyGlobalConfigResponse> ModifyGlobalConfig(ModifyGlobalConfigRequest req)
        {
            return InternalRequestAsync<ModifyGlobalConfigResponse>(req, "ModifyGlobalConfig");
        }

        /// <summary>
        /// This API is used to modify the global configuration of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalConfigRequest"/></param>
        /// <returns><see cref="ModifyGlobalConfigResponse"/></returns>
        public ModifyGlobalConfigResponse ModifyGlobalConfigSync(ModifyGlobalConfigRequest req)
        {
            return InternalRequestAsync<ModifyGlobalConfigResponse>(req, "ModifyGlobalConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set inspection task configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyInspectionSettingsRequest"/></param>
        /// <returns><see cref="ModifyInspectionSettingsResponse"/></returns>
        public Task<ModifyInspectionSettingsResponse> ModifyInspectionSettings(ModifyInspectionSettingsRequest req)
        {
            return InternalRequestAsync<ModifyInspectionSettingsResponse>(req, "ModifyInspectionSettings");
        }

        /// <summary>
        /// This API is used to set inspection task configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyInspectionSettingsRequest"/></param>
        /// <returns><see cref="ModifyInspectionSettingsResponse"/></returns>
        public ModifyInspectionSettingsResponse ModifyInspectionSettingsSync(ModifyInspectionSettingsRequest req)
        {
            return InternalRequestAsync<ModifyInspectionSettingsResponse>(req, "ModifyInspectionSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a cluster name.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceBasicRequest"/></param>
        /// <returns><see cref="ModifyInstanceBasicResponse"/></returns>
        public Task<ModifyInstanceBasicResponse> ModifyInstanceBasic(ModifyInstanceBasicRequest req)
        {
            return InternalRequestAsync<ModifyInstanceBasicResponse>(req, "ModifyInstanceBasic");
        }

        /// <summary>
        /// This API is used to modify a cluster name.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceBasicRequest"/></param>
        /// <returns><see cref="ModifyInstanceBasicResponse"/></returns>
        public ModifyInstanceBasicResponse ModifyInstanceBasicSync(ModifyInstanceBasicRequest req)
        {
            return InternalRequestAsync<ModifyInstanceBasicResponse>(req, "ModifyInstanceBasic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resize an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public Task<ModifyResourceResponse> ModifyResource(ModifyResourceRequest req)
        {
            return InternalRequestAsync<ModifyResourceResponse>(req, "ModifyResource");
        }

        /// <summary>
        /// This API is used to resize an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public ModifyResourceResponse ModifyResourceSync(ModifyResourceRequest req)
        {
            return InternalRequestAsync<ModifyResourceResponse>(req, "ModifyResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is deprecated. Use ModifyYarnQueueV2 to modify queue configuration. No related logs exist in the past one year.
        /// 
        /// This API is used to modify the resource configuration of YARN Resource Scheduling. It has been deprecated. Use the ModifyYarnQueueV2 API to modify the queue configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public Task<ModifyResourceScheduleConfigResponse> ModifyResourceScheduleConfig(ModifyResourceScheduleConfigRequest req)
        {
            return InternalRequestAsync<ModifyResourceScheduleConfigResponse>(req, "ModifyResourceScheduleConfig");
        }

        /// <summary>
        /// This API is deprecated. Use ModifyYarnQueueV2 to modify queue configuration. No related logs exist in the past one year.
        /// 
        /// This API is used to modify the resource configuration of YARN Resource Scheduling. It has been deprecated. Use the ModifyYarnQueueV2 API to modify the queue configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public ModifyResourceScheduleConfigResponse ModifyResourceScheduleConfigSync(ModifyResourceScheduleConfigRequest req)
        {
            return InternalRequestAsync<ModifyResourceScheduleConfigResponse>(req, "ModifyResourceScheduleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a YARN resource scheduler. After the modification, you can click Deploy to bring it into effect.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public Task<ModifyResourceSchedulerResponse> ModifyResourceScheduler(ModifyResourceSchedulerRequest req)
        {
            return InternalRequestAsync<ModifyResourceSchedulerResponse>(req, "ModifyResourceScheduler");
        }

        /// <summary>
        /// This API is used to modify a YARN resource scheduler. After the modification, you can click Deploy to bring it into effect.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public ModifyResourceSchedulerResponse ModifyResourceSchedulerSync(ModifyResourceSchedulerRequest req)
        {
            return InternalRequestAsync<ModifyResourceSchedulerResponse>(req, "ModifyResourceScheduler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to forcibly modify tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagsRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagsResponse"/></returns>
        public Task<ModifyResourcesTagsResponse> ModifyResourcesTags(ModifyResourcesTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagsResponse>(req, "ModifyResourcesTags");
        }

        /// <summary>
        /// This API is used to forcibly modify tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagsRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagsResponse"/></returns>
        public ModifyResourcesTagsResponse ModifyResourcesTagsSync(ModifyResourcesTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagsResponse>(req, "ModifyResourcesTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resize a Serverless HBase instance.- If the API call is successful, a Serverless HBase instance will be created. If the instance creation request is successful, the RequestID of the request will be returned.- This is an asynchronous API. The operation is not completed immediately when the API call returns. The instance operation result can be viewed by calling DescribeInstancesList to view the StatusDesc status of the current instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySLInstanceRequest"/></param>
        /// <returns><see cref="ModifySLInstanceResponse"/></returns>
        public Task<ModifySLInstanceResponse> ModifySLInstance(ModifySLInstanceRequest req)
        {
            return InternalRequestAsync<ModifySLInstanceResponse>(req, "ModifySLInstance");
        }

        /// <summary>
        /// This API is used to resize a Serverless HBase instance.- If the API call is successful, a Serverless HBase instance will be created. If the instance creation request is successful, the RequestID of the request will be returned.- This is an asynchronous API. The operation is not completed immediately when the API call returns. The instance operation result can be viewed by calling DescribeInstancesList to view the StatusDesc status of the current instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySLInstanceRequest"/></param>
        /// <returns><see cref="ModifySLInstanceResponse"/></returns>
        public ModifySLInstanceResponse ModifySLInstanceSync(ModifySLInstanceRequest req)
        {
            return InternalRequestAsync<ModifySLInstanceResponse>(req, "ModifySLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the Serverless HBase instance name.
        /// </summary>
        /// <param name="req"><see cref="ModifySLInstanceBasicRequest"/></param>
        /// <returns><see cref="ModifySLInstanceBasicResponse"/></returns>
        public Task<ModifySLInstanceBasicResponse> ModifySLInstanceBasic(ModifySLInstanceBasicRequest req)
        {
            return InternalRequestAsync<ModifySLInstanceBasicResponse>(req, "ModifySLInstanceBasic");
        }

        /// <summary>
        /// This API is used to modify the Serverless HBase instance name.
        /// </summary>
        /// <param name="req"><see cref="ModifySLInstanceBasicRequest"/></param>
        /// <returns><see cref="ModifySLInstanceBasicResponse"/></returns>
        public ModifySLInstanceBasicResponse ModifySLInstanceBasicSync(ModifySLInstanceBasicRequest req)
        {
            return InternalRequestAsync<ModifySLInstanceBasicResponse>(req, "ModifySLInstanceBasic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user groups under User Management.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserGroupRequest"/></param>
        /// <returns><see cref="ModifyUserGroupResponse"/></returns>
        public Task<ModifyUserGroupResponse> ModifyUserGroup(ModifyUserGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserGroupResponse>(req, "ModifyUserGroup");
        }

        /// <summary>
        /// This API is used to modify user groups under User Management.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserGroupRequest"/></param>
        /// <returns><see cref="ModifyUserGroupResponse"/></returns>
        public ModifyUserGroupResponse ModifyUserGroupSync(ModifyUserGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserGroupResponse>(req, "ModifyUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change user password (user management).
        /// </summary>
        /// <param name="req"><see cref="ModifyUserManagerPwdRequest"/></param>
        /// <returns><see cref="ModifyUserManagerPwdResponse"/></returns>
        public Task<ModifyUserManagerPwdResponse> ModifyUserManagerPwd(ModifyUserManagerPwdRequest req)
        {
            return InternalRequestAsync<ModifyUserManagerPwdResponse>(req, "ModifyUserManagerPwd");
        }

        /// <summary>
        /// This API is used to change user password (user management).
        /// </summary>
        /// <param name="req"><see cref="ModifyUserManagerPwdRequest"/></param>
        /// <returns><see cref="ModifyUserManagerPwdResponse"/></returns>
        public ModifyUserManagerPwdResponse ModifyUserManagerPwdSync(ModifyUserManagerPwdRequest req)
        {
            return InternalRequestAsync<ModifyUserManagerPwdResponse>(req, "ModifyUserManagerPwd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the user information of user groups.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsersOfGroupSTDRequest"/></param>
        /// <returns><see cref="ModifyUsersOfGroupSTDResponse"/></returns>
        public Task<ModifyUsersOfGroupSTDResponse> ModifyUsersOfGroupSTD(ModifyUsersOfGroupSTDRequest req)
        {
            return InternalRequestAsync<ModifyUsersOfGroupSTDResponse>(req, "ModifyUsersOfGroupSTD");
        }

        /// <summary>
        /// This API is used to change the user information of user groups.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsersOfGroupSTDRequest"/></param>
        /// <returns><see cref="ModifyUsersOfGroupSTDResponse"/></returns>
        public ModifyUsersOfGroupSTDResponse ModifyUsersOfGroupSTDSync(ModifyUsersOfGroupSTDRequest req)
        {
            return InternalRequestAsync<ModifyUsersOfGroupSTDResponse>(req, "ModifyUsersOfGroupSTD")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is deprecated. Use DeployYarnConf to bring configurations into effect after deployment.
        /// 
        /// This API is used to bring configurations into effect after deployment. It has been deprecated. Use the DeployYarnConf API to bring configurations into effect after deployment.
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnDeployRequest"/></param>
        /// <returns><see cref="ModifyYarnDeployResponse"/></returns>
        public Task<ModifyYarnDeployResponse> ModifyYarnDeploy(ModifyYarnDeployRequest req)
        {
            return InternalRequestAsync<ModifyYarnDeployResponse>(req, "ModifyYarnDeploy");
        }

        /// <summary>
        /// This API is deprecated. Use DeployYarnConf to bring configurations into effect after deployment.
        /// 
        /// This API is used to bring configurations into effect after deployment. It has been deprecated. Use the DeployYarnConf API to bring configurations into effect after deployment.
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnDeployRequest"/></param>
        /// <returns><see cref="ModifyYarnDeployResponse"/></returns>
        public ModifyYarnDeployResponse ModifyYarnDeploySync(ModifyYarnDeployRequest req)
        {
            return InternalRequestAsync<ModifyYarnDeployResponse>(req, "ModifyYarnDeploy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify queue information in resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnQueueV2Request"/></param>
        /// <returns><see cref="ModifyYarnQueueV2Response"/></returns>
        public Task<ModifyYarnQueueV2Response> ModifyYarnQueueV2(ModifyYarnQueueV2Request req)
        {
            return InternalRequestAsync<ModifyYarnQueueV2Response>(req, "ModifyYarnQueueV2");
        }

        /// <summary>
        /// This API is used to modify queue information in resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnQueueV2Request"/></param>
        /// <returns><see cref="ModifyYarnQueueV2Response"/></returns>
        public ModifyYarnQueueV2Response ModifyYarnQueueV2Sync(ModifyYarnQueueV2Request req)
        {
            return InternalRequestAsync<ModifyYarnQueueV2Response>(req, "ModifyYarnQueueV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the resource configuration of YARN resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="ResetYarnConfigRequest"/></param>
        /// <returns><see cref="ResetYarnConfigResponse"/></returns>
        public Task<ResetYarnConfigResponse> ResetYarnConfig(ResetYarnConfigRequest req)
        {
            return InternalRequestAsync<ResetYarnConfigResponse>(req, "ResetYarnConfig");
        }

        /// <summary>
        /// This API is used to modify the resource configuration of YARN resource scheduling.
        /// </summary>
        /// <param name="req"><see cref="ResetYarnConfigRequest"/></param>
        /// <returns><see cref="ResetYarnConfigResponse"/></returns>
        public ResetYarnConfigResponse ResetYarnConfigSync(ResetYarnConfigRequest req)
        {
            return InternalRequestAsync<ResetYarnConfigResponse>(req, "ResetYarnConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale out the cloud data disk.
        /// </summary>
        /// <param name="req"><see cref="ResizeDataDisksRequest"/></param>
        /// <returns><see cref="ResizeDataDisksResponse"/></returns>
        public Task<ResizeDataDisksResponse> ResizeDataDisks(ResizeDataDisksRequest req)
        {
            return InternalRequestAsync<ResizeDataDisksResponse>(req, "ResizeDataDisks");
        }

        /// <summary>
        /// This API is used to scale out the cloud data disk.
        /// </summary>
        /// <param name="req"><see cref="ResizeDataDisksRequest"/></param>
        /// <returns><see cref="ResizeDataDisksResponse"/></returns>
        public ResizeDataDisksResponse ResizeDataDisksSync(ResizeDataDisksRequest req)
        {
            return InternalRequestAsync<ResizeDataDisksResponse>(req, "ResizeDataDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale out a cluster.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterResponse"/></returns>
        public Task<ScaleOutClusterResponse> ScaleOutCluster(ScaleOutClusterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterResponse>(req, "ScaleOutCluster");
        }

        /// <summary>
        /// This API is used to scale out a cluster.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterResponse"/></returns>
        public ScaleOutClusterResponse ScaleOutClusterSync(ScaleOutClusterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterResponse>(req, "ScaleOutCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// This API is used to scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set specifications for a node in the current cluster to default or not.
        /// </summary>
        /// <param name="req"><see cref="SetNodeResourceConfigDefaultRequest"/></param>
        /// <returns><see cref="SetNodeResourceConfigDefaultResponse"/></returns>
        public Task<SetNodeResourceConfigDefaultResponse> SetNodeResourceConfigDefault(SetNodeResourceConfigDefaultRequest req)
        {
            return InternalRequestAsync<SetNodeResourceConfigDefaultResponse>(req, "SetNodeResourceConfigDefault");
        }

        /// <summary>
        /// This API is used to set specifications for a node in the current cluster to default or not.
        /// </summary>
        /// <param name="req"><see cref="SetNodeResourceConfigDefaultRequest"/></param>
        /// <returns><see cref="SetNodeResourceConfigDefaultResponse"/></returns>
        public SetNodeResourceConfigDefaultResponse SetNodeResourceConfigDefaultSync(SetNodeResourceConfigDefaultRequest req)
        {
            return InternalRequestAsync<SetNodeResourceConfigDefaultResponse>(req, "SetNodeResourceConfigDefault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start, stop, or restart services.
        /// </summary>
        /// <param name="req"><see cref="StartStopServiceOrMonitorRequest"/></param>
        /// <returns><see cref="StartStopServiceOrMonitorResponse"/></returns>
        public Task<StartStopServiceOrMonitorResponse> StartStopServiceOrMonitor(StartStopServiceOrMonitorRequest req)
        {
            return InternalRequestAsync<StartStopServiceOrMonitorResponse>(req, "StartStopServiceOrMonitor");
        }

        /// <summary>
        /// This API is used to start, stop, or restart services.
        /// </summary>
        /// <param name="req"><see cref="StartStopServiceOrMonitorRequest"/></param>
        /// <returns><see cref="StartStopServiceOrMonitorResponse"/></returns>
        public StartStopServiceOrMonitorResponse StartStopServiceOrMonitorSync(StartStopServiceOrMonitorRequest req)
        {
            return InternalRequestAsync<StartStopServiceOrMonitorResponse>(req, "StartStopServiceOrMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="TerminateClusterNodesRequest"/></param>
        /// <returns><see cref="TerminateClusterNodesResponse"/></returns>
        public Task<TerminateClusterNodesResponse> TerminateClusterNodes(TerminateClusterNodesRequest req)
        {
            return InternalRequestAsync<TerminateClusterNodesResponse>(req, "TerminateClusterNodes");
        }

        /// <summary>
        /// This API is used to terminate cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="TerminateClusterNodesRequest"/></param>
        /// <returns><see cref="TerminateClusterNodesResponse"/></returns>
        public TerminateClusterNodesResponse TerminateClusterNodesSync(TerminateClusterNodesRequest req)
        {
            return InternalRequestAsync<TerminateClusterNodesResponse>(req, "TerminateClusterNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate EMR instances. It is only supported in the official paid edition of EMR.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public Task<TerminateInstanceResponse> TerminateInstance(TerminateInstanceRequest req)
        {
            return InternalRequestAsync<TerminateInstanceResponse>(req, "TerminateInstance");
        }

        /// <summary>
        /// This API is used to terminate EMR instances. It is only supported in the official paid edition of EMR.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public TerminateInstanceResponse TerminateInstanceSync(TerminateInstanceRequest req)
        {
            return InternalRequestAsync<TerminateInstanceResponse>(req, "TerminateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a Serverless HBase instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateSLInstanceRequest"/></param>
        /// <returns><see cref="TerminateSLInstanceResponse"/></returns>
        public Task<TerminateSLInstanceResponse> TerminateSLInstance(TerminateSLInstanceRequest req)
        {
            return InternalRequestAsync<TerminateSLInstanceResponse>(req, "TerminateSLInstance");
        }

        /// <summary>
        /// This API is used to terminate a Serverless HBase instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateSLInstanceRequest"/></param>
        /// <returns><see cref="TerminateSLInstanceResponse"/></returns>
        public TerminateSLInstanceResponse TerminateSLInstanceSync(TerminateSLInstanceRequest req)
        {
            return InternalRequestAsync<TerminateSLInstanceResponse>(req, "TerminateSLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a task node.
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public Task<TerminateTasksResponse> TerminateTasks(TerminateTasksRequest req)
        {
            return InternalRequestAsync<TerminateTasksResponse>(req, "TerminateTasks");
        }

        /// <summary>
        /// This API is used to terminate a task node.
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public TerminateTasksResponse TerminateTasksSync(TerminateTasksRequest req)
        {
            return InternalRequestAsync<TerminateTasksResponse>(req, "TerminateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
