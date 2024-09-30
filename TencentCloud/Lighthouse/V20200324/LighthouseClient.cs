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

namespace TencentCloud.Lighthouse.V20200324
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lighthouse.V20200324.Models;

   public class LighthouseClient : AbstractClient{

       private const string endpoint = "lighthouse.tencentcloudapi.com";
       private const string version = "2020-03-24";
       private const string sdkVersion = "SDK_NET_3.0.991";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LighthouseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LighthouseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to roll back the system disk snapshot of the specified instance.
        /// <li>Only rollback to the original system disk is supported.</li>
        /// <li>Only snapshots in `NORMAL` status can be used for rollback. To query the status of a snapshot, you can call the `DescribeSnapshots` API and see the `SnapshotState` field in the response.</li>
        /// <li>When a snapshot is rolled back, the status of the instance must be `STOPPED` or `RUNNING`. You can call the `DescribeInstances` API to query the instance status. Instances in `RUNNING` status will be forcibly shut down before snapshot rollback.</li>
        /// </summary>
        /// <param name="req"><see cref="ApplyInstanceSnapshotRequest"/></param>
        /// <returns><see cref="ApplyInstanceSnapshotResponse"/></returns>
        public Task<ApplyInstanceSnapshotResponse> ApplyInstanceSnapshot(ApplyInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<ApplyInstanceSnapshotResponse>(req, "ApplyInstanceSnapshot");
        }

        /// <summary>
        /// This API is used to roll back the system disk snapshot of the specified instance.
        /// <li>Only rollback to the original system disk is supported.</li>
        /// <li>Only snapshots in `NORMAL` status can be used for rollback. To query the status of a snapshot, you can call the `DescribeSnapshots` API and see the `SnapshotState` field in the response.</li>
        /// <li>When a snapshot is rolled back, the status of the instance must be `STOPPED` or `RUNNING`. You can call the `DescribeInstances` API to query the instance status. Instances in `RUNNING` status will be forcibly shut down before snapshot rollback.</li>
        /// </summary>
        /// <param name="req"><see cref="ApplyInstanceSnapshotRequest"/></param>
        /// <returns><see cref="ApplyInstanceSnapshotResponse"/></returns>
        public ApplyInstanceSnapshotResponse ApplyInstanceSnapshotSync(ApplyInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<ApplyInstanceSnapshotResponse>(req, "ApplyInstanceSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a user-specified key pair to an instance.
        /// * Only instances on LINUX_UNIX in [RUNNING, STOPPED] status are supported. Instances in `RUNNING` status will be forcibly shut down before binding.
        /// * If the public key of a key pair is written to the SSH configuration of the instance, you will be able to log in to the instance with the private key of the key pair.
        /// * If the instance is already associated with a key, the old key will become invalid.
        /// * If you currently use a password to log in, you will no longer be able to do so after you associate the instance with a key.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If instances not available for the operation are selected, you will get an error code.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public Task<AssociateInstancesKeyPairsResponse> AssociateInstancesKeyPairs(AssociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<AssociateInstancesKeyPairsResponse>(req, "AssociateInstancesKeyPairs");
        }

        /// <summary>
        /// This API is used to bind a user-specified key pair to an instance.
        /// * Only instances on LINUX_UNIX in [RUNNING, STOPPED] status are supported. Instances in `RUNNING` status will be forcibly shut down before binding.
        /// * If the public key of a key pair is written to the SSH configuration of the instance, you will be able to log in to the instance with the private key of the key pair.
        /// * If the instance is already associated with a key, the old key will become invalid.
        /// * If you currently use a password to log in, you will no longer be able to do so after you associate the instance with a key.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If instances not available for the operation are selected, you will get an error code.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public AssociateInstancesKeyPairsResponse AssociateInstancesKeyPairsSync(AssociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<AssociateInstancesKeyPairsResponse>(req, "AssociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public Task<AttachCcnResponse> AttachCcn(AttachCcnRequest req)
        {
            return InternalRequestAsync<AttachCcnResponse>(req, "AttachCcn");
        }

        /// <summary>
        /// This API is used to associate a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public AttachCcnResponse AttachCcnSync(AttachCcnRequest req)
        {
            return InternalRequestAsync<AttachCcnResponse>(req, "AttachCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to attach one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks");
        }

        /// <summary>
        /// This API is used to attach one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image.
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public Task<CreateBlueprintResponse> CreateBlueprint(CreateBlueprintRequest req)
        {
            return InternalRequestAsync<CreateBlueprintResponse>(req, "CreateBlueprint");
        }

        /// <summary>
        /// This API is used to create an image.
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public CreateBlueprintResponse CreateBlueprintSync(CreateBlueprintRequest req)
        {
            return InternalRequestAsync<CreateBlueprintResponse>(req, "CreateBlueprint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public Task<CreateDisksResponse> CreateDisks(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks");
        }

        /// <summary>
        /// This API is used to create one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public CreateDisksResponse CreateDisksSync(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a firewall rule on an instance.
        /// 
        /// 
        /// * `FirewallVersion` is the firewall version number. Every time you update the firewall rule version, it will be automatically increased by 1 to prevent the updated rule from expiring. If it is left empty, conflicts will not be considered.
        /// 
        /// In the `FirewallRules` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallRulesResponse"/></returns>
        public Task<CreateFirewallRulesResponse> CreateFirewallRules(CreateFirewallRulesRequest req)
        {
            return InternalRequestAsync<CreateFirewallRulesResponse>(req, "CreateFirewallRules");
        }

        /// <summary>
        /// This API is used to add a firewall rule on an instance.
        /// 
        /// 
        /// * `FirewallVersion` is the firewall version number. Every time you update the firewall rule version, it will be automatically increased by 1 to prevent the updated rule from expiring. If it is left empty, conflicts will not be considered.
        /// 
        /// In the `FirewallRules` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallRulesResponse"/></returns>
        public CreateFirewallRulesResponse CreateFirewallRulesSync(CreateFirewallRulesRequest req)
        {
            return InternalRequestAsync<CreateFirewallRulesResponse>(req, "CreateFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a system disk snapshot of the specified instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshot(CreateInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<CreateInstanceSnapshotResponse>(req, "CreateInstanceSnapshot");
        }

        /// <summary>
        /// This API is used to create a system disk snapshot of the specified instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public CreateInstanceSnapshotResponse CreateInstanceSnapshotSync(CreateInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<CreateInstanceSnapshotResponse>(req, "CreateInstanceSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create one or more Lighthouse instances.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// This API is used to create one or more Lighthouse instances.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair");
        }

        /// <summary>
        /// This API is used to create a key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public Task<DeleteBlueprintsResponse> DeleteBlueprints(DeleteBlueprintsRequest req)
        {
            return InternalRequestAsync<DeleteBlueprintsResponse>(req, "DeleteBlueprints");
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public DeleteBlueprintsResponse DeleteBlueprintsSync(DeleteBlueprintsRequest req)
        {
            return InternalRequestAsync<DeleteBlueprintsResponse>(req, "DeleteBlueprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a firewall rule of an instance.
        /// 
        /// * `FirewallVersion` is used to specify the version of the firewall to be manipulated. If the `FirewallVersion` value passed in is not equal to the current latest version of the firewall, a failure will be returned. If `FirewallVersion` is not passed in, the specified rule will be deleted directly.
        /// 
        /// In the `FirewallRules` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallRulesResponse"/></returns>
        public Task<DeleteFirewallRulesResponse> DeleteFirewallRules(DeleteFirewallRulesRequest req)
        {
            return InternalRequestAsync<DeleteFirewallRulesResponse>(req, "DeleteFirewallRules");
        }

        /// <summary>
        /// This API is used to delete a firewall rule of an instance.
        /// 
        /// * `FirewallVersion` is used to specify the version of the firewall to be manipulated. If the `FirewallVersion` value passed in is not equal to the current latest version of the firewall, a failure will be returned. If `FirewallVersion` is not passed in, the specified rule will be deleted directly.
        /// 
        /// In the `FirewallRules` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallRulesResponse"/></returns>
        public DeleteFirewallRulesResponse DeleteFirewallRulesSync(DeleteFirewallRulesRequest req)
        {
            return InternalRequestAsync<DeleteFirewallRulesResponse>(req, "DeleteFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public Task<DeleteKeyPairsResponse> DeleteKeyPairs(DeleteKeyPairsRequest req)
        {
            return InternalRequestAsync<DeleteKeyPairsResponse>(req, "DeleteKeyPairs");
        }

        /// <summary>
        /// This API is used to delete a key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public DeleteKeyPairsResponse DeleteKeyPairsSync(DeleteKeyPairsRequest req)
        {
            return InternalRequestAsync<DeleteKeyPairsResponse>(req, "DeleteKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a snapshot.
        /// The snapshot must be in `NORMAL` status. To query the status of a snapshot, you can call the `DescribeSnapshots` API and see the `SnapshotState` field in the response.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots");
        }

        /// <summary>
        /// This API is used to delete a snapshot.
        /// The snapshot must be in `NORMAL` status. To query the status of a snapshot, you can call the `DescribeSnapshots` API and see the `SnapshotState` field in the response.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of scenes in all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllScenesRequest"/></param>
        /// <returns><see cref="DescribeAllScenesResponse"/></returns>
        public Task<DescribeAllScenesResponse> DescribeAllScenes(DescribeAllScenesRequest req)
        {
            return InternalRequestAsync<DescribeAllScenesResponse>(req, "DescribeAllScenes");
        }

        /// <summary>
        /// This API is used to query the list of scenes in all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllScenesRequest"/></param>
        /// <returns><see cref="DescribeAllScenesResponse"/></returns>
        public DescribeAllScenesResponse DescribeAllScenesSync(DescribeAllScenesRequest req)
        {
            return InternalRequestAsync<DescribeAllScenesResponse>(req, "DescribeAllScenes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of an image instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public Task<DescribeBlueprintInstancesResponse> DescribeBlueprintInstances(DescribeBlueprintInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintInstancesResponse>(req, "DescribeBlueprintInstances");
        }

        /// <summary>
        /// This API is used to query the information of an image instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public DescribeBlueprintInstancesResponse DescribeBlueprintInstancesSync(DescribeBlueprintInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintInstancesResponse>(req, "DescribeBlueprintInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public Task<DescribeBlueprintsResponse> DescribeBlueprints(DescribeBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintsResponse>(req, "DescribeBlueprints");
        }

        /// <summary>
        /// This API is used to query the information of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public DescribeBlueprintsResponse DescribeBlueprintsSync(DescribeBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintsResponse>(req, "DescribeBlueprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the discount information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public Task<DescribeBundleDiscountResponse> DescribeBundleDiscount(DescribeBundleDiscountRequest req)
        {
            return InternalRequestAsync<DescribeBundleDiscountResponse>(req, "DescribeBundleDiscount");
        }

        /// <summary>
        /// This API is used to query the discount information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public DescribeBundleDiscountResponse DescribeBundleDiscountSync(DescribeBundleDiscountRequest req)
        {
            return InternalRequestAsync<DescribeBundleDiscountResponse>(req, "DescribeBundleDiscount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public Task<DescribeBundlesResponse> DescribeBundles(DescribeBundlesRequest req)
        {
            return InternalRequestAsync<DescribeBundlesResponse>(req, "DescribeBundles");
        }

        /// <summary>
        /// This API is used to query the information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public DescribeBundlesResponse DescribeBundlesSync(DescribeBundlesRequest req)
        {
            return InternalRequestAsync<DescribeBundlesResponse>(req, "DescribeBundles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of instances associated with CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances");
        }

        /// <summary>
        /// This API is used to query the information of instances associated with CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cloud disk configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public Task<DescribeDiskConfigsResponse> DescribeDiskConfigs(DescribeDiskConfigsRequest req)
        {
            return InternalRequestAsync<DescribeDiskConfigsResponse>(req, "DescribeDiskConfigs");
        }

        /// <summary>
        /// This API is used to query the cloud disk configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public DescribeDiskConfigsResponse DescribeDiskConfigsSync(DescribeDiskConfigsRequest req)
        {
            return InternalRequestAsync<DescribeDiskConfigsResponse>(req, "DescribeDiskConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the discount information of a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public Task<DescribeDiskDiscountResponse> DescribeDiskDiscount(DescribeDiskDiscountRequest req)
        {
            return InternalRequestAsync<DescribeDiskDiscountResponse>(req, "DescribeDiskDiscount");
        }

        /// <summary>
        /// This API is used to query the discount information of a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public DescribeDiskDiscountResponse DescribeDiskDiscountSync(DescribeDiskDiscountRequest req)
        {
            return InternalRequestAsync<DescribeDiskDiscountResponse>(req, "DescribeDiskDiscount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks");
        }

        /// <summary>
        /// This API is used to query the information of one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public DescribeDisksResponse DescribeDisksSync(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public Task<DescribeDisksDeniedActionsResponse> DescribeDisksDeniedActions(DescribeDisksDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDisksDeniedActionsResponse>(req, "DescribeDisksDeniedActions");
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public DescribeDisksDeniedActionsResponse DescribeDisksDeniedActionsSync(DescribeDisksDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDisksDeniedActionsResponse>(req, "DescribeDisksDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query whether the specified cloud disk can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public Task<DescribeDisksReturnableResponse> DescribeDisksReturnable(DescribeDisksReturnableRequest req)
        {
            return InternalRequestAsync<DescribeDisksReturnableResponse>(req, "DescribeDisksReturnable");
        }

        /// <summary>
        /// This API is used to query whether the specified cloud disk can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public DescribeDisksReturnableResponse DescribeDisksReturnableSync(DescribeDisksReturnableRequest req)
        {
            return InternalRequestAsync<DescribeDisksReturnableResponse>(req, "DescribeDisksReturnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the firewall rules of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public Task<DescribeFirewallRulesResponse> DescribeFirewallRules(DescribeFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesResponse>(req, "DescribeFirewallRules");
        }

        /// <summary>
        /// This API is used to query the firewall rules of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public DescribeFirewallRulesResponse DescribeFirewallRulesSync(DescribeFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesResponse>(req, "DescribeFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a firewall rule template.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public Task<DescribeFirewallRulesTemplateResponse> DescribeFirewallRulesTemplate(DescribeFirewallRulesTemplateRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesTemplateResponse>(req, "DescribeFirewallRulesTemplate");
        }

        /// <summary>
        /// This API is used to query a firewall rule template.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public DescribeFirewallRulesTemplateResponse DescribeFirewallRulesTemplateSync(DescribeFirewallRulesTemplateRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesTemplateResponse>(req, "DescribeFirewallRulesTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the quota information of general resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public Task<DescribeGeneralResourceQuotasResponse> DescribeGeneralResourceQuotas(DescribeGeneralResourceQuotasRequest req)
        {
            return InternalRequestAsync<DescribeGeneralResourceQuotasResponse>(req, "DescribeGeneralResourceQuotas");
        }

        /// <summary>
        /// This API is used to query the quota information of general resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public DescribeGeneralResourceQuotasResponse DescribeGeneralResourceQuotasSync(DescribeGeneralResourceQuotasRequest req)
        {
            return InternalRequestAsync<DescribeGeneralResourceQuotasResponse>(req, "DescribeGeneralResourceQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the attributes of the default login key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginKeyPairAttributeResponse"/></returns>
        public Task<DescribeInstanceLoginKeyPairAttributeResponse> DescribeInstanceLoginKeyPairAttribute(DescribeInstanceLoginKeyPairAttributeRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLoginKeyPairAttributeResponse>(req, "DescribeInstanceLoginKeyPairAttribute");
        }

        /// <summary>
        /// This API is used to query the attributes of the default login key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginKeyPairAttributeResponse"/></returns>
        public DescribeInstanceLoginKeyPairAttributeResponse DescribeInstanceLoginKeyPairAttributeSync(DescribeInstanceLoginKeyPairAttributeRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLoginKeyPairAttributeResponse>(req, "DescribeInstanceLoginKeyPairAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the URL for VNC login.
        /// 
        /// * It does not support `STOPPED` CVMs.
        /// * A VNC URL is only valid for 15 seconds. If you do not access the URL within 15 seconds, you will need to query another one.
        /// * The VNC URL can be used once only. You need to query a new one if you want to log in again.
        /// * Up to 30 re-connection attempts allowed in one minute.
        /// * `InstanceVncUrl`: Its value will be returned after the API is successfully called.
        /// After you get the value of `InstanceVncUrl`, you need to append `InstanceVncUrl=xxxx` to the end of the link `https://img.qcloud.com/qcloud/app/active_vnc/index.html?`.
        ///  The final URL can be in the following formats:
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl");
        }

        /// <summary>
        /// This API is used to query the URL for VNC login.
        /// 
        /// * It does not support `STOPPED` CVMs.
        /// * A VNC URL is only valid for 15 seconds. If you do not access the URL within 15 seconds, you will need to query another one.
        /// * The VNC URL can be used once only. You need to query a new one if you want to log in again.
        /// * Up to 30 re-connection attempts allowed in one minute.
        /// * `InstanceVncUrl`: Its value will be returned after the API is successfully called.
        /// After you get the value of `InstanceVncUrl`, you need to append `InstanceVncUrl=xxxx` to the end of the link `https://img.qcloud.com/qcloud/app/active_vnc/index.html?`.
        ///  The final URL can be in the following formats:
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of one or multiple instances.
        /// 
        /// * You can query the details of an instance according to its ID, name, or private IP.
        /// * For more information on filters, please see [Filters](https://intl.cloud.tencent.com/document/product/1207/47576?from_cn_redirect=1#Filter).
        /// * If no parameter is defined, the status of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// * The latest operation (LatestOperation) and the latest operation status (LatestOperationState) of the instance can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query the details of one or multiple instances.
        /// 
        /// * You can query the details of an instance according to its ID, name, or private IP.
        /// * For more information on filters, please see [Filters](https://intl.cloud.tencent.com/document/product/1207/47576?from_cn_redirect=1#Filter).
        /// * If no parameter is defined, the status of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// * The latest operation (LatestOperation) and the latest operation status (LatestOperationState) of the instance can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions");
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of cloud disks attached to instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public Task<DescribeInstancesDiskNumResponse> DescribeInstancesDiskNum(DescribeInstancesDiskNumRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDiskNumResponse>(req, "DescribeInstancesDiskNum");
        }

        /// <summary>
        /// This API is used to query the number of cloud disks attached to instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public DescribeInstancesDiskNumResponse DescribeInstancesDiskNumSync(DescribeInstancesDiskNumRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDiskNumResponse>(req, "DescribeInstancesDiskNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query whether the specified instance can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public Task<DescribeInstancesReturnableResponse> DescribeInstancesReturnable(DescribeInstancesReturnableRequest req)
        {
            return InternalRequestAsync<DescribeInstancesReturnableResponse>(req, "DescribeInstancesReturnable");
        }

        /// <summary>
        /// This API is used to query whether the specified instance can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public DescribeInstancesReturnableResponse DescribeInstancesReturnableSync(DescribeInstancesReturnableRequest req)
        {
            return InternalRequestAsync<DescribeInstancesReturnableResponse>(req, "DescribeInstancesReturnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the traffic package details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public Task<DescribeInstancesTrafficPackagesResponse> DescribeInstancesTrafficPackages(DescribeInstancesTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesTrafficPackagesResponse>(req, "DescribeInstancesTrafficPackages");
        }

        /// <summary>
        /// This API is used to query the traffic package details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public DescribeInstancesTrafficPackagesResponse DescribeInstancesTrafficPackagesSync(DescribeInstancesTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesTrafficPackagesResponse>(req, "DescribeInstancesTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public Task<DescribeKeyPairsResponse> DescribeKeyPairs(DescribeKeyPairsRequest req)
        {
            return InternalRequestAsync<DescribeKeyPairsResponse>(req, "DescribeKeyPairs");
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public DescribeKeyPairsResponse DescribeKeyPairsSync(DescribeKeyPairsRequest req)
        {
            return InternalRequestAsync<DescribeKeyPairsResponse>(req, "DescribeKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of package options of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public Task<DescribeModifyInstanceBundlesResponse> DescribeModifyInstanceBundles(DescribeModifyInstanceBundlesRequest req)
        {
            return InternalRequestAsync<DescribeModifyInstanceBundlesResponse>(req, "DescribeModifyInstanceBundles");
        }

        /// <summary>
        /// This API is used to query the list of package options of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public DescribeModifyInstanceBundlesResponse DescribeModifyInstanceBundlesSync(DescribeModifyInstanceBundlesRequest req)
        {
            return InternalRequestAsync<DescribeModifyInstanceBundlesResponse>(req, "DescribeModifyInstanceBundles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is used to query the information of regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image information of a reset instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public Task<DescribeResetInstanceBlueprintsResponse> DescribeResetInstanceBlueprints(DescribeResetInstanceBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeResetInstanceBlueprintsResponse>(req, "DescribeResetInstanceBlueprints");
        }

        /// <summary>
        /// This API is used to query the image information of a reset instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public DescribeResetInstanceBlueprintsResponse DescribeResetInstanceBlueprintsSync(DescribeResetInstanceBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeResetInstanceBlueprintsResponse>(req, "DescribeResetInstanceBlueprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of scenes.
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public Task<DescribeScenesResponse> DescribeScenes(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes");
        }

        /// <summary>
        /// This API is used to query the list of scenes.
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public DescribeScenesResponse DescribeScenesSync(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
        }

        /// <summary>
        /// This API is used to query the list of snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public Task<DescribeSnapshotsDeniedActionsResponse> DescribeSnapshotsDeniedActions(DescribeSnapshotsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsDeniedActionsResponse>(req, "DescribeSnapshotsDeniedActions");
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public DescribeSnapshotsDeniedActionsResponse DescribeSnapshotsDeniedActionsSync(DescribeSnapshotsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsDeniedActionsResponse>(req, "DescribeSnapshotsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of AZs in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query the list of AZs in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disassociate with a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public Task<DetachCcnResponse> DetachCcn(DetachCcnRequest req)
        {
            return InternalRequestAsync<DetachCcnResponse>(req, "DetachCcn");
        }

        /// <summary>
        /// This API is used to disassociate with a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public DetachCcnResponse DetachCcnSync(DetachCcnRequest req)
        {
            return InternalRequestAsync<DetachCcnResponse>(req, "DetachCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detach one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public Task<DetachDisksResponse> DetachDisks(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks");
        }

        /// <summary>
        /// This API is used to detach one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public DetachDisksResponse DetachDisksSync(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an instance from the specified key pair.
        /// 
        /// * Only instances on LINUX_UNIX in [RUNNING, STOPPED] status are supported. Instances in `RUNNING` status will be forcibly shut down before unbinding.
        /// * After a key pair is unassociated from an instance, you can log in to the instance with password.
        /// * If no password was set, you cannot log in to the instance with SSH after unbinding. You can call the ResetInstancesPassword API to set a login password.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs");
        }

        /// <summary>
        /// This API is used to unbind an instance from the specified key pair.
        /// 
        /// * Only instances on LINUX_UNIX in [RUNNING, STOPPED] status are supported. Instances in `RUNNING` status will be forcibly shut down before unbinding.
        /// * After a key pair is unassociated from an instance, you can log in to the instance with password.
        /// * If no password was set, you cannot log in to the instance with SSH after unbinding. You can call the ResetInstancesPassword API to set a login password.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import the specified key pair.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public Task<ImportKeyPairResponse> ImportKeyPair(ImportKeyPairRequest req)
        {
            return InternalRequestAsync<ImportKeyPairResponse>(req, "ImportKeyPair");
        }

        /// <summary>
        /// This API is used to import the specified key pair.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public ImportKeyPairResponse ImportKeyPairSync(ImportKeyPairRequest req)
        {
            return InternalRequestAsync<ImportKeyPairResponse>(req, "ImportKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of a created image.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public Task<InquirePriceCreateBlueprintResponse> InquirePriceCreateBlueprint(InquirePriceCreateBlueprintRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateBlueprintResponse>(req, "InquirePriceCreateBlueprint");
        }

        /// <summary>
        /// This API is used to query the price of a created image.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public InquirePriceCreateBlueprintResponse InquirePriceCreateBlueprintSync(InquirePriceCreateBlueprintRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateBlueprintResponse>(req, "InquirePriceCreateBlueprint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of purchasing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public Task<InquirePriceCreateDisksResponse> InquirePriceCreateDisks(InquirePriceCreateDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDisksResponse>(req, "InquirePriceCreateDisks");
        }

        /// <summary>
        /// This API is used to query the price of purchasing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public InquirePriceCreateDisksResponse InquirePriceCreateDisksSync(InquirePriceCreateDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDisksResponse>(req, "InquirePriceCreateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of a created instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public Task<InquirePriceCreateInstancesResponse> InquirePriceCreateInstances(InquirePriceCreateInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateInstancesResponse>(req, "InquirePriceCreateInstances");
        }

        /// <summary>
        /// This API is used to query the price of a created instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public InquirePriceCreateInstancesResponse InquirePriceCreateInstancesSync(InquirePriceCreateInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateInstancesResponse>(req, "InquirePriceCreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of renewing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public Task<InquirePriceRenewDisksResponse> InquirePriceRenewDisks(InquirePriceRenewDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDisksResponse>(req, "InquirePriceRenewDisks");
        }

        /// <summary>
        /// This API is used to query the price of renewing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public InquirePriceRenewDisksResponse InquirePriceRenewDisksSync(InquirePriceRenewDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDisksResponse>(req, "InquirePriceRenewDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of renewing one or more instances.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public Task<InquirePriceRenewInstancesResponse> InquirePriceRenewInstances(InquirePriceRenewInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewInstancesResponse>(req, "InquirePriceRenewInstances");
        }

        /// <summary>
        /// This API is used to query the price of renewing one or more instances.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public InquirePriceRenewInstancesResponse InquirePriceRenewInstancesSync(InquirePriceRenewInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewInstancesResponse>(req, "InquirePriceRenewInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return one or more Lighthouse cloud disks.
        /// 
        /// You can only perform this operation on `UNATTACHED` disks.
        /// After the successful call of the API, the cloud disk goes to the SHUTDOWN state.
        /// Up to 20 instances are supported at one time. 
        /// This API is async. After the request is sent, a `RequestId` is returned. At this time, the operation is not completed yet. To check the result, you need to call  [DescribeDisks](https://intl.cloud.tencent.com/document/product/1207/66093?from_cn_redirect=1). If the latest operation status (LatestOperationState) of the disk is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="IsolateDisksRequest"/></param>
        /// <returns><see cref="IsolateDisksResponse"/></returns>
        public Task<IsolateDisksResponse> IsolateDisks(IsolateDisksRequest req)
        {
            return InternalRequestAsync<IsolateDisksResponse>(req, "IsolateDisks");
        }

        /// <summary>
        /// This API is used to return one or more Lighthouse cloud disks.
        /// 
        /// You can only perform this operation on `UNATTACHED` disks.
        /// After the successful call of the API, the cloud disk goes to the SHUTDOWN state.
        /// Up to 20 instances are supported at one time. 
        /// This API is async. After the request is sent, a `RequestId` is returned. At this time, the operation is not completed yet. To check the result, you need to call  [DescribeDisks](https://intl.cloud.tencent.com/document/product/1207/66093?from_cn_redirect=1). If the latest operation status (LatestOperationState) of the disk is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="IsolateDisksRequest"/></param>
        /// <returns><see cref="IsolateDisksResponse"/></returns>
        public IsolateDisksResponse IsolateDisksSync(IsolateDisksRequest req)
        {
            return InternalRequestAsync<IsolateDisksResponse>(req, "IsolateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return one or more Lighthouse instances. 
        /// * Only `RUNNING` and `STOPPED` instances can be returned. 
        /// * The instance status goes to `SHUTDOWN` after the API is called successfully. 
        /// * Batch operations are supported. Up to 20 resources (including instances and data disks) can be returned in each request. 
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="IsolateInstancesRequest"/></param>
        /// <returns><see cref="IsolateInstancesResponse"/></returns>
        public Task<IsolateInstancesResponse> IsolateInstances(IsolateInstancesRequest req)
        {
            return InternalRequestAsync<IsolateInstancesResponse>(req, "IsolateInstances");
        }

        /// <summary>
        /// This API is used to return one or more Lighthouse instances. 
        /// * Only `RUNNING` and `STOPPED` instances can be returned. 
        /// * The instance status goes to `SHUTDOWN` after the API is called successfully. 
        /// * Batch operations are supported. Up to 20 resources (including instances and data disks) can be returned in each request. 
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="IsolateInstancesRequest"/></param>
        /// <returns><see cref="IsolateInstancesResponse"/></returns>
        public IsolateInstancesResponse IsolateInstancesSync(IsolateInstancesRequest req)
        {
            return InternalRequestAsync<IsolateInstancesResponse>(req, "IsolateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an image attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public Task<ModifyBlueprintAttributeResponse> ModifyBlueprintAttribute(ModifyBlueprintAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBlueprintAttributeResponse>(req, "ModifyBlueprintAttribute");
        }

        /// <summary>
        /// This API is used to modify an image attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public ModifyBlueprintAttributeResponse ModifyBlueprintAttributeSync(ModifyBlueprintAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBlueprintAttributeResponse>(req, "ModifyBlueprintAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cloud disk attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public Task<ModifyDisksAttributeResponse> ModifyDisksAttribute(ModifyDisksAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDisksAttributeResponse>(req, "ModifyDisksAttribute");
        }

        /// <summary>
        /// This API is used to modify cloud disk attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public ModifyDisksAttributeResponse ModifyDisksAttributeSync(ModifyDisksAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDisksAttributeResponse>(req, "ModifyDisksAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of auto-renewal of cloud disks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public Task<ModifyDisksRenewFlagResponse> ModifyDisksRenewFlag(ModifyDisksRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDisksRenewFlagResponse>(req, "ModifyDisksRenewFlag");
        }

        /// <summary>
        /// This API is used to modify the configuration of auto-renewal of cloud disks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public ModifyDisksRenewFlagResponse ModifyDisksRenewFlagSync(ModifyDisksRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDisksRenewFlagResponse>(req, "ModifyDisksRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the description of a single firewall rule.
        /// 
        /// * `FirewallVersion` is used to specify the version of the firewall to be manipulated. If the `FirewallVersion` value passed in is not equal to the current latest version of the firewall, a failure will be returned. If `FirewallVersion` is not passed in, the description of the specified rule will be modified directly.
        /// 
        /// In the `FirewallRule` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRuleDescriptionRequest"/></param>
        /// <returns><see cref="ModifyFirewallRuleDescriptionResponse"/></returns>
        public Task<ModifyFirewallRuleDescriptionResponse> ModifyFirewallRuleDescription(ModifyFirewallRuleDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRuleDescriptionResponse>(req, "ModifyFirewallRuleDescription");
        }

        /// <summary>
        /// This API is used to modify the description of a single firewall rule.
        /// 
        /// * `FirewallVersion` is used to specify the version of the firewall to be manipulated. If the `FirewallVersion` value passed in is not equal to the current latest version of the firewall, a failure will be returned. If `FirewallVersion` is not passed in, the description of the specified rule will be modified directly.
        /// 
        /// In the `FirewallRule` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRuleDescriptionRequest"/></param>
        /// <returns><see cref="ModifyFirewallRuleDescriptionResponse"/></returns>
        public ModifyFirewallRuleDescriptionResponse ModifyFirewallRuleDescriptionSync(ModifyFirewallRuleDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRuleDescriptionResponse>(req, "ModifyFirewallRuleDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the firewall rules of an instance.
        /// 
        /// This API deletes all firewall rules of the current instance first and then adds new rules.
        /// 
        /// * `FirewallVersion` is used to specify the version of the firewall to be manipulated. If the `FirewallVersion` value passed in is not equal to the current latest version of the firewall, a failure will be returned. If `FirewallVersion` is not passed in, the specified rule will be reset directly.
        /// 
        /// In the `FirewallRules` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRulesRequest"/></param>
        /// <returns><see cref="ModifyFirewallRulesResponse"/></returns>
        public Task<ModifyFirewallRulesResponse> ModifyFirewallRules(ModifyFirewallRulesRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRulesResponse>(req, "ModifyFirewallRules");
        }

        /// <summary>
        /// This API is used to reset the firewall rules of an instance.
        /// 
        /// This API deletes all firewall rules of the current instance first and then adds new rules.
        /// 
        /// * `FirewallVersion` is used to specify the version of the firewall to be manipulated. If the `FirewallVersion` value passed in is not equal to the current latest version of the firewall, a failure will be returned. If `FirewallVersion` is not passed in, the specified rule will be reset directly.
        /// 
        /// In the `FirewallRules` parameter:
        /// * Valid values of the `Protocol` field include `TCP`, `UDP`, `ICMP`, and `ALL`.
        /// * For the `Port` field, you can enter only `ALL`, a single port number, several port numbers separated by commas, or a port range indicated by two port numbers separated by a minus sign. If `Port` is a range, the port number on the left of the minus sign must be smaller than the one on the right. If `Protocol` is not `TCP` or `UDP`, `Port` can only be empty or `ALL`. The length of the `Port` field cannot exceed 64 characters.
        /// * For the `CidrBlock` field, you can enter any string that conforms to the CIDR format standard. Multi-Tenant network isolation rules take precedence over private network rules in the firewall.
        /// * For the `Action` field, you can enter only `ACCEPT` or `DROP`.
        /// * The length of the `FirewallRuleDescription` field cannot exceed 64 characters.
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRulesRequest"/></param>
        /// <returns><see cref="ModifyFirewallRulesResponse"/></returns>
        public ModifyFirewallRulesResponse ModifyFirewallRulesSync(ModifyFirewallRulesRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRulesResponse>(req, "ModifyFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an instance attribute. 
        /// * The instance name is used only for users’ convenience. 
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute");
        }

        /// <summary>
        /// This API is used to modify an instance attribute. 
        /// * The instance name is used only for users’ convenience. 
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used change one or more Lighthouse instance bundles. 
        /// * Only `RUNNING` and `STOPPED` instances can be changed. 
        /// * Batch operations are supported. The maximum number of instances in each request is 30. 
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesBundleRequest"/></param>
        /// <returns><see cref="ModifyInstancesBundleResponse"/></returns>
        public Task<ModifyInstancesBundleResponse> ModifyInstancesBundle(ModifyInstancesBundleRequest req)
        {
            return InternalRequestAsync<ModifyInstancesBundleResponse>(req, "ModifyInstancesBundle");
        }

        /// <summary>
        /// This API is used change one or more Lighthouse instance bundles. 
        /// * Only `RUNNING` and `STOPPED` instances can be changed. 
        /// * Batch operations are supported. The maximum number of instances in each request is 30. 
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesBundleRequest"/></param>
        /// <returns><see cref="ModifyInstancesBundleResponse"/></returns>
        public ModifyInstancesBundleResponse ModifyInstancesBundleSync(ModifyInstancesBundleRequest req)
        {
            return InternalRequestAsync<ModifyInstancesBundleResponse>(req, "ModifyInstancesBundle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the attributes of the default login key pair of an instance.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesLoginKeyPairAttributeResponse"/></returns>
        public Task<ModifyInstancesLoginKeyPairAttributeResponse> ModifyInstancesLoginKeyPairAttribute(ModifyInstancesLoginKeyPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesLoginKeyPairAttributeResponse>(req, "ModifyInstancesLoginKeyPairAttribute");
        }

        /// <summary>
        /// This API is used to set the attributes of the default login key pair of an instance.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesLoginKeyPairAttributeResponse"/></returns>
        public ModifyInstancesLoginKeyPairAttributeResponse ModifyInstancesLoginKeyPairAttributeSync(ModifyInstancesLoginKeyPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesLoginKeyPairAttributeResponse>(req, "ModifyInstancesLoginKeyPairAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the auto-renewal setting of monthly-subscribed instances. 
        /// 
        /// * Instances with auto-renewal enabled are automatically renewed on a monthly basis upon the expiration. 
        /// * Batch operations are supported. Up to 100 instances per request is allowed.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public Task<ModifyInstancesRenewFlagResponse> ModifyInstancesRenewFlag(ModifyInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstancesRenewFlagResponse>(req, "ModifyInstancesRenewFlag");
        }

        /// <summary>
        /// This API is used to change the auto-renewal setting of monthly-subscribed instances. 
        /// 
        /// * Instances with auto-renewal enabled are automatically renewed on a monthly basis upon the expiration. 
        /// * Batch operations are supported. Up to 100 instances per request is allowed.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public ModifyInstancesRenewFlagResponse ModifyInstancesRenewFlagSync(ModifyInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstancesRenewFlagResponse>(req, "ModifyInstancesRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a snapshot.
        /// <li>The snapshot name is used only for users’ convenience.</li>
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttribute(ModifySnapshotAttributeRequest req)
        {
            return InternalRequestAsync<ModifySnapshotAttributeResponse>(req, "ModifySnapshotAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a snapshot.
        /// <li>The snapshot name is used only for users’ convenience.</li>
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttributeSync(ModifySnapshotAttributeRequest req)
        {
            return InternalRequestAsync<ModifySnapshotAttributeResponse>(req, "ModifySnapshotAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `REBOOTING` when the API is called successfully and will become `RUNNING` when the instance is successfully restarted.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances");
        }

        /// <summary>
        /// This API is used to restart instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `REBOOTING` when the API is called successfully and will become `RUNNING` when the instance is successfully restarted.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew one or more Lighthouse cloud disks.
        /// 
        /// This operation can only be performed on data disks with the status of `ATTACHED`, `UNATTACHED` or `SHUTDOWN`.
        /// Up to 50 cloud disks are supported at one time.
        /// This API is async. After the request is sent, a `RequestId` is returned. At this time, the operation is not completed yet. To check the result, you need to call  [DescribeDisks](https://intl.cloud.tencent.com/document/product/1207/66093?from_cn_redirect=1). If the latest operation status (LatestOperationState) of the disk is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="RenewDisksRequest"/></param>
        /// <returns><see cref="RenewDisksResponse"/></returns>
        public Task<RenewDisksResponse> RenewDisks(RenewDisksRequest req)
        {
            return InternalRequestAsync<RenewDisksResponse>(req, "RenewDisks");
        }

        /// <summary>
        /// This API is used to renew one or more Lighthouse cloud disks.
        /// 
        /// This operation can only be performed on data disks with the status of `ATTACHED`, `UNATTACHED` or `SHUTDOWN`.
        /// Up to 50 cloud disks are supported at one time.
        /// This API is async. After the request is sent, a `RequestId` is returned. At this time, the operation is not completed yet. To check the result, you need to call  [DescribeDisks](https://intl.cloud.tencent.com/document/product/1207/66093?from_cn_redirect=1). If the latest operation status (LatestOperationState) of the disk is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="RenewDisksRequest"/></param>
        /// <returns><see cref="RenewDisksResponse"/></returns>
        public RenewDisksResponse RenewDisksSync(RenewDisksRequest req)
        {
            return InternalRequestAsync<RenewDisksResponse>(req, "RenewDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew one or more Lighthouse instances.
        /// * You can only perform this operation on instances whose status is `RUNNING`, `STOPPED` and `SHUTDOWN`.
        /// * Batch operations are supported. Up to 100 instances are supported in each request.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="RenewInstancesRequest"/></param>
        /// <returns><see cref="RenewInstancesResponse"/></returns>
        public Task<RenewInstancesResponse> RenewInstances(RenewInstancesRequest req)
        {
            return InternalRequestAsync<RenewInstancesResponse>(req, "RenewInstances");
        }

        /// <summary>
        /// This API is used to renew one or more Lighthouse instances.
        /// * You can only perform this operation on instances whose status is `RUNNING`, `STOPPED` and `SHUTDOWN`.
        /// * Batch operations are supported. Up to 100 instances are supported in each request.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="RenewInstancesRequest"/></param>
        /// <returns><see cref="RenewInstancesResponse"/></returns>
        public RenewInstancesResponse RenewInstancesSync(RenewInstancesRequest req)
        {
            return InternalRequestAsync<RenewInstancesResponse>(req, "RenewInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for association again after a CCN instance association application expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public Task<ResetAttachCcnResponse> ResetAttachCcn(ResetAttachCcnRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnResponse>(req, "ResetAttachCcn");
        }

        /// <summary>
        /// This API is used to apply for association again after a CCN instance association application expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public ResetAttachCcnResponse ResetAttachCcnSync(ResetAttachCcnRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnResponse>(req, "ResetAttachCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reinstall the image on the specified instance.
        /// 
        /// * If you specify a `BlueprintId`, the specified image is used; otherwise, the image used by the current instance is used.
        /// * The system disk will be formatted and reset. Therefore, make sure that no important files are stored on the system disk.
        /// * Currently, this API does not support switching the operating system between `LINUX_UNIX` and `WINDOWS` for instances.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public Task<ResetInstanceResponse> ResetInstance(ResetInstanceRequest req)
        {
            return InternalRequestAsync<ResetInstanceResponse>(req, "ResetInstance");
        }

        /// <summary>
        /// This API is used to reinstall the image on the specified instance.
        /// 
        /// * If you specify a `BlueprintId`, the specified image is used; otherwise, the image used by the current instance is used.
        /// * The system disk will be formatted and reset. Therefore, make sure that no important files are stored on the system disk.
        /// * Currently, this API does not support switching the operating system between `LINUX_UNIX` and `WINDOWS` for instances.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public ResetInstanceResponse ResetInstanceSync(ResetInstanceRequest req)
        {
            return InternalRequestAsync<ResetInstanceResponse>(req, "ResetInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the password of the instance OS to a user-specified password.
        /// * You can only use this API to modify the password of the admin account. The name of the admin account varies by OS (on Windows, it is `Administrator`; on Ubuntu, it is `ubuntu`; on other systems, it is `root`).
        /// * Batch operations are supported. You can reset the passwords of multiple instances to the same one. The maximum number of instances in each request is 100.
        /// * It’s recommended to shut down the instance first and then reset the password. If the instance is running, this API will try to shut it down normally. If the attempt fails, it will force to instance to shut down.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// Note: Just like powering off a physical PC, a forced shutdown may cause data loss or the corruption of file system.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword");
        }

        /// <summary>
        /// This API is used to reset the password of the instance OS to a user-specified password.
        /// * You can only use this API to modify the password of the admin account. The name of the admin account varies by OS (on Windows, it is `Administrator`; on Ubuntu, it is `ubuntu`; on other systems, it is `root`).
        /// * Batch operations are supported. You can reset the passwords of multiple instances to the same one. The maximum number of instances in each request is 100.
        /// * It’s recommended to shut down the instance first and then reset the password. If the instance is running, this API will try to shut it down normally. If the attempt fails, it will force to instance to shut down.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// Note: Just like powering off a physical PC, a forced shutdown may cause data loss or the corruption of file system.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start one or more instances.
        /// 
        /// * You can only perform this operation on instances whose status is `STOPPED`.
        /// * The instance status will become `STARTING` when the API is called successfully and will become `RUNNING` when the instance is successfully started.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances");
        }

        /// <summary>
        /// This API is used to start one or more instances.
        /// 
        /// * You can only perform this operation on instances whose status is `STOPPED`.
        /// * The instance status will become `STARTING` when the API is called successfully and will become `RUNNING` when the instance is successfully started.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to shut down one or more instances.
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `STOPPING` when the API is called successfully and will become `STOPPED` when the instance is successfully shut down.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances");
        }

        /// <summary>
        /// This API is used to shut down one or more instances.
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `STOPPING` when the API is called successfully and will become `STOPPED` when the instance is successfully shut down.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate one or more cloud disk.
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public Task<TerminateDisksResponse> TerminateDisks(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks");
        }

        /// <summary>
        /// This API is used to terminate one or more cloud disk.
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public TerminateDisksResponse TerminateDisksSync(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate one or more instances.
        /// 
        /// * Instances in `SHUTDOWN` status can be terminated through this API and cannot be recovered.
        /// * Batch operations are supported. The allowed maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// This API is used to terminate one or more instances.
        /// 
        /// * Instances in `SHUTDOWN` status can be terminated through this API and cannot be recovered.
        /// * Batch operations are supported. The allowed maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
