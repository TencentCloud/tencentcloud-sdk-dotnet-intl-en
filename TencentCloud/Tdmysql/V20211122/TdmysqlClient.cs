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

namespace TencentCloud.Tdmysql.V20211122
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdmysql.V20211122.Models;

   public class TdmysqlClient : AbstractClient{

       private const string endpoint = "tdmysql.intl.tencentcloudapi.com";
       private const string version = "2021-11-22";
       private const string sdkVersion = "SDK_NET_3.0.1340";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdmysqlClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdmysqlClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to lift isolation for instances in batch.
        /// </summary>
        /// <param name="req"><see cref="CancelIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="CancelIsolateDBInstancesResponse"/></returns>
        public Task<CancelIsolateDBInstancesResponse> CancelIsolateDBInstances(CancelIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<CancelIsolateDBInstancesResponse>(req, "CancelIsolateDBInstances");
        }

        /// <summary>
        /// This API is used to lift isolation for instances in batch.
        /// </summary>
        /// <param name="req"><see cref="CancelIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="CancelIsolateDBInstancesResponse"/></returns>
        public CancelIsolateDBInstancesResponse CancelIsolateDBInstancesSync(CancelIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<CancelIsolateDBInstancesResponse>(req, "CancelIsolateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create clone instances.
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public Task<CreateCloneInstanceResponse> CreateCloneInstance(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance");
        }

        /// <summary>
        /// This API is used to create clone instances.
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public CreateCloneInstanceResponse CreateCloneInstanceSync(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch create instances.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances");
        }

        /// <summary>
        /// This API is used to batch create instances.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a manual backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public Task<CreateDBSBackupResponse> CreateDBSBackup(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup");
        }

        /// <summary>
        /// This API is used to create a manual backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public CreateDBSBackupResponse CreateDBSBackupSync(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create users in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateUsersRequest"/></param>
        /// <returns><see cref="CreateUsersResponse"/></returns>
        public Task<CreateUsersResponse> CreateUsers(CreateUsersRequest req)
        {
            return InternalRequestAsync<CreateUsersResponse>(req, "CreateUsers");
        }

        /// <summary>
        /// This API is used to create users in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateUsersRequest"/></param>
        /// <returns><see cref="CreateUsersResponse"/></returns>
        public CreateUsersResponse CreateUsersSync(CreateUsersRequest req)
        {
            return InternalRequestAsync<CreateUsersResponse>(req, "CreateUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete manual backups of instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public Task<DeleteDBSBackupSetsResponse> DeleteDBSBackupSets(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets");
        }

        /// <summary>
        /// This API is used to delete manual backups of instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public DeleteDBSBackupSetsResponse DeleteDBSBackupSetsSync(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete users.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers");
        }

        /// <summary>
        /// This API is used to batch delete users.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetail(DescribeDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDetailResponse>(req, "DescribeDBInstanceDetail");
        }

        /// <summary>
        /// This API is used to query instance details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetailSync(DescribeDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDetailResponse>(req, "DescribeDBInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// This API is used to query instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the current parameter settings of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public Task<DescribeDBParametersResponse> DescribeDBParameters(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters");
        }

        /// <summary>
        /// This API is used to obtain the current parameter settings of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public DescribeDBParametersResponse DescribeDBParametersSync(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance archived WAL log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSArchiveLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSArchiveLogsResponse"/></returns>
        public Task<DescribeDBSArchiveLogsResponse> DescribeDBSArchiveLogs(DescribeDBSArchiveLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSArchiveLogsResponse>(req, "DescribeDBSArchiveLogs");
        }

        /// <summary>
        /// This API is used to query instance archived WAL log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSArchiveLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSArchiveLogsResponse"/></returns>
        public DescribeDBSArchiveLogsResponse DescribeDBSArchiveLogsSync(DescribeDBSArchiveLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSArchiveLogsResponse>(req, "DescribeDBSArchiveLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the recoverable time.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public Task<DescribeDBSAvailableRecoveryTimeResponse> DescribeDBSAvailableRecoveryTime(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime");
        }

        /// <summary>
        /// This API is used to obtain the recoverable time.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public DescribeDBSAvailableRecoveryTimeResponse DescribeDBSAvailableRecoveryTimeSync(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query an instance backup strategy
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupPolicyResponse"/></returns>
        public Task<DescribeDBSBackupPolicyResponse> DescribeDBSBackupPolicy(DescribeDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupPolicyResponse>(req, "DescribeDBSBackupPolicy");
        }

        /// <summary>
        /// Query an instance backup strategy
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupPolicyResponse"/></returns>
        public DescribeDBSBackupPolicyResponse DescribeDBSBackupPolicySync(DescribeDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupPolicyResponse>(req, "DescribeDBSBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance backup set information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupSetsResponse"/></returns>
        public Task<DescribeDBSBackupSetsResponse> DescribeDBSBackupSets(DescribeDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupSetsResponse>(req, "DescribeDBSBackupSets");
        }

        /// <summary>
        /// This API is used to query instance backup set information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupSetsResponse"/></returns>
        public DescribeDBSBackupSetsResponse DescribeDBSBackupSetsSync(DescribeDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupSetsResponse>(req, "DescribeDBSBackupSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance backup space overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsResponse"/></returns>
        public Task<DescribeDBSBackupStatisticsResponse> DescribeDBSBackupStatistics(DescribeDBSBackupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsResponse>(req, "DescribeDBSBackupStatistics");
        }

        /// <summary>
        /// This API is used to query instance backup space overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsResponse"/></returns>
        public DescribeDBSBackupStatisticsResponse DescribeDBSBackupStatisticsSync(DescribeDBSBackupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsResponse>(req, "DescribeDBSBackupStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query backup set statistical detail.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsDetailRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsDetailResponse"/></returns>
        public Task<DescribeDBSBackupStatisticsDetailResponse> DescribeDBSBackupStatisticsDetail(DescribeDBSBackupStatisticsDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsDetailResponse>(req, "DescribeDBSBackupStatisticsDetail");
        }

        /// <summary>
        /// This API is used to query backup set statistical detail.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsDetailRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsDetailResponse"/></returns>
        public DescribeDBSBackupStatisticsDetailResponse DescribeDBSBackupStatisticsDetailSync(DescribeDBSBackupStatisticsDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsDetailResponse>(req, "DescribeDBSBackupStatisticsDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query clone list
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSCloneInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBSCloneInstancesResponse"/></returns>
        public Task<DescribeDBSCloneInstancesResponse> DescribeDBSCloneInstances(DescribeDBSCloneInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBSCloneInstancesResponse>(req, "DescribeDBSCloneInstances");
        }

        /// <summary>
        /// Query clone list
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSCloneInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBSCloneInstancesResponse"/></returns>
        public DescribeDBSCloneInstancesResponse DescribeDBSCloneInstancesSync(DescribeDBSCloneInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBSCloneInstancesResponse>(req, "DescribeDBSCloneInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance security group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// This API is used to query instance security group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the object list in the database of a cloud database instance, including table, stored procedure, view and function.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public Task<DescribeDatabaseObjectsResponse> DescribeDatabaseObjects(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects");
        }

        /// <summary>
        /// This API is used to query the object list in the database of a cloud database instance, including table, stored procedure, view and function.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public DescribeDatabaseObjectsResponse DescribeDatabaseObjectsSync(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the database list of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// This API is used to query the database list of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the process status of an asynchronous task.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow");
        }

        /// <summary>
        /// This API is used to query the process status of an asynchronous task.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the SSL status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceSSLStatusResponse"/></returns>
        public Task<DescribeInstanceSSLStatusResponse> DescribeInstanceSSLStatus(DescribeInstanceSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSSLStatusResponse>(req, "DescribeInstanceSSLStatus");
        }

        /// <summary>
        /// This API is used to query the SSL status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceSSLStatusResponse"/></returns>
        public DescribeInstanceSSLStatusResponse DescribeInstanceSSLStatusSync(DescribeInstanceSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSSLStatusResponse>(req, "DescribeInstanceSSLStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query maintenance time window configurations
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public Task<DescribeMaintenanceWindowResponse> DescribeMaintenanceWindow(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow");
        }

        /// <summary>
        /// Query maintenance time window configurations
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public DescribeMaintenanceWindowResponse DescribeMaintenanceWindowSync(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query available regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleInfoResponse"/></returns>
        public Task<DescribeSaleInfoResponse> DescribeSaleInfo(DescribeSaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeSaleInfoResponse>(req, "DescribeSaleInfo");
        }

        /// <summary>
        /// This API is used to query available regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleInfoResponse"/></returns>
        public DescribeSaleInfoResponse DescribeSaleInfoSync(DescribeSaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeSaleInfoResponse>(req, "DescribeSaleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query slow logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs");
        }

        /// <summary>
        /// This API is used to query slow logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list available component specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecsRequest"/></param>
        /// <returns><see cref="DescribeSpecsResponse"/></returns>
        public Task<DescribeSpecsResponse> DescribeSpecs(DescribeSpecsRequest req)
        {
            return InternalRequestAsync<DescribeSpecsResponse>(req, "DescribeSpecs");
        }

        /// <summary>
        /// This API is used to list available component specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecsRequest"/></param>
        /// <returns><see cref="DescribeSpecsResponse"/></returns>
        public DescribeSpecsResponse DescribeSpecsSync(DescribeSpecsRequest req)
        {
            return InternalRequestAsync<DescribeSpecsResponse>(req, "DescribeSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeUserPrivilegesResponse"/></returns>
        public Task<DescribeUserPrivilegesResponse> DescribeUserPrivileges(DescribeUserPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeUserPrivilegesResponse>(req, "DescribeUserPrivileges");
        }

        /// <summary>
        /// This API is used to query user permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeUserPrivilegesResponse"/></returns>
        public DescribeUserPrivilegesResponse DescribeUserPrivilegesSync(DescribeUserPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeUserPrivilegesResponse>(req, "DescribeUserPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers");
        }

        /// <summary>
        /// This API is used to query user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to destroy instances in batch.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstancesRequest"/></param>
        /// <returns><see cref="DestroyInstancesResponse"/></returns>
        public Task<DestroyInstancesResponse> DestroyInstances(DestroyInstancesRequest req)
        {
            return InternalRequestAsync<DestroyInstancesResponse>(req, "DestroyInstances");
        }

        /// <summary>
        /// This API is used to destroy instances in batch.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstancesRequest"/></param>
        /// <returns><see cref="DestroyInstancesResponse"/></returns>
        public DestroyInstancesResponse DestroyInstancesSync(DestroyInstancesRequest req)
        {
            return InternalRequestAsync<DestroyInstancesResponse>(req, "DestroyInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to horizontally scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ExpandInstanceRequest"/></param>
        /// <returns><see cref="ExpandInstanceResponse"/></returns>
        public Task<ExpandInstanceResponse> ExpandInstance(ExpandInstanceRequest req)
        {
            return InternalRequestAsync<ExpandInstanceResponse>(req, "ExpandInstance");
        }

        /// <summary>
        /// This API is used to horizontally scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ExpandInstanceRequest"/></param>
        /// <returns><see cref="ExpandInstanceResponse"/></returns>
        public ExpandInstanceResponse ExpandInstanceSync(ExpandInstanceRequest req)
        {
            return InternalRequestAsync<ExpandInstanceResponse>(req, "ExpandInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch isolate instances.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// This API is used to batch isolate instances.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag");
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cloud database security groups.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API is used to modify cloud database security groups.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the VPC port of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVPortRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVPortResponse"/></returns>
        public Task<ModifyDBInstanceVPortResponse> ModifyDBInstanceVPort(ModifyDBInstanceVPortRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceVPortResponse>(req, "ModifyDBInstanceVPort");
        }

        /// <summary>
        /// This API is used to modify the VPC port of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVPortRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVPortResponse"/></returns>
        public ModifyDBInstanceVPortResponse ModifyDBInstanceVPortSync(ModifyDBInstanceVPortRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceVPortResponse>(req, "ModifyDBInstanceVPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters");
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public ModifyDBParametersResponse ModifyDBParametersSync(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the instance backup strategy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public Task<ModifyDBSBackupPolicyResponse> ModifyDBSBackupPolicy(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy");
        }

        /// <summary>
        /// This API is used to modify the instance backup strategy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public ModifyDBSBackupPolicyResponse ModifyDBSBackupPolicySync(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify backup notes of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupSetCommentRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupSetCommentResponse"/></returns>
        public Task<ModifyDBSBackupSetCommentResponse> ModifyDBSBackupSetComment(ModifyDBSBackupSetCommentRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupSetCommentResponse>(req, "ModifyDBSBackupSetComment");
        }

        /// <summary>
        /// This API is used to modify backup notes of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupSetCommentRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupSetCommentResponse"/></returns>
        public ModifyDBSBackupSetCommentResponse ModifyDBSBackupSetCommentSync(ModifyDBSBackupSetCommentRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupSetCommentResponse>(req, "ModifyDBSBackupSetComment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance name.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName");
        }

        /// <summary>
        /// This API is used to modify instance name.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the network to which the instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public Task<ModifyInstanceNetworkResponse> ModifyInstanceNetwork(ModifyInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNetworkResponse>(req, "ModifyInstanceNetwork");
        }

        /// <summary>
        /// This API is used to modify the network to which the instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public ModifyInstanceNetworkResponse ModifyInstanceNetworkSync(ModifyInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNetworkResponse>(req, "ModifyInstanceNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable the SSL feature of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceSSLStatusRequest"/></param>
        /// <returns><see cref="ModifyInstanceSSLStatusResponse"/></returns>
        public Task<ModifyInstanceSSLStatusResponse> ModifyInstanceSSLStatus(ModifyInstanceSSLStatusRequest req)
        {
            return InternalRequestAsync<ModifyInstanceSSLStatusResponse>(req, "ModifyInstanceSSLStatus");
        }

        /// <summary>
        /// This API is used to enable or disable the SSL feature of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceSSLStatusRequest"/></param>
        /// <returns><see cref="ModifyInstanceSSLStatusResponse"/></returns>
        public ModifyInstanceSSLStatusResponse ModifyInstanceSSLStatusSync(ModifyInstanceSSLStatusRequest req)
        {
            return InternalRequestAsync<ModifyInstanceSSLStatusResponse>(req, "ModifyInstanceSSLStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add new or modify instance maintenance time window configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public Task<ModifyMaintenanceWindowResponse> ModifyMaintenanceWindow(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow");
        }

        /// <summary>
        /// Add new or modify instance maintenance time window configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public ModifyMaintenanceWindowResponse ModifyMaintenanceWindowSync(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyUserPrivilegesResponse"/></returns>
        public Task<ModifyUserPrivilegesResponse> ModifyUserPrivileges(ModifyUserPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesResponse>(req, "ModifyUserPrivileges");
        }

        /// <summary>
        /// This API is used to modify user permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyUserPrivilegesResponse"/></returns>
        public ModifyUserPrivilegesResponse ModifyUserPrivilegesSync(ModifyUserPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesResponse>(req, "ModifyUserPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset user password.
        /// </summary>
        /// <param name="req"><see cref="ResetUserPasswordRequest"/></param>
        /// <returns><see cref="ResetUserPasswordResponse"/></returns>
        public Task<ResetUserPasswordResponse> ResetUserPassword(ResetUserPasswordRequest req)
        {
            return InternalRequestAsync<ResetUserPasswordResponse>(req, "ResetUserPassword");
        }

        /// <summary>
        /// This API is used to reset user password.
        /// </summary>
        /// <param name="req"><see cref="ResetUserPasswordRequest"/></param>
        /// <returns><see cref="ResetUserPasswordResponse"/></returns>
        public ResetUserPasswordResponse ResetUserPasswordSync(ResetUserPasswordRequest req)
        {
            return InternalRequestAsync<ResetUserPasswordResponse>(req, "ResetUserPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch reset user password.
        /// </summary>
        /// <param name="req"><see cref="ResetUsersPasswordRequest"/></param>
        /// <returns><see cref="ResetUsersPasswordResponse"/></returns>
        public Task<ResetUsersPasswordResponse> ResetUsersPassword(ResetUsersPasswordRequest req)
        {
            return InternalRequestAsync<ResetUsersPasswordResponse>(req, "ResetUsersPassword");
        }

        /// <summary>
        /// This API is used to batch reset user password.
        /// </summary>
        /// <param name="req"><see cref="ResetUsersPasswordRequest"/></param>
        /// <returns><see cref="ResetUsersPasswordResponse"/></returns>
        public ResetUsersPasswordResponse ResetUsersPasswordSync(ResetUsersPasswordRequest req)
        {
            return InternalRequestAsync<ResetUsersPasswordResponse>(req, "ResetUsersPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart database instances.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public Task<RestartDBInstancesResponse> RestartDBInstances(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances");
        }

        /// <summary>
        /// This API is used to restart database instances.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public RestartDBInstancesResponse RestartDBInstancesSync(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale up a TDSQL Boundless instance, which can be a primary instance or a disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// This API is used to scale up a TDSQL Boundless instance, which can be a primary instance or a disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
