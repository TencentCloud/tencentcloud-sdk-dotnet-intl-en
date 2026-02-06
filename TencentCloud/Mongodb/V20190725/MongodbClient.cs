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

namespace TencentCloud.Mongodb.V20190725
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mongodb.V20190725.Models;

   public class MongodbClient : AbstractClient{

       private const string endpoint = "mongodb.intl.tencentcloudapi.com";
       private const string version = "2019-07-25";
       private const string sdkVersion = "SDK_NET_3.0.1262";

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
        /// This API is used to specify the project of a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public Task<AssignProjectResponse> AssignProject(AssignProjectRequest req)
        {
            return InternalRequestAsync<AssignProjectResponse>(req, "AssignProject");
        }

        /// <summary>
        /// This API is used to specify the project of a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public AssignProjectResponse AssignProjectSync(AssignProjectRequest req)
        {
            return InternalRequestAsync<AssignProjectResponse>(req, "AssignProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to customize an account to access the instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountUserRequest"/></param>
        /// <returns><see cref="CreateAccountUserResponse"/></returns>
        public Task<CreateAccountUserResponse> CreateAccountUser(CreateAccountUserRequest req)
        {
            return InternalRequestAsync<CreateAccountUserResponse>(req, "CreateAccountUser");
        }

        /// <summary>
        /// This API is used to customize an account to access the instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountUserRequest"/></param>
        /// <returns><see cref="CreateAccountUserResponse"/></returns>
        public CreateAccountUserResponse CreateAccountUserSync(CreateAccountUserRequest req)
        {
            return InternalRequestAsync<CreateAccountUserResponse>(req, "CreateAccountUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to back up an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDBInstanceRequest"/></param>
        /// <returns><see cref="CreateBackupDBInstanceResponse"/></returns>
        public Task<CreateBackupDBInstanceResponse> CreateBackupDBInstance(CreateBackupDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateBackupDBInstanceResponse>(req, "CreateBackupDBInstance");
        }

        /// <summary>
        /// This API is used to back up an instance.
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
        /// This API is used to create a yearly/monthly subscription TencentDB for MongoDB instance. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/35767?from_cn_redirect=1) API can be called to query and obtain the supported sales specifications.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance");
        }

        /// <summary>
        /// This API is used to create a yearly/monthly subscription TencentDB for MongoDB instance. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/35767?from_cn_redirect=1) API can be called to query and obtain the supported sales specifications.
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
        /// This API is used to create a log download task.
        /// </summary>
        /// <param name="req"><see cref="CreateLogDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLogDownloadTaskResponse"/></returns>
        public Task<CreateLogDownloadTaskResponse> CreateLogDownloadTask(CreateLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLogDownloadTaskResponse>(req, "CreateLogDownloadTask");
        }

        /// <summary>
        /// This API is used to create a log download task.
        /// </summary>
        /// <param name="req"><see cref="CreateLogDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLogDownloadTaskResponse"/></returns>
        public CreateLogDownloadTaskResponse CreateLogDownloadTaskSync(CreateLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLogDownloadTaskResponse>(req, "CreateLogDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom account of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountUserRequest"/></param>
        /// <returns><see cref="DeleteAccountUserResponse"/></returns>
        public Task<DeleteAccountUserResponse> DeleteAccountUser(DeleteAccountUserRequest req)
        {
            return InternalRequestAsync<DeleteAccountUserResponse>(req, "DeleteAccountUser");
        }

        /// <summary>
        /// This API is used to delete a custom account of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountUserRequest"/></param>
        /// <returns><see cref="DeleteAccountUserResponse"/></returns>
        public DeleteAccountUserResponse DeleteAccountUserSync(DeleteAccountUserRequest req)
        {
            return InternalRequestAsync<DeleteAccountUserResponse>(req, "DeleteAccountUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a log download task.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogDownloadTaskRequest"/></param>
        /// <returns><see cref="DeleteLogDownloadTaskResponse"/></returns>
        public Task<DeleteLogDownloadTaskResponse> DeleteLogDownloadTask(DeleteLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<DeleteLogDownloadTaskResponse>(req, "DeleteLogDownloadTask");
        }

        /// <summary>
        /// This API is used to delete a log download task.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogDownloadTaskRequest"/></param>
        /// <returns><see cref="DeleteLogDownloadTaskResponse"/></returns>
        public DeleteLogDownloadTaskResponse DeleteLogDownloadTaskSync(DeleteLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<DeleteLogDownloadTaskResponse>(req, "DeleteLogDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the asynchronous task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// This API is used to query the asynchronous task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information about the backup download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public Task<DescribeBackupDownloadTaskResponse> DescribeBackupDownloadTask(DescribeBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadTaskResponse>(req, "DescribeBackupDownloadTask");
        }

        /// <summary>
        /// This API is used to query information about the backup download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public DescribeBackupDownloadTaskResponse DescribeBackupDownloadTaskSync(DescribeBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadTaskResponse>(req, "DescribeBackupDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the automatic backup configuration information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRulesRequest"/></param>
        /// <returns><see cref="DescribeBackupRulesResponse"/></returns>
        public Task<DescribeBackupRulesResponse> DescribeBackupRules(DescribeBackupRulesRequest req)
        {
            return InternalRequestAsync<DescribeBackupRulesResponse>(req, "DescribeBackupRules");
        }

        /// <summary>
        /// This API is used to obtain the automatic backup configuration information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRulesRequest"/></param>
        /// <returns><see cref="DescribeBackupRulesResponse"/></returns>
        public DescribeBackupRulesResponse DescribeBackupRulesSync(DescribeBackupRulesRequest req)
        {
            return InternalRequestAsync<DescribeBackupRulesResponse>(req, "DescribeBackupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the client connection information on an instance, including the IP address for connection and the number of connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public Task<DescribeClientConnectionsResponse> DescribeClientConnections(DescribeClientConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeClientConnectionsResponse>(req, "DescribeClientConnections");
        }

        /// <summary>
        /// This API is used to query the client connection information on an instance, including the IP address for connection and the number of connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public DescribeClientConnectionsResponse DescribeClientConnectionsSync(DescribeClientConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeClientConnectionsResponse>(req, "DescribeClientConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the operation currently being performed on a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentOpRequest"/></param>
        /// <returns><see cref="DescribeCurrentOpResponse"/></returns>
        public Task<DescribeCurrentOpResponse> DescribeCurrentOp(DescribeCurrentOpRequest req)
        {
            return InternalRequestAsync<DescribeCurrentOpResponse>(req, "DescribeCurrentOp");
        }

        /// <summary>
        /// This API is used to query the operation currently being performed on a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentOpRequest"/></param>
        /// <returns><see cref="DescribeCurrentOpResponse"/></returns>
        public DescribeCurrentOpResponse DescribeCurrentOpSync(DescribeCurrentOpRequest req)
        {
            return InternalRequestAsync<DescribeCurrentOpResponse>(req, "DescribeCurrentOp")
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
        /// This API is used to get order details of purchase, renewal, and specification adjustment of a MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public Task<DescribeDBInstanceDealResponse> DescribeDBInstanceDeal(DescribeDBInstanceDealRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDealResponse>(req, "DescribeDBInstanceDeal");
        }

        /// <summary>
        /// This API is used to get order details of purchase, renewal, and specification adjustment of a MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public DescribeDBInstanceDealResponse DescribeDBInstanceDealSync(DescribeDBInstanceDealRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDealResponse>(req, "DescribeDBInstanceDeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the table information on a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNamespaceRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNamespaceResponse"/></returns>
        public Task<DescribeDBInstanceNamespaceResponse> DescribeDBInstanceNamespace(DescribeDBInstanceNamespaceRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNamespaceResponse>(req, "DescribeDBInstanceNamespace");
        }

        /// <summary>
        /// This API is used to query the table information on a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNamespaceRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNamespaceResponse"/></returns>
        public DescribeDBInstanceNamespaceResponse DescribeDBInstanceNamespaceSync(DescribeDBInstanceNamespaceRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNamespaceResponse>(req, "DescribeDBInstanceNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query node attributes, such as the AZ, node name, address, role, status, delay between primary and secondary nodes, priority, voting right, and tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNodePropertyRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNodePropertyResponse"/></returns>
        public Task<DescribeDBInstanceNodePropertyResponse> DescribeDBInstanceNodeProperty(DescribeDBInstanceNodePropertyRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNodePropertyResponse>(req, "DescribeDBInstanceNodeProperty");
        }

        /// <summary>
        /// This API is used to query node attributes, such as the AZ, node name, address, role, status, delay between primary and secondary nodes, priority, voting right, and tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNodePropertyRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNodePropertyResponse"/></returns>
        public DescribeDBInstanceNodePropertyResponse DescribeDBInstanceNodePropertySync(DescribeDBInstanceNodePropertyRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNodePropertyResponse>(req, "DescribeDBInstanceNodeProperty")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TencentDB for MongoDB instances. It supports filtering primary instances, disaster recovery instances, and read-only instances by project ID, instance ID, instance status, and other conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// This API is used to query the list of TencentDB for MongoDB instances. It supports filtering primary instances, disaster recovery instances, and read-only instances by project ID, instance ID, instance status, and other conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query slow log details of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDetailedSlowLogsResponse"/></returns>
        public Task<DescribeDetailedSlowLogsResponse> DescribeDetailedSlowLogs(DescribeDetailedSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDetailedSlowLogsResponse>(req, "DescribeDetailedSlowLogs");
        }

        /// <summary>
        /// This API is used to query slow log details of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDetailedSlowLogsResponse"/></returns>
        public DescribeDetailedSlowLogsResponse DescribeDetailedSlowLogsSync(DescribeDetailedSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDetailedSlowLogsResponse>(req, "DescribeDetailedSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of parameters that can be modified for the current instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// This API is used to query the list of parameters that can be modified for the current instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the enabling status of Secure Sockets Layer (SSL) for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSSLRequest"/></param>
        /// <returns><see cref="DescribeInstanceSSLResponse"/></returns>
        public Task<DescribeInstanceSSLResponse> DescribeInstanceSSL(DescribeInstanceSSLRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSSLResponse>(req, "DescribeInstanceSSL");
        }

        /// <summary>
        /// This API is used to view the enabling status of Secure Sockets Layer (SSL) for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSSLRequest"/></param>
        /// <returns><see cref="DescribeInstanceSSLResponse"/></returns>
        public DescribeInstanceSSLResponse DescribeInstanceSSLSync(DescribeInstanceSSLRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSSLResponse>(req, "DescribeInstanceSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a log download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDownloadTasksRequest"/></param>
        /// <returns><see cref="DescribeLogDownloadTasksResponse"/></returns>
        public Task<DescribeLogDownloadTasksResponse> DescribeLogDownloadTasks(DescribeLogDownloadTasksRequest req)
        {
            return InternalRequestAsync<DescribeLogDownloadTasksResponse>(req, "DescribeLogDownloadTasks");
        }

        /// <summary>
        /// This API is used to query a log download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDownloadTasksRequest"/></param>
        /// <returns><see cref="DescribeLogDownloadTasksResponse"/></returns>
        public DescribeLogDownloadTasksResponse DescribeLogDownloadTasksSync(DescribeLogDownloadTasksRequest req)
        {
            return InternalRequestAsync<DescribeLogDownloadTasksResponse>(req, "DescribeLogDownloadTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query running logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMongodbLogsRequest"/></param>
        /// <returns><see cref="DescribeMongodbLogsResponse"/></returns>
        public Task<DescribeMongodbLogsResponse> DescribeMongodbLogs(DescribeMongodbLogsRequest req)
        {
            return InternalRequestAsync<DescribeMongodbLogsResponse>(req, "DescribeMongodbLogs");
        }

        /// <summary>
        /// This API is used to query running logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMongodbLogsRequest"/></param>
        /// <returns><see cref="DescribeMongodbLogsResponse"/></returns>
        public DescribeMongodbLogsResponse DescribeMongodbLogsSync(DescribeMongodbLogsRequest req)
        {
            return InternalRequestAsync<DescribeMongodbLogsResponse>(req, "DescribeMongodbLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupResponse"/></returns>
        public Task<DescribeSecurityGroupResponse> DescribeSecurityGroup(DescribeSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupResponse>(req, "DescribeSecurityGroup");
        }

        /// <summary>
        /// This API is used to query security groups bound to an instance.
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
        /// This API is used to query the sales specification of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public Task<DescribeSpecInfoResponse> DescribeSpecInfo(DescribeSpecInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpecInfoResponse>(req, "DescribeSpecInfo");
        }

        /// <summary>
        /// This API is used to query the sales specification of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public DescribeSpecInfoResponse DescribeSpecInfoSync(DescribeSpecInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpecInfoResponse>(req, "DescribeSpecInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the transparent data encryption (TDE) capability for TencentDB for MongoDB.
        /// </summary>
        /// <param name="req"><see cref="EnableTransparentDataEncryptionRequest"/></param>
        /// <returns><see cref="EnableTransparentDataEncryptionResponse"/></returns>
        public Task<EnableTransparentDataEncryptionResponse> EnableTransparentDataEncryption(EnableTransparentDataEncryptionRequest req)
        {
            return InternalRequestAsync<EnableTransparentDataEncryptionResponse>(req, "EnableTransparentDataEncryption");
        }

        /// <summary>
        /// This API is used to enable the transparent data encryption (TDE) capability for TencentDB for MongoDB.
        /// </summary>
        /// <param name="req"><see cref="EnableTransparentDataEncryptionRequest"/></param>
        /// <returns><see cref="EnableTransparentDataEncryptionResponse"/></returns>
        public EnableTransparentDataEncryptionResponse EnableTransparentDataEncryptionSync(EnableTransparentDataEncryptionRequest req)
        {
            return InternalRequestAsync<EnableTransparentDataEncryptionResponse>(req, "EnableTransparentDataEncryption")
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
        /// This API is used to set the SSL status for an instance.
        /// </summary>
        /// <param name="req"><see cref="InstanceEnableSSLRequest"/></param>
        /// <returns><see cref="InstanceEnableSSLResponse"/></returns>
        public Task<InstanceEnableSSLResponse> InstanceEnableSSL(InstanceEnableSSLRequest req)
        {
            return InternalRequestAsync<InstanceEnableSSLResponse>(req, "InstanceEnableSSL");
        }

        /// <summary>
        /// This API is used to set the SSL status for an instance.
        /// </summary>
        /// <param name="req"><see cref="InstanceEnableSSLRequest"/></param>
        /// <returns><see cref="InstanceEnableSSLResponse"/></returns>
        public InstanceEnableSSLResponse InstanceEnableSSLSync(InstanceEnableSSLRequest req)
        {
            return InternalRequestAsync<InstanceEnableSSLResponse>(req, "InstanceEnableSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a pay-as-you-go TencentDB for MongoDB instance. After isolation, the instance is retained in the recycle bin, and data cannot be written into it. After a certain period of isolation, the instance is deleted permanently. For the retention time in the recycle bin, see the pay-as-you-go service terms. The deleted pay-as-you-go instance cannot be recovered. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// This API is used to isolate a pay-as-you-go TencentDB for MongoDB instance. After isolation, the instance is retained in the recycle bin, and data cannot be written into it. After a certain period of isolation, the instance is deleted permanently. For the retention time in the recycle bin, see the pay-as-you-go service terms. The deleted pay-as-you-go instance cannot be recovered. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a specific operation performed on a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="KillOpsRequest"/></param>
        /// <returns><see cref="KillOpsResponse"/></returns>
        public Task<KillOpsResponse> KillOps(KillOpsRequest req)
        {
            return InternalRequestAsync<KillOpsResponse>(req, "KillOps");
        }

        /// <summary>
        /// This API is used to terminate a specific operation performed on a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="KillOpsRequest"/></param>
        /// <returns><see cref="KillOpsResponse"/></returns>
        public KillOpsResponse KillOpsSync(KillOpsRequest req)
        {
            return InternalRequestAsync<KillOpsResponse>(req, "KillOps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the network information on a TencentDB for MongoDB instance. It supports switching from a basic network to a VPC network or from one VPC network to another VPC network.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public Task<ModifyDBInstanceNetworkAddressResponse> ModifyDBInstanceNetworkAddress(ModifyDBInstanceNetworkAddressRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkAddressResponse>(req, "ModifyDBInstanceNetworkAddress");
        }

        /// <summary>
        /// This API is used to modify the network information on a TencentDB for MongoDB instance. It supports switching from a basic network to a VPC network or from one VPC network to another VPC network.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public ModifyDBInstanceNetworkAddressResponse ModifyDBInstanceNetworkAddressSync(ModifyDBInstanceNetworkAddressRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkAddressResponse>(req, "ModifyDBInstanceNetworkAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupResponse> ModifyDBInstanceSecurityGroup(ModifyDBInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupResponse>(req, "ModifyDBInstanceSecurityGroup");
        }

        /// <summary>
        /// This API is used to modify security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public ModifyDBInstanceSecurityGroupResponse ModifyDBInstanceSecurityGroupSync(ModifyDBInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupResponse>(req, "ModifyDBInstanceSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the TencentDB for MongoDB instance configuration. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1) API can be called to query and obtain the supported sales specifications.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec");
        }

        /// <summary>
        /// This API is used to adjust the TencentDB for MongoDB instance configuration. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1) API can be called to query and obtain the supported sales specifications.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecSync(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the parameter configuration of a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams");
        }

        /// <summary>
        /// This API is used to modify the parameter configuration of a TencentDB for MongoDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams")
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
        /// This API is used to reset the instance access password.
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public Task<ResetDBInstancePasswordResponse> ResetDBInstancePassword(ResetDBInstancePasswordRequest req)
        {
            return InternalRequestAsync<ResetDBInstancePasswordResponse>(req, "ResetDBInstancePassword");
        }

        /// <summary>
        /// This API is used to reset the instance access password.
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public ResetDBInstancePasswordResponse ResetDBInstancePasswordSync(ResetDBInstancePasswordRequest req)
        {
            return InternalRequestAsync<ResetDBInstancePasswordResponse>(req, "ResetDBInstancePassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the account permissions of an instance.
        /// </summary>
        /// <param name="req"><see cref="SetAccountUserPrivilegeRequest"/></param>
        /// <returns><see cref="SetAccountUserPrivilegeResponse"/></returns>
        public Task<SetAccountUserPrivilegeResponse> SetAccountUserPrivilege(SetAccountUserPrivilegeRequest req)
        {
            return InternalRequestAsync<SetAccountUserPrivilegeResponse>(req, "SetAccountUserPrivilege");
        }

        /// <summary>
        /// This API is used to set the account permissions of an instance.
        /// </summary>
        /// <param name="req"><see cref="SetAccountUserPrivilegeRequest"/></param>
        /// <returns><see cref="SetAccountUserPrivilegeResponse"/></returns>
        public SetAccountUserPrivilegeResponse SetAccountUserPrivilegeSync(SetAccountUserPrivilegeRequest req)
        {
            return InternalRequestAsync<SetAccountUserPrivilegeResponse>(req, "SetAccountUserPrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set instance termination protection.
        /// </summary>
        /// <param name="req"><see cref="SetDBInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="SetDBInstanceDeletionProtectionResponse"/></returns>
        public Task<SetDBInstanceDeletionProtectionResponse> SetDBInstanceDeletionProtection(SetDBInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<SetDBInstanceDeletionProtectionResponse>(req, "SetDBInstanceDeletionProtection");
        }

        /// <summary>
        /// This API is used to set instance termination protection.
        /// </summary>
        /// <param name="req"><see cref="SetDBInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="SetDBInstanceDeletionProtectionResponse"/></returns>
        public SetDBInstanceDeletionProtectionResponse SetDBInstanceDeletionProtectionSync(SetDBInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<SetDBInstanceDeletionProtectionResponse>(req, "SetDBInstanceDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="SetInstanceMaintenanceRequest"/></param>
        /// <returns><see cref="SetInstanceMaintenanceResponse"/></returns>
        public Task<SetInstanceMaintenanceResponse> SetInstanceMaintenance(SetInstanceMaintenanceRequest req)
        {
            return InternalRequestAsync<SetInstanceMaintenanceResponse>(req, "SetInstanceMaintenance");
        }

        /// <summary>
        /// This API is used to set the instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="SetInstanceMaintenanceRequest"/></param>
        /// <returns><see cref="SetInstanceMaintenanceResponse"/></returns>
        public SetInstanceMaintenanceResponse SetInstanceMaintenanceSync(SetInstanceMaintenanceRequest req)
        {
            return InternalRequestAsync<SetInstanceMaintenanceResponse>(req, "SetInstanceMaintenance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate monthly subscription billing instances.
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstancesRequest"/></param>
        /// <returns><see cref="TerminateDBInstancesResponse"/></returns>
        public Task<TerminateDBInstancesResponse> TerminateDBInstances(TerminateDBInstancesRequest req)
        {
            return InternalRequestAsync<TerminateDBInstancesResponse>(req, "TerminateDBInstances");
        }

        /// <summary>
        /// This API is used to terminate monthly subscription billing instances.
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstancesRequest"/></param>
        /// <returns><see cref="TerminateDBInstancesResponse"/></returns>
        public TerminateDBInstancesResponse TerminateDBInstancesSync(TerminateDBInstancesRequest req)
        {
            return InternalRequestAsync<TerminateDBInstancesResponse>(req, "TerminateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the kernel version of the database instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion");
        }

        /// <summary>
        /// This API is used to upgrade the kernel version of the database instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionSync(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the database kernel across versions. Currently, it is only supported to upgrade from version 3.6 to 4.0, 4.0 to 4.2, 4.2 to 4.4, and 4.4 to 5.0.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDbInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeDbInstanceVersionResponse"/></returns>
        public Task<UpgradeDbInstanceVersionResponse> UpgradeDbInstanceVersion(UpgradeDbInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDbInstanceVersionResponse>(req, "UpgradeDbInstanceVersion");
        }

        /// <summary>
        /// This API is used to upgrade the database kernel across versions. Currently, it is only supported to upgrade from version 3.6 to 4.0, 4.0 to 4.2, 4.2 to 4.4, and 4.4 to 5.0.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDbInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeDbInstanceVersionResponse"/></returns>
        public UpgradeDbInstanceVersionResponse UpgradeDbInstanceVersionSync(UpgradeDbInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDbInstanceVersionResponse>(req, "UpgradeDbInstanceVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
