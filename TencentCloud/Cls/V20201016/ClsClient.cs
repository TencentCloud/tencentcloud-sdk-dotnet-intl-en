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

namespace TencentCloud.Cls.V20201016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cls.V20201016.Models;

   public class ClsClient : AbstractClient{

       private const string endpoint = "cls.tencentcloudapi.com";
       private const string version = "2020-10-16";
       private const string sdkVersion = "SDK_NET_3.0.981";

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
        /// This API is used to create a notification group.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice");
        }

        /// <summary>
        /// This API is used to create a notification group.
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
        /// This API is used to create a download task. To get the returned download address, call DescribeExports to view the task list. The CosPath parameter is also included for download address. For more information, visit https://intl.cloud.tencent.com/document/product/614/56449.?from_cn_redirect=1
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public Task<CreateExportResponse> CreateExport(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport");
        }

        /// <summary>
        /// This API is used to create a download task. To get the returned download address, call DescribeExports to view the task list. The CosPath parameter is also included for download address. For more information, visit https://intl.cloud.tencent.com/document/product/614/56449.?from_cn_redirect=1
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public CreateExportResponse CreateExportSync(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport")
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
        /// This API is used to create a log topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// This API is used to create a log topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
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
        /// This API is used to delete an alarm blocking rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmShieldRequest"/></param>
        /// <returns><see cref="DeleteAlarmShieldResponse"/></returns>
        public Task<DeleteAlarmShieldResponse> DeleteAlarmShield(DeleteAlarmShieldRequest req)
        {
            return InternalRequestAsync<DeleteAlarmShieldResponse>(req, "DeleteAlarmShield");
        }

        /// <summary>
        /// This API is used to delete an alarm blocking rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmShieldRequest"/></param>
        /// <returns><see cref="DeleteAlarmShieldResponse"/></returns>
        public DeleteAlarmShieldResponse DeleteAlarmShieldSync(DeleteAlarmShieldRequest req)
        {
            return InternalRequestAsync<DeleteAlarmShieldResponse>(req, "DeleteAlarmShield")
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
        /// This API is used to delete a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public Task<DeleteConsumerResponse> DeleteConsumer(DeleteConsumerRequest req)
        {
            return InternalRequestAsync<DeleteConsumerResponse>(req, "DeleteConsumer");
        }

        /// <summary>
        /// This API is used to delete a shipping task.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public DeleteConsumerResponse DeleteConsumerSync(DeleteConsumerRequest req)
        {
            return InternalRequestAsync<DeleteConsumerResponse>(req, "DeleteConsumer")
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
        /// This API is used to delete a log topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// This API is used to delete a log topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
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
        /// This API is used to get the list of topic partitions.
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public Task<DescribePartitionsResponse> DescribePartitions(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions");
        }

        /// <summary>
        /// This API is used to get the list of topic partitions.
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public DescribePartitionsResponse DescribePartitionsSync(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions")
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
        /// This API is used to get the list of log topics and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics");
        }

        /// <summary>
        /// This API is used to get the list of log topics and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics")
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
        /// This API is used to merge a topic partition in read/write state. During merge, a topic partition ID can be specified, and CLS will automatically merge the partition adjacent to the right of the range.
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public Task<MergePartitionResponse> MergePartition(MergePartitionRequest req)
        {
            return InternalRequestAsync<MergePartitionResponse>(req, "MergePartition");
        }

        /// <summary>
        /// This API is used to merge a topic partition in read/write state. During merge, a topic partition ID can be specified, and CLS will automatically merge the partition adjacent to the right of the range.
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
        /// This API is used to modify alarm blocking rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmShieldRequest"/></param>
        /// <returns><see cref="ModifyAlarmShieldResponse"/></returns>
        public Task<ModifyAlarmShieldResponse> ModifyAlarmShield(ModifyAlarmShieldRequest req)
        {
            return InternalRequestAsync<ModifyAlarmShieldResponse>(req, "ModifyAlarmShield");
        }

        /// <summary>
        /// This API is used to modify alarm blocking rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmShieldRequest"/></param>
        /// <returns><see cref="ModifyAlarmShieldResponse"/></returns>
        public ModifyAlarmShieldResponse ModifyAlarmShieldSync(ModifyAlarmShieldRequest req)
        {
            return InternalRequestAsync<ModifyAlarmShieldResponse>(req, "ModifyAlarmShield")
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
        /// This API is used to modify a machine group.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public Task<ModifyMachineGroupResponse> ModifyMachineGroup(ModifyMachineGroupRequest req)
        {
            return InternalRequestAsync<ModifyMachineGroupResponse>(req, "ModifyMachineGroup");
        }

        /// <summary>
        /// This API is used to modify a machine group.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public ModifyMachineGroupResponse ModifyMachineGroupSync(ModifyMachineGroupRequest req)
        {
            return InternalRequestAsync<ModifyMachineGroupResponse>(req, "ModifyMachineGroup")
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
        /// This API is used to modify a log topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// This API is used to modify a log topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
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
        /// This API is used to query the latest metric value at a specified time.
        /// </summary>
        /// <param name="req"><see cref="QueryMetricRequest"/></param>
        /// <returns><see cref="QueryMetricResponse"/></returns>
        public Task<QueryMetricResponse> QueryMetric(QueryMetricRequest req)
        {
            return InternalRequestAsync<QueryMetricResponse>(req, "QueryMetric");
        }

        /// <summary>
        /// This API is used to query the latest metric value at a specified time.
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
        /// This API is used to search and analyze logs. When using this API, please note the following:1. Besides being subject to the default API request frequency limit by this API, for a single log topic, the concurrency number cannot exceed 15. 2. For search syntax, it's recommended to use the CQL syntax rule. Please use the SyntaxRule parameter and set its value to 1.
        /// 3. The maximum value of API's response data packet is 49MB. It is recommended to enable gzip compression (HTTP Request Header Accept-Encoding: gzip).
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog");
        }

        /// <summary>
        /// This API is used to search and analyze logs. When using this API, please note the following:1. Besides being subject to the default API request frequency limit by this API, for a single log topic, the concurrency number cannot exceed 15. 2. For search syntax, it's recommended to use the CQL syntax rule. Please use the SyntaxRule parameter and set its value to 1.
        /// 3. The maximum value of API's response data packet is 49MB. It is recommended to enable gzip compression (HTTP Request Header Accept-Encoding: gzip).
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to split a topic partition.
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public Task<SplitPartitionResponse> SplitPartition(SplitPartitionRequest req)
        {
            return InternalRequestAsync<SplitPartitionResponse>(req, "SplitPartition");
        }

        /// <summary>
        /// This API is used to split a topic partition.
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public SplitPartitionResponse SplitPartitionSync(SplitPartitionRequest req)
        {
            return InternalRequestAsync<SplitPartitionResponse>(req, "SplitPartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ## Note
        /// To ensure log data reliability and help you use CLS more efficiently, we recommend you use the optimized API to upload logs. For more information about the API, see [Uploading Log via API](https://intl.cloud.tencent.com/document/product/614/16873?from_cn_redirect=1).
        /// 
        /// For the optimized API, we have developed an SDK (available in multiple languages) that provides features including async sending, resource control, automatic retry, graceful shutdown, and detection-based reporting. For details, see [Uploading Log via SDK](https://intl.cloud.tencent.com/document/product/614/67157?from_cn_redirect=1).
        /// 
        /// `UploadLog` allows you to synchronously upload log data. If you still want to continue to use this API instead of the optimized one, read this document.
        /// 
        /// ## Feature Description
        /// 
        /// This API is used to write logs to a specified log topic.
        /// 
        /// CLS provides the following two modes:
        /// 
        /// #### Load balancing mode
        /// 
        /// In this mode, logs will be automatically written to a target partition among all readable/writable partitions under the current log topic based on the load balancing principle. This mode is suitable for scenarios where sequential consumption is not needed.
        /// 
        /// #### Hash routing mode
        /// 
        /// In this mode, data will be written to a target partition that meets the range requirements based on the carried hash value (`X-CLS-HashKey`). For example, a log source can be bound to a topic partition through `HashKey`, strictly guaranteeing the sequence of the data written to and consumed in this partition.
        /// 
        ///                  
        /// 
        /// #### Input parameters (pb binary streams in `body`)
        /// 
        /// | Parameter       | Type    | Location | Required | Description                                                         |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb   | Yes   | The `logGroup` list, which describes the encapsulated log groups. We recommend you enter up to five `logGroup` values. |
        /// 
        /// `LogGroup` description:
        /// 
        /// | Parameter      | Required | Description                                                         |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | Yes       | Log array consisting of multiple `Log` values. The `Log` indicates a log, and a `LogGroup` can contain up to 10,000 `Log` values. |
        /// | contextFlow | No       | Unique `LogGroup` ID, which should be passed in if the context feature needs to be used. Format: "{Context ID}-{LogGroupID}". <br>Context ID: Uniquely identifies the context (a series of log files that are continuously scrolling or a series of logs that need to be sequenced), which is a 64-bit integer hex string. <br>LogGroupID: A 64-bit integer hex string that continuously increases, such as `102700A66102516A-59F59`.                        |
        /// | filename    | No       | Log filename                                                   |
        /// | source      | No       | Log source, which is generally the machine IP                           |
        /// | logTags     | No       | List of log tags                                               |
        /// 
        /// `Log` description:
        /// 
        /// | Parameter   | Required | Description                                                         |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time     | Yes       | Unix timestamp of log time in seconds or milliseconds (recommended)      |
        /// | contents | No       | Log content in key-value format. A log can contain multiple key-value pairs. |
        /// 
        /// `Content` description:
        /// 
        /// | Parameter | Required | Description                                                         |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | Yes       | Key of a field group in one log, which cannot start with `_`.                 |
        /// | value  | Yes       | Value of a field group. The `value` of one log cannot exceed 1 MB and the total `value` in `LogGroup` cannot exceed 5 MB. |
        /// 
        /// `LogTag` description:
        /// 
        /// | Parameter | Required | Description                             |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | Yes       | Key of a custom tag                 |
        /// | value  | Yes       | Value corresponding to the custom tag key |
        /// 
        /// ## pb Compilation Example
        /// 
        /// This example shows you how to use the protoc compiler to compile a pb description file into a log upload API in C++.
        /// 
        /// > ?Currently, protoc supports compilation in multiple programming languages such as Java, C++, and Python. For more information, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// #### 1. Install protocol buffers
        /// 
        /// Download [Protocol Buffers](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz), decompress the package, and install the tool. The version used in the example is protobuf 2.6.1 running on CentOS 7.3. Run the following command to decompress the `protobuf-2.6.1.tar.gz` package to the `/usr/local` directory and go to the directory:
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// Run the following commands to start compilation and installation and configure the environment variables:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// After the compilation succeeds, run the following command to check the version:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. Create a pb description file
        /// 
        /// A pb description file is an agreed-on data interchange format for communication. To upload logs, compile the specified protocol format to an API in the target programming language and add the API to the project code. For more information, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// Create a pb message description file `cls.proto` based on the pb data format content specified by CLS.
        /// 
        /// > !The pb description file content cannot be modified, and the filename must end with `.proto`.
        /// 
        /// The content of `cls.proto` (pb description file) is as follows:
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        ///         required string key   = 1; // Key of each field group
        ///         required string value = 2; // Value of each field group
        ///     }
        ///     required int64   time     = 1; // Unix timestamp
        ///     repeated Content contents = 2; // Multiple key-value pairs in one log
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
        ///     repeated Log    logs        = 1; // Log array consisting of multiple logs
        ///     optional string contextFlow = 2; // This parameter does not take effect currently
        ///     optional string filename    = 3; // Log filename
        ///     optional string source      = 4; // Log source, which is generally the machine IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        ///     repeated LogGroup logGroupList = 1; // Log group list
        /// }
        /// ```
        /// 
        /// #### 3. Compile and generate the API
        /// 
        /// This example uses the proto compiler to generate a C++ file in the same directory as the `cls.proto` file. Run the following compilation command:
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// > ?`--cpp_out=./` indicates that the file will be compiled in cpp format and output to the current directory. `./cls.proto` indicates the `cls.proto` description file in the current directory.
        /// 
        /// After the compilation succeeds, the code file in the corresponding programming language will be generated. This example generates the `cls.pb.h` header file and [cls.pb.cc](http://cls.pb.cc) code implementation file as shown below:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. Call the API
        /// 
        /// Import the generated `cls.pb.h` header file into the code and call the API for data encapsulation.
        /// </summary>
        /// <param name="req"><see cref="UploadLogRequest"/></param>
        /// <returns><see cref="UploadLogResponse"/></returns>
        public Task<UploadLogResponse> UploadLog(UploadLogRequest req)
        {
            return InternalRequestAsync<UploadLogResponse>(req, "UploadLog");
        }

        /// <summary>
        /// ## Note
        /// To ensure log data reliability and help you use CLS more efficiently, we recommend you use the optimized API to upload logs. For more information about the API, see [Uploading Log via API](https://intl.cloud.tencent.com/document/product/614/16873?from_cn_redirect=1).
        /// 
        /// For the optimized API, we have developed an SDK (available in multiple languages) that provides features including async sending, resource control, automatic retry, graceful shutdown, and detection-based reporting. For details, see [Uploading Log via SDK](https://intl.cloud.tencent.com/document/product/614/67157?from_cn_redirect=1).
        /// 
        /// `UploadLog` allows you to synchronously upload log data. If you still want to continue to use this API instead of the optimized one, read this document.
        /// 
        /// ## Feature Description
        /// 
        /// This API is used to write logs to a specified log topic.
        /// 
        /// CLS provides the following two modes:
        /// 
        /// #### Load balancing mode
        /// 
        /// In this mode, logs will be automatically written to a target partition among all readable/writable partitions under the current log topic based on the load balancing principle. This mode is suitable for scenarios where sequential consumption is not needed.
        /// 
        /// #### Hash routing mode
        /// 
        /// In this mode, data will be written to a target partition that meets the range requirements based on the carried hash value (`X-CLS-HashKey`). For example, a log source can be bound to a topic partition through `HashKey`, strictly guaranteeing the sequence of the data written to and consumed in this partition.
        /// 
        ///                  
        /// 
        /// #### Input parameters (pb binary streams in `body`)
        /// 
        /// | Parameter       | Type    | Location | Required | Description                                                         |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb   | Yes   | The `logGroup` list, which describes the encapsulated log groups. We recommend you enter up to five `logGroup` values. |
        /// 
        /// `LogGroup` description:
        /// 
        /// | Parameter      | Required | Description                                                         |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | Yes       | Log array consisting of multiple `Log` values. The `Log` indicates a log, and a `LogGroup` can contain up to 10,000 `Log` values. |
        /// | contextFlow | No       | Unique `LogGroup` ID, which should be passed in if the context feature needs to be used. Format: "{Context ID}-{LogGroupID}". <br>Context ID: Uniquely identifies the context (a series of log files that are continuously scrolling or a series of logs that need to be sequenced), which is a 64-bit integer hex string. <br>LogGroupID: A 64-bit integer hex string that continuously increases, such as `102700A66102516A-59F59`.                        |
        /// | filename    | No       | Log filename                                                   |
        /// | source      | No       | Log source, which is generally the machine IP                           |
        /// | logTags     | No       | List of log tags                                               |
        /// 
        /// `Log` description:
        /// 
        /// | Parameter   | Required | Description                                                         |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time     | Yes       | Unix timestamp of log time in seconds or milliseconds (recommended)      |
        /// | contents | No       | Log content in key-value format. A log can contain multiple key-value pairs. |
        /// 
        /// `Content` description:
        /// 
        /// | Parameter | Required | Description                                                         |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | Yes       | Key of a field group in one log, which cannot start with `_`.                 |
        /// | value  | Yes       | Value of a field group. The `value` of one log cannot exceed 1 MB and the total `value` in `LogGroup` cannot exceed 5 MB. |
        /// 
        /// `LogTag` description:
        /// 
        /// | Parameter | Required | Description                             |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | Yes       | Key of a custom tag                 |
        /// | value  | Yes       | Value corresponding to the custom tag key |
        /// 
        /// ## pb Compilation Example
        /// 
        /// This example shows you how to use the protoc compiler to compile a pb description file into a log upload API in C++.
        /// 
        /// > ?Currently, protoc supports compilation in multiple programming languages such as Java, C++, and Python. For more information, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// #### 1. Install protocol buffers
        /// 
        /// Download [Protocol Buffers](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz), decompress the package, and install the tool. The version used in the example is protobuf 2.6.1 running on CentOS 7.3. Run the following command to decompress the `protobuf-2.6.1.tar.gz` package to the `/usr/local` directory and go to the directory:
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// Run the following commands to start compilation and installation and configure the environment variables:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// After the compilation succeeds, run the following command to check the version:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. Create a pb description file
        /// 
        /// A pb description file is an agreed-on data interchange format for communication. To upload logs, compile the specified protocol format to an API in the target programming language and add the API to the project code. For more information, see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// Create a pb message description file `cls.proto` based on the pb data format content specified by CLS.
        /// 
        /// > !The pb description file content cannot be modified, and the filename must end with `.proto`.
        /// 
        /// The content of `cls.proto` (pb description file) is as follows:
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        ///         required string key   = 1; // Key of each field group
        ///         required string value = 2; // Value of each field group
        ///     }
        ///     required int64   time     = 1; // Unix timestamp
        ///     repeated Content contents = 2; // Multiple key-value pairs in one log
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
        ///     repeated Log    logs        = 1; // Log array consisting of multiple logs
        ///     optional string contextFlow = 2; // This parameter does not take effect currently
        ///     optional string filename    = 3; // Log filename
        ///     optional string source      = 4; // Log source, which is generally the machine IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        ///     repeated LogGroup logGroupList = 1; // Log group list
        /// }
        /// ```
        /// 
        /// #### 3. Compile and generate the API
        /// 
        /// This example uses the proto compiler to generate a C++ file in the same directory as the `cls.proto` file. Run the following compilation command:
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// > ?`--cpp_out=./` indicates that the file will be compiled in cpp format and output to the current directory. `./cls.proto` indicates the `cls.proto` description file in the current directory.
        /// 
        /// After the compilation succeeds, the code file in the corresponding programming language will be generated. This example generates the `cls.pb.h` header file and [cls.pb.cc](http://cls.pb.cc) code implementation file as shown below:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. Call the API
        /// 
        /// Import the generated `cls.pb.h` header file into the code and call the API for data encapsulation.
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
