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

namespace TencentCloud.Cbs.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cbs.V20170312.Models;

   public class CbsClient : AbstractClient{

       private const string endpoint = "cbs.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CbsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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
        public async Task<ApplySnapshotResponse> ApplySnapshot(ApplySnapshotRequest req)
        {
             JsonResponseModel<ApplySnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplySnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ApplySnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplySnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AttachDisks) is used to mount cloud disks.
        ///  
        /// * Batch operations are supported. Multiple cloud disks can be mounted to a CVM. If there is a cloud disk that does not allow this operation, the operation is not performed and a specific error code is returned.
        /// * This API is an asynchronous API. If the request for mounting the cloud disk successfully returns results, the operation of mounting cloud disk has been initiated at the background. You can use the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) to query the cloud disk status. If the status changes from "ATTACHING" to "ATTACHED", the cloud disk is mounted.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public async Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
             JsonResponseModel<AttachDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AttachDisks) is used to mount cloud disks.
        ///  
        /// * Batch operations are supported. Multiple cloud disks can be mounted to a CVM. If there is a cloud disk that does not allow this operation, the operation is not performed and a specific error code is returned.
        /// * This API is an asynchronous API. If the request for mounting the cloud disk successfully returns results, the operation of mounting cloud disk has been initiated at the background. You can use the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) to query the cloud disk status. If the status changes from "ATTACHING" to "ATTACHED", the cloud disk is mounted.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
             JsonResponseModel<AttachDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (BindAutoSnapshotPolicy) is used to bind the cloud disk to the specified scheduled snapshot policy.
        /// 
        /// * For the scheduled snapshot policy limit of each region, see [Scheduled Snapshots](https://intl.cloud.tencent.com/document/product/362/8191?from_cn_redirect=1).
        /// * When a cloud disk that is bound to a scheduled snapshot policy is in the unused state (that is, an elastic cloud disk has not been mounted or the server of an inelastic disk is powered off) scheduled snapshots are not created.
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public async Task<BindAutoSnapshotPolicyResponse> BindAutoSnapshotPolicy(BindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<BindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<BindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateAutoSnapshotPolicy) is used to create a scheduled snapshot policy.
        /// 
        /// * For the limits on the number of scheduled snapshot policies that can be created in each region, see [Scheduled Snapshots](https://intl.cloud.tencent.com/document/product/362/8191?from_cn_redirect=1).
        /// * The quantity and capacity of the snapshots that can be created in each region are limited. For more information, see the **Snapshots** page on the Tencent Cloud Console. If the number of snapshots exceeds the quota, the creation of the scheduled snapshots will fail.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<CreateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more cloud disks.
        /// 
        /// * This API supports creating a cloud disk with a data disk snapshot so that the snapshot data can be copied to the purchased cloud disk.
        /// * This API is an async API. A cloud disk ID list will be returned when a request is made successfully, but it does not mean that the creation has been completed. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query cloud disks by `DiskId`. If a new cloud disk can be found and its state is 'UNATTACHED' or 'ATTACHED', it means that the cloud disk has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public async Task<CreateDisksResponse> CreateDisks(CreateDisksRequest req)
        {
             JsonResponseModel<CreateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more cloud disks.
        /// 
        /// * This API supports creating a cloud disk with a data disk snapshot so that the snapshot data can be copied to the purchased cloud disk.
        /// * This API is an async API. A cloud disk ID list will be returned when a request is made successfully, but it does not mean that the creation has been completed. You can call the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API to query cloud disks by `DiskId`. If a new cloud disk can be found and its state is 'UNATTACHED' or 'ATTACHED', it means that the cloud disk has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public CreateDisksResponse CreateDisksSync(CreateDisksRequest req)
        {
             JsonResponseModel<CreateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateSnapshot) is used to create a snapshot of a specified cloud disk.
        /// 
        /// * Snapshots can only be created for cloud disks with the snapshot capability. To check whether a cloud disk has the snapshot capability, see the SnapshotAbility field returned by the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1).
        /// * For the number of snapshots that can be created, please see [Product Usage Restriction](https://intl.cloud.tencent.com/doc/product/362/5145?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotRequest"/></param>
        /// <returns><see cref="CreateSnapshotResponse"/></returns>
        public async Task<CreateSnapshotResponse> CreateSnapshot(CreateSnapshotRequest req)
        {
             JsonResponseModel<CreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateSnapshot) is used to create a snapshot of a specified cloud disk.
        /// 
        /// * Snapshots can only be created for cloud disks with the snapshot capability. To check whether a cloud disk has the snapshot capability, see the SnapshotAbility field returned by the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1).
        /// * For the number of snapshots that can be created, please see [Product Usage Restriction](https://intl.cloud.tencent.com/doc/product/362/5145?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotRequest"/></param>
        /// <returns><see cref="CreateSnapshotResponse"/></returns>
        public CreateSnapshotResponse CreateSnapshotSync(CreateSnapshotRequest req)
        {
             JsonResponseModel<CreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAutoSnapshotPolicies) is used to delete scheduled snapshot policies.
        /// 
        /// * Batch operations are supported. If one of the scheduled snapshot policies in a batch cannot be deleted, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPoliciesResponse"/></returns>
        public async Task<DeleteAutoSnapshotPoliciesResponse> DeleteAutoSnapshotPolicies(DeleteAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DeleteAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteSnapshots) is used to delete snapshots.
        /// 
        /// * The snapshot must be in NORMAL status. The snapshot status can be queried in the SnapshotState field in the output parameters through the API [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1).
        /// * Batch operations are supported. If one of the snapshots in a batch cannot be deleted, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public async Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteSnapshots) is used to delete snapshots.
        /// 
        /// * The snapshot must be in NORMAL status. The snapshot status can be queried in the SnapshotState field in the output parameters through the API [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1).
        /// * Batch operations are supported. If one of the snapshots in a batch cannot be deleted, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAutoSnapshotPolicies) is used to query scheduled snapshot policies.
        /// 
        /// * You can query the detailed information of scheduled snapshot policies by ID, name, or status. Insert `AND` between different values. For details on filtering information, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of the scheduled snapshot policy lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public async Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAutoSnapshotPolicies) is used to query scheduled snapshot policies.
        /// 
        /// * You can query the detailed information of scheduled snapshot policies by ID, name, or status. Insert `AND` between different values. For details on filtering information, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of the scheduled snapshot policy lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPoliciesSync(DescribeAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDiskAssociatedAutoSnapshotPolicy) is used to query the scheduled snapshot policy bound to a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskAssociatedAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DescribeDiskAssociatedAutoSnapshotPolicyResponse"/></returns>
        public async Task<DescribeDiskAssociatedAutoSnapshotPolicyResponse> DescribeDiskAssociatedAutoSnapshotPolicy(DescribeDiskAssociatedAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskAssociatedAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDiskAssociatedAutoSnapshotPolicy) is used to query the scheduled snapshot policy bound to a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskAssociatedAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DescribeDiskAssociatedAutoSnapshotPolicyResponse"/></returns>
        public DescribeDiskAssociatedAutoSnapshotPolicyResponse DescribeDiskAssociatedAutoSnapshotPolicySync(DescribeDiskAssociatedAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskAssociatedAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDiskConfigQuota) is used to query the cloud disk quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigQuotaRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigQuotaResponse"/></returns>
        public async Task<DescribeDiskConfigQuotaResponse> DescribeDiskConfigQuota(DescribeDiskConfigQuotaRequest req)
        {
             JsonResponseModel<DescribeDiskConfigQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskConfigQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDiskConfigQuota) is used to query the cloud disk quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigQuotaRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigQuotaResponse"/></returns>
        public DescribeDiskConfigQuotaResponse DescribeDiskConfigQuotaSync(DescribeDiskConfigQuotaRequest req)
        {
             JsonResponseModel<DescribeDiskConfigQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskConfigQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDiskOperationLogs) is used to query a list of cloud disk operation logs.
        /// 
        /// This can be filtered according to the cloud disk ID. The format of cloud disk IDs is as follows: disk-a1kmcp13.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeDiskOperationLogsResponse"/></returns>
        public async Task<DescribeDiskOperationLogsResponse> DescribeDiskOperationLogs(DescribeDiskOperationLogsRequest req)
        {
             JsonResponseModel<DescribeDiskOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDiskOperationLogs) is used to query a list of cloud disk operation logs.
        /// 
        /// This can be filtered according to the cloud disk ID. The format of cloud disk IDs is as follows: disk-a1kmcp13.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeDiskOperationLogsResponse"/></returns>
        public DescribeDiskOperationLogsResponse DescribeDiskOperationLogsSync(DescribeDiskOperationLogsRequest req)
        {
             JsonResponseModel<DescribeDiskOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDisks) is used to query the list of cloud disks.
        /// 
        /// * The details of the cloud disk can be queried based on the ID, type or status of the cloud disk. The relationship between different conditions is AND. For more information about filtering, please see the `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of cloud disk lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public async Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
             JsonResponseModel<DescribeDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeInstancesDiskNum) is used to query the number of cloud disks mounted in the instance.
        /// 
        /// * Batch operations are supported. If multiple CVM instance IDs are specified, the returned results will list the number of cloud disks mounted on each CVM.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public async Task<DescribeInstancesDiskNumResponse> DescribeInstancesDiskNum(DescribeInstancesDiskNumRequest req)
        {
             JsonResponseModel<DescribeInstancesDiskNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDiskNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDiskNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeInstancesDiskNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDiskNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDiskNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSnapshotOperationLogs) is used to query a list of snapshot operation logs.
        /// 
        /// You can filter according to the snapshot ID. The snapshot ID format is as follows: snap-a1kmcp13.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public async Task<DescribeSnapshotOperationLogsResponse> DescribeSnapshotOperationLogs(DescribeSnapshotOperationLogsRequest req)
        {
             JsonResponseModel<DescribeSnapshotOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSnapshotOperationLogs) is used to query a list of snapshot operation logs.
        /// 
        /// You can filter according to the snapshot ID. The snapshot ID format is as follows: snap-a1kmcp13.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public DescribeSnapshotOperationLogsResponse DescribeSnapshotOperationLogsSync(DescribeSnapshotOperationLogsRequest req)
        {
             JsonResponseModel<DescribeSnapshotOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the sharing information of snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeSnapshotSharePermissionResponse"/></returns>
        public async Task<DescribeSnapshotSharePermissionResponse> DescribeSnapshotSharePermission(DescribeSnapshotSharePermissionRequest req)
        {
             JsonResponseModel<DescribeSnapshotSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the sharing information of snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeSnapshotSharePermissionResponse"/></returns>
        public DescribeSnapshotSharePermissionResponse DescribeSnapshotSharePermissionSync(DescribeSnapshotSharePermissionRequest req)
        {
             JsonResponseModel<DescribeSnapshotSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSnapshots) is used to query the details of snapshots.
        /// 
        /// * Filter the results by the snapshot ID, the ID of cloud disk, for which the snapshot is created, and the type of cloud disk, for which the snapshot is created. The relationship between different conditions is AND. For more information about filtering, please see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit`; the default is 20) of snapshot lists are returned to the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DetachDisks) is used to unmount cloud disks.
        /// 
        /// * Batch operations are supported. Multiple cloud disks mounted to the same CVM can be unmounted in batch. If there is a cloud disk that does not allow this operation, the operation is not performed and a specific error code is returned.
        /// * This API is an asynchronous API. When the request successfully returns results, the cloud disk is not unmounted from the CVM immediately. You can use the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) to query the cloud disk status. If the status changes from "ATTACHED" to "UNATTACHED", the cloud disk is unmounted.
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public async Task<DetachDisksResponse> DetachDisks(DetachDisksRequest req)
        {
             JsonResponseModel<DetachDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DetachDisks) is used to unmount cloud disks.
        /// 
        /// * Batch operations are supported. Multiple cloud disks mounted to the same CVM can be unmounted in batch. If there is a cloud disk that does not allow this operation, the operation is not performed and a specific error code is returned.
        /// * This API is an asynchronous API. When the request successfully returns results, the cloud disk is not unmounted from the CVM immediately. You can use the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) to query the cloud disk status. If the status changes from "ATTACHED" to "UNATTACHED", the cloud disk is unmounted.
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public DetachDisksResponse DetachDisksSync(DetachDisksRequest req)
        {
             JsonResponseModel<DetachDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get snapshot overview information.
        /// </summary>
        /// <param name="req"><see cref="GetSnapOverviewRequest"/></param>
        /// <returns><see cref="GetSnapOverviewResponse"/></returns>
        public async Task<GetSnapOverviewResponse> GetSnapOverview(GetSnapOverviewRequest req)
        {
             JsonResponseModel<GetSnapOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSnapOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSnapOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get snapshot overview information.
        /// </summary>
        /// <param name="req"><see cref="GetSnapOverviewRequest"/></param>
        /// <returns><see cref="GetSnapOverviewResponse"/></returns>
        public GetSnapOverviewResponse GetSnapOverviewSync(GetSnapOverviewRequest req)
        {
             JsonResponseModel<GetSnapOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSnapOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSnapOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceCreateDisks) is used to inquire the price for cloud disk creation.
        /// 
        /// * It supports inquiring the price for the creation of multiple cloud disks. The total price for the creation is returned.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDisksResponse"/></returns>
        public async Task<InquiryPriceCreateDisksResponse> InquiryPriceCreateDisks(InquiryPriceCreateDisksRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceCreateDisks) is used to inquire the price for cloud disk creation.
        /// 
        /// * It supports inquiring the price for the creation of multiple cloud disks. The total price for the creation is returned.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDisksResponse"/></returns>
        public InquiryPriceCreateDisksResponse InquiryPriceCreateDisksSync(InquiryPriceCreateDisksRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for expanding cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeDiskRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeDiskResponse"/></returns>
        public async Task<InquiryPriceResizeDiskResponse> InquiryPriceResizeDisk(InquiryPriceResizeDiskRequest req)
        {
             JsonResponseModel<InquiryPriceResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for expanding cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeDiskRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeDiskResponse"/></returns>
        public InquiryPriceResizeDiskResponse InquiryPriceResizeDiskSync(InquiryPriceResizeDiskRequest req)
        {
             JsonResponseModel<InquiryPriceResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAutoSnapshotPolicyAttribute) is used to modify the attributes of an automatic snapshot policy.
        /// 
        /// * You can use this API to modify the attributes of a scheduled snapshot policy, including the execution policy, name, and activation.
        /// * When modifying the number of days for retention, you must ensure that there is no clash with the permanent retention attribute. Otherwise, the entire operation will fail and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoSnapshotPolicyAttributeRequest"/></param>
        /// <returns><see cref="ModifyAutoSnapshotPolicyAttributeResponse"/></returns>
        public async Task<ModifyAutoSnapshotPolicyAttributeResponse> ModifyAutoSnapshotPolicyAttribute(ModifyAutoSnapshotPolicyAttributeRequest req)
        {
             JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoSnapshotPolicyAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoSnapshotPolicyAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * Only the project ID of elastic cloud disk can be modified. The project ID of the cloud disk created with the CVM is linked with the CVM. The project ID can be can be queried in the Portable field in the output parameters through the API [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1).
        /// * "Cloud disk name" is only used by users for their management. Tencent Cloud does not use the name as the basis for ticket submission or cloud disk management.
        /// * Batch operations are supported. If multiple cloud disk IDs are specified, all the specified cloud disks must have the same attribute. If there is a cloud disk that does not allow this operation, the operation is not performed and a specific error code is returned.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskAttributesRequest"/></param>
        /// <returns><see cref="ModifyDiskAttributesResponse"/></returns>
        public async Task<ModifyDiskAttributesResponse> ModifyDiskAttributes(ModifyDiskAttributesRequest req)
        {
             JsonResponseModel<ModifyDiskAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDiskAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiskAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyDiskAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDiskAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiskAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifySnapshotAttribute) is used to modify the attributes of a specified snapshot.
        /// 
        /// * Currently, you can only modify snapshot name and change non-permanent snapshots into permanent snapshots.
        /// * "Snapshot name" is only used by users for their management. Tencent Cloud does not use the name as the basis for ticket submission or snapshot management.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttribute(ModifySnapshotAttributeRequest req)
        {
             JsonResponseModel<ModifySnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifySnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifySnapshotsSharePermissionResponse> ModifySnapshotsSharePermission(ModifySnapshotsSharePermissionRequest req)
        {
             JsonResponseModel<ModifySnapshotsSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotsSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotsSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifySnapshotsSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotsSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotsSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResizeDisk) is used to expand the capacity of the cloud disk.
        /// 
        /// * Only elastic cloud disks can be expanded. The cloud disk type can be queried in the Portable field in the output parameters through the API [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1). For the cloud disk created along with the CVM, the capacity can only be expanded via the API [ResizeInstanceDisks](https://intl.cloud.tencent.com/document/product/213/15731?from_cn_redirect=1).
        /// * This API is an asynchronous API. The cloud disk is not immediately expanded to the specified size as the API successfully returns results. You can use the API [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1) to query the cloud disk status. The cloud disk in the status of "EXPANDING" is in the process of capacity expansion. When the status changes to "UNATTACHED", the capacity expansion is completed. 
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public async Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
             JsonResponseModel<ResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResizeDisk) is used to expand the capacity of the cloud disk.
        /// 
        /// * Only elastic cloud disks can be expanded. The cloud disk type can be queried in the Portable field in the output parameters through the API [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1). For the cloud disk created along with the CVM, the capacity can only be expanded via the API [ResizeInstanceDisks](https://intl.cloud.tencent.com/document/product/213/15731?from_cn_redirect=1).
        /// * This API is an asynchronous API. The cloud disk is not immediately expanded to the specified size as the API successfully returns results. You can use the API [DescribeDisks](https://intl.cloud.tencent.comhttps://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1?from_cn_redirect=1) to query the cloud disk status. The cloud disk in the status of "EXPANDING" is in the process of capacity expansion. When the status changes to "UNATTACHED", the capacity expansion is completed. 
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
             JsonResponseModel<ResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<TerminateDisksResponse> TerminateDisks(TerminateDisksRequest req)
        {
             JsonResponseModel<TerminateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<TerminateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UnbindAutoSnapshotPolicy) is used to unbind the cloud disk from the specified scheduled snapshot policy.
        /// 
        /// * Batch operations are supported. Multiple cloud disks can be unbound from a snapshot policy at one time. 
        /// * If the passed-in cloud disks are not bound to the current scheduled snapshot policy, they will be skipped. Only cloud disks that are bound to the current scheduled snapshot policy are processed.
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public async Task<UnbindAutoSnapshotPolicyResponse> UnbindAutoSnapshotPolicy(UnbindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<UnbindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<UnbindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
