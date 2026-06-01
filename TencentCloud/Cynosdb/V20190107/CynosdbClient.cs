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

namespace TencentCloud.Cynosdb.V20190107
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cynosdb.V20190107.Models;

   public class CynosdbClient : AbstractClient{

       private const string endpoint = "cynosdb.intl.tencentcloudapi.com";
       private const string version = "2019-01-07";
       private const string sdkVersion = "SDK_NET_3.0.1324";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CynosdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CynosdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This interface (ActivateInstance) restores access to isolated instances.
        /// </summary>
        /// <param name="req"><see cref="ActivateInstanceRequest"/></param>
        /// <returns><see cref="ActivateInstanceResponse"/></returns>
        public Task<ActivateInstanceResponse> ActivateInstance(ActivateInstanceRequest req)
        {
            return InternalRequestAsync<ActivateInstanceResponse>(req, "ActivateInstance");
        }

        /// <summary>
        /// This interface (ActivateInstance) restores access to isolated instances.
        /// </summary>
        /// <param name="req"><see cref="ActivateInstanceRequest"/></param>
        /// <returns><see cref="ActivateInstanceResponse"/></returns>
        public ActivateInstanceResponse ActivateInstanceSync(ActivateInstanceRequest req)
        {
            return InternalRequestAsync<ActivateInstanceResponse>(req, "ActivateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Release the analysis cluster from quarantined state
        /// </summary>
        /// <param name="req"><see cref="ActivateLibraDBClusterRequest"/></param>
        /// <returns><see cref="ActivateLibraDBClusterResponse"/></returns>
        public Task<ActivateLibraDBClusterResponse> ActivateLibraDBCluster(ActivateLibraDBClusterRequest req)
        {
            return InternalRequestAsync<ActivateLibraDBClusterResponse>(req, "ActivateLibraDBCluster");
        }

        /// <summary>
        /// Release the analysis cluster from quarantined state
        /// </summary>
        /// <param name="req"><see cref="ActivateLibraDBClusterRequest"/></param>
        /// <returns><see cref="ActivateLibraDBClusterResponse"/></returns>
        public ActivateLibraDBClusterResponse ActivateLibraDBClusterSync(ActivateLibraDBClusterRequest req)
        {
            return InternalRequestAsync<ActivateLibraDBClusterResponse>(req, "ActivateLibraDBCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an isolated read-only analysis engine instance.
        /// </summary>
        /// <param name="req"><see cref="ActivateLibraDBInstanceRequest"/></param>
        /// <returns><see cref="ActivateLibraDBInstanceResponse"/></returns>
        public Task<ActivateLibraDBInstanceResponse> ActivateLibraDBInstance(ActivateLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<ActivateLibraDBInstanceResponse>(req, "ActivateLibraDBInstance");
        }

        /// <summary>
        /// This API is used to unbind an isolated read-only analysis engine instance.
        /// </summary>
        /// <param name="req"><see cref="ActivateLibraDBInstanceRequest"/></param>
        /// <returns><see cref="ActivateLibraDBInstanceResponse"/></returns>
        public ActivateLibraDBInstanceResponse ActivateLibraDBInstanceSync(ActivateLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<ActivateLibraDBInstanceResponse>(req, "ActivateLibraDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (AddClusterSlaveZone) is used to enable multi-az deployment for a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="AddClusterSlaveZoneResponse"/></returns>
        public Task<AddClusterSlaveZoneResponse> AddClusterSlaveZone(AddClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<AddClusterSlaveZoneResponse>(req, "AddClusterSlaveZone");
        }

        /// <summary>
        /// This interface (AddClusterSlaveZone) is used to enable multi-az deployment for a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="AddClusterSlaveZoneResponse"/></returns>
        public AddClusterSlaveZoneResponse AddClusterSlaveZoneSync(AddClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<AddClusterSlaveZoneResponse>(req, "AddClusterSlaveZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public Task<AddInstancesResponse> AddInstances(AddInstancesRequest req)
        {
            return InternalRequestAsync<AddInstancesResponse>(req, "AddInstances");
        }

        /// <summary>
        /// This API is used to add instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public AddInstancesResponse AddInstancesSync(AddInstancesRequest req)
        {
            return InternalRequestAsync<AddInstancesResponse>(req, "AddInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add read-only analysis engine to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddLibraDBInstancesRequest"/></param>
        /// <returns><see cref="AddLibraDBInstancesResponse"/></returns>
        public Task<AddLibraDBInstancesResponse> AddLibraDBInstances(AddLibraDBInstancesRequest req)
        {
            return InternalRequestAsync<AddLibraDBInstancesResponse>(req, "AddLibraDBInstances");
        }

        /// <summary>
        /// This API is used to add read-only analysis engine to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddLibraDBInstancesRequest"/></param>
        /// <returns><see cref="AddLibraDBInstancesResponse"/></returns>
        public AddLibraDBInstancesResponse AddLibraDBInstancesSync(AddLibraDBInstancesRequest req)
        {
            return InternalRequestAsync<AddLibraDBInstancesResponse>(req, "AddLibraDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add a read-only instance to the serverless cluster
        /// </summary>
        /// <param name="req"><see cref="AddServerlessRoInstancesRequest"/></param>
        /// <returns><see cref="AddServerlessRoInstancesResponse"/></returns>
        public Task<AddServerlessRoInstancesResponse> AddServerlessRoInstances(AddServerlessRoInstancesRequest req)
        {
            return InternalRequestAsync<AddServerlessRoInstancesResponse>(req, "AddServerlessRoInstances");
        }

        /// <summary>
        /// Add a read-only instance to the serverless cluster
        /// </summary>
        /// <param name="req"><see cref="AddServerlessRoInstancesRequest"/></param>
        /// <returns><see cref="AddServerlessRoInstancesResponse"/></returns>
        public AddServerlessRoInstancesResponse AddServerlessRoInstancesSync(AddServerlessRoInstancesRequest req)
        {
            return InternalRequestAsync<AddServerlessRoInstancesResponse>(req, "AddServerlessRoInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk bind security groups to cloud resources.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to bulk bind security groups to cloud resources.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind resource packages to a cluster.
        /// </summary>
        /// <param name="req"><see cref="BindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="BindClusterResourcePackagesResponse"/></returns>
        public Task<BindClusterResourcePackagesResponse> BindClusterResourcePackages(BindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<BindClusterResourcePackagesResponse>(req, "BindClusterResourcePackages");
        }

        /// <summary>
        /// This API is used to bind resource packages to a cluster.
        /// </summary>
        /// <param name="req"><see cref="BindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="BindClusterResourcePackagesResponse"/></returns>
        public BindClusterResourcePackagesResponse BindClusterResourcePackagesSync(BindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<BindClusterResourcePackagesResponse>(req, "BindClusterResourcePackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Calculate the backup file list that will expire and be deleted after modifying the backup retention period
        /// </summary>
        /// <param name="req"><see cref="CalculateBackupSaveSecExpiresRequest"/></param>
        /// <returns><see cref="CalculateBackupSaveSecExpiresResponse"/></returns>
        public Task<CalculateBackupSaveSecExpiresResponse> CalculateBackupSaveSecExpires(CalculateBackupSaveSecExpiresRequest req)
        {
            return InternalRequestAsync<CalculateBackupSaveSecExpiresResponse>(req, "CalculateBackupSaveSecExpires");
        }

        /// <summary>
        /// Calculate the backup file list that will expire and be deleted after modifying the backup retention period
        /// </summary>
        /// <param name="req"><see cref="CalculateBackupSaveSecExpiresRequest"/></param>
        /// <returns><see cref="CalculateBackupSaveSecExpiresResponse"/></returns>
        public CalculateBackupSaveSecExpiresResponse CalculateBackupSaveSecExpiresSync(CalculateBackupSaveSecExpiresRequest req)
        {
            return InternalRequestAsync<CalculateBackupSaveSecExpiresResponse>(req, "CalculateBackupSaveSecExpires")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify whether it is possible to add a read-only analysis engine instance to the cluster.
        /// </summary>
        /// <param name="req"><see cref="CheckCreateLibraDBInstanceRequest"/></param>
        /// <returns><see cref="CheckCreateLibraDBInstanceResponse"/></returns>
        public Task<CheckCreateLibraDBInstanceResponse> CheckCreateLibraDBInstance(CheckCreateLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<CheckCreateLibraDBInstanceResponse>(req, "CheckCreateLibraDBInstance");
        }

        /// <summary>
        /// This API is used to verify whether it is possible to add a read-only analysis engine instance to the cluster.
        /// </summary>
        /// <param name="req"><see cref="CheckCreateLibraDBInstanceRequest"/></param>
        /// <returns><see cref="CheckCreateLibraDBInstanceResponse"/></returns>
        public CheckCreateLibraDBInstanceResponse CheckCreateLibraDBInstanceSync(CheckCreateLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<CheckCreateLibraDBInstanceResponse>(req, "CheckCreateLibraDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check if it is possible to trigger cross-AZ migration.
        /// </summary>
        /// <param name="req"><see cref="CheckTransferClusterZoneRequest"/></param>
        /// <returns><see cref="CheckTransferClusterZoneResponse"/></returns>
        public Task<CheckTransferClusterZoneResponse> CheckTransferClusterZone(CheckTransferClusterZoneRequest req)
        {
            return InternalRequestAsync<CheckTransferClusterZoneResponse>(req, "CheckTransferClusterZone");
        }

        /// <summary>
        /// This API is used to check if it is possible to trigger cross-AZ migration.
        /// </summary>
        /// <param name="req"><see cref="CheckTransferClusterZoneRequest"/></param>
        /// <returns><see cref="CheckTransferClusterZoneResponse"/></returns>
        public CheckTransferClusterZoneResponse CheckTransferClusterZoneSync(CheckTransferClusterZoneRequest req)
        {
            return InternalRequestAsync<CheckTransferClusterZoneResponse>(req, "CheckTransferClusterZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to close the database audit service for TDSQL-C MySQL instances.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public Task<CloseAuditServiceResponse> CloseAuditService(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService");
        }

        /// <summary>
        /// This API is used to close the database audit service for TDSQL-C MySQL instances.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public CloseAuditServiceResponse CloseAuditServiceSync(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to close cluster password complexity.
        /// </summary>
        /// <param name="req"><see cref="CloseClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CloseClusterPasswordComplexityResponse"/></returns>
        public Task<CloseClusterPasswordComplexityResponse> CloseClusterPasswordComplexity(CloseClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CloseClusterPasswordComplexityResponse>(req, "CloseClusterPasswordComplexity");
        }

        /// <summary>
        /// This API is used to close cluster password complexity.
        /// </summary>
        /// <param name="req"><see cref="CloseClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CloseClusterPasswordComplexityResponse"/></returns>
        public CloseClusterPasswordComplexityResponse CloseClusterPasswordComplexitySync(CloseClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CloseClusterPasswordComplexityResponse>(req, "CloseClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to close the database proxy service of a cluster.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyRequest"/></param>
        /// <returns><see cref="CloseProxyResponse"/></returns>
        public Task<CloseProxyResponse> CloseProxy(CloseProxyRequest req)
        {
            return InternalRequestAsync<CloseProxyResponse>(req, "CloseProxy");
        }

        /// <summary>
        /// This API is used to close the database proxy service of a cluster.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyRequest"/></param>
        /// <returns><see cref="CloseProxyResponse"/></returns>
        public CloseProxyResponse CloseProxySync(CloseProxyRequest req)
        {
            return InternalRequestAsync<CloseProxyResponse>(req, "CloseProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to close the database proxy connection address.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyEndPointRequest"/></param>
        /// <returns><see cref="CloseProxyEndPointResponse"/></returns>
        public Task<CloseProxyEndPointResponse> CloseProxyEndPoint(CloseProxyEndPointRequest req)
        {
            return InternalRequestAsync<CloseProxyEndPointResponse>(req, "CloseProxyEndPoint");
        }

        /// <summary>
        /// This API is used to close the database proxy connection address.
        /// </summary>
        /// <param name="req"><see cref="CloseProxyEndPointRequest"/></param>
        /// <returns><see cref="CloseProxyEndPointResponse"/></returns>
        public CloseProxyEndPointResponse CloseProxyEndPointSync(CloseProxyEndPointRequest req)
        {
            return InternalRequestAsync<CloseProxyEndPointResponse>(req, "CloseProxyEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable SSL encryption.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public Task<CloseSSLResponse> CloseSSL(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL");
        }

        /// <summary>
        /// This API is used to disable SSL encryption.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public CloseSSLResponse CloseSSLSync(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (CloseWan) is used to disable public network.
        /// </summary>
        /// <param name="req"><see cref="CloseWanRequest"/></param>
        /// <returns><see cref="CloseWanResponse"/></returns>
        public Task<CloseWanResponse> CloseWan(CloseWanRequest req)
        {
            return InternalRequestAsync<CloseWanResponse>(req, "CloseWan");
        }

        /// <summary>
        /// This interface (CloseWan) is used to disable public network.
        /// </summary>
        /// <param name="req"><see cref="CloseWanRequest"/></param>
        /// <returns><see cref="CloseWanResponse"/></returns>
        public CloseWanResponse CloseWanSync(CloseWanRequest req)
        {
            return InternalRequestAsync<CloseWanResponse>(req, "CloseWan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Copy backup files to the designated safe
        /// </summary>
        /// <param name="req"><see cref="CopyBackupToVaultRequest"/></param>
        /// <returns><see cref="CopyBackupToVaultResponse"/></returns>
        public Task<CopyBackupToVaultResponse> CopyBackupToVault(CopyBackupToVaultRequest req)
        {
            return InternalRequestAsync<CopyBackupToVaultResponse>(req, "CopyBackupToVault");
        }

        /// <summary>
        /// Copy backup files to the designated safe
        /// </summary>
        /// <param name="req"><see cref="CopyBackupToVaultRequest"/></param>
        /// <returns><see cref="CopyBackupToVaultResponse"/></returns>
        public CopyBackupToVaultResponse CopyBackupToVaultSync(CopyBackupToVaultRequest req)
        {
            return InternalRequestAsync<CopyBackupToVaultResponse>(req, "CopyBackupToVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to copy the password complexity of a replication cluster.
        /// </summary>
        /// <param name="req"><see cref="CopyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CopyClusterPasswordComplexityResponse"/></returns>
        public Task<CopyClusterPasswordComplexityResponse> CopyClusterPasswordComplexity(CopyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CopyClusterPasswordComplexityResponse>(req, "CopyClusterPasswordComplexity");
        }

        /// <summary>
        /// This API is used to copy the password complexity of a replication cluster.
        /// </summary>
        /// <param name="req"><see cref="CopyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="CopyClusterPasswordComplexityResponse"/></returns>
        public CopyClusterPasswordComplexityResponse CopyClusterPasswordComplexitySync(CopyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<CopyClusterPasswordComplexityResponse>(req, "CopyClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create user accounts.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public Task<CreateAccountsResponse> CreateAccounts(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts");
        }

        /// <summary>
        /// This API is used to create user accounts.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public CreateAccountsResponse CreateAccountsSync(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public Task<CreateAuditRuleTemplateResponse> CreateAuditRuleTemplate(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate");
        }

        /// <summary>
        /// This API is used to create audit rule templates.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public CreateAuditRuleTemplateResponse CreateAuditRuleTemplateSync(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a manual backup for a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// This API is used to create a manual backup for a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create log delivery.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSDeliveryRequest"/></param>
        /// <returns><see cref="CreateCLSDeliveryResponse"/></returns>
        public Task<CreateCLSDeliveryResponse> CreateCLSDelivery(CreateCLSDeliveryRequest req)
        {
            return InternalRequestAsync<CreateCLSDeliveryResponse>(req, "CreateCLSDelivery");
        }

        /// <summary>
        /// This API is used to create log delivery.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSDeliveryRequest"/></param>
        /// <returns><see cref="CreateCLSDeliveryResponse"/></returns>
        public CreateCLSDeliveryResponse CreateCLSDeliverySync(CreateCLSDeliveryRequest req)
        {
            return InternalRequestAsync<CreateCLSDeliveryResponse>(req, "CreateCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a database.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterDatabaseRequest"/></param>
        /// <returns><see cref="CreateClusterDatabaseResponse"/></returns>
        public Task<CreateClusterDatabaseResponse> CreateClusterDatabase(CreateClusterDatabaseRequest req)
        {
            return InternalRequestAsync<CreateClusterDatabaseResponse>(req, "CreateClusterDatabase");
        }

        /// <summary>
        /// This API is used to create a database.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterDatabaseRequest"/></param>
        /// <returns><see cref="CreateClusterDatabaseResponse"/></returns>
        public CreateClusterDatabaseResponse CreateClusterDatabaseSync(CreateClusterDatabaseRequest req)
        {
            return InternalRequestAsync<CreateClusterDatabaseResponse>(req, "CreateClusterDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase new clusters.
        /// </summary>
        /// <param name="req"><see cref="CreateClustersRequest"/></param>
        /// <returns><see cref="CreateClustersResponse"/></returns>
        public Task<CreateClustersResponse> CreateClusters(CreateClustersRequest req)
        {
            return InternalRequestAsync<CreateClustersResponse>(req, "CreateClusters");
        }

        /// <summary>
        /// This API is used to purchase new clusters.
        /// </summary>
        /// <param name="req"><see cref="CreateClustersRequest"/></param>
        /// <returns><see cref="CreateClustersResponse"/></returns>
        public CreateClustersResponse CreateClustersSync(CreateClustersRequest req)
        {
            return InternalRequestAsync<CreateClustersResponse>(req, "CreateClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a newly purchased cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrateClusterRequest"/></param>
        /// <returns><see cref="CreateIntegrateClusterResponse"/></returns>
        public Task<CreateIntegrateClusterResponse> CreateIntegrateCluster(CreateIntegrateClusterRequest req)
        {
            return InternalRequestAsync<CreateIntegrateClusterResponse>(req, "CreateIntegrateCluster");
        }

        /// <summary>
        /// This API is used to create a newly purchased cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrateClusterRequest"/></param>
        /// <returns><see cref="CreateIntegrateClusterResponse"/></returns>
        public CreateIntegrateClusterResponse CreateIntegrateClusterSync(CreateIntegrateClusterRequest req)
        {
            return InternalRequestAsync<CreateIntegrateClusterResponse>(req, "CreateIntegrateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an analysis cluster account.
        /// </summary>
        /// <param name="req"><see cref="CreateLibraDBClusterAccountsRequest"/></param>
        /// <returns><see cref="CreateLibraDBClusterAccountsResponse"/></returns>
        public Task<CreateLibraDBClusterAccountsResponse> CreateLibraDBClusterAccounts(CreateLibraDBClusterAccountsRequest req)
        {
            return InternalRequestAsync<CreateLibraDBClusterAccountsResponse>(req, "CreateLibraDBClusterAccounts");
        }

        /// <summary>
        /// This API is used to create an analysis cluster account.
        /// </summary>
        /// <param name="req"><see cref="CreateLibraDBClusterAccountsRequest"/></param>
        /// <returns><see cref="CreateLibraDBClusterAccountsResponse"/></returns>
        public CreateLibraDBClusterAccountsResponse CreateLibraDBClusterAccountsSync(CreateLibraDBClusterAccountsRequest req)
        {
            return InternalRequestAsync<CreateLibraDBClusterAccountsResponse>(req, "CreateLibraDBClusterAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TDSQL-C analysis cluster
        /// </summary>
        /// <param name="req"><see cref="CreateLibraDBClustersRequest"/></param>
        /// <returns><see cref="CreateLibraDBClustersResponse"/></returns>
        public Task<CreateLibraDBClustersResponse> CreateLibraDBClusters(CreateLibraDBClustersRequest req)
        {
            return InternalRequestAsync<CreateLibraDBClustersResponse>(req, "CreateLibraDBClusters");
        }

        /// <summary>
        /// This API is used to create a TDSQL-C analysis cluster
        /// </summary>
        /// <param name="req"><see cref="CreateLibraDBClustersRequest"/></param>
        /// <returns><see cref="CreateLibraDBClustersResponse"/></returns>
        public CreateLibraDBClustersResponse CreateLibraDBClustersSync(CreateLibraDBClustersRequest req)
        {
            return InternalRequestAsync<CreateLibraDBClustersResponse>(req, "CreateLibraDBClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create parameter templates.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate");
        }

        /// <summary>
        /// This API is used to create parameter templates.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the database proxy of a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public Task<CreateProxyResponse> CreateProxy(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy");
        }

        /// <summary>
        /// This API is used to enable the database proxy of a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public CreateProxyResponse CreateProxySync(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a database proxy connection point.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyEndPointRequest"/></param>
        /// <returns><see cref="CreateProxyEndPointResponse"/></returns>
        public Task<CreateProxyEndPointResponse> CreateProxyEndPoint(CreateProxyEndPointRequest req)
        {
            return InternalRequestAsync<CreateProxyEndPointResponse>(req, "CreateProxyEndPoint");
        }

        /// <summary>
        /// This API is used to create a database proxy connection point.
        /// </summary>
        /// <param name="req"><see cref="CreateProxyEndPointRequest"/></param>
        /// <returns><see cref="CreateProxyEndPointResponse"/></returns>
        public CreateProxyEndPointResponse CreateProxyEndPointSync(CreateProxyEndPointRequest req)
        {
            return InternalRequestAsync<CreateProxyEndPointResponse>(req, "CreateProxyEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase new resource packets.
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePackageRequest"/></param>
        /// <returns><see cref="CreateResourcePackageResponse"/></returns>
        public Task<CreateResourcePackageResponse> CreateResourcePackage(CreateResourcePackageRequest req)
        {
            return InternalRequestAsync<CreateResourcePackageResponse>(req, "CreateResourcePackage");
        }

        /// <summary>
        /// This API is used to purchase new resource packets.
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePackageRequest"/></param>
        /// <returns><see cref="CreateResourcePackageResponse"/></returns>
        public CreateResourcePackageResponse CreateResourcePackageSync(CreateResourcePackageRequest req)
        {
            return InternalRequestAsync<CreateResourcePackageResponse>(req, "CreateResourcePackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a backup safe
        /// </summary>
        /// <param name="req"><see cref="CreateVaultRequest"/></param>
        /// <returns><see cref="CreateVaultResponse"/></returns>
        public Task<CreateVaultResponse> CreateVault(CreateVaultRequest req)
        {
            return InternalRequestAsync<CreateVaultResponse>(req, "CreateVault");
        }

        /// <summary>
        /// Create a backup safe
        /// </summary>
        /// <param name="req"><see cref="CreateVaultRequest"/></param>
        /// <returns><see cref="CreateVaultResponse"/></returns>
        public CreateVaultResponse CreateVaultSync(CreateVaultRequest req)
        {
            return InternalRequestAsync<CreateVaultResponse>(req, "CreateVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete user accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public Task<DeleteAccountsResponse> DeleteAccounts(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts");
        }

        /// <summary>
        /// This API is used to delete user accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public DeleteAccountsResponse DeleteAccountsSync(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts")
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
        /// This API is used to delete manual backups for a cluster. Automatic backups cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public Task<DeleteBackupResponse> DeleteBackup(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup");
        }

        /// <summary>
        /// This API is used to delete manual backups for a cluster. Automatic backups cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public DeleteBackupResponse DeleteBackupSync(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete specified backup files from the safe
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupVaultRequest"/></param>
        /// <returns><see cref="DeleteBackupVaultResponse"/></returns>
        public Task<DeleteBackupVaultResponse> DeleteBackupVault(DeleteBackupVaultRequest req)
        {
            return InternalRequestAsync<DeleteBackupVaultResponse>(req, "DeleteBackupVault");
        }

        /// <summary>
        /// Delete specified backup files from the safe
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupVaultRequest"/></param>
        /// <returns><see cref="DeleteBackupVaultResponse"/></returns>
        public DeleteBackupVaultResponse DeleteBackupVaultSync(DeleteBackupVaultRequest req)
        {
            return InternalRequestAsync<DeleteBackupVaultResponse>(req, "DeleteBackupVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete log delivery.
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSDeliveryRequest"/></param>
        /// <returns><see cref="DeleteCLSDeliveryResponse"/></returns>
        public Task<DeleteCLSDeliveryResponse> DeleteCLSDelivery(DeleteCLSDeliveryRequest req)
        {
            return InternalRequestAsync<DeleteCLSDeliveryResponse>(req, "DeleteCLSDelivery");
        }

        /// <summary>
        /// This API is used to delete log delivery.
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSDeliveryRequest"/></param>
        /// <returns><see cref="DeleteCLSDeliveryResponse"/></returns>
        public DeleteCLSDeliveryResponse DeleteCLSDeliverySync(DeleteCLSDeliveryRequest req)
        {
            return InternalRequestAsync<DeleteCLSDeliveryResponse>(req, "DeleteCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface is used to delete a database.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterDatabaseRequest"/></param>
        /// <returns><see cref="DeleteClusterDatabaseResponse"/></returns>
        public Task<DeleteClusterDatabaseResponse> DeleteClusterDatabase(DeleteClusterDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteClusterDatabaseResponse>(req, "DeleteClusterDatabase");
        }

        /// <summary>
        /// This interface is used to delete a database.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterDatabaseRequest"/></param>
        /// <returns><see cref="DeleteClusterDatabaseResponse"/></returns>
        public DeleteClusterDatabaseResponse DeleteClusterDatabaseSync(DeleteClusterDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteClusterDatabaseResponse>(req, "DeleteClusterDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete residual backups for cluster deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterSaveBackupRequest"/></param>
        /// <returns><see cref="DeleteClusterSaveBackupResponse"/></returns>
        public Task<DeleteClusterSaveBackupResponse> DeleteClusterSaveBackup(DeleteClusterSaveBackupRequest req)
        {
            return InternalRequestAsync<DeleteClusterSaveBackupResponse>(req, "DeleteClusterSaveBackup");
        }

        /// <summary>
        /// This API is used to delete residual backups for cluster deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterSaveBackupRequest"/></param>
        /// <returns><see cref="DeleteClusterSaveBackupResponse"/></returns>
        public DeleteClusterSaveBackupResponse DeleteClusterSaveBackupSync(DeleteClusterSaveBackupRequest req)
        {
            return InternalRequestAsync<DeleteClusterSaveBackupResponse>(req, "DeleteClusterSaveBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deleting a TDSQL-C Analysis Cluster
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraDBClusterRequest"/></param>
        /// <returns><see cref="DeleteLibraDBClusterResponse"/></returns>
        public Task<DeleteLibraDBClusterResponse> DeleteLibraDBCluster(DeleteLibraDBClusterRequest req)
        {
            return InternalRequestAsync<DeleteLibraDBClusterResponse>(req, "DeleteLibraDBCluster");
        }

        /// <summary>
        /// Deleting a TDSQL-C Analysis Cluster
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraDBClusterRequest"/></param>
        /// <returns><see cref="DeleteLibraDBClusterResponse"/></returns>
        public DeleteLibraDBClusterResponse DeleteLibraDBClusterSync(DeleteLibraDBClusterRequest req)
        {
            return InternalRequestAsync<DeleteLibraDBClusterResponse>(req, "DeleteLibraDBCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete cluster accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraDBClusterAccountsRequest"/></param>
        /// <returns><see cref="DeleteLibraDBClusterAccountsResponse"/></returns>
        public Task<DeleteLibraDBClusterAccountsResponse> DeleteLibraDBClusterAccounts(DeleteLibraDBClusterAccountsRequest req)
        {
            return InternalRequestAsync<DeleteLibraDBClusterAccountsResponse>(req, "DeleteLibraDBClusterAccounts");
        }

        /// <summary>
        /// This API is used to delete cluster accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraDBClusterAccountsRequest"/></param>
        /// <returns><see cref="DeleteLibraDBClusterAccountsResponse"/></returns>
        public DeleteLibraDBClusterAccountsResponse DeleteLibraDBClusterAccountsSync(DeleteLibraDBClusterAccountsRequest req)
        {
            return InternalRequestAsync<DeleteLibraDBClusterAccountsResponse>(req, "DeleteLibraDBClusterAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate");
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bulk deletion of backup safes
        /// </summary>
        /// <param name="req"><see cref="DeleteVaultsRequest"/></param>
        /// <returns><see cref="DeleteVaultsResponse"/></returns>
        public Task<DeleteVaultsResponse> DeleteVaults(DeleteVaultsRequest req)
        {
            return InternalRequestAsync<DeleteVaultsResponse>(req, "DeleteVaults");
        }

        /// <summary>
        /// Bulk deletion of backup safes
        /// </summary>
        /// <param name="req"><see cref="DeleteVaultsRequest"/></param>
        /// <returns><see cref="DeleteVaultsResponse"/></returns>
        public DeleteVaultsResponse DeleteVaultsSync(DeleteVaultsRequest req)
        {
            return InternalRequestAsync<DeleteVaultsResponse>(req, "DeleteVaults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query account privileges.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// This API is used to query account privileges.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the database account list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// This API is used to query the database account list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the instance list of database audit.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// This API is used to obtain the instance list of database audit.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query audit rule template information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public Task<DescribeAuditRuleTemplatesResponse> DescribeAuditRuleTemplates(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates");
        }

        /// <summary>
        /// This API is used to query audit rule template information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public DescribeAuditRuleTemplatesResponse DescribeAuditRuleTemplatesSync(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the audit rules of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleWithInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleWithInstanceIdsResponse"/></returns>
        public Task<DescribeAuditRuleWithInstanceIdsResponse> DescribeAuditRuleWithInstanceIds(DescribeAuditRuleWithInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleWithInstanceIdsResponse>(req, "DescribeAuditRuleWithInstanceIds");
        }

        /// <summary>
        /// This API is used to obtain the audit rules of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleWithInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleWithInstanceIdsResponse"/></returns>
        public DescribeAuditRuleWithInstanceIdsResponse DescribeAuditRuleWithInstanceIdsSync(DescribeAuditRuleWithInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleWithInstanceIdsResponse>(req, "DescribeAuditRuleWithInstanceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the backup configuration information of a specified cluster, including the full backup time period and the backup file retention time.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public Task<DescribeBackupConfigResponse> DescribeBackupConfig(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig");
        }

        /// <summary>
        /// This API is used to obtain the backup configuration information of a specified cluster, including the full backup time period and the backup file retention time.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public DescribeBackupConfigResponse DescribeBackupConfigSync(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download source limit of the default backup configured by the user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to query the download source limit of the default backup configured by the user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download link of cluster backup files.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadUrlResponse"/></returns>
        public Task<DescribeBackupDownloadUrlResponse> DescribeBackupDownloadUrl(DescribeBackupDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadUrlResponse>(req, "DescribeBackupDownloadUrl");
        }

        /// <summary>
        /// This API is used to query the download link of cluster backup files.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadUrlResponse"/></returns>
        public DescribeBackupDownloadUrlResponse DescribeBackupDownloadUrlSync(DescribeBackupDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadUrlResponse>(req, "DescribeBackupDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the default backup download access restrictions of user-level settings in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadUserRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadUserRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadUserRestrictionResponse> DescribeBackupDownloadUserRestriction(DescribeBackupDownloadUserRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadUserRestrictionResponse>(req, "DescribeBackupDownloadUserRestriction");
        }

        /// <summary>
        /// This API is used to query the default backup download access restrictions of user-level settings in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadUserRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadUserRestrictionResponse"/></returns>
        public DescribeBackupDownloadUserRestrictionResponse DescribeBackupDownloadUserRestrictionSync(DescribeBackupDownloadUserRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadUserRestrictionResponse>(req, "DescribeBackupDownloadUserRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup file list of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListRequest"/></param>
        /// <returns><see cref="DescribeBackupListResponse"/></returns>
        public Task<DescribeBackupListResponse> DescribeBackupList(DescribeBackupListRequest req)
        {
            return InternalRequestAsync<DescribeBackupListResponse>(req, "DescribeBackupList");
        }

        /// <summary>
        /// This API is used to query the backup file list of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListRequest"/></param>
        /// <returns><see cref="DescribeBackupListResponse"/></returns>
        public DescribeBackupListResponse DescribeBackupListSync(DescribeBackupListRequest req)
        {
            return InternalRequestAsync<DescribeBackupListResponse>(req, "DescribeBackupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query backup file list based on safe ID
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListByVaultRequest"/></param>
        /// <returns><see cref="DescribeBackupListByVaultResponse"/></returns>
        public Task<DescribeBackupListByVaultResponse> DescribeBackupListByVault(DescribeBackupListByVaultRequest req)
        {
            return InternalRequestAsync<DescribeBackupListByVaultResponse>(req, "DescribeBackupListByVault");
        }

        /// <summary>
        /// Query backup file list based on safe ID
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListByVaultRequest"/></param>
        /// <returns><see cref="DescribeBackupListByVaultResponse"/></returns>
        public DescribeBackupListByVaultResponse DescribeBackupListByVaultSync(DescribeBackupListByVaultRequest req)
        {
            return InternalRequestAsync<DescribeBackupListByVaultResponse>(req, "DescribeBackupListByVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query binlog configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeBinlogConfigResponse"/></returns>
        public Task<DescribeBinlogConfigResponse> DescribeBinlogConfig(DescribeBinlogConfigRequest req)
        {
            return InternalRequestAsync<DescribeBinlogConfigResponse>(req, "DescribeBinlogConfig");
        }

        /// <summary>
        /// This API is used to query binlog configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeBinlogConfigResponse"/></returns>
        public DescribeBinlogConfigResponse DescribeBinlogConfigSync(DescribeBinlogConfigRequest req)
        {
            return InternalRequestAsync<DescribeBinlogConfigResponse>(req, "DescribeBinlogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download address of Binlog.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBinlogDownloadUrlResponse"/></returns>
        public Task<DescribeBinlogDownloadUrlResponse> DescribeBinlogDownloadUrl(DescribeBinlogDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBinlogDownloadUrlResponse>(req, "DescribeBinlogDownloadUrl");
        }

        /// <summary>
        /// This API is used to query the download address of Binlog.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBinlogDownloadUrlResponse"/></returns>
        public DescribeBinlogDownloadUrlResponse DescribeBinlogDownloadUrlSync(DescribeBinlogDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBinlogDownloadUrlResponse>(req, "DescribeBinlogDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query binlog backups in the insurance box
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogListByVaultRequest"/></param>
        /// <returns><see cref="DescribeBinlogListByVaultResponse"/></returns>
        public Task<DescribeBinlogListByVaultResponse> DescribeBinlogListByVault(DescribeBinlogListByVaultRequest req)
        {
            return InternalRequestAsync<DescribeBinlogListByVaultResponse>(req, "DescribeBinlogListByVault");
        }

        /// <summary>
        /// Query binlog backups in the insurance box
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogListByVaultRequest"/></param>
        /// <returns><see cref="DescribeBinlogListByVaultResponse"/></returns>
        public DescribeBinlogListByVaultResponse DescribeBinlogListByVaultSync(DescribeBinlogListByVaultRequest req)
        {
            return InternalRequestAsync<DescribeBinlogListByVaultResponse>(req, "DescribeBinlogListByVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the binlog retention period of a cluster in days.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="DescribeBinlogSaveDaysResponse"/></returns>
        public Task<DescribeBinlogSaveDaysResponse> DescribeBinlogSaveDays(DescribeBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<DescribeBinlogSaveDaysResponse>(req, "DescribeBinlogSaveDays");
        }

        /// <summary>
        /// This API is used to query the binlog retention period of a cluster in days.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="DescribeBinlogSaveDaysResponse"/></returns>
        public DescribeBinlogSaveDaysResponse DescribeBinlogSaveDaysSync(DescribeBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<DescribeBinlogSaveDaysResponse>(req, "DescribeBinlogSaveDays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (DescribeBinlogs) queries the cluster binlog list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public Task<DescribeBinlogsResponse> DescribeBinlogs(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs");
        }

        /// <summary>
        /// This interface (DescribeBinlogs) queries the cluster binlog list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public DescribeBinlogsResponse DescribeBinlogsSync(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// this interface is used for querying parameter comparison after specification adjustment.
        /// </summary>
        /// <param name="req"><see cref="DescribeChangedParamsAfterUpgradeRequest"/></param>
        /// <returns><see cref="DescribeChangedParamsAfterUpgradeResponse"/></returns>
        public Task<DescribeChangedParamsAfterUpgradeResponse> DescribeChangedParamsAfterUpgrade(DescribeChangedParamsAfterUpgradeRequest req)
        {
            return InternalRequestAsync<DescribeChangedParamsAfterUpgradeResponse>(req, "DescribeChangedParamsAfterUpgrade");
        }

        /// <summary>
        /// this interface is used for querying parameter comparison after specification adjustment.
        /// </summary>
        /// <param name="req"><see cref="DescribeChangedParamsAfterUpgradeRequest"/></param>
        /// <returns><see cref="DescribeChangedParamsAfterUpgradeResponse"/></returns>
        public DescribeChangedParamsAfterUpgradeResponse DescribeChangedParamsAfterUpgradeSync(DescribeChangedParamsAfterUpgradeRequest req)
        {
            return InternalRequestAsync<DescribeChangedParamsAfterUpgradeResponse>(req, "DescribeChangedParamsAfterUpgrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the table list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDatabaseTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterDatabaseTablesResponse"/></returns>
        public Task<DescribeClusterDatabaseTablesResponse> DescribeClusterDatabaseTables(DescribeClusterDatabaseTablesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDatabaseTablesResponse>(req, "DescribeClusterDatabaseTables");
        }

        /// <summary>
        /// This API is used to access the table list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDatabaseTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterDatabaseTablesResponse"/></returns>
        public DescribeClusterDatabaseTablesResponse DescribeClusterDatabaseTablesSync(DescribeClusterDatabaseTablesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDatabaseTablesResponse>(req, "DescribeClusterDatabaseTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain cluster database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDatabasesResponse"/></returns>
        public Task<DescribeClusterDatabasesResponse> DescribeClusterDatabases(DescribeClusterDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDatabasesResponse>(req, "DescribeClusterDatabases");
        }

        /// <summary>
        /// This API is used to obtain cluster database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDatabasesResponse"/></returns>
        public DescribeClusterDatabasesResponse DescribeClusterDatabasesSync(DescribeClusterDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDatabasesResponse>(req, "DescribeClusterDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display cluster details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail");
        }

        /// <summary>
        /// This API is used to display cluster details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailDatabasesResponse"/></returns>
        public Task<DescribeClusterDetailDatabasesResponse> DescribeClusterDetailDatabases(DescribeClusterDetailDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailDatabasesResponse>(req, "DescribeClusterDetailDatabases");
        }

        /// <summary>
        /// This API is used to query database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailDatabasesRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailDatabasesResponse"/></returns>
        public DescribeClusterDetailDatabasesResponse DescribeClusterDetailDatabasesSync(DescribeClusterDetailDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailDatabasesResponse>(req, "DescribeClusterDetailDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGrpsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGrpsResponse"/></returns>
        public Task<DescribeClusterInstanceGrpsResponse> DescribeClusterInstanceGrps(DescribeClusterInstanceGrpsRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstanceGrpsResponse>(req, "DescribeClusterInstanceGrps");
        }

        /// <summary>
        /// This API is used to query instance groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGrpsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGrpsResponse"/></returns>
        public DescribeClusterInstanceGrpsResponse DescribeClusterInstanceGrpsSync(DescribeClusterInstanceGrpsRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstanceGrpsResponse>(req, "DescribeClusterInstanceGrps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterParamsRequest"/></param>
        /// <returns><see cref="DescribeClusterParamsResponse"/></returns>
        public Task<DescribeClusterParamsResponse> DescribeClusterParams(DescribeClusterParamsRequest req)
        {
            return InternalRequestAsync<DescribeClusterParamsResponse>(req, "DescribeClusterParams");
        }

        /// <summary>
        /// This API is used to query cluster parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterParamsRequest"/></param>
        /// <returns><see cref="DescribeClusterParamsResponse"/></returns>
        public DescribeClusterParamsResponse DescribeClusterParamsSync(DescribeClusterParamsRequest req)
        {
            return InternalRequestAsync<DescribeClusterParamsResponse>(req, "DescribeClusterParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the cluster password complexity details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="DescribeClusterPasswordComplexityResponse"/></returns>
        public Task<DescribeClusterPasswordComplexityResponse> DescribeClusterPasswordComplexity(DescribeClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<DescribeClusterPasswordComplexityResponse>(req, "DescribeClusterPasswordComplexity");
        }

        /// <summary>
        /// This API is used to view the cluster password complexity details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="DescribeClusterPasswordComplexityResponse"/></returns>
        public DescribeClusterPasswordComplexityResponse DescribeClusterPasswordComplexitySync(DescribeClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<DescribeClusterPasswordComplexityResponse>(req, "DescribeClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cluster read-only switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReadOnlyRequest"/></param>
        /// <returns><see cref="DescribeClusterReadOnlyResponse"/></returns>
        public Task<DescribeClusterReadOnlyResponse> DescribeClusterReadOnly(DescribeClusterReadOnlyRequest req)
        {
            return InternalRequestAsync<DescribeClusterReadOnlyResponse>(req, "DescribeClusterReadOnly");
        }

        /// <summary>
        /// This API is used to query the cluster read-only switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReadOnlyRequest"/></param>
        /// <returns><see cref="DescribeClusterReadOnlyResponse"/></returns>
        public DescribeClusterReadOnlyResponse DescribeClusterReadOnlySync(DescribeClusterReadOnlyRequest req)
        {
            return InternalRequestAsync<DescribeClusterReadOnlyResponse>(req, "DescribeClusterReadOnly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster transparent encryption information.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTransparentEncryptInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterTransparentEncryptInfoResponse"/></returns>
        public Task<DescribeClusterTransparentEncryptInfoResponse> DescribeClusterTransparentEncryptInfo(DescribeClusterTransparentEncryptInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterTransparentEncryptInfoResponse>(req, "DescribeClusterTransparentEncryptInfo");
        }

        /// <summary>
        /// This API is used to query cluster transparent encryption information.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTransparentEncryptInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterTransparentEncryptInfoResponse"/></returns>
        public DescribeClusterTransparentEncryptInfoResponse DescribeClusterTransparentEncryptInfoSync(DescribeClusterTransparentEncryptInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterTransparentEncryptInfoResponse>(req, "DescribeClusterTransparentEncryptInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// This API is used to describe clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
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
        /// This API is used to query task flow information.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow");
        }

        /// <summary>
        /// This API is used to query task flow information.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance log delivery information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCLSLogDeliveryRequest"/></param>
        /// <returns><see cref="DescribeInstanceCLSLogDeliveryResponse"/></returns>
        public Task<DescribeInstanceCLSLogDeliveryResponse> DescribeInstanceCLSLogDelivery(DescribeInstanceCLSLogDeliveryRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCLSLogDeliveryResponse>(req, "DescribeInstanceCLSLogDelivery");
        }

        /// <summary>
        /// This API is used to query instance log delivery information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCLSLogDeliveryRequest"/></param>
        /// <returns><see cref="DescribeInstanceCLSLogDeliveryResponse"/></returns>
        public DescribeInstanceCLSLogDeliveryResponse DescribeInstanceCLSLogDeliverySync(DescribeInstanceCLSLogDeliveryRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCLSLogDeliveryResponse>(req, "DescribeInstanceCLSLogDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public Task<DescribeInstanceDetailResponse> DescribeInstanceDetail(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail");
        }

        /// <summary>
        /// This API is used to query instance details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public DescribeInstanceDetailResponse DescribeInstanceDetailSync(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of instance error logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceErrorLogsResponse"/></returns>
        public Task<DescribeInstanceErrorLogsResponse> DescribeInstanceErrorLogs(DescribeInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceErrorLogsResponse>(req, "DescribeInstanceErrorLogs");
        }

        /// <summary>
        /// This API is used to query the list of instance error logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceErrorLogsResponse"/></returns>
        public DescribeInstanceErrorLogsResponse DescribeInstanceErrorLogsSync(DescribeInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceErrorLogsResponse>(req, "DescribeInstanceErrorLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance parameter list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// This API is used to query the instance parameter list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the slow log details of an instance. Subject to platform return size limits, return results may be truncated if they are too large.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceSlowQueriesResponse"/></returns>
        public Task<DescribeInstanceSlowQueriesResponse> DescribeInstanceSlowQueries(DescribeInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSlowQueriesResponse>(req, "DescribeInstanceSlowQueries");
        }

        /// <summary>
        /// This API is used to query the slow log details of an instance. Subject to platform return size limits, return results may be truncated if they are too large.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceSlowQueriesResponse"/></returns>
        public DescribeInstanceSlowQueriesResponse DescribeInstanceSlowQueriesSync(DescribeInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSlowQueriesResponse>(req, "DescribeInstanceSlowQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (DescribeInstanceSpecs) is used to query the instance specifications available for purchase on the query purchase page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsResponse"/></returns>
        public Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecs(DescribeInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSpecsResponse>(req, "DescribeInstanceSpecs");
        }

        /// <summary>
        /// This interface (DescribeInstanceSpecs) is used to query the instance specifications available for purchase on the query purchase page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsResponse"/></returns>
        public DescribeInstanceSpecsResponse DescribeInstanceSpecsSync(DescribeInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSpecsResponse>(req, "DescribeInstanceSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query instance specifications based on operation type
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsByOperationTypeRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsByOperationTypeResponse"/></returns>
        public Task<DescribeInstanceSpecsByOperationTypeResponse> DescribeInstanceSpecsByOperationType(DescribeInstanceSpecsByOperationTypeRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSpecsByOperationTypeResponse>(req, "DescribeInstanceSpecsByOperationType");
        }

        /// <summary>
        /// Query instance specifications based on operation type
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsByOperationTypeRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsByOperationTypeResponse"/></returns>
        public DescribeInstanceSpecsByOperationTypeResponse DescribeInstanceSpecsByOperationTypeSync(DescribeInstanceSpecsByOperationTypeRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSpecsByOperationTypeResponse>(req, "DescribeInstanceSpecsByOperationType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query the list of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance list under the same cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesWithinSameClusterRequest"/></param>
        /// <returns><see cref="DescribeInstancesWithinSameClusterResponse"/></returns>
        public Task<DescribeInstancesWithinSameClusterResponse> DescribeInstancesWithinSameCluster(DescribeInstancesWithinSameClusterRequest req)
        {
            return InternalRequestAsync<DescribeInstancesWithinSameClusterResponse>(req, "DescribeInstancesWithinSameCluster");
        }

        /// <summary>
        /// This API is used to query the instance list under the same cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesWithinSameClusterRequest"/></param>
        /// <returns><see cref="DescribeInstancesWithinSameClusterResponse"/></returns>
        public DescribeInstancesWithinSameClusterResponse DescribeInstancesWithinSameClusterSync(DescribeInstancesWithinSameClusterRequest req)
        {
            return InternalRequestAsync<DescribeInstancesWithinSameClusterResponse>(req, "DescribeInstancesWithinSameCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrateTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrateTaskResponse"/></returns>
        public Task<DescribeIntegrateTaskResponse> DescribeIntegrateTask(DescribeIntegrateTaskRequest req)
        {
            return InternalRequestAsync<DescribeIntegrateTaskResponse>(req, "DescribeIntegrateTask");
        }

        /// <summary>
        /// This API is used to query cluster tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrateTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrateTaskResponse"/></returns>
        public DescribeIntegrateTaskResponse DescribeIntegrateTaskSync(DescribeIntegrateTaskRequest req)
        {
            return InternalRequestAsync<DescribeIntegrateTaskResponse>(req, "DescribeIntegrateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface is used for querying the recycle bin instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIsolatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeIsolatedInstancesResponse"/></returns>
        public Task<DescribeIsolatedInstancesResponse> DescribeIsolatedInstances(DescribeIsolatedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeIsolatedInstancesResponse>(req, "DescribeIsolatedInstances");
        }

        /// <summary>
        /// This interface is used for querying the recycle bin instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIsolatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeIsolatedInstancesResponse"/></returns>
        public DescribeIsolatedInstancesResponse DescribeIsolatedInstancesSync(DescribeIsolatedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeIsolatedInstancesResponse>(req, "DescribeIsolatedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query and analyze all permissions of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAccountAllPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAccountAllPrivilegesResponse"/></returns>
        public Task<DescribeLibraDBClusterAccountAllPrivilegesResponse> DescribeLibraDBClusterAccountAllPrivileges(DescribeLibraDBClusterAccountAllPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAccountAllPrivilegesResponse>(req, "DescribeLibraDBClusterAccountAllPrivileges");
        }

        /// <summary>
        /// This API is used to query and analyze all permissions of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAccountAllPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAccountAllPrivilegesResponse"/></returns>
        public DescribeLibraDBClusterAccountAllPrivilegesResponse DescribeLibraDBClusterAccountAllPrivilegesSync(DescribeLibraDBClusterAccountAllPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAccountAllPrivilegesResponse>(req, "DescribeLibraDBClusterAccountAllPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the permissions of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAccountPrivilegesResponse"/></returns>
        public Task<DescribeLibraDBClusterAccountPrivilegesResponse> DescribeLibraDBClusterAccountPrivileges(DescribeLibraDBClusterAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAccountPrivilegesResponse>(req, "DescribeLibraDBClusterAccountPrivileges");
        }

        /// <summary>
        /// This API is used to query the permissions of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAccountPrivilegesResponse"/></returns>
        public DescribeLibraDBClusterAccountPrivilegesResponse DescribeLibraDBClusterAccountPrivilegesSync(DescribeLibraDBClusterAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAccountPrivilegesResponse>(req, "DescribeLibraDBClusterAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query and analyze cluster accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAccountsRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAccountsResponse"/></returns>
        public Task<DescribeLibraDBClusterAccountsResponse> DescribeLibraDBClusterAccounts(DescribeLibraDBClusterAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAccountsResponse>(req, "DescribeLibraDBClusterAccounts");
        }

        /// <summary>
        /// This API is used to query and analyze cluster accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAccountsRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAccountsResponse"/></returns>
        public DescribeLibraDBClusterAccountsResponse DescribeLibraDBClusterAccountsSync(DescribeLibraDBClusterAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAccountsResponse>(req, "DescribeLibraDBClusterAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the advanced mapping rule of the analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAutoMapRuleRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAutoMapRuleResponse"/></returns>
        public Task<DescribeLibraDBClusterAutoMapRuleResponse> DescribeLibraDBClusterAutoMapRule(DescribeLibraDBClusterAutoMapRuleRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAutoMapRuleResponse>(req, "DescribeLibraDBClusterAutoMapRule");
        }

        /// <summary>
        /// This API is used to view the advanced mapping rule of the analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterAutoMapRuleRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterAutoMapRuleResponse"/></returns>
        public DescribeLibraDBClusterAutoMapRuleResponse DescribeLibraDBClusterAutoMapRuleSync(DescribeLibraDBClusterAutoMapRuleRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterAutoMapRuleResponse>(req, "DescribeLibraDBClusterAutoMapRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query TDSQL-C analysis cluster information
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterDetailResponse"/></returns>
        public Task<DescribeLibraDBClusterDetailResponse> DescribeLibraDBClusterDetail(DescribeLibraDBClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterDetailResponse>(req, "DescribeLibraDBClusterDetail");
        }

        /// <summary>
        /// Query TDSQL-C analysis cluster information
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterDetailResponse"/></returns>
        public DescribeLibraDBClusterDetailResponse DescribeLibraDBClusterDetailSync(DescribeLibraDBClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterDetailResponse>(req, "DescribeLibraDBClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the database/table mapping relationship of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterTableMappingRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterTableMappingResponse"/></returns>
        public Task<DescribeLibraDBClusterTableMappingResponse> DescribeLibraDBClusterTableMapping(DescribeLibraDBClusterTableMappingRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterTableMappingResponse>(req, "DescribeLibraDBClusterTableMapping");
        }

        /// <summary>
        /// This API is used to view the database/table mapping relationship of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClusterTableMappingRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClusterTableMappingResponse"/></returns>
        public DescribeLibraDBClusterTableMappingResponse DescribeLibraDBClusterTableMappingSync(DescribeLibraDBClusterTableMappingRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClusterTableMappingResponse>(req, "DescribeLibraDBClusterTableMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the analysis cluster list
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClustersRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClustersResponse"/></returns>
        public Task<DescribeLibraDBClustersResponse> DescribeLibraDBClusters(DescribeLibraDBClustersRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClustersResponse>(req, "DescribeLibraDBClusters");
        }

        /// <summary>
        /// Query the analysis cluster list
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBClustersRequest"/></param>
        /// <returns><see cref="DescribeLibraDBClustersResponse"/></returns>
        public DescribeLibraDBClustersResponse DescribeLibraDBClustersSync(DescribeLibraDBClustersRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBClustersResponse>(req, "DescribeLibraDBClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the source instance information of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBDataSourceRequest"/></param>
        /// <returns><see cref="DescribeLibraDBDataSourceResponse"/></returns>
        public Task<DescribeLibraDBDataSourceResponse> DescribeLibraDBDataSource(DescribeLibraDBDataSourceRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBDataSourceResponse>(req, "DescribeLibraDBDataSource");
        }

        /// <summary>
        /// This API is used to query the source instance information of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBDataSourceRequest"/></param>
        /// <returns><see cref="DescribeLibraDBDataSourceResponse"/></returns>
        public DescribeLibraDBDataSourceResponse DescribeLibraDBDataSourceSync(DescribeLibraDBDataSourceRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBDataSourceResponse>(req, "DescribeLibraDBDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the analysis engine forwarding parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBForwardConfigRequest"/></param>
        /// <returns><see cref="DescribeLibraDBForwardConfigResponse"/></returns>
        public Task<DescribeLibraDBForwardConfigResponse> DescribeLibraDBForwardConfig(DescribeLibraDBForwardConfigRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBForwardConfigResponse>(req, "DescribeLibraDBForwardConfig");
        }

        /// <summary>
        /// This API is used to query the analysis engine forwarding parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBForwardConfigRequest"/></param>
        /// <returns><see cref="DescribeLibraDBForwardConfigResponse"/></returns>
        public DescribeLibraDBForwardConfigResponse DescribeLibraDBForwardConfigSync(DescribeLibraDBForwardConfigRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBForwardConfigResponse>(req, "DescribeLibraDBForwardConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query read-only analysis engine details.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeLibraDBInstanceDetailResponse"/></returns>
        public Task<DescribeLibraDBInstanceDetailResponse> DescribeLibraDBInstanceDetail(DescribeLibraDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBInstanceDetailResponse>(req, "DescribeLibraDBInstanceDetail");
        }

        /// <summary>
        /// This API is used to query read-only analysis engine details.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeLibraDBInstanceDetailResponse"/></returns>
        public DescribeLibraDBInstanceDetailResponse DescribeLibraDBInstanceDetailSync(DescribeLibraDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBInstanceDetailResponse>(req, "DescribeLibraDBInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the specification list of the read-only analysis engine supported in the region.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeLibraDBInstanceSpecsResponse"/></returns>
        public Task<DescribeLibraDBInstanceSpecsResponse> DescribeLibraDBInstanceSpecs(DescribeLibraDBInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBInstanceSpecsResponse>(req, "DescribeLibraDBInstanceSpecs");
        }

        /// <summary>
        /// This API is used to query the specification list of the read-only analysis engine supported in the region.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeLibraDBInstanceSpecsResponse"/></returns>
        public DescribeLibraDBInstanceSpecsResponse DescribeLibraDBInstanceSpecsSync(DescribeLibraDBInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBInstanceSpecsResponse>(req, "DescribeLibraDBInstanceSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query slow SQL details in the read-only analysis engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeLibraDBSlowLogsResponse"/></returns>
        public Task<DescribeLibraDBSlowLogsResponse> DescribeLibraDBSlowLogs(DescribeLibraDBSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBSlowLogsResponse>(req, "DescribeLibraDBSlowLogs");
        }

        /// <summary>
        /// This API is used to query slow SQL details in the read-only analysis engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeLibraDBSlowLogsResponse"/></returns>
        public DescribeLibraDBSlowLogsResponse DescribeLibraDBSlowLogsSync(DescribeLibraDBSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBSlowLogsResponse>(req, "DescribeLibraDBSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of supported versions for the read-only analysis engine
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBVersionRequest"/></param>
        /// <returns><see cref="DescribeLibraDBVersionResponse"/></returns>
        public Task<DescribeLibraDBVersionResponse> DescribeLibraDBVersion(DescribeLibraDBVersionRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBVersionResponse>(req, "DescribeLibraDBVersion");
        }

        /// <summary>
        /// Query the list of supported versions for the read-only analysis engine
        /// </summary>
        /// <param name="req"><see cref="DescribeLibraDBVersionRequest"/></param>
        /// <returns><see cref="DescribeLibraDBVersionResponse"/></returns>
        public DescribeLibraDBVersionResponse DescribeLibraDBVersionSync(DescribeLibraDBVersionRequest req)
        {
            return InternalRequestAsync<DescribeLibraDBVersionResponse>(req, "DescribeLibraDBVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (DescribeMaintainPeriod) is used to query the instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainPeriodRequest"/></param>
        /// <returns><see cref="DescribeMaintainPeriodResponse"/></returns>
        public Task<DescribeMaintainPeriodResponse> DescribeMaintainPeriod(DescribeMaintainPeriodRequest req)
        {
            return InternalRequestAsync<DescribeMaintainPeriodResponse>(req, "DescribeMaintainPeriod");
        }

        /// <summary>
        /// This interface (DescribeMaintainPeriod) is used to query the instance maintenance window.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainPeriodRequest"/></param>
        /// <returns><see cref="DescribeMaintainPeriodResponse"/></returns>
        public DescribeMaintainPeriodResponse DescribeMaintainPeriodSync(DescribeMaintainPeriodRequest req)
        {
            return InternalRequestAsync<DescribeMaintainPeriodResponse>(req, "DescribeMaintainPeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user parameter template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateDetailResponse"/></returns>
        public Task<DescribeParamTemplateDetailResponse> DescribeParamTemplateDetail(DescribeParamTemplateDetailRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateDetailResponse>(req, "DescribeParamTemplateDetail");
        }

        /// <summary>
        /// This API is used to query user parameter template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateDetailResponse"/></returns>
        public DescribeParamTemplateDetailResponse DescribeParamTemplateDetailSync(DescribeParamTemplateDetailRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateDetailResponse>(req, "DescribeParamTemplateDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all parameter template information under the user-specified product.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates");
        }

        /// <summary>
        /// This API is used to query all parameter template information under the user-specified product.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query project security group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// This API is used to query project security group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query agent list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public Task<DescribeProxiesResponse> DescribeProxies(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies");
        }

        /// <summary>
        /// This API is used to query agent list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public DescribeProxiesResponse DescribeProxiesSync(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of proxy nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyNodesRequest"/></param>
        /// <returns><see cref="DescribeProxyNodesResponse"/></returns>
        public Task<DescribeProxyNodesResponse> DescribeProxyNodes(DescribeProxyNodesRequest req)
        {
            return InternalRequestAsync<DescribeProxyNodesResponse>(req, "DescribeProxyNodes");
        }

        /// <summary>
        /// This API is used to query the list of proxy nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyNodesRequest"/></param>
        /// <returns><see cref="DescribeProxyNodesResponse"/></returns>
        public DescribeProxyNodesResponse DescribeProxyNodesSync(DescribeProxyNodesRequest req)
        {
            return InternalRequestAsync<DescribeProxyNodesResponse>(req, "DescribeProxyNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query database proxy specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySpecsRequest"/></param>
        /// <returns><see cref="DescribeProxySpecsResponse"/></returns>
        public Task<DescribeProxySpecsResponse> DescribeProxySpecs(DescribeProxySpecsRequest req)
        {
            return InternalRequestAsync<DescribeProxySpecsResponse>(req, "DescribeProxySpecs");
        }

        /// <summary>
        /// This API is used to query database proxy specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySpecsRequest"/></param>
        /// <returns><see cref="DescribeProxySpecsResponse"/></returns>
        public DescribeProxySpecsResponse DescribeProxySpecsSync(DescribeProxySpecsRequest req)
        {
            return InternalRequestAsync<DescribeProxySpecsResponse>(req, "DescribeProxySpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query RedoLog backups
        /// </summary>
        /// <param name="req"><see cref="DescribeRedoLogListByVaultRequest"/></param>
        /// <returns><see cref="DescribeRedoLogListByVaultResponse"/></returns>
        public Task<DescribeRedoLogListByVaultResponse> DescribeRedoLogListByVault(DescribeRedoLogListByVaultRequest req)
        {
            return InternalRequestAsync<DescribeRedoLogListByVaultResponse>(req, "DescribeRedoLogListByVault");
        }

        /// <summary>
        /// Query RedoLog backups
        /// </summary>
        /// <param name="req"><see cref="DescribeRedoLogListByVaultRequest"/></param>
        /// <returns><see cref="DescribeRedoLogListByVaultResponse"/></returns>
        public DescribeRedoLogListByVaultResponse DescribeRedoLogListByVaultSync(DescribeRedoLogListByVaultRequest req)
        {
            return InternalRequestAsync<DescribeRedoLogListByVaultResponse>(req, "DescribeRedoLogListByVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the redo log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRedoLogsRequest"/></param>
        /// <returns><see cref="DescribeRedoLogsResponse"/></returns>
        public Task<DescribeRedoLogsResponse> DescribeRedoLogs(DescribeRedoLogsRequest req)
        {
            return InternalRequestAsync<DescribeRedoLogsResponse>(req, "DescribeRedoLogs");
        }

        /// <summary>
        /// This API is used to query the redo log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRedoLogsRequest"/></param>
        /// <returns><see cref="DescribeRedoLogsResponse"/></returns>
        public DescribeRedoLogsResponse DescribeRedoLogsSync(DescribeRedoLogsRequest req)
        {
            return InternalRequestAsync<DescribeRedoLogsResponse>(req, "DescribeRedoLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query resource package usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageDetailRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageDetailResponse"/></returns>
        public Task<DescribeResourcePackageDetailResponse> DescribeResourcePackageDetail(DescribeResourcePackageDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageDetailResponse>(req, "DescribeResourcePackageDetail");
        }

        /// <summary>
        /// This API is used to query resource package usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageDetailRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageDetailResponse"/></returns>
        public DescribeResourcePackageDetailResponse DescribeResourcePackageDetailSync(DescribeResourcePackageDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageDetailResponse>(req, "DescribeResourcePackageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query resource package list.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageListRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageListResponse"/></returns>
        public Task<DescribeResourcePackageListResponse> DescribeResourcePackageList(DescribeResourcePackageListRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageListResponse>(req, "DescribeResourcePackageList");
        }

        /// <summary>
        /// This API is used to query resource package list.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageListRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageListResponse"/></returns>
        public DescribeResourcePackageListResponse DescribeResourcePackageListSync(DescribeResourcePackageListRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageListResponse>(req, "DescribeResourcePackageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query resource package specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageSaleSpecRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageSaleSpecResponse"/></returns>
        public Task<DescribeResourcePackageSaleSpecResponse> DescribeResourcePackageSaleSpec(DescribeResourcePackageSaleSpecRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageSaleSpecResponse>(req, "DescribeResourcePackageSaleSpec");
        }

        /// <summary>
        /// This API is used to query resource package specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcePackageSaleSpecRequest"/></param>
        /// <returns><see cref="DescribeResourcePackageSaleSpecResponse"/></returns>
        public DescribeResourcePackageSaleSpecResponse DescribeResourcePackageSaleSpecSync(DescribeResourcePackageSaleSpecRequest req)
        {
            return InternalRequestAsync<DescribeResourcePackageSaleSpecResponse>(req, "DescribeResourcePackageSaleSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (DescribeResourcesByDealName) is used to query order-associated instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public Task<DescribeResourcesByDealNameResponse> DescribeResourcesByDealName(DescribeResourcesByDealNameRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByDealNameResponse>(req, "DescribeResourcesByDealName");
        }

        /// <summary>
        /// This interface (DescribeResourcesByDealName) is used to query order-associated instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public DescribeResourcesByDealNameResponse DescribeResourcesByDealNameSync(DescribeResourcesByDealNameRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByDealNameResponse>(req, "DescribeResourcesByDealName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rollback time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeRangeResponse"/></returns>
        public Task<DescribeRollbackTimeRangeResponse> DescribeRollbackTimeRange(DescribeRollbackTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeRangeResponse>(req, "DescribeRollbackTimeRange");
        }

        /// <summary>
        /// This API is used to query the rollback time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeRangeResponse"/></returns>
        public DescribeRollbackTimeRangeResponse DescribeRollbackTimeRangeSync(DescribeRollbackTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeRangeResponse>(req, "DescribeRollbackTimeRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution plan details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSQLExecutionPlanRequest"/></param>
        /// <returns><see cref="DescribeSQLExecutionPlanResponse"/></returns>
        public Task<DescribeSQLExecutionPlanResponse> DescribeSQLExecutionPlan(DescribeSQLExecutionPlanRequest req)
        {
            return InternalRequestAsync<DescribeSQLExecutionPlanResponse>(req, "DescribeSQLExecutionPlan");
        }

        /// <summary>
        /// This API is used to query the execution plan details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSQLExecutionPlanRequest"/></param>
        /// <returns><see cref="DescribeSQLExecutionPlanResponse"/></returns>
        public DescribeSQLExecutionPlanResponse DescribeSQLExecutionPlanSync(DescribeSQLExecutionPlanRequest req)
        {
            return InternalRequestAsync<DescribeSQLExecutionPlanResponse>(req, "DescribeSQLExecutionPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query legacy backup cluster information.
        /// </summary>
        /// <param name="req"><see cref="DescribeSaveBackupClustersRequest"/></param>
        /// <returns><see cref="DescribeSaveBackupClustersResponse"/></returns>
        public Task<DescribeSaveBackupClustersResponse> DescribeSaveBackupClusters(DescribeSaveBackupClustersRequest req)
        {
            return InternalRequestAsync<DescribeSaveBackupClustersResponse>(req, "DescribeSaveBackupClusters");
        }

        /// <summary>
        /// This API is used to query legacy backup cluster information.
        /// </summary>
        /// <param name="req"><see cref="DescribeSaveBackupClustersRequest"/></param>
        /// <returns><see cref="DescribeSaveBackupClustersResponse"/></returns>
        public DescribeSaveBackupClustersResponse DescribeSaveBackupClustersSync(DescribeSaveBackupClustersRequest req)
        {
            return InternalRequestAsync<DescribeSaveBackupClustersResponse>(req, "DescribeSaveBackupClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query available specifications of Serverless instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeServerlessInstanceSpecsResponse"/></returns>
        public Task<DescribeServerlessInstanceSpecsResponse> DescribeServerlessInstanceSpecs(DescribeServerlessInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeServerlessInstanceSpecsResponse>(req, "DescribeServerlessInstanceSpecs");
        }

        /// <summary>
        /// This API is used to query available specifications of Serverless instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeServerlessInstanceSpecsResponse"/></returns>
        public DescribeServerlessInstanceSpecsResponse DescribeServerlessInstanceSpecsSync(DescribeServerlessInstanceSpecsRequest req)
        {
            return InternalRequestAsync<DescribeServerlessInstanceSpecsResponse>(req, "DescribeServerlessInstanceSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query serverless policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessStrategyRequest"/></param>
        /// <returns><see cref="DescribeServerlessStrategyResponse"/></returns>
        public Task<DescribeServerlessStrategyResponse> DescribeServerlessStrategy(DescribeServerlessStrategyRequest req)
        {
            return InternalRequestAsync<DescribeServerlessStrategyResponse>(req, "DescribeServerlessStrategy");
        }

        /// <summary>
        /// This API is used to query serverless policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessStrategyRequest"/></param>
        /// <returns><see cref="DescribeServerlessStrategyResponse"/></returns>
        public DescribeServerlessStrategyResponse DescribeServerlessStrategySync(DescribeServerlessStrategyRequest req)
        {
            return InternalRequestAsync<DescribeServerlessStrategyResponse>(req, "DescribeServerlessStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query from availability zones.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlaveZonesRequest"/></param>
        /// <returns><see cref="DescribeSlaveZonesResponse"/></returns>
        public Task<DescribeSlaveZonesResponse> DescribeSlaveZones(DescribeSlaveZonesRequest req)
        {
            return InternalRequestAsync<DescribeSlaveZonesResponse>(req, "DescribeSlaveZones");
        }

        /// <summary>
        /// This API is used to query from availability zones.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlaveZonesRequest"/></param>
        /// <returns><see cref="DescribeSlaveZonesResponse"/></returns>
        public DescribeSlaveZonesResponse DescribeSlaveZonesSync(DescribeSlaveZonesRequest req)
        {
            return InternalRequestAsync<DescribeSlaveZonesResponse>(req, "DescribeSlaveZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query supported database proxy versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportProxyVersionRequest"/></param>
        /// <returns><see cref="DescribeSupportProxyVersionResponse"/></returns>
        public Task<DescribeSupportProxyVersionResponse> DescribeSupportProxyVersion(DescribeSupportProxyVersionRequest req)
        {
            return InternalRequestAsync<DescribeSupportProxyVersionResponse>(req, "DescribeSupportProxyVersion");
        }

        /// <summary>
        /// This API is used to query supported database proxy versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportProxyVersionRequest"/></param>
        /// <returns><see cref="DescribeSupportProxyVersionResponse"/></returns>
        public DescribeSupportProxyVersionResponse DescribeSupportProxyVersionSync(DescribeSupportProxyVersionRequest req)
        {
            return InternalRequestAsync<DescribeSupportProxyVersionResponse>(req, "DescribeSupportProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query task lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// This API is used to query task lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the cluster information list associated with the backup safe
        /// </summary>
        /// <param name="req"><see cref="DescribeVaultBackupClusterInfoRequest"/></param>
        /// <returns><see cref="DescribeVaultBackupClusterInfoResponse"/></returns>
        public Task<DescribeVaultBackupClusterInfoResponse> DescribeVaultBackupClusterInfo(DescribeVaultBackupClusterInfoRequest req)
        {
            return InternalRequestAsync<DescribeVaultBackupClusterInfoResponse>(req, "DescribeVaultBackupClusterInfo");
        }

        /// <summary>
        /// Query the cluster information list associated with the backup safe
        /// </summary>
        /// <param name="req"><see cref="DescribeVaultBackupClusterInfoRequest"/></param>
        /// <returns><see cref="DescribeVaultBackupClusterInfoResponse"/></returns>
        public DescribeVaultBackupClusterInfoResponse DescribeVaultBackupClusterInfoSync(DescribeVaultBackupClusterInfoRequest req)
        {
            return InternalRequestAsync<DescribeVaultBackupClusterInfoResponse>(req, "DescribeVaultBackupClusterInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query backup safe list, support page, filter and sort.
        /// </summary>
        /// <param name="req"><see cref="DescribeVaultsRequest"/></param>
        /// <returns><see cref="DescribeVaultsResponse"/></returns>
        public Task<DescribeVaultsResponse> DescribeVaults(DescribeVaultsRequest req)
        {
            return InternalRequestAsync<DescribeVaultsResponse>(req, "DescribeVaults");
        }

        /// <summary>
        /// Query backup safe list, support page, filter and sort.
        /// </summary>
        /// <param name="req"><see cref="DescribeVaultsRequest"/></param>
        /// <returns><see cref="DescribeVaultsResponse"/></returns>
        public DescribeVaultsResponse DescribeVaultsSync(DescribeVaultsRequest req)
        {
            return InternalRequestAsync<DescribeVaultsResponse>(req, "DescribeVaults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query marketable regional availability zone information.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query marketable regional availability zone information.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind cloud resources from security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to unbind cloud resources from security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Download the analysis cluster list
        /// </summary>
        /// <param name="req"><see cref="DownloadLibraDBClusterListRequest"/></param>
        /// <returns><see cref="DownloadLibraDBClusterListResponse"/></returns>
        public Task<DownloadLibraDBClusterListResponse> DownloadLibraDBClusterList(DownloadLibraDBClusterListRequest req)
        {
            return InternalRequestAsync<DownloadLibraDBClusterListResponse>(req, "DownloadLibraDBClusterList");
        }

        /// <summary>
        /// Download the analysis cluster list
        /// </summary>
        /// <param name="req"><see cref="DownloadLibraDBClusterListRequest"/></param>
        /// <returns><see cref="DownloadLibraDBClusterListResponse"/></returns>
        public DownloadLibraDBClusterListResponse DownloadLibraDBClusterListSync(DownloadLibraDBClusterListRequest req)
        {
            return InternalRequestAsync<DownloadLibraDBClusterListResponse>(req, "DownloadLibraDBClusterList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the error logs of an instance.
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="ExportInstanceErrorLogsResponse"/></returns>
        public Task<ExportInstanceErrorLogsResponse> ExportInstanceErrorLogs(ExportInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<ExportInstanceErrorLogsResponse>(req, "ExportInstanceErrorLogs");
        }

        /// <summary>
        /// This API is used to export the error logs of an instance.
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceErrorLogsRequest"/></param>
        /// <returns><see cref="ExportInstanceErrorLogsResponse"/></returns>
        public ExportInstanceErrorLogsResponse ExportInstanceErrorLogsSync(ExportInstanceErrorLogsRequest req)
        {
            return InternalRequestAsync<ExportInstanceErrorLogsResponse>(req, "ExportInstanceErrorLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export instance slow logs.
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="ExportInstanceSlowQueriesResponse"/></returns>
        public Task<ExportInstanceSlowQueriesResponse> ExportInstanceSlowQueries(ExportInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<ExportInstanceSlowQueriesResponse>(req, "ExportInstanceSlowQueries");
        }

        /// <summary>
        /// This API is used to export instance slow logs.
        /// </summary>
        /// <param name="req"><see cref="ExportInstanceSlowQueriesRequest"/></param>
        /// <returns><see cref="ExportInstanceSlowQueriesResponse"/></returns>
        public ExportInstanceSlowQueriesResponse ExportInstanceSlowQueriesSync(ExportInstanceSlowQueriesRequest req)
        {
            return InternalRequestAsync<ExportInstanceSlowQueriesResponse>(req, "ExportInstanceSlowQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the usage details of a resource package.
        /// </summary>
        /// <param name="req"><see cref="ExportResourcePackageDeductDetailsRequest"/></param>
        /// <returns><see cref="ExportResourcePackageDeductDetailsResponse"/></returns>
        public Task<ExportResourcePackageDeductDetailsResponse> ExportResourcePackageDeductDetails(ExportResourcePackageDeductDetailsRequest req)
        {
            return InternalRequestAsync<ExportResourcePackageDeductDetailsResponse>(req, "ExportResourcePackageDeductDetails");
        }

        /// <summary>
        /// This API is used to export the usage details of a resource package.
        /// </summary>
        /// <param name="req"><see cref="ExportResourcePackageDeductDetailsRequest"/></param>
        /// <returns><see cref="ExportResourcePackageDeductDetailsResponse"/></returns>
        public ExportResourcePackageDeductDetailsResponse ExportResourcePackageDeductDetailsSync(ExportResourcePackageDeductDetailsRequest req)
        {
            return InternalRequestAsync<ExportResourcePackageDeductDetailsResponse>(req, "ExportResourcePackageDeductDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to grant permissions to authorized accounts in batch.
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public Task<GrantAccountPrivilegesResponse> GrantAccountPrivileges(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges");
        }

        /// <summary>
        /// This API is used to grant permissions to authorized accounts in batch.
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public GrantAccountPrivilegesResponse GrantAccountPrivilegesSync(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (InquirePriceCreate) is used for price inquiry of newly purchased clusters.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateRequest"/></param>
        /// <returns><see cref="InquirePriceCreateResponse"/></returns>
        public Task<InquirePriceCreateResponse> InquirePriceCreate(InquirePriceCreateRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateResponse>(req, "InquirePriceCreate");
        }

        /// <summary>
        /// This interface (InquirePriceCreate) is used for price inquiry of newly purchased clusters.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateRequest"/></param>
        /// <returns><see cref="InquirePriceCreateResponse"/></returns>
        public InquirePriceCreateResponse InquirePriceCreateSync(InquirePriceCreateRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateResponse>(req, "InquirePriceCreate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for modifying the specifications of a prepaid cluster.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyRequest"/></param>
        /// <returns><see cref="InquirePriceModifyResponse"/></returns>
        public Task<InquirePriceModifyResponse> InquirePriceModify(InquirePriceModifyRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyResponse>(req, "InquirePriceModify");
        }

        /// <summary>
        /// This API is used to query the price for modifying the specifications of a prepaid cluster.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyRequest"/></param>
        /// <returns><see cref="InquirePriceModifyResponse"/></returns>
        public InquirePriceModifyResponse InquirePriceModifySync(InquirePriceModifyRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyResponse>(req, "InquirePriceModify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to inquire prices in batch.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceMultiSpecRequest"/></param>
        /// <returns><see cref="InquirePriceMultiSpecResponse"/></returns>
        public Task<InquirePriceMultiSpecResponse> InquirePriceMultiSpec(InquirePriceMultiSpecRequest req)
        {
            return InternalRequestAsync<InquirePriceMultiSpecResponse>(req, "InquirePriceMultiSpec");
        }

        /// <summary>
        /// This API is used to inquire prices in batch.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceMultiSpecRequest"/></param>
        /// <returns><see cref="InquirePriceMultiSpecResponse"/></returns>
        public InquirePriceMultiSpecResponse InquirePriceMultiSpecSync(InquirePriceMultiSpecRequest req)
        {
            return InternalRequestAsync<InquirePriceMultiSpecResponse>(req, "InquirePriceMultiSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the renewal price of a cluster.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewRequest"/></param>
        /// <returns><see cref="InquirePriceRenewResponse"/></returns>
        public Task<InquirePriceRenewResponse> InquirePriceRenew(InquirePriceRenewRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewResponse>(req, "InquirePriceRenew");
        }

        /// <summary>
        /// This API is used to query the renewal price of a cluster.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewRequest"/></param>
        /// <returns><see cref="InquirePriceRenewResponse"/></returns>
        public InquirePriceRenewResponse InquirePriceRenewSync(InquirePriceRenewRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewResponse>(req, "InquirePriceRenew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (IsolateCluster) is used to isolate a cluster.
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public Task<IsolateClusterResponse> IsolateCluster(IsolateClusterRequest req)
        {
            return InternalRequestAsync<IsolateClusterResponse>(req, "IsolateCluster");
        }

        /// <summary>
        /// This interface (IsolateCluster) is used to isolate a cluster.
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public IsolateClusterResponse IsolateClusterSync(IsolateClusterRequest req)
        {
            return InternalRequestAsync<IsolateClusterResponse>(req, "IsolateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate an instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateInstanceRequest"/></param>
        /// <returns><see cref="IsolateInstanceResponse"/></returns>
        public Task<IsolateInstanceResponse> IsolateInstance(IsolateInstanceRequest req)
        {
            return InternalRequestAsync<IsolateInstanceResponse>(req, "IsolateInstance");
        }

        /// <summary>
        /// This API is used to isolate an instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateInstanceRequest"/></param>
        /// <returns><see cref="IsolateInstanceResponse"/></returns>
        public IsolateInstanceResponse IsolateInstanceSync(IsolateInstanceRequest req)
        {
            return InternalRequestAsync<IsolateInstanceResponse>(req, "IsolateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Isolating a TDSQL-C Analysis Cluster
        /// </summary>
        /// <param name="req"><see cref="IsolateLibraDBClusterRequest"/></param>
        /// <returns><see cref="IsolateLibraDBClusterResponse"/></returns>
        public Task<IsolateLibraDBClusterResponse> IsolateLibraDBCluster(IsolateLibraDBClusterRequest req)
        {
            return InternalRequestAsync<IsolateLibraDBClusterResponse>(req, "IsolateLibraDBCluster");
        }

        /// <summary>
        /// Isolating a TDSQL-C Analysis Cluster
        /// </summary>
        /// <param name="req"><see cref="IsolateLibraDBClusterRequest"/></param>
        /// <returns><see cref="IsolateLibraDBClusterResponse"/></returns>
        public IsolateLibraDBClusterResponse IsolateLibraDBClusterSync(IsolateLibraDBClusterRequest req)
        {
            return InternalRequestAsync<IsolateLibraDBClusterResponse>(req, "IsolateLibraDBCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate read-only analysis engine instances.
        /// </summary>
        /// <param name="req"><see cref="IsolateLibraDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateLibraDBInstanceResponse"/></returns>
        public Task<IsolateLibraDBInstanceResponse> IsolateLibraDBInstance(IsolateLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateLibraDBInstanceResponse>(req, "IsolateLibraDBInstance");
        }

        /// <summary>
        /// This API is used to isolate read-only analysis engine instances.
        /// </summary>
        /// <param name="req"><see cref="IsolateLibraDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateLibraDBInstanceResponse"/></returns>
        public IsolateLibraDBInstanceResponse IsolateLibraDBInstanceSync(IsolateLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateLibraDBInstanceResponse>(req, "IsolateLibraDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the descriptions of a database account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription");
        }

        /// <summary>
        /// This API is used to modify the descriptions of a database account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify account hosts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountHostRequest"/></param>
        /// <returns><see cref="ModifyAccountHostResponse"/></returns>
        public Task<ModifyAccountHostResponse> ModifyAccountHost(ModifyAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyAccountHostResponse>(req, "ModifyAccountHost");
        }

        /// <summary>
        /// This API is used to modify account hosts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountHostRequest"/></param>
        /// <returns><see cref="ModifyAccountHostResponse"/></returns>
        public ModifyAccountHostResponse ModifyAccountHostSync(ModifyAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyAccountHostResponse>(req, "ModifyAccountHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify account database and table permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// This API is used to modify account database and table permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges")
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
        /// This API is used to modify the audit configurations of an instance, such as audit log retention period and audit rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// This API is used to modify the audit configurations of an instance, such as audit log retention period and audit rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the backup configuration of a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public Task<ModifyBackupConfigResponse> ModifyBackupConfig(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig");
        }

        /// <summary>
        /// This API is used to modify the backup configuration of a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public ModifyBackupConfigResponse ModifyBackupConfigSync(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the download source limit of the backup file for the user in the current region. It can be configured to allow downloads from both private and public networks, only the private network, or a designated vpc or ip within the private network.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to modify the download source limit of the backup file for the user in the current region. It can be configured to allow downloads from both private and public networks, only the private network, or a designated vpc or ip within the private network.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the download source restrictions for backup files in the user's current region. It can be configured to allow downloads from both private and public networks, only from a private network, or from a designated vpc or ip within the private network.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadUserRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadUserRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadUserRestrictionResponse> ModifyBackupDownloadUserRestriction(ModifyBackupDownloadUserRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadUserRestrictionResponse>(req, "ModifyBackupDownloadUserRestriction");
        }

        /// <summary>
        /// This API is used to modify the download source restrictions for backup files in the user's current region. It can be configured to allow downloads from both private and public networks, only from a private network, or from a designated vpc or ip within the private network.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadUserRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadUserRestrictionResponse"/></returns>
        public ModifyBackupDownloadUserRestrictionResponse ModifyBackupDownloadUserRestrictionSync(ModifyBackupDownloadUserRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadUserRestrictionResponse>(req, "ModifyBackupDownloadUserRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a backup file.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public Task<ModifyBackupNameResponse> ModifyBackupName(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName");
        }

        /// <summary>
        /// This API is used to rename a backup file.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public ModifyBackupNameResponse ModifyBackupNameSync(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Binlog configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyBinlogConfigResponse"/></returns>
        public Task<ModifyBinlogConfigResponse> ModifyBinlogConfig(ModifyBinlogConfigRequest req)
        {
            return InternalRequestAsync<ModifyBinlogConfigResponse>(req, "ModifyBinlogConfig");
        }

        /// <summary>
        /// This API is used to modify Binlog configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyBinlogConfigResponse"/></returns>
        public ModifyBinlogConfigResponse ModifyBinlogConfigSync(ModifyBinlogConfigRequest req)
        {
            return InternalRequestAsync<ModifyBinlogConfigResponse>(req, "ModifyBinlogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the binlog retention period in days.
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="ModifyBinlogSaveDaysResponse"/></returns>
        public Task<ModifyBinlogSaveDaysResponse> ModifyBinlogSaveDays(ModifyBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<ModifyBinlogSaveDaysResponse>(req, "ModifyBinlogSaveDays");
        }

        /// <summary>
        /// This API is used to modify the binlog retention period in days.
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogSaveDaysRequest"/></param>
        /// <returns><see cref="ModifyBinlogSaveDaysResponse"/></returns>
        public ModifyBinlogSaveDaysResponse ModifyBinlogSaveDaysSync(ModifyBinlogSaveDaysRequest req)
        {
            return InternalRequestAsync<ModifyBinlogSaveDaysResponse>(req, "ModifyBinlogSaveDays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster configuration to automatically copy Binlog and RedoLog to safe.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterBinlogRedoLogAutoCopyVaultRequest"/></param>
        /// <returns><see cref="ModifyClusterBinlogRedoLogAutoCopyVaultResponse"/></returns>
        public Task<ModifyClusterBinlogRedoLogAutoCopyVaultResponse> ModifyClusterBinlogRedoLogAutoCopyVault(ModifyClusterBinlogRedoLogAutoCopyVaultRequest req)
        {
            return InternalRequestAsync<ModifyClusterBinlogRedoLogAutoCopyVaultResponse>(req, "ModifyClusterBinlogRedoLogAutoCopyVault");
        }

        /// <summary>
        /// This API is used to modify cluster configuration to automatically copy Binlog and RedoLog to safe.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterBinlogRedoLogAutoCopyVaultRequest"/></param>
        /// <returns><see cref="ModifyClusterBinlogRedoLogAutoCopyVaultResponse"/></returns>
        public ModifyClusterBinlogRedoLogAutoCopyVaultResponse ModifyClusterBinlogRedoLogAutoCopyVaultSync(ModifyClusterBinlogRedoLogAutoCopyVaultRequest req)
        {
            return InternalRequestAsync<ModifyClusterBinlogRedoLogAutoCopyVaultResponse>(req, "ModifyClusterBinlogRedoLogAutoCopyVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify account authorization of a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDatabaseRequest"/></param>
        /// <returns><see cref="ModifyClusterDatabaseResponse"/></returns>
        public Task<ModifyClusterDatabaseResponse> ModifyClusterDatabase(ModifyClusterDatabaseRequest req)
        {
            return InternalRequestAsync<ModifyClusterDatabaseResponse>(req, "ModifyClusterDatabase");
        }

        /// <summary>
        /// This API is used to modify account authorization of a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDatabaseRequest"/></param>
        /// <returns><see cref="ModifyClusterDatabaseResponse"/></returns>
        public ModifyClusterDatabaseResponse ModifyClusterDatabaseSync(ModifyClusterDatabaseRequest req)
        {
            return InternalRequestAsync<ModifyClusterDatabaseResponse>(req, "ModifyClusterDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable global encryption
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterGlobalEncryptionRequest"/></param>
        /// <returns><see cref="ModifyClusterGlobalEncryptionResponse"/></returns>
        public Task<ModifyClusterGlobalEncryptionResponse> ModifyClusterGlobalEncryption(ModifyClusterGlobalEncryptionRequest req)
        {
            return InternalRequestAsync<ModifyClusterGlobalEncryptionResponse>(req, "ModifyClusterGlobalEncryption");
        }

        /// <summary>
        /// Enable global encryption
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterGlobalEncryptionRequest"/></param>
        /// <returns><see cref="ModifyClusterGlobalEncryptionResponse"/></returns>
        public ModifyClusterGlobalEncryptionResponse ModifyClusterGlobalEncryptionSync(ModifyClusterGlobalEncryptionRequest req)
        {
            return InternalRequestAsync<ModifyClusterGlobalEncryptionResponse>(req, "ModifyClusterGlobalEncryption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster names.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName");
        }

        /// <summary>
        /// This API is used to modify cluster names.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterParamRequest"/></param>
        /// <returns><see cref="ModifyClusterParamResponse"/></returns>
        public Task<ModifyClusterParamResponse> ModifyClusterParam(ModifyClusterParamRequest req)
        {
            return InternalRequestAsync<ModifyClusterParamResponse>(req, "ModifyClusterParam");
        }

        /// <summary>
        /// This API is used to modify cluster parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterParamRequest"/></param>
        /// <returns><see cref="ModifyClusterParamResponse"/></returns>
        public ModifyClusterParamResponse ModifyClusterParamSync(ModifyClusterParamRequest req)
        {
            return InternalRequestAsync<ModifyClusterParamResponse>(req, "ModifyClusterParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify or enable cluster password complexity.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordComplexityResponse"/></returns>
        public Task<ModifyClusterPasswordComplexityResponse> ModifyClusterPasswordComplexity(ModifyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordComplexityResponse>(req, "ModifyClusterPasswordComplexity");
        }

        /// <summary>
        /// This API is used to modify or enable cluster password complexity.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordComplexityResponse"/></returns>
        public ModifyClusterPasswordComplexityResponse ModifyClusterPasswordComplexitySync(ModifyClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordComplexityResponse>(req, "ModifyClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the read-only switch of a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyClusterReadOnlyResponse"/></returns>
        public Task<ModifyClusterReadOnlyResponse> ModifyClusterReadOnly(ModifyClusterReadOnlyRequest req)
        {
            return InternalRequestAsync<ModifyClusterReadOnlyResponse>(req, "ModifyClusterReadOnly");
        }

        /// <summary>
        /// This API is used to modify the read-only switch of a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyClusterReadOnlyResponse"/></returns>
        public ModifyClusterReadOnlyResponse ModifyClusterReadOnlySync(ModifyClusterReadOnlyRequest req)
        {
            return InternalRequestAsync<ModifyClusterReadOnlyResponse>(req, "ModifyClusterReadOnly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the slave availability zone of a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="ModifyClusterSlaveZoneResponse"/></returns>
        public Task<ModifyClusterSlaveZoneResponse> ModifyClusterSlaveZone(ModifyClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<ModifyClusterSlaveZoneResponse>(req, "ModifyClusterSlaveZone");
        }

        /// <summary>
        /// This API is used to modify the slave availability zone of a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="ModifyClusterSlaveZoneResponse"/></returns>
        public ModifyClusterSlaveZoneResponse ModifyClusterSlaveZoneSync(ModifyClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<ModifyClusterSlaveZoneResponse>(req, "ModifyClusterSlaveZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the security group bound to the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API is used to modify the security group bound to the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
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
        /// This API is used to modify the instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam");
        }

        /// <summary>
        /// This API is used to modify the instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the time limit for upgrading the kernel minor version of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceUpgradeLimitDaysRequest"/></param>
        /// <returns><see cref="ModifyInstanceUpgradeLimitDaysResponse"/></returns>
        public Task<ModifyInstanceUpgradeLimitDaysResponse> ModifyInstanceUpgradeLimitDays(ModifyInstanceUpgradeLimitDaysRequest req)
        {
            return InternalRequestAsync<ModifyInstanceUpgradeLimitDaysResponse>(req, "ModifyInstanceUpgradeLimitDays");
        }

        /// <summary>
        /// This API is used to modify the time limit for upgrading the kernel minor version of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceUpgradeLimitDaysRequest"/></param>
        /// <returns><see cref="ModifyInstanceUpgradeLimitDaysResponse"/></returns>
        public ModifyInstanceUpgradeLimitDaysResponse ModifyInstanceUpgradeLimitDaysSync(ModifyInstanceUpgradeLimitDaysRequest req)
        {
            return InternalRequestAsync<ModifyInstanceUpgradeLimitDaysResponse>(req, "ModifyInstanceUpgradeLimitDays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the description of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterAccountDescriptionResponse"/></returns>
        public Task<ModifyLibraDBClusterAccountDescriptionResponse> ModifyLibraDBClusterAccountDescription(ModifyLibraDBClusterAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterAccountDescriptionResponse>(req, "ModifyLibraDBClusterAccountDescription");
        }

        /// <summary>
        /// This API is used to modify the description of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterAccountDescriptionResponse"/></returns>
        public ModifyLibraDBClusterAccountDescriptionResponse ModifyLibraDBClusterAccountDescriptionSync(ModifyLibraDBClusterAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterAccountDescriptionResponse>(req, "ModifyLibraDBClusterAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the log in to the host information of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterAccountHostRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterAccountHostResponse"/></returns>
        public Task<ModifyLibraDBClusterAccountHostResponse> ModifyLibraDBClusterAccountHost(ModifyLibraDBClusterAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterAccountHostResponse>(req, "ModifyLibraDBClusterAccountHost");
        }

        /// <summary>
        /// This API is used to modify the log in to the host information of a cluster account.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterAccountHostRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterAccountHostResponse"/></returns>
        public ModifyLibraDBClusterAccountHostResponse ModifyLibraDBClusterAccountHostSync(ModifyLibraDBClusterAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterAccountHostResponse>(req, "ModifyLibraDBClusterAccountHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the permission of a cluster account for analytics.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterAccountPrivilegeResponse"/></returns>
        public Task<ModifyLibraDBClusterAccountPrivilegeResponse> ModifyLibraDBClusterAccountPrivilege(ModifyLibraDBClusterAccountPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterAccountPrivilegeResponse>(req, "ModifyLibraDBClusterAccountPrivilege");
        }

        /// <summary>
        /// This API is used to modify the permission of a cluster account for analytics.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterAccountPrivilegeResponse"/></returns>
        public ModifyLibraDBClusterAccountPrivilegeResponse ModifyLibraDBClusterAccountPrivilegeSync(ModifyLibraDBClusterAccountPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterAccountPrivilegeResponse>(req, "ModifyLibraDBClusterAccountPrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the TDSQL-C analytical cluster data source.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterDataSourceRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterDataSourceResponse"/></returns>
        public Task<ModifyLibraDBClusterDataSourceResponse> ModifyLibraDBClusterDataSource(ModifyLibraDBClusterDataSourceRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterDataSourceResponse>(req, "ModifyLibraDBClusterDataSource");
        }

        /// <summary>
        /// This API is used to modify the TDSQL-C analytical cluster data source.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterDataSourceRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterDataSourceResponse"/></returns>
        public ModifyLibraDBClusterDataSourceResponse ModifyLibraDBClusterDataSourceSync(ModifyLibraDBClusterDataSourceRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterDataSourceResponse>(req, "ModifyLibraDBClusterDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the name of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterNameRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterNameResponse"/></returns>
        public Task<ModifyLibraDBClusterNameResponse> ModifyLibraDBClusterName(ModifyLibraDBClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterNameResponse>(req, "ModifyLibraDBClusterName");
        }

        /// <summary>
        /// This API is used to modify the name of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterNameRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterNameResponse"/></returns>
        public ModifyLibraDBClusterNameResponse ModifyLibraDBClusterNameSync(ModifyLibraDBClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterNameResponse>(req, "ModifyLibraDBClusterName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the project ID of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterProjectRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterProjectResponse"/></returns>
        public Task<ModifyLibraDBClusterProjectResponse> ModifyLibraDBClusterProject(ModifyLibraDBClusterProjectRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterProjectResponse>(req, "ModifyLibraDBClusterProject");
        }

        /// <summary>
        /// This API is used to modify the project ID of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterProjectRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterProjectResponse"/></returns>
        public ModifyLibraDBClusterProjectResponse ModifyLibraDBClusterProjectSync(ModifyLibraDBClusterProjectRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterProjectResponse>(req, "ModifyLibraDBClusterProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the sync object of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterReplicationObjectRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterReplicationObjectResponse"/></returns>
        public Task<ModifyLibraDBClusterReplicationObjectResponse> ModifyLibraDBClusterReplicationObject(ModifyLibraDBClusterReplicationObjectRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterReplicationObjectResponse>(req, "ModifyLibraDBClusterReplicationObject");
        }

        /// <summary>
        /// This API is used to modify the sync object of an analysis cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBClusterReplicationObjectRequest"/></param>
        /// <returns><see cref="ModifyLibraDBClusterReplicationObjectResponse"/></returns>
        public ModifyLibraDBClusterReplicationObjectResponse ModifyLibraDBClusterReplicationObjectSync(ModifyLibraDBClusterReplicationObjectRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBClusterReplicationObjectResponse>(req, "ModifyLibraDBClusterReplicationObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the automatic forwarding parameter of a read-only analysis instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBForwardConfigRequest"/></param>
        /// <returns><see cref="ModifyLibraDBForwardConfigResponse"/></returns>
        public Task<ModifyLibraDBForwardConfigResponse> ModifyLibraDBForwardConfig(ModifyLibraDBForwardConfigRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBForwardConfigResponse>(req, "ModifyLibraDBForwardConfig");
        }

        /// <summary>
        /// This API is used to modify the automatic forwarding parameter of a read-only analysis instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraDBForwardConfigRequest"/></param>
        /// <returns><see cref="ModifyLibraDBForwardConfigResponse"/></returns>
        public ModifyLibraDBForwardConfigResponse ModifyLibraDBForwardConfigSync(ModifyLibraDBForwardConfigRequest req)
        {
            return InternalRequestAsync<ModifyLibraDBForwardConfigResponse>(req, "ModifyLibraDBForwardConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify maintenance time configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainPeriodConfigRequest"/></param>
        /// <returns><see cref="ModifyMaintainPeriodConfigResponse"/></returns>
        public Task<ModifyMaintainPeriodConfigResponse> ModifyMaintainPeriodConfig(ModifyMaintainPeriodConfigRequest req)
        {
            return InternalRequestAsync<ModifyMaintainPeriodConfigResponse>(req, "ModifyMaintainPeriodConfig");
        }

        /// <summary>
        /// This API is used to modify maintenance time configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainPeriodConfigRequest"/></param>
        /// <returns><see cref="ModifyMaintainPeriodConfigResponse"/></returns>
        public ModifyMaintainPeriodConfigResponse ModifyMaintainPeriodConfigSync(ModifyMaintainPeriodConfigRequest req)
        {
            return InternalRequestAsync<ModifyMaintainPeriodConfigResponse>(req, "ModifyMaintainPeriodConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate");
        }

        /// <summary>
        /// This API is used to modify a parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the description of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyDescRequest"/></param>
        /// <returns><see cref="ModifyProxyDescResponse"/></returns>
        public Task<ModifyProxyDescResponse> ModifyProxyDesc(ModifyProxyDescRequest req)
        {
            return InternalRequestAsync<ModifyProxyDescResponse>(req, "ModifyProxyDesc");
        }

        /// <summary>
        /// This API is used to modify the description of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyDescRequest"/></param>
        /// <returns><see cref="ModifyProxyDescResponse"/></returns>
        public ModifyProxyDescResponse ModifyProxyDescSync(ModifyProxyDescRequest req)
        {
            return InternalRequestAsync<ModifyProxyDescResponse>(req, "ModifyProxyDesc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure read-write separation for database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyRwSplitRequest"/></param>
        /// <returns><see cref="ModifyProxyRwSplitResponse"/></returns>
        public Task<ModifyProxyRwSplitResponse> ModifyProxyRwSplit(ModifyProxyRwSplitRequest req)
        {
            return InternalRequestAsync<ModifyProxyRwSplitResponse>(req, "ModifyProxyRwSplit");
        }

        /// <summary>
        /// This API is used to configure read-write separation for database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyRwSplitRequest"/></param>
        /// <returns><see cref="ModifyProxyRwSplitResponse"/></returns>
        public ModifyProxyRwSplitResponse ModifyProxyRwSplitSync(ModifyProxyRwSplitRequest req)
        {
            return InternalRequestAsync<ModifyProxyRwSplitResponse>(req, "ModifyProxyRwSplit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the binding relationship between resource packages and clusters.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageClustersRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageClustersResponse"/></returns>
        public Task<ModifyResourcePackageClustersResponse> ModifyResourcePackageClusters(ModifyResourcePackageClustersRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageClustersResponse>(req, "ModifyResourcePackageClusters");
        }

        /// <summary>
        /// This API is used to modify the binding relationship between resource packages and clusters.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageClustersRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageClustersResponse"/></returns>
        public ModifyResourcePackageClustersResponse ModifyResourcePackageClustersSync(ModifyResourcePackageClustersRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageClustersResponse>(req, "ModifyResourcePackageClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify resource package name.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageNameRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageNameResponse"/></returns>
        public Task<ModifyResourcePackageNameResponse> ModifyResourcePackageName(ModifyResourcePackageNameRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageNameResponse>(req, "ModifyResourcePackageName");
        }

        /// <summary>
        /// This API is used to modify resource package name.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackageNameRequest"/></param>
        /// <returns><see cref="ModifyResourcePackageNameResponse"/></returns>
        public ModifyResourcePackageNameResponse ModifyResourcePackageNameSync(ModifyResourcePackageNameRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackageNameResponse>(req, "ModifyResourcePackageName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the deduction priority of the bound resource package.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackagesDeductionPriorityRequest"/></param>
        /// <returns><see cref="ModifyResourcePackagesDeductionPriorityResponse"/></returns>
        public Task<ModifyResourcePackagesDeductionPriorityResponse> ModifyResourcePackagesDeductionPriority(ModifyResourcePackagesDeductionPriorityRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackagesDeductionPriorityResponse>(req, "ModifyResourcePackagesDeductionPriority");
        }

        /// <summary>
        /// This API is used to modify the deduction priority of the bound resource package.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePackagesDeductionPriorityRequest"/></param>
        /// <returns><see cref="ModifyResourcePackagesDeductionPriorityResponse"/></returns>
        public ModifyResourcePackagesDeductionPriorityResponse ModifyResourcePackagesDeductionPrioritySync(ModifyResourcePackagesDeductionPriorityRequest req)
        {
            return InternalRequestAsync<ModifyResourcePackagesDeductionPriorityResponse>(req, "ModifyResourcePackagesDeductionPriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the serverless policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyServerlessStrategyRequest"/></param>
        /// <returns><see cref="ModifyServerlessStrategyResponse"/></returns>
        public Task<ModifyServerlessStrategyResponse> ModifyServerlessStrategy(ModifyServerlessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyServerlessStrategyResponse>(req, "ModifyServerlessStrategy");
        }

        /// <summary>
        /// This API is used to modify the serverless policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyServerlessStrategyRequest"/></param>
        /// <returns><see cref="ModifyServerlessStrategyResponse"/></returns>
        public ModifyServerlessStrategyResponse ModifyServerlessStrategySync(ModifyServerlessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyServerlessStrategyResponse>(req, "ModifyServerlessStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the snapshot backup cross-region configuration of a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapBackupCrossRegionConfigRequest"/></param>
        /// <returns><see cref="ModifySnapBackupCrossRegionConfigResponse"/></returns>
        public Task<ModifySnapBackupCrossRegionConfigResponse> ModifySnapBackupCrossRegionConfig(ModifySnapBackupCrossRegionConfigRequest req)
        {
            return InternalRequestAsync<ModifySnapBackupCrossRegionConfigResponse>(req, "ModifySnapBackupCrossRegionConfig");
        }

        /// <summary>
        /// This API is used to modify the snapshot backup cross-region configuration of a specified cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapBackupCrossRegionConfigRequest"/></param>
        /// <returns><see cref="ModifySnapBackupCrossRegionConfigResponse"/></returns>
        public ModifySnapBackupCrossRegionConfigResponse ModifySnapBackupCrossRegionConfigSync(ModifySnapBackupCrossRegionConfigRequest req)
        {
            return InternalRequestAsync<ModifySnapBackupCrossRegionConfigResponse>(req, "ModifySnapBackupCrossRegionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify backup safe configuration, including the name, description, retention duration, encryption key, lock time.
        /// </summary>
        /// <param name="req"><see cref="ModifyVaultRequest"/></param>
        /// <returns><see cref="ModifyVaultResponse"/></returns>
        public Task<ModifyVaultResponse> ModifyVault(ModifyVaultRequest req)
        {
            return InternalRequestAsync<ModifyVaultResponse>(req, "ModifyVault");
        }

        /// <summary>
        /// Modify backup safe configuration, including the name, description, retention duration, encryption key, lock time.
        /// </summary>
        /// <param name="req"><see cref="ModifyVaultRequest"/></param>
        /// <returns><see cref="ModifyVaultResponse"/></returns>
        public ModifyVaultResponse ModifyVaultSync(ModifyVaultRequest req)
        {
            return InternalRequestAsync<ModifyVaultResponse>(req, "ModifyVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the ip and port of an instance group.
        /// </summary>
        /// <param name="req"><see cref="ModifyVipVportRequest"/></param>
        /// <returns><see cref="ModifyVipVportResponse"/></returns>
        public Task<ModifyVipVportResponse> ModifyVipVport(ModifyVipVportRequest req)
        {
            return InternalRequestAsync<ModifyVipVportResponse>(req, "ModifyVipVport");
        }

        /// <summary>
        /// This API is used to modify the ip and port of an instance group.
        /// </summary>
        /// <param name="req"><see cref="ModifyVipVportRequest"/></param>
        /// <returns><see cref="ModifyVipVportResponse"/></returns>
        public ModifyVipVportResponse ModifyVipVportSync(ModifyVipVportRequest req)
        {
            return InternalRequestAsync<ModifyVipVportResponse>(req, "ModifyVipVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (OfflineCluster) is used to terminate clusters.
        /// </summary>
        /// <param name="req"><see cref="OfflineClusterRequest"/></param>
        /// <returns><see cref="OfflineClusterResponse"/></returns>
        public Task<OfflineClusterResponse> OfflineCluster(OfflineClusterRequest req)
        {
            return InternalRequestAsync<OfflineClusterResponse>(req, "OfflineCluster");
        }

        /// <summary>
        /// This interface (OfflineCluster) is used to terminate clusters.
        /// </summary>
        /// <param name="req"><see cref="OfflineClusterRequest"/></param>
        /// <returns><see cref="OfflineClusterResponse"/></returns>
        public OfflineClusterResponse OfflineClusterSync(OfflineClusterRequest req)
        {
            return InternalRequestAsync<OfflineClusterResponse>(req, "OfflineCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (OfflineInstance) is used to terminate an instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineInstanceRequest"/></param>
        /// <returns><see cref="OfflineInstanceResponse"/></returns>
        public Task<OfflineInstanceResponse> OfflineInstance(OfflineInstanceRequest req)
        {
            return InternalRequestAsync<OfflineInstanceResponse>(req, "OfflineInstance");
        }

        /// <summary>
        /// This interface (OfflineInstance) is used to terminate an instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineInstanceRequest"/></param>
        /// <returns><see cref="OfflineInstanceResponse"/></returns>
        public OfflineInstanceResponse OfflineInstanceSync(OfflineInstanceRequest req)
        {
            return InternalRequestAsync<OfflineInstanceResponse>(req, "OfflineInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Decommission an analysis cluster
        /// </summary>
        /// <param name="req"><see cref="OfflineLibraDBClusterRequest"/></param>
        /// <returns><see cref="OfflineLibraDBClusterResponse"/></returns>
        public Task<OfflineLibraDBClusterResponse> OfflineLibraDBCluster(OfflineLibraDBClusterRequest req)
        {
            return InternalRequestAsync<OfflineLibraDBClusterResponse>(req, "OfflineLibraDBCluster");
        }

        /// <summary>
        /// Decommission an analysis cluster
        /// </summary>
        /// <param name="req"><see cref="OfflineLibraDBClusterRequest"/></param>
        /// <returns><see cref="OfflineLibraDBClusterResponse"/></returns>
        public OfflineLibraDBClusterResponse OfflineLibraDBClusterSync(OfflineLibraDBClusterRequest req)
        {
            return InternalRequestAsync<OfflineLibraDBClusterResponse>(req, "OfflineLibraDBCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to decommission a read-only analysis engine instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineLibraDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineLibraDBInstanceResponse"/></returns>
        public Task<OfflineLibraDBInstanceResponse> OfflineLibraDBInstance(OfflineLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<OfflineLibraDBInstanceResponse>(req, "OfflineLibraDBInstance");
        }

        /// <summary>
        /// This API is used to decommission a read-only analysis engine instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineLibraDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineLibraDBInstanceResponse"/></returns>
        public OfflineLibraDBInstanceResponse OfflineLibraDBInstanceSync(OfflineLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<OfflineLibraDBInstanceResponse>(req, "OfflineLibraDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable database audit service for an instance.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// This API is used to enable database audit service for an instance.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the custom password complexity feature.
        /// </summary>
        /// <param name="req"><see cref="OpenClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="OpenClusterPasswordComplexityResponse"/></returns>
        public Task<OpenClusterPasswordComplexityResponse> OpenClusterPasswordComplexity(OpenClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<OpenClusterPasswordComplexityResponse>(req, "OpenClusterPasswordComplexity");
        }

        /// <summary>
        /// This API is used to enable the custom password complexity feature.
        /// </summary>
        /// <param name="req"><see cref="OpenClusterPasswordComplexityRequest"/></param>
        /// <returns><see cref="OpenClusterPasswordComplexityResponse"/></returns>
        public OpenClusterPasswordComplexityResponse OpenClusterPasswordComplexitySync(OpenClusterPasswordComplexityRequest req)
        {
            return InternalRequestAsync<OpenClusterPasswordComplexityResponse>(req, "OpenClusterPasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable read-only instance group access.
        /// </summary>
        /// <param name="req"><see cref="OpenClusterReadOnlyInstanceGroupAccessRequest"/></param>
        /// <returns><see cref="OpenClusterReadOnlyInstanceGroupAccessResponse"/></returns>
        public Task<OpenClusterReadOnlyInstanceGroupAccessResponse> OpenClusterReadOnlyInstanceGroupAccess(OpenClusterReadOnlyInstanceGroupAccessRequest req)
        {
            return InternalRequestAsync<OpenClusterReadOnlyInstanceGroupAccessResponse>(req, "OpenClusterReadOnlyInstanceGroupAccess");
        }

        /// <summary>
        /// This API is used to enable read-only instance group access.
        /// </summary>
        /// <param name="req"><see cref="OpenClusterReadOnlyInstanceGroupAccessRequest"/></param>
        /// <returns><see cref="OpenClusterReadOnlyInstanceGroupAccessResponse"/></returns>
        public OpenClusterReadOnlyInstanceGroupAccessResponse OpenClusterReadOnlyInstanceGroupAccessSync(OpenClusterReadOnlyInstanceGroupAccessRequest req)
        {
            return InternalRequestAsync<OpenClusterReadOnlyInstanceGroupAccessResponse>(req, "OpenClusterReadOnlyInstanceGroupAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable transparent data encryption for the cluster.
        /// </summary>
        /// <param name="req"><see cref="OpenClusterTransparentEncryptRequest"/></param>
        /// <returns><see cref="OpenClusterTransparentEncryptResponse"/></returns>
        public Task<OpenClusterTransparentEncryptResponse> OpenClusterTransparentEncrypt(OpenClusterTransparentEncryptRequest req)
        {
            return InternalRequestAsync<OpenClusterTransparentEncryptResponse>(req, "OpenClusterTransparentEncrypt");
        }

        /// <summary>
        /// Enable transparent data encryption for the cluster.
        /// </summary>
        /// <param name="req"><see cref="OpenClusterTransparentEncryptRequest"/></param>
        /// <returns><see cref="OpenClusterTransparentEncryptResponse"/></returns>
        public OpenClusterTransparentEncryptResponse OpenClusterTransparentEncryptSync(OpenClusterTransparentEncryptRequest req)
        {
            return InternalRequestAsync<OpenClusterTransparentEncryptResponse>(req, "OpenClusterTransparentEncrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (OpenReadOnlyInstanceExclusiveAccess) is used to enable the dedicated access access group for a read-only instance.
        /// </summary>
        /// <param name="req"><see cref="OpenReadOnlyInstanceExclusiveAccessRequest"/></param>
        /// <returns><see cref="OpenReadOnlyInstanceExclusiveAccessResponse"/></returns>
        public Task<OpenReadOnlyInstanceExclusiveAccessResponse> OpenReadOnlyInstanceExclusiveAccess(OpenReadOnlyInstanceExclusiveAccessRequest req)
        {
            return InternalRequestAsync<OpenReadOnlyInstanceExclusiveAccessResponse>(req, "OpenReadOnlyInstanceExclusiveAccess");
        }

        /// <summary>
        /// This interface (OpenReadOnlyInstanceExclusiveAccess) is used to enable the dedicated access access group for a read-only instance.
        /// </summary>
        /// <param name="req"><see cref="OpenReadOnlyInstanceExclusiveAccessRequest"/></param>
        /// <returns><see cref="OpenReadOnlyInstanceExclusiveAccessResponse"/></returns>
        public OpenReadOnlyInstanceExclusiveAccessResponse OpenReadOnlyInstanceExclusiveAccessSync(OpenReadOnlyInstanceExclusiveAccessRequest req)
        {
            return InternalRequestAsync<OpenReadOnlyInstanceExclusiveAccessResponse>(req, "OpenReadOnlyInstanceExclusiveAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (OpenWan) is used to enable external network.
        /// </summary>
        /// <param name="req"><see cref="OpenWanRequest"/></param>
        /// <returns><see cref="OpenWanResponse"/></returns>
        public Task<OpenWanResponse> OpenWan(OpenWanRequest req)
        {
            return InternalRequestAsync<OpenWanResponse>(req, "OpenWan");
        }

        /// <summary>
        /// This interface (OpenWan) is used to enable external network.
        /// </summary>
        /// <param name="req"><see cref="OpenWanRequest"/></param>
        /// <returns><see cref="OpenWanResponse"/></returns>
        public OpenWanResponse OpenWanSync(OpenWanRequest req)
        {
            return InternalRequestAsync<OpenWanResponse>(req, "OpenWan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to suspend a serverless cluster.
        /// </summary>
        /// <param name="req"><see cref="PauseServerlessRequest"/></param>
        /// <returns><see cref="PauseServerlessResponse"/></returns>
        public Task<PauseServerlessResponse> PauseServerless(PauseServerlessRequest req)
        {
            return InternalRequestAsync<PauseServerlessResponse>(req, "PauseServerless");
        }

        /// <summary>
        /// This API is used to suspend a serverless cluster.
        /// </summary>
        /// <param name="req"><see cref="PauseServerlessRequest"/></param>
        /// <returns><see cref="PauseServerlessResponse"/></returns>
        public PauseServerlessResponse PauseServerlessSync(PauseServerlessRequest req)
        {
            return InternalRequestAsync<PauseServerlessResponse>(req, "PauseServerless")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to refund a resource package.
        /// </summary>
        /// <param name="req"><see cref="RefundResourcePackageRequest"/></param>
        /// <returns><see cref="RefundResourcePackageResponse"/></returns>
        public Task<RefundResourcePackageResponse> RefundResourcePackage(RefundResourcePackageRequest req)
        {
            return InternalRequestAsync<RefundResourcePackageResponse>(req, "RefundResourcePackage");
        }

        /// <summary>
        /// This API is used to refund a resource package.
        /// </summary>
        /// <param name="req"><see cref="RefundResourcePackageRequest"/></param>
        /// <returns><see cref="RefundResourcePackageResponse"/></returns>
        public RefundResourcePackageResponse RefundResourcePackageSync(RefundResourcePackageRequest req)
        {
            return InternalRequestAsync<RefundResourcePackageResponse>(req, "RefundResourcePackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reload the database proxy of Cloud Load Balancer.
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public Task<ReloadBalanceProxyNodeResponse> ReloadBalanceProxyNode(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode");
        }

        /// <summary>
        /// This API is used to reload the database proxy of Cloud Load Balancer.
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public ReloadBalanceProxyNodeResponse ReloadBalanceProxyNodeSync(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable multi-AZ deployment for a cluster.
        /// </summary>
        /// <param name="req"><see cref="RemoveClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="RemoveClusterSlaveZoneResponse"/></returns>
        public Task<RemoveClusterSlaveZoneResponse> RemoveClusterSlaveZone(RemoveClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<RemoveClusterSlaveZoneResponse>(req, "RemoveClusterSlaveZone");
        }

        /// <summary>
        /// This API is used to disable multi-AZ deployment for a cluster.
        /// </summary>
        /// <param name="req"><see cref="RemoveClusterSlaveZoneRequest"/></param>
        /// <returns><see cref="RemoveClusterSlaveZoneResponse"/></returns>
        public RemoveClusterSlaveZoneResponse RemoveClusterSlaveZoneSync(RemoveClusterSlaveZoneRequest req)
        {
            return InternalRequestAsync<RemoveClusterSlaveZoneResponse>(req, "RemoveClusterSlaveZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew the cluster.
        /// </summary>
        /// <param name="req"><see cref="RenewClustersRequest"/></param>
        /// <returns><see cref="RenewClustersResponse"/></returns>
        public Task<RenewClustersResponse> RenewClusters(RenewClustersRequest req)
        {
            return InternalRequestAsync<RenewClustersResponse>(req, "RenewClusters");
        }

        /// <summary>
        /// This API is used to renew the cluster.
        /// </summary>
        /// <param name="req"><see cref="RenewClustersRequest"/></param>
        /// <returns><see cref="RenewClustersResponse"/></returns>
        public RenewClustersResponse RenewClustersSync(RenewClustersRequest req)
        {
            return InternalRequestAsync<RenewClustersResponse>(req, "RenewClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renew an analysis cluster
        /// </summary>
        /// <param name="req"><see cref="RenewLibraDBClustersRequest"/></param>
        /// <returns><see cref="RenewLibraDBClustersResponse"/></returns>
        public Task<RenewLibraDBClustersResponse> RenewLibraDBClusters(RenewLibraDBClustersRequest req)
        {
            return InternalRequestAsync<RenewLibraDBClustersResponse>(req, "RenewLibraDBClusters");
        }

        /// <summary>
        /// Renew an analysis cluster
        /// </summary>
        /// <param name="req"><see cref="RenewLibraDBClustersRequest"/></param>
        /// <returns><see cref="RenewLibraDBClustersResponse"/></returns>
        public RenewLibraDBClustersResponse RenewLibraDBClustersSync(RenewLibraDBClustersRequest req)
        {
            return InternalRequestAsync<RenewLibraDBClustersResponse>(req, "RenewLibraDBClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replay instance audit logs.
        /// </summary>
        /// <param name="req"><see cref="ReplayInstanceAuditLogRequest"/></param>
        /// <returns><see cref="ReplayInstanceAuditLogResponse"/></returns>
        public Task<ReplayInstanceAuditLogResponse> ReplayInstanceAuditLog(ReplayInstanceAuditLogRequest req)
        {
            return InternalRequestAsync<ReplayInstanceAuditLogResponse>(req, "ReplayInstanceAuditLog");
        }

        /// <summary>
        /// This API is used to replay instance audit logs.
        /// </summary>
        /// <param name="req"><see cref="ReplayInstanceAuditLogRequest"/></param>
        /// <returns><see cref="ReplayInstanceAuditLogResponse"/></returns>
        public ReplayInstanceAuditLogResponse ReplayInstanceAuditLogSync(ReplayInstanceAuditLogRequest req)
        {
            return InternalRequestAsync<ReplayInstanceAuditLogResponse>(req, "ReplayInstanceAuditLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the database account password.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// This API is used to modify the database account password.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the cluster account password for analytics
        /// </summary>
        /// <param name="req"><see cref="ResetLibraDBClusterAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetLibraDBClusterAccountPasswordResponse"/></returns>
        public Task<ResetLibraDBClusterAccountPasswordResponse> ResetLibraDBClusterAccountPassword(ResetLibraDBClusterAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetLibraDBClusterAccountPasswordResponse>(req, "ResetLibraDBClusterAccountPassword");
        }

        /// <summary>
        /// Modify the cluster account password for analytics
        /// </summary>
        /// <param name="req"><see cref="ResetLibraDBClusterAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetLibraDBClusterAccountPasswordResponse"/></returns>
        public ResetLibraDBClusterAccountPasswordResponse ResetLibraDBClusterAccountPasswordSync(ResetLibraDBClusterAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetLibraDBClusterAccountPasswordResponse>(req, "ResetLibraDBClusterAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reboot an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance");
        }

        /// <summary>
        /// This API is used to reboot an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Restart the read-only analysis engine
        /// </summary>
        /// <param name="req"><see cref="RestartLibraDBInstanceRequest"/></param>
        /// <returns><see cref="RestartLibraDBInstanceResponse"/></returns>
        public Task<RestartLibraDBInstanceResponse> RestartLibraDBInstance(RestartLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartLibraDBInstanceResponse>(req, "RestartLibraDBInstance");
        }

        /// <summary>
        /// Restart the read-only analysis engine
        /// </summary>
        /// <param name="req"><see cref="RestartLibraDBInstanceRequest"/></param>
        /// <returns><see cref="RestartLibraDBInstanceResponse"/></returns>
        public RestartLibraDBInstanceResponse RestartLibraDBInstanceSync(RestartLibraDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartLibraDBInstanceResponse>(req, "RestartLibraDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restore a serverless cluster.
        /// </summary>
        /// <param name="req"><see cref="ResumeServerlessRequest"/></param>
        /// <returns><see cref="ResumeServerlessResponse"/></returns>
        public Task<ResumeServerlessResponse> ResumeServerless(ResumeServerlessRequest req)
        {
            return InternalRequestAsync<ResumeServerlessResponse>(req, "ResumeServerless");
        }

        /// <summary>
        /// This API is used to restore a serverless cluster.
        /// </summary>
        /// <param name="req"><see cref="ResumeServerlessRequest"/></param>
        /// <returns><see cref="ResumeServerlessResponse"/></returns>
        public ResumeServerlessResponse ResumeServerlessSync(ResumeServerlessRequest req)
        {
            return InternalRequestAsync<ResumeServerlessResponse>(req, "ResumeServerless")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform cluster rollback.
        /// </summary>
        /// <param name="req"><see cref="RollBackClusterRequest"/></param>
        /// <returns><see cref="RollBackClusterResponse"/></returns>
        public Task<RollBackClusterResponse> RollBackCluster(RollBackClusterRequest req)
        {
            return InternalRequestAsync<RollBackClusterResponse>(req, "RollBackCluster");
        }

        /// <summary>
        /// This API is used to perform cluster rollback.
        /// </summary>
        /// <param name="req"><see cref="RollBackClusterRequest"/></param>
        /// <returns><see cref="RollBackClusterResponse"/></returns>
        public RollBackClusterResponse RollBackClusterSync(RollBackClusterRequest req)
        {
            return InternalRequestAsync<RollBackClusterResponse>(req, "RollBackCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to roll back to a new cluster.
        /// </summary>
        /// <param name="req"><see cref="RollbackToNewClusterRequest"/></param>
        /// <returns><see cref="RollbackToNewClusterResponse"/></returns>
        public Task<RollbackToNewClusterResponse> RollbackToNewCluster(RollbackToNewClusterRequest req)
        {
            return InternalRequestAsync<RollbackToNewClusterResponse>(req, "RollbackToNewCluster");
        }

        /// <summary>
        /// This API is used to roll back to a new cluster.
        /// </summary>
        /// <param name="req"><see cref="RollbackToNewClusterRequest"/></param>
        /// <returns><see cref="RollbackToNewClusterResponse"/></returns>
        public RollbackToNewClusterResponse RollbackToNewClusterSync(RollbackToNewClusterRequest req)
        {
            return InternalRequestAsync<RollbackToNewClusterResponse>(req, "RollbackToNewCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search cluster database lists.
        /// </summary>
        /// <param name="req"><see cref="SearchClusterDatabasesRequest"/></param>
        /// <returns><see cref="SearchClusterDatabasesResponse"/></returns>
        public Task<SearchClusterDatabasesResponse> SearchClusterDatabases(SearchClusterDatabasesRequest req)
        {
            return InternalRequestAsync<SearchClusterDatabasesResponse>(req, "SearchClusterDatabases");
        }

        /// <summary>
        /// This API is used to search cluster database lists.
        /// </summary>
        /// <param name="req"><see cref="SearchClusterDatabasesRequest"/></param>
        /// <returns><see cref="SearchClusterDatabasesResponse"/></returns>
        public SearchClusterDatabasesResponse SearchClusterDatabasesSync(SearchClusterDatabasesRequest req)
        {
            return InternalRequestAsync<SearchClusterDatabasesResponse>(req, "SearchClusterDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search cluster data table lists.
        /// </summary>
        /// <param name="req"><see cref="SearchClusterTablesRequest"/></param>
        /// <returns><see cref="SearchClusterTablesResponse"/></returns>
        public Task<SearchClusterTablesResponse> SearchClusterTables(SearchClusterTablesRequest req)
        {
            return InternalRequestAsync<SearchClusterTablesResponse>(req, "SearchClusterTables");
        }

        /// <summary>
        /// This API is used to search cluster data table lists.
        /// </summary>
        /// <param name="req"><see cref="SearchClusterTablesRequest"/></param>
        /// <returns><see cref="SearchClusterTablesResponse"/></returns>
        public SearchClusterTablesResponse SearchClusterTablesSync(SearchClusterTablesRequest req)
        {
            return InternalRequestAsync<SearchClusterTablesResponse>(req, "SearchClusterTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set whether to renew the TDSQL-C analysis cluster
        /// </summary>
        /// <param name="req"><see cref="SetLibraDBClusterRenewFlagRequest"/></param>
        /// <returns><see cref="SetLibraDBClusterRenewFlagResponse"/></returns>
        public Task<SetLibraDBClusterRenewFlagResponse> SetLibraDBClusterRenewFlag(SetLibraDBClusterRenewFlagRequest req)
        {
            return InternalRequestAsync<SetLibraDBClusterRenewFlagResponse>(req, "SetLibraDBClusterRenewFlag");
        }

        /// <summary>
        /// Set whether to renew the TDSQL-C analysis cluster
        /// </summary>
        /// <param name="req"><see cref="SetLibraDBClusterRenewFlagRequest"/></param>
        /// <returns><see cref="SetLibraDBClusterRenewFlagResponse"/></returns>
        public SetLibraDBClusterRenewFlagResponse SetLibraDBClusterRenewFlagSync(SetLibraDBClusterRenewFlagRequest req)
        {
            return InternalRequestAsync<SetLibraDBClusterRenewFlagResponse>(req, "SetLibraDBClusterRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the auto-renewal feature of an instance.
        /// </summary>
        /// <param name="req"><see cref="SetRenewFlagRequest"/></param>
        /// <returns><see cref="SetRenewFlagResponse"/></returns>
        public Task<SetRenewFlagResponse> SetRenewFlag(SetRenewFlagRequest req)
        {
            return InternalRequestAsync<SetRenewFlagResponse>(req, "SetRenewFlag");
        }

        /// <summary>
        /// This API is used to set the auto-renewal feature of an instance.
        /// </summary>
        /// <param name="req"><see cref="SetRenewFlagRequest"/></param>
        /// <returns><see cref="SetRenewFlagResponse"/></returns>
        public SetRenewFlagResponse SetRenewFlagSync(SetRenewFlagRequest req)
        {
            return InternalRequestAsync<SetRenewFlagResponse>(req, "SetRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (StartCLSDelivery) is used to enable log delivery functionality.
        /// </summary>
        /// <param name="req"><see cref="StartCLSDeliveryRequest"/></param>
        /// <returns><see cref="StartCLSDeliveryResponse"/></returns>
        public Task<StartCLSDeliveryResponse> StartCLSDelivery(StartCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StartCLSDeliveryResponse>(req, "StartCLSDelivery");
        }

        /// <summary>
        /// This interface (StartCLSDelivery) is used to enable log delivery functionality.
        /// </summary>
        /// <param name="req"><see cref="StartCLSDeliveryRequest"/></param>
        /// <returns><see cref="StartCLSDeliveryResponse"/></returns>
        public StartCLSDeliveryResponse StartCLSDeliverySync(StartCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StartCLSDeliveryResponse>(req, "StartCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop the log delivery feature.
        /// </summary>
        /// <param name="req"><see cref="StopCLSDeliveryRequest"/></param>
        /// <returns><see cref="StopCLSDeliveryResponse"/></returns>
        public Task<StopCLSDeliveryResponse> StopCLSDelivery(StopCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StopCLSDeliveryResponse>(req, "StopCLSDelivery");
        }

        /// <summary>
        /// This API is used to stop the log delivery feature.
        /// </summary>
        /// <param name="req"><see cref="StopCLSDeliveryRequest"/></param>
        /// <returns><see cref="StopCLSDeliveryResponse"/></returns>
        public StopCLSDeliveryResponse StopCLSDeliverySync(StopCLSDeliveryRequest req)
        {
            return InternalRequestAsync<StopCLSDeliveryResponse>(req, "StopCLSDelivery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replace the cluster vpc.
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterVpcRequest"/></param>
        /// <returns><see cref="SwitchClusterVpcResponse"/></returns>
        public Task<SwitchClusterVpcResponse> SwitchClusterVpc(SwitchClusterVpcRequest req)
        {
            return InternalRequestAsync<SwitchClusterVpcResponse>(req, "SwitchClusterVpc");
        }

        /// <summary>
        /// This API is used to replace the cluster vpc.
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterVpcRequest"/></param>
        /// <returns><see cref="SwitchClusterVpcResponse"/></returns>
        public SwitchClusterVpcResponse SwitchClusterVpcSync(SwitchClusterVpcRequest req)
        {
            return InternalRequestAsync<SwitchClusterVpcResponse>(req, "SwitchClusterVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch the primary and secondary AZs of a cluster.
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterZoneRequest"/></param>
        /// <returns><see cref="SwitchClusterZoneResponse"/></returns>
        public Task<SwitchClusterZoneResponse> SwitchClusterZone(SwitchClusterZoneRequest req)
        {
            return InternalRequestAsync<SwitchClusterZoneResponse>(req, "SwitchClusterZone");
        }

        /// <summary>
        /// This API is used to switch the primary and secondary AZs of a cluster.
        /// </summary>
        /// <param name="req"><see cref="SwitchClusterZoneRequest"/></param>
        /// <returns><see cref="SwitchClusterZoneResponse"/></returns>
        public SwitchClusterZoneResponse SwitchClusterZoneSync(SwitchClusterZoneRequest req)
        {
            return InternalRequestAsync<SwitchClusterZoneResponse>(req, "SwitchClusterZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replace the vpc of the database proxy.
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyVpcRequest"/></param>
        /// <returns><see cref="SwitchProxyVpcResponse"/></returns>
        public Task<SwitchProxyVpcResponse> SwitchProxyVpc(SwitchProxyVpcRequest req)
        {
            return InternalRequestAsync<SwitchProxyVpcResponse>(req, "SwitchProxyVpc");
        }

        /// <summary>
        /// This API is used to replace the vpc of the database proxy.
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyVpcRequest"/></param>
        /// <returns><see cref="SwitchProxyVpcResponse"/></returns>
        public SwitchProxyVpcResponse SwitchProxyVpcSync(SwitchProxyVpcRequest req)
        {
            return InternalRequestAsync<SwitchProxyVpcResponse>(req, "SwitchProxyVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger cross-AZ migration.
        /// </summary>
        /// <param name="req"><see cref="TransferClusterZoneRequest"/></param>
        /// <returns><see cref="TransferClusterZoneResponse"/></returns>
        public Task<TransferClusterZoneResponse> TransferClusterZone(TransferClusterZoneRequest req)
        {
            return InternalRequestAsync<TransferClusterZoneResponse>(req, "TransferClusterZone");
        }

        /// <summary>
        /// This API is used to trigger cross-AZ migration.
        /// </summary>
        /// <param name="req"><see cref="TransferClusterZoneRequest"/></param>
        /// <returns><see cref="TransferClusterZoneResponse"/></returns>
        public TransferClusterZoneResponse TransferClusterZoneSync(TransferClusterZoneRequest req)
        {
            return InternalRequestAsync<TransferClusterZoneResponse>(req, "TransferClusterZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind resource packages from clusters.
        /// </summary>
        /// <param name="req"><see cref="UnbindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="UnbindClusterResourcePackagesResponse"/></returns>
        public Task<UnbindClusterResourcePackagesResponse> UnbindClusterResourcePackages(UnbindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<UnbindClusterResourcePackagesResponse>(req, "UnbindClusterResourcePackages");
        }

        /// <summary>
        /// This API is used to unbind resource packages from clusters.
        /// </summary>
        /// <param name="req"><see cref="UnbindClusterResourcePackagesRequest"/></param>
        /// <returns><see cref="UnbindClusterResourcePackagesResponse"/></returns>
        public UnbindClusterResourcePackagesResponse UnbindClusterResourcePackagesSync(UnbindClusterResourcePackagesRequest req)
        {
            return InternalRequestAsync<UnbindClusterResourcePackagesResponse>(req, "UnbindClusterResourcePackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (UpgradeClusterVersion) is used to update the kernel minor version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterVersionRequest"/></param>
        /// <returns><see cref="UpgradeClusterVersionResponse"/></returns>
        public Task<UpgradeClusterVersionResponse> UpgradeClusterVersion(UpgradeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpgradeClusterVersionResponse>(req, "UpgradeClusterVersion");
        }

        /// <summary>
        /// This interface (UpgradeClusterVersion) is used to update the kernel minor version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterVersionRequest"/></param>
        /// <returns><see cref="UpgradeClusterVersionResponse"/></returns>
        public UpgradeClusterVersionResponse UpgradeClusterVersionSync(UpgradeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpgradeClusterVersionResponse>(req, "UpgradeClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface (UpgradeInstance) is used to upgrade instances.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// This interface (UpgradeInstance) is used to upgrade instances.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade database proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyRequest"/></param>
        /// <returns><see cref="UpgradeProxyResponse"/></returns>
        public Task<UpgradeProxyResponse> UpgradeProxy(UpgradeProxyRequest req)
        {
            return InternalRequestAsync<UpgradeProxyResponse>(req, "UpgradeProxy");
        }

        /// <summary>
        /// This API is used to upgrade database proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyRequest"/></param>
        /// <returns><see cref="UpgradeProxyResponse"/></returns>
        public UpgradeProxyResponse UpgradeProxySync(UpgradeProxyRequest req)
        {
            return InternalRequestAsync<UpgradeProxyResponse>(req, "UpgradeProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the database proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public Task<UpgradeProxyVersionResponse> UpgradeProxyVersion(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion");
        }

        /// <summary>
        /// This API is used to upgrade the database proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public UpgradeProxyVersionResponse UpgradeProxyVersionSync(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
