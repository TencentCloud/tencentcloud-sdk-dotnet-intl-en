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

namespace TencentCloud.Chdfs.V20201112
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Chdfs.V20201112.Models;

   public class ChdfsClient : AbstractClient{

       private const string endpoint = "chdfs.tencentcloudapi.com";
       private const string version = "2020-11-12";
       private const string sdkVersion = "SDK_NET_3.0.1090";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ChdfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ChdfsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind multiple permission groups to a mount point.
        /// </summary>
        /// <param name="req"><see cref="AssociateAccessGroupsRequest"/></param>
        /// <returns><see cref="AssociateAccessGroupsResponse"/></returns>
        public Task<AssociateAccessGroupsResponse> AssociateAccessGroups(AssociateAccessGroupsRequest req)
        {
            return InternalRequestAsync<AssociateAccessGroupsResponse>(req, "AssociateAccessGroups");
        }

        /// <summary>
        /// This API is used to bind multiple permission groups to a mount point.
        /// </summary>
        /// <param name="req"><see cref="AssociateAccessGroupsRequest"/></param>
        /// <returns><see cref="AssociateAccessGroupsResponse"/></returns>
        public AssociateAccessGroupsResponse AssociateAccessGroupsSync(AssociateAccessGroupsRequest req)
        {
            return InternalRequestAsync<AssociateAccessGroupsResponse>(req, "AssociateAccessGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a permission group.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessGroupRequest"/></param>
        /// <returns><see cref="CreateAccessGroupResponse"/></returns>
        public Task<CreateAccessGroupResponse> CreateAccessGroup(CreateAccessGroupRequest req)
        {
            return InternalRequestAsync<CreateAccessGroupResponse>(req, "CreateAccessGroup");
        }

        /// <summary>
        /// This API is used to create a permission group.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessGroupRequest"/></param>
        /// <returns><see cref="CreateAccessGroupResponse"/></returns>
        public CreateAccessGroupResponse CreateAccessGroupSync(CreateAccessGroupRequest req)
        {
            return InternalRequestAsync<CreateAccessGroupResponse>(req, "CreateAccessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch create permission rules. You don't need to enter the permission rule IDs and creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessRulesRequest"/></param>
        /// <returns><see cref="CreateAccessRulesResponse"/></returns>
        public Task<CreateAccessRulesResponse> CreateAccessRules(CreateAccessRulesRequest req)
        {
            return InternalRequestAsync<CreateAccessRulesResponse>(req, "CreateAccessRules");
        }

        /// <summary>
        /// This API is used to batch create permission rules. You don't need to enter the permission rule IDs and creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessRulesRequest"/></param>
        /// <returns><see cref="CreateAccessRulesResponse"/></returns>
        public CreateAccessRulesResponse CreateAccessRulesSync(CreateAccessRulesRequest req)
        {
            return InternalRequestAsync<CreateAccessRulesResponse>(req, "CreateAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a file system (asynchronously).
        /// </summary>
        /// <param name="req"><see cref="CreateFileSystemRequest"/></param>
        /// <returns><see cref="CreateFileSystemResponse"/></returns>
        public Task<CreateFileSystemResponse> CreateFileSystem(CreateFileSystemRequest req)
        {
            return InternalRequestAsync<CreateFileSystemResponse>(req, "CreateFileSystem");
        }

        /// <summary>
        /// This API is used to create a file system (asynchronously).
        /// </summary>
        /// <param name="req"><see cref="CreateFileSystemRequest"/></param>
        /// <returns><see cref="CreateFileSystemResponse"/></returns>
        public CreateFileSystemResponse CreateFileSystemSync(CreateFileSystemRequest req)
        {
            return InternalRequestAsync<CreateFileSystemResponse>(req, "CreateFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch create lifecycle rules. You don't need to enter the lifecycle rule IDs and creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateLifeCycleRulesRequest"/></param>
        /// <returns><see cref="CreateLifeCycleRulesResponse"/></returns>
        public Task<CreateLifeCycleRulesResponse> CreateLifeCycleRules(CreateLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<CreateLifeCycleRulesResponse>(req, "CreateLifeCycleRules");
        }

        /// <summary>
        /// This API is used to batch create lifecycle rules. You don't need to enter the lifecycle rule IDs and creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateLifeCycleRulesRequest"/></param>
        /// <returns><see cref="CreateLifeCycleRulesResponse"/></returns>
        public CreateLifeCycleRulesResponse CreateLifeCycleRulesSync(CreateLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<CreateLifeCycleRulesResponse>(req, "CreateLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a mount point for a successfully created file system.
        /// </summary>
        /// <param name="req"><see cref="CreateMountPointRequest"/></param>
        /// <returns><see cref="CreateMountPointResponse"/></returns>
        public Task<CreateMountPointResponse> CreateMountPoint(CreateMountPointRequest req)
        {
            return InternalRequestAsync<CreateMountPointResponse>(req, "CreateMountPoint");
        }

        /// <summary>
        /// This API is used to create a mount point for a successfully created file system.
        /// </summary>
        /// <param name="req"><see cref="CreateMountPointRequest"/></param>
        /// <returns><see cref="CreateMountPointResponse"/></returns>
        public CreateMountPointResponse CreateMountPointSync(CreateMountPointRequest req)
        {
            return InternalRequestAsync<CreateMountPointResponse>(req, "CreateMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch create restoration tasks. You don't need to enter the restoration task IDs, status, and creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateRestoreTasksRequest"/></param>
        /// <returns><see cref="CreateRestoreTasksResponse"/></returns>
        public Task<CreateRestoreTasksResponse> CreateRestoreTasks(CreateRestoreTasksRequest req)
        {
            return InternalRequestAsync<CreateRestoreTasksResponse>(req, "CreateRestoreTasks");
        }

        /// <summary>
        /// This API is used to batch create restoration tasks. You don't need to enter the restoration task IDs, status, and creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateRestoreTasksRequest"/></param>
        /// <returns><see cref="CreateRestoreTasksResponse"/></returns>
        public CreateRestoreTasksResponse CreateRestoreTasksSync(CreateRestoreTasksRequest req)
        {
            return InternalRequestAsync<CreateRestoreTasksResponse>(req, "CreateRestoreTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a permission group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessGroupRequest"/></param>
        /// <returns><see cref="DeleteAccessGroupResponse"/></returns>
        public Task<DeleteAccessGroupResponse> DeleteAccessGroup(DeleteAccessGroupRequest req)
        {
            return InternalRequestAsync<DeleteAccessGroupResponse>(req, "DeleteAccessGroup");
        }

        /// <summary>
        /// This API is used to delete a permission group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessGroupRequest"/></param>
        /// <returns><see cref="DeleteAccessGroupResponse"/></returns>
        public DeleteAccessGroupResponse DeleteAccessGroupSync(DeleteAccessGroupRequest req)
        {
            return InternalRequestAsync<DeleteAccessGroupResponse>(req, "DeleteAccessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete permission rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessRulesResponse"/></returns>
        public Task<DeleteAccessRulesResponse> DeleteAccessRules(DeleteAccessRulesRequest req)
        {
            return InternalRequestAsync<DeleteAccessRulesResponse>(req, "DeleteAccessRules");
        }

        /// <summary>
        /// This API is used to batch delete permission rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessRulesResponse"/></returns>
        public DeleteAccessRulesResponse DeleteAccessRulesSync(DeleteAccessRulesRequest req)
        {
            return InternalRequestAsync<DeleteAccessRulesResponse>(req, "DeleteAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a file system. Non-empty file systems cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSystemRequest"/></param>
        /// <returns><see cref="DeleteFileSystemResponse"/></returns>
        public Task<DeleteFileSystemResponse> DeleteFileSystem(DeleteFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteFileSystemResponse>(req, "DeleteFileSystem");
        }

        /// <summary>
        /// This API is used to delete a file system. Non-empty file systems cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSystemRequest"/></param>
        /// <returns><see cref="DeleteFileSystemResponse"/></returns>
        public DeleteFileSystemResponse DeleteFileSystemSync(DeleteFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteFileSystemResponse>(req, "DeleteFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete lifecycle rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DeleteLifeCycleRulesResponse"/></returns>
        public Task<DeleteLifeCycleRulesResponse> DeleteLifeCycleRules(DeleteLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DeleteLifeCycleRulesResponse>(req, "DeleteLifeCycleRules");
        }

        /// <summary>
        /// This API is used to batch delete lifecycle rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DeleteLifeCycleRulesResponse"/></returns>
        public DeleteLifeCycleRulesResponse DeleteLifeCycleRulesSync(DeleteLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DeleteLifeCycleRulesResponse>(req, "DeleteLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a mount point.
        /// </summary>
        /// <param name="req"><see cref="DeleteMountPointRequest"/></param>
        /// <returns><see cref="DeleteMountPointResponse"/></returns>
        public Task<DeleteMountPointResponse> DeleteMountPoint(DeleteMountPointRequest req)
        {
            return InternalRequestAsync<DeleteMountPointResponse>(req, "DeleteMountPoint");
        }

        /// <summary>
        /// This API is used to delete a mount point.
        /// </summary>
        /// <param name="req"><see cref="DeleteMountPointRequest"/></param>
        /// <returns><see cref="DeleteMountPointResponse"/></returns>
        public DeleteMountPointResponse DeleteMountPointSync(DeleteMountPointRequest req)
        {
            return InternalRequestAsync<DeleteMountPointResponse>(req, "DeleteMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the details of a permission group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupResponse"/></returns>
        public Task<DescribeAccessGroupResponse> DescribeAccessGroup(DescribeAccessGroupRequest req)
        {
            return InternalRequestAsync<DescribeAccessGroupResponse>(req, "DescribeAccessGroup");
        }

        /// <summary>
        /// This API is used to view the details of a permission group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupResponse"/></returns>
        public DescribeAccessGroupResponse DescribeAccessGroupSync(DescribeAccessGroupRequest req)
        {
            return InternalRequestAsync<DescribeAccessGroupResponse>(req, "DescribeAccessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of permission groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupsResponse"/></returns>
        public Task<DescribeAccessGroupsResponse> DescribeAccessGroups(DescribeAccessGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccessGroupsResponse>(req, "DescribeAccessGroups");
        }

        /// <summary>
        /// This API is used to view the list of permission groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupsResponse"/></returns>
        public DescribeAccessGroupsResponse DescribeAccessGroupsSync(DescribeAccessGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccessGroupsResponse>(req, "DescribeAccessGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of permission rules by permission group ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessRulesResponse"/></returns>
        public Task<DescribeAccessRulesResponse> DescribeAccessRules(DescribeAccessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessRulesResponse>(req, "DescribeAccessRules");
        }

        /// <summary>
        /// This API is used to view the list of permission rules by permission group ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessRulesResponse"/></returns>
        public DescribeAccessRulesResponse DescribeAccessRulesSync(DescribeAccessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessRulesResponse>(req, "DescribeAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the details of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemRequest"/></param>
        /// <returns><see cref="DescribeFileSystemResponse"/></returns>
        public Task<DescribeFileSystemResponse> DescribeFileSystem(DescribeFileSystemRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemResponse>(req, "DescribeFileSystem");
        }

        /// <summary>
        /// This API is used to view the details of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemRequest"/></param>
        /// <returns><see cref="DescribeFileSystemResponse"/></returns>
        public DescribeFileSystemResponse DescribeFileSystemSync(DescribeFileSystemRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemResponse>(req, "DescribeFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of file systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemsResponse"/></returns>
        public Task<DescribeFileSystemsResponse> DescribeFileSystems(DescribeFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemsResponse>(req, "DescribeFileSystems");
        }

        /// <summary>
        /// This API is used to view the list of file systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemsResponse"/></returns>
        public DescribeFileSystemsResponse DescribeFileSystemsSync(DescribeFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemsResponse>(req, "DescribeFileSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of lifecycle rules by file system ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DescribeLifeCycleRulesResponse"/></returns>
        public Task<DescribeLifeCycleRulesResponse> DescribeLifeCycleRules(DescribeLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DescribeLifeCycleRulesResponse>(req, "DescribeLifeCycleRules");
        }

        /// <summary>
        /// This API is used to view the list of lifecycle rules by file system ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DescribeLifeCycleRulesResponse"/></returns>
        public DescribeLifeCycleRulesResponse DescribeLifeCycleRulesSync(DescribeLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DescribeLifeCycleRulesResponse>(req, "DescribeLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the details of a mount point.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointRequest"/></param>
        /// <returns><see cref="DescribeMountPointResponse"/></returns>
        public Task<DescribeMountPointResponse> DescribeMountPoint(DescribeMountPointRequest req)
        {
            return InternalRequestAsync<DescribeMountPointResponse>(req, "DescribeMountPoint");
        }

        /// <summary>
        /// This API is used to view the details of a mount point.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointRequest"/></param>
        /// <returns><see cref="DescribeMountPointResponse"/></returns>
        public DescribeMountPointResponse DescribeMountPointSync(DescribeMountPointRequest req)
        {
            return InternalRequestAsync<DescribeMountPointResponse>(req, "DescribeMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of mount points.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointsRequest"/></param>
        /// <returns><see cref="DescribeMountPointsResponse"/></returns>
        public Task<DescribeMountPointsResponse> DescribeMountPoints(DescribeMountPointsRequest req)
        {
            return InternalRequestAsync<DescribeMountPointsResponse>(req, "DescribeMountPoints");
        }

        /// <summary>
        /// This API is used to view the list of mount points.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointsRequest"/></param>
        /// <returns><see cref="DescribeMountPointsResponse"/></returns>
        public DescribeMountPointsResponse DescribeMountPointsSync(DescribeMountPointsRequest req)
        {
            return InternalRequestAsync<DescribeMountPointsResponse>(req, "DescribeMountPoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of resource tags by file system ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public Task<DescribeResourceTagsResponse> DescribeResourceTags(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags");
        }

        /// <summary>
        /// This API is used to view the list of resource tags by file system ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public DescribeResourceTagsResponse DescribeResourceTagsSync(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of restoration tasks by file system ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTasksRequest"/></param>
        /// <returns><see cref="DescribeRestoreTasksResponse"/></returns>
        public Task<DescribeRestoreTasksResponse> DescribeRestoreTasks(DescribeRestoreTasksRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTasksResponse>(req, "DescribeRestoreTasks");
        }

        /// <summary>
        /// This API is used to view the list of restoration tasks by file system ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTasksRequest"/></param>
        /// <returns><see cref="DescribeRestoreTasksResponse"/></returns>
        public DescribeRestoreTasksResponse DescribeRestoreTasksSync(DescribeRestoreTasksRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTasksResponse>(req, "DescribeRestoreTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind multiple permission groups from a mount point.
        /// </summary>
        /// <param name="req"><see cref="DisassociateAccessGroupsRequest"/></param>
        /// <returns><see cref="DisassociateAccessGroupsResponse"/></returns>
        public Task<DisassociateAccessGroupsResponse> DisassociateAccessGroups(DisassociateAccessGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateAccessGroupsResponse>(req, "DisassociateAccessGroups");
        }

        /// <summary>
        /// This API is used to unbind multiple permission groups from a mount point.
        /// </summary>
        /// <param name="req"><see cref="DisassociateAccessGroupsRequest"/></param>
        /// <returns><see cref="DisassociateAccessGroupsResponse"/></returns>
        public DisassociateAccessGroupsResponse DisassociateAccessGroupsSync(DisassociateAccessGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateAccessGroupsResponse>(req, "DisassociateAccessGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a permission group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessGroupRequest"/></param>
        /// <returns><see cref="ModifyAccessGroupResponse"/></returns>
        public Task<ModifyAccessGroupResponse> ModifyAccessGroup(ModifyAccessGroupRequest req)
        {
            return InternalRequestAsync<ModifyAccessGroupResponse>(req, "ModifyAccessGroup");
        }

        /// <summary>
        /// This API is used to modify the attributes of a permission group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessGroupRequest"/></param>
        /// <returns><see cref="ModifyAccessGroupResponse"/></returns>
        public ModifyAccessGroupResponse ModifyAccessGroupSync(ModifyAccessGroupRequest req)
        {
            return InternalRequestAsync<ModifyAccessGroupResponse>(req, "ModifyAccessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch modify the attributes of permission rules, such as address, access mode, and priority. You must specify the permission rule IDs.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessRulesRequest"/></param>
        /// <returns><see cref="ModifyAccessRulesResponse"/></returns>
        public Task<ModifyAccessRulesResponse> ModifyAccessRules(ModifyAccessRulesRequest req)
        {
            return InternalRequestAsync<ModifyAccessRulesResponse>(req, "ModifyAccessRules");
        }

        /// <summary>
        /// This API is used to batch modify the attributes of permission rules, such as address, access mode, and priority. You must specify the permission rule IDs.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessRulesRequest"/></param>
        /// <returns><see cref="ModifyAccessRulesResponse"/></returns>
        public ModifyAccessRulesResponse ModifyAccessRulesSync(ModifyAccessRulesRequest req)
        {
            return InternalRequestAsync<ModifyAccessRulesResponse>(req, "ModifyAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a successfully created file system.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemRequest"/></param>
        /// <returns><see cref="ModifyFileSystemResponse"/></returns>
        public Task<ModifyFileSystemResponse> ModifyFileSystem(ModifyFileSystemRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemResponse>(req, "ModifyFileSystem");
        }

        /// <summary>
        /// This API is used to modify the attributes of a successfully created file system.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemRequest"/></param>
        /// <returns><see cref="ModifyFileSystemResponse"/></returns>
        public ModifyFileSystemResponse ModifyFileSystemSync(ModifyFileSystemRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemResponse>(req, "ModifyFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch modify the attributes of lifecycle rules, such as name, path, transition list, and status. You must specify the lifecycle rule IDs.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifeCycleRulesRequest"/></param>
        /// <returns><see cref="ModifyLifeCycleRulesResponse"/></returns>
        public Task<ModifyLifeCycleRulesResponse> ModifyLifeCycleRules(ModifyLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<ModifyLifeCycleRulesResponse>(req, "ModifyLifeCycleRules");
        }

        /// <summary>
        /// This API is used to batch modify the attributes of lifecycle rules, such as name, path, transition list, and status. You must specify the lifecycle rule IDs.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifeCycleRulesRequest"/></param>
        /// <returns><see cref="ModifyLifeCycleRulesResponse"/></returns>
        public ModifyLifeCycleRulesResponse ModifyLifeCycleRulesSync(ModifyLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<ModifyLifeCycleRulesResponse>(req, "ModifyLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a mount point.
        /// </summary>
        /// <param name="req"><see cref="ModifyMountPointRequest"/></param>
        /// <returns><see cref="ModifyMountPointResponse"/></returns>
        public Task<ModifyMountPointResponse> ModifyMountPoint(ModifyMountPointRequest req)
        {
            return InternalRequestAsync<ModifyMountPointResponse>(req, "ModifyMountPoint");
        }

        /// <summary>
        /// This API is used to modify the attributes of a mount point.
        /// </summary>
        /// <param name="req"><see cref="ModifyMountPointRequest"/></param>
        /// <returns><see cref="ModifyMountPointResponse"/></returns>
        public ModifyMountPointResponse ModifyMountPointSync(ModifyMountPointRequest req)
        {
            return InternalRequestAsync<ModifyMountPointResponse>(req, "ModifyMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the list of resource tags by overwriting them all.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags");
        }

        /// <summary>
        /// This API is used to modify the list of resource tags by overwriting them all.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public ModifyResourceTagsResponse ModifyResourceTagsSync(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
