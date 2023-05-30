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

namespace TencentCloud.Tiw.V20190919
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tiw.V20190919.Models;

   public class TiwClient : AbstractClient{

       private const string endpoint = "tiw.tencentcloudapi.com";
       private const string version = "2019-09-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TiwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to apply for a Tencent Interactive Whiteboard trial (15-day by default).
        /// </summary>
        /// <param name="req"><see cref="ApplyTiwTrialRequest"/></param>
        /// <returns><see cref="ApplyTiwTrialResponse"/></returns>
        public async Task<ApplyTiwTrialResponse> ApplyTiwTrial(ApplyTiwTrialRequest req)
        {
             JsonResponseModel<ApplyTiwTrialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyTiwTrial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyTiwTrialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a Tencent Interactive Whiteboard trial (15-day by default).
        /// </summary>
        /// <param name="req"><see cref="ApplyTiwTrialRequest"/></param>
        /// <returns><see cref="ApplyTiwTrialResponse"/></returns>
        public ApplyTiwTrialResponse ApplyTiwTrialSync(ApplyTiwTrialRequest req)
        {
             JsonResponseModel<ApplyTiwTrialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyTiwTrial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyTiwTrialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public async Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an offline recording task.
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineRecordRequest"/></param>
        /// <returns><see cref="CreateOfflineRecordResponse"/></returns>
        public async Task<CreateOfflineRecordResponse> CreateOfflineRecord(CreateOfflineRecordRequest req)
        {
             JsonResponseModel<CreateOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an offline recording task.
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineRecordRequest"/></param>
        /// <returns><see cref="CreateOfflineRecordResponse"/></returns>
        public CreateOfflineRecordResponse CreateOfflineRecordSync(CreateOfflineRecordRequest req)
        {
             JsonResponseModel<CreateOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a whiteboard snapshot task. If a callback URL is provided, the whiteboard snapshot result is sent to the callback URL after the task is complete.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public async Task<CreateSnapshotTaskResponse> CreateSnapshotTask(CreateSnapshotTaskRequest req)
        {
             JsonResponseModel<CreateSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a whiteboard snapshot task. If a callback URL is provided, the whiteboard snapshot result is sent to the callback URL after the task is complete.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public CreateSnapshotTaskResponse CreateSnapshotTaskSync(CreateSnapshotTaskRequest req)
        {
             JsonResponseModel<CreateSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public async Task<CreateTranscodeResponse> CreateTranscode(CreateTranscodeRequest req)
        {
             JsonResponseModel<CreateTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public CreateTranscodeResponse CreateTranscodeSync(CreateTranscodeRequest req)
        {
             JsonResponseModel<CreateTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public async Task<CreateVideoGenerationTaskResponse> CreateVideoGenerationTask(CreateVideoGenerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public CreateVideoGenerationTaskResponse CreateVideoGenerationTaskSync(CreateVideoGenerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information about other cloud products by using the service role.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeAPIServiceResponse"/></returns>
        public async Task<DescribeAPIServiceResponse> DescribeAPIService(DescribeAPIServiceRequest req)
        {
             JsonResponseModel<DescribeAPIServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAPIService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information about other cloud products by using the service role.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeAPIServiceResponse"/></returns>
        public DescribeAPIServiceResponse DescribeAPIServiceSync(DescribeAPIServiceRequest req)
        {
             JsonResponseModel<DescribeAPIServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAPIService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfosRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfosResponse"/></returns>
        public async Task<DescribeApplicationInfosResponse> DescribeApplicationInfos(DescribeApplicationInfosRequest req)
        {
             JsonResponseModel<DescribeApplicationInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfosRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfosResponse"/></returns>
        public DescribeApplicationInfosResponse DescribeApplicationInfosSync(DescribeApplicationInfosRequest req)
        {
             JsonResponseModel<DescribeApplicationInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the subproduct usage of Tencent Interactive Whiteboard.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationUsageRequest"/></param>
        /// <returns><see cref="DescribeApplicationUsageResponse"/></returns>
        public async Task<DescribeApplicationUsageResponse> DescribeApplicationUsage(DescribeApplicationUsageRequest req)
        {
             JsonResponseModel<DescribeApplicationUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the subproduct usage of Tencent Interactive Whiteboard.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationUsageRequest"/></param>
        /// <returns><see cref="DescribeApplicationUsageResponse"/></returns>
        public DescribeApplicationUsageResponse DescribeApplicationUsageSync(DescribeApplicationUsageRequest req)
        {
             JsonResponseModel<DescribeApplicationUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the logs of a whiteboard application on a client.
        /// </summary>
        /// <param name="req"><see cref="DescribeBoardSDKLogRequest"/></param>
        /// <returns><see cref="DescribeBoardSDKLogResponse"/></returns>
        public async Task<DescribeBoardSDKLogResponse> DescribeBoardSDKLog(DescribeBoardSDKLogRequest req)
        {
             JsonResponseModel<DescribeBoardSDKLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBoardSDKLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBoardSDKLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the logs of a whiteboard application on a client.
        /// </summary>
        /// <param name="req"><see cref="DescribeBoardSDKLogRequest"/></param>
        /// <returns><see cref="DescribeBoardSDKLogResponse"/></returns>
        public DescribeBoardSDKLogResponse DescribeBoardSDKLogSync(DescribeBoardSDKLogRequest req)
        {
             JsonResponseModel<DescribeBoardSDKLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBoardSDKLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBoardSDKLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instant messaging (IM) applications that are available for creating a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeIMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeIMApplicationsResponse"/></returns>
        public async Task<DescribeIMApplicationsResponse> DescribeIMApplications(DescribeIMApplicationsRequest req)
        {
             JsonResponseModel<DescribeIMApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIMApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIMApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instant messaging (IM) applications that are available for creating a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeIMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeIMApplicationsResponse"/></returns>
        public DescribeIMApplicationsResponse DescribeIMApplicationsSync(DescribeIMApplicationsRequest req)
        {
             JsonResponseModel<DescribeIMApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIMApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIMApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information about an offline recording task, including the recording progress and recording result.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordResponse"/></returns>
        public async Task<DescribeOfflineRecordResponse> DescribeOfflineRecord(DescribeOfflineRecordRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information about an offline recording task, including the recording progress and recording result.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordResponse"/></returns>
        public DescribeOfflineRecordResponse DescribeOfflineRecordSync(DescribeOfflineRecordRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the offline recording callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordCallbackResponse"/></returns>
        public async Task<DescribeOfflineRecordCallbackResponse> DescribeOfflineRecordCallback(DescribeOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the offline recording callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordCallbackResponse"/></returns>
        public DescribeOfflineRecordCallbackResponse DescribeOfflineRecordCallbackSync(DescribeOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status and result of a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public async Task<DescribeOnlineRecordResponse> DescribeOnlineRecord(DescribeOnlineRecordRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status and result of a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public DescribeOnlineRecordResponse DescribeOnlineRecordSync(DescribeOnlineRecordRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time recording callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public async Task<DescribeOnlineRecordCallbackResponse> DescribeOnlineRecordCallback(DescribeOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time recording callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public DescribeOnlineRecordCallbackResponse DescribeOnlineRecordCallbackSync(DescribeOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the pay-as-you-go usage of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribePostpaidUsageRequest"/></param>
        /// <returns><see cref="DescribePostpaidUsageResponse"/></returns>
        public async Task<DescribePostpaidUsageResponse> DescribePostpaidUsage(DescribePostpaidUsageRequest req)
        {
             JsonResponseModel<DescribePostpaidUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePostpaidUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpaidUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the pay-as-you-go usage of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribePostpaidUsageRequest"/></param>
        /// <returns><see cref="DescribePostpaidUsageResponse"/></returns>
        public DescribePostpaidUsageResponse DescribePostpaidUsageSync(DescribePostpaidUsageRequest req)
        {
             JsonResponseModel<DescribePostpaidUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePostpaidUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpaidUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quality data of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityMetricsRequest"/></param>
        /// <returns><see cref="DescribeQualityMetricsResponse"/></returns>
        public async Task<DescribeQualityMetricsResponse> DescribeQualityMetrics(DescribeQualityMetricsRequest req)
        {
             JsonResponseModel<DescribeQualityMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQualityMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quality data of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityMetricsRequest"/></param>
        /// <returns><see cref="DescribeQualityMetricsResponse"/></returns>
        public DescribeQualityMetricsResponse DescribeQualityMetricsSync(DescribeQualityMetricsRequest req)
        {
             JsonResponseModel<DescribeQualityMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQualityMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query real-time recording tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSearchRequest"/></param>
        /// <returns><see cref="DescribeRecordSearchResponse"/></returns>
        public async Task<DescribeRecordSearchResponse> DescribeRecordSearch(DescribeRecordSearchRequest req)
        {
             JsonResponseModel<DescribeRecordSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query real-time recording tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSearchRequest"/></param>
        /// <returns><see cref="DescribeRecordSearchResponse"/></returns>
        public DescribeRecordSearchResponse DescribeRecordSearchSync(DescribeRecordSearchRequest req)
        {
             JsonResponseModel<DescribeRecordSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the rooms of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomListRequest"/></param>
        /// <returns><see cref="DescribeRoomListResponse"/></returns>
        public async Task<DescribeRoomListResponse> DescribeRoomList(DescribeRoomListRequest req)
        {
             JsonResponseModel<DescribeRoomListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the rooms of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomListRequest"/></param>
        /// <returns><see cref="DescribeRoomListResponse"/></returns>
        public DescribeRoomListResponse DescribeRoomListSync(DescribeRoomListRequest req)
        {
             JsonResponseModel<DescribeRoomListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information about a whiteboard snapshot task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public async Task<DescribeSnapshotTaskResponse> DescribeSnapshotTask(DescribeSnapshotTaskRequest req)
        {
             JsonResponseModel<DescribeSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information about a whiteboard snapshot task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public DescribeSnapshotTaskResponse DescribeSnapshotTaskSync(DescribeSnapshotTaskRequest req)
        {
             JsonResponseModel<DescribeSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the daily billable usage of a whiteboard application.
        /// 1. The period queried per request cannot be longer than 31 days.
        /// 2. Due to statistics delays and other reasons, you cannot query the usage data of the current day. You can query today's usage after 7:00 tomorrow.
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWDailyUsageResponse"/></returns>
        public async Task<DescribeTIWDailyUsageResponse> DescribeTIWDailyUsage(DescribeTIWDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTIWDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the daily billable usage of a whiteboard application.
        /// 1. The period queried per request cannot be longer than 31 days.
        /// 2. Due to statistics delays and other reasons, you cannot query the usage data of the current day. You can query today's usage after 7:00 tomorrow.
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWDailyUsageResponse"/></returns>
        public DescribeTIWDailyUsageResponse DescribeTIWDailyUsageSync(DescribeTIWDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTIWDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the daily billable usage by each room of a whiteboard application.
        /// 1. The period queried per request cannot be longer than 31 days.
        /// 2. Due to statistics delays and other reasons, you cannot query the usage data of the current day. You can query today's usage after 7:00 tomorrow.
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWRoomDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWRoomDailyUsageResponse"/></returns>
        public async Task<DescribeTIWRoomDailyUsageResponse> DescribeTIWRoomDailyUsage(DescribeTIWRoomDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWRoomDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTIWRoomDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWRoomDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the daily billable usage by each room of a whiteboard application.
        /// 1. The period queried per request cannot be longer than 31 days.
        /// 2. Due to statistics delays and other reasons, you cannot query the usage data of the current day. You can query today's usage after 7:00 tomorrow.
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWRoomDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWRoomDailyUsageResponse"/></returns>
        public DescribeTIWRoomDailyUsageResponse DescribeTIWRoomDailyUsageSync(DescribeTIWRoomDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWRoomDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTIWRoomDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWRoomDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the progress and result of a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public async Task<DescribeTranscodeResponse> DescribeTranscode(DescribeTranscodeRequest req)
        {
             JsonResponseModel<DescribeTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the progress and result of a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public DescribeTranscodeResponse DescribeTranscodeSync(DescribeTranscodeRequest req)
        {
             JsonResponseModel<DescribeTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the document transcoding callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public async Task<DescribeTranscodeCallbackResponse> DescribeTranscodeCallback(DescribeTranscodeCallbackRequest req)
        {
             JsonResponseModel<DescribeTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the document transcoding callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public DescribeTranscodeCallbackResponse DescribeTranscodeCallbackSync(DescribeTranscodeCallbackRequest req)
        {
             JsonResponseModel<DescribeTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query transcoding tasks by document name.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeSearchRequest"/></param>
        /// <returns><see cref="DescribeTranscodeSearchResponse"/></returns>
        public async Task<DescribeTranscodeSearchResponse> DescribeTranscodeSearch(DescribeTranscodeSearchRequest req)
        {
             JsonResponseModel<DescribeTranscodeSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query transcoding tasks by document name.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeSearchRequest"/></param>
        /// <returns><see cref="DescribeTranscodeSearchResponse"/></returns>
        public DescribeTranscodeSearchResponse DescribeTranscodeSearchSync(DescribeTranscodeSearchRequest req)
        {
             JsonResponseModel<DescribeTranscodeSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the summary of subproduct usage within a specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryResponse"/></returns>
        public async Task<DescribeUsageSummaryResponse> DescribeUsageSummary(DescribeUsageSummaryRequest req)
        {
             JsonResponseModel<DescribeUsageSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the summary of subproduct usage within a specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryResponse"/></returns>
        public DescribeUsageSummaryResponse DescribeUsageSummarySync(DescribeUsageSummaryRequest req)
        {
             JsonResponseModel<DescribeUsageSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the users of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public async Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
             JsonResponseModel<DescribeUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the users of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
             JsonResponseModel<DescribeUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query user resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesResponse"/></returns>
        public async Task<DescribeUserResourcesResponse> DescribeUserResources(DescribeUserResourcesRequest req)
        {
             JsonResponseModel<DescribeUserResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query user resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesResponse"/></returns>
        public DescribeUserResourcesResponse DescribeUserResourcesSync(DescribeUserResourcesRequest req)
        {
             JsonResponseModel<DescribeUserResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the Tencent Interactive Whiteboard service status of a user, including the activation status and validity period.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserStatusRequest"/></param>
        /// <returns><see cref="DescribeUserStatusResponse"/></returns>
        public async Task<DescribeUserStatusResponse> DescribeUserStatus(DescribeUserStatusRequest req)
        {
             JsonResponseModel<DescribeUserStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the Tencent Interactive Whiteboard service status of a user, including the activation status and validity period.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserStatusRequest"/></param>
        /// <returns><see cref="DescribeUserStatusResponse"/></returns>
        public DescribeUserStatusResponse DescribeUserStatusSync(DescribeUserStatusRequest req)
        {
             JsonResponseModel<DescribeUserStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status and result of a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public async Task<DescribeVideoGenerationTaskResponse> DescribeVideoGenerationTask(DescribeVideoGenerationTaskRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status and result of a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public DescribeVideoGenerationTaskResponse DescribeVideoGenerationTaskSync(DescribeVideoGenerationTaskRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public async Task<DescribeVideoGenerationTaskCallbackResponse> DescribeVideoGenerationTaskCallback(DescribeVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public DescribeVideoGenerationTaskCallbackResponse DescribeVideoGenerationTaskCallbackSync(DescribeVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardApplicationConfigResponse"/></returns>
        public async Task<DescribeWhiteboardApplicationConfigResponse> DescribeWhiteboardApplicationConfig(DescribeWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardApplicationConfigResponse"/></returns>
        public DescribeWhiteboardApplicationConfigResponse DescribeWhiteboardApplicationConfigSync(DescribeWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardBucketConfigResponse"/></returns>
        public async Task<DescribeWhiteboardBucketConfigResponse> DescribeWhiteboardBucketConfig(DescribeWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardBucketConfigResponse"/></returns>
        public DescribeWhiteboardBucketConfigResponse DescribeWhiteboardBucketConfigSync(DescribeWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status and result of a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public async Task<DescribeWhiteboardPushResponse> DescribeWhiteboardPush(DescribeWhiteboardPushRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status and result of a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public DescribeWhiteboardPushResponse DescribeWhiteboardPushSync(DescribeWhiteboardPushRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the whiteboard push callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public async Task<DescribeWhiteboardPushCallbackResponse> DescribeWhiteboardPushCallback(DescribeWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the whiteboard push callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public DescribeWhiteboardPushCallbackResponse DescribeWhiteboardPushCallbackSync(DescribeWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query whiteboard push tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushSearchRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushSearchResponse"/></returns>
        public async Task<DescribeWhiteboardPushSearchResponse> DescribeWhiteboardPushSearch(DescribeWhiteboardPushSearchRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardPushSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query whiteboard push tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushSearchRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushSearchResponse"/></returns>
        public DescribeWhiteboardPushSearchResponse DescribeWhiteboardPushSearchSync(DescribeWhiteboardPushSearchRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardPushSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public async Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
             JsonResponseModel<ModifyApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
             JsonResponseModel<ModifyApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set auto-renewal for a Tencent Interactive Whiteboard monthly feature package.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public async Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set auto-renewal for a Tencent Interactive Whiteboard monthly feature package.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardApplicationConfigResponse"/></returns>
        public async Task<ModifyWhiteboardApplicationConfigResponse> ModifyWhiteboardApplicationConfig(ModifyWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardApplicationConfigResponse"/></returns>
        public ModifyWhiteboardApplicationConfigResponse ModifyWhiteboardApplicationConfigSync(ModifyWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardBucketConfigResponse"/></returns>
        public async Task<ModifyWhiteboardBucketConfigResponse> ModifyWhiteboardBucketConfig(ModifyWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardBucketConfigResponse"/></returns>
        public ModifyWhiteboardBucketConfigResponse ModifyWhiteboardBucketConfigSync(ModifyWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pause real-time recording.
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public async Task<PauseOnlineRecordResponse> PauseOnlineRecord(PauseOnlineRecordRequest req)
        {
             JsonResponseModel<PauseOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PauseOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pause real-time recording.
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public PauseOnlineRecordResponse PauseOnlineRecordSync(PauseOnlineRecordRequest req)
        {
             JsonResponseModel<PauseOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PauseOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public async Task<ResumeOnlineRecordResponse> ResumeOnlineRecord(ResumeOnlineRecordRequest req)
        {
             JsonResponseModel<ResumeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public ResumeOnlineRecordResponse ResumeOnlineRecordSync(ResumeOnlineRecordRequest req)
        {
             JsonResponseModel<ResumeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the offline recording callback URL.
        /// </summary>
        /// <param name="req"><see cref="SetOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOfflineRecordCallbackResponse"/></returns>
        public async Task<SetOfflineRecordCallbackResponse> SetOfflineRecordCallback(SetOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the offline recording callback URL.
        /// </summary>
        /// <param name="req"><see cref="SetOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOfflineRecordCallbackResponse"/></returns>
        public SetOfflineRecordCallbackResponse SetOfflineRecordCallbackSync(SetOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the real-time recording callback address. For the callback format, please [see here](https://intl.cloud.tencent.com/document/product/1137/40258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public async Task<SetOnlineRecordCallbackResponse> SetOnlineRecordCallback(SetOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the real-time recording callback address. For the callback format, please [see here](https://intl.cloud.tencent.com/document/product/1137/40258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public SetOnlineRecordCallbackResponse SetOnlineRecordCallbackSync(SetOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for real-time recording. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public async Task<SetOnlineRecordCallbackKeyResponse> SetOnlineRecordCallbackKey(SetOnlineRecordCallbackKeyRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOnlineRecordCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for real-time recording. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public SetOnlineRecordCallbackKeyResponse SetOnlineRecordCallbackKeySync(SetOnlineRecordCallbackKeyRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOnlineRecordCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback address for document transcoding. For the callback format, please [see here](https://intl.cloud.tencent.com/document/product/1137/40260?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public async Task<SetTranscodeCallbackResponse> SetTranscodeCallback(SetTranscodeCallbackRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback address for document transcoding. For the callback format, please [see here](https://intl.cloud.tencent.com/document/product/1137/40260?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public SetTranscodeCallbackResponse SetTranscodeCallbackSync(SetTranscodeCallbackRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for document transcoding. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public async Task<SetTranscodeCallbackKeyResponse> SetTranscodeCallbackKey(SetTranscodeCallbackKeyRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTranscodeCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for document transcoding. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public SetTranscodeCallbackKeyResponse SetTranscodeCallbackKeySync(SetTranscodeCallbackKeyRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTranscodeCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public async Task<SetVideoGenerationTaskCallbackResponse> SetVideoGenerationTaskCallback(SetVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public SetVideoGenerationTaskCallbackResponse SetVideoGenerationTaskCallbackSync(SetVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public async Task<SetVideoGenerationTaskCallbackKeyResponse> SetVideoGenerationTaskCallbackKey(SetVideoGenerationTaskCallbackKeyRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetVideoGenerationTaskCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public SetVideoGenerationTaskCallbackKeyResponse SetVideoGenerationTaskCallbackKeySync(SetVideoGenerationTaskCallbackKeyRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetVideoGenerationTaskCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the whiteboard push callback URL. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public async Task<SetWhiteboardPushCallbackResponse> SetWhiteboardPushCallback(SetWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the whiteboard push callback URL. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public SetWhiteboardPushCallbackResponse SetWhiteboardPushCallbackSync(SetWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for whiteboard push. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public async Task<SetWhiteboardPushCallbackKeyResponse> SetWhiteboardPushCallbackKey(SetWhiteboardPushCallbackKeyRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetWhiteboardPushCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the callback authentication key for whiteboard push. For more information, see [Event Notification](https://intl.cloud.tencent.com/document/product/1137/40257?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public SetWhiteboardPushCallbackKeyResponse SetWhiteboardPushCallbackKeySync(SetWhiteboardPushCallbackKeyRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetWhiteboardPushCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public async Task<StartOnlineRecordResponse> StartOnlineRecord(StartOnlineRecordRequest req)
        {
             JsonResponseModel<StartOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public StartOnlineRecordResponse StartOnlineRecordSync(StartOnlineRecordRequest req)
        {
             JsonResponseModel<StartOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public async Task<StartWhiteboardPushResponse> StartWhiteboardPush(StartWhiteboardPushRequest req)
        {
             JsonResponseModel<StartWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public StartWhiteboardPushResponse StartWhiteboardPushSync(StartWhiteboardPushRequest req)
        {
             JsonResponseModel<StartWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop real-time recording.
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public async Task<StopOnlineRecordResponse> StopOnlineRecord(StopOnlineRecordRequest req)
        {
             JsonResponseModel<StopOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop real-time recording.
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public StopOnlineRecordResponse StopOnlineRecordSync(StopOnlineRecordRequest req)
        {
             JsonResponseModel<StopOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public async Task<StopWhiteboardPushResponse> StopWhiteboardPush(StopWhiteboardPushRequest req)
        {
             JsonResponseModel<StopWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public StopWhiteboardPushResponse StopWhiteboardPushSync(StopWhiteboardPushRequest req)
        {
             JsonResponseModel<StopWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
