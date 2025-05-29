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

namespace TencentCloud.Ckafka.V20190819
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ckafka.V20190819.Models;

   public class CkafkaClient : AbstractClient{

       private const string endpoint = "ckafka.intl.tencentcloudapi.com";
       private const string version = "2019-08-19";
       private const string sdkVersion = "SDK_NET_3.0.1141";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CkafkaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CkafkaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create ACL policies in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public Task<BatchCreateAclResponse> BatchCreateAcl(BatchCreateAclRequest req)
        {
            return InternalRequestAsync<BatchCreateAclResponse>(req, "BatchCreateAcl");
        }

        /// <summary>
        /// This API is used to create ACL policies in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public BatchCreateAclResponse BatchCreateAclSync(BatchCreateAclRequest req)
        {
            return InternalRequestAsync<BatchCreateAclResponse>(req, "BatchCreateAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch modify consumer group offsets.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public Task<BatchModifyGroupOffsetsResponse> BatchModifyGroupOffsets(BatchModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<BatchModifyGroupOffsetsResponse>(req, "BatchModifyGroupOffsets");
        }

        /// <summary>
        /// This API is used to batch modify consumer group offsets.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public BatchModifyGroupOffsetsResponse BatchModifyGroupOffsetsSync(BatchModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<BatchModifyGroupOffsetsResponse>(req, "BatchModifyGroupOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch set topic attributes.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public Task<BatchModifyTopicAttributesResponse> BatchModifyTopicAttributes(BatchModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<BatchModifyTopicAttributesResponse>(req, "BatchModifyTopicAttributes");
        }

        /// <summary>
        /// This API is used to batch set topic attributes.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public BatchModifyTopicAttributesResponse BatchModifyTopicAttributesSync(BatchModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<BatchModifyTopicAttributesResponse>(req, "BatchModifyTopicAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an ACL policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public Task<CreateAclResponse> CreateAcl(CreateAclRequest req)
        {
            return InternalRequestAsync<CreateAclResponse>(req, "CreateAcl");
        }

        /// <summary>
        /// This API is used to add an ACL policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public CreateAclResponse CreateAclSync(CreateAclRequest req)
        {
            return InternalRequestAsync<CreateAclResponse>(req, "CreateAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API shows you how to create an ACL rule.
        /// </summary>
        /// <param name="req"><see cref="CreateAclRuleRequest"/></param>
        /// <returns><see cref="CreateAclRuleResponse"/></returns>
        public Task<CreateAclRuleResponse> CreateAclRule(CreateAclRuleRequest req)
        {
            return InternalRequestAsync<CreateAclRuleResponse>(req, "CreateAclRule");
        }

        /// <summary>
        /// This API shows you how to create an ACL rule.
        /// </summary>
        /// <param name="req"><see cref="CreateAclRuleRequest"/></param>
        /// <returns><see cref="CreateAclRuleResponse"/></returns>
        public CreateAclRuleResponse CreateAclRuleSync(CreateAclRuleRequest req)
        {
            return InternalRequestAsync<CreateAclRuleResponse>(req, "CreateAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public Task<CreateConsumerResponse> CreateConsumer(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer");
        }

        /// <summary>
        /// This API is used to create a consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public CreateConsumerResponse CreateConsumerSync(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a DataHub topic.
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTopicRequest"/></param>
        /// <returns><see cref="CreateDatahubTopicResponse"/></returns>
        public Task<CreateDatahubTopicResponse> CreateDatahubTopic(CreateDatahubTopicRequest req)
        {
            return InternalRequestAsync<CreateDatahubTopicResponse>(req, "CreateDatahubTopic");
        }

        /// <summary>
        /// This API is used to create a DataHub topic.
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTopicRequest"/></param>
        /// <returns><see cref="CreateDatahubTopicResponse"/></returns>
        public CreateDatahubTopicResponse CreateDatahubTopicSync(CreateDatahubTopicRequest req)
        {
            return InternalRequestAsync<CreateDatahubTopicResponse>(req, "CreateDatahubTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go instance.  It will be deprecated in future versions. We recommend that you use the `CreatePostPaidInstance` API instead.  You can call this API via SDK or the TencentCloud API console to create a pay-as-you-go CKafka instance,  which is an alternate option for making a purchase in the console.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePostRequest"/></param>
        /// <returns><see cref="CreateInstancePostResponse"/></returns>
        public Task<CreateInstancePostResponse> CreateInstancePost(CreateInstancePostRequest req)
        {
            return InternalRequestAsync<CreateInstancePostResponse>(req, "CreateInstancePost");
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go instance.  It will be deprecated in future versions. We recommend that you use the `CreatePostPaidInstance` API instead.  You can call this API via SDK or the TencentCloud API console to create a pay-as-you-go CKafka instance,  which is an alternate option for making a purchase in the console.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePostRequest"/></param>
        /// <returns><see cref="CreateInstancePostResponse"/></returns>
        public CreateInstancePostResponse CreateInstancePostSync(CreateInstancePostRequest req)
        {
            return InternalRequestAsync<CreateInstancePostResponse>(req, "CreateInstancePost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a partition in a topic.
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public Task<CreatePartitionResponse> CreatePartition(CreatePartitionRequest req)
        {
            return InternalRequestAsync<CreatePartitionResponse>(req, "CreatePartition");
        }

        /// <summary>
        /// This API is used to add a partition in a topic.
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public CreatePartitionResponse CreatePartitionSync(CreatePartitionRequest req)
        {
            return InternalRequestAsync<CreatePartitionResponse>(req, "CreatePartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replace `CreateInstancePost`  to create a pay-as-you-go instance.  You can call this API via SDK or the TencentCloud API console to create a pay-as-you-go CKafka instance,  which is an alternate option for making a purchase in the console.
        /// </summary>
        /// <param name="req"><see cref="CreatePostPaidInstanceRequest"/></param>
        /// <returns><see cref="CreatePostPaidInstanceResponse"/></returns>
        public Task<CreatePostPaidInstanceResponse> CreatePostPaidInstance(CreatePostPaidInstanceRequest req)
        {
            return InternalRequestAsync<CreatePostPaidInstanceResponse>(req, "CreatePostPaidInstance");
        }

        /// <summary>
        /// This API is used to replace `CreateInstancePost`  to create a pay-as-you-go instance.  You can call this API via SDK or the TencentCloud API console to create a pay-as-you-go CKafka instance,  which is an alternate option for making a purchase in the console.
        /// </summary>
        /// <param name="req"><see cref="CreatePostPaidInstanceRequest"/></param>
        /// <returns><see cref="CreatePostPaidInstanceResponse"/></returns>
        public CreatePostPaidInstanceResponse CreatePostPaidInstanceSync(CreatePostPaidInstanceRequest req)
        {
            return InternalRequestAsync<CreatePostPaidInstanceResponse>(req, "CreatePostPaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// This API is used to create a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public Task<CreateTopicIpWhiteListResponse> CreateTopicIpWhiteList(CreateTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<CreateTopicIpWhiteListResponse>(req, "CreateTopicIpWhiteList");
        }

        /// <summary>
        /// This API is used to create a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public CreateTopicIpWhiteListResponse CreateTopicIpWhiteListSync(CreateTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<CreateTopicIpWhiteListResponse>(req, "CreateTopicIpWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// This API is used to add a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public Task<DeleteAclResponse> DeleteAcl(DeleteAclRequest req)
        {
            return InternalRequestAsync<DeleteAclResponse>(req, "DeleteAcl");
        }

        /// <summary>
        /// This API is used to delete an ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public DeleteAclResponse DeleteAclSync(DeleteAclRequest req)
        {
            return InternalRequestAsync<DeleteAclResponse>(req, "DeleteAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a monthly subscribed (prepaid) instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePreRequest"/></param>
        /// <returns><see cref="DeleteInstancePreResponse"/></returns>
        public Task<DeleteInstancePreResponse> DeleteInstancePre(DeleteInstancePreRequest req)
        {
            return InternalRequestAsync<DeleteInstancePreResponse>(req, "DeleteInstancePre");
        }

        /// <summary>
        /// This API is used to delete a monthly subscribed (prepaid) instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePreRequest"/></param>
        /// <returns><see cref="DeleteInstancePreResponse"/></returns>
        public DeleteInstancePreResponse DeleteInstancePreSync(DeleteInstancePreRequest req)
        {
            return InternalRequestAsync<DeleteInstancePreResponse>(req, "DeleteInstancePre")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a route.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public Task<DeleteRouteResponse> DeleteRoute(DeleteRouteRequest req)
        {
            return InternalRequestAsync<DeleteRouteResponse>(req, "DeleteRoute");
        }

        /// <summary>
        /// This API is used to delete a route.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public DeleteRouteResponse DeleteRouteSync(DeleteRouteRequest req)
        {
            return InternalRequestAsync<DeleteRouteResponse>(req, "DeleteRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the delayed trigger time of route deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public Task<DeleteRouteTriggerTimeResponse> DeleteRouteTriggerTime(DeleteRouteTriggerTimeRequest req)
        {
            return InternalRequestAsync<DeleteRouteTriggerTimeResponse>(req, "DeleteRouteTriggerTime");
        }

        /// <summary>
        /// This API is used to modify the delayed trigger time of route deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public DeleteRouteTriggerTimeResponse DeleteRouteTriggerTimeSync(DeleteRouteTriggerTimeRequest req)
        {
            return InternalRequestAsync<DeleteRouteTriggerTimeResponse>(req, "DeleteRouteTriggerTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// This API is used to delete a CKafka topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public Task<DeleteTopicIpWhiteListResponse> DeleteTopicIpWhiteList(DeleteTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteTopicIpWhiteListResponse>(req, "DeleteTopicIpWhiteList");
        }

        /// <summary>
        /// This API is used to delete a topic IP allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public DeleteTopicIpWhiteListResponse DeleteTopicIpWhiteListSync(DeleteTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteTopicIpWhiteListResponse>(req, "DeleteTopicIpWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// This API is used to delete a user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public Task<DescribeACLResponse> DescribeACL(DescribeACLRequest req)
        {
            return InternalRequestAsync<DescribeACLResponse>(req, "DescribeACL");
        }

        /// <summary>
        /// This API is used to enumerate ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public DescribeACLResponse DescribeACLSync(DescribeACLRequest req)
        {
            return InternalRequestAsync<DescribeACLResponse>(req, "DescribeACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the ACL rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public Task<DescribeAclRuleResponse> DescribeAclRule(DescribeAclRuleRequest req)
        {
            return InternalRequestAsync<DescribeAclRuleResponse>(req, "DescribeAclRule");
        }

        /// <summary>
        /// This API is used to query the ACL rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public DescribeAclRuleResponse DescribeAclRuleSync(DescribeAclRuleRequest req)
        {
            return InternalRequestAsync<DescribeAclRuleResponse>(req, "DescribeAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public Task<DescribeAppInfoResponse> DescribeAppInfo(DescribeAppInfoRequest req)
        {
            return InternalRequestAsync<DescribeAppInfoResponse>(req, "DescribeAppInfo");
        }

        /// <summary>
        /// This API is used to query the user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public DescribeAppInfoResponse DescribeAppInfoSync(DescribeAppInfoRequest req)
        {
            return InternalRequestAsync<DescribeAppInfoResponse>(req, "DescribeAppInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the AZ list of Ckafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public Task<DescribeCkafkaZoneResponse> DescribeCkafkaZone(DescribeCkafkaZoneRequest req)
        {
            return InternalRequestAsync<DescribeCkafkaZoneResponse>(req, "DescribeCkafkaZone");
        }

        /// <summary>
        /// This API is used to view the AZ list of Ckafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public DescribeCkafkaZoneResponse DescribeCkafkaZoneSync(DescribeCkafkaZoneRequest req)
        {
            return InternalRequestAsync<DescribeCkafkaZoneResponse>(req, "DescribeCkafkaZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public Task<DescribeConsumerGroupResponse> DescribeConsumerGroup(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup");
        }

        /// <summary>
        /// This API is used to query consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public DescribeConsumerGroupResponse DescribeConsumerGroupSync(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DataHub topic attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicResponse"/></returns>
        public Task<DescribeDatahubTopicResponse> DescribeDatahubTopic(DescribeDatahubTopicRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicResponse>(req, "DescribeDatahubTopic");
        }

        /// <summary>
        /// This API is used to get the DataHub topic attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicResponse"/></returns>
        public DescribeDatahubTopicResponse DescribeDatahubTopicSync(DescribeDatahubTopicRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicResponse>(req, "DescribeDatahubTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the DataHub topic list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicsRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicsResponse"/></returns>
        public Task<DescribeDatahubTopicsResponse> DescribeDatahubTopics(DescribeDatahubTopicsRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicsResponse>(req, "DescribeDatahubTopics");
        }

        /// <summary>
        /// This API is used to query the DataHub topic list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicsRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicsResponse"/></returns>
        public DescribeDatahubTopicsResponse DescribeDatahubTopicsSync(DescribeDatahubTopicsRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicsResponse>(req, "DescribeDatahubTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate consumer groups (simplified).
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup");
        }

        /// <summary>
        /// This API is used to enumerate consumer groups (simplified).
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public Task<DescribeGroupInfoResponse> DescribeGroupInfo(DescribeGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeGroupInfoResponse>(req, "DescribeGroupInfo");
        }

        /// <summary>
        /// This API is used to get consumer group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public DescribeGroupInfoResponse DescribeGroupInfoSync(DescribeGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeGroupInfoResponse>(req, "DescribeGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the consumer group offset.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public Task<DescribeGroupOffsetsResponse> DescribeGroupOffsets(DescribeGroupOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeGroupOffsetsResponse>(req, "DescribeGroupOffsets");
        }

        /// <summary>
        /// This API is used to get the consumer group offset.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public DescribeGroupOffsetsResponse DescribeGroupOffsetsSync(DescribeGroupOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeGroupOffsetsResponse>(req, "DescribeGroupOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get instance attributes. 
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public Task<DescribeInstanceAttributesResponse> DescribeInstanceAttributes(DescribeInstanceAttributesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAttributesResponse>(req, "DescribeInstanceAttributes");
        }

        /// <summary>
        /// This API is used to get instance attributes. 
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public DescribeInstanceAttributesResponse DescribeInstanceAttributesSync(DescribeInstanceAttributesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAttributesResponse>(req, "DescribeInstanceAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of CKafka instances under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to get the list of CKafka instances under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get instance list details under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public Task<DescribeInstancesDetailResponse> DescribeInstancesDetail(DescribeInstancesDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDetailResponse>(req, "DescribeInstancesDetail");
        }

        /// <summary>
        /// This API is used to get instance list details under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public DescribeInstancesDetailResponse DescribeInstancesDetailSync(DescribeInstancesDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDetailResponse>(req, "DescribeInstancesDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate regions, and can be called only in Guangzhou.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public Task<DescribeRegionResponse> DescribeRegion(DescribeRegionRequest req)
        {
            return InternalRequestAsync<DescribeRegionResponse>(req, "DescribeRegion");
        }

        /// <summary>
        /// This API is used to enumerate regions, and can be called only in Guangzhou.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public DescribeRegionResponse DescribeRegionSync(DescribeRegionRequest req)
        {
            return InternalRequestAsync<DescribeRegionResponse>(req, "DescribeRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view route information.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public Task<DescribeRouteResponse> DescribeRoute(DescribeRouteRequest req)
        {
            return InternalRequestAsync<DescribeRouteResponse>(req, "DescribeRoute");
        }

        /// <summary>
        /// This API is used to view route information.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public DescribeRouteResponse DescribeRouteSync(DescribeRouteRequest req)
        {
            return InternalRequestAsync<DescribeRouteResponse>(req, "DescribeRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// This API is used to query the task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API domain name: https://ckafka.tencentcloudapi.com
        /// This API is used to get the list of topics in a CKafka instance of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic");
        }

        /// <summary>
        /// API domain name: https://ckafka.tencentcloudapi.com
        /// This API is used to get the list of topics in a CKafka instance of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get topic attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public Task<DescribeTopicAttributesResponse> DescribeTopicAttributes(DescribeTopicAttributesRequest req)
        {
            return InternalRequestAsync<DescribeTopicAttributesResponse>(req, "DescribeTopicAttributes");
        }

        /// <summary>
        /// This API is used to get topic attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public DescribeTopicAttributesResponse DescribeTopicAttributesSync(DescribeTopicAttributesRequest req)
        {
            return InternalRequestAsync<DescribeTopicAttributesResponse>(req, "DescribeTopicAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get topic list details (only for call in the console).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public Task<DescribeTopicDetailResponse> DescribeTopicDetail(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail");
        }

        /// <summary>
        /// This API is used to get topic list details (only for call in the console).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public DescribeTopicDetailResponse DescribeTopicDetailSync(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the connection information of the topic producer.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicProduceConnectionRequest"/></param>
        /// <returns><see cref="DescribeTopicProduceConnectionResponse"/></returns>
        public Task<DescribeTopicProduceConnectionResponse> DescribeTopicProduceConnection(DescribeTopicProduceConnectionRequest req)
        {
            return InternalRequestAsync<DescribeTopicProduceConnectionResponse>(req, "DescribeTopicProduceConnection");
        }

        /// <summary>
        /// This API is used to query the connection information of the topic producer.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicProduceConnectionRequest"/></param>
        /// <returns><see cref="DescribeTopicProduceConnectionResponse"/></returns>
        public DescribeTopicProduceConnectionResponse DescribeTopicProduceConnectionSync(DescribeTopicProduceConnectionRequest req)
        {
            return InternalRequestAsync<DescribeTopicProduceConnectionResponse>(req, "DescribeTopicProduceConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search and subscribe the message group information of a topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public Task<DescribeTopicSubscribeGroupResponse> DescribeTopicSubscribeGroup(DescribeTopicSubscribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeTopicSubscribeGroupResponse>(req, "DescribeTopicSubscribeGroup");
        }

        /// <summary>
        /// This API is used to search and subscribe the message group information of a topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public DescribeTopicSubscribeGroupResponse DescribeTopicSubscribeGroupSync(DescribeTopicSubscribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeTopicSubscribeGroupResponse>(req, "DescribeTopicSubscribeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a synced topic replica.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public Task<DescribeTopicSyncReplicaResponse> DescribeTopicSyncReplica(DescribeTopicSyncReplicaRequest req)
        {
            return InternalRequestAsync<DescribeTopicSyncReplicaResponse>(req, "DescribeTopicSyncReplica");
        }

        /// <summary>
        /// This API is used to get the details of a synced topic replica.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public DescribeTopicSyncReplicaResponse DescribeTopicSyncReplicaSync(DescribeTopicSyncReplicaRequest req)
        {
            return InternalRequestAsync<DescribeTopicSyncReplicaResponse>(req, "DescribeTopicSyncReplica")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user information.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// This API is used to query user information.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query messages based on a specified offset position.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public Task<FetchMessageByOffsetResponse> FetchMessageByOffset(FetchMessageByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageByOffsetResponse>(req, "FetchMessageByOffset");
        }

        /// <summary>
        /// This API is used to query messages based on a specified offset position.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public FetchMessageByOffsetResponse FetchMessageByOffsetSync(FetchMessageByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageByOffsetResponse>(req, "FetchMessageByOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the message list based on an offset.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public Task<FetchMessageListByOffsetResponse> FetchMessageListByOffset(FetchMessageListByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageListByOffsetResponse>(req, "FetchMessageListByOffset");
        }

        /// <summary>
        /// This API is used to query the message list based on an offset.
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public FetchMessageListByOffsetResponse FetchMessageListByOffsetSync(FetchMessageListByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageListByOffsetResponse>(req, "FetchMessageListByOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase a CKafka instance or query the instance renewal price.
        /// </summary>
        /// <param name="req"><see cref="InquireCkafkaPriceRequest"/></param>
        /// <returns><see cref="InquireCkafkaPriceResponse"/></returns>
        public Task<InquireCkafkaPriceResponse> InquireCkafkaPrice(InquireCkafkaPriceRequest req)
        {
            return InternalRequestAsync<InquireCkafkaPriceResponse>(req, "InquireCkafkaPrice");
        }

        /// <summary>
        /// This API is used to purchase a CKafka instance or query the instance renewal price.
        /// </summary>
        /// <param name="req"><see cref="InquireCkafkaPriceRequest"/></param>
        /// <returns><see cref="InquireCkafkaPriceResponse"/></returns>
        public InquireCkafkaPriceResponse InquireCkafkaPriceSync(InquireCkafkaPriceRequest req)
        {
            return InternalRequestAsync<InquireCkafkaPriceResponse>(req, "InquireCkafkaPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an ACL policy, and currently only supports specifying whether to apply the preset rule to new topics.
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public Task<ModifyAclRuleResponse> ModifyAclRule(ModifyAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyAclRuleResponse>(req, "ModifyAclRule");
        }

        /// <summary>
        /// This API is used to modify an ACL policy, and currently only supports specifying whether to apply the preset rule to new topics.
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public ModifyAclRuleResponse ModifyAclRuleSync(ModifyAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyAclRuleResponse>(req, "ModifyAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the DataHub topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTopicRequest"/></param>
        /// <returns><see cref="ModifyDatahubTopicResponse"/></returns>
        public Task<ModifyDatahubTopicResponse> ModifyDatahubTopic(ModifyDatahubTopicRequest req)
        {
            return InternalRequestAsync<ModifyDatahubTopicResponse>(req, "ModifyDatahubTopic");
        }

        /// <summary>
        /// This API is used to modify the DataHub topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTopicRequest"/></param>
        /// <returns><see cref="ModifyDatahubTopicResponse"/></returns>
        public ModifyDatahubTopicResponse ModifyDatahubTopicSync(ModifyDatahubTopicRequest req)
        {
            return InternalRequestAsync<ModifyDatahubTopicResponse>(req, "ModifyDatahubTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the consumer group (Groups) offset.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public Task<ModifyGroupOffsetsResponse> ModifyGroupOffsets(ModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<ModifyGroupOffsetsResponse>(req, "ModifyGroupOffsets");
        }

        /// <summary>
        /// This API is used to set the consumer group (Groups) offset.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public ModifyGroupOffsetsResponse ModifyGroupOffsetsSync(ModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<ModifyGroupOffsetsResponse>(req, "ModifyGroupOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set instance attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public Task<ModifyInstanceAttributesResponse> ModifyInstanceAttributes(ModifyInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributesResponse>(req, "ModifyInstanceAttributes");
        }

        /// <summary>
        /// This API is used to set instance attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public ModifyInstanceAttributesResponse ModifyInstanceAttributesSync(ModifyInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributesResponse>(req, "ModifyInstanceAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the configurations of a prepaid instance, such as disk capacity and bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public Task<ModifyInstancePreResponse> ModifyInstancePre(ModifyInstancePreRequest req)
        {
            return InternalRequestAsync<ModifyInstancePreResponse>(req, "ModifyInstancePre");
        }

        /// <summary>
        /// This API is used to change the configurations of a prepaid instance, such as disk capacity and bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public ModifyInstancePreResponse ModifyInstancePreSync(ModifyInstancePreRequest req)
        {
            return InternalRequestAsync<ModifyInstancePreResponse>(req, "ModifyInstancePre")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the password.
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public Task<ModifyPasswordResponse> ModifyPassword(ModifyPasswordRequest req)
        {
            return InternalRequestAsync<ModifyPasswordResponse>(req, "ModifyPassword");
        }

        /// <summary>
        /// This API is used to change the password.
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public ModifyPasswordResponse ModifyPasswordSync(ModifyPasswordRequest req)
        {
            return InternalRequestAsync<ModifyPasswordResponse>(req, "ModifyPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public Task<ModifyTopicAttributesResponse> ModifyTopicAttributes(ModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTopicAttributesResponse>(req, "ModifyTopicAttributes");
        }

        /// <summary>
        /// This API is used to modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public ModifyTopicAttributesResponse ModifyTopicAttributesSync(ModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTopicAttributesResponse>(req, "ModifyTopicAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send messages through the HTTP access layer.
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public Task<SendMessageResponse> SendMessage(SendMessageRequest req)
        {
            return InternalRequestAsync<SendMessageResponse>(req, "SendMessage");
        }

        /// <summary>
        /// This API is used to send messages through the HTTP access layer.
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public SendMessageResponse SendMessageSync(SendMessageRequest req)
        {
            return InternalRequestAsync<SendMessageResponse>(req, "SendMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
