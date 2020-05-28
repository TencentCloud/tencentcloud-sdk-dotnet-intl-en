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

namespace TencentCloud.Monitor.V20180724
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20180724.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.tencentcloudapi.com";
       private const string version = "2018-07-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to bind an alarm policy to a specific object.
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public async Task<BindingPolicyObjectResponse> BindingPolicyObject(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an alarm policy to a specific object.
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public BindingPolicyObjectResponse BindingPolicyObjectSync(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a policy group.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroup(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a policy group.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public CreatePolicyGroupResponse CreatePolicyGroupSync(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy group.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroup(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy group.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public DeletePolicyGroupResponse DeletePolicyGroupSync(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the platform event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public async Task<DescribeAccidentEventListResponse> DescribeAccidentEventList(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the platform event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public DescribeAccidentEventListResponse DescribeAccidentEventListSync(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public async Task<DescribeBaseMetricsResponse> DescribeBaseMetrics(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public DescribeBaseMetricsResponse DescribeBaseMetricsSync(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the basic alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public async Task<DescribeBasicAlarmListResponse> DescribeBasicAlarmList(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the basic alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public DescribeBasicAlarmListResponse DescribeBasicAlarmListSync(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bound object list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public async Task<DescribeBindingPolicyObjectListResponse> DescribeBindingPolicyObjectList(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bound object list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public DescribeBindingPolicyObjectListResponse DescribeBindingPolicyObjectListSync(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get basic alarm policy conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public async Task<DescribePolicyConditionListResponse> DescribePolicyConditionList(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get basic alarm policy conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public DescribePolicyConditionListResponse DescribePolicyConditionListSync(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get details of a basic policy group.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public async Task<DescribePolicyGroupInfoResponse> DescribePolicyGroupInfo(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get details of a basic policy group.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public DescribePolicyGroupInfoResponse DescribePolicyGroupInfoSync(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of basic policy alarm groups.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public async Task<DescribePolicyGroupListResponse> DescribePolicyGroupList(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of basic policy alarm groups.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public DescribePolicyGroupListResponse DescribePolicyGroupListSync(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of product events by page.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public async Task<DescribeProductEventListResponse> DescribeProductEventList(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of product events by page.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public DescribeProductEventListResponse DescribeProductEventListSync(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the monitoring data of a Tencent Cloud product by passing in the product's namespace, object dimension description, and monitoring metric.
        /// API call rate limit: 20 calls/sec, 1,200 calls/min.
        /// If you need to call a lot of metrics and objects, there may be cases where the call fails due to the rate limit. It is recommended to spread the call requests as much as possible over time.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public async Task<GetMonitorDataResponse> GetMonitorData(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the monitoring data of a Tencent Cloud product by passing in the product's namespace, object dimension description, and monitoring metric.
        /// API call rate limit: 20 calls/sec, 1,200 calls/min.
        /// If you need to call a lot of metrics and objects, there may be cases where the call fails due to the rate limit. It is recommended to spread the call requests as much as possible over time.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public GetMonitorDataResponse GetMonitorDataSync(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public async Task<ModifyAlarmReceiversResponse> ModifyAlarmReceivers(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public ModifyAlarmReceiversResponse ModifyAlarmReceiversSync(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update policy group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroup(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update policy group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroupSync(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The default API request rate limit is 50 requests/sec.
        /// The default upper limit on metrics of a single tenant is 100.
        /// A maximum of 30 metric/value pairs can be reported at a time. When an error is returned for a request, no metrics/values in the request will be saved.
        /// 
        /// The reporting timestamp is the timestamp when you want to save the data. We recommend that you construct a timestamp at integer minutes.
        /// The time range of a timestamp is from 300 seconds before the current time to the current time.
        /// The data of the same IP metric/value pair must be reported by minute in chronological order.
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public async Task<PutMonitorDataResponse> PutMonitorData(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The default API request rate limit is 50 requests/sec.
        /// The default upper limit on metrics of a single tenant is 100.
        /// A maximum of 30 metric/value pairs can be reported at a time. When an error is returned for a request, no metrics/values in the request will be saved.
        /// 
        /// The reporting timestamp is the timestamp when you want to save the data. We recommend that you construct a timestamp at integer minutes.
        /// The time range of a timestamp is from 300 seconds before the current time to the current time.
        /// The data of the same IP metric/value pair must be reported by minute in chronological order.
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public PutMonitorDataResponse PutMonitorDataSync(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a custom alarm notification.
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public async Task<SendCustomAlarmMsgResponse> SendCustomAlarmMsg(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a custom alarm notification.
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public SendCustomAlarmMsgResponse SendCustomAlarmMsgSync(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete all bound objects.
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public async Task<UnBindingAllPolicyObjectResponse> UnBindingAllPolicyObject(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete all bound objects.
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public UnBindingAllPolicyObjectResponse UnBindingAllPolicyObjectSync(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an object that is bound to a policy.
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public async Task<UnBindingPolicyObjectResponse> UnBindingPolicyObject(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an object that is bound to a policy.
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public UnBindingPolicyObjectResponse UnBindingPolicyObjectSync(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
