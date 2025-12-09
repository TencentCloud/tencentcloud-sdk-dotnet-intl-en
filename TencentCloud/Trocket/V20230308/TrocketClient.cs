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

namespace TencentCloud.Trocket.V20230308
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trocket.V20230308.Models;

   public class TrocketClient : AbstractClient{

       private const string endpoint = "trocket.intl.tencentcloudapi.com";
       private const string version = "2023-03-08";
       private const string sdkVersion = "SDK_NET_3.0.1244";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrocketClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrocketClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to modify the Topic status during migration and go to next step.
        /// </summary>
        /// <param name="req"><see cref="ChangeMigratingTopicToNextStageRequest"/></param>
        /// <returns><see cref="ChangeMigratingTopicToNextStageResponse"/></returns>
        public Task<ChangeMigratingTopicToNextStageResponse> ChangeMigratingTopicToNextStage(ChangeMigratingTopicToNextStageRequest req)
        {
            return InternalRequestAsync<ChangeMigratingTopicToNextStageResponse>(req, "ChangeMigratingTopicToNextStage");
        }

        /// <summary>
        /// This API is used to modify the Topic status during migration and go to next step.
        /// </summary>
        /// <param name="req"><see cref="ChangeMigratingTopicToNextStageRequest"/></param>
        /// <returns><see cref="ChangeMigratingTopicToNextStageResponse"/></returns>
        public ChangeMigratingTopicToNextStageResponse ChangeMigratingTopicToNextStageSync(ChangeMigratingTopicToNextStageRequest req)
        {
            return InternalRequestAsync<ChangeMigratingTopicToNextStageResponse>(req, "ChangeMigratingTopicToNextStage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create consumer groups.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public Task<CreateConsumerGroupResponse> CreateConsumerGroup(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup");
        }

        /// <summary>
        /// Create consumer groups.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public CreateConsumerGroupResponse CreateConsumerGroupSync(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RocketMQ 5.x cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// This API is used to create a RocketMQ 5.x cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole");
        }

        /// <summary>
        /// This API is used to add a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a consumer group. After a consumer group is deleted, all configurations and related data of the consumer group are cleared and cannot be restored. After deletion, online consumer clients report errors. It is recommended to take clients offline in advance.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public Task<DeleteConsumerGroupResponse> DeleteConsumerGroup(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup");
        }

        /// <summary>
        /// This API is used to delete a consumer group. After a consumer group is deleted, all configurations and related data of the consumer group are cleared and cannot be restored. After deletion, online consumer clients report errors. It is recommended to take clients offline in advance.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroupSync(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TDMQ RocketMQ 5.x cluster. Topics, consumer groups, and roles in use should be deleted first.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// This API is used to delete a TDMQ RocketMQ 5.x cluster. Topics, consumer groups, and roles in use should be deleted first.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a role. Make sure that the related information on this role is not used in the current code. After the role is deleted, the keys (AccessKey and SecretKey) used to produce or consume messages with this role become invalid immediately.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public Task<DeleteRoleResponse> DeleteRole(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole");
        }

        /// <summary>
        /// This API is used to delete a role. Make sure that the related information on this role is not used in the current code. After the role is deleted, the keys (AccessKey and SecretKey) used to produce or consume messages with this role become invalid immediately.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public DeleteRoleResponse DeleteRoleSync(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a smooth migration task. Only canceled tasks can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteSmoothMigrationTaskRequest"/></param>
        /// <returns><see cref="DeleteSmoothMigrationTaskResponse"/></returns>
        public Task<DeleteSmoothMigrationTaskResponse> DeleteSmoothMigrationTask(DeleteSmoothMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteSmoothMigrationTaskResponse>(req, "DeleteSmoothMigrationTask");
        }

        /// <summary>
        /// This API is used to delete a smooth migration task. Only canceled tasks can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteSmoothMigrationTaskRequest"/></param>
        /// <returns><see cref="DeleteSmoothMigrationTaskResponse"/></returns>
        public DeleteSmoothMigrationTaskResponse DeleteSmoothMigrationTaskSync(DeleteSmoothMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteSmoothMigrationTaskResponse>(req, "DeleteSmoothMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a topic. After deletion, all configurations and related data of the topic will be cleared and cannot be restored.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// This API is used to delete a topic. After deletion, all configurations and related data of the topic will be cleared and cannot be restored.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query consumer client details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerClientRequest"/></param>
        /// <returns><see cref="DescribeConsumerClientResponse"/></returns>
        public Task<DescribeConsumerClientResponse> DescribeConsumerClient(DescribeConsumerClientRequest req)
        {
            return InternalRequestAsync<DescribeConsumerClientResponse>(req, "DescribeConsumerClient");
        }

        /// <summary>
        /// Query consumer client details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerClientRequest"/></param>
        /// <returns><see cref="DescribeConsumerClientResponse"/></returns>
        public DescribeConsumerClientResponse DescribeConsumerClientSync(DescribeConsumerClientRequest req)
        {
            return InternalRequestAsync<DescribeConsumerClientResponse>(req, "DescribeConsumerClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the client connection list of a consumer group.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerClientListRequest"/></param>
        /// <returns><see cref="DescribeConsumerClientListResponse"/></returns>
        public Task<DescribeConsumerClientListResponse> DescribeConsumerClientList(DescribeConsumerClientListRequest req)
        {
            return InternalRequestAsync<DescribeConsumerClientListResponse>(req, "DescribeConsumerClientList");
        }

        /// <summary>
        /// This API is used to query the client connection list of a consumer group.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerClientListRequest"/></param>
        /// <returns><see cref="DescribeConsumerClientListResponse"/></returns>
        public DescribeConsumerClientListResponse DescribeConsumerClientListSync(DescribeConsumerClientListRequest req)
        {
            return InternalRequestAsync<DescribeConsumerClientListResponse>(req, "DescribeConsumerClientList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query consumer group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public Task<DescribeConsumerGroupResponse> DescribeConsumerGroup(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup");
        }

        /// <summary>
        /// Query consumer group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public DescribeConsumerGroupResponse DescribeConsumerGroupSync(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of heaped messages in a specified consumer group.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerLagRequest"/></param>
        /// <returns><see cref="DescribeConsumerLagResponse"/></returns>
        public Task<DescribeConsumerLagResponse> DescribeConsumerLag(DescribeConsumerLagRequest req)
        {
            return InternalRequestAsync<DescribeConsumerLagResponse>(req, "DescribeConsumerLag");
        }

        /// <summary>
        /// This API is used to query the number of heaped messages in a specified consumer group.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerLagRequest"/></param>
        /// <returns><see cref="DescribeConsumerLagResponse"/></returns>
        public DescribeConsumerLagResponse DescribeConsumerLagSync(DescribeConsumerLagRequest req)
        {
            return InternalRequestAsync<DescribeConsumerLagResponse>(req, "DescribeConsumerLag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe clusters, supporting both 4.x and 5.x clusters. Among them, parameter usage of Filters is as follows:.
        /// 
        /// -InstanceName, the cluster name, supports fuzzy query and can be obtained from the API return value or console.
        /// -InstanceId Cluster ID, exact query, obtain from the current API or console.
        /// - InstanceType cluster type, see [InstanceItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#InstanceItem) data structure, supports multiple selections.
        /// - Version: cluster edition, enumeration values as follows:.
        /// -4 RocketMQ 4.x clusters.
        /// -Deploy a RocketMQ 5.x cluster.
        /// 
        /// This API is used to demonstrate Filters.
        ///  [{ "Name": "InstanceId", "Values": ["rmq-72mo3a9o"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeFusionInstanceListRequest"/></param>
        /// <returns><see cref="DescribeFusionInstanceListResponse"/></returns>
        public Task<DescribeFusionInstanceListResponse> DescribeFusionInstanceList(DescribeFusionInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeFusionInstanceListResponse>(req, "DescribeFusionInstanceList");
        }

        /// <summary>
        /// This API is used to describe clusters, supporting both 4.x and 5.x clusters. Among them, parameter usage of Filters is as follows:.
        /// 
        /// -InstanceName, the cluster name, supports fuzzy query and can be obtained from the API return value or console.
        /// -InstanceId Cluster ID, exact query, obtain from the current API or console.
        /// - InstanceType cluster type, see [InstanceItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#InstanceItem) data structure, supports multiple selections.
        /// - Version: cluster edition, enumeration values as follows:.
        /// -4 RocketMQ 4.x clusters.
        /// -Deploy a RocketMQ 5.x cluster.
        /// 
        /// This API is used to demonstrate Filters.
        ///  [{ "Name": "InstanceId", "Values": ["rmq-72mo3a9o"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeFusionInstanceListRequest"/></param>
        /// <returns><see cref="DescribeFusionInstanceListResponse"/></returns>
        public DescribeFusionInstanceListResponse DescribeFusionInstanceListSync(DescribeFusionInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeFusionInstanceListResponse>(req, "DescribeFusionInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query RocketMQ 5.x cluster information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// This API is used to query RocketMQ 5.x cluster information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe clusters. It only supports 5.x clusters. Description of the Filters parameter use is as follows:.
        /// 
        /// -InstanceName Cluster name, supports fuzzy search.
        /// - InstanceId The Tencent Cloud RocketMQ instance ID, obtained from the [DescribeFusionInstanceList](https://www.tencentcloud.comom/document/api/1493/106745?from_cn_redirect=1) API or console.
        /// - InstanceType cluster type, see [InstanceItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#InstanceItem) data structure, supports multiple selections.
        /// -InstanceStatus cluster status, see [InstanceItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#InstanceItem) data structure, supports multiple selections.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "InstanceId",
        ///     "Values": ["rmq-72mo3a9o"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList");
        }

        /// <summary>
        /// This API is used to describe clusters. It only supports 5.x clusters. Description of the Filters parameter use is as follows:.
        /// 
        /// -InstanceName Cluster name, supports fuzzy search.
        /// - InstanceId The Tencent Cloud RocketMQ instance ID, obtained from the [DescribeFusionInstanceList](https://www.tencentcloud.comom/document/api/1493/106745?from_cn_redirect=1) API or console.
        /// - InstanceType cluster type, see [InstanceItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#InstanceItem) data structure, supports multiple selections.
        /// -InstanceStatus cluster status, see [InstanceItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#InstanceItem) data structure, supports multiple selections.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "InstanceId",
        ///     "Values": ["rmq-72mo3a9o"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query message details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageRequest"/></param>
        /// <returns><see cref="DescribeMessageResponse"/></returns>
        public Task<DescribeMessageResponse> DescribeMessage(DescribeMessageRequest req)
        {
            return InternalRequestAsync<DescribeMessageResponse>(req, "DescribeMessage");
        }

        /// <summary>
        /// Query message details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageRequest"/></param>
        /// <returns><see cref="DescribeMessageResponse"/></returns>
        public DescribeMessageResponse DescribeMessageSync(DescribeMessageRequest req)
        {
            return InternalRequestAsync<DescribeMessageResponse>(req, "DescribeMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the message list. If querying dead letter messages, set the ConsumerGroup parameter.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageListRequest"/></param>
        /// <returns><see cref="DescribeMessageListResponse"/></returns>
        public Task<DescribeMessageListResponse> DescribeMessageList(DescribeMessageListRequest req)
        {
            return InternalRequestAsync<DescribeMessageListResponse>(req, "DescribeMessageList");
        }

        /// <summary>
        /// Query the message list. If querying dead letter messages, set the ConsumerGroup parameter.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageListRequest"/></param>
        /// <returns><see cref="DescribeMessageListResponse"/></returns>
        public DescribeMessageListResponse DescribeMessageListSync(DescribeMessageListRequest req)
        {
            return InternalRequestAsync<DescribeMessageListResponse>(req, "DescribeMessageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query message trace by message ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageTraceRequest"/></param>
        /// <returns><see cref="DescribeMessageTraceResponse"/></returns>
        public Task<DescribeMessageTraceResponse> DescribeMessageTrace(DescribeMessageTraceRequest req)
        {
            return InternalRequestAsync<DescribeMessageTraceResponse>(req, "DescribeMessageTrace");
        }

        /// <summary>
        /// This API is used to query message trace by message ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageTraceRequest"/></param>
        /// <returns><see cref="DescribeMessageTraceResponse"/></returns>
        public DescribeMessageTraceResponse DescribeMessageTraceSync(DescribeMessageTraceRequest req)
        {
            return InternalRequestAsync<DescribeMessageTraceResponse>(req, "DescribeMessageTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view real-time information of migration consumption groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigratingGroupStatsRequest"/></param>
        /// <returns><see cref="DescribeMigratingGroupStatsResponse"/></returns>
        public Task<DescribeMigratingGroupStatsResponse> DescribeMigratingGroupStats(DescribeMigratingGroupStatsRequest req)
        {
            return InternalRequestAsync<DescribeMigratingGroupStatsResponse>(req, "DescribeMigratingGroupStats");
        }

        /// <summary>
        /// This API is used to view real-time information of migration consumption groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigratingGroupStatsRequest"/></param>
        /// <returns><see cref="DescribeMigratingGroupStatsResponse"/></returns>
        public DescribeMigratingGroupStatsResponse DescribeMigratingGroupStatsSync(DescribeMigratingGroupStatsRequest req)
        {
            return InternalRequestAsync<DescribeMigratingGroupStatsResponse>(req, "DescribeMigratingGroupStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Topic migration status list.
        /// 
        /// The Filters field is a query filter that supports the following conditions:.
        /// This API is used to get topic names with fuzzy query support.
        /// This api is used to query the migration status. See the data structure in MigratingTopic (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#MigratingTopic).
        /// This API is used to manage namespaces, valid only for 4.x clusters.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "TopicName",
        ///     "Values": ["topic-a"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeMigratingTopicListRequest"/></param>
        /// <returns><see cref="DescribeMigratingTopicListResponse"/></returns>
        public Task<DescribeMigratingTopicListResponse> DescribeMigratingTopicList(DescribeMigratingTopicListRequest req)
        {
            return InternalRequestAsync<DescribeMigratingTopicListResponse>(req, "DescribeMigratingTopicList");
        }

        /// <summary>
        /// This API is used to query the Topic migration status list.
        /// 
        /// The Filters field is a query filter that supports the following conditions:.
        /// This API is used to get topic names with fuzzy query support.
        /// This api is used to query the migration status. See the data structure in MigratingTopic (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#MigratingTopic).
        /// This API is used to manage namespaces, valid only for 4.x clusters.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "TopicName",
        ///     "Values": ["topic-a"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeMigratingTopicListRequest"/></param>
        /// <returns><see cref="DescribeMigratingTopicListResponse"/></returns>
        public DescribeMigratingTopicListResponse DescribeMigratingTopicListSync(DescribeMigratingTopicListRequest req)
        {
            return InternalRequestAsync<DescribeMigratingTopicListResponse>(req, "DescribeMigratingTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query real-time data of migration topics.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigratingTopicStatsRequest"/></param>
        /// <returns><see cref="DescribeMigratingTopicStatsResponse"/></returns>
        public Task<DescribeMigratingTopicStatsResponse> DescribeMigratingTopicStats(DescribeMigratingTopicStatsRequest req)
        {
            return InternalRequestAsync<DescribeMigratingTopicStatsResponse>(req, "DescribeMigratingTopicStats");
        }

        /// <summary>
        /// This API is used to query real-time data of migration topics.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigratingTopicStatsRequest"/></param>
        /// <returns><see cref="DescribeMigratingTopicStatsResponse"/></returns>
        public DescribeMigratingTopicStatsResponse DescribeMigratingTopicStatsSync(DescribeMigratingTopicStatsRequest req)
        {
            return InternalRequestAsync<DescribeMigratingTopicStatsResponse>(req, "DescribeMigratingTopicStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search the data migration task list. Filter parameter usage instructions are as follows:.
        /// 
        /// This API is used to search precisely according to task ID.
        /// InstanceId. This API is used to precisely search based on instance ID.
        /// This API is used to search by task Type.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTaskListRequest"/></param>
        /// <returns><see cref="DescribeMigrationTaskListResponse"/></returns>
        public Task<DescribeMigrationTaskListResponse> DescribeMigrationTaskList(DescribeMigrationTaskListRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTaskListResponse>(req, "DescribeMigrationTaskList");
        }

        /// <summary>
        /// This API is used to search the data migration task list. Filter parameter usage instructions are as follows:.
        /// 
        /// This API is used to search precisely according to task ID.
        /// InstanceId. This API is used to precisely search based on instance ID.
        /// This API is used to search by task Type.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTaskListRequest"/></param>
        /// <returns><see cref="DescribeMigrationTaskListResponse"/></returns>
        public DescribeMigrationTaskListResponse DescribeMigrationTaskListSync(DescribeMigrationTaskListRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTaskListResponse>(req, "DescribeMigrationTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query producer list information associated with a topic. Filters support the following criteria:.
        /// -client IP.
        /// -client ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeProducerListRequest"/></param>
        /// <returns><see cref="DescribeProducerListResponse"/></returns>
        public Task<DescribeProducerListResponse> DescribeProducerList(DescribeProducerListRequest req)
        {
            return InternalRequestAsync<DescribeProducerListResponse>(req, "DescribeProducerList");
        }

        /// <summary>
        /// This API is used to query producer list information associated with a topic. Filters support the following criteria:.
        /// -client IP.
        /// -client ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeProducerListRequest"/></param>
        /// <returns><see cref="DescribeProducerListResponse"/></returns>
        public DescribeProducerListResponse DescribeProducerListSync(DescribeProducerListRequest req)
        {
            return InternalRequestAsync<DescribeProducerListResponse>(req, "DescribeProducerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query product sales specifications against RocketMQ 5.x clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSKUsRequest"/></param>
        /// <returns><see cref="DescribeProductSKUsResponse"/></returns>
        public Task<DescribeProductSKUsResponse> DescribeProductSKUs(DescribeProductSKUsRequest req)
        {
            return InternalRequestAsync<DescribeProductSKUsResponse>(req, "DescribeProductSKUs");
        }

        /// <summary>
        /// This API is used to query product sales specifications against RocketMQ 5.x clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSKUsRequest"/></param>
        /// <returns><see cref="DescribeProductSKUsResponse"/></returns>
        public DescribeProductSKUsResponse DescribeProductSKUsSync(DescribeProductSKUsRequest req)
        {
            return InternalRequestAsync<DescribeProductSKUsResponse>(req, "DescribeProductSKUs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of roles. Filter parameter usage instructions are as follows:.
        /// 
        /// -Role name supports fuzzy search and can be obtained from the API return value or console.
        /// -AccessKey, support fuzzy search, obtain from API return value or console.
        /// 
        /// This API is used to demonstrate Filters. 
        /// [{ "Name": "RoleName", "Values": ["test_role"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList");
        }

        /// <summary>
        /// This API is used to query the list of roles. Filter parameter usage instructions are as follows:.
        /// 
        /// -Role name supports fuzzy search and can be obtained from the API return value or console.
        /// -AccessKey, support fuzzy search, obtain from API return value or console.
        /// 
        /// This API is used to demonstrate Filters. 
        /// [{ "Name": "RoleName", "Values": ["test_role"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the migration task list smoothly.
        /// 
        /// This API is used to query the supported fields of the query parameter Filters as follows:.
        /// Task status, supports multiple selections. 
        /// ConnectionType, network connection type, supports multiple selections. See the description of SmoothMigrationTaskItem (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#SmoothMigrationTaskItem).
        /// This API is used to search for an instance by instance ID with precise matching. 
        /// This API is used to query task names with fuzzy search support.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "InstanceId",
        ///     "Values": ["rmq-1gzecldfg"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeSmoothMigrationTaskListRequest"/></param>
        /// <returns><see cref="DescribeSmoothMigrationTaskListResponse"/></returns>
        public Task<DescribeSmoothMigrationTaskListResponse> DescribeSmoothMigrationTaskList(DescribeSmoothMigrationTaskListRequest req)
        {
            return InternalRequestAsync<DescribeSmoothMigrationTaskListResponse>(req, "DescribeSmoothMigrationTaskList");
        }

        /// <summary>
        /// This API is used to query the migration task list smoothly.
        /// 
        /// This API is used to query the supported fields of the query parameter Filters as follows:.
        /// Task status, supports multiple selections. 
        /// ConnectionType, network connection type, supports multiple selections. See the description of SmoothMigrationTaskItem (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#SmoothMigrationTaskItem).
        /// This API is used to search for an instance by instance ID with precise matching. 
        /// This API is used to query task names with fuzzy search support.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "InstanceId",
        ///     "Values": ["rmq-1gzecldfg"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeSmoothMigrationTaskListRequest"/></param>
        /// <returns><see cref="DescribeSmoothMigrationTaskListResponse"/></returns>
        public DescribeSmoothMigrationTaskListResponse DescribeSmoothMigrationTaskListSync(DescribeSmoothMigrationTaskListRequest req)
        {
            return InternalRequestAsync<DescribeSmoothMigrationTaskListResponse>(req, "DescribeSmoothMigrationTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the group list of the source cluster during the smooth migration process.
        /// 
        /// The Filters field is a query filter that supports the following fields:.
        /// This API is used to query consumer group names with fuzzy search support.
        /// This API is used to check whether the data is Imported.
        /// This api is used to check the import status. See SourceClusterGroupConfig (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#SourceClusterGroupConfig) for details.
        /// This API is used to manage namespaces, valid only for 4.x clusters.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "GroupName",
        ///     "Values": ["group-a"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceClusterGroupListRequest"/></param>
        /// <returns><see cref="DescribeSourceClusterGroupListResponse"/></returns>
        public Task<DescribeSourceClusterGroupListResponse> DescribeSourceClusterGroupList(DescribeSourceClusterGroupListRequest req)
        {
            return InternalRequestAsync<DescribeSourceClusterGroupListResponse>(req, "DescribeSourceClusterGroupList");
        }

        /// <summary>
        /// This API is used to obtain the group list of the source cluster during the smooth migration process.
        /// 
        /// The Filters field is a query filter that supports the following fields:.
        /// This API is used to query consumer group names with fuzzy search support.
        /// This API is used to check whether the data is Imported.
        /// This api is used to check the import status. See SourceClusterGroupConfig (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#SourceClusterGroupConfig) for details.
        /// This API is used to manage namespaces, valid only for 4.x clusters.
        /// 
        /// This API is used to demonstrate Filters.
        /// [{
        ///     "Name": "GroupName",
        ///     "Values": ["group-a"]
        /// }]
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceClusterGroupListRequest"/></param>
        /// <returns><see cref="DescribeSourceClusterGroupListResponse"/></returns>
        public DescribeSourceClusterGroupListResponse DescribeSourceClusterGroupListSync(DescribeSourceClusterGroupListRequest req)
        {
            return InternalRequestAsync<DescribeSourceClusterGroupListResponse>(req, "DescribeSourceClusterGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query topic details. The Offset and Limit parameters are pagination parameters for consumer groups subscribing to this topic. The Filter parameter usage instructions are as follows:.
        /// 
        /// -The ConsumerGroup name can be obtained from the [ConsumeGroupItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ConsumeGroupItem) in the API response of [DescribeConsumerGroupList](https://www.tencentcloud.comom/document/api/1493/101535?from_cn_redirect=1) or from the console.
        /// 
        /// This API is used to demonstrate Filters. 
        /// [{ "Name": "ConsumerGroup", "Values": ["test_group"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic");
        }

        /// <summary>
        /// This API is used to query topic details. The Offset and Limit parameters are pagination parameters for consumer groups subscribing to this topic. The Filter parameter usage instructions are as follows:.
        /// 
        /// -The ConsumerGroup name can be obtained from the [ConsumeGroupItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ConsumeGroupItem) in the API response of [DescribeConsumerGroupList](https://www.tencentcloud.comom/document/api/1493/101535?from_cn_redirect=1) or from the console.
        /// 
        /// This API is used to demonstrate Filters. 
        /// [{ "Name": "ConsumerGroup", "Values": ["test_group"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search the topic list. Filter parameter usage instructions are as follows:.
        /// 
        /// -TopicName supports fuzzy search. Obtain it from the [TopicItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#TopicItem) in the [DescribeTopicList](https://www.tencentcloud.comom/document/api/1493/96030?from_cn_redirect=1) API response or the console.
        /// -Search by TopicType, support multiple selections. See the TopicType field in the [DescribeTopic](https://www.tencentcloud.comom/document/api/1493/97945?from_cn_redirect=1) API.
        /// 
        /// This API is used to demonstrate Filters.
        ///  [{ "Name": "TopicName", "Values": ["test_topic"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public Task<DescribeTopicListResponse> DescribeTopicList(DescribeTopicListRequest req)
        {
            return InternalRequestAsync<DescribeTopicListResponse>(req, "DescribeTopicList");
        }

        /// <summary>
        /// This API is used to search the topic list. Filter parameter usage instructions are as follows:.
        /// 
        /// -TopicName supports fuzzy search. Obtain it from the [TopicItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#TopicItem) in the [DescribeTopicList](https://www.tencentcloud.comom/document/api/1493/96030?from_cn_redirect=1) API response or the console.
        /// -Search by TopicType, support multiple selections. See the TopicType field in the [DescribeTopic](https://www.tencentcloud.comom/document/api/1493/97945?from_cn_redirect=1) API.
        /// 
        /// This API is used to demonstrate Filters.
        ///  [{ "Name": "TopicName", "Values": ["test_topic"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public DescribeTopicListResponse DescribeTopicListSync(DescribeTopicListRequest req)
        {
            return InternalRequestAsync<DescribeTopicListResponse>(req, "DescribeTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get topic list by consumer group. Filter parameter usage instructions are as follows:.
        /// 
        /// -TopicName. It can be obtained from [TopicItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#TopicItem) returned by the API [DescribeTopicList](https://www.tencentcloud.comom/document/api/1493/96030?from_cn_redirect=1) or from the console.
        /// 
        /// This API is used to demonstrate Filters. 
        /// [{ "Name": "TopicName", "Values": ["test_topic"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListByGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicListByGroupResponse"/></returns>
        public Task<DescribeTopicListByGroupResponse> DescribeTopicListByGroup(DescribeTopicListByGroupRequest req)
        {
            return InternalRequestAsync<DescribeTopicListByGroupResponse>(req, "DescribeTopicListByGroup");
        }

        /// <summary>
        /// This API is used to get topic list by consumer group. Filter parameter usage instructions are as follows:.
        /// 
        /// -TopicName. It can be obtained from [TopicItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#TopicItem) returned by the API [DescribeTopicList](https://www.tencentcloud.comom/document/api/1493/96030?from_cn_redirect=1) or from the console.
        /// 
        /// This API is used to demonstrate Filters. 
        /// [{ "Name": "TopicName", "Values": ["test_topic"] }]
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListByGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicListByGroupResponse"/></returns>
        public DescribeTopicListByGroupResponse DescribeTopicListByGroupSync(DescribeTopicListByGroupRequest req)
        {
            return InternalRequestAsync<DescribeTopicListByGroupResponse>(req, "DescribeTopicListByGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the topics being migrated are in normal status. Only topics in normal status can enter the next migration stage.
        /// </summary>
        /// <param name="req"><see cref="DoHealthCheckOnMigratingTopicRequest"/></param>
        /// <returns><see cref="DoHealthCheckOnMigratingTopicResponse"/></returns>
        public Task<DoHealthCheckOnMigratingTopicResponse> DoHealthCheckOnMigratingTopic(DoHealthCheckOnMigratingTopicRequest req)
        {
            return InternalRequestAsync<DoHealthCheckOnMigratingTopicResponse>(req, "DoHealthCheckOnMigratingTopic");
        }

        /// <summary>
        /// This API is used to check whether the topics being migrated are in normal status. Only topics in normal status can enter the next migration stage.
        /// </summary>
        /// <param name="req"><see cref="DoHealthCheckOnMigratingTopicRequest"/></param>
        /// <returns><see cref="DoHealthCheckOnMigratingTopicResponse"/></returns>
        public DoHealthCheckOnMigratingTopicResponse DoHealthCheckOnMigratingTopicSync(DoHealthCheckOnMigratingTopicRequest req)
        {
            return InternalRequestAsync<DoHealthCheckOnMigratingTopicResponse>(req, "DoHealthCheckOnMigratingTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify consumer group attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public Task<ModifyConsumerGroupResponse> ModifyConsumerGroup(ModifyConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupResponse>(req, "ModifyConsumerGroup");
        }

        /// <summary>
        /// Modify consumer group attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public ModifyConsumerGroupResponse ModifyConsumerGroupSync(ModifyConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupResponse>(req, "ModifyConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify attributes of a TDMQ RocketMQ 5.x cluster. Only running clusters support this operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to modify attributes of a TDMQ RocketMQ 5.x cluster. Only running clusters support this operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify access points of a TDMQ RocketMQ 5.x cluster. Make sure that the access points exist before the operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEndpointRequest"/></param>
        /// <returns><see cref="ModifyInstanceEndpointResponse"/></returns>
        public Task<ModifyInstanceEndpointResponse> ModifyInstanceEndpoint(ModifyInstanceEndpointRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEndpointResponse>(req, "ModifyInstanceEndpoint");
        }

        /// <summary>
        /// This API is used to modify access points of a TDMQ RocketMQ 5.x cluster. Make sure that the access points exist before the operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEndpointRequest"/></param>
        /// <returns><see cref="ModifyInstanceEndpointResponse"/></returns>
        public ModifyInstanceEndpointResponse ModifyInstanceEndpointSync(ModifyInstanceEndpointRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEndpointResponse>(req, "ModifyInstanceEndpoint")
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
        /// Modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// Modify topic attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a topic from the migration list. It is valid only when the topic is in the initial state.
        /// </summary>
        /// <param name="req"><see cref="RemoveMigratingTopicRequest"/></param>
        /// <returns><see cref="RemoveMigratingTopicResponse"/></returns>
        public Task<RemoveMigratingTopicResponse> RemoveMigratingTopic(RemoveMigratingTopicRequest req)
        {
            return InternalRequestAsync<RemoveMigratingTopicResponse>(req, "RemoveMigratingTopic");
        }

        /// <summary>
        /// This API is used to remove a topic from the migration list. It is valid only when the topic is in the initial state.
        /// </summary>
        /// <param name="req"><see cref="RemoveMigratingTopicRequest"/></param>
        /// <returns><see cref="RemoveMigratingTopicResponse"/></returns>
        public RemoveMigratingTopicResponse RemoveMigratingTopicSync(RemoveMigratingTopicRequest req)
        {
            return InternalRequestAsync<RemoveMigratingTopicResponse>(req, "RemoveMigratingTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resend dead letter messages.
        /// </summary>
        /// <param name="req"><see cref="ResendDeadLetterMessageRequest"/></param>
        /// <returns><see cref="ResendDeadLetterMessageResponse"/></returns>
        public Task<ResendDeadLetterMessageResponse> ResendDeadLetterMessage(ResendDeadLetterMessageRequest req)
        {
            return InternalRequestAsync<ResendDeadLetterMessageResponse>(req, "ResendDeadLetterMessage");
        }

        /// <summary>
        /// This API is used to resend dead letter messages.
        /// </summary>
        /// <param name="req"><see cref="ResendDeadLetterMessageRequest"/></param>
        /// <returns><see cref="ResendDeadLetterMessageResponse"/></returns>
        public ResendDeadLetterMessageResponse ResendDeadLetterMessageSync(ResendDeadLetterMessageRequest req)
        {
            return InternalRequestAsync<ResendDeadLetterMessageResponse>(req, "ResendDeadLetterMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reset the consumption position.
        /// </summary>
        /// <param name="req"><see cref="ResetConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ResetConsumerGroupOffsetResponse"/></returns>
        public Task<ResetConsumerGroupOffsetResponse> ResetConsumerGroupOffset(ResetConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ResetConsumerGroupOffsetResponse>(req, "ResetConsumerGroupOffset");
        }

        /// <summary>
        /// Reset the consumption position.
        /// </summary>
        /// <param name="req"><see cref="ResetConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ResetConsumerGroupOffsetResponse"/></returns>
        public ResetConsumerGroupOffsetResponse ResetConsumerGroupOffsetSync(ResetConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ResetConsumerGroupOffsetResponse>(req, "ResetConsumerGroupOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to roll back the topic that is undergoing migration to the previous stage.
        /// </summary>
        /// <param name="req"><see cref="RollbackMigratingTopicStageRequest"/></param>
        /// <returns><see cref="RollbackMigratingTopicStageResponse"/></returns>
        public Task<RollbackMigratingTopicStageResponse> RollbackMigratingTopicStage(RollbackMigratingTopicStageRequest req)
        {
            return InternalRequestAsync<RollbackMigratingTopicStageResponse>(req, "RollbackMigratingTopicStage");
        }

        /// <summary>
        /// This API is used to roll back the topic that is undergoing migration to the previous stage.
        /// </summary>
        /// <param name="req"><see cref="RollbackMigratingTopicStageRequest"/></param>
        /// <returns><see cref="RollbackMigratingTopicStageResponse"/></returns>
        public RollbackMigratingTopicStageResponse RollbackMigratingTopicStageSync(RollbackMigratingTopicStageRequest req)
        {
            return InternalRequestAsync<RollbackMigratingTopicStageResponse>(req, "RollbackMigratingTopicStage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
