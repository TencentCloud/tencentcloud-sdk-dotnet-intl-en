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

namespace TencentCloud.Redis.V20180412
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Redis.V20180412.Models;

   public class RedisClient : AbstractClient{

       private const string endpoint = "redis.tencentcloudapi.com";
       private const string version = "2018-04-12";
       private const string sdkVersion = "SDK_NET_3.0.942";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RedisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RedisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add replication group members.
        /// </summary>
        /// <param name="req"><see cref="AddReplicationInstanceRequest"/></param>
        /// <returns><see cref="AddReplicationInstanceResponse"/></returns>
        public Task<AddReplicationInstanceResponse> AddReplicationInstance(AddReplicationInstanceRequest req)
        {
            return InternalRequestAsync<AddReplicationInstanceResponse>(req, "AddReplicationInstance");
        }

        /// <summary>
        /// This API is used to add replication group members.
        /// </summary>
        /// <param name="req"><see cref="AddReplicationInstanceRequest"/></param>
        /// <returns><see cref="AddReplicationInstanceResponse"/></returns>
        public AddReplicationInstanceResponse AddReplicationInstanceSync(AddReplicationInstanceRequest req)
        {
            return InternalRequestAsync<AddReplicationInstanceResponse>(req, "AddReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable public network access.
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public Task<AllocateWanAddressResponse> AllocateWanAddress(AllocateWanAddressRequest req)
        {
            return InternalRequestAsync<AllocateWanAddressResponse>(req, "AllocateWanAddress");
        }

        /// <summary>
        /// This API is used to enable public network access.
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public AllocateWanAddressResponse AllocateWanAddressSync(AllocateWanAddressRequest req)
        {
            return InternalRequestAsync<AllocateWanAddressResponse>(req, "AllocateWanAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply a parameter template to instances.
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public Task<ApplyParamsTemplateResponse> ApplyParamsTemplate(ApplyParamsTemplateRequest req)
        {
            return InternalRequestAsync<ApplyParamsTemplateResponse>(req, "ApplyParamsTemplate");
        }

        /// <summary>
        /// This API is used to apply a parameter template to instances.
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public ApplyParamsTemplateResponse ApplyParamsTemplateSync(ApplyParamsTemplateRequest req)
        {
            return InternalRequestAsync<ApplyParamsTemplateResponse>(req, "ApplyParamsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a security group to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to bind a security group to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the role of an instance in a replication group.
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public Task<ChangeInstanceRoleResponse> ChangeInstanceRole(ChangeInstanceRoleRequest req)
        {
            return InternalRequestAsync<ChangeInstanceRoleResponse>(req, "ChangeInstanceRole");
        }

        /// <summary>
        /// This API is used to modify the role of an instance in a replication group.
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public ChangeInstanceRoleResponse ChangeInstanceRoleSync(ChangeInstanceRoleRequest req)
        {
            return InternalRequestAsync<ChangeInstanceRoleResponse>(req, "ChangeInstanceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set a read-only instance in a replication group as a master instance.
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public Task<ChangeMasterInstanceResponse> ChangeMasterInstance(ChangeMasterInstanceRequest req)
        {
            return InternalRequestAsync<ChangeMasterInstanceResponse>(req, "ChangeMasterInstance");
        }

        /// <summary>
        /// This API is used to set a read-only instance in a replication group as a master instance.
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public ChangeMasterInstanceResponse ChangeMasterInstanceSync(ChangeMasterInstanceRequest req)
        {
            return InternalRequestAsync<ChangeMasterInstanceResponse>(req, "ChangeMasterInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to promote a replica node group to a master node group or a replica node to a master node for an instance.
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public Task<ChangeReplicaToMasterResponse> ChangeReplicaToMaster(ChangeReplicaToMasterRequest req)
        {
            return InternalRequestAsync<ChangeReplicaToMasterResponse>(req, "ChangeReplicaToMaster");
        }

        /// <summary>
        /// This API is used to promote a replica node group to a master node group or a replica node to a master node for an instance.
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public ChangeReplicaToMasterResponse ChangeReplicaToMasterSync(ChangeReplicaToMasterRequest req)
        {
            return InternalRequestAsync<ChangeReplicaToMasterResponse>(req, "ChangeReplicaToMaster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to eliminate an instance in the recycle bin immediately.
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public Task<CleanUpInstanceResponse> CleanUpInstance(CleanUpInstanceRequest req)
        {
            return InternalRequestAsync<CleanUpInstanceResponse>(req, "CleanUpInstance");
        }

        /// <summary>
        /// This API is used to eliminate an instance in the recycle bin immediately.
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public CleanUpInstanceResponse CleanUpInstanceSync(CleanUpInstanceRequest req)
        {
            return InternalRequestAsync<CleanUpInstanceResponse>(req, "CleanUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clear the data of a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public Task<ClearInstanceResponse> ClearInstance(ClearInstanceRequest req)
        {
            return InternalRequestAsync<ClearInstanceResponse>(req, "ClearInstance");
        }

        /// <summary>
        /// This API is used to clear the data of a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public ClearInstanceResponse ClearInstanceSync(ClearInstanceRequest req)
        {
            return InternalRequestAsync<ClearInstanceResponse>(req, "ClearInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clone a complete new instance based on the current instance backup file.
        /// </summary>
        /// <param name="req"><see cref="CloneInstancesRequest"/></param>
        /// <returns><see cref="CloneInstancesResponse"/></returns>
        public Task<CloneInstancesResponse> CloneInstances(CloneInstancesRequest req)
        {
            return InternalRequestAsync<CloneInstancesResponse>(req, "CloneInstances");
        }

        /// <summary>
        /// This API is used to clone a complete new instance based on the current instance backup file.
        /// </summary>
        /// <param name="req"><see cref="CloneInstancesRequest"/></param>
        /// <returns><see cref="CloneInstancesResponse"/></returns>
        public CloneInstancesResponse CloneInstancesSync(CloneInstancesRequest req)
        {
            return InternalRequestAsync<CloneInstancesResponse>(req, "CloneInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable SSL.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public Task<CloseSSLResponse> CloseSSL(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL");
        }

        /// <summary>
        /// This API is used to disable SSL.
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public CloseSSLResponse CloseSSLSync(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to customize the account for accessing the instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public Task<CreateInstanceAccountResponse> CreateInstanceAccount(CreateInstanceAccountRequest req)
        {
            return InternalRequestAsync<CreateInstanceAccountResponse>(req, "CreateInstanceAccount");
        }

        /// <summary>
        /// This API is used to customize the account for accessing the instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public CreateInstanceAccountResponse CreateInstanceAccountSync(CreateInstanceAccountRequest req)
        {
            return InternalRequestAsync<CreateInstanceAccountResponse>(req, "CreateInstanceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an TencentDB or Redis instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// This API is used to create an TencentDB or Redis instance.
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
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate");
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a replication group.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationGroupRequest"/></param>
        /// <returns><see cref="CreateReplicationGroupResponse"/></returns>
        public Task<CreateReplicationGroupResponse> CreateReplicationGroup(CreateReplicationGroupRequest req)
        {
            return InternalRequestAsync<CreateReplicationGroupResponse>(req, "CreateReplicationGroup");
        }

        /// <summary>
        /// This API is used to create a replication group.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationGroupRequest"/></param>
        /// <returns><see cref="CreateReplicationGroupResponse"/></returns>
        public CreateReplicationGroupResponse CreateReplicationGroupSync(CreateReplicationGroupRequest req)
        {
            return InternalRequestAsync<CreateReplicationGroupResponse>(req, "CreateReplicationGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public Task<DeleteInstanceAccountResponse> DeleteInstanceAccount(DeleteInstanceAccountRequest req)
        {
            return InternalRequestAsync<DeleteInstanceAccountResponse>(req, "DeleteInstanceAccount");
        }

        /// <summary>
        /// This API is used to delete an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public DeleteInstanceAccountResponse DeleteInstanceAccountSync(DeleteInstanceAccountRequest req)
        {
            return InternalRequestAsync<DeleteInstanceAccountResponse>(req, "DeleteInstanceAccount")
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
        /// This API is used to remove replication group members. Note: The API is being deprecated. Please use RemoveReplicationInstance instead.
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public Task<DeleteReplicationInstanceResponse> DeleteReplicationInstance(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance");
        }

        /// <summary>
        /// This API is used to remove replication group members. Note: The API is being deprecated. Please use RemoveReplicationInstance instead.
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public DeleteReplicationInstanceResponse DeleteReplicationInstanceSync(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the configuration rules for an automatic backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public Task<DescribeAutoBackupConfigResponse> DescribeAutoBackupConfig(DescribeAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupConfigResponse>(req, "DescribeAutoBackupConfig");
        }

        /// <summary>
        /// This API is used to get the configuration rules for an automatic backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public DescribeAutoBackupConfigResponse DescribeAutoBackupConfigSync(DescribeAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupConfigResponse>(req, "DescribeAutoBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download address for a database backup file in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to query the download address for a database backup file in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download address of a backup RDB file.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public Task<DescribeBackupUrlResponse> DescribeBackupUrl(DescribeBackupUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupUrlResponse>(req, "DescribeBackupUrl");
        }

        /// <summary>
        /// This API is used to query the download address of a backup RDB file.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public DescribeBackupUrlResponse DescribeBackupUrlSync(DescribeBackupUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupUrlResponse>(req, "DescribeBackupUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of instance bandwidth.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthRangeRequest"/></param>
        /// <returns><see cref="DescribeBandwidthRangeResponse"/></returns>
        public Task<DescribeBandwidthRangeResponse> DescribeBandwidthRange(DescribeBandwidthRangeRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthRangeResponse>(req, "DescribeBandwidthRange");
        }

        /// <summary>
        /// This API is used to query the information of instance bandwidth.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthRangeRequest"/></param>
        /// <returns><see cref="DescribeBandwidthRangeResponse"/></returns>
        public DescribeBandwidthRangeResponse DescribeBandwidthRangeSync(DescribeBandwidthRangeRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthRangeResponse>(req, "DescribeBandwidthRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API has been disused. It was used to query the list of Redis instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public Task<DescribeCommonDBInstancesResponse> DescribeCommonDBInstances(DescribeCommonDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCommonDBInstancesResponse>(req, "DescribeCommonDBInstances");
        }

        /// <summary>
        /// This API has been disused. It was used to query the list of Redis instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public DescribeCommonDBInstancesResponse DescribeCommonDBInstancesSync(DescribeCommonDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCommonDBInstancesResponse>(req, "DescribeCommonDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// This API is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public Task<DescribeInstanceAccountResponse> DescribeInstanceAccount(DescribeInstanceAccountRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAccountResponse>(req, "DescribeInstanceAccount");
        }

        /// <summary>
        /// This API is used to query the information of an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public DescribeInstanceAccountResponse DescribeInstanceAccountSync(DescribeInstanceAccountRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAccountResponse>(req, "DescribeInstanceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public Task<DescribeInstanceBackupsResponse> DescribeInstanceBackups(DescribeInstanceBackupsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBackupsResponse>(req, "DescribeInstanceBackups");
        }

        /// <summary>
        /// This API is used to query the backup list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public DescribeInstanceBackupsResponse DescribeInstanceBackupsSync(DescribeInstanceBackupsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBackupsResponse>(req, "DescribeInstanceBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the DTS task details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public Task<DescribeInstanceDTSInfoResponse> DescribeInstanceDTSInfo(DescribeInstanceDTSInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDTSInfoResponse>(req, "DescribeInstanceDTSInfo");
        }

        /// <summary>
        /// This API is used to query the DTS task details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public DescribeInstanceDTSInfoResponse DescribeInstanceDTSInfoSync(DescribeInstanceDTSInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDTSInfoResponse>(req, "DescribeInstanceDTSInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public Task<DescribeInstanceDealDetailResponse> DescribeInstanceDealDetail(DescribeInstanceDealDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDealDetailResponse>(req, "DescribeInstanceDealDetail");
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public DescribeInstanceDealDetailResponse DescribeInstanceDealDetailSync(DescribeInstanceDealDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDealDetailResponse>(req, "DescribeInstanceDealDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the event information on a TecentDB for Redis instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceEventsRequest"/></param>
        /// <returns><see cref="DescribeInstanceEventsResponse"/></returns>
        public Task<DescribeInstanceEventsResponse> DescribeInstanceEvents(DescribeInstanceEventsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceEventsResponse>(req, "DescribeInstanceEvents");
        }

        /// <summary>
        /// This API is used to query the event information on a TecentDB for Redis instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceEventsRequest"/></param>
        /// <returns><see cref="DescribeInstanceEventsResponse"/></returns>
        public DescribeInstanceEventsResponse DescribeInstanceEventsSync(DescribeInstanceEventsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceEventsResponse>(req, "DescribeInstanceEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API for querying big keys of a TencentDB for Redis instance was disused on October 31, 2022. For more information, see [API for Querying Instance Big Key Will Be Disused](https://intl.cloud.tencent.com/document/product/239/81005?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public Task<DescribeInstanceMonitorBigKeyResponse> DescribeInstanceMonitorBigKey(DescribeInstanceMonitorBigKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyResponse>(req, "DescribeInstanceMonitorBigKey");
        }

        /// <summary>
        /// The API for querying big keys of a TencentDB for Redis instance was disused on October 31, 2022. For more information, see [API for Querying Instance Big Key Will Be Disused](https://intl.cloud.tencent.com/document/product/239/81005?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public DescribeInstanceMonitorBigKeyResponse DescribeInstanceMonitorBigKeySync(DescribeInstanceMonitorBigKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyResponse>(req, "DescribeInstanceMonitorBigKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API for querying big keys of a TencentDB for Redis instance was disused on October 31, 2022. For more information, see [API for Querying Instance Big Key Will Be Disused](https://intl.cloud.tencent.com/document/product/239/81005?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public Task<DescribeInstanceMonitorBigKeySizeDistResponse> DescribeInstanceMonitorBigKeySizeDist(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeySizeDistResponse>(req, "DescribeInstanceMonitorBigKeySizeDist");
        }

        /// <summary>
        /// The API for querying big keys of a TencentDB for Redis instance was disused on October 31, 2022. For more information, see [API for Querying Instance Big Key Will Be Disused](https://intl.cloud.tencent.com/document/product/239/81005?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeySizeDistResponse DescribeInstanceMonitorBigKeySizeDistSync(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeySizeDistResponse>(req, "DescribeInstanceMonitorBigKeySizeDist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API for querying big keys of a TencentDB for Redis instance was disused on October 31, 2022. For more information, see [API for Querying Instance Big Key Will Be Disused](https://intl.cloud.tencent.com/document/product/239/81005?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public Task<DescribeInstanceMonitorBigKeyTypeDistResponse> DescribeInstanceMonitorBigKeyTypeDist(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyTypeDistResponse>(req, "DescribeInstanceMonitorBigKeyTypeDist");
        }

        /// <summary>
        /// The API for querying big keys of a TencentDB for Redis instance was disused on October 31, 2022. For more information, see [API for Querying Instance Big Key Will Be Disused](https://intl.cloud.tencent.com/document/product/239/81005?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeyTypeDistResponse DescribeInstanceMonitorBigKeyTypeDistSync(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyTypeDistResponse>(req, "DescribeInstanceMonitorBigKeyTypeDist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the hot key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public Task<DescribeInstanceMonitorHotKeyResponse> DescribeInstanceMonitorHotKey(DescribeInstanceMonitorHotKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorHotKeyResponse>(req, "DescribeInstanceMonitorHotKey");
        }

        /// <summary>
        /// This API is used to query the hot key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public DescribeInstanceMonitorHotKeyResponse DescribeInstanceMonitorHotKeySync(DescribeInstanceMonitorHotKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorHotKeyResponse>(req, "DescribeInstanceMonitorHotKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the access source information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public Task<DescribeInstanceMonitorSIPResponse> DescribeInstanceMonitorSIP(DescribeInstanceMonitorSIPRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorSIPResponse>(req, "DescribeInstanceMonitorSIP");
        }

        /// <summary>
        /// This API is used to query the access source information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public DescribeInstanceMonitorSIPResponse DescribeInstanceMonitorSIPSync(DescribeInstanceMonitorSIPRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorSIPResponse>(req, "DescribeInstanceMonitorSIP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the distribution of instance access duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public Task<DescribeInstanceMonitorTookDistResponse> DescribeInstanceMonitorTookDist(DescribeInstanceMonitorTookDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTookDistResponse>(req, "DescribeInstanceMonitorTookDist");
        }

        /// <summary>
        /// This API is used to query the distribution of instance access duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public DescribeInstanceMonitorTookDistResponse DescribeInstanceMonitorTookDistSync(DescribeInstanceMonitorTookDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTookDistResponse>(req, "DescribeInstanceMonitorTookDist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an instance access command.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public Task<DescribeInstanceMonitorTopNCmdResponse> DescribeInstanceMonitorTopNCmd(DescribeInstanceMonitorTopNCmdRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdResponse>(req, "DescribeInstanceMonitorTopNCmd");
        }

        /// <summary>
        /// This API is used to query an instance access command.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdResponse DescribeInstanceMonitorTopNCmdSync(DescribeInstanceMonitorTopNCmdRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdResponse>(req, "DescribeInstanceMonitorTopNCmd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance CPU time.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public Task<DescribeInstanceMonitorTopNCmdTookResponse> DescribeInstanceMonitorTopNCmdTook(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdTookResponse>(req, "DescribeInstanceMonitorTopNCmdTook");
        }

        /// <summary>
        /// This API is used to query the instance CPU time.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdTookResponse DescribeInstanceMonitorTopNCmdTookSync(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdTookResponse>(req, "DescribeInstanceMonitorTopNCmdTook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of an instance node.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo");
        }

        /// <summary>
        /// This API is used to query the information of an instance node.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of parameter modifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords");
        }

        /// <summary>
        /// This API is used to query the list of parameter modifications.
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
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public Task<DescribeInstanceSecurityGroupResponse> DescribeInstanceSecurityGroup(DescribeInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSecurityGroupResponse>(req, "DescribeInstanceSecurityGroup");
        }

        /// <summary>
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public DescribeInstanceSecurityGroupResponse DescribeInstanceSecurityGroupSync(DescribeInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSecurityGroupResponse>(req, "DescribeInstanceSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the shard information of the instance on cluster architecture.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public Task<DescribeInstanceShardsResponse> DescribeInstanceShards(DescribeInstanceShardsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceShardsResponse>(req, "DescribeInstanceShards");
        }

        /// <summary>
        /// This API is used to get the shard information of the instance on cluster architecture.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public DescribeInstanceShardsResponse DescribeInstanceShardsSync(DescribeInstanceShardsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceShardsResponse>(req, "DescribeInstanceShards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeInstanceSupportFeature) is used to query the supported features of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSupportFeatureRequest"/></param>
        /// <returns><see cref="DescribeInstanceSupportFeatureResponse"/></returns>
        public Task<DescribeInstanceSupportFeatureResponse> DescribeInstanceSupportFeature(DescribeInstanceSupportFeatureRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSupportFeatureResponse>(req, "DescribeInstanceSupportFeature");
        }

        /// <summary>
        /// This API (DescribeInstanceSupportFeature) is used to query the supported features of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSupportFeatureRequest"/></param>
        /// <returns><see cref="DescribeInstanceSupportFeatureResponse"/></returns>
        public DescribeInstanceSupportFeatureResponse DescribeInstanceSupportFeatureSync(DescribeInstanceSupportFeatureRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSupportFeatureResponse>(req, "DescribeInstanceSupportFeature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a Redis node.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public Task<DescribeInstanceZoneInfoResponse> DescribeInstanceZoneInfo(DescribeInstanceZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceZoneInfoResponse>(req, "DescribeInstanceZoneInfo");
        }

        /// <summary>
        /// This API is used to query the details of a Redis node.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public DescribeInstanceZoneInfoResponse DescribeInstanceZoneInfoSync(DescribeInstanceZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceZoneInfoResponse>(req, "DescribeInstanceZoneInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query the list of Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance maintenance window. The maintenance window specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public Task<DescribeMaintenanceWindowResponse> DescribeMaintenanceWindow(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow");
        }

        /// <summary>
        /// This API is used to query instance maintenance window. The maintenance window specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public DescribeMaintenanceWindowResponse DescribeMaintenanceWindowSync(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo");
        }

        /// <summary>
        /// This API is used to query the details of a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates");
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query purchasable TencentDB for Redis specifications in all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public Task<DescribeProductInfoResponse> DescribeProductInfo(DescribeProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeProductInfoResponse>(req, "DescribeProductInfo");
        }

        /// <summary>
        /// This API is used to query purchasable TencentDB for Redis specifications in all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public DescribeProductInfoResponse DescribeProductInfoSync(DescribeProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeProductInfoResponse>(req, "DescribeProductInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group information of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public Task<DescribeProjectSecurityGroupResponse> DescribeProjectSecurityGroup(DescribeProjectSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupResponse>(req, "DescribeProjectSecurityGroup");
        }

        /// <summary>
        /// This API is used to query the security group information of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public DescribeProjectSecurityGroupResponse DescribeProjectSecurityGroupSync(DescribeProjectSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupResponse>(req, "DescribeProjectSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// This API is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the slow queries of the proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public Task<DescribeProxySlowLogResponse> DescribeProxySlowLog(DescribeProxySlowLogRequest req)
        {
            return InternalRequestAsync<DescribeProxySlowLogResponse>(req, "DescribeProxySlowLog");
        }

        /// <summary>
        /// This API is used to query the slow queries of the proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public DescribeProxySlowLogResponse DescribeProxySlowLogSync(DescribeProxySlowLogRequest req)
        {
            return InternalRequestAsync<DescribeProxySlowLogResponse>(req, "DescribeProxySlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a replication group.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public Task<DescribeReplicationGroupResponse> DescribeReplicationGroup(DescribeReplicationGroupRequest req)
        {
            return InternalRequestAsync<DescribeReplicationGroupResponse>(req, "DescribeReplicationGroup");
        }

        /// <summary>
        /// This API is used to query a replication group.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public DescribeReplicationGroupResponse DescribeReplicationGroupSync(DescribeReplicationGroupRequest req)
        {
            return InternalRequestAsync<DescribeReplicationGroupResponse>(req, "DescribeReplicationGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the SSL authentication information of an instance, such as enablement status, configuration status, and certificate address.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public Task<DescribeSSLStatusResponse> DescribeSSLStatus(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus");
        }

        /// <summary>
        /// This API is used to query the SSL authentication information of an instance, such as enablement status, configuration status, and certificate address.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public DescribeSSLStatusResponse DescribeSSLStatusSync(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the records of slow query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogResponse>(req, "DescribeSlowLog");
        }

        /// <summary>
        /// This API is used to query the records of slow query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public DescribeSlowLogResponse DescribeSlowLogSync(DescribeSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogResponse>(req, "DescribeSlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the execution of a specified task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo");
        }

        /// <summary>
        /// This API is used to get the execution of a specified task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task list information of a specified instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList");
        }

        /// <summary>
        /// This API is used to query the task list information of a specified instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query slow queries of a Tendis instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public Task<DescribeTendisSlowLogResponse> DescribeTendisSlowLog(DescribeTendisSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeTendisSlowLogResponse>(req, "DescribeTendisSlowLog");
        }

        /// <summary>
        /// This API is used to query slow queries of a Tendis instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public DescribeTendisSlowLogResponse DescribeTendisSlowLogSync(DescribeTendisSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeTendisSlowLogResponse>(req, "DescribeTendisSlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public Task<DestroyPostpaidInstanceResponse> DestroyPostpaidInstance(DestroyPostpaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPostpaidInstanceResponse>(req, "DestroyPostpaidInstance");
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public DestroyPostpaidInstanceResponse DestroyPostpaidInstanceSync(DestroyPostpaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPostpaidInstanceResponse>(req, "DestroyPostpaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return a monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public Task<DestroyPrepaidInstanceResponse> DestroyPrepaidInstance(DestroyPrepaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrepaidInstanceResponse>(req, "DestroyPrepaidInstance");
        }

        /// <summary>
        /// This API is used to return a monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public DestroyPrepaidInstanceResponse DestroyPrepaidInstanceSync(DestroyPrepaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrepaidInstanceResponse>(req, "DestroyPrepaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public Task<DisableReplicaReadonlyResponse> DisableReplicaReadonly(DisableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<DisableReplicaReadonlyResponse>(req, "DisableReplicaReadonly");
        }

        /// <summary>
        /// This API is used to disable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public DisableReplicaReadonlyResponse DisableReplicaReadonlySync(DisableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<DisableReplicaReadonlyResponse>(req, "DisableReplicaReadonly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a security group from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to unbind a security group from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public Task<EnableReplicaReadonlyResponse> EnableReplicaReadonly(EnableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<EnableReplicaReadonlyResponse>(req, "EnableReplicaReadonly");
        }

        /// <summary>
        /// This API is used to enable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public EnableReplicaReadonlyResponse EnableReplicaReadonlySync(EnableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<EnableReplicaReadonlyResponse>(req, "EnableReplicaReadonly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for purchasing an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance");
        }

        /// <summary>
        /// This API is used to query the price for purchasing an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for scaling an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public Task<InquiryPriceUpgradeInstanceResponse> InquiryPriceUpgradeInstance(InquiryPriceUpgradeInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeInstanceResponse>(req, "InquiryPriceUpgradeInstance");
        }

        /// <summary>
        /// This API is used to query the price for scaling an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public InquiryPriceUpgradeInstanceResponse InquiryPriceUpgradeInstanceSync(InquiryPriceUpgradeInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeInstanceResponse>(req, "InquiryPriceUpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to simulate the failure.
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public Task<KillMasterGroupResponse> KillMasterGroup(KillMasterGroupRequest req)
        {
            return InternalRequestAsync<KillMasterGroupResponse>(req, "KillMasterGroup");
        }

        /// <summary>
        /// This API is used to simulate the failure.
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public KillMasterGroupResponse KillMasterGroupSync(KillMasterGroupRequest req)
        {
            return InternalRequestAsync<KillMasterGroupResponse>(req, "KillMasterGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manually back up a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public Task<ManualBackupInstanceResponse> ManualBackupInstance(ManualBackupInstanceRequest req)
        {
            return InternalRequestAsync<ManualBackupInstanceResponse>(req, "ManualBackupInstance");
        }

        /// <summary>
        /// This API is used to manually back up a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public ManualBackupInstanceResponse ManualBackupInstanceSync(ManualBackupInstanceRequest req)
        {
            return InternalRequestAsync<ManualBackupInstanceResponse>(req, "ManualBackupInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the access password for an instance.
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public Task<ModfiyInstancePasswordResponse> ModfiyInstancePassword(ModfiyInstancePasswordRequest req)
        {
            return InternalRequestAsync<ModfiyInstancePasswordResponse>(req, "ModfiyInstancePassword");
        }

        /// <summary>
        /// This API is used to modify the access password for an instance.
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public ModfiyInstancePasswordResponse ModfiyInstancePasswordSync(ModfiyInstancePasswordRequest req)
        {
            return InternalRequestAsync<ModfiyInstancePasswordResponse>(req, "ModfiyInstancePassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the configuration for an automatic backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public Task<ModifyAutoBackupConfigResponse> ModifyAutoBackupConfig(ModifyAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupConfigResponse>(req, "ModifyAutoBackupConfig");
        }

        /// <summary>
        /// This API is used to set the configuration for an automatic backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public ModifyAutoBackupConfigResponse ModifyAutoBackupConfigSync(ModifyAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupConfigResponse>(req, "ModifyAutoBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the network information and address for downloading a backup file.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction");
        }

        /// <summary>
        /// This API is used to modify the network information and address for downloading a backup file.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the connection configuration of an instance, including the bandwidth and maximum number of connections.
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public Task<ModifyConnectionConfigResponse> ModifyConnectionConfig(ModifyConnectionConfigRequest req)
        {
            return InternalRequestAsync<ModifyConnectionConfigResponse>(req, "ModifyConnectionConfig");
        }

        /// <summary>
        /// This API is used to modify the connection configuration of an instance, including the bandwidth and maximum number of connections.
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public ModifyConnectionConfigResponse ModifyConnectionConfigSync(ModifyConnectionConfigRequest req)
        {
            return InternalRequestAsync<ModifyConnectionConfigResponse>(req, "ModifyConnectionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API is used to modify the security groups bound to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to modify instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public Task<ModifyInstanceAccountResponse> ModifyInstanceAccount(ModifyInstanceAccountRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAccountResponse>(req, "ModifyInstanceAccount");
        }

        /// <summary>
        /// This API is used to modify an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public ModifyInstanceAccountResponse ModifyInstanceAccountSync(ModifyInstanceAccountRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAccountResponse>(req, "ModifyInstanceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the availability zone of the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAvailabilityZonesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAvailabilityZonesResponse"/></returns>
        public Task<ModifyInstanceAvailabilityZonesResponse> ModifyInstanceAvailabilityZones(ModifyInstanceAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAvailabilityZonesResponse>(req, "ModifyInstanceAvailabilityZones");
        }

        /// <summary>
        /// This API is used to change the availability zone of the instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAvailabilityZonesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAvailabilityZonesResponse"/></returns>
        public ModifyInstanceAvailabilityZonesResponse ModifyInstanceAvailabilityZonesSync(ModifyInstanceAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAvailabilityZonesResponse>(req, "ModifyInstanceAvailabilityZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the operations event execution schedule of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEventRequest"/></param>
        /// <returns><see cref="ModifyInstanceEventResponse"/></returns>
        public Task<ModifyInstanceEventResponse> ModifyInstanceEvent(ModifyInstanceEventRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEventResponse>(req, "ModifyInstanceEvent");
        }

        /// <summary>
        /// This API is used to modify the operations event execution schedule of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEventRequest"/></param>
        /// <returns><see cref="ModifyInstanceEventResponse"/></returns>
        public ModifyInstanceEventResponse ModifyInstanceEventSync(ModifyInstanceEventRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEventResponse>(req, "ModifyInstanceEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the parameters of TencentDB for Redis instances
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams");
        }

        /// <summary>
        /// This API is used to modify the parameters of TencentDB for Redis instances
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set instance input mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public Task<ModifyInstanceReadOnlyResponse> ModifyInstanceReadOnly(ModifyInstanceReadOnlyRequest req)
        {
            return InternalRequestAsync<ModifyInstanceReadOnlyResponse>(req, "ModifyInstanceReadOnly");
        }

        /// <summary>
        /// This API is used to set instance input mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public ModifyInstanceReadOnlyResponse ModifyInstanceReadOnlySync(ModifyInstanceReadOnlyRequest req)
        {
            return InternalRequestAsync<ModifyInstanceReadOnlyResponse>(req, "ModifyInstanceReadOnly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the instance maintenance time. The maintenance time specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business. Note: if the compatible version upgrade or architecture upgrade task has been initiated for an instance, its maintenance time cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public Task<ModifyMaintenanceWindowResponse> ModifyMaintenanceWindow(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow");
        }

        /// <summary>
        /// This API is used to modify the instance maintenance time. The maintenance time specifies a time period during which compatible version upgrade, architecture upgrade, backend maintenance, and other operations can be performed to avoid affecting business. Note: if the compatible version upgrade or architecture upgrade task has been initiated for an instance, its maintenance time cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public ModifyMaintenanceWindowResponse ModifyMaintenanceWindowSync(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the network configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public Task<ModifyNetworkConfigResponse> ModifyNetworkConfig(ModifyNetworkConfigRequest req)
        {
            return InternalRequestAsync<ModifyNetworkConfigResponse>(req, "ModifyNetworkConfig");
        }

        /// <summary>
        /// This API is used to modify the network configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public ModifyNetworkConfigResponse ModifyNetworkConfigSync(ModifyNetworkConfigRequest req)
        {
            return InternalRequestAsync<ModifyNetworkConfigResponse>(req, "ModifyNetworkConfig")
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
        /// This API is used to enable SSL.
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public Task<OpenSSLResponse> OpenSSL(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL");
        }

        /// <summary>
        /// This API is used to enable SSL.
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public OpenSSLResponse OpenSSLSync(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable public network access.
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public Task<ReleaseWanAddressResponse> ReleaseWanAddress(ReleaseWanAddressRequest req)
        {
            return InternalRequestAsync<ReleaseWanAddressResponse>(req, "ReleaseWanAddress");
        }

        /// <summary>
        /// This API is used to disable public network access.
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public ReleaseWanAddressResponse ReleaseWanAddressSync(ReleaseWanAddressRequest req)
        {
            return InternalRequestAsync<ReleaseWanAddressResponse>(req, "ReleaseWanAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a member from a replication group.
        /// </summary>
        /// <param name="req"><see cref="RemoveReplicationInstanceRequest"/></param>
        /// <returns><see cref="RemoveReplicationInstanceResponse"/></returns>
        public Task<RemoveReplicationInstanceResponse> RemoveReplicationInstance(RemoveReplicationInstanceRequest req)
        {
            return InternalRequestAsync<RemoveReplicationInstanceResponse>(req, "RemoveReplicationInstance");
        }

        /// <summary>
        /// This API is used to remove a member from a replication group.
        /// </summary>
        /// <param name="req"><see cref="RemoveReplicationInstanceRequest"/></param>
        /// <returns><see cref="RemoveReplicationInstanceResponse"/></returns>
        public RemoveReplicationInstanceResponse RemoveReplicationInstanceSync(RemoveReplicationInstanceRequest req)
        {
            return InternalRequestAsync<RemoveReplicationInstanceResponse>(req, "RemoveReplicationInstance")
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
        /// This API is used to reset a password.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword");
        }

        /// <summary>
        /// This API is used to reset a password.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restore a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance");
        }

        /// <summary>
        /// This API is used to restore a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deisolate an instance.
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public Task<StartupInstanceResponse> StartupInstance(StartupInstanceRequest req)
        {
            return InternalRequestAsync<StartupInstanceResponse>(req, "StartupInstance");
        }

        /// <summary>
        /// This API is used to deisolate an instance.
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public StartupInstanceResponse StartupInstanceSync(StartupInstanceRequest req)
        {
            return InternalRequestAsync<StartupInstanceResponse>(req, "StartupInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to immediately switch instances that are in the time window pending switch operation. Users can manually initiate this operation.
        /// </summary>
        /// <param name="req"><see cref="SwitchAccessNewInstanceRequest"/></param>
        /// <returns><see cref="SwitchAccessNewInstanceResponse"/></returns>
        public Task<SwitchAccessNewInstanceResponse> SwitchAccessNewInstance(SwitchAccessNewInstanceRequest req)
        {
            return InternalRequestAsync<SwitchAccessNewInstanceResponse>(req, "SwitchAccessNewInstance");
        }

        /// <summary>
        /// This API is used to immediately switch instances that are in the time window pending switch operation. Users can manually initiate this operation.
        /// </summary>
        /// <param name="req"><see cref="SwitchAccessNewInstanceRequest"/></param>
        /// <returns><see cref="SwitchAccessNewInstanceResponse"/></returns>
        public SwitchAccessNewInstanceResponse SwitchAccessNewInstanceSync(SwitchAccessNewInstanceRequest req)
        {
            return InternalRequestAsync<SwitchAccessNewInstanceResponse>(req, "SwitchAccessNewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to swap the VIPs of instances for instance disaster recovery switch in scenarios where cross-AZ disaster recovery is supported through DTS. After the VIPs of the source and target instances are swapped, the target instance can be written into and the DTS sync task between them will be disconnected.
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public Task<SwitchInstanceVipResponse> SwitchInstanceVip(SwitchInstanceVipRequest req)
        {
            return InternalRequestAsync<SwitchInstanceVipResponse>(req, "SwitchInstanceVip");
        }

        /// <summary>
        /// This API is used to swap the VIPs of instances for instance disaster recovery switch in scenarios where cross-AZ disaster recovery is supported through DTS. After the VIPs of the source and target instances are swapped, the target instance can be written into and the DTS sync task between them will be disconnected.
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public SwitchInstanceVipResponse SwitchInstanceVipSync(SwitchInstanceVipRequest req)
        {
            return InternalRequestAsync<SwitchInstanceVipResponse>(req, "SwitchInstanceVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to simulate the failure of a proxy node.
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public Task<SwitchProxyResponse> SwitchProxy(SwitchProxyRequest req)
        {
            return InternalRequestAsync<SwitchProxyResponse>(req, "SwitchProxy");
        }

        /// <summary>
        /// This API is used to simulate the failure of a proxy node.
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public SwitchProxyResponse SwitchProxySync(SwitchProxyRequest req)
        {
            return InternalRequestAsync<SwitchProxyResponse>(req, "SwitchProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the instance configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// This API is used to modify the instance configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the instance to a later version or to upgrade the current standard architecture to the cluster architecture.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersion(UpgradeInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceVersionResponse>(req, "UpgradeInstanceVersion");
        }

        /// <summary>
        /// This API is used to upgrade the instance to a later version or to upgrade the current standard architecture to the cluster architecture.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public UpgradeInstanceVersionResponse UpgradeInstanceVersionSync(UpgradeInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceVersionResponse>(req, "UpgradeInstanceVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade instance proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public Task<UpgradeProxyVersionResponse> UpgradeProxyVersion(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion");
        }

        /// <summary>
        /// This API is used to upgrade instance proxy version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public UpgradeProxyVersionResponse UpgradeProxyVersionSync(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade instance minor version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public Task<UpgradeSmallVersionResponse> UpgradeSmallVersion(UpgradeSmallVersionRequest req)
        {
            return InternalRequestAsync<UpgradeSmallVersionResponse>(req, "UpgradeSmallVersion");
        }

        /// <summary>
        /// This API is used to upgrade instance minor version.
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public UpgradeSmallVersionResponse UpgradeSmallVersionSync(UpgradeSmallVersionRequest req)
        {
            return InternalRequestAsync<UpgradeSmallVersionResponse>(req, "UpgradeSmallVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade an instance to support multi-AZ deployment.
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public Task<UpgradeVersionToMultiAvailabilityZonesResponse> UpgradeVersionToMultiAvailabilityZones(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<UpgradeVersionToMultiAvailabilityZonesResponse>(req, "UpgradeVersionToMultiAvailabilityZones");
        }

        /// <summary>
        /// This API is used to upgrade an instance to support multi-AZ deployment.
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public UpgradeVersionToMultiAvailabilityZonesResponse UpgradeVersionToMultiAvailabilityZonesSync(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<UpgradeVersionToMultiAvailabilityZonesResponse>(req, "UpgradeVersionToMultiAvailabilityZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
