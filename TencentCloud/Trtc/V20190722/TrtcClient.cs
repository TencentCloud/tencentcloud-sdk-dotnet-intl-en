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

namespace TencentCloud.Trtc.V20190722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trtc.V20190722.Models;

   public class TrtcClient : AbstractClient{

       private const string endpoint = "trtc.intl.tencentcloudapi.com";
       private const string version = "2019-07-22";
       private const string sdkVersion = "SDK_NET_3.0.1262";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrtcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrtcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to provide service for server-side robot control.
        /// </summary>
        /// <param name="req"><see cref="ControlAIConversationRequest"/></param>
        /// <returns><see cref="ControlAIConversationResponse"/></returns>
        public Task<ControlAIConversationResponse> ControlAIConversation(ControlAIConversationRequest req)
        {
            return InternalRequestAsync<ControlAIConversationResponse>(req, "ControlAIConversation");
        }

        /// <summary>
        /// This API is used to provide service for server-side robot control.
        /// </summary>
        /// <param name="req"><see cref="ControlAIConversationRequest"/></param>
        /// <returns><see cref="ControlAIConversationResponse"/></returns>
        public ControlAIConversationResponse ControlAIConversationSync(ControlAIConversationRequest req)
        {
            return InternalRequestAsync<ControlAIConversationResponse>(req, "ControlAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API description:
        /// This API is used to enable the cloud moderation feature to complete audio and video slicing, video frame extraction, and audio stream recording in the room, and submit them to the specified moderation supplier for completing the moderation.
        /// 
        /// This API is used to achieve the following goals:
        /// * This API is used to specify the moderation parameters (ModerationParams) to specify the detailed parameters required for moderation.
        /// * This API is used to specify the storage parameter (SliceStorageParams) to specify the cloud storage you want to upload the file complying with the moderation policy to. Currently, Tencent Cloud Object Storage (COS) and third-party AWS are supported.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudModerationRequest"/></param>
        /// <returns><see cref="CreateCloudModerationResponse"/></returns>
        public Task<CreateCloudModerationResponse> CreateCloudModeration(CreateCloudModerationRequest req)
        {
            return InternalRequestAsync<CreateCloudModerationResponse>(req, "CreateCloudModeration");
        }

        /// <summary>
        /// API description:
        /// This API is used to enable the cloud moderation feature to complete audio and video slicing, video frame extraction, and audio stream recording in the room, and submit them to the specified moderation supplier for completing the moderation.
        /// 
        /// This API is used to achieve the following goals:
        /// * This API is used to specify the moderation parameters (ModerationParams) to specify the detailed parameters required for moderation.
        /// * This API is used to specify the storage parameter (SliceStorageParams) to specify the cloud storage you want to upload the file complying with the moderation policy to. Currently, Tencent Cloud Object Storage (COS) and third-party AWS are supported.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudModerationRequest"/></param>
        /// <returns><see cref="CreateCloudModerationResponse"/></returns>
        public CreateCloudModerationResponse CreateCloudModerationSync(CreateCloudModerationRequest req)
        {
            return InternalRequestAsync<CreateCloudModerationResponse>(req, "CreateCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API description:.
        /// Start on-cloud recording to complete audio and video recording in the room and upload to designated cloud storage. This API is used to record each audio and video stream in the TRTC room separately or merge multiple video images into one stream.
        /// Before official online operation, pay attention to the recording best practices (https://www.tencentcloud.comom/document/product/647/76497?from_cn_redirect=1#e7e2f04c-6cde-43c9-9cd0-0f8d22dee68c). In conjunction with best practices, it can greatly improve API recording availability.
        /// 
        /// This API is used to achieve the following goals:.
        /// Specify the subscription stream parameter (RecordParams) to specify the blocklist or allowlist of anchors that need to be recorded.
        /// * This API is used to specify the storage parameter (StorageParams) to specify the cloud storage you want to upload to. Currently, Tencent Cloud Video on Demand (VOD), Cloud Object Storage (COS), and third-party AWS are supported.
        /// Specify detailed parameters for audio and video transcoding in mixed-stream mode (MixTranscodeParams), including video resolution, video bitrate, video frame rate, and sound quality.
        /// * Specify the position and layout of each stream in mixed-stream mode, or configure via an automatic Template.
        /// 
        /// Key nouns:.
        /// * Single stream recording: Record the audio and video of subscribed UserIds in the room separately. The recording service uploads the files to your designated cloud storage in real time.
        /// Mixed-stream recording: Mix the audio and video of subscribed UserId in the room into a video file and upload the recorded files to your designated cloud storage. (After recording ends, go to the VOD console https://console.cloud.tencent.com/vod/media or the object storage COS console https://console.cloud.tencent.com/cos/bucket to view files).
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public Task<CreateCloudRecordingResponse> CreateCloudRecording(CreateCloudRecordingRequest req)
        {
            return InternalRequestAsync<CreateCloudRecordingResponse>(req, "CreateCloudRecording");
        }

        /// <summary>
        /// API description:.
        /// Start on-cloud recording to complete audio and video recording in the room and upload to designated cloud storage. This API is used to record each audio and video stream in the TRTC room separately or merge multiple video images into one stream.
        /// Before official online operation, pay attention to the recording best practices (https://www.tencentcloud.comom/document/product/647/76497?from_cn_redirect=1#e7e2f04c-6cde-43c9-9cd0-0f8d22dee68c). In conjunction with best practices, it can greatly improve API recording availability.
        /// 
        /// This API is used to achieve the following goals:.
        /// Specify the subscription stream parameter (RecordParams) to specify the blocklist or allowlist of anchors that need to be recorded.
        /// * This API is used to specify the storage parameter (StorageParams) to specify the cloud storage you want to upload to. Currently, Tencent Cloud Video on Demand (VOD), Cloud Object Storage (COS), and third-party AWS are supported.
        /// Specify detailed parameters for audio and video transcoding in mixed-stream mode (MixTranscodeParams), including video resolution, video bitrate, video frame rate, and sound quality.
        /// * Specify the position and layout of each stream in mixed-stream mode, or configure via an automatic Template.
        /// 
        /// Key nouns:.
        /// * Single stream recording: Record the audio and video of subscribed UserIds in the room separately. The recording service uploads the files to your designated cloud storage in real time.
        /// Mixed-stream recording: Mix the audio and video of subscribed UserId in the room into a video file and upload the recorded files to your designated cloud storage. (After recording ends, go to the VOD console https://console.cloud.tencent.com/vod/media or the object storage COS console https://console.cloud.tencent.com/cos/bucket to view files).
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public CreateCloudRecordingResponse CreateCloudRecordingSync(CreateCloudRecordingRequest req)
        {
            return InternalRequestAsync<CreateCloudRecordingResponse>(req, "CreateCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API description:
        /// This API is used to enable the cloud slicing feature, completing audio and video slicing tasks in the room, and uploading them to the specified cloud storage.
        /// This API is used to achieve the following goals:
        /// * This API is used to specify the slicing parameter (SliceParams) to define the blocklist or allowlist of the anchors that require slicing.
        /// * This API is used to specify the storage parameter (SliceStorageParams) to specify the cloud storage you want to upload to. Currently, Tencent Cloud Object Storage (COS) and third-party AWS are supported.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSliceTaskRequest"/></param>
        /// <returns><see cref="CreateCloudSliceTaskResponse"/></returns>
        public Task<CreateCloudSliceTaskResponse> CreateCloudSliceTask(CreateCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<CreateCloudSliceTaskResponse>(req, "CreateCloudSliceTask");
        }

        /// <summary>
        /// API description:
        /// This API is used to enable the cloud slicing feature, completing audio and video slicing tasks in the room, and uploading them to the specified cloud storage.
        /// This API is used to achieve the following goals:
        /// * This API is used to specify the slicing parameter (SliceParams) to define the blocklist or allowlist of the anchors that require slicing.
        /// * This API is used to specify the storage parameter (SliceStorageParams) to specify the cloud storage you want to upload to. Currently, Tencent Cloud Object Storage (COS) and third-party AWS are supported.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSliceTaskRequest"/></param>
        /// <returns><see cref="CreateCloudSliceTaskResponse"/></returns>
        public CreateCloudSliceTaskResponse CreateCloudSliceTaskSync(CreateCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<CreateCloudSliceTaskResponse>(req, "CreateCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop submission for moderation after the cloud moderation task is successfully started.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudModerationRequest"/></param>
        /// <returns><see cref="DeleteCloudModerationResponse"/></returns>
        public Task<DeleteCloudModerationResponse> DeleteCloudModeration(DeleteCloudModerationRequest req)
        {
            return InternalRequestAsync<DeleteCloudModerationResponse>(req, "DeleteCloudModeration");
        }

        /// <summary>
        /// This API is used to stop submission for moderation after the cloud moderation task is successfully started.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudModerationRequest"/></param>
        /// <returns><see cref="DeleteCloudModerationResponse"/></returns>
        public DeleteCloudModerationResponse DeleteCloudModerationSync(DeleteCloudModerationRequest req)
        {
            return InternalRequestAsync<DeleteCloudModerationResponse>(req, "DeleteCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a recording task. If a task is stopped successfully, but the uploading of recording files has not completed, the backend will continue to upload the files and will notify you via a callback when the upload is completed.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public Task<DeleteCloudRecordingResponse> DeleteCloudRecording(DeleteCloudRecordingRequest req)
        {
            return InternalRequestAsync<DeleteCloudRecordingResponse>(req, "DeleteCloudRecording");
        }

        /// <summary>
        /// This API is used to stop a recording task. If a task is stopped successfully, but the uploading of recording files has not completed, the backend will continue to upload the files and will notify you via a callback when the upload is completed.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public DeleteCloudRecordingResponse DeleteCloudRecordingSync(DeleteCloudRecordingRequest req)
        {
            return InternalRequestAsync<DeleteCloudRecordingResponse>(req, "DeleteCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop the slicing task after it is started. Successfully stopping the slicing does not mean that all files are fully transmitted; if the transmission is not completed, the backend will continue to upload files. After the upload is successful, a notification is sent to the customer, prompting that all files have been transmitted, through the event callback.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DeleteCloudSliceTaskResponse"/></returns>
        public Task<DeleteCloudSliceTaskResponse> DeleteCloudSliceTask(DeleteCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DeleteCloudSliceTaskResponse>(req, "DeleteCloudSliceTask");
        }

        /// <summary>
        /// This API is used to stop the slicing task after it is started. Successfully stopping the slicing does not mean that all files are fully transmitted; if the transmission is not completed, the backend will continue to upload files. After the upload is successful, a notification is sent to the customer, prompting that all files have been transmitted, through the event callback.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DeleteCloudSliceTaskResponse"/></returns>
        public DeleteCloudSliceTaskResponse DeleteCloudSliceTaskSync(DeleteCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DeleteCloudSliceTaskResponse>(req, "DeleteCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe the AI conversation task status
        /// </summary>
        /// <param name="req"><see cref="DescribeAIConversationRequest"/></param>
        /// <returns><see cref="DescribeAIConversationResponse"/></returns>
        public Task<DescribeAIConversationResponse> DescribeAIConversation(DescribeAIConversationRequest req)
        {
            return InternalRequestAsync<DescribeAIConversationResponse>(req, "DescribeAIConversation");
        }

        /// <summary>
        /// Describe the AI conversation task status
        /// </summary>
        /// <param name="req"><see cref="DescribeAIConversationRequest"/></param>
        /// <returns><see cref="DescribeAIConversationResponse"/></returns>
        public DescribeAIConversationResponse DescribeAIConversationSync(DescribeAIConversationRequest req)
        {
            return InternalRequestAsync<DescribeAIConversationResponse>(req, "DescribeAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe AI transcription task status
        /// </summary>
        /// <param name="req"><see cref="DescribeAITranscriptionRequest"/></param>
        /// <returns><see cref="DescribeAITranscriptionResponse"/></returns>
        public Task<DescribeAITranscriptionResponse> DescribeAITranscription(DescribeAITranscriptionRequest req)
        {
            return InternalRequestAsync<DescribeAITranscriptionResponse>(req, "DescribeAITranscription");
        }

        /// <summary>
        /// Describe AI transcription task status
        /// </summary>
        /// <param name="req"><see cref="DescribeAITranscriptionRequest"/></param>
        /// <returns><see cref="DescribeAITranscriptionResponse"/></returns>
        public DescribeAITranscriptionResponse DescribeAITranscriptionSync(DescribeAITranscriptionRequest req)
        {
            return InternalRequestAsync<DescribeAITranscriptionResponse>(req, "DescribeAITranscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (the old `DescribeCallDetail`) is used to query the user list and call quality data of a specified time range in the last 14 days. If `DataType` is not null, the data of up to six users during a period of up to one hour can be queried (the period can start and end on different days). If `DataType` is null, the data of up to 100 users can be returned per page (the value of `PageSize` cannot exceed 100). Six users are queried by default. The period queried cannot exceed four hours. This API is used to query call quality and is not recommended for billing purposes.
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/54481?product=pricing.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeCallDetailInfoResponse"/></returns>
        public Task<DescribeCallDetailInfoResponse> DescribeCallDetailInfo(DescribeCallDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeCallDetailInfoResponse>(req, "DescribeCallDetailInfo");
        }

        /// <summary>
        /// This API (the old `DescribeCallDetail`) is used to query the user list and call quality data of a specified time range in the last 14 days. If `DataType` is not null, the data of up to six users during a period of up to one hour can be queried (the period can start and end on different days). If `DataType` is null, the data of up to 100 users can be returned per page (the value of `PageSize` cannot exceed 100). Six users are queried by default. The period queried cannot exceed four hours. This API is used to query call quality and is not recommended for billing purposes.
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/54481?product=pricing.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeCallDetailInfoResponse"/></returns>
        public DescribeCallDetailInfoResponse DescribeCallDetailInfoSync(DescribeCallDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeCallDetailInfoResponse>(req, "DescribeCallDetailInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of the moderation task and information about the subscription blocklist and allowlist after the task is started, which is valid only when the task is in progress. An error will be returned if the task is exited.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudModerationRequest"/></param>
        /// <returns><see cref="DescribeCloudModerationResponse"/></returns>
        public Task<DescribeCloudModerationResponse> DescribeCloudModeration(DescribeCloudModerationRequest req)
        {
            return InternalRequestAsync<DescribeCloudModerationResponse>(req, "DescribeCloudModeration");
        }

        /// <summary>
        /// This API is used to query the status of the moderation task and information about the subscription blocklist and allowlist after the task is started, which is valid only when the task is in progress. An error will be returned if the task is exited.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudModerationRequest"/></param>
        /// <returns><see cref="DescribeCloudModerationResponse"/></returns>
        public DescribeCloudModerationResponse DescribeCloudModerationSync(DescribeCloudModerationRequest req)
        {
            return InternalRequestAsync<DescribeCloudModerationResponse>(req, "DescribeCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of a recording task after it starts. It works only when a task is in progress. If the task has already ended when this API is called, an error will be returned.
        /// If a recording file is being uploaded to VOD, the response parameter `StorageFileList` will not contain the information of the recording file. Please listen for the recording file callback to get the information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRecordingRequest"/></param>
        /// <returns><see cref="DescribeCloudRecordingResponse"/></returns>
        public Task<DescribeCloudRecordingResponse> DescribeCloudRecording(DescribeCloudRecordingRequest req)
        {
            return InternalRequestAsync<DescribeCloudRecordingResponse>(req, "DescribeCloudRecording");
        }

        /// <summary>
        /// This API is used to query the status of a recording task after it starts. It works only when a task is in progress. If the task has already ended when this API is called, an error will be returned.
        /// If a recording file is being uploaded to VOD, the response parameter `StorageFileList` will not contain the information of the recording file. Please listen for the recording file callback to get the information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRecordingRequest"/></param>
        /// <returns><see cref="DescribeCloudRecordingResponse"/></returns>
        public DescribeCloudRecordingResponse DescribeCloudRecordingSync(DescribeCloudRecordingRequest req)
        {
            return InternalRequestAsync<DescribeCloudRecordingResponse>(req, "DescribeCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of the slicing task after it is started, which is valid only when the task is in progress. An error will be returned if the task is exited.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudSliceTaskResponse"/></returns>
        public Task<DescribeCloudSliceTaskResponse> DescribeCloudSliceTask(DescribeCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudSliceTaskResponse>(req, "DescribeCloudSliceTask");
        }

        /// <summary>
        /// This API is used to query the status of the slicing task after it is started, which is valid only when the task is in progress. An error will be returned if the task is exited.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudSliceTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudSliceTaskResponse"/></returns>
        public DescribeCloudSliceTaskResponse DescribeCloudSliceTaskSync(DescribeCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudSliceTaskResponse>(req, "DescribeCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query your usage of TRTC’s On-Cloud MixTranscoding service.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeMixTranscodingUsageRequest"/></param>
        /// <returns><see cref="DescribeMixTranscodingUsageResponse"/></returns>
        public Task<DescribeMixTranscodingUsageResponse> DescribeMixTranscodingUsage(DescribeMixTranscodingUsageRequest req)
        {
            return InternalRequestAsync<DescribeMixTranscodingUsageResponse>(req, "DescribeMixTranscodingUsage");
        }

        /// <summary>
        /// This API is used to query your usage of TRTC’s On-Cloud MixTranscoding service.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeMixTranscodingUsageRequest"/></param>
        /// <returns><see cref="DescribeMixTranscodingUsageResponse"/></returns>
        public DescribeMixTranscodingUsageResponse DescribeMixTranscodingUsageSync(DescribeMixTranscodingUsageRequest req)
        {
            return InternalRequestAsync<DescribeMixTranscodingUsageResponse>(req, "DescribeMixTranscodingUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query your TRTC recording usage.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingUsageRequest"/></param>
        /// <returns><see cref="DescribeRecordingUsageResponse"/></returns>
        public Task<DescribeRecordingUsageResponse> DescribeRecordingUsage(DescribeRecordingUsageRequest req)
        {
            return InternalRequestAsync<DescribeRecordingUsageResponse>(req, "DescribeRecordingUsage");
        }

        /// <summary>
        /// This API is used to query your TRTC recording usage.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingUsageRequest"/></param>
        /// <returns><see cref="DescribeRecordingUsageResponse"/></returns>
        public DescribeRecordingUsageResponse DescribeRecordingUsageSync(DescribeRecordingUsageRequest req)
        {
            return InternalRequestAsync<DescribeRecordingUsageResponse>(req, "DescribeRecordingUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query your usage of TRTC’s relay to CDN service.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelayUsageRequest"/></param>
        /// <returns><see cref="DescribeRelayUsageResponse"/></returns>
        public Task<DescribeRelayUsageResponse> DescribeRelayUsage(DescribeRelayUsageRequest req)
        {
            return InternalRequestAsync<DescribeRelayUsageResponse>(req, "DescribeRelayUsage");
        }

        /// <summary>
        /// This API is used to query your usage of TRTC’s relay to CDN service.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelayUsageRequest"/></param>
        /// <returns><see cref="DescribeRelayUsageResponse"/></returns>
        public DescribeRelayUsageResponse DescribeRelayUsageSync(DescribeRelayUsageRequest req)
        {
            return InternalRequestAsync<DescribeRelayUsageResponse>(req, "DescribeRelayUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (the old `DescribeRoomInformation`) is used to query the rooms of an application (`SDKAppID`) in the last 14 days. Up to 100 records can be returned per call (10 are returned by default).
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/54481
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public Task<DescribeRoomInfoResponse> DescribeRoomInfo(DescribeRoomInfoRequest req)
        {
            return InternalRequestAsync<DescribeRoomInfoResponse>(req, "DescribeRoomInfo");
        }

        /// <summary>
        /// This API (the old `DescribeRoomInformation`) is used to query the rooms of an application (`SDKAppID`) in the last 14 days. Up to 100 records can be returned per call (10 are returned by default).
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/54481
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public DescribeRoomInfoResponse DescribeRoomInfoSync(DescribeRoomInfoRequest req)
        {
            return InternalRequestAsync<DescribeRoomInfoResponse>(req, "DescribeRoomInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (the old `DescribeHistoryScale`) is used to query the daily number of rooms and users of an application (`SDKAppID`) in the last 14 days. Data for the current day cannot be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeScaleInfoRequest"/></param>
        /// <returns><see cref="DescribeScaleInfoResponse"/></returns>
        public Task<DescribeScaleInfoResponse> DescribeScaleInfo(DescribeScaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeScaleInfoResponse>(req, "DescribeScaleInfo");
        }

        /// <summary>
        /// This API (the old `DescribeHistoryScale`) is used to query the daily number of rooms and users of an application (`SDKAppID`) in the last 14 days. Data for the current day cannot be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeScaleInfoRequest"/></param>
        /// <returns><see cref="DescribeScaleInfoResponse"/></returns>
        public DescribeScaleInfoResponse DescribeScaleInfoSync(DescribeScaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeScaleInfoResponse>(req, "DescribeScaleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// You can query the status of the Relay task.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamIngestRequest"/></param>
        /// <returns><see cref="DescribeStreamIngestResponse"/></returns>
        public Task<DescribeStreamIngestResponse> DescribeStreamIngest(DescribeStreamIngestRequest req)
        {
            return InternalRequestAsync<DescribeStreamIngestResponse>(req, "DescribeStreamIngest");
        }

        /// <summary>
        /// You can query the status of the Relay task.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamIngestRequest"/></param>
        /// <returns><see cref="DescribeStreamIngestResponse"/></returns>
        public DescribeStreamIngestResponse DescribeStreamIngestSync(DescribeStreamIngestRequest req)
        {
            return InternalRequestAsync<DescribeStreamIngestResponse>(req, "DescribeStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Data Dashboard Quality Metrics (including the following metrics)
        /// joinSuccessRate: Join channel success rate.
        /// joinSuccessIn5sRate: Join channel success rate within 5s.
        /// audioFreezeRate: Audio stutter rate.
        /// videoFreezeRate: Video stutter rate.
        /// networkDelay: Lag rate.
        /// Note:
        /// 1. To call the API, you need to activate the monitoring dashboard Standard Edition and Premium Edition, the monitoring dashboard Free Edition does not support calling. Monitoring dashboard version features and billing overview: https://trtc.io/document/54481.
        /// 2. The query time range depends on the monitoring dashboard function version, premium edition can query the last 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketQualityDataResponse"/></returns>
        public Task<DescribeTRTCMarketQualityDataResponse> DescribeTRTCMarketQualityData(DescribeTRTCMarketQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketQualityDataResponse>(req, "DescribeTRTCMarketQualityData");
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Data Dashboard Quality Metrics (including the following metrics)
        /// joinSuccessRate: Join channel success rate.
        /// joinSuccessIn5sRate: Join channel success rate within 5s.
        /// audioFreezeRate: Audio stutter rate.
        /// videoFreezeRate: Video stutter rate.
        /// networkDelay: Lag rate.
        /// Note:
        /// 1. To call the API, you need to activate the monitoring dashboard Standard Edition and Premium Edition, the monitoring dashboard Free Edition does not support calling. Monitoring dashboard version features and billing overview: https://trtc.io/document/54481.
        /// 2. The query time range depends on the monitoring dashboard function version, premium edition can query the last 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketQualityDataResponse"/></returns>
        public DescribeTRTCMarketQualityDataResponse DescribeTRTCMarketQualityDataSync(DescribeTRTCMarketQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketQualityDataResponse>(req, "DescribeTRTCMarketQualityData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Data Dashboard Scale Metrics (will return userCount, roomCount, peakCurrentUsers, peakCurrentChannels)
        /// - userCount: number of users in the call,
        /// - roomCount: number of rooms in the call, counted as one call channel from the time a user joins the channel to the time all users leave the channel.
        /// - peakCurrentChannels: peak number of channels online at the same time.
        /// - peakCurrentUsers: peak number of users online at the same time.
        /// Note:
        /// 1. To call the interface, you need to activate the monitoring dashboard Standard Edition and Premium Edition, the monitoring dashboard Free Edition does not support calling, for monitoring dashboard version features and billing overview: https://trtc.io/document/54481.
        /// 2. The query time range depends on the monitoring dashboard function version, premium edition can query up to 60 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketScaleDataResponse"/></returns>
        public Task<DescribeTRTCMarketScaleDataResponse> DescribeTRTCMarketScaleData(DescribeTRTCMarketScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketScaleDataResponse>(req, "DescribeTRTCMarketScaleData");
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Data Dashboard Scale Metrics (will return userCount, roomCount, peakCurrentUsers, peakCurrentChannels)
        /// - userCount: number of users in the call,
        /// - roomCount: number of rooms in the call, counted as one call channel from the time a user joins the channel to the time all users leave the channel.
        /// - peakCurrentChannels: peak number of channels online at the same time.
        /// - peakCurrentUsers: peak number of users online at the same time.
        /// Note:
        /// 1. To call the interface, you need to activate the monitoring dashboard Standard Edition and Premium Edition, the monitoring dashboard Free Edition does not support calling, for monitoring dashboard version features and billing overview: https://trtc.io/document/54481.
        /// 2. The query time range depends on the monitoring dashboard function version, premium edition can query up to 60 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCMarketScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCMarketScaleDataResponse"/></returns>
        public DescribeTRTCMarketScaleDataResponse DescribeTRTCMarketScaleDataSync(DescribeTRTCMarketScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCMarketScaleDataResponse>(req, "DescribeTRTCMarketScaleData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Real-Time Monitoring Quality Metrics (return the following metrics)
        ///  -Video stutter rate
        ///  -Audio stutter rate
        ///  Note:
        ///  1. To call the API, you need to activate the Monitoring Dashboard Standard Edition and Premium Edition. The Monitoring Dashboard Free Edition does not support calling. For monitoring dashboard version features and billing overview, please visit: https://trtc.io/document/54481.
        ///  2. The query time range depends on the monitoring dashboard function version. The premium edition can query up to 1 hours
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeQualityDataResponse"/></returns>
        public Task<DescribeTRTCRealTimeQualityDataResponse> DescribeTRTCRealTimeQualityData(DescribeTRTCRealTimeQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeQualityDataResponse>(req, "DescribeTRTCRealTimeQualityData");
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Real-Time Monitoring Quality Metrics (return the following metrics)
        ///  -Video stutter rate
        ///  -Audio stutter rate
        ///  Note:
        ///  1. To call the API, you need to activate the Monitoring Dashboard Standard Edition and Premium Edition. The Monitoring Dashboard Free Edition does not support calling. For monitoring dashboard version features and billing overview, please visit: https://trtc.io/document/54481.
        ///  2. The query time range depends on the monitoring dashboard function version. The premium edition can query up to 1 hours
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeQualityDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeQualityDataResponse"/></returns>
        public DescribeTRTCRealTimeQualityDataResponse DescribeTRTCRealTimeQualityDataSync(DescribeTRTCRealTimeQualityDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeQualityDataResponse>(req, "DescribeTRTCRealTimeQualityData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Real-Time Monitoring Scale Metrics (the following metrics will be returned) -userCount (Online users) -roomCount (Online rooms) Note: 1. To call the interface, you need to activate the monitoring dashboard Standard Edition and Premium Edition, the monitoring dashboard Free Edition does not support calling. For monitoring dashboard version features and billing overview, please visit: https://trtc.io/document/54481. 2. The query time range depends on the function version of the monitoring dashboard. The premium edition can query the last 1 hours
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeScaleDataResponse"/></returns>
        public Task<DescribeTRTCRealTimeScaleDataResponse> DescribeTRTCRealTimeScaleData(DescribeTRTCRealTimeScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeScaleDataResponse>(req, "DescribeTRTCRealTimeScaleData");
        }

        /// <summary>
        /// Query TRTC Monitoring Dashboard - Real-Time Monitoring Scale Metrics (the following metrics will be returned) -userCount (Online users) -roomCount (Online rooms) Note: 1. To call the interface, you need to activate the monitoring dashboard Standard Edition and Premium Edition, the monitoring dashboard Free Edition does not support calling. For monitoring dashboard version features and billing overview, please visit: https://trtc.io/document/54481. 2. The query time range depends on the function version of the monitoring dashboard. The premium edition can query the last 1 hours
        /// </summary>
        /// <param name="req"><see cref="DescribeTRTCRealTimeScaleDataRequest"/></param>
        /// <returns><see cref="DescribeTRTCRealTimeScaleDataResponse"/></returns>
        public DescribeTRTCRealTimeScaleDataResponse DescribeTRTCRealTimeScaleDataSync(DescribeTRTCRealTimeScaleDataRequest req)
        {
            return InternalRequestAsync<DescribeTRTCRealTimeScaleDataResponse>(req, "DescribeTRTCRealTimeScaleData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query usage data grouped by room.
        /// - The queried period cannot exceed 24 hours. If the period spans two different days, the data returned may not be accurate due to a delay in data collection. You can make multiple calls to query the usage on different days.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is one call every 15 seconds.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcRoomUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcRoomUsageResponse"/></returns>
        public Task<DescribeTrtcRoomUsageResponse> DescribeTrtcRoomUsage(DescribeTrtcRoomUsageRequest req)
        {
            return InternalRequestAsync<DescribeTrtcRoomUsageResponse>(req, "DescribeTrtcRoomUsage");
        }

        /// <summary>
        /// This API is used to query usage data grouped by room.
        /// - The queried period cannot exceed 24 hours. If the period spans two different days, the data returned may not be accurate due to a delay in data collection. You can make multiple calls to query the usage on different days.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is one call every 15 seconds.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcRoomUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcRoomUsageResponse"/></returns>
        public DescribeTrtcRoomUsageResponse DescribeTrtcRoomUsageSync(DescribeTrtcRoomUsageRequest req)
        {
            return InternalRequestAsync<DescribeTrtcRoomUsageResponse>(req, "DescribeTrtcRoomUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query your TRTC audio/video duration.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcUsageResponse"/></returns>
        public Task<DescribeTrtcUsageResponse> DescribeTrtcUsage(DescribeTrtcUsageRequest req)
        {
            return InternalRequestAsync<DescribeTrtcUsageResponse>(req, "DescribeTrtcUsage");
        }

        /// <summary>
        /// This API is used to query your TRTC audio/video duration.
        /// - If the period queried is one day or shorter, the statistics returned are on a five-minute basis. If the period queried is longer than one day, the statistics returned are on a daily basis.
        /// - The period queried per request cannot be longer than 31 days.
        /// - If you query the statistics of the current day, the statistics returned may be inaccurate due to the delay in data collection.
        /// - You can use this API to query your historical usage or to reconcile data, but we do not recommend you use it for crucial business logic.
        /// - The rate limit of this API is five calls per second.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrtcUsageRequest"/></param>
        /// <returns><see cref="DescribeTrtcUsageResponse"/></returns>
        public DescribeTrtcUsageResponse DescribeTrtcUsageSync(DescribeTrtcUsageRequest req)
        {
            return InternalRequestAsync<DescribeTrtcUsageResponse>(req, "DescribeTrtcUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (the old `DescribeAbnormalEvent`) is used to query up to 20 random abnormal user experiences of an application (`SDKAppID`) in the last 14 days. The start and end time can be on two different days, but they cannot be more than one hour apart.
        /// For details about the error events, see https://intl.cloud.tencent.com/document/product/647/44916?from_cn_redirect=1
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://www.tencentcloud.com/document/product/647/54481.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnusualEventRequest"/></param>
        /// <returns><see cref="DescribeUnusualEventResponse"/></returns>
        public Task<DescribeUnusualEventResponse> DescribeUnusualEvent(DescribeUnusualEventRequest req)
        {
            return InternalRequestAsync<DescribeUnusualEventResponse>(req, "DescribeUnusualEvent");
        }

        /// <summary>
        /// This API (the old `DescribeAbnormalEvent`) is used to query up to 20 random abnormal user experiences of an application (`SDKAppID`) in the last 14 days. The start and end time can be on two different days, but they cannot be more than one hour apart.
        /// For details about the error events, see https://intl.cloud.tencent.com/document/product/647/44916?from_cn_redirect=1
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://www.tencentcloud.com/document/product/647/54481.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnusualEventRequest"/></param>
        /// <returns><see cref="DescribeUnusualEventResponse"/></returns>
        public DescribeUnusualEventResponse DescribeUnusualEventSync(DescribeUnusualEventRequest req)
        {
            return InternalRequestAsync<DescribeUnusualEventResponse>(req, "DescribeUnusualEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (the old `DescribeDetailEvent`) is used to query the events of a call in the last 14 days, including user entry and exit, turning the camera on/off, etc.
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/54481?product=pricing.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserEventRequest"/></param>
        /// <returns><see cref="DescribeUserEventResponse"/></returns>
        public Task<DescribeUserEventResponse> DescribeUserEvent(DescribeUserEventRequest req)
        {
            return InternalRequestAsync<DescribeUserEventResponse>(req, "DescribeUserEvent");
        }

        /// <summary>
        /// This API (the old `DescribeDetailEvent`) is used to query the events of a call in the last 14 days, including user entry and exit, turning the camera on/off, etc.
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/54481?product=pricing.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserEventRequest"/></param>
        /// <returns><see cref="DescribeUserEventResponse"/></returns>
        public DescribeUserEventResponse DescribeUserEventSync(DescribeUserEventRequest req)
        {
            return InternalRequestAsync<DescribeUserEventResponse>(req, "DescribeUserEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (the old `DescribeUserInformation`) is used to query the user list of a specified time range (up to four hours) in the last 14 days. The data of up to 100 users can be returned per page (six are returned by default).
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/60214?product=pricing.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// This API (the old `DescribeUserInformation`) is used to query the user list of a specified time range (up to four hours) in the last 14 days. The data of up to 100 users can be returned per page (six are returned by default).
        /// **Note**:
        /// 1. You can use this API to query historical data or for reconciliation purposes, but we do not recommend you use it for crucial business logic.
        /// 2. If you need to call this API, please upgrade the monitoring dashboard version to "Standard". For more details, please refer to: https://trtc.io/document/60214?product=pricing.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the status of a web-page recording task
        /// </summary>
        /// <param name="req"><see cref="DescribeWebRecordRequest"/></param>
        /// <returns><see cref="DescribeWebRecordResponse"/></returns>
        public Task<DescribeWebRecordResponse> DescribeWebRecord(DescribeWebRecordRequest req)
        {
            return InternalRequestAsync<DescribeWebRecordResponse>(req, "DescribeWebRecord");
        }

        /// <summary>
        /// Queries the status of a web-page recording task
        /// </summary>
        /// <param name="req"><see cref="DescribeWebRecordRequest"/></param>
        /// <returns><see cref="DescribeWebRecordResponse"/></returns>
        public DescribeWebRecordResponse DescribeWebRecordSync(DescribeWebRecordRequest req)
        {
            return InternalRequestAsync<DescribeWebRecordResponse>(req, "DescribeWebRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove all users from a room and dismiss the room. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public Task<DismissRoomResponse> DismissRoom(DismissRoomRequest req)
        {
            return InternalRequestAsync<DismissRoomResponse>(req, "DismissRoom");
        }

        /// <summary>
        /// This API is used to remove all users from a room and dismiss the room. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public DismissRoomResponse DismissRoomSync(DismissRoomRequest req)
        {
            return InternalRequestAsync<DismissRoomResponse>(req, "DismissRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove all users from a room and close the room. It works on all platforms. For Android, iOS, Windows, and macOS, you need to update the TRTC SDK to version 6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdResponse"/></returns>
        public Task<DismissRoomByStrRoomIdResponse> DismissRoomByStrRoomId(DismissRoomByStrRoomIdRequest req)
        {
            return InternalRequestAsync<DismissRoomByStrRoomIdResponse>(req, "DismissRoomByStrRoomId");
        }

        /// <summary>
        /// This API is used to remove all users from a room and close the room. It works on all platforms. For Android, iOS, Windows, and macOS, you need to update the TRTC SDK to version 6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdResponse"/></returns>
        public DismissRoomByStrRoomIdResponse DismissRoomByStrRoomIdSync(DismissRoomByStrRoomIdRequest req)
        {
            return InternalRequestAsync<DismissRoomByStrRoomIdResponse>(req, "DismissRoomByStrRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the subscription blocklist and allowlist after the cloud moderation task is successfully started.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudModerationRequest"/></param>
        /// <returns><see cref="ModifyCloudModerationResponse"/></returns>
        public Task<ModifyCloudModerationResponse> ModifyCloudModeration(ModifyCloudModerationRequest req)
        {
            return InternalRequestAsync<ModifyCloudModerationResponse>(req, "ModifyCloudModeration");
        }

        /// <summary>
        /// This API is used to update the subscription blocklist and allowlist after the cloud moderation task is successfully started.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudModerationRequest"/></param>
        /// <returns><see cref="ModifyCloudModerationResponse"/></returns>
        public ModifyCloudModerationResponse ModifyCloudModerationSync(ModifyCloudModerationRequest req)
        {
            return InternalRequestAsync<ModifyCloudModerationResponse>(req, "ModifyCloudModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a recording task. It works only when a task is in progress. If the task has already ended when this API is called, an error will be returned. You need to specify all the parameters for each request instead of just the ones you want to modify.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudRecordingRequest"/></param>
        /// <returns><see cref="ModifyCloudRecordingResponse"/></returns>
        public Task<ModifyCloudRecordingResponse> ModifyCloudRecording(ModifyCloudRecordingRequest req)
        {
            return InternalRequestAsync<ModifyCloudRecordingResponse>(req, "ModifyCloudRecording");
        }

        /// <summary>
        /// This API is used to modify a recording task. It works only when a task is in progress. If the task has already ended when this API is called, an error will be returned. You need to specify all the parameters for each request instead of just the ones you want to modify.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudRecordingRequest"/></param>
        /// <returns><see cref="ModifyCloudRecordingResponse"/></returns>
        public ModifyCloudRecordingResponse ModifyCloudRecordingSync(ModifyCloudRecordingRequest req)
        {
            return InternalRequestAsync<ModifyCloudRecordingResponse>(req, "ModifyCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the slicing task after it is started. It can be used to update the allowlist or blocklist for the specified subscription stream.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudSliceTaskRequest"/></param>
        /// <returns><see cref="ModifyCloudSliceTaskResponse"/></returns>
        public Task<ModifyCloudSliceTaskResponse> ModifyCloudSliceTask(ModifyCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<ModifyCloudSliceTaskResponse>(req, "ModifyCloudSliceTask");
        }

        /// <summary>
        /// This API is used to update the slicing task after it is started. It can be used to update the allowlist or blocklist for the specified subscription stream.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudSliceTaskRequest"/></param>
        /// <returns><see cref="ModifyCloudSliceTaskResponse"/></returns>
        public ModifyCloudSliceTaskResponse ModifyCloudSliceTaskSync(ModifyCloudSliceTaskRequest req)
        {
            return InternalRequestAsync<ModifyCloudSliceTaskResponse>(req, "ModifyCloudSliceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a user from a room. It is applicable to scenarios where the anchor, room owner, or admin wants to kick out a user. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public Task<RemoveUserResponse> RemoveUser(RemoveUserRequest req)
        {
            return InternalRequestAsync<RemoveUserResponse>(req, "RemoveUser");
        }

        /// <summary>
        /// This API is used to remove a user from a room. It is applicable to scenarios where the anchor, room owner, or admin wants to kick out a user. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public RemoveUserResponse RemoveUserSync(RemoveUserRequest req)
        {
            return InternalRequestAsync<RemoveUserResponse>(req, "RemoveUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a user from a room. It allows the anchor, room owner, or admin to kick out a user, and works on all platforms. For Android, iOS, Windows, and macOS, you need to update the TRTC SDK to version 6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByStrRoomIdRequest"/></param>
        /// <returns><see cref="RemoveUserByStrRoomIdResponse"/></returns>
        public Task<RemoveUserByStrRoomIdResponse> RemoveUserByStrRoomId(RemoveUserByStrRoomIdRequest req)
        {
            return InternalRequestAsync<RemoveUserByStrRoomIdResponse>(req, "RemoveUserByStrRoomId");
        }

        /// <summary>
        /// This API is used to remove a user from a room. It allows the anchor, room owner, or admin to kick out a user, and works on all platforms. For Android, iOS, Windows, and macOS, you need to update the TRTC SDK to version 6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByStrRoomIdRequest"/></param>
        /// <returns><see cref="RemoveUserByStrRoomIdResponse"/></returns>
        public RemoveUserByStrRoomIdResponse RemoveUserByStrRoomIdSync(RemoveUserByStrRoomIdRequest req)
        {
            return InternalRequestAsync<RemoveUserByStrRoomIdResponse>(req, "RemoveUserByStrRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable or enable the audio and video of a user. It can be used by an anchor, room owner, or admin to block or unblock a user. It supports platforms including Android, iOS, Windows, macOS, web, and WeChat Mini Program. Use this API if the room ID is a number.
        /// </summary>
        /// <param name="req"><see cref="SetUserBlockedRequest"/></param>
        /// <returns><see cref="SetUserBlockedResponse"/></returns>
        public Task<SetUserBlockedResponse> SetUserBlocked(SetUserBlockedRequest req)
        {
            return InternalRequestAsync<SetUserBlockedResponse>(req, "SetUserBlocked");
        }

        /// <summary>
        /// This API is used to disable or enable the audio and video of a user. It can be used by an anchor, room owner, or admin to block or unblock a user. It supports platforms including Android, iOS, Windows, macOS, web, and WeChat Mini Program. Use this API if the room ID is a number.
        /// </summary>
        /// <param name="req"><see cref="SetUserBlockedRequest"/></param>
        /// <returns><see cref="SetUserBlockedResponse"/></returns>
        public SetUserBlockedResponse SetUserBlockedSync(SetUserBlockedRequest req)
        {
            return InternalRequestAsync<SetUserBlockedResponse>(req, "SetUserBlocked")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API allows an anchor, room owner, admin to mute/unmute a user. It can be used on platforms including Android, iOS, Windows, macOS, web, and WeChat Mini Program. Use this API when the room ID is a string.
        /// </summary>
        /// <param name="req"><see cref="SetUserBlockedByStrRoomIdRequest"/></param>
        /// <returns><see cref="SetUserBlockedByStrRoomIdResponse"/></returns>
        public Task<SetUserBlockedByStrRoomIdResponse> SetUserBlockedByStrRoomId(SetUserBlockedByStrRoomIdRequest req)
        {
            return InternalRequestAsync<SetUserBlockedByStrRoomIdResponse>(req, "SetUserBlockedByStrRoomId");
        }

        /// <summary>
        /// This API allows an anchor, room owner, admin to mute/unmute a user. It can be used on platforms including Android, iOS, Windows, macOS, web, and WeChat Mini Program. Use this API when the room ID is a string.
        /// </summary>
        /// <param name="req"><see cref="SetUserBlockedByStrRoomIdRequest"/></param>
        /// <returns><see cref="SetUserBlockedByStrRoomIdResponse"/></returns>
        public SetUserBlockedByStrRoomIdResponse SetUserBlockedByStrRoomIdSync(SetUserBlockedByStrRoomIdRequest req)
        {
            return InternalRequestAsync<SetUserBlockedByStrRoomIdResponse>(req, "SetUserBlockedByStrRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate AI conversation task, where the AI bot enters the TRTC room to engage in AI conversation with specified members in the room. This is suitable for scenarios such as intelligent customer service and AI language teachers. The TRTC AI conversation feature has built-in speech-to-text capabilities , allowing customers to flexibly specify third-party AI model (LLM) services and text-to-speech (TTS) services. For more [feature details](https://cloud.tencent.com/document/product/647/108901).
        /// </summary>
        /// <param name="req"><see cref="StartAIConversationRequest"/></param>
        /// <returns><see cref="StartAIConversationResponse"/></returns>
        public Task<StartAIConversationResponse> StartAIConversation(StartAIConversationRequest req)
        {
            return InternalRequestAsync<StartAIConversationResponse>(req, "StartAIConversation");
        }

        /// <summary>
        /// Initiate AI conversation task, where the AI bot enters the TRTC room to engage in AI conversation with specified members in the room. This is suitable for scenarios such as intelligent customer service and AI language teachers. The TRTC AI conversation feature has built-in speech-to-text capabilities , allowing customers to flexibly specify third-party AI model (LLM) services and text-to-speech (TTS) services. For more [feature details](https://cloud.tencent.com/document/product/647/108901).
        /// </summary>
        /// <param name="req"><see cref="StartAIConversationRequest"/></param>
        /// <returns><see cref="StartAIConversationResponse"/></returns>
        public StartAIConversationResponse StartAIConversationSync(StartAIConversationRequest req)
        {
            return InternalRequestAsync<StartAIConversationResponse>(req, "StartAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate the transcription bot. The backend will pull the stream through the bot to perform real-time speech recognition and deliver subtitles and transcription messages. The transcription bot supports two stream pulling modes, controlled by the `TranscriptionMode` field:
        /// - Pull the stream of the entire room.
        /// - Pull the stream of a specific user.
        /// 
        /// The server delivers subtitles and transcription messages in real-time through TRTC's custom messages, with `CmdId` fixed at 1. The client only needs to listen for the callback of custom messages. For example, see the [C++ callback](https://cloud.tencent.com/document/product/647/79637#4cd82f4edb24992a15a25187089e1565). Other clients, such as Android, Web, etc., can also be found at the same link.
        /// </summary>
        /// <param name="req"><see cref="StartAITranscriptionRequest"/></param>
        /// <returns><see cref="StartAITranscriptionResponse"/></returns>
        public Task<StartAITranscriptionResponse> StartAITranscription(StartAITranscriptionRequest req)
        {
            return InternalRequestAsync<StartAITranscriptionResponse>(req, "StartAITranscription");
        }

        /// <summary>
        /// Initiate the transcription bot. The backend will pull the stream through the bot to perform real-time speech recognition and deliver subtitles and transcription messages. The transcription bot supports two stream pulling modes, controlled by the `TranscriptionMode` field:
        /// - Pull the stream of the entire room.
        /// - Pull the stream of a specific user.
        /// 
        /// The server delivers subtitles and transcription messages in real-time through TRTC's custom messages, with `CmdId` fixed at 1. The client only needs to listen for the callback of custom messages. For example, see the [C++ callback](https://cloud.tencent.com/document/product/647/79637#4cd82f4edb24992a15a25187089e1565). Other clients, such as Android, Web, etc., can also be found at the same link.
        /// </summary>
        /// <param name="req"><see cref="StartAITranscriptionRequest"/></param>
        /// <returns><see cref="StartAITranscriptionResponse"/></returns>
        public StartAITranscriptionResponse StartAITranscriptionSync(StartAITranscriptionRequest req)
        {
            return InternalRequestAsync<StartAITranscriptionResponse>(req, "StartAITranscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **API Description**
        /// 
        /// This API starts a stream mixing and relaying task. This API mixes multiple audio/video streams from a TRTC room into a single stream, encodes it, and then pushes it to CDN server or publishs it into the TRTC room. It also supports relaying a single stream from a TRTC room directly without transcoding.
        /// 
        /// After success, the API returns a globally unique TaskID. You will need this TaskId in later operations such as updating or stopping the task.
        /// 
        /// For more details, refer to the document:  [Feature Description](https://trtc.io/zh/document/47858?product=rtcengine ) and [FAQs](https://trtc.io/zh/document/36058?product=rtcengine&menulabel=core%20sdk&platform=web) .
        /// 
        /// Note: You can enable the relay to CDN in the console to monitor events under the CDN relay status. For callback details, see: [Relay to CDN Callback Description](https://trtc.io/zh/document/54913?product=rtcengine&menulabel=core%20sdk&platform=web ) .
        /// 
        /// Starting a relay task may incur the following fees:
        /// MCU stream mixing and transcoding fees: [See Cloud Stream Mixing and Transcoding Pricing](https://trtc.io/zh/document/47631 ) .
        /// </summary>
        /// <param name="req"><see cref="StartPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StartPublishCdnStreamResponse"/></returns>
        public Task<StartPublishCdnStreamResponse> StartPublishCdnStream(StartPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StartPublishCdnStreamResponse>(req, "StartPublishCdnStream");
        }

        /// <summary>
        /// **API Description**
        /// 
        /// This API starts a stream mixing and relaying task. This API mixes multiple audio/video streams from a TRTC room into a single stream, encodes it, and then pushes it to CDN server or publishs it into the TRTC room. It also supports relaying a single stream from a TRTC room directly without transcoding.
        /// 
        /// After success, the API returns a globally unique TaskID. You will need this TaskId in later operations such as updating or stopping the task.
        /// 
        /// For more details, refer to the document:  [Feature Description](https://trtc.io/zh/document/47858?product=rtcengine ) and [FAQs](https://trtc.io/zh/document/36058?product=rtcengine&menulabel=core%20sdk&platform=web) .
        /// 
        /// Note: You can enable the relay to CDN in the console to monitor events under the CDN relay status. For callback details, see: [Relay to CDN Callback Description](https://trtc.io/zh/document/54913?product=rtcengine&menulabel=core%20sdk&platform=web ) .
        /// 
        /// Starting a relay task may incur the following fees:
        /// MCU stream mixing and transcoding fees: [See Cloud Stream Mixing and Transcoding Pricing](https://trtc.io/zh/document/47631 ) .
        /// </summary>
        /// <param name="req"><see cref="StartPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StartPublishCdnStreamResponse"/></returns>
        public StartPublishCdnStreamResponse StartPublishCdnStreamSync(StartPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StartPublishCdnStreamResponse>(req, "StartPublishCdnStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Push an online media stream to the TRTC room.
        /// </summary>
        /// <param name="req"><see cref="StartStreamIngestRequest"/></param>
        /// <returns><see cref="StartStreamIngestResponse"/></returns>
        public Task<StartStreamIngestResponse> StartStreamIngest(StartStreamIngestRequest req)
        {
            return InternalRequestAsync<StartStreamIngestResponse>(req, "StartStreamIngest");
        }

        /// <summary>
        /// Push an online media stream to the TRTC room.
        /// </summary>
        /// <param name="req"><see cref="StartStreamIngestRequest"/></param>
        /// <returns><see cref="StartStreamIngestResponse"/></returns>
        public StartStreamIngestResponse StartStreamIngestSync(StartStreamIngestRequest req)
        {
            return InternalRequestAsync<StartStreamIngestResponse>(req, "StartStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface can be used to initiate a web-page recording task. In the interface parameters, specify the recording URL, recording resolution, recording result storage and other parameters. If there are parameter or API logic problems, the result will be returned immediately. If there are page problems, such as the page cannot be accessed, the result will be returned in the callback. Please pay attention.
        /// </summary>
        /// <param name="req"><see cref="StartWebRecordRequest"/></param>
        /// <returns><see cref="StartWebRecordResponse"/></returns>
        public Task<StartWebRecordResponse> StartWebRecord(StartWebRecordRequest req)
        {
            return InternalRequestAsync<StartWebRecordResponse>(req, "StartWebRecord");
        }

        /// <summary>
        /// This interface can be used to initiate a web-page recording task. In the interface parameters, specify the recording URL, recording resolution, recording result storage and other parameters. If there are parameter or API logic problems, the result will be returned immediately. If there are page problems, such as the page cannot be accessed, the result will be returned in the callback. Please pay attention.
        /// </summary>
        /// <param name="req"><see cref="StartWebRecordRequest"/></param>
        /// <returns><see cref="StartWebRecordResponse"/></returns>
        public StartWebRecordResponse StartWebRecordSync(StartWebRecordRequest req)
        {
            return InternalRequestAsync<StartWebRecordResponse>(req, "StartWebRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop AI conversation task
        /// </summary>
        /// <param name="req"><see cref="StopAIConversationRequest"/></param>
        /// <returns><see cref="StopAIConversationResponse"/></returns>
        public Task<StopAIConversationResponse> StopAIConversation(StopAIConversationRequest req)
        {
            return InternalRequestAsync<StopAIConversationResponse>(req, "StopAIConversation");
        }

        /// <summary>
        /// Stop AI conversation task
        /// </summary>
        /// <param name="req"><see cref="StopAIConversationRequest"/></param>
        /// <returns><see cref="StopAIConversationResponse"/></returns>
        public StopAIConversationResponse StopAIConversationSync(StopAIConversationRequest req)
        {
            return InternalRequestAsync<StopAIConversationResponse>(req, "StopAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop AI Transcription task
        /// </summary>
        /// <param name="req"><see cref="StopAITranscriptionRequest"/></param>
        /// <returns><see cref="StopAITranscriptionResponse"/></returns>
        public Task<StopAITranscriptionResponse> StopAITranscription(StopAITranscriptionRequest req)
        {
            return InternalRequestAsync<StopAITranscriptionResponse>(req, "StopAITranscription");
        }

        /// <summary>
        /// Stop AI Transcription task
        /// </summary>
        /// <param name="req"><see cref="StopAITranscriptionRequest"/></param>
        /// <returns><see cref="StopAITranscriptionResponse"/></returns>
        public StopAITranscriptionResponse StopAITranscriptionSync(StopAITranscriptionRequest req)
        {
            return InternalRequestAsync<StopAITranscriptionResponse>(req, "StopAITranscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a relaying task.
        /// You can create a relay task before the anchor enters the room. When the relay task is finished, you need to call the stop interface actively. If you do not call the Stop Relay Task Interface, Tencent Cloud will automatically stop the mix relay task when all users participating in the mix have no data uploaded for a period of time exceeding the timeout (AgentParams.MaxIdleTime) set when starting the relay task.
        /// </summary>
        /// <param name="req"><see cref="StopPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StopPublishCdnStreamResponse"/></returns>
        public Task<StopPublishCdnStreamResponse> StopPublishCdnStream(StopPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StopPublishCdnStreamResponse>(req, "StopPublishCdnStream");
        }

        /// <summary>
        /// This API is used to stop a relaying task.
        /// You can create a relay task before the anchor enters the room. When the relay task is finished, you need to call the stop interface actively. If you do not call the Stop Relay Task Interface, Tencent Cloud will automatically stop the mix relay task when all users participating in the mix have no data uploaded for a period of time exceeding the timeout (AgentParams.MaxIdleTime) set when starting the relay task.
        /// </summary>
        /// <param name="req"><see cref="StopPublishCdnStreamRequest"/></param>
        /// <returns><see cref="StopPublishCdnStreamResponse"/></returns>
        public StopPublishCdnStreamResponse StopPublishCdnStreamSync(StopPublishCdnStreamRequest req)
        {
            return InternalRequestAsync<StopPublishCdnStreamResponse>(req, "StopPublishCdnStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop a Pull stream Relay task.
        /// </summary>
        /// <param name="req"><see cref="StopStreamIngestRequest"/></param>
        /// <returns><see cref="StopStreamIngestResponse"/></returns>
        public Task<StopStreamIngestResponse> StopStreamIngest(StopStreamIngestRequest req)
        {
            return InternalRequestAsync<StopStreamIngestResponse>(req, "StopStreamIngest");
        }

        /// <summary>
        /// Stop a Pull stream Relay task.
        /// </summary>
        /// <param name="req"><see cref="StopStreamIngestRequest"/></param>
        /// <returns><see cref="StopStreamIngestResponse"/></returns>
        public StopStreamIngestResponse StopStreamIngestSync(StopStreamIngestRequest req)
        {
            return InternalRequestAsync<StopStreamIngestResponse>(req, "StopStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop an web-page recording task
        /// </summary>
        /// <param name="req"><see cref="StopWebRecordRequest"/></param>
        /// <returns><see cref="StopWebRecordResponse"/></returns>
        public Task<StopWebRecordResponse> StopWebRecord(StopWebRecordRequest req)
        {
            return InternalRequestAsync<StopWebRecordResponse>(req, "StopWebRecord");
        }

        /// <summary>
        /// Stop an web-page recording task
        /// </summary>
        /// <param name="req"><see cref="StopWebRecordRequest"/></param>
        /// <returns><see cref="StopWebRecordResponse"/></returns>
        public StopWebRecordResponse StopWebRecordSync(StopWebRecordRequest req)
        {
            return InternalRequestAsync<StopWebRecordResponse>(req, "StopWebRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update AI conversation task parameters
        /// </summary>
        /// <param name="req"><see cref="UpdateAIConversationRequest"/></param>
        /// <returns><see cref="UpdateAIConversationResponse"/></returns>
        public Task<UpdateAIConversationResponse> UpdateAIConversation(UpdateAIConversationRequest req)
        {
            return InternalRequestAsync<UpdateAIConversationResponse>(req, "UpdateAIConversation");
        }

        /// <summary>
        /// Update AI conversation task parameters
        /// </summary>
        /// <param name="req"><see cref="UpdateAIConversationRequest"/></param>
        /// <returns><see cref="UpdateAIConversationResponse"/></returns>
        public UpdateAIConversationResponse UpdateAIConversationSync(UpdateAIConversationRequest req)
        {
            return InternalRequestAsync<UpdateAIConversationResponse>(req, "UpdateAIConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the parameters of a relaying task.
        /// Note: For details about how to use this API, see the `StartPublishCdnStream` document.
        /// </summary>
        /// <param name="req"><see cref="UpdatePublishCdnStreamRequest"/></param>
        /// <returns><see cref="UpdatePublishCdnStreamResponse"/></returns>
        public Task<UpdatePublishCdnStreamResponse> UpdatePublishCdnStream(UpdatePublishCdnStreamRequest req)
        {
            return InternalRequestAsync<UpdatePublishCdnStreamResponse>(req, "UpdatePublishCdnStream");
        }

        /// <summary>
        /// This API is used to change the parameters of a relaying task.
        /// Note: For details about how to use this API, see the `StartPublishCdnStream` document.
        /// </summary>
        /// <param name="req"><see cref="UpdatePublishCdnStreamRequest"/></param>
        /// <returns><see cref="UpdatePublishCdnStreamResponse"/></returns>
        public UpdatePublishCdnStreamResponse UpdatePublishCdnStreamSync(UpdatePublishCdnStreamRequest req)
        {
            return InternalRequestAsync<UpdatePublishCdnStreamResponse>(req, "UpdatePublishCdnStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// You can update the StreamUrl of the Relay task.
        /// </summary>
        /// <param name="req"><see cref="UpdateStreamIngestRequest"/></param>
        /// <returns><see cref="UpdateStreamIngestResponse"/></returns>
        public Task<UpdateStreamIngestResponse> UpdateStreamIngest(UpdateStreamIngestRequest req)
        {
            return InternalRequestAsync<UpdateStreamIngestResponse>(req, "UpdateStreamIngest");
        }

        /// <summary>
        /// You can update the StreamUrl of the Relay task.
        /// </summary>
        /// <param name="req"><see cref="UpdateStreamIngestRequest"/></param>
        /// <returns><see cref="UpdateStreamIngestResponse"/></returns>
        public UpdateStreamIngestResponse UpdateStreamIngestSync(UpdateStreamIngestRequest req)
        {
            return InternalRequestAsync<UpdateStreamIngestResponse>(req, "UpdateStreamIngest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
