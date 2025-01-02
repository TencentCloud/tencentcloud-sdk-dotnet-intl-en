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

namespace TencentCloud.Asr.V20190614
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Asr.V20190614.Models;

   public class AsrClient : AbstractClient{

       private const string endpoint = "asr.tencentcloudapi.com";
       private const string version = "2019-06-14";
       private const string sdkVersion = "SDK_NET_3.0.1046";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AsrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AsrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API can be used to recognize audio content with a long duration in recording files. If you want to use ASR with UI, visit [the trial console] (https://console.cloud.tencent.com/asr/demonstrate). For product pricing, see [Billing Overview (Online Version)] (https://intl.cloud.tencent.com/document/product/1093/35686?from_cn_redirect=1)
        /// - Default frequency limit: 20 requests/second. This limit only applies to submitted requests but not the response time.
        /// Response time: The API adopts asynchronous callback and does not return results in real time. Recognition results will be returned within 3 hours at most. ** In most cases, audio with a duration of 1 hour can be recognized in 1 to 3 minutes. ** Note: The response time does not include the audio download time and will not apply to scenarios where recordings with a total audio duration of over 1,000 hours or over 20,000 requests are submitted within 30 minutes.
        /// - Audio formats: WAV, MP3, M4A, FLV, MP4, WMA, 3GP, AMR, AAC, OGG (Opus), and FLAC.
        /// - Supported languages: See the description of ** EngineModelType ** in this document or go to [Product Features] (https://intl.cloud.tencent.com/document/product/1093/35682?from_cn_redirect=1) for details.
        /// - Audio submission method: This API supports ** audio URLs and local audio files **. It is recommended to use [Tencent Cloud COS] (https://intl.cloud.tencent.com/document/product/436/38484?from_cn_redirect=1) to store audio files, generate URLs, and submit requests. This method does not incur public network or downstream traffic fees but can speed up task processing. (Set the public read and private write permissions for COS buckets or URLs to be externally accessible.)
        /// - Audio restrictions: For a single URL, the audio duration cannot exceed 5 hours, and the file size cannot exceed 1 GB. For a local audio file, the file size cannot exceed 5 MB.
        /// - Obtain recognition results: Results can be obtained through ** callback or polling **. See [Result Query] (https://intl.cloud.tencent.com/document/product/1093/37822?from_cn_redirect=1) for details.
        /// - Recognition result retention period: Recognition results are retained on the server for 24 hours.
        /// - For the signature method, see the content related to the signature method v3 in [Public Parameters] (https://intl.cloud.tencent.com/document/api/1093/35640?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateRecTaskRequest"/></param>
        /// <returns><see cref="CreateRecTaskResponse"/></returns>
        public Task<CreateRecTaskResponse> CreateRecTask(CreateRecTaskRequest req)
        {
            return InternalRequestAsync<CreateRecTaskResponse>(req, "CreateRecTask");
        }

        /// <summary>
        /// This API can be used to recognize audio content with a long duration in recording files. If you want to use ASR with UI, visit [the trial console] (https://console.cloud.tencent.com/asr/demonstrate). For product pricing, see [Billing Overview (Online Version)] (https://intl.cloud.tencent.com/document/product/1093/35686?from_cn_redirect=1)
        /// - Default frequency limit: 20 requests/second. This limit only applies to submitted requests but not the response time.
        /// Response time: The API adopts asynchronous callback and does not return results in real time. Recognition results will be returned within 3 hours at most. ** In most cases, audio with a duration of 1 hour can be recognized in 1 to 3 minutes. ** Note: The response time does not include the audio download time and will not apply to scenarios where recordings with a total audio duration of over 1,000 hours or over 20,000 requests are submitted within 30 minutes.
        /// - Audio formats: WAV, MP3, M4A, FLV, MP4, WMA, 3GP, AMR, AAC, OGG (Opus), and FLAC.
        /// - Supported languages: See the description of ** EngineModelType ** in this document or go to [Product Features] (https://intl.cloud.tencent.com/document/product/1093/35682?from_cn_redirect=1) for details.
        /// - Audio submission method: This API supports ** audio URLs and local audio files **. It is recommended to use [Tencent Cloud COS] (https://intl.cloud.tencent.com/document/product/436/38484?from_cn_redirect=1) to store audio files, generate URLs, and submit requests. This method does not incur public network or downstream traffic fees but can speed up task processing. (Set the public read and private write permissions for COS buckets or URLs to be externally accessible.)
        /// - Audio restrictions: For a single URL, the audio duration cannot exceed 5 hours, and the file size cannot exceed 1 GB. For a local audio file, the file size cannot exceed 5 MB.
        /// - Obtain recognition results: Results can be obtained through ** callback or polling **. See [Result Query] (https://intl.cloud.tencent.com/document/product/1093/37822?from_cn_redirect=1) for details.
        /// - Recognition result retention period: Recognition results are retained on the server for 24 hours.
        /// - For the signature method, see the content related to the signature method v3 in [Public Parameters] (https://intl.cloud.tencent.com/document/api/1093/35640?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateRecTaskRequest"/></param>
        /// <returns><see cref="CreateRecTaskResponse"/></returns>
        public CreateRecTaskResponse CreateRecTaskSync(CreateRecTaskRequest req)
        {
            return InternalRequestAsync<CreateRecTaskResponse>(req, "CreateRecTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The recognition results can be obtained through callback or polling after the recording recognition request API is called.
        /// - ** Note: A task is valid for 24 hours. Do not query the results with tasks that have existed for more than 24 hours or use task ID as the unique business ID because duplicate TaskIds of different dates may exist. **
        /// - For the callback method, the results will be sent by using a POST request to the callback URL specified in the request after the recognition is completed. For more details, see [Callback Description] (https://intl.cloud.tencent.com/document/product/1093/52632?from_cn_redirect=1).
        /// - For the polling method, you need to actively provide the task ID to poll for recognition results. There are four possible results: success, waiting, in progress, and failure. For detailed information, see the content below.
        /// - The request method is HTTP POST, and Content-Type is "application/json; charset=utf-8".
        /// - For the signature method, see the content related to the signature method v3 in [Public Parameters](https://intl.cloud.tencent.com/document/api/1093/35640?from_cn_redirect=1).
        /// - Default request frequency limit: 50 requests/second. If you want to increase the request frequency limit, submit a [ticket](https://console.cloud.tencent.com/workorder/category).
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// The recognition results can be obtained through callback or polling after the recording recognition request API is called.
        /// - ** Note: A task is valid for 24 hours. Do not query the results with tasks that have existed for more than 24 hours or use task ID as the unique business ID because duplicate TaskIds of different dates may exist. **
        /// - For the callback method, the results will be sent by using a POST request to the callback URL specified in the request after the recognition is completed. For more details, see [Callback Description] (https://intl.cloud.tencent.com/document/product/1093/52632?from_cn_redirect=1).
        /// - For the polling method, you need to actively provide the task ID to poll for recognition results. There are four possible results: success, waiting, in progress, and failure. For detailed information, see the content below.
        /// - The request method is HTTP POST, and Content-Type is "application/json; charset=utf-8".
        /// - For the signature method, see the content related to the signature method v3 in [Public Parameters](https://intl.cloud.tencent.com/document/api/1093/35640?from_cn_redirect=1).
        /// - Default request frequency limit: 50 requests/second. If you want to increase the request frequency limit, submit a [ticket](https://console.cloud.tencent.com/workorder/category).
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}