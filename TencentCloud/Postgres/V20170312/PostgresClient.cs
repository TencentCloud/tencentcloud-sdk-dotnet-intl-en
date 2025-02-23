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

namespace TencentCloud.Postgres.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Postgres.V20170312.Models;

   public class PostgresClient : AbstractClient{

       private const string endpoint = "postgres.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1075";

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
        /// This API is used to disable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public Task<CloseServerlessDBExtranetAccessResponse> CloseServerlessDBExtranetAccess(CloseServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseServerlessDBExtranetAccessResponse>(req, "CloseServerlessDBExtranetAccess");
        }

        /// <summary>
        /// This API is used to disable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public CloseServerlessDBExtranetAccessResponse CloseServerlessDBExtranetAccessSync(CloseServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseServerlessDBExtranetAccessResponse>(req, "CloseServerlessDBExtranetAccess")
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
        /// This API is used to create a network for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public Task<CreateDBInstanceNetworkAccessResponse> CreateDBInstanceNetworkAccess(CreateDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceNetworkAccessResponse>(req, "CreateDBInstanceNetworkAccess");
        }

        /// <summary>
        /// This API is used to create a network for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public CreateDBInstanceNetworkAccessResponse CreateDBInstanceNetworkAccessSync(CreateDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceNetworkAccessResponse>(req, "CreateDBInstanceNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create (but not initialize) one or more TencentDB for PostgreSQL instances. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances");
        }

        /// <summary>
        /// This API is used to create (but not initialize) one or more TencentDB for PostgreSQL instances. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances")
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
        /// This API is used to create a network for an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public Task<CreateReadOnlyGroupNetworkAccessResponse> CreateReadOnlyGroupNetworkAccess(CreateReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupNetworkAccessResponse>(req, "CreateReadOnlyGroupNetworkAccess");
        }

        /// <summary>
        /// This API is used to create a network for an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public CreateReadOnlyGroupNetworkAccessResponse CreateReadOnlyGroupNetworkAccessSync(CreateReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupNetworkAccessResponse>(req, "CreateReadOnlyGroupNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a PostgreSQL for Serverless instance. If the creation succeeds, the instance ID will be returned.
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public Task<CreateServerlessDBInstanceResponse> CreateServerlessDBInstance(CreateServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateServerlessDBInstanceResponse>(req, "CreateServerlessDBInstance");
        }

        /// <summary>
        /// This API is used to create a PostgreSQL for Serverless instance. If the creation succeeds, the instance ID will be returned.
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public CreateServerlessDBInstanceResponse CreateServerlessDBInstanceSync(CreateServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateServerlessDBInstanceResponse>(req, "CreateServerlessDBInstance")
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
        /// This API is used to delete a network of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public Task<DeleteDBInstanceNetworkAccessResponse> DeleteDBInstanceNetworkAccess(DeleteDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceNetworkAccessResponse>(req, "DeleteDBInstanceNetworkAccess");
        }

        /// <summary>
        /// This API is used to delete a network of an instance.
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
        /// This API is used to delete a network of an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public Task<DeleteReadOnlyGroupNetworkAccessResponse> DeleteReadOnlyGroupNetworkAccess(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupNetworkAccessResponse>(req, "DeleteReadOnlyGroupNetworkAccess");
        }

        /// <summary>
        /// This API is used to delete a network of an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public DeleteReadOnlyGroupNetworkAccessResponse DeleteReadOnlyGroupNetworkAccessSync(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupNetworkAccessResponse>(req, "DeleteReadOnlyGroupNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public Task<DeleteServerlessDBInstanceResponse> DeleteServerlessDBInstance(DeleteServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteServerlessDBInstanceResponse>(req, "DeleteServerlessDBInstance");
        }

        /// <summary>
        /// This API is used to delete a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public DeleteServerlessDBInstanceResponse DeleteServerlessDBInstanceSync(DeleteServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteServerlessDBInstanceResponse>(req, "DeleteServerlessDBInstance")
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
        /// This API is used to query the backup list of an instance. This API is disused and replaced by the [DescribeBaseBackups](https://intl.cloud.tencent.com/document/api/409/89022?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public Task<DescribeDBBackupsResponse> DescribeDBBackups(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups");
        }

        /// <summary>
        /// This API is used to query the backup list of an instance. This API is disused and replaced by the [DescribeBaseBackups](https://intl.cloud.tencent.com/document/api/409/89022?from_cn_redirect=1) API.
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
        /// This API is used to query the HA configuration of an instance, which includes:
        /// <li>Allow a standby node to promote to a primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceHAConfigResponse"/></returns>
        public Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfig(DescribeDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceHAConfigResponse>(req, "DescribeDBInstanceHAConfig");
        }

        /// <summary>
        /// This API is used to query the HA configuration of an instance, which includes:
        /// <li>Allow a standby node to promote to a primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
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
        /// This API is used to get a slow query log. Since it was deprecated on September 1, 2021, it has no longer returned data. You need to use the [DescribeSlowQueryList](https://intl.cloud.tencent.com/document/product/409/60540?from_cn_redirect=1) API instead to get slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public Task<DescribeDBSlowlogsResponse> DescribeDBSlowlogs(DescribeDBSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowlogsResponse>(req, "DescribeDBSlowlogs");
        }

        /// <summary>
        /// This API is used to get a slow query log. Since it was deprecated on September 1, 2021, it has no longer returned data. You need to use the [DescribeSlowQueryList](https://intl.cloud.tencent.com/document/product/409/60540?from_cn_redirect=1) API instead to get slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public DescribeDBSlowlogsResponse DescribeDBSlowlogsSync(DescribeDBSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowlogsResponse>(req, "DescribeDBSlowlogs")
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
        /// This API is used to get the instance Xlog list. This API is disused and replaced by the [DescribeBaseBackups](https://www.tencentcloud.com/zh/document/product/409/54343) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public Task<DescribeDBXlogsResponse> DescribeDBXlogs(DescribeDBXlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBXlogsResponse>(req, "DescribeDBXlogs");
        }

        /// <summary>
        /// This API is used to get the instance Xlog list. This API is disused and replaced by the [DescribeBaseBackups](https://www.tencentcloud.com/zh/document/product/409/54343) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public DescribeDBXlogsResponse DescribeDBXlogsSync(DescribeDBXlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBXlogsResponse>(req, "DescribeDBXlogs")
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
        /// This API is used to query the purchasable specification configuration. u200cThis API is disused and replaced by the [DescribeClasses](https://intl.cloud.tencent.com/document/api/409/89019?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig");
        }

        /// <summary>
        /// This API is used to query the purchasable specification configuration. u200cThis API is disused and replaced by the [DescribeClasses](https://intl.cloud.tencent.com/document/api/409/89019?from_cn_redirect=1) API.
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
        /// This API is used to query the details of one or more PostgreSQL for Serverless instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public Task<DescribeServerlessDBInstancesResponse> DescribeServerlessDBInstances(DescribeServerlessDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeServerlessDBInstancesResponse>(req, "DescribeServerlessDBInstances");
        }

        /// <summary>
        /// This API is used to query the details of one or more PostgreSQL for Serverless instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public DescribeServerlessDBInstancesResponse DescribeServerlessDBInstancesSync(DescribeServerlessDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeServerlessDBInstancesResponse>(req, "DescribeServerlessDBInstances")
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
        /// This API is used to initialize a TencentDB for PostgreSQL instance. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDBInstancesResponse>(req, "InitDBInstances");
        }

        /// <summary>
        /// This API is used to initialize a TencentDB for PostgreSQL instance. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public InitDBInstancesResponse InitDBInstancesSync(InitDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDBInstancesResponse>(req, "InitDBInstances")
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
        /// This API is used to switch the instance billing mode from pay-as-you-go to monthly subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public Task<ModifyDBInstanceChargeTypeResponse> ModifyDBInstanceChargeType(ModifyDBInstanceChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceChargeTypeResponse>(req, "ModifyDBInstanceChargeType");
        }

        /// <summary>
        /// This API is used to switch the instance billing mode from pay-as-you-go to monthly subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public ModifyDBInstanceChargeTypeResponse ModifyDBInstanceChargeTypeSync(ModifyDBInstanceChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceChargeTypeResponse>(req, "ModifyDBInstanceChargeType")
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
        /// This API is used to modify the HA configuration of an instance. which includes:
        /// <li>Allow the standby node to promote to the primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceHAConfigResponse"/></returns>
        public Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfig(ModifyDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceHAConfigResponse>(req, "ModifyDBInstanceHAConfig");
        }

        /// <summary>
        /// This API is used to modify the HA configuration of an instance. which includes:
        /// <li>Allow the standby node to promote to the primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
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
        /// This API is used to modify instance specifications, including memory and disk size.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec");
        }

        /// <summary>
        /// This API is used to modify instance specifications, including memory and disk size.
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
        /// This API is used to enable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public Task<OpenServerlessDBExtranetAccessResponse> OpenServerlessDBExtranetAccess(OpenServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenServerlessDBExtranetAccessResponse>(req, "OpenServerlessDBExtranetAccess");
        }

        /// <summary>
        /// This API is used to enable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public OpenServerlessDBExtranetAccessResponse OpenServerlessDBExtranetAccessSync(OpenServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenServerlessDBExtranetAccessResponse>(req, "OpenServerlessDBExtranetAccess")
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
        /// This API is used to enable the primary-standby switch of an instance.
        /// <li>By initiating a switch, you can verify whether the primary-standby switch is performed correctly.
        /// <li>By using forced switch, you can forcibly initiate the primary-standby switch when the delay of replica node failed to meet the switch requirement.
        /// <li>This operation can only be performed for the primary instance.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public Task<SwitchDBInstancePrimaryResponse> SwitchDBInstancePrimary(SwitchDBInstancePrimaryRequest req)
        {
            return InternalRequestAsync<SwitchDBInstancePrimaryResponse>(req, "SwitchDBInstancePrimary");
        }

        /// <summary>
        /// This API is used to enable the primary-standby switch of an instance.
        /// <li>By initiating a switch, you can verify whether the primary-standby switch is performed correctly.
        /// <li>By using forced switch, you can forcibly initiate the primary-standby switch when the delay of replica node failed to meet the switch requirement.
        /// <li>This operation can only be performed for the primary instance.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public SwitchDBInstancePrimaryResponse SwitchDBInstancePrimarySync(SwitchDBInstancePrimaryRequest req)
        {
            return InternalRequestAsync<SwitchDBInstancePrimaryResponse>(req, "SwitchDBInstancePrimary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade instance configurations. u200cThis API is disused and replaced by the [ModifyDBInstanceSpec](https://intl.cloud.tencent.com/document/api/409/63689?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance");
        }

        /// <summary>
        /// This API is used to upgrade instance configurations. u200cThis API is disused and replaced by the [ModifyDBInstanceSpec](https://intl.cloud.tencent.com/document/api/409/63689?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance")
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
