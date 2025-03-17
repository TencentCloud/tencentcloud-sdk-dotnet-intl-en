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
       private const string sdkVersion = "SDK_NET_3.0.1091";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to apply for a Tencent Interactive Whiteboard trial (15-day by default).
        /// </summary>
        /// <param name="req"><see cref="ApplyTiwTrialRequest"/></param>
        /// <returns><see cref="ApplyTiwTrialResponse"/></returns>
        public Task<ApplyTiwTrialResponse> ApplyTiwTrial(ApplyTiwTrialRequest req)
        {
            return InternalRequestAsync<ApplyTiwTrialResponse>(req, "ApplyTiwTrial");
        }

        /// <summary>
        /// This API is used to apply for a Tencent Interactive Whiteboard trial (15-day by default).
        /// </summary>
        /// <param name="req"><see cref="ApplyTiwTrialRequest"/></param>
        /// <returns><see cref="ApplyTiwTrialResponse"/></returns>
        public ApplyTiwTrialResponse ApplyTiwTrialSync(ApplyTiwTrialRequest req)
        {
            return InternalRequestAsync<ApplyTiwTrialResponse>(req, "ApplyTiwTrial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication");
        }

        /// <summary>
        /// This API is used to create a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a whiteboard snapshot task. If a callback URL is provided, the whiteboard snapshot result is sent to the callback URL after the task is complete.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public Task<CreateSnapshotTaskResponse> CreateSnapshotTask(CreateSnapshotTaskRequest req)
        {
            return InternalRequestAsync<CreateSnapshotTaskResponse>(req, "CreateSnapshotTask");
        }

        /// <summary>
        /// This API is used to create a whiteboard snapshot task. If a callback URL is provided, the whiteboard snapshot result is sent to the callback URL after the task is complete.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public CreateSnapshotTaskResponse CreateSnapshotTaskSync(CreateSnapshotTaskRequest req)
        {
            return InternalRequestAsync<CreateSnapshotTaskResponse>(req, "CreateSnapshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public Task<CreateTranscodeResponse> CreateTranscode(CreateTranscodeRequest req)
        {
            return InternalRequestAsync<CreateTranscodeResponse>(req, "CreateTranscode");
        }

        /// <summary>
        /// This API is used to create a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public CreateTranscodeResponse CreateTranscodeSync(CreateTranscodeRequest req)
        {
            return InternalRequestAsync<CreateTranscodeResponse>(req, "CreateTranscode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public Task<CreateVideoGenerationTaskResponse> CreateVideoGenerationTask(CreateVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoGenerationTaskResponse>(req, "CreateVideoGenerationTask");
        }

        /// <summary>
        /// This API is used to create a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public CreateVideoGenerationTaskResponse CreateVideoGenerationTaskSync(CreateVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoGenerationTaskResponse>(req, "CreateVideoGenerationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information about other cloud products by using the service role.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeAPIServiceResponse"/></returns>
        public Task<DescribeAPIServiceResponse> DescribeAPIService(DescribeAPIServiceRequest req)
        {
            return InternalRequestAsync<DescribeAPIServiceResponse>(req, "DescribeAPIService");
        }

        /// <summary>
        /// This API is used to query the information about other cloud products by using the service role.
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeAPIServiceResponse"/></returns>
        public DescribeAPIServiceResponse DescribeAPIServiceSync(DescribeAPIServiceRequest req)
        {
            return InternalRequestAsync<DescribeAPIServiceResponse>(req, "DescribeAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfosRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfosResponse"/></returns>
        public Task<DescribeApplicationInfosResponse> DescribeApplicationInfos(DescribeApplicationInfosRequest req)
        {
            return InternalRequestAsync<DescribeApplicationInfosResponse>(req, "DescribeApplicationInfos");
        }

        /// <summary>
        /// This API is used to query the details of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfosRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfosResponse"/></returns>
        public DescribeApplicationInfosResponse DescribeApplicationInfosSync(DescribeApplicationInfosRequest req)
        {
            return InternalRequestAsync<DescribeApplicationInfosResponse>(req, "DescribeApplicationInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the subproduct usage of Tencent Interactive Whiteboard.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationUsageRequest"/></param>
        /// <returns><see cref="DescribeApplicationUsageResponse"/></returns>
        public Task<DescribeApplicationUsageResponse> DescribeApplicationUsage(DescribeApplicationUsageRequest req)
        {
            return InternalRequestAsync<DescribeApplicationUsageResponse>(req, "DescribeApplicationUsage");
        }

        /// <summary>
        /// This API is used to query the subproduct usage of Tencent Interactive Whiteboard.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationUsageRequest"/></param>
        /// <returns><see cref="DescribeApplicationUsageResponse"/></returns>
        public DescribeApplicationUsageResponse DescribeApplicationUsageSync(DescribeApplicationUsageRequest req)
        {
            return InternalRequestAsync<DescribeApplicationUsageResponse>(req, "DescribeApplicationUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the logs of a whiteboard application on a client.
        /// </summary>
        /// <param name="req"><see cref="DescribeBoardSDKLogRequest"/></param>
        /// <returns><see cref="DescribeBoardSDKLogResponse"/></returns>
        public Task<DescribeBoardSDKLogResponse> DescribeBoardSDKLog(DescribeBoardSDKLogRequest req)
        {
            return InternalRequestAsync<DescribeBoardSDKLogResponse>(req, "DescribeBoardSDKLog");
        }

        /// <summary>
        /// This API is used to query the logs of a whiteboard application on a client.
        /// </summary>
        /// <param name="req"><see cref="DescribeBoardSDKLogRequest"/></param>
        /// <returns><see cref="DescribeBoardSDKLogResponse"/></returns>
        public DescribeBoardSDKLogResponse DescribeBoardSDKLogSync(DescribeBoardSDKLogRequest req)
        {
            return InternalRequestAsync<DescribeBoardSDKLogResponse>(req, "DescribeBoardSDKLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instant messaging (IM) applications that are available for creating a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeIMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeIMApplicationsResponse"/></returns>
        public Task<DescribeIMApplicationsResponse> DescribeIMApplications(DescribeIMApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeIMApplicationsResponse>(req, "DescribeIMApplications");
        }

        /// <summary>
        /// This API is used to query the instant messaging (IM) applications that are available for creating a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeIMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeIMApplicationsResponse"/></returns>
        public DescribeIMApplicationsResponse DescribeIMApplicationsSync(DescribeIMApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeIMApplicationsResponse>(req, "DescribeIMApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status and result of a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public Task<DescribeOnlineRecordResponse> DescribeOnlineRecord(DescribeOnlineRecordRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordResponse>(req, "DescribeOnlineRecord");
        }

        /// <summary>
        /// This API is used to query the status and result of a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public DescribeOnlineRecordResponse DescribeOnlineRecordSync(DescribeOnlineRecordRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordResponse>(req, "DescribeOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time recording callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public Task<DescribeOnlineRecordCallbackResponse> DescribeOnlineRecordCallback(DescribeOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordCallbackResponse>(req, "DescribeOnlineRecordCallback");
        }

        /// <summary>
        /// This API is used to query the real-time recording callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public DescribeOnlineRecordCallbackResponse DescribeOnlineRecordCallbackSync(DescribeOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordCallbackResponse>(req, "DescribeOnlineRecordCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the pay-as-you-go usage of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribePostpaidUsageRequest"/></param>
        /// <returns><see cref="DescribePostpaidUsageResponse"/></returns>
        public Task<DescribePostpaidUsageResponse> DescribePostpaidUsage(DescribePostpaidUsageRequest req)
        {
            return InternalRequestAsync<DescribePostpaidUsageResponse>(req, "DescribePostpaidUsage");
        }

        /// <summary>
        /// This API is used to query the pay-as-you-go usage of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribePostpaidUsageRequest"/></param>
        /// <returns><see cref="DescribePostpaidUsageResponse"/></returns>
        public DescribePostpaidUsageResponse DescribePostpaidUsageSync(DescribePostpaidUsageRequest req)
        {
            return InternalRequestAsync<DescribePostpaidUsageResponse>(req, "DescribePostpaidUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the quality data of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityMetricsRequest"/></param>
        /// <returns><see cref="DescribeQualityMetricsResponse"/></returns>
        public Task<DescribeQualityMetricsResponse> DescribeQualityMetrics(DescribeQualityMetricsRequest req)
        {
            return InternalRequestAsync<DescribeQualityMetricsResponse>(req, "DescribeQualityMetrics");
        }

        /// <summary>
        /// This API is used to query the quality data of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityMetricsRequest"/></param>
        /// <returns><see cref="DescribeQualityMetricsResponse"/></returns>
        public DescribeQualityMetricsResponse DescribeQualityMetricsSync(DescribeQualityMetricsRequest req)
        {
            return InternalRequestAsync<DescribeQualityMetricsResponse>(req, "DescribeQualityMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query real-time recording tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSearchRequest"/></param>
        /// <returns><see cref="DescribeRecordSearchResponse"/></returns>
        public Task<DescribeRecordSearchResponse> DescribeRecordSearch(DescribeRecordSearchRequest req)
        {
            return InternalRequestAsync<DescribeRecordSearchResponse>(req, "DescribeRecordSearch");
        }

        /// <summary>
        /// This API is used to query real-time recording tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSearchRequest"/></param>
        /// <returns><see cref="DescribeRecordSearchResponse"/></returns>
        public DescribeRecordSearchResponse DescribeRecordSearchSync(DescribeRecordSearchRequest req)
        {
            return InternalRequestAsync<DescribeRecordSearchResponse>(req, "DescribeRecordSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rooms of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomListRequest"/></param>
        /// <returns><see cref="DescribeRoomListResponse"/></returns>
        public Task<DescribeRoomListResponse> DescribeRoomList(DescribeRoomListRequest req)
        {
            return InternalRequestAsync<DescribeRoomListResponse>(req, "DescribeRoomList");
        }

        /// <summary>
        /// This API is used to query the rooms of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomListRequest"/></param>
        /// <returns><see cref="DescribeRoomListResponse"/></returns>
        public DescribeRoomListResponse DescribeRoomListSync(DescribeRoomListRequest req)
        {
            return InternalRequestAsync<DescribeRoomListResponse>(req, "DescribeRoomList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information about a whiteboard snapshot task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public Task<DescribeSnapshotTaskResponse> DescribeSnapshotTask(DescribeSnapshotTaskRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotTaskResponse>(req, "DescribeSnapshotTask");
        }

        /// <summary>
        /// This API is used to query the information about a whiteboard snapshot task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public DescribeSnapshotTaskResponse DescribeSnapshotTaskSync(DescribeSnapshotTaskRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotTaskResponse>(req, "DescribeSnapshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the daily billable usage of a whiteboard application.
        /// 1. The period queried per request cannot be longer than 31 days.
        /// 2. Due to statistics delays and other reasons, you cannot query the usage data of the current day. You can query today's usage after 7:00 tomorrow.
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWDailyUsageResponse"/></returns>
        public Task<DescribeTIWDailyUsageResponse> DescribeTIWDailyUsage(DescribeTIWDailyUsageRequest req)
        {
            return InternalRequestAsync<DescribeTIWDailyUsageResponse>(req, "DescribeTIWDailyUsage");
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
            return InternalRequestAsync<DescribeTIWDailyUsageResponse>(req, "DescribeTIWDailyUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the daily billable usage by each room of a whiteboard application.
        /// 1. The period queried per request cannot be longer than 31 days.
        /// 2. Due to statistics delays and other reasons, you cannot query the usage data of the current day. You can query today's usage after 7:00 tomorrow.
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWRoomDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWRoomDailyUsageResponse"/></returns>
        public Task<DescribeTIWRoomDailyUsageResponse> DescribeTIWRoomDailyUsage(DescribeTIWRoomDailyUsageRequest req)
        {
            return InternalRequestAsync<DescribeTIWRoomDailyUsageResponse>(req, "DescribeTIWRoomDailyUsage");
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
            return InternalRequestAsync<DescribeTIWRoomDailyUsageResponse>(req, "DescribeTIWRoomDailyUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the progress and result of a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public Task<DescribeTranscodeResponse> DescribeTranscode(DescribeTranscodeRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeResponse>(req, "DescribeTranscode");
        }

        /// <summary>
        /// This API is used to query the progress and result of a document transcoding task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public DescribeTranscodeResponse DescribeTranscodeSync(DescribeTranscodeRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeResponse>(req, "DescribeTranscode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the document transcoding callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public Task<DescribeTranscodeCallbackResponse> DescribeTranscodeCallback(DescribeTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeCallbackResponse>(req, "DescribeTranscodeCallback");
        }

        /// <summary>
        /// This API is used to query the document transcoding callback address.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public DescribeTranscodeCallbackResponse DescribeTranscodeCallbackSync(DescribeTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeCallbackResponse>(req, "DescribeTranscodeCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query transcoding tasks by document name.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeSearchRequest"/></param>
        /// <returns><see cref="DescribeTranscodeSearchResponse"/></returns>
        public Task<DescribeTranscodeSearchResponse> DescribeTranscodeSearch(DescribeTranscodeSearchRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeSearchResponse>(req, "DescribeTranscodeSearch");
        }

        /// <summary>
        /// This API is used to query transcoding tasks by document name.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeSearchRequest"/></param>
        /// <returns><see cref="DescribeTranscodeSearchResponse"/></returns>
        public DescribeTranscodeSearchResponse DescribeTranscodeSearchSync(DescribeTranscodeSearchRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeSearchResponse>(req, "DescribeTranscodeSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the summary of subproduct usage within a specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryResponse"/></returns>
        public Task<DescribeUsageSummaryResponse> DescribeUsageSummary(DescribeUsageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUsageSummaryResponse>(req, "DescribeUsageSummary");
        }

        /// <summary>
        /// This API is used to query the summary of subproduct usage within a specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryResponse"/></returns>
        public DescribeUsageSummaryResponse DescribeUsageSummarySync(DescribeUsageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUsageSummaryResponse>(req, "DescribeUsageSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the users of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList");
        }

        /// <summary>
        /// This API is used to query the users of a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesResponse"/></returns>
        public Task<DescribeUserResourcesResponse> DescribeUserResources(DescribeUserResourcesRequest req)
        {
            return InternalRequestAsync<DescribeUserResourcesResponse>(req, "DescribeUserResources");
        }

        /// <summary>
        /// This API is used to query user resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesResponse"/></returns>
        public DescribeUserResourcesResponse DescribeUserResourcesSync(DescribeUserResourcesRequest req)
        {
            return InternalRequestAsync<DescribeUserResourcesResponse>(req, "DescribeUserResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Tencent Interactive Whiteboard service status of a user, including the activation status and validity period.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserStatusRequest"/></param>
        /// <returns><see cref="DescribeUserStatusResponse"/></returns>
        public Task<DescribeUserStatusResponse> DescribeUserStatus(DescribeUserStatusRequest req)
        {
            return InternalRequestAsync<DescribeUserStatusResponse>(req, "DescribeUserStatus");
        }

        /// <summary>
        /// This API is used to query the Tencent Interactive Whiteboard service status of a user, including the activation status and validity period.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserStatusRequest"/></param>
        /// <returns><see cref="DescribeUserStatusResponse"/></returns>
        public DescribeUserStatusResponse DescribeUserStatusSync(DescribeUserStatusRequest req)
        {
            return InternalRequestAsync<DescribeUserStatusResponse>(req, "DescribeUserStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status and result of a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public Task<DescribeVideoGenerationTaskResponse> DescribeVideoGenerationTask(DescribeVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskResponse>(req, "DescribeVideoGenerationTask");
        }

        /// <summary>
        /// This API is used to query the status and result of a recording video generation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public DescribeVideoGenerationTaskResponse DescribeVideoGenerationTaskSync(DescribeVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskResponse>(req, "DescribeVideoGenerationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public Task<DescribeVideoGenerationTaskCallbackResponse> DescribeVideoGenerationTaskCallback(DescribeVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskCallbackResponse>(req, "DescribeVideoGenerationTaskCallback");
        }

        /// <summary>
        /// This API is used to query the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public DescribeVideoGenerationTaskCallbackResponse DescribeVideoGenerationTaskCallbackSync(DescribeVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskCallbackResponse>(req, "DescribeVideoGenerationTaskCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardApplicationConfigResponse"/></returns>
        public Task<DescribeWhiteboardApplicationConfigResponse> DescribeWhiteboardApplicationConfig(DescribeWhiteboardApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardApplicationConfigResponse>(req, "DescribeWhiteboardApplicationConfig");
        }

        /// <summary>
        /// This API is used to query the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardApplicationConfigResponse"/></returns>
        public DescribeWhiteboardApplicationConfigResponse DescribeWhiteboardApplicationConfigSync(DescribeWhiteboardApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardApplicationConfigResponse>(req, "DescribeWhiteboardApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardBucketConfigResponse"/></returns>
        public Task<DescribeWhiteboardBucketConfigResponse> DescribeWhiteboardBucketConfig(DescribeWhiteboardBucketConfigRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardBucketConfigResponse>(req, "DescribeWhiteboardBucketConfig");
        }

        /// <summary>
        /// This API is used to query the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardBucketConfigResponse"/></returns>
        public DescribeWhiteboardBucketConfigResponse DescribeWhiteboardBucketConfigSync(DescribeWhiteboardBucketConfigRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardBucketConfigResponse>(req, "DescribeWhiteboardBucketConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status and result of a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public Task<DescribeWhiteboardPushResponse> DescribeWhiteboardPush(DescribeWhiteboardPushRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushResponse>(req, "DescribeWhiteboardPush");
        }

        /// <summary>
        /// This API is used to query the status and result of a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public DescribeWhiteboardPushResponse DescribeWhiteboardPushSync(DescribeWhiteboardPushRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushResponse>(req, "DescribeWhiteboardPush")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the whiteboard push callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public Task<DescribeWhiteboardPushCallbackResponse> DescribeWhiteboardPushCallback(DescribeWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushCallbackResponse>(req, "DescribeWhiteboardPushCallback");
        }

        /// <summary>
        /// This API is used to query the whiteboard push callback URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public DescribeWhiteboardPushCallbackResponse DescribeWhiteboardPushCallbackSync(DescribeWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushCallbackResponse>(req, "DescribeWhiteboardPushCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query whiteboard push tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushSearchRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushSearchResponse"/></returns>
        public Task<DescribeWhiteboardPushSearchResponse> DescribeWhiteboardPushSearch(DescribeWhiteboardPushSearchRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushSearchResponse>(req, "DescribeWhiteboardPushSearch");
        }

        /// <summary>
        /// This API is used to query whiteboard push tasks by room ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushSearchRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushSearchResponse"/></returns>
        public DescribeWhiteboardPushSearchResponse DescribeWhiteboardPushSearchSync(DescribeWhiteboardPushSearchRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushSearchResponse>(req, "DescribeWhiteboardPushSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication");
        }

        /// <summary>
        /// This API is used to modify a whiteboard application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set auto-renewal for a Tencent Interactive Whiteboard monthly feature package.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag");
        }

        /// <summary>
        /// This API is used to set auto-renewal for a Tencent Interactive Whiteboard monthly feature package.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardApplicationConfigResponse"/></returns>
        public Task<ModifyWhiteboardApplicationConfigResponse> ModifyWhiteboardApplicationConfig(ModifyWhiteboardApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyWhiteboardApplicationConfigResponse>(req, "ModifyWhiteboardApplicationConfig");
        }

        /// <summary>
        /// This API is used to modify the task-related configurations of a whiteboard application, including the bucket and callback URL.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardApplicationConfigResponse"/></returns>
        public ModifyWhiteboardApplicationConfigResponse ModifyWhiteboardApplicationConfigSync(ModifyWhiteboardApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyWhiteboardApplicationConfigResponse>(req, "ModifyWhiteboardApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardBucketConfigResponse"/></returns>
        public Task<ModifyWhiteboardBucketConfigResponse> ModifyWhiteboardBucketConfig(ModifyWhiteboardBucketConfigRequest req)
        {
            return InternalRequestAsync<ModifyWhiteboardBucketConfigResponse>(req, "ModifyWhiteboardBucketConfig");
        }

        /// <summary>
        /// This API is used to modify the bucket configurations for document transcoding and real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardBucketConfigResponse"/></returns>
        public ModifyWhiteboardBucketConfigResponse ModifyWhiteboardBucketConfigSync(ModifyWhiteboardBucketConfigRequest req)
        {
            return InternalRequestAsync<ModifyWhiteboardBucketConfigResponse>(req, "ModifyWhiteboardBucketConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause real-time recording.
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public Task<PauseOnlineRecordResponse> PauseOnlineRecord(PauseOnlineRecordRequest req)
        {
            return InternalRequestAsync<PauseOnlineRecordResponse>(req, "PauseOnlineRecord");
        }

        /// <summary>
        /// This API is used to pause real-time recording.
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public PauseOnlineRecordResponse PauseOnlineRecordSync(PauseOnlineRecordRequest req)
        {
            return InternalRequestAsync<PauseOnlineRecordResponse>(req, "PauseOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resume real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public Task<ResumeOnlineRecordResponse> ResumeOnlineRecord(ResumeOnlineRecordRequest req)
        {
            return InternalRequestAsync<ResumeOnlineRecordResponse>(req, "ResumeOnlineRecord");
        }

        /// <summary>
        /// This API is used to resume real-time recording.
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public ResumeOnlineRecordResponse ResumeOnlineRecordSync(ResumeOnlineRecordRequest req)
        {
            return InternalRequestAsync<ResumeOnlineRecordResponse>(req, "ResumeOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the real-time recording callback address. For the callback format, please [see here](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public Task<SetOnlineRecordCallbackResponse> SetOnlineRecordCallback(SetOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackResponse>(req, "SetOnlineRecordCallback");
        }

        /// <summary>
        /// This API is used to set the real-time recording callback address. For the callback format, please [see here](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public SetOnlineRecordCallbackResponse SetOnlineRecordCallbackSync(SetOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackResponse>(req, "SetOnlineRecordCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the callback authentication key for real-time recording. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public Task<SetOnlineRecordCallbackKeyResponse> SetOnlineRecordCallbackKey(SetOnlineRecordCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackKeyResponse>(req, "SetOnlineRecordCallbackKey");
        }

        /// <summary>
        /// This API is used to set the callback authentication key for real-time recording. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public SetOnlineRecordCallbackKeyResponse SetOnlineRecordCallbackKeySync(SetOnlineRecordCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackKeyResponse>(req, "SetOnlineRecordCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the callback address for document transcoding. For the callback format, please [see here](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public Task<SetTranscodeCallbackResponse> SetTranscodeCallback(SetTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackResponse>(req, "SetTranscodeCallback");
        }

        /// <summary>
        /// This API is used to set the callback address for document transcoding. For the callback format, please [see here](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public SetTranscodeCallbackResponse SetTranscodeCallbackSync(SetTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackResponse>(req, "SetTranscodeCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the callback authentication key for document transcoding. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public Task<SetTranscodeCallbackKeyResponse> SetTranscodeCallbackKey(SetTranscodeCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackKeyResponse>(req, "SetTranscodeCallbackKey");
        }

        /// <summary>
        /// This API is used to set the callback authentication key for document transcoding. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public SetTranscodeCallbackKeyResponse SetTranscodeCallbackKeySync(SetTranscodeCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackKeyResponse>(req, "SetTranscodeCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public Task<SetVideoGenerationTaskCallbackResponse> SetVideoGenerationTaskCallback(SetVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackResponse>(req, "SetVideoGenerationTaskCallback");
        }

        /// <summary>
        /// This API is used to set the callback URL for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public SetVideoGenerationTaskCallbackResponse SetVideoGenerationTaskCallbackSync(SetVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackResponse>(req, "SetVideoGenerationTaskCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the callback authentication key for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public Task<SetVideoGenerationTaskCallbackKeyResponse> SetVideoGenerationTaskCallbackKey(SetVideoGenerationTaskCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackKeyResponse>(req, "SetVideoGenerationTaskCallbackKey");
        }

        /// <summary>
        /// This API is used to set the callback authentication key for recording video generation.
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public SetVideoGenerationTaskCallbackKeyResponse SetVideoGenerationTaskCallbackKeySync(SetVideoGenerationTaskCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackKeyResponse>(req, "SetVideoGenerationTaskCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the whiteboard push callback URL. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public Task<SetWhiteboardPushCallbackResponse> SetWhiteboardPushCallback(SetWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackResponse>(req, "SetWhiteboardPushCallback");
        }

        /// <summary>
        /// This API is used to set the whiteboard push callback URL. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public SetWhiteboardPushCallbackResponse SetWhiteboardPushCallbackSync(SetWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackResponse>(req, "SetWhiteboardPushCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the callback authentication key for whiteboard push. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public Task<SetWhiteboardPushCallbackKeyResponse> SetWhiteboardPushCallbackKey(SetWhiteboardPushCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackKeyResponse>(req, "SetWhiteboardPushCallbackKey");
        }

        /// <summary>
        /// This API is used to set the callback authentication key for whiteboard push. For more information, see [Event Notification](https://www.tencentcloud.com/document/product/1176/55569).
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public SetWhiteboardPushCallbackKeyResponse SetWhiteboardPushCallbackKeySync(SetWhiteboardPushCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackKeyResponse>(req, "SetWhiteboardPushCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public Task<StartOnlineRecordResponse> StartOnlineRecord(StartOnlineRecordRequest req)
        {
            return InternalRequestAsync<StartOnlineRecordResponse>(req, "StartOnlineRecord");
        }

        /// <summary>
        /// This API is used to start a real-time recording task.
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public StartOnlineRecordResponse StartOnlineRecordSync(StartOnlineRecordRequest req)
        {
            return InternalRequestAsync<StartOnlineRecordResponse>(req, "StartOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public Task<StartWhiteboardPushResponse> StartWhiteboardPush(StartWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StartWhiteboardPushResponse>(req, "StartWhiteboardPush");
        }

        /// <summary>
        /// This API is used to start a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public StartWhiteboardPushResponse StartWhiteboardPushSync(StartWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StartWhiteboardPushResponse>(req, "StartWhiteboardPush")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop real-time recording.
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public Task<StopOnlineRecordResponse> StopOnlineRecord(StopOnlineRecordRequest req)
        {
            return InternalRequestAsync<StopOnlineRecordResponse>(req, "StopOnlineRecord");
        }

        /// <summary>
        /// This API is used to stop real-time recording.
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public StopOnlineRecordResponse StopOnlineRecordSync(StopOnlineRecordRequest req)
        {
            return InternalRequestAsync<StopOnlineRecordResponse>(req, "StopOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public Task<StopWhiteboardPushResponse> StopWhiteboardPush(StopWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StopWhiteboardPushResponse>(req, "StopWhiteboardPush");
        }

        /// <summary>
        /// This API is used to stop a whiteboard push task.
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public StopWhiteboardPushResponse StopWhiteboardPushSync(StopWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StopWhiteboardPushResponse>(req, "StopWhiteboardPush")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
