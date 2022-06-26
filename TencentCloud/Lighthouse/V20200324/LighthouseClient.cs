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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LighthouseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to roll back the system disk snapshot of the specified instance.
        /// <li>Only rollback to the original system disk is supported.</li>
        /// <li>Only snapshots in `NORMAL` status can be used for rollback. To query the status of a snapshot, you can call the `DescribeSnapshots` API and see the `SnapshotState` field in the response.</li>
        /// <li>When a snapshot is rolled back, the status of the instance must be `STOPPED` or `RUNNING`. You can call the `DescribeInstances` API to query the instance status. Instances in `RUNNING` status will be forcibly shut down before snapshot rollback.</li>
        /// </summary>
        /// <param name="req"><see cref="ApplyInstanceSnapshotRequest"/></param>
        /// <returns><see cref="ApplyInstanceSnapshotResponse"/></returns>
        public async Task<ApplyInstanceSnapshotResponse> ApplyInstanceSnapshot(ApplyInstanceSnapshotRequest req)
        {
             JsonResponseModel<ApplyInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ApplyInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<AssociateInstancesKeyPairsResponse> AssociateInstancesKeyPairs(AssociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public async Task<AttachCcnResponse> AttachCcn(AttachCcnRequest req)
        {
             JsonResponseModel<AttachCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public AttachCcnResponse AttachCcnSync(AttachCcnRequest req)
        {
             JsonResponseModel<AttachCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to attach one or more cloud disks.
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
        /// This API is used to attach one or more cloud disks.
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
        /// This API is used to create an image.
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public async Task<CreateBlueprintResponse> CreateBlueprint(CreateBlueprintRequest req)
        {
             JsonResponseModel<CreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image.
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public CreateBlueprintResponse CreateBlueprintSync(CreateBlueprintRequest req)
        {
             JsonResponseModel<CreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateFirewallRulesResponse> CreateFirewallRules(CreateFirewallRulesRequest req)
        {
             JsonResponseModel<CreateFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a system disk snapshot of the specified instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public async Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshot(CreateInstanceSnapshotRequest req)
        {
             JsonResponseModel<CreateInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a system disk snapshot of the specified instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public CreateInstanceSnapshotResponse CreateInstanceSnapshotSync(CreateInstanceSnapshotRequest req)
        {
             JsonResponseModel<CreateInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more Lighthouse instances.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more Lighthouse instances.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public async Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a key pair.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public async Task<DeleteBlueprintsResponse> DeleteBlueprints(DeleteBlueprintsRequest req)
        {
             JsonResponseModel<DeleteBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public DeleteBlueprintsResponse DeleteBlueprintsSync(DeleteBlueprintsRequest req)
        {
             JsonResponseModel<DeleteBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DeleteFirewallRulesResponse> DeleteFirewallRules(DeleteFirewallRulesRequest req)
        {
             JsonResponseModel<DeleteFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairs(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a key pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public DeleteKeyPairsResponse DeleteKeyPairsSync(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a snapshot.
        /// The snapshot must be in `NORMAL` status. To query the status of a snapshot, you can call the `DescribeSnapshots` API and see the `SnapshotState` field in the response.
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
        /// This API is used to delete a snapshot.
        /// The snapshot must be in `NORMAL` status. To query the status of a snapshot, you can call the `DescribeSnapshots` API and see the `SnapshotState` field in the response.
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
        /// This API is used to query the information of an image instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public async Task<DescribeBlueprintInstancesResponse> DescribeBlueprintInstances(DescribeBlueprintInstancesRequest req)
        {
             JsonResponseModel<DescribeBlueprintInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlueprintInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of an image instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public DescribeBlueprintInstancesResponse DescribeBlueprintInstancesSync(DescribeBlueprintInstancesRequest req)
        {
             JsonResponseModel<DescribeBlueprintInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlueprintInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public async Task<DescribeBlueprintsResponse> DescribeBlueprints(DescribeBlueprintsRequest req)
        {
             JsonResponseModel<DescribeBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public DescribeBlueprintsResponse DescribeBlueprintsSync(DescribeBlueprintsRequest req)
        {
             JsonResponseModel<DescribeBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the discount information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public async Task<DescribeBundleDiscountResponse> DescribeBundleDiscount(DescribeBundleDiscountRequest req)
        {
             JsonResponseModel<DescribeBundleDiscountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBundleDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundleDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the discount information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public DescribeBundleDiscountResponse DescribeBundleDiscountSync(DescribeBundleDiscountRequest req)
        {
             JsonResponseModel<DescribeBundleDiscountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBundleDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundleDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public async Task<DescribeBundlesResponse> DescribeBundles(DescribeBundlesRequest req)
        {
             JsonResponseModel<DescribeBundlesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public DescribeBundlesResponse DescribeBundlesSync(DescribeBundlesRequest req)
        {
             JsonResponseModel<DescribeBundlesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of instances associated with CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public async Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of instances associated with CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the cloud disk configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public async Task<DescribeDiskConfigsResponse> DescribeDiskConfigs(DescribeDiskConfigsRequest req)
        {
             JsonResponseModel<DescribeDiskConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the cloud disk configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public DescribeDiskConfigsResponse DescribeDiskConfigsSync(DescribeDiskConfigsRequest req)
        {
             JsonResponseModel<DescribeDiskConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the discount information of a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public async Task<DescribeDiskDiscountResponse> DescribeDiskDiscount(DescribeDiskDiscountRequest req)
        {
             JsonResponseModel<DescribeDiskDiscountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the discount information of a cloud disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public DescribeDiskDiscountResponse DescribeDiskDiscountSync(DescribeDiskDiscountRequest req)
        {
             JsonResponseModel<DescribeDiskDiscountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of one or more cloud disks.
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
        /// This API is used to query the information of one or more cloud disks.
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
        /// This API is used to query the list of operation limits of one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public async Task<DescribeDisksDeniedActionsResponse> DescribeDisksDeniedActions(DescribeDisksDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeDisksDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisksDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more cloud disks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public DescribeDisksDeniedActionsResponse DescribeDisksDeniedActionsSync(DescribeDisksDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeDisksDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisksDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query whether the specified cloud disk can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public async Task<DescribeDisksReturnableResponse> DescribeDisksReturnable(DescribeDisksReturnableRequest req)
        {
             JsonResponseModel<DescribeDisksReturnableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisksReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query whether the specified cloud disk can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public DescribeDisksReturnableResponse DescribeDisksReturnableSync(DescribeDisksReturnableRequest req)
        {
             JsonResponseModel<DescribeDisksReturnableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisksReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the firewall rules of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public async Task<DescribeFirewallRulesResponse> DescribeFirewallRules(DescribeFirewallRulesRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the firewall rules of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public DescribeFirewallRulesResponse DescribeFirewallRulesSync(DescribeFirewallRulesRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a firewall rule template.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public async Task<DescribeFirewallRulesTemplateResponse> DescribeFirewallRulesTemplate(DescribeFirewallRulesTemplateRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirewallRulesTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a firewall rule template.
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public DescribeFirewallRulesTemplateResponse DescribeFirewallRulesTemplateSync(DescribeFirewallRulesTemplateRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirewallRulesTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota information of general resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public async Task<DescribeGeneralResourceQuotasResponse> DescribeGeneralResourceQuotas(DescribeGeneralResourceQuotasRequest req)
        {
             JsonResponseModel<DescribeGeneralResourceQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGeneralResourceQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralResourceQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota information of general resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public DescribeGeneralResourceQuotasResponse DescribeGeneralResourceQuotasSync(DescribeGeneralResourceQuotasRequest req)
        {
             JsonResponseModel<DescribeGeneralResourceQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGeneralResourceQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralResourceQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the attributes of the default login key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginKeyPairAttributeResponse"/></returns>
        public async Task<DescribeInstanceLoginKeyPairAttributeResponse> DescribeInstanceLoginKeyPairAttribute(DescribeInstanceLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the attributes of the default login key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginKeyPairAttributeResponse"/></returns>
        public DescribeInstanceLoginKeyPairAttributeResponse DescribeInstanceLoginKeyPairAttributeSync(DescribeInstanceLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the URL for VNC login.
        /// 
        /// * It does not support `STOPPED` CVMs.
        /// * A VNC URL is only valid for 15 seconds. If you do not access the URL within 15 seconds, you will need to query another one.
        /// * The VNC URL can be used once only. You need to query a new one if you want to log in again.
        /// * Up to 30 re-connection attempts allowed in one minute.
        /// After you get the value of `InstanceVncUrl`, you need to append `InstanceVncUrl=xxxx` to the end of the link `https://img.qcloud.com/qcloud/app/active_vnc/index.html?`.
        /// 
        ///   - `InstanceVncUrl`: Its value will be returned after the API is successfully called.
        /// 
        ///     The final URL can be in the following formats:
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the URL for VNC login.
        /// 
        /// * It does not support `STOPPED` CVMs.
        /// * A VNC URL is only valid for 15 seconds. If you do not access the URL within 15 seconds, you will need to query another one.
        /// * The VNC URL can be used once only. You need to query a new one if you want to log in again.
        /// * Up to 30 re-connection attempts allowed in one minute.
        /// After you get the value of `InstanceVncUrl`, you need to append `InstanceVncUrl=xxxx` to the end of the link `https://img.qcloud.com/qcloud/app/active_vnc/index.html?`.
        /// 
        ///   - `InstanceVncUrl`: Its value will be returned after the API is successfully called.
        /// 
        ///     The final URL can be in the following formats:
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public async Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the number of cloud disks attached to instances.
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
        /// This API is used to query the number of cloud disks attached to instances.
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
        /// This API is used to query whether the specified instance can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public async Task<DescribeInstancesReturnableResponse> DescribeInstancesReturnable(DescribeInstancesReturnableRequest req)
        {
             JsonResponseModel<DescribeInstancesReturnableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query whether the specified instance can be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public DescribeInstancesReturnableResponse DescribeInstancesReturnableSync(DescribeInstancesReturnableRequest req)
        {
             JsonResponseModel<DescribeInstancesReturnableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the traffic package details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public async Task<DescribeInstancesTrafficPackagesResponse> DescribeInstancesTrafficPackages(DescribeInstancesTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeInstancesTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the traffic package details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public DescribeInstancesTrafficPackagesResponse DescribeInstancesTrafficPackagesSync(DescribeInstancesTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeInstancesTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairs(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public DescribeKeyPairsResponse DescribeKeyPairsSync(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of package options of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public async Task<DescribeModifyInstanceBundlesResponse> DescribeModifyInstanceBundles(DescribeModifyInstanceBundlesRequest req)
        {
             JsonResponseModel<DescribeModifyInstanceBundlesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModifyInstanceBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModifyInstanceBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of package options of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public DescribeModifyInstanceBundlesResponse DescribeModifyInstanceBundlesSync(DescribeModifyInstanceBundlesRequest req)
        {
             JsonResponseModel<DescribeModifyInstanceBundlesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModifyInstanceBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModifyInstanceBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the image information of a reset instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public async Task<DescribeResetInstanceBlueprintsResponse> DescribeResetInstanceBlueprints(DescribeResetInstanceBlueprintsRequest req)
        {
             JsonResponseModel<DescribeResetInstanceBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResetInstanceBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResetInstanceBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the image information of a reset instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public DescribeResetInstanceBlueprintsResponse DescribeResetInstanceBlueprintsSync(DescribeResetInstanceBlueprintsRequest req)
        {
             JsonResponseModel<DescribeResetInstanceBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResetInstanceBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResetInstanceBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of snapshots.
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
        /// This API is used to query the list of snapshots.
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
        /// This API is used to query the list of operation limits of one or more snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public async Task<DescribeSnapshotsDeniedActionsResponse> DescribeSnapshotsDeniedActions(DescribeSnapshotsDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotsDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of operation limits of one or more snapshots.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public DescribeSnapshotsDeniedActionsResponse DescribeSnapshotsDeniedActionsSync(DescribeSnapshotsDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotsDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of AZs in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of AZs in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unassociate a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public async Task<DetachCcnResponse> DetachCcn(DetachCcnRequest req)
        {
             JsonResponseModel<DetachCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unassociate a CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public DetachCcnResponse DetachCcnSync(DetachCcnRequest req)
        {
             JsonResponseModel<DetachCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detach one or more cloud disks.
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
        /// This API is used to detach one or more cloud disks.
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
        public async Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import the specified key pair.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public async Task<ImportKeyPairResponse> ImportKeyPair(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import the specified key pair.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public ImportKeyPairResponse ImportKeyPairSync(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of a created image.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public async Task<InquirePriceCreateBlueprintResponse> InquirePriceCreateBlueprint(InquirePriceCreateBlueprintRequest req)
        {
             JsonResponseModel<InquirePriceCreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of a created image.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public InquirePriceCreateBlueprintResponse InquirePriceCreateBlueprintSync(InquirePriceCreateBlueprintRequest req)
        {
             JsonResponseModel<InquirePriceCreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of purchasing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public async Task<InquirePriceCreateDisksResponse> InquirePriceCreateDisks(InquirePriceCreateDisksRequest req)
        {
             JsonResponseModel<InquirePriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of purchasing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public InquirePriceCreateDisksResponse InquirePriceCreateDisksSync(InquirePriceCreateDisksRequest req)
        {
             JsonResponseModel<InquirePriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of a created instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public async Task<InquirePriceCreateInstancesResponse> InquirePriceCreateInstances(InquirePriceCreateInstancesRequest req)
        {
             JsonResponseModel<InquirePriceCreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of a created instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public InquirePriceCreateInstancesResponse InquirePriceCreateInstancesSync(InquirePriceCreateInstancesRequest req)
        {
             JsonResponseModel<InquirePriceCreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of renewing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public async Task<InquirePriceRenewDisksResponse> InquirePriceRenewDisks(InquirePriceRenewDisksRequest req)
        {
             JsonResponseModel<InquirePriceRenewDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRenewDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of renewing cloud disks.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public InquirePriceRenewDisksResponse InquirePriceRenewDisksSync(InquirePriceRenewDisksRequest req)
        {
             JsonResponseModel<InquirePriceRenewDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRenewDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of renewed instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public async Task<InquirePriceRenewInstancesResponse> InquirePriceRenewInstances(InquirePriceRenewInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of renewed instance.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public InquirePriceRenewInstancesResponse InquirePriceRenewInstancesSync(InquirePriceRenewInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an image attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public async Task<ModifyBlueprintAttributeResponse> ModifyBlueprintAttribute(ModifyBlueprintAttributeRequest req)
        {
             JsonResponseModel<ModifyBlueprintAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlueprintAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlueprintAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an image attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public ModifyBlueprintAttributeResponse ModifyBlueprintAttributeSync(ModifyBlueprintAttributeRequest req)
        {
             JsonResponseModel<ModifyBlueprintAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlueprintAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlueprintAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify cloud disk attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public async Task<ModifyDisksAttributeResponse> ModifyDisksAttribute(ModifyDisksAttributeRequest req)
        {
             JsonResponseModel<ModifyDisksAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisksAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify cloud disk attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public ModifyDisksAttributeResponse ModifyDisksAttributeSync(ModifyDisksAttributeRequest req)
        {
             JsonResponseModel<ModifyDisksAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisksAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration of auto-renewal of cloud disks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public async Task<ModifyDisksRenewFlagResponse> ModifyDisksRenewFlag(ModifyDisksRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDisksRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisksRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration of auto-renewal of cloud disks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public ModifyDisksRenewFlagResponse ModifyDisksRenewFlagSync(ModifyDisksRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDisksRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisksRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifyFirewallRuleDescriptionResponse> ModifyFirewallRuleDescription(ModifyFirewallRuleDescriptionRequest req)
        {
             JsonResponseModel<ModifyFirewallRuleDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFirewallRuleDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRuleDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyFirewallRuleDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFirewallRuleDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRuleDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifyFirewallRulesResponse> ModifyFirewallRules(ModifyFirewallRulesRequest req)
        {
             JsonResponseModel<ModifyFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of instances.
        /// * The instance name is used only for users’ convenience.
        /// * Batch operations are supported. Each request can contain up to 100 instances at a time.
        /// * This API is async. A successful request will return a `RequestId`, it does not mean the operation is completed. You can call the `DescribeInstances` API to query the operation result. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public async Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of instances.
        /// * The instance name is used only for users’ convenience.
        /// * Batch operations are supported. Each request can contain up to 100 instances at a time.
        /// * This API is async. A successful request will return a `RequestId`, it does not mean the operation is completed. You can call the `DescribeInstances` API to query the operation result. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the attributes of the default login key pair of an instance.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesLoginKeyPairAttributeResponse"/></returns>
        public async Task<ModifyInstancesLoginKeyPairAttributeResponse> ModifyInstancesLoginKeyPairAttribute(ModifyInstancesLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the attributes of the default login key pair of an instance.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesLoginKeyPairAttributeResponse"/></returns>
        public ModifyInstancesLoginKeyPairAttributeResponse ModifyInstancesLoginKeyPairAttributeSync(ModifyInstancesLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the renewal flags of monthly subscribed instances.
        /// 
        /// * Instances marked with "auto-renewal" will be automatically renewed for one month when they expire.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public async Task<ModifyInstancesRenewFlagResponse> ModifyInstancesRenewFlag(ModifyInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the renewal flags of monthly subscribed instances.
        /// 
        /// * Instances marked with "auto-renewal" will be automatically renewed for one month when they expire.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public ModifyInstancesRenewFlagResponse ModifyInstancesRenewFlagSync(ModifyInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a snapshot.
        /// <li>The snapshot name is used only for users’ convenience.</li>
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
        /// This API is used to modify the attributes of a snapshot.
        /// <li>The snapshot name is used only for users’ convenience.</li>
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
        /// This API is used to restart instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `REBOOTING` when the API is called successfully and will become `RUNNING` when the instance is successfully restarted.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public async Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for association again after a CCN instance association application expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public async Task<ResetAttachCcnResponse> ResetAttachCcn(ResetAttachCcnRequest req)
        {
             JsonResponseModel<ResetAttachCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for association again after a CCN instance association application expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public ResetAttachCcnResponse ResetAttachCcnSync(ResetAttachCcnRequest req)
        {
             JsonResponseModel<ResetAttachCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ResetInstanceResponse> ResetInstance(ResetInstanceRequest req)
        {
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate one or more cloud disk.
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
        /// This API is used to terminate one or more cloud disk.
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
        /// This API is used to terminate one or more instances.
        /// 
        /// * Instances in `SHUTDOWN` status can be terminated through this API and cannot be recovered.
        /// * Batch operations are supported. The allowed maximum number of instances in each request is 100.
        /// * This API is async. After the request is sent successfully, a `RequestId` will be returned. At this time, the operation is not completed immediately. The result of the instance operation can be queried by calling the `DescribeInstances` API. If the latest operation status (LatestOperationState) of the instance is `SUCCESS`, the operation is successful.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public async Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
