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

namespace TencentCloud.Sqlserver.V20180328
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sqlserver.V20180328.Models;

   public class SqlserverClient : AbstractClient{

       private const string endpoint = "sqlserver.intl.tencentcloudapi.com";
       private const string version = "2018-03-28";
       private const string sdkVersion = "SDK_NET_3.0.1202";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SqlserverClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SqlserverClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind security groups to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to bind security groups to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to balance the routing weight of each read-only instance according to the predefined weights. The DescribeReadOnlyGroupAutoWeight API is used to query the predefined weights.
        /// </summary>
        /// <param name="req"><see cref="BalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="BalanceReadOnlyGroupResponse"/></returns>
        public Task<BalanceReadOnlyGroupResponse> BalanceReadOnlyGroup(BalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<BalanceReadOnlyGroupResponse>(req, "BalanceReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to balance the routing weight of each read-only instance according to the predefined weights. The DescribeReadOnlyGroupAutoWeight API is used to query the predefined weights.
        /// </summary>
        /// <param name="req"><see cref="BalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="BalanceReadOnlyGroupResponse"/></returns>
        public BalanceReadOnlyGroupResponse BalanceReadOnlyGroupSync(BalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<BalanceReadOnlyGroupResponse>(req, "BalanceReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clone and rename databases of an instance. The clones are still in the instance from which they are cloned.
        /// </summary>
        /// <param name="req"><see cref="CloneDBRequest"/></param>
        /// <returns><see cref="CloneDBResponse"/></returns>
        public Task<CloneDBResponse> CloneDB(CloneDBRequest req)
        {
            return InternalRequestAsync<CloneDBResponse>(req, "CloneDB");
        }

        /// <summary>
        /// This API is used to clone and rename databases of an instance. The clones are still in the instance from which they are cloned.
        /// </summary>
        /// <param name="req"><see cref="CloneDBRequest"/></param>
        /// <returns><see cref="CloneDBResponse"/></returns>
        public CloneDBResponse CloneDBSync(CloneDBRequest req)
        {
            return InternalRequestAsync<CloneDBResponse>(req, "CloneDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable instance interconnection.
        /// </summary>
        /// <param name="req"><see cref="CloseInterCommunicationRequest"/></param>
        /// <returns><see cref="CloseInterCommunicationResponse"/></returns>
        public Task<CloseInterCommunicationResponse> CloseInterCommunication(CloseInterCommunicationRequest req)
        {
            return InternalRequestAsync<CloseInterCommunicationResponse>(req, "CloseInterCommunication");
        }

        /// <summary>
        /// This API is used to disable instance interconnection.
        /// </summary>
        /// <param name="req"><see cref="CloseInterCommunicationRequest"/></param>
        /// <returns><see cref="CloseInterCommunicationResponse"/></returns>
        public CloseInterCommunicationResponse CloseInterCommunicationSync(CloseInterCommunicationRequest req)
        {
            return InternalRequestAsync<CloseInterCommunicationResponse>(req, "CloseInterCommunication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to complete the instance upgrade and switch immediately without waiting for the maintenance window when the instance status is "upgrade pending switch" after scale-out is initiated. This API needs to be called during off-peak hours of the instance. Some databases cannot be accessed before the switch is completed.
        /// </summary>
        /// <param name="req"><see cref="CompleteExpansionRequest"/></param>
        /// <returns><see cref="CompleteExpansionResponse"/></returns>
        public Task<CompleteExpansionResponse> CompleteExpansion(CompleteExpansionRequest req)
        {
            return InternalRequestAsync<CompleteExpansionResponse>(req, "CompleteExpansion");
        }

        /// <summary>
        /// This API is used to complete the instance upgrade and switch immediately without waiting for the maintenance window when the instance status is "upgrade pending switch" after scale-out is initiated. This API needs to be called during off-peak hours of the instance. Some databases cannot be accessed before the switch is completed.
        /// </summary>
        /// <param name="req"><see cref="CompleteExpansionRequest"/></param>
        /// <returns><see cref="CompleteExpansionResponse"/></returns>
        public CompleteExpansionResponse CompleteExpansionSync(CompleteExpansionRequest req)
        {
            return InternalRequestAsync<CompleteExpansionResponse>(req, "CompleteExpansion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an instance account.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
        }

        /// <summary>
        /// This API is used to create an instance account.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a backup.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// This API is used to create a backup.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a backup import task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupMigrationRequest"/></param>
        /// <returns><see cref="CreateBackupMigrationResponse"/></returns>
        public Task<CreateBackupMigrationResponse> CreateBackupMigration(CreateBackupMigrationRequest req)
        {
            return InternalRequestAsync<CreateBackupMigrationResponse>(req, "CreateBackupMigration");
        }

        /// <summary>
        /// This API is used to create a backup import task.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupMigrationRequest"/></param>
        /// <returns><see cref="CreateBackupMigrationResponse"/></returns>
        public CreateBackupMigrationResponse CreateBackupMigrationSync(CreateBackupMigrationRequest req)
        {
            return InternalRequestAsync<CreateBackupMigrationResponse>(req, "CreateBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create basic edition instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBasicDBInstancesResponse"/></returns>
        public Task<CreateBasicDBInstancesResponse> CreateBasicDBInstances(CreateBasicDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBasicDBInstancesResponse>(req, "CreateBasicDBInstances");
        }

        /// <summary>
        /// This API is used to create basic edition instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBasicDBInstancesResponse"/></returns>
        public CreateBasicDBInstancesResponse CreateBasicDBInstancesSync(CreateBasicDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBasicDBInstancesResponse>(req, "CreateBasicDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create business intelligence service instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBusinessDBInstancesResponse"/></returns>
        public Task<CreateBusinessDBInstancesResponse> CreateBusinessDBInstances(CreateBusinessDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBusinessDBInstancesResponse>(req, "CreateBusinessDBInstances");
        }

        /// <summary>
        /// This API is used to create business intelligence service instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBusinessDBInstancesResponse"/></returns>
        public CreateBusinessDBInstancesResponse CreateBusinessDBInstancesSync(CreateBusinessDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBusinessDBInstancesResponse>(req, "CreateBusinessDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a business intelligence service file.
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="CreateBusinessIntelligenceFileResponse"/></returns>
        public Task<CreateBusinessIntelligenceFileResponse> CreateBusinessIntelligenceFile(CreateBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<CreateBusinessIntelligenceFileResponse>(req, "CreateBusinessIntelligenceFile");
        }

        /// <summary>
        /// This API is used to add a business intelligence service file.
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="CreateBusinessIntelligenceFileResponse"/></returns>
        public CreateBusinessIntelligenceFileResponse CreateBusinessIntelligenceFileSync(CreateBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<CreateBusinessIntelligenceFileResponse>(req, "CreateBusinessIntelligenceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create high-availability instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateCloudDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudDBInstancesResponse"/></returns>
        public Task<CreateCloudDBInstancesResponse> CreateCloudDBInstances(CreateCloudDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudDBInstancesResponse>(req, "CreateCloudDBInstances");
        }

        /// <summary>
        /// This API is used to create high-availability instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateCloudDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudDBInstancesResponse"/></returns>
        public CreateCloudDBInstancesResponse CreateCloudDBInstancesSync(CreateCloudDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudDBInstancesResponse>(req, "CreateCloudDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create read-only instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateCloudReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudReadOnlyDBInstancesResponse"/></returns>
        public Task<CreateCloudReadOnlyDBInstancesResponse> CreateCloudReadOnlyDBInstances(CreateCloudReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudReadOnlyDBInstancesResponse>(req, "CreateCloudReadOnlyDBInstances");
        }

        /// <summary>
        /// This API is used to create read-only instances (cloud disk).
        /// </summary>
        /// <param name="req"><see cref="CreateCloudReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudReadOnlyDBInstancesResponse"/></returns>
        public CreateCloudReadOnlyDBInstancesResponse CreateCloudReadOnlyDBInstancesSync(CreateCloudReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudReadOnlyDBInstancesResponse>(req, "CreateCloudReadOnlyDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a database.
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public Task<CreateDBResponse> CreateDB(CreateDBRequest req)
        {
            return InternalRequestAsync<CreateDBResponse>(req, "CreateDB");
        }

        /// <summary>
        /// This API is used to create a database.
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public CreateDBResponse CreateDBSync(CreateDBRequest req)
        {
            return InternalRequestAsync<CreateDBResponse>(req, "CreateDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create high-availability instances (local disk).
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances");
        }

        /// <summary>
        /// This API is used to create high-availability instances (local disk).
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationResponse"/></returns>
        public Task<CreateIncrementalMigrationResponse> CreateIncrementalMigration(CreateIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationResponse>(req, "CreateIncrementalMigration");
        }

        /// <summary>
        /// This API is used to create an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationResponse"/></returns>
        public CreateIncrementalMigrationResponse CreateIncrementalMigrationSync(CreateIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationResponse>(req, "CreateIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a migration task.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public Task<CreateMigrationResponse> CreateMigration(CreateMigrationRequest req)
        {
            return InternalRequestAsync<CreateMigrationResponse>(req, "CreateMigration");
        }

        /// <summary>
        /// This API is used to create a migration task.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public CreateMigrationResponse CreateMigrationSync(CreateMigrationRequest req)
        {
            return InternalRequestAsync<CreateMigrationResponse>(req, "CreateMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a publish/subscribe relationship between two databases. A subscriber cannot act as a publisher, and a publisher can have multiple subscriber instances.
        /// </summary>
        /// <param name="req"><see cref="CreatePublishSubscribeRequest"/></param>
        /// <returns><see cref="CreatePublishSubscribeResponse"/></returns>
        public Task<CreatePublishSubscribeResponse> CreatePublishSubscribe(CreatePublishSubscribeRequest req)
        {
            return InternalRequestAsync<CreatePublishSubscribeResponse>(req, "CreatePublishSubscribe");
        }

        /// <summary>
        /// This API is used to create a publish/subscribe relationship between two databases. A subscriber cannot act as a publisher, and a publisher can have multiple subscriber instances.
        /// </summary>
        /// <param name="req"><see cref="CreatePublishSubscribeRequest"/></param>
        /// <returns><see cref="CreatePublishSubscribeResponse"/></returns>
        public CreatePublishSubscribeResponse CreatePublishSubscribeSync(CreatePublishSubscribeRequest req)
        {
            return InternalRequestAsync<CreatePublishSubscribeResponse>(req, "CreatePublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create read-only instances (local disk).
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstancesResponse"/></returns>
        public Task<CreateReadOnlyDBInstancesResponse> CreateReadOnlyDBInstances(CreateReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstancesResponse>(req, "CreateReadOnlyDBInstances");
        }

        /// <summary>
        /// This API is used to create read-only instances (local disk).
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstancesResponse"/></returns>
        public CreateReadOnlyDBInstancesResponse CreateReadOnlyDBInstancesSync(CreateReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstancesResponse>(req, "CreateReadOnlyDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manually cut block logs and deadlock logs.
        /// </summary>
        /// <param name="req"><see cref="CutXEventsRequest"/></param>
        /// <returns><see cref="CutXEventsResponse"/></returns>
        public Task<CutXEventsResponse> CutXEvents(CutXEventsRequest req)
        {
            return InternalRequestAsync<CutXEventsResponse>(req, "CutXEvents");
        }

        /// <summary>
        /// This API is used to manually cut block logs and deadlock logs.
        /// </summary>
        /// <param name="req"><see cref="CutXEventsRequest"/></param>
        /// <returns><see cref="CutXEventsResponse"/></returns>
        public CutXEventsResponse CutXEventsSync(CutXEventsRequest req)
        {
            return InternalRequestAsync<CutXEventsResponse>(req, "CutXEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an instance account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount");
        }

        /// <summary>
        /// This API is used to delete an instance account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a backup import task.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupMigrationRequest"/></param>
        /// <returns><see cref="DeleteBackupMigrationResponse"/></returns>
        public Task<DeleteBackupMigrationResponse> DeleteBackupMigration(DeleteBackupMigrationRequest req)
        {
            return InternalRequestAsync<DeleteBackupMigrationResponse>(req, "DeleteBackupMigration");
        }

        /// <summary>
        /// This API is used to delete a backup import task.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupMigrationRequest"/></param>
        /// <returns><see cref="DeleteBackupMigrationResponse"/></returns>
        public DeleteBackupMigrationResponse DeleteBackupMigrationSync(DeleteBackupMigrationRequest req)
        {
            return InternalRequestAsync<DeleteBackupMigrationResponse>(req, "DeleteBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a business intelligence service file.
        /// </summary>
        /// <param name="req"><see cref="DeleteBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DeleteBusinessIntelligenceFileResponse"/></returns>
        public Task<DeleteBusinessIntelligenceFileResponse> DeleteBusinessIntelligenceFile(DeleteBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DeleteBusinessIntelligenceFileResponse>(req, "DeleteBusinessIntelligenceFile");
        }

        /// <summary>
        /// This API is used to delete a business intelligence service file.
        /// </summary>
        /// <param name="req"><see cref="DeleteBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DeleteBusinessIntelligenceFileResponse"/></returns>
        public DeleteBusinessIntelligenceFileResponse DeleteBusinessIntelligenceFileSync(DeleteBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DeleteBusinessIntelligenceFileResponse>(req, "DeleteBusinessIntelligenceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to drop a database.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public Task<DeleteDBResponse> DeleteDB(DeleteDBRequest req)
        {
            return InternalRequestAsync<DeleteDBResponse>(req, "DeleteDB");
        }

        /// <summary>
        /// This API is used to drop a database.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public DeleteDBResponse DeleteDBSync(DeleteDBRequest req)
        {
            return InternalRequestAsync<DeleteDBResponse>(req, "DeleteDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release SQL server instances (eliminated immediately) in the recycle bin. The released instances will be physically terminated after being retained for a period of time. Their publish-subscribe relationships will be automatically disassociated, and their RO replicas will be automatically released.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceResponse"/></returns>
        public Task<DeleteDBInstanceResponse> DeleteDBInstance(DeleteDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceResponse>(req, "DeleteDBInstance");
        }

        /// <summary>
        /// This API is used to release SQL server instances (eliminated immediately) in the recycle bin. The released instances will be physically terminated after being retained for a period of time. Their publish-subscribe relationships will be automatically disassociated, and their RO replicas will be automatically released.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceResponse"/></returns>
        public DeleteDBInstanceResponse DeleteDBInstanceSync(DeleteDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceResponse>(req, "DeleteDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationResponse"/></returns>
        public Task<DeleteIncrementalMigrationResponse> DeleteIncrementalMigration(DeleteIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationResponse>(req, "DeleteIncrementalMigration");
        }

        /// <summary>
        /// This API is used to delete an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationResponse"/></returns>
        public DeleteIncrementalMigrationResponse DeleteIncrementalMigrationSync(DeleteIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationResponse>(req, "DeleteIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a migration task.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public Task<DeleteMigrationResponse> DeleteMigration(DeleteMigrationRequest req)
        {
            return InternalRequestAsync<DeleteMigrationResponse>(req, "DeleteMigration");
        }

        /// <summary>
        /// This API is used to delete a migration task.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public DeleteMigrationResponse DeleteMigrationSync(DeleteMigrationRequest req)
        {
            return InternalRequestAsync<DeleteMigrationResponse>(req, "DeleteMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the publish/subscribe relationship between two databases.
        /// </summary>
        /// <param name="req"><see cref="DeletePublishSubscribeRequest"/></param>
        /// <returns><see cref="DeletePublishSubscribeResponse"/></returns>
        public Task<DeletePublishSubscribeResponse> DeletePublishSubscribe(DeletePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DeletePublishSubscribeResponse>(req, "DeletePublishSubscribe");
        }

        /// <summary>
        /// This API is used to delete the publish/subscribe relationship between two databases.
        /// </summary>
        /// <param name="req"><see cref="DeletePublishSubscribeRequest"/></param>
        /// <returns><see cref="DeletePublishSubscribeResponse"/></returns>
        public DeletePublishSubscribeResponse DeletePublishSubscribeSync(DeletePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DeletePublishSubscribeResponse>(req, "DeletePublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information on the account and permissions associated with the database.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegeByDBRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegeByDBResponse"/></returns>
        public Task<DescribeAccountPrivilegeByDBResponse> DescribeAccountPrivilegeByDB(DescribeAccountPrivilegeByDBRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegeByDBResponse>(req, "DescribeAccountPrivilegeByDB");
        }

        /// <summary>
        /// This API is used to query information on the account and permissions associated with the database.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegeByDBRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegeByDBResponse"/></returns>
        public DescribeAccountPrivilegeByDBResponse DescribeAccountPrivilegeByDBSync(DescribeAccountPrivilegeByDBRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegeByDBResponse>(req, "DescribeAccountPrivilegeByDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull the list of instance accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// This API is used to pull the list of instance accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the created backup details through the backup creation process ID. The process ID can be obtained through the CreateBackup API.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeBackupByFlowIdResponse"/></returns>
        public Task<DescribeBackupByFlowIdResponse> DescribeBackupByFlowId(DescribeBackupByFlowIdRequest req)
        {
            return InternalRequestAsync<DescribeBackupByFlowIdResponse>(req, "DescribeBackupByFlowId");
        }

        /// <summary>
        /// This API is used to query the created backup details through the backup creation process ID. The process ID can be obtained through the CreateBackup API.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeBackupByFlowIdResponse"/></returns>
        public DescribeBackupByFlowIdResponse DescribeBackupByFlowIdSync(DescribeBackupByFlowIdRequest req)
        {
            return InternalRequestAsync<DescribeBackupByFlowIdResponse>(req, "DescribeBackupByFlowId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the commands of creating backups canonically.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupCommandRequest"/></param>
        /// <returns><see cref="DescribeBackupCommandResponse"/></returns>
        public Task<DescribeBackupCommandResponse> DescribeBackupCommand(DescribeBackupCommandRequest req)
        {
            return InternalRequestAsync<DescribeBackupCommandResponse>(req, "DescribeBackupCommand");
        }

        /// <summary>
        /// This API is used to query the commands of creating backups canonically.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupCommandRequest"/></param>
        /// <returns><see cref="DescribeBackupCommandResponse"/></returns>
        public DescribeBackupCommandResponse DescribeBackupCommandSync(DescribeBackupCommandRequest req)
        {
            return InternalRequestAsync<DescribeBackupCommandResponse>(req, "DescribeBackupCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an unarchived backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public Task<DescribeBackupFilesResponse> DescribeBackupFiles(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles");
        }

        /// <summary>
        /// This API is used to query the details of an unarchived backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public DescribeBackupFilesResponse DescribeBackupFilesSync(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMigrationRequest"/></param>
        /// <returns><see cref="DescribeBackupMigrationResponse"/></returns>
        public Task<DescribeBackupMigrationResponse> DescribeBackupMigration(DescribeBackupMigrationRequest req)
        {
            return InternalRequestAsync<DescribeBackupMigrationResponse>(req, "DescribeBackupMigration");
        }

        /// <summary>
        /// This API is used to create an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMigrationRequest"/></param>
        /// <returns><see cref="DescribeBackupMigrationResponse"/></returns>
        public DescribeBackupMigrationResponse DescribeBackupMigrationSync(DescribeBackupMigrationRequest req)
        {
            return InternalRequestAsync<DescribeBackupMigrationResponse>(req, "DescribeBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query backup space usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMonitorRequest"/></param>
        /// <returns><see cref="DescribeBackupMonitorResponse"/></returns>
        public Task<DescribeBackupMonitorResponse> DescribeBackupMonitor(DescribeBackupMonitorRequest req)
        {
            return InternalRequestAsync<DescribeBackupMonitorResponse>(req, "DescribeBackupMonitor");
        }

        /// <summary>
        /// This API is used to query backup space usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMonitorRequest"/></param>
        /// <returns><see cref="DescribeBackupMonitorResponse"/></returns>
        public DescribeBackupMonitorResponse DescribeBackupMonitorSync(DescribeBackupMonitorRequest req)
        {
            return InternalRequestAsync<DescribeBackupMonitorResponse>(req, "DescribeBackupMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time statistics list of backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeBackupStatisticalResponse"/></returns>
        public Task<DescribeBackupStatisticalResponse> DescribeBackupStatistical(DescribeBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeBackupStatisticalResponse>(req, "DescribeBackupStatistical");
        }

        /// <summary>
        /// This API is used to query the real-time statistics list of backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeBackupStatisticalResponse"/></returns>
        public DescribeBackupStatisticalResponse DescribeBackupStatisticalSync(DescribeBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeBackupStatisticalResponse>(req, "DescribeBackupStatistical")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup overview information of databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummaryRequest"/></param>
        /// <returns><see cref="DescribeBackupSummaryResponse"/></returns>
        public Task<DescribeBackupSummaryResponse> DescribeBackupSummary(DescribeBackupSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummaryResponse>(req, "DescribeBackupSummary");
        }

        /// <summary>
        /// This API is used to query the backup overview information of databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummaryRequest"/></param>
        /// <returns><see cref="DescribeBackupSummaryResponse"/></returns>
        public DescribeBackupSummaryResponse DescribeBackupSummarySync(DescribeBackupSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummaryResponse>(req, "DescribeBackupSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the size of uploaded backup files. It is valid if the backup file type is `COS_UPLOAD` (the file is stored in COS).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUploadSizeRequest"/></param>
        /// <returns><see cref="DescribeBackupUploadSizeResponse"/></returns>
        public Task<DescribeBackupUploadSizeResponse> DescribeBackupUploadSize(DescribeBackupUploadSizeRequest req)
        {
            return InternalRequestAsync<DescribeBackupUploadSizeResponse>(req, "DescribeBackupUploadSize");
        }

        /// <summary>
        /// This API is used to query the size of uploaded backup files. It is valid if the backup file type is `COS_UPLOAD` (the file is stored in COS).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUploadSizeRequest"/></param>
        /// <returns><see cref="DescribeBackupUploadSizeResponse"/></returns>
        public DescribeBackupUploadSizeResponse DescribeBackupUploadSizeSync(DescribeBackupUploadSizeRequest req)
        {
            return InternalRequestAsync<DescribeBackupUploadSizeResponse>(req, "DescribeBackupUploadSize")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups");
        }

        /// <summary>
        /// This API is used to query the list of backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public DescribeBackupsResponse DescribeBackupsSync(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the files required by business intelligence service.
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DescribeBusinessIntelligenceFileResponse"/></returns>
        public Task<DescribeBusinessIntelligenceFileResponse> DescribeBusinessIntelligenceFile(DescribeBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DescribeBusinessIntelligenceFileResponse>(req, "DescribeBusinessIntelligenceFile");
        }

        /// <summary>
        /// This API is used to query the files required by business intelligence service.
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DescribeBusinessIntelligenceFileResponse"/></returns>
        public DescribeBusinessIntelligenceFileResponse DescribeBusinessIntelligenceFileSync(DescribeBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DescribeBusinessIntelligenceFileResponse>(req, "DescribeBusinessIntelligenceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the character set and time zone supported by the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCollationTimeZoneRequest"/></param>
        /// <returns><see cref="DescribeCollationTimeZoneResponse"/></returns>
        public Task<DescribeCollationTimeZoneResponse> DescribeCollationTimeZone(DescribeCollationTimeZoneRequest req)
        {
            return InternalRequestAsync<DescribeCollationTimeZoneResponse>(req, "DescribeCollationTimeZone");
        }

        /// <summary>
        /// This API is used to query the character set and time zone supported by the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCollationTimeZoneRequest"/></param>
        /// <returns><see cref="DescribeCollationTimeZoneResponse"/></returns>
        public DescribeCollationTimeZoneResponse DescribeCollationTimeZoneSync(DescribeCollationTimeZoneRequest req)
        {
            return InternalRequestAsync<DescribeCollationTimeZoneResponse>(req, "DescribeCollationTimeZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time statistics list of cross-region backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeCrossBackupStatisticalResponse"/></returns>
        public Task<DescribeCrossBackupStatisticalResponse> DescribeCrossBackupStatistical(DescribeCrossBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeCrossBackupStatisticalResponse>(req, "DescribeCrossBackupStatistical");
        }

        /// <summary>
        /// This API is used to query the real-time statistics list of cross-region backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeCrossBackupStatisticalResponse"/></returns>
        public DescribeCrossBackupStatisticalResponse DescribeCrossBackupStatisticalSync(DescribeCrossBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeCrossBackupStatisticalResponse>(req, "DescribeCrossBackupStatistical")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the disaster recovery region and AZ of the secondary node based on the primary instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionZoneResponse"/></returns>
        public Task<DescribeCrossRegionZoneResponse> DescribeCrossRegionZone(DescribeCrossRegionZoneRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionZoneResponse>(req, "DescribeCrossRegionZone");
        }

        /// <summary>
        /// This API is used to query the disaster recovery region and AZ of the secondary node based on the primary instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionZoneResponse"/></returns>
        public DescribeCrossRegionZoneResponse DescribeCrossRegionZoneSync(DescribeCrossRegionZoneRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionZoneResponse>(req, "DescribeCrossRegionZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the target region for cross-region backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionsRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionsResponse"/></returns>
        public Task<DescribeCrossRegionsResponse> DescribeCrossRegions(DescribeCrossRegionsRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionsResponse>(req, "DescribeCrossRegions");
        }

        /// <summary>
        /// This API is used to query the target region for cross-region backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionsRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionsResponse"/></returns>
        public DescribeCrossRegionsResponse DescribeCrossRegionsSync(DescribeCrossRegionsRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionsResponse>(req, "DescribeCrossRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the database character sets supported by an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCharsetsRequest"/></param>
        /// <returns><see cref="DescribeDBCharsetsResponse"/></returns>
        public Task<DescribeDBCharsetsResponse> DescribeDBCharsets(DescribeDBCharsetsRequest req)
        {
            return InternalRequestAsync<DescribeDBCharsetsResponse>(req, "DescribeDBCharsets");
        }

        /// <summary>
        /// This API is used to query the database character sets supported by an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCharsetsRequest"/></param>
        /// <returns><see cref="DescribeDBCharsetsResponse"/></returns>
        public DescribeDBCharsetsResponse DescribeDBCharsetsSync(DescribeDBCharsetsRequest req)
        {
            return InternalRequestAsync<DescribeDBCharsetsResponse>(req, "DescribeDBCharsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of the interconnected instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInterRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInterResponse"/></returns>
        public Task<DescribeDBInstanceInterResponse> DescribeDBInstanceInter(DescribeDBInstanceInterRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInterResponse>(req, "DescribeDBInstanceInter");
        }

        /// <summary>
        /// This API is used to query the information of the interconnected instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInterRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInterResponse"/></returns>
        public DescribeDBInstanceInterResponse DescribeDBInstanceInterSync(DescribeDBInstanceInterRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInterResponse>(req, "DescribeDBInstanceInter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// This API is used to query the list of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the attributes of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesAttributeResponse"/></returns>
        public Task<DescribeDBInstancesAttributeResponse> DescribeDBInstancesAttribute(DescribeDBInstancesAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesAttributeResponse>(req, "DescribeDBInstancesAttribute");
        }

        /// <summary>
        /// This API is used to query the attributes of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesAttributeResponse"/></returns>
        public DescribeDBInstancesAttributeResponse DescribeDBInstancesAttributeSync(DescribeDBInstancesAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesAttributeResponse>(req, "DescribeDBInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information on the databases and permissions associated with the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPrivilegeByAccountRequest"/></param>
        /// <returns><see cref="DescribeDBPrivilegeByAccountResponse"/></returns>
        public Task<DescribeDBPrivilegeByAccountResponse> DescribeDBPrivilegeByAccount(DescribeDBPrivilegeByAccountRequest req)
        {
            return InternalRequestAsync<DescribeDBPrivilegeByAccountResponse>(req, "DescribeDBPrivilegeByAccount");
        }

        /// <summary>
        /// This API is used to query information on the databases and permissions associated with the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPrivilegeByAccountRequest"/></param>
        /// <returns><see cref="DescribeDBPrivilegeByAccountResponse"/></returns>
        public DescribeDBPrivilegeByAccountResponse DescribeDBPrivilegeByAccountSync(DescribeDBPrivilegeByAccountRequest req)
        {
            return InternalRequestAsync<DescribeDBPrivilegeByAccountResponse>(req, "DescribeDBPrivilegeByAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query databases that can be rolled back.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBRestoreTimeRequest"/></param>
        /// <returns><see cref="DescribeDBRestoreTimeResponse"/></returns>
        public Task<DescribeDBRestoreTimeResponse> DescribeDBRestoreTime(DescribeDBRestoreTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBRestoreTimeResponse>(req, "DescribeDBRestoreTime");
        }

        /// <summary>
        /// This API is used to query databases that can be rolled back.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBRestoreTimeRequest"/></param>
        /// <returns><see cref="DescribeDBRestoreTimeResponse"/></returns>
        public DescribeDBRestoreTimeResponse DescribeDBRestoreTimeSync(DescribeDBRestoreTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBRestoreTimeResponse>(req, "DescribeDBRestoreTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group details of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// This API is used to query the security group details of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of databases
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public Task<DescribeDBsResponse> DescribeDBs(DescribeDBsRequest req)
        {
            return InternalRequestAsync<DescribeDBsResponse>(req, "DescribeDBs");
        }

        /// <summary>
        /// This API is used to query the list of databases
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public DescribeDBsResponse DescribeDBsSync(DescribeDBsRequest req)
        {
            return InternalRequestAsync<DescribeDBsResponse>(req, "DescribeDBs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database configurations. It does not return information of the accounts that have permissions to operate the database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsNormalRequest"/></param>
        /// <returns><see cref="DescribeDBsNormalResponse"/></returns>
        public Task<DescribeDBsNormalResponse> DescribeDBsNormal(DescribeDBsNormalRequest req)
        {
            return InternalRequestAsync<DescribeDBsNormalResponse>(req, "DescribeDBsNormal");
        }

        /// <summary>
        /// This API is used to query database configurations. It does not return information of the accounts that have permissions to operate the database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsNormalRequest"/></param>
        /// <returns><see cref="DescribeDBsNormalResponse"/></returns>
        public DescribeDBsNormalResponse DescribeDBsNormalSync(DescribeDBsNormalRequest req)
        {
            return InternalRequestAsync<DescribeDBsNormalResponse>(req, "DescribeDBsNormal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the database name associated with the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseNamesRequest"/></param>
        /// <returns><see cref="DescribeDatabaseNamesResponse"/></returns>
        public Task<DescribeDatabaseNamesResponse> DescribeDatabaseNames(DescribeDatabaseNamesRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseNamesResponse>(req, "DescribeDatabaseNames");
        }

        /// <summary>
        /// This API is used to query the database name associated with the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseNamesRequest"/></param>
        /// <returns><see cref="DescribeDatabaseNamesResponse"/></returns>
        public DescribeDatabaseNamesResponse DescribeDatabaseNamesSync(DescribeDatabaseNamesRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseNamesResponse>(req, "DescribeDatabaseNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// This API is used to query the database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database configuration information. This API does not contain accounts associated with databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesNormalRequest"/></param>
        /// <returns><see cref="DescribeDatabasesNormalResponse"/></returns>
        public Task<DescribeDatabasesNormalResponse> DescribeDatabasesNormal(DescribeDatabasesNormalRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesNormalResponse>(req, "DescribeDatabasesNormal");
        }

        /// <summary>
        /// This API is used to query database configuration information. This API does not contain accounts associated with databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesNormalRequest"/></param>
        /// <returns><see cref="DescribeDatabasesNormalResponse"/></returns>
        public DescribeDatabasesNormalResponse DescribeDatabasesNormalSync(DescribeDatabasesNormalRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesNormalResponse>(req, "DescribeDatabasesNormal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query flow status.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public Task<DescribeFlowStatusResponse> DescribeFlowStatus(DescribeFlowStatusRequest req)
        {
            return InternalRequestAsync<DescribeFlowStatusResponse>(req, "DescribeFlowStatus");
        }

        /// <summary>
        /// This API is used to query flow status.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public DescribeFlowStatusResponse DescribeFlowStatusSync(DescribeFlowStatusRequest req)
        {
            return InternalRequestAsync<DescribeFlowStatusResponse>(req, "DescribeFlowStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform the manual primary-secondary switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeHASwitchLogRequest"/></param>
        /// <returns><see cref="DescribeHASwitchLogResponse"/></returns>
        public Task<DescribeHASwitchLogResponse> DescribeHASwitchLog(DescribeHASwitchLogRequest req)
        {
            return InternalRequestAsync<DescribeHASwitchLogResponse>(req, "DescribeHASwitchLog");
        }

        /// <summary>
        /// This API is used to perform the manual primary-secondary switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeHASwitchLogRequest"/></param>
        /// <returns><see cref="DescribeHASwitchLogResponse"/></returns>
        public DescribeHASwitchLogResponse DescribeHASwitchLogSync(DescribeHASwitchLogRequest req)
        {
            return InternalRequestAsync<DescribeHASwitchLogResponse>(req, "DescribeHASwitchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationResponse"/></returns>
        public Task<DescribeIncrementalMigrationResponse> DescribeIncrementalMigration(DescribeIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationResponse>(req, "DescribeIncrementalMigration");
        }

        /// <summary>
        /// This API is used to query an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationResponse"/></returns>
        public DescribeIncrementalMigrationResponse DescribeIncrementalMigrationSync(DescribeIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationResponse>(req, "DescribeIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance ID by the order number.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByOrdersRequest"/></param>
        /// <returns><see cref="DescribeInstanceByOrdersResponse"/></returns>
        public Task<DescribeInstanceByOrdersResponse> DescribeInstanceByOrders(DescribeInstanceByOrdersRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByOrdersResponse>(req, "DescribeInstanceByOrders");
        }

        /// <summary>
        /// This API is used to query the instance ID by the order number.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByOrdersRequest"/></param>
        /// <returns><see cref="DescribeInstanceByOrdersResponse"/></returns>
        public DescribeInstanceByOrdersResponse DescribeInstanceByOrdersSync(DescribeInstanceByOrdersRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByOrdersResponse>(req, "DescribeInstanceByOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the parameter modification records of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords");
        }

        /// <summary>
        /// This API is used to query the parameter modification records of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the parameter list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// This API is used to query the parameter list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of asynchronous tasks related to an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTasksRequest"/></param>
        /// <returns><see cref="DescribeInstanceTasksResponse"/></returns>
        public Task<DescribeInstanceTasksResponse> DescribeInstanceTasks(DescribeInstanceTasksRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTasksResponse>(req, "DescribeInstanceTasks");
        }

        /// <summary>
        /// This API is used to query the list of asynchronous tasks related to an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTasksRequest"/></param>
        /// <returns><see cref="DescribeInstanceTasksResponse"/></returns>
        public DescribeInstanceTasksResponse DescribeInstanceTasksSync(DescribeInstanceTasksRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTasksResponse>(req, "DescribeInstanceTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance billing parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTradeParameterRequest"/></param>
        /// <returns><see cref="DescribeInstanceTradeParameterResponse"/></returns>
        public Task<DescribeInstanceTradeParameterResponse> DescribeInstanceTradeParameter(DescribeInstanceTradeParameterRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTradeParameterResponse>(req, "DescribeInstanceTradeParameter");
        }

        /// <summary>
        /// This API is used to query the instance billing parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTradeParameterRequest"/></param>
        /// <returns><see cref="DescribeInstanceTradeParameterResponse"/></returns>
        public DescribeInstanceTradeParameterResponse DescribeInstanceTradeParameterSync(DescribeInstanceTradeParameterRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTradeParameterResponse>(req, "DescribeInstanceTradeParameter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the maintenance time window of an instance based on its instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceSpanRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceSpanResponse"/></returns>
        public Task<DescribeMaintenanceSpanResponse> DescribeMaintenanceSpan(DescribeMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceSpanResponse>(req, "DescribeMaintenanceSpan");
        }

        /// <summary>
        /// This API is used to query the maintenance time window of an instance based on its instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceSpanRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceSpanResponse"/></returns>
        public DescribeMaintenanceSpanResponse DescribeMaintenanceSpanSync(DescribeMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceSpanResponse>(req, "DescribeMaintenanceSpan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query migration task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail");
        }

        /// <summary>
        /// This API is used to query migration task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of eligible migration tasks based on the entered criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public Task<DescribeMigrationsResponse> DescribeMigrations(DescribeMigrationsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationsResponse>(req, "DescribeMigrations");
        }

        /// <summary>
        /// This API is used to query the list of eligible migration tasks based on the entered criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public DescribeMigrationsResponse DescribeMigrationsSync(DescribeMigrationsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationsResponse>(req, "DescribeMigrations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// This API is used to query order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query purchasable specification configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig");
        }

        /// <summary>
        /// This API is used to query purchasable specification configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// This API is used to query security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the publish/subscribe relationship list.
        /// </summary>
        /// <param name="req"><see cref="DescribePublishSubscribeRequest"/></param>
        /// <returns><see cref="DescribePublishSubscribeResponse"/></returns>
        public Task<DescribePublishSubscribeResponse> DescribePublishSubscribe(DescribePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DescribePublishSubscribeResponse>(req, "DescribePublishSubscribe");
        }

        /// <summary>
        /// This API is used to query the publish/subscribe relationship list.
        /// </summary>
        /// <param name="req"><see cref="DescribePublishSubscribeRequest"/></param>
        /// <returns><see cref="DescribePublishSubscribeResponse"/></returns>
        public DescribePublishSubscribeResponse DescribePublishSubscribeSync(DescribePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DescribePublishSubscribeResponse>(req, "DescribePublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the automatic weight assignment result of the read-only group. The BalanceReadOnlyGroup API is used to perform routing weight assignment according to the automatic weight assignment result.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupAutoWeightRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupAutoWeightResponse"/></returns>
        public Task<DescribeReadOnlyGroupAutoWeightResponse> DescribeReadOnlyGroupAutoWeight(DescribeReadOnlyGroupAutoWeightRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupAutoWeightResponse>(req, "DescribeReadOnlyGroupAutoWeight");
        }

        /// <summary>
        /// This API is used to query the automatic weight assignment result of the read-only group. The BalanceReadOnlyGroup API is used to perform routing weight assignment according to the automatic weight assignment result.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupAutoWeightRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupAutoWeightResponse"/></returns>
        public DescribeReadOnlyGroupAutoWeightResponse DescribeReadOnlyGroupAutoWeightSync(DescribeReadOnlyGroupAutoWeightRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupAutoWeightResponse>(req, "DescribeReadOnlyGroupAutoWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the read-only group where the read-only instance is located by its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupByReadOnlyInstanceRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupByReadOnlyInstanceResponse"/></returns>
        public Task<DescribeReadOnlyGroupByReadOnlyInstanceResponse> DescribeReadOnlyGroupByReadOnlyInstance(DescribeReadOnlyGroupByReadOnlyInstanceRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupByReadOnlyInstanceResponse>(req, "DescribeReadOnlyGroupByReadOnlyInstance");
        }

        /// <summary>
        /// This API is used to query the read-only group where the read-only instance is located by its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupByReadOnlyInstanceRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupByReadOnlyInstanceResponse"/></returns>
        public DescribeReadOnlyGroupByReadOnlyInstanceResponse DescribeReadOnlyGroupByReadOnlyInstanceSync(DescribeReadOnlyGroupByReadOnlyInstanceRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupByReadOnlyInstanceResponse>(req, "DescribeReadOnlyGroupByReadOnlyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query read-only group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupDetailsResponse"/></returns>
        public Task<DescribeReadOnlyGroupDetailsResponse> DescribeReadOnlyGroupDetails(DescribeReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupDetailsResponse>(req, "DescribeReadOnlyGroupDetails");
        }

        /// <summary>
        /// This API is used to query read-only group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupDetailsResponse"/></returns>
        public DescribeReadOnlyGroupDetailsResponse DescribeReadOnlyGroupDetailsSync(DescribeReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupDetailsResponse>(req, "DescribeReadOnlyGroupDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the read-only group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupListRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupListResponse"/></returns>
        public Task<DescribeReadOnlyGroupListResponse> DescribeReadOnlyGroupList(DescribeReadOnlyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupListResponse>(req, "DescribeReadOnlyGroupList");
        }

        /// <summary>
        /// This API is used to query the read-only group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupListRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupListResponse"/></returns>
        public DescribeReadOnlyGroupListResponse DescribeReadOnlyGroupListSync(DescribeReadOnlyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupListResponse>(req, "DescribeReadOnlyGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query purchasable regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is used to query purchasable regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scheduled backup retention plans of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegularBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRegularBackupPlanResponse"/></returns>
        public Task<DescribeRegularBackupPlanResponse> DescribeRegularBackupPlan(DescribeRegularBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRegularBackupPlanResponse>(req, "DescribeRegularBackupPlan");
        }

        /// <summary>
        /// This API is used to query the scheduled backup retention plans of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegularBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRegularBackupPlanResponse"/></returns>
        public DescribeRegularBackupPlanResponse DescribeRegularBackupPlanSync(DescribeRegularBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRegularBackupPlanResponse>(req, "DescribeRegularBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of rollback tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskResponse"/></returns>
        public Task<DescribeRestoreTaskResponse> DescribeRestoreTask(DescribeRestoreTaskRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskResponse>(req, "DescribeRestoreTask");
        }

        /// <summary>
        /// This API is used to query the list of rollback tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskResponse"/></returns>
        public DescribeRestoreTaskResponse DescribeRestoreTaskSync(DescribeRestoreTaskRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskResponse>(req, "DescribeRestoreTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time range available for rollback by time point.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRestoreTimeRangeResponse"/></returns>
        public Task<DescribeRestoreTimeRangeResponse> DescribeRestoreTimeRange(DescribeRestoreTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTimeRangeResponse>(req, "DescribeRestoreTimeRange");
        }

        /// <summary>
        /// This API is used to query the time range available for rollback by time point.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRestoreTimeRangeResponse"/></returns>
        public DescribeRestoreTimeRangeResponse DescribeRestoreTimeRangeSync(DescribeRestoreTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTimeRangeResponse>(req, "DescribeRestoreTimeRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public Task<DescribeRollbackTimeResponse> DescribeRollbackTime(DescribeRollbackTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeResponse>(req, "DescribeRollbackTime");
        }

        /// <summary>
        /// This API is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public DescribeRollbackTimeResponse DescribeRollbackTimeSync(DescribeRollbackTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeResponse>(req, "DescribeRollbackTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get file information of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public Task<DescribeSlowlogsResponse> DescribeSlowlogs(DescribeSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowlogsResponse>(req, "DescribeSlowlogs");
        }

        /// <summary>
        /// This API is used to get file information of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public DescribeSlowlogsResponse DescribeSlowlogsSync(DescribeSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowlogsResponse>(req, "DescribeSlowlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status information on specifications, including the sales status and reference price. (The actual price is subject to the result returned by price querying APIs.)
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecSellStatusRequest"/></param>
        /// <returns><see cref="DescribeSpecSellStatusResponse"/></returns>
        public Task<DescribeSpecSellStatusResponse> DescribeSpecSellStatus(DescribeSpecSellStatusRequest req)
        {
            return InternalRequestAsync<DescribeSpecSellStatusResponse>(req, "DescribeSpecSellStatus");
        }

        /// <summary>
        /// This API is used to query the status information on specifications, including the sales status and reference price. (The actual price is subject to the result returned by price querying APIs.)
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecSellStatusRequest"/></param>
        /// <returns><see cref="DescribeSpecSellStatusResponse"/></returns>
        public DescribeSpecSellStatusResponse DescribeSpecSellStatusSync(DescribeSpecSellStatusRequest req)
        {
            return InternalRequestAsync<DescribeSpecSellStatusResponse>(req, "DescribeSpecSellStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pre-check the impact of the instance configuration adjustment before the adjustment.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradeInstanceCheckRequest"/></param>
        /// <returns><see cref="DescribeUpgradeInstanceCheckResponse"/></returns>
        public Task<DescribeUpgradeInstanceCheckResponse> DescribeUpgradeInstanceCheck(DescribeUpgradeInstanceCheckRequest req)
        {
            return InternalRequestAsync<DescribeUpgradeInstanceCheckResponse>(req, "DescribeUpgradeInstanceCheck");
        }

        /// <summary>
        /// This API is used to pre-check the impact of the instance configuration adjustment before the adjustment.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradeInstanceCheckRequest"/></param>
        /// <returns><see cref="DescribeUpgradeInstanceCheckResponse"/></returns>
        public DescribeUpgradeInstanceCheckResponse DescribeUpgradeInstanceCheckSync(DescribeUpgradeInstanceCheckRequest req)
        {
            return InternalRequestAsync<DescribeUpgradeInstanceCheckResponse>(req, "DescribeUpgradeInstanceCheck")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a backup upload permission.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadBackupInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadBackupInfoResponse"/></returns>
        public Task<DescribeUploadBackupInfoResponse> DescribeUploadBackupInfo(DescribeUploadBackupInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadBackupInfoResponse>(req, "DescribeUploadBackupInfo");
        }

        /// <summary>
        /// This API is used to query a backup upload permission.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadBackupInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadBackupInfoResponse"/></returns>
        public DescribeUploadBackupInfoResponse DescribeUploadBackupInfoSync(DescribeUploadBackupInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadBackupInfoResponse>(req, "DescribeUploadBackupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of extended events.
        /// </summary>
        /// <param name="req"><see cref="DescribeXEventsRequest"/></param>
        /// <returns><see cref="DescribeXEventsResponse"/></returns>
        public Task<DescribeXEventsResponse> DescribeXEvents(DescribeXEventsRequest req)
        {
            return InternalRequestAsync<DescribeXEventsResponse>(req, "DescribeXEvents");
        }

        /// <summary>
        /// This API is used to query the list of extended events.
        /// </summary>
        /// <param name="req"><see cref="DescribeXEventsRequest"/></param>
        /// <returns><see cref="DescribeXEventsResponse"/></returns>
        public DescribeXEventsResponse DescribeXEventsSync(DescribeXEventsRequest req)
        {
            return InternalRequestAsync<DescribeXEventsResponse>(req, "DescribeXEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query currently purchasable AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query currently purchasable AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to unbind security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of requested instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances");
        }

        /// <summary>
        /// This API is used to query the price of requested instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the upgrade prices of a monthly subscribed instance.
        /// .
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance");
        }

        /// <summary>
        /// This API is used to query the upgrade prices of a monthly subscribed instance.
        /// .
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance account permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilege(ModifyAccountPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegeResponse>(req, "ModifyAccountPrivilege");
        }

        /// <summary>
        /// This API is used to modify instance account permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public ModifyAccountPrivilegeResponse ModifyAccountPrivilegeSync(ModifyAccountPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegeResponse>(req, "ModifyAccountPrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify account remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public Task<ModifyAccountRemarkResponse> ModifyAccountRemark(ModifyAccountRemarkRequest req)
        {
            return InternalRequestAsync<ModifyAccountRemarkResponse>(req, "ModifyAccountRemark");
        }

        /// <summary>
        /// This API is used to modify account remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public ModifyAccountRemarkResponse ModifyAccountRemarkSync(ModifyAccountRemarkRequest req)
        {
            return InternalRequestAsync<ModifyAccountRemarkResponse>(req, "ModifyAccountRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a backup import task.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupMigrationRequest"/></param>
        /// <returns><see cref="ModifyBackupMigrationResponse"/></returns>
        public Task<ModifyBackupMigrationResponse> ModifyBackupMigration(ModifyBackupMigrationRequest req)
        {
            return InternalRequestAsync<ModifyBackupMigrationResponse>(req, "ModifyBackupMigration");
        }

        /// <summary>
        /// This API is used to modify a backup import task.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupMigrationRequest"/></param>
        /// <returns><see cref="ModifyBackupMigrationResponse"/></returns>
        public ModifyBackupMigrationResponse ModifyBackupMigrationSync(ModifyBackupMigrationRequest req)
        {
            return InternalRequestAsync<ModifyBackupMigrationResponse>(req, "ModifyBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the name of a backup task.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public Task<ModifyBackupNameResponse> ModifyBackupName(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName");
        }

        /// <summary>
        /// This API is used to modify the name of a backup task.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public ModifyBackupNameResponse ModifyBackupNameSync(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the backup policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public Task<ModifyBackupStrategyResponse> ModifyBackupStrategy(ModifyBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyBackupStrategyResponse>(req, "ModifyBackupStrategy");
        }

        /// <summary>
        /// This API is used to modify the backup policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public ModifyBackupStrategyResponse ModifyBackupStrategySync(ModifyBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyBackupStrategyResponse>(req, "ModifyBackupStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the public network for the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloseWanIpRequest"/></param>
        /// <returns><see cref="ModifyCloseWanIpResponse"/></returns>
        public Task<ModifyCloseWanIpResponse> ModifyCloseWanIp(ModifyCloseWanIpRequest req)
        {
            return InternalRequestAsync<ModifyCloseWanIpResponse>(req, "ModifyCloseWanIp");
        }

        /// <summary>
        /// This API is used to disable the public network for the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloseWanIpRequest"/></param>
        /// <returns><see cref="ModifyCloseWanIpResponse"/></returns>
        public ModifyCloseWanIpResponse ModifyCloseWanIpSync(ModifyCloseWanIpRequest req)
        {
            return InternalRequestAsync<ModifyCloseWanIpResponse>(req, "ModifyCloseWanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable cross-region backup policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyCrossBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyCrossBackupStrategyResponse"/></returns>
        public Task<ModifyCrossBackupStrategyResponse> ModifyCrossBackupStrategy(ModifyCrossBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyCrossBackupStrategyResponse>(req, "ModifyCrossBackupStrategy");
        }

        /// <summary>
        /// This API is used to enable or disable cross-region backup policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyCrossBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyCrossBackupStrategyResponse"/></returns>
        public ModifyCrossBackupStrategyResponse ModifyCrossBackupStrategySync(ModifyCrossBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyCrossBackupStrategyResponse>(req, "ModifyCrossBackupStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable TDE of a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public Task<ModifyDBEncryptAttributesResponse> ModifyDBEncryptAttributes(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes");
        }

        /// <summary>
        /// This API is used to enable or disable TDE of a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public ModifyDBEncryptAttributesResponse ModifyDBEncryptAttributesSync(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// This API is used to rename an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch a running instance from a VPC to another.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkResponse"/></returns>
        public Task<ModifyDBInstanceNetworkResponse> ModifyDBInstanceNetwork(ModifyDBInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkResponse>(req, "ModifyDBInstanceNetwork");
        }

        /// <summary>
        /// This API is used to switch a running instance from a VPC to another.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkResponse"/></returns>
        public ModifyDBInstanceNetworkResponse ModifyDBInstanceNetworkSync(ModifyDBInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkResponse>(req, "ModifyDBInstanceNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the instance remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNoteRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNoteResponse"/></returns>
        public Task<ModifyDBInstanceNoteResponse> ModifyDBInstanceNote(ModifyDBInstanceNoteRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNoteResponse>(req, "ModifyDBInstanceNote");
        }

        /// <summary>
        /// This API is used to modify the instance remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNoteRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNoteResponse"/></returns>
        public ModifyDBInstanceNoteResponse ModifyDBInstanceNoteSync(ModifyDBInstanceNoteRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNoteResponse>(req, "ModifyDBInstanceNote")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the project to which a database instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public Task<ModifyDBInstanceProjectResponse> ModifyDBInstanceProject(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject");
        }

        /// <summary>
        /// This API is used to modify the project to which a database instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public ModifyDBInstanceProjectResponse ModifyDBInstanceProjectSync(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable/disable/update SSL encryption.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSSLRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSSLResponse"/></returns>
        public Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSL(ModifyDBInstanceSSLRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSSLResponse>(req, "ModifyDBInstanceSSL");
        }

        /// <summary>
        /// This API is used to enable/disable/update SSL encryption.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSSLRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSSLResponse"/></returns>
        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSLSync(ModifyDBInstanceSSLRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSSLResponse>(req, "ModifyDBInstanceSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API is used to modify security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public Task<ModifyDBNameResponse> ModifyDBName(ModifyDBNameRequest req)
        {
            return InternalRequestAsync<ModifyDBNameResponse>(req, "ModifyDBName");
        }

        /// <summary>
        /// This API is used to rename a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public ModifyDBNameResponse ModifyDBNameSync(ModifyDBNameRequest req)
        {
            return InternalRequestAsync<ModifyDBNameResponse>(req, "ModifyDBName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify database remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public Task<ModifyDBRemarkResponse> ModifyDBRemark(ModifyDBRemarkRequest req)
        {
            return InternalRequestAsync<ModifyDBRemarkResponse>(req, "ModifyDBRemark");
        }

        /// <summary>
        /// This API is used to modify database remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public ModifyDBRemarkResponse ModifyDBRemarkSync(ModifyDBRemarkRequest req)
        {
            return InternalRequestAsync<ModifyDBRemarkResponse>(req, "ModifyDBRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable the read-only feature of the replica server.
        /// </summary>
        /// <param name="req"><see cref="ModifyDReadableRequest"/></param>
        /// <returns><see cref="ModifyDReadableResponse"/></returns>
        public Task<ModifyDReadableResponse> ModifyDReadable(ModifyDReadableRequest req)
        {
            return InternalRequestAsync<ModifyDReadableResponse>(req, "ModifyDReadable");
        }

        /// <summary>
        /// This API is used to enable or disable the read-only feature of the replica server.
        /// </summary>
        /// <param name="req"><see cref="ModifyDReadableRequest"/></param>
        /// <returns><see cref="ModifyDReadableResponse"/></returns>
        public ModifyDReadableResponse ModifyDReadableSync(ModifyDReadableRequest req)
        {
            return InternalRequestAsync<ModifyDReadableResponse>(req, "ModifyDReadable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable the change data capture (CDC) feature.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCDCRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCDCResponse"/></returns>
        public Task<ModifyDatabaseCDCResponse> ModifyDatabaseCDC(ModifyDatabaseCDCRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCDCResponse>(req, "ModifyDatabaseCDC");
        }

        /// <summary>
        /// This API is used to enable or disable the change data capture (CDC) feature.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCDCRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCDCResponse"/></returns>
        public ModifyDatabaseCDCResponse ModifyDatabaseCDCSync(ModifyDatabaseCDCRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCDCResponse>(req, "ModifyDatabaseCDC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable the change tracking (CT) feature.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCTRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCTResponse"/></returns>
        public Task<ModifyDatabaseCTResponse> ModifyDatabaseCT(ModifyDatabaseCTRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCTResponse>(req, "ModifyDatabaseCT");
        }

        /// <summary>
        /// This API is used to enable or disable the change tracking (CT) feature.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCTRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCTResponse"/></returns>
        public ModifyDatabaseCTResponse ModifyDatabaseCTSync(ModifyDatabaseCTRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCTResponse>(req, "ModifyDatabaseCT")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to shrink database MDF files.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseMdfRequest"/></param>
        /// <returns><see cref="ModifyDatabaseMdfResponse"/></returns>
        public Task<ModifyDatabaseMdfResponse> ModifyDatabaseMdf(ModifyDatabaseMdfRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseMdfResponse>(req, "ModifyDatabaseMdf");
        }

        /// <summary>
        /// This API is used to shrink database MDF files.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseMdfRequest"/></param>
        /// <returns><see cref="ModifyDatabaseMdfResponse"/></returns>
        public ModifyDatabaseMdfResponse ModifyDatabaseMdfSync(ModifyDatabaseMdfRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseMdfResponse>(req, "ModifyDatabaseMdf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance database permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabasePrivilegeRequest"/></param>
        /// <returns><see cref="ModifyDatabasePrivilegeResponse"/></returns>
        public Task<ModifyDatabasePrivilegeResponse> ModifyDatabasePrivilege(ModifyDatabasePrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyDatabasePrivilegeResponse>(req, "ModifyDatabasePrivilege");
        }

        /// <summary>
        /// This API is used to modify instance database permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabasePrivilegeRequest"/></param>
        /// <returns><see cref="ModifyDatabasePrivilegeResponse"/></returns>
        public ModifyDatabasePrivilegeResponse ModifyDatabasePrivilegeSync(ModifyDatabasePrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyDatabasePrivilegeResponse>(req, "ModifyDatabasePrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to shrink the database mdf (Shrink mdf).
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseShrinkMDFRequest"/></param>
        /// <returns><see cref="ModifyDatabaseShrinkMDFResponse"/></returns>
        public Task<ModifyDatabaseShrinkMDFResponse> ModifyDatabaseShrinkMDF(ModifyDatabaseShrinkMDFRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseShrinkMDFResponse>(req, "ModifyDatabaseShrinkMDF");
        }

        /// <summary>
        /// This API is used to shrink the database mdf (Shrink mdf).
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseShrinkMDFRequest"/></param>
        /// <returns><see cref="ModifyDatabaseShrinkMDFResponse"/></returns>
        public ModifyDatabaseShrinkMDFResponse ModifyDatabaseShrinkMDFSync(ModifyDatabaseShrinkMDFRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseShrinkMDFResponse>(req, "ModifyDatabaseShrinkMDF")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationResponse"/></returns>
        public Task<ModifyIncrementalMigrationResponse> ModifyIncrementalMigration(ModifyIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationResponse>(req, "ModifyIncrementalMigration");
        }

        /// <summary>
        /// This API is used to modify an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationResponse"/></returns>
        public ModifyIncrementalMigrationResponse ModifyIncrementalMigrationSync(ModifyIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationResponse>(req, "ModifyIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable TDE of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceEncryptAttributesResponse"/></returns>
        public Task<ModifyInstanceEncryptAttributesResponse> ModifyInstanceEncryptAttributes(ModifyInstanceEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEncryptAttributesResponse>(req, "ModifyInstanceEncryptAttributes");
        }

        /// <summary>
        /// This API is used to enable TDE of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceEncryptAttributesResponse"/></returns>
        public ModifyInstanceEncryptAttributesResponse ModifyInstanceEncryptAttributesSync(ModifyInstanceEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEncryptAttributesResponse>(req, "ModifyInstanceEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// <b>Note</b>: if <b>the instance needs to be restarted</b> for the modified parameter to take effect, <b>it will be restarted</b> immediately or during the maintenance time according to the `WaitSwitch` parameter.
        /// Before you modify a parameter, you can use the `DescribeInstanceParams` API to query whether the instance needs to be restarted.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam");
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// <b>Note</b>: if <b>the instance needs to be restarted</b> for the modified parameter to take effect, <b>it will be restarted</b> immediately or during the maintenance time according to the `WaitSwitch` parameter.
        /// Before you modify a parameter, you can use the `DescribeInstanceParams` API to query whether the instance needs to be restarted.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the maintenance window of the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceSpanRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceSpanResponse"/></returns>
        public Task<ModifyMaintenanceSpanResponse> ModifyMaintenanceSpan(ModifyMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceSpanResponse>(req, "ModifyMaintenanceSpan");
        }

        /// <summary>
        /// This API is used to modify the maintenance window of the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceSpanRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceSpanResponse"/></returns>
        public ModifyMaintenanceSpanResponse ModifyMaintenanceSpanSync(ModifyMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceSpanResponse>(req, "ModifyMaintenanceSpan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an existing migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public Task<ModifyMigrationResponse> ModifyMigration(ModifyMigrationRequest req)
        {
            return InternalRequestAsync<ModifyMigrationResponse>(req, "ModifyMigration");
        }

        /// <summary>
        /// This API is used to modify an existing migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public ModifyMigrationResponse ModifyMigrationSync(ModifyMigrationRequest req)
        {
            return InternalRequestAsync<ModifyMigrationResponse>(req, "ModifyMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the public network for the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyOpenWanIpRequest"/></param>
        /// <returns><see cref="ModifyOpenWanIpResponse"/></returns>
        public Task<ModifyOpenWanIpResponse> ModifyOpenWanIp(ModifyOpenWanIpRequest req)
        {
            return InternalRequestAsync<ModifyOpenWanIpResponse>(req, "ModifyOpenWanIp");
        }

        /// <summary>
        /// This API is used to enable the public network for the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyOpenWanIpRequest"/></param>
        /// <returns><see cref="ModifyOpenWanIpResponse"/></returns>
        public ModifyOpenWanIpResponse ModifyOpenWanIpSync(ModifyOpenWanIpRequest req)
        {
            return InternalRequestAsync<ModifyOpenWanIpResponse>(req, "ModifyOpenWanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the publish/subscribe relationship of the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeResponse"/></returns>
        public Task<ModifyPublishSubscribeResponse> ModifyPublishSubscribe(ModifyPublishSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeResponse>(req, "ModifyPublishSubscribe");
        }

        /// <summary>
        /// This API is used to modify the publish/subscribe relationship of the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeResponse"/></returns>
        public ModifyPublishSubscribeResponse ModifyPublishSubscribeSync(ModifyPublishSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeResponse>(req, "ModifyPublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the publish/subscribe names.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeNameRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeNameResponse"/></returns>
        public Task<ModifyPublishSubscribeNameResponse> ModifyPublishSubscribeName(ModifyPublishSubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeNameResponse>(req, "ModifyPublishSubscribeName");
        }

        /// <summary>
        /// This API is used to modify the publish/subscribe names.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeNameRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeNameResponse"/></returns>
        public ModifyPublishSubscribeNameResponse ModifyPublishSubscribeNameSync(ModifyPublishSubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeNameResponse>(req, "ModifyPublishSubscribeName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify read-only group details.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupDetailsResponse"/></returns>
        public Task<ModifyReadOnlyGroupDetailsResponse> ModifyReadOnlyGroupDetails(ModifyReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupDetailsResponse>(req, "ModifyReadOnlyGroupDetails");
        }

        /// <summary>
        /// This API is used to modify read-only group details.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupDetailsResponse"/></returns>
        public ModifyReadOnlyGroupDetailsResponse ModifyReadOnlyGroupDetailsSync(ModifyReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupDetailsResponse>(req, "ModifyReadOnlyGroupDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable instance interconnection, which can interconnect business intelligence services.
        /// </summary>
        /// <param name="req"><see cref="OpenInterCommunicationRequest"/></param>
        /// <returns><see cref="OpenInterCommunicationResponse"/></returns>
        public Task<OpenInterCommunicationResponse> OpenInterCommunication(OpenInterCommunicationRequest req)
        {
            return InternalRequestAsync<OpenInterCommunicationResponse>(req, "OpenInterCommunication");
        }

        /// <summary>
        /// This API is used to enable instance interconnection, which can interconnect business intelligence services.
        /// </summary>
        /// <param name="req"><see cref="OpenInterCommunicationRequest"/></param>
        /// <returns><see cref="OpenInterCommunicationResponse"/></returns>
        public OpenInterCommunicationResponse OpenInterCommunicationSync(OpenInterCommunicationRequest req)
        {
            return InternalRequestAsync<OpenInterCommunicationResponse>(req, "OpenInterCommunication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return a deactivated SQL Server instance.
        /// </summary>
        /// <param name="req"><see cref="RecycleDBInstanceRequest"/></param>
        /// <returns><see cref="RecycleDBInstanceResponse"/></returns>
        public Task<RecycleDBInstanceResponse> RecycleDBInstance(RecycleDBInstanceRequest req)
        {
            return InternalRequestAsync<RecycleDBInstanceResponse>(req, "RecycleDBInstance");
        }

        /// <summary>
        /// This API is used to return a deactivated SQL Server instance.
        /// </summary>
        /// <param name="req"><see cref="RecycleDBInstanceRequest"/></param>
        /// <returns><see cref="RecycleDBInstanceResponse"/></returns>
        public RecycleDBInstanceResponse RecycleDBInstanceSync(RecycleDBInstanceRequest req)
        {
            return InternalRequestAsync<RecycleDBInstanceResponse>(req, "RecycleDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reclaim resources of read-only groups immediately. The resources, such as VIP, occupied by the read-only group will be released immediately and cannot be recovered.
        /// </summary>
        /// <param name="req"><see cref="RecycleReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RecycleReadOnlyGroupResponse"/></returns>
        public Task<RecycleReadOnlyGroupResponse> RecycleReadOnlyGroup(RecycleReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RecycleReadOnlyGroupResponse>(req, "RecycleReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to reclaim resources of read-only groups immediately. The resources, such as VIP, occupied by the read-only group will be released immediately and cannot be recovered.
        /// </summary>
        /// <param name="req"><see cref="RecycleReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RecycleReadOnlyGroupResponse"/></returns>
        public RecycleReadOnlyGroupResponse RecycleReadOnlyGroupSync(RecycleReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RecycleReadOnlyGroupResponse>(req, "RecycleReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete backup files created by users manually. The backup policy to be deleted can be instance backup or multi-database backup.
        /// </summary>
        /// <param name="req"><see cref="RemoveBackupsRequest"/></param>
        /// <returns><see cref="RemoveBackupsResponse"/></returns>
        public Task<RemoveBackupsResponse> RemoveBackups(RemoveBackupsRequest req)
        {
            return InternalRequestAsync<RemoveBackupsResponse>(req, "RemoveBackups");
        }

        /// <summary>
        /// This API is used to delete backup files created by users manually. The backup policy to be deleted can be instance backup or multi-database backup.
        /// </summary>
        /// <param name="req"><see cref="RemoveBackupsRequest"/></param>
        /// <returns><see cref="RemoveBackupsResponse"/></returns>
        public RemoveBackupsResponse RemoveBackupsSync(RemoveBackupsRequest req)
        {
            return InternalRequestAsync<RemoveBackupsResponse>(req, "RemoveBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover the pay-as-you-go instance that is manually isolated through the API TerminateDBInstance from the recycle bin.
        /// </summary>
        /// <param name="req"><see cref="RenewPostpaidDBInstanceRequest"/></param>
        /// <returns><see cref="RenewPostpaidDBInstanceResponse"/></returns>
        public Task<RenewPostpaidDBInstanceResponse> RenewPostpaidDBInstance(RenewPostpaidDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewPostpaidDBInstanceResponse>(req, "RenewPostpaidDBInstance");
        }

        /// <summary>
        /// This API is used to recover the pay-as-you-go instance that is manually isolated through the API TerminateDBInstance from the recycle bin.
        /// </summary>
        /// <param name="req"><see cref="RenewPostpaidDBInstanceRequest"/></param>
        /// <returns><see cref="RenewPostpaidDBInstanceResponse"/></returns>
        public RenewPostpaidDBInstanceResponse RenewPostpaidDBInstanceSync(RenewPostpaidDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewPostpaidDBInstanceResponse>(req, "RenewPostpaidDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the account password of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// This API is used to reset the account password of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart a database instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance");
        }

        /// <summary>
        /// This API is used to restart a database instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to roll back the database by backup set.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance");
        }

        /// <summary>
        /// This API is used to roll back the database by backup set.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to roll back the instance by time point.
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public Task<RollbackInstanceResponse> RollbackInstance(RollbackInstanceRequest req)
        {
            return InternalRequestAsync<RollbackInstanceResponse>(req, "RollbackInstance");
        }

        /// <summary>
        /// This API is used to roll back the instance by time point.
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public RollbackInstanceResponse RollbackInstanceSync(RollbackInstanceRequest req)
        {
            return InternalRequestAsync<RollbackInstanceResponse>(req, "RollbackInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start running a migration task.
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public Task<RunMigrationResponse> RunMigration(RunMigrationRequest req)
        {
            return InternalRequestAsync<RunMigrationResponse>(req, "RunMigration");
        }

        /// <summary>
        /// This API is used to start running a migration task.
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public RunMigrationResponse RunMigrationSync(RunMigrationRequest req)
        {
            return InternalRequestAsync<RunMigrationResponse>(req, "RunMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a backup import task.
        /// </summary>
        /// <param name="req"><see cref="StartBackupMigrationRequest"/></param>
        /// <returns><see cref="StartBackupMigrationResponse"/></returns>
        public Task<StartBackupMigrationResponse> StartBackupMigration(StartBackupMigrationRequest req)
        {
            return InternalRequestAsync<StartBackupMigrationResponse>(req, "StartBackupMigration");
        }

        /// <summary>
        /// This API is used to start a backup import task.
        /// </summary>
        /// <param name="req"><see cref="StartBackupMigrationRequest"/></param>
        /// <returns><see cref="StartBackupMigrationResponse"/></returns>
        public StartBackupMigrationResponse StartBackupMigrationSync(StartBackupMigrationRequest req)
        {
            return InternalRequestAsync<StartBackupMigrationResponse>(req, "StartBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="StartIncrementalMigrationRequest"/></param>
        /// <returns><see cref="StartIncrementalMigrationResponse"/></returns>
        public Task<StartIncrementalMigrationResponse> StartIncrementalMigration(StartIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<StartIncrementalMigrationResponse>(req, "StartIncrementalMigration");
        }

        /// <summary>
        /// This API is used to start an incremental backup import task.
        /// </summary>
        /// <param name="req"><see cref="StartIncrementalMigrationRequest"/></param>
        /// <returns><see cref="StartIncrementalMigrationResponse"/></returns>
        public StartIncrementalMigrationResponse StartIncrementalMigrationSync(StartIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<StartIncrementalMigrationResponse>(req, "StartIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start and stop an extended event.
        /// </summary>
        /// <param name="req"><see cref="StartInstanceXEventRequest"/></param>
        /// <returns><see cref="StartInstanceXEventResponse"/></returns>
        public Task<StartInstanceXEventResponse> StartInstanceXEvent(StartInstanceXEventRequest req)
        {
            return InternalRequestAsync<StartInstanceXEventResponse>(req, "StartInstanceXEvent");
        }

        /// <summary>
        /// This API is used to start and stop an extended event.
        /// </summary>
        /// <param name="req"><see cref="StartInstanceXEventRequest"/></param>
        /// <returns><see cref="StartInstanceXEventResponse"/></returns>
        public StartInstanceXEventResponse StartInstanceXEventSync(StartInstanceXEventRequest req)
        {
            return InternalRequestAsync<StartInstanceXEventResponse>(req, "StartInstanceXEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manually switch between primary and secondary.
        /// </summary>
        /// <param name="req"><see cref="SwitchCloudInstanceHARequest"/></param>
        /// <returns><see cref="SwitchCloudInstanceHAResponse"/></returns>
        public Task<SwitchCloudInstanceHAResponse> SwitchCloudInstanceHA(SwitchCloudInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchCloudInstanceHAResponse>(req, "SwitchCloudInstanceHA");
        }

        /// <summary>
        /// This API is used to manually switch between primary and secondary.
        /// </summary>
        /// <param name="req"><see cref="SwitchCloudInstanceHARequest"/></param>
        /// <returns><see cref="SwitchCloudInstanceHAResponse"/></returns>
        public SwitchCloudInstanceHAResponse SwitchCloudInstanceHASync(SwitchCloudInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchCloudInstanceHAResponse>(req, "SwitchCloudInstanceHA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate an instance to move it into a recycle bin.
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public Task<TerminateDBInstanceResponse> TerminateDBInstance(TerminateDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDBInstanceResponse>(req, "TerminateDBInstance");
        }

        /// <summary>
        /// This API is used to isolate an instance to move it into a recycle bin.
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public TerminateDBInstanceResponse TerminateDBInstanceSync(TerminateDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDBInstanceResponse>(req, "TerminateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance");
        }

        /// <summary>
        /// This API is used to upgrade an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
