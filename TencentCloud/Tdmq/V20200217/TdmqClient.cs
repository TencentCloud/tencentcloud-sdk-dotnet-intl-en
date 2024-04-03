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

namespace TencentCloud.Tdmq.V20200217
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdmq.V20200217.Models;

   public class TdmqClient : AbstractClient{

       private const string endpoint = "tdmq.tencentcloudapi.com";
       private const string version = "2020-02-17";
       private const string sdkVersion = "SDK_NET_3.0.872";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdmqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdmqClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to acknowledge the message in the specified topic by the provided `MessageID`.
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public Task<AcknowledgeMessageResponse> AcknowledgeMessage(AcknowledgeMessageRequest req)
        {
            return InternalRequestAsync<AcknowledgeMessageResponse>(req, "AcknowledgeMessage");
        }

        /// <summary>
        /// This API is used to acknowledge the message in the specified topic by the provided `MessageID`.
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public AcknowledgeMessageResponse AcknowledgeMessageSync(AcknowledgeMessageRequest req)
        {
            return InternalRequestAsync<AcknowledgeMessageResponse>(req, "AcknowledgeMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clear the messages in the CMQ message queue.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public Task<ClearCmqQueueResponse> ClearCmqQueue(ClearCmqQueueRequest req)
        {
            return InternalRequestAsync<ClearCmqQueueResponse>(req, "ClearCmqQueue");
        }

        /// <summary>
        /// This API is used to clear the messages in the CMQ message queue.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public ClearCmqQueueResponse ClearCmqQueueSync(ClearCmqQueueRequest req)
        {
            return InternalRequestAsync<ClearCmqQueueResponse>(req, "ClearCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clear the message tags of a subscriber.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public Task<ClearCmqSubscriptionFilterTagsResponse> ClearCmqSubscriptionFilterTags(ClearCmqSubscriptionFilterTagsRequest req)
        {
            return InternalRequestAsync<ClearCmqSubscriptionFilterTagsResponse>(req, "ClearCmqSubscriptionFilterTags");
        }

        /// <summary>
        /// This API is used to clear the message tags of a subscriber.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public ClearCmqSubscriptionFilterTagsResponse ClearCmqSubscriptionFilterTagsSync(ClearCmqSubscriptionFilterTagsRequest req)
        {
            return InternalRequestAsync<ClearCmqSubscriptionFilterTagsResponse>(req, "ClearCmqSubscriptionFilterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public Task<CreateCmqQueueResponse> CreateCmqQueue(CreateCmqQueueRequest req)
        {
            return InternalRequestAsync<CreateCmqQueueResponse>(req, "CreateCmqQueue");
        }

        /// <summary>
        /// This API is used to create a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public CreateCmqQueueResponse CreateCmqQueueSync(CreateCmqQueueRequest req)
        {
            return InternalRequestAsync<CreateCmqQueueResponse>(req, "CreateCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public Task<CreateCmqSubscribeResponse> CreateCmqSubscribe(CreateCmqSubscribeRequest req)
        {
            return InternalRequestAsync<CreateCmqSubscribeResponse>(req, "CreateCmqSubscribe");
        }

        /// <summary>
        /// This API is used to create a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public CreateCmqSubscribeResponse CreateCmqSubscribeSync(CreateCmqSubscribeRequest req)
        {
            return InternalRequestAsync<CreateCmqSubscribeResponse>(req, "CreateCmqSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public Task<CreateCmqTopicResponse> CreateCmqTopic(CreateCmqTopicRequest req)
        {
            return InternalRequestAsync<CreateCmqTopicResponse>(req, "CreateCmqTopic");
        }

        /// <summary>
        /// This API is used to create a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public CreateCmqTopicResponse CreateCmqTopicSync(CreateCmqTopicRequest req)
        {
            return InternalRequestAsync<CreateCmqTopicResponse>(req, "CreateCmqTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TDMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment");
        }

        /// <summary>
        /// This API is used to create a TDMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an environment role.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public Task<CreateEnvironmentRoleResponse> CreateEnvironmentRole(CreateEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentRoleResponse>(req, "CreateEnvironmentRole");
        }

        /// <summary>
        /// This API is used to create an environment role.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public CreateEnvironmentRoleResponse CreateEnvironmentRoleSync(CreateEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentRoleResponse>(req, "CreateEnvironmentRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TDMQ for RabbitMQ user.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQUserResponse"/></returns>
        public Task<CreateRabbitMQUserResponse> CreateRabbitMQUser(CreateRabbitMQUserRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQUserResponse>(req, "CreateRabbitMQUser");
        }

        /// <summary>
        /// This API is used to create a TDMQ for RabbitMQ user.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQUserResponse"/></returns>
        public CreateRabbitMQUserResponse CreateRabbitMQUserSync(CreateRabbitMQUserRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQUserResponse>(req, "CreateRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TDMQ for RabbitMQ exclusive instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVipInstanceResponse"/></returns>
        public Task<CreateRabbitMQVipInstanceResponse> CreateRabbitMQVipInstance(CreateRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVipInstanceResponse>(req, "CreateRabbitMQVipInstance");
        }

        /// <summary>
        /// This API is used to create a TDMQ for RabbitMQ exclusive instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVipInstanceResponse"/></returns>
        public CreateRabbitMQVipInstanceResponse CreateRabbitMQVipInstanceSync(CreateRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVipInstanceResponse>(req, "CreateRabbitMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TDMQ for RabbitMQ vhost.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVirtualHostResponse"/></returns>
        public Task<CreateRabbitMQVirtualHostResponse> CreateRabbitMQVirtualHost(CreateRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVirtualHostResponse>(req, "CreateRabbitMQVirtualHost");
        }

        /// <summary>
        /// This API is used to create a TDMQ for RabbitMQ vhost.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVirtualHostResponse"/></returns>
        public CreateRabbitMQVirtualHostResponse CreateRabbitMQVirtualHostSync(CreateRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVirtualHostResponse>(req, "CreateRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public Task<CreateRocketMQClusterResponse> CreateRocketMQCluster(CreateRocketMQClusterRequest req)
        {
            return InternalRequestAsync<CreateRocketMQClusterResponse>(req, "CreateRocketMQCluster");
        }

        /// <summary>
        /// This API is used to create a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public CreateRocketMQClusterResponse CreateRocketMQClusterSync(CreateRocketMQClusterRequest req)
        {
            return InternalRequestAsync<CreateRocketMQClusterResponse>(req, "CreateRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public Task<CreateRocketMQGroupResponse> CreateRocketMQGroup(CreateRocketMQGroupRequest req)
        {
            return InternalRequestAsync<CreateRocketMQGroupResponse>(req, "CreateRocketMQGroup");
        }

        /// <summary>
        /// This API is used to create a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public CreateRocketMQGroupResponse CreateRocketMQGroupSync(CreateRocketMQGroupRequest req)
        {
            return InternalRequestAsync<CreateRocketMQGroupResponse>(req, "CreateRocketMQGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public Task<CreateRocketMQNamespaceResponse> CreateRocketMQNamespace(CreateRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<CreateRocketMQNamespaceResponse>(req, "CreateRocketMQNamespace");
        }

        /// <summary>
        /// This API is used to create a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public CreateRocketMQNamespaceResponse CreateRocketMQNamespaceSync(CreateRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<CreateRocketMQNamespaceResponse>(req, "CreateRocketMQNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public Task<CreateRocketMQTopicResponse> CreateRocketMQTopic(CreateRocketMQTopicRequest req)
        {
            return InternalRequestAsync<CreateRocketMQTopicResponse>(req, "CreateRocketMQTopic");
        }

        /// <summary>
        /// This API is used to create a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public CreateRocketMQTopicResponse CreateRocketMQTopicSync(CreateRocketMQTopicRequest req)
        {
            return InternalRequestAsync<CreateRocketMQTopicResponse>(req, "CreateRocketMQTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole");
        }

        /// <summary>
        /// This API is used to create a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a subscription to a topic.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest req)
        {
            return InternalRequestAsync<CreateSubscriptionResponse>(req, "CreateSubscription");
        }

        /// <summary>
        /// This API is used to create a subscription to a topic.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public CreateSubscriptionResponse CreateSubscriptionSync(CreateSubscriptionRequest req)
        {
            return InternalRequestAsync<CreateSubscriptionResponse>(req, "CreateSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a message topic in the specified partition and type.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// This API is used to add a message topic in the specified partition and type.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// This API is used to delete a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public Task<DeleteCmqQueueResponse> DeleteCmqQueue(DeleteCmqQueueRequest req)
        {
            return InternalRequestAsync<DeleteCmqQueueResponse>(req, "DeleteCmqQueue");
        }

        /// <summary>
        /// This API is used to delete a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public DeleteCmqQueueResponse DeleteCmqQueueSync(DeleteCmqQueueRequest req)
        {
            return InternalRequestAsync<DeleteCmqQueueResponse>(req, "DeleteCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public Task<DeleteCmqSubscribeResponse> DeleteCmqSubscribe(DeleteCmqSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteCmqSubscribeResponse>(req, "DeleteCmqSubscribe");
        }

        /// <summary>
        /// This API is used to delete a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public DeleteCmqSubscribeResponse DeleteCmqSubscribeSync(DeleteCmqSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteCmqSubscribeResponse>(req, "DeleteCmqSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public Task<DeleteCmqTopicResponse> DeleteCmqTopic(DeleteCmqTopicRequest req)
        {
            return InternalRequestAsync<DeleteCmqTopicResponse>(req, "DeleteCmqTopic");
        }

        /// <summary>
        /// This API is used to delete a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public DeleteCmqTopicResponse DeleteCmqTopicSync(DeleteCmqTopicRequest req)
        {
            return InternalRequestAsync<DeleteCmqTopicResponse>(req, "DeleteCmqTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an environment role.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public Task<DeleteEnvironmentRolesResponse> DeleteEnvironmentRoles(DeleteEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentRolesResponse>(req, "DeleteEnvironmentRoles");
        }

        /// <summary>
        /// This API is used to delete an environment role.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public DeleteEnvironmentRolesResponse DeleteEnvironmentRolesSync(DeleteEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentRolesResponse>(req, "DeleteEnvironmentRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete namespaces under a tenant.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public Task<DeleteEnvironmentsResponse> DeleteEnvironments(DeleteEnvironmentsRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentsResponse>(req, "DeleteEnvironments");
        }

        /// <summary>
        /// This API is used to batch delete namespaces under a tenant.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public DeleteEnvironmentsResponse DeleteEnvironmentsSync(DeleteEnvironmentsRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentsResponse>(req, "DeleteEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TDMQ for RabbitMQ user.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQUserResponse"/></returns>
        public Task<DeleteRabbitMQUserResponse> DeleteRabbitMQUser(DeleteRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQUserResponse>(req, "DeleteRabbitMQUser");
        }

        /// <summary>
        /// This API is used to delete a TDMQ for RabbitMQ user.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQUserResponse"/></returns>
        public DeleteRabbitMQUserResponse DeleteRabbitMQUserSync(DeleteRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQUserResponse>(req, "DeleteRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TDMQ for RabbitMQ exclusive instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVipInstanceResponse"/></returns>
        public Task<DeleteRabbitMQVipInstanceResponse> DeleteRabbitMQVipInstance(DeleteRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVipInstanceResponse>(req, "DeleteRabbitMQVipInstance");
        }

        /// <summary>
        /// This API is used to delete a TDMQ for RabbitMQ exclusive instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVipInstanceResponse"/></returns>
        public DeleteRabbitMQVipInstanceResponse DeleteRabbitMQVipInstanceSync(DeleteRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVipInstanceResponse>(req, "DeleteRabbitMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TDMQ for RabbitMQ vhost.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVirtualHostResponse"/></returns>
        public Task<DeleteRabbitMQVirtualHostResponse> DeleteRabbitMQVirtualHost(DeleteRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVirtualHostResponse>(req, "DeleteRabbitMQVirtualHost");
        }

        /// <summary>
        /// This API is used to delete a TDMQ for RabbitMQ vhost.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVirtualHostResponse"/></returns>
        public DeleteRabbitMQVirtualHostResponse DeleteRabbitMQVirtualHostSync(DeleteRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVirtualHostResponse>(req, "DeleteRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public Task<DeleteRocketMQClusterResponse> DeleteRocketMQCluster(DeleteRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQClusterResponse>(req, "DeleteRocketMQCluster");
        }

        /// <summary>
        /// This API is used to delete a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public DeleteRocketMQClusterResponse DeleteRocketMQClusterSync(DeleteRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQClusterResponse>(req, "DeleteRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public Task<DeleteRocketMQGroupResponse> DeleteRocketMQGroup(DeleteRocketMQGroupRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQGroupResponse>(req, "DeleteRocketMQGroup");
        }

        /// <summary>
        /// This API is used to delete a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public DeleteRocketMQGroupResponse DeleteRocketMQGroupSync(DeleteRocketMQGroupRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQGroupResponse>(req, "DeleteRocketMQGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public Task<DeleteRocketMQNamespaceResponse> DeleteRocketMQNamespace(DeleteRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQNamespaceResponse>(req, "DeleteRocketMQNamespace");
        }

        /// <summary>
        /// This API is used to delete a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public DeleteRocketMQNamespaceResponse DeleteRocketMQNamespaceSync(DeleteRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQNamespaceResponse>(req, "DeleteRocketMQNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public Task<DeleteRocketMQTopicResponse> DeleteRocketMQTopic(DeleteRocketMQTopicRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQTopicResponse>(req, "DeleteRocketMQTopic");
        }

        /// <summary>
        /// This API is used to delete a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public DeleteRocketMQTopicResponse DeleteRocketMQTopicSync(DeleteRocketMQTopicRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQTopicResponse>(req, "DeleteRocketMQTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or multiple roles.
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public Task<DeleteRolesResponse> DeleteRoles(DeleteRolesRequest req)
        {
            return InternalRequestAsync<DeleteRolesResponse>(req, "DeleteRoles");
        }

        /// <summary>
        /// This API is used to delete one or multiple roles.
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public DeleteRolesResponse DeleteRolesSync(DeleteRolesRequest req)
        {
            return InternalRequestAsync<DeleteRolesResponse>(req, "DeleteRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscriptionsRequest"/></param>
        /// <returns><see cref="DeleteSubscriptionsResponse"/></returns>
        public Task<DeleteSubscriptionsResponse> DeleteSubscriptions(DeleteSubscriptionsRequest req)
        {
            return InternalRequestAsync<DeleteSubscriptionsResponse>(req, "DeleteSubscriptions");
        }

        /// <summary>
        /// This API is used to delete a subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscriptionsRequest"/></param>
        /// <returns><see cref="DeleteSubscriptionsResponse"/></returns>
        public DeleteSubscriptionsResponse DeleteSubscriptionsSync(DeleteSubscriptionsRequest req)
        {
            return InternalRequestAsync<DeleteSubscriptionsResponse>(req, "DeleteSubscriptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete topics.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicsRequest"/></param>
        /// <returns><see cref="DeleteTopicsResponse"/></returns>
        public Task<DeleteTopicsResponse> DeleteTopics(DeleteTopicsRequest req)
        {
            return InternalRequestAsync<DeleteTopicsResponse>(req, "DeleteTopics");
        }

        /// <summary>
        /// This API is used to batch delete topics.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicsRequest"/></param>
        /// <returns><see cref="DeleteTopicsResponse"/></returns>
        public DeleteTopicsResponse DeleteTopicsSync(DeleteTopicsRequest req)
        {
            return InternalRequestAsync<DeleteTopicsResponse>(req, "DeleteTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of dedicated clusters bound to a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindClustersRequest"/></param>
        /// <returns><see cref="DescribeBindClustersResponse"/></returns>
        public Task<DescribeBindClustersResponse> DescribeBindClusters(DescribeBindClustersRequest req)
        {
            return InternalRequestAsync<DescribeBindClustersResponse>(req, "DescribeBindClusters");
        }

        /// <summary>
        /// This API is used to get the list of dedicated clusters bound to a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindClustersRequest"/></param>
        /// <returns><see cref="DescribeBindClustersResponse"/></returns>
        public DescribeBindClustersResponse DescribeBindClustersSync(DescribeBindClustersRequest req)
        {
            return InternalRequestAsync<DescribeBindClustersResponse>(req, "DescribeBindClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the tenant-VPC binding relationship.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public Task<DescribeBindVpcsResponse> DescribeBindVpcs(DescribeBindVpcsRequest req)
        {
            return InternalRequestAsync<DescribeBindVpcsResponse>(req, "DescribeBindVpcs");
        }

        /// <summary>
        /// This API is used to get the tenant-VPC binding relationship.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public DescribeBindVpcsResponse DescribeBindVpcsSync(DescribeBindVpcsRequest req)
        {
            return InternalRequestAsync<DescribeBindVpcsResponse>(req, "DescribeBindVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail");
        }

        /// <summary>
        /// This API is used to get the details of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// This API is used to get the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate the source queues of a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqDeadLetterSourceQueuesResponse"/></returns>
        public Task<DescribeCmqDeadLetterSourceQueuesResponse> DescribeCmqDeadLetterSourceQueues(DescribeCmqDeadLetterSourceQueuesRequest req)
        {
            return InternalRequestAsync<DescribeCmqDeadLetterSourceQueuesResponse>(req, "DescribeCmqDeadLetterSourceQueues");
        }

        /// <summary>
        /// This API is used to enumerate the source queues of a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqDeadLetterSourceQueuesResponse"/></returns>
        public DescribeCmqDeadLetterSourceQueuesResponse DescribeCmqDeadLetterSourceQueuesSync(DescribeCmqDeadLetterSourceQueuesRequest req)
        {
            return InternalRequestAsync<DescribeCmqDeadLetterSourceQueuesResponse>(req, "DescribeCmqDeadLetterSourceQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public Task<DescribeCmqQueueDetailResponse> DescribeCmqQueueDetail(DescribeCmqQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueueDetailResponse>(req, "DescribeCmqQueueDetail");
        }

        /// <summary>
        /// This API is used to query the details of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public DescribeCmqQueueDetailResponse DescribeCmqQueueDetailSync(DescribeCmqQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueueDetailResponse>(req, "DescribeCmqQueueDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all CMQ queues.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqQueuesResponse"/></returns>
        public Task<DescribeCmqQueuesResponse> DescribeCmqQueues(DescribeCmqQueuesRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueuesResponse>(req, "DescribeCmqQueues");
        }

        /// <summary>
        /// This API is used to query all CMQ queues.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqQueuesResponse"/></returns>
        public DescribeCmqQueuesResponse DescribeCmqQueuesSync(DescribeCmqQueuesRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueuesResponse>(req, "DescribeCmqQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CMQ subscription details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public Task<DescribeCmqSubscriptionDetailResponse> DescribeCmqSubscriptionDetail(DescribeCmqSubscriptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqSubscriptionDetailResponse>(req, "DescribeCmqSubscriptionDetail");
        }

        /// <summary>
        /// This API is used to query the CMQ subscription details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public DescribeCmqSubscriptionDetailResponse DescribeCmqSubscriptionDetailSync(DescribeCmqSubscriptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqSubscriptionDetailResponse>(req, "DescribeCmqSubscriptionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public Task<DescribeCmqTopicDetailResponse> DescribeCmqTopicDetail(DescribeCmqTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicDetailResponse>(req, "DescribeCmqTopicDetail");
        }

        /// <summary>
        /// This API is used to query the details of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public DescribeCmqTopicDetailResponse DescribeCmqTopicDetailSync(DescribeCmqTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicDetailResponse>(req, "DescribeCmqTopicDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate all CMQ topics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicsRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicsResponse"/></returns>
        public Task<DescribeCmqTopicsResponse> DescribeCmqTopics(DescribeCmqTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicsResponse>(req, "DescribeCmqTopics");
        }

        /// <summary>
        /// This API is used to enumerate all CMQ topics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicsRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicsResponse"/></returns>
        public DescribeCmqTopicsResponse DescribeCmqTopicsSync(DescribeCmqTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicsResponse>(req, "DescribeCmqTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public Task<DescribeEnvironmentAttributesResponse> DescribeEnvironmentAttributes(DescribeEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentAttributesResponse>(req, "DescribeEnvironmentAttributes");
        }

        /// <summary>
        /// This API is used to get the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public DescribeEnvironmentAttributesResponse DescribeEnvironmentAttributesSync(DescribeEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentAttributesResponse>(req, "DescribeEnvironmentAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of namespace roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentRolesResponse"/></returns>
        public Task<DescribeEnvironmentRolesResponse> DescribeEnvironmentRoles(DescribeEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentRolesResponse>(req, "DescribeEnvironmentRoles");
        }

        /// <summary>
        /// This API is used to get the list of namespace roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentRolesResponse"/></returns>
        public DescribeEnvironmentRolesResponse DescribeEnvironmentRolesSync(DescribeEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentRolesResponse>(req, "DescribeEnvironmentRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of namespaces under a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// This API is used to get the list of namespaces under a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain message production overview information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public Task<DescribePublisherSummaryResponse> DescribePublisherSummary(DescribePublisherSummaryRequest req)
        {
            return InternalRequestAsync<DescribePublisherSummaryResponse>(req, "DescribePublisherSummary");
        }

        /// <summary>
        /// This API is used to obtain message production overview information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public DescribePublisherSummaryResponse DescribePublisherSummarySync(DescribePublisherSummaryRequest req)
        {
            return InternalRequestAsync<DescribePublisherSummaryResponse>(req, "DescribePublisherSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of producer information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public Task<DescribePublishersResponse> DescribePublishers(DescribePublishersRequest req)
        {
            return InternalRequestAsync<DescribePublishersResponse>(req, "DescribePublishers");
        }

        /// <summary>
        /// This API is used to obtain the list of producer information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public DescribePublishersResponse DescribePublishersSync(DescribePublishersRequest req)
        {
            return InternalRequestAsync<DescribePublishersResponse>(req, "DescribePublishers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of a TDMQ for Pulsar pro cluster instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstanceDetailResponse"/></returns>
        public Task<DescribePulsarProInstanceDetailResponse> DescribePulsarProInstanceDetail(DescribePulsarProInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstanceDetailResponse>(req, "DescribePulsarProInstanceDetail");
        }

        /// <summary>
        /// This API is used to obtain the information of a TDMQ for Pulsar pro cluster instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstanceDetailResponse"/></returns>
        public DescribePulsarProInstanceDetailResponse DescribePulsarProInstanceDetailSync(DescribePulsarProInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstanceDetailResponse>(req, "DescribePulsarProInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of the purchased TDMQ for Pulsar pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstancesRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstancesResponse"/></returns>
        public Task<DescribePulsarProInstancesResponse> DescribePulsarProInstances(DescribePulsarProInstancesRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstancesResponse>(req, "DescribePulsarProInstances");
        }

        /// <summary>
        /// This API is used to query the list of the purchased TDMQ for Pulsar pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstancesRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstancesResponse"/></returns>
        public DescribePulsarProInstancesResponse DescribePulsarProInstancesSync(DescribePulsarProInstancesRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstancesResponse>(req, "DescribePulsarProInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ exclusive cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQNodeListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQNodeListResponse"/></returns>
        public Task<DescribeRabbitMQNodeListResponse> DescribeRabbitMQNodeList(DescribeRabbitMQNodeListRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQNodeListResponse>(req, "DescribeRabbitMQNodeList");
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ exclusive cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQNodeListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQNodeListResponse"/></returns>
        public DescribeRabbitMQNodeListResponse DescribeRabbitMQNodeListSync(DescribeRabbitMQNodeListRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQNodeListResponse>(req, "DescribeRabbitMQNodeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ users.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQUserResponse"/></returns>
        public Task<DescribeRabbitMQUserResponse> DescribeRabbitMQUser(DescribeRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQUserResponse>(req, "DescribeRabbitMQUser");
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ users.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQUserResponse"/></returns>
        public DescribeRabbitMQUserResponse DescribeRabbitMQUserSync(DescribeRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQUserResponse>(req, "DescribeRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of the purchased TDMQ for RabbitMQ exclusive instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstancesResponse"/></returns>
        public Task<DescribeRabbitMQVipInstancesResponse> DescribeRabbitMQVipInstances(DescribeRabbitMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVipInstancesResponse>(req, "DescribeRabbitMQVipInstances");
        }

        /// <summary>
        /// This API is used to query the list of the purchased TDMQ for RabbitMQ exclusive instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstancesResponse"/></returns>
        public DescribeRabbitMQVipInstancesResponse DescribeRabbitMQVipInstancesSync(DescribeRabbitMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVipInstancesResponse>(req, "DescribeRabbitMQVipInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ vhosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostResponse"/></returns>
        public Task<DescribeRabbitMQVirtualHostResponse> DescribeRabbitMQVirtualHost(DescribeRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVirtualHostResponse>(req, "DescribeRabbitMQVirtualHost");
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ vhosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostResponse"/></returns>
        public DescribeRabbitMQVirtualHostResponse DescribeRabbitMQVirtualHostSync(DescribeRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVirtualHostResponse>(req, "DescribeRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ exclusive vhosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostListResponse"/></returns>
        public Task<DescribeRabbitMQVirtualHostListResponse> DescribeRabbitMQVirtualHostList(DescribeRabbitMQVirtualHostListRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVirtualHostListResponse>(req, "DescribeRabbitMQVirtualHostList");
        }

        /// <summary>
        /// This API is used to query the list of TDMQ for RabbitMQ exclusive vhosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostListResponse"/></returns>
        public DescribeRabbitMQVirtualHostListResponse DescribeRabbitMQVirtualHostListSync(DescribeRabbitMQVirtualHostListRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVirtualHostListResponse>(req, "DescribeRabbitMQVirtualHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a specific RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public Task<DescribeRocketMQClusterResponse> DescribeRocketMQCluster(DescribeRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClusterResponse>(req, "DescribeRocketMQCluster");
        }

        /// <summary>
        /// This API is used to get the information of a specific RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public DescribeRocketMQClusterResponse DescribeRocketMQClusterSync(DescribeRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClusterResponse>(req, "DescribeRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClustersRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClustersResponse"/></returns>
        public Task<DescribeRocketMQClustersResponse> DescribeRocketMQClusters(DescribeRocketMQClustersRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClustersResponse>(req, "DescribeRocketMQClusters");
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClustersRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClustersResponse"/></returns>
        public DescribeRocketMQClustersResponse DescribeRocketMQClustersSync(DescribeRocketMQClustersRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClustersResponse>(req, "DescribeRocketMQClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ consumer groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQGroupsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQGroupsResponse"/></returns>
        public Task<DescribeRocketMQGroupsResponse> DescribeRocketMQGroups(DescribeRocketMQGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQGroupsResponse>(req, "DescribeRocketMQGroups");
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ consumer groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQGroupsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQGroupsResponse"/></returns>
        public DescribeRocketMQGroupsResponse DescribeRocketMQGroupsSync(DescribeRocketMQGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQGroupsResponse>(req, "DescribeRocketMQGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the TDMQ for RocketMQ message details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgResponse"/></returns>
        public Task<DescribeRocketMQMsgResponse> DescribeRocketMQMsg(DescribeRocketMQMsgRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMsgResponse>(req, "DescribeRocketMQMsg");
        }

        /// <summary>
        /// This API is used to query the TDMQ for RocketMQ message details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgResponse"/></returns>
        public DescribeRocketMQMsgResponse DescribeRocketMQMsgSync(DescribeRocketMQMsgRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMsgResponse>(req, "DescribeRocketMQMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQNamespacesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQNamespacesResponse"/></returns>
        public Task<DescribeRocketMQNamespacesResponse> DescribeRocketMQNamespaces(DescribeRocketMQNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQNamespacesResponse>(req, "DescribeRocketMQNamespaces");
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQNamespacesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQNamespacesResponse"/></returns>
        public DescribeRocketMQNamespacesResponse DescribeRocketMQNamespacesSync(DescribeRocketMQNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQNamespacesResponse>(req, "DescribeRocketMQNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ topics.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsResponse"/></returns>
        public Task<DescribeRocketMQTopicsResponse> DescribeRocketMQTopics(DescribeRocketMQTopicsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicsResponse>(req, "DescribeRocketMQTopics");
        }

        /// <summary>
        /// This API is used to get the list of RocketMQ topics.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsResponse"/></returns>
        public DescribeRocketMQTopicsResponse DescribeRocketMQTopicsSync(DescribeRocketMQTopicsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicsResponse>(req, "DescribeRocketMQTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a specific TDMQ for RocketMQ exclusive cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstanceDetailResponse"/></returns>
        public Task<DescribeRocketMQVipInstanceDetailResponse> DescribeRocketMQVipInstanceDetail(DescribeRocketMQVipInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstanceDetailResponse>(req, "DescribeRocketMQVipInstanceDetail");
        }

        /// <summary>
        /// This API is used to get the information of a specific TDMQ for RocketMQ exclusive cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstanceDetailResponse"/></returns>
        public DescribeRocketMQVipInstanceDetailResponse DescribeRocketMQVipInstanceDetailSync(DescribeRocketMQVipInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstanceDetailResponse>(req, "DescribeRocketMQVipInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of the purchased TDMQ for RocketMQ exclusive instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstancesResponse"/></returns>
        public Task<DescribeRocketMQVipInstancesResponse> DescribeRocketMQVipInstances(DescribeRocketMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstancesResponse>(req, "DescribeRocketMQVipInstances");
        }

        /// <summary>
        /// This API is used to query the list of the purchased TDMQ for RocketMQ exclusive instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstancesResponse"/></returns>
        public DescribeRocketMQVipInstancesResponse DescribeRocketMQVipInstancesSync(DescribeRocketMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstancesResponse>(req, "DescribeRocketMQVipInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public Task<DescribeRolesResponse> DescribeRoles(DescribeRolesRequest req)
        {
            return InternalRequestAsync<DescribeRolesResponse>(req, "DescribeRoles");
        }

        /// <summary>
        /// This API is used to get the list of roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public DescribeRolesResponse DescribeRolesSync(DescribeRolesRequest req)
        {
            return InternalRequestAsync<DescribeRolesResponse>(req, "DescribeRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of subscribers under the specified environment and topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionsResponse"/></returns>
        public Task<DescribeSubscriptionsResponse> DescribeSubscriptions(DescribeSubscriptionsRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionsResponse>(req, "DescribeSubscriptions");
        }

        /// <summary>
        /// This API is used to query the list of subscribers under the specified environment and topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionsResponse"/></returns>
        public DescribeSubscriptionsResponse DescribeSubscriptionsSync(DescribeSubscriptionsRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionsResponse>(req, "DescribeSubscriptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of topics under an environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics");
        }

        /// <summary>
        /// This API is used to get the list of topics under an environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public Task<ModifyClusterResponse> ModifyCluster(ModifyClusterRequest req)
        {
            return InternalRequestAsync<ModifyClusterResponse>(req, "ModifyCluster");
        }

        /// <summary>
        /// This API is used to update a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public ModifyClusterResponse ModifyClusterSync(ModifyClusterRequest req)
        {
            return InternalRequestAsync<ModifyClusterResponse>(req, "ModifyCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public Task<ModifyCmqQueueAttributeResponse> ModifyCmqQueueAttribute(ModifyCmqQueueAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqQueueAttributeResponse>(req, "ModifyCmqQueueAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public ModifyCmqQueueAttributeResponse ModifyCmqQueueAttributeSync(ModifyCmqQueueAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqQueueAttributeResponse>(req, "ModifyCmqQueueAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public Task<ModifyCmqSubscriptionAttributeResponse> ModifyCmqSubscriptionAttribute(ModifyCmqSubscriptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqSubscriptionAttributeResponse>(req, "ModifyCmqSubscriptionAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public ModifyCmqSubscriptionAttributeResponse ModifyCmqSubscriptionAttributeSync(ModifyCmqSubscriptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqSubscriptionAttributeResponse>(req, "ModifyCmqSubscriptionAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public Task<ModifyCmqTopicAttributeResponse> ModifyCmqTopicAttribute(ModifyCmqTopicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqTopicAttributeResponse>(req, "ModifyCmqTopicAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public ModifyCmqTopicAttributeResponse ModifyCmqTopicAttributeSync(ModifyCmqTopicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqTopicAttributeResponse>(req, "ModifyCmqTopicAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public Task<ModifyEnvironmentAttributesResponse> ModifyEnvironmentAttributes(ModifyEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentAttributesResponse>(req, "ModifyEnvironmentAttributes");
        }

        /// <summary>
        /// This API is used to modify the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public ModifyEnvironmentAttributesResponse ModifyEnvironmentAttributesSync(ModifyEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentAttributesResponse>(req, "ModifyEnvironmentAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an environment role.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public Task<ModifyEnvironmentRoleResponse> ModifyEnvironmentRole(ModifyEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentRoleResponse>(req, "ModifyEnvironmentRole");
        }

        /// <summary>
        /// This API is used to modify an environment role.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public ModifyEnvironmentRoleResponse ModifyEnvironmentRoleSync(ModifyEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentRoleResponse>(req, "ModifyEnvironmentRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a TDMQ for RabbitMQ user.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQUserResponse"/></returns>
        public Task<ModifyRabbitMQUserResponse> ModifyRabbitMQUser(ModifyRabbitMQUserRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQUserResponse>(req, "ModifyRabbitMQUser");
        }

        /// <summary>
        /// This API is used to modify a TDMQ for RabbitMQ user.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQUserResponse"/></returns>
        public ModifyRabbitMQUserResponse ModifyRabbitMQUserSync(ModifyRabbitMQUserRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQUserResponse>(req, "ModifyRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a TDMQ for RabbitMQ vhost.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVirtualHostResponse"/></returns>
        public Task<ModifyRabbitMQVirtualHostResponse> ModifyRabbitMQVirtualHost(ModifyRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQVirtualHostResponse>(req, "ModifyRabbitMQVirtualHost");
        }

        /// <summary>
        /// This API is used to modify a TDMQ for RabbitMQ vhost.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVirtualHostResponse"/></returns>
        public ModifyRabbitMQVirtualHostResponse ModifyRabbitMQVirtualHostSync(ModifyRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQVirtualHostResponse>(req, "ModifyRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public Task<ModifyRocketMQClusterResponse> ModifyRocketMQCluster(ModifyRocketMQClusterRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQClusterResponse>(req, "ModifyRocketMQCluster");
        }

        /// <summary>
        /// This API is used to update a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public ModifyRocketMQClusterResponse ModifyRocketMQClusterSync(ModifyRocketMQClusterRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQClusterResponse>(req, "ModifyRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public Task<ModifyRocketMQGroupResponse> ModifyRocketMQGroup(ModifyRocketMQGroupRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQGroupResponse>(req, "ModifyRocketMQGroup");
        }

        /// <summary>
        /// This API is used to update a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public ModifyRocketMQGroupResponse ModifyRocketMQGroupSync(ModifyRocketMQGroupRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQGroupResponse>(req, "ModifyRocketMQGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configurations of a TDMQ for RocketMQ exclusive instance, including the upgrade of the instance specification, node count, and storage, and the downgrade of the instance specification. After you call this API to place the order and make payments, the configuration modification will be in progress. You can query whether the modification has been completed through the `DescribeRocketMQVipInstances` API`.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceSpecResponse"/></returns>
        public Task<ModifyRocketMQInstanceSpecResponse> ModifyRocketMQInstanceSpec(ModifyRocketMQInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQInstanceSpecResponse>(req, "ModifyRocketMQInstanceSpec");
        }

        /// <summary>
        /// This API is used to modify the configurations of a TDMQ for RocketMQ exclusive instance, including the upgrade of the instance specification, node count, and storage, and the downgrade of the instance specification. After you call this API to place the order and make payments, the configuration modification will be in progress. You can query whether the modification has been completed through the `DescribeRocketMQVipInstances` API`.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceSpecResponse"/></returns>
        public ModifyRocketMQInstanceSpecResponse ModifyRocketMQInstanceSpecSync(ModifyRocketMQInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQInstanceSpecResponse>(req, "ModifyRocketMQInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public Task<ModifyRocketMQNamespaceResponse> ModifyRocketMQNamespace(ModifyRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQNamespaceResponse>(req, "ModifyRocketMQNamespace");
        }

        /// <summary>
        /// This API is used to update a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public ModifyRocketMQNamespaceResponse ModifyRocketMQNamespaceSync(ModifyRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQNamespaceResponse>(req, "ModifyRocketMQNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public Task<ModifyRocketMQTopicResponse> ModifyRocketMQTopic(ModifyRocketMQTopicRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQTopicResponse>(req, "ModifyRocketMQTopic");
        }

        /// <summary>
        /// This API is used to update a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public ModifyRocketMQTopicResponse ModifyRocketMQTopicSync(ModifyRocketMQTopicRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQTopicResponse>(req, "ModifyRocketMQTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a role.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public Task<ModifyRoleResponse> ModifyRole(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole");
        }

        /// <summary>
        /// This API is used to modify a role.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public ModifyRoleResponse ModifyRoleSync(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the topic remarks and number of partitions.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// This API is used to modify the topic remarks and number of partitions.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send a CMQ topic message.
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public Task<PublishCmqMsgResponse> PublishCmqMsg(PublishCmqMsgRequest req)
        {
            return InternalRequestAsync<PublishCmqMsgResponse>(req, "PublishCmqMsg");
        }

        /// <summary>
        /// This API is used to send a CMQ topic message.
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public PublishCmqMsgResponse PublishCmqMsgSync(PublishCmqMsgRequest req)
        {
            return InternalRequestAsync<PublishCmqMsgResponse>(req, "PublishCmqMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Currently, the `ReceiveMessage` API only supports partitioned topics. It is used to receive messages sent to a specified partitioned topic. If it is called when there are no messages in the partitioned topic, the `ReceiveTimeout` exception will be reported.
        /// 
        /// Instructions on how to use `BatchReceivePolicy`:
        /// 
        /// `BatchReceive` has three parameters:
        /// 
        /// ● `MaxNumMessages`: The maximum number of messages returned by `Receive` when `BatchReceive` is used.
        /// ● `MaxNumBytes`: The maximum size (in bytes) of the message returned by `Receive` when `BatchReceive` is used.
        /// ● `Timeout`: The maximum timeout period (in milliseconds) of calling `Receive` when `BatchReceive` is used.
        /// 
        /// By default, if you don’t specify any of the three parameters, the `BatchReceive` feature is disabled; if one of the three parameter values is above zero, `BatchReceive` is enabled. `BatchReceive` will be disabled when any of the three parameter values reaches the threshold you specify.
        /// 
        /// Note: The values of both `MaxNumMessages` and `MaxNumBytes` are subject to the value of `ReceiveQueueSize`. If the values of `ReceiveQueueSize` and `MaxNumMessages` are 5 and 10, respectively, you can receive up to five rather than 10 messages when `BatchReceive` is used.
        /// 
        /// 
        /// 
        /// The API configured with `BatchReceivePolicy` returns multiple messages at a time.
        /// 
        /// 1. These messages are separated by “###”. After receiving them, you can separate them with split tools in different languages.
        /// 2. MessageIDs are separated by “###”. After receiving the messages, you can separate the MessageIDs with split tools in different languages, so that you can obtain the `MessageID` field information required for calling the `AcknowledgeMessage` API.
        /// </summary>
        /// <param name="req"><see cref="ReceiveMessageRequest"/></param>
        /// <returns><see cref="ReceiveMessageResponse"/></returns>
        public Task<ReceiveMessageResponse> ReceiveMessage(ReceiveMessageRequest req)
        {
            return InternalRequestAsync<ReceiveMessageResponse>(req, "ReceiveMessage");
        }

        /// <summary>
        /// Currently, the `ReceiveMessage` API only supports partitioned topics. It is used to receive messages sent to a specified partitioned topic. If it is called when there are no messages in the partitioned topic, the `ReceiveTimeout` exception will be reported.
        /// 
        /// Instructions on how to use `BatchReceivePolicy`:
        /// 
        /// `BatchReceive` has three parameters:
        /// 
        /// ● `MaxNumMessages`: The maximum number of messages returned by `Receive` when `BatchReceive` is used.
        /// ● `MaxNumBytes`: The maximum size (in bytes) of the message returned by `Receive` when `BatchReceive` is used.
        /// ● `Timeout`: The maximum timeout period (in milliseconds) of calling `Receive` when `BatchReceive` is used.
        /// 
        /// By default, if you don’t specify any of the three parameters, the `BatchReceive` feature is disabled; if one of the three parameter values is above zero, `BatchReceive` is enabled. `BatchReceive` will be disabled when any of the three parameter values reaches the threshold you specify.
        /// 
        /// Note: The values of both `MaxNumMessages` and `MaxNumBytes` are subject to the value of `ReceiveQueueSize`. If the values of `ReceiveQueueSize` and `MaxNumMessages` are 5 and 10, respectively, you can receive up to five rather than 10 messages when `BatchReceive` is used.
        /// 
        /// 
        /// 
        /// The API configured with `BatchReceivePolicy` returns multiple messages at a time.
        /// 
        /// 1. These messages are separated by “###”. After receiving them, you can separate them with split tools in different languages.
        /// 2. MessageIDs are separated by “###”. After receiving the messages, you can separate the MessageIDs with split tools in different languages, so that you can obtain the `MessageID` field information required for calling the `AcknowledgeMessage` API.
        /// </summary>
        /// <param name="req"><see cref="ReceiveMessageRequest"/></param>
        /// <returns><see cref="ReceiveMessageResponse"/></returns>
        public ReceiveMessageResponse ReceiveMessageSync(ReceiveMessageRequest req)
        {
            return InternalRequestAsync<ReceiveMessageResponse>(req, "ReceiveMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rewind a message by timestamp, accurate down to the millisecond.
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public Task<ResetMsgSubOffsetByTimestampResponse> ResetMsgSubOffsetByTimestamp(ResetMsgSubOffsetByTimestampRequest req)
        {
            return InternalRequestAsync<ResetMsgSubOffsetByTimestampResponse>(req, "ResetMsgSubOffsetByTimestamp");
        }

        /// <summary>
        /// This API is used to rewind a message by timestamp, accurate down to the millisecond.
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public ResetMsgSubOffsetByTimestampResponse ResetMsgSubOffsetByTimestampSync(ResetMsgSubOffsetByTimestampRequest req)
        {
            return InternalRequestAsync<ResetMsgSubOffsetByTimestampResponse>(req, "ResetMsgSubOffsetByTimestamp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the consumption offset of a specified consumer group to a specified timestamp.
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public Task<ResetRocketMQConsumerOffSetResponse> ResetRocketMQConsumerOffSet(ResetRocketMQConsumerOffSetRequest req)
        {
            return InternalRequestAsync<ResetRocketMQConsumerOffSetResponse>(req, "ResetRocketMQConsumerOffSet");
        }

        /// <summary>
        /// This API is used to reset the consumption offset of a specified consumer group to a specified timestamp.
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public ResetRocketMQConsumerOffSetResponse ResetRocketMQConsumerOffSetSync(ResetRocketMQConsumerOffSetRequest req)
        {
            return InternalRequestAsync<ResetRocketMQConsumerOffSetResponse>(req, "ResetRocketMQConsumerOffSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rewind a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public Task<RewindCmqQueueResponse> RewindCmqQueue(RewindCmqQueueRequest req)
        {
            return InternalRequestAsync<RewindCmqQueueResponse>(req, "RewindCmqQueue");
        }

        /// <summary>
        /// This API is used to rewind a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public RewindCmqQueueResponse RewindCmqQueueSync(RewindCmqQueueRequest req)
        {
            return InternalRequestAsync<RewindCmqQueueResponse>(req, "RewindCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch send messages.
        /// 
        /// Note: the batch message sending API in TDMQ is to package messages into a batch on the service side of TDMQ-HTTP and then send the batch as a TCP request inside the service. Therefore, when using this API, you should still follow the logic of sending a single message: each message is an independent HTTP request, and multiple HTTP requests are aggregated into one batch inside the TDMQ-HTTP service and then sent to the server; that is, batch sending messages is the same as sending a single message in terms of usage, and batch aggregation is completed inside the TDMQ-HTTP service.
        /// </summary>
        /// <param name="req"><see cref="SendBatchMessagesRequest"/></param>
        /// <returns><see cref="SendBatchMessagesResponse"/></returns>
        public Task<SendBatchMessagesResponse> SendBatchMessages(SendBatchMessagesRequest req)
        {
            return InternalRequestAsync<SendBatchMessagesResponse>(req, "SendBatchMessages");
        }

        /// <summary>
        /// This API is used to batch send messages.
        /// 
        /// Note: the batch message sending API in TDMQ is to package messages into a batch on the service side of TDMQ-HTTP and then send the batch as a TCP request inside the service. Therefore, when using this API, you should still follow the logic of sending a single message: each message is an independent HTTP request, and multiple HTTP requests are aggregated into one batch inside the TDMQ-HTTP service and then sent to the server; that is, batch sending messages is the same as sending a single message in terms of usage, and batch aggregation is completed inside the TDMQ-HTTP service.
        /// </summary>
        /// <param name="req"><see cref="SendBatchMessagesRequest"/></param>
        /// <returns><see cref="SendBatchMessagesResponse"/></returns>
        public SendBatchMessagesResponse SendBatchMessagesSync(SendBatchMessagesRequest req)
        {
            return InternalRequestAsync<SendBatchMessagesResponse>(req, "SendBatchMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send a CMQ message.
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public Task<SendCmqMsgResponse> SendCmqMsg(SendCmqMsgRequest req)
        {
            return InternalRequestAsync<SendCmqMsgResponse>(req, "SendCmqMsg");
        }

        /// <summary>
        /// This API is used to send a CMQ message.
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public SendCmqMsgResponse SendCmqMsgSync(SendCmqMsgRequest req)
        {
            return InternalRequestAsync<SendCmqMsgResponse>(req, "SendCmqMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send a single message.
        /// The message cannot be sent to a persistent topic.
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public Task<SendMessagesResponse> SendMessages(SendMessagesRequest req)
        {
            return InternalRequestAsync<SendMessagesResponse>(req, "SendMessages");
        }

        /// <summary>
        /// This API is used to send a single message.
        /// The message cannot be sent to a persistent topic.
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public SendMessagesResponse SendMessagesSync(SendMessagesRequest req)
        {
            return InternalRequestAsync<SendMessagesResponse>(req, "SendMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to test message sending. It cannot be used in the production environment.
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public Task<SendMsgResponse> SendMsg(SendMsgRequest req)
        {
            return InternalRequestAsync<SendMsgResponse>(req, "SendMsg");
        }

        /// <summary>
        /// This API is used to test message sending. It cannot be used in the production environment.
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public SendMsgResponse SendMsgSync(SendMsgRequest req)
        {
            return InternalRequestAsync<SendMsgResponse>(req, "SendMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This document is used to send a TDMQ for RocketMQ message.
        /// </summary>
        /// <param name="req"><see cref="SendRocketMQMessageRequest"/></param>
        /// <returns><see cref="SendRocketMQMessageResponse"/></returns>
        public Task<SendRocketMQMessageResponse> SendRocketMQMessage(SendRocketMQMessageRequest req)
        {
            return InternalRequestAsync<SendRocketMQMessageResponse>(req, "SendRocketMQMessage");
        }

        /// <summary>
        /// This document is used to send a TDMQ for RocketMQ message.
        /// </summary>
        /// <param name="req"><see cref="SendRocketMQMessageRequest"/></param>
        /// <returns><see cref="SendRocketMQMessageResponse"/></returns>
        public SendRocketMQMessageResponse SendRocketMQMessageSync(SendRocketMQMessageRequest req)
        {
            return InternalRequestAsync<SendRocketMQMessageResponse>(req, "SendRocketMQMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public Task<UnbindCmqDeadLetterResponse> UnbindCmqDeadLetter(UnbindCmqDeadLetterRequest req)
        {
            return InternalRequestAsync<UnbindCmqDeadLetterResponse>(req, "UnbindCmqDeadLetter");
        }

        /// <summary>
        /// This API is used to unbind a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public UnbindCmqDeadLetterResponse UnbindCmqDeadLetterSync(UnbindCmqDeadLetterRequest req)
        {
            return InternalRequestAsync<UnbindCmqDeadLetterResponse>(req, "UnbindCmqDeadLetter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
