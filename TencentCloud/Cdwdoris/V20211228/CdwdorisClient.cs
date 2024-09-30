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

namespace TencentCloud.Cdwdoris.V20211228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwdoris.V20211228.Models;

   public class CdwdorisClient : AbstractClient{

       private const string endpoint = "cdwdoris.tencentcloudapi.com";
       private const string version = "2021-12-28";
       private const string sdkVersion = "SDK_NET_3.0.991";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwdorisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwdorisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add and modify a user.
        /// </summary>
        /// <param name="req"><see cref="ActionAlterUserRequest"/></param>
        /// <returns><see cref="ActionAlterUserResponse"/></returns>
        public Task<ActionAlterUserResponse> ActionAlterUser(ActionAlterUserRequest req)
        {
            return InternalRequestAsync<ActionAlterUserResponse>(req, "ActionAlterUser");
        }

        /// <summary>
        /// This API is used to add and modify a user.
        /// </summary>
        /// <param name="req"><see cref="ActionAlterUserRequest"/></param>
        /// <returns><see cref="ActionAlterUserResponse"/></returns>
        public ActionAlterUserResponse ActionAlterUserSync(ActionAlterUserRequest req)
        {
            return InternalRequestAsync<ActionAlterUserResponse>(req, "ActionAlterUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel the corresponding backup instance task.
        /// </summary>
        /// <param name="req"><see cref="CancelBackupJobRequest"/></param>
        /// <returns><see cref="CancelBackupJobResponse"/></returns>
        public Task<CancelBackupJobResponse> CancelBackupJob(CancelBackupJobRequest req)
        {
            return InternalRequestAsync<CancelBackupJobResponse>(req, "CancelBackupJob");
        }

        /// <summary>
        /// This API is used to cancel the corresponding backup instance task.
        /// </summary>
        /// <param name="req"><see cref="CancelBackupJobRequest"/></param>
        /// <returns><see cref="CancelBackupJobResponse"/></returns>
        public CancelBackupJobResponse CancelBackupJobSync(CancelBackupJobRequest req)
        {
            return InternalRequestAsync<CancelBackupJobResponse>(req, "CancelBackupJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether variables and configurations for hot/cold data layering are correct.
        /// </summary>
        /// <param name="req"><see cref="CheckCoolDownWorkingVariableConfigCorrectRequest"/></param>
        /// <returns><see cref="CheckCoolDownWorkingVariableConfigCorrectResponse"/></returns>
        public Task<CheckCoolDownWorkingVariableConfigCorrectResponse> CheckCoolDownWorkingVariableConfigCorrect(CheckCoolDownWorkingVariableConfigCorrectRequest req)
        {
            return InternalRequestAsync<CheckCoolDownWorkingVariableConfigCorrectResponse>(req, "CheckCoolDownWorkingVariableConfigCorrect");
        }

        /// <summary>
        /// This API is used to check whether variables and configurations for hot/cold data layering are correct.
        /// </summary>
        /// <param name="req"><see cref="CheckCoolDownWorkingVariableConfigCorrectRequest"/></param>
        /// <returns><see cref="CheckCoolDownWorkingVariableConfigCorrectResponse"/></returns>
        public CheckCoolDownWorkingVariableConfigCorrectResponse CheckCoolDownWorkingVariableConfigCorrectSync(CheckCoolDownWorkingVariableConfigCorrectRequest req)
        {
            return InternalRequestAsync<CheckCoolDownWorkingVariableConfigCorrectResponse>(req, "CheckCoolDownWorkingVariableConfigCorrect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to copy the source table to the target table.
        /// </summary>
        /// <param name="req"><see cref="CopyTableDatasRequest"/></param>
        /// <returns><see cref="CopyTableDatasResponse"/></returns>
        public Task<CopyTableDatasResponse> CopyTableDatas(CopyTableDatasRequest req)
        {
            return InternalRequestAsync<CopyTableDatasResponse>(req, "CopyTableDatas");
        }

        /// <summary>
        /// This API is used to copy the source table to the target table.
        /// </summary>
        /// <param name="req"><see cref="CopyTableDatasRequest"/></param>
        /// <returns><see cref="CopyTableDatasResponse"/></returns>
        public CopyTableDatasResponse CopyTableDatasSync(CopyTableDatasRequest req)
        {
            return InternalRequestAsync<CopyTableDatasResponse>(req, "CopyTableDatas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create or modify backup policies.
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public Task<CreateBackUpScheduleResponse> CreateBackUpSchedule(CreateBackUpScheduleRequest req)
        {
            return InternalRequestAsync<CreateBackUpScheduleResponse>(req, "CreateBackUpSchedule");
        }

        /// <summary>
        /// This API is used to create or modify backup policies.
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public CreateBackUpScheduleResponse CreateBackUpScheduleSync(CreateBackUpScheduleRequest req)
        {
            return InternalRequestAsync<CreateBackUpScheduleResponse>(req, "CreateBackUpSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a hot/cold data layering policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCoolDownPolicyRequest"/></param>
        /// <returns><see cref="CreateCoolDownPolicyResponse"/></returns>
        public Task<CreateCoolDownPolicyResponse> CreateCoolDownPolicy(CreateCoolDownPolicyRequest req)
        {
            return InternalRequestAsync<CreateCoolDownPolicyResponse>(req, "CreateCoolDownPolicy");
        }

        /// <summary>
        /// This API is used to create a hot/cold data layering policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCoolDownPolicyRequest"/></param>
        /// <returns><see cref="CreateCoolDownPolicyResponse"/></returns>
        public CreateCoolDownPolicyResponse CreateCoolDownPolicySync(CreateCoolDownPolicyRequest req)
        {
            return InternalRequestAsync<CreateCoolDownPolicyResponse>(req, "CreateCoolDownPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TCHouse-D database.
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase");
        }

        /// <summary>
        /// This API is used to create a TCHouse-D database.
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public CreateDatabaseResponse CreateDatabaseSync(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create clusters.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public Task<CreateInstanceNewResponse> CreateInstanceNew(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew");
        }

        /// <summary>
        /// This API is used to create clusters.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public CreateInstanceNewResponse CreateInstanceNewSync(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TCHouse-D table under the specified database.
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public Task<CreateTableResponse> CreateTable(CreateTableRequest req)
        {
            return InternalRequestAsync<CreateTableResponse>(req, "CreateTable");
        }

        /// <summary>
        /// This API is used to create a TCHouse-D table under the specified database.
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public CreateTableResponse CreateTableSync(CreateTableRequest req)
        {
            return InternalRequestAsync<CreateTableResponse>(req, "CreateTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create resource groups.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkloadGroupRequest"/></param>
        /// <returns><see cref="CreateWorkloadGroupResponse"/></returns>
        public Task<CreateWorkloadGroupResponse> CreateWorkloadGroup(CreateWorkloadGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkloadGroupResponse>(req, "CreateWorkloadGroup");
        }

        /// <summary>
        /// This API is used to create resource groups.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkloadGroupRequest"/></param>
        /// <returns><see cref="CreateWorkloadGroupResponse"/></returns>
        public CreateWorkloadGroupResponse CreateWorkloadGroupSync(CreateWorkloadGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkloadGroupResponse>(req, "CreateWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete backup data.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackUpDataRequest"/></param>
        /// <returns><see cref="DeleteBackUpDataResponse"/></returns>
        public Task<DeleteBackUpDataResponse> DeleteBackUpData(DeleteBackUpDataRequest req)
        {
            return InternalRequestAsync<DeleteBackUpDataResponse>(req, "DeleteBackUpData");
        }

        /// <summary>
        /// This API is used to delete backup data.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackUpDataRequest"/></param>
        /// <returns><see cref="DeleteBackUpDataResponse"/></returns>
        public DeleteBackUpDataResponse DeleteBackUpDataSync(DeleteBackUpDataRequest req)
        {
            return InternalRequestAsync<DeleteBackUpDataResponse>(req, "DeleteBackUpData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the specified table in the specified database.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public Task<DeleteTableResponse> DeleteTable(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable");
        }

        /// <summary>
        /// This API is used to delete the specified table in the specified database.
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public DeleteTableResponse DeleteTableSync(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete resource groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkloadGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkloadGroupResponse"/></returns>
        public Task<DeleteWorkloadGroupResponse> DeleteWorkloadGroup(DeleteWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkloadGroupResponse>(req, "DeleteWorkloadGroup");
        }

        /// <summary>
        /// This API is used to delete resource groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkloadGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkloadGroupResponse"/></returns>
        public DeleteWorkloadGroupResponse DeleteWorkloadGroupSync(DeleteWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkloadGroupResponse>(req, "DeleteWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display region information and the total number of clusters in each region on the cluster list page.
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaRegionRequest"/></param>
        /// <returns><see cref="DescribeAreaRegionResponse"/></returns>
        public Task<DescribeAreaRegionResponse> DescribeAreaRegion(DescribeAreaRegionRequest req)
        {
            return InternalRequestAsync<DescribeAreaRegionResponse>(req, "DescribeAreaRegion");
        }

        /// <summary>
        /// This API is used to display region information and the total number of clusters in each region on the cluster list page.
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaRegionRequest"/></param>
        /// <returns><see cref="DescribeAreaRegionResponse"/></returns>
        public DescribeAreaRegionResponse DescribeAreaRegionSync(DescribeAreaRegionRequest req)
        {
            return InternalRequestAsync<DescribeAreaRegionResponse>(req, "DescribeAreaRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of backup instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobResponse"/></returns>
        public Task<DescribeBackUpJobResponse> DescribeBackUpJob(DescribeBackUpJobRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobResponse>(req, "DescribeBackUpJob");
        }

        /// <summary>
        /// This API is used to query the list of backup instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobResponse"/></returns>
        public DescribeBackUpJobResponse DescribeBackUpJobSync(DescribeBackUpJobRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobResponse>(req, "DescribeBackUpJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query backup task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobDetailResponse"/></returns>
        public Task<DescribeBackUpJobDetailResponse> DescribeBackUpJobDetail(DescribeBackUpJobDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobDetailResponse>(req, "DescribeBackUpJobDetail");
        }

        /// <summary>
        /// This API is used to query backup task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobDetailResponse"/></returns>
        public DescribeBackUpJobDetailResponse DescribeBackUpJobDetailSync(DescribeBackUpJobDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobDetailResponse>(req, "DescribeBackUpJobDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the scheduled task information for the backup and migration.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpSchedulesRequest"/></param>
        /// <returns><see cref="DescribeBackUpSchedulesResponse"/></returns>
        public Task<DescribeBackUpSchedulesResponse> DescribeBackUpSchedules(DescribeBackUpSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpSchedulesResponse>(req, "DescribeBackUpSchedules");
        }

        /// <summary>
        /// This API is used to obtain the scheduled task information for the backup and migration.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpSchedulesRequest"/></param>
        /// <returns><see cref="DescribeBackUpSchedulesResponse"/></returns>
        public DescribeBackUpSchedulesResponse DescribeBackUpSchedulesSync(DescribeBackUpSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpSchedulesResponse>(req, "DescribeBackUpSchedules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of the table available for backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTablesRequest"/></param>
        /// <returns><see cref="DescribeBackUpTablesResponse"/></returns>
        public Task<DescribeBackUpTablesResponse> DescribeBackUpTables(DescribeBackUpTablesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTablesResponse>(req, "DescribeBackUpTables");
        }

        /// <summary>
        /// This API is used to obtain the information of the table available for backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTablesRequest"/></param>
        /// <returns><see cref="DescribeBackUpTablesResponse"/></returns>
        public DescribeBackUpTablesResponse DescribeBackUpTablesSync(DescribeBackUpTablesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTablesResponse>(req, "DescribeBackUpTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the progress details of backup tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpTaskDetailResponse"/></returns>
        public Task<DescribeBackUpTaskDetailResponse> DescribeBackUpTaskDetail(DescribeBackUpTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTaskDetailResponse>(req, "DescribeBackUpTaskDetail");
        }

        /// <summary>
        /// This API is used to query the progress details of backup tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpTaskDetailResponse"/></returns>
        public DescribeBackUpTaskDetailResponse DescribeBackUpTaskDetailSync(DescribeBackUpTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTaskDetailResponse>(req, "DescribeBackUpTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the contents of the latest configuration files (config.xml, metrika.xml, and user.xml) of the cluster and display them to the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public Task<DescribeClusterConfigsResponse> DescribeClusterConfigs(DescribeClusterConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsResponse>(req, "DescribeClusterConfigs");
        }

        /// <summary>
        /// This API is used to get the contents of the latest configuration files (config.xml, metrika.xml, and user.xml) of the cluster and display them to the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public DescribeClusterConfigsResponse DescribeClusterConfigsSync(DescribeClusterConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsResponse>(req, "DescribeClusterConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the modification history of cluster configuration files.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsHistoryResponse"/></returns>
        public Task<DescribeClusterConfigsHistoryResponse> DescribeClusterConfigsHistory(DescribeClusterConfigsHistoryRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsHistoryResponse>(req, "DescribeClusterConfigsHistory");
        }

        /// <summary>
        /// This API is used to obtain the modification history of cluster configuration files.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsHistoryResponse"/></returns>
        public DescribeClusterConfigsHistoryResponse DescribeClusterConfigsHistorySync(DescribeClusterConfigsHistoryRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsHistoryResponse>(req, "DescribeClusterConfigsHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of backend nodes supporting hot/cold data layering.
        /// </summary>
        /// <param name="req"><see cref="DescribeCoolDownBackendsRequest"/></param>
        /// <returns><see cref="DescribeCoolDownBackendsResponse"/></returns>
        public Task<DescribeCoolDownBackendsResponse> DescribeCoolDownBackends(DescribeCoolDownBackendsRequest req)
        {
            return InternalRequestAsync<DescribeCoolDownBackendsResponse>(req, "DescribeCoolDownBackends");
        }

        /// <summary>
        /// This API is used to query the list of backend nodes supporting hot/cold data layering.
        /// </summary>
        /// <param name="req"><see cref="DescribeCoolDownBackendsRequest"/></param>
        /// <returns><see cref="DescribeCoolDownBackendsResponse"/></returns>
        public DescribeCoolDownBackendsResponse DescribeCoolDownBackendsSync(DescribeCoolDownBackendsRequest req)
        {
            return InternalRequestAsync<DescribeCoolDownBackendsResponse>(req, "DescribeCoolDownBackends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of hot/cold data layering policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeCoolDownPoliciesRequest"/></param>
        /// <returns><see cref="DescribeCoolDownPoliciesResponse"/></returns>
        public Task<DescribeCoolDownPoliciesResponse> DescribeCoolDownPolicies(DescribeCoolDownPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeCoolDownPoliciesResponse>(req, "DescribeCoolDownPolicies");
        }

        /// <summary>
        /// This API is used to query the list of hot/cold data layering policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeCoolDownPoliciesRequest"/></param>
        /// <returns><see cref="DescribeCoolDownPoliciesResponse"/></returns>
        public DescribeCoolDownPoliciesResponse DescribeCoolDownPoliciesSync(DescribeCoolDownPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeCoolDownPoliciesResponse>(req, "DescribeCoolDownPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the layered hot and cold data in a table.
        /// </summary>
        /// <param name="req"><see cref="DescribeCoolDownTableDataRequest"/></param>
        /// <returns><see cref="DescribeCoolDownTableDataResponse"/></returns>
        public Task<DescribeCoolDownTableDataResponse> DescribeCoolDownTableData(DescribeCoolDownTableDataRequest req)
        {
            return InternalRequestAsync<DescribeCoolDownTableDataResponse>(req, "DescribeCoolDownTableData");
        }

        /// <summary>
        /// This API is used to query the layered hot and cold data in a table.
        /// </summary>
        /// <param name="req"><see cref="DescribeCoolDownTableDataRequest"/></param>
        /// <returns><see cref="DescribeCoolDownTableDataResponse"/></returns>
        public DescribeCoolDownTableDataResponse DescribeCoolDownTableDataSync(DescribeCoolDownTableDataRequest req)
        {
            return InternalRequestAsync<DescribeCoolDownTableDataResponse>(req, "DescribeCoolDownTableData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch obtain the table creation DDL.
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateTablesDDLRequest"/></param>
        /// <returns><see cref="DescribeCreateTablesDDLResponse"/></returns>
        public Task<DescribeCreateTablesDDLResponse> DescribeCreateTablesDDL(DescribeCreateTablesDDLRequest req)
        {
            return InternalRequestAsync<DescribeCreateTablesDDLResponse>(req, "DescribeCreateTablesDDL");
        }

        /// <summary>
        /// This API is used to batch obtain the table creation DDL.
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateTablesDDLRequest"/></param>
        /// <returns><see cref="DescribeCreateTablesDDLResponse"/></returns>
        public DescribeCreateTablesDDLResponse DescribeCreateTablesDDLSync(DescribeCreateTablesDDLRequest req)
        {
            return InternalRequestAsync<DescribeCreateTablesDDLResponse>(req, "DescribeCreateTablesDDL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the database information under a specific data source.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDatabaseResponse"/></returns>
        public Task<DescribeDatabaseResponse> DescribeDatabase(DescribeDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseResponse>(req, "DescribeDatabase");
        }

        /// <summary>
        /// This API is used to obtain the database information under a specific data source.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDatabaseResponse"/></returns>
        public DescribeDatabaseResponse DescribeDatabaseSync(DescribeDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseResponse>(req, "DescribeDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download database audit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditDownloadRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditDownloadResponse"/></returns>
        public Task<DescribeDatabaseAuditDownloadResponse> DescribeDatabaseAuditDownload(DescribeDatabaseAuditDownloadRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditDownloadResponse>(req, "DescribeDatabaseAuditDownload");
        }

        /// <summary>
        /// This API is used to download database audit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditDownloadRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditDownloadResponse"/></returns>
        public DescribeDatabaseAuditDownloadResponse DescribeDatabaseAuditDownloadSync(DescribeDatabaseAuditDownloadRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditDownloadResponse>(req, "DescribeDatabaseAuditDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get database audit records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditRecordsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditRecordsResponse"/></returns>
        public Task<DescribeDatabaseAuditRecordsResponse> DescribeDatabaseAuditRecords(DescribeDatabaseAuditRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditRecordsResponse>(req, "DescribeDatabaseAuditRecords");
        }

        /// <summary>
        /// This API is used to get database audit records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditRecordsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditRecordsResponse"/></returns>
        public DescribeDatabaseAuditRecordsResponse DescribeDatabaseAuditRecordsSync(DescribeDatabaseAuditRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditRecordsResponse>(req, "DescribeDatabaseAuditRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the specific information of a cluster based on the cluster ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// This API is used to query the specific information of a cluster based on the cluster ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of cluster node information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public Task<DescribeInstanceNodesResponse> DescribeInstanceNodes(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes");
        }

        /// <summary>
        /// This API is used to get the list of cluster node information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public DescribeInstanceNodesResponse DescribeInstanceNodesSync(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the BE/FE node roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesInfoResponse"/></returns>
        public Task<DescribeInstanceNodesInfoResponse> DescribeInstanceNodesInfo(DescribeInstanceNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesInfoResponse>(req, "DescribeInstanceNodesInfo");
        }

        /// <summary>
        /// This API is used to get the BE/FE node roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesInfoResponse"/></returns>
        public DescribeInstanceNodesInfoResponse DescribeInstanceNodesInfoSync(DescribeInstanceNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesInfoResponse>(req, "DescribeInstanceNodesInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain cluster node roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRoleRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesRoleResponse"/></returns>
        public Task<DescribeInstanceNodesRoleResponse> DescribeInstanceNodesRole(DescribeInstanceNodesRoleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesRoleResponse>(req, "DescribeInstanceNodesRole");
        }

        /// <summary>
        /// This API is used to obtain cluster node roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRoleRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesRoleResponse"/></returns>
        public DescribeInstanceNodesRoleResponse DescribeInstanceNodesRoleSync(DescribeInstanceNodesRoleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesRoleResponse>(req, "DescribeInstanceNodesRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull the operation list of the cluster. The API supports pagination query and filtering operation records by time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationHistoryRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationHistoryResponse"/></returns>
        public Task<DescribeInstanceOperationHistoryResponse> DescribeInstanceOperationHistory(DescribeInstanceOperationHistoryRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationHistoryResponse>(req, "DescribeInstanceOperationHistory");
        }

        /// <summary>
        /// This API is used to pull the operation list of the cluster. The API supports pagination query and filtering operation records by time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationHistoryRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationHistoryResponse"/></returns>
        public DescribeInstanceOperationHistoryResponse DescribeInstanceOperationHistorySync(DescribeInstanceOperationHistoryRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationHistoryResponse>(req, "DescribeInstanceOperationHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull operations of the cluster on the cluster details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations");
        }

        /// <summary>
        /// This API is used to pull operations of the cluster on the cluster details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display cluster status, process progress, etc. in the cluster details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public Task<DescribeInstanceStateResponse> DescribeInstanceState(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState");
        }

        /// <summary>
        /// This API is used to display cluster status, process progress, etc. in the cluster details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public DescribeInstanceStateResponse DescribeInstanceStateSync(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of subnets used by the cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUsedSubnetsRequest"/></param>
        /// <returns><see cref="DescribeInstanceUsedSubnetsResponse"/></returns>
        public Task<DescribeInstanceUsedSubnetsResponse> DescribeInstanceUsedSubnets(DescribeInstanceUsedSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUsedSubnetsResponse>(req, "DescribeInstanceUsedSubnets");
        }

        /// <summary>
        /// This API is used to obtain the information of subnets used by the cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUsedSubnetsRequest"/></param>
        /// <returns><see cref="DescribeInstanceUsedSubnetsResponse"/></returns>
        public DescribeInstanceUsedSubnetsResponse DescribeInstanceUsedSubnetsSync(DescribeInstanceUsedSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUsedSubnetsResponse>(req, "DescribeInstanceUsedSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to get the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check cluster health
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesHealthStateRequest"/></param>
        /// <returns><see cref="DescribeInstancesHealthStateResponse"/></returns>
        public Task<DescribeInstancesHealthStateResponse> DescribeInstancesHealthState(DescribeInstancesHealthStateRequest req)
        {
            return InternalRequestAsync<DescribeInstancesHealthStateResponse>(req, "DescribeInstancesHealthState");
        }

        /// <summary>
        /// This API is used to check cluster health
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesHealthStateRequest"/></param>
        /// <returns><see cref="DescribeInstancesHealthStateResponse"/></returns>
        public DescribeInstancesHealthStateResponse DescribeInstancesHealthStateSync(DescribeInstancesHealthStateRequest req)
        {
            return InternalRequestAsync<DescribeInstancesHealthStateResponse>(req, "DescribeInstancesHealthState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the SQL query details of the Doris user.
        /// </summary>
        /// <param name="req"><see cref="DescribeQueryAnalyseRequest"/></param>
        /// <returns><see cref="DescribeQueryAnalyseResponse"/></returns>
        public Task<DescribeQueryAnalyseResponse> DescribeQueryAnalyse(DescribeQueryAnalyseRequest req)
        {
            return InternalRequestAsync<DescribeQueryAnalyseResponse>(req, "DescribeQueryAnalyse");
        }

        /// <summary>
        /// This API is used to obtain the SQL query details of the Doris user.
        /// </summary>
        /// <param name="req"><see cref="DescribeQueryAnalyseRequest"/></param>
        /// <returns><see cref="DescribeQueryAnalyseResponse"/></returns>
        public DescribeQueryAnalyseResponse DescribeQueryAnalyseSync(DescribeQueryAnalyseRequest req)
        {
            return InternalRequestAsync<DescribeQueryAnalyseResponse>(req, "DescribeQueryAnalyse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the progress details of the recovery task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskDetailResponse"/></returns>
        public Task<DescribeRestoreTaskDetailResponse> DescribeRestoreTaskDetail(DescribeRestoreTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskDetailResponse>(req, "DescribeRestoreTaskDetail");
        }

        /// <summary>
        /// This API is used to query the progress details of the recovery task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskDetailResponse"/></returns>
        public DescribeRestoreTaskDetailResponse DescribeRestoreTaskDetailSync(DescribeRestoreTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskDetailResponse>(req, "DescribeRestoreTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the slow log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsResponse"/></returns>
        public Task<DescribeSlowQueryRecordsResponse> DescribeSlowQueryRecords(DescribeSlowQueryRecordsRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsResponse>(req, "DescribeSlowQueryRecords");
        }

        /// <summary>
        /// This API is used to get the slow log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsResponse"/></returns>
        public DescribeSlowQueryRecordsResponse DescribeSlowQueryRecordsSync(DescribeSlowQueryRecordsRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsResponse>(req, "DescribeSlowQueryRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download slow log files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsDownloadRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsDownloadResponse"/></returns>
        public Task<DescribeSlowQueryRecordsDownloadResponse> DescribeSlowQueryRecordsDownload(DescribeSlowQueryRecordsDownloadRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsDownloadResponse>(req, "DescribeSlowQueryRecordsDownload");
        }

        /// <summary>
        /// This API is used to download slow log files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsDownloadRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsDownloadResponse"/></returns>
        public DescribeSlowQueryRecordsDownloadResponse DescribeSlowQueryRecordsDownloadSync(DescribeSlowQueryRecordsDownloadRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsDownloadResponse>(req, "DescribeSlowQueryRecordsDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull the specification list of data nodes and zookeeper nodes for the cluster on the purchase page.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public Task<DescribeSpecResponse> DescribeSpec(DescribeSpecRequest req)
        {
            return InternalRequestAsync<DescribeSpecResponse>(req, "DescribeSpec");
        }

        /// <summary>
        /// This API is used to pull the specification list of data nodes and zookeeper nodes for the cluster on the purchase page.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public DescribeSpecResponse DescribeSpecSync(DescribeSpecRequest req)
        {
            return InternalRequestAsync<DescribeSpecResponse>(req, "DescribeSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cluster information by executing SQL commands.
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlApisRequest"/></param>
        /// <returns><see cref="DescribeSqlApisResponse"/></returns>
        public Task<DescribeSqlApisResponse> DescribeSqlApis(DescribeSqlApisRequest req)
        {
            return InternalRequestAsync<DescribeSqlApisResponse>(req, "DescribeSqlApis");
        }

        /// <summary>
        /// This API is used to query the cluster information by executing SQL commands.
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlApisRequest"/></param>
        /// <returns><see cref="DescribeSqlApisResponse"/></returns>
        public DescribeSqlApisResponse DescribeSqlApisSync(DescribeSqlApisRequest req)
        {
            return InternalRequestAsync<DescribeSqlApisResponse>(req, "DescribeSqlApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the table information. It only supports querying table information in the TCHouse-D internal catalog.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public Task<DescribeTableResponse> DescribeTable(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable");
        }

        /// <summary>
        /// This API is used to obtain the table information. It only supports querying table information in the TCHouse-D internal catalog.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public DescribeTableResponse DescribeTableSync(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of tables under the specified data source and database.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableListRequest"/></param>
        /// <returns><see cref="DescribeTableListResponse"/></returns>
        public Task<DescribeTableListResponse> DescribeTableList(DescribeTableListRequest req)
        {
            return InternalRequestAsync<DescribeTableListResponse>(req, "DescribeTableList");
        }

        /// <summary>
        /// This API is used to obtain the list of tables under the specified data source and database.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableListRequest"/></param>
        /// <returns><see cref="DescribeTableListResponse"/></returns>
        public DescribeTableListResponse DescribeTableListSync(DescribeTableListRequest req)
        {
            return InternalRequestAsync<DescribeTableListResponse>(req, "DescribeTableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the resource information bound to each user in the current cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeUserBindWorkloadGroupResponse"/></returns>
        public Task<DescribeUserBindWorkloadGroupResponse> DescribeUserBindWorkloadGroup(DescribeUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeUserBindWorkloadGroupResponse>(req, "DescribeUserBindWorkloadGroup");
        }

        /// <summary>
        /// This API is used to obtain the resource information bound to each user in the current cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeUserBindWorkloadGroupResponse"/></returns>
        public DescribeUserBindWorkloadGroupResponse DescribeUserBindWorkloadGroupSync(DescribeUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeUserBindWorkloadGroupResponse>(req, "DescribeUserBindWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain detailed information of Doris users, including account information, permission host, and permission configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPolicyRequest"/></param>
        /// <returns><see cref="DescribeUserPolicyResponse"/></returns>
        public Task<DescribeUserPolicyResponse> DescribeUserPolicy(DescribeUserPolicyRequest req)
        {
            return InternalRequestAsync<DescribeUserPolicyResponse>(req, "DescribeUserPolicy");
        }

        /// <summary>
        /// This API is used to obtain detailed information of Doris users, including account information, permission host, and permission configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPolicyRequest"/></param>
        /// <returns><see cref="DescribeUserPolicyResponse"/></returns>
        public DescribeUserPolicyResponse DescribeUserPolicySync(DescribeUserPolicyRequest req)
        {
            return InternalRequestAsync<DescribeUserPolicyResponse>(req, "DescribeUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain resource group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeWorkloadGroupResponse"/></returns>
        public Task<DescribeWorkloadGroupResponse> DescribeWorkloadGroup(DescribeWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeWorkloadGroupResponse>(req, "DescribeWorkloadGroup");
        }

        /// <summary>
        /// This API is used to obtain resource group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeWorkloadGroupResponse"/></returns>
        public DescribeWorkloadGroupResponse DescribeWorkloadGroupSync(DescribeWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeWorkloadGroupResponse>(req, "DescribeWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate clusters.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public Task<DestroyInstanceResponse> DestroyInstance(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance");
        }

        /// <summary>
        /// This API is used to terminate clusters.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public DestroyInstanceResponse DestroyInstanceSync(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to execute an SQL query statement with parameters and return the query results.
        /// </summary>
        /// <param name="req"><see cref="ExecuteParametrizedQueryRequest"/></param>
        /// <returns><see cref="ExecuteParametrizedQueryResponse"/></returns>
        public Task<ExecuteParametrizedQueryResponse> ExecuteParametrizedQuery(ExecuteParametrizedQueryRequest req)
        {
            return InternalRequestAsync<ExecuteParametrizedQueryResponse>(req, "ExecuteParametrizedQuery");
        }

        /// <summary>
        /// This API is used to execute an SQL query statement with parameters and return the query results.
        /// </summary>
        /// <param name="req"><see cref="ExecuteParametrizedQueryRequest"/></param>
        /// <returns><see cref="ExecuteParametrizedQueryResponse"/></returns>
        public ExecuteParametrizedQueryResponse ExecuteParametrizedQuerySync(ExecuteParametrizedQueryRequest req)
        {
            return InternalRequestAsync<ExecuteParametrizedQueryResponse>(req, "ExecuteParametrizedQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query data according to the specified database and table name, and support field selection and pagination.
        /// </summary>
        /// <param name="req"><see cref="ExecuteSelectQueryRequest"/></param>
        /// <returns><see cref="ExecuteSelectQueryResponse"/></returns>
        public Task<ExecuteSelectQueryResponse> ExecuteSelectQuery(ExecuteSelectQueryRequest req)
        {
            return InternalRequestAsync<ExecuteSelectQueryResponse>(req, "ExecuteSelectQuery");
        }

        /// <summary>
        /// This API is used to query data according to the specified database and table name, and support field selection and pagination.
        /// </summary>
        /// <param name="req"><see cref="ExecuteSelectQueryRequest"/></param>
        /// <returns><see cref="ExecuteSelectQueryResponse"/></returns>
        public ExecuteSelectQueryResponse ExecuteSelectQuerySync(ExecuteSelectQueryRequest req)
        {
            return InternalRequestAsync<ExecuteSelectQueryResponse>(req, "ExecuteSelectQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to insert data into TCHouse-D.
        /// </summary>
        /// <param name="req"><see cref="InsertDatasToTableRequest"/></param>
        /// <returns><see cref="InsertDatasToTableResponse"/></returns>
        public Task<InsertDatasToTableResponse> InsertDatasToTable(InsertDatasToTableRequest req)
        {
            return InternalRequestAsync<InsertDatasToTableResponse>(req, "InsertDatasToTable");
        }

        /// <summary>
        /// This API is used to insert data into TCHouse-D.
        /// </summary>
        /// <param name="req"><see cref="InsertDatasToTableRequest"/></param>
        /// <returns><see cref="InsertDatasToTableResponse"/></returns>
        public InsertDatasToTableResponse InsertDatasToTableSync(InsertDatasToTableRequest req)
        {
            return InternalRequestAsync<InsertDatasToTableResponse>(req, "InsertDatasToTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the XML cluster configuration file on the cluster configuration page.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterConfigsRequest"/></param>
        /// <returns><see cref="ModifyClusterConfigsResponse"/></returns>
        public Task<ModifyClusterConfigsResponse> ModifyClusterConfigs(ModifyClusterConfigsRequest req)
        {
            return InternalRequestAsync<ModifyClusterConfigsResponse>(req, "ModifyClusterConfigs");
        }

        /// <summary>
        /// This API is used to modify the XML cluster configuration file on the cluster configuration page.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterConfigsRequest"/></param>
        /// <returns><see cref="ModifyClusterConfigsResponse"/></returns>
        public ModifyClusterConfigsResponse ModifyClusterConfigsSync(ModifyClusterConfigsRequest req)
        {
            return InternalRequestAsync<ModifyClusterConfigsResponse>(req, "ModifyClusterConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the hot/cold data layering policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCoolDownPolicyRequest"/></param>
        /// <returns><see cref="ModifyCoolDownPolicyResponse"/></returns>
        public Task<ModifyCoolDownPolicyResponse> ModifyCoolDownPolicy(ModifyCoolDownPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCoolDownPolicyResponse>(req, "ModifyCoolDownPolicy");
        }

        /// <summary>
        /// This API is used to modify the hot/cold data layering policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCoolDownPolicyRequest"/></param>
        /// <returns><see cref="ModifyCoolDownPolicyResponse"/></returns>
        public ModifyCoolDownPolicyResponse ModifyCoolDownPolicySync(ModifyCoolDownPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCoolDownPolicyResponse>(req, "ModifyCoolDownPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to GRANT and REVOKE the database and table in the Doris database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseTableAccessRequest"/></param>
        /// <returns><see cref="ModifyDatabaseTableAccessResponse"/></returns>
        public Task<ModifyDatabaseTableAccessResponse> ModifyDatabaseTableAccess(ModifyDatabaseTableAccessRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseTableAccessResponse>(req, "ModifyDatabaseTableAccess");
        }

        /// <summary>
        /// This API is used to GRANT and REVOKE the database and table in the Doris database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseTableAccessRequest"/></param>
        /// <returns><see cref="ModifyDatabaseTableAccessResponse"/></returns>
        public ModifyDatabaseTableAccessResponse ModifyDatabaseTableAccessSync(ModifyDatabaseTableAccessRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseTableAccessResponse>(req, "ModifyDatabaseTableAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the cluster's name.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to modify the cluster's name.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify configurations in the KV mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public Task<ModifyInstanceKeyValConfigsResponse> ModifyInstanceKeyValConfigs(ModifyInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceKeyValConfigsResponse>(req, "ModifyInstanceKeyValConfigs");
        }

        /// <summary>
        /// This API is used to modify configurations in the KV mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public ModifyInstanceKeyValConfigsResponse ModifyInstanceKeyValConfigsSync(ModifyInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceKeyValConfigsResponse>(req, "ModifyInstanceKeyValConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the node status.
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyNodeStatusResponse"/></returns>
        public Task<ModifyNodeStatusResponse> ModifyNodeStatus(ModifyNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyNodeStatusResponse>(req, "ModifyNodeStatus");
        }

        /// <summary>
        /// This API is used to change the node status.
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyNodeStatusResponse"/></returns>
        public ModifyNodeStatusResponse ModifyNodeStatusSync(ModifyNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyNodeStatusResponse>(req, "ModifyNodeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit security groups.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupsResponse"/></returns>
        public Task<ModifySecurityGroupsResponse> ModifySecurityGroups(ModifySecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupsResponse>(req, "ModifySecurityGroups");
        }

        /// <summary>
        /// This API is used to edit security groups.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupsResponse"/></returns>
        public ModifySecurityGroupsResponse ModifySecurityGroupsSync(ModifySecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupsResponse>(req, "ModifySecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the resource group bound to the user.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyUserBindWorkloadGroupResponse"/></returns>
        public Task<ModifyUserBindWorkloadGroupResponse> ModifyUserBindWorkloadGroup(ModifyUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserBindWorkloadGroupResponse>(req, "ModifyUserBindWorkloadGroup");
        }

        /// <summary>
        /// This API is used to modify the resource group bound to the user.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyUserBindWorkloadGroupResponse"/></returns>
        public ModifyUserBindWorkloadGroupResponse ModifyUserBindWorkloadGroupSync(ModifyUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserBindWorkloadGroupResponse>(req, "ModifyUserBindWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user permissions and support three permission setting categories: catalog, all db, and some db tables.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesV3Request"/></param>
        /// <returns><see cref="ModifyUserPrivilegesV3Response"/></returns>
        public Task<ModifyUserPrivilegesV3Response> ModifyUserPrivilegesV3(ModifyUserPrivilegesV3Request req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesV3Response>(req, "ModifyUserPrivilegesV3");
        }

        /// <summary>
        /// This API is used to modify user permissions and support three permission setting categories: catalog, all db, and some db tables.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesV3Request"/></param>
        /// <returns><see cref="ModifyUserPrivilegesV3Response"/></returns>
        public ModifyUserPrivilegesV3Response ModifyUserPrivilegesV3Sync(ModifyUserPrivilegesV3Request req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesV3Response>(req, "ModifyUserPrivilegesV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the resource group information.
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupResponse"/></returns>
        public Task<ModifyWorkloadGroupResponse> ModifyWorkloadGroup(ModifyWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupResponse>(req, "ModifyWorkloadGroup");
        }

        /// <summary>
        /// This API is used to modify the resource group information.
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupResponse"/></returns>
        public ModifyWorkloadGroupResponse ModifyWorkloadGroupSync(ModifyWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupResponse>(req, "ModifyWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable resource groups.
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupStatusResponse"/></returns>
        public Task<ModifyWorkloadGroupStatusResponse> ModifyWorkloadGroupStatus(ModifyWorkloadGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupStatusResponse>(req, "ModifyWorkloadGroupStatus");
        }

        /// <summary>
        /// This API is used to enable or disable resource groups.
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupStatusResponse"/></returns>
        public ModifyWorkloadGroupStatusResponse ModifyWorkloadGroupStatusSync(ModifyWorkloadGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupStatusResponse>(req, "ModifyWorkloadGroupStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable hot/cold data layering.
        /// </summary>
        /// <param name="req"><see cref="OpenCoolDownRequest"/></param>
        /// <returns><see cref="OpenCoolDownResponse"/></returns>
        public Task<OpenCoolDownResponse> OpenCoolDown(OpenCoolDownRequest req)
        {
            return InternalRequestAsync<OpenCoolDownResponse>(req, "OpenCoolDown");
        }

        /// <summary>
        /// This API is used to enable hot/cold data layering.
        /// </summary>
        /// <param name="req"><see cref="OpenCoolDownRequest"/></param>
        /// <returns><see cref="OpenCoolDownResponse"/></returns>
        public OpenCoolDownResponse OpenCoolDownSync(OpenCoolDownRequest req)
        {
            return InternalRequestAsync<OpenCoolDownResponse>(req, "OpenCoolDown")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable and describe the cold storage policy.
        /// </summary>
        /// <param name="req"><see cref="OpenCoolDownPolicyRequest"/></param>
        /// <returns><see cref="OpenCoolDownPolicyResponse"/></returns>
        public Task<OpenCoolDownPolicyResponse> OpenCoolDownPolicy(OpenCoolDownPolicyRequest req)
        {
            return InternalRequestAsync<OpenCoolDownPolicyResponse>(req, "OpenCoolDownPolicy");
        }

        /// <summary>
        /// This API is used to enable and describe the cold storage policy.
        /// </summary>
        /// <param name="req"><see cref="OpenCoolDownPolicyRequest"/></param>
        /// <returns><see cref="OpenCoolDownPolicyResponse"/></returns>
        public OpenCoolDownPolicyResponse OpenCoolDownPolicySync(OpenCoolDownPolicyRequest req)
        {
            return InternalRequestAsync<OpenCoolDownPolicyResponse>(req, "OpenCoolDownPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query data according to the specified database and table names, and support field selection and pagination.
        /// </summary>
        /// <param name="req"><see cref="QueryTableDataRequest"/></param>
        /// <returns><see cref="QueryTableDataResponse"/></returns>
        public Task<QueryTableDataResponse> QueryTableData(QueryTableDataRequest req)
        {
            return InternalRequestAsync<QueryTableDataResponse>(req, "QueryTableData");
        }

        /// <summary>
        /// This API is used to query data according to the specified database and table names, and support field selection and pagination.
        /// </summary>
        /// <param name="req"><see cref="QueryTableDataRequest"/></param>
        /// <returns><see cref="QueryTableDataResponse"/></returns>
        public QueryTableDataResponse QueryTableDataSync(QueryTableDataRequest req)
        {
            return InternalRequestAsync<QueryTableDataResponse>(req, "QueryTableData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to back up and recover.
        /// </summary>
        /// <param name="req"><see cref="RecoverBackUpJobRequest"/></param>
        /// <returns><see cref="RecoverBackUpJobResponse"/></returns>
        public Task<RecoverBackUpJobResponse> RecoverBackUpJob(RecoverBackUpJobRequest req)
        {
            return InternalRequestAsync<RecoverBackUpJobResponse>(req, "RecoverBackUpJob");
        }

        /// <summary>
        /// This API is used to back up and recover.
        /// </summary>
        /// <param name="req"><see cref="RecoverBackUpJobRequest"/></param>
        /// <returns><see cref="RecoverBackUpJobResponse"/></returns>
        public RecoverBackUpJobResponse RecoverBackUpJobSync(RecoverBackUpJobRequest req)
        {
            return InternalRequestAsync<RecoverBackUpJobResponse>(req, "RecoverBackUpJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale in clusters.
        /// </summary>
        /// <param name="req"><see cref="ReduceInstanceRequest"/></param>
        /// <returns><see cref="ReduceInstanceResponse"/></returns>
        public Task<ReduceInstanceResponse> ReduceInstance(ReduceInstanceRequest req)
        {
            return InternalRequestAsync<ReduceInstanceResponse>(req, "ReduceInstance");
        }

        /// <summary>
        /// This API is used to scale in clusters.
        /// </summary>
        /// <param name="req"><see cref="ReduceInstanceRequest"/></param>
        /// <returns><see cref="ReduceInstanceResponse"/></returns>
        public ReduceInstanceResponse ReduceInstanceSync(ReduceInstanceRequest req)
        {
            return InternalRequestAsync<ReduceInstanceResponse>(req, "ReduceInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to expand cloud disks.
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk");
        }

        /// <summary>
        /// This API is used to expand cloud disks.
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart the cluster to make the configuration file take effect.
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForConfigsRequest"/></param>
        /// <returns><see cref="RestartClusterForConfigsResponse"/></returns>
        public Task<RestartClusterForConfigsResponse> RestartClusterForConfigs(RestartClusterForConfigsRequest req)
        {
            return InternalRequestAsync<RestartClusterForConfigsResponse>(req, "RestartClusterForConfigs");
        }

        /// <summary>
        /// This API is used to restart the cluster to make the configuration file take effect.
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForConfigsRequest"/></param>
        /// <returns><see cref="RestartClusterForConfigsResponse"/></returns>
        public RestartClusterForConfigsResponse RestartClusterForConfigsSync(RestartClusterForConfigsRequest req)
        {
            return InternalRequestAsync<RestartClusterForConfigsResponse>(req, "RestartClusterForConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to indicate the rolling restart of the clusters.
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForNodeRequest"/></param>
        /// <returns><see cref="RestartClusterForNodeResponse"/></returns>
        public Task<RestartClusterForNodeResponse> RestartClusterForNode(RestartClusterForNodeRequest req)
        {
            return InternalRequestAsync<RestartClusterForNodeResponse>(req, "RestartClusterForNode");
        }

        /// <summary>
        /// This API is used to indicate the rolling restart of the clusters.
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForNodeRequest"/></param>
        /// <returns><see cref="RestartClusterForNodeResponse"/></returns>
        public RestartClusterForNodeResponse RestartClusterForNodeSync(RestartClusterForNodeRequest req)
        {
            return InternalRequestAsync<RestartClusterForNodeResponse>(req, "RestartClusterForNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to horizontally scale out nodes.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// This API is used to horizontally scale out nodes.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale up/down computing resources.
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public Task<ScaleUpInstanceResponse> ScaleUpInstance(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance");
        }

        /// <summary>
        /// This API is used to scale up/down computing resources.
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public ScaleUpInstanceResponse ScaleUpInstanceSync(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the hot/cold data layering information on a cluster.
        /// </summary>
        /// <param name="req"><see cref="UpdateCoolDownRequest"/></param>
        /// <returns><see cref="UpdateCoolDownResponse"/></returns>
        public Task<UpdateCoolDownResponse> UpdateCoolDown(UpdateCoolDownRequest req)
        {
            return InternalRequestAsync<UpdateCoolDownResponse>(req, "UpdateCoolDown");
        }

        /// <summary>
        /// This API is used to update the hot/cold data layering information on a cluster.
        /// </summary>
        /// <param name="req"><see cref="UpdateCoolDownRequest"/></param>
        /// <returns><see cref="UpdateCoolDownResponse"/></returns>
        public UpdateCoolDownResponse UpdateCoolDownSync(UpdateCoolDownRequest req)
        {
            return InternalRequestAsync<UpdateCoolDownResponse>(req, "UpdateCoolDown")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a specified database, including setting the data volume quota, renaming the database, setting the replica quantity quota, and modifying other attributes of the database.
        /// </summary>
        /// <param name="req"><see cref="UpdateDatabaseRequest"/></param>
        /// <returns><see cref="UpdateDatabaseResponse"/></returns>
        public Task<UpdateDatabaseResponse> UpdateDatabase(UpdateDatabaseRequest req)
        {
            return InternalRequestAsync<UpdateDatabaseResponse>(req, "UpdateDatabase");
        }

        /// <summary>
        /// This API is used to modify the attributes of a specified database, including setting the data volume quota, renaming the database, setting the replica quantity quota, and modifying other attributes of the database.
        /// </summary>
        /// <param name="req"><see cref="UpdateDatabaseRequest"/></param>
        /// <returns><see cref="UpdateDatabaseResponse"/></returns>
        public UpdateDatabaseResponse UpdateDatabaseSync(UpdateDatabaseRequest req)
        {
            return InternalRequestAsync<UpdateDatabaseResponse>(req, "UpdateDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a specified table. The API parameters are consistent with those for creating a table.
        /// </summary>
        /// <param name="req"><see cref="UpdateTableSchemaRequest"/></param>
        /// <returns><see cref="UpdateTableSchemaResponse"/></returns>
        public Task<UpdateTableSchemaResponse> UpdateTableSchema(UpdateTableSchemaRequest req)
        {
            return InternalRequestAsync<UpdateTableSchemaResponse>(req, "UpdateTableSchema");
        }

        /// <summary>
        /// This API is used to modify the attributes of a specified table. The API parameters are consistent with those for creating a table.
        /// </summary>
        /// <param name="req"><see cref="UpdateTableSchemaRequest"/></param>
        /// <returns><see cref="UpdateTableSchemaResponse"/></returns>
        public UpdateTableSchemaResponse UpdateTableSchemaSync(UpdateTableSchemaRequest req)
        {
            return InternalRequestAsync<UpdateTableSchemaResponse>(req, "UpdateTableSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
