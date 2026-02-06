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

namespace TencentCloud.Mqtt.V20240516
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mqtt.V20240516.Models;

   public class MqttClient : AbstractClient{

       private const string endpoint = "mqtt.intl.tencentcloudapi.com";
       private const string version = "2024-05-16";
       private const string sdkVersion = "SDK_NET_3.0.1262";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MqttClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MqttClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add a subscription for an MQTT client.
        /// </summary>
        /// <param name="req"><see cref="AddClientSubscriptionRequest"/></param>
        /// <returns><see cref="AddClientSubscriptionResponse"/></returns>
        public Task<AddClientSubscriptionResponse> AddClientSubscription(AddClientSubscriptionRequest req)
        {
            return InternalRequestAsync<AddClientSubscriptionResponse>(req, "AddClientSubscription");
        }

        /// <summary>
        /// This API is used to add a subscription for an MQTT client.
        /// </summary>
        /// <param name="req"><see cref="AddClientSubscriptionRequest"/></param>
        /// <returns><see cref="AddClientSubscriptionResponse"/></returns>
        public AddClientSubscriptionResponse AddClientSubscriptionSync(AddClientSubscriptionRequest req)
        {
            return InternalRequestAsync<AddClientSubscriptionResponse>(req, "AddClientSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a performance test task for an MQTT instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="CreateAuthorizationPolicyResponse"/></returns>
        public Task<CreateAuthorizationPolicyResponse> CreateAuthorizationPolicy(CreateAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuthorizationPolicyResponse>(req, "CreateAuthorizationPolicy");
        }

        /// <summary>
        /// This API is used to create a performance test task for an MQTT instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="CreateAuthorizationPolicyResponse"/></returns>
        public CreateAuthorizationPolicyResponse CreateAuthorizationPolicySync(CreateAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuthorizationPolicyResponse>(req, "CreateAuthorizationPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase a new MQTT instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// This API is used to purchase a new MQTT instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a message enrichment rule.
        /// </summary>
        /// <param name="req"><see cref="CreateMessageEnrichmentRuleRequest"/></param>
        /// <returns><see cref="CreateMessageEnrichmentRuleResponse"/></returns>
        public Task<CreateMessageEnrichmentRuleResponse> CreateMessageEnrichmentRule(CreateMessageEnrichmentRuleRequest req)
        {
            return InternalRequestAsync<CreateMessageEnrichmentRuleResponse>(req, "CreateMessageEnrichmentRule");
        }

        /// <summary>
        /// This API is used to create a message enrichment rule.
        /// </summary>
        /// <param name="req"><see cref="CreateMessageEnrichmentRuleRequest"/></param>
        /// <returns><see cref="CreateMessageEnrichmentRuleResponse"/></returns>
        public CreateMessageEnrichmentRuleResponse CreateMessageEnrichmentRuleSync(CreateMessageEnrichmentRuleRequest req)
        {
            return InternalRequestAsync<CreateMessageEnrichmentRuleResponse>(req, "CreateMessageEnrichmentRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an MQTT role.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// This API is used to add an MQTT role.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete policy rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuthorizationPolicyResponse"/></returns>
        public Task<DeleteAuthorizationPolicyResponse> DeleteAuthorizationPolicy(DeleteAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuthorizationPolicyResponse>(req, "DeleteAuthorizationPolicy");
        }

        /// <summary>
        /// This API is used to delete policy rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuthorizationPolicyResponse"/></returns>
        public DeleteAuthorizationPolicyResponse DeleteAuthorizationPolicySync(DeleteAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuthorizationPolicyResponse>(req, "DeleteAuthorizationPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a subscription of an MQTT client.
        /// </summary>
        /// <param name="req"><see cref="DeleteClientSubscriptionRequest"/></param>
        /// <returns><see cref="DeleteClientSubscriptionResponse"/></returns>
        public Task<DeleteClientSubscriptionResponse> DeleteClientSubscription(DeleteClientSubscriptionRequest req)
        {
            return InternalRequestAsync<DeleteClientSubscriptionResponse>(req, "DeleteClientSubscription");
        }

        /// <summary>
        /// This API is used to delete a subscription of an MQTT client.
        /// </summary>
        /// <param name="req"><see cref="DeleteClientSubscriptionRequest"/></param>
        /// <returns><see cref="DeleteClientSubscriptionResponse"/></returns>
        public DeleteClientSubscriptionResponse DeleteClientSubscriptionSync(DeleteClientSubscriptionRequest req)
        {
            return InternalRequestAsync<DeleteClientSubscriptionResponse>(req, "DeleteClientSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an MQTT instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// This API is used to delete an MQTT instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the message enrichment rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageEnrichmentRuleRequest"/></param>
        /// <returns><see cref="DeleteMessageEnrichmentRuleResponse"/></returns>
        public Task<DeleteMessageEnrichmentRuleResponse> DeleteMessageEnrichmentRule(DeleteMessageEnrichmentRuleRequest req)
        {
            return InternalRequestAsync<DeleteMessageEnrichmentRuleResponse>(req, "DeleteMessageEnrichmentRule");
        }

        /// <summary>
        /// This API is used to delete the message enrichment rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageEnrichmentRuleRequest"/></param>
        /// <returns><see cref="DeleteMessageEnrichmentRuleResponse"/></returns>
        public DeleteMessageEnrichmentRuleResponse DeleteMessageEnrichmentRuleSync(DeleteMessageEnrichmentRuleRequest req)
        {
            return InternalRequestAsync<DeleteMessageEnrichmentRuleResponse>(req, "DeleteMessageEnrichmentRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an MQTT topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// This API is used to delete an MQTT topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an MQTT user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// This API is used to delete an MQTT user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query authorization rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthorizationPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuthorizationPoliciesResponse"/></returns>
        public Task<DescribeAuthorizationPoliciesResponse> DescribeAuthorizationPolicies(DescribeAuthorizationPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuthorizationPoliciesResponse>(req, "DescribeAuthorizationPolicies");
        }

        /// <summary>
        /// This API is used to query authorization rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthorizationPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuthorizationPoliciesResponse"/></returns>
        public DescribeAuthorizationPoliciesResponse DescribeAuthorizationPoliciesSync(DescribeAuthorizationPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuthorizationPoliciesResponse>(req, "DescribeAuthorizationPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the MQTT client details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientListRequest"/></param>
        /// <returns><see cref="DescribeClientListResponse"/></returns>
        public Task<DescribeClientListResponse> DescribeClientList(DescribeClientListRequest req)
        {
            return InternalRequestAsync<DescribeClientListResponse>(req, "DescribeClientList");
        }

        /// <summary>
        /// This API is used to query the MQTT client details.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientListRequest"/></param>
        /// <returns><see cref="DescribeClientListResponse"/></returns>
        public DescribeClientListResponse DescribeClientListSync(DescribeClientListRequest req)
        {
            return InternalRequestAsync<DescribeClientListResponse>(req, "DescribeClientList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// This API is used to query instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query messages based on subscription.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageByTopicRequest"/></param>
        /// <returns><see cref="DescribeMessageByTopicResponse"/></returns>
        public Task<DescribeMessageByTopicResponse> DescribeMessageByTopic(DescribeMessageByTopicRequest req)
        {
            return InternalRequestAsync<DescribeMessageByTopicResponse>(req, "DescribeMessageByTopic");
        }

        /// <summary>
        /// This API is used to query messages based on subscription.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageByTopicRequest"/></param>
        /// <returns><see cref="DescribeMessageByTopicResponse"/></returns>
        public DescribeMessageByTopicResponse DescribeMessageByTopicSync(DescribeMessageByTopicRequest req)
        {
            return InternalRequestAsync<DescribeMessageByTopicResponse>(req, "DescribeMessageByTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the MQTT message details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageDetailsRequest"/></param>
        /// <returns><see cref="DescribeMessageDetailsResponse"/></returns>
        public Task<DescribeMessageDetailsResponse> DescribeMessageDetails(DescribeMessageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMessageDetailsResponse>(req, "DescribeMessageDetails");
        }

        /// <summary>
        /// This API is used to query the MQTT message details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageDetailsRequest"/></param>
        /// <returns><see cref="DescribeMessageDetailsResponse"/></returns>
        public DescribeMessageDetailsResponse DescribeMessageDetailsSync(DescribeMessageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMessageDetailsResponse>(req, "DescribeMessageDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query message enrichment rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageEnrichmentRulesRequest"/></param>
        /// <returns><see cref="DescribeMessageEnrichmentRulesResponse"/></returns>
        public Task<DescribeMessageEnrichmentRulesResponse> DescribeMessageEnrichmentRules(DescribeMessageEnrichmentRulesRequest req)
        {
            return InternalRequestAsync<DescribeMessageEnrichmentRulesResponse>(req, "DescribeMessageEnrichmentRules");
        }

        /// <summary>
        /// This API is used to query message enrichment rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageEnrichmentRulesRequest"/></param>
        /// <returns><see cref="DescribeMessageEnrichmentRulesResponse"/></returns>
        public DescribeMessageEnrichmentRulesResponse DescribeMessageEnrichmentRulesSync(DescribeMessageEnrichmentRulesRequest req)
        {
            return InternalRequestAsync<DescribeMessageEnrichmentRulesResponse>(req, "DescribeMessageEnrichmentRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the MQTT topic details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic");
        }

        /// <summary>
        /// This API is used to query the MQTT topic details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user list. Filter parameter usage instructions are as follows:.
        /// 
        /// This API is used to perform Username fuzzy search.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList");
        }

        /// <summary>
        /// This API is used to query the user list. Filter parameter usage instructions are as follows:.
        /// 
        /// This API is used to perform Username fuzzy search.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to kick out a client.
        /// </summary>
        /// <param name="req"><see cref="KickOutClientRequest"/></param>
        /// <returns><see cref="KickOutClientResponse"/></returns>
        public Task<KickOutClientResponse> KickOutClient(KickOutClientRequest req)
        {
            return InternalRequestAsync<KickOutClientResponse>(req, "KickOutClient");
        }

        /// <summary>
        /// This API is used to kick out a client.
        /// </summary>
        /// <param name="req"><see cref="KickOutClientRequest"/></param>
        /// <returns><see cref="KickOutClientResponse"/></returns>
        public KickOutClientResponse KickOutClientSync(KickOutClientRequest req)
        {
            return InternalRequestAsync<KickOutClientResponse>(req, "KickOutClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify policy rules. See the data plane authorization policy description (https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="ModifyAuthorizationPolicyResponse"/></returns>
        public Task<ModifyAuthorizationPolicyResponse> ModifyAuthorizationPolicy(ModifyAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAuthorizationPolicyResponse>(req, "ModifyAuthorizationPolicy");
        }

        /// <summary>
        /// This API is used to modify policy rules. See the data plane authorization policy description (https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="ModifyAuthorizationPolicyResponse"/></returns>
        public ModifyAuthorizationPolicyResponse ModifyAuthorizationPolicySync(ModifyAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAuthorizationPolicyResponse>(req, "ModifyAuthorizationPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance attributes. Only running clusters can call this API to perform configuration change.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to modify instance attributes. Only running clusters can call this API to perform configuration change.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify message enrichment rules.
        /// Note: All attributes of the current rule must be submitted, even if specific fields are not modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyMessageEnrichmentRuleRequest"/></param>
        /// <returns><see cref="ModifyMessageEnrichmentRuleResponse"/></returns>
        public Task<ModifyMessageEnrichmentRuleResponse> ModifyMessageEnrichmentRule(ModifyMessageEnrichmentRuleRequest req)
        {
            return InternalRequestAsync<ModifyMessageEnrichmentRuleResponse>(req, "ModifyMessageEnrichmentRule");
        }

        /// <summary>
        /// This API is used to modify message enrichment rules.
        /// Note: All attributes of the current rule must be submitted, even if specific fields are not modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyMessageEnrichmentRuleRequest"/></param>
        /// <returns><see cref="ModifyMessageEnrichmentRuleResponse"/></returns>
        public ModifyMessageEnrichmentRuleResponse ModifyMessageEnrichmentRuleSync(ModifyMessageEnrichmentRuleRequest req)
        {
            return InternalRequestAsync<ModifyMessageEnrichmentRuleResponse>(req, "ModifyMessageEnrichmentRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an MQTT role.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// This API is used to modify an MQTT role.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify policy rule priority.
        /// </summary>
        /// <param name="req"><see cref="UpdateAuthorizationPolicyPriorityRequest"/></param>
        /// <returns><see cref="UpdateAuthorizationPolicyPriorityResponse"/></returns>
        public Task<UpdateAuthorizationPolicyPriorityResponse> UpdateAuthorizationPolicyPriority(UpdateAuthorizationPolicyPriorityRequest req)
        {
            return InternalRequestAsync<UpdateAuthorizationPolicyPriorityResponse>(req, "UpdateAuthorizationPolicyPriority");
        }

        /// <summary>
        /// This API is used to modify policy rule priority.
        /// </summary>
        /// <param name="req"><see cref="UpdateAuthorizationPolicyPriorityRequest"/></param>
        /// <returns><see cref="UpdateAuthorizationPolicyPriorityResponse"/></returns>
        public UpdateAuthorizationPolicyPriorityResponse UpdateAuthorizationPolicyPrioritySync(UpdateAuthorizationPolicyPriorityRequest req)
        {
            return InternalRequestAsync<UpdateAuthorizationPolicyPriorityResponse>(req, "UpdateAuthorizationPolicyPriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the priority for message enrichment rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateMessageEnrichmentRulePriorityRequest"/></param>
        /// <returns><see cref="UpdateMessageEnrichmentRulePriorityResponse"/></returns>
        public Task<UpdateMessageEnrichmentRulePriorityResponse> UpdateMessageEnrichmentRulePriority(UpdateMessageEnrichmentRulePriorityRequest req)
        {
            return InternalRequestAsync<UpdateMessageEnrichmentRulePriorityResponse>(req, "UpdateMessageEnrichmentRulePriority");
        }

        /// <summary>
        /// This API is used to modify the priority for message enrichment rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateMessageEnrichmentRulePriorityRequest"/></param>
        /// <returns><see cref="UpdateMessageEnrichmentRulePriorityResponse"/></returns>
        public UpdateMessageEnrichmentRulePriorityResponse UpdateMessageEnrichmentRulePrioritySync(UpdateMessageEnrichmentRulePriorityRequest req)
        {
            return InternalRequestAsync<UpdateMessageEnrichmentRulePriorityResponse>(req, "UpdateMessageEnrichmentRulePriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
