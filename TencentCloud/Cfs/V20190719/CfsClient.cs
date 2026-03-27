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

namespace TencentCloud.Cfs.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfs.V20190719.Models;

   public class CfsClient : AbstractClient{

       private const string endpoint = "cfs.intl.tencentcloudapi.com";
       private const string version = "2019-07-19";
       private const string sdkVersion = "SDK_NET_3.0.1281";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Configure the directory list associated with the lifecycle policy.
        /// </summary>
        /// <param name="req"><see cref="ApplyPathLifecyclePolicyRequest"/></param>
        /// <returns><see cref="ApplyPathLifecyclePolicyResponse"/></returns>
        public Task<ApplyPathLifecyclePolicyResponse> ApplyPathLifecyclePolicy(ApplyPathLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<ApplyPathLifecyclePolicyResponse>(req, "ApplyPathLifecyclePolicy");
        }

        /// <summary>
        /// Configure the directory list associated with the lifecycle policy.
        /// </summary>
        /// <param name="req"><see cref="ApplyPathLifecyclePolicyRequest"/></param>
        /// <returns><see cref="ApplyPathLifecyclePolicyResponse"/></returns>
        public ApplyPathLifecyclePolicyResponse ApplyPathLifecyclePolicySync(ApplyPathLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<ApplyPathLifecyclePolicyResponse>(req, "ApplyPathLifecyclePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind one or multiple file systems to a snapshot policy. A file system can be bound to only one policy.
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public Task<BindAutoSnapshotPolicyResponse> BindAutoSnapshotPolicy(BindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoSnapshotPolicyResponse>(req, "BindAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API is used to bind one or multiple file systems to a snapshot policy. A file system can be bound to only one policy.
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public BindAutoSnapshotPolicyResponse BindAutoSnapshotPolicySync(BindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoSnapshotPolicyResponse>(req, "BindAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a scheduled snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoSnapshotPolicyResponse>(req, "CreateAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API is used to create a scheduled snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicySync(CreateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoSnapshotPolicyResponse>(req, "CreateAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a file system.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public Task<CreateCfsFileSystemResponse> CreateCfsFileSystem(CreateCfsFileSystemRequest req)
        {
            return InternalRequestAsync<CreateCfsFileSystemResponse>(req, "CreateCfsFileSystem");
        }

        /// <summary>
        /// This API is used to create a file system.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public CreateCfsFileSystemResponse CreateCfsFileSystemSync(CreateCfsFileSystemRequest req)
        {
            return InternalRequestAsync<CreateCfsFileSystemResponse>(req, "CreateCfsFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a permission group.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public Task<CreateCfsPGroupResponse> CreateCfsPGroup(CreateCfsPGroupRequest req)
        {
            return InternalRequestAsync<CreateCfsPGroupResponse>(req, "CreateCfsPGroup");
        }

        /// <summary>
        /// This API is used to create a permission group.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public CreateCfsPGroupResponse CreateCfsPGroupSync(CreateCfsPGroupRequest req)
        {
            return InternalRequestAsync<CreateCfsPGroupResponse>(req, "CreateCfsPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public Task<CreateCfsRuleResponse> CreateCfsRule(CreateCfsRuleRequest req)
        {
            return InternalRequestAsync<CreateCfsRuleResponse>(req, "CreateCfsRule");
        }

        /// <summary>
        /// This API is used to create a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public CreateCfsRuleResponse CreateCfsRuleSync(CreateCfsRuleRequest req)
        {
            return InternalRequestAsync<CreateCfsRuleResponse>(req, "CreateCfsRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a file system snapshot.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsSnapshotRequest"/></param>
        /// <returns><see cref="CreateCfsSnapshotResponse"/></returns>
        public Task<CreateCfsSnapshotResponse> CreateCfsSnapshot(CreateCfsSnapshotRequest req)
        {
            return InternalRequestAsync<CreateCfsSnapshotResponse>(req, "CreateCfsSnapshot");
        }

        /// <summary>
        /// This API is used to create a file system snapshot.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsSnapshotRequest"/></param>
        /// <returns><see cref="CreateCfsSnapshotResponse"/></returns>
        public CreateCfsSnapshotResponse CreateCfsSnapshotSync(CreateCfsSnapshotRequest req)
        {
            return InternalRequestAsync<CreateCfsSnapshotResponse>(req, "CreateCfsSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data flow.
        /// </summary>
        /// <param name="req"><see cref="CreateDataFlowRequest"/></param>
        /// <returns><see cref="CreateDataFlowResponse"/></returns>
        public Task<CreateDataFlowResponse> CreateDataFlow(CreateDataFlowRequest req)
        {
            return InternalRequestAsync<CreateDataFlowResponse>(req, "CreateDataFlow");
        }

        /// <summary>
        /// This API is used to create a data flow.
        /// </summary>
        /// <param name="req"><see cref="CreateDataFlowRequest"/></param>
        /// <returns><see cref="CreateDataFlowResponse"/></returns>
        public CreateDataFlowResponse CreateDataFlowSync(CreateDataFlowRequest req)
        {
            return InternalRequestAsync<CreateDataFlowResponse>(req, "CreateDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Support proactive settlement/preheat API.
        /// </summary>
        /// <param name="req"><see cref="CreateLifecycleDataTaskRequest"/></param>
        /// <returns><see cref="CreateLifecycleDataTaskResponse"/></returns>
        public Task<CreateLifecycleDataTaskResponse> CreateLifecycleDataTask(CreateLifecycleDataTaskRequest req)
        {
            return InternalRequestAsync<CreateLifecycleDataTaskResponse>(req, "CreateLifecycleDataTask");
        }

        /// <summary>
        /// Support proactive settlement/preheat API.
        /// </summary>
        /// <param name="req"><see cref="CreateLifecycleDataTaskRequest"/></param>
        /// <returns><see cref="CreateLifecycleDataTaskResponse"/></returns>
        public CreateLifecycleDataTaskResponse CreateLifecycleDataTaskSync(CreateLifecycleDataTaskRequest req)
        {
            return InternalRequestAsync<CreateLifecycleDataTaskResponse>(req, "CreateLifecycleDataTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a file storage lifecycle policy.
        /// </summary>
        /// <param name="req"><see cref="CreateLifecyclePolicyRequest"/></param>
        /// <returns><see cref="CreateLifecyclePolicyResponse"/></returns>
        public Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicy(CreateLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<CreateLifecyclePolicyResponse>(req, "CreateLifecyclePolicy");
        }

        /// <summary>
        /// This API is used to create a file storage lifecycle policy.
        /// </summary>
        /// <param name="req"><see cref="CreateLifecyclePolicyRequest"/></param>
        /// <returns><see cref="CreateLifecyclePolicyResponse"/></returns>
        public CreateLifecyclePolicyResponse CreateLifecyclePolicySync(CreateLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<CreateLifecyclePolicyResponse>(req, "CreateLifecyclePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Download the file list in a lifecycle task.
        /// </summary>
        /// <param name="req"><see cref="CreateLifecyclePolicyDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLifecyclePolicyDownloadTaskResponse"/></returns>
        public Task<CreateLifecyclePolicyDownloadTaskResponse> CreateLifecyclePolicyDownloadTask(CreateLifecyclePolicyDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLifecyclePolicyDownloadTaskResponse>(req, "CreateLifecyclePolicyDownloadTask");
        }

        /// <summary>
        /// Download the file list in a lifecycle task.
        /// </summary>
        /// <param name="req"><see cref="CreateLifecyclePolicyDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLifecyclePolicyDownloadTaskResponse"/></returns>
        public CreateLifecyclePolicyDownloadTaskResponse CreateLifecyclePolicyDownloadTaskSync(CreateLifecyclePolicyDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLifecyclePolicyDownloadTaskResponse>(req, "CreateLifecyclePolicyDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a migration task.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationTaskRequest"/></param>
        /// <returns><see cref="CreateMigrationTaskResponse"/></returns>
        public Task<CreateMigrationTaskResponse> CreateMigrationTask(CreateMigrationTaskRequest req)
        {
            return InternalRequestAsync<CreateMigrationTaskResponse>(req, "CreateMigrationTask");
        }

        /// <summary>
        /// This API is used to create a migration task.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationTaskRequest"/></param>
        /// <returns><see cref="CreateMigrationTaskResponse"/></returns>
        public CreateMigrationTaskResponse CreateMigrationTaskSync(CreateMigrationTaskRequest req)
        {
            return InternalRequestAsync<CreateMigrationTaskResponse>(req, "CreateMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a scheduled snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPolicyResponse"/></returns>
        public Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicy(DeleteAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAutoSnapshotPolicyResponse>(req, "DeleteAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API is used to delete a scheduled snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPolicyResponse"/></returns>
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicySync(DeleteAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAutoSnapshotPolicyResponse>(req, "DeleteAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a file system.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public Task<DeleteCfsFileSystemResponse> DeleteCfsFileSystem(DeleteCfsFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteCfsFileSystemResponse>(req, "DeleteCfsFileSystem");
        }

        /// <summary>
        /// This API is used to delete a file system.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public DeleteCfsFileSystemResponse DeleteCfsFileSystemSync(DeleteCfsFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteCfsFileSystemResponse>(req, "DeleteCfsFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a permission group. Only permission groups not bound to a file system can be deleted by this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public Task<DeleteCfsPGroupResponse> DeleteCfsPGroup(DeleteCfsPGroupRequest req)
        {
            return InternalRequestAsync<DeleteCfsPGroupResponse>(req, "DeleteCfsPGroup");
        }

        /// <summary>
        /// This API is used to delete a permission group. Only permission groups not bound to a file system can be deleted by this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public DeleteCfsPGroupResponse DeleteCfsPGroupSync(DeleteCfsPGroupRequest req)
        {
            return InternalRequestAsync<DeleteCfsPGroupResponse>(req, "DeleteCfsPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public Task<DeleteCfsRuleResponse> DeleteCfsRule(DeleteCfsRuleRequest req)
        {
            return InternalRequestAsync<DeleteCfsRuleResponse>(req, "DeleteCfsRule");
        }

        /// <summary>
        /// This API is used to delete a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public DeleteCfsRuleResponse DeleteCfsRuleSync(DeleteCfsRuleRequest req)
        {
            return InternalRequestAsync<DeleteCfsRuleResponse>(req, "DeleteCfsRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a file system snapshot.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsSnapshotRequest"/></param>
        /// <returns><see cref="DeleteCfsSnapshotResponse"/></returns>
        public Task<DeleteCfsSnapshotResponse> DeleteCfsSnapshot(DeleteCfsSnapshotRequest req)
        {
            return InternalRequestAsync<DeleteCfsSnapshotResponse>(req, "DeleteCfsSnapshot");
        }

        /// <summary>
        /// This API is used to delete a file system snapshot.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsSnapshotRequest"/></param>
        /// <returns><see cref="DeleteCfsSnapshotResponse"/></returns>
        public DeleteCfsSnapshotResponse DeleteCfsSnapshotSync(DeleteCfsSnapshotRequest req)
        {
            return InternalRequestAsync<DeleteCfsSnapshotResponse>(req, "DeleteCfsSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a data flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteDataFlowRequest"/></param>
        /// <returns><see cref="DeleteDataFlowResponse"/></returns>
        public Task<DeleteDataFlowResponse> DeleteDataFlow(DeleteDataFlowRequest req)
        {
            return InternalRequestAsync<DeleteDataFlowResponse>(req, "DeleteDataFlow");
        }

        /// <summary>
        /// Delete a data flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteDataFlowRequest"/></param>
        /// <returns><see cref="DeleteDataFlowResponse"/></returns>
        public DeleteDataFlowResponse DeleteDataFlowSync(DeleteDataFlowRequest req)
        {
            return InternalRequestAsync<DeleteDataFlowResponse>(req, "DeleteDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a lifecycle management policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecyclePolicyRequest"/></param>
        /// <returns><see cref="DeleteLifecyclePolicyResponse"/></returns>
        public Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<DeleteLifecyclePolicyResponse>(req, "DeleteLifecyclePolicy");
        }

        /// <summary>
        /// Delete a lifecycle management policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecyclePolicyRequest"/></param>
        /// <returns><see cref="DeleteLifecyclePolicyResponse"/></returns>
        public DeleteLifecyclePolicyResponse DeleteLifecyclePolicySync(DeleteLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<DeleteLifecyclePolicyResponse>(req, "DeleteLifecyclePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete migration tasks. Deletion is not supported for tasks in the status of Waiting, creating, running, canceling, or terminating.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationTaskRequest"/></param>
        /// <returns><see cref="DeleteMigrationTaskResponse"/></returns>
        public Task<DeleteMigrationTaskResponse> DeleteMigrationTask(DeleteMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteMigrationTaskResponse>(req, "DeleteMigrationTask");
        }

        /// <summary>
        /// This API is used to delete migration tasks. Deletion is not supported for tasks in the status of Waiting, creating, running, canceling, or terminating.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationTaskRequest"/></param>
        /// <returns><see cref="DeleteMigrationTaskResponse"/></returns>
        public DeleteMigrationTaskResponse DeleteMigrationTaskSync(DeleteMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteMigrationTaskResponse>(req, "DeleteMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of scheduled snapshot policies of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoSnapshotPoliciesResponse>(req, "DescribeAutoSnapshotPolicies");
        }

        /// <summary>
        /// This API is used to query the list of scheduled snapshot policies of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPoliciesSync(DescribeAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoSnapshotPoliciesResponse>(req, "DescribeAutoSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the availability of a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public Task<DescribeAvailableZoneInfoResponse> DescribeAvailableZoneInfo(DescribeAvailableZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeAvailableZoneInfoResponse>(req, "DescribeAvailableZoneInfo");
        }

        /// <summary>
        /// This API is used to query the availability of a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public DescribeAvailableZoneInfoResponse DescribeAvailableZoneInfoSync(DescribeAvailableZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeAvailableZoneInfoResponse>(req, "DescribeAvailableZoneInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// To obtain the list of data source buckets.
        /// </summary>
        /// <param name="req"><see cref="DescribeBucketListRequest"/></param>
        /// <returns><see cref="DescribeBucketListResponse"/></returns>
        public Task<DescribeBucketListResponse> DescribeBucketList(DescribeBucketListRequest req)
        {
            return InternalRequestAsync<DescribeBucketListResponse>(req, "DescribeBucketList");
        }

        /// <summary>
        /// To obtain the list of data source buckets.
        /// </summary>
        /// <param name="req"><see cref="DescribeBucketListRequest"/></param>
        /// <returns><see cref="DescribeBucketListResponse"/></returns>
        public DescribeBucketListResponse DescribeBucketListSync(DescribeBucketListRequest req)
        {
            return InternalRequestAsync<DescribeBucketListResponse>(req, "DescribeBucketList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query clients on which this file system is mounted. To do so, the client needs to have the CFS monitoring plugin installed.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public Task<DescribeCfsFileSystemClientsResponse> DescribeCfsFileSystemClients(DescribeCfsFileSystemClientsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemClientsResponse>(req, "DescribeCfsFileSystemClients");
        }

        /// <summary>
        /// This API is used to query clients on which this file system is mounted. To do so, the client needs to have the CFS monitoring plugin installed.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public DescribeCfsFileSystemClientsResponse DescribeCfsFileSystemClientsSync(DescribeCfsFileSystemClientsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemClientsResponse>(req, "DescribeCfsFileSystemClients")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query file systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public Task<DescribeCfsFileSystemsResponse> DescribeCfsFileSystems(DescribeCfsFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemsResponse>(req, "DescribeCfsFileSystems");
        }

        /// <summary>
        /// This API is used to query file systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public DescribeCfsFileSystemsResponse DescribeCfsFileSystemsSync(DescribeCfsFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemsResponse>(req, "DescribeCfsFileSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of permission groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public Task<DescribeCfsPGroupsResponse> DescribeCfsPGroups(DescribeCfsPGroupsRequest req)
        {
            return InternalRequestAsync<DescribeCfsPGroupsResponse>(req, "DescribeCfsPGroups");
        }

        /// <summary>
        /// This API is used to query the list of permission groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public DescribeCfsPGroupsResponse DescribeCfsPGroupsSync(DescribeCfsPGroupsRequest req)
        {
            return InternalRequestAsync<DescribeCfsPGroupsResponse>(req, "DescribeCfsPGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of permission group rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public Task<DescribeCfsRulesResponse> DescribeCfsRules(DescribeCfsRulesRequest req)
        {
            return InternalRequestAsync<DescribeCfsRulesResponse>(req, "DescribeCfsRules");
        }

        /// <summary>
        /// This API is used to query the list of permission group rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public DescribeCfsRulesResponse DescribeCfsRulesSync(DescribeCfsRulesRequest req)
        {
            return InternalRequestAsync<DescribeCfsRulesResponse>(req, "DescribeCfsRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of the CFS service.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public Task<DescribeCfsServiceStatusResponse> DescribeCfsServiceStatus(DescribeCfsServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeCfsServiceStatusResponse>(req, "DescribeCfsServiceStatus");
        }

        /// <summary>
        /// This API is used to query the status of the CFS service.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public DescribeCfsServiceStatusResponse DescribeCfsServiceStatusSync(DescribeCfsServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeCfsServiceStatusResponse>(req, "DescribeCfsServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the snapshot overview of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotOverviewRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotOverviewResponse"/></returns>
        public Task<DescribeCfsSnapshotOverviewResponse> DescribeCfsSnapshotOverview(DescribeCfsSnapshotOverviewRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotOverviewResponse>(req, "DescribeCfsSnapshotOverview");
        }

        /// <summary>
        /// This API is used to get the snapshot overview of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotOverviewRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotOverviewResponse"/></returns>
        public DescribeCfsSnapshotOverviewResponse DescribeCfsSnapshotOverviewSync(DescribeCfsSnapshotOverviewRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotOverviewResponse>(req, "DescribeCfsSnapshotOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of snapshots of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotsResponse"/></returns>
        public Task<DescribeCfsSnapshotsResponse> DescribeCfsSnapshots(DescribeCfsSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotsResponse>(req, "DescribeCfsSnapshots");
        }

        /// <summary>
        /// This API is used to query the list of snapshots of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotsResponse"/></returns>
        public DescribeCfsSnapshotsResponse DescribeCfsSnapshotsSync(DescribeCfsSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotsResponse>(req, "DescribeCfsSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query data flow information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFlowRequest"/></param>
        /// <returns><see cref="DescribeDataFlowResponse"/></returns>
        public Task<DescribeDataFlowResponse> DescribeDataFlow(DescribeDataFlowRequest req)
        {
            return InternalRequestAsync<DescribeDataFlowResponse>(req, "DescribeDataFlow");
        }

        /// <summary>
        /// This API is used to query data flow information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFlowRequest"/></param>
        /// <returns><see cref="DescribeDataFlowResponse"/></returns>
        public DescribeDataFlowResponse DescribeDataFlowSync(DescribeDataFlowRequest req)
        {
            return InternalRequestAsync<DescribeDataFlowResponse>(req, "DescribeDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the lifecycle task. It only supports querying task data within 3 months.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecycleDataTaskRequest"/></param>
        /// <returns><see cref="DescribeLifecycleDataTaskResponse"/></returns>
        public Task<DescribeLifecycleDataTaskResponse> DescribeLifecycleDataTask(DescribeLifecycleDataTaskRequest req)
        {
            return InternalRequestAsync<DescribeLifecycleDataTaskResponse>(req, "DescribeLifecycleDataTask");
        }

        /// <summary>
        /// This API is used to query the lifecycle task. It only supports querying task data within 3 months.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecycleDataTaskRequest"/></param>
        /// <returns><see cref="DescribeLifecycleDataTaskResponse"/></returns>
        public DescribeLifecycleDataTaskResponse DescribeLifecycleDataTaskSync(DescribeLifecycleDataTaskRequest req)
        {
            return InternalRequestAsync<DescribeLifecycleDataTaskResponse>(req, "DescribeLifecycleDataTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query lifecycle management policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecyclePoliciesRequest"/></param>
        /// <returns><see cref="DescribeLifecyclePoliciesResponse"/></returns>
        public Task<DescribeLifecyclePoliciesResponse> DescribeLifecyclePolicies(DescribeLifecyclePoliciesRequest req)
        {
            return InternalRequestAsync<DescribeLifecyclePoliciesResponse>(req, "DescribeLifecyclePolicies");
        }

        /// <summary>
        /// Query lifecycle management policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecyclePoliciesRequest"/></param>
        /// <returns><see cref="DescribeLifecyclePoliciesResponse"/></returns>
        public DescribeLifecyclePoliciesResponse DescribeLifecyclePoliciesSync(DescribeLifecyclePoliciesRequest req)
        {
            return InternalRequestAsync<DescribeLifecyclePoliciesResponse>(req, "DescribeLifecyclePolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of migration tasks.
        /// To use this API, submit a ticket for us to add you to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTasksRequest"/></param>
        /// <returns><see cref="DescribeMigrationTasksResponse"/></returns>
        public Task<DescribeMigrationTasksResponse> DescribeMigrationTasks(DescribeMigrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTasksResponse>(req, "DescribeMigrationTasks");
        }

        /// <summary>
        /// This API is used to get the list of migration tasks.
        /// To use this API, submit a ticket for us to add you to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTasksRequest"/></param>
        /// <returns><see cref="DescribeMigrationTasksResponse"/></returns>
        public DescribeMigrationTasksResponse DescribeMigrationTasksSync(DescribeMigrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTasksResponse>(req, "DescribeMigrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mount targets of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public Task<DescribeMountTargetsResponse> DescribeMountTargets(DescribeMountTargetsRequest req)
        {
            return InternalRequestAsync<DescribeMountTargetsResponse>(req, "DescribeMountTargets");
        }

        /// <summary>
        /// This API is used to query the mount targets of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public DescribeMountTargetsResponse DescribeMountTargetsSync(DescribeMountTargetsRequest req)
        {
            return InternalRequestAsync<DescribeMountTargetsResponse>(req, "DescribeMountTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the operation logs of a snapshot.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public Task<DescribeSnapshotOperationLogsResponse> DescribeSnapshotOperationLogs(DescribeSnapshotOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotOperationLogsResponse>(req, "DescribeSnapshotOperationLogs");
        }

        /// <summary>
        /// This API is used to query the operation logs of a snapshot.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public DescribeSnapshotOperationLogsResponse DescribeSnapshotOperationLogsSync(DescribeSnapshotOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotOperationLogsResponse>(req, "DescribeSnapshotOperationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// File system directory operation API. Currently, only the Turbo series file system supports calling this API to perform directory operations. The Universal Series file system (including the enhanced version) does not support calling.
        /// </summary>
        /// <param name="req"><see cref="DoDirectoryOperationRequest"/></param>
        /// <returns><see cref="DoDirectoryOperationResponse"/></returns>
        public Task<DoDirectoryOperationResponse> DoDirectoryOperation(DoDirectoryOperationRequest req)
        {
            return InternalRequestAsync<DoDirectoryOperationResponse>(req, "DoDirectoryOperation");
        }

        /// <summary>
        /// File system directory operation API. Currently, only the Turbo series file system supports calling this API to perform directory operations. The Universal Series file system (including the enhanced version) does not support calling.
        /// </summary>
        /// <param name="req"><see cref="DoDirectoryOperationRequest"/></param>
        /// <returns><see cref="DoDirectoryOperationResponse"/></returns>
        public DoDirectoryOperationResponse DoDirectoryOperationSync(DoDirectoryOperationRequest req)
        {
            return InternalRequestAsync<DoDirectoryOperationResponse>(req, "DoDirectoryOperation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify data flow parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDataFlowRequest"/></param>
        /// <returns><see cref="ModifyDataFlowResponse"/></returns>
        public Task<ModifyDataFlowResponse> ModifyDataFlow(ModifyDataFlowRequest req)
        {
            return InternalRequestAsync<ModifyDataFlowResponse>(req, "ModifyDataFlow");
        }

        /// <summary>
        /// Modify data flow parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDataFlowRequest"/></param>
        /// <returns><see cref="ModifyDataFlowResponse"/></returns>
        public ModifyDataFlowResponse ModifyDataFlowSync(ModifyDataFlowRequest req)
        {
            return InternalRequestAsync<ModifyDataFlowResponse>(req, "ModifyDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the file system scaling policy. It supports only the turbo file system.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemAutoScaleUpRuleRequest"/></param>
        /// <returns><see cref="ModifyFileSystemAutoScaleUpRuleResponse"/></returns>
        public Task<ModifyFileSystemAutoScaleUpRuleResponse> ModifyFileSystemAutoScaleUpRule(ModifyFileSystemAutoScaleUpRuleRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemAutoScaleUpRuleResponse>(req, "ModifyFileSystemAutoScaleUpRule");
        }

        /// <summary>
        /// This API is used to set the file system scaling policy. It supports only the turbo file system.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemAutoScaleUpRuleRequest"/></param>
        /// <returns><see cref="ModifyFileSystemAutoScaleUpRuleResponse"/></returns>
        public ModifyFileSystemAutoScaleUpRuleResponse ModifyFileSystemAutoScaleUpRuleSync(ModifyFileSystemAutoScaleUpRuleRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemAutoScaleUpRuleResponse>(req, "ModifyFileSystemAutoScaleUpRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a file storage lifecycle policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecyclePolicyRequest"/></param>
        /// <returns><see cref="ModifyLifecyclePolicyResponse"/></returns>
        public Task<ModifyLifecyclePolicyResponse> ModifyLifecyclePolicy(ModifyLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<ModifyLifecyclePolicyResponse>(req, "ModifyLifecyclePolicy");
        }

        /// <summary>
        /// Update a file storage lifecycle policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecyclePolicyRequest"/></param>
        /// <returns><see cref="ModifyLifecyclePolicyResponse"/></returns>
        public ModifyLifecyclePolicyResponse ModifyLifecyclePolicySync(ModifyLifecyclePolicyRequest req)
        {
            return InternalRequestAsync<ModifyLifecyclePolicyResponse>(req, "ModifyLifecyclePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to expand the turbo file system. It only supports expansion and does not support scale-down. The scaling increment for the turbo standard type is 10240 GIB, and for the turbo performance type, it is 5120 GIB.
        /// </summary>
        /// <param name="req"><see cref="ScaleUpFileSystemRequest"/></param>
        /// <returns><see cref="ScaleUpFileSystemResponse"/></returns>
        public Task<ScaleUpFileSystemResponse> ScaleUpFileSystem(ScaleUpFileSystemRequest req)
        {
            return InternalRequestAsync<ScaleUpFileSystemResponse>(req, "ScaleUpFileSystem");
        }

        /// <summary>
        /// This API is used to expand the turbo file system. It only supports expansion and does not support scale-down. The scaling increment for the turbo standard type is 10240 GIB, and for the turbo performance type, it is 5120 GIB.
        /// </summary>
        /// <param name="req"><see cref="ScaleUpFileSystemRequest"/></param>
        /// <returns><see cref="ScaleUpFileSystemResponse"/></returns>
        public ScaleUpFileSystemResponse ScaleUpFileSystemSync(ScaleUpFileSystemRequest req)
        {
            return InternalRequestAsync<ScaleUpFileSystemResponse>(req, "ScaleUpFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to activate the CFS service.
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public Task<SignUpCfsServiceResponse> SignUpCfsService(SignUpCfsServiceRequest req)
        {
            return InternalRequestAsync<SignUpCfsServiceResponse>(req, "SignUpCfsService");
        }

        /// <summary>
        /// This API is used to activate the CFS service.
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public SignUpCfsServiceResponse SignUpCfsServiceSync(SignUpCfsServiceRequest req)
        {
            return InternalRequestAsync<SignUpCfsServiceResponse>(req, "SignUpCfsService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a lifecycle task.
        /// </summary>
        /// <param name="req"><see cref="StopLifecycleDataTaskRequest"/></param>
        /// <returns><see cref="StopLifecycleDataTaskResponse"/></returns>
        public Task<StopLifecycleDataTaskResponse> StopLifecycleDataTask(StopLifecycleDataTaskRequest req)
        {
            return InternalRequestAsync<StopLifecycleDataTaskResponse>(req, "StopLifecycleDataTask");
        }

        /// <summary>
        /// This API is used to terminate a lifecycle task.
        /// </summary>
        /// <param name="req"><see cref="StopLifecycleDataTaskRequest"/></param>
        /// <returns><see cref="StopLifecycleDataTaskResponse"/></returns>
        public StopLifecycleDataTaskResponse StopLifecycleDataTaskSync(StopLifecycleDataTaskRequest req)
        {
            return InternalRequestAsync<StopLifecycleDataTaskResponse>(req, "StopLifecycleDataTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a migration task, including tasks in the Waiting or Running status.
        /// </summary>
        /// <param name="req"><see cref="StopMigrationTaskRequest"/></param>
        /// <returns><see cref="StopMigrationTaskResponse"/></returns>
        public Task<StopMigrationTaskResponse> StopMigrationTask(StopMigrationTaskRequest req)
        {
            return InternalRequestAsync<StopMigrationTaskResponse>(req, "StopMigrationTask");
        }

        /// <summary>
        /// This API is used to terminate a migration task, including tasks in the Waiting or Running status.
        /// </summary>
        /// <param name="req"><see cref="StopMigrationTaskRequest"/></param>
        /// <returns><see cref="StopMigrationTaskResponse"/></returns>
        public StopMigrationTaskResponse StopMigrationTaskSync(StopMigrationTaskRequest req)
        {
            return InternalRequestAsync<StopMigrationTaskResponse>(req, "StopMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a snapshot policy from a file system.
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public Task<UnbindAutoSnapshotPolicyResponse> UnbindAutoSnapshotPolicy(UnbindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoSnapshotPolicyResponse>(req, "UnbindAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API is used to unbind a snapshot policy from a file system.
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public UnbindAutoSnapshotPolicyResponse UnbindAutoSnapshotPolicySync(UnbindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoSnapshotPolicyResponse>(req, "UnbindAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a scheduled snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="UpdateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UpdateAutoSnapshotPolicyResponse"/></returns>
        public Task<UpdateAutoSnapshotPolicyResponse> UpdateAutoSnapshotPolicy(UpdateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UpdateAutoSnapshotPolicyResponse>(req, "UpdateAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API is used to update a scheduled snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="UpdateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UpdateAutoSnapshotPolicyResponse"/></returns>
        public UpdateAutoSnapshotPolicyResponse UpdateAutoSnapshotPolicySync(UpdateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UpdateAutoSnapshotPolicyResponse>(req, "UpdateAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a file system name.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public Task<UpdateCfsFileSystemNameResponse> UpdateCfsFileSystemName(UpdateCfsFileSystemNameRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemNameResponse>(req, "UpdateCfsFileSystemName");
        }

        /// <summary>
        /// This API is used to update a file system name.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public UpdateCfsFileSystemNameResponse UpdateCfsFileSystemNameSync(UpdateCfsFileSystemNameRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemNameResponse>(req, "UpdateCfsFileSystemName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the permission group used by a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public Task<UpdateCfsFileSystemPGroupResponse> UpdateCfsFileSystemPGroup(UpdateCfsFileSystemPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemPGroupResponse>(req, "UpdateCfsFileSystemPGroup");
        }

        /// <summary>
        /// This API is used to update the permission group used by a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public UpdateCfsFileSystemPGroupResponse UpdateCfsFileSystemPGroupSync(UpdateCfsFileSystemPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemPGroupResponse>(req, "UpdateCfsFileSystemPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the capacity limit of a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public Task<UpdateCfsFileSystemSizeLimitResponse> UpdateCfsFileSystemSizeLimit(UpdateCfsFileSystemSizeLimitRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemSizeLimitResponse>(req, "UpdateCfsFileSystemSizeLimit");
        }

        /// <summary>
        /// This API is used to update the capacity limit of a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public UpdateCfsFileSystemSizeLimitResponse UpdateCfsFileSystemSizeLimitSync(UpdateCfsFileSystemSizeLimitRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemSizeLimitResponse>(req, "UpdateCfsFileSystemSizeLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the information of a permission group.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public Task<UpdateCfsPGroupResponse> UpdateCfsPGroup(UpdateCfsPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsPGroupResponse>(req, "UpdateCfsPGroup");
        }

        /// <summary>
        /// This API is used to update the information of a permission group.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public UpdateCfsPGroupResponse UpdateCfsPGroupSync(UpdateCfsPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsPGroupResponse>(req, "UpdateCfsPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a permission rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public Task<UpdateCfsRuleResponse> UpdateCfsRule(UpdateCfsRuleRequest req)
        {
            return InternalRequestAsync<UpdateCfsRuleResponse>(req, "UpdateCfsRule");
        }

        /// <summary>
        /// This API is used to update a permission rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public UpdateCfsRuleResponse UpdateCfsRuleSync(UpdateCfsRuleRequest req)
        {
            return InternalRequestAsync<UpdateCfsRuleResponse>(req, "UpdateCfsRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the name and retention period of a file system snapshot.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsSnapshotAttributeRequest"/></param>
        /// <returns><see cref="UpdateCfsSnapshotAttributeResponse"/></returns>
        public Task<UpdateCfsSnapshotAttributeResponse> UpdateCfsSnapshotAttribute(UpdateCfsSnapshotAttributeRequest req)
        {
            return InternalRequestAsync<UpdateCfsSnapshotAttributeResponse>(req, "UpdateCfsSnapshotAttribute");
        }

        /// <summary>
        /// This API is used to update the name and retention period of a file system snapshot.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsSnapshotAttributeRequest"/></param>
        /// <returns><see cref="UpdateCfsSnapshotAttributeResponse"/></returns>
        public UpdateCfsSnapshotAttributeResponse UpdateCfsSnapshotAttributeSync(UpdateCfsSnapshotAttributeRequest req)
        {
            return InternalRequestAsync<UpdateCfsSnapshotAttributeResponse>(req, "UpdateCfsSnapshotAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
