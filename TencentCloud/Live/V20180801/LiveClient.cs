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

namespace TencentCloud.Live.V20180801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Live.V20180801.Models;

   public class LiveClient : AbstractClient{

       private const string endpoint = "live.tencentcloudapi.com";
       private const string version = "2018-08-01";
       private const string sdkVersion = "SDK_NET_3.0.1024";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LiveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LiveClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to set a delay in playing the images of large live streaming events, in case of emergencies.
        /// 
        /// Note: if you are to set the delay before stream push, set it at least 5 minutes before the push. This API supports configuration only by stream.
        /// </summary>
        /// <param name="req"><see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns><see cref="AddDelayLiveStreamResponse"/></returns>
        public Task<AddDelayLiveStreamResponse> AddDelayLiveStream(AddDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<AddDelayLiveStreamResponse>(req, "AddDelayLiveStream");
        }

        /// <summary>
        /// This API is used to set a delay in playing the images of large live streaming events, in case of emergencies.
        /// 
        /// Note: if you are to set the delay before stream push, set it at least 5 minutes before the push. This API supports configuration only by stream.
        /// </summary>
        /// <param name="req"><see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns><see cref="AddDelayLiveStreamResponse"/></returns>
        public AddDelayLiveStreamResponse AddDelayLiveStreamSync(AddDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<AddDelayLiveStreamResponse>(req, "AddDelayLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a domain name. Only one domain name can be submitted at a time, and it must have an ICP filing.
        /// </summary>
        /// <param name="req"><see cref="AddLiveDomainRequest"/></param>
        /// <returns><see cref="AddLiveDomainResponse"/></returns>
        public Task<AddLiveDomainResponse> AddLiveDomain(AddLiveDomainRequest req)
        {
            return InternalRequestAsync<AddLiveDomainResponse>(req, "AddLiveDomain");
        }

        /// <summary>
        /// This API is used to add a domain name. Only one domain name can be submitted at a time, and it must have an ICP filing.
        /// </summary>
        /// <param name="req"><see cref="AddLiveDomainRequest"/></param>
        /// <returns><see cref="AddLiveDomainResponse"/></returns>
        public AddLiveDomainResponse AddLiveDomainSync(AddLiveDomainRequest req)
        {
            return InternalRequestAsync<AddLiveDomainResponse>(req, "AddLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After a watermark is added and a watermark ID is successfully returned, you need to call the [CreateLiveWatermarkRule](https://intl.cloud.tencent.com/document/product/267/32629?from_cn_redirect=1) API to bind the watermark ID to a stream.
        /// After the number of watermarks exceeds the upper limit of 100, to add a new watermark, you must delete an old one first.
        /// </summary>
        /// <param name="req"><see cref="AddLiveWatermarkRequest"/></param>
        /// <returns><see cref="AddLiveWatermarkResponse"/></returns>
        public Task<AddLiveWatermarkResponse> AddLiveWatermark(AddLiveWatermarkRequest req)
        {
            return InternalRequestAsync<AddLiveWatermarkResponse>(req, "AddLiveWatermark");
        }

        /// <summary>
        /// After a watermark is added and a watermark ID is successfully returned, you need to call the [CreateLiveWatermarkRule](https://intl.cloud.tencent.com/document/product/267/32629?from_cn_redirect=1) API to bind the watermark ID to a stream.
        /// After the number of watermarks exceeds the upper limit of 100, to add a new watermark, you must delete an old one first.
        /// </summary>
        /// <param name="req"><see cref="AddLiveWatermarkRequest"/></param>
        /// <returns><see cref="AddLiveWatermarkResponse"/></returns>
        public AddLiveWatermarkResponse AddLiveWatermarkSync(AddLiveWatermarkRequest req)
        {
            return InternalRequestAsync<AddLiveWatermarkResponse>(req, "AddLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify the ownership of a domain.
        /// </summary>
        /// <param name="req"><see cref="AuthenticateDomainOwnerRequest"/></param>
        /// <returns><see cref="AuthenticateDomainOwnerResponse"/></returns>
        public Task<AuthenticateDomainOwnerResponse> AuthenticateDomainOwner(AuthenticateDomainOwnerRequest req)
        {
            return InternalRequestAsync<AuthenticateDomainOwnerResponse>(req, "AuthenticateDomainOwner");
        }

        /// <summary>
        /// This API is used to verify the ownership of a domain.
        /// </summary>
        /// <param name="req"><see cref="AuthenticateDomainOwnerRequest"/></param>
        /// <returns><see cref="AuthenticateDomainOwnerResponse"/></returns>
        public AuthenticateDomainOwnerResponse AuthenticateDomainOwnerSync(AuthenticateDomainOwnerRequest req)
        {
            return InternalRequestAsync<AuthenticateDomainOwnerResponse>(req, "AuthenticateDomainOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel a stream mix. It can be used basically in the same way as `mix_streamv2.cancel_mix_stream`.
        /// </summary>
        /// <param name="req"><see cref="CancelCommonMixStreamRequest"/></param>
        /// <returns><see cref="CancelCommonMixStreamResponse"/></returns>
        public Task<CancelCommonMixStreamResponse> CancelCommonMixStream(CancelCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CancelCommonMixStreamResponse>(req, "CancelCommonMixStream");
        }

        /// <summary>
        /// This API is used to cancel a stream mix. It can be used basically in the same way as `mix_streamv2.cancel_mix_stream`.
        /// </summary>
        /// <param name="req"><see cref="CancelCommonMixStreamRequest"/></param>
        /// <returns><see cref="CancelCommonMixStreamResponse"/></returns>
        public CancelCommonMixStreamResponse CancelCommonMixStreamSync(CancelCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CancelCommonMixStreamResponse>(req, "CancelCommonMixStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a general stream mix. It can be used basically in the same way as the legacy `mix_streamv2.start_mix_stream_advanced` API.
        /// Note: currently, up to 16 streams can be mixed.
        /// Best practice: https://intl.cloud.tencent.com/document/product/267/45566?from_cn_redirect=1
        /// </summary>
        /// <param name="req"><see cref="CreateCommonMixStreamRequest"/></param>
        /// <returns><see cref="CreateCommonMixStreamResponse"/></returns>
        public Task<CreateCommonMixStreamResponse> CreateCommonMixStream(CreateCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CreateCommonMixStreamResponse>(req, "CreateCommonMixStream");
        }

        /// <summary>
        /// This API is used to create a general stream mix. It can be used basically in the same way as the legacy `mix_streamv2.start_mix_stream_advanced` API.
        /// Note: currently, up to 16 streams can be mixed.
        /// Best practice: https://intl.cloud.tencent.com/document/product/267/45566?from_cn_redirect=1
        /// </summary>
        /// <param name="req"><see cref="CreateCommonMixStreamRequest"/></param>
        /// <returns><see cref="CreateCommonMixStreamResponse"/></returns>
        public CreateCommonMixStreamResponse CreateCommonMixStreamSync(CreateCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CreateCommonMixStreamResponse>(req, "CreateCommonMixStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// To create a callback rule, you need to first call the [CreateLiveCallbackTemplate](https://intl.cloud.tencent.com/document/product/267/32637?from_cn_redirect=1) API to create a callback template and bind the returned template ID to the domain name/path.
        /// <br>Callback protocol-related document: [Event Message Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackRuleResponse"/></returns>
        public Task<CreateLiveCallbackRuleResponse> CreateLiveCallbackRule(CreateLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackRuleResponse>(req, "CreateLiveCallbackRule");
        }

        /// <summary>
        /// To create a callback rule, you need to first call the [CreateLiveCallbackTemplate](https://intl.cloud.tencent.com/document/product/267/32637?from_cn_redirect=1) API to create a callback template and bind the returned template ID to the domain name/path.
        /// <br>Callback protocol-related document: [Event Message Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackRuleResponse"/></returns>
        public CreateLiveCallbackRuleResponse CreateLiveCallbackRuleSync(CreateLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackRuleResponse>(req, "CreateLiveCallbackRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a callback template. Up to 50 templates can be created. After the template ID is returned, you need to call the [CreateLiveCallbackRule](https://intl.cloud.tencent.com/document/product/267/32638?from_cn_redirect=1) API to bind the template ID to a domain name/path.
        /// <br>For information about callback protocols, see [How to Receive Event Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// Note: You need to specify at least one callback URL.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackTemplateResponse"/></returns>
        public Task<CreateLiveCallbackTemplateResponse> CreateLiveCallbackTemplate(CreateLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackTemplateResponse>(req, "CreateLiveCallbackTemplate");
        }

        /// <summary>
        /// This API is used to create a callback template. Up to 50 templates can be created. After the template ID is returned, you need to call the [CreateLiveCallbackRule](https://intl.cloud.tencent.com/document/product/267/32638?from_cn_redirect=1) API to bind the template ID to a domain name/path.
        /// <br>For information about callback protocols, see [How to Receive Event Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// Note: You need to specify at least one callback URL.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackTemplateResponse"/></returns>
        public CreateLiveCallbackTemplateResponse CreateLiveCallbackTemplateSync(CreateLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackTemplateResponse>(req, "CreateLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to pull streams from video files or an external live streaming source and publish them to a specified destination URL.
        /// Notes:
        /// 1. By default, you can have at most 20 stream pulling tasks at a time. You can submit a ticket to raise the limit.
        /// 2. Only H.264 and H.265 are supported for video. If the source video is in a different format, please transcode it first.
        /// 3. Only AAC is supported for audio. If the source audio is in a different format, please transcode it first.
        /// 4. You can enable auto deletion in the console to delete expired tasks automatically.
        /// 5. The pull and relay feature is a paid feature. For its billing details, see [Relay](https://intl.cloud.tencent.com/document/product/267/53308?from_cn_redirect=1).
        /// 6. CSS is only responsible for pulling and relaying content. Please make sure that your content is authorized and complies with relevant laws and regulations. In case of copyright infringement or violation of laws or regulations, CSS will suspend its service for you and reserves the right to seek legal remedies.
        /// </summary>
        /// <param name="req"><see cref="CreateLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="CreateLivePullStreamTaskResponse"/></returns>
        public Task<CreateLivePullStreamTaskResponse> CreateLivePullStreamTask(CreateLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<CreateLivePullStreamTaskResponse>(req, "CreateLivePullStreamTask");
        }

        /// <summary>
        /// This API is used to create a task to pull streams from video files or an external live streaming source and publish them to a specified destination URL.
        /// Notes:
        /// 1. By default, you can have at most 20 stream pulling tasks at a time. You can submit a ticket to raise the limit.
        /// 2. Only H.264 and H.265 are supported for video. If the source video is in a different format, please transcode it first.
        /// 3. Only AAC is supported for audio. If the source audio is in a different format, please transcode it first.
        /// 4. You can enable auto deletion in the console to delete expired tasks automatically.
        /// 5. The pull and relay feature is a paid feature. For its billing details, see [Relay](https://intl.cloud.tencent.com/document/product/267/53308?from_cn_redirect=1).
        /// 6. CSS is only responsible for pulling and relaying content. Please make sure that your content is authorized and complies with relevant laws and regulations. In case of copyright infringement or violation of laws or regulations, CSS will suspend its service for you and reserves the right to seek legal remedies.
        /// </summary>
        /// <param name="req"><see cref="CreateLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="CreateLivePullStreamTaskResponse"/></returns>
        public CreateLivePullStreamTaskResponse CreateLivePullStreamTaskSync(CreateLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<CreateLivePullStreamTaskResponse>(req, "CreateLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// - Prerequisites
        ///   1. Recording files are stored on the VOD platform, so if you need to use the recording feature, you must first activate the VOD service.
        ///   2. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) will be charged according to the VOD billing mode. For more information, please see the [corresponding document](https://intl.cloud.tencent.com/document/product/266/2838?from_cn_redirect=1).
        /// 
        /// - Mode description
        ///   This API supports two recording modes:
        ///   1. Scheduled recording mode **(default mode)**.
        ///     The start time and end time need to be passed in, according to which the recording task will start and end automatically. Before the set end time expires (provided that `StopLiveRecord` is not called to terminate the task prematurely), the recording task is valid and will be started even after the push is interrupted and restarted multiple times.
        ///   2. Real-time video recording mode.
        ///     The start time passed in will be ignored, and recording will be started immediately after the recording task is created. The recording duration can be up to 30 minutes. If the end time passed in is more than 30 minutes after the current time, it will be counted as 30 minutes. Real-time video recording is mainly used for recording highlight scenes, and you are recommended to keep the duration within 5 minutes.
        /// 
        /// - Precautions
        ///   1. The API call timeout period should be set to more than 3 seconds; otherwise, retries and calls by different start/end time values may result in repeated recording tasks and thus incur additional recording fees.
        ///   2. Subject to the audio and video file formats (FLV/MP4/HLS), the video codec of H.264 and audio codec of AAC are supported.
        ///   3. In order to avoid malicious or unintended frequent API requests, the maximum number of tasks that can be created in scheduled recording mode is limited: up to 4,000 tasks can be created per day (excluding deleted ones), and up to 400 ones can run concurrently. If you need a higher upper limit, please submit a ticket for application.
        ///   4. This calling method does not support recording streams outside Mainland China for the time being.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRequest"/></param>
        /// <returns><see cref="CreateLiveRecordResponse"/></returns>
        public Task<CreateLiveRecordResponse> CreateLiveRecord(CreateLiveRecordRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordResponse>(req, "CreateLiveRecord");
        }

        /// <summary>
        /// - Prerequisites
        ///   1. Recording files are stored on the VOD platform, so if you need to use the recording feature, you must first activate the VOD service.
        ///   2. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) will be charged according to the VOD billing mode. For more information, please see the [corresponding document](https://intl.cloud.tencent.com/document/product/266/2838?from_cn_redirect=1).
        /// 
        /// - Mode description
        ///   This API supports two recording modes:
        ///   1. Scheduled recording mode **(default mode)**.
        ///     The start time and end time need to be passed in, according to which the recording task will start and end automatically. Before the set end time expires (provided that `StopLiveRecord` is not called to terminate the task prematurely), the recording task is valid and will be started even after the push is interrupted and restarted multiple times.
        ///   2. Real-time video recording mode.
        ///     The start time passed in will be ignored, and recording will be started immediately after the recording task is created. The recording duration can be up to 30 minutes. If the end time passed in is more than 30 minutes after the current time, it will be counted as 30 minutes. Real-time video recording is mainly used for recording highlight scenes, and you are recommended to keep the duration within 5 minutes.
        /// 
        /// - Precautions
        ///   1. The API call timeout period should be set to more than 3 seconds; otherwise, retries and calls by different start/end time values may result in repeated recording tasks and thus incur additional recording fees.
        ///   2. Subject to the audio and video file formats (FLV/MP4/HLS), the video codec of H.264 and audio codec of AAC are supported.
        ///   3. In order to avoid malicious or unintended frequent API requests, the maximum number of tasks that can be created in scheduled recording mode is limited: up to 4,000 tasks can be created per day (excluding deleted ones), and up to 400 ones can run concurrently. If you need a higher upper limit, please submit a ticket for application.
        ///   4. This calling method does not support recording streams outside Mainland China for the time being.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRequest"/></param>
        /// <returns><see cref="CreateLiveRecordResponse"/></returns>
        public CreateLiveRecordResponse CreateLiveRecordSync(CreateLiveRecordRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordResponse>(req, "CreateLiveRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// To create a recording rule, you need to first call the [CreateLiveRecordTemplate](https://intl.cloud.tencent.com/document/product/267/32614?from_cn_redirect=1) API to create a recording template and bind the returned template ID to the stream.
        /// <br>Recording-related document: [LVB Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns><see cref="CreateLiveRecordRuleResponse"/></returns>
        public Task<CreateLiveRecordRuleResponse> CreateLiveRecordRule(CreateLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordRuleResponse>(req, "CreateLiveRecordRule");
        }

        /// <summary>
        /// To create a recording rule, you need to first call the [CreateLiveRecordTemplate](https://intl.cloud.tencent.com/document/product/267/32614?from_cn_redirect=1) API to create a recording template and bind the returned template ID to the stream.
        /// <br>Recording-related document: [LVB Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns><see cref="CreateLiveRecordRuleResponse"/></returns>
        public CreateLiveRecordRuleResponse CreateLiveRecordRuleSync(CreateLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordRuleResponse>(req, "CreateLiveRecordRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a recording template. You can create up to 50 templates. To use a template, you need to call the [CreateLiveRecordRule](https://intl.cloud.tencent.com/document/product/267/32615?from_cn_redirect=1) API to bind the template ID returned by this API to a stream.
        /// <br>More on recording: [Live Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1)
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate");
        }

        /// <summary>
        /// This API is used to create a recording template. You can create up to 50 templates. To use a template, you need to call the [CreateLiveRecordRule](https://intl.cloud.tencent.com/document/product/267/32615?from_cn_redirect=1) API to bind the template ID returned by this API to a stream.
        /// <br>More on recording: [Live Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1)
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplateSync(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a screencapturing rule. You need to first call the [CreateLiveSnapshotTemplate](https://intl.cloud.tencent.com/document/product/267/32624?from_cn_redirect=1) API to create a screencapturing template to bind the returned template ID to the stream.
        /// <br>Screencapturing document: [LVB Screencapturing](https://intl.cloud.tencent.com/document/product/267/32737?from_cn_redirect=1).
        /// Note: only one screencapturing template can be associated with one domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotRuleResponse"/></returns>
        public Task<CreateLiveSnapshotRuleResponse> CreateLiveSnapshotRule(CreateLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotRuleResponse>(req, "CreateLiveSnapshotRule");
        }

        /// <summary>
        /// This API is used to create a screencapturing rule. You need to first call the [CreateLiveSnapshotTemplate](https://intl.cloud.tencent.com/document/product/267/32624?from_cn_redirect=1) API to create a screencapturing template to bind the returned template ID to the stream.
        /// <br>Screencapturing document: [LVB Screencapturing](https://intl.cloud.tencent.com/document/product/267/32737?from_cn_redirect=1).
        /// Note: only one screencapturing template can be associated with one domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotRuleResponse"/></returns>
        public CreateLiveSnapshotRuleResponse CreateLiveSnapshotRuleSync(CreateLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotRuleResponse>(req, "CreateLiveSnapshotRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a screencapture template. After a template ID is returned, you need to call the [CreateLiveSnapshotRule](https://intl.cloud.tencent.com/document/product/267/32625?from_cn_redirect=1) API to bind the template ID to a stream. You can create up to 50 screencapture templates.
        /// <br>To learn more about the live screencapture feature, see [Live Screencapture](https://intl.cloud.tencent.com/document/product/267/32737?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotTemplateResponse"/></returns>
        public Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplate(CreateLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotTemplateResponse>(req, "CreateLiveSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to create a screencapture template. After a template ID is returned, you need to call the [CreateLiveSnapshotRule](https://intl.cloud.tencent.com/document/product/267/32625?from_cn_redirect=1) API to bind the template ID to a stream. You can create up to 50 screencapture templates.
        /// <br>To learn more about the live screencapture feature, see [Live Screencapture](https://intl.cloud.tencent.com/document/product/267/32737?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotTemplateResponse"/></returns>
        public CreateLiveSnapshotTemplateResponse CreateLiveSnapshotTemplateSync(CreateLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotTemplateResponse>(req, "CreateLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a time shifting rule. You need to first call the [CreateLiveTranscodeTemplate](https://intl.cloud.tencent.com/document/product/267/86169?from_cn_redirect=1) API to create a time shifting template, and then call this API to bind the template ID returned to a stream.
        /// <br>More about time shifting: [Time Shifting](https://intl.cloud.tencent.com/document/product/267/86134?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftRuleResponse"/></returns>
        public Task<CreateLiveTimeShiftRuleResponse> CreateLiveTimeShiftRule(CreateLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftRuleResponse>(req, "CreateLiveTimeShiftRule");
        }

        /// <summary>
        /// This API is used to create a time shifting rule. You need to first call the [CreateLiveTranscodeTemplate](https://intl.cloud.tencent.com/document/product/267/86169?from_cn_redirect=1) API to create a time shifting template, and then call this API to bind the template ID returned to a stream.
        /// <br>More about time shifting: [Time Shifting](https://intl.cloud.tencent.com/document/product/267/86134?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftRuleResponse"/></returns>
        public CreateLiveTimeShiftRuleResponse CreateLiveTimeShiftRuleSync(CreateLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftRuleResponse>(req, "CreateLiveTimeShiftRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a time shifting template.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftTemplateResponse"/></returns>
        public Task<CreateLiveTimeShiftTemplateResponse> CreateLiveTimeShiftTemplate(CreateLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftTemplateResponse>(req, "CreateLiveTimeShiftTemplate");
        }

        /// <summary>
        /// This API is used to create a time shifting template.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftTemplateResponse"/></returns>
        public CreateLiveTimeShiftTemplateResponse CreateLiveTimeShiftTemplateSync(CreateLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftTemplateResponse>(req, "CreateLiveTimeShiftTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a transcoding rule that binds a template ID to a stream. Up to 50 transcoding rules can be created in total. Before you call this API, you need to first call [CreateLiveTranscodeTemplate](https://intl.cloud.tencent.com/document/product/267/32646?from_cn_redirect=1) to get the template ID.
        /// <br>Related document: [Live Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeRuleResponse"/></returns>
        public Task<CreateLiveTranscodeRuleResponse> CreateLiveTranscodeRule(CreateLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeRuleResponse>(req, "CreateLiveTranscodeRule");
        }

        /// <summary>
        /// This API is used to create a transcoding rule that binds a template ID to a stream. Up to 50 transcoding rules can be created in total. Before you call this API, you need to first call [CreateLiveTranscodeTemplate](https://intl.cloud.tencent.com/document/product/267/32646?from_cn_redirect=1) to get the template ID.
        /// <br>Related document: [Live Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeRuleResponse"/></returns>
        public CreateLiveTranscodeRuleResponse CreateLiveTranscodeRuleSync(CreateLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeRuleResponse>(req, "CreateLiveTranscodeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a transcoding template. Up to 50 transcoding templates can be created in total. To use a template, you need to call [CreateLiveTranscodeRule](https://intl.cloud.tencent.com/document/product/267/32647?from_cn_redirect=1) to bind the template ID returned by this API to a stream.
        /// <br>For more information about transcoding, see [Live Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeTemplateResponse"/></returns>
        public Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplate(CreateLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeTemplateResponse>(req, "CreateLiveTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to create a transcoding template. Up to 50 transcoding templates can be created in total. To use a template, you need to call [CreateLiveTranscodeRule](https://intl.cloud.tencent.com/document/product/267/32647?from_cn_redirect=1) to bind the template ID returned by this API to a stream.
        /// <br>For more information about transcoding, see [Live Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeTemplateResponse"/></returns>
        public CreateLiveTranscodeTemplateResponse CreateLiveTranscodeTemplateSync(CreateLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeTemplateResponse>(req, "CreateLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// To create a watermarking rule, you need to first call the [AddLiveWatermark](https://intl.cloud.tencent.com/document/product/267/30154?from_cn_redirect=1) API to add a watermark and bind the returned watermark ID to the stream.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="CreateLiveWatermarkRuleResponse"/></returns>
        public Task<CreateLiveWatermarkRuleResponse> CreateLiveWatermarkRule(CreateLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveWatermarkRuleResponse>(req, "CreateLiveWatermarkRule");
        }

        /// <summary>
        /// To create a watermarking rule, you need to first call the [AddLiveWatermark](https://intl.cloud.tencent.com/document/product/267/30154?from_cn_redirect=1) API to add a watermark and bind the returned watermark ID to the stream.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="CreateLiveWatermarkRuleResponse"/></returns>
        public CreateLiveWatermarkRuleResponse CreateLiveWatermarkRuleSync(CreateLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveWatermarkRuleResponse>(req, "CreateLiveWatermarkRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a recording task that starts and ends at specific times and records videos according to a specific recording template.
        /// - Prerequisites
        /// 1. Because recording files are saved in VOD, you must first activate VOD.
        /// 2. Storage and playback traffic fees are charged for storing and playing the videos recorded. For details, see [Purchase Guide](https://intl.cloud.tencent.com/document/product/266/2837).
        /// - Notes
        /// 1. If streaming is interrupted, the current recording will stop and a recording file will be generated. When streaming resumes, as long as it’s before the end time of the task, recording will start again.
        /// 2. Avoid creating recording tasks with overlapping time periods. If there are multiple tasks with overlapping time periods for the same stream, the system will start three recording tasks at most to avoid repeated recording.
        /// 3. Task records are kept for three months by the platform.
        /// 4. Do not use the new [CreateRecordTask](https://intl.cloud.tencent.com/document/product/267/45983?from_cn_redirect=1), [StopRecordTask](https://intl.cloud.tencent.com/document/product/267/45981?from_cn_redirect=1), and [DeleteRecordTask] APIs together with the old `CreateLiveRecord`, `StopLiveRecord`, and `DeleteLiveRecord` APIs.
        /// 5. Do not create recording tasks and push streams at the same time. After creating a recording task, we recommend you wait at least three seconds before pushing streams.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordTaskRequest"/></param>
        /// <returns><see cref="CreateRecordTaskResponse"/></returns>
        public Task<CreateRecordTaskResponse> CreateRecordTask(CreateRecordTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordTaskResponse>(req, "CreateRecordTask");
        }

        /// <summary>
        /// This API is used to create a recording task that starts and ends at specific times and records videos according to a specific recording template.
        /// - Prerequisites
        /// 1. Because recording files are saved in VOD, you must first activate VOD.
        /// 2. Storage and playback traffic fees are charged for storing and playing the videos recorded. For details, see [Purchase Guide](https://intl.cloud.tencent.com/document/product/266/2837).
        /// - Notes
        /// 1. If streaming is interrupted, the current recording will stop and a recording file will be generated. When streaming resumes, as long as it’s before the end time of the task, recording will start again.
        /// 2. Avoid creating recording tasks with overlapping time periods. If there are multiple tasks with overlapping time periods for the same stream, the system will start three recording tasks at most to avoid repeated recording.
        /// 3. Task records are kept for three months by the platform.
        /// 4. Do not use the new [CreateRecordTask](https://intl.cloud.tencent.com/document/product/267/45983?from_cn_redirect=1), [StopRecordTask](https://intl.cloud.tencent.com/document/product/267/45981?from_cn_redirect=1), and [DeleteRecordTask] APIs together with the old `CreateLiveRecord`, `StopLiveRecord`, and `DeleteLiveRecord` APIs.
        /// 5. Do not create recording tasks and push streams at the same time. After creating a recording task, we recommend you wait at least three seconds before pushing streams.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordTaskRequest"/></param>
        /// <returns><see cref="CreateRecordTaskResponse"/></returns>
        public CreateRecordTaskResponse CreateRecordTaskSync(CreateRecordTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordTaskResponse>(req, "CreateRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a screencapturing task that has a specific start and end time and takes screenshots according to the template configured.
        /// - Note
        /// 1. If the stream is interrupted, screencapturing will stop. However, the task will still be valid before the specified end time, and screencapturing will be performed as required after the stream is resumed.
        /// 2. Avoid creating screencapturing tasks with overlapping time periods. The system will execute at most three screencapturing tasks on the same stream at a time.
        /// 3. Task records are only kept for three months.
        /// 4. The new screencapturing APIs (CreateScreenshotTask/StopScreenshotTask/DeleteScreenshotTask) are not compatible with the legacy ones (CreateLiveInstantSnapshot/StopLiveInstantSnapshot). Do not mix them when you call APIs to manage screencapturing tasks.
        /// 5. If you create a screencapturing task and publish the stream at the same time, the task may fail to be executed at the specified time. After creating a screencapturing task, we recommend you wait at least three seconds before publishing the stream.
        /// </summary>
        /// <param name="req"><see cref="CreateScreenshotTaskRequest"/></param>
        /// <returns><see cref="CreateScreenshotTaskResponse"/></returns>
        public Task<CreateScreenshotTaskResponse> CreateScreenshotTask(CreateScreenshotTaskRequest req)
        {
            return InternalRequestAsync<CreateScreenshotTaskResponse>(req, "CreateScreenshotTask");
        }

        /// <summary>
        /// This API is used to create a screencapturing task that has a specific start and end time and takes screenshots according to the template configured.
        /// - Note
        /// 1. If the stream is interrupted, screencapturing will stop. However, the task will still be valid before the specified end time, and screencapturing will be performed as required after the stream is resumed.
        /// 2. Avoid creating screencapturing tasks with overlapping time periods. The system will execute at most three screencapturing tasks on the same stream at a time.
        /// 3. Task records are only kept for three months.
        /// 4. The new screencapturing APIs (CreateScreenshotTask/StopScreenshotTask/DeleteScreenshotTask) are not compatible with the legacy ones (CreateLiveInstantSnapshot/StopLiveInstantSnapshot). Do not mix them when you call APIs to manage screencapturing tasks.
        /// 5. If you create a screencapturing task and publish the stream at the same time, the task may fail to be executed at the specified time. After creating a screencapturing task, we recommend you wait at least three seconds before publishing the stream.
        /// </summary>
        /// <param name="req"><see cref="CreateScreenshotTaskRequest"/></param>
        /// <returns><see cref="CreateScreenshotTaskResponse"/></returns>
        public CreateScreenshotTaskResponse CreateScreenshotTaskSync(CreateScreenshotTaskRequest req)
        {
            return InternalRequestAsync<CreateScreenshotTaskResponse>(req, "CreateScreenshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a callback rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackRuleResponse"/></returns>
        public Task<DeleteLiveCallbackRuleResponse> DeleteLiveCallbackRule(DeleteLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackRuleResponse>(req, "DeleteLiveCallbackRule");
        }

        /// <summary>
        /// This API is used to delete a callback rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackRuleResponse"/></returns>
        public DeleteLiveCallbackRuleResponse DeleteLiveCallbackRuleSync(DeleteLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackRuleResponse>(req, "DeleteLiveCallbackRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API deletes a callback template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackTemplateResponse"/></returns>
        public Task<DeleteLiveCallbackTemplateResponse> DeleteLiveCallbackTemplate(DeleteLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackTemplateResponse>(req, "DeleteLiveCallbackTemplate");
        }

        /// <summary>
        /// This API deletes a callback template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackTemplateResponse"/></returns>
        public DeleteLiveCallbackTemplateResponse DeleteLiveCallbackTemplateSync(DeleteLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackTemplateResponse>(req, "DeleteLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an added LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveDomainRequest"/></param>
        /// <returns><see cref="DeleteLiveDomainResponse"/></returns>
        public Task<DeleteLiveDomainResponse> DeleteLiveDomain(DeleteLiveDomainRequest req)
        {
            return InternalRequestAsync<DeleteLiveDomainResponse>(req, "DeleteLiveDomain");
        }

        /// <summary>
        /// This API is used to delete an added LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveDomainRequest"/></param>
        /// <returns><see cref="DeleteLiveDomainResponse"/></returns>
        public DeleteLiveDomainResponse DeleteLiveDomainSync(DeleteLiveDomainRequest req)
        {
            return InternalRequestAsync<DeleteLiveDomainResponse>(req, "DeleteLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a task created by `CreateLivePullStreamTask`.
        /// Notes:
        /// 1. For the `TaskId` request parameter, pass in the task ID returned by the `CreateLivePullStreamTask` API.
        /// 2. You can query the ID of a task using the `DescribeLivePullStreamTasks` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="DeleteLivePullStreamTaskResponse"/></returns>
        public Task<DeleteLivePullStreamTaskResponse> DeleteLivePullStreamTask(DeleteLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<DeleteLivePullStreamTaskResponse>(req, "DeleteLivePullStreamTask");
        }

        /// <summary>
        /// This API is used to delete a task created by `CreateLivePullStreamTask`.
        /// Notes:
        /// 1. For the `TaskId` request parameter, pass in the task ID returned by the `CreateLivePullStreamTask` API.
        /// 2. You can query the ID of a task using the `DescribeLivePullStreamTasks` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="DeleteLivePullStreamTaskResponse"/></returns>
        public DeleteLivePullStreamTaskResponse DeleteLivePullStreamTaskSync(DeleteLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<DeleteLivePullStreamTaskResponse>(req, "DeleteLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Note: The `DeleteLiveRecord` API is only used to delete the record of recording tasks but not stop recording or deleting an ongoing recording task. If you need to stop a recording task, please use the [StopLiveRecord](https://intl.cloud.tencent.com/document/product/267/30146?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordResponse"/></returns>
        public Task<DeleteLiveRecordResponse> DeleteLiveRecord(DeleteLiveRecordRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordResponse>(req, "DeleteLiveRecord");
        }

        /// <summary>
        /// Note: The `DeleteLiveRecord` API is only used to delete the record of recording tasks but not stop recording or deleting an ongoing recording task. If you need to stop a recording task, please use the [StopLiveRecord](https://intl.cloud.tencent.com/document/product/267/30146?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordResponse"/></returns>
        public DeleteLiveRecordResponse DeleteLiveRecordSync(DeleteLiveRecordRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordResponse>(req, "DeleteLiveRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a recording rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordRuleResponse"/></returns>
        public Task<DeleteLiveRecordRuleResponse> DeleteLiveRecordRule(DeleteLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordRuleResponse>(req, "DeleteLiveRecordRule");
        }

        /// <summary>
        /// This API is used to delete a recording rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordRuleResponse"/></returns>
        public DeleteLiveRecordRuleResponse DeleteLiveRecordRuleSync(DeleteLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordRuleResponse>(req, "DeleteLiveRecordRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a recording template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate");
        }

        /// <summary>
        /// This API is used to delete a recording template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplateSync(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a screencapturing rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotRuleResponse"/></returns>
        public Task<DeleteLiveSnapshotRuleResponse> DeleteLiveSnapshotRule(DeleteLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotRuleResponse>(req, "DeleteLiveSnapshotRule");
        }

        /// <summary>
        /// This API is used to delete a screencapturing rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotRuleResponse"/></returns>
        public DeleteLiveSnapshotRuleResponse DeleteLiveSnapshotRuleSync(DeleteLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotRuleResponse>(req, "DeleteLiveSnapshotRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotTemplateResponse"/></returns>
        public Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplate(DeleteLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotTemplateResponse>(req, "DeleteLiveSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to delete a screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotTemplateResponse"/></returns>
        public DeleteLiveSnapshotTemplateResponse DeleteLiveSnapshotTemplateSync(DeleteLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotTemplateResponse>(req, "DeleteLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a time shifting rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftRuleResponse"/></returns>
        public Task<DeleteLiveTimeShiftRuleResponse> DeleteLiveTimeShiftRule(DeleteLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftRuleResponse>(req, "DeleteLiveTimeShiftRule");
        }

        /// <summary>
        /// This API is used to delete a time shifting rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftRuleResponse"/></returns>
        public DeleteLiveTimeShiftRuleResponse DeleteLiveTimeShiftRuleSync(DeleteLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftRuleResponse>(req, "DeleteLiveTimeShiftRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a time shifting template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftTemplateResponse"/></returns>
        public Task<DeleteLiveTimeShiftTemplateResponse> DeleteLiveTimeShiftTemplate(DeleteLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftTemplateResponse>(req, "DeleteLiveTimeShiftTemplate");
        }

        /// <summary>
        /// This API is used to delete a time shifting template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftTemplateResponse"/></returns>
        public DeleteLiveTimeShiftTemplateResponse DeleteLiveTimeShiftTemplateSync(DeleteLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftTemplateResponse>(req, "DeleteLiveTimeShiftTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a transcoding rule.
        /// `DomainName+AppName+StreamName+TemplateId` uniquely identifies a single transcoding rule. If you need to delete it, strong match is required. `TemplateId` is required. Even if other parameters are empty, you still need to pass in an empty string to make a strong match.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeRuleResponse"/></returns>
        public Task<DeleteLiveTranscodeRuleResponse> DeleteLiveTranscodeRule(DeleteLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeRuleResponse>(req, "DeleteLiveTranscodeRule");
        }

        /// <summary>
        /// This API is used to delete a transcoding rule.
        /// `DomainName+AppName+StreamName+TemplateId` uniquely identifies a single transcoding rule. If you need to delete it, strong match is required. `TemplateId` is required. Even if other parameters are empty, you still need to pass in an empty string to make a strong match.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeRuleResponse"/></returns>
        public DeleteLiveTranscodeRuleResponse DeleteLiveTranscodeRuleSync(DeleteLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeRuleResponse>(req, "DeleteLiveTranscodeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeTemplateResponse"/></returns>
        public Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplate(DeleteLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeTemplateResponse>(req, "DeleteLiveTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to delete a transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeTemplateResponse"/></returns>
        public DeleteLiveTranscodeTemplateResponse DeleteLiveTranscodeTemplateSync(DeleteLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeTemplateResponse>(req, "DeleteLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkResponse"/></returns>
        public Task<DeleteLiveWatermarkResponse> DeleteLiveWatermark(DeleteLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkResponse>(req, "DeleteLiveWatermark");
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkResponse"/></returns>
        public DeleteLiveWatermarkResponse DeleteLiveWatermarkSync(DeleteLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkResponse>(req, "DeleteLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a watermarking rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkRuleResponse"/></returns>
        public Task<DeleteLiveWatermarkRuleResponse> DeleteLiveWatermarkRule(DeleteLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkRuleResponse>(req, "DeleteLiveWatermarkRule");
        }

        /// <summary>
        /// This API is used to delete a watermarking rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkRuleResponse"/></returns>
        public DeleteLiveWatermarkRuleResponse DeleteLiveWatermarkRuleSync(DeleteLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkRuleResponse>(req, "DeleteLiveWatermarkRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a recording task configuration. The deletion does not affect running tasks and takes effect only for new pushes.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordTaskResponse"/></returns>
        public Task<DeleteRecordTaskResponse> DeleteRecordTask(DeleteRecordTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordTaskResponse>(req, "DeleteRecordTask");
        }

        /// <summary>
        /// This API is used to delete a recording task configuration. The deletion does not affect running tasks and takes effect only for new pushes.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordTaskResponse"/></returns>
        public DeleteRecordTaskResponse DeleteRecordTaskSync(DeleteRecordTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordTaskResponse>(req, "DeleteRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the playback data of all streams at a specified time point (accurate to the minute).
        /// </summary>
        /// <param name="req"><see cref="DescribeAllStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeAllStreamPlayInfoListResponse"/></returns>
        public Task<DescribeAllStreamPlayInfoListResponse> DescribeAllStreamPlayInfoList(DescribeAllStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAllStreamPlayInfoListResponse>(req, "DescribeAllStreamPlayInfoList");
        }

        /// <summary>
        /// This API is used to get the playback data of all streams at a specified time point (accurate to the minute).
        /// </summary>
        /// <param name="req"><see cref="DescribeAllStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeAllStreamPlayInfoListResponse"/></returns>
        public DescribeAllStreamPlayInfoListResponse DescribeAllStreamPlayInfoListSync(DescribeAllStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAllStreamPlayInfoListResponse>(req, "DescribeAllStreamPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the data of billable bandwidth and traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeBillBandwidthAndFluxListResponse"/></returns>
        public Task<DescribeBillBandwidthAndFluxListResponse> DescribeBillBandwidthAndFluxList(DescribeBillBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribeBillBandwidthAndFluxListResponse>(req, "DescribeBillBandwidthAndFluxList");
        }

        /// <summary>
        /// This API is used to query the data of billable bandwidth and traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeBillBandwidthAndFluxListResponse"/></returns>
        public DescribeBillBandwidthAndFluxListResponse DescribeBillBandwidthAndFluxListSync(DescribeBillBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribeBillBandwidthAndFluxListResponse>(req, "DescribeBillBandwidthAndFluxList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of concurrent recording channels, which is applicable to LCB and LVB.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentRecordStreamNumRequest"/></param>
        /// <returns><see cref="DescribeConcurrentRecordStreamNumResponse"/></returns>
        public Task<DescribeConcurrentRecordStreamNumResponse> DescribeConcurrentRecordStreamNum(DescribeConcurrentRecordStreamNumRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentRecordStreamNumResponse>(req, "DescribeConcurrentRecordStreamNum");
        }

        /// <summary>
        /// This API is used to query the number of concurrent recording channels, which is applicable to LCB and LVB.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentRecordStreamNumRequest"/></param>
        /// <returns><see cref="DescribeConcurrentRecordStreamNumResponse"/></returns>
        public DescribeConcurrentRecordStreamNumResponse DescribeConcurrentRecordStreamNumSync(DescribeConcurrentRecordStreamNumRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentRecordStreamNumResponse>(req, "DescribeConcurrentRecordStreamNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the billable bandwidth of live stream relaying in the last 3 months. The query period is up to 31 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverBandwidthListRequest"/></param>
        /// <returns><see cref="DescribeDeliverBandwidthListResponse"/></returns>
        public Task<DescribeDeliverBandwidthListResponse> DescribeDeliverBandwidthList(DescribeDeliverBandwidthListRequest req)
        {
            return InternalRequestAsync<DescribeDeliverBandwidthListResponse>(req, "DescribeDeliverBandwidthList");
        }

        /// <summary>
        /// This API is used to query the billable bandwidth of live stream relaying in the last 3 months. The query period is up to 31 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverBandwidthListRequest"/></param>
        /// <returns><see cref="DescribeDeliverBandwidthListResponse"/></returns>
        public DescribeDeliverBandwidthListResponse DescribeDeliverBandwidthListSync(DescribeDeliverBandwidthListRequest req)
        {
            return InternalRequestAsync<DescribeDeliverBandwidthListResponse>(req, "DescribeDeliverBandwidthList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the downstream playback data by district and ISP.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeGroupProIspPlayInfoListResponse"/></returns>
        public Task<DescribeGroupProIspPlayInfoListResponse> DescribeGroupProIspPlayInfoList(DescribeGroupProIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeGroupProIspPlayInfoListResponse>(req, "DescribeGroupProIspPlayInfoList");
        }

        /// <summary>
        /// This API is used to query the downstream playback data by district and ISP.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeGroupProIspPlayInfoListResponse"/></returns>
        public DescribeGroupProIspPlayInfoListResponse DescribeGroupProIspPlayInfoListSync(DescribeGroupProIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeGroupProIspPlayInfoListResponse>(req, "DescribeGroupProIspPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of each playback HTTP status code at a 5-minute granularity in a certain period of time.
        /// Note: data can be queried one hour after it is generated. For example, data between 10:00 and 10:59 cannot be queried until 12:00.
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns><see cref="DescribeHttpStatusInfoListResponse"/></returns>
        public Task<DescribeHttpStatusInfoListResponse> DescribeHttpStatusInfoList(DescribeHttpStatusInfoListRequest req)
        {
            return InternalRequestAsync<DescribeHttpStatusInfoListResponse>(req, "DescribeHttpStatusInfoList");
        }

        /// <summary>
        /// This API is used to query the number of each playback HTTP status code at a 5-minute granularity in a certain period of time.
        /// Note: data can be queried one hour after it is generated. For example, data between 10:00 and 10:59 cannot be queried until 12:00.
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns><see cref="DescribeHttpStatusInfoListResponse"/></returns>
        public DescribeHttpStatusInfoListResponse DescribeHttpStatusInfoListSync(DescribeHttpStatusInfoListRequest req)
        {
            return InternalRequestAsync<DescribeHttpStatusInfoListResponse>(req, "DescribeHttpStatusInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the callback rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackRulesResponse"/></returns>
        public Task<DescribeLiveCallbackRulesResponse> DescribeLiveCallbackRules(DescribeLiveCallbackRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackRulesResponse>(req, "DescribeLiveCallbackRules");
        }

        /// <summary>
        /// This API is used to get the callback rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackRulesResponse"/></returns>
        public DescribeLiveCallbackRulesResponse DescribeLiveCallbackRulesSync(DescribeLiveCallbackRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackRulesResponse>(req, "DescribeLiveCallbackRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a single callback template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplateResponse"/></returns>
        public Task<DescribeLiveCallbackTemplateResponse> DescribeLiveCallbackTemplate(DescribeLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplateResponse>(req, "DescribeLiveCallbackTemplate");
        }

        /// <summary>
        /// This API is used to get a single callback template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplateResponse"/></returns>
        public DescribeLiveCallbackTemplateResponse DescribeLiveCallbackTemplateSync(DescribeLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplateResponse>(req, "DescribeLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the callback template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplatesResponse"/></returns>
        public Task<DescribeLiveCallbackTemplatesResponse> DescribeLiveCallbackTemplates(DescribeLiveCallbackTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplatesResponse>(req, "DescribeLiveCallbackTemplates");
        }

        /// <summary>
        /// This API is used to get the callback template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplatesResponse"/></returns>
        public DescribeLiveCallbackTemplatesResponse DescribeLiveCallbackTemplatesSync(DescribeLiveCallbackTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplatesResponse>(req, "DescribeLiveCallbackTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertRequest"/></param>
        /// <returns><see cref="DescribeLiveCertResponse"/></returns>
        public Task<DescribeLiveCertResponse> DescribeLiveCert(DescribeLiveCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertResponse>(req, "DescribeLiveCert");
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertRequest"/></param>
        /// <returns><see cref="DescribeLiveCertResponse"/></returns>
        public DescribeLiveCertResponse DescribeLiveCertSync(DescribeLiveCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertResponse>(req, "DescribeLiveCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the certificate information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertsRequest"/></param>
        /// <returns><see cref="DescribeLiveCertsResponse"/></returns>
        public Task<DescribeLiveCertsResponse> DescribeLiveCerts(DescribeLiveCertsRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertsResponse>(req, "DescribeLiveCerts");
        }

        /// <summary>
        /// This API is used to get the certificate information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertsRequest"/></param>
        /// <returns><see cref="DescribeLiveCertsResponse"/></returns>
        public DescribeLiveCertsResponse DescribeLiveCertsSync(DescribeLiveCertsRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertsResponse>(req, "DescribeLiveCerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of delayed playbacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDelayInfoListResponse"/></returns>
        public Task<DescribeLiveDelayInfoListResponse> DescribeLiveDelayInfoList(DescribeLiveDelayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveDelayInfoListResponse>(req, "DescribeLiveDelayInfoList");
        }

        /// <summary>
        /// This API is used to get the list of delayed playbacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDelayInfoListResponse"/></returns>
        public DescribeLiveDelayInfoListResponse DescribeLiveDelayInfoListSync(DescribeLiveDelayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveDelayInfoListResponse>(req, "DescribeLiveDelayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the LVB domain name information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainResponse"/></returns>
        public Task<DescribeLiveDomainResponse> DescribeLiveDomain(DescribeLiveDomainRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainResponse>(req, "DescribeLiveDomain");
        }

        /// <summary>
        /// This API is used to query the LVB domain name information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainResponse"/></returns>
        public DescribeLiveDomainResponse DescribeLiveDomainSync(DescribeLiveDomainRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainResponse>(req, "DescribeLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the domain name certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertResponse"/></returns>
        public Task<DescribeLiveDomainCertResponse> DescribeLiveDomainCert(DescribeLiveDomainCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertResponse>(req, "DescribeLiveDomainCert");
        }

        /// <summary>
        /// This API is used to get the domain name certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertResponse"/></returns>
        public DescribeLiveDomainCertResponse DescribeLiveDomainCertSync(DescribeLiveDomainCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertResponse>(req, "DescribeLiveDomainCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query domains bound with certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertBindingsResponse"/></returns>
        public Task<DescribeLiveDomainCertBindingsResponse> DescribeLiveDomainCertBindings(DescribeLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertBindingsResponse>(req, "DescribeLiveDomainCertBindings");
        }

        /// <summary>
        /// This API is used to query domains bound with certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertBindingsResponse"/></returns>
        public DescribeLiveDomainCertBindingsResponse DescribeLiveDomainCertBindingsSync(DescribeLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertBindingsResponse>(req, "DescribeLiveDomainCertBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query referer allowlist/blocklist configuration of a live streaming domain name.
        /// Referer information is included in HTTP requests. After you enable referer configuration, live streams using RTMP or WebRTC for playback will not authenticate the referer and can be played back normally. To make the referer configuration effective, the HTTP-FLV or HLS protocol is recommended for playback.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRefererRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainRefererResponse"/></returns>
        public Task<DescribeLiveDomainRefererResponse> DescribeLiveDomainReferer(DescribeLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainRefererResponse>(req, "DescribeLiveDomainReferer");
        }

        /// <summary>
        /// This API is used to query referer allowlist/blocklist configuration of a live streaming domain name.
        /// Referer information is included in HTTP requests. After you enable referer configuration, live streams using RTMP or WebRTC for playback will not authenticate the referer and can be played back normally. To make the referer configuration effective, the HTTP-FLV or HLS protocol is recommended for playback.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRefererRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainRefererResponse"/></returns>
        public DescribeLiveDomainRefererResponse DescribeLiveDomainRefererSync(DescribeLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainRefererResponse>(req, "DescribeLiveDomainReferer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query domain names by domain name status and type.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainsResponse"/></returns>
        public Task<DescribeLiveDomainsResponse> DescribeLiveDomains(DescribeLiveDomainsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainsResponse>(req, "DescribeLiveDomains");
        }

        /// <summary>
        /// This API is used to query domain names by domain name status and type.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainsResponse"/></returns>
        public DescribeLiveDomainsResponse DescribeLiveDomainsSync(DescribeLiveDomainsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainsResponse>(req, "DescribeLiveDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of disabled streams.
        /// 
        /// Note: this API is used for query only and should not be relied too much upon in important business scenarios.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns><see cref="DescribeLiveForbidStreamListResponse"/></returns>
        public Task<DescribeLiveForbidStreamListResponse> DescribeLiveForbidStreamList(DescribeLiveForbidStreamListRequest req)
        {
            return InternalRequestAsync<DescribeLiveForbidStreamListResponse>(req, "DescribeLiveForbidStreamList");
        }

        /// <summary>
        /// This API is used to get the list of disabled streams.
        /// 
        /// Note: this API is used for query only and should not be relied too much upon in important business scenarios.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns><see cref="DescribeLiveForbidStreamListResponse"/></returns>
        public DescribeLiveForbidStreamListResponse DescribeLiveForbidStreamListSync(DescribeLiveForbidStreamListRequest req)
        {
            return InternalRequestAsync<DescribeLiveForbidStreamListResponse>(req, "DescribeLiveForbidStreamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePlayAuthKeyResponse"/></returns>
        public Task<DescribeLivePlayAuthKeyResponse> DescribeLivePlayAuthKey(DescribeLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePlayAuthKeyResponse>(req, "DescribeLivePlayAuthKey");
        }

        /// <summary>
        /// This API is used to query the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePlayAuthKeyResponse"/></returns>
        public DescribeLivePlayAuthKeyResponse DescribeLivePlayAuthKeySync(DescribeLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePlayAuthKeyResponse>(req, "DescribeLivePlayAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the stream pulling tasks created by `CreateLivePullStreamTask`.
        /// The tasks returned are sorted by last updated time in descending order.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePullStreamTasksRequest"/></param>
        /// <returns><see cref="DescribeLivePullStreamTasksResponse"/></returns>
        public Task<DescribeLivePullStreamTasksResponse> DescribeLivePullStreamTasks(DescribeLivePullStreamTasksRequest req)
        {
            return InternalRequestAsync<DescribeLivePullStreamTasksResponse>(req, "DescribeLivePullStreamTasks");
        }

        /// <summary>
        /// This API is used to query the stream pulling tasks created by `CreateLivePullStreamTask`.
        /// The tasks returned are sorted by last updated time in descending order.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePullStreamTasksRequest"/></param>
        /// <returns><see cref="DescribeLivePullStreamTasksResponse"/></returns>
        public DescribeLivePullStreamTasksResponse DescribeLivePullStreamTasksSync(DescribeLivePullStreamTasksRequest req)
        {
            return InternalRequestAsync<DescribeLivePullStreamTasksResponse>(req, "DescribeLivePullStreamTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePushAuthKeyResponse"/></returns>
        public Task<DescribeLivePushAuthKeyResponse> DescribeLivePushAuthKey(DescribeLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePushAuthKeyResponse>(req, "DescribeLivePushAuthKey");
        }

        /// <summary>
        /// This API is used to query the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePushAuthKeyResponse"/></returns>
        public DescribeLivePushAuthKeyResponse DescribeLivePushAuthKeySync(DescribeLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePushAuthKeyResponse>(req, "DescribeLivePushAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordRulesResponse"/></returns>
        public Task<DescribeLiveRecordRulesResponse> DescribeLiveRecordRules(DescribeLiveRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordRulesResponse>(req, "DescribeLiveRecordRules");
        }

        /// <summary>
        /// This API is used to get the list of recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordRulesResponse"/></returns>
        public DescribeLiveRecordRulesResponse DescribeLiveRecordRulesSync(DescribeLiveRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordRulesResponse>(req, "DescribeLiveRecordRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a single recording template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplateResponse"/></returns>
        public Task<DescribeLiveRecordTemplateResponse> DescribeLiveRecordTemplate(DescribeLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplateResponse>(req, "DescribeLiveRecordTemplate");
        }

        /// <summary>
        /// This API is used to get a single recording template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplateResponse"/></returns>
        public DescribeLiveRecordTemplateResponse DescribeLiveRecordTemplateSync(DescribeLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplateResponse>(req, "DescribeLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the recording template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public Task<DescribeLiveRecordTemplatesResponse> DescribeLiveRecordTemplates(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates");
        }

        /// <summary>
        /// This API is used to get the recording template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public DescribeLiveRecordTemplatesResponse DescribeLiveRecordTemplatesSync(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the screencapturing rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotRulesResponse"/></returns>
        public Task<DescribeLiveSnapshotRulesResponse> DescribeLiveSnapshotRules(DescribeLiveSnapshotRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotRulesResponse>(req, "DescribeLiveSnapshotRules");
        }

        /// <summary>
        /// This API is used to get the screencapturing rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotRulesResponse"/></returns>
        public DescribeLiveSnapshotRulesResponse DescribeLiveSnapshotRulesSync(DescribeLiveSnapshotRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotRulesResponse>(req, "DescribeLiveSnapshotRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a single screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplateResponse"/></returns>
        public Task<DescribeLiveSnapshotTemplateResponse> DescribeLiveSnapshotTemplate(DescribeLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplateResponse>(req, "DescribeLiveSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to get a single screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplateResponse"/></returns>
        public DescribeLiveSnapshotTemplateResponse DescribeLiveSnapshotTemplateSync(DescribeLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplateResponse>(req, "DescribeLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the screencapturing template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplatesResponse"/></returns>
        public Task<DescribeLiveSnapshotTemplatesResponse> DescribeLiveSnapshotTemplates(DescribeLiveSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplatesResponse>(req, "DescribeLiveSnapshotTemplates");
        }

        /// <summary>
        /// This API is used to get the screencapturing template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplatesResponse"/></returns>
        public DescribeLiveSnapshotTemplatesResponse DescribeLiveSnapshotTemplatesSync(DescribeLiveSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplatesResponse>(req, "DescribeLiveSnapshotTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query stream push/interruption events.<br>
        /// 
        /// Notes:
        /// 1. This API is used to query stream push/interruption records, and should not be relied too much upon in important business scenarios.
        /// 2. You can use the `IsFilter` parameter of this API to filter and get required push records.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamEventListResponse"/></returns>
        public Task<DescribeLiveStreamEventListResponse> DescribeLiveStreamEventList(DescribeLiveStreamEventListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamEventListResponse>(req, "DescribeLiveStreamEventList");
        }

        /// <summary>
        /// This API is used to query stream push/interruption events.<br>
        /// 
        /// Notes:
        /// 1. This API is used to query stream push/interruption records, and should not be relied too much upon in important business scenarios.
        /// 2. You can use the `IsFilter` parameter of this API to filter and get required push records.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamEventListResponse"/></returns>
        public DescribeLiveStreamEventListResponse DescribeLiveStreamEventListSync(DescribeLiveStreamEventListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamEventListResponse>(req, "DescribeLiveStreamEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of ongoing live streams. It queries the information of live streams after they are pushed successfully. 
        /// 
        /// Notes:
        /// 1. This API is used to query the list of active live streams only, and should not be relied too much upon in important business scenarios.
        /// 2. This API can query up to 20,000 streams. To query more streams, please contact our after-sales service team.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamOnlineListResponse"/></returns>
        public Task<DescribeLiveStreamOnlineListResponse> DescribeLiveStreamOnlineList(DescribeLiveStreamOnlineListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamOnlineListResponse>(req, "DescribeLiveStreamOnlineList");
        }

        /// <summary>
        /// This API is used to get the list of ongoing live streams. It queries the information of live streams after they are pushed successfully. 
        /// 
        /// Notes:
        /// 1. This API is used to query the list of active live streams only, and should not be relied too much upon in important business scenarios.
        /// 2. This API can query up to 20,000 streams. To query more streams, please contact our after-sales service team.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamOnlineListResponse"/></returns>
        public DescribeLiveStreamOnlineListResponse DescribeLiveStreamOnlineListSync(DescribeLiveStreamOnlineListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamOnlineListResponse>(req, "DescribeLiveStreamOnlineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the list of pushed streams. <br>
        /// Note: Up to 10,000 entries can be queried per page. More data can be obtained by adjusting the query time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPublishedListResponse"/></returns>
        public Task<DescribeLiveStreamPublishedListResponse> DescribeLiveStreamPublishedList(DescribeLiveStreamPublishedListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPublishedListResponse>(req, "DescribeLiveStreamPublishedList");
        }

        /// <summary>
        /// This API is used to return the list of pushed streams. <br>
        /// Note: Up to 10,000 entries can be queried per page. More data can be obtained by adjusting the query time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPublishedListResponse"/></returns>
        public DescribeLiveStreamPublishedListResponse DescribeLiveStreamPublishedListSync(DescribeLiveStreamPublishedListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPublishedListResponse>(req, "DescribeLiveStreamPublishedList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the push information of all real-time streams, including client IP, server IP, frame rate, bitrate, domain name, and push start time.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPushInfoListResponse"/></returns>
        public Task<DescribeLiveStreamPushInfoListResponse> DescribeLiveStreamPushInfoList(DescribeLiveStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPushInfoListResponse>(req, "DescribeLiveStreamPushInfoList");
        }

        /// <summary>
        /// This API is used to query the push information of all real-time streams, including client IP, server IP, frame rate, bitrate, domain name, and push start time.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPushInfoListResponse"/></returns>
        public DescribeLiveStreamPushInfoListResponse DescribeLiveStreamPushInfoListSync(DescribeLiveStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPushInfoListResponse>(req, "DescribeLiveStreamPushInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the stream status, which may be active, inactive, or disabled.
        /// 
        /// Notes:
        /// This API allows you to query the status of a stream in real time. Given external factors such as network jitter, note the following when you determine whether a host is online:
        /// 1. If possible, use your own logic of stream starting/stopping in a room, such as streaming signaling on the client and the online heartbeat of a host, to determine whether the host is online.
        /// 2. If your application does not provide the room management feature, use the following methods to determine whether a host is online:
        /// 2.1 Use the [live stream callback](https://intl.cloud.tencent.com/document/product/267/20388?from_cn_redirect=1).
        /// 2.2 Call [DescribeLiveStreamOnlineList](https://intl.cloud.tencent.com/document/api/267/20472?from_cn_redirect=1) on a regular basis (interval > 1 min).
        /// 2.3 Call this API.
        /// 2.4 A host is considered to be online if the result returned by any of the above methods indicates so. If an API call times out or a parsing error occurs, to minimize the impact on your business, CSS will also consider the host online.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamStateResponse"/></returns>
        public Task<DescribeLiveStreamStateResponse> DescribeLiveStreamState(DescribeLiveStreamStateRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamStateResponse>(req, "DescribeLiveStreamState");
        }

        /// <summary>
        /// This API is used to get the stream status, which may be active, inactive, or disabled.
        /// 
        /// Notes:
        /// This API allows you to query the status of a stream in real time. Given external factors such as network jitter, note the following when you determine whether a host is online:
        /// 1. If possible, use your own logic of stream starting/stopping in a room, such as streaming signaling on the client and the online heartbeat of a host, to determine whether the host is online.
        /// 2. If your application does not provide the room management feature, use the following methods to determine whether a host is online:
        /// 2.1 Use the [live stream callback](https://intl.cloud.tencent.com/document/product/267/20388?from_cn_redirect=1).
        /// 2.2 Call [DescribeLiveStreamOnlineList](https://intl.cloud.tencent.com/document/api/267/20472?from_cn_redirect=1) on a regular basis (interval > 1 min).
        /// 2.3 Call this API.
        /// 2.4 A host is considered to be online if the result returned by any of the above methods indicates so. If an API call times out or a parsing error occurs, to minimize the impact on your business, CSS will also consider the host online.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamStateResponse"/></returns>
        public DescribeLiveStreamStateResponse DescribeLiveStreamStateSync(DescribeLiveStreamStateRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamStateResponse>(req, "DescribeLiveStreamState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time-shift video length, time-shift days, and total time-shift period of push domains. The data returned is on a five-minute basis. You can use it for reconciliation.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftBillInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftBillInfoListResponse"/></returns>
        public Task<DescribeLiveTimeShiftBillInfoListResponse> DescribeLiveTimeShiftBillInfoList(DescribeLiveTimeShiftBillInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftBillInfoListResponse>(req, "DescribeLiveTimeShiftBillInfoList");
        }

        /// <summary>
        /// This API is used to query the time-shift video length, time-shift days, and total time-shift period of push domains. The data returned is on a five-minute basis. You can use it for reconciliation.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftBillInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftBillInfoListResponse"/></returns>
        public DescribeLiveTimeShiftBillInfoListResponse DescribeLiveTimeShiftBillInfoListSync(DescribeLiveTimeShiftBillInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftBillInfoListResponse>(req, "DescribeLiveTimeShiftBillInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query time shifting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftRulesResponse"/></returns>
        public Task<DescribeLiveTimeShiftRulesResponse> DescribeLiveTimeShiftRules(DescribeLiveTimeShiftRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftRulesResponse>(req, "DescribeLiveTimeShiftRules");
        }

        /// <summary>
        /// This API is used to query time shifting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftRulesResponse"/></returns>
        public DescribeLiveTimeShiftRulesResponse DescribeLiveTimeShiftRulesSync(DescribeLiveTimeShiftRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftRulesResponse>(req, "DescribeLiveTimeShiftRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query time shifting templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftTemplatesResponse"/></returns>
        public Task<DescribeLiveTimeShiftTemplatesResponse> DescribeLiveTimeShiftTemplates(DescribeLiveTimeShiftTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftTemplatesResponse>(req, "DescribeLiveTimeShiftTemplates");
        }

        /// <summary>
        /// This API is used to query time shifting templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftTemplatesResponse"/></returns>
        public DescribeLiveTimeShiftTemplatesResponse DescribeLiveTimeShiftTemplatesSync(DescribeLiveTimeShiftTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftTemplatesResponse>(req, "DescribeLiveTimeShiftTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the transcoding details of a particular day or a specific time period. Querying may fail if the amount of data queried is too large. In such cases, try shortening the time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeDetailInfoResponse"/></returns>
        public Task<DescribeLiveTranscodeDetailInfoResponse> DescribeLiveTranscodeDetailInfo(DescribeLiveTranscodeDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeDetailInfoResponse>(req, "DescribeLiveTranscodeDetailInfo");
        }

        /// <summary>
        /// This API is used to query the transcoding details of a particular day or a specific time period. Querying may fail if the amount of data queried is too large. In such cases, try shortening the time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeDetailInfoResponse"/></returns>
        public DescribeLiveTranscodeDetailInfoResponse DescribeLiveTranscodeDetailInfoSync(DescribeLiveTranscodeDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeDetailInfoResponse>(req, "DescribeLiveTranscodeDetailInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of transcoding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeRulesResponse"/></returns>
        public Task<DescribeLiveTranscodeRulesResponse> DescribeLiveTranscodeRules(DescribeLiveTranscodeRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeRulesResponse>(req, "DescribeLiveTranscodeRules");
        }

        /// <summary>
        /// This API is used to get the list of transcoding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeRulesResponse"/></returns>
        public DescribeLiveTranscodeRulesResponse DescribeLiveTranscodeRulesSync(DescribeLiveTranscodeRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeRulesResponse>(req, "DescribeLiveTranscodeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a single transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplateResponse"/></returns>
        public Task<DescribeLiveTranscodeTemplateResponse> DescribeLiveTranscodeTemplate(DescribeLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplateResponse>(req, "DescribeLiveTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to get a single transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplateResponse"/></returns>
        public DescribeLiveTranscodeTemplateResponse DescribeLiveTranscodeTemplateSync(DescribeLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplateResponse>(req, "DescribeLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the transcoding template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplatesResponse"/></returns>
        public Task<DescribeLiveTranscodeTemplatesResponse> DescribeLiveTranscodeTemplates(DescribeLiveTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplatesResponse>(req, "DescribeLiveTranscodeTemplates");
        }

        /// <summary>
        /// This API is used to get the transcoding template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplatesResponse"/></returns>
        public DescribeLiveTranscodeTemplatesResponse DescribeLiveTranscodeTemplatesSync(DescribeLiveTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplatesResponse>(req, "DescribeLiveTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query transcoding usage. You can use it to query data in the past three months.
        /// Notes:
        /// If the start time and end time are on the same day, the data returned will be on a 5-minute basis.
        /// If the start time and end time are not on the same day or if the data of specified domains is queried, the data returned will be on an hourly basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTotalInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTotalInfoResponse"/></returns>
        public Task<DescribeLiveTranscodeTotalInfoResponse> DescribeLiveTranscodeTotalInfo(DescribeLiveTranscodeTotalInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTotalInfoResponse>(req, "DescribeLiveTranscodeTotalInfo");
        }

        /// <summary>
        /// This API is used to query transcoding usage. You can use it to query data in the past three months.
        /// Notes:
        /// If the start time and end time are on the same day, the data returned will be on a 5-minute basis.
        /// If the start time and end time are not on the same day or if the data of specified domains is queried, the data returned will be on an hourly basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTotalInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTotalInfoResponse"/></returns>
        public DescribeLiveTranscodeTotalInfoResponse DescribeLiveTranscodeTotalInfoSync(DescribeLiveTranscodeTotalInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTotalInfoResponse>(req, "DescribeLiveTranscodeTotalInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a single watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkResponse"/></returns>
        public Task<DescribeLiveWatermarkResponse> DescribeLiveWatermark(DescribeLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkResponse>(req, "DescribeLiveWatermark");
        }

        /// <summary>
        /// This API is used to get the information of a single watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkResponse"/></returns>
        public DescribeLiveWatermarkResponse DescribeLiveWatermarkSync(DescribeLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkResponse>(req, "DescribeLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the watermarking rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkRulesResponse"/></returns>
        public Task<DescribeLiveWatermarkRulesResponse> DescribeLiveWatermarkRules(DescribeLiveWatermarkRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkRulesResponse>(req, "DescribeLiveWatermarkRules");
        }

        /// <summary>
        /// This API is used to get the watermarking rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkRulesResponse"/></returns>
        public DescribeLiveWatermarkRulesResponse DescribeLiveWatermarkRulesSync(DescribeLiveWatermarkRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkRulesResponse>(req, "DescribeLiveWatermarkRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the watermark list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarksResponse"/></returns>
        public Task<DescribeLiveWatermarksResponse> DescribeLiveWatermarks(DescribeLiveWatermarksRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarksResponse>(req, "DescribeLiveWatermarks");
        }

        /// <summary>
        /// This API is used to query the watermark list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarksResponse"/></returns>
        public DescribeLiveWatermarksResponse DescribeLiveWatermarksSync(DescribeLiveWatermarksRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarksResponse>(req, "DescribeLiveWatermarks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes, i.e., the occurrences of each HTTP error code (4xx and 5xx) at a 1-minute granularity in a certain period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeDetailInfoListResponse"/></returns>
        public Task<DescribePlayErrorCodeDetailInfoListResponse> DescribePlayErrorCodeDetailInfoList(DescribePlayErrorCodeDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeDetailInfoListResponse>(req, "DescribePlayErrorCodeDetailInfoList");
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes, i.e., the occurrences of each HTTP error code (4xx and 5xx) at a 1-minute granularity in a certain period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeDetailInfoListResponse"/></returns>
        public DescribePlayErrorCodeDetailInfoListResponse DescribePlayErrorCodeDetailInfoListSync(DescribePlayErrorCodeDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeDetailInfoListResponse>(req, "DescribePlayErrorCodeDetailInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeSumInfoListResponse"/></returns>
        public Task<DescribePlayErrorCodeSumInfoListResponse> DescribePlayErrorCodeSumInfoList(DescribePlayErrorCodeSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeSumInfoListResponse>(req, "DescribePlayErrorCodeSumInfoList");
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeSumInfoListResponse"/></returns>
        public DescribePlayErrorCodeSumInfoListResponse DescribePlayErrorCodeSumInfoListSync(DescribePlayErrorCodeSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeSumInfoListResponse>(req, "DescribePlayErrorCodeSumInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the downstream playback data of a specified ISP in a specified district, including bandwidth, traffic, number of requests, and number of concurrent connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeProvinceIspPlayInfoListResponse"/></returns>
        public Task<DescribeProvinceIspPlayInfoListResponse> DescribeProvinceIspPlayInfoList(DescribeProvinceIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeProvinceIspPlayInfoListResponse>(req, "DescribeProvinceIspPlayInfoList");
        }

        /// <summary>
        /// This API is used to query the downstream playback data of a specified ISP in a specified district, including bandwidth, traffic, number of requests, and number of concurrent connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeProvinceIspPlayInfoListResponse"/></returns>
        public DescribeProvinceIspPlayInfoListResponse DescribeProvinceIspPlayInfoListSync(DescribeProvinceIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeProvinceIspPlayInfoListResponse>(req, "DescribeProvinceIspPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve a list of recording tasks that were started and ended within a specified time range. 
        /// - Prerequisites: 
        /// 1. This API is only used to query recording tasks created by the CreateRecordTask interface. 
        /// 2. It cannot retrieve recording tasks that have been deleted by the DeleteRecordTask interface or tasks that have expired (platform retains for 3 months).
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordTaskResponse"/></returns>
        public Task<DescribeRecordTaskResponse> DescribeRecordTask(DescribeRecordTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordTaskResponse>(req, "DescribeRecordTask");
        }

        /// <summary>
        /// This API is used to retrieve a list of recording tasks that were started and ended within a specified time range. 
        /// - Prerequisites: 
        /// 1. This API is only used to query recording tasks created by the CreateRecordTask interface. 
        /// 2. It cannot retrieve recording tasks that have been deleted by the DeleteRecordTask interface or tasks that have expired (platform retains for 3 months).
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordTaskResponse"/></returns>
        public DescribeRecordTaskResponse DescribeRecordTaskSync(DescribeRecordTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordTaskResponse>(req, "DescribeRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API is used to query the number of screenshots as an LVB value-added service.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenShotSheetNumListRequest"/></param>
        /// <returns><see cref="DescribeScreenShotSheetNumListResponse"/></returns>
        public Task<DescribeScreenShotSheetNumListResponse> DescribeScreenShotSheetNumList(DescribeScreenShotSheetNumListRequest req)
        {
            return InternalRequestAsync<DescribeScreenShotSheetNumListResponse>(req, "DescribeScreenShotSheetNumList");
        }

        /// <summary>
        /// The API is used to query the number of screenshots as an LVB value-added service.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenShotSheetNumListRequest"/></param>
        /// <returns><see cref="DescribeScreenShotSheetNumListResponse"/></returns>
        public DescribeScreenShotSheetNumListResponse DescribeScreenShotSheetNumListSync(DescribeScreenShotSheetNumListRequest req)
        {
            return InternalRequestAsync<DescribeScreenShotSheetNumListResponse>(req, "DescribeScreenShotSheetNumList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the playback data of each stream at the day level, including the total traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamDayPlayInfoListResponse"/></returns>
        public Task<DescribeStreamDayPlayInfoListResponse> DescribeStreamDayPlayInfoList(DescribeStreamDayPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamDayPlayInfoListResponse>(req, "DescribeStreamDayPlayInfoList");
        }

        /// <summary>
        /// This API is used to query the playback data of each stream at the day level, including the total traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamDayPlayInfoListResponse"/></returns>
        public DescribeStreamDayPlayInfoListResponse DescribeStreamDayPlayInfoListSync(DescribeStreamDayPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamDayPlayInfoListResponse>(req, "DescribeStreamDayPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the playback data. It supports querying the playback details by stream name and aggregated data by playback domain name. Data in the last 4 minutes or so cannot be queried due to delay.
        /// Note: to query by `AppName`, you need to submit a ticket first. After your application succeeds, it will take about 5 business days (subject to the time in the reply) for the configuration to take effect.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public Task<DescribeStreamPlayInfoListResponse> DescribeStreamPlayInfoList(DescribeStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPlayInfoListResponse>(req, "DescribeStreamPlayInfoList");
        }

        /// <summary>
        /// This API is used to query the playback data. It supports querying the playback details by stream name and aggregated data by playback domain name. Data in the last 4 minutes or so cannot be queried due to delay.
        /// Note: to query by `AppName`, you need to submit a ticket first. After your application succeeds, it will take about 5 business days (subject to the time in the reply) for the configuration to take effect.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public DescribeStreamPlayInfoListResponse DescribeStreamPlayInfoListSync(DescribeStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPlayInfoListResponse>(req, "DescribeStreamPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the push data of a stream, including the audio/video frame rate, bitrate, elapsed time, and codec.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPushInfoListResponse"/></returns>
        public Task<DescribeStreamPushInfoListResponse> DescribeStreamPushInfoList(DescribeStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPushInfoListResponse>(req, "DescribeStreamPushInfoList");
        }

        /// <summary>
        /// This API is used to get the push data of a stream, including the audio/video frame rate, bitrate, elapsed time, and codec.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPushInfoListResponse"/></returns>
        public DescribeStreamPushInfoListResponse DescribeStreamPushInfoListSync(DescribeStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPushInfoListResponse>(req, "DescribeStreamPushInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time shifting details of a specific time period (up to 24 hours). You need to call `DescribeTimeShiftStreamList` first to get the request parameters of this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftRecordDetailResponse"/></returns>
        public Task<DescribeTimeShiftRecordDetailResponse> DescribeTimeShiftRecordDetail(DescribeTimeShiftRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftRecordDetailResponse>(req, "DescribeTimeShiftRecordDetail");
        }

        /// <summary>
        /// This API is used to query the time shifting details of a specific time period (up to 24 hours). You need to call `DescribeTimeShiftStreamList` first to get the request parameters of this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftRecordDetailResponse"/></returns>
        public DescribeTimeShiftRecordDetailResponse DescribeTimeShiftRecordDetailSync(DescribeTimeShiftRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftRecordDetailResponse>(req, "DescribeTimeShiftRecordDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time shifted streams in a specific time period (up to 24 hours).
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftStreamListRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftStreamListResponse"/></returns>
        public Task<DescribeTimeShiftStreamListResponse> DescribeTimeShiftStreamList(DescribeTimeShiftStreamListRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftStreamListResponse>(req, "DescribeTimeShiftStreamList");
        }

        /// <summary>
        /// This API is used to query the time shifted streams in a specific time period (up to 24 hours).
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftStreamListRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftStreamListResponse"/></returns>
        public DescribeTimeShiftStreamListResponse DescribeTimeShiftStreamListSync(DescribeTimeShiftStreamListRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftStreamListResponse>(req, "DescribeTimeShiftStreamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of the top n client IPs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeTopClientIpSumInfoListResponse"/></returns>
        public Task<DescribeTopClientIpSumInfoListResponse> DescribeTopClientIpSumInfoList(DescribeTopClientIpSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTopClientIpSumInfoListResponse>(req, "DescribeTopClientIpSumInfoList");
        }

        /// <summary>
        /// This API is used to query the information of the top n client IPs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeTopClientIpSumInfoListResponse"/></returns>
        public DescribeTopClientIpSumInfoListResponse DescribeTopClientIpSumInfoListSync(DescribeTopClientIpSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTopClientIpSumInfoListResponse>(req, "DescribeTopClientIpSumInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of transcoding tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTaskNumRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTaskNumResponse"/></returns>
        public Task<DescribeTranscodeTaskNumResponse> DescribeTranscodeTaskNum(DescribeTranscodeTaskNumRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTaskNumResponse>(req, "DescribeTranscodeTaskNum");
        }

        /// <summary>
        /// This API is used to query the number of transcoding tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTaskNumRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTaskNumResponse"/></returns>
        public DescribeTranscodeTaskNumResponse DescribeTranscodeTaskNumSync(DescribeTranscodeTaskNumRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTaskNumResponse>(req, "DescribeTranscodeTaskNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of LVB upstream channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadStreamNumsRequest"/></param>
        /// <returns><see cref="DescribeUploadStreamNumsResponse"/></returns>
        public Task<DescribeUploadStreamNumsResponse> DescribeUploadStreamNums(DescribeUploadStreamNumsRequest req)
        {
            return InternalRequestAsync<DescribeUploadStreamNumsResponse>(req, "DescribeUploadStreamNums");
        }

        /// <summary>
        /// This API is used to query the number of LVB upstream channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadStreamNumsRequest"/></param>
        /// <returns><see cref="DescribeUploadStreamNumsResponse"/></returns>
        public DescribeUploadStreamNumsResponse DescribeUploadStreamNumsSync(DescribeUploadStreamNumsRequest req)
        {
            return InternalRequestAsync<DescribeUploadStreamNumsResponse>(req, "DescribeUploadStreamNums")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of the top n domain names or stream IDs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeVisitTopSumInfoListResponse"/></returns>
        public Task<DescribeVisitTopSumInfoListResponse> DescribeVisitTopSumInfoList(DescribeVisitTopSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeVisitTopSumInfoListResponse>(req, "DescribeVisitTopSumInfoList");
        }

        /// <summary>
        /// This API is used to query the information of the top n domain names or stream IDs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeVisitTopSumInfoListResponse"/></returns>
        public DescribeVisitTopSumInfoListResponse DescribeVisitTopSumInfoListSync(DescribeVisitTopSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeVisitTopSumInfoListResponse>(req, "DescribeVisitTopSumInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause a live stream. The stream can be resumed if it is paused.
        /// Note: If you call this API to pause an inactive stream, the request will be considered successful.
        /// </summary>
        /// <param name="req"><see cref="DropLiveStreamRequest"/></param>
        /// <returns><see cref="DropLiveStreamResponse"/></returns>
        public Task<DropLiveStreamResponse> DropLiveStream(DropLiveStreamRequest req)
        {
            return InternalRequestAsync<DropLiveStreamResponse>(req, "DropLiveStream");
        }

        /// <summary>
        /// This API is used to pause a live stream. The stream can be resumed if it is paused.
        /// Note: If you call this API to pause an inactive stream, the request will be considered successful.
        /// </summary>
        /// <param name="req"><see cref="DropLiveStreamRequest"/></param>
        /// <returns><see cref="DropLiveStreamResponse"/></returns>
        public DropLiveStreamResponse DropLiveStreamSync(DropLiveStreamRequest req)
        {
            return InternalRequestAsync<DropLiveStreamResponse>(req, "DropLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a disabled LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="EnableLiveDomainRequest"/></param>
        /// <returns><see cref="EnableLiveDomainResponse"/></returns>
        public Task<EnableLiveDomainResponse> EnableLiveDomain(EnableLiveDomainRequest req)
        {
            return InternalRequestAsync<EnableLiveDomainResponse>(req, "EnableLiveDomain");
        }

        /// <summary>
        /// This API is used to enable a disabled LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="EnableLiveDomainRequest"/></param>
        /// <returns><see cref="EnableLiveDomainResponse"/></returns>
        public EnableLiveDomainResponse EnableLiveDomainSync(EnableLiveDomainRequest req)
        {
            return InternalRequestAsync<EnableLiveDomainResponse>(req, "EnableLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable an LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveDomainRequest"/></param>
        /// <returns><see cref="ForbidLiveDomainResponse"/></returns>
        public Task<ForbidLiveDomainResponse> ForbidLiveDomain(ForbidLiveDomainRequest req)
        {
            return InternalRequestAsync<ForbidLiveDomainResponse>(req, "ForbidLiveDomain");
        }

        /// <summary>
        /// This API is used to disable an LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveDomainRequest"/></param>
        /// <returns><see cref="ForbidLiveDomainResponse"/></returns>
        public ForbidLiveDomainResponse ForbidLiveDomainSync(ForbidLiveDomainRequest req)
        {
            return InternalRequestAsync<ForbidLiveDomainResponse>(req, "ForbidLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a stream. You can set a time to resume the stream.
        /// Note:
        /// 1. As long as the correct stream name is passed in, the stream will be disabled successfully.
        /// 2. If you want a stream to be disabled only if the push domain, push path, and stream name match, please submit a ticket.
        /// 3. If you have configured domain groups, you must pass in the correct push domain in order to disable a stream.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
            return InternalRequestAsync<ForbidLiveStreamResponse>(req, "ForbidLiveStream");
        }

        /// <summary>
        /// This API is used to disable a stream. You can set a time to resume the stream.
        /// Note:
        /// 1. As long as the correct stream name is passed in, the stream will be disabled successfully.
        /// 2. If you want a stream to be disabled only if the push domain, push path, and stream name match, please submit a ticket.
        /// 3. If you have configured domain groups, you must pass in the correct push domain in order to disable a stream.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public ForbidLiveStreamResponse ForbidLiveStreamSync(ForbidLiveStreamRequest req)
        {
            return InternalRequestAsync<ForbidLiveStreamResponse>(req, "ForbidLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a callback template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveCallbackTemplateResponse"/></returns>
        public Task<ModifyLiveCallbackTemplateResponse> ModifyLiveCallbackTemplate(ModifyLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveCallbackTemplateResponse>(req, "ModifyLiveCallbackTemplate");
        }

        /// <summary>
        /// This API is used to modify a callback template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveCallbackTemplateResponse"/></returns>
        public ModifyLiveCallbackTemplateResponse ModifyLiveCallbackTemplateSync(ModifyLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveCallbackTemplateResponse>(req, "ModifyLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a certificate to multiple playback domains and update the HTTPS configuration of the domains.
        /// If a self-owned certificate is used, it will be automatically uploaded to Tencent Cloud’s SSL Certificate Service.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainCertBindingsResponse"/></returns>
        public Task<ModifyLiveDomainCertBindingsResponse> ModifyLiveDomainCertBindings(ModifyLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainCertBindingsResponse>(req, "ModifyLiveDomainCertBindings");
        }

        /// <summary>
        /// This API is used to bind a certificate to multiple playback domains and update the HTTPS configuration of the domains.
        /// If a self-owned certificate is used, it will be automatically uploaded to Tencent Cloud’s SSL Certificate Service.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainCertBindingsResponse"/></returns>
        public ModifyLiveDomainCertBindingsResponse ModifyLiveDomainCertBindingsSync(ModifyLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainCertBindingsResponse>(req, "ModifyLiveDomainCertBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure referer allowlist/blocklist of a live streaming domain name.
        /// Referer information is included in HTTP requests. After you enable referer configuration, live streams using RTMP or WebRTC for playback will not authenticate the referer and can be played back normally. To make the referer configuration effective, the HTTP-FLV or HLS protocol is recommended for playback.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainRefererRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainRefererResponse"/></returns>
        public Task<ModifyLiveDomainRefererResponse> ModifyLiveDomainReferer(ModifyLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainRefererResponse>(req, "ModifyLiveDomainReferer");
        }

        /// <summary>
        /// This API is used to configure referer allowlist/blocklist of a live streaming domain name.
        /// Referer information is included in HTTP requests. After you enable referer configuration, live streams using RTMP or WebRTC for playback will not authenticate the referer and can be played back normally. To make the referer configuration effective, the HTTP-FLV or HLS protocol is recommended for playback.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainRefererRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainRefererResponse"/></returns>
        public ModifyLiveDomainRefererResponse ModifyLiveDomainRefererSync(ModifyLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainRefererResponse>(req, "ModifyLiveDomainReferer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePlayAuthKeyResponse"/></returns>
        public Task<ModifyLivePlayAuthKeyResponse> ModifyLivePlayAuthKey(ModifyLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayAuthKeyResponse>(req, "ModifyLivePlayAuthKey");
        }

        /// <summary>
        /// This API is used to modify the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePlayAuthKeyResponse"/></returns>
        public ModifyLivePlayAuthKeyResponse ModifyLivePlayAuthKeySync(ModifyLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayAuthKeyResponse>(req, "ModifyLivePlayAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a playback domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns><see cref="ModifyLivePlayDomainResponse"/></returns>
        public Task<ModifyLivePlayDomainResponse> ModifyLivePlayDomain(ModifyLivePlayDomainRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayDomainResponse>(req, "ModifyLivePlayDomain");
        }

        /// <summary>
        /// This API is used to modify a playback domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns><see cref="ModifyLivePlayDomainResponse"/></returns>
        public ModifyLivePlayDomainResponse ModifyLivePlayDomainSync(ModifyLivePlayDomainRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayDomainResponse>(req, "ModifyLivePlayDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a stream pulling task. 
        /// 1. You cannot modify the destination URL. To publish to a new destination, please create a new task.
        /// 2. You cannot modify the source type. To use a different source type, please create a new task.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="ModifyLivePullStreamTaskResponse"/></returns>
        public Task<ModifyLivePullStreamTaskResponse> ModifyLivePullStreamTask(ModifyLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<ModifyLivePullStreamTaskResponse>(req, "ModifyLivePullStreamTask");
        }

        /// <summary>
        /// This API is used to modify a stream pulling task. 
        /// 1. You cannot modify the destination URL. To publish to a new destination, please create a new task.
        /// 2. You cannot modify the source type. To use a different source type, please create a new task.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="ModifyLivePullStreamTaskResponse"/></returns>
        public ModifyLivePullStreamTaskResponse ModifyLivePullStreamTaskSync(ModifyLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<ModifyLivePullStreamTaskResponse>(req, "ModifyLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePushAuthKeyResponse"/></returns>
        public Task<ModifyLivePushAuthKeyResponse> ModifyLivePushAuthKey(ModifyLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePushAuthKeyResponse>(req, "ModifyLivePushAuthKey");
        }

        /// <summary>
        /// This API is used to modify the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePushAuthKeyResponse"/></returns>
        public ModifyLivePushAuthKeyResponse ModifyLivePushAuthKeySync(ModifyLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePushAuthKeyResponse>(req, "ModifyLivePushAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the recording template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public Task<ModifyLiveRecordTemplateResponse> ModifyLiveRecordTemplate(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate");
        }

        /// <summary>
        /// This API is used to modify the recording template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public ModifyLiveRecordTemplateResponse ModifyLiveRecordTemplateSync(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the screencapturing template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveSnapshotTemplateResponse"/></returns>
        public Task<ModifyLiveSnapshotTemplateResponse> ModifyLiveSnapshotTemplate(ModifyLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveSnapshotTemplateResponse>(req, "ModifyLiveSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to modify the screencapturing template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveSnapshotTemplateResponse"/></returns>
        public ModifyLiveSnapshotTemplateResponse ModifyLiveSnapshotTemplateSync(ModifyLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveSnapshotTemplateResponse>(req, "ModifyLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a time shifting template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTimeShiftTemplateResponse"/></returns>
        public Task<ModifyLiveTimeShiftTemplateResponse> ModifyLiveTimeShiftTemplate(ModifyLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTimeShiftTemplateResponse>(req, "ModifyLiveTimeShiftTemplate");
        }

        /// <summary>
        /// This API is used to modify a time shifting template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTimeShiftTemplateResponse"/></returns>
        public ModifyLiveTimeShiftTemplateResponse ModifyLiveTimeShiftTemplateSync(ModifyLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTimeShiftTemplateResponse>(req, "ModifyLiveTimeShiftTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the transcoding template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTranscodeTemplateResponse"/></returns>
        public Task<ModifyLiveTranscodeTemplateResponse> ModifyLiveTranscodeTemplate(ModifyLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTranscodeTemplateResponse>(req, "ModifyLiveTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to modify the transcoding template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTranscodeTemplateResponse"/></returns>
        public ModifyLiveTranscodeTemplateResponse ModifyLiveTranscodeTemplateSync(ModifyLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTranscodeTemplateResponse>(req, "ModifyLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Restart the running live streaming pull task.
        /// </summary>
        /// <param name="req"><see cref="RestartLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="RestartLivePullStreamTaskResponse"/></returns>
        public Task<RestartLivePullStreamTaskResponse> RestartLivePullStreamTask(RestartLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<RestartLivePullStreamTaskResponse>(req, "RestartLivePullStreamTask");
        }

        /// <summary>
        /// Restart the running live streaming pull task.
        /// </summary>
        /// <param name="req"><see cref="RestartLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="RestartLivePullStreamTaskResponse"/></returns>
        public RestartLivePullStreamTaskResponse RestartLivePullStreamTaskSync(RestartLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<RestartLivePullStreamTaskResponse>(req, "RestartLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel the delay setting and recover the real-time display of the live streaming image.
        /// </summary>
        /// <param name="req"><see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeDelayLiveStreamResponse"/></returns>
        public Task<ResumeDelayLiveStreamResponse> ResumeDelayLiveStream(ResumeDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeDelayLiveStreamResponse>(req, "ResumeDelayLiveStream");
        }

        /// <summary>
        /// This API is used to cancel the delay setting and recover the real-time display of the live streaming image.
        /// </summary>
        /// <param name="req"><see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeDelayLiveStreamResponse"/></returns>
        public ResumeDelayLiveStreamResponse ResumeDelayLiveStreamSync(ResumeDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeDelayLiveStreamResponse>(req, "ResumeDelayLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resume the push of a specific stream.
        /// </summary>
        /// <param name="req"><see cref="ResumeLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeLiveStreamResponse"/></returns>
        public Task<ResumeLiveStreamResponse> ResumeLiveStream(ResumeLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeLiveStreamResponse>(req, "ResumeLiveStream");
        }

        /// <summary>
        /// This API is used to resume the push of a specific stream.
        /// </summary>
        /// <param name="req"><see cref="ResumeLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeLiveStreamResponse"/></returns>
        public ResumeLiveStreamResponse ResumeLiveStreamSync(ResumeLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeLiveStreamResponse>(req, "ResumeLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Note: Recording files are stored on the VOD platform. To use the recording feature, you need to activate a VOD account and ensure that it is available. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) will be charged according to the VOD billing method. For more information, please see the corresponding document.
        /// </summary>
        /// <param name="req"><see cref="StopLiveRecordRequest"/></param>
        /// <returns><see cref="StopLiveRecordResponse"/></returns>
        public Task<StopLiveRecordResponse> StopLiveRecord(StopLiveRecordRequest req)
        {
            return InternalRequestAsync<StopLiveRecordResponse>(req, "StopLiveRecord");
        }

        /// <summary>
        /// Note: Recording files are stored on the VOD platform. To use the recording feature, you need to activate a VOD account and ensure that it is available. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) will be charged according to the VOD billing method. For more information, please see the corresponding document.
        /// </summary>
        /// <param name="req"><see cref="StopLiveRecordRequest"/></param>
        /// <returns><see cref="StopLiveRecordResponse"/></returns>
        public StopLiveRecordResponse StopLiveRecordSync(StopLiveRecordRequest req)
        {
            return InternalRequestAsync<StopLiveRecordResponse>(req, "StopLiveRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate an ongoing recording task and generate a recording file.
        /// </summary>
        /// <param name="req"><see cref="StopRecordTaskRequest"/></param>
        /// <returns><see cref="StopRecordTaskResponse"/></returns>
        public Task<StopRecordTaskResponse> StopRecordTask(StopRecordTaskRequest req)
        {
            return InternalRequestAsync<StopRecordTaskResponse>(req, "StopRecordTask");
        }

        /// <summary>
        /// This API is used to terminate an ongoing recording task and generate a recording file.
        /// </summary>
        /// <param name="req"><see cref="StopRecordTaskRequest"/></param>
        /// <returns><see cref="StopRecordTaskResponse"/></returns>
        public StopRecordTaskResponse StopRecordTaskSync(StopRecordTaskRequest req)
        {
            return InternalRequestAsync<StopRecordTaskResponse>(req, "StopRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a domain name certificate.
        /// </summary>
        /// <param name="req"><see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns><see cref="UnBindLiveDomainCertResponse"/></returns>
        public Task<UnBindLiveDomainCertResponse> UnBindLiveDomainCert(UnBindLiveDomainCertRequest req)
        {
            return InternalRequestAsync<UnBindLiveDomainCertResponse>(req, "UnBindLiveDomainCert");
        }

        /// <summary>
        /// This API is used to unbind a domain name certificate.
        /// </summary>
        /// <param name="req"><see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns><see cref="UnBindLiveDomainCertResponse"/></returns>
        public UnBindLiveDomainCertResponse UnBindLiveDomainCertSync(UnBindLiveDomainCertRequest req)
        {
            return InternalRequestAsync<UnBindLiveDomainCertResponse>(req, "UnBindLiveDomainCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a watermark.
        /// </summary>
        /// <param name="req"><see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns><see cref="UpdateLiveWatermarkResponse"/></returns>
        public Task<UpdateLiveWatermarkResponse> UpdateLiveWatermark(UpdateLiveWatermarkRequest req)
        {
            return InternalRequestAsync<UpdateLiveWatermarkResponse>(req, "UpdateLiveWatermark");
        }

        /// <summary>
        /// This API is used to update a watermark.
        /// </summary>
        /// <param name="req"><see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns><see cref="UpdateLiveWatermarkResponse"/></returns>
        public UpdateLiveWatermarkResponse UpdateLiveWatermarkSync(UpdateLiveWatermarkRequest req)
        {
            return InternalRequestAsync<UpdateLiveWatermarkResponse>(req, "UpdateLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
