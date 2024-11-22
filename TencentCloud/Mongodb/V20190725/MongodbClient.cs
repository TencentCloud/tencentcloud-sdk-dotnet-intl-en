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

namespace TencentCloud.Mongodb.V20190725
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mongodb.V20190725.Models;

   public class MongodbClient : AbstractClient{

       private const string endpoint = "mongodb.tencentcloudapi.com";
       private const string version = "2019-07-25";
       private const string sdkVersion = "SDK_NET_3.0.1018";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MongodbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MongodbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to specify the project to which a TencentDB instance belongs.
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public Task<AssignProjectResponse> AssignProject(AssignProjectRequest req)
        {
            return InternalRequestAsync<AssignProjectResponse>(req, "AssignProject");
        }

        /// <summary>
        /// This API is used to specify the project to which a TencentDB instance belongs.
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public AssignProjectResponse AssignProjectSync(AssignProjectRequest req)
        {
            return InternalRequestAsync<AssignProjectResponse>(req, "AssignProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create instance backups.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDBInstanceRequest"/></param>
        /// <returns><see cref="CreateBackupDBInstanceResponse"/></returns>
        public Task<CreateBackupDBInstanceResponse> CreateBackupDBInstance(CreateBackupDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateBackupDBInstanceResponse>(req, "CreateBackupDBInstance");
        }

        /// <summary>
        /// This API is used to create instance backups.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDBInstanceRequest"/></param>
        /// <returns><see cref="CreateBackupDBInstanceResponse"/></returns>
        public CreateBackupDBInstanceResponse CreateBackupDBInstanceSync(CreateBackupDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateBackupDBInstanceResponse>(req, "CreateBackupDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a backup download task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateBackupDownloadTaskResponse"/></returns>
        public Task<CreateBackupDownloadTaskResponse> CreateBackupDownloadTask(CreateBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateBackupDownloadTaskResponse>(req, "CreateBackupDownloadTask");
        }

        /// <summary>
        /// This API is used to create a backup download task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateBackupDownloadTaskResponse"/></returns>
        public CreateBackupDownloadTaskResponse CreateBackupDownloadTaskSync(CreateBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateBackupDownloadTaskResponse>(req, "CreateBackupDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a monthly subscription TencentDB for MongoDB instance. The purchasable specifications supported by this API can be obtained through the `DescribeSpecInfo` API.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance");
        }

        /// <summary>
        /// This API is used to create a monthly subscription TencentDB for MongoDB instance. The purchasable specifications supported by this API can be obtained through the `DescribeSpecInfo` API.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public Task<CreateDBInstanceHourResponse> CreateDBInstanceHour(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour");
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public CreateDBInstanceHourResponse CreateDBInstanceHourSync(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query async task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// This API is used to query async task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query backup download task information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public Task<DescribeBackupDownloadTaskResponse> DescribeBackupDownloadTask(DescribeBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadTaskResponse>(req, "DescribeBackupDownloadTask");
        }

        /// <summary>
        /// This API is used to query backup download task information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public DescribeBackupDownloadTaskResponse DescribeBackupDownloadTaskSync(DescribeBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadTaskResponse>(req, "DescribeBackupDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the client connection information of an instance, including the IP and number of connections. Currently, only instances of MongoDB 3.2 are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public Task<DescribeClientConnectionsResponse> DescribeClientConnections(DescribeClientConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeClientConnectionsResponse>(req, "DescribeClientConnections");
        }

        /// <summary>
        /// This API is used to query the client connection information of an instance, including the IP and number of connections. Currently, only instances of MongoDB 3.2 are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public DescribeClientConnectionsResponse DescribeClientConnectionsSync(DescribeClientConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeClientConnectionsResponse>(req, "DescribeClientConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of instance backups. Currently, only backups created in the last seven days can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public Task<DescribeDBBackupsResponse> DescribeDBBackups(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups");
        }

        /// <summary>
        /// This API is used to query the list of instance backups. Currently, only backups created in the last seven days can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public DescribeDBBackupsResponse DescribeDBBackupsSync(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get details of purchase, renewal, and specification adjustment orders of a MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public Task<DescribeDBInstanceDealResponse> DescribeDBInstanceDeal(DescribeDBInstanceDealRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDealResponse>(req, "DescribeDBInstanceDeal");
        }

        /// <summary>
        /// This API is used to get details of purchase, renewal, and specification adjustment orders of a MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public DescribeDBInstanceDealResponse DescribeDBInstanceDealSync(DescribeDBInstanceDealRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDealResponse>(req, "DescribeDBInstanceDeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TencentDB instances (which can be primary, disaster recovery, or read-only instances). It supports filtering instances by project ID, instance ID, and instance status.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// This API is used to query the list of TencentDB instances (which can be primary, disaster recovery, or read-only instances). It supports filtering instances by project ID, instance ID, and instance status.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the modifiable parameter list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// This API is used to query the modifiable parameter list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security groups associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupResponse"/></returns>
        public Task<DescribeSecurityGroupResponse> DescribeSecurityGroup(DescribeSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupResponse>(req, "DescribeSecurityGroup");
        }

        /// <summary>
        /// This API is used to query the security groups associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupResponse"/></returns>
        public DescribeSecurityGroupResponse DescribeSecurityGroupSync(DescribeSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupResponse>(req, "DescribeSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the slow log statistics of a database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogPatternsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogPatternsResponse"/></returns>
        public Task<DescribeSlowLogPatternsResponse> DescribeSlowLogPatterns(DescribeSlowLogPatternsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogPatternsResponse>(req, "DescribeSlowLogPatterns");
        }

        /// <summary>
        /// This API is used to get the slow log statistics of a database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogPatternsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogPatternsResponse"/></returns>
        public DescribeSlowLogPatternsResponse DescribeSlowLogPatternsSync(DescribeSlowLogPatternsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogPatternsResponse>(req, "DescribeSlowLogPatterns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the slow log information of a TencentDB instance. Only slow logs for the last 7 days can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs");
        }

        /// <summary>
        /// This API is used to get the slow log information of a TencentDB instance. Only slow logs for the last 7 days can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public Task<DescribeSpecInfoResponse> DescribeSpecInfo(DescribeSpecInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpecInfoResponse>(req, "DescribeSpecInfo");
        }

        /// <summary>
        /// This API is used to query the purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public DescribeSpecInfoResponse DescribeSpecInfoSync(DescribeSpecInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpecInfoResponse>(req, "DescribeSpecInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to run the `FlushRouterConfig` command on all mongos instances.
        /// </summary>
        /// <param name="req"><see cref="FlushInstanceRouterConfigRequest"/></param>
        /// <returns><see cref="FlushInstanceRouterConfigResponse"/></returns>
        public Task<FlushInstanceRouterConfigResponse> FlushInstanceRouterConfig(FlushInstanceRouterConfigRequest req)
        {
            return InternalRequestAsync<FlushInstanceRouterConfigResponse>(req, "FlushInstanceRouterConfig");
        }

        /// <summary>
        /// This API is used to run the `FlushRouterConfig` command on all mongos instances.
        /// </summary>
        /// <param name="req"><see cref="FlushInstanceRouterConfigRequest"/></param>
        /// <returns><see cref="FlushInstanceRouterConfigResponse"/></returns>
        public FlushInstanceRouterConfigResponse FlushInstanceRouterConfigSync(FlushInstanceRouterConfigRequest req)
        {
            return InternalRequestAsync<FlushInstanceRouterConfigResponse>(req, "FlushInstanceRouterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query price of instance creation. The `region` parameter must be passed in this API, otherwise verification will fail. This API allows queries only for purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDBInstancesResponse"/></returns>
        public Task<InquirePriceCreateDBInstancesResponse> InquirePriceCreateDBInstances(InquirePriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDBInstancesResponse>(req, "InquirePriceCreateDBInstances");
        }

        /// <summary>
        /// This API is used to query price of instance creation. The `region` parameter must be passed in this API, otherwise verification will fail. This API allows queries only for purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDBInstancesResponse"/></returns>
        public InquirePriceCreateDBInstancesResponse InquirePriceCreateDBInstancesSync(InquirePriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDBInstancesResponse>(req, "InquirePriceCreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of instance specification adjustment.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDBInstanceSpecResponse"/></returns>
        public Task<InquirePriceModifyDBInstanceSpecResponse> InquirePriceModifyDBInstanceSpec(InquirePriceModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDBInstanceSpecResponse>(req, "InquirePriceModifyDBInstanceSpec");
        }

        /// <summary>
        /// This API is used to query the price of instance specification adjustment.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDBInstanceSpecResponse"/></returns>
        public InquirePriceModifyDBInstanceSpecResponse InquirePriceModifyDBInstanceSpecSync(InquirePriceModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDBInstanceSpecResponse>(req, "InquirePriceModifyDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the renewal price of a monthly subscription instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDBInstancesResponse"/></returns>
        public Task<InquirePriceRenewDBInstancesResponse> InquirePriceRenewDBInstances(InquirePriceRenewDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDBInstancesResponse>(req, "InquirePriceRenewDBInstances");
        }

        /// <summary>
        /// This API is used to query the renewal price of a monthly subscription instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDBInstancesResponse"/></returns>
        public InquirePriceRenewDBInstancesResponse InquirePriceRenewDBInstancesSync(InquirePriceRenewDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDBInstancesResponse>(req, "InquirePriceRenewDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a pay-as-you-go TencentDB for MongoDB instance. An isolated instance is retained in the recycle bin and data can no longer be written to it. After it is isolated for a certain period of time, it will be completely deleted. For the retention period in the recycle bin, please see the terms of service for pay-as-you-go billing. Isolated pay-as-you-go instances cannot be recovered, so please proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// This API is used to isolate a pay-as-you-go TencentDB for MongoDB instance. An isolated instance is retained in the recycle bin and data can no longer be written to it. After it is isolated for a certain period of time, it will be completely deleted. For the retention period in the recycle bin, please see the terms of service for pay-as-you-go billing. Isolated pay-as-you-go instances cannot be recovered, so please proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the network settings of a TencentDB instance, such as switching its network type from classic network to VPC or between VPCs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public Task<ModifyDBInstanceNetworkAddressResponse> ModifyDBInstanceNetworkAddress(ModifyDBInstanceNetworkAddressRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkAddressResponse>(req, "ModifyDBInstanceNetworkAddress");
        }

        /// <summary>
        /// This API is used to modify the network settings of a TencentDB instance, such as switching its network type from classic network to VPC or between VPCs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public ModifyDBInstanceNetworkAddressResponse ModifyDBInstanceNetworkAddressSync(ModifyDBInstanceNetworkAddressRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkAddressResponse>(req, "ModifyDBInstanceNetworkAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the security groups associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupResponse> ModifyDBInstanceSecurityGroup(ModifyDBInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupResponse>(req, "ModifyDBInstanceSecurityGroup");
        }

        /// <summary>
        /// This API is used to modify the security groups associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public ModifyDBInstanceSecurityGroupResponse ModifyDBInstanceSecurityGroupSync(ModifyDBInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupResponse>(req, "ModifyDBInstanceSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the specification configuration of a TencentDB for MongoDB. The purchasable specifications supported by the API can be obtained through the DescribeSpecInfo API.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec");
        }

        /// <summary>
        /// This API is used to adjust the specification configuration of a TencentDB for MongoDB. The purchasable specifications supported by the API can be obtained through the DescribeSpecInfo API.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecSync(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deactivate isolated TencentDB instances immediately. The instances must be in isolated status.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineIsolatedDBInstanceResponse"/></returns>
        public Task<OfflineIsolatedDBInstanceResponse> OfflineIsolatedDBInstance(OfflineIsolatedDBInstanceRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedDBInstanceResponse>(req, "OfflineIsolatedDBInstance");
        }

        /// <summary>
        /// This API is used to deactivate isolated TencentDB instances immediately. The instances must be in isolated status.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineIsolatedDBInstanceResponse"/></returns>
        public OfflineIsolatedDBInstanceResponse OfflineIsolatedDBInstanceSync(OfflineIsolatedDBInstanceRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedDBInstanceResponse>(req, "OfflineIsolatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="RenameInstanceRequest"/></param>
        /// <returns><see cref="RenameInstanceResponse"/></returns>
        public Task<RenameInstanceResponse> RenameInstance(RenameInstanceRequest req)
        {
            return InternalRequestAsync<RenameInstanceResponse>(req, "RenameInstance");
        }

        /// <summary>
        /// This API is used to rename a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="RenameInstanceRequest"/></param>
        /// <returns><see cref="RenameInstanceResponse"/></returns>
        public RenameInstanceResponse RenameInstanceSync(RenameInstanceRequest req)
        {
            return InternalRequestAsync<RenameInstanceResponse>(req, "RenameInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew a monthly subscription TencentDB instance. Only monthly subscription instances are supported, while pay-as-you-go instances do not need to be renewed.
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstancesRequest"/></param>
        /// <returns><see cref="RenewDBInstancesResponse"/></returns>
        public Task<RenewDBInstancesResponse> RenewDBInstances(RenewDBInstancesRequest req)
        {
            return InternalRequestAsync<RenewDBInstancesResponse>(req, "RenewDBInstances");
        }

        /// <summary>
        /// This API is used to renew a monthly subscription TencentDB instance. Only monthly subscription instances are supported, while pay-as-you-go instances do not need to be renewed.
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstancesRequest"/></param>
        /// <returns><see cref="RenewDBInstancesResponse"/></returns>
        public RenewDBInstancesResponse RenewDBInstancesSync(RenewDBInstancesRequest req)
        {
            return InternalRequestAsync<RenewDBInstancesResponse>(req, "RenewDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance password.
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public Task<ResetDBInstancePasswordResponse> ResetDBInstancePassword(ResetDBInstancePasswordRequest req)
        {
            return InternalRequestAsync<ResetDBInstancePasswordResponse>(req, "ResetDBInstancePassword");
        }

        /// <summary>
        /// This API is used to modify instance password.
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public ResetDBInstancePasswordResponse ResetDBInstancePasswordSync(ResetDBInstancePasswordRequest req)
        {
            return InternalRequestAsync<ResetDBInstancePasswordResponse>(req, "ResetDBInstancePassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
