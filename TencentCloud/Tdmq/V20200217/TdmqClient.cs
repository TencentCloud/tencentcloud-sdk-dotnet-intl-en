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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdmqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to acknowledge the message in the specified topic by the provided `MessageID`.
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public async Task<AcknowledgeMessageResponse> AcknowledgeMessage(AcknowledgeMessageRequest req)
        {
             JsonResponseModel<AcknowledgeMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcknowledgeMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcknowledgeMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to acknowledge the message in the specified topic by the provided `MessageID`.
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public AcknowledgeMessageResponse AcknowledgeMessageSync(AcknowledgeMessageRequest req)
        {
             JsonResponseModel<AcknowledgeMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcknowledgeMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcknowledgeMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the messages in the CMQ message queue.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public async Task<ClearCmqQueueResponse> ClearCmqQueue(ClearCmqQueueRequest req)
        {
             JsonResponseModel<ClearCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the messages in the CMQ message queue.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public ClearCmqQueueResponse ClearCmqQueueSync(ClearCmqQueueRequest req)
        {
             JsonResponseModel<ClearCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the message tags of a subscriber.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public async Task<ClearCmqSubscriptionFilterTagsResponse> ClearCmqSubscriptionFilterTags(ClearCmqSubscriptionFilterTagsRequest req)
        {
             JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearCmqSubscriptionFilterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the message tags of a subscriber.
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public ClearCmqSubscriptionFilterTagsResponse ClearCmqSubscriptionFilterTagsSync(ClearCmqSubscriptionFilterTagsRequest req)
        {
             JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearCmqSubscriptionFilterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public async Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public async Task<CreateCmqQueueResponse> CreateCmqQueue(CreateCmqQueueRequest req)
        {
             JsonResponseModel<CreateCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public CreateCmqQueueResponse CreateCmqQueueSync(CreateCmqQueueRequest req)
        {
             JsonResponseModel<CreateCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public async Task<CreateCmqSubscribeResponse> CreateCmqSubscribe(CreateCmqSubscribeRequest req)
        {
             JsonResponseModel<CreateCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public CreateCmqSubscribeResponse CreateCmqSubscribeSync(CreateCmqSubscribeRequest req)
        {
             JsonResponseModel<CreateCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public async Task<CreateCmqTopicResponse> CreateCmqTopic(CreateCmqTopicRequest req)
        {
             JsonResponseModel<CreateCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public CreateCmqTopicResponse CreateCmqTopicSync(CreateCmqTopicRequest req)
        {
             JsonResponseModel<CreateCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TDMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public async Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
             JsonResponseModel<CreateEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TDMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
             JsonResponseModel<CreateEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an environment role.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public async Task<CreateEnvironmentRoleResponse> CreateEnvironmentRole(CreateEnvironmentRoleRequest req)
        {
             JsonResponseModel<CreateEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an environment role.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public CreateEnvironmentRoleResponse CreateEnvironmentRoleSync(CreateEnvironmentRoleRequest req)
        {
             JsonResponseModel<CreateEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public async Task<CreateRocketMQClusterResponse> CreateRocketMQCluster(CreateRocketMQClusterRequest req)
        {
             JsonResponseModel<CreateRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public CreateRocketMQClusterResponse CreateRocketMQClusterSync(CreateRocketMQClusterRequest req)
        {
             JsonResponseModel<CreateRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public async Task<CreateRocketMQGroupResponse> CreateRocketMQGroup(CreateRocketMQGroupRequest req)
        {
             JsonResponseModel<CreateRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public CreateRocketMQGroupResponse CreateRocketMQGroupSync(CreateRocketMQGroupRequest req)
        {
             JsonResponseModel<CreateRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public async Task<CreateRocketMQNamespaceResponse> CreateRocketMQNamespace(CreateRocketMQNamespaceRequest req)
        {
             JsonResponseModel<CreateRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public CreateRocketMQNamespaceResponse CreateRocketMQNamespaceSync(CreateRocketMQNamespaceRequest req)
        {
             JsonResponseModel<CreateRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public async Task<CreateRocketMQTopicResponse> CreateRocketMQTopic(CreateRocketMQTopicRequest req)
        {
             JsonResponseModel<CreateRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public CreateRocketMQTopicResponse CreateRocketMQTopicSync(CreateRocketMQTopicRequest req)
        {
             JsonResponseModel<CreateRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public async Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a subscription to a topic.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public async Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest req)
        {
             JsonResponseModel<CreateSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a subscription to a topic.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public CreateSubscriptionResponse CreateSubscriptionSync(CreateSubscriptionRequest req)
        {
             JsonResponseModel<CreateSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a message topic in the specified partition and type.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a message topic in the specified partition and type.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public async Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public async Task<DeleteCmqQueueResponse> DeleteCmqQueue(DeleteCmqQueueRequest req)
        {
             JsonResponseModel<DeleteCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public DeleteCmqQueueResponse DeleteCmqQueueSync(DeleteCmqQueueRequest req)
        {
             JsonResponseModel<DeleteCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public async Task<DeleteCmqSubscribeResponse> DeleteCmqSubscribe(DeleteCmqSubscribeRequest req)
        {
             JsonResponseModel<DeleteCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public DeleteCmqSubscribeResponse DeleteCmqSubscribeSync(DeleteCmqSubscribeRequest req)
        {
             JsonResponseModel<DeleteCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public async Task<DeleteCmqTopicResponse> DeleteCmqTopic(DeleteCmqTopicRequest req)
        {
             JsonResponseModel<DeleteCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public DeleteCmqTopicResponse DeleteCmqTopicSync(DeleteCmqTopicRequest req)
        {
             JsonResponseModel<DeleteCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an environment role.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public async Task<DeleteEnvironmentRolesResponse> DeleteEnvironmentRoles(DeleteEnvironmentRolesRequest req)
        {
             JsonResponseModel<DeleteEnvironmentRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEnvironmentRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an environment role.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public DeleteEnvironmentRolesResponse DeleteEnvironmentRolesSync(DeleteEnvironmentRolesRequest req)
        {
             JsonResponseModel<DeleteEnvironmentRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEnvironmentRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete namespaces under a tenant.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public async Task<DeleteEnvironmentsResponse> DeleteEnvironments(DeleteEnvironmentsRequest req)
        {
             JsonResponseModel<DeleteEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete namespaces under a tenant.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public DeleteEnvironmentsResponse DeleteEnvironmentsSync(DeleteEnvironmentsRequest req)
        {
             JsonResponseModel<DeleteEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public async Task<DeleteRocketMQClusterResponse> DeleteRocketMQCluster(DeleteRocketMQClusterRequest req)
        {
             JsonResponseModel<DeleteRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public DeleteRocketMQClusterResponse DeleteRocketMQClusterSync(DeleteRocketMQClusterRequest req)
        {
             JsonResponseModel<DeleteRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public async Task<DeleteRocketMQGroupResponse> DeleteRocketMQGroup(DeleteRocketMQGroupRequest req)
        {
             JsonResponseModel<DeleteRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public DeleteRocketMQGroupResponse DeleteRocketMQGroupSync(DeleteRocketMQGroupRequest req)
        {
             JsonResponseModel<DeleteRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public async Task<DeleteRocketMQNamespaceResponse> DeleteRocketMQNamespace(DeleteRocketMQNamespaceRequest req)
        {
             JsonResponseModel<DeleteRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public DeleteRocketMQNamespaceResponse DeleteRocketMQNamespaceSync(DeleteRocketMQNamespaceRequest req)
        {
             JsonResponseModel<DeleteRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public async Task<DeleteRocketMQTopicResponse> DeleteRocketMQTopic(DeleteRocketMQTopicRequest req)
        {
             JsonResponseModel<DeleteRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public DeleteRocketMQTopicResponse DeleteRocketMQTopicSync(DeleteRocketMQTopicRequest req)
        {
             JsonResponseModel<DeleteRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or multiple roles.
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public async Task<DeleteRolesResponse> DeleteRoles(DeleteRolesRequest req)
        {
             JsonResponseModel<DeleteRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or multiple roles.
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public DeleteRolesResponse DeleteRolesSync(DeleteRolesRequest req)
        {
             JsonResponseModel<DeleteRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the tenant-VPC binding relationship.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public async Task<DescribeBindVpcsResponse> DescribeBindVpcs(DescribeBindVpcsRequest req)
        {
             JsonResponseModel<DescribeBindVpcsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the tenant-VPC binding relationship.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public DescribeBindVpcsResponse DescribeBindVpcsSync(DescribeBindVpcsRequest req)
        {
             JsonResponseModel<DescribeBindVpcsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public async Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate the source queues of a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqDeadLetterSourceQueuesResponse"/></returns>
        public async Task<DescribeCmqDeadLetterSourceQueuesResponse> DescribeCmqDeadLetterSourceQueues(DescribeCmqDeadLetterSourceQueuesRequest req)
        {
             JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqDeadLetterSourceQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate the source queues of a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqDeadLetterSourceQueuesResponse"/></returns>
        public DescribeCmqDeadLetterSourceQueuesResponse DescribeCmqDeadLetterSourceQueuesSync(DescribeCmqDeadLetterSourceQueuesRequest req)
        {
             JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqDeadLetterSourceQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public async Task<DescribeCmqQueueDetailResponse> DescribeCmqQueueDetail(DescribeCmqQueueDetailRequest req)
        {
             JsonResponseModel<DescribeCmqQueueDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqQueueDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqQueueDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public DescribeCmqQueueDetailResponse DescribeCmqQueueDetailSync(DescribeCmqQueueDetailRequest req)
        {
             JsonResponseModel<DescribeCmqQueueDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqQueueDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqQueueDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CMQ subscription details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public async Task<DescribeCmqSubscriptionDetailResponse> DescribeCmqSubscriptionDetail(DescribeCmqSubscriptionDetailRequest req)
        {
             JsonResponseModel<DescribeCmqSubscriptionDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqSubscriptionDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqSubscriptionDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CMQ subscription details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public DescribeCmqSubscriptionDetailResponse DescribeCmqSubscriptionDetailSync(DescribeCmqSubscriptionDetailRequest req)
        {
             JsonResponseModel<DescribeCmqSubscriptionDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqSubscriptionDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqSubscriptionDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public async Task<DescribeCmqTopicDetailResponse> DescribeCmqTopicDetail(DescribeCmqTopicDetailRequest req)
        {
             JsonResponseModel<DescribeCmqTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public DescribeCmqTopicDetailResponse DescribeCmqTopicDetailSync(DescribeCmqTopicDetailRequest req)
        {
             JsonResponseModel<DescribeCmqTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public async Task<DescribeEnvironmentAttributesResponse> DescribeEnvironmentAttributes(DescribeEnvironmentAttributesRequest req)
        {
             JsonResponseModel<DescribeEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public DescribeEnvironmentAttributesResponse DescribeEnvironmentAttributesSync(DescribeEnvironmentAttributesRequest req)
        {
             JsonResponseModel<DescribeEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain message production overview information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public async Task<DescribePublisherSummaryResponse> DescribePublisherSummary(DescribePublisherSummaryRequest req)
        {
             JsonResponseModel<DescribePublisherSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublisherSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublisherSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain message production overview information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public DescribePublisherSummaryResponse DescribePublisherSummarySync(DescribePublisherSummaryRequest req)
        {
             JsonResponseModel<DescribePublisherSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublisherSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublisherSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of producer information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public async Task<DescribePublishersResponse> DescribePublishers(DescribePublishersRequest req)
        {
             JsonResponseModel<DescribePublishersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublishers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublishersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of producer information.
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public DescribePublishersResponse DescribePublishersSync(DescribePublishersRequest req)
        {
             JsonResponseModel<DescribePublishersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublishers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublishersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specific RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public async Task<DescribeRocketMQClusterResponse> DescribeRocketMQCluster(DescribeRocketMQClusterRequest req)
        {
             JsonResponseModel<DescribeRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specific RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public DescribeRocketMQClusterResponse DescribeRocketMQClusterSync(DescribeRocketMQClusterRequest req)
        {
             JsonResponseModel<DescribeRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public async Task<DescribeRolesResponse> DescribeRoles(DescribeRolesRequest req)
        {
             JsonResponseModel<DescribeRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public DescribeRolesResponse DescribeRolesSync(DescribeRolesRequest req)
        {
             JsonResponseModel<DescribeRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public async Task<ModifyClusterResponse> ModifyCluster(ModifyClusterRequest req)
        {
             JsonResponseModel<ModifyClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public ModifyClusterResponse ModifyClusterSync(ModifyClusterRequest req)
        {
             JsonResponseModel<ModifyClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public async Task<ModifyCmqQueueAttributeResponse> ModifyCmqQueueAttribute(ModifyCmqQueueAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqQueueAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCmqQueueAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqQueueAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public ModifyCmqQueueAttributeResponse ModifyCmqQueueAttributeSync(ModifyCmqQueueAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqQueueAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCmqQueueAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqQueueAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public async Task<ModifyCmqSubscriptionAttributeResponse> ModifyCmqSubscriptionAttribute(ModifyCmqSubscriptionAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqSubscriptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCmqSubscriptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqSubscriptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public ModifyCmqSubscriptionAttributeResponse ModifyCmqSubscriptionAttributeSync(ModifyCmqSubscriptionAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqSubscriptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCmqSubscriptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqSubscriptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public async Task<ModifyCmqTopicAttributeResponse> ModifyCmqTopicAttribute(ModifyCmqTopicAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqTopicAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCmqTopicAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqTopicAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public ModifyCmqTopicAttributeResponse ModifyCmqTopicAttributeSync(ModifyCmqTopicAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqTopicAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCmqTopicAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqTopicAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public async Task<ModifyEnvironmentAttributesResponse> ModifyEnvironmentAttributes(ModifyEnvironmentAttributesRequest req)
        {
             JsonResponseModel<ModifyEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public ModifyEnvironmentAttributesResponse ModifyEnvironmentAttributesSync(ModifyEnvironmentAttributesRequest req)
        {
             JsonResponseModel<ModifyEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an environment role.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public async Task<ModifyEnvironmentRoleResponse> ModifyEnvironmentRole(ModifyEnvironmentRoleRequest req)
        {
             JsonResponseModel<ModifyEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an environment role.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public ModifyEnvironmentRoleResponse ModifyEnvironmentRoleSync(ModifyEnvironmentRoleRequest req)
        {
             JsonResponseModel<ModifyEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public async Task<ModifyRocketMQClusterResponse> ModifyRocketMQCluster(ModifyRocketMQClusterRequest req)
        {
             JsonResponseModel<ModifyRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public ModifyRocketMQClusterResponse ModifyRocketMQClusterSync(ModifyRocketMQClusterRequest req)
        {
             JsonResponseModel<ModifyRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public async Task<ModifyRocketMQGroupResponse> ModifyRocketMQGroup(ModifyRocketMQGroupRequest req)
        {
             JsonResponseModel<ModifyRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ consumer group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public ModifyRocketMQGroupResponse ModifyRocketMQGroupSync(ModifyRocketMQGroupRequest req)
        {
             JsonResponseModel<ModifyRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public async Task<ModifyRocketMQNamespaceResponse> ModifyRocketMQNamespace(ModifyRocketMQNamespaceRequest req)
        {
             JsonResponseModel<ModifyRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ namespace.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public ModifyRocketMQNamespaceResponse ModifyRocketMQNamespaceSync(ModifyRocketMQNamespaceRequest req)
        {
             JsonResponseModel<ModifyRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public async Task<ModifyRocketMQTopicResponse> ModifyRocketMQTopic(ModifyRocketMQTopicRequest req)
        {
             JsonResponseModel<ModifyRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a RocketMQ topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public ModifyRocketMQTopicResponse ModifyRocketMQTopicSync(ModifyRocketMQTopicRequest req)
        {
             JsonResponseModel<ModifyRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a role.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public async Task<ModifyRoleResponse> ModifyRole(ModifyRoleRequest req)
        {
             JsonResponseModel<ModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a role.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public ModifyRoleResponse ModifyRoleSync(ModifyRoleRequest req)
        {
             JsonResponseModel<ModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the topic remarks and number of partitions.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public async Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the topic remarks and number of partitions.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a CMQ topic message.
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public async Task<PublishCmqMsgResponse> PublishCmqMsg(PublishCmqMsgRequest req)
        {
             JsonResponseModel<PublishCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a CMQ topic message.
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public PublishCmqMsgResponse PublishCmqMsgSync(PublishCmqMsgRequest req)
        {
             JsonResponseModel<PublishCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to receive messages sent to the specified topic.
        /// </summary>
        /// <param name="req"><see cref="ReceiveMessageRequest"/></param>
        /// <returns><see cref="ReceiveMessageResponse"/></returns>
        public async Task<ReceiveMessageResponse> ReceiveMessage(ReceiveMessageRequest req)
        {
             JsonResponseModel<ReceiveMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReceiveMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReceiveMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to receive messages sent to the specified topic.
        /// </summary>
        /// <param name="req"><see cref="ReceiveMessageRequest"/></param>
        /// <returns><see cref="ReceiveMessageResponse"/></returns>
        public ReceiveMessageResponse ReceiveMessageSync(ReceiveMessageRequest req)
        {
             JsonResponseModel<ReceiveMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReceiveMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReceiveMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rewind a message by timestamp, accurate down to the millisecond.
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public async Task<ResetMsgSubOffsetByTimestampResponse> ResetMsgSubOffsetByTimestamp(ResetMsgSubOffsetByTimestampRequest req)
        {
             JsonResponseModel<ResetMsgSubOffsetByTimestampResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetMsgSubOffsetByTimestamp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetMsgSubOffsetByTimestampResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rewind a message by timestamp, accurate down to the millisecond.
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public ResetMsgSubOffsetByTimestampResponse ResetMsgSubOffsetByTimestampSync(ResetMsgSubOffsetByTimestampRequest req)
        {
             JsonResponseModel<ResetMsgSubOffsetByTimestampResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetMsgSubOffsetByTimestamp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetMsgSubOffsetByTimestampResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the consumption offset of a specified consumer group to a specified timestamp.
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public async Task<ResetRocketMQConsumerOffSetResponse> ResetRocketMQConsumerOffSet(ResetRocketMQConsumerOffSetRequest req)
        {
             JsonResponseModel<ResetRocketMQConsumerOffSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetRocketMQConsumerOffSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRocketMQConsumerOffSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the consumption offset of a specified consumer group to a specified timestamp.
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public ResetRocketMQConsumerOffSetResponse ResetRocketMQConsumerOffSetSync(ResetRocketMQConsumerOffSetRequest req)
        {
             JsonResponseModel<ResetRocketMQConsumerOffSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetRocketMQConsumerOffSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRocketMQConsumerOffSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rewind a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public async Task<RewindCmqQueueResponse> RewindCmqQueue(RewindCmqQueueRequest req)
        {
             JsonResponseModel<RewindCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RewindCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RewindCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rewind a CMQ queue.
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public RewindCmqQueueResponse RewindCmqQueueSync(RewindCmqQueueRequest req)
        {
             JsonResponseModel<RewindCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RewindCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RewindCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch send messages.
        /// 
        /// Note: the batch message sending API in TDMQ is to package messages into a batch on the service side of TDMQ-HTTP and then send the batch as a TCP request inside the service. Therefore, when using this API, you should still follow the logic of sending a single message: each message is an independent HTTP request, and multiple HTTP requests are aggregated into one batch inside the TDMQ-HTTP service and then sent to the server; that is, batch sending messages is the same as sending a single message in terms of usage, and batch aggregation is completed inside the TDMQ-HTTP service.
        /// </summary>
        /// <param name="req"><see cref="SendBatchMessagesRequest"/></param>
        /// <returns><see cref="SendBatchMessagesResponse"/></returns>
        public async Task<SendBatchMessagesResponse> SendBatchMessages(SendBatchMessagesRequest req)
        {
             JsonResponseModel<SendBatchMessagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendBatchMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendBatchMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<SendBatchMessagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendBatchMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendBatchMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a CMQ message.
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public async Task<SendCmqMsgResponse> SendCmqMsg(SendCmqMsgRequest req)
        {
             JsonResponseModel<SendCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a CMQ message.
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public SendCmqMsgResponse SendCmqMsgSync(SendCmqMsgRequest req)
        {
             JsonResponseModel<SendCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send one message.
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public async Task<SendMessagesResponse> SendMessages(SendMessagesRequest req)
        {
             JsonResponseModel<SendMessagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send one message.
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public SendMessagesResponse SendMessagesSync(SendMessagesRequest req)
        {
             JsonResponseModel<SendMessagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to test message sending. It cannot be used in the production environment.
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public async Task<SendMsgResponse> SendMsg(SendMsgRequest req)
        {
             JsonResponseModel<SendMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to test message sending. It cannot be used in the production environment.
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public SendMsgResponse SendMsgSync(SendMsgRequest req)
        {
             JsonResponseModel<SendMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public async Task<UnbindCmqDeadLetterResponse> UnbindCmqDeadLetter(UnbindCmqDeadLetterRequest req)
        {
             JsonResponseModel<UnbindCmqDeadLetterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindCmqDeadLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCmqDeadLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a CMQ dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public UnbindCmqDeadLetterResponse UnbindCmqDeadLetterSync(UnbindCmqDeadLetterRequest req)
        {
             JsonResponseModel<UnbindCmqDeadLetterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindCmqDeadLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCmqDeadLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
