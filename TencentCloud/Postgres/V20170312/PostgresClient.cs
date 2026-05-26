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

namespace TencentCloud.Postgres.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Postgres.V20170312.Models;

   public class PostgresClient : AbstractClient{

       private const string endpoint = "postgres.intl.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1319";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PostgresClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PostgresClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add a read-only replica to an RO group.
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public Task<AddDBInstanceToReadOnlyGroupResponse> AddDBInstanceToReadOnlyGroup(AddDBInstanceToReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<AddDBInstanceToReadOnlyGroupResponse>(req, "AddDBInstanceToReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to add a read-only replica to an RO group.
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public AddDBInstanceToReadOnlyGroupResponse AddDBInstanceToReadOnlyGroupSync(AddDBInstanceToReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<AddDBInstanceToReadOnlyGroupResponse>(req, "AddDBInstanceToReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clone an instance by specifying a backup set or a point in time.
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public Task<CloneDBInstanceResponse> CloneDBInstance(CloneDBInstanceRequest req)
        {
            return InternalRequestAsync<CloneDBInstanceResponse>(req, "CloneDBInstance");
        }

        /// <summary>
        /// This API is used to clone an instance by specifying a backup set or a point in time.
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public CloneDBInstanceResponse CloneDBInstanceSync(CloneDBInstanceRequest req)
        {
            return InternalRequestAsync<CloneDBInstanceResponse>(req, "CloneDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable CAM verification service for a database account.
        /// </summary>
        /// <param name="req"><see cref="CloseAccountCAMRequest"/></param>
        /// <returns><see cref="CloseAccountCAMResponse"/></returns>
        public Task<CloseAccountCAMResponse> CloseAccountCAM(CloseAccountCAMRequest req)
        {
            return InternalRequestAsync<CloseAccountCAMResponse>(req, "CloseAccountCAM");
        }

        /// <summary>
        /// This API is used to disable CAM verification service for a database account.
        /// </summary>
        /// <param name="req"><see cref="CloseAccountCAMRequest"/></param>
        /// <returns><see cref="CloseAccountCAMResponse"/></returns>
        public CloseAccountCAMResponse CloseAccountCAMSync(CloseAccountCAMRequest req)
        {
            return InternalRequestAsync<CloseAccountCAMResponse>(req, "CloseAccountCAM")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the audit feature for a database instance.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public Task<CloseAuditServiceResponse> CloseAuditService(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService");
        }

        /// <summary>
        /// This API is used to disable the audit feature for a database instance.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public CloseAuditServiceResponse CloseAuditServiceSync(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the public network address of an instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess");
        }

        /// <summary>
        /// This API is used to disable the public network address of an instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data account. The returned Oid is the unique identifier of the account, which matches the oid recorded in the database system table pg_roles.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
        }

        /// <summary>
        /// This API is used to create a data account. The returned Oid is the unique identifier of the account, which matches the oid recorded in the database system table pg_roles.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creating an Audit Log File
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public Task<CreateAuditLogFileResponse> CreateAuditLogFile(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile");
        }

        /// <summary>
        /// Creating an Audit Log File
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public CreateAuditLogFileResponse CreateAuditLogFileSync(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a backup policy.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupPlanRequest"/></param>
        /// <returns><see cref="CreateBackupPlanResponse"/></returns>
        public Task<CreateBackupPlanResponse> CreateBackupPlan(CreateBackupPlanRequest req)
        {
            return InternalRequestAsync<CreateBackupPlanResponse>(req, "CreateBackupPlan");
        }

        /// <summary>
        /// This API is used to create a backup policy.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupPlanRequest"/></param>
        /// <returns><see cref="CreateBackupPlanResponse"/></returns>
        public CreateBackupPlanResponse CreateBackupPlanSync(CreateBackupPlanRequest req)
        {
            return InternalRequestAsync<CreateBackupPlanResponse>(req, "CreateBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public Task<CreateBaseBackupResponse> CreateBaseBackup(CreateBaseBackupRequest req)
        {
            return InternalRequestAsync<CreateBaseBackupResponse>(req, "CreateBaseBackup");
        }

        /// <summary>
        /// This API is used to create a data backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public CreateBaseBackupResponse CreateBaseBackupSync(CreateBaseBackupRequest req)
        {
            return InternalRequestAsync<CreateBaseBackupResponse>(req, "CreateBaseBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create instance networks. Each instance allows a maximum of 2 network configurations and a minimum of 1.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public Task<CreateDBInstanceNetworkAccessResponse> CreateDBInstanceNetworkAccess(CreateDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceNetworkAccessResponse>(req, "CreateDBInstanceNetworkAccess");
        }

        /// <summary>
        /// This API is used to create instance networks. Each instance allows a maximum of 2 network configurations and a minimum of 1.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public CreateDBInstanceNetworkAccessResponse CreateDBInstanceNetworkAccessSync(CreateDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceNetworkAccessResponse>(req, "CreateDBInstanceNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a database, requiring the specified database name and owner.
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase");
        }

        /// <summary>
        /// This API is used to create a database, requiring the specified database name and owner.
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public CreateDatabaseResponse CreateDatabaseSync(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create one or more PostgreSQL instances. Instances created through this interface do not need to be initialized and can be used directly.
        /// <li>After an instance is successfully created, it will automatically start up, and its status changes to "Running".</li>
        /// <li>For prepaid instances, the required amount for the instance purchase will be deducted in advance. For post-paid hourly instances, the amount required for the purchase within the first hour will be temporarily frozen. Please ensure that your account balance is sufficient before calling this interface.</li>
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// This API is used to create one or more PostgreSQL instances. Instances created through this interface do not need to be initialized and can be used directly.
        /// <li>After an instance is successfully created, it will automatically start up, and its status changes to "Running".</li>
        /// <li>For prepaid instances, the required amount for the instance purchase will be deducted in advance. For post-paid hourly instances, the amount required for the purchase within the first hour will be temporarily frozen. Please ensure that your account balance is sufficient before calling this interface.</li>
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public Task<CreateParameterTemplateResponse> CreateParameterTemplate(CreateParameterTemplateRequest req)
        {
            return InternalRequestAsync<CreateParameterTemplateResponse>(req, "CreateParameterTemplate");
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public CreateParameterTemplateResponse CreateParameterTemplateSync(CreateParameterTemplateRequest req)
        {
            return InternalRequestAsync<CreateParameterTemplateResponse>(req, "CreateParameterTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create read-only replicas.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstance(CreateReadOnlyDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstanceResponse>(req, "CreateReadOnlyDBInstance");
        }

        /// <summary>
        /// This API is used to create read-only replicas.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstanceSync(CreateReadOnlyDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstanceResponse>(req, "CreateReadOnlyDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public Task<CreateReadOnlyGroupResponse> CreateReadOnlyGroup(CreateReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupResponse>(req, "CreateReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to create an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public CreateReadOnlyGroupResponse CreateReadOnlyGroupSync(CreateReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupResponse>(req, "CreateReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create network for RO groups. The largest quantity of networks to create is 2.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public Task<CreateReadOnlyGroupNetworkAccessResponse> CreateReadOnlyGroupNetworkAccess(CreateReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupNetworkAccessResponse>(req, "CreateReadOnlyGroupNetworkAccess");
        }

        /// <summary>
        /// This API is used to create network for RO groups. The largest quantity of networks to create is 2.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public CreateReadOnlyGroupNetworkAccessResponse CreateReadOnlyGroupNetworkAccessSync(CreateReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupNetworkAccessResponse>(req, "CreateReadOnlyGroupNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a database account. Oid and UserName must be input simultaneously to avoid accidental deletion. Note: This API is reentrant. If the account no longer exists, calling this API to delete it will not trigger an error.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount");
        }

        /// <summary>
        /// This API is used to delete a database account. Oid and UserName must be input simultaneously to avoid accidental deletion. Note: This API is reentrant. If the account no longer exists, calling this API to delete it will not trigger an error.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an audit log file
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public Task<DeleteAuditLogFileResponse> DeleteAuditLogFile(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile");
        }

        /// <summary>
        /// Deletes an audit log file
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public DeleteAuditLogFileResponse DeleteAuditLogFileSync(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a backup policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteBackupPlanResponse"/></returns>
        public Task<DeleteBackupPlanResponse> DeleteBackupPlan(DeleteBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteBackupPlanResponse>(req, "DeleteBackupPlan");
        }

        /// <summary>
        /// This API is used to delete a backup policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteBackupPlanResponse"/></returns>
        public DeleteBackupPlanResponse DeleteBackupPlanSync(DeleteBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteBackupPlanResponse>(req, "DeleteBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a specified data backup for an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public Task<DeleteBaseBackupResponse> DeleteBaseBackup(DeleteBaseBackupRequest req)
        {
            return InternalRequestAsync<DeleteBaseBackupResponse>(req, "DeleteBaseBackup");
        }

        /// <summary>
        /// This API is used to delete a specified data backup for an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public DeleteBaseBackupResponse DeleteBaseBackupSync(DeleteBaseBackupRequest req)
        {
            return InternalRequestAsync<DeleteBaseBackupResponse>(req, "DeleteBaseBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a network from an instance while keeping at least one network.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public Task<DeleteDBInstanceNetworkAccessResponse> DeleteDBInstanceNetworkAccess(DeleteDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceNetworkAccessResponse>(req, "DeleteDBInstanceNetworkAccess");
        }

        /// <summary>
        /// This API is used to delete a network from an instance while keeping at least one network.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public DeleteDBInstanceNetworkAccessResponse DeleteDBInstanceNetworkAccessSync(DeleteDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceNetworkAccessResponse>(req, "DeleteDBInstanceNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the specified log backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public Task<DeleteLogBackupResponse> DeleteLogBackup(DeleteLogBackupRequest req)
        {
            return InternalRequestAsync<DeleteLogBackupResponse>(req, "DeleteLogBackup");
        }

        /// <summary>
        /// This API is used to delete the specified log backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public DeleteLogBackupResponse DeleteLogBackupSync(DeleteLogBackupRequest req)
        {
            return InternalRequestAsync<DeleteLogBackupResponse>(req, "DeleteLogBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public Task<DeleteParameterTemplateResponse> DeleteParameterTemplate(DeleteParameterTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParameterTemplateResponse>(req, "DeleteParameterTemplate");
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public DeleteParameterTemplateResponse DeleteParameterTemplateSync(DeleteParameterTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParameterTemplateResponse>(req, "DeleteParameterTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public Task<DeleteReadOnlyGroupResponse> DeleteReadOnlyGroup(DeleteReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupResponse>(req, "DeleteReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to delete an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public DeleteReadOnlyGroupResponse DeleteReadOnlyGroupSync(DeleteReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupResponse>(req, "DeleteReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a network from an RO group (at least 1 network must remain).
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public Task<DeleteReadOnlyGroupNetworkAccessResponse> DeleteReadOnlyGroupNetworkAccess(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupNetworkAccessResponse>(req, "DeleteReadOnlyGroupNetworkAccess");
        }

        /// <summary>
        /// This API is used to delete a network from an RO group (at least 1 network must remain).
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public DeleteReadOnlyGroupNetworkAccessResponse DeleteReadOnlyGroupNetworkAccessSync(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupNetworkAccessResponse>(req, "DeleteReadOnlyGroupNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the permission list of a database account on a database object.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// This API is used to query the permission list of a database account on a database object.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of the database accounts for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// This API is used to query the list of the database accounts for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the audit instance list
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// Query the audit instance list
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries audit log files
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public Task<DescribeAuditLogFilesResponse> DescribeAuditLogFiles(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles");
        }

        /// <summary>
        /// Queries audit log files
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public DescribeAuditLogFilesResponse DescribeAuditLogFilesSync(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a Database Audit log.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public Task<DescribeAuditLogsResponse> DescribeAuditLogs(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs");
        }

        /// <summary>
        /// This API is used to query a Database Audit log.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public DescribeAuditLogsResponse DescribeAuditLogsSync(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the available restoration time of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTime(DescribeAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeAvailableRecoveryTimeResponse>(req, "DescribeAvailableRecoveryTime");
        }

        /// <summary>
        /// This API is used to query the available restoration time of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTimeSync(DescribeAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeAvailableRecoveryTimeResponse>(req, "DescribeAvailableRecoveryTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to query the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// u200cThis API is used to query the download address of a specified backup set, including full backup sets and incremental log backup sets.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public Task<DescribeBackupDownloadURLResponse> DescribeBackupDownloadURL(DescribeBackupDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadURLResponse>(req, "DescribeBackupDownloadURL");
        }

        /// <summary>
        /// u200cThis API is used to query the download address of a specified backup set, including full backup sets and incremental log backup sets.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public DescribeBackupDownloadURLResponse DescribeBackupDownloadURLSync(DescribeBackupDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadURLResponse>(req, "DescribeBackupDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup overview. It will return the current number and size of backups, free backup space size, and paid backup space size (all size values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public Task<DescribeBackupOverviewResponse> DescribeBackupOverview(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview");
        }

        /// <summary>
        /// This API is used to query the backup overview. It will return the current number and size of backups, free backup space size, and paid backup space size (all size values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public DescribeBackupOverviewResponse DescribeBackupOverviewSync(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all backup plans of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public Task<DescribeBackupPlansResponse> DescribeBackupPlans(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans");
        }

        /// <summary>
        /// This API is used to query all backup plans of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public DescribeBackupPlansResponse DescribeBackupPlansSync(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup statistics of an instance. It will return the number and size (bytes) of backups of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public Task<DescribeBackupSummariesResponse> DescribeBackupSummaries(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries");
        }

        /// <summary>
        /// This API is used to query the backup statistics of an instance. It will return the number and size (bytes) of backups of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public DescribeBackupSummariesResponse DescribeBackupSummariesSync(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of data backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public Task<DescribeBaseBackupsResponse> DescribeBaseBackups(DescribeBaseBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBaseBackupsResponse>(req, "DescribeBaseBackups");
        }

        /// <summary>
        /// This API is used to query the list of data backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public DescribeBaseBackupsResponse DescribeBaseBackupsSync(DescribeBaseBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBaseBackupsResponse>(req, "DescribeBaseBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public Task<DescribeClassesResponse> DescribeClasses(DescribeClassesRequest req)
        {
            return InternalRequestAsync<DescribeClassesResponse>(req, "DescribeClasses");
        }

        /// <summary>
        /// This API is used to query purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public DescribeClassesResponse DescribeClassesSync(DescribeClassesRequest req)
        {
            return InternalRequestAsync<DescribeClassesResponse>(req, "DescribeClasses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the minimum specification required by a cloned instance, including `SpecCode` and disk specification.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public Task<DescribeCloneDBInstanceSpecResponse> DescribeCloneDBInstanceSpec(DescribeCloneDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<DescribeCloneDBInstanceSpecResponse>(req, "DescribeCloneDBInstanceSpec");
        }

        /// <summary>
        /// This API is used to query the minimum specification required by a cloned instance, including `SpecCode` and disk specification.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public DescribeCloneDBInstanceSpecResponse DescribeCloneDBInstanceSpecSync(DescribeCloneDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<DescribeCloneDBInstanceSpecResponse>(req, "DescribeCloneDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This api is used to query instance backup list. This interface belongs to early stage and stopped feature iteration. We recommend using api [DescribeBaseBackups](https://www.tencentcloud.com/document/product/409/54343) as an alternative.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public Task<DescribeDBBackupsResponse> DescribeDBBackups(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups");
        }

        /// <summary>
        /// This api is used to query instance backup list. This interface belongs to early stage and stopped feature iteration. We recommend using api [DescribeBaseBackups](https://www.tencentcloud.com/document/product/409/54343) as an alternative.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public DescribeDBBackupsResponse DescribeDBBackupsSync(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an error log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public Task<DescribeDBErrlogsResponse> DescribeDBErrlogs(DescribeDBErrlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBErrlogsResponse>(req, "DescribeDBErrlogs");
        }

        /// <summary>
        /// This API is used to query an error log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public DescribeDBErrlogsResponse DescribeDBErrlogsSync(DescribeDBErrlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBErrlogsResponse>(req, "DescribeDBErrlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of one instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceAttributeResponse>(req, "DescribeDBInstanceAttribute");
        }

        /// <summary>
        /// This API is used to query the details of one instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeSync(DescribeDBInstanceAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceAttributeResponse>(req, "DescribeDBInstanceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDBInstanceHConfig) is used to query instance HA configuration information. The HA configuration information includes:
        /// <li>This API is used to configure conditions for allowing a secondary node to switch over to a primary node.</li>.
        /// <li>This API is used to configure conditions for using synchronous or asynchronous replication in semi-sync instances.</li>.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceHAConfigResponse"/></returns>
        public Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfig(DescribeDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceHAConfigResponse>(req, "DescribeDBInstanceHAConfig");
        }

        /// <summary>
        /// This API (DescribeDBInstanceHConfig) is used to query instance HA configuration information. The HA configuration information includes:
        /// <li>This API is used to configure conditions for allowing a secondary node to switch over to a primary node.</li>.
        /// <li>This API is used to configure conditions for using synchronous or asynchronous replication in semi-sync instances.</li>.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceHAConfigResponse"/></returns>
        public DescribeDBInstanceHAConfigResponse DescribeDBInstanceHAConfigSync(DescribeDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceHAConfigResponse>(req, "DescribeDBInstanceHAConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the parameters of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public Task<DescribeDBInstanceParametersResponse> DescribeDBInstanceParameters(DescribeDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParametersResponse>(req, "DescribeDBInstanceParameters");
        }

        /// <summary>
        /// This API is used to query the parameters of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public DescribeDBInstanceParametersResponse DescribeDBInstanceParametersSync(DescribeDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParametersResponse>(req, "DescribeDBInstanceParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the SSL status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSSLConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSSLConfigResponse"/></returns>
        public Task<DescribeDBInstanceSSLConfigResponse> DescribeDBInstanceSSLConfig(DescribeDBInstanceSSLConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceSSLConfigResponse>(req, "DescribeDBInstanceSSLConfig");
        }

        /// <summary>
        /// This API is used to query the SSL status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSSLConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSSLConfigResponse"/></returns>
        public DescribeDBInstanceSSLConfigResponse DescribeDBInstanceSSLConfigSync(DescribeDBInstanceSSLConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceSSLConfigResponse>(req, "DescribeDBInstanceSSLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public Task<DescribeDBInstanceSecurityGroupsResponse> DescribeDBInstanceSecurityGroups(DescribeDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceSecurityGroupsResponse>(req, "DescribeDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API is used to query the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public DescribeDBInstanceSecurityGroupsResponse DescribeDBInstanceSecurityGroupsSync(DescribeDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceSecurityGroupsResponse>(req, "DescribeDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// This API is used to query the details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of supported database versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public Task<DescribeDBVersionsResponse> DescribeDBVersions(DescribeDBVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDBVersionsResponse>(req, "DescribeDBVersions");
        }

        /// <summary>
        /// This API is used to query the list of supported database versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public DescribeDBVersionsResponse DescribeDBVersionsSync(DescribeDBVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDBVersionsResponse>(req, "DescribeDBVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This api is used to get instance Xlog list. This interface belongs to early api and has stopped feature iteration. We recommend using api [DescribeLogBackups](https://www.tencentcloud.com/document/api/409/89021?from_cn_redirect=1) as substitution.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public Task<DescribeDBXlogsResponse> DescribeDBXlogs(DescribeDBXlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBXlogsResponse>(req, "DescribeDBXlogs");
        }

        /// <summary>
        /// This api is used to get instance Xlog list. This interface belongs to early api and has stopped feature iteration. We recommend using api [DescribeLogBackups](https://www.tencentcloud.com/document/api/409/89021?from_cn_redirect=1) as substitution.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public DescribeDBXlogsResponse DescribeDBXlogsSync(DescribeDBXlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBXlogsResponse>(req, "DescribeDBXlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database object list, such as the mode list in test database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public Task<DescribeDatabaseObjectsResponse> DescribeDatabaseObjects(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects");
        }

        /// <summary>
        /// This API is used to query database object list, such as the mode list in test database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public DescribeDatabaseObjectsResponse DescribeDatabaseObjectsSync(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the database list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// This API is used to query the database list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an exclusive cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClustersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClustersResponse"/></returns>
        public Task<DescribeDedicatedClustersResponse> DescribeDedicatedClusters(DescribeDedicatedClustersRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClustersResponse>(req, "DescribeDedicatedClusters");
        }

        /// <summary>
        /// This API is used to query an exclusive cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClustersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClustersResponse"/></returns>
        public DescribeDedicatedClustersResponse DescribeDedicatedClustersSync(DescribeDedicatedClustersRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClustersResponse>(req, "DescribeDedicatedClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all parameters supported by a database version and engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public Task<DescribeDefaultParametersResponse> DescribeDefaultParameters(DescribeDefaultParametersRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParametersResponse>(req, "DescribeDefaultParameters");
        }

        /// <summary>
        /// This API is used to query all parameters supported by a database version and engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public DescribeDefaultParametersResponse DescribeDefaultParametersSync(DescribeDefaultParametersRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParametersResponse>(req, "DescribeDefaultParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public Task<DescribeEncryptionKeysResponse> DescribeEncryptionKeys(DescribeEncryptionKeysRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionKeysResponse>(req, "DescribeEncryptionKeys");
        }

        /// <summary>
        /// This API is used to query the instance key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public DescribeEncryptionKeysResponse DescribeEncryptionKeysSync(DescribeEncryptionKeysRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionKeysResponse>(req, "DescribeEncryptionKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of log backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public Task<DescribeLogBackupsResponse> DescribeLogBackups(DescribeLogBackupsRequest req)
        {
            return InternalRequestAsync<DescribeLogBackupsResponse>(req, "DescribeLogBackups");
        }

        /// <summary>
        /// This API is used to query the list of log backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public DescribeLogBackupsResponse DescribeLogBackupsSync(DescribeLogBackupsRequest req)
        {
            return InternalRequestAsync<DescribeLogBackupsResponse>(req, "DescribeLogBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintainTimeWindowResponse"/></returns>
        public Task<DescribeMaintainTimeWindowResponse> DescribeMaintainTimeWindow(DescribeMaintainTimeWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintainTimeWindowResponse>(req, "DescribeMaintainTimeWindow");
        }

        /// <summary>
        /// This API is used to query instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintainTimeWindowResponse"/></returns>
        public DescribeMaintainTimeWindowResponse DescribeMaintainTimeWindowSync(DescribeMaintainTimeWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintainTimeWindowResponse>(req, "DescribeMaintainTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a parameter template, including basic information and parameter information.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public Task<DescribeParameterTemplateAttributesResponse> DescribeParameterTemplateAttributes(DescribeParameterTemplateAttributesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplateAttributesResponse>(req, "DescribeParameterTemplateAttributes");
        }

        /// <summary>
        /// This API is used to query the details of a parameter template, including basic information and parameter information.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public DescribeParameterTemplateAttributesResponse DescribeParameterTemplateAttributesSync(DescribeParameterTemplateAttributesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplateAttributesResponse>(req, "DescribeParameterTemplateAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public Task<DescribeParameterTemplatesResponse> DescribeParameterTemplates(DescribeParameterTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplatesResponse>(req, "DescribeParameterTemplates");
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public DescribeParameterTemplatesResponse DescribeParameterTemplatesSync(DescribeParameterTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplatesResponse>(req, "DescribeParameterTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the parameter modification event.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public Task<DescribeParamsEventResponse> DescribeParamsEvent(DescribeParamsEventRequest req)
        {
            return InternalRequestAsync<DescribeParamsEventResponse>(req, "DescribeParamsEvent");
        }

        /// <summary>
        /// This API is used to query the parameter modification event.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public DescribeParamsEventResponse DescribeParamsEventSync(DescribeParamsEventRequest req)
        {
            return InternalRequestAsync<DescribeParamsEventResponse>(req, "DescribeParamsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This api is used to query sales specification configuration. This interface belongs to the early stage and has stopped feature iteration. It is recommended to use the new api [DescribeClasses](https://www.tencentcloud.com/document/api/409/89019?from_cn_redirect=1) as an alternative.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig");
        }

        /// <summary>
        /// This api is used to query sales specification configuration. This interface belongs to the early stage and has stopped feature iteration. It is recommended to use the new api [DescribeClasses](https://www.tencentcloud.com/document/api/409/89019?from_cn_redirect=1) as an alternative.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of RO groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public Task<DescribeReadOnlyGroupsResponse> DescribeReadOnlyGroups(DescribeReadOnlyGroupsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupsResponse>(req, "DescribeReadOnlyGroups");
        }

        /// <summary>
        /// This API is used to query the list of RO groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public DescribeReadOnlyGroupsResponse DescribeReadOnlyGroupsSync(DescribeReadOnlyGroupsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupsResponse>(req, "DescribeReadOnlyGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the purchasable regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is used to query the purchasable regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to count and analyze slow query statements during the specified period of time and return aggregated statistical analysis results which are classified by statement with abstract parameter values.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public Task<DescribeSlowQueryAnalysisResponse> DescribeSlowQueryAnalysis(DescribeSlowQueryAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryAnalysisResponse>(req, "DescribeSlowQueryAnalysis");
        }

        /// <summary>
        /// This API is used to count and analyze slow query statements during the specified period of time and return aggregated statistical analysis results which are classified by statement with abstract parameter values.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public DescribeSlowQueryAnalysisResponse DescribeSlowQueryAnalysisSync(DescribeSlowQueryAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryAnalysisResponse>(req, "DescribeSlowQueryAnalysis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the slow queries during the specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public Task<DescribeSlowQueryListResponse> DescribeSlowQueryList(DescribeSlowQueryListRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryListResponse>(req, "DescribeSlowQueryList");
        }

        /// <summary>
        /// This API is used to get the slow queries during the specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public DescribeSlowQueryListResponse DescribeSlowQueryListSync(DescribeSlowQueryListRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryListResponse>(req, "DescribeSlowQueryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task list and show the progress of async task execution.
        /// This API is used to show summarized steps, which may be adjusted during version iteration. It is not recommended for key logic usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// This API is used to query the task list and show the progress of async task execution.
        /// This API is used to show summarized steps, which may be adjusted during version iteration. It is not recommended for key logic usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the supported AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query the supported AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate an isolated instance by specifying the `DBInstanceId` parameter. The data of a terminated instance will be deleted and cannot be recovered. Be cautious with this API calling. Only the instance in isolation can be terminated.
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public Task<DestroyDBInstanceResponse> DestroyDBInstance(DestroyDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDBInstanceResponse>(req, "DestroyDBInstance");
        }

        /// <summary>
        /// This API is used to terminate an isolated instance by specifying the `DBInstanceId` parameter. The data of a terminated instance will be deleted and cannot be recovered. Be cautious with this API calling. Only the instance in isolation can be terminated.
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public DestroyDBInstanceResponse DestroyDBInstanceSync(DestroyDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDBInstanceResponse>(req, "DestroyDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove one or more instances from isolation.
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public Task<DisIsolateDBInstancesResponse> DisIsolateDBInstances(DisIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<DisIsolateDBInstancesResponse>(req, "DisIsolateDBInstances");
        }

        /// <summary>
        /// This API is used to remove one or more instances from isolation.
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public DisIsolateDBInstancesResponse DisIsolateDBInstancesSync(DisIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<DisIsolateDBInstancesResponse>(req, "DisIsolateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the purchase price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances");
        }

        /// <summary>
        /// This API is used to query the purchase price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the renewal price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public Task<InquiryPriceRenewDBInstanceResponse> InquiryPriceRenewDBInstance(InquiryPriceRenewDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewDBInstanceResponse>(req, "InquiryPriceRenewDBInstance");
        }

        /// <summary>
        /// This API is used to query the renewal price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public InquiryPriceRenewDBInstanceResponse InquiryPriceRenewDBInstanceSync(InquiryPriceRenewDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewDBInstanceResponse>(req, "InquiryPriceRenewDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the fees of upgrading a specified database instance. Only pay-as-you-go instance is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance");
        }

        /// <summary>
        /// This API is used to query the fees of upgrading a specified database instance. Only pay-as-you-go instance is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate an instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public Task<IsolateDBInstancesResponse> IsolateDBInstances(IsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<IsolateDBInstancesResponse>(req, "IsolateDBInstances");
        }

        /// <summary>
        /// This API is used to isolate an instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public IsolateDBInstancesResponse IsolateDBInstancesSync(IsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<IsolateDBInstancesResponse>(req, "IsolateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to lock a database account. After being locked, the current connection will disconnect and unable to establish a new connection.
        /// </summary>
        /// <param name="req"><see cref="LockAccountRequest"/></param>
        /// <returns><see cref="LockAccountResponse"/></returns>
        public Task<LockAccountResponse> LockAccount(LockAccountRequest req)
        {
            return InternalRequestAsync<LockAccountResponse>(req, "LockAccount");
        }

        /// <summary>
        /// This API is used to lock a database account. After being locked, the current connection will disconnect and unable to establish a new connection.
        /// </summary>
        /// <param name="req"><see cref="LockAccountRequest"/></param>
        /// <returns><see cref="LockAccountResponse"/></returns>
        public LockAccountResponse LockAccountSync(LockAccountRequest req)
        {
            return InternalRequestAsync<LockAccountResponse>(req, "LockAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the permission of an account on a database object and modify the account type.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// This API is used to modify the permission of an account on a database object and modify the account type.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges")
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
        /// Modify the audit feature of the database instance
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// Modify the audit feature of the database instance
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to modify the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the backup plan of an instance, such as modifying the backup start time. By default, a full backup starts at midnight every day and the generated backup files will be retained for seven days.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public Task<ModifyBackupPlanResponse> ModifyBackupPlan(ModifyBackupPlanRequest req)
        {
            return InternalRequestAsync<ModifyBackupPlanResponse>(req, "ModifyBackupPlan");
        }

        /// <summary>
        /// This API is used to modify the backup plan of an instance, such as modifying the backup start time. By default, a full backup starts at midnight every day and the generated backup files will be retained for seven days.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public ModifyBackupPlanResponse ModifyBackupPlanSync(ModifyBackupPlanRequest req)
        {
            return InternalRequestAsync<ModifyBackupPlanResponse>(req, "ModifyBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the expiration time of a specified data backup for an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public Task<ModifyBaseBackupExpireTimeResponse> ModifyBaseBackupExpireTime(ModifyBaseBackupExpireTimeRequest req)
        {
            return InternalRequestAsync<ModifyBaseBackupExpireTimeResponse>(req, "ModifyBaseBackupExpireTime");
        }

        /// <summary>
        /// This API is used to modify the expiration time of a specified data backup for an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public ModifyBaseBackupExpireTimeResponse ModifyBaseBackupExpireTimeSync(ModifyBaseBackupExpireTimeRequest req)
        {
            return InternalRequestAsync<ModifyBaseBackupExpireTimeResponse>(req, "ModifyBaseBackupExpireTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch the instance billing mode from pay-as-you-go to yearly/monthly subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public Task<ModifyDBInstanceChargeTypeResponse> ModifyDBInstanceChargeType(ModifyDBInstanceChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceChargeTypeResponse>(req, "ModifyDBInstanceChargeType");
        }

        /// <summary>
        /// This API is used to switch the instance billing mode from pay-as-you-go to yearly/monthly subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public ModifyDBInstanceChargeTypeResponse ModifyDBInstanceChargeTypeSync(ModifyDBInstanceChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceChargeTypeResponse>(req, "ModifyDBInstanceChargeType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (DeletionProtection) is used to enable or disable instance destruction protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeletionProtectionResponse"/></returns>
        public Task<ModifyDBInstanceDeletionProtectionResponse> ModifyDBInstanceDeletionProtection(ModifyDBInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceDeletionProtectionResponse>(req, "ModifyDBInstanceDeletionProtection");
        }

        /// <summary>
        /// This interface (DeletionProtection) is used to enable or disable instance destruction protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeletionProtectionResponse"/></returns>
        public ModifyDBInstanceDeletionProtectionResponse ModifyDBInstanceDeletionProtectionSync(ModifyDBInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceDeletionProtectionResponse>(req, "ModifyDBInstanceDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the AZs where the nodes of a source instance reside.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public Task<ModifyDBInstanceDeploymentResponse> ModifyDBInstanceDeployment(ModifyDBInstanceDeploymentRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceDeploymentResponse>(req, "ModifyDBInstanceDeployment");
        }

        /// <summary>
        /// This API is used to modify the AZs where the nodes of a source instance reside.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public ModifyDBInstanceDeploymentResponse ModifyDBInstanceDeploymentSync(ModifyDBInstanceDeploymentRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceDeploymentResponse>(req, "ModifyDBInstanceDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance HA configuration info. Among them, HA configuration info includes:.
        /// <li>This API is used to configure conditions for allowing a secondary node to switch over to a primary node.</li>.
        /// <li>This API is used to configure conditions for using synchronous replication or async replication in semi-sync instances.</li>.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceHAConfigResponse"/></returns>
        public Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfig(ModifyDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceHAConfigResponse>(req, "ModifyDBInstanceHAConfig");
        }

        /// <summary>
        /// This API is used to modify instance HA configuration info. Among them, HA configuration info includes:.
        /// <li>This API is used to configure conditions for allowing a secondary node to switch over to a primary node.</li>.
        /// <li>This API is used to configure conditions for using synchronous replication or async replication in semi-sync instances.</li>.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceHAConfigResponse"/></returns>
        public ModifyDBInstanceHAConfigResponse ModifyDBInstanceHAConfigSync(ModifyDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceHAConfigResponse>(req, "ModifyDBInstanceHAConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a TencentDB for PostgreSQL instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// This API is used to rename a TencentDB for PostgreSQL instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public Task<ModifyDBInstanceParametersResponse> ModifyDBInstanceParameters(ModifyDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceParametersResponse>(req, "ModifyDBInstanceParameters");
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public ModifyDBInstanceParametersResponse ModifyDBInstanceParametersSync(ModifyDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceParametersResponse>(req, "ModifyDBInstanceParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the RO group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public Task<ModifyDBInstanceReadOnlyGroupResponse> ModifyDBInstanceReadOnlyGroup(ModifyDBInstanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceReadOnlyGroupResponse>(req, "ModifyDBInstanceReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to modify the RO group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public ModifyDBInstanceReadOnlyGroupResponse ModifyDBInstanceReadOnlyGroupSync(ModifyDBInstanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceReadOnlyGroupResponse>(req, "ModifyDBInstanceReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the SSL configuration of an instance, including enabling, disabling, and modifying the connection address protected by an SSL certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSSLConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSSLConfigResponse"/></returns>
        public Task<ModifyDBInstanceSSLConfigResponse> ModifyDBInstanceSSLConfig(ModifyDBInstanceSSLConfigRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSSLConfigResponse>(req, "ModifyDBInstanceSSLConfig");
        }

        /// <summary>
        /// This API is used to modify the SSL configuration of an instance, including enabling, disabling, and modifying the connection address protected by an SSL certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSSLConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSSLConfigResponse"/></returns>
        public ModifyDBInstanceSSLConfigResponse ModifyDBInstanceSSLConfigSync(ModifyDBInstanceSSLConfigRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSSLConfigResponse>(req, "ModifyDBInstanceSSLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API is used to modify the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance specifications, including memory, Disk and Cpu.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec");
        }

        /// <summary>
        /// This API is used to modify instance specifications, including memory, Disk and Cpu.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecSync(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the project of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject");
        }

        /// <summary>
        /// This API is used to modify the project of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change database owner.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseOwnerRequest"/></param>
        /// <returns><see cref="ModifyDatabaseOwnerResponse"/></returns>
        public Task<ModifyDatabaseOwnerResponse> ModifyDatabaseOwner(ModifyDatabaseOwnerRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseOwnerResponse>(req, "ModifyDatabaseOwner");
        }

        /// <summary>
        /// This API is used to change database owner.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseOwnerRequest"/></param>
        /// <returns><see cref="ModifyDatabaseOwnerResponse"/></returns>
        public ModifyDatabaseOwnerResponse ModifyDatabaseOwnerSync(ModifyDatabaseOwnerRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseOwnerResponse>(req, "ModifyDatabaseOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintainTimeWindowResponse"/></returns>
        public Task<ModifyMaintainTimeWindowResponse> ModifyMaintainTimeWindow(ModifyMaintainTimeWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintainTimeWindowResponse>(req, "ModifyMaintainTimeWindow");
        }

        /// <summary>
        /// This API is used to modify the instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintainTimeWindowResponse"/></returns>
        public ModifyMaintainTimeWindowResponse ModifyMaintainTimeWindowSync(ModifyMaintainTimeWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintainTimeWindowResponse>(req, "ModifyMaintainTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configurations, such as parameter template name and description. It can also be used to manage the parameter list in the parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public Task<ModifyParameterTemplateResponse> ModifyParameterTemplate(ModifyParameterTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParameterTemplateResponse>(req, "ModifyParameterTemplate");
        }

        /// <summary>
        /// This API is used to modify the configurations, such as parameter template name and description. It can also be used to manage the parameter list in the parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public ModifyParameterTemplateResponse ModifyParameterTemplateSync(ModifyParameterTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParameterTemplateResponse>(req, "ModifyParameterTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the read-only instance weight.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyDBInstanceWeightRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyDBInstanceWeightResponse"/></returns>
        public Task<ModifyReadOnlyDBInstanceWeightResponse> ModifyReadOnlyDBInstanceWeight(ModifyReadOnlyDBInstanceWeightRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyDBInstanceWeightResponse>(req, "ModifyReadOnlyDBInstanceWeight");
        }

        /// <summary>
        /// This API is used to modify the read-only instance weight.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyDBInstanceWeightRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyDBInstanceWeightResponse"/></returns>
        public ModifyReadOnlyDBInstanceWeightResponse ModifyReadOnlyDBInstanceWeightSync(ModifyReadOnlyDBInstanceWeightRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyDBInstanceWeightResponse>(req, "ModifyReadOnlyDBInstanceWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify RO group configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public Task<ModifyReadOnlyGroupConfigResponse> ModifyReadOnlyGroupConfig(ModifyReadOnlyGroupConfigRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupConfigResponse>(req, "ModifyReadOnlyGroupConfig");
        }

        /// <summary>
        /// This API is used to modify RO group configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public ModifyReadOnlyGroupConfigResponse ModifyReadOnlyGroupConfigSync(ModifyReadOnlyGroupConfigRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupConfigResponse>(req, "ModifyReadOnlyGroupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform a primary-standby switch for an instance waiting for the switch after it is upgraded.
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public Task<ModifySwitchTimePeriodResponse> ModifySwitchTimePeriod(ModifySwitchTimePeriodRequest req)
        {
            return InternalRequestAsync<ModifySwitchTimePeriodResponse>(req, "ModifySwitchTimePeriod");
        }

        /// <summary>
        /// This API is used to perform a primary-standby switch for an instance waiting for the switch after it is upgraded.
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public ModifySwitchTimePeriodResponse ModifySwitchTimePeriodSync(ModifySwitchTimePeriodRequest req)
        {
            return InternalRequestAsync<ModifySwitchTimePeriodResponse>(req, "ModifySwitchTimePeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable CAM verification service for a database account.
        /// </summary>
        /// <param name="req"><see cref="OpenAccountCAMRequest"/></param>
        /// <returns><see cref="OpenAccountCAMResponse"/></returns>
        public Task<OpenAccountCAMResponse> OpenAccountCAM(OpenAccountCAMRequest req)
        {
            return InternalRequestAsync<OpenAccountCAMResponse>(req, "OpenAccountCAM");
        }

        /// <summary>
        /// This API is used to enable CAM verification service for a database account.
        /// </summary>
        /// <param name="req"><see cref="OpenAccountCAMRequest"/></param>
        /// <returns><see cref="OpenAccountCAMResponse"/></returns>
        public OpenAccountCAMResponse OpenAccountCAMSync(OpenAccountCAMRequest req)
        {
            return InternalRequestAsync<OpenAccountCAMResponse>(req, "OpenAccountCAM")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable the audit feature of the database instance
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// Enable the audit feature of the database instance
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public Task<OpenDBExtranetAccessResponse> OpenDBExtranetAccess(OpenDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenDBExtranetAccessResponse>(req, "OpenDBExtranetAccess");
        }

        /// <summary>
        /// This API is used to enable the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public OpenDBExtranetAccessResponse OpenDBExtranetAccessSync(OpenDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenDBExtranetAccessResponse>(req, "OpenDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rebalance the loads of read-only replicas in an RO group. Please note that connections to those read-only replicas will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public Task<RebalanceReadOnlyGroupResponse> RebalanceReadOnlyGroup(RebalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RebalanceReadOnlyGroupResponse>(req, "RebalanceReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to rebalance the loads of read-only replicas in an RO group. Please note that connections to those read-only replicas will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public RebalanceReadOnlyGroupResponse RebalanceReadOnlyGroupSync(RebalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RebalanceReadOnlyGroupResponse>(req, "RebalanceReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manually reset the password for an account with CAM Verification enabled.
        /// </summary>
        /// <param name="req"><see cref="RefreshAccountPasswordRequest"/></param>
        /// <returns><see cref="RefreshAccountPasswordResponse"/></returns>
        public Task<RefreshAccountPasswordResponse> RefreshAccountPassword(RefreshAccountPasswordRequest req)
        {
            return InternalRequestAsync<RefreshAccountPasswordResponse>(req, "RefreshAccountPassword");
        }

        /// <summary>
        /// This API is used to manually reset the password for an account with CAM Verification enabled.
        /// </summary>
        /// <param name="req"><see cref="RefreshAccountPasswordRequest"/></param>
        /// <returns><see cref="RefreshAccountPasswordResponse"/></returns>
        public RefreshAccountPasswordResponse RefreshAccountPasswordSync(RefreshAccountPasswordRequest req)
        {
            return InternalRequestAsync<RefreshAccountPasswordResponse>(req, "RefreshAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a read-only replica from an RO group.
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public Task<RemoveDBInstanceFromReadOnlyGroupResponse> RemoveDBInstanceFromReadOnlyGroup(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RemoveDBInstanceFromReadOnlyGroupResponse>(req, "RemoveDBInstanceFromReadOnlyGroup");
        }

        /// <summary>
        /// This API is used to remove a read-only replica from an RO group.
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public RemoveDBInstanceFromReadOnlyGroupResponse RemoveDBInstanceFromReadOnlyGroupSync(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RemoveDBInstanceFromReadOnlyGroupResponse>(req, "RemoveDBInstanceFromReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance");
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance")
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
        /// This API is used to restart an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance");
        }

        /// <summary>
        /// This API is used to restart an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover database-related objects such as databases and tables on the original instance based on the backup set or recovery target time.
        /// </summary>
        /// <param name="req"><see cref="RestoreDBInstanceObjectsRequest"/></param>
        /// <returns><see cref="RestoreDBInstanceObjectsResponse"/></returns>
        public Task<RestoreDBInstanceObjectsResponse> RestoreDBInstanceObjects(RestoreDBInstanceObjectsRequest req)
        {
            return InternalRequestAsync<RestoreDBInstanceObjectsResponse>(req, "RestoreDBInstanceObjects");
        }

        /// <summary>
        /// This API is used to recover database-related objects such as databases and tables on the original instance based on the backup set or recovery target time.
        /// </summary>
        /// <param name="req"><see cref="RestoreDBInstanceObjectsRequest"/></param>
        /// <returns><see cref="RestoreDBInstanceObjectsResponse"/></returns>
        public RestoreDBInstanceObjectsResponse RestoreDBInstanceObjectsSync(RestoreDBInstanceObjectsRequest req)
        {
            return InternalRequestAsync<RestoreDBInstanceObjectsResponse>(req, "RestoreDBInstanceObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public Task<SetAutoRenewFlagResponse> SetAutoRenewFlag(SetAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<SetAutoRenewFlagResponse>(req, "SetAutoRenewFlag");
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public SetAutoRenewFlagResponse SetAutoRenewFlagSync(SetAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<SetAutoRenewFlagResponse>(req, "SetAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch over primary and replica nodes.
        /// <li>This API is used to verify whether the business can correctly handle instance primary/backup switch scenarios by initiating switch proactively.</li>.
        /// <li>This API is used to force a primary-secondary switch when the backup node latency fails to satisfy the switch condition by using forced switching.</li>.
        /// <li>This API is used to perform this operation on the primary instance only.</li>.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public Task<SwitchDBInstancePrimaryResponse> SwitchDBInstancePrimary(SwitchDBInstancePrimaryRequest req)
        {
            return InternalRequestAsync<SwitchDBInstancePrimaryResponse>(req, "SwitchDBInstancePrimary");
        }

        /// <summary>
        /// This API is used to switch over primary and replica nodes.
        /// <li>This API is used to verify whether the business can correctly handle instance primary/backup switch scenarios by initiating switch proactively.</li>.
        /// <li>This API is used to force a primary-secondary switch when the backup node latency fails to satisfy the switch condition by using forced switching.</li>.
        /// <li>This API is used to perform this operation on the primary instance only.</li>.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public SwitchDBInstancePrimaryResponse SwitchDBInstancePrimarySync(SwitchDBInstancePrimaryRequest req)
        {
            return InternalRequestAsync<SwitchDBInstancePrimaryResponse>(req, "SwitchDBInstancePrimary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unlock a database account. The account can log in to the database after being unlocked.
        /// </summary>
        /// <param name="req"><see cref="UnlockAccountRequest"/></param>
        /// <returns><see cref="UnlockAccountResponse"/></returns>
        public Task<UnlockAccountResponse> UnlockAccount(UnlockAccountRequest req)
        {
            return InternalRequestAsync<UnlockAccountResponse>(req, "UnlockAccount");
        }

        /// <summary>
        /// This API is used to unlock a database account. The account can log in to the database after being unlocked.
        /// </summary>
        /// <param name="req"><see cref="UnlockAccountRequest"/></param>
        /// <returns><see cref="UnlockAccountResponse"/></returns>
        public UnlockAccountResponse UnlockAccountSync(UnlockAccountRequest req)
        {
            return InternalRequestAsync<UnlockAccountResponse>(req, "UnlockAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the kernel version of an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion");
        }

        /// <summary>
        /// This API is used to upgrade the kernel version of an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionSync(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the major kernel version of an instance, for example, from PostgreSQL 12 to PostgreSQL 15.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceMajorVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceMajorVersionResponse"/></returns>
        public Task<UpgradeDBInstanceMajorVersionResponse> UpgradeDBInstanceMajorVersion(UpgradeDBInstanceMajorVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceMajorVersionResponse>(req, "UpgradeDBInstanceMajorVersion");
        }

        /// <summary>
        /// This API is used to upgrade the major kernel version of an instance, for example, from PostgreSQL 12 to PostgreSQL 15.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceMajorVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceMajorVersionResponse"/></returns>
        public UpgradeDBInstanceMajorVersionResponse UpgradeDBInstanceMajorVersionSync(UpgradeDBInstanceMajorVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceMajorVersionResponse>(req, "UpgradeDBInstanceMajorVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
