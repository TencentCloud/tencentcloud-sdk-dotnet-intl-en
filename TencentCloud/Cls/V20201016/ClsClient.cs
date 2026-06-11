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

namespace TencentCloud.Cls.V20201016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cls.V20201016.Models;

   public class ClsClient : AbstractClient{

       private const string endpoint = "cls.intl.tencentcloudapi.com";
       private const string version = "2020-10-16";
       private const string sdkVersion = "SDK_NET_3.0.1329";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ClsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add machine group information.
        /// </summary>
        /// <param name="req"><see cref="AddMachineGroupInfoRequest"/></param>
        /// <returns><see cref="AddMachineGroupInfoResponse"/></returns>
        public Task<AddMachineGroupInfoResponse> AddMachineGroupInfo(AddMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<AddMachineGroupInfoResponse>(req, "AddMachineGroupInfo");
        }

        /// <summary>
        /// This API is used to add machine group information.
        /// </summary>
        /// <param name="req"><see cref="AddMachineGroupInfoRequest"/></param>
        /// <returns><see cref="AddMachineGroupInfoResponse"/></returns>
        public AddMachineGroupInfoResponse AddMachineGroupInfoSync(AddMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<AddMachineGroupInfoResponse>(req, "AddMachineGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply the collection configuration to a specified machine group.
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroup(ApplyConfigToMachineGroupRequest req)
        {
            return InternalRequestAsync<ApplyConfigToMachineGroupResponse>(req, "ApplyConfigToMachineGroup");
        }

        /// <summary>
        /// This API is used to apply the collection configuration to a specified machine group.
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public ApplyConfigToMachineGroupResponse ApplyConfigToMachineGroupSync(ApplyConfigToMachineGroupRequest req)
        {
            return InternalRequestAsync<ApplyConfigToMachineGroupResponse>(req, "ApplyConfigToMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel creating a reindexing task.
        /// </summary>
        /// <param name="req"><see cref="CancelRebuildIndexTaskRequest"/></param>
        /// <returns><see cref="CancelRebuildIndexTaskResponse"/></returns>
        public Task<CancelRebuildIndexTaskResponse> CancelRebuildIndexTask(CancelRebuildIndexTaskRequest req)
        {
            return InternalRequestAsync<CancelRebuildIndexTaskResponse>(req, "CancelRebuildIndexTask");
        }

        /// <summary>
        /// This API is used to cancel creating a reindexing task.
        /// </summary>
        /// <param name="req"><see cref="CancelRebuildIndexTaskRequest"/></param>
        /// <returns><see cref="CancelRebuildIndexTaskResponse"/></returns>
        public CancelRebuildIndexTaskResponse CancelRebuildIndexTaskSync(CancelRebuildIndexTaskRequest req)
        {
            return InternalRequestAsync<CancelRebuildIndexTaskResponse>(req, "CancelRebuildIndexTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Call the API to initiate a dialogue request.
        /// This API supports AI-powered logging features such as intelligently generating retrieval analysis statements.
        /// Note: When calling this API via SSE streaming, ensure the request domain name is set to cls.ai.tencentcloudapi.com (configurable as cls.ai.internal.tencentcloudapi.com in a private network environment).
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public Task<ChatCompletionsResponse> ChatCompletions(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions");
        }

        /// <summary>
        /// Call the API to initiate a dialogue request.
        /// This API supports AI-powered logging features such as intelligently generating retrieval analysis statements.
        /// Note: When calling this API via SSE streaming, ensure the request domain name is set to cls.ai.tencentcloudapi.com (configurable as cls.ai.internal.tencentcloudapi.com in a private network environment).
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public ChatCompletionsResponse ChatCompletionsSync(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify the syntax of data processing DSL functions.
        /// </summary>
        /// <param name="req"><see cref="CheckFunctionRequest"/></param>
        /// <returns><see cref="CheckFunctionResponse"/></returns>
        public Task<CheckFunctionResponse> CheckFunction(CheckFunctionRequest req)
        {
            return InternalRequestAsync<CheckFunctionResponse>(req, "CheckFunction");
        }

        /// <summary>
        /// This API is used to verify the syntax of data processing DSL functions.
        /// </summary>
        /// <param name="req"><see cref="CheckFunctionRequest"/></param>
        /// <returns><see cref="CheckFunctionResponse"/></returns>
        public CheckFunctionResponse CheckFunctionSync(CheckFunctionRequest req)
        {
            return InternalRequestAsync<CheckFunctionResponse>(req, "CheckFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the Kafka service cluster is accessible.
        /// </summary>
        /// <param name="req"><see cref="CheckRechargeKafkaServerRequest"/></param>
        /// <returns><see cref="CheckRechargeKafkaServerResponse"/></returns>
        public Task<CheckRechargeKafkaServerResponse> CheckRechargeKafkaServer(CheckRechargeKafkaServerRequest req)
        {
            return InternalRequestAsync<CheckRechargeKafkaServerResponse>(req, "CheckRechargeKafkaServer");
        }

        /// <summary>
        /// This API is used to check whether the Kafka service cluster is accessible.
        /// </summary>
        /// <param name="req"><see cref="CheckRechargeKafkaServerRequest"/></param>
        /// <returns><see cref="CheckRechargeKafkaServerResponse"/></returns>
        public CheckRechargeKafkaServerResponse CheckRechargeKafkaServerSync(CheckRechargeKafkaServerRequest req)
        {
            return InternalRequestAsync<CheckRechargeKafkaServerResponse>(req, "CheckRechargeKafkaServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable Kafka consumption.
        /// </summary>
        /// <param name="req"><see cref="CloseKafkaConsumerRequest"/></param>
        /// <returns><see cref="CloseKafkaConsumerResponse"/></returns>
        public Task<CloseKafkaConsumerResponse> CloseKafkaConsumer(CloseKafkaConsumerRequest req)
        {
            return InternalRequestAsync<CloseKafkaConsumerResponse>(req, "CloseKafkaConsumer");
        }

        /// <summary>
        /// This API is used to disable Kafka consumption.
        /// </summary>
        /// <param name="req"><see cref="CloseKafkaConsumerRequest"/></param>
        /// <returns><see cref="CloseKafkaConsumerResponse"/></returns>
        public CloseKafkaConsumerResponse CloseKafkaConsumerSync(CloseKafkaConsumerRequest req)
        {
            return InternalRequestAsync<CloseKafkaConsumerResponse>(req, "CloseKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit a consumption offset.
        /// </summary>
        /// <param name="req"><see cref="CommitConsumerOffsetsRequest"/></param>
        /// <returns><see cref="CommitConsumerOffsetsResponse"/></returns>
        public Task<CommitConsumerOffsetsResponse> CommitConsumerOffsets(CommitConsumerOffsetsRequest req)
        {
            return InternalRequestAsync<CommitConsumerOffsetsResponse>(req, "CommitConsumerOffsets");
        }

        /// <summary>
        /// This API is used to submit a consumption offset.
        /// </summary>
        /// <param name="req"><see cref="CommitConsumerOffsetsRequest"/></param>
        /// <returns><see cref="CommitConsumerOffsetsResponse"/></returns>
        public CommitConsumerOffsetsResponse CommitConsumerOffsetsSync(CommitConsumerOffsetsRequest req)
        {
            return InternalRequestAsync<CommitConsumerOffsetsResponse>(req, "CommitConsumerOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public Task<CreateAlarmResponse> CreateAlarm(CreateAlarmRequest req)
        {
            return InternalRequestAsync<CreateAlarmResponse>(req, "CreateAlarm");
        }

        /// <summary>
        /// This API is used to create an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public CreateAlarmResponse CreateAlarmSync(CreateAlarmRequest req)
        {
            return InternalRequestAsync<CreateAlarmResponse>(req, "CreateAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a notification channel group with two configuration modes to choose from.
        /// 1. Easy mode provides the most basic notification channel function. The following parameters are required:
        /// - Type
        /// - NoticeReceivers
        /// - WebCallbacks
        /// 
        /// 2. Advanced mode: On the basis of easy mode, it supports setting rules, setting notification channels for different types of alarms, and escalating alarms. The following parameters are required:
        /// - NoticeRules
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice");
        }

        /// <summary>
        /// This API is used to create a notification channel group with two configuration modes to choose from.
        /// 1. Easy mode provides the most basic notification channel function. The following parameters are required:
        /// - Type
        /// - NoticeReceivers
        /// - WebCallbacks
        /// 
        /// 2. Advanced mode: On the basis of easy mode, it supports setting rules, setting notification channels for different types of alarms, and escalating alarms. The following parameters are required:
        /// - NoticeRules
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public CreateAlarmNoticeResponse CreateAlarmNoticeSync(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an alarm blocking rule.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmShieldRequest"/></param>
        /// <returns><see cref="CreateAlarmShieldResponse"/></returns>
        public Task<CreateAlarmShieldResponse> CreateAlarmShield(CreateAlarmShieldRequest req)
        {
            return InternalRequestAsync<CreateAlarmShieldResponse>(req, "CreateAlarmShield");
        }

        /// <summary>
        /// This API is used to create an alarm blocking rule.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmShieldRequest"/></param>
        /// <returns><see cref="CreateAlarmShieldResponse"/></returns>
        public CreateAlarmShieldResponse CreateAlarmShieldSync(CreateAlarmShieldRequest req)
        {
            return InternalRequestAsync<CreateAlarmShieldResponse>(req, "CreateAlarmShield")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud product integration uses internal APIs
        /// </summary>
        /// <param name="req"><see cref="CreateCloudProductLogCollectionRequest"/></param>
        /// <returns><see cref="CreateCloudProductLogCollectionResponse"/></returns>
        public Task<CreateCloudProductLogCollectionResponse> CreateCloudProductLogCollection(CreateCloudProductLogCollectionRequest req)
        {
            return InternalRequestAsync<CreateCloudProductLogCollectionResponse>(req, "CreateCloudProductLogCollection");
        }

        /// <summary>
        /// Cloud product integration uses internal APIs
        /// </summary>
        /// <param name="req"><see cref="CreateCloudProductLogCollectionRequest"/></param>
        /// <returns><see cref="CreateCloudProductLogCollectionResponse"/></returns>
        public CreateCloudProductLogCollectionResponse CreateCloudProductLogCollectionSync(CreateCloudProductLogCollectionRequest req)
        {
            return InternalRequestAsync<CreateCloudProductLogCollectionResponse>(req, "CreateCloudProductLogCollection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public Task<CreateConfigResponse> CreateConfig(CreateConfigRequest req)
        {
            return InternalRequestAsync<CreateConfigResponse>(req, "CreateConfig");
        }

        /// <summary>
        /// This API is used to create collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public CreateConfigResponse CreateConfigSync(CreateConfigRequest req)
        {
            return InternalRequestAsync<CreateConfigResponse>(req, "CreateConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the DataSight Console
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleRequest"/></param>
        /// <returns><see cref="CreateConsoleResponse"/></returns>
        public Task<CreateConsoleResponse> CreateConsole(CreateConsoleRequest req)
        {
            return InternalRequestAsync<CreateConsoleResponse>(req, "CreateConsole");
        }

        /// <summary>
        /// This API is used to create the DataSight Console
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleRequest"/></param>
        /// <returns><see cref="CreateConsoleResponse"/></returns>
        public CreateConsoleResponse CreateConsoleSync(CreateConsoleRequest req)
        {
            return InternalRequestAsync<CreateConsoleResponse>(req, "CreateConsole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CKafka delivery task.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public Task<CreateConsumerResponse> CreateConsumer(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer");
        }

        /// <summary>
        /// This API is used to create a CKafka delivery task.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public CreateConsumerResponse CreateConsumerSync(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the heartbeat of a consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public Task<CreateConsumerGroupResponse> CreateConsumerGroup(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup");
        }

        /// <summary>
        /// This API is used to check the heartbeat of a consumer group.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public CreateConsumerGroupResponse CreateConsumerGroupSync(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a COS import task.
        /// </summary>
        /// <param name="req"><see cref="CreateCosRechargeRequest"/></param>
        /// <returns><see cref="CreateCosRechargeResponse"/></returns>
        public Task<CreateCosRechargeResponse> CreateCosRecharge(CreateCosRechargeRequest req)
        {
            return InternalRequestAsync<CreateCosRechargeResponse>(req, "CreateCosRecharge");
        }

        /// <summary>
        /// This API is used to create a COS import task.
        /// </summary>
        /// <param name="req"><see cref="CreateCosRechargeRequest"/></param>
        /// <returns><see cref="CreateCosRechargeResponse"/></returns>
        public CreateCosRechargeResponse CreateCosRechargeSync(CreateCosRechargeRequest req)
        {
            return InternalRequestAsync<CreateCosRechargeResponse>(req, "CreateCosRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dashboard.
        /// </summary>
        /// <param name="req"><see cref="CreateDashboardRequest"/></param>
        /// <returns><see cref="CreateDashboardResponse"/></returns>
        public Task<CreateDashboardResponse> CreateDashboard(CreateDashboardRequest req)
        {
            return InternalRequestAsync<CreateDashboardResponse>(req, "CreateDashboard");
        }

        /// <summary>
        /// This API is used to create a dashboard.
        /// </summary>
        /// <param name="req"><see cref="CreateDashboardRequest"/></param>
        /// <returns><see cref="CreateDashboardResponse"/></returns>
        public CreateDashboardResponse CreateDashboardSync(CreateDashboardRequest req)
        {
            return InternalRequestAsync<CreateDashboardResponse>(req, "CreateDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dashboard subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateDashboardSubscribeRequest"/></param>
        /// <returns><see cref="CreateDashboardSubscribeResponse"/></returns>
        public Task<CreateDashboardSubscribeResponse> CreateDashboardSubscribe(CreateDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<CreateDashboardSubscribeResponse>(req, "CreateDashboardSubscribe");
        }

        /// <summary>
        /// This API is used to create a dashboard subscription.
        /// </summary>
        /// <param name="req"><see cref="CreateDashboardSubscribeRequest"/></param>
        /// <returns><see cref="CreateDashboardSubscribeResponse"/></returns>
        public CreateDashboardSubscribeResponse CreateDashboardSubscribeSync(CreateDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<CreateDashboardSubscribeResponse>(req, "CreateDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data processing task.
        /// </summary>
        /// <param name="req"><see cref="CreateDataTransformRequest"/></param>
        /// <returns><see cref="CreateDataTransformResponse"/></returns>
        public Task<CreateDataTransformResponse> CreateDataTransform(CreateDataTransformRequest req)
        {
            return InternalRequestAsync<CreateDataTransformResponse>(req, "CreateDataTransform");
        }

        /// <summary>
        /// This API is used to create a data processing task.
        /// </summary>
        /// <param name="req"><see cref="CreateDataTransformRequest"/></param>
        /// <returns><see cref="CreateDataTransformResponse"/></returns>
        public CreateDataTransformResponse CreateDataTransformSync(CreateDataTransformRequest req)
        {
            return InternalRequestAsync<CreateDataTransformResponse>(req, "CreateDataTransform")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a delivery SCF task.
        /// </summary>
        /// <param name="req"><see cref="CreateDeliverCloudFunctionRequest"/></param>
        /// <returns><see cref="CreateDeliverCloudFunctionResponse"/></returns>
        public Task<CreateDeliverCloudFunctionResponse> CreateDeliverCloudFunction(CreateDeliverCloudFunctionRequest req)
        {
            return InternalRequestAsync<CreateDeliverCloudFunctionResponse>(req, "CreateDeliverCloudFunction");
        }

        /// <summary>
        /// This API is used to create a delivery SCF task.
        /// </summary>
        /// <param name="req"><see cref="CreateDeliverCloudFunctionRequest"/></param>
        /// <returns><see cref="CreateDeliverCloudFunctionResponse"/></returns>
        public CreateDeliverCloudFunctionResponse CreateDeliverCloudFunctionSync(CreateDeliverCloudFunctionRequest req)
        {
            return InternalRequestAsync<CreateDeliverCloudFunctionResponse>(req, "CreateDeliverCloudFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a DLC delivery task
        /// </summary>
        /// <param name="req"><see cref="CreateDlcDeliverRequest"/></param>
        /// <returns><see cref="CreateDlcDeliverResponse"/></returns>
        public Task<CreateDlcDeliverResponse> CreateDlcDeliver(CreateDlcDeliverRequest req)
        {
            return InternalRequestAsync<CreateDlcDeliverResponse>(req, "CreateDlcDeliver");
        }

        /// <summary>
        /// Create a DLC delivery task
        /// </summary>
        /// <param name="req"><see cref="CreateDlcDeliverRequest"/></param>
        /// <returns><see cref="CreateDlcDeliverResponse"/></returns>
        public CreateDlcDeliverResponse CreateDlcDeliverSync(CreateDlcDeliverRequest req)
        {
            return InternalRequestAsync<CreateDlcDeliverResponse>(req, "CreateDlcDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an es import configuration
        /// </summary>
        /// <param name="req"><see cref="CreateEsRechargeRequest"/></param>
        /// <returns><see cref="CreateEsRechargeResponse"/></returns>
        public Task<CreateEsRechargeResponse> CreateEsRecharge(CreateEsRechargeRequest req)
        {
            return InternalRequestAsync<CreateEsRechargeResponse>(req, "CreateEsRecharge");
        }

        /// <summary>
        /// This API is used to create an es import configuration
        /// </summary>
        /// <param name="req"><see cref="CreateEsRechargeRequest"/></param>
        /// <returns><see cref="CreateEsRechargeResponse"/></returns>
        public CreateEsRechargeResponse CreateEsRechargeSync(CreateEsRechargeRequest req)
        {
            return InternalRequestAsync<CreateEsRechargeResponse>(req, "CreateEsRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API only creates download tasks. The download address returned by the task can be obtained by user invocation of [DescribeExports](https://www.tencentcloud.com/document/product/614/56449?from_cn_redirect=1) to view task list, which includes the CosPath parameter for the download address.
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public Task<CreateExportResponse> CreateExport(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport");
        }

        /// <summary>
        /// This API only creates download tasks. The download address returned by the task can be obtained by user invocation of [DescribeExports](https://www.tencentcloud.com/document/product/614/56449?from_cn_redirect=1) to view task list, which includes the CosPath parameter for the download address.
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public CreateExportResponse CreateExportSync(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create host metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateHostMetricConfigRequest"/></param>
        /// <returns><see cref="CreateHostMetricConfigResponse"/></returns>
        public Task<CreateHostMetricConfigResponse> CreateHostMetricConfig(CreateHostMetricConfigRequest req)
        {
            return InternalRequestAsync<CreateHostMetricConfigResponse>(req, "CreateHostMetricConfig");
        }

        /// <summary>
        /// This API is used to create host metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateHostMetricConfigRequest"/></param>
        /// <returns><see cref="CreateHostMetricConfigResponse"/></returns>
        public CreateHostMetricConfigResponse CreateHostMetricConfigSync(CreateHostMetricConfigRequest req)
        {
            return InternalRequestAsync<CreateHostMetricConfigResponse>(req, "CreateHostMetricConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an index.
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex");
        }

        /// <summary>
        /// This API is used to create an index.
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Kafka data subscription task.
        /// </summary>
        /// <param name="req"><see cref="CreateKafkaRechargeRequest"/></param>
        /// <returns><see cref="CreateKafkaRechargeResponse"/></returns>
        public Task<CreateKafkaRechargeResponse> CreateKafkaRecharge(CreateKafkaRechargeRequest req)
        {
            return InternalRequestAsync<CreateKafkaRechargeResponse>(req, "CreateKafkaRecharge");
        }

        /// <summary>
        /// This API is used to create a Kafka data subscription task.
        /// </summary>
        /// <param name="req"><see cref="CreateKafkaRechargeRequest"/></param>
        /// <returns><see cref="CreateKafkaRechargeResponse"/></returns>
        public CreateKafkaRechargeResponse CreateKafkaRechargeSync(CreateKafkaRechargeRequest req)
        {
            return InternalRequestAsync<CreateKafkaRechargeResponse>(req, "CreateKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a logset. The ID of the created logset is returned.
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public Task<CreateLogsetResponse> CreateLogset(CreateLogsetRequest req)
        {
            return InternalRequestAsync<CreateLogsetResponse>(req, "CreateLogset");
        }

        /// <summary>
        /// This API is used to create a logset. The ID of the created logset is returned.
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public CreateLogsetResponse CreateLogsetSync(CreateLogsetRequest req)
        {
            return InternalRequestAsync<CreateLogsetResponse>(req, "CreateLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a machine group.
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public Task<CreateMachineGroupResponse> CreateMachineGroup(CreateMachineGroupRequest req)
        {
            return InternalRequestAsync<CreateMachineGroupResponse>(req, "CreateMachineGroup");
        }

        /// <summary>
        /// This API is used to create a machine group.
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public CreateMachineGroupResponse CreateMachineGroupSync(CreateMachineGroupRequest req)
        {
            return InternalRequestAsync<CreateMachineGroupResponse>(req, "CreateMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateMetricConfigRequest"/></param>
        /// <returns><see cref="CreateMetricConfigResponse"/></returns>
        public Task<CreateMetricConfigResponse> CreateMetricConfig(CreateMetricConfigRequest req)
        {
            return InternalRequestAsync<CreateMetricConfigResponse>(req, "CreateMetricConfig");
        }

        /// <summary>
        /// This API is used to create metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateMetricConfigRequest"/></param>
        /// <returns><see cref="CreateMetricConfigResponse"/></returns>
        public CreateMetricConfigResponse CreateMetricConfigSync(CreateMetricConfigRequest req)
        {
            return InternalRequestAsync<CreateMetricConfigResponse>(req, "CreateMetricConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateMetricSubscribeRequest"/></param>
        /// <returns><see cref="CreateMetricSubscribeResponse"/></returns>
        public Task<CreateMetricSubscribeResponse> CreateMetricSubscribe(CreateMetricSubscribeRequest req)
        {
            return InternalRequestAsync<CreateMetricSubscribeResponse>(req, "CreateMetricSubscribe");
        }

        /// <summary>
        /// This API is used to create metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateMetricSubscribeRequest"/></param>
        /// <returns><see cref="CreateMetricSubscribeResponse"/></returns>
        public CreateMetricSubscribeResponse CreateMetricSubscribeSync(CreateMetricSubscribeRequest req)
        {
            return InternalRequestAsync<CreateMetricSubscribeResponse>(req, "CreateMetricSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a network application.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkApplicationRequest"/></param>
        /// <returns><see cref="CreateNetworkApplicationResponse"/></returns>
        public Task<CreateNetworkApplicationResponse> CreateNetworkApplication(CreateNetworkApplicationRequest req)
        {
            return InternalRequestAsync<CreateNetworkApplicationResponse>(req, "CreateNetworkApplication");
        }

        /// <summary>
        /// This API is used to create a network application.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkApplicationRequest"/></param>
        /// <returns><see cref="CreateNetworkApplicationResponse"/></returns>
        public CreateNetworkApplicationResponse CreateNetworkApplicationSync(CreateNetworkApplicationRequest req)
        {
            return InternalRequestAsync<CreateNetworkApplicationResponse>(req, "CreateNetworkApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create notification content.
        /// </summary>
        /// <param name="req"><see cref="CreateNoticeContentRequest"/></param>
        /// <returns><see cref="CreateNoticeContentResponse"/></returns>
        public Task<CreateNoticeContentResponse> CreateNoticeContent(CreateNoticeContentRequest req)
        {
            return InternalRequestAsync<CreateNoticeContentResponse>(req, "CreateNoticeContent");
        }

        /// <summary>
        /// This API is used to create notification content.
        /// </summary>
        /// <param name="req"><see cref="CreateNoticeContentRequest"/></param>
        /// <returns><see cref="CreateNoticeContentResponse"/></returns>
        public CreateNoticeContentResponse CreateNoticeContentSync(CreateNoticeContentRequest req)
        {
            return InternalRequestAsync<CreateNoticeContentResponse>(req, "CreateNoticeContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to creates rebuild index tasks.
        /// Note:
        /// -A single log topic allows only one index reconstruction task at a time and can have up to 10 rebuild index task records. Delete task records that are no longer needed before creating an index task.
        /// -Logs within the same time range only allow rebuilding indexes once. Delete previous task records before rebuilding again.
        /// -Deleting a rebuild index task record restores the index data before rebuilding an index.
        /// -The log write traffic of the selected time range cannot exceed 5TB.
        /// -The index rebuilding time range is subject to the log time. When the log uploading time has a deviation exceeding one hour from the index rebuilding time range (for example, reporting a new log at 16:00 for 02:00 to CLS and rebuilding the log index for 00:00–12:00), the logs will not be rebuilt and cannot be retrieved subsequently. When reporting a new log to the reconstructed log time range, it will not be rebuilt and cannot be retrieved subsequently.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildIndexTaskRequest"/></param>
        /// <returns><see cref="CreateRebuildIndexTaskResponse"/></returns>
        public Task<CreateRebuildIndexTaskResponse> CreateRebuildIndexTask(CreateRebuildIndexTaskRequest req)
        {
            return InternalRequestAsync<CreateRebuildIndexTaskResponse>(req, "CreateRebuildIndexTask");
        }

        /// <summary>
        /// This API is used to creates rebuild index tasks.
        /// Note:
        /// -A single log topic allows only one index reconstruction task at a time and can have up to 10 rebuild index task records. Delete task records that are no longer needed before creating an index task.
        /// -Logs within the same time range only allow rebuilding indexes once. Delete previous task records before rebuilding again.
        /// -Deleting a rebuild index task record restores the index data before rebuilding an index.
        /// -The log write traffic of the selected time range cannot exceed 5TB.
        /// -The index rebuilding time range is subject to the log time. When the log uploading time has a deviation exceeding one hour from the index rebuilding time range (for example, reporting a new log at 16:00 for 02:00 to CLS and rebuilding the log index for 00:00–12:00), the logs will not be rebuilt and cannot be retrieved subsequently. When reporting a new log to the reconstructed log time range, it will not be rebuilt and cannot be retrieved subsequently.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildIndexTaskRequest"/></param>
        /// <returns><see cref="CreateRebuildIndexTaskResponse"/></returns>
        public CreateRebuildIndexTaskResponse CreateRebuildIndexTaskSync(CreateRebuildIndexTaskRequest req)
        {
            return InternalRequestAsync<CreateRebuildIndexTaskResponse>(req, "CreateRebuildIndexTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creating a Metric Pre-Aggregation Task
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleTaskResponse"/></returns>
        public Task<CreateRecordingRuleTaskResponse> CreateRecordingRuleTask(CreateRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleTaskResponse>(req, "CreateRecordingRuleTask");
        }

        /// <summary>
        /// Creating a Metric Pre-Aggregation Task
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleTaskResponse"/></returns>
        public CreateRecordingRuleTaskResponse CreateRecordingRuleTaskSync(CreateRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleTaskResponse>(req, "CreateRecordingRuleTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creating a Metric Pre-Aggregation Task Through a YAML File
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleYamlTaskResponse"/></returns>
        public Task<CreateRecordingRuleYamlTaskResponse> CreateRecordingRuleYamlTask(CreateRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleYamlTaskResponse>(req, "CreateRecordingRuleYamlTask");
        }

        /// <summary>
        /// Creating a Metric Pre-Aggregation Task Through a YAML File
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleYamlTaskResponse"/></returns>
        public CreateRecordingRuleYamlTaskResponse CreateRecordingRuleYamlTaskSync(CreateRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleYamlTaskResponse>(req, "CreateRecordingRuleYamlTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a scheduled SQL analysis task.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledSqlRequest"/></param>
        /// <returns><see cref="CreateScheduledSqlResponse"/></returns>
        public Task<CreateScheduledSqlResponse> CreateScheduledSql(CreateScheduledSqlRequest req)
        {
            return InternalRequestAsync<CreateScheduledSqlResponse>(req, "CreateScheduledSql");
        }

        /// <summary>
        /// This API is used to create a scheduled SQL analysis task.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledSqlRequest"/></param>
        /// <returns><see cref="CreateScheduledSqlResponse"/></returns>
        public CreateScheduledSqlResponse CreateScheduledSqlSync(CreateScheduledSqlRequest req)
        {
            return InternalRequestAsync<CreateScheduledSqlResponse>(req, "CreateScheduledSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a query view
        /// </summary>
        /// <param name="req"><see cref="CreateSearchViewRequest"/></param>
        /// <returns><see cref="CreateSearchViewResponse"/></returns>
        public Task<CreateSearchViewResponse> CreateSearchView(CreateSearchViewRequest req)
        {
            return InternalRequestAsync<CreateSearchViewResponse>(req, "CreateSearchView");
        }

        /// <summary>
        /// Create a query view
        /// </summary>
        /// <param name="req"><see cref="CreateSearchViewRequest"/></param>
        /// <returns><see cref="CreateSearchViewResponse"/></returns>
        public CreateSearchViewResponse CreateSearchViewSync(CreateSearchViewRequest req)
        {
            return InternalRequestAsync<CreateSearchViewResponse>(req, "CreateSearchView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to ship to COS. Note: To use this API, you need to check whether you have configured the role and permission for shipping to COS. If not, see **Viewing and Configuring Shipping Authorization** at https://intl.cloud.tencent.com/document/product/614/71623.?from_cn_redirect=1
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public Task<CreateShipperResponse> CreateShipper(CreateShipperRequest req)
        {
            return InternalRequestAsync<CreateShipperResponse>(req, "CreateShipper");
        }

        /// <summary>
        /// This API is used to create a task to ship to COS. Note: To use this API, you need to check whether you have configured the role and permission for shipping to COS. If not, see **Viewing and Configuring Shipping Authorization** at https://intl.cloud.tencent.com/document/product/614/71623.?from_cn_redirect=1
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public CreateShipperResponse CreateShipperSync(CreateShipperRequest req)
        {
            return InternalRequestAsync<CreateShipperResponse>(req, "CreateShipper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Splunk delivery task
        /// </summary>
        /// <param name="req"><see cref="CreateSplunkDeliverRequest"/></param>
        /// <returns><see cref="CreateSplunkDeliverResponse"/></returns>
        public Task<CreateSplunkDeliverResponse> CreateSplunkDeliver(CreateSplunkDeliverRequest req)
        {
            return InternalRequestAsync<CreateSplunkDeliverResponse>(req, "CreateSplunkDeliver");
        }

        /// <summary>
        /// Create a Splunk delivery task
        /// </summary>
        /// <param name="req"><see cref="CreateSplunkDeliverRequest"/></param>
        /// <returns><see cref="CreateSplunkDeliverResponse"/></returns>
        public CreateSplunkDeliverResponse CreateSplunkDeliverSync(CreateSplunkDeliverRequest req)
        {
            return InternalRequestAsync<CreateSplunkDeliverResponse>(req, "CreateSplunkDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create logs or metric topics.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// This API is used to create logs or metric topics.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create alarm channel callback configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWebCallbackRequest"/></param>
        /// <returns><see cref="CreateWebCallbackResponse"/></returns>
        public Task<CreateWebCallbackResponse> CreateWebCallback(CreateWebCallbackRequest req)
        {
            return InternalRequestAsync<CreateWebCallbackResponse>(req, "CreateWebCallback");
        }

        /// <summary>
        /// This API is used to create alarm channel callback configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWebCallbackRequest"/></param>
        /// <returns><see cref="CreateWebCallbackResponse"/></returns>
        public CreateWebCallbackResponse CreateWebCallbackSync(CreateWebCallbackRequest req)
        {
            return InternalRequestAsync<CreateWebCallbackResponse>(req, "CreateWebCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public Task<DeleteAlarmResponse> DeleteAlarm(DeleteAlarmRequest req)
        {
            return InternalRequestAsync<DeleteAlarmResponse>(req, "DeleteAlarm");
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public DeleteAlarmResponse DeleteAlarmSync(DeleteAlarmRequest req)
        {
            return InternalRequestAsync<DeleteAlarmResponse>(req, "DeleteAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a notification group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public Task<DeleteAlarmNoticeResponse> DeleteAlarmNotice(DeleteAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticeResponse>(req, "DeleteAlarmNotice");
        }

        /// <summary>
        /// This API is used to delete a notification group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public DeleteAlarmNoticeResponse DeleteAlarmNoticeSync(DeleteAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticeResponse>(req, "DeleteAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alarm blocking rule. When the alarm blocking rule is active or invalid, it cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmShieldRequest"/></param>
        /// <returns><see cref="DeleteAlarmShieldResponse"/></returns>
        public Task<DeleteAlarmShieldResponse> DeleteAlarmShield(DeleteAlarmShieldRequest req)
        {
            return InternalRequestAsync<DeleteAlarmShieldResponse>(req, "DeleteAlarmShield");
        }

        /// <summary>
        /// This API is used to delete an alarm blocking rule. When the alarm blocking rule is active or invalid, it cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmShieldRequest"/></param>
        /// <returns><see cref="DeleteAlarmShieldResponse"/></returns>
        public DeleteAlarmShieldResponse DeleteAlarmShieldSync(DeleteAlarmShieldRequest req)
        {
            return InternalRequestAsync<DeleteAlarmShieldResponse>(req, "DeleteAlarmShield")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud product integration uses internal APIs
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudProductLogCollectionRequest"/></param>
        /// <returns><see cref="DeleteCloudProductLogCollectionResponse"/></returns>
        public Task<DeleteCloudProductLogCollectionResponse> DeleteCloudProductLogCollection(DeleteCloudProductLogCollectionRequest req)
        {
            return InternalRequestAsync<DeleteCloudProductLogCollectionResponse>(req, "DeleteCloudProductLogCollection");
        }

        /// <summary>
        /// Cloud product integration uses internal APIs
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudProductLogCollectionRequest"/></param>
        /// <returns><see cref="DeleteCloudProductLogCollectionResponse"/></returns>
        public DeleteCloudProductLogCollectionResponse DeleteCloudProductLogCollectionSync(DeleteCloudProductLogCollectionRequest req)
        {
            return InternalRequestAsync<DeleteCloudProductLogCollectionResponse>(req, "DeleteCloudProductLogCollection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public Task<DeleteConfigResponse> DeleteConfig(DeleteConfigRequest req)
        {
            return InternalRequestAsync<DeleteConfigResponse>(req, "DeleteConfig");
        }

        /// <summary>
        /// This API is used to delete collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public DeleteConfigResponse DeleteConfigSync(DeleteConfigRequest req)
        {
            return InternalRequestAsync<DeleteConfigResponse>(req, "DeleteConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the collection configuration applied to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public Task<DeleteConfigFromMachineGroupResponse> DeleteConfigFromMachineGroup(DeleteConfigFromMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteConfigFromMachineGroupResponse>(req, "DeleteConfigFromMachineGroup");
        }

        /// <summary>
        /// This API is used to delete the collection configuration applied to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public DeleteConfigFromMachineGroupResponse DeleteConfigFromMachineGroupSync(DeleteConfigFromMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteConfigFromMachineGroupResponse>(req, "DeleteConfigFromMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the DataSight Console
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleRequest"/></param>
        /// <returns><see cref="DeleteConsoleResponse"/></returns>
        public Task<DeleteConsoleResponse> DeleteConsole(DeleteConsoleRequest req)
        {
            return InternalRequestAsync<DeleteConsoleResponse>(req, "DeleteConsole");
        }

        /// <summary>
        /// This API is used to delete the DataSight Console
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleRequest"/></param>
        /// <returns><see cref="DeleteConsoleResponse"/></returns>
        public DeleteConsoleResponse DeleteConsoleSync(DeleteConsoleRequest req)
        {
            return InternalRequestAsync<DeleteConsoleResponse>(req, "DeleteConsole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deleting a CKafka Delivery Task
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public Task<DeleteConsumerResponse> DeleteConsumer(DeleteConsumerRequest req)
        {
            return InternalRequestAsync<DeleteConsumerResponse>(req, "DeleteConsumer");
        }

        /// <summary>
        /// Deleting a CKafka Delivery Task
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public DeleteConsumerResponse DeleteConsumerSync(DeleteConsumerRequest req)
        {
            return InternalRequestAsync<DeleteConsumerResponse>(req, "DeleteConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete consumer groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public Task<DeleteConsumerGroupResponse> DeleteConsumerGroup(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup");
        }

        /// <summary>
        /// Delete consumer groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroupSync(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cos Import Task.
        /// </summary>
        /// <param name="req"><see cref="DeleteCosRechargeRequest"/></param>
        /// <returns><see cref="DeleteCosRechargeResponse"/></returns>
        public Task<DeleteCosRechargeResponse> DeleteCosRecharge(DeleteCosRechargeRequest req)
        {
            return InternalRequestAsync<DeleteCosRechargeResponse>(req, "DeleteCosRecharge");
        }

        /// <summary>
        /// This API is used to delete a cos Import Task.
        /// </summary>
        /// <param name="req"><see cref="DeleteCosRechargeRequest"/></param>
        /// <returns><see cref="DeleteCosRechargeResponse"/></returns>
        public DeleteCosRechargeResponse DeleteCosRechargeSync(DeleteCosRechargeRequest req)
        {
            return InternalRequestAsync<DeleteCosRechargeResponse>(req, "DeleteCosRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete dashboards.
        /// </summary>
        /// <param name="req"><see cref="DeleteDashboardRequest"/></param>
        /// <returns><see cref="DeleteDashboardResponse"/></returns>
        public Task<DeleteDashboardResponse> DeleteDashboard(DeleteDashboardRequest req)
        {
            return InternalRequestAsync<DeleteDashboardResponse>(req, "DeleteDashboard");
        }

        /// <summary>
        /// This API is used to delete dashboards.
        /// </summary>
        /// <param name="req"><see cref="DeleteDashboardRequest"/></param>
        /// <returns><see cref="DeleteDashboardResponse"/></returns>
        public DeleteDashboardResponse DeleteDashboardSync(DeleteDashboardRequest req)
        {
            return InternalRequestAsync<DeleteDashboardResponse>(req, "DeleteDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete dashboard subscriptions.
        /// </summary>
        /// <param name="req"><see cref="DeleteDashboardSubscribeRequest"/></param>
        /// <returns><see cref="DeleteDashboardSubscribeResponse"/></returns>
        public Task<DeleteDashboardSubscribeResponse> DeleteDashboardSubscribe(DeleteDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteDashboardSubscribeResponse>(req, "DeleteDashboardSubscribe");
        }

        /// <summary>
        /// This API is used to delete dashboard subscriptions.
        /// </summary>
        /// <param name="req"><see cref="DeleteDashboardSubscribeRequest"/></param>
        /// <returns><see cref="DeleteDashboardSubscribeResponse"/></returns>
        public DeleteDashboardSubscribeResponse DeleteDashboardSubscribeSync(DeleteDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteDashboardSubscribeResponse>(req, "DeleteDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a data processing task.
        /// </summary>
        /// <param name="req"><see cref="DeleteDataTransformRequest"/></param>
        /// <returns><see cref="DeleteDataTransformResponse"/></returns>
        public Task<DeleteDataTransformResponse> DeleteDataTransform(DeleteDataTransformRequest req)
        {
            return InternalRequestAsync<DeleteDataTransformResponse>(req, "DeleteDataTransform");
        }

        /// <summary>
        /// This API is used to delete a data processing task.
        /// </summary>
        /// <param name="req"><see cref="DeleteDataTransformRequest"/></param>
        /// <returns><see cref="DeleteDataTransformResponse"/></returns>
        public DeleteDataTransformResponse DeleteDataTransformSync(DeleteDataTransformRequest req)
        {
            return InternalRequestAsync<DeleteDataTransformResponse>(req, "DeleteDataTransform")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a DLC delivery task
        /// </summary>
        /// <param name="req"><see cref="DeleteDlcDeliverRequest"/></param>
        /// <returns><see cref="DeleteDlcDeliverResponse"/></returns>
        public Task<DeleteDlcDeliverResponse> DeleteDlcDeliver(DeleteDlcDeliverRequest req)
        {
            return InternalRequestAsync<DeleteDlcDeliverResponse>(req, "DeleteDlcDeliver");
        }

        /// <summary>
        /// Delete a DLC delivery task
        /// </summary>
        /// <param name="req"><see cref="DeleteDlcDeliverRequest"/></param>
        /// <returns><see cref="DeleteDlcDeliverResponse"/></returns>
        public DeleteDlcDeliverResponse DeleteDlcDeliverSync(DeleteDlcDeliverRequest req)
        {
            return InternalRequestAsync<DeleteDlcDeliverResponse>(req, "DeleteDlcDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete es import configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteEsRechargeRequest"/></param>
        /// <returns><see cref="DeleteEsRechargeResponse"/></returns>
        public Task<DeleteEsRechargeResponse> DeleteEsRecharge(DeleteEsRechargeRequest req)
        {
            return InternalRequestAsync<DeleteEsRechargeResponse>(req, "DeleteEsRecharge");
        }

        /// <summary>
        /// Delete es import configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteEsRechargeRequest"/></param>
        /// <returns><see cref="DeleteEsRechargeResponse"/></returns>
        public DeleteEsRechargeResponse DeleteEsRechargeSync(DeleteEsRechargeRequest req)
        {
            return InternalRequestAsync<DeleteEsRechargeResponse>(req, "DeleteEsRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a log download task.
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public Task<DeleteExportResponse> DeleteExport(DeleteExportRequest req)
        {
            return InternalRequestAsync<DeleteExportResponse>(req, "DeleteExport");
        }

        /// <summary>
        /// This API is used to delete a log download task.
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public DeleteExportResponse DeleteExportSync(DeleteExportRequest req)
        {
            return InternalRequestAsync<DeleteExportResponse>(req, "DeleteExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete host metric collection configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteHostMetricConfigRequest"/></param>
        /// <returns><see cref="DeleteHostMetricConfigResponse"/></returns>
        public Task<DeleteHostMetricConfigResponse> DeleteHostMetricConfig(DeleteHostMetricConfigRequest req)
        {
            return InternalRequestAsync<DeleteHostMetricConfigResponse>(req, "DeleteHostMetricConfig");
        }

        /// <summary>
        /// Delete host metric collection configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteHostMetricConfigRequest"/></param>
        /// <returns><see cref="DeleteHostMetricConfigResponse"/></returns>
        public DeleteHostMetricConfigResponse DeleteHostMetricConfigSync(DeleteHostMetricConfigRequest req)
        {
            return InternalRequestAsync<DeleteHostMetricConfigResponse>(req, "DeleteHostMetricConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the index configuration of a log topic. After deleting, you cannot retrieve or query the collected logs.
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex");
        }

        /// <summary>
        /// This API is used to delete the index configuration of a log topic. After deleting, you cannot retrieve or query the collected logs.
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Kafka data subscription task.
        /// </summary>
        /// <param name="req"><see cref="DeleteKafkaRechargeRequest"/></param>
        /// <returns><see cref="DeleteKafkaRechargeResponse"/></returns>
        public Task<DeleteKafkaRechargeResponse> DeleteKafkaRecharge(DeleteKafkaRechargeRequest req)
        {
            return InternalRequestAsync<DeleteKafkaRechargeResponse>(req, "DeleteKafkaRecharge");
        }

        /// <summary>
        /// This API is used to delete a Kafka data subscription task.
        /// </summary>
        /// <param name="req"><see cref="DeleteKafkaRechargeRequest"/></param>
        /// <returns><see cref="DeleteKafkaRechargeResponse"/></returns>
        public DeleteKafkaRechargeResponse DeleteKafkaRechargeSync(DeleteKafkaRechargeRequest req)
        {
            return InternalRequestAsync<DeleteKafkaRechargeResponse>(req, "DeleteKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a logset.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public Task<DeleteLogsetResponse> DeleteLogset(DeleteLogsetRequest req)
        {
            return InternalRequestAsync<DeleteLogsetResponse>(req, "DeleteLogset");
        }

        /// <summary>
        /// This API is used to delete a logset.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public DeleteLogsetResponse DeleteLogsetSync(DeleteLogsetRequest req)
        {
            return InternalRequestAsync<DeleteLogsetResponse>(req, "DeleteLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public Task<DeleteMachineGroupResponse> DeleteMachineGroup(DeleteMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupResponse>(req, "DeleteMachineGroup");
        }

        /// <summary>
        /// This API is used to delete a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public DeleteMachineGroupResponse DeleteMachineGroupSync(DeleteMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupResponse>(req, "DeleteMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete machine group information.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupInfoRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupInfoResponse"/></returns>
        public Task<DeleteMachineGroupInfoResponse> DeleteMachineGroupInfo(DeleteMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupInfoResponse>(req, "DeleteMachineGroupInfo");
        }

        /// <summary>
        /// This API is used to delete machine group information.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupInfoRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupInfoResponse"/></returns>
        public DeleteMachineGroupInfoResponse DeleteMachineGroupInfoSync(DeleteMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupInfoResponse>(req, "DeleteMachineGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteMetricConfigRequest"/></param>
        /// <returns><see cref="DeleteMetricConfigResponse"/></returns>
        public Task<DeleteMetricConfigResponse> DeleteMetricConfig(DeleteMetricConfigRequest req)
        {
            return InternalRequestAsync<DeleteMetricConfigResponse>(req, "DeleteMetricConfig");
        }

        /// <summary>
        /// This API is used to delete metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteMetricConfigRequest"/></param>
        /// <returns><see cref="DeleteMetricConfigResponse"/></returns>
        public DeleteMetricConfigResponse DeleteMetricConfigSync(DeleteMetricConfigRequest req)
        {
            return InternalRequestAsync<DeleteMetricConfigResponse>(req, "DeleteMetricConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteMetricSubscribeRequest"/></param>
        /// <returns><see cref="DeleteMetricSubscribeResponse"/></returns>
        public Task<DeleteMetricSubscribeResponse> DeleteMetricSubscribe(DeleteMetricSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteMetricSubscribeResponse>(req, "DeleteMetricSubscribe");
        }

        /// <summary>
        /// This API is used to delete metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteMetricSubscribeRequest"/></param>
        /// <returns><see cref="DeleteMetricSubscribeResponse"/></returns>
        public DeleteMetricSubscribeResponse DeleteMetricSubscribeSync(DeleteMetricSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteMetricSubscribeResponse>(req, "DeleteMetricSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a web application
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkApplicationRequest"/></param>
        /// <returns><see cref="DeleteNetworkApplicationResponse"/></returns>
        public Task<DeleteNetworkApplicationResponse> DeleteNetworkApplication(DeleteNetworkApplicationRequest req)
        {
            return InternalRequestAsync<DeleteNetworkApplicationResponse>(req, "DeleteNetworkApplication");
        }

        /// <summary>
        /// Delete a web application
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkApplicationRequest"/></param>
        /// <returns><see cref="DeleteNetworkApplicationResponse"/></returns>
        public DeleteNetworkApplicationResponse DeleteNetworkApplicationSync(DeleteNetworkApplicationRequest req)
        {
            return InternalRequestAsync<DeleteNetworkApplicationResponse>(req, "DeleteNetworkApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete notification content configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteNoticeContentRequest"/></param>
        /// <returns><see cref="DeleteNoticeContentResponse"/></returns>
        public Task<DeleteNoticeContentResponse> DeleteNoticeContent(DeleteNoticeContentRequest req)
        {
            return InternalRequestAsync<DeleteNoticeContentResponse>(req, "DeleteNoticeContent");
        }

        /// <summary>
        /// This API is used to delete notification content configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteNoticeContentRequest"/></param>
        /// <returns><see cref="DeleteNoticeContentResponse"/></returns>
        public DeleteNoticeContentResponse DeleteNoticeContentSync(DeleteNoticeContentRequest req)
        {
            return InternalRequestAsync<DeleteNoticeContentResponse>(req, "DeleteNoticeContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a pre-aggregation analysis task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordingRuleTaskResponse"/></returns>
        public Task<DeleteRecordingRuleTaskResponse> DeleteRecordingRuleTask(DeleteRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRuleTaskResponse>(req, "DeleteRecordingRuleTask");
        }

        /// <summary>
        /// This API is used to delete a pre-aggregation analysis task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordingRuleTaskResponse"/></returns>
        public DeleteRecordingRuleTaskResponse DeleteRecordingRuleTaskSync(DeleteRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRuleTaskResponse>(req, "DeleteRecordingRuleTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the pre-aggregation task in yaml.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordingRuleYamlTaskResponse"/></returns>
        public Task<DeleteRecordingRuleYamlTaskResponse> DeleteRecordingRuleYamlTask(DeleteRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRuleYamlTaskResponse>(req, "DeleteRecordingRuleYamlTask");
        }

        /// <summary>
        /// This API is used to delete the pre-aggregation task in yaml.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordingRuleYamlTaskResponse"/></returns>
        public DeleteRecordingRuleYamlTaskResponse DeleteRecordingRuleYamlTaskSync(DeleteRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRuleYamlTaskResponse>(req, "DeleteRecordingRuleYamlTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a scheduled SQL analysis task.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledSqlRequest"/></param>
        /// <returns><see cref="DeleteScheduledSqlResponse"/></returns>
        public Task<DeleteScheduledSqlResponse> DeleteScheduledSql(DeleteScheduledSqlRequest req)
        {
            return InternalRequestAsync<DeleteScheduledSqlResponse>(req, "DeleteScheduledSql");
        }

        /// <summary>
        /// This API is used to delete a scheduled SQL analysis task.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledSqlRequest"/></param>
        /// <returns><see cref="DeleteScheduledSqlResponse"/></returns>
        public DeleteScheduledSqlResponse DeleteScheduledSqlSync(DeleteScheduledSqlRequest req)
        {
            return InternalRequestAsync<DeleteScheduledSqlResponse>(req, "DeleteScheduledSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a query view.
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchViewRequest"/></param>
        /// <returns><see cref="DeleteSearchViewResponse"/></returns>
        public Task<DeleteSearchViewResponse> DeleteSearchView(DeleteSearchViewRequest req)
        {
            return InternalRequestAsync<DeleteSearchViewResponse>(req, "DeleteSearchView");
        }

        /// <summary>
        /// This API is used to delete a query view.
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchViewRequest"/></param>
        /// <returns><see cref="DeleteSearchViewResponse"/></returns>
        public DeleteSearchViewResponse DeleteSearchViewSync(DeleteSearchViewRequest req)
        {
            return InternalRequestAsync<DeleteSearchViewResponse>(req, "DeleteSearchView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a COS shipping task.
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public Task<DeleteShipperResponse> DeleteShipper(DeleteShipperRequest req)
        {
            return InternalRequestAsync<DeleteShipperResponse>(req, "DeleteShipper");
        }

        /// <summary>
        /// This API is used to delete a COS shipping task.
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public DeleteShipperResponse DeleteShipperSync(DeleteShipperRequest req)
        {
            return InternalRequestAsync<DeleteShipperResponse>(req, "DeleteShipper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Splunk delivery task
        /// </summary>
        /// <param name="req"><see cref="DeleteSplunkDeliverRequest"/></param>
        /// <returns><see cref="DeleteSplunkDeliverResponse"/></returns>
        public Task<DeleteSplunkDeliverResponse> DeleteSplunkDeliver(DeleteSplunkDeliverRequest req)
        {
            return InternalRequestAsync<DeleteSplunkDeliverResponse>(req, "DeleteSplunkDeliver");
        }

        /// <summary>
        /// Delete a Splunk delivery task
        /// </summary>
        /// <param name="req"><see cref="DeleteSplunkDeliverRequest"/></param>
        /// <returns><see cref="DeleteSplunkDeliverResponse"/></returns>
        public DeleteSplunkDeliverResponse DeleteSplunkDeliverSync(DeleteSplunkDeliverRequest req)
        {
            return InternalRequestAsync<DeleteSplunkDeliverResponse>(req, "DeleteSplunkDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete logs or metric topics.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// This API is used to delete logs or metric topics.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete alarm channel callback configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebCallbackRequest"/></param>
        /// <returns><see cref="DeleteWebCallbackResponse"/></returns>
        public Task<DeleteWebCallbackResponse> DeleteWebCallback(DeleteWebCallbackRequest req)
        {
            return InternalRequestAsync<DeleteWebCallbackResponse>(req, "DeleteWebCallback");
        }

        /// <summary>
        /// This API is used to delete alarm channel callback configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebCallbackRequest"/></param>
        /// <returns><see cref="DeleteWebCallbackResponse"/></returns>
        public DeleteWebCallbackResponse DeleteWebCallbackSync(DeleteWebCallbackRequest req)
        {
            return InternalRequestAsync<DeleteWebCallbackResponse>(req, "DeleteWebCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the notification group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public Task<DescribeAlarmNoticesResponse> DescribeAlarmNotices(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices");
        }

        /// <summary>
        /// This API is used to get the notification group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public DescribeAlarmNoticesResponse DescribeAlarmNoticesSync(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access alarm blocking configuration rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmShieldsRequest"/></param>
        /// <returns><see cref="DescribeAlarmShieldsResponse"/></returns>
        public Task<DescribeAlarmShieldsResponse> DescribeAlarmShields(DescribeAlarmShieldsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmShieldsResponse>(req, "DescribeAlarmShields");
        }

        /// <summary>
        /// This API is used to access alarm blocking configuration rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmShieldsRequest"/></param>
        /// <returns><see cref="DescribeAlarmShieldsResponse"/></returns>
        public DescribeAlarmShieldsResponse DescribeAlarmShieldsSync(DescribeAlarmShieldsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmShieldsResponse>(req, "DescribeAlarmShields")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the alarm policy list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public Task<DescribeAlarmsResponse> DescribeAlarms(DescribeAlarmsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmsResponse>(req, "DescribeAlarms");
        }

        /// <summary>
        /// This API is used to get the alarm policy list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public DescribeAlarmsResponse DescribeAlarmsSync(DescribeAlarmsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmsResponse>(req, "DescribeAlarms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get alarm records, such as today's uncleared alarms.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordHistoryRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordHistoryResponse"/></returns>
        public Task<DescribeAlertRecordHistoryResponse> DescribeAlertRecordHistory(DescribeAlertRecordHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAlertRecordHistoryResponse>(req, "DescribeAlertRecordHistory");
        }

        /// <summary>
        /// This API is used to get alarm records, such as today's uncleared alarms.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordHistoryRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordHistoryResponse"/></returns>
        public DescribeAlertRecordHistoryResponse DescribeAlertRecordHistorySync(DescribeAlertRecordHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAlertRecordHistoryResponse>(req, "DescribeAlertRecordHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud product integration uses relevant APIs
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudProductLogTasksRequest"/></param>
        /// <returns><see cref="DescribeCloudProductLogTasksResponse"/></returns>
        public Task<DescribeCloudProductLogTasksResponse> DescribeCloudProductLogTasks(DescribeCloudProductLogTasksRequest req)
        {
            return InternalRequestAsync<DescribeCloudProductLogTasksResponse>(req, "DescribeCloudProductLogTasks");
        }

        /// <summary>
        /// Cloud product integration uses relevant APIs
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudProductLogTasksRequest"/></param>
        /// <returns><see cref="DescribeCloudProductLogTasksResponse"/></returns>
        public DescribeCloudProductLogTasksResponse DescribeCloudProductLogTasksSync(DescribeCloudProductLogTasksRequest req)
        {
            return InternalRequestAsync<DescribeCloudProductLogTasksResponse>(req, "DescribeCloudProductLogTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterBaseMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterBaseMetricConfigsResponse"/></returns>
        public Task<DescribeClusterBaseMetricConfigsResponse> DescribeClusterBaseMetricConfigs(DescribeClusterBaseMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterBaseMetricConfigsResponse>(req, "DescribeClusterBaseMetricConfigs");
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterBaseMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterBaseMetricConfigsResponse"/></returns>
        public DescribeClusterBaseMetricConfigsResponse DescribeClusterBaseMetricConfigsSync(DescribeClusterBaseMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterBaseMetricConfigsResponse>(req, "DescribeClusterBaseMetricConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterMetricConfigsResponse"/></returns>
        public Task<DescribeClusterMetricConfigsResponse> DescribeClusterMetricConfigs(DescribeClusterMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterMetricConfigsResponse>(req, "DescribeClusterMetricConfigs");
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterMetricConfigsResponse"/></returns>
        public DescribeClusterMetricConfigsResponse DescribeClusterMetricConfigsSync(DescribeClusterMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterMetricConfigsResponse>(req, "DescribeClusterMetricConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the machine group bound to collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public Task<DescribeConfigMachineGroupsResponse> DescribeConfigMachineGroups(DescribeConfigMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConfigMachineGroupsResponse>(req, "DescribeConfigMachineGroups");
        }

        /// <summary>
        /// This API is used to get the machine group bound to collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public DescribeConfigMachineGroupsResponse DescribeConfigMachineGroupsSync(DescribeConfigMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConfigMachineGroupsResponse>(req, "DescribeConfigMachineGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public Task<DescribeConfigsResponse> DescribeConfigs(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs");
        }

        /// <summary>
        /// This API is used to get collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public DescribeConfigsResponse DescribeConfigsSync(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the DataSight console instance list
        /// </summary>
        /// <param name="req"><see cref="DescribeConsolesRequest"/></param>
        /// <returns><see cref="DescribeConsolesResponse"/></returns>
        public Task<DescribeConsolesResponse> DescribeConsoles(DescribeConsolesRequest req)
        {
            return InternalRequestAsync<DescribeConsolesResponse>(req, "DescribeConsoles");
        }

        /// <summary>
        /// Query the DataSight console instance list
        /// </summary>
        /// <param name="req"><see cref="DescribeConsolesRequest"/></param>
        /// <returns><see cref="DescribeConsolesResponse"/></returns>
        public DescribeConsolesResponse DescribeConsolesSync(DescribeConsolesRequest req)
        {
            return InternalRequestAsync<DescribeConsolesResponse>(req, "DescribeConsoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerRequest"/></param>
        /// <returns><see cref="DescribeConsumerResponse"/></returns>
        public Task<DescribeConsumerResponse> DescribeConsumer(DescribeConsumerRequest req)
        {
            return InternalRequestAsync<DescribeConsumerResponse>(req, "DescribeConsumer");
        }

        /// <summary>
        /// This API is used to query a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerRequest"/></param>
        /// <returns><see cref="DescribeConsumerResponse"/></returns>
        public DescribeConsumerResponse DescribeConsumerSync(DescribeConsumerRequest req)
        {
            return InternalRequestAsync<DescribeConsumerResponse>(req, "DescribeConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the consumer group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupsRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupsResponse"/></returns>
        public Task<DescribeConsumerGroupsResponse> DescribeConsumerGroups(DescribeConsumerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupsResponse>(req, "DescribeConsumerGroups");
        }

        /// <summary>
        /// This API is used to obtain the consumer group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupsRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupsResponse"/></returns>
        public DescribeConsumerGroupsResponse DescribeConsumerGroupsSync(DescribeConsumerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupsResponse>(req, "DescribeConsumerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtaining the Consumer Group Point Information
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerOffsetsRequest"/></param>
        /// <returns><see cref="DescribeConsumerOffsetsResponse"/></returns>
        public Task<DescribeConsumerOffsetsResponse> DescribeConsumerOffsets(DescribeConsumerOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerOffsetsResponse>(req, "DescribeConsumerOffsets");
        }

        /// <summary>
        /// Obtaining the Consumer Group Point Information
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerOffsetsRequest"/></param>
        /// <returns><see cref="DescribeConsumerOffsetsResponse"/></returns>
        public DescribeConsumerOffsetsResponse DescribeConsumerOffsetsSync(DescribeConsumerOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerOffsetsResponse>(req, "DescribeConsumerOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview Kafka shipping data.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerPreviewRequest"/></param>
        /// <returns><see cref="DescribeConsumerPreviewResponse"/></returns>
        public Task<DescribeConsumerPreviewResponse> DescribeConsumerPreview(DescribeConsumerPreviewRequest req)
        {
            return InternalRequestAsync<DescribeConsumerPreviewResponse>(req, "DescribeConsumerPreview");
        }

        /// <summary>
        /// This API is used to preview Kafka shipping data.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerPreviewRequest"/></param>
        /// <returns><see cref="DescribeConsumerPreviewResponse"/></returns>
        public DescribeConsumerPreviewResponse DescribeConsumerPreviewSync(DescribeConsumerPreviewRequest req)
        {
            return InternalRequestAsync<DescribeConsumerPreviewResponse>(req, "DescribeConsumerPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the shipping rule information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumersRequest"/></param>
        /// <returns><see cref="DescribeConsumersResponse"/></returns>
        public Task<DescribeConsumersResponse> DescribeConsumers(DescribeConsumersRequest req)
        {
            return InternalRequestAsync<DescribeConsumersResponse>(req, "DescribeConsumers");
        }

        /// <summary>
        /// This API is used to obtain the shipping rule information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumersRequest"/></param>
        /// <returns><see cref="DescribeConsumersResponse"/></returns>
        public DescribeConsumersResponse DescribeConsumersSync(DescribeConsumersRequest req)
        {
            return InternalRequestAsync<DescribeConsumersResponse>(req, "DescribeConsumers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get COS import configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRechargesRequest"/></param>
        /// <returns><see cref="DescribeCosRechargesResponse"/></returns>
        public Task<DescribeCosRechargesResponse> DescribeCosRecharges(DescribeCosRechargesRequest req)
        {
            return InternalRequestAsync<DescribeCosRechargesResponse>(req, "DescribeCosRecharges");
        }

        /// <summary>
        /// This API is used to get COS import configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRechargesRequest"/></param>
        /// <returns><see cref="DescribeCosRechargesResponse"/></returns>
        public DescribeCosRechargesResponse DescribeCosRechargesSync(DescribeCosRechargesRequest req)
        {
            return InternalRequestAsync<DescribeCosRechargesResponse>(req, "DescribeCosRecharges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the dashboard subscription list, and supports paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardSubscribesRequest"/></param>
        /// <returns><see cref="DescribeDashboardSubscribesResponse"/></returns>
        public Task<DescribeDashboardSubscribesResponse> DescribeDashboardSubscribes(DescribeDashboardSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeDashboardSubscribesResponse>(req, "DescribeDashboardSubscribes");
        }

        /// <summary>
        /// This API is used to obtain the dashboard subscription list, and supports paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardSubscribesRequest"/></param>
        /// <returns><see cref="DescribeDashboardSubscribesResponse"/></returns>
        public DescribeDashboardSubscribesResponse DescribeDashboardSubscribesSync(DescribeDashboardSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeDashboardSubscribesResponse>(req, "DescribeDashboardSubscribes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the basic information of data processing tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTransformInfoRequest"/></param>
        /// <returns><see cref="DescribeDataTransformInfoResponse"/></returns>
        public Task<DescribeDataTransformInfoResponse> DescribeDataTransformInfo(DescribeDataTransformInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataTransformInfoResponse>(req, "DescribeDataTransformInfo");
        }

        /// <summary>
        /// This API is used to get the basic information of data processing tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTransformInfoRequest"/></param>
        /// <returns><see cref="DescribeDataTransformInfoResponse"/></returns>
        public DescribeDataTransformInfoResponse DescribeDataTransformInfoSync(DescribeDataTransformInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataTransformInfoResponse>(req, "DescribeDataTransformInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search alarm channel callback configuration lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeDlcDeliversRequest"/></param>
        /// <returns><see cref="DescribeDlcDeliversResponse"/></returns>
        public Task<DescribeDlcDeliversResponse> DescribeDlcDelivers(DescribeDlcDeliversRequest req)
        {
            return InternalRequestAsync<DescribeDlcDeliversResponse>(req, "DescribeDlcDelivers");
        }

        /// <summary>
        /// This API is used to search alarm channel callback configuration lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeDlcDeliversRequest"/></param>
        /// <returns><see cref="DescribeDlcDeliversResponse"/></returns>
        public DescribeDlcDeliversResponse DescribeDlcDeliversSync(DescribeDlcDeliversRequest req)
        {
            return InternalRequestAsync<DescribeDlcDeliversResponse>(req, "DescribeDlcDelivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Import Preview
        /// </summary>
        /// <param name="req"><see cref="DescribeEsRechargePreviewRequest"/></param>
        /// <returns><see cref="DescribeEsRechargePreviewResponse"/></returns>
        public Task<DescribeEsRechargePreviewResponse> DescribeEsRechargePreview(DescribeEsRechargePreviewRequest req)
        {
            return InternalRequestAsync<DescribeEsRechargePreviewResponse>(req, "DescribeEsRechargePreview");
        }

        /// <summary>
        /// Import Preview
        /// </summary>
        /// <param name="req"><see cref="DescribeEsRechargePreviewRequest"/></param>
        /// <returns><see cref="DescribeEsRechargePreviewResponse"/></returns>
        public DescribeEsRechargePreviewResponse DescribeEsRechargePreviewSync(DescribeEsRechargePreviewRequest req)
        {
            return InternalRequestAsync<DescribeEsRechargePreviewResponse>(req, "DescribeEsRechargePreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the es import configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeEsRechargesRequest"/></param>
        /// <returns><see cref="DescribeEsRechargesResponse"/></returns>
        public Task<DescribeEsRechargesResponse> DescribeEsRecharges(DescribeEsRechargesRequest req)
        {
            return InternalRequestAsync<DescribeEsRechargesResponse>(req, "DescribeEsRecharges");
        }

        /// <summary>
        /// Retrieve the es import configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeEsRechargesRequest"/></param>
        /// <returns><see cref="DescribeEsRechargesResponse"/></returns>
        public DescribeEsRechargesResponse DescribeEsRechargesSync(DescribeEsRechargesRequest req)
        {
            return InternalRequestAsync<DescribeEsRechargesResponse>(req, "DescribeEsRecharges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public Task<DescribeExportsResponse> DescribeExports(DescribeExportsRequest req)
        {
            return InternalRequestAsync<DescribeExportsResponse>(req, "DescribeExports");
        }

        /// <summary>
        /// This API is used to get the list of log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public DescribeExportsResponse DescribeExportsSync(DescribeExportsRequest req)
        {
            return InternalRequestAsync<DescribeExportsResponse>(req, "DescribeExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeHostMetricConfigsResponse"/></returns>
        public Task<DescribeHostMetricConfigsResponse> DescribeHostMetricConfigs(DescribeHostMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeHostMetricConfigsResponse>(req, "DescribeHostMetricConfigs");
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeHostMetricConfigsResponse"/></returns>
        public DescribeHostMetricConfigsResponse DescribeHostMetricConfigsSync(DescribeHostMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeHostMetricConfigsResponse>(req, "DescribeHostMetricConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the index configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public Task<DescribeIndexResponse> DescribeIndex(DescribeIndexRequest req)
        {
            return InternalRequestAsync<DescribeIndexResponse>(req, "DescribeIndex");
        }

        /// <summary>
        /// This API is used to get the index configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public DescribeIndexResponse DescribeIndexSync(DescribeIndexRequest req)
        {
            return InternalRequestAsync<DescribeIndexResponse>(req, "DescribeIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access Kafka protocol consumption information.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerResponse"/></returns>
        public Task<DescribeKafkaConsumerResponse> DescribeKafkaConsumer(DescribeKafkaConsumerRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerResponse>(req, "DescribeKafkaConsumer");
        }

        /// <summary>
        /// This API is used to access Kafka protocol consumption information.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerResponse"/></returns>
        public DescribeKafkaConsumerResponse DescribeKafkaConsumerSync(DescribeKafkaConsumerRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerResponse>(req, "DescribeKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve Kafka protocol consumption group details
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerGroupDetailResponse"/></returns>
        public Task<DescribeKafkaConsumerGroupDetailResponse> DescribeKafkaConsumerGroupDetail(DescribeKafkaConsumerGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerGroupDetailResponse>(req, "DescribeKafkaConsumerGroupDetail");
        }

        /// <summary>
        /// Retrieve Kafka protocol consumption group details
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerGroupDetailResponse"/></returns>
        public DescribeKafkaConsumerGroupDetailResponse DescribeKafkaConsumerGroupDetailSync(DescribeKafkaConsumerGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerGroupDetailResponse>(req, "DescribeKafkaConsumerGroupDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the information list of Kafka protocol consumption groups
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerGroupListRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerGroupListResponse"/></returns>
        public Task<DescribeKafkaConsumerGroupListResponse> DescribeKafkaConsumerGroupList(DescribeKafkaConsumerGroupListRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerGroupListResponse>(req, "DescribeKafkaConsumerGroupList");
        }

        /// <summary>
        /// Retrieve the information list of Kafka protocol consumption groups
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerGroupListRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerGroupListResponse"/></returns>
        public DescribeKafkaConsumerGroupListResponse DescribeKafkaConsumerGroupListSync(DescribeKafkaConsumerGroupListRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerGroupListResponse>(req, "DescribeKafkaConsumerGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview the Kafka consumption.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerPreviewRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerPreviewResponse"/></returns>
        public Task<DescribeKafkaConsumerPreviewResponse> DescribeKafkaConsumerPreview(DescribeKafkaConsumerPreviewRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerPreviewResponse>(req, "DescribeKafkaConsumerPreview");
        }

        /// <summary>
        /// This API is used to preview the Kafka consumption.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerPreviewRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerPreviewResponse"/></returns>
        public DescribeKafkaConsumerPreviewResponse DescribeKafkaConsumerPreviewSync(DescribeKafkaConsumerPreviewRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerPreviewResponse>(req, "DescribeKafkaConsumerPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the topic information list of Kafka consumption.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerTopicsRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerTopicsResponse"/></returns>
        public Task<DescribeKafkaConsumerTopicsResponse> DescribeKafkaConsumerTopics(DescribeKafkaConsumerTopicsRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerTopicsResponse>(req, "DescribeKafkaConsumerTopics");
        }

        /// <summary>
        /// This API is used to obtain the topic information list of Kafka consumption.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerTopicsRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerTopicsResponse"/></returns>
        public DescribeKafkaConsumerTopicsResponse DescribeKafkaConsumerTopicsSync(DescribeKafkaConsumerTopicsRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerTopicsResponse>(req, "DescribeKafkaConsumerTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of Kafka data subscription tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaRechargesRequest"/></param>
        /// <returns><see cref="DescribeKafkaRechargesResponse"/></returns>
        public Task<DescribeKafkaRechargesResponse> DescribeKafkaRecharges(DescribeKafkaRechargesRequest req)
        {
            return InternalRequestAsync<DescribeKafkaRechargesResponse>(req, "DescribeKafkaRecharges");
        }

        /// <summary>
        /// This API is used to get the list of Kafka data subscription tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaRechargesRequest"/></param>
        /// <returns><see cref="DescribeKafkaRechargesResponse"/></returns>
        public DescribeKafkaRechargesResponse DescribeKafkaRechargesSync(DescribeKafkaRechargesRequest req)
        {
            return InternalRequestAsync<DescribeKafkaRechargesResponse>(req, "DescribeKafkaRecharges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for content near the log context. For more details, see [Context Search](https://intl.cloud.tencent.com/document/product/614/53248?from_cn_redirect=1).The maximum value of API's return data packet is 49MB. It is recommended to enable gzip compression (HTTP Request Header Accept-Encoding: gzip).
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public Task<DescribeLogContextResponse> DescribeLogContext(DescribeLogContextRequest req)
        {
            return InternalRequestAsync<DescribeLogContextResponse>(req, "DescribeLogContext");
        }

        /// <summary>
        /// This API is used to search for content near the log context. For more details, see [Context Search](https://intl.cloud.tencent.com/document/product/614/53248?from_cn_redirect=1).The maximum value of API's return data packet is 49MB. It is recommended to enable gzip compression (HTTP Request Header Accept-Encoding: gzip).
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public DescribeLogContextResponse DescribeLogContextSync(DescribeLogContextRequest req)
        {
            return InternalRequestAsync<DescribeLogContextResponse>(req, "DescribeLogContext")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a log count histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public Task<DescribeLogHistogramResponse> DescribeLogHistogram(DescribeLogHistogramRequest req)
        {
            return InternalRequestAsync<DescribeLogHistogramResponse>(req, "DescribeLogHistogram");
        }

        /// <summary>
        /// This API is used to get a log count histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public DescribeLogHistogramResponse DescribeLogHistogramSync(DescribeLogHistogramRequest req)
        {
            return InternalRequestAsync<DescribeLogHistogramResponse>(req, "DescribeLogHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of logsets.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public Task<DescribeLogsetsResponse> DescribeLogsets(DescribeLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeLogsetsResponse>(req, "DescribeLogsets");
        }

        /// <summary>
        /// This API is used to get the list of logsets.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public DescribeLogsetsResponse DescribeLogsetsSync(DescribeLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeLogsetsResponse>(req, "DescribeLogsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the collection rule configuration bound to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public Task<DescribeMachineGroupConfigsResponse> DescribeMachineGroupConfigs(DescribeMachineGroupConfigsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupConfigsResponse>(req, "DescribeMachineGroupConfigs");
        }

        /// <summary>
        /// This API is used to get the collection rule configuration bound to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public DescribeMachineGroupConfigsResponse DescribeMachineGroupConfigsSync(DescribeMachineGroupConfigsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupConfigsResponse>(req, "DescribeMachineGroupConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of machine groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public Task<DescribeMachineGroupsResponse> DescribeMachineGroups(DescribeMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupsResponse>(req, "DescribeMachineGroups");
        }

        /// <summary>
        /// This API is used to get the list of machine groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public DescribeMachineGroupsResponse DescribeMachineGroupsSync(DescribeMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupsResponse>(req, "DescribeMachineGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the status of a machine under the specified machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines");
        }

        /// <summary>
        /// This API is used to get the status of a machine under the specified machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricCorrectDimensionRequest"/></param>
        /// <returns><see cref="DescribeMetricCorrectDimensionResponse"/></returns>
        public Task<DescribeMetricCorrectDimensionResponse> DescribeMetricCorrectDimension(DescribeMetricCorrectDimensionRequest req)
        {
            return InternalRequestAsync<DescribeMetricCorrectDimensionResponse>(req, "DescribeMetricCorrectDimension");
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricCorrectDimensionRequest"/></param>
        /// <returns><see cref="DescribeMetricCorrectDimensionResponse"/></returns>
        public DescribeMetricCorrectDimensionResponse DescribeMetricCorrectDimensionSync(DescribeMetricCorrectDimensionRequest req)
        {
            return InternalRequestAsync<DescribeMetricCorrectDimensionResponse>(req, "DescribeMetricCorrectDimension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricSubscribePreviewRequest"/></param>
        /// <returns><see cref="DescribeMetricSubscribePreviewResponse"/></returns>
        public Task<DescribeMetricSubscribePreviewResponse> DescribeMetricSubscribePreview(DescribeMetricSubscribePreviewRequest req)
        {
            return InternalRequestAsync<DescribeMetricSubscribePreviewResponse>(req, "DescribeMetricSubscribePreview");
        }

        /// <summary>
        /// This API is used to create metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricSubscribePreviewRequest"/></param>
        /// <returns><see cref="DescribeMetricSubscribePreviewResponse"/></returns>
        public DescribeMetricSubscribePreviewResponse DescribeMetricSubscribePreviewSync(DescribeMetricSubscribePreviewRequest req)
        {
            return InternalRequestAsync<DescribeMetricSubscribePreviewResponse>(req, "DescribeMetricSubscribePreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricSubscribesRequest"/></param>
        /// <returns><see cref="DescribeMetricSubscribesResponse"/></returns>
        public Task<DescribeMetricSubscribesResponse> DescribeMetricSubscribes(DescribeMetricSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeMetricSubscribesResponse>(req, "DescribeMetricSubscribes");
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricSubscribesRequest"/></param>
        /// <returns><see cref="DescribeMetricSubscribesResponse"/></returns>
        public DescribeMetricSubscribesResponse DescribeMetricSubscribesSync(DescribeMetricSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeMetricSubscribesResponse>(req, "DescribeMetricSubscribes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve web application details
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkApplicationDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkApplicationDetailResponse"/></returns>
        public Task<DescribeNetworkApplicationDetailResponse> DescribeNetworkApplicationDetail(DescribeNetworkApplicationDetailRequest req)
        {
            return InternalRequestAsync<DescribeNetworkApplicationDetailResponse>(req, "DescribeNetworkApplicationDetail");
        }

        /// <summary>
        /// Retrieve web application details
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkApplicationDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkApplicationDetailResponse"/></returns>
        public DescribeNetworkApplicationDetailResponse DescribeNetworkApplicationDetailSync(DescribeNetworkApplicationDetailRequest req)
        {
            return InternalRequestAsync<DescribeNetworkApplicationDetailResponse>(req, "DescribeNetworkApplicationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the network application list
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkApplicationsRequest"/></param>
        /// <returns><see cref="DescribeNetworkApplicationsResponse"/></returns>
        public Task<DescribeNetworkApplicationsResponse> DescribeNetworkApplications(DescribeNetworkApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkApplicationsResponse>(req, "DescribeNetworkApplications");
        }

        /// <summary>
        /// Retrieve the network application list
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkApplicationsRequest"/></param>
        /// <returns><see cref="DescribeNetworkApplicationsResponse"/></returns>
        public DescribeNetworkApplicationsResponse DescribeNetworkApplicationsSync(DescribeNetworkApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkApplicationsResponse>(req, "DescribeNetworkApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the notification content list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeContentsRequest"/></param>
        /// <returns><see cref="DescribeNoticeContentsResponse"/></returns>
        public Task<DescribeNoticeContentsResponse> DescribeNoticeContents(DescribeNoticeContentsRequest req)
        {
            return InternalRequestAsync<DescribeNoticeContentsResponse>(req, "DescribeNoticeContents");
        }

        /// <summary>
        /// This API is used to obtain the notification content list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeContentsRequest"/></param>
        /// <returns><see cref="DescribeNoticeContentsResponse"/></returns>
        public DescribeNoticeContentsResponse DescribeNoticeContentsSync(DescribeNoticeContentsRequest req)
        {
            return InternalRequestAsync<DescribeNoticeContentsResponse>(req, "DescribeNoticeContents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is deprecated. If needed, please use the DescribeTopics API to get the number of partitions.
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public Task<DescribePartitionsResponse> DescribePartitions(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions");
        }

        /// <summary>
        /// This API is deprecated. If needed, please use the DescribeTopics API to get the number of partitions.
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public DescribePartitionsResponse DescribePartitionsSync(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of rebuild index tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildIndexTasksRequest"/></param>
        /// <returns><see cref="DescribeRebuildIndexTasksResponse"/></returns>
        public Task<DescribeRebuildIndexTasksResponse> DescribeRebuildIndexTasks(DescribeRebuildIndexTasksRequest req)
        {
            return InternalRequestAsync<DescribeRebuildIndexTasksResponse>(req, "DescribeRebuildIndexTasks");
        }

        /// <summary>
        /// This API is used to obtain the list of rebuild index tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildIndexTasksRequest"/></param>
        /// <returns><see cref="DescribeRebuildIndexTasksResponse"/></returns>
        public DescribeRebuildIndexTasksResponse DescribeRebuildIndexTasksSync(DescribeRebuildIndexTasksRequest req)
        {
            return InternalRequestAsync<DescribeRebuildIndexTasksResponse>(req, "DescribeRebuildIndexTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the pre-aggregation task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordingRuleTaskResponse"/></returns>
        public Task<DescribeRecordingRuleTaskResponse> DescribeRecordingRuleTask(DescribeRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRuleTaskResponse>(req, "DescribeRecordingRuleTask");
        }

        /// <summary>
        /// This API is used to retrieve the pre-aggregation task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordingRuleTaskResponse"/></returns>
        public DescribeRecordingRuleTaskResponse DescribeRecordingRuleTaskSync(DescribeRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRuleTaskResponse>(req, "DescribeRecordingRuleTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the pre-aggregation task list in yaml.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordingRuleYamlTaskResponse"/></returns>
        public Task<DescribeRecordingRuleYamlTaskResponse> DescribeRecordingRuleYamlTask(DescribeRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRuleYamlTaskResponse>(req, "DescribeRecordingRuleYamlTask");
        }

        /// <summary>
        /// This API is used to retrieve the pre-aggregation task list in yaml.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordingRuleYamlTaskResponse"/></returns>
        public DescribeRecordingRuleYamlTaskResponse DescribeRecordingRuleYamlTaskSync(DescribeRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRuleYamlTaskResponse>(req, "DescribeRecordingRuleYamlTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the scheduled SQL analysis task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledSqlInfoRequest"/></param>
        /// <returns><see cref="DescribeScheduledSqlInfoResponse"/></returns>
        public Task<DescribeScheduledSqlInfoResponse> DescribeScheduledSqlInfo(DescribeScheduledSqlInfoRequest req)
        {
            return InternalRequestAsync<DescribeScheduledSqlInfoResponse>(req, "DescribeScheduledSqlInfo");
        }

        /// <summary>
        /// This API is used to access the scheduled SQL analysis task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledSqlInfoRequest"/></param>
        /// <returns><see cref="DescribeScheduledSqlInfoResponse"/></returns>
        public DescribeScheduledSqlInfoResponse DescribeScheduledSqlInfoSync(DescribeScheduledSqlInfoRequest req)
        {
            return InternalRequestAsync<DescribeScheduledSqlInfoResponse>(req, "DescribeScheduledSqlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query view list
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchViewsRequest"/></param>
        /// <returns><see cref="DescribeSearchViewsResponse"/></returns>
        public Task<DescribeSearchViewsResponse> DescribeSearchViews(DescribeSearchViewsRequest req)
        {
            return InternalRequestAsync<DescribeSearchViewsResponse>(req, "DescribeSearchViews");
        }

        /// <summary>
        /// Query view list
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchViewsRequest"/></param>
        /// <returns><see cref="DescribeSearchViewsResponse"/></returns>
        public DescribeSearchViewsResponse DescribeSearchViewsSync(DescribeSearchViewsRequest req)
        {
            return InternalRequestAsync<DescribeSearchViewsResponse>(req, "DescribeSearchViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of shipping tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public Task<DescribeShipperTasksResponse> DescribeShipperTasks(DescribeShipperTasksRequest req)
        {
            return InternalRequestAsync<DescribeShipperTasksResponse>(req, "DescribeShipperTasks");
        }

        /// <summary>
        /// This API is used to get the list of shipping tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public DescribeShipperTasksResponse DescribeShipperTasksSync(DescribeShipperTasksRequest req)
        {
            return InternalRequestAsync<DescribeShipperTasksResponse>(req, "DescribeShipperTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the configuration of the task shipped to COS.
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public Task<DescribeShippersResponse> DescribeShippers(DescribeShippersRequest req)
        {
            return InternalRequestAsync<DescribeShippersResponse>(req, "DescribeShippers");
        }

        /// <summary>
        /// This API is used to get the configuration of the task shipped to COS.
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public DescribeShippersResponse DescribeShippersSync(DescribeShippersRequest req)
        {
            return InternalRequestAsync<DescribeShippersResponse>(req, "DescribeShippers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the Splunk delivery task list
        /// </summary>
        /// <param name="req"><see cref="DescribeSplunkDeliversRequest"/></param>
        /// <returns><see cref="DescribeSplunkDeliversResponse"/></returns>
        public Task<DescribeSplunkDeliversResponse> DescribeSplunkDelivers(DescribeSplunkDeliversRequest req)
        {
            return InternalRequestAsync<DescribeSplunkDeliversResponse>(req, "DescribeSplunkDelivers");
        }

        /// <summary>
        /// Retrieve the Splunk delivery task list
        /// </summary>
        /// <param name="req"><see cref="DescribeSplunkDeliversRequest"/></param>
        /// <returns><see cref="DescribeSplunkDeliversResponse"/></returns>
        public DescribeSplunkDeliversResponse DescribeSplunkDeliversSync(DescribeSplunkDeliversRequest req)
        {
            return InternalRequestAsync<DescribeSplunkDeliversResponse>(req, "DescribeSplunkDelivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// splunk delivery task preview
        /// </summary>
        /// <param name="req"><see cref="DescribeSplunkPreviewRequest"/></param>
        /// <returns><see cref="DescribeSplunkPreviewResponse"/></returns>
        public Task<DescribeSplunkPreviewResponse> DescribeSplunkPreview(DescribeSplunkPreviewRequest req)
        {
            return InternalRequestAsync<DescribeSplunkPreviewResponse>(req, "DescribeSplunkPreview");
        }

        /// <summary>
        /// splunk delivery task preview
        /// </summary>
        /// <param name="req"><see cref="DescribeSplunkPreviewRequest"/></param>
        /// <returns><see cref="DescribeSplunkPreviewResponse"/></returns>
        public DescribeSplunkPreviewResponse DescribeSplunkPreviewSync(DescribeSplunkPreviewRequest req)
        {
            return InternalRequestAsync<DescribeSplunkPreviewResponse>(req, "DescribeSplunkPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicBaseMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeTopicBaseMetricConfigsResponse"/></returns>
        public Task<DescribeTopicBaseMetricConfigsResponse> DescribeTopicBaseMetricConfigs(DescribeTopicBaseMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeTopicBaseMetricConfigsResponse>(req, "DescribeTopicBaseMetricConfigs");
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicBaseMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeTopicBaseMetricConfigsResponse"/></returns>
        public DescribeTopicBaseMetricConfigsResponse DescribeTopicBaseMetricConfigsSync(DescribeTopicBaseMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeTopicBaseMetricConfigsResponse>(req, "DescribeTopicBaseMetricConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeTopicMetricConfigsResponse"/></returns>
        public Task<DescribeTopicMetricConfigsResponse> DescribeTopicMetricConfigs(DescribeTopicMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeTopicMetricConfigsResponse>(req, "DescribeTopicMetricConfigs");
        }

        /// <summary>
        /// This API is used to obtain metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicMetricConfigsRequest"/></param>
        /// <returns><see cref="DescribeTopicMetricConfigsResponse"/></returns>
        public DescribeTopicMetricConfigsResponse DescribeTopicMetricConfigsSync(DescribeTopicMetricConfigsRequest req)
        {
            return InternalRequestAsync<DescribeTopicMetricConfigsResponse>(req, "DescribeTopicMetricConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain logs or metric topic lists and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics");
        }

        /// <summary>
        /// This API is used to obtain logs or metric topic lists and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search alarm channel callback configuration lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebCallbacksRequest"/></param>
        /// <returns><see cref="DescribeWebCallbacksResponse"/></returns>
        public Task<DescribeWebCallbacksResponse> DescribeWebCallbacks(DescribeWebCallbacksRequest req)
        {
            return InternalRequestAsync<DescribeWebCallbacksResponse>(req, "DescribeWebCallbacks");
        }

        /// <summary>
        /// This API is used to search alarm channel callback configuration lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebCallbacksRequest"/></param>
        /// <returns><see cref="DescribeWebCallbacksResponse"/></returns>
        public DescribeWebCallbacksResponse DescribeWebCallbacksSync(DescribeWebCallbacksRequest req)
        {
            return InternalRequestAsync<DescribeWebCallbacksResponse>(req, "DescribeWebCallbacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to estimate rebuild index tasks.
        /// </summary>
        /// <param name="req"><see cref="EstimateRebuildIndexTaskRequest"/></param>
        /// <returns><see cref="EstimateRebuildIndexTaskResponse"/></returns>
        public Task<EstimateRebuildIndexTaskResponse> EstimateRebuildIndexTask(EstimateRebuildIndexTaskRequest req)
        {
            return InternalRequestAsync<EstimateRebuildIndexTaskResponse>(req, "EstimateRebuildIndexTask");
        }

        /// <summary>
        /// This API is used to estimate rebuild index tasks.
        /// </summary>
        /// <param name="req"><see cref="EstimateRebuildIndexTaskRequest"/></param>
        /// <returns><see cref="EstimateRebuildIndexTaskResponse"/></returns>
        public EstimateRebuildIndexTaskResponse EstimateRebuildIndexTaskSync(EstimateRebuildIndexTaskRequest req)
        {
            return InternalRequestAsync<EstimateRebuildIndexTaskResponse>(req, "EstimateRebuildIndexTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access alarm policy execution details.
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public Task<GetAlarmLogResponse> GetAlarmLog(GetAlarmLogRequest req)
        {
            return InternalRequestAsync<GetAlarmLogResponse>(req, "GetAlarmLog");
        }

        /// <summary>
        /// This API is used to access alarm policy execution details.
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public GetAlarmLogResponse GetAlarmLogSync(GetAlarmLogRequest req)
        {
            return InternalRequestAsync<GetAlarmLogResponse>(req, "GetAlarmLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether CLS is enabled.
        /// This API is used to fill in any region for Region, recommend using Guangzhou (ap-guangzhou).
        /// </summary>
        /// <param name="req"><see cref="GetClsServiceRequest"/></param>
        /// <returns><see cref="GetClsServiceResponse"/></returns>
        public Task<GetClsServiceResponse> GetClsService(GetClsServiceRequest req)
        {
            return InternalRequestAsync<GetClsServiceResponse>(req, "GetClsService");
        }

        /// <summary>
        /// This API is used to check whether CLS is enabled.
        /// This API is used to fill in any region for Region, recommend using Guangzhou (ap-guangzhou).
        /// </summary>
        /// <param name="req"><see cref="GetClsServiceRequest"/></param>
        /// <returns><see cref="GetClsServiceResponse"/></returns>
        public GetClsServiceResponse GetClsServiceSync(GetClsServiceRequest req)
        {
            return InternalRequestAsync<GetClsServiceResponse>(req, "GetClsService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of time series label values.
        /// </summary>
        /// <param name="req"><see cref="GetMetricLabelValuesRequest"/></param>
        /// <returns><see cref="GetMetricLabelValuesResponse"/></returns>
        public Task<GetMetricLabelValuesResponse> GetMetricLabelValues(GetMetricLabelValuesRequest req)
        {
            return InternalRequestAsync<GetMetricLabelValuesResponse>(req, "GetMetricLabelValues");
        }

        /// <summary>
        /// This API is used to obtain the list of time series label values.
        /// </summary>
        /// <param name="req"><see cref="GetMetricLabelValuesRequest"/></param>
        /// <returns><see cref="GetMetricLabelValuesResponse"/></returns>
        public GetMetricLabelValuesResponse GetMetricLabelValuesSync(GetMetricLabelValuesRequest req)
        {
            return InternalRequestAsync<GetMetricLabelValuesResponse>(req, "GetMetricLabelValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is deprecated. If needed, please use the ModifyTopic API to change the number of partitions.
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public Task<MergePartitionResponse> MergePartition(MergePartitionRequest req)
        {
            return InternalRequestAsync<MergePartitionResponse>(req, "MergePartition");
        }

        /// <summary>
        /// This API is deprecated. If needed, please use the ModifyTopic API to change the number of partitions.
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public MergePartitionResponse MergePartitionSync(MergePartitionRequest req)
        {
            return InternalRequestAsync<MergePartitionResponse>(req, "MergePartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an alarm policy. At least one valid configuration item needs to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public Task<ModifyAlarmResponse> ModifyAlarm(ModifyAlarmRequest req)
        {
            return InternalRequestAsync<ModifyAlarmResponse>(req, "ModifyAlarm");
        }

        /// <summary>
        /// This API is used to modify an alarm policy. At least one valid configuration item needs to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public ModifyAlarmResponse ModifyAlarmSync(ModifyAlarmRequest req)
        {
            return InternalRequestAsync<ModifyAlarmResponse>(req, "ModifyAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a notification group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public Task<ModifyAlarmNoticeResponse> ModifyAlarmNotice(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice");
        }

        /// <summary>
        /// This API is used to modify a notification group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public ModifyAlarmNoticeResponse ModifyAlarmNoticeSync(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify alarm blocking rules. When the alarm blocking rule is invalid, it cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmShieldRequest"/></param>
        /// <returns><see cref="ModifyAlarmShieldResponse"/></returns>
        public Task<ModifyAlarmShieldResponse> ModifyAlarmShield(ModifyAlarmShieldRequest req)
        {
            return InternalRequestAsync<ModifyAlarmShieldResponse>(req, "ModifyAlarmShield");
        }

        /// <summary>
        /// This API is used to modify alarm blocking rules. When the alarm blocking rule is invalid, it cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmShieldRequest"/></param>
        /// <returns><see cref="ModifyAlarmShieldResponse"/></returns>
        public ModifyAlarmShieldResponse ModifyAlarmShieldSync(ModifyAlarmShieldRequest req)
        {
            return InternalRequestAsync<ModifyAlarmShieldResponse>(req, "ModifyAlarmShield")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud product integration uses internal APIs
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudProductLogCollectionRequest"/></param>
        /// <returns><see cref="ModifyCloudProductLogCollectionResponse"/></returns>
        public Task<ModifyCloudProductLogCollectionResponse> ModifyCloudProductLogCollection(ModifyCloudProductLogCollectionRequest req)
        {
            return InternalRequestAsync<ModifyCloudProductLogCollectionResponse>(req, "ModifyCloudProductLogCollection");
        }

        /// <summary>
        /// Cloud product integration uses internal APIs
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudProductLogCollectionRequest"/></param>
        /// <returns><see cref="ModifyCloudProductLogCollectionResponse"/></returns>
        public ModifyCloudProductLogCollectionResponse ModifyCloudProductLogCollectionSync(ModifyCloudProductLogCollectionRequest req)
        {
            return InternalRequestAsync<ModifyCloudProductLogCollectionResponse>(req, "ModifyCloudProductLogCollection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public Task<ModifyConfigResponse> ModifyConfig(ModifyConfigRequest req)
        {
            return InternalRequestAsync<ModifyConfigResponse>(req, "ModifyConfig");
        }

        /// <summary>
        /// This API is used to modify collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public ModifyConfigResponse ModifyConfigSync(ModifyConfigRequest req)
        {
            return InternalRequestAsync<ModifyConfigResponse>(req, "ModifyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the DataSight Console
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleRequest"/></param>
        /// <returns><see cref="ModifyConsoleResponse"/></returns>
        public Task<ModifyConsoleResponse> ModifyConsole(ModifyConsoleRequest req)
        {
            return InternalRequestAsync<ModifyConsoleResponse>(req, "ModifyConsole");
        }

        /// <summary>
        /// This API is used to edit the DataSight Console
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleRequest"/></param>
        /// <returns><see cref="ModifyConsoleResponse"/></returns>
        public ModifyConsoleResponse ModifyConsoleSync(ModifyConsoleRequest req)
        {
            return InternalRequestAsync<ModifyConsoleResponse>(req, "ModifyConsole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a CKafka delivery task.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerRequest"/></param>
        /// <returns><see cref="ModifyConsumerResponse"/></returns>
        public Task<ModifyConsumerResponse> ModifyConsumer(ModifyConsumerRequest req)
        {
            return InternalRequestAsync<ModifyConsumerResponse>(req, "ModifyConsumer");
        }

        /// <summary>
        /// This API is used to modify a CKafka delivery task.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerRequest"/></param>
        /// <returns><see cref="ModifyConsumerResponse"/></returns>
        public ModifyConsumerResponse ModifyConsumerSync(ModifyConsumerRequest req)
        {
            return InternalRequestAsync<ModifyConsumerResponse>(req, "ModifyConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the consumer group information.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public Task<ModifyConsumerGroupResponse> ModifyConsumerGroup(ModifyConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupResponse>(req, "ModifyConsumerGroup");
        }

        /// <summary>
        /// This API is used to update the consumer group information.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public ModifyConsumerGroupResponse ModifyConsumerGroupSync(ModifyConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupResponse>(req, "ModifyConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a COS import task.
        /// </summary>
        /// <param name="req"><see cref="ModifyCosRechargeRequest"/></param>
        /// <returns><see cref="ModifyCosRechargeResponse"/></returns>
        public Task<ModifyCosRechargeResponse> ModifyCosRecharge(ModifyCosRechargeRequest req)
        {
            return InternalRequestAsync<ModifyCosRechargeResponse>(req, "ModifyCosRecharge");
        }

        /// <summary>
        /// This API is used to modify a COS import task.
        /// </summary>
        /// <param name="req"><see cref="ModifyCosRechargeRequest"/></param>
        /// <returns><see cref="ModifyCosRechargeResponse"/></returns>
        public ModifyCosRechargeResponse ModifyCosRechargeSync(ModifyCosRechargeRequest req)
        {
            return InternalRequestAsync<ModifyCosRechargeResponse>(req, "ModifyCosRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the dashboard.
        /// </summary>
        /// <param name="req"><see cref="ModifyDashboardRequest"/></param>
        /// <returns><see cref="ModifyDashboardResponse"/></returns>
        public Task<ModifyDashboardResponse> ModifyDashboard(ModifyDashboardRequest req)
        {
            return InternalRequestAsync<ModifyDashboardResponse>(req, "ModifyDashboard");
        }

        /// <summary>
        /// This API is used to modify the dashboard.
        /// </summary>
        /// <param name="req"><see cref="ModifyDashboardRequest"/></param>
        /// <returns><see cref="ModifyDashboardResponse"/></returns>
        public ModifyDashboardResponse ModifyDashboardSync(ModifyDashboardRequest req)
        {
            return InternalRequestAsync<ModifyDashboardResponse>(req, "ModifyDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify dashboard subscriptions.
        /// </summary>
        /// <param name="req"><see cref="ModifyDashboardSubscribeRequest"/></param>
        /// <returns><see cref="ModifyDashboardSubscribeResponse"/></returns>
        public Task<ModifyDashboardSubscribeResponse> ModifyDashboardSubscribe(ModifyDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyDashboardSubscribeResponse>(req, "ModifyDashboardSubscribe");
        }

        /// <summary>
        /// This API is used to modify dashboard subscriptions.
        /// </summary>
        /// <param name="req"><see cref="ModifyDashboardSubscribeRequest"/></param>
        /// <returns><see cref="ModifyDashboardSubscribeResponse"/></returns>
        public ModifyDashboardSubscribeResponse ModifyDashboardSubscribeSync(ModifyDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyDashboardSubscribeResponse>(req, "ModifyDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a data processing task.
        /// </summary>
        /// <param name="req"><see cref="ModifyDataTransformRequest"/></param>
        /// <returns><see cref="ModifyDataTransformResponse"/></returns>
        public Task<ModifyDataTransformResponse> ModifyDataTransform(ModifyDataTransformRequest req)
        {
            return InternalRequestAsync<ModifyDataTransformResponse>(req, "ModifyDataTransform");
        }

        /// <summary>
        /// This API is used to modify a data processing task.
        /// </summary>
        /// <param name="req"><see cref="ModifyDataTransformRequest"/></param>
        /// <returns><see cref="ModifyDataTransformResponse"/></returns>
        public ModifyDataTransformResponse ModifyDataTransformSync(ModifyDataTransformRequest req)
        {
            return InternalRequestAsync<ModifyDataTransformResponse>(req, "ModifyDataTransform")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a DLC delivery task
        /// </summary>
        /// <param name="req"><see cref="ModifyDlcDeliverRequest"/></param>
        /// <returns><see cref="ModifyDlcDeliverResponse"/></returns>
        public Task<ModifyDlcDeliverResponse> ModifyDlcDeliver(ModifyDlcDeliverRequest req)
        {
            return InternalRequestAsync<ModifyDlcDeliverResponse>(req, "ModifyDlcDeliver");
        }

        /// <summary>
        /// Modify a DLC delivery task
        /// </summary>
        /// <param name="req"><see cref="ModifyDlcDeliverRequest"/></param>
        /// <returns><see cref="ModifyDlcDeliverResponse"/></returns>
        public ModifyDlcDeliverResponse ModifyDlcDeliverSync(ModifyDlcDeliverRequest req)
        {
            return InternalRequestAsync<ModifyDlcDeliverResponse>(req, "ModifyDlcDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify es import configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyEsRechargeRequest"/></param>
        /// <returns><see cref="ModifyEsRechargeResponse"/></returns>
        public Task<ModifyEsRechargeResponse> ModifyEsRecharge(ModifyEsRechargeRequest req)
        {
            return InternalRequestAsync<ModifyEsRechargeResponse>(req, "ModifyEsRecharge");
        }

        /// <summary>
        /// Modify es import configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyEsRechargeRequest"/></param>
        /// <returns><see cref="ModifyEsRechargeResponse"/></returns>
        public ModifyEsRechargeResponse ModifyEsRechargeSync(ModifyEsRechargeRequest req)
        {
            return InternalRequestAsync<ModifyEsRechargeResponse>(req, "ModifyEsRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify host metric collection configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyHostMetricConfigRequest"/></param>
        /// <returns><see cref="ModifyHostMetricConfigResponse"/></returns>
        public Task<ModifyHostMetricConfigResponse> ModifyHostMetricConfig(ModifyHostMetricConfigRequest req)
        {
            return InternalRequestAsync<ModifyHostMetricConfigResponse>(req, "ModifyHostMetricConfig");
        }

        /// <summary>
        /// Modify host metric collection configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyHostMetricConfigRequest"/></param>
        /// <returns><see cref="ModifyHostMetricConfigResponse"/></returns>
        public ModifyHostMetricConfigResponse ModifyHostMetricConfigSync(ModifyHostMetricConfigRequest req)
        {
            return InternalRequestAsync<ModifyHostMetricConfigResponse>(req, "ModifyHostMetricConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the index configuration. It is subject to the default request frequency limit, and the number of concurrent requests to the same log topic cannot exceed 1, i.e., the index configuration of only one log topic can be modified at a time.
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public Task<ModifyIndexResponse> ModifyIndex(ModifyIndexRequest req)
        {
            return InternalRequestAsync<ModifyIndexResponse>(req, "ModifyIndex");
        }

        /// <summary>
        /// This API is used to modify the index configuration. It is subject to the default request frequency limit, and the number of concurrent requests to the same log topic cannot exceed 1, i.e., the index configuration of only one log topic can be modified at a time.
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public ModifyIndexResponse ModifyIndexSync(ModifyIndexRequest req)
        {
            return InternalRequestAsync<ModifyIndexResponse>(req, "ModifyIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Kafka protocol consumption information.
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerResponse"/></returns>
        public Task<ModifyKafkaConsumerResponse> ModifyKafkaConsumer(ModifyKafkaConsumerRequest req)
        {
            return InternalRequestAsync<ModifyKafkaConsumerResponse>(req, "ModifyKafkaConsumer");
        }

        /// <summary>
        /// This API is used to modify Kafka protocol consumption information.
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerResponse"/></returns>
        public ModifyKafkaConsumerResponse ModifyKafkaConsumerSync(ModifyKafkaConsumerRequest req)
        {
            return InternalRequestAsync<ModifyKafkaConsumerResponse>(req, "ModifyKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Kafka protocol consumption group offsets.
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerGroupOffsetResponse"/></returns>
        public Task<ModifyKafkaConsumerGroupOffsetResponse> ModifyKafkaConsumerGroupOffset(ModifyKafkaConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ModifyKafkaConsumerGroupOffsetResponse>(req, "ModifyKafkaConsumerGroupOffset");
        }

        /// <summary>
        /// This API is used to modify Kafka protocol consumption group offsets.
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerGroupOffsetResponse"/></returns>
        public ModifyKafkaConsumerGroupOffsetResponse ModifyKafkaConsumerGroupOffsetSync(ModifyKafkaConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ModifyKafkaConsumerGroupOffsetResponse>(req, "ModifyKafkaConsumerGroupOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a Kafka data subscription task.
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaRechargeRequest"/></param>
        /// <returns><see cref="ModifyKafkaRechargeResponse"/></returns>
        public Task<ModifyKafkaRechargeResponse> ModifyKafkaRecharge(ModifyKafkaRechargeRequest req)
        {
            return InternalRequestAsync<ModifyKafkaRechargeResponse>(req, "ModifyKafkaRecharge");
        }

        /// <summary>
        /// This API is used to modify a Kafka data subscription task.
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaRechargeRequest"/></param>
        /// <returns><see cref="ModifyKafkaRechargeResponse"/></returns>
        public ModifyKafkaRechargeResponse ModifyKafkaRechargeSync(ModifyKafkaRechargeRequest req)
        {
            return InternalRequestAsync<ModifyKafkaRechargeResponse>(req, "ModifyKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a logset.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public Task<ModifyLogsetResponse> ModifyLogset(ModifyLogsetRequest req)
        {
            return InternalRequestAsync<ModifyLogsetResponse>(req, "ModifyLogset");
        }

        /// <summary>
        /// This API is used to modify a logset.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public ModifyLogsetResponse ModifyLogsetSync(ModifyLogsetRequest req)
        {
            return InternalRequestAsync<ModifyLogsetResponse>(req, "ModifyLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify machine group.
        /// Note: Modifying the interface will directly overwrite historical data and change it to valid input parameters this time. Please be cautious when calling this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public Task<ModifyMachineGroupResponse> ModifyMachineGroup(ModifyMachineGroupRequest req)
        {
            return InternalRequestAsync<ModifyMachineGroupResponse>(req, "ModifyMachineGroup");
        }

        /// <summary>
        /// Modify machine group.
        /// Note: Modifying the interface will directly overwrite historical data and change it to valid input parameters this time. Please be cautious when calling this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public ModifyMachineGroupResponse ModifyMachineGroupSync(ModifyMachineGroupRequest req)
        {
            return InternalRequestAsync<ModifyMachineGroupResponse>(req, "ModifyMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyMetricConfigRequest"/></param>
        /// <returns><see cref="ModifyMetricConfigResponse"/></returns>
        public Task<ModifyMetricConfigResponse> ModifyMetricConfig(ModifyMetricConfigRequest req)
        {
            return InternalRequestAsync<ModifyMetricConfigResponse>(req, "ModifyMetricConfig");
        }

        /// <summary>
        /// This API is used to create metric collection configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyMetricConfigRequest"/></param>
        /// <returns><see cref="ModifyMetricConfigResponse"/></returns>
        public ModifyMetricConfigResponse ModifyMetricConfigSync(ModifyMetricConfigRequest req)
        {
            return InternalRequestAsync<ModifyMetricConfigResponse>(req, "ModifyMetricConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyMetricSubscribeRequest"/></param>
        /// <returns><see cref="ModifyMetricSubscribeResponse"/></returns>
        public Task<ModifyMetricSubscribeResponse> ModifyMetricSubscribe(ModifyMetricSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyMetricSubscribeResponse>(req, "ModifyMetricSubscribe");
        }

        /// <summary>
        /// This API is used to modify metric subscription configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyMetricSubscribeRequest"/></param>
        /// <returns><see cref="ModifyMetricSubscribeResponse"/></returns>
        public ModifyMetricSubscribeResponse ModifyMetricSubscribeSync(ModifyMetricSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyMetricSubscribeResponse>(req, "ModifyMetricSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a web application
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkApplicationRequest"/></param>
        /// <returns><see cref="ModifyNetworkApplicationResponse"/></returns>
        public Task<ModifyNetworkApplicationResponse> ModifyNetworkApplication(ModifyNetworkApplicationRequest req)
        {
            return InternalRequestAsync<ModifyNetworkApplicationResponse>(req, "ModifyNetworkApplication");
        }

        /// <summary>
        /// Modify a web application
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkApplicationRequest"/></param>
        /// <returns><see cref="ModifyNetworkApplicationResponse"/></returns>
        public ModifyNetworkApplicationResponse ModifyNetworkApplicationSync(ModifyNetworkApplicationRequest req)
        {
            return InternalRequestAsync<ModifyNetworkApplicationResponse>(req, "ModifyNetworkApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify notification content configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyNoticeContentRequest"/></param>
        /// <returns><see cref="ModifyNoticeContentResponse"/></returns>
        public Task<ModifyNoticeContentResponse> ModifyNoticeContent(ModifyNoticeContentRequest req)
        {
            return InternalRequestAsync<ModifyNoticeContentResponse>(req, "ModifyNoticeContent");
        }

        /// <summary>
        /// This API is used to modify notification content configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyNoticeContentRequest"/></param>
        /// <returns><see cref="ModifyNoticeContentResponse"/></returns>
        public ModifyNoticeContentResponse ModifyNoticeContentSync(ModifyNoticeContentRequest req)
        {
            return InternalRequestAsync<ModifyNoticeContentResponse>(req, "ModifyNoticeContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a scheduled pre-aggregation task.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="ModifyRecordingRuleTaskResponse"/></returns>
        public Task<ModifyRecordingRuleTaskResponse> ModifyRecordingRuleTask(ModifyRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<ModifyRecordingRuleTaskResponse>(req, "ModifyRecordingRuleTask");
        }

        /// <summary>
        /// This API is used to modify a scheduled pre-aggregation task.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingRuleTaskRequest"/></param>
        /// <returns><see cref="ModifyRecordingRuleTaskResponse"/></returns>
        public ModifyRecordingRuleTaskResponse ModifyRecordingRuleTaskSync(ModifyRecordingRuleTaskRequest req)
        {
            return InternalRequestAsync<ModifyRecordingRuleTaskResponse>(req, "ModifyRecordingRuleTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifying a Metric Pre-Aggregation Task Through a YAML File
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="ModifyRecordingRuleYamlTaskResponse"/></returns>
        public Task<ModifyRecordingRuleYamlTaskResponse> ModifyRecordingRuleYamlTask(ModifyRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<ModifyRecordingRuleYamlTaskResponse>(req, "ModifyRecordingRuleYamlTask");
        }

        /// <summary>
        /// Modifying a Metric Pre-Aggregation Task Through a YAML File
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingRuleYamlTaskRequest"/></param>
        /// <returns><see cref="ModifyRecordingRuleYamlTaskResponse"/></returns>
        public ModifyRecordingRuleYamlTaskResponse ModifyRecordingRuleYamlTaskSync(ModifyRecordingRuleYamlTaskRequest req)
        {
            return InternalRequestAsync<ModifyRecordingRuleYamlTaskResponse>(req, "ModifyRecordingRuleYamlTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a scheduled SQL analysis task.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledSqlRequest"/></param>
        /// <returns><see cref="ModifyScheduledSqlResponse"/></returns>
        public Task<ModifyScheduledSqlResponse> ModifyScheduledSql(ModifyScheduledSqlRequest req)
        {
            return InternalRequestAsync<ModifyScheduledSqlResponse>(req, "ModifyScheduledSql");
        }

        /// <summary>
        /// This API is used to modify a scheduled SQL analysis task.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledSqlRequest"/></param>
        /// <returns><see cref="ModifyScheduledSqlResponse"/></returns>
        public ModifyScheduledSqlResponse ModifyScheduledSqlSync(ModifyScheduledSqlRequest req)
        {
            return InternalRequestAsync<ModifyScheduledSqlResponse>(req, "ModifyScheduledSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a query view.
        /// </summary>
        /// <param name="req"><see cref="ModifySearchViewRequest"/></param>
        /// <returns><see cref="ModifySearchViewResponse"/></returns>
        public Task<ModifySearchViewResponse> ModifySearchView(ModifySearchViewRequest req)
        {
            return InternalRequestAsync<ModifySearchViewResponse>(req, "ModifySearchView");
        }

        /// <summary>
        /// This API is used to modify a query view.
        /// </summary>
        /// <param name="req"><see cref="ModifySearchViewRequest"/></param>
        /// <returns><see cref="ModifySearchViewResponse"/></returns>
        public ModifySearchViewResponse ModifySearchViewSync(ModifySearchViewRequest req)
        {
            return InternalRequestAsync<ModifySearchViewResponse>(req, "ModifySearchView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an existing shipping rule. To use this API, you need to grant CLS the write permission of the specified bucket.
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public Task<ModifyShipperResponse> ModifyShipper(ModifyShipperRequest req)
        {
            return InternalRequestAsync<ModifyShipperResponse>(req, "ModifyShipper");
        }

        /// <summary>
        /// This API is used to modify an existing shipping rule. To use this API, you need to grant CLS the write permission of the specified bucket.
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public ModifyShipperResponse ModifyShipperSync(ModifyShipperRequest req)
        {
            return InternalRequestAsync<ModifyShipperResponse>(req, "ModifyShipper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify information related to splunk delivery task
        /// </summary>
        /// <param name="req"><see cref="ModifySplunkDeliverRequest"/></param>
        /// <returns><see cref="ModifySplunkDeliverResponse"/></returns>
        public Task<ModifySplunkDeliverResponse> ModifySplunkDeliver(ModifySplunkDeliverRequest req)
        {
            return InternalRequestAsync<ModifySplunkDeliverResponse>(req, "ModifySplunkDeliver");
        }

        /// <summary>
        /// Modify information related to splunk delivery task
        /// </summary>
        /// <param name="req"><see cref="ModifySplunkDeliverRequest"/></param>
        /// <returns><see cref="ModifySplunkDeliverResponse"/></returns>
        public ModifySplunkDeliverResponse ModifySplunkDeliverSync(ModifySplunkDeliverRequest req)
        {
            return InternalRequestAsync<ModifySplunkDeliverResponse>(req, "ModifySplunkDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify logs or metric topics.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// This API is used to modify logs or metric topics.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify alarm channel callback configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebCallbackRequest"/></param>
        /// <returns><see cref="ModifyWebCallbackResponse"/></returns>
        public Task<ModifyWebCallbackResponse> ModifyWebCallback(ModifyWebCallbackRequest req)
        {
            return InternalRequestAsync<ModifyWebCallbackResponse>(req, "ModifyWebCallback");
        }

        /// <summary>
        /// This API is used to modify alarm channel callback configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebCallbackRequest"/></param>
        /// <returns><see cref="ModifyWebCallbackResponse"/></returns>
        public ModifyWebCallbackResponse ModifyWebCallbackSync(ModifyWebCallbackRequest req)
        {
            return InternalRequestAsync<ModifyWebCallbackResponse>(req, "ModifyWebCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create resources and indexes dependent on OpenClaw.
        /// </summary>
        /// <param name="req"><see cref="OpenClawServiceRequest"/></param>
        /// <returns><see cref="OpenClawServiceResponse"/></returns>
        public Task<OpenClawServiceResponse> OpenClawService(OpenClawServiceRequest req)
        {
            return InternalRequestAsync<OpenClawServiceResponse>(req, "OpenClawService");
        }

        /// <summary>
        /// This API is used to create resources and indexes dependent on OpenClaw.
        /// </summary>
        /// <param name="req"><see cref="OpenClawServiceRequest"/></param>
        /// <returns><see cref="OpenClawServiceResponse"/></returns>
        public OpenClawServiceResponse OpenClawServiceSync(OpenClawServiceRequest req)
        {
            return InternalRequestAsync<OpenClawServiceResponse>(req, "OpenClawService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable logging
        /// This API is used to enable CLS in all regions by filling any region for Region, recommend using Guangzhou (ap-guangzhou).
        /// </summary>
        /// <param name="req"><see cref="OpenClsServiceRequest"/></param>
        /// <returns><see cref="OpenClsServiceResponse"/></returns>
        public Task<OpenClsServiceResponse> OpenClsService(OpenClsServiceRequest req)
        {
            return InternalRequestAsync<OpenClsServiceResponse>(req, "OpenClsService");
        }

        /// <summary>
        /// Enable logging
        /// This API is used to enable CLS in all regions by filling any region for Region, recommend using Guangzhou (ap-guangzhou).
        /// </summary>
        /// <param name="req"><see cref="OpenClsServiceRequest"/></param>
        /// <returns><see cref="OpenClsServiceResponse"/></returns>
        public OpenClsServiceResponse OpenClsServiceSync(OpenClsServiceRequest req)
        {
            return InternalRequestAsync<OpenClsServiceResponse>(req, "OpenClsService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the Kafka consumption feature.
        /// </summary>
        /// <param name="req"><see cref="OpenKafkaConsumerRequest"/></param>
        /// <returns><see cref="OpenKafkaConsumerResponse"/></returns>
        public Task<OpenKafkaConsumerResponse> OpenKafkaConsumer(OpenKafkaConsumerRequest req)
        {
            return InternalRequestAsync<OpenKafkaConsumerResponse>(req, "OpenKafkaConsumer");
        }

        /// <summary>
        /// This API is used to enable the Kafka consumption feature.
        /// </summary>
        /// <param name="req"><see cref="OpenKafkaConsumerRequest"/></param>
        /// <returns><see cref="OpenKafkaConsumerResponse"/></returns>
        public OpenKafkaConsumerResponse OpenKafkaConsumerSync(OpenKafkaConsumerRequest req)
        {
            return InternalRequestAsync<OpenKafkaConsumerResponse>(req, "OpenKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview the logs of Kafka data subscription tasks.
        /// </summary>
        /// <param name="req"><see cref="PreviewKafkaRechargeRequest"/></param>
        /// <returns><see cref="PreviewKafkaRechargeResponse"/></returns>
        public Task<PreviewKafkaRechargeResponse> PreviewKafkaRecharge(PreviewKafkaRechargeRequest req)
        {
            return InternalRequestAsync<PreviewKafkaRechargeResponse>(req, "PreviewKafkaRecharge");
        }

        /// <summary>
        /// This API is used to preview the logs of Kafka data subscription tasks.
        /// </summary>
        /// <param name="req"><see cref="PreviewKafkaRechargeRequest"/></param>
        /// <returns><see cref="PreviewKafkaRechargeResponse"/></returns>
        public PreviewKafkaRechargeResponse PreviewKafkaRechargeSync(PreviewKafkaRechargeRequest req)
        {
            return InternalRequestAsync<PreviewKafkaRechargeResponse>(req, "PreviewKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the latest metric value at a specified time.
        /// If there is no metric data in the 5 minutes before that moment, there will be no query result.
        /// </summary>
        /// <param name="req"><see cref="QueryMetricRequest"/></param>
        /// <returns><see cref="QueryMetricResponse"/></returns>
        public Task<QueryMetricResponse> QueryMetric(QueryMetricRequest req)
        {
            return InternalRequestAsync<QueryMetricResponse>(req, "QueryMetric");
        }

        /// <summary>
        /// Query the latest metric value at a specified time.
        /// If there is no metric data in the 5 minutes before that moment, there will be no query result.
        /// </summary>
        /// <param name="req"><see cref="QueryMetricRequest"/></param>
        /// <returns><see cref="QueryMetricResponse"/></returns>
        public QueryMetricResponse QueryMetricSync(QueryMetricRequest req)
        {
            return InternalRequestAsync<QueryMetricResponse>(req, "QueryMetric")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of metrics within a specified time range.
        /// </summary>
        /// <param name="req"><see cref="QueryRangeMetricRequest"/></param>
        /// <returns><see cref="QueryRangeMetricResponse"/></returns>
        public Task<QueryRangeMetricResponse> QueryRangeMetric(QueryRangeMetricRequest req)
        {
            return InternalRequestAsync<QueryRangeMetricResponse>(req, "QueryRangeMetric");
        }

        /// <summary>
        /// This API is used to query the trend of metrics within a specified time range.
        /// </summary>
        /// <param name="req"><see cref="QueryRangeMetricRequest"/></param>
        /// <returns><see cref="QueryRangeMetricResponse"/></returns>
        public QueryRangeMetricResponse QueryRangeMetricSync(QueryRangeMetricRequest req)
        {
            return InternalRequestAsync<QueryRangeMetricResponse>(req, "QueryRangeMetric")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry a failed shipping task.
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public Task<RetryShipperTaskResponse> RetryShipperTask(RetryShipperTaskRequest req)
        {
            return InternalRequestAsync<RetryShipperTaskResponse>(req, "RetryShipperTask");
        }

        /// <summary>
        /// This API is used to retry a failed shipping task.
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public RetryShipperTaskResponse RetryShipperTaskSync(RetryShipperTaskRequest req)
        {
            return InternalRequestAsync<RetryShipperTaskResponse>(req, "RetryShipperTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview COS import information.
        /// </summary>
        /// <param name="req"><see cref="SearchCosRechargeInfoRequest"/></param>
        /// <returns><see cref="SearchCosRechargeInfoResponse"/></returns>
        public Task<SearchCosRechargeInfoResponse> SearchCosRechargeInfo(SearchCosRechargeInfoRequest req)
        {
            return InternalRequestAsync<SearchCosRechargeInfoResponse>(req, "SearchCosRechargeInfo");
        }

        /// <summary>
        /// This API is used to preview COS import information.
        /// </summary>
        /// <param name="req"><see cref="SearchCosRechargeInfoRequest"/></param>
        /// <returns><see cref="SearchCosRechargeInfoResponse"/></returns>
        public SearchCosRechargeInfoResponse SearchCosRechargeInfoSync(SearchCosRechargeInfoRequest req)
        {
            return InternalRequestAsync<SearchCosRechargeInfoResponse>(req, "SearchCosRechargeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview the dashboard subscription.
        /// </summary>
        /// <param name="req"><see cref="SearchDashboardSubscribeRequest"/></param>
        /// <returns><see cref="SearchDashboardSubscribeResponse"/></returns>
        public Task<SearchDashboardSubscribeResponse> SearchDashboardSubscribe(SearchDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<SearchDashboardSubscribeResponse>(req, "SearchDashboardSubscribe");
        }

        /// <summary>
        /// This API is used to preview the dashboard subscription.
        /// </summary>
        /// <param name="req"><see cref="SearchDashboardSubscribeRequest"/></param>
        /// <returns><see cref="SearchDashboardSubscribeResponse"/></returns>
        public SearchDashboardSubscribeResponse SearchDashboardSubscribeSync(SearchDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<SearchDashboardSubscribeResponse>(req, "SearchDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve and analyze logs. Please note the following matters when using this API.
        /// 1. Besides being subject to the default API request rate limit, for a single log topic, the number of concurrent queries cannot exceed 15.
        /// 2. The API's return data packet maximum is 49MB. It is recommended to enable gzip compression (HTTP Request Header Accept-Encoding: gzip).
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog");
        }

        /// <summary>
        /// This API is used to retrieve and analyze logs. Please note the following matters when using this API.
        /// 1. Besides being subject to the default API request rate limit, for a single log topic, the number of concurrent queries cannot exceed 15.
        /// 2. The API's return data packet maximum is 49MB. It is recommended to enable gzip compression (HTTP Request Header Accept-Encoding: gzip).
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the heartbeat of a consumer group.
        /// </summary>
        /// <param name="req"><see cref="SendConsumerHeartbeatRequest"/></param>
        /// <returns><see cref="SendConsumerHeartbeatResponse"/></returns>
        public Task<SendConsumerHeartbeatResponse> SendConsumerHeartbeat(SendConsumerHeartbeatRequest req)
        {
            return InternalRequestAsync<SendConsumerHeartbeatResponse>(req, "SendConsumerHeartbeat");
        }

        /// <summary>
        /// This API is used to check the heartbeat of a consumer group.
        /// </summary>
        /// <param name="req"><see cref="SendConsumerHeartbeatRequest"/></param>
        /// <returns><see cref="SendConsumerHeartbeatResponse"/></returns>
        public SendConsumerHeartbeatResponse SendConsumerHeartbeatSync(SendConsumerHeartbeatRequest req)
        {
            return InternalRequestAsync<SendConsumerHeartbeatResponse>(req, "SendConsumerHeartbeat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is deprecated. If needed, please use the ModifyTopic API to change the number of partitions.
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public Task<SplitPartitionResponse> SplitPartition(SplitPartitionRequest req)
        {
            return InternalRequestAsync<SplitPartitionResponse>(req, "SplitPartition");
        }

        /// <summary>
        /// This API is deprecated. If needed, please use the ModifyTopic API to change the number of partitions.
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public SplitPartitionResponse SplitPartitionSync(SplitPartitionRequest req)
        {
            return InternalRequestAsync<SplitPartitionResponse>(req, "SplitPartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ## Notification
        /// To ensure the reliability of your log data and use the log service more efficiently, we recommend that you use the CLS-optimized API to upload structured logs (https://www.tencentcloud.com/document/product/614/16873?from_cn_redirect=1).
        /// 
        /// Meanwhile, we have specially optimized and customized SDKs in multiple languages for this API for you to choose from. The SDK provides unified async sending, resource control, automatic retry, graceful shutdown, perception reporting, and other features to improve the log reporting function. For details, refer to [SDK Collection](https://www.tencentcloud.com/document/product/614/67157?from_cn_redirect=1).
        /// 
        /// Meanwhile, the log upload API also supports synchronous log data upload. If you select to continue using this API, refer to the following text.
        /// 
        /// ## Feature Description
        /// 
        /// This API is used to write logs to the designated log topic.
        /// 
        /// #### Input parameter (pb binary stream, located in body)
        /// 
        /// | Field name | Data type | Location | Must | Description |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb   | Yes | logGroup list, encapsulated content of the log group list. It is advisable not to exceed 5 logGroups. |
        /// 
        /// Group description:
        /// 
        /// | Field name | Required or optional | Description |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | is       | a log array, which means a set of multiple logs. One Log represents one log, and the number of logs in one LogGroup cannot exceed 10000 |
        /// | contextFlow | No | The unique ID of LogGroup, which must be imported when using context features. Format: "{context ID}-{LogGroupID}".<br>Context ID: A unique identifier for a context (a series of consecutively scrolled log files or a sequence of logs requiring order preservation), a 64-bit integer string in base 16.<br>LogGroupID: A consecutively incremental integer string in base 16. Example: "102700A66102516A-59F59".
        /// | filename    | No       | Log file name |
        /// | source      | No       | Log source, using machine IP as a label in general use       |
        /// | logTags     | No       | Log tag list                                               |
        /// 
        /// Log description:
        /// 
        /// | field name | Required or optional | Description |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time     | is       | log time (Unix timestamp), supports second, millisecond, microsecond, milliseconds is recommended |
        /// | contents | No | Key-value formatted log content, representing multiple key-value composites in a log |
        /// 
        /// Content description:
        /// 
        /// | Field name | Required or optional | Description |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | Yes       | The key value of a field group in a single-line log. It cannot start with `_` |
        /// | value  | Yes       | The value of a field group in a single-line log. The value of a single-line log must not exceed 1MB, and the sum of ALL values in a LogGroup cannot exceed 5MB. |
        /// 
        /// LogTag description:
        /// 
        /// | Field name | Required or optional | Description |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | Yes      | Custom tag key                 |
        /// | value  | is       | value corresponding to the custom tag key |
        /// 
        /// ## PB Compilation Example
        /// 
        /// This example shows how to use the official protoc compiler to compile and generate a C++ language adjustable log upload API from a description file.
        /// 
        /// Currently protoc officially supports compilation for languages such as Java, C++, and Python. For details, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// #### 1. Protocol Buffer installation
        /// 
        /// Download [Protocol Buffer](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz), unzip and install. The example version is protobuf 2.6.1, and the environment is Centos 7.3 system. Decompress the `protobuf-2.6.1.tar.gz` compressed package to the `/usr/local` directory and enter the directory. Execute the command as follows:
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// Start compilation and installation, configure environment variables, execute the command as follows:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// After successful compilation, view the version using the following command:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. Create PB description file
        /// 
        /// The PB description file is the data interchange format agreed by the communication parties. When uploading logs, compile the specified protocol format into the calling interface of the corresponding language version, then add to engineering code. For details, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// Create a local PB message description file cls.proto based on the PB data format specified by the log service.
        /// 
        /// !PB description file content immutable, and the file name must end with `.proto`.
        /// 
        /// The content of cls.proto (PB description file) is as follows:
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        /// required string key = 1; // key for each group of fields
        /// required string value = 2; // The value of the group field
        ///     }
        /// required int64   time     = 1; // A timestamp in UNIX time format
        /// repeated Content contents = 2; // multiple kv combinations in a log
        /// }
        /// 
        /// message LogTag
        /// {
        ///     required string key       = 1;
        ///     required string value     = 2;
        /// }
        /// 
        /// message LogGroup
        /// {
        /// repeated Log    logs        = 1; // log array composed of multiple logs
        /// optional string contextFlow = 2; // Currently no utility
        /// optional string filename = 3; // log file name
        /// optional string source      = 4; // log source, general use machine IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        /// repeated LogGroup logGroupList = 1; // log group list
        /// }
        /// ```
        /// 
        /// #### 3. Compile and generate
        /// 
        /// In this example, use the proto compiler to generate C++ language files under the same directory as the cls.proto file and execute the following compilation command:
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// `--cpp_out=./` means compile to cpp format and output in the current directory. `./cls.proto` refers to the cls.proto description file located in the current directory.
        /// 
        /// After successful compilation, it will output the code file in the corresponding language. This routine generates the cls.pb.h header file and the cls.pb.cc code implementation file, as shown below:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. Call
        /// 
        /// Import the generated cls.pb.h header file into the code and call the interface to encapsulate the data format.
        /// </summary>
        /// <param name="req"><see cref="UploadLogRequest"/></param>
        /// <returns><see cref="UploadLogResponse"/></returns>
        public Task<UploadLogResponse> UploadLog(UploadLogRequest req)
        {
            return InternalRequestAsync<UploadLogResponse>(req, "UploadLog");
        }

        /// <summary>
        /// ## Notification
        /// To ensure the reliability of your log data and use the log service more efficiently, we recommend that you use the CLS-optimized API to upload structured logs (https://www.tencentcloud.com/document/product/614/16873?from_cn_redirect=1).
        /// 
        /// Meanwhile, we have specially optimized and customized SDKs in multiple languages for this API for you to choose from. The SDK provides unified async sending, resource control, automatic retry, graceful shutdown, perception reporting, and other features to improve the log reporting function. For details, refer to [SDK Collection](https://www.tencentcloud.com/document/product/614/67157?from_cn_redirect=1).
        /// 
        /// Meanwhile, the log upload API also supports synchronous log data upload. If you select to continue using this API, refer to the following text.
        /// 
        /// ## Feature Description
        /// 
        /// This API is used to write logs to the designated log topic.
        /// 
        /// #### Input parameter (pb binary stream, located in body)
        /// 
        /// | Field name | Data type | Location | Must | Description |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb   | Yes | logGroup list, encapsulated content of the log group list. It is advisable not to exceed 5 logGroups. |
        /// 
        /// Group description:
        /// 
        /// | Field name | Required or optional | Description |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | is       | a log array, which means a set of multiple logs. One Log represents one log, and the number of logs in one LogGroup cannot exceed 10000 |
        /// | contextFlow | No | The unique ID of LogGroup, which must be imported when using context features. Format: "{context ID}-{LogGroupID}".<br>Context ID: A unique identifier for a context (a series of consecutively scrolled log files or a sequence of logs requiring order preservation), a 64-bit integer string in base 16.<br>LogGroupID: A consecutively incremental integer string in base 16. Example: "102700A66102516A-59F59".
        /// | filename    | No       | Log file name |
        /// | source      | No       | Log source, using machine IP as a label in general use       |
        /// | logTags     | No       | Log tag list                                               |
        /// 
        /// Log description:
        /// 
        /// | field name | Required or optional | Description |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time     | is       | log time (Unix timestamp), supports second, millisecond, microsecond, milliseconds is recommended |
        /// | contents | No | Key-value formatted log content, representing multiple key-value composites in a log |
        /// 
        /// Content description:
        /// 
        /// | Field name | Required or optional | Description |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | Yes       | The key value of a field group in a single-line log. It cannot start with `_` |
        /// | value  | Yes       | The value of a field group in a single-line log. The value of a single-line log must not exceed 1MB, and the sum of ALL values in a LogGroup cannot exceed 5MB. |
        /// 
        /// LogTag description:
        /// 
        /// | Field name | Required or optional | Description |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | Yes      | Custom tag key                 |
        /// | value  | is       | value corresponding to the custom tag key |
        /// 
        /// ## PB Compilation Example
        /// 
        /// This example shows how to use the official protoc compiler to compile and generate a C++ language adjustable log upload API from a description file.
        /// 
        /// Currently protoc officially supports compilation for languages such as Java, C++, and Python. For details, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// #### 1. Protocol Buffer installation
        /// 
        /// Download [Protocol Buffer](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz), unzip and install. The example version is protobuf 2.6.1, and the environment is Centos 7.3 system. Decompress the `protobuf-2.6.1.tar.gz` compressed package to the `/usr/local` directory and enter the directory. Execute the command as follows:
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// Start compilation and installation, configure environment variables, execute the command as follows:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// After successful compilation, view the version using the following command:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. Create PB description file
        /// 
        /// The PB description file is the data interchange format agreed by the communication parties. When uploading logs, compile the specified protocol format into the calling interface of the corresponding language version, then add to engineering code. For details, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// Create a local PB message description file cls.proto based on the PB data format specified by the log service.
        /// 
        /// !PB description file content immutable, and the file name must end with `.proto`.
        /// 
        /// The content of cls.proto (PB description file) is as follows:
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        /// required string key = 1; // key for each group of fields
        /// required string value = 2; // The value of the group field
        ///     }
        /// required int64   time     = 1; // A timestamp in UNIX time format
        /// repeated Content contents = 2; // multiple kv combinations in a log
        /// }
        /// 
        /// message LogTag
        /// {
        ///     required string key       = 1;
        ///     required string value     = 2;
        /// }
        /// 
        /// message LogGroup
        /// {
        /// repeated Log    logs        = 1; // log array composed of multiple logs
        /// optional string contextFlow = 2; // Currently no utility
        /// optional string filename = 3; // log file name
        /// optional string source      = 4; // log source, general use machine IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        /// repeated LogGroup logGroupList = 1; // log group list
        /// }
        /// ```
        /// 
        /// #### 3. Compile and generate
        /// 
        /// In this example, use the proto compiler to generate C++ language files under the same directory as the cls.proto file and execute the following compilation command:
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// `--cpp_out=./` means compile to cpp format and output in the current directory. `./cls.proto` refers to the cls.proto description file located in the current directory.
        /// 
        /// After successful compilation, it will output the code file in the corresponding language. This routine generates the cls.pb.h header file and the cls.pb.cc code implementation file, as shown below:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. Call
        /// 
        /// Import the generated cls.pb.h header file into the code and call the interface to encapsulate the data format.
        /// </summary>
        /// <param name="req"><see cref="UploadLogRequest"/></param>
        /// <returns><see cref="UploadLogResponse"/></returns>
        public UploadLogResponse UploadLogSync(UploadLogRequest req)
        {
            return InternalRequestAsync<UploadLogResponse>(req, "UploadLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
