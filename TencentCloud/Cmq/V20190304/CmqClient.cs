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

namespace TencentCloud.Cmq.V20190304
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cmq.V20190304.Models;

   public class CmqClient : AbstractClient{

       private const string endpoint = "cmq.intl.tencentcloudapi.com";
       private const string version = "2019-03-04";
       private const string sdkVersion = "SDK_NET_3.0.1132";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CmqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CmqClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to clear all messages in a queue.
        /// </summary>
        /// <param name="req"><see cref="ClearQueueRequest"/></param>
        /// <returns><see cref="ClearQueueResponse"/></returns>
        public Task<ClearQueueResponse> ClearQueue(ClearQueueRequest req)
        {
            return InternalRequestAsync<ClearQueueResponse>(req, "ClearQueue");
        }

        /// <summary>
        /// This API is used to clear all messages in a queue.
        /// </summary>
        /// <param name="req"><see cref="ClearQueueRequest"/></param>
        /// <returns><see cref="ClearQueueResponse"/></returns>
        public ClearQueueResponse ClearQueueSync(ClearQueueRequest req)
        {
            return InternalRequestAsync<ClearQueueResponse>(req, "ClearQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clear the message tags of a subscriber.
        /// </summary>
        /// <param name="req"><see cref="ClearSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearSubscriptionFilterTagsResponse"/></returns>
        public Task<ClearSubscriptionFilterTagsResponse> ClearSubscriptionFilterTags(ClearSubscriptionFilterTagsRequest req)
        {
            return InternalRequestAsync<ClearSubscriptionFilterTagsResponse>(req, "ClearSubscriptionFilterTags");
        }

        /// <summary>
        /// This API is used to clear the message tags of a subscriber.
        /// </summary>
        /// <param name="req"><see cref="ClearSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearSubscriptionFilterTagsResponse"/></returns>
        public ClearSubscriptionFilterTagsResponse ClearSubscriptionFilterTagsSync(ClearSubscriptionFilterTagsRequest req)
        {
            return InternalRequestAsync<ClearSubscriptionFilterTagsResponse>(req, "ClearSubscriptionFilterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a queue.
        /// </summary>
        /// <param name="req"><see cref="CreateQueueRequest"/></param>
        /// <returns><see cref="CreateQueueResponse"/></returns>
        public Task<CreateQueueResponse> CreateQueue(CreateQueueRequest req)
        {
            return InternalRequestAsync<CreateQueueResponse>(req, "CreateQueue");
        }

        /// <summary>
        /// This API is used to create a queue.
        /// </summary>
        /// <param name="req"><see cref="CreateQueueRequest"/></param>
        /// <returns><see cref="CreateQueueResponse"/></returns>
        public CreateQueueResponse CreateQueueSync(CreateQueueRequest req)
        {
            return InternalRequestAsync<CreateQueueResponse>(req, "CreateQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public Task<CreateSubscribeResponse> CreateSubscribe(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe");
        }

        /// <summary>
        /// This API is used to create a subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public CreateSubscribeResponse CreateSubscribeSync(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// This API is used to create a topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteQueueRequest"/></param>
        /// <returns><see cref="DeleteQueueResponse"/></returns>
        public Task<DeleteQueueResponse> DeleteQueue(DeleteQueueRequest req)
        {
            return InternalRequestAsync<DeleteQueueResponse>(req, "DeleteQueue");
        }

        /// <summary>
        /// This API is used to delete a queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteQueueRequest"/></param>
        /// <returns><see cref="DeleteQueueResponse"/></returns>
        public DeleteQueueResponse DeleteQueueSync(DeleteQueueRequest req)
        {
            return InternalRequestAsync<DeleteQueueResponse>(req, "DeleteQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscribeRequest"/></param>
        /// <returns><see cref="DeleteSubscribeResponse"/></returns>
        public Task<DeleteSubscribeResponse> DeleteSubscribe(DeleteSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteSubscribeResponse>(req, "DeleteSubscribe");
        }

        /// <summary>
        /// This API is used to delete a subscription.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscribeRequest"/></param>
        /// <returns><see cref="DeleteSubscribeResponse"/></returns>
        public DeleteSubscribeResponse DeleteSubscribeSync(DeleteSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteSubscribeResponse>(req, "DeleteSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// This API is used to delete a topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate the source queues of a dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeDeadLetterSourceQueuesResponse"/></returns>
        public Task<DescribeDeadLetterSourceQueuesResponse> DescribeDeadLetterSourceQueues(DescribeDeadLetterSourceQueuesRequest req)
        {
            return InternalRequestAsync<DescribeDeadLetterSourceQueuesResponse>(req, "DescribeDeadLetterSourceQueues");
        }

        /// <summary>
        /// This API is used to enumerate the source queues of a dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeDeadLetterSourceQueuesResponse"/></returns>
        public DescribeDeadLetterSourceQueuesResponse DescribeDeadLetterSourceQueuesSync(DescribeDeadLetterSourceQueuesRequest req)
        {
            return InternalRequestAsync<DescribeDeadLetterSourceQueuesResponse>(req, "DescribeDeadLetterSourceQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate queues.
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeQueueDetailResponse"/></returns>
        public Task<DescribeQueueDetailResponse> DescribeQueueDetail(DescribeQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeQueueDetailResponse>(req, "DescribeQueueDetail");
        }

        /// <summary>
        /// This API is used to enumerate queues.
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeQueueDetailResponse"/></returns>
        public DescribeQueueDetailResponse DescribeQueueDetailSync(DescribeQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeQueueDetailResponse>(req, "DescribeQueueDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query subscription details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionDetailResponse"/></returns>
        public Task<DescribeSubscriptionDetailResponse> DescribeSubscriptionDetail(DescribeSubscriptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionDetailResponse>(req, "DescribeSubscriptionDetail");
        }

        /// <summary>
        /// This API is used to query subscription details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionDetailResponse"/></returns>
        public DescribeSubscriptionDetailResponse DescribeSubscriptionDetailSync(DescribeSubscriptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionDetailResponse>(req, "DescribeSubscriptionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query topic details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public Task<DescribeTopicDetailResponse> DescribeTopicDetail(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail");
        }

        /// <summary>
        /// This API is used to query topic details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public DescribeTopicDetailResponse DescribeTopicDetailSync(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify queue attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyQueueAttributeResponse"/></returns>
        public Task<ModifyQueueAttributeResponse> ModifyQueueAttribute(ModifyQueueAttributeRequest req)
        {
            return InternalRequestAsync<ModifyQueueAttributeResponse>(req, "ModifyQueueAttribute");
        }

        /// <summary>
        /// This API is used to modify queue attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyQueueAttributeResponse"/></returns>
        public ModifyQueueAttributeResponse ModifyQueueAttributeSync(ModifyQueueAttributeRequest req)
        {
            return InternalRequestAsync<ModifyQueueAttributeResponse>(req, "ModifyQueueAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify subscription attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifySubscriptionAttributeResponse"/></returns>
        public Task<ModifySubscriptionAttributeResponse> ModifySubscriptionAttribute(ModifySubscriptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubscriptionAttributeResponse>(req, "ModifySubscriptionAttribute");
        }

        /// <summary>
        /// This API is used to modify subscription attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifySubscriptionAttributeResponse"/></returns>
        public ModifySubscriptionAttributeResponse ModifySubscriptionAttributeSync(ModifySubscriptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubscriptionAttributeResponse>(req, "ModifySubscriptionAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributeResponse"/></returns>
        public Task<ModifyTopicAttributeResponse> ModifyTopicAttribute(ModifyTopicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTopicAttributeResponse>(req, "ModifyTopicAttribute");
        }

        /// <summary>
        /// This API is used to modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributeResponse"/></returns>
        public ModifyTopicAttributeResponse ModifyTopicAttributeSync(ModifyTopicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTopicAttributeResponse>(req, "ModifyTopicAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rewind a queue.
        /// </summary>
        /// <param name="req"><see cref="RewindQueueRequest"/></param>
        /// <returns><see cref="RewindQueueResponse"/></returns>
        public Task<RewindQueueResponse> RewindQueue(RewindQueueRequest req)
        {
            return InternalRequestAsync<RewindQueueResponse>(req, "RewindQueue");
        }

        /// <summary>
        /// This API is used to rewind a queue.
        /// </summary>
        /// <param name="req"><see cref="RewindQueueRequest"/></param>
        /// <returns><see cref="RewindQueueResponse"/></returns>
        public RewindQueueResponse RewindQueueSync(RewindQueueRequest req)
        {
            return InternalRequestAsync<RewindQueueResponse>(req, "RewindQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="UnbindDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindDeadLetterResponse"/></returns>
        public Task<UnbindDeadLetterResponse> UnbindDeadLetter(UnbindDeadLetterRequest req)
        {
            return InternalRequestAsync<UnbindDeadLetterResponse>(req, "UnbindDeadLetter");
        }

        /// <summary>
        /// This API is used to unbind a dead letter queue.
        /// </summary>
        /// <param name="req"><see cref="UnbindDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindDeadLetterResponse"/></returns>
        public UnbindDeadLetterResponse UnbindDeadLetterSync(UnbindDeadLetterRequest req)
        {
            return InternalRequestAsync<UnbindDeadLetterResponse>(req, "UnbindDeadLetter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
