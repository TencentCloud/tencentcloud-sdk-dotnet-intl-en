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

namespace TencentCloud.Tcaplusdb.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcaplusdb.V20190823.Models;

   public class TcaplusdbClient : AbstractClient{

       private const string endpoint = "tcaplusdb.tencentcloudapi.com";
       private const string version = "2019-08-23";
       private const string sdkVersion = "SDK_NET_3.0.1041";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcaplusdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcaplusdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to clear table data based on the specified table information.
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
        public Task<ClearTablesResponse> ClearTables(ClearTablesRequest req)
        {
            return InternalRequestAsync<ClearTablesResponse>(req, "ClearTables");
        }

        /// <summary>
        /// This API is used to clear table data based on the specified table information.
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
        public ClearTablesResponse ClearTablesSync(ClearTablesRequest req)
        {
            return InternalRequestAsync<ClearTablesResponse>(req, "ClearTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to select a target table, upload and verify the table modification file, and return the result of whether the table structure is allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
        public Task<CompareIdlFilesResponse> CompareIdlFiles(CompareIdlFilesRequest req)
        {
            return InternalRequestAsync<CompareIdlFilesResponse>(req, "CompareIdlFiles");
        }

        /// <summary>
        /// This API is used to select a target table, upload and verify the table modification file, and return the result of whether the table structure is allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
        public CompareIdlFilesResponse CompareIdlFilesSync(CompareIdlFilesRequest req)
        {
            return InternalRequestAsync<CompareIdlFilesResponse>(req, "CompareIdlFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a backup task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// This API is used to create a backup task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TcaplusDB cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// This API is used to create a TcaplusDB cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create one or more table snapshots at a specified past time point.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotsRequest"/></param>
        /// <returns><see cref="CreateSnapshotsResponse"/></returns>
        public Task<CreateSnapshotsResponse> CreateSnapshots(CreateSnapshotsRequest req)
        {
            return InternalRequestAsync<CreateSnapshotsResponse>(req, "CreateSnapshots");
        }

        /// <summary>
        /// This API is used to create one or more table snapshots at a specified past time point.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotsRequest"/></param>
        /// <returns><see cref="CreateSnapshotsResponse"/></returns>
        public CreateSnapshotsResponse CreateSnapshotsSync(CreateSnapshotsRequest req)
        {
            return InternalRequestAsync<CreateSnapshotsResponse>(req, "CreateSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a table group in a TcaplusDB cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public Task<CreateTableGroupResponse> CreateTableGroup(CreateTableGroupRequest req)
        {
            return InternalRequestAsync<CreateTableGroupResponse>(req, "CreateTableGroup");
        }

        /// <summary>
        /// This API is used to create a table group in a TcaplusDB cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public CreateTableGroupResponse CreateTableGroupSync(CreateTableGroupRequest req)
        {
            return InternalRequestAsync<CreateTableGroupResponse>(req, "CreateTableGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create tables in batches based on the selected IDL file list.
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
        public Task<CreateTablesResponse> CreateTables(CreateTablesRequest req)
        {
            return InternalRequestAsync<CreateTablesResponse>(req, "CreateTables");
        }

        /// <summary>
        /// This API is used to create tables in batches based on the selected IDL file list.
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
        public CreateTablesResponse CreateTablesSync(CreateTablesRequest req)
        {
            return InternalRequestAsync<CreateTablesResponse>(req, "CreateTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a manual backup.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRecordsRequest"/></param>
        /// <returns><see cref="DeleteBackupRecordsResponse"/></returns>
        public Task<DeleteBackupRecordsResponse> DeleteBackupRecords(DeleteBackupRecordsRequest req)
        {
            return InternalRequestAsync<DeleteBackupRecordsResponse>(req, "DeleteBackupRecords");
        }

        /// <summary>
        /// This API is used to delete a manual backup.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRecordsRequest"/></param>
        /// <returns><see cref="DeleteBackupRecordsResponse"/></returns>
        public DeleteBackupRecordsResponse DeleteBackupRecordsSync(DeleteBackupRecordsRequest req)
        {
            return InternalRequestAsync<DeleteBackupRecordsResponse>(req, "DeleteBackupRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TcaplusDB cluster, which will succeed only after all resources (including table groups and tables) in the cluster are released.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// This API is used to delete a TcaplusDB cluster, which will succeed only after all resources (including table groups and tables) in the cluster are released.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a target IDL file by specifying the cluster ID and information of the file to be deleted. If the file is associated with a table, deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
        public Task<DeleteIdlFilesResponse> DeleteIdlFiles(DeleteIdlFilesRequest req)
        {
            return InternalRequestAsync<DeleteIdlFilesResponse>(req, "DeleteIdlFiles");
        }

        /// <summary>
        /// This API is used to delete a target IDL file by specifying the cluster ID and information of the file to be deleted. If the file is associated with a table, deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
        public DeleteIdlFilesResponse DeleteIdlFilesSync(DeleteIdlFilesRequest req)
        {
            return InternalRequestAsync<DeleteIdlFilesResponse>(req, "DeleteIdlFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more table snapshots.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots");
        }

        /// <summary>
        /// This API is used to delete one or more table snapshots.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable data subscription for tables.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableDataFlowRequest"/></param>
        /// <returns><see cref="DeleteTableDataFlowResponse"/></returns>
        public Task<DeleteTableDataFlowResponse> DeleteTableDataFlow(DeleteTableDataFlowRequest req)
        {
            return InternalRequestAsync<DeleteTableDataFlowResponse>(req, "DeleteTableDataFlow");
        }

        /// <summary>
        /// This API is used to disable data subscription for tables.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableDataFlowRequest"/></param>
        /// <returns><see cref="DeleteTableDataFlowResponse"/></returns>
        public DeleteTableDataFlowResponse DeleteTableDataFlowSync(DeleteTableDataFlowRequest req)
        {
            return InternalRequestAsync<DeleteTableDataFlowResponse>(req, "DeleteTableDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a table group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public Task<DeleteTableGroupResponse> DeleteTableGroup(DeleteTableGroupRequest req)
        {
            return InternalRequestAsync<DeleteTableGroupResponse>(req, "DeleteTableGroup");
        }

        /// <summary>
        /// This API is used to delete a table group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public DeleteTableGroupResponse DeleteTableGroupSync(DeleteTableGroupRequest req)
        {
            return InternalRequestAsync<DeleteTableGroupResponse>(req, "DeleteTableGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the global index from a table.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableIndexRequest"/></param>
        /// <returns><see cref="DeleteTableIndexResponse"/></returns>
        public Task<DeleteTableIndexResponse> DeleteTableIndex(DeleteTableIndexRequest req)
        {
            return InternalRequestAsync<DeleteTableIndexResponse>(req, "DeleteTableIndex");
        }

        /// <summary>
        /// This API is used to delete the global index from a table.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableIndexRequest"/></param>
        /// <returns><see cref="DeleteTableIndexResponse"/></returns>
        public DeleteTableIndexResponse DeleteTableIndexSync(DeleteTableIndexRequest req)
        {
            return InternalRequestAsync<DeleteTableIndexResponse>(req, "DeleteTableIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to drop a specified table. Calling this API for the first time means to move the table to the recycle bin, while calling it again means to drop the table completely from the recycle bin.
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
        public Task<DeleteTablesResponse> DeleteTables(DeleteTablesRequest req)
        {
            return InternalRequestAsync<DeleteTablesResponse>(req, "DeleteTables");
        }

        /// <summary>
        /// This API is used to drop a specified table. Calling this API for the first time means to move the table to the recycle bin, while calling it again means to drop the table completely from the recycle bin.
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
        public DeleteTablesResponse DeleteTablesSync(DeleteTablesRequest req)
        {
            return InternalRequestAsync<DeleteTablesResponse>(req, "DeleteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query backup records.
        /// 
        /// When querying the cluster level, set `TableGroupId` to `-1` and `TableName` to `-1`.
        /// When querying the cluster and table group levels, set `TableName` to `-1`.
        /// When querying the cluster, table group, and table levels, both `TableGroupId` and `TableName` cannot be set to `-1`.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRecordsRequest"/></param>
        /// <returns><see cref="DescribeBackupRecordsResponse"/></returns>
        public Task<DescribeBackupRecordsResponse> DescribeBackupRecords(DescribeBackupRecordsRequest req)
        {
            return InternalRequestAsync<DescribeBackupRecordsResponse>(req, "DescribeBackupRecords");
        }

        /// <summary>
        /// This API is used to query backup records.
        /// 
        /// When querying the cluster level, set `TableGroupId` to `-1` and `TableName` to `-1`.
        /// When querying the cluster and table group levels, set `TableName` to `-1`.
        /// When querying the cluster, table group, and table levels, both `TableGroupId` and `TableName` cannot be set to `-1`.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRecordsRequest"/></param>
        /// <returns><see cref="DescribeBackupRecordsResponse"/></returns>
        public DescribeBackupRecordsResponse DescribeBackupRecordsSync(DescribeBackupRecordsRequest req)
        {
            return InternalRequestAsync<DescribeBackupRecordsResponse>(req, "DescribeBackupRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the associated tag list of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTagsRequest"/></param>
        /// <returns><see cref="DescribeClusterTagsResponse"/></returns>
        public Task<DescribeClusterTagsResponse> DescribeClusterTags(DescribeClusterTagsRequest req)
        {
            return InternalRequestAsync<DescribeClusterTagsResponse>(req, "DescribeClusterTags");
        }

        /// <summary>
        /// This API is used to get the associated tag list of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTagsRequest"/></param>
        /// <returns><see cref="DescribeClusterTagsResponse"/></returns>
        public DescribeClusterTagsResponse DescribeClusterTagsSync(DescribeClusterTagsRequest req)
        {
            return InternalRequestAsync<DescribeClusterTagsResponse>(req, "DescribeClusterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the TcaplusDB cluster list, including cluster details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// This API is used to query the TcaplusDB cluster list, including cluster details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query table description file details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
        public Task<DescribeIdlFileInfosResponse> DescribeIdlFileInfos(DescribeIdlFileInfosRequest req)
        {
            return InternalRequestAsync<DescribeIdlFileInfosResponse>(req, "DescribeIdlFileInfos");
        }

        /// <summary>
        /// This API is used to query table description file details.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
        public DescribeIdlFileInfosResponse DescribeIdlFileInfosSync(DescribeIdlFileInfosRequest req)
        {
            return InternalRequestAsync<DescribeIdlFileInfosResponse>(req, "DescribeIdlFileInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the available machines in a dedicated cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRequest"/></param>
        /// <returns><see cref="DescribeMachineResponse"/></returns>
        public Task<DescribeMachineResponse> DescribeMachine(DescribeMachineRequest req)
        {
            return InternalRequestAsync<DescribeMachineResponse>(req, "DescribeMachine");
        }

        /// <summary>
        /// This API is used to query the available machines in a dedicated cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRequest"/></param>
        /// <returns><see cref="DescribeMachineResponse"/></returns>
        public DescribeMachineResponse DescribeMachineSync(DescribeMachineRequest req)
        {
            return InternalRequestAsync<DescribeMachineResponse>(req, "DescribeMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of regions supported by the TcaplusDB service.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is used to query the list of regions supported by the TcaplusDB service.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of table snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
        }

        /// <summary>
        /// This API is used to query the list of table snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the associated tag list of a table group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupTagsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupTagsResponse"/></returns>
        public Task<DescribeTableGroupTagsResponse> DescribeTableGroupTags(DescribeTableGroupTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupTagsResponse>(req, "DescribeTableGroupTags");
        }

        /// <summary>
        /// This API is used to get the associated tag list of a table group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupTagsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupTagsResponse"/></returns>
        public DescribeTableGroupTagsResponse DescribeTableGroupTagsSync(DescribeTableGroupTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupTagsResponse>(req, "DescribeTableGroupTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the table group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public Task<DescribeTableGroupsResponse> DescribeTableGroups(DescribeTableGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupsResponse>(req, "DescribeTableGroups");
        }

        /// <summary>
        /// This API is used to query the table group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public DescribeTableGroupsResponse DescribeTableGroupsSync(DescribeTableGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupsResponse>(req, "DescribeTableGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get table tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableTagsRequest"/></param>
        /// <returns><see cref="DescribeTableTagsResponse"/></returns>
        public Task<DescribeTableTagsResponse> DescribeTableTags(DescribeTableTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableTagsResponse>(req, "DescribeTableTags");
        }

        /// <summary>
        /// This API is used to get table tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableTagsRequest"/></param>
        /// <returns><see cref="DescribeTableTagsResponse"/></returns>
        public DescribeTableTagsResponse DescribeTableTagsSync(DescribeTableTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableTagsResponse>(req, "DescribeTableTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query table details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// This API is used to query table details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a table in recycle bin.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
        public Task<DescribeTablesInRecycleResponse> DescribeTablesInRecycle(DescribeTablesInRecycleRequest req)
        {
            return InternalRequestAsync<DescribeTablesInRecycleResponse>(req, "DescribeTablesInRecycle");
        }

        /// <summary>
        /// This API is used to query the details of a table in recycle bin.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
        public DescribeTablesInRecycleResponse DescribeTablesInRecycleSync(DescribeTablesInRecycleRequest req)
        {
            return InternalRequestAsync<DescribeTablesInRecycleResponse>(req, "DescribeTablesInRecycle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query whether the current user is in the allowlist and control whether the user can create TDR-type apps or tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
        public Task<DescribeUinInWhitelistResponse> DescribeUinInWhitelist(DescribeUinInWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeUinInWhitelistResponse>(req, "DescribeUinInWhitelist");
        }

        /// <summary>
        /// This API is used to query whether the current user is in the allowlist and control whether the user can create TDR-type apps or tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
        public DescribeUinInWhitelistResponse DescribeUinInWhitelistSync(DescribeUinInWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeUinInWhitelistResponse>(req, "DescribeUinInWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the RESTful API.
        /// </summary>
        /// <param name="req"><see cref="DisableRestProxyRequest"/></param>
        /// <returns><see cref="DisableRestProxyResponse"/></returns>
        public Task<DisableRestProxyResponse> DisableRestProxy(DisableRestProxyRequest req)
        {
            return InternalRequestAsync<DisableRestProxyResponse>(req, "DisableRestProxy");
        }

        /// <summary>
        /// This API is used to disable the RESTful API.
        /// </summary>
        /// <param name="req"><see cref="DisableRestProxyRequest"/></param>
        /// <returns><see cref="DisableRestProxyResponse"/></returns>
        public DisableRestProxyResponse DisableRestProxySync(DisableRestProxyRequest req)
        {
            return InternalRequestAsync<DisableRestProxyResponse>(req, "DisableRestProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the RESTful API.
        /// </summary>
        /// <param name="req"><see cref="EnableRestProxyRequest"/></param>
        /// <returns><see cref="EnableRestProxyResponse"/></returns>
        public Task<EnableRestProxyResponse> EnableRestProxy(EnableRestProxyRequest req)
        {
            return InternalRequestAsync<EnableRestProxyResponse>(req, "EnableRestProxy");
        }

        /// <summary>
        /// This API is used to enable the RESTful API.
        /// </summary>
        /// <param name="req"><see cref="EnableRestProxyRequest"/></param>
        /// <returns><see cref="EnableRestProxyResponse"/></returns>
        public EnableRestProxyResponse EnableRestProxySync(EnableRestProxyRequest req)
        {
            return InternalRequestAsync<EnableRestProxyResponse>(req, "EnableRestProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import a snapshot into a new table or the original table from which the snapshot was created.
        /// </summary>
        /// <param name="req"><see cref="ImportSnapshotsRequest"/></param>
        /// <returns><see cref="ImportSnapshotsResponse"/></returns>
        public Task<ImportSnapshotsResponse> ImportSnapshots(ImportSnapshotsRequest req)
        {
            return InternalRequestAsync<ImportSnapshotsResponse>(req, "ImportSnapshots");
        }

        /// <summary>
        /// This API is used to import a snapshot into a new table or the original table from which the snapshot was created.
        /// </summary>
        /// <param name="req"><see cref="ImportSnapshotsRequest"/></param>
        /// <returns><see cref="ImportSnapshotsResponse"/></returns>
        public ImportSnapshotsResponse ImportSnapshotsSync(ImportSnapshotsRequest req)
        {
            return InternalRequestAsync<ImportSnapshotsResponse>(req, "ImportSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to merge tables.
        /// </summary>
        /// <param name="req"><see cref="MergeTablesDataRequest"/></param>
        /// <returns><see cref="MergeTablesDataResponse"/></returns>
        public Task<MergeTablesDataResponse> MergeTablesData(MergeTablesDataRequest req)
        {
            return InternalRequestAsync<MergeTablesDataResponse>(req, "MergeTablesData");
        }

        /// <summary>
        /// This API is used to merge tables.
        /// </summary>
        /// <param name="req"><see cref="MergeTablesDataRequest"/></param>
        /// <returns><see cref="MergeTablesDataResponse"/></returns>
        public MergeTablesDataResponse MergeTablesDataSync(MergeTablesDataRequest req)
        {
            return InternalRequestAsync<MergeTablesDataResponse>(req, "MergeTablesData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable the cluster operation approval feature.
        /// </summary>
        /// <param name="req"><see cref="ModifyCensorshipRequest"/></param>
        /// <returns><see cref="ModifyCensorshipResponse"/></returns>
        public Task<ModifyCensorshipResponse> ModifyCensorship(ModifyCensorshipRequest req)
        {
            return InternalRequestAsync<ModifyCensorshipResponse>(req, "ModifyCensorship");
        }

        /// <summary>
        /// This API is used to enable or disable the cluster operation approval feature.
        /// </summary>
        /// <param name="req"><see cref="ModifyCensorshipRequest"/></param>
        /// <returns><see cref="ModifyCensorshipResponse"/></returns>
        public ModifyCensorshipResponse ModifyCensorshipSync(ModifyCensorshipRequest req)
        {
            return InternalRequestAsync<ModifyCensorshipResponse>(req, "ModifyCensorship")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the machines of a dedicated cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public Task<ModifyClusterMachineResponse> ModifyClusterMachine(ModifyClusterMachineRequest req)
        {
            return InternalRequestAsync<ModifyClusterMachineResponse>(req, "ModifyClusterMachine");
        }

        /// <summary>
        /// This API is used to modify the machines of a dedicated cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public ModifyClusterMachineResponse ModifyClusterMachineSync(ModifyClusterMachineRequest req)
        {
            return InternalRequestAsync<ModifyClusterMachineResponse>(req, "ModifyClusterMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName");
        }

        /// <summary>
        /// This API is used to rename a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the password of a specified cluster. The backend will allow the TcaplusDB SDK to access databases with both old and new passwords before the old password expires. You cannot submit a new password change request before the old password expires or submit a request to modify the expiration time of the old password after the old password expires.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public Task<ModifyClusterPasswordResponse> ModifyClusterPassword(ModifyClusterPasswordRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordResponse>(req, "ModifyClusterPassword");
        }

        /// <summary>
        /// This API is used to change the password of a specified cluster. The backend will allow the TcaplusDB SDK to access databases with both old and new passwords before the old password expires. You cannot submit a new password change request before the old password expires or submit a request to modify the expiration time of the old password after the old password expires.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public ModifyClusterPasswordResponse ModifyClusterPasswordSync(ModifyClusterPasswordRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordResponse>(req, "ModifyClusterPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public Task<ModifyClusterTagsResponse> ModifyClusterTags(ModifyClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyClusterTagsResponse>(req, "ModifyClusterTags");
        }

        /// <summary>
        /// This API is used to modify cluster tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public ModifyClusterTagsResponse ModifyClusterTagsSync(ModifyClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyClusterTagsResponse>(req, "ModifyClusterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the expiration time of one or more table snapshots.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotsRequest"/></param>
        /// <returns><see cref="ModifySnapshotsResponse"/></returns>
        public Task<ModifySnapshotsResponse> ModifySnapshots(ModifySnapshotsRequest req)
        {
            return InternalRequestAsync<ModifySnapshotsResponse>(req, "ModifySnapshots");
        }

        /// <summary>
        /// This API is used to modify the expiration time of one or more table snapshots.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotsRequest"/></param>
        /// <returns><see cref="ModifySnapshotsResponse"/></returns>
        public ModifySnapshotsResponse ModifySnapshotsSync(ModifySnapshotsRequest req)
        {
            return InternalRequestAsync<ModifySnapshotsResponse>(req, "ModifySnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a TcaplusDB table group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public Task<ModifyTableGroupNameResponse> ModifyTableGroupName(ModifyTableGroupNameRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupNameResponse>(req, "ModifyTableGroupName");
        }

        /// <summary>
        /// This API is used to rename a TcaplusDB table group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public ModifyTableGroupNameResponse ModifyTableGroupNameSync(ModifyTableGroupNameRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupNameResponse>(req, "ModifyTableGroupName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify table group tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupTagsRequest"/></param>
        /// <returns><see cref="ModifyTableGroupTagsResponse"/></returns>
        public Task<ModifyTableGroupTagsResponse> ModifyTableGroupTags(ModifyTableGroupTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupTagsResponse>(req, "ModifyTableGroupTags");
        }

        /// <summary>
        /// This API is used to modify table group tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupTagsRequest"/></param>
        /// <returns><see cref="ModifyTableGroupTagsResponse"/></returns>
        public ModifyTableGroupTagsResponse ModifyTableGroupTagsSync(ModifyTableGroupTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupTagsResponse>(req, "ModifyTableGroupTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify table remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
        public Task<ModifyTableMemosResponse> ModifyTableMemos(ModifyTableMemosRequest req)
        {
            return InternalRequestAsync<ModifyTableMemosResponse>(req, "ModifyTableMemos");
        }

        /// <summary>
        /// This API is used to modify table remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
        public ModifyTableMemosResponse ModifyTableMemosSync(ModifyTableMemosRequest req)
        {
            return InternalRequestAsync<ModifyTableMemosResponse>(req, "ModifyTableMemos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale a table.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
        public Task<ModifyTableQuotasResponse> ModifyTableQuotas(ModifyTableQuotasRequest req)
        {
            return InternalRequestAsync<ModifyTableQuotasResponse>(req, "ModifyTableQuotas");
        }

        /// <summary>
        /// This API is used to scale a table.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
        public ModifyTableQuotasResponse ModifyTableQuotasSync(ModifyTableQuotasRequest req)
        {
            return InternalRequestAsync<ModifyTableQuotasResponse>(req, "ModifyTableQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify table tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableTagsRequest"/></param>
        /// <returns><see cref="ModifyTableTagsResponse"/></returns>
        public Task<ModifyTableTagsResponse> ModifyTableTags(ModifyTableTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableTagsResponse>(req, "ModifyTableTags");
        }

        /// <summary>
        /// This API is used to modify table tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableTagsRequest"/></param>
        /// <returns><see cref="ModifyTableTagsResponse"/></returns>
        public ModifyTableTagsResponse ModifyTableTagsSync(ModifyTableTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableTagsResponse>(req, "ModifyTableTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify specified tables in batches based on the selected table definition IDL file.
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
        public Task<ModifyTablesResponse> ModifyTables(ModifyTablesRequest req)
        {
            return InternalRequestAsync<ModifyTablesResponse>(req, "ModifyTables");
        }

        /// <summary>
        /// This API is used to modify specified tables in batches based on the selected table definition IDL file.
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
        public ModifyTablesResponse ModifyTablesSync(ModifyTablesRequest req)
        {
            return InternalRequestAsync<ModifyTablesResponse>(req, "ModifyTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover a dropped table from the recycle bin. It will not work for tables to be released due to arrears.
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
        public Task<RecoverRecycleTablesResponse> RecoverRecycleTables(RecoverRecycleTablesRequest req)
        {
            return InternalRequestAsync<RecoverRecycleTablesResponse>(req, "RecoverRecycleTables");
        }

        /// <summary>
        /// This API is used to recover a dropped table from the recycle bin. It will not work for tables to be released due to arrears.
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
        public RecoverRecycleTablesResponse RecoverRecycleTablesSync(RecoverRecycleTablesRequest req)
        {
            return InternalRequestAsync<RecoverRecycleTablesResponse>(req, "RecoverRecycleTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to roll back table data.
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
        public Task<RollbackTablesResponse> RollbackTables(RollbackTablesRequest req)
        {
            return InternalRequestAsync<RollbackTablesResponse>(req, "RollbackTables");
        }

        /// <summary>
        /// This API is used to roll back table data.
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
        public RollbackTablesResponse RollbackTablesSync(RollbackTablesRequest req)
        {
            return InternalRequestAsync<RollbackTablesResponse>(req, "RollbackTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add/delete/modify backup expiration policy. `ClusterId` must be a specific cluster ID (appid).
        /// </summary>
        /// <param name="req"><see cref="SetBackupExpireRuleRequest"/></param>
        /// <returns><see cref="SetBackupExpireRuleResponse"/></returns>
        public Task<SetBackupExpireRuleResponse> SetBackupExpireRule(SetBackupExpireRuleRequest req)
        {
            return InternalRequestAsync<SetBackupExpireRuleResponse>(req, "SetBackupExpireRule");
        }

        /// <summary>
        /// This API is used to add/delete/modify backup expiration policy. `ClusterId` must be a specific cluster ID (appid).
        /// </summary>
        /// <param name="req"><see cref="SetBackupExpireRuleRequest"/></param>
        /// <returns><see cref="SetBackupExpireRuleResponse"/></returns>
        public SetBackupExpireRuleResponse SetBackupExpireRuleSync(SetBackupExpireRuleRequest req)
        {
            return InternalRequestAsync<SetBackupExpireRuleResponse>(req, "SetBackupExpireRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable data subscription for tables or modify the feature's configurations.
        /// </summary>
        /// <param name="req"><see cref="SetTableDataFlowRequest"/></param>
        /// <returns><see cref="SetTableDataFlowResponse"/></returns>
        public Task<SetTableDataFlowResponse> SetTableDataFlow(SetTableDataFlowRequest req)
        {
            return InternalRequestAsync<SetTableDataFlowResponse>(req, "SetTableDataFlow");
        }

        /// <summary>
        /// This API is used to enable data subscription for tables or modify the feature's configurations.
        /// </summary>
        /// <param name="req"><see cref="SetTableDataFlowRequest"/></param>
        /// <returns><see cref="SetTableDataFlowResponse"/></returns>
        public SetTableDataFlowResponse SetTableDataFlowSync(SetTableDataFlowRequest req)
        {
            return InternalRequestAsync<SetTableDataFlowResponse>(req, "SetTableDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a global index for a table.
        /// </summary>
        /// <param name="req"><see cref="SetTableIndexRequest"/></param>
        /// <returns><see cref="SetTableIndexResponse"/></returns>
        public Task<SetTableIndexResponse> SetTableIndex(SetTableIndexRequest req)
        {
            return InternalRequestAsync<SetTableIndexResponse>(req, "SetTableIndex");
        }

        /// <summary>
        /// This API is used to create a global index for a table.
        /// </summary>
        /// <param name="req"><see cref="SetTableIndexRequest"/></param>
        /// <returns><see cref="SetTableIndexResponse"/></returns>
        public SetTableIndexResponse SetTableIndexSync(SetTableIndexRequest req)
        {
            return InternalRequestAsync<SetTableIndexResponse>(req, "SetTableIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the application status.
        /// </summary>
        /// <param name="req"><see cref="UpdateApplyRequest"/></param>
        /// <returns><see cref="UpdateApplyResponse"/></returns>
        public Task<UpdateApplyResponse> UpdateApply(UpdateApplyRequest req)
        {
            return InternalRequestAsync<UpdateApplyResponse>(req, "UpdateApply");
        }

        /// <summary>
        /// This API is used to update the application status.
        /// </summary>
        /// <param name="req"><see cref="UpdateApplyRequest"/></param>
        /// <returns><see cref="UpdateApplyResponse"/></returns>
        public UpdateApplyResponse UpdateApplySync(UpdateApplyRequest req)
        {
            return InternalRequestAsync<UpdateApplyResponse>(req, "UpdateApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upload and verify a table creation file and return the definition of tables that are verified to be valid.
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
        public Task<VerifyIdlFilesResponse> VerifyIdlFiles(VerifyIdlFilesRequest req)
        {
            return InternalRequestAsync<VerifyIdlFilesResponse>(req, "VerifyIdlFiles");
        }

        /// <summary>
        /// This API is used to upload and verify a table creation file and return the definition of tables that are verified to be valid.
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
        public VerifyIdlFilesResponse VerifyIdlFilesSync(VerifyIdlFilesRequest req)
        {
            return InternalRequestAsync<VerifyIdlFilesResponse>(req, "VerifyIdlFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
