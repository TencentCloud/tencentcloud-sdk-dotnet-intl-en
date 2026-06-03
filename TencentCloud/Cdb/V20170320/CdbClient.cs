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

namespace TencentCloud.Cdb.V20170320
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdb.V20170320.Models;

   public class CdbClient : AbstractClient{

       private const string endpoint = "cdb.intl.tencentcloudapi.com";
       private const string version = "2017-03-20";
       private const string sdkVersion = "SDK_NET_3.0.1326";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add a maintenance time window for cloud database instances to specify which time periods allow automatic execution of access operations.
        /// </summary>
        /// <param name="req"><see cref="AddTimeWindowRequest"/></param>
        /// <returns><see cref="AddTimeWindowResponse"/></returns>
        public Task<AddTimeWindowResponse> AddTimeWindow(AddTimeWindowRequest req)
        {
            return InternalRequestAsync<AddTimeWindowResponse>(req, "AddTimeWindow");
        }

        /// <summary>
        /// This API is used to add a maintenance time window for cloud database instances to specify which time periods allow automatic execution of access operations.
        /// </summary>
        /// <param name="req"><see cref="AddTimeWindowRequest"/></param>
        /// <returns><see cref="AddTimeWindowResponse"/></returns>
        public AddTimeWindowResponse AddTimeWindowSync(AddTimeWindowRequest req)
        {
            return InternalRequestAsync<AddTimeWindowResponse>(req, "AddTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust database proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyResponse"/></returns>
        public Task<AdjustCdbProxyResponse> AdjustCdbProxy(AdjustCdbProxyRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyResponse>(req, "AdjustCdbProxy");
        }

        /// <summary>
        /// This API is used to adjust database proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyResponse"/></returns>
        public AdjustCdbProxyResponse AdjustCdbProxySync(AdjustCdbProxyRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyResponse>(req, "AdjustCdbProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the database proxy address configuration.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyAddressRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyAddressResponse"/></returns>
        public Task<AdjustCdbProxyAddressResponse> AdjustCdbProxyAddress(AdjustCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyAddressResponse>(req, "AdjustCdbProxyAddress");
        }

        /// <summary>
        /// This API is used to adjust the database proxy address configuration.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyAddressRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyAddressResponse"/></returns>
        public AdjustCdbProxyAddressResponse AdjustCdbProxyAddressSync(AdjustCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyAddressResponse>(req, "AdjustCdbProxyAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform aggregation statistics on specified data columns in audit log result sets with different filter criteria.
        /// </summary>
        /// <param name="req"><see cref="AnalyzeAuditLogsRequest"/></param>
        /// <returns><see cref="AnalyzeAuditLogsResponse"/></returns>
        public Task<AnalyzeAuditLogsResponse> AnalyzeAuditLogs(AnalyzeAuditLogsRequest req)
        {
            return InternalRequestAsync<AnalyzeAuditLogsResponse>(req, "AnalyzeAuditLogs");
        }

        /// <summary>
        /// This API is used to perform aggregation statistics on specified data columns in audit log result sets with different filter criteria.
        /// </summary>
        /// <param name="req"><see cref="AnalyzeAuditLogsRequest"/></param>
        /// <returns><see cref="AnalyzeAuditLogsResponse"/></returns>
        public AnalyzeAuditLogsResponse AnalyzeAuditLogsSync(AnalyzeAuditLogsRequest req)
        {
            return InternalRequestAsync<AnalyzeAuditLogsResponse>(req, "AnalyzeAuditLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (AssociateSecurityGroups) is used to bind security groups to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// This API (AssociateSecurityGroups) is used to bind security groups to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rebalance the loads of instances in an RO group. Please note that the database connections to those instances will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="BalanceRoGroupLoadRequest"/></param>
        /// <returns><see cref="BalanceRoGroupLoadResponse"/></returns>
        public Task<BalanceRoGroupLoadResponse> BalanceRoGroupLoad(BalanceRoGroupLoadRequest req)
        {
            return InternalRequestAsync<BalanceRoGroupLoadResponse>(req, "BalanceRoGroupLoad");
        }

        /// <summary>
        /// This API is used to rebalance the loads of instances in an RO group. Please note that the database connections to those instances will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="BalanceRoGroupLoadRequest"/></param>
        /// <returns><see cref="BalanceRoGroupLoadResponse"/></returns>
        public BalanceRoGroupLoadResponse BalanceRoGroupLoadSync(BalanceRoGroupLoadRequest req)
        {
            return InternalRequestAsync<BalanceRoGroupLoadResponse>(req, "BalanceRoGroupLoad")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the audit service for an instance.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public Task<CloseAuditServiceResponse> CloseAuditService(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService");
        }

        /// <summary>
        /// This API is used to disable the audit service for an instance.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public CloseAuditServiceResponse CloseAuditServiceSync(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the database proxy.
        /// </summary>
        /// <param name="req"><see cref="CloseCDBProxyRequest"/></param>
        /// <returns><see cref="CloseCDBProxyResponse"/></returns>
        public Task<CloseCDBProxyResponse> CloseCDBProxy(CloseCDBProxyRequest req)
        {
            return InternalRequestAsync<CloseCDBProxyResponse>(req, "CloseCDBProxy");
        }

        /// <summary>
        /// This API is used to disable the database proxy.
        /// </summary>
        /// <param name="req"><see cref="CloseCDBProxyRequest"/></param>
        /// <returns><see cref="CloseCDBProxyResponse"/></returns>
        public CloseCDBProxyResponse CloseCDBProxySync(CloseCDBProxyRequest req)
        {
            return InternalRequestAsync<CloseCDBProxyResponse>(req, "CloseCDBProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable database proxy.
        /// </summary>
        /// <param name="req"><see cref="CloseCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CloseCdbProxyAddressResponse"/></returns>
        public Task<CloseCdbProxyAddressResponse> CloseCdbProxyAddress(CloseCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CloseCdbProxyAddressResponse>(req, "CloseCdbProxyAddress");
        }

        /// <summary>
        /// This API is used to disable database proxy.
        /// </summary>
        /// <param name="req"><see cref="CloseCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CloseCdbProxyAddressResponse"/></returns>
        public CloseCdbProxyAddressResponse CloseCdbProxyAddressSync(CloseCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CloseCdbProxyAddressResponse>(req, "CloseCdbProxyAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to close the SSL connectivity function.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public Task<CloseSSLResponse> CloseSSL(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL");
        }

        /// <summary>
        /// This API is used to close the SSL connectivity function.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public CloseSSLResponse CloseSSLSync(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CloseWanService) is used to disable public network access for TencentDB instance, which will make public IP addresses inaccessible.
        /// </summary>
        /// <param name="req"><see cref="CloseWanServiceRequest"/></param>
        /// <returns><see cref="CloseWanServiceResponse"/></returns>
        public Task<CloseWanServiceResponse> CloseWanService(CloseWanServiceRequest req)
        {
            return InternalRequestAsync<CloseWanServiceResponse>(req, "CloseWanService");
        }

        /// <summary>
        /// This API (CloseWanService) is used to disable public network access for TencentDB instance, which will make public IP addresses inaccessible.
        /// </summary>
        /// <param name="req"><see cref="CloseWanServiceRequest"/></param>
        /// <returns><see cref="CloseWanServiceResponse"/></returns>
        public CloseWanServiceResponse CloseWanServiceSync(CloseWanServiceRequest req)
        {
            return InternalRequestAsync<CloseWanServiceResponse>(req, "CloseWanService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create cloud database accounts. It requires specifying a new account name and domain name as well as the corresponding password. You can also set the account's remark information and maximum number of available connections.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public Task<CreateAccountsResponse> CreateAccounts(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts");
        }

        /// <summary>
        /// This API is used to create cloud database accounts. It requires specifying a new account name and domain name as well as the corresponding password. You can also set the account's remark information and maximum number of available connections.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public CreateAccountsResponse CreateAccountsSync(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an audit log file for a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public Task<CreateAuditLogFileResponse> CreateAuditLogFile(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile");
        }

        /// <summary>
        /// This API is used to create an audit log file for a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public CreateAuditLogFileResponse CreateAuditLogFileSync(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an audit policy for a TencentDB instance by associating an audit rule with the TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditPolicyRequest"/></param>
        /// <returns><see cref="CreateAuditPolicyResponse"/></returns>
        public Task<CreateAuditPolicyResponse> CreateAuditPolicy(CreateAuditPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuditPolicyResponse>(req, "CreateAuditPolicy");
        }

        /// <summary>
        /// This API is used to create an audit policy for a TencentDB instance by associating an audit rule with the TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditPolicyRequest"/></param>
        /// <returns><see cref="CreateAuditPolicyResponse"/></returns>
        public CreateAuditPolicyResponse CreateAuditPolicySync(CreateAuditPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuditPolicyResponse>(req, "CreateAuditPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an audit rule template.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public Task<CreateAuditRuleTemplateResponse> CreateAuditRuleTemplate(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate");
        }

        /// <summary>
        /// This API is used to create an audit rule template.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public CreateAuditRuleTemplateResponse CreateAuditRuleTemplateSync(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a database backup.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// This API is used to create a database backup.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a database proxy for the primary instance.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyRequest"/></param>
        /// <returns><see cref="CreateCdbProxyResponse"/></returns>
        public Task<CreateCdbProxyResponse> CreateCdbProxy(CreateCdbProxyRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyResponse>(req, "CreateCdbProxy");
        }

        /// <summary>
        /// This API is used to create a database proxy for the primary instance.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyRequest"/></param>
        /// <returns><see cref="CreateCdbProxyResponse"/></returns>
        public CreateCdbProxyResponse CreateCdbProxySync(CreateCdbProxyRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyResponse>(req, "CreateCdbProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a proxy address for database proxy.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CreateCdbProxyAddressResponse"/></returns>
        public Task<CreateCdbProxyAddressResponse> CreateCdbProxyAddress(CreateCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyAddressResponse>(req, "CreateCdbProxyAddress");
        }

        /// <summary>
        /// This API is used to add a proxy address for database proxy.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CreateCdbProxyAddressResponse"/></returns>
        public CreateCdbProxyAddressResponse CreateCdbProxyAddressSync(CreateCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyAddressResponse>(req, "CreateCdbProxyAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a clone instance from the source instance. You can specify a physical backup file or a rollback time point for the clone instance.
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public Task<CreateCloneInstanceResponse> CreateCloneInstance(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance");
        }

        /// <summary>
        /// This API is used to create a clone instance from the source instance. You can specify a physical backup file or a rollback time point for the clone instance.
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public CreateCloneInstanceResponse CreateCloneInstanceSync(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud database data import task.
        /// Note that the file for the data import task must be uploaded to Tencent Cloud in advance. The user must perform file import on the console.
        /// </summary>
        /// <param name="req"><see cref="CreateDBImportJobRequest"/></param>
        /// <returns><see cref="CreateDBImportJobResponse"/></returns>
        public Task<CreateDBImportJobResponse> CreateDBImportJob(CreateDBImportJobRequest req)
        {
            return InternalRequestAsync<CreateDBImportJobResponse>(req, "CreateDBImportJob");
        }

        /// <summary>
        /// This API is used to create a cloud database data import task.
        /// Note that the file for the data import task must be uploaded to Tencent Cloud in advance. The user must perform file import on the console.
        /// </summary>
        /// <param name="req"><see cref="CreateDBImportJobRequest"/></param>
        /// <returns><see cref="CreateDBImportJobResponse"/></returns>
        public CreateDBImportJobResponse CreateDBImportJobSync(CreateDBImportJobRequest req)
        {
            return InternalRequestAsync<CreateDBImportJobResponse>(req, "CreateDBImportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud database instance with an annual/monthly subscription, including primary instance, disaster recovery instance, and read-only instance. You can create a cloud database instance by importing instance specification, MySQL version number, purchase period, and quantity information.
        /// 
        /// This API is an asynchronous API. You can also use the query instance list API (https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) to query the instance details. When the Status of the instance is 1 and TaskStatus is 0, it means the instance has been delivered successfully.
        /// 
        /// 1. First, please use the API for the query (https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1) to obtain the purchasable specifications of cloud databases, then please use the API for the query (https://www.tencentcloud.com/document/api/236/18566?from_cn_redirect=1) to query database price.
        /// 2. You can create up to 100 instances at a time, with a maximum instance duration of 36 months.
        /// 3. Support creating MySQL 5.5, MySQL 5.6, MySQL 5.7, and MySQL 8.0 versions.
        /// 4. Support creating primary instance, read-only instance, disaster recovery instance.
        /// 5. When ParamTemplateId or AlarmPolicyList is specified in the input parameters, you need to upgrade the SDK to the latest version to support it.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance");
        }

        /// <summary>
        /// This API is used to create a cloud database instance with an annual/monthly subscription, including primary instance, disaster recovery instance, and read-only instance. You can create a cloud database instance by importing instance specification, MySQL version number, purchase period, and quantity information.
        /// 
        /// This API is an asynchronous API. You can also use the query instance list API (https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) to query the instance details. When the Status of the instance is 1 and TaskStatus is 0, it means the instance has been delivered successfully.
        /// 
        /// 1. First, please use the API for the query (https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1) to obtain the purchasable specifications of cloud databases, then please use the API for the query (https://www.tencentcloud.com/document/api/236/18566?from_cn_redirect=1) to query database price.
        /// 2. You can create up to 100 instances at a time, with a maximum instance duration of 36 months.
        /// 3. Support creating MySQL 5.5, MySQL 5.6, MySQL 5.7, and MySQL 8.0 versions.
        /// 4. Support creating primary instance, read-only instance, disaster recovery instance.
        /// 5. When ParamTemplateId or AlarmPolicyList is specified in the input parameters, you need to upgrade the SDK to the latest version to support it.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create pay-as-you-go instances. You can create a cloud database instance by inputting the instance specification, MySQL version number, quantity, etc. It supports the creation of primary instances, disaster recovery instances, and read-only instances.
        /// 
        /// This API is an async API. You can also use the API for the query (https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) to check the instance details. When the instance Status is 1 and TaskStatus is 0, it means the instance has been delivered successfully.
        /// 
        /// 1. First, please use the API for the query (https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1) to obtain the purchasable specifications of cloud databases, then please use the API for the query (https://www.tencentcloud.com/document/api/236/18566?from_cn_redirect=1) to query the instance selling price.
        /// 2. Supports a maximum of 100 instances created at a time, with a maximum duration of 36 months;
        /// 3. Support creating MySQL 5.5, MySQL 5.6, MySQL 5.7, and MySQL 8.0 versions.
        /// 4. Support creating primary instances, disaster recovery instances, and read-only instances.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public Task<CreateDBInstanceHourResponse> CreateDBInstanceHour(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour");
        }

        /// <summary>
        /// This API is used to create pay-as-you-go instances. You can create a cloud database instance by inputting the instance specification, MySQL version number, quantity, etc. It supports the creation of primary instances, disaster recovery instances, and read-only instances.
        /// 
        /// This API is an async API. You can also use the API for the query (https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) to check the instance details. When the instance Status is 1 and TaskStatus is 0, it means the instance has been delivered successfully.
        /// 
        /// 1. First, please use the API for the query (https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1) to obtain the purchasable specifications of cloud databases, then please use the API for the query (https://www.tencentcloud.com/document/api/236/18566?from_cn_redirect=1) to query the instance selling price.
        /// 2. Supports a maximum of 100 instances created at a time, with a maximum duration of 36 months;
        /// 3. Support creating MySQL 5.5, MySQL 5.6, MySQL 5.7, and MySQL 8.0 versions.
        /// 4. Support creating primary instances, disaster recovery instances, and read-only instances.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public CreateDBInstanceHourResponse CreateDBInstanceHourSync(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a database in a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase");
        }

        /// <summary>
        /// This API is used to create a database in a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public CreateDatabaseResponse CreateDatabaseSync(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate");
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a VIP exclusive to a TencentDB read-only instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRoInstanceIpRequest"/></param>
        /// <returns><see cref="CreateRoInstanceIpResponse"/></returns>
        public Task<CreateRoInstanceIpResponse> CreateRoInstanceIp(CreateRoInstanceIpRequest req)
        {
            return InternalRequestAsync<CreateRoInstanceIpResponse>(req, "CreateRoInstanceIp");
        }

        /// <summary>
        /// This API is used to create a VIP exclusive to a TencentDB read-only instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRoInstanceIpRequest"/></param>
        /// <returns><see cref="CreateRoInstanceIpResponse"/></returns>
        public CreateRoInstanceIpResponse CreateRoInstanceIpSync(CreateRoInstanceIpRequest req)
        {
            return InternalRequestAsync<CreateRoInstanceIpResponse>(req, "CreateRoInstanceIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable password rotation.
        /// </summary>
        /// <param name="req"><see cref="CreateRotationPasswordRequest"/></param>
        /// <returns><see cref="CreateRotationPasswordResponse"/></returns>
        public Task<CreateRotationPasswordResponse> CreateRotationPassword(CreateRotationPasswordRequest req)
        {
            return InternalRequestAsync<CreateRotationPasswordResponse>(req, "CreateRotationPassword");
        }

        /// <summary>
        /// This API is used to enable password rotation.
        /// </summary>
        /// <param name="req"><see cref="CreateRotationPasswordRequest"/></param>
        /// <returns><see cref="CreateRotationPasswordResponse"/></returns>
        public CreateRotationPasswordResponse CreateRotationPasswordSync(CreateRotationPasswordRequest req)
        {
            return InternalRequestAsync<CreateRotationPasswordResponse>(req, "CreateRotationPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete CDB accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public Task<DeleteAccountsResponse> DeleteAccounts(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts");
        }

        /// <summary>
        /// This API is used to delete CDB accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public DeleteAccountsResponse DeleteAccountsSync(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an audit log file of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public Task<DeleteAuditLogFileResponse> DeleteAuditLogFile(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile");
        }

        /// <summary>
        /// This API is used to delete an audit log file of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public DeleteAuditLogFileResponse DeleteAuditLogFileSync(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an audit policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuditPolicyResponse"/></returns>
        public Task<DeleteAuditPolicyResponse> DeleteAuditPolicy(DeleteAuditPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuditPolicyResponse>(req, "DeleteAuditPolicy");
        }

        /// <summary>
        /// This API is used to delete an audit policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuditPolicyResponse"/></returns>
        public DeleteAuditPolicyResponse DeleteAuditPolicySync(DeleteAuditPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuditPolicyResponse>(req, "DeleteAuditPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleTemplatesResponse"/></returns>
        public Task<DeleteAuditRuleTemplatesResponse> DeleteAuditRuleTemplates(DeleteAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleTemplatesResponse>(req, "DeleteAuditRuleTemplates");
        }

        /// <summary>
        /// This API is used to delete audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleTemplatesResponse"/></returns>
        public DeleteAuditRuleTemplatesResponse DeleteAuditRuleTemplatesSync(DeleteAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleTemplatesResponse>(req, "DeleteAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete database backups. It only supports deleting manually initiated backups.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public Task<DeleteBackupResponse> DeleteBackup(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup");
        }

        /// <summary>
        /// This API is used to delete database backups. It only supports deleting manually initiated backups.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public DeleteBackupResponse DeleteBackupSync(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a database in a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteDatabaseRequest"/></param>
        /// <returns><see cref="DeleteDatabaseResponse"/></returns>
        public Task<DeleteDatabaseResponse> DeleteDatabase(DeleteDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteDatabaseResponse>(req, "DeleteDatabase");
        }

        /// <summary>
        /// This API is used to delete a database in a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteDatabaseRequest"/></param>
        /// <returns><see cref="DeleteDatabaseResponse"/></returns>
        public DeleteDatabaseResponse DeleteDatabaseSync(DeleteDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteDatabaseResponse>(req, "DeleteDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete parameter template.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate");
        }

        /// <summary>
        /// This API is used to delete parameter template.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to close instance account password rotation.
        /// </summary>
        /// <param name="req"><see cref="DeleteRotationPasswordRequest"/></param>
        /// <returns><see cref="DeleteRotationPasswordResponse"/></returns>
        public Task<DeleteRotationPasswordResponse> DeleteRotationPassword(DeleteRotationPasswordRequest req)
        {
            return InternalRequestAsync<DeleteRotationPasswordResponse>(req, "DeleteRotationPassword");
        }

        /// <summary>
        /// This API is used to close instance account password rotation.
        /// </summary>
        /// <param name="req"><see cref="DeleteRotationPasswordRequest"/></param>
        /// <returns><see cref="DeleteRotationPasswordResponse"/></returns>
        public DeleteRotationPasswordResponse DeleteRotationPasswordSync(DeleteRotationPasswordRequest req)
        {
            return InternalRequestAsync<DeleteRotationPasswordResponse>(req, "DeleteRotationPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the maintenance time window of a cloud database instance. After deleting the instance maintenance window, the default maintenance period is 03:00-04:00 daily with a data validation delay threshold of 10 seconds. When switching to a new instance during the maintenance time window, the switch is performed by default at 03:00-04:00.
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeWindowRequest"/></param>
        /// <returns><see cref="DeleteTimeWindowResponse"/></returns>
        public Task<DeleteTimeWindowResponse> DeleteTimeWindow(DeleteTimeWindowRequest req)
        {
            return InternalRequestAsync<DeleteTimeWindowResponse>(req, "DeleteTimeWindow");
        }

        /// <summary>
        /// This API is used to delete the maintenance time window of a cloud database instance. After deleting the instance maintenance window, the default maintenance period is 03:00-04:00 daily with a data validation delay threshold of 10 seconds. When switching to a new instance during the maintenance time window, the switch is performed by default at 03:00-04:00.
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeWindowRequest"/></param>
        /// <returns><see cref="DeleteTimeWindowResponse"/></returns>
        public DeleteTimeWindowResponse DeleteTimeWindowSync(DeleteTimeWindowRequest req)
        {
            return InternalRequestAsync<DeleteTimeWindowResponse>(req, "DeleteTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the permission information supported by a cloud database account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// This API is used to query the permission information supported by a cloud database account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query ALL account information of the cloud database.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// This API is used to query ALL account information of the cloud database.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAsyncRequestInfo) is used to query the async task execution result of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// This API (DescribeAsyncRequestInfo) is used to query the async task execution result of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the service configurations for a TencentDB audit policy, including the audit log retention period.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditConfigRequest"/></param>
        /// <returns><see cref="DescribeAuditConfigResponse"/></returns>
        public Task<DescribeAuditConfigResponse> DescribeAuditConfig(DescribeAuditConfigRequest req)
        {
            return InternalRequestAsync<DescribeAuditConfigResponse>(req, "DescribeAuditConfig");
        }

        /// <summary>
        /// This API is used to query the service configurations for a TencentDB audit policy, including the audit log retention period.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditConfigRequest"/></param>
        /// <returns><see cref="DescribeAuditConfigResponse"/></returns>
        public DescribeAuditConfigResponse DescribeAuditConfigSync(DescribeAuditConfigRequest req)
        {
            return InternalRequestAsync<DescribeAuditConfigResponse>(req, "DescribeAuditConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of audit instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// This API is used to obtain the list of audit instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the audit log files of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public Task<DescribeAuditLogFilesResponse> DescribeAuditLogFiles(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles");
        }

        /// <summary>
        /// This API is used to query the audit log files of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public DescribeAuditLogFilesResponse DescribeAuditLogFilesSync(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database audit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public Task<DescribeAuditLogsResponse> DescribeAuditLogs(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs");
        }

        /// <summary>
        /// This API is used to query database audit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public DescribeAuditLogsResponse DescribeAuditLogsSync(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query audit policies of cloud database instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuditPoliciesResponse"/></returns>
        public Task<DescribeAuditPoliciesResponse> DescribeAuditPolicies(DescribeAuditPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuditPoliciesResponse>(req, "DescribeAuditPolicies");
        }

        /// <summary>
        /// This API is used to query audit policies of cloud database instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuditPoliciesResponse"/></returns>
        public DescribeAuditPoliciesResponse DescribeAuditPoliciesSync(DescribeAuditPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuditPoliciesResponse>(req, "DescribeAuditPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the change history of rule templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplateModifyHistoryRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplateModifyHistoryResponse"/></returns>
        public Task<DescribeAuditRuleTemplateModifyHistoryResponse> DescribeAuditRuleTemplateModifyHistory(DescribeAuditRuleTemplateModifyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplateModifyHistoryResponse>(req, "DescribeAuditRuleTemplateModifyHistory");
        }

        /// <summary>
        /// This API is used to query the change history of rule templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplateModifyHistoryRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplateModifyHistoryResponse"/></returns>
        public DescribeAuditRuleTemplateModifyHistoryResponse DescribeAuditRuleTemplateModifyHistorySync(DescribeAuditRuleTemplateModifyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplateModifyHistoryResponse>(req, "DescribeAuditRuleTemplateModifyHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public Task<DescribeAuditRuleTemplatesResponse> DescribeAuditRuleTemplates(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates");
        }

        /// <summary>
        /// This API is used to query the information of audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public DescribeAuditRuleTemplatesResponse DescribeAuditRuleTemplatesSync(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create audit rules no longer supported.
        /// 
        /// This API is used to query audit rules in current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRulesRequest"/></param>
        /// <returns><see cref="DescribeAuditRulesResponse"/></returns>
        public Task<DescribeAuditRulesResponse> DescribeAuditRules(DescribeAuditRulesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRulesResponse>(req, "DescribeAuditRules");
        }

        /// <summary>
        /// This API is used to create audit rules no longer supported.
        /// 
        /// This API is used to query audit rules in current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRulesRequest"/></param>
        /// <returns><see cref="DescribeAuditRulesResponse"/></returns>
        public DescribeAuditRulesResponse DescribeAuditRulesSync(DescribeAuditRulesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRulesResponse>(req, "DescribeAuditRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database backup configuration info.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public Task<DescribeBackupConfigResponse> DescribeBackupConfig(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig");
        }

        /// <summary>
        /// This API is used to query database backup configuration info.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public DescribeBackupConfigResponse DescribeBackupConfigSync(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the decryption key of a backup file.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDecryptionKeyRequest"/></param>
        /// <returns><see cref="DescribeBackupDecryptionKeyResponse"/></returns>
        public Task<DescribeBackupDecryptionKeyResponse> DescribeBackupDecryptionKey(DescribeBackupDecryptionKeyRequest req)
        {
            return InternalRequestAsync<DescribeBackupDecryptionKeyResponse>(req, "DescribeBackupDecryptionKey");
        }

        /// <summary>
        /// This API is used to query the decryption key of a backup file.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDecryptionKeyRequest"/></param>
        /// <returns><see cref="DescribeBackupDecryptionKeyResponse"/></returns>
        public DescribeBackupDecryptionKeyResponse DescribeBackupDecryptionKeySync(DescribeBackupDecryptionKeyRequest req)
        {
            return InternalRequestAsync<DescribeBackupDecryptionKeyResponse>(req, "DescribeBackupDecryptionKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the restrictions of downloading backups in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to query the restrictions of downloading backups in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the default encryption status of an instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeBackupEncryptionStatusResponse"/></returns>
        public Task<DescribeBackupEncryptionStatusResponse> DescribeBackupEncryptionStatus(DescribeBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeBackupEncryptionStatusResponse>(req, "DescribeBackupEncryptionStatus");
        }

        /// <summary>
        /// This API is used to query the default encryption status of an instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeBackupEncryptionStatusResponse"/></returns>
        public DescribeBackupEncryptionStatusResponse DescribeBackupEncryptionStatusSync(DescribeBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeBackupEncryptionStatusResponse>(req, "DescribeBackupEncryptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup overview of a user. It will return the user's current total number of backups, total capacity used by backups, capacity in the free tier, and paid capacity (all capacity values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public Task<DescribeBackupOverviewResponse> DescribeBackupOverview(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview");
        }

        /// <summary>
        /// This API is used to query the backup overview of a user. It will return the user's current total number of backups, total capacity used by backups, capacity in the free tier, and paid capacity (all capacity values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public DescribeBackupOverviewResponse DescribeBackupOverviewSync(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query backup statistics, return the occupied capacity of backups by instance as well as the count and capacity of data backup and log backup for each instance (in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public Task<DescribeBackupSummariesResponse> DescribeBackupSummaries(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries");
        }

        /// <summary>
        /// This API is used to query backup statistics, return the occupied capacity of backups by instance as well as the count and capacity of data backup and log backup for each instance (in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public DescribeBackupSummariesResponse DescribeBackupSummariesSync(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeBackups) is used to query the backups of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups");
        }

        /// <summary>
        /// This API (DescribeBackups) is used to query the backups of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public DescribeBackupsResponse DescribeBackupsSync(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBinlogBackupOverviewResponse"/></returns>
        public Task<DescribeBinlogBackupOverviewResponse> DescribeBinlogBackupOverview(DescribeBinlogBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBinlogBackupOverviewResponse>(req, "DescribeBinlogBackupOverview");
        }

        /// <summary>
        /// This API is used to query the log backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBinlogBackupOverviewResponse"/></returns>
        public DescribeBinlogBackupOverviewResponse DescribeBinlogBackupOverviewSync(DescribeBinlogBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBinlogBackupOverviewResponse>(req, "DescribeBinlogBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of binlog files of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public Task<DescribeBinlogsResponse> DescribeBinlogs(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs");
        }

        /// <summary>
        /// This API is used to query the list of binlog files of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public DescribeBinlogsResponse DescribeBinlogsSync(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CPU Elastic Scaling information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCPUExpandStrategyInfoRequest"/></param>
        /// <returns><see cref="DescribeCPUExpandStrategyInfoResponse"/></returns>
        public Task<DescribeCPUExpandStrategyInfoResponse> DescribeCPUExpandStrategyInfo(DescribeCPUExpandStrategyInfoRequest req)
        {
            return InternalRequestAsync<DescribeCPUExpandStrategyInfoResponse>(req, "DescribeCPUExpandStrategyInfo");
        }

        /// <summary>
        /// This API is used to query the CPU Elastic Scaling information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCPUExpandStrategyInfoRequest"/></param>
        /// <returns><see cref="DescribeCPUExpandStrategyInfoResponse"/></returns>
        public DescribeCPUExpandStrategyInfoResponse DescribeCPUExpandStrategyInfoSync(DescribeCPUExpandStrategyInfoRequest req)
        {
            return InternalRequestAsync<DescribeCPUExpandStrategyInfoResponse>(req, "DescribeCPUExpandStrategyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database proxy detailed information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbProxyInfoRequest"/></param>
        /// <returns><see cref="DescribeCdbProxyInfoResponse"/></returns>
        public Task<DescribeCdbProxyInfoResponse> DescribeCdbProxyInfo(DescribeCdbProxyInfoRequest req)
        {
            return InternalRequestAsync<DescribeCdbProxyInfoResponse>(req, "DescribeCdbProxyInfo");
        }

        /// <summary>
        /// This API is used to query database proxy detailed information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbProxyInfoRequest"/></param>
        /// <returns><see cref="DescribeCdbProxyInfoResponse"/></returns>
        public DescribeCdbProxyInfoResponse DescribeCdbProxyInfoSync(DescribeCdbProxyInfoRequest req)
        {
            return InternalRequestAsync<DescribeCdbProxyInfoResponse>(req, "DescribeCdbProxyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the purchasable specifications of TencentDB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeCdbZoneConfigResponse"/></returns>
        public Task<DescribeCdbZoneConfigResponse> DescribeCdbZoneConfig(DescribeCdbZoneConfigRequest req)
        {
            return InternalRequestAsync<DescribeCdbZoneConfigResponse>(req, "DescribeCdbZoneConfig");
        }

        /// <summary>
        /// This API is used to query the purchasable specifications of TencentDB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeCdbZoneConfigResponse"/></returns>
        public DescribeCdbZoneConfigResponse DescribeCdbZoneConfigSync(DescribeCdbZoneConfigRequest req)
        {
            return InternalRequestAsync<DescribeCdbZoneConfigResponse>(req, "DescribeCdbZoneConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the clone task list of a user instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneListRequest"/></param>
        /// <returns><see cref="DescribeCloneListResponse"/></returns>
        public Task<DescribeCloneListResponse> DescribeCloneList(DescribeCloneListRequest req)
        {
            return InternalRequestAsync<DescribeCloneListResponse>(req, "DescribeCloneList");
        }

        /// <summary>
        /// This API is used to query the clone task list of a user instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneListRequest"/></param>
        /// <returns><see cref="DescribeCloneListResponse"/></returns>
        public DescribeCloneListResponse DescribeCloneListSync(DescribeCloneListRequest req)
        {
            return InternalRequestAsync<DescribeCloneListResponse>(req, "DescribeCloneList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cloud disk edition instance info.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterInfoResponse"/></returns>
        public Task<DescribeClusterInfoResponse> DescribeClusterInfo(DescribeClusterInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterInfoResponse>(req, "DescribeClusterInfo");
        }

        /// <summary>
        /// This API is used to query cloud disk edition instance info.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterInfoResponse"/></returns>
        public DescribeClusterInfoResponse DescribeClusterInfoSync(DescribeClusterInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterInfoResponse>(req, "DescribeClusterInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cloud database version attributes, including whether database encryption and database audit are supported, and other features.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBFeaturesRequest"/></param>
        /// <returns><see cref="DescribeDBFeaturesResponse"/></returns>
        public Task<DescribeDBFeaturesResponse> DescribeDBFeatures(DescribeDBFeaturesRequest req)
        {
            return InternalRequestAsync<DescribeDBFeaturesResponse>(req, "DescribeDBFeatures");
        }

        /// <summary>
        /// This API is used to query cloud database version attributes, including whether database encryption and database audit are supported, and other features.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBFeaturesRequest"/></param>
        /// <returns><see cref="DescribeDBFeaturesResponse"/></returns>
        public DescribeDBFeaturesResponse DescribeDBFeaturesSync(DescribeDBFeaturesRequest req)
        {
            return InternalRequestAsync<DescribeDBFeaturesResponse>(req, "DescribeDBFeatures")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDBImportRecords) is used to query the records of import tasks in a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBImportRecordsResponse"/></returns>
        public Task<DescribeDBImportRecordsResponse> DescribeDBImportRecords(DescribeDBImportRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBImportRecordsResponse>(req, "DescribeDBImportRecords");
        }

        /// <summary>
        /// This API (DescribeDBImportRecords) is used to query the records of import tasks in a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBImportRecordsResponse"/></returns>
        public DescribeDBImportRecordsResponse DescribeDBImportRecordsSync(DescribeDBImportRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBImportRecordsResponse>(req, "DescribeDBImportRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDBInstanceCharset) is used to query the character set and its name of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceCharsetResponse"/></returns>
        public Task<DescribeDBInstanceCharsetResponse> DescribeDBInstanceCharset(DescribeDBInstanceCharsetRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceCharsetResponse>(req, "DescribeDBInstanceCharset");
        }

        /// <summary>
        /// This API (DescribeDBInstanceCharset) is used to query the character set and its name of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceCharsetResponse"/></returns>
        public DescribeDBInstanceCharsetResponse DescribeDBInstanceCharsetSync(DescribeDBInstanceCharsetRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceCharsetResponse>(req, "DescribeDBInstanceCharset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration message of a cloud database instance, including sync mode and deployment mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceConfigResponse"/></returns>
        public Task<DescribeDBInstanceConfigResponse> DescribeDBInstanceConfig(DescribeDBInstanceConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceConfigResponse>(req, "DescribeDBInstanceConfig");
        }

        /// <summary>
        /// This API is used to query the configuration message of a cloud database instance, including sync mode and deployment mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceConfigResponse"/></returns>
        public DescribeDBInstanceConfigResponse DescribeDBInstanceConfigSync(DescribeDBInstanceConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceConfigResponse>(req, "DescribeDBInstanceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDBInstanceGTID) is used to query whether GTID is activated for a TencentDB instance. Instances on or below version 5.5 are not supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceGTIDResponse"/></returns>
        public Task<DescribeDBInstanceGTIDResponse> DescribeDBInstanceGTID(DescribeDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceGTIDResponse>(req, "DescribeDBInstanceGTID");
        }

        /// <summary>
        /// This API (DescribeDBInstanceGTID) is used to query whether GTID is activated for a TencentDB instance. Instances on or below version 5.5 are not supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceGTIDResponse"/></returns>
        public DescribeDBInstanceGTIDResponse DescribeDBInstanceGTIDSync(DescribeDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceGTIDResponse>(req, "DescribeDBInstanceGTID")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the basic information of an instance, including instance ID, instance name, and whether encryption is enabled. Querying read-only instances is not supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInfoResponse"/></returns>
        public Task<DescribeDBInstanceInfoResponse> DescribeDBInstanceInfo(DescribeDBInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInfoResponse>(req, "DescribeDBInstanceInfo");
        }

        /// <summary>
        /// This API is used to query the basic information of an instance, including instance ID, instance name, and whether encryption is enabled. Querying read-only instances is not supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInfoResponse"/></returns>
        public DescribeDBInstanceInfoResponse DescribeDBInstanceInfoSync(DescribeDBInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInfoResponse>(req, "DescribeDBInstanceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration of slow log and error log delivery to CLS for an instance. It filters out the present instance log delivery configuration to CLS by AppId, Region, and instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceLogToCLSResponse"/></returns>
        public Task<DescribeDBInstanceLogToCLSResponse> DescribeDBInstanceLogToCLS(DescribeDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceLogToCLSResponse>(req, "DescribeDBInstanceLogToCLS");
        }

        /// <summary>
        /// This API is used to query the configuration of slow log and error log delivery to CLS for an instance. It filters out the present instance log delivery configuration to CLS by AppId, Region, and instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceLogToCLSResponse"/></returns>
        public DescribeDBInstanceLogToCLSResponse DescribeDBInstanceLogToCLSSync(DescribeDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceLogToCLSResponse>(req, "DescribeDBInstanceLogToCLS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the expected time required to restart a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceRebootTimeResponse"/></returns>
        public Task<DescribeDBInstanceRebootTimeResponse> DescribeDBInstanceRebootTime(DescribeDBInstanceRebootTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceRebootTimeResponse>(req, "DescribeDBInstanceRebootTime");
        }

        /// <summary>
        /// This API is used to query the expected time required to restart a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceRebootTimeResponse"/></returns>
        public DescribeDBInstanceRebootTimeResponse DescribeDBInstanceRebootTimeSync(DescribeDBInstanceRebootTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceRebootTimeResponse>(req, "DescribeDBInstanceRebootTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TencentDB for MySQL instances. It supports filtering instances by conditions such as project ID, instance ID, access address, and instance status. It also supports querying the list of information about primary instances, disaster recovery instances, and read-only instances.
        /// This API is used to return the availability zone (AZ) status during purchase, which does not change along with the proactive HA switch. If you want to know the AZ status in real time, query through the [DescribeDBInstanceConfig](https://www.tencentcloud.com/document/product/236/17491?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// This API is used to query the list of TencentDB for MySQL instances. It supports filtering instances by conditions such as project ID, instance ID, access address, and instance status. It also supports querying the list of information about primary instances, disaster recovery instances, and read-only instances.
        /// This API is used to return the availability zone (AZ) status during purchase, which does not change along with the proactive HA switch. If you want to know the AZ status in real time, query through the [DescribeDBInstanceConfig](https://www.tencentcloud.com/document/product/236/17491?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of purchasing or renewing a cloud database instance. It supports querying the price of pay-as-you-go or yearly/monthly subscription. You can input instance type, purchase period, purchase quantity, memory size, disk capacity and availability zone information to query instance price. You can input instance name to query instance renewal price.
        /// 
        /// Note: To request a price for a certain region, please use the access point of the corresponding region. For access point information, please refer to the <a href="https://www.tencentcloud.com/document/api/236/15832?from_cn_redirect=1">service address</a> document. For example, to request a price for the Guangzhou region, send the request to: cdb.ap-guangzhou.tencentcloudapi.com. Likewise, for the Shanghai region, send the request to: cdb.ap-shanghai.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDBPriceResponse"/></returns>
        public Task<DescribeDBPriceResponse> DescribeDBPrice(DescribeDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDBPriceResponse>(req, "DescribeDBPrice");
        }

        /// <summary>
        /// This API is used to query the price of purchasing or renewing a cloud database instance. It supports querying the price of pay-as-you-go or yearly/monthly subscription. You can input instance type, purchase period, purchase quantity, memory size, disk capacity and availability zone information to query instance price. You can input instance name to query instance renewal price.
        /// 
        /// Note: To request a price for a certain region, please use the access point of the corresponding region. For access point information, please refer to the <a href="https://www.tencentcloud.com/document/api/236/15832?from_cn_redirect=1">service address</a> document. For example, to request a price for the Guangzhou region, send the request to: cdb.ap-guangzhou.tencentcloudapi.com. Likewise, for the Shanghai region, send the request to: cdb.ap-shanghai.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDBPriceResponse"/></returns>
        public DescribeDBPriceResponse DescribeDBPriceSync(DescribeDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDBPriceResponse>(req, "DescribeDBPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDBSecurityGroups) is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// This API (DescribeDBSecurityGroups) is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDBSwitchRecords) is used to query the instance switch records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBSwitchRecordsResponse"/></returns>
        public Task<DescribeDBSwitchRecordsResponse> DescribeDBSwitchRecords(DescribeDBSwitchRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBSwitchRecordsResponse>(req, "DescribeDBSwitchRecords");
        }

        /// <summary>
        /// This API (DescribeDBSwitchRecords) is used to query the instance switch records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBSwitchRecordsResponse"/></returns>
        public DescribeDBSwitchRecordsResponse DescribeDBSwitchRecordsSync(DescribeDBSwitchRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBSwitchRecordsResponse>(req, "DescribeDBSwitchRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the data backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeDataBackupOverviewResponse"/></returns>
        public Task<DescribeDataBackupOverviewResponse> DescribeDataBackupOverview(DescribeDataBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDataBackupOverviewResponse>(req, "DescribeDataBackupOverview");
        }

        /// <summary>
        /// This API is used to query the data backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeDataBackupOverviewResponse"/></returns>
        public DescribeDataBackupOverviewResponse DescribeDataBackupOverviewSync(DescribeDataBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDataBackupOverviewResponse>(req, "DescribeDataBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of databases in a TencentDB instance which must be a source or disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// This API is used to query the information of databases in a TencentDB instance which must be a source or disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDefaultParams) is used to query the list of default configurable parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns><see cref="DescribeDefaultParamsResponse"/></returns>
        public Task<DescribeDefaultParamsResponse> DescribeDefaultParams(DescribeDefaultParamsRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParamsResponse>(req, "DescribeDefaultParams");
        }

        /// <summary>
        /// This API (DescribeDefaultParams) is used to query the list of default configurable parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns><see cref="DescribeDefaultParamsResponse"/></returns>
        public DescribeDefaultParamsResponse DescribeDefaultParamsSync(DescribeDefaultParamsRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParamsResponse>(req, "DescribeDefaultParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDeviceMonitorInfo) is used to query the monitoring information of a TencentDB physical machine on the day. Currently, it only supports instances with 488 GB memory and 6 TB disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorInfoResponse"/></returns>
        public Task<DescribeDeviceMonitorInfoResponse> DescribeDeviceMonitorInfo(DescribeDeviceMonitorInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceMonitorInfoResponse>(req, "DescribeDeviceMonitorInfo");
        }

        /// <summary>
        /// This API (DescribeDeviceMonitorInfo) is used to query the monitoring information of a TencentDB physical machine on the day. Currently, it only supports instances with 488 GB memory and 6 TB disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorInfoResponse"/></returns>
        public DescribeDeviceMonitorInfoResponse DescribeDeviceMonitorInfoSync(DescribeDeviceMonitorInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceMonitorInfoResponse>(req, "DescribeDeviceMonitorInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the error logs of an instance over the past month by search criteria.
        /// Note: the HTTP response packet will be very large if it contain a single large error log, which causes the API call to time out. If this happens, we recommend you lower the value of the input parameter `Limit` to reduce the packet size so that the API can respond timely.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogDataRequest"/></param>
        /// <returns><see cref="DescribeErrorLogDataResponse"/></returns>
        public Task<DescribeErrorLogDataResponse> DescribeErrorLogData(DescribeErrorLogDataRequest req)
        {
            return InternalRequestAsync<DescribeErrorLogDataResponse>(req, "DescribeErrorLogData");
        }

        /// <summary>
        /// This API is used to query the error logs of an instance over the past month by search criteria.
        /// Note: the HTTP response packet will be very large if it contain a single large error log, which causes the API call to time out. If this happens, we recommend you lower the value of the input parameter `Limit` to reduce the packet size so that the API can respond timely.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogDataRequest"/></param>
        /// <returns><see cref="DescribeErrorLogDataResponse"/></returns>
        public DescribeErrorLogDataResponse DescribeErrorLogDataSync(DescribeErrorLogDataRequest req)
        {
            return InternalRequestAsync<DescribeErrorLogDataResponse>(req, "DescribeErrorLogData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query event information of instance occurrence.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeInstanceAlarmEventsResponse"/></returns>
        public Task<DescribeInstanceAlarmEventsResponse> DescribeInstanceAlarmEvents(DescribeInstanceAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAlarmEventsResponse>(req, "DescribeInstanceAlarmEvents");
        }

        /// <summary>
        /// This API is used to query event information of instance occurrence.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeInstanceAlarmEventsResponse"/></returns>
        public DescribeInstanceAlarmEventsResponse DescribeInstanceAlarmEventsSync(DescribeInstanceAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAlarmEventsResponse>(req, "DescribeInstanceAlarmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeInstanceParamRecords) is used to query the parameter modification records of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords");
        }

        /// <summary>
        /// This API (DescribeInstanceParamRecords) is used to query the parameter modification records of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeInstanceParams) is used to query the list of parameters for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// This API (DescribeInstanceParams) is used to query the list of parameters for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the password complexity parameter list of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="DescribeInstancePasswordComplexityResponse"/></returns>
        public Task<DescribeInstancePasswordComplexityResponse> DescribeInstancePasswordComplexity(DescribeInstancePasswordComplexityRequest req)
        {
            return InternalRequestAsync<DescribeInstancePasswordComplexityResponse>(req, "DescribeInstancePasswordComplexity");
        }

        /// <summary>
        /// This API is used to query the password complexity parameter list of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="DescribeInstancePasswordComplexityResponse"/></returns>
        public DescribeInstancePasswordComplexityResponse DescribeInstancePasswordComplexitySync(DescribeInstancePasswordComplexityRequest req)
        {
            return InternalRequestAsync<DescribeInstancePasswordComplexityResponse>(req, "DescribeInstancePasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance version upgrade validation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUpgradeCheckJobRequest"/></param>
        /// <returns><see cref="DescribeInstanceUpgradeCheckJobResponse"/></returns>
        public Task<DescribeInstanceUpgradeCheckJobResponse> DescribeInstanceUpgradeCheckJob(DescribeInstanceUpgradeCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUpgradeCheckJobResponse>(req, "DescribeInstanceUpgradeCheckJob");
        }

        /// <summary>
        /// This API is used to query the instance version upgrade validation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUpgradeCheckJobRequest"/></param>
        /// <returns><see cref="DescribeInstanceUpgradeCheckJobResponse"/></returns>
        public DescribeInstanceUpgradeCheckJobResponse DescribeInstanceUpgradeCheckJobSync(DescribeInstanceUpgradeCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUpgradeCheckJobResponse>(req, "DescribeInstanceUpgradeCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the upgrade type of a database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUpgradeTypeRequest"/></param>
        /// <returns><see cref="DescribeInstanceUpgradeTypeResponse"/></returns>
        public Task<DescribeInstanceUpgradeTypeResponse> DescribeInstanceUpgradeType(DescribeInstanceUpgradeTypeRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUpgradeTypeResponse>(req, "DescribeInstanceUpgradeType");
        }

        /// <summary>
        /// This API is used to query the upgrade type of a database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUpgradeTypeRequest"/></param>
        /// <returns><see cref="DescribeInstanceUpgradeTypeResponse"/></returns>
        public DescribeInstanceUpgradeTypeResponse DescribeInstanceUpgradeTypeSync(DescribeInstanceUpgradeTypeRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUpgradeTypeResponse>(req, "DescribeInstanceUpgradeType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the retention policy of local binlog of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeLocalBinlogConfigResponse"/></returns>
        public Task<DescribeLocalBinlogConfigResponse> DescribeLocalBinlogConfig(DescribeLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLocalBinlogConfigResponse>(req, "DescribeLocalBinlogConfig");
        }

        /// <summary>
        /// This API is used to query the retention policy of local binlog of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeLocalBinlogConfigResponse"/></returns>
        public DescribeLocalBinlogConfigResponse DescribeLocalBinlogConfigSync(DescribeLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLocalBinlogConfigResponse>(req, "DescribeLocalBinlogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query parameter template details.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo");
        }

        /// <summary>
        /// This API is used to query parameter template details.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the parameter template list.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates");
        }

        /// <summary>
        /// This API is used to query the parameter template list.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeProjectSecurityGroups) is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// This API (DescribeProjectSecurityGroups) is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyCustomConfRequest"/></param>
        /// <returns><see cref="DescribeProxyCustomConfResponse"/></returns>
        public Task<DescribeProxyCustomConfResponse> DescribeProxyCustomConf(DescribeProxyCustomConfRequest req)
        {
            return InternalRequestAsync<DescribeProxyCustomConfResponse>(req, "DescribeProxyCustomConf");
        }

        /// <summary>
        /// This API is used to query the proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyCustomConfRequest"/></param>
        /// <returns><see cref="DescribeProxyCustomConfResponse"/></returns>
        public DescribeProxyCustomConfResponse DescribeProxyCustomConfSync(DescribeProxyCustomConfRequest req)
        {
            return InternalRequestAsync<DescribeProxyCustomConfResponse>(req, "DescribeProxyCustomConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance support proxy version and parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySupportParamRequest"/></param>
        /// <returns><see cref="DescribeProxySupportParamResponse"/></returns>
        public Task<DescribeProxySupportParamResponse> DescribeProxySupportParam(DescribeProxySupportParamRequest req)
        {
            return InternalRequestAsync<DescribeProxySupportParamResponse>(req, "DescribeProxySupportParam");
        }

        /// <summary>
        /// This API is used to query instance support proxy version and parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySupportParamRequest"/></param>
        /// <returns><see cref="DescribeProxySupportParamResponse"/></returns>
        public DescribeProxySupportParamResponse DescribeProxySupportParamSync(DescribeProxySupportParamRequest req)
        {
            return InternalRequestAsync<DescribeProxySupportParamResponse>(req, "DescribeProxySupportParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeRemoteBackupConfigResponse"/></returns>
        public Task<DescribeRemoteBackupConfigResponse> DescribeRemoteBackupConfig(DescribeRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeRemoteBackupConfigResponse>(req, "DescribeRemoteBackupConfig");
        }

        /// <summary>
        /// This API is used to query the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeRemoteBackupConfigResponse"/></returns>
        public DescribeRemoteBackupConfigResponse DescribeRemoteBackupConfigSync(DescribeRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeRemoteBackupConfigResponse>(req, "DescribeRemoteBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all RO groups of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoGroupsRequest"/></param>
        /// <returns><see cref="DescribeRoGroupsResponse"/></returns>
        public Task<DescribeRoGroupsResponse> DescribeRoGroups(DescribeRoGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRoGroupsResponse>(req, "DescribeRoGroups");
        }

        /// <summary>
        /// This API is used to query all RO groups of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoGroupsRequest"/></param>
        /// <returns><see cref="DescribeRoGroupsResponse"/></returns>
        public DescribeRoGroupsResponse DescribeRoGroupsSync(DescribeRoGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRoGroupsResponse>(req, "DescribeRoGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the minimum specification of a read-only instance that can be purchased or upgraded to.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoMinScaleRequest"/></param>
        /// <returns><see cref="DescribeRoMinScaleResponse"/></returns>
        public Task<DescribeRoMinScaleResponse> DescribeRoMinScale(DescribeRoMinScaleRequest req)
        {
            return InternalRequestAsync<DescribeRoMinScaleResponse>(req, "DescribeRoMinScale");
        }

        /// <summary>
        /// This API is used to query the minimum specification of a read-only instance that can be purchased or upgraded to.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoMinScaleRequest"/></param>
        /// <returns><see cref="DescribeRoMinScaleResponse"/></returns>
        public DescribeRoMinScaleResponse DescribeRoMinScaleSync(DescribeRoMinScaleRequest req)
        {
            return InternalRequestAsync<DescribeRoMinScaleResponse>(req, "DescribeRoMinScale")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRollbackRangeTime) is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackRangeTimeResponse"/></returns>
        public Task<DescribeRollbackRangeTimeResponse> DescribeRollbackRangeTime(DescribeRollbackRangeTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackRangeTimeResponse>(req, "DescribeRollbackRangeTime");
        }

        /// <summary>
        /// This API (DescribeRollbackRangeTime) is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackRangeTimeResponse"/></returns>
        public DescribeRollbackRangeTimeResponse DescribeRollbackRangeTimeSync(DescribeRollbackRangeTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackRangeTimeResponse>(req, "DescribeRollbackRangeTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rollback task detail of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRollbackTaskDetailResponse"/></returns>
        public Task<DescribeRollbackTaskDetailResponse> DescribeRollbackTaskDetail(DescribeRollbackTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTaskDetailResponse>(req, "DescribeRollbackTaskDetail");
        }

        /// <summary>
        /// This API is used to query the rollback task detail of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRollbackTaskDetailResponse"/></returns>
        public DescribeRollbackTaskDetailResponse DescribeRollbackTaskDetailSync(DescribeRollbackTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTaskDetailResponse>(req, "DescribeRollbackTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query SSL activation status. If SSL has been enabled, it will synchronously return the certificate download URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public Task<DescribeSSLStatusResponse> DescribeSSLStatus(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus");
        }

        /// <summary>
        /// This API is used to query SSL activation status. If SSL has been enabled, it will synchronously return the certificate download URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public DescribeSSLStatusResponse DescribeSSLStatusSync(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for instance slow logs under usage conditions. Only allow viewing slow logs within one month.
        /// During use, pay attention: a single slow log may be too large, causing the entire http request return content to be too large, furthermore leading to API timeout. Once timed out, narrow down the Limit parameter value when querying, thereby reducing the size and enabling the API to return content promptly.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogDataRequest"/></param>
        /// <returns><see cref="DescribeSlowLogDataResponse"/></returns>
        public Task<DescribeSlowLogDataResponse> DescribeSlowLogData(DescribeSlowLogDataRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogDataResponse>(req, "DescribeSlowLogData");
        }

        /// <summary>
        /// This API is used to search for instance slow logs under usage conditions. Only allow viewing slow logs within one month.
        /// During use, pay attention: a single slow log may be too large, causing the entire http request return content to be too large, furthermore leading to API timeout. Once timed out, narrow down the Limit parameter value when querying, thereby reducing the size and enabling the API to return content promptly.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogDataRequest"/></param>
        /// <returns><see cref="DescribeSlowLogDataResponse"/></returns>
        public DescribeSlowLogDataResponse DescribeSlowLogDataSync(DescribeSlowLogDataRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogDataResponse>(req, "DescribeSlowLogData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the slow query log of a cloud database instance.
        /// Description: If the data volume is too large in a single query, it may lead to response timeout. We recommend shortening the query time range per request, such as one hour, to avoid timeout.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs");
        }

        /// <summary>
        /// This API is used to obtain the slow query log of a cloud database instance.
        /// Description: If the data volume is too large in a single query, it may lead to response timeout. We recommend shortening the query time range per request, such as one hour, to avoid timeout.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeSupportedPrivileges) is used to query the information of TencentDB account permissions, including global permissions, database permissions, table permissions, and column permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeSupportedPrivilegesResponse"/></returns>
        public Task<DescribeSupportedPrivilegesResponse> DescribeSupportedPrivileges(DescribeSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeSupportedPrivilegesResponse>(req, "DescribeSupportedPrivileges");
        }

        /// <summary>
        /// This API (DescribeSupportedPrivileges) is used to query the information of TencentDB account permissions, including global permissions, database permissions, table permissions, and column permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeSupportedPrivilegesResponse"/></returns>
        public DescribeSupportedPrivilegesResponse DescribeSupportedPrivilegesSync(DescribeSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeSupportedPrivilegesResponse>(req, "DescribeSupportedPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query table column information of a designated database in a cloud database instance. It only supports primary instance and disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableColumnsRequest"/></param>
        /// <returns><see cref="DescribeTableColumnsResponse"/></returns>
        public Task<DescribeTableColumnsResponse> DescribeTableColumns(DescribeTableColumnsRequest req)
        {
            return InternalRequestAsync<DescribeTableColumnsResponse>(req, "DescribeTableColumns");
        }

        /// <summary>
        /// This API is used to query table column information of a designated database in a cloud database instance. It only supports primary instance and disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableColumnsRequest"/></param>
        /// <returns><see cref="DescribeTableColumnsResponse"/></returns>
        public DescribeTableColumnsResponse DescribeTableColumnsSync(DescribeTableColumnsRequest req)
        {
            return InternalRequestAsync<DescribeTableColumnsResponse>(req, "DescribeTableColumns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of database tables in a TencentDB instance. It only supports source or disaster recovery instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// This API is used to query the information of database tables in a TencentDB instance. It only supports source or disaster recovery instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access tag information of the instance for cloud databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeTagsOfInstanceIdsResponse"/></returns>
        public Task<DescribeTagsOfInstanceIdsResponse> DescribeTagsOfInstanceIds(DescribeTagsOfInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeTagsOfInstanceIdsResponse>(req, "DescribeTagsOfInstanceIds");
        }

        /// <summary>
        /// This API is used to access tag information of the instance for cloud databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeTagsOfInstanceIdsResponse"/></returns>
        public DescribeTagsOfInstanceIdsResponse DescribeTagsOfInstanceIdsSync(DescribeTagsOfInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeTagsOfInstanceIdsResponse>(req, "DescribeTagsOfInstanceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeTasks) is used to query the list of tasks for a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// This API (DescribeTasks) is used to query the list of tasks for a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeTimeWindow) is used to query the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeTimeWindowResponse"/></returns>
        public Task<DescribeTimeWindowResponse> DescribeTimeWindow(DescribeTimeWindowRequest req)
        {
            return InternalRequestAsync<DescribeTimeWindowResponse>(req, "DescribeTimeWindow");
        }

        /// <summary>
        /// This API (DescribeTimeWindow) is used to query the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeTimeWindowResponse"/></returns>
        public DescribeTimeWindowResponse DescribeTimeWindowSync(DescribeTimeWindowRequest req)
        {
            return InternalRequestAsync<DescribeTimeWindowResponse>(req, "DescribeTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of SQL files imported by users. The common request parameter `Region` must be `ap-shanghai`.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns><see cref="DescribeUploadedFilesResponse"/></returns>
        public Task<DescribeUploadedFilesResponse> DescribeUploadedFiles(DescribeUploadedFilesRequest req)
        {
            return InternalRequestAsync<DescribeUploadedFilesResponse>(req, "DescribeUploadedFiles");
        }

        /// <summary>
        /// This API is used to query the list of SQL files imported by users. The common request parameter `Region` must be `ap-shanghai`.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns><see cref="DescribeUploadedFilesResponse"/></returns>
        public DescribeUploadedFilesResponse DescribeUploadedFilesSync(DescribeUploadedFilesRequest req)
        {
            return InternalRequestAsync<DescribeUploadedFilesResponse>(req, "DescribeUploadedFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DisassociateSecurityGroups) is used to unbind security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// This API (DisassociateSecurityGroups) is used to unbind security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a cloud database instance. After an instance is isolated, you cannot access the database via IP and port. The isolated instance can be started in the recycle bin. If the instance is isolated due to arrears, please recharge as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// This API is used to isolate a cloud database instance. After an instance is isolated, you cannot access the database via IP and port. The isolated instance can be started in the recycle bin. If the instance is isolated due to arrears, please recharge as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyAccountDescription) is used to modify the remarks of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription");
        }

        /// <summary>
        /// This API (ModifyAccountDescription) is used to modify the remarks of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the maximum number of available connections for a cloud database account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountMaxUserConnectionsRequest"/></param>
        /// <returns><see cref="ModifyAccountMaxUserConnectionsResponse"/></returns>
        public Task<ModifyAccountMaxUserConnectionsResponse> ModifyAccountMaxUserConnections(ModifyAccountMaxUserConnectionsRequest req)
        {
            return InternalRequestAsync<ModifyAccountMaxUserConnectionsResponse>(req, "ModifyAccountMaxUserConnections");
        }

        /// <summary>
        /// This API is used to modify the maximum number of available connections for a cloud database account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountMaxUserConnectionsRequest"/></param>
        /// <returns><see cref="ModifyAccountMaxUserConnectionsResponse"/></returns>
        public ModifyAccountMaxUserConnectionsResponse ModifyAccountMaxUserConnectionsSync(ModifyAccountMaxUserConnectionsRequest req)
        {
            return InternalRequestAsync<ModifyAccountMaxUserConnectionsResponse>(req, "ModifyAccountMaxUserConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyAccountPassword) is used to modify the password of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyAccountPasswordResponse"/></returns>
        public Task<ModifyAccountPasswordResponse> ModifyAccountPassword(ModifyAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyAccountPasswordResponse>(req, "ModifyAccountPassword");
        }

        /// <summary>
        /// This API (ModifyAccountPassword) is used to modify the password of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyAccountPasswordResponse"/></returns>
        public ModifyAccountPasswordResponse ModifyAccountPasswordSync(ModifyAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyAccountPasswordResponse>(req, "ModifyAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the permissions of a TencentDB instance account.
        /// 
        /// Note that when modifying account permissions, you need to pass in the full permission information of the account. You can [query the account permission information
        /// ](https://intl.cloud.tencent.com/document/api/236/17500?from_cn_redirect=1) first before modifying permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// This API is used to modify the permissions of a TencentDB instance account.
        /// 
        /// Note that when modifying account permissions, you need to pass in the full permission information of the account. You can [query the account permission information
        /// ](https://intl.cloud.tencent.com/document/api/236/17500?from_cn_redirect=1) first before modifying permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the service configurations for a TencentDB audit policy, including the audit log retention period.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditConfigRequest"/></param>
        /// <returns><see cref="ModifyAuditConfigResponse"/></returns>
        public Task<ModifyAuditConfigResponse> ModifyAuditConfig(ModifyAuditConfigRequest req)
        {
            return InternalRequestAsync<ModifyAuditConfigResponse>(req, "ModifyAuditConfig");
        }

        /// <summary>
        /// This API is used to modify the service configurations for a TencentDB audit policy, including the audit log retention period.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditConfigRequest"/></param>
        /// <returns><see cref="ModifyAuditConfigResponse"/></returns>
        public ModifyAuditConfigResponse ModifyAuditConfigSync(ModifyAuditConfigRequest req)
        {
            return InternalRequestAsync<ModifyAuditConfigResponse>(req, "ModifyAuditConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleTemplatesResponse"/></returns>
        public Task<ModifyAuditRuleTemplatesResponse> ModifyAuditRuleTemplates(ModifyAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleTemplatesResponse>(req, "ModifyAuditRuleTemplates");
        }

        /// <summary>
        /// This API is used to modify audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleTemplatesResponse"/></returns>
        public ModifyAuditRuleTemplatesResponse ModifyAuditRuleTemplatesSync(ModifyAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleTemplatesResponse>(req, "ModifyAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the service configurations for a TencentDB instance, including the audit log retention period and the audit rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// This API is used to modify the service configurations for a TencentDB instance, including the audit log retention period and the audit rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag");
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify database backup configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public Task<ModifyBackupConfigResponse> ModifyBackupConfig(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig");
        }

        /// <summary>
        /// This API is used to modify database backup configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public ModifyBackupConfigResponse ModifyBackupConfigSync(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the restrictions of downloading backups in a region. You can specify which types of networks (private, or both private and public), VPCs, and IPs to download backups.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to modify the restrictions of downloading backups in a region. You can specify which types of networks (private, or both private and public), VPCs, and IPs to download backups.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the encryption status of an instance backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="ModifyBackupEncryptionStatusResponse"/></returns>
        public Task<ModifyBackupEncryptionStatusResponse> ModifyBackupEncryptionStatus(ModifyBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<ModifyBackupEncryptionStatusResponse>(req, "ModifyBackupEncryptionStatus");
        }

        /// <summary>
        /// This API is used to set the encryption status of an instance backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="ModifyBackupEncryptionStatusResponse"/></returns>
        public ModifyBackupEncryptionStatusResponse ModifyBackupEncryptionStatusSync(ModifyBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<ModifyBackupEncryptionStatusResponse>(req, "ModifyBackupEncryptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the proxy address description.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressDescRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressDescResponse"/></returns>
        public Task<ModifyCdbProxyAddressDescResponse> ModifyCdbProxyAddressDesc(ModifyCdbProxyAddressDescRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressDescResponse>(req, "ModifyCdbProxyAddressDesc");
        }

        /// <summary>
        /// This API is used to modify the proxy address description.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressDescRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressDescResponse"/></returns>
        public ModifyCdbProxyAddressDescResponse ModifyCdbProxyAddressDescSync(ModifyCdbProxyAddressDescRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressDescResponse>(req, "ModifyCdbProxyAddressDesc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the database proxy address VPC information.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressVipAndVPortRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressVipAndVPortResponse"/></returns>
        public Task<ModifyCdbProxyAddressVipAndVPortResponse> ModifyCdbProxyAddressVipAndVPort(ModifyCdbProxyAddressVipAndVPortRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressVipAndVPortResponse>(req, "ModifyCdbProxyAddressVipAndVPort");
        }

        /// <summary>
        /// This API is used to modify the database proxy address VPC information.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressVipAndVPortRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressVipAndVPortResponse"/></returns>
        public ModifyCdbProxyAddressVipAndVPortResponse ModifyCdbProxyAddressVipAndVPortSync(ModifyCdbProxyAddressVipAndVPortRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressVipAndVPortResponse>(req, "ModifyCdbProxyAddressVipAndVPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure database proxy parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyParamRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyParamResponse"/></returns>
        public Task<ModifyCdbProxyParamResponse> ModifyCdbProxyParam(ModifyCdbProxyParamRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyParamResponse>(req, "ModifyCdbProxyParam");
        }

        /// <summary>
        /// This API is used to configure database proxy parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyParamRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyParamResponse"/></returns>
        public ModifyCdbProxyParamResponse ModifyCdbProxyParamSync(ModifyCdbProxyParamRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyParamResponse>(req, "ModifyCdbProxyParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable the feature of sending CDB slow and error logs to CLS.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceLogToCLSResponse"/></returns>
        public Task<ModifyDBInstanceLogToCLSResponse> ModifyDBInstanceLogToCLS(ModifyDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceLogToCLSResponse>(req, "ModifyDBInstanceLogToCLS");
        }

        /// <summary>
        /// This API is used to enable or disable the feature of sending CDB slow and error logs to CLS.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceLogToCLSResponse"/></returns>
        public ModifyDBInstanceLogToCLSResponse ModifyDBInstanceLogToCLSSync(ModifyDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceLogToCLSResponse>(req, "ModifyDBInstanceLogToCLS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the mode of a cloud database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceModesRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceModesResponse"/></returns>
        public Task<ModifyDBInstanceModesResponse> ModifyDBInstanceModes(ModifyDBInstanceModesRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceModesResponse>(req, "ModifyDBInstanceModes");
        }

        /// <summary>
        /// This API is used to change the mode of a cloud database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceModesRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceModesResponse"/></returns>
        public ModifyDBInstanceModesResponse ModifyDBInstanceModesSync(ModifyDBInstanceModesRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceModesResponse>(req, "ModifyDBInstanceModes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyDBInstanceName) is used to rename a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// This API (ModifyDBInstanceName) is used to rename a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyDBInstanceProject) is used to modify the project to which a TencentDB instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public Task<ModifyDBInstanceProjectResponse> ModifyDBInstanceProject(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject");
        }

        /// <summary>
        /// This API (ModifyDBInstanceProject) is used to modify the project to which a TencentDB instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public ModifyDBInstanceProjectResponse ModifyDBInstanceProjectSync(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyDBInstanceSecurityGroups) is used to modify the security groups bound to a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API (ModifyDBInstanceSecurityGroups) is used to modify the security groups bound to a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a cloud database instance. It can also perform basic network to VPC network and subnet change under VPC network.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVipVportResponse"/></returns>
        public Task<ModifyDBInstanceVipVportResponse> ModifyDBInstanceVipVport(ModifyDBInstanceVipVportRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceVipVportResponse>(req, "ModifyDBInstanceVipVport");
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a cloud database instance. It can also perform basic network to VPC network and subnet change under VPC network.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVipVportResponse"/></returns>
        public ModifyDBInstanceVipVportResponse ModifyDBInstanceVipVportSync(ModifyDBInstanceVipVportRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceVipVportResponse>(req, "ModifyDBInstanceVipVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyInstanceParam) is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam");
        }

        /// <summary>
        /// This API (ModifyInstanceParam) is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the password complexity of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyInstancePasswordComplexityResponse"/></returns>
        public Task<ModifyInstancePasswordComplexityResponse> ModifyInstancePasswordComplexity(ModifyInstancePasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyInstancePasswordComplexityResponse>(req, "ModifyInstancePasswordComplexity");
        }

        /// <summary>
        /// This API is used to modify the password complexity of a cloud database instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyInstancePasswordComplexityResponse"/></returns>
        public ModifyInstancePasswordComplexityResponse ModifyInstancePasswordComplexitySync(ModifyInstancePasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyInstancePasswordComplexityResponse>(req, "ModifyInstancePasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyInstanceTag) is used to add, modify, or delete an instance tag.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTagRequest"/></param>
        /// <returns><see cref="ModifyInstanceTagResponse"/></returns>
        public Task<ModifyInstanceTagResponse> ModifyInstanceTag(ModifyInstanceTagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTagResponse>(req, "ModifyInstanceTag");
        }

        /// <summary>
        /// This API (ModifyInstanceTag) is used to add, modify, or delete an instance tag.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTagRequest"/></param>
        /// <returns><see cref="ModifyInstanceTagResponse"/></returns>
        public ModifyInstanceTagResponse ModifyInstanceTagSync(ModifyInstanceTagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTagResponse>(req, "ModifyInstanceTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the local binlog retention policy of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyLocalBinlogConfigResponse"/></returns>
        public Task<ModifyLocalBinlogConfigResponse> ModifyLocalBinlogConfig(ModifyLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLocalBinlogConfigResponse>(req, "ModifyLocalBinlogConfig");
        }

        /// <summary>
        /// This API is used to modify the local binlog retention policy of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyLocalBinlogConfigResponse"/></returns>
        public ModifyLocalBinlogConfigResponse ModifyLocalBinlogConfigSync(ModifyLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLocalBinlogConfigResponse>(req, "ModifyLocalBinlogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the name or description of a placement group.
        /// </summary>
        /// <param name="req"><see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns><see cref="ModifyNameOrDescByDpIdResponse"/></returns>
        public Task<ModifyNameOrDescByDpIdResponse> ModifyNameOrDescByDpId(ModifyNameOrDescByDpIdRequest req)
        {
            return InternalRequestAsync<ModifyNameOrDescByDpIdResponse>(req, "ModifyNameOrDescByDpId");
        }

        /// <summary>
        /// This API is used to modify the name or description of a placement group.
        /// </summary>
        /// <param name="req"><see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns><see cref="ModifyNameOrDescByDpIdResponse"/></returns>
        public ModifyNameOrDescByDpIdResponse ModifyNameOrDescByDpIdSync(ModifyNameOrDescByDpIdRequest req)
        {
            return InternalRequestAsync<ModifyNameOrDescByDpIdResponse>(req, "ModifyNameOrDescByDpId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify parameter templates.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate");
        }

        /// <summary>
        /// This API is used to modify parameter templates.
        /// Description: The parameter template is a common component, effective across all regions once configured. For api calls, Guangzhou or Singapore is available to configure region.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the sync method of an instance.
        /// Description: This API can be called only by an exclusive cluster. This API is about to go offline.
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectModeRequest"/></param>
        /// <returns><see cref="ModifyProtectModeResponse"/></returns>
        public Task<ModifyProtectModeResponse> ModifyProtectMode(ModifyProtectModeRequest req)
        {
            return InternalRequestAsync<ModifyProtectModeResponse>(req, "ModifyProtectMode");
        }

        /// <summary>
        /// This API is used to modify the sync method of an instance.
        /// Description: This API can be called only by an exclusive cluster. This API is about to go offline.
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectModeRequest"/></param>
        /// <returns><see cref="ModifyProtectModeResponse"/></returns>
        public ModifyProtectModeResponse ModifyProtectModeSync(ModifyProtectModeRequest req)
        {
            return InternalRequestAsync<ModifyProtectModeResponse>(req, "ModifyProtectMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyRemoteBackupConfigResponse"/></returns>
        public Task<ModifyRemoteBackupConfigResponse> ModifyRemoteBackupConfig(ModifyRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyRemoteBackupConfigResponse>(req, "ModifyRemoteBackupConfig");
        }

        /// <summary>
        /// This API is used to modify the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyRemoteBackupConfigResponse"/></returns>
        public ModifyRemoteBackupConfigResponse ModifyRemoteBackupConfigSync(ModifyRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyRemoteBackupConfigResponse>(req, "ModifyRemoteBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the information of a TencentDB RO group, such as configuring a read-only instance removal policy in case of excessive delay, setting read weights of read-only instances, and setting the replication delay.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyRoGroupInfoResponse"/></returns>
        public Task<ModifyRoGroupInfoResponse> ModifyRoGroupInfo(ModifyRoGroupInfoRequest req)
        {
            return InternalRequestAsync<ModifyRoGroupInfoResponse>(req, "ModifyRoGroupInfo");
        }

        /// <summary>
        /// This API is used to update the information of a TencentDB RO group, such as configuring a read-only instance removal policy in case of excessive delay, setting read weights of read-only instances, and setting the replication delay.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyRoGroupInfoResponse"/></returns>
        public ModifyRoGroupInfoResponse ModifyRoGroupInfoSync(ModifyRoGroupInfoRequest req)
        {
            return InternalRequestAsync<ModifyRoGroupInfoResponse>(req, "ModifyRoGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the vip and vport of a Ro group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupVipVportRequest"/></param>
        /// <returns><see cref="ModifyRoGroupVipVportResponse"/></returns>
        public Task<ModifyRoGroupVipVportResponse> ModifyRoGroupVipVport(ModifyRoGroupVipVportRequest req)
        {
            return InternalRequestAsync<ModifyRoGroupVipVportResponse>(req, "ModifyRoGroupVipVport");
        }

        /// <summary>
        /// This API is used to modify the vip and vport of a Ro group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupVipVportRequest"/></param>
        /// <returns><see cref="ModifyRoGroupVipVportResponse"/></returns>
        public ModifyRoGroupVipVportResponse ModifyRoGroupVipVportSync(ModifyRoGroupVipVportRequest req)
        {
            return InternalRequestAsync<ModifyRoGroupVipVportResponse>(req, "ModifyRoGroupVipVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyTimeWindow) is used to update the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyTimeWindowResponse"/></returns>
        public Task<ModifyTimeWindowResponse> ModifyTimeWindow(ModifyTimeWindowRequest req)
        {
            return InternalRequestAsync<ModifyTimeWindowResponse>(req, "ModifyTimeWindow");
        }

        /// <summary>
        /// This API (ModifyTimeWindow) is used to update the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyTimeWindowResponse"/></returns>
        public ModifyTimeWindowResponse ModifyTimeWindowSync(ModifyTimeWindowRequest req)
        {
            return InternalRequestAsync<ModifyTimeWindowResponse>(req, "ModifyTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This api is used to deactivate cloud database instances in quarantined state now. The instance Status for row operations must be quarantined state, such as instances with Status value 5 queried through the query instance list api.
        /// 
        /// This API is used to perform asynchronous operation, and delays may occur when reclaiming partial resources. You can query by using the query instance list API (https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) with specified instance InstanceId and status Status as [5,6,7]. Among them, 5 represents isolated, 6 represents offline, and 7 represents Offline. If the return instance is empty, all instance resources have been released.
        /// 
        /// Note that after the instance goes offline, relevant resources and data cannot be recovered. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns><see cref="OfflineIsolatedInstancesResponse"/></returns>
        public Task<OfflineIsolatedInstancesResponse> OfflineIsolatedInstances(OfflineIsolatedInstancesRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedInstancesResponse>(req, "OfflineIsolatedInstances");
        }

        /// <summary>
        /// This api is used to deactivate cloud database instances in quarantined state now. The instance Status for row operations must be quarantined state, such as instances with Status value 5 queried through the query instance list api.
        /// 
        /// This API is used to perform asynchronous operation, and delays may occur when reclaiming partial resources. You can query by using the query instance list API (https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) with specified instance InstanceId and status Status as [5,6,7]. Among them, 5 represents isolated, 6 represents offline, and 7 represents Offline. If the return instance is empty, all instance resources have been released.
        /// 
        /// Note that after the instance goes offline, relevant resources and data cannot be recovered. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns><see cref="OfflineIsolatedInstancesResponse"/></returns>
        public OfflineIsolatedInstancesResponse OfflineIsolatedInstancesSync(OfflineIsolatedInstancesRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedInstancesResponse>(req, "OfflineIsolatedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to activate audit service for CDB instance.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// This API is used to activate audit service for CDB instance.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable data storage encryption for instance and support users to specify custom keys.
        /// 
        /// Note that before enabling data storage encryption for instance, perform the following operations:
        /// 
        /// 1. Perform instance initialization (https://www.tencentcloud.com/document/api/236/15873?from_cn_redirect=1).
        /// 
        /// 2. Enable the KMS service (https://console.cloud.tencent.com/kms2).
        /// 
        /// 3. Grant the cloud database (MySQL) permission to access the KMS key (https://console.cloud.tencent.com/cam/role). The role name is MySQL_QCSRole and the preset policy name is QcloudAccessForMySQLRole.
        /// 4. Closing is not allowed after encryption being enabled.
        /// 
        /// This API may take up to 10s, and the client may timeout. If the API call returns InternalError, please call [DescribeDBInstanceInfo](https://www.tencentcloud.com/document/product/236/44160?from_cn_redirect=1) to confirm whether backend encryption is successfully enabled. After calling, if the parameter Encryption is YES, it means activation is successful.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceEncryptionRequest"/></param>
        /// <returns><see cref="OpenDBInstanceEncryptionResponse"/></returns>
        public Task<OpenDBInstanceEncryptionResponse> OpenDBInstanceEncryption(OpenDBInstanceEncryptionRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceEncryptionResponse>(req, "OpenDBInstanceEncryption");
        }

        /// <summary>
        /// This API is used to enable data storage encryption for instance and support users to specify custom keys.
        /// 
        /// Note that before enabling data storage encryption for instance, perform the following operations:
        /// 
        /// 1. Perform instance initialization (https://www.tencentcloud.com/document/api/236/15873?from_cn_redirect=1).
        /// 
        /// 2. Enable the KMS service (https://console.cloud.tencent.com/kms2).
        /// 
        /// 3. Grant the cloud database (MySQL) permission to access the KMS key (https://console.cloud.tencent.com/cam/role). The role name is MySQL_QCSRole and the preset policy name is QcloudAccessForMySQLRole.
        /// 4. Closing is not allowed after encryption being enabled.
        /// 
        /// This API may take up to 10s, and the client may timeout. If the API call returns InternalError, please call [DescribeDBInstanceInfo](https://www.tencentcloud.com/document/product/236/44160?from_cn_redirect=1) to confirm whether backend encryption is successfully enabled. After calling, if the parameter Encryption is YES, it means activation is successful.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceEncryptionRequest"/></param>
        /// <returns><see cref="OpenDBInstanceEncryptionResponse"/></returns>
        public OpenDBInstanceEncryptionResponse OpenDBInstanceEncryptionSync(OpenDBInstanceEncryptionRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceEncryptionResponse>(req, "OpenDBInstanceEncryption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (OpenDBInstanceGTID) is used to enable GTID for a TencentDB instance. Only instances on or above version 5.6 are supported.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="OpenDBInstanceGTIDResponse"/></returns>
        public Task<OpenDBInstanceGTIDResponse> OpenDBInstanceGTID(OpenDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceGTIDResponse>(req, "OpenDBInstanceGTID");
        }

        /// <summary>
        /// This API (OpenDBInstanceGTID) is used to enable GTID for a TencentDB instance. Only instances on or above version 5.6 are supported.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="OpenDBInstanceGTIDResponse"/></returns>
        public OpenDBInstanceGTIDResponse OpenDBInstanceGTIDSync(OpenDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceGTIDResponse>(req, "OpenDBInstanceGTID")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable SSL connectivity function.
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public Task<OpenSSLResponse> OpenSSL(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL");
        }

        /// <summary>
        /// This API is used to enable SSL connectivity function.
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public OpenSSLResponse OpenSSLSync(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (OpenWanService) is used to enable public network access for an instance.
        /// 
        /// Note that before enabling public network access, you need to first [initialize the instance](https://intl.cloud.tencent.com/document/api/236/15873?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="OpenWanServiceRequest"/></param>
        /// <returns><see cref="OpenWanServiceResponse"/></returns>
        public Task<OpenWanServiceResponse> OpenWanService(OpenWanServiceRequest req)
        {
            return InternalRequestAsync<OpenWanServiceResponse>(req, "OpenWanService");
        }

        /// <summary>
        /// This API (OpenWanService) is used to enable public network access for an instance.
        /// 
        /// Note that before enabling public network access, you need to first [initialize the instance](https://intl.cloud.tencent.com/document/api/236/15873?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="OpenWanServiceRequest"/></param>
        /// <returns><see cref="OpenWanServiceResponse"/></returns>
        public OpenWanServiceResponse OpenWanServiceSync(OpenWanServiceRequest req)
        {
            return InternalRequestAsync<OpenWanServiceResponse>(req, "OpenWanService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restore isolated cloud database instances. It is only used for de-isolating pay-as-you-go instances. For monthly subscription instances, please use RenewDBInstance.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIsolatedDBInstancesRequest"/></param>
        /// <returns><see cref="ReleaseIsolatedDBInstancesResponse"/></returns>
        public Task<ReleaseIsolatedDBInstancesResponse> ReleaseIsolatedDBInstances(ReleaseIsolatedDBInstancesRequest req)
        {
            return InternalRequestAsync<ReleaseIsolatedDBInstancesResponse>(req, "ReleaseIsolatedDBInstances");
        }

        /// <summary>
        /// This API is used to restore isolated cloud database instances. It is only used for de-isolating pay-as-you-go instances. For monthly subscription instances, please use RenewDBInstance.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIsolatedDBInstancesRequest"/></param>
        /// <returns><see cref="ReleaseIsolatedDBInstancesResponse"/></returns>
        public ReleaseIsolatedDBInstancesResponse ReleaseIsolatedDBInstancesSync(ReleaseIsolatedDBInstancesRequest req)
        {
            return InternalRequestAsync<ReleaseIsolatedDBInstancesResponse>(req, "ReleaseIsolatedDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rebalance the load on database proxy.
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public Task<ReloadBalanceProxyNodeResponse> ReloadBalanceProxyNode(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode");
        }

        /// <summary>
        /// This API is used to rebalance the load on database proxy.
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public ReloadBalanceProxyNodeResponse ReloadBalanceProxyNodeSync(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew cloud database instances. It supports yearly/monthly subscription instances. Pay-as-you-go instances can be renewed as yearly/monthly subscription instances through this API.
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public Task<RenewDBInstanceResponse> RenewDBInstance(RenewDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDBInstanceResponse>(req, "RenewDBInstance");
        }

        /// <summary>
        /// This API is used to renew cloud database instances. It supports yearly/monthly subscription instances. Pay-as-you-go instances can be renewed as yearly/monthly subscription instances through this API.
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public RenewDBInstanceResponse RenewDBInstanceSync(RenewDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDBInstanceResponse>(req, "RenewDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Manually refresh rotation passwords
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword");
        }

        /// <summary>
        /// Manually refresh rotation passwords
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the root account and initialize the account permissions.
        /// </summary>
        /// <param name="req"><see cref="ResetRootAccountRequest"/></param>
        /// <returns><see cref="ResetRootAccountResponse"/></returns>
        public Task<ResetRootAccountResponse> ResetRootAccount(ResetRootAccountRequest req)
        {
            return InternalRequestAsync<ResetRootAccountResponse>(req, "ResetRootAccount");
        }

        /// <summary>
        /// This API is used to reset the root account and initialize the account permissions.
        /// </summary>
        /// <param name="req"><see cref="ResetRootAccountRequest"/></param>
        /// <returns><see cref="ResetRootAccountResponse"/></returns>
        public ResetRootAccountResponse ResetRootAccountSync(ResetRootAccountRequest req)
        {
            return InternalRequestAsync<ResetRootAccountResponse>(req, "ResetRootAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart cloud database instances.
        /// 
        /// Note:
        /// This API supports performing a restart operation on primary instances, read-only instances, and disaster recovery instances.
        /// 2. The instance status must be normal and no other async tasks are in progress.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public Task<RestartDBInstancesResponse> RestartDBInstances(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances");
        }

        /// <summary>
        /// This API is used to restart cloud database instances.
        /// 
        /// Note:
        /// This API supports performing a restart operation on primary instances, read-only instances, and disaster recovery instances.
        /// 2. The instance status must be normal and no other async tasks are in progress.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public RestartDBInstancesResponse RestartDBInstancesSync(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (StartBatchRollback) is used to roll back the tables of a TencentDB instance in batches.
        /// </summary>
        /// <param name="req"><see cref="StartBatchRollbackRequest"/></param>
        /// <returns><see cref="StartBatchRollbackResponse"/></returns>
        public Task<StartBatchRollbackResponse> StartBatchRollback(StartBatchRollbackRequest req)
        {
            return InternalRequestAsync<StartBatchRollbackResponse>(req, "StartBatchRollback");
        }

        /// <summary>
        /// This API (StartBatchRollback) is used to roll back the tables of a TencentDB instance in batches.
        /// </summary>
        /// <param name="req"><see cref="StartBatchRollbackRequest"/></param>
        /// <returns><see cref="StartBatchRollbackResponse"/></returns>
        public StartBatchRollbackResponse StartBatchRollbackSync(StartBatchRollbackRequest req)
        {
            return InternalRequestAsync<StartBatchRollbackResponse>(req, "StartBatchRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable CPU Elastic Scaling, including one-time manual scale-out and automatic elastic scaling.
        /// </summary>
        /// <param name="req"><see cref="StartCpuExpandRequest"/></param>
        /// <returns><see cref="StartCpuExpandResponse"/></returns>
        public Task<StartCpuExpandResponse> StartCpuExpand(StartCpuExpandRequest req)
        {
            return InternalRequestAsync<StartCpuExpandResponse>(req, "StartCpuExpand");
        }

        /// <summary>
        /// This API is used to enable CPU Elastic Scaling, including one-time manual scale-out and automatic elastic scaling.
        /// </summary>
        /// <param name="req"><see cref="StartCpuExpandRequest"/></param>
        /// <returns><see cref="StartCpuExpandResponse"/></returns>
        public StartCpuExpandResponse StartCpuExpandSync(StartCpuExpandRequest req)
        {
            return InternalRequestAsync<StartCpuExpandResponse>(req, "StartCpuExpand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable RO replication and sync data from the primary instance.
        /// </summary>
        /// <param name="req"><see cref="StartReplicationRequest"/></param>
        /// <returns><see cref="StartReplicationResponse"/></returns>
        public Task<StartReplicationResponse> StartReplication(StartReplicationRequest req)
        {
            return InternalRequestAsync<StartReplicationResponse>(req, "StartReplication");
        }

        /// <summary>
        /// This API is used to enable RO replication and sync data from the primary instance.
        /// </summary>
        /// <param name="req"><see cref="StartReplicationRequest"/></param>
        /// <returns><see cref="StartReplicationResponse"/></returns>
        public StartReplicationResponse StartReplicationSync(StartReplicationRequest req)
        {
            return InternalRequestAsync<StartReplicationResponse>(req, "StartReplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable elastic CPU expansion.
        /// </summary>
        /// <param name="req"><see cref="StopCpuExpandRequest"/></param>
        /// <returns><see cref="StopCpuExpandResponse"/></returns>
        public Task<StopCpuExpandResponse> StopCpuExpand(StopCpuExpandRequest req)
        {
            return InternalRequestAsync<StopCpuExpandResponse>(req, "StopCpuExpand");
        }

        /// <summary>
        /// This API is used to disable elastic CPU expansion.
        /// </summary>
        /// <param name="req"><see cref="StopCpuExpandRequest"/></param>
        /// <returns><see cref="StopCpuExpandResponse"/></returns>
        public StopCpuExpandResponse StopCpuExpandSync(StopCpuExpandRequest req)
        {
            return InternalRequestAsync<StopCpuExpandResponse>(req, "StopCpuExpand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a data import task.
        /// Description: Only incomplete import jobs support termination, and the executed SQL part is retained after termination.
        /// </summary>
        /// <param name="req"><see cref="StopDBImportJobRequest"/></param>
        /// <returns><see cref="StopDBImportJobResponse"/></returns>
        public Task<StopDBImportJobResponse> StopDBImportJob(StopDBImportJobRequest req)
        {
            return InternalRequestAsync<StopDBImportJobResponse>(req, "StopDBImportJob");
        }

        /// <summary>
        /// This API is used to terminate a data import task.
        /// Description: Only incomplete import jobs support termination, and the executed SQL part is retained after termination.
        /// </summary>
        /// <param name="req"><see cref="StopDBImportJobRequest"/></param>
        /// <returns><see cref="StopDBImportJobResponse"/></returns>
        public StopDBImportJobResponse StopDBImportJobSync(StopDBImportJobRequest req)
        {
            return InternalRequestAsync<StopDBImportJobResponse>(req, "StopDBImportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop RO replication and interrupt data sync from the primary instance.
        /// </summary>
        /// <param name="req"><see cref="StopReplicationRequest"/></param>
        /// <returns><see cref="StopReplicationResponse"/></returns>
        public Task<StopReplicationResponse> StopReplication(StopReplicationRequest req)
        {
            return InternalRequestAsync<StopReplicationResponse>(req, "StopReplication");
        }

        /// <summary>
        /// This API is used to stop RO replication and interrupt data sync from the primary instance.
        /// </summary>
        /// <param name="req"><see cref="StopReplicationRequest"/></param>
        /// <returns><see cref="StopReplicationResponse"/></returns>
        public StopReplicationResponse StopReplicationSync(StopReplicationRequest req)
        {
            return InternalRequestAsync<StopReplicationResponse>(req, "StopReplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This api is used to revoke an ongoing rollback task of an instance. The api response returns an Asynchronous Task ID. The revocation result can be queried through [DescribeAsyncRequestInfo](https://www.tencentcloud.com/document/api/236/20410?from_cn_redirect=1) for task execution.
        /// </summary>
        /// <param name="req"><see cref="StopRollbackRequest"/></param>
        /// <returns><see cref="StopRollbackResponse"/></returns>
        public Task<StopRollbackResponse> StopRollback(StopRollbackRequest req)
        {
            return InternalRequestAsync<StopRollbackResponse>(req, "StopRollback");
        }

        /// <summary>
        /// This api is used to revoke an ongoing rollback task of an instance. The api response returns an Asynchronous Task ID. The revocation result can be queried through [DescribeAsyncRequestInfo](https://www.tencentcloud.com/document/api/236/20410?from_cn_redirect=1) for task execution.
        /// </summary>
        /// <param name="req"><see cref="StopRollbackRequest"/></param>
        /// <returns><see cref="StopRollbackResponse"/></returns>
        public StopRollbackResponse StopRollbackSync(StopRollbackRequest req)
        {
            return InternalRequestAsync<StopRollbackResponse>(req, "StopRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit an instance version upgrade validation task.
        /// </summary>
        /// <param name="req"><see cref="SubmitInstanceUpgradeCheckJobRequest"/></param>
        /// <returns><see cref="SubmitInstanceUpgradeCheckJobResponse"/></returns>
        public Task<SubmitInstanceUpgradeCheckJobResponse> SubmitInstanceUpgradeCheckJob(SubmitInstanceUpgradeCheckJobRequest req)
        {
            return InternalRequestAsync<SubmitInstanceUpgradeCheckJobResponse>(req, "SubmitInstanceUpgradeCheckJob");
        }

        /// <summary>
        /// This API is used to submit an instance version upgrade validation task.
        /// </summary>
        /// <param name="req"><see cref="SubmitInstanceUpgradeCheckJobRequest"/></param>
        /// <returns><see cref="SubmitInstanceUpgradeCheckJobResponse"/></returns>
        public SubmitInstanceUpgradeCheckJobResponse SubmitInstanceUpgradeCheckJobSync(SubmitInstanceUpgradeCheckJobRequest req)
        {
            return InternalRequestAsync<SubmitInstanceUpgradeCheckJobResponse>(req, "SubmitInstanceUpgradeCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manually initiate an immediate switch after database proxy configuration modification or edition upgrade.
        /// </summary>
        /// <param name="req"><see cref="SwitchCDBProxyRequest"/></param>
        /// <returns><see cref="SwitchCDBProxyResponse"/></returns>
        public Task<SwitchCDBProxyResponse> SwitchCDBProxy(SwitchCDBProxyRequest req)
        {
            return InternalRequestAsync<SwitchCDBProxyResponse>(req, "SwitchCDBProxy");
        }

        /// <summary>
        /// This API is used to manually initiate an immediate switch after database proxy configuration modification or edition upgrade.
        /// </summary>
        /// <param name="req"><see cref="SwitchCDBProxyRequest"/></param>
        /// <returns><see cref="SwitchCDBProxyResponse"/></returns>
        public SwitchCDBProxyResponse SwitchCDBProxySync(SwitchCDBProxyRequest req)
        {
            return InternalRequestAsync<SwitchCDBProxyResponse>(req, "SwitchCDBProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for source-to-replica switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceMasterSlaveRequest"/></param>
        /// <returns><see cref="SwitchDBInstanceMasterSlaveResponse"/></returns>
        public Task<SwitchDBInstanceMasterSlaveResponse> SwitchDBInstanceMasterSlave(SwitchDBInstanceMasterSlaveRequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceMasterSlaveResponse>(req, "SwitchDBInstanceMasterSlave");
        }

        /// <summary>
        /// This API is used for source-to-replica switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceMasterSlaveRequest"/></param>
        /// <returns><see cref="SwitchDBInstanceMasterSlaveResponse"/></returns>
        public SwitchDBInstanceMasterSlaveResponse SwitchDBInstanceMasterSlaveSync(SwitchDBInstanceMasterSlaveRequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceMasterSlaveResponse>(req, "SwitchDBInstanceMasterSlave")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch a cloud database disaster recovery instance to primary instance. Note that the request must be sent to the region where the disaster recovery instance is located.
        /// </summary>
        /// <param name="req"><see cref="SwitchDrInstanceToMasterRequest"/></param>
        /// <returns><see cref="SwitchDrInstanceToMasterResponse"/></returns>
        public Task<SwitchDrInstanceToMasterResponse> SwitchDrInstanceToMaster(SwitchDrInstanceToMasterRequest req)
        {
            return InternalRequestAsync<SwitchDrInstanceToMasterResponse>(req, "SwitchDrInstanceToMaster");
        }

        /// <summary>
        /// This API is used to switch a cloud database disaster recovery instance to primary instance. Note that the request must be sent to the region where the disaster recovery instance is located.
        /// </summary>
        /// <param name="req"><see cref="SwitchDrInstanceToMasterRequest"/></param>
        /// <returns><see cref="SwitchDrInstanceToMasterResponse"/></returns>
        public SwitchDrInstanceToMasterResponse SwitchDrInstanceToMasterSync(SwitchDrInstanceToMasterRequest req)
        {
            return InternalRequestAsync<SwitchDrInstanceToMasterResponse>(req, "SwitchDrInstanceToMaster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (SwitchForUpgrade) is used to switch to a new instance. You can initiate this process when the primary instance being upgraded is pending switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchForUpgradeRequest"/></param>
        /// <returns><see cref="SwitchForUpgradeResponse"/></returns>
        public Task<SwitchForUpgradeResponse> SwitchForUpgrade(SwitchForUpgradeRequest req)
        {
            return InternalRequestAsync<SwitchForUpgradeResponse>(req, "SwitchForUpgrade");
        }

        /// <summary>
        /// This API (SwitchForUpgrade) is used to switch to a new instance. You can initiate this process when the primary instance being upgraded is pending switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchForUpgradeRequest"/></param>
        /// <returns><see cref="SwitchForUpgradeResponse"/></returns>
        public SwitchForUpgradeResponse SwitchForUpgradeSync(SwitchForUpgradeRequest req)
        {
            return InternalRequestAsync<SwitchForUpgradeResponse>(req, "SwitchForUpgrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the database proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeCDBProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeCDBProxyVersionResponse"/></returns>
        public Task<UpgradeCDBProxyVersionResponse> UpgradeCDBProxyVersion(UpgradeCDBProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeCDBProxyVersionResponse>(req, "UpgradeCDBProxyVersion");
        }

        /// <summary>
        /// This API is used to upgrade the database proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeCDBProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeCDBProxyVersionResponse"/></returns>
        public UpgradeCDBProxyVersionResponse UpgradeCDBProxyVersionSync(UpgradeCDBProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeCDBProxyVersionResponse>(req, "UpgradeCDBProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade or downgrade the configuration of a cloud database instance. Supported instance types include primary instance, disaster recovery instance and read-only instance. If you need to migrate business, fill in the instance specification (CPU, memory), otherwise the system will use the minimum allowed specification by default.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance");
        }

        /// <summary>
        /// This API is used to upgrade or downgrade the configuration of a cloud database instance. Supported instance types include primary instance, disaster recovery instance and read-only instance. If you need to migrate business, fill in the instance specification (CPU, memory), otherwise the system will use the minimum allowed specification by default.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the version of a cloud database instance. Supported instance types include primary instance, disaster recovery instance, and read-only instance. Before upgrade, submit an upgrade check task via SubmitInstanceUpgradeCheckJob (https://www.tencentcloud.com/document/product/236/110468?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceEngineVersionResponse"/></returns>
        public Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceEngineVersionResponse>(req, "UpgradeDBInstanceEngineVersion");
        }

        /// <summary>
        /// This API is used to upgrade the version of a cloud database instance. Supported instance types include primary instance, disaster recovery instance, and read-only instance. Before upgrade, submit an upgrade check task via SubmitInstanceUpgradeCheckJob (https://www.tencentcloud.com/document/product/236/110468?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceEngineVersionResponse"/></returns>
        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersionSync(UpgradeDBInstanceEngineVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceEngineVersionResponse>(req, "UpgradeDBInstanceEngineVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
