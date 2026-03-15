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
       private const string sdkVersion = "SDK_NET_3.0.1273";

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
        /// Create an instance backup set.
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public Task<CreateDBSBackupResponse> CreateDBSBackup(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup");
        }

        /// <summary>
        /// Create an instance backup set.
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public CreateDBSBackupResponse CreateDBSBackupSync(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete instance backup sets.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public Task<DeleteDBSBackupSetsResponse> DeleteDBSBackupSets(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets");
        }

        /// <summary>
        /// Delete instance backup sets.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public DeleteDBSBackupSetsResponse DeleteDBSBackupSetsSync(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets")
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
        /// Query recoverable time.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public Task<DescribeDBSAvailableRecoveryTimeResponse> DescribeDBSAvailableRecoveryTime(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime");
        }

        /// <summary>
        /// Query recoverable time.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public DescribeDBSAvailableRecoveryTimeResponse DescribeDBSAvailableRecoveryTimeSync(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query clone list of instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSCloneInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBSCloneInstancesResponse"/></returns>
        public Task<DescribeDBSCloneInstancesResponse> DescribeDBSCloneInstances(DescribeDBSCloneInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBSCloneInstancesResponse>(req, "DescribeDBSCloneInstances");
        }

        /// <summary>
        /// Query clone list of instances.
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
        /// Modify the instance backup strategy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public Task<ModifyDBSBackupPolicyResponse> ModifyDBSBackupPolicy(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy");
        }

        /// <summary>
        /// Modify the instance backup strategy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public ModifyDBSBackupPolicyResponse ModifyDBSBackupPolicySync(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the backup set remark.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupSetCommentRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupSetCommentResponse"/></returns>
        public Task<ModifyDBSBackupSetCommentResponse> ModifyDBSBackupSetComment(ModifyDBSBackupSetCommentRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupSetCommentResponse>(req, "ModifyDBSBackupSetComment");
        }

        /// <summary>
        /// Modify the backup set remark.
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

    }
}
