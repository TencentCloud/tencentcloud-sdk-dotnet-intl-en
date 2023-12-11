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

namespace TencentCloud.Ams.V20201229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ams.V20201229.Models;

   public class AmsClient : AbstractClient{

       private const string endpoint = "ams.tencentcloudapi.com";
       private const string version = "2020-12-29";
       private const string sdkVersion = "3.0.840";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to cancel a moderation task. If it returns `RequestId`, the task has been canceled successfully.<br>Default API request rate limit: **20 requests/sec**.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask");
        }

        /// <summary>
        /// This API is used to cancel a moderation task. If it returns `RequestId`, the task has been canceled successfully.<br>Default API request rate limit: **20 requests/sec**.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit audio content (such as an audio file or stream URL) for smart moderation. Before using it, you need to log in to the console with the Tencent Cloud root account [to activate AMS](https://console.cloud.tencent.com/cms/audio/package) and adjust the business configuration.<br>
        /// 
        /// ### Feature use instructions
        /// - Go to the "[CMS console - AMS](https://console.cloud.tencent.com/cms/audio/package)" to activate AMS.
        /// - Default API request rate limit: **20 requests/sec**. When this limit is exceeded, requests for async moderation tasks (audio on demand) will automatically join the queue of requests pending moderation, while an error will be reported for sync moderation tasks (audio live streaming).
        /// 
        /// ### API feature description
        /// - It can detect audio streams or files for non-compliant content;
        /// - You can set the callback address (Callback) to get the detection result (for moderation tasks in progress, the maximum callback time is the configured **segment length + 2s). You can also call the API for querying the audio detection result to poll the detection result;
        /// - It can recognize various types of non-compliant content, including vulgarity, abuse, porn, and advertising;
        /// - You can submit **up to 10** detection tasks at a time.
        /// 
        /// ### Call description for audio file
        /// - Supported audio file size: **< 500 MB**;
        /// - Supported audio file duration: **< 1 hour**;
        /// - Supported audio bitrate: 128–256 Kbps;
        /// - Supported audio file formats: WAV, MP3, AAC, FLAC, AMR, 3GP, M4A, WMA, OGG, and APE;
        /// - **When the input is a video file**, the audio track can be extracted from it for audio content moderation.
        /// 
        /// ### Call description for audio stream
        /// - Supported audio stream duration: **< 3 hours**;
        /// - Supported audio bitrate: 128–256 Kbps;
        /// - Supported audio stream transfer protocols: RTMP, HTTP, and HTTPS;
        /// - Supported audio stream formats: RTP, SRTP, RTMP, RTMPS, MMSH, MMST, HLS, HTTP, TCP, HTTPS, and M3U8;
        /// - **When the input is a video stream**, the audio track can be extracted from it for audio content moderation.
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationTaskResponse"/></returns>
        public Task<CreateAudioModerationTaskResponse> CreateAudioModerationTask(CreateAudioModerationTaskRequest req)
        {
            return InternalRequestAsync<CreateAudioModerationTaskResponse>(req, "CreateAudioModerationTask");
        }

        /// <summary>
        /// This API is used to submit audio content (such as an audio file or stream URL) for smart moderation. Before using it, you need to log in to the console with the Tencent Cloud root account [to activate AMS](https://console.cloud.tencent.com/cms/audio/package) and adjust the business configuration.<br>
        /// 
        /// ### Feature use instructions
        /// - Go to the "[CMS console - AMS](https://console.cloud.tencent.com/cms/audio/package)" to activate AMS.
        /// - Default API request rate limit: **20 requests/sec**. When this limit is exceeded, requests for async moderation tasks (audio on demand) will automatically join the queue of requests pending moderation, while an error will be reported for sync moderation tasks (audio live streaming).
        /// 
        /// ### API feature description
        /// - It can detect audio streams or files for non-compliant content;
        /// - You can set the callback address (Callback) to get the detection result (for moderation tasks in progress, the maximum callback time is the configured **segment length + 2s). You can also call the API for querying the audio detection result to poll the detection result;
        /// - It can recognize various types of non-compliant content, including vulgarity, abuse, porn, and advertising;
        /// - You can submit **up to 10** detection tasks at a time.
        /// 
        /// ### Call description for audio file
        /// - Supported audio file size: **< 500 MB**;
        /// - Supported audio file duration: **< 1 hour**;
        /// - Supported audio bitrate: 128–256 Kbps;
        /// - Supported audio file formats: WAV, MP3, AAC, FLAC, AMR, 3GP, M4A, WMA, OGG, and APE;
        /// - **When the input is a video file**, the audio track can be extracted from it for audio content moderation.
        /// 
        /// ### Call description for audio stream
        /// - Supported audio stream duration: **< 3 hours**;
        /// - Supported audio bitrate: 128–256 Kbps;
        /// - Supported audio stream transfer protocols: RTMP, HTTP, and HTTPS;
        /// - Supported audio stream formats: RTP, SRTP, RTMP, RTMPS, MMSH, MMST, HLS, HTTP, TCP, HTTPS, and M3U8;
        /// - **When the input is a video stream**, the audio track can be extracted from it for audio content moderation.
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationTaskResponse"/></returns>
        public CreateAudioModerationTaskResponse CreateAudioModerationTaskSync(CreateAudioModerationTaskRequest req)
        {
            return InternalRequestAsync<CreateAudioModerationTaskResponse>(req, "CreateAudioModerationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface is used to view the detailed information of the audio moderation tasks, including task status, detection results, corresponding text content recognized from the audio file, recommended follow-up operations of the maliciousness tags corresponding to the detection results, and so on. For specific output content, see the output parameter examples.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// This interface is used to view the detailed information of the audio moderation tasks, including task status, detection results, corresponding text content recognized from the audio file, recommended follow-up operations of the maliciousness tags corresponding to the detection results, and so on. For specific output content, see the output parameter examples.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of moderation tasks. You can also filter moderation tasks by multiple types of business information, such as business type, moderation result, and task status. The output content of the task list includes the total number of queried tasks, task name, task status, audio moderation type, maliciousness tag of the detection result, and suggested operation. For the specific output content, see the sample output parameters.<br>Default API request rate limit: **20 requests/sec**.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// This API is used to view the list of moderation tasks. You can also filter moderation tasks by multiple types of business information, such as business type, moderation result, and task status. The output content of the task list includes the total number of queried tasks, task name, task status, audio moderation type, maliciousness tag of the detection result, and suggested operation. For the specific output content, see the sample output parameters.<br>Default API request rate limit: **20 requests/sec**.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
