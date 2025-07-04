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

namespace TencentCloud.Cbs.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cbs.V20170312.Models;

   public class CbsClient : AbstractClient{

       private const string endpoint = "cbs.intl.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1164";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CbsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CbsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to roll back a backup point to the original cloud disk.
        /// 
        /// * Only rollback to the original cloud disk is supported. For a data disk backup point, if you want to copy the backup point data to another cloud disk, use the `CreateSnapshot` API to convert the backup point into a snapshot, use the `CreateDisks` API to create an elastic cloud disk, and then copy the snapshot data to it.
        /// * Only backup points in `NORMAL` status can be rolled back. To query the status of a backup point, call the `DescribeDiskBackups` API and see the `BackupState` field in the response.
        /// * For an elastic cloud disk, it must be in unattached status. To query the status of the cloud disk, call the `DescribeDisks` API and see the `Attached` field in the response. For a non-elastic cloud disk purchased together with an instance, the instance must be in shutdown status, which can be queried through the `DescribeInstancesStatus` API.
        /// </summary>
        /// <param name="req"><see cref="ApplyDiskBackupRequest"/></param>
        /// <returns><see cref="ApplyDiskBackupResponse"/></returns>
        public Task<ApplyDiskBackupResponse> ApplyDiskBackup(ApplyDiskBackupRequest req)
        {
            return InternalRequestAsync<ApplyDiskBackupResponse>(req, "ApplyDiskBackup");
        }

        /// <summary>
        /// This API is used to roll back a backup point to the original cloud disk.
        /// 
        /// * Only rollback to the original cloud disk is supported. For a data disk backup point, if you want to copy the backup point data to another cloud disk, use the `CreateSnapshot` API to convert the backup point into a snapshot, use the `CreateDisks` API to create an elastic cloud disk, and then copy the snapshot data to it.
        /// * Only backup points in `NORMAL` status can be rolled back. To query the status of a backup point, call the `DescribeDiskBackups` API and see the `BackupState` field in the response.
        /// * For an elastic cloud disk, it must be in unattached status. To query the status of the cloud disk, call the `DescribeDisks` API and see the `Attached` field in the response. For a non-elastic cloud disk purchased together with an instance, the instance must be in shutdown status, which can be queried through the `DescribeInstancesStatus` API.
        /// </summary>
        /// <param name="req"><see cref="ApplyDiskBackupRequest"/></param>
        /// <returns><see cref="ApplyDiskBackupResponse"/></returns>
        public ApplyDiskBackupResponse ApplyDiskBackupSync(ApplyDiskBackupRequest req)
        {
            return InternalRequestAsync<ApplyDiskBackupResponse>(req, "ApplyDiskBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ApplySnapshot) is used to roll back a snapshot to the original cloud disk.
        /// 
        /// * The snapshot can only be rolled back to the original cloud disk. For data disk snapshots, if you need to copy the snapshot data to other cloud disks, use the API [CreateDisks](https://intl.cloud.tencent.com/document/product/362/16312?from_cn_redirect=1) to create an elastic cloud disk and then copy the snapshot data to the created cloud disk. 
        /// * The snapshot for rollback must be in NORMAL status. The snapshot status can be queried in the SnapshotState field in the output parameters through the API [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1).
        /// * For elastic cloud disks, the cloud disk must be in UNMOUNTED status. The cloud disk status can be queried in the Attached field returned by the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1). For non-elastic cloud disks purchased together with instances, the instance must be in SHUTDOWN status. The instance status can be queried through the API [DescribeInstancesStatus](https://intl.cloud.tencent.com/document/product/213/15738?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplySnapshotRequest"/></param>
        /// <returns><see cref="ApplySnapshotResponse"/></returns>
        public Task<ApplySnapshotResponse> ApplySnapshot(ApplySnapshotRequest req)
        {
            return InternalRequestAsync<ApplySnapshotResponse>(req, "ApplySnapshot");
        }

        /// <summary>
        /// This API (ApplySnapshot) is used to roll back a snapshot to the original cloud disk.
        /// 
        /// * The snapshot can only be rolled back to the original cloud disk. For data disk snapshots, if you need to copy the snapshot data to other cloud disks, use the API [CreateDisks](https://intl.cloud.tencent.com/document/product/362/16312?from_cn_redirect=1) to create an elastic cloud disk and then copy the snapshot data to the created cloud disk. 
        /// * The snapshot for rollback must be in NORMAL status. The snapshot status can be queried in the SnapshotState field in the output parameters through the API [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1).
        /// * For elastic cloud disks, the cloud disk must be in UNMOUNTED status. The cloud disk status can be queried in the Attached field returned by the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1). For non-elastic cloud disks purchased together with instances, the instance must be in SHUTDOWN status. The instance status can be queried through the API [DescribeInstancesStatus](https://intl.cloud.tencent.com/document/product/213/15738?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplySnapshotRequest"/></param>
        /// <returns><see cref="ApplySnapshotResponse"/></returns>
        public ApplySnapshotResponse ApplySnapshotSync(ApplySnapshotRequest req)
        {
            return InternalRequestAsync<ApplySnapshotResponse>(req, "ApplySnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to mount one or more cloud disks.
        ///  
        /// * Batch operation is supported. You can mount multiple cloud disks to one CVM in a single request. If any of these cloud disks cannot be mounted, the operation fails and a specific error code returns.
        /// * This is an async API. A successful request indicates that the mounting is initiated. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query the status of cloud disks. If the status changes from `ATTACHING` to `ATTACHED`, the mounting is successful.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks");
        }

        /// <summary>
        /// This API is used to mount one or more cloud disks.
        ///  
        /// * Batch operation is supported. You can mount multiple cloud disks to one CVM in a single request. If any of these cloud disks cannot be mounted, the operation fails and a specific error code returns.
        /// * This is an async API. A successful request indicates that the mounting is initiated. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query the status of cloud disks. If the status changes from `ATTACHING` to `ATTACHED`, the mounting is successful.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (BindAutoSnapshotPolicy) is used to bind the cloud disk to the specified scheduled snapshot policy.
        /// 
        /// * For the scheduled snapshot policy limit of each region, see [Scheduled Snapshots](https://intl.cloud.tencent.com/document/product/362/8191?from_cn_redirect=1).
        /// * When a cloud disk that is bound to a scheduled snapshot policy is in the unused state (that is, an elastic cloud disk has not been mounted or the server of an inelastic disk is powered off) scheduled snapshots are not created.
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public Task<BindAutoSnapshotPolicyResponse> BindAutoSnapshotPolicy(BindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoSnapshotPolicyResponse>(req, "BindAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API (BindAutoSnapshotPolicy) is used to bind the cloud disk to the specified scheduled snapshot policy.
        /// 
        /// * For the scheduled snapshot policy limit of each region, see [Scheduled Snapshots](https://intl.cloud.tencent.com/document/product/362/8191?from_cn_redirect=1).
        /// * When a cloud disk that is bound to a scheduled snapshot policy is in the unused state (that is, an elastic cloud disk has not been mounted or the server of an inelastic disk is powered off) scheduled snapshots are not created.
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public BindAutoSnapshotPolicyResponse BindAutoSnapshotPolicySync(BindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoSnapshotPolicyResponse>(req, "BindAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replicate a snapshot to another region.
        /// 
        /// * This is an async API. A new snapshot ID is issued when the cross-region replication task is generated. It does not mean that the snapshot has been replicated successfully. You can all the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API in the destination region to check for this snapshot. If the snapshot status is `NORMAL`, the snapshot is replicated successfully.
        /// * The snapshot cross-region replication service will be commercialized in the Q3 of 2022. We will notify users about the commercialization in advance. Please check your messages in the Message Center.
        /// </summary>
        /// <param name="req"><see cref="CopySnapshotCrossRegionsRequest"/></param>
        /// <returns><see cref="CopySnapshotCrossRegionsResponse"/></returns>
        public Task<CopySnapshotCrossRegionsResponse> CopySnapshotCrossRegions(CopySnapshotCrossRegionsRequest req)
        {
            return InternalRequestAsync<CopySnapshotCrossRegionsResponse>(req, "CopySnapshotCrossRegions");
        }

        /// <summary>
        /// This API is used to replicate a snapshot to another region.
        /// 
        /// * This is an async API. A new snapshot ID is issued when the cross-region replication task is generated. It does not mean that the snapshot has been replicated successfully. You can all the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API in the destination region to check for this snapshot. If the snapshot status is `NORMAL`, the snapshot is replicated successfully.
        /// * The snapshot cross-region replication service will be commercialized in the Q3 of 2022. We will notify users about the commercialization in advance. Please check your messages in the Message Center.
        /// </summary>
        /// <param name="req"><see cref="CopySnapshotCrossRegionsRequest"/></param>
        /// <returns><see cref="CopySnapshotCrossRegionsResponse"/></returns>
        public CopySnapshotCrossRegionsResponse CopySnapshotCrossRegionsSync(CopySnapshotCrossRegionsRequest req)
        {
            return InternalRequestAsync<CopySnapshotCrossRegionsResponse>(req, "CopySnapshotCrossRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateAutoSnapshotPolicy) is used to create a scheduled snapshot policy.
        /// 
        /// * For the limits on the number of scheduled snapshot policies that can be created in each region, see [Scheduled Snapshots](https://intl.cloud.tencent.com/document/product/362/8191?from_cn_redirect=1).
        /// * The quantity and capacity of the snapshots that can be created in each region are limited. For more information, see the **Snapshots** page on the Tencent Cloud Console. If the number of snapshots exceeds the quota, the creation of the scheduled snapshots will fail.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoSnapshotPolicyResponse>(req, "CreateAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API (CreateAutoSnapshotPolicy) is used to create a scheduled snapshot policy.
        /// 
        /// * For the limits on the number of scheduled snapshot policies that can be created in each region, see [Scheduled Snapshots](https://intl.cloud.tencent.com/document/product/362/8191?from_cn_redirect=1).
        /// * The quantity and capacity of the snapshots that can be created in each region are limited. For more information, see the **Snapshots** page on the Tencent Cloud Console. If the number of snapshots exceeds the quota, the creation of the scheduled snapshots will fail.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicySync(CreateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoSnapshotPolicyResponse>(req, "CreateAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a backup point for a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="CreateDiskBackupRequest"/></param>
        /// <returns><see cref="CreateDiskBackupResponse"/></returns>
        public Task<CreateDiskBackupResponse> CreateDiskBackup(CreateDiskBackupRequest req)
        {
            return InternalRequestAsync<CreateDiskBackupResponse>(req, "CreateDiskBackup");
        }

        /// <summary>
        /// This API is used to create a backup point for a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="CreateDiskBackupRequest"/></param>
        /// <returns><see cref="CreateDiskBackupResponse"/></returns>
        public CreateDiskBackupResponse CreateDiskBackupSync(CreateDiskBackupRequest req)
        {
            return InternalRequestAsync<CreateDiskBackupResponse>(req, "CreateDiskBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create cloud disks.
        /// 
        /// * This API supports creating a cloud disk with a data disk snapshot so that the snapshot data can be copied to the purchased cloud disk.
        /// * This API is async. A cloud disk ID list will be returned when a request is made successfully, but it does not mean that the creation has been completed. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query cloud disks by `DiskId`. If a new cloud disk can be found and its status is `UNATTACHED` or `ATTACHED`, the cloud disk has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public Task<CreateDisksResponse> CreateDisks(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks");
        }

        /// <summary>
        /// This API is used to create cloud disks.
        /// 
        /// * This API supports creating a cloud disk with a data disk snapshot so that the snapshot data can be copied to the purchased cloud disk.
        /// * This API is async. A cloud disk ID list will be returned when a request is made successfully, but it does not mean that the creation has been completed. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query cloud disks by `DiskId`. If a new cloud disk can be found and its status is `UNATTACHED` or `ATTACHED`, the cloud disk has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public CreateDisksResponse CreateDisksSync(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a snapshot for the specified cloud disk.
        /// 
        /// * You can only create snapshots for cloud disks with the snapshot capability. To check whether a cloud disk is snapshot-enabled, call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API and see the `SnapshotAbility` field in the response.
        /// * For the maximum number of snapshots that can be created, see [Use Limits](https://intl.cloud.tencent.com/doc/product/362/5145?from_cn_redirect=1).
        /// * Currently, you can convert backup points into general snapshots. After the conversion, snapshot usage fees may be charged, backup points will not be retained, and the occupied backup point quota will be released.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotRequest"/></param>
        /// <returns><see cref="CreateSnapshotResponse"/></returns>
        public Task<CreateSnapshotResponse> CreateSnapshot(CreateSnapshotRequest req)
        {
            return InternalRequestAsync<CreateSnapshotResponse>(req, "CreateSnapshot");
        }

        /// <summary>
        /// This API is used to create a snapshot for the specified cloud disk.
        /// 
        /// * You can only create snapshots for cloud disks with the snapshot capability. To check whether a cloud disk is snapshot-enabled, call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API and see the `SnapshotAbility` field in the response.
        /// * For the maximum number of snapshots that can be created, see [Use Limits](https://intl.cloud.tencent.com/doc/product/362/5145?from_cn_redirect=1).
        /// * Currently, you can convert backup points into general snapshots. After the conversion, snapshot usage fees may be charged, backup points will not be retained, and the occupied backup point quota will be released.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotRequest"/></param>
        /// <returns><see cref="CreateSnapshotResponse"/></returns>
        public CreateSnapshotResponse CreateSnapshotSync(CreateSnapshotRequest req)
        {
            return InternalRequestAsync<CreateSnapshotResponse>(req, "CreateSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteAutoSnapshotPolicies) is used to delete scheduled snapshot policies.
        /// 
        /// * Batch operations are supported. If one of the scheduled snapshot policies in a batch cannot be deleted, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPoliciesResponse"/></returns>
        public Task<DeleteAutoSnapshotPoliciesResponse> DeleteAutoSnapshotPolicies(DeleteAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteAutoSnapshotPoliciesResponse>(req, "DeleteAutoSnapshotPolicies");
        }

        /// <summary>
        /// This API (DeleteAutoSnapshotPolicies) is used to delete scheduled snapshot policies.
        /// 
        /// * Batch operations are supported. If one of the scheduled snapshot policies in a batch cannot be deleted, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPoliciesResponse"/></returns>
        public DeleteAutoSnapshotPoliciesResponse DeleteAutoSnapshotPoliciesSync(DeleteAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteAutoSnapshotPoliciesResponse>(req, "DeleteAutoSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the backup points of the specified cloud disk in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteDiskBackupsRequest"/></param>
        /// <returns><see cref="DeleteDiskBackupsResponse"/></returns>
        public Task<DeleteDiskBackupsResponse> DeleteDiskBackups(DeleteDiskBackupsRequest req)
        {
            return InternalRequestAsync<DeleteDiskBackupsResponse>(req, "DeleteDiskBackups");
        }

        /// <summary>
        /// This API is used to delete the backup points of the specified cloud disk in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteDiskBackupsRequest"/></param>
        /// <returns><see cref="DeleteDiskBackupsResponse"/></returns>
        public DeleteDiskBackupsResponse DeleteDiskBackupsSync(DeleteDiskBackupsRequest req)
        {
            return InternalRequestAsync<DeleteDiskBackupsResponse>(req, "DeleteDiskBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete snapshots.
        /// 
        /// * Only snapshots in the `NORMAL` state can be deleted. To query the state of a snapshot, you can call the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API and check the `SnapshotState` field in the response.
        /// * Batch operations are supported. If there is any snapshot that cannot be deleted, the operation will not be performed and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots");
        }

        /// <summary>
        /// This API is used to delete snapshots.
        /// 
        /// * Only snapshots in the `NORMAL` state can be deleted. To query the state of a snapshot, you can call the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API and check the `SnapshotState` field in the response.
        /// * Batch operations are supported. If there is any snapshot that cannot be deleted, the operation will not be performed and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query scheduled snapshot policies.
        /// 
        /// * You can filter scheduled snapshot policies by ID, name, state, etc. The relationship between different filters is logical `AND`. For details on filters, see `Filter`.
        /// * If no parameter is specified, a certain number of scheduled snapshot policies under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoSnapshotPoliciesResponse>(req, "DescribeAutoSnapshotPolicies");
        }

        /// <summary>
        /// This API is used to query scheduled snapshot policies.
        /// 
        /// * You can filter scheduled snapshot policies by ID, name, state, etc. The relationship between different filters is logical `AND`. For details on filters, see `Filter`.
        /// * If no parameter is specified, a certain number of scheduled snapshot policies under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPoliciesSync(DescribeAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoSnapshotPoliciesResponse>(req, "DescribeAutoSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDiskAssociatedAutoSnapshotPolicy) is used to query the scheduled snapshot policy bound to a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskAssociatedAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DescribeDiskAssociatedAutoSnapshotPolicyResponse"/></returns>
        public Task<DescribeDiskAssociatedAutoSnapshotPolicyResponse> DescribeDiskAssociatedAutoSnapshotPolicy(DescribeDiskAssociatedAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDiskAssociatedAutoSnapshotPolicyResponse>(req, "DescribeDiskAssociatedAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API (DescribeDiskAssociatedAutoSnapshotPolicy) is used to query the scheduled snapshot policy bound to a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskAssociatedAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DescribeDiskAssociatedAutoSnapshotPolicyResponse"/></returns>
        public DescribeDiskAssociatedAutoSnapshotPolicyResponse DescribeDiskAssociatedAutoSnapshotPolicySync(DescribeDiskAssociatedAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDiskAssociatedAutoSnapshotPolicyResponse>(req, "DescribeDiskAssociatedAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of backup points.
        /// 
        /// You can filter results by backup point ID. You can also look for certain backup points by specifying the ID or type of the cloud disk for which the backup points are created. The relationship between different filters is logical `AND`. For more information on filters, see `Filter`.
        /// If the parameter is empty, a certain number (as specified by `Limit` and 20 by default) of backup points will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskBackupsRequest"/></param>
        /// <returns><see cref="DescribeDiskBackupsResponse"/></returns>
        public Task<DescribeDiskBackupsResponse> DescribeDiskBackups(DescribeDiskBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDiskBackupsResponse>(req, "DescribeDiskBackups");
        }

        /// <summary>
        /// This API is used to query the details of backup points.
        /// 
        /// You can filter results by backup point ID. You can also look for certain backup points by specifying the ID or type of the cloud disk for which the backup points are created. The relationship between different filters is logical `AND`. For more information on filters, see `Filter`.
        /// If the parameter is empty, a certain number (as specified by `Limit` and 20 by default) of backup points will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskBackupsRequest"/></param>
        /// <returns><see cref="DescribeDiskBackupsResponse"/></returns>
        public DescribeDiskBackupsResponse DescribeDiskBackupsSync(DescribeDiskBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDiskBackupsResponse>(req, "DescribeDiskBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDiskConfigQuota) is used to query the cloud disk quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigQuotaRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigQuotaResponse"/></returns>
        public Task<DescribeDiskConfigQuotaResponse> DescribeDiskConfigQuota(DescribeDiskConfigQuotaRequest req)
        {
            return InternalRequestAsync<DescribeDiskConfigQuotaResponse>(req, "DescribeDiskConfigQuota");
        }

        /// <summary>
        /// This API (DescribeDiskConfigQuota) is used to query the cloud disk quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigQuotaRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigQuotaResponse"/></returns>
        public DescribeDiskConfigQuotaResponse DescribeDiskConfigQuotaSync(DescribeDiskConfigQuotaRequest req)
        {
            return InternalRequestAsync<DescribeDiskConfigQuotaResponse>(req, "DescribeDiskConfigQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口已废弃，切换至云审计接口。见https://tapd.woa.com/pro/prong/stories/view/1010114221880719007
        /// 
        /// This API has been disused. Use the CloudAudit API instead, For more information, visit https://tapd.woa.com/pro/prong/stories/view/1010114221880719007.
        /// 
        /// This API is used to query the operation logs of a cloud disk. It will be disused soon. Use [LookUpEvents](https://intl.cloud.tencent.com/document/product/629/12359?from_cn_redirect=1) instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeDiskOperationLogsResponse"/></returns>
        public Task<DescribeDiskOperationLogsResponse> DescribeDiskOperationLogs(DescribeDiskOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeDiskOperationLogsResponse>(req, "DescribeDiskOperationLogs");
        }

        /// <summary>
        /// 接口已废弃，切换至云审计接口。见https://tapd.woa.com/pro/prong/stories/view/1010114221880719007
        /// 
        /// This API has been disused. Use the CloudAudit API instead, For more information, visit https://tapd.woa.com/pro/prong/stories/view/1010114221880719007.
        /// 
        /// This API is used to query the operation logs of a cloud disk. It will be disused soon. Use [LookUpEvents](https://intl.cloud.tencent.com/document/product/629/12359?from_cn_redirect=1) instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeDiskOperationLogsResponse"/></returns>
        public DescribeDiskOperationLogsResponse DescribeDiskOperationLogsSync(DescribeDiskOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeDiskOperationLogsResponse>(req, "DescribeDiskOperationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDisks) is used to query the list of cloud disks.
        /// 
        /// * The details of the cloud disk can be queried based on the ID, type or status of the cloud disk. The relationship between different conditions is AND. For more information about filtering, please see the `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of cloud disk lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks");
        }

        /// <summary>
        /// This API (DescribeDisks) is used to query the list of cloud disks.
        /// 
        /// * The details of the cloud disk can be queried based on the ID, type or status of the cloud disk. The relationship between different conditions is AND. For more information about filtering, please see the `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of cloud disk lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public DescribeDisksResponse DescribeDisksSync(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeInstancesDiskNum) is used to query the number of cloud disks mounted in the instance.
        /// 
        /// * Batch operations are supported. If multiple CVM instance IDs are specified, the returned results will list the number of cloud disks mounted on each CVM.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public Task<DescribeInstancesDiskNumResponse> DescribeInstancesDiskNum(DescribeInstancesDiskNumRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDiskNumResponse>(req, "DescribeInstancesDiskNum");
        }

        /// <summary>
        /// This API (DescribeInstancesDiskNum) is used to query the number of cloud disks mounted in the instance.
        /// 
        /// * Batch operations are supported. If multiple CVM instance IDs are specified, the returned results will list the number of cloud disks mounted on each CVM.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public DescribeInstancesDiskNumResponse DescribeInstancesDiskNumSync(DescribeInstancesDiskNumRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDiskNumResponse>(req, "DescribeInstancesDiskNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口已废弃，切换至云审计接口。见https://tapd.woa.com/pro/prong/stories/view/1010114221880719007
        /// 
        /// This API has been disused. Use the CloudAudit API instead, For more information, visit https://tapd.woa.com/pro/prong/stories/view/1010114221880719007.
        /// 
        /// This API is used to query the operation logs of a snapshot. It will be disused soon. Use [LookUpEvents](https://intl.cloud.tencent.com/document/product/629/12359?from_cn_redirect=1) instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public Task<DescribeSnapshotOperationLogsResponse> DescribeSnapshotOperationLogs(DescribeSnapshotOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotOperationLogsResponse>(req, "DescribeSnapshotOperationLogs");
        }

        /// <summary>
        /// 接口已废弃，切换至云审计接口。见https://tapd.woa.com/pro/prong/stories/view/1010114221880719007
        /// 
        /// This API has been disused. Use the CloudAudit API instead, For more information, visit https://tapd.woa.com/pro/prong/stories/view/1010114221880719007.
        /// 
        /// This API is used to query the operation logs of a snapshot. It will be disused soon. Use [LookUpEvents](https://intl.cloud.tencent.com/document/product/629/12359?from_cn_redirect=1) instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public DescribeSnapshotOperationLogsResponse DescribeSnapshotOperationLogsSync(DescribeSnapshotOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotOperationLogsResponse>(req, "DescribeSnapshotOperationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the sharing information of snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeSnapshotSharePermissionResponse"/></returns>
        public Task<DescribeSnapshotSharePermissionResponse> DescribeSnapshotSharePermission(DescribeSnapshotSharePermissionRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotSharePermissionResponse>(req, "DescribeSnapshotSharePermission");
        }

        /// <summary>
        /// This API is used to query the sharing information of snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeSnapshotSharePermissionResponse"/></returns>
        public DescribeSnapshotSharePermissionResponse DescribeSnapshotSharePermissionSync(DescribeSnapshotSharePermissionRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotSharePermissionResponse>(req, "DescribeSnapshotSharePermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeSnapshots) is used to query the details of snapshots.
        /// 
        /// * Filter the results by the snapshot ID, the ID of cloud disk, for which the snapshot is created, and the type of cloud disk, for which the snapshot is created. The relationship between different conditions is AND. For more information about filtering, please see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of snapshot lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
        }

        /// <summary>
        /// This API (DescribeSnapshots) is used to query the details of snapshots.
        /// 
        /// * Filter the results by the snapshot ID, the ID of cloud disk, for which the snapshot is created, and the type of cloud disk, for which the snapshot is created. The relationship between different conditions is AND. For more information about filtering, please see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of snapshot lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unmount one or more cloud disks.
        /// 
        /// * Batch operation is supported. You can unmount multiple cloud disks from the same CVM in a single request. If any of these cloud disks cannot be unmounted, the operation fails and a specific error code returns.
        /// * This is an async API. A successful request does not mean that the cloud disks have been unmounted successfully. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query the status of cloud disks. When the status changes from `ATTACHED` to `UNATTACHED`, the unmounting is successful.
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public Task<DetachDisksResponse> DetachDisks(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks");
        }

        /// <summary>
        /// This API is used to unmount one or more cloud disks.
        /// 
        /// * Batch operation is supported. You can unmount multiple cloud disks from the same CVM in a single request. If any of these cloud disks cannot be unmounted, the operation fails and a specific error code returns.
        /// * This is an async API. A successful request does not mean that the cloud disks have been unmounted successfully. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query the status of cloud disks. When the status changes from `ATTACHED` to `UNATTACHED`, the unmounting is successful.
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public DetachDisksResponse DetachDisksSync(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get snapshot overview information.
        /// </summary>
        /// <param name="req"><see cref="GetSnapOverviewRequest"/></param>
        /// <returns><see cref="GetSnapOverviewResponse"/></returns>
        public Task<GetSnapOverviewResponse> GetSnapOverview(GetSnapOverviewRequest req)
        {
            return InternalRequestAsync<GetSnapOverviewResponse>(req, "GetSnapOverview");
        }

        /// <summary>
        /// This API is used to get snapshot overview information.
        /// </summary>
        /// <param name="req"><see cref="GetSnapOverviewRequest"/></param>
        /// <returns><see cref="GetSnapOverviewResponse"/></returns>
        public GetSnapOverviewResponse GetSnapOverviewSync(GetSnapOverviewRequest req)
        {
            return InternalRequestAsync<GetSnapOverviewResponse>(req, "GetSnapOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reinitialize the cloud disks. Note the following when reinitializing the cloud disks:
        /// 1. For a cloud disk created from a snapshot, it is rolled back to the state of the snapshot;
        /// 2. For a cloud disk created from the scratch, all data are cleared. Please check and back up the necessary data before the reinitialization;
        /// 3. Currently, you can only re-initialize a cloud disk when it’s not attached to a resource and not shared by others;
        /// 4. For a cloud disk created from a snapshot, if the snapshot has been deleted, it cannot be reinitialized.
        /// </summary>
        /// <param name="req"><see cref="InitializeDisksRequest"/></param>
        /// <returns><see cref="InitializeDisksResponse"/></returns>
        public Task<InitializeDisksResponse> InitializeDisks(InitializeDisksRequest req)
        {
            return InternalRequestAsync<InitializeDisksResponse>(req, "InitializeDisks");
        }

        /// <summary>
        /// This API is used to reinitialize the cloud disks. Note the following when reinitializing the cloud disks:
        /// 1. For a cloud disk created from a snapshot, it is rolled back to the state of the snapshot;
        /// 2. For a cloud disk created from the scratch, all data are cleared. Please check and back up the necessary data before the reinitialization;
        /// 3. Currently, you can only re-initialize a cloud disk when it’s not attached to a resource and not shared by others;
        /// 4. For a cloud disk created from a snapshot, if the snapshot has been deleted, it cannot be reinitialized.
        /// </summary>
        /// <param name="req"><see cref="InitializeDisksRequest"/></param>
        /// <returns><see cref="InitializeDisksResponse"/></returns>
        public InitializeDisksResponse InitializeDisksSync(InitializeDisksRequest req)
        {
            return InternalRequestAsync<InitializeDisksResponse>(req, "InitializeDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of a cloud disk after its backup point quota is modified.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDiskBackupQuotaRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDiskBackupQuotaResponse"/></returns>
        public Task<InquirePriceModifyDiskBackupQuotaResponse> InquirePriceModifyDiskBackupQuota(InquirePriceModifyDiskBackupQuotaRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDiskBackupQuotaResponse>(req, "InquirePriceModifyDiskBackupQuota");
        }

        /// <summary>
        /// This API is used to query the price of a cloud disk after its backup point quota is modified.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDiskBackupQuotaRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDiskBackupQuotaResponse"/></returns>
        public InquirePriceModifyDiskBackupQuotaResponse InquirePriceModifyDiskBackupQuotaSync(InquirePriceModifyDiskBackupQuotaRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDiskBackupQuotaResponse>(req, "InquirePriceModifyDiskBackupQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for adjusting the cloud disk’s extra performance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDiskExtraPerformanceRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDiskExtraPerformanceResponse"/></returns>
        public Task<InquirePriceModifyDiskExtraPerformanceResponse> InquirePriceModifyDiskExtraPerformance(InquirePriceModifyDiskExtraPerformanceRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDiskExtraPerformanceResponse>(req, "InquirePriceModifyDiskExtraPerformance");
        }

        /// <summary>
        /// This API is used to query the price for adjusting the cloud disk’s extra performance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDiskExtraPerformanceRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDiskExtraPerformanceResponse"/></returns>
        public InquirePriceModifyDiskExtraPerformanceResponse InquirePriceModifyDiskExtraPerformanceSync(InquirePriceModifyDiskExtraPerformanceRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDiskExtraPerformanceResponse>(req, "InquirePriceModifyDiskExtraPerformance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of creating cloud disks.
        /// 
        /// * You can query the price of creating multiple cloud disks in a single request. In this case, the price returned will be the total price.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDisksResponse"/></returns>
        public Task<InquiryPriceCreateDisksResponse> InquiryPriceCreateDisks(InquiryPriceCreateDisksRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDisksResponse>(req, "InquiryPriceCreateDisks");
        }

        /// <summary>
        /// This API is used to query the price of creating cloud disks.
        /// 
        /// * You can query the price of creating multiple cloud disks in a single request. In this case, the price returned will be the total price.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDisksResponse"/></returns>
        public InquiryPriceCreateDisksResponse InquiryPriceCreateDisksSync(InquiryPriceCreateDisksRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDisksResponse>(req, "InquiryPriceCreateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for expanding cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeDiskRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeDiskResponse"/></returns>
        public Task<InquiryPriceResizeDiskResponse> InquiryPriceResizeDisk(InquiryPriceResizeDiskRequest req)
        {
            return InternalRequestAsync<InquiryPriceResizeDiskResponse>(req, "InquiryPriceResizeDisk");
        }

        /// <summary>
        /// This API is used to query the price for expanding cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeDiskRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeDiskResponse"/></returns>
        public InquiryPriceResizeDiskResponse InquiryPriceResizeDiskSync(InquiryPriceResizeDiskRequest req)
        {
            return InternalRequestAsync<InquiryPriceResizeDiskResponse>(req, "InquiryPriceResizeDisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyAutoSnapshotPolicyAttribute) is used to modify the attributes of an automatic snapshot policy.
        /// 
        /// * You can use this API to modify the attributes of a scheduled snapshot policy, including the execution policy, name, and activation.
        /// * When modifying the number of days for retention, you must ensure that there is no clash with the permanent retention attribute. Otherwise, the entire operation will fail and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoSnapshotPolicyAttributeRequest"/></param>
        /// <returns><see cref="ModifyAutoSnapshotPolicyAttributeResponse"/></returns>
        public Task<ModifyAutoSnapshotPolicyAttributeResponse> ModifyAutoSnapshotPolicyAttribute(ModifyAutoSnapshotPolicyAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAutoSnapshotPolicyAttributeResponse>(req, "ModifyAutoSnapshotPolicyAttribute");
        }

        /// <summary>
        /// This API (ModifyAutoSnapshotPolicyAttribute) is used to modify the attributes of an automatic snapshot policy.
        /// 
        /// * You can use this API to modify the attributes of a scheduled snapshot policy, including the execution policy, name, and activation.
        /// * When modifying the number of days for retention, you must ensure that there is no clash with the permanent retention attribute. Otherwise, the entire operation will fail and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoSnapshotPolicyAttributeRequest"/></param>
        /// <returns><see cref="ModifyAutoSnapshotPolicyAttributeResponse"/></returns>
        public ModifyAutoSnapshotPolicyAttributeResponse ModifyAutoSnapshotPolicyAttributeSync(ModifyAutoSnapshotPolicyAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAutoSnapshotPolicyAttributeResponse>(req, "ModifyAutoSnapshotPolicyAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * Only the project ID of elastic cloud disk can be modified. The project ID of the cloud disk created with the CVM is linked with the CVM. The project ID can be can be queried in the Portable field in the output parameters through the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1).
        /// * "Cloud disk name" is only used by users for their management. Tencent Cloud does not use the name as the basis for ticket submission or cloud disk management.
        /// * Batch operations are supported. If multiple cloud disk IDs are specified, all the specified cloud disks must have the same attribute. If there is a cloud disk that does not allow this operation, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskAttributesRequest"/></param>
        /// <returns><see cref="ModifyDiskAttributesResponse"/></returns>
        public Task<ModifyDiskAttributesResponse> ModifyDiskAttributes(ModifyDiskAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDiskAttributesResponse>(req, "ModifyDiskAttributes");
        }

        /// <summary>
        /// * Only the project ID of elastic cloud disk can be modified. The project ID of the cloud disk created with the CVM is linked with the CVM. The project ID can be can be queried in the Portable field in the output parameters through the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1).
        /// * "Cloud disk name" is only used by users for their management. Tencent Cloud does not use the name as the basis for ticket submission or cloud disk management.
        /// * Batch operations are supported. If multiple cloud disk IDs are specified, all the specified cloud disks must have the same attribute. If there is a cloud disk that does not allow this operation, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskAttributesRequest"/></param>
        /// <returns><see cref="ModifyDiskAttributesResponse"/></returns>
        public ModifyDiskAttributesResponse ModifyDiskAttributesSync(ModifyDiskAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDiskAttributesResponse>(req, "ModifyDiskAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the cloud disk backup point quota.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskBackupQuotaRequest"/></param>
        /// <returns><see cref="ModifyDiskBackupQuotaResponse"/></returns>
        public Task<ModifyDiskBackupQuotaResponse> ModifyDiskBackupQuota(ModifyDiskBackupQuotaRequest req)
        {
            return InternalRequestAsync<ModifyDiskBackupQuotaResponse>(req, "ModifyDiskBackupQuota");
        }

        /// <summary>
        /// This API is used to modify the cloud disk backup point quota.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskBackupQuotaRequest"/></param>
        /// <returns><see cref="ModifyDiskBackupQuotaResponse"/></returns>
        public ModifyDiskBackupQuotaResponse ModifyDiskBackupQuotaSync(ModifyDiskBackupQuotaRequest req)
        {
            return InternalRequestAsync<ModifyDiskBackupQuotaResponse>(req, "ModifyDiskBackupQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust extra performance for Enhanced SSD (CLOUD_HSSD) and ulTra SSD. 
        /// 
        /// *This API only supports adjust extra performance for Enhanced SSD and ulTra SSD. 
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskExtraPerformanceRequest"/></param>
        /// <returns><see cref="ModifyDiskExtraPerformanceResponse"/></returns>
        public Task<ModifyDiskExtraPerformanceResponse> ModifyDiskExtraPerformance(ModifyDiskExtraPerformanceRequest req)
        {
            return InternalRequestAsync<ModifyDiskExtraPerformanceResponse>(req, "ModifyDiskExtraPerformance");
        }

        /// <summary>
        /// This API is used to adjust extra performance for Enhanced SSD (CLOUD_HSSD) and ulTra SSD. 
        /// 
        /// *This API only supports adjust extra performance for Enhanced SSD and ulTra SSD. 
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskExtraPerformanceRequest"/></param>
        /// <returns><see cref="ModifyDiskExtraPerformanceResponse"/></returns>
        public ModifyDiskExtraPerformanceResponse ModifyDiskExtraPerformanceSync(ModifyDiskExtraPerformanceRequest req)
        {
            return InternalRequestAsync<ModifyDiskExtraPerformanceResponse>(req, "ModifyDiskExtraPerformance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifySnapshotAttribute) is used to modify the attributes of a specified snapshot.
        /// 
        /// * Currently, you can only modify snapshot name and change non-permanent snapshots into permanent snapshots.
        /// * "Snapshot name" is only used by users for their management. Tencent Cloud does not use the name as the basis for ticket submission or snapshot management.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttribute(ModifySnapshotAttributeRequest req)
        {
            return InternalRequestAsync<ModifySnapshotAttributeResponse>(req, "ModifySnapshotAttribute");
        }

        /// <summary>
        /// This API (ModifySnapshotAttribute) is used to modify the attributes of a specified snapshot.
        /// 
        /// * Currently, you can only modify snapshot name and change non-permanent snapshots into permanent snapshots.
        /// * "Snapshot name" is only used by users for their management. Tencent Cloud does not use the name as the basis for ticket submission or snapshot management.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttributeSync(ModifySnapshotAttributeRequest req)
        {
            return InternalRequestAsync<ModifySnapshotAttributeResponse>(req, "ModifySnapshotAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify snapshot sharing information.
        /// 
        /// After snapshots are shared, the accounts they are shared to can use the snapshot to create cloud disks.
        /// * Each snapshot can be shared to at most 50 accounts.
        /// * You can use a shared snapshot to create cloud disks, but you cannot change its name or description.
        /// * Snapshots can only be shared with accounts in the same region.
        /// * Only data disk snapshots can be shared.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotsSharePermissionRequest"/></param>
        /// <returns><see cref="ModifySnapshotsSharePermissionResponse"/></returns>
        public Task<ModifySnapshotsSharePermissionResponse> ModifySnapshotsSharePermission(ModifySnapshotsSharePermissionRequest req)
        {
            return InternalRequestAsync<ModifySnapshotsSharePermissionResponse>(req, "ModifySnapshotsSharePermission");
        }

        /// <summary>
        /// This API is used to modify snapshot sharing information.
        /// 
        /// After snapshots are shared, the accounts they are shared to can use the snapshot to create cloud disks.
        /// * Each snapshot can be shared to at most 50 accounts.
        /// * You can use a shared snapshot to create cloud disks, but you cannot change its name or description.
        /// * Snapshots can only be shared with accounts in the same region.
        /// * Only data disk snapshots can be shared.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotsSharePermissionRequest"/></param>
        /// <returns><see cref="ModifySnapshotsSharePermissionResponse"/></returns>
        public ModifySnapshotsSharePermissionResponse ModifySnapshotsSharePermissionSync(ModifySnapshotsSharePermissionRequest req)
        {
            return InternalRequestAsync<ModifySnapshotsSharePermissionResponse>(req, "ModifySnapshotsSharePermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to expand cloud disks. 
        /// 
        /// *This API supports only the expansion of elastic cloud disks. To query the type of a cloud disk, you can call the [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1) API and check the `Portable` field in the response. To expand non-elastic cloud disks, you can call the [ResizeInstanceDisks](https://intl.cloud.tencent.com/document/product/213/15731?from_cn_redirect=1) API. *This is an async API. A successful return of this API does not mean that the cloud disk has been expanded successfully. You can call the [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1) API to query the status of a cloud disk. `EXPANDING` indicates that the expansion is in process.
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk");
        }

        /// <summary>
        /// This API is used to expand cloud disks. 
        /// 
        /// *This API supports only the expansion of elastic cloud disks. To query the type of a cloud disk, you can call the [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1) API and check the `Portable` field in the response. To expand non-elastic cloud disks, you can call the [ResizeInstanceDisks](https://intl.cloud.tencent.com/document/product/213/15731?from_cn_redirect=1) API. *This is an async API. A successful return of this API does not mean that the cloud disk has been expanded successfully. You can call the [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1) API to query the status of a cloud disk. `EXPANDING` indicates that the expansion is in process.
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return cloud disks.
        /// 
        /// * You can use this API to return cloud disks you no longer need.
        /// * This API can be used to return pay-as-you-go cloud disks billed on hourly basis. 
        /// * Batch operations are supported. The maximum number of cloud disks in each request is 50. If there is any specified cloud disk that cannot be returned, an error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public Task<TerminateDisksResponse> TerminateDisks(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks");
        }

        /// <summary>
        /// This API is used to return cloud disks.
        /// 
        /// * You can use this API to return cloud disks you no longer need.
        /// * This API can be used to return pay-as-you-go cloud disks billed on hourly basis. 
        /// * Batch operations are supported. The maximum number of cloud disks in each request is 50. If there is any specified cloud disk that cannot be returned, an error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public TerminateDisksResponse TerminateDisksSync(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (UnbindAutoSnapshotPolicy) is used to unbind the cloud disk from the specified scheduled snapshot policy.
        /// 
        /// * Batch operations are supported. Multiple cloud disks can be unbound from a snapshot policy at one time. 
        /// * If the passed-in cloud disks are not bound to the current scheduled snapshot policy, they will be skipped. Only cloud disks that are bound to the current scheduled snapshot policy are processed.
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public Task<UnbindAutoSnapshotPolicyResponse> UnbindAutoSnapshotPolicy(UnbindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoSnapshotPolicyResponse>(req, "UnbindAutoSnapshotPolicy");
        }

        /// <summary>
        /// This API (UnbindAutoSnapshotPolicy) is used to unbind the cloud disk from the specified scheduled snapshot policy.
        /// 
        /// * Batch operations are supported. Multiple cloud disks can be unbound from a snapshot policy at one time. 
        /// * If the passed-in cloud disks are not bound to the current scheduled snapshot policy, they will be skipped. Only cloud disks that are bound to the current scheduled snapshot policy are processed.
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public UnbindAutoSnapshotPolicyResponse UnbindAutoSnapshotPolicySync(UnbindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoSnapshotPolicyResponse>(req, "UnbindAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
