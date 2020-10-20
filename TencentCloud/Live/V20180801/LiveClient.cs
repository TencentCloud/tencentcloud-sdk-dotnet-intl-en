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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LiveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to set the delay time for a stream.
        /// Note: if you want to set delayed playback before pushing, you need to do so 5 minutes in advance.
        /// Currently, this API only supports stream granularity, and the feature supporting domain name and application granularities will be available in the future.
        /// Use case: for important live streams, you can set delayed playback in advance to avoid contingency issues.
        /// </summary>
        /// <param name="req"><see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns><see cref="AddDelayLiveStreamResponse"/></returns>
        public async Task<AddDelayLiveStreamResponse> AddDelayLiveStream(AddDelayLiveStreamRequest req)
        {
             JsonResponseModel<AddDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the delay time for a stream.
        /// Note: if you want to set delayed playback before pushing, you need to do so 5 minutes in advance.
        /// Currently, this API only supports stream granularity, and the feature supporting domain name and application granularities will be available in the future.
        /// Use case: for important live streams, you can set delayed playback in advance to avoid contingency issues.
        /// </summary>
        /// <param name="req"><see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns><see cref="AddDelayLiveStreamResponse"/></returns>
        public AddDelayLiveStreamResponse AddDelayLiveStreamSync(AddDelayLiveStreamRequest req)
        {
             JsonResponseModel<AddDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a domain name. Only one domain name can be submitted at a time, and it must have an ICP filing.
        /// </summary>
        /// <param name="req"><see cref="AddLiveDomainRequest"/></param>
        /// <returns><see cref="AddLiveDomainResponse"/></returns>
        public async Task<AddLiveDomainResponse> AddLiveDomain(AddLiveDomainRequest req)
        {
             JsonResponseModel<AddLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a domain name. Only one domain name can be submitted at a time, and it must have an ICP filing.
        /// </summary>
        /// <param name="req"><see cref="AddLiveDomainRequest"/></param>
        /// <returns><see cref="AddLiveDomainResponse"/></returns>
        public AddLiveDomainResponse AddLiveDomainSync(AddLiveDomainRequest req)
        {
             JsonResponseModel<AddLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a watermark is added and a watermark ID is successfully returned, you need to call the [CreateLiveWatermarkRule](https://intl.cloud.tencent.com/document/product/267/32629?from_cn_redirect=1) API and bind the watermark ID to the stream.
        /// </summary>
        /// <param name="req"><see cref="AddLiveWatermarkRequest"/></param>
        /// <returns><see cref="AddLiveWatermarkResponse"/></returns>
        public async Task<AddLiveWatermarkResponse> AddLiveWatermark(AddLiveWatermarkRequest req)
        {
             JsonResponseModel<AddLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a watermark is added and a watermark ID is successfully returned, you need to call the [CreateLiveWatermarkRule](https://intl.cloud.tencent.com/document/product/267/32629?from_cn_redirect=1) API and bind the watermark ID to the stream.
        /// </summary>
        /// <param name="req"><see cref="AddLiveWatermarkRequest"/></param>
        /// <returns><see cref="AddLiveWatermarkResponse"/></returns>
        public AddLiveWatermarkResponse AddLiveWatermarkSync(AddLiveWatermarkRequest req)
        {
             JsonResponseModel<AddLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a domain name certificate.
        /// Note: you need to call the `CreateLiveCert` API first to add a certificate. After getting the certificate ID, call this API for binding.
        /// </summary>
        /// <param name="req"><see cref="BindLiveDomainCertRequest"/></param>
        /// <returns><see cref="BindLiveDomainCertResponse"/></returns>
        public async Task<BindLiveDomainCertResponse> BindLiveDomainCert(BindLiveDomainCertRequest req)
        {
             JsonResponseModel<BindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a domain name certificate.
        /// Note: you need to call the `CreateLiveCert` API first to add a certificate. After getting the certificate ID, call this API for binding.
        /// </summary>
        /// <param name="req"><see cref="BindLiveDomainCertRequest"/></param>
        /// <returns><see cref="BindLiveDomainCertResponse"/></returns>
        public BindLiveDomainCertResponse BindLiveDomainCertSync(BindLiveDomainCertRequest req)
        {
             JsonResponseModel<BindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a stream mix. It can be used basically in the same way as `mix_streamv2.cancel_mix_stream`.
        /// </summary>
        /// <param name="req"><see cref="CancelCommonMixStreamRequest"/></param>
        /// <returns><see cref="CancelCommonMixStreamResponse"/></returns>
        public async Task<CancelCommonMixStreamResponse> CancelCommonMixStream(CancelCommonMixStreamRequest req)
        {
             JsonResponseModel<CancelCommonMixStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelCommonMixStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCommonMixStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a stream mix. It can be used basically in the same way as `mix_streamv2.cancel_mix_stream`.
        /// </summary>
        /// <param name="req"><see cref="CancelCommonMixStreamRequest"/></param>
        /// <returns><see cref="CancelCommonMixStreamResponse"/></returns>
        public CancelCommonMixStreamResponse CancelCommonMixStreamSync(CancelCommonMixStreamRequest req)
        {
             JsonResponseModel<CancelCommonMixStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelCommonMixStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCommonMixStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a general stream mix. It can be used basically in the same way as the legacy `mix_streamv2.start_mix_stream_advanced` API.
        /// Note: currently, up to 16 streams can be mixed.
        /// Best practice: https://intl.cloud.tencent.com/document/product/267/45566?from_cn_redirect=1
        /// </summary>
        /// <param name="req"><see cref="CreateCommonMixStreamRequest"/></param>
        /// <returns><see cref="CreateCommonMixStreamResponse"/></returns>
        public async Task<CreateCommonMixStreamResponse> CreateCommonMixStream(CreateCommonMixStreamRequest req)
        {
             JsonResponseModel<CreateCommonMixStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCommonMixStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCommonMixStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateCommonMixStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCommonMixStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCommonMixStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a callback rule, you need to first call the [CreateLiveCallbackTemplate](https://intl.cloud.tencent.com/document/product/267/32637?from_cn_redirect=1) API to create a callback template and bind the returned template ID to the domain name/path.
        /// <br>Callback protocol-related document: [Event Message Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackRuleResponse"/></returns>
        public async Task<CreateLiveCallbackRuleResponse> CreateLiveCallbackRule(CreateLiveCallbackRuleRequest req)
        {
             JsonResponseModel<CreateLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a callback rule, you need to first call the [CreateLiveCallbackTemplate](https://intl.cloud.tencent.com/document/product/267/32637?from_cn_redirect=1) API to create a callback template and bind the returned template ID to the domain name/path.
        /// <br>Callback protocol-related document: [Event Message Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackRuleResponse"/></returns>
        public CreateLiveCallbackRuleResponse CreateLiveCallbackRuleSync(CreateLiveCallbackRuleRequest req)
        {
             JsonResponseModel<CreateLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a callback template is created and a template ID is successfully returned, you need to call the [CreateLiveCallbackRule](https://intl.cloud.tencent.com/document/product/267/32638?from_cn_redirect=1) API and bind the template ID to the domain name/path.
        /// <br>Callback protocol document: [Event Message Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// Note: at least enter one callback URL.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackTemplateResponse"/></returns>
        public async Task<CreateLiveCallbackTemplateResponse> CreateLiveCallbackTemplate(CreateLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<CreateLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a callback template is created and a template ID is successfully returned, you need to call the [CreateLiveCallbackRule](https://intl.cloud.tencent.com/document/product/267/32638?from_cn_redirect=1) API and bind the template ID to the domain name/path.
        /// <br>Callback protocol document: [Event Message Notification](https://intl.cloud.tencent.com/document/product/267/32744?from_cn_redirect=1).
        /// Note: at least enter one callback URL.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackTemplateResponse"/></returns>
        public CreateLiveCallbackTemplateResponse CreateLiveCallbackTemplateSync(CreateLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<CreateLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCertRequest"/></param>
        /// <returns><see cref="CreateLiveCertResponse"/></returns>
        public async Task<CreateLiveCertResponse> CreateLiveCert(CreateLiveCertRequest req)
        {
             JsonResponseModel<CreateLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCertRequest"/></param>
        /// <returns><see cref="CreateLiveCertResponse"/></returns>
        public CreateLiveCertResponse CreateLiveCertSync(CreateLiveCertRequest req)
        {
             JsonResponseModel<CreateLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateLiveRecordResponse> CreateLiveRecord(CreateLiveRecordRequest req)
        {
             JsonResponseModel<CreateLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a recording rule, you need to first call the [CreateLiveRecordTemplate](https://intl.cloud.tencent.com/document/product/267/32614?from_cn_redirect=1) API to create a recording template and bind the returned template ID to the stream.
        /// <br>Recording-related document: [LVB Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns><see cref="CreateLiveRecordRuleResponse"/></returns>
        public async Task<CreateLiveRecordRuleResponse> CreateLiveRecordRule(CreateLiveRecordRuleRequest req)
        {
             JsonResponseModel<CreateLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a recording rule, you need to first call the [CreateLiveRecordTemplate](https://intl.cloud.tencent.com/document/product/267/32614?from_cn_redirect=1) API to create a recording template and bind the returned template ID to the stream.
        /// <br>Recording-related document: [LVB Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns><see cref="CreateLiveRecordRuleResponse"/></returns>
        public CreateLiveRecordRuleResponse CreateLiveRecordRuleSync(CreateLiveRecordRuleRequest req)
        {
             JsonResponseModel<CreateLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a recording template is created and a template ID is successfully returned, you need to call the [CreateLiveRecordRule](https://intl.cloud.tencent.com/document/product/267/32615?from_cn_redirect=1) API and bind the template ID to the stream.
        /// <br>Recording-related document: [LVB Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public async Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest req)
        {
             JsonResponseModel<CreateLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a recording template is created and a template ID is successfully returned, you need to call the [CreateLiveRecordRule](https://intl.cloud.tencent.com/document/product/267/32615?from_cn_redirect=1) API and bind the template ID to the stream.
        /// <br>Recording-related document: [LVB Recording](https://intl.cloud.tencent.com/document/product/267/32739?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplateSync(CreateLiveRecordTemplateRequest req)
        {
             JsonResponseModel<CreateLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a screencapturing rule. You need to first call the [CreateLiveSnapshotTemplate](https://intl.cloud.tencent.com/document/product/267/32624?from_cn_redirect=1) API to create a screencapturing template to bind the returned template ID to the stream.
        /// <br>Screencapturing document: [LVB Screencapturing](https://intl.cloud.tencent.com/document/product/267/32737?from_cn_redirect=1).
        /// Note: only one screencapturing template can be associated with one domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotRuleResponse"/></returns>
        public async Task<CreateLiveSnapshotRuleResponse> CreateLiveSnapshotRule(CreateLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a screencapturing template is created and a template ID is successfully returned, you need to call the [CreateLiveSnapshotRule](https://intl.cloud.tencent.com/document/product/267/32625?from_cn_redirect=1) API and bind the template ID to the stream.
        /// <br>Screencapturing-related document: [LVB Screencapturing](https://intl.cloud.tencent.com/document/product/267/32737?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotTemplateResponse"/></returns>
        public async Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplate(CreateLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a screencapturing template is created and a template ID is successfully returned, you need to call the [CreateLiveSnapshotRule](https://intl.cloud.tencent.com/document/product/267/32625?from_cn_redirect=1) API and bind the template ID to the stream.
        /// <br>Screencapturing-related document: [LVB Screencapturing](https://intl.cloud.tencent.com/document/product/267/32737?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotTemplateResponse"/></returns>
        public CreateLiveSnapshotTemplateResponse CreateLiveSnapshotTemplateSync(CreateLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a transcoding rule, you need to first call the [CreateLiveTranscodeTemplate](https://intl.cloud.tencent.com/document/product/267/32646?from_cn_redirect=1) API to create a transcoding template and bind the returned template ID to the stream.
        /// <br>Transcoding-related document: [LVB Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeRuleResponse"/></returns>
        public async Task<CreateLiveTranscodeRuleResponse> CreateLiveTranscodeRule(CreateLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a transcoding rule, you need to first call the [CreateLiveTranscodeTemplate](https://intl.cloud.tencent.com/document/product/267/32646?from_cn_redirect=1) API to create a transcoding template and bind the returned template ID to the stream.
        /// <br>Transcoding-related document: [LVB Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeRuleResponse"/></returns>
        public CreateLiveTranscodeRuleResponse CreateLiveTranscodeRuleSync(CreateLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a transcoding template is created and a template ID is successfully returned, you need to call the [CreateLiveTranscodeRule](https://intl.cloud.tencent.com/document/product/267/32647?from_cn_redirect=1) API and bind the returned template ID to the stream.
        /// <br>Transcoding-related document: [LVB Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeTemplateResponse"/></returns>
        public async Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplate(CreateLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a transcoding template is created and a template ID is successfully returned, you need to call the [CreateLiveTranscodeRule](https://intl.cloud.tencent.com/document/product/267/32647?from_cn_redirect=1) API and bind the returned template ID to the stream.
        /// <br>Transcoding-related document: [LVB Remuxing and Transcoding](https://intl.cloud.tencent.com/document/product/267/32736?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeTemplateResponse"/></returns>
        public CreateLiveTranscodeTemplateResponse CreateLiveTranscodeTemplateSync(CreateLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a watermarking rule, you need to first call the [AddLiveWatermark](https://intl.cloud.tencent.com/document/product/267/30154?from_cn_redirect=1) API to add a watermark and bind the returned watermark ID to the stream.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="CreateLiveWatermarkRuleResponse"/></returns>
        public async Task<CreateLiveWatermarkRuleResponse> CreateLiveWatermarkRule(CreateLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<CreateLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// To create a watermarking rule, you need to first call the [AddLiveWatermark](https://intl.cloud.tencent.com/document/product/267/30154?from_cn_redirect=1) API to add a watermark and bind the returned watermark ID to the stream.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="CreateLiveWatermarkRuleResponse"/></returns>
        public CreateLiveWatermarkRuleResponse CreateLiveWatermarkRuleSync(CreateLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<CreateLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recording task that starts and ends at specified times and records by using the configuration corresponding to a specified recording template ID.
        /// - Prerequisites
        /// 1. Recording files are stored on the VOD platform, so if you need to use the recording feature, you must first activate the VOD service.
        /// 2. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) are charged according to the VOD billing method. For details, see the [corresponding document](https://intl.cloud.tencent.com/document/product/266/2837?from_cn_redirect=1).
        /// - Precautions
        /// 1. An interruption will end the current recording and generate a recording file. The task will still be valid before the end time expires, and the stream will be recorded within this period as long as it is pushed, regardless of whether the push is interrupted or restarted multiple times.
        /// 2. Avoid creating recording tasks with overlapping time periods. If there are multiple tasks with overlapping time periods for the same stream, the system will start three recording tasks at most to avoid repeated recording.
        /// 3. The record of a created recording task will be retained for 3 months on the platform.
        /// 4. The current recording task management APIs (CreateRecordTask/StopRecordTask/DeleteRecordTask) are not compatible with the legacy APIs (CreateLiveRecord/StopLiveRecord/DeleteLiveRecord), and they cannot be used together.
        /// 5. Do not create recording tasks and push streams at the same time, or recording tasks might not take effect and be delayed. Wait at least 3 seconds between each action.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordTaskRequest"/></param>
        /// <returns><see cref="CreateRecordTaskResponse"/></returns>
        public async Task<CreateRecordTaskResponse> CreateRecordTask(CreateRecordTaskRequest req)
        {
             JsonResponseModel<CreateRecordTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecordTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recording task that starts and ends at specified times and records by using the configuration corresponding to a specified recording template ID.
        /// - Prerequisites
        /// 1. Recording files are stored on the VOD platform, so if you need to use the recording feature, you must first activate the VOD service.
        /// 2. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) are charged according to the VOD billing method. For details, see the [corresponding document](https://intl.cloud.tencent.com/document/product/266/2837?from_cn_redirect=1).
        /// - Precautions
        /// 1. An interruption will end the current recording and generate a recording file. The task will still be valid before the end time expires, and the stream will be recorded within this period as long as it is pushed, regardless of whether the push is interrupted or restarted multiple times.
        /// 2. Avoid creating recording tasks with overlapping time periods. If there are multiple tasks with overlapping time periods for the same stream, the system will start three recording tasks at most to avoid repeated recording.
        /// 3. The record of a created recording task will be retained for 3 months on the platform.
        /// 4. The current recording task management APIs (CreateRecordTask/StopRecordTask/DeleteRecordTask) are not compatible with the legacy APIs (CreateLiveRecord/StopLiveRecord/DeleteLiveRecord), and they cannot be used together.
        /// 5. Do not create recording tasks and push streams at the same time, or recording tasks might not take effect and be delayed. Wait at least 3 seconds between each action.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordTaskRequest"/></param>
        /// <returns><see cref="CreateRecordTaskResponse"/></returns>
        public CreateRecordTaskResponse CreateRecordTaskSync(CreateRecordTaskRequest req)
        {
             JsonResponseModel<CreateRecordTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecordTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a callback rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackRuleResponse"/></returns>
        public async Task<DeleteLiveCallbackRuleResponse> DeleteLiveCallbackRule(DeleteLiveCallbackRuleRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a callback rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackRuleResponse"/></returns>
        public DeleteLiveCallbackRuleResponse DeleteLiveCallbackRuleSync(DeleteLiveCallbackRuleRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API deletes a callback template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackTemplateResponse"/></returns>
        public async Task<DeleteLiveCallbackTemplateResponse> DeleteLiveCallbackTemplate(DeleteLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API deletes a callback template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackTemplateResponse"/></returns>
        public DeleteLiveCallbackTemplateResponse DeleteLiveCallbackTemplateSync(DeleteLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a certificate corresponding to the domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCertRequest"/></param>
        /// <returns><see cref="DeleteLiveCertResponse"/></returns>
        public async Task<DeleteLiveCertResponse> DeleteLiveCert(DeleteLiveCertRequest req)
        {
             JsonResponseModel<DeleteLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a certificate corresponding to the domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCertRequest"/></param>
        /// <returns><see cref="DeleteLiveCertResponse"/></returns>
        public DeleteLiveCertResponse DeleteLiveCertSync(DeleteLiveCertRequest req)
        {
             JsonResponseModel<DeleteLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an added LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveDomainRequest"/></param>
        /// <returns><see cref="DeleteLiveDomainResponse"/></returns>
        public async Task<DeleteLiveDomainResponse> DeleteLiveDomain(DeleteLiveDomainRequest req)
        {
             JsonResponseModel<DeleteLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an added LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveDomainRequest"/></param>
        /// <returns><see cref="DeleteLiveDomainResponse"/></returns>
        public DeleteLiveDomainResponse DeleteLiveDomainSync(DeleteLiveDomainRequest req)
        {
             JsonResponseModel<DeleteLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Note: The `DeleteLiveRecord` API is only used to delete the record of recording tasks but not stop recording or deleting an ongoing recording task. If you need to stop a recording task, please use the [StopLiveRecord](https://intl.cloud.tencent.com/document/product/267/30146?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordResponse"/></returns>
        public async Task<DeleteLiveRecordResponse> DeleteLiveRecord(DeleteLiveRecordRequest req)
        {
             JsonResponseModel<DeleteLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Note: The `DeleteLiveRecord` API is only used to delete the record of recording tasks but not stop recording or deleting an ongoing recording task. If you need to stop a recording task, please use the [StopLiveRecord](https://intl.cloud.tencent.com/document/product/267/30146?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordResponse"/></returns>
        public DeleteLiveRecordResponse DeleteLiveRecordSync(DeleteLiveRecordRequest req)
        {
             JsonResponseModel<DeleteLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordRuleResponse"/></returns>
        public async Task<DeleteLiveRecordRuleResponse> DeleteLiveRecordRule(DeleteLiveRecordRuleRequest req)
        {
             JsonResponseModel<DeleteLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordRuleResponse"/></returns>
        public DeleteLiveRecordRuleResponse DeleteLiveRecordRuleSync(DeleteLiveRecordRuleRequest req)
        {
             JsonResponseModel<DeleteLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public async Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplateSync(DeleteLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a screencapturing rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotRuleResponse"/></returns>
        public async Task<DeleteLiveSnapshotRuleResponse> DeleteLiveSnapshotRule(DeleteLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a screencapturing rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotRuleResponse"/></returns>
        public DeleteLiveSnapshotRuleResponse DeleteLiveSnapshotRuleSync(DeleteLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotTemplateResponse"/></returns>
        public async Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplate(DeleteLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotTemplateResponse"/></returns>
        public DeleteLiveSnapshotTemplateResponse DeleteLiveSnapshotTemplateSync(DeleteLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a transcoding rule.
        /// `DomainName+AppName+StreamName+TemplateId` uniquely identifies a single transcoding rule. If you need to delete it, strong match is required. `TemplateId` is required. Even if other parameters are empty, you still need to pass in an empty string to make a strong match.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeRuleResponse"/></returns>
        public async Task<DeleteLiveTranscodeRuleResponse> DeleteLiveTranscodeRule(DeleteLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a transcoding rule.
        /// `DomainName+AppName+StreamName+TemplateId` uniquely identifies a single transcoding rule. If you need to delete it, strong match is required. `TemplateId` is required. Even if other parameters are empty, you still need to pass in an empty string to make a strong match.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeRuleResponse"/></returns>
        public DeleteLiveTranscodeRuleResponse DeleteLiveTranscodeRuleSync(DeleteLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeTemplateResponse"/></returns>
        public async Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplate(DeleteLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeTemplateResponse"/></returns>
        public DeleteLiveTranscodeTemplateResponse DeleteLiveTranscodeTemplateSync(DeleteLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkResponse"/></returns>
        public async Task<DeleteLiveWatermarkResponse> DeleteLiveWatermark(DeleteLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkResponse"/></returns>
        public DeleteLiveWatermarkResponse DeleteLiveWatermarkSync(DeleteLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a watermarking rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkRuleResponse"/></returns>
        public async Task<DeleteLiveWatermarkRuleResponse> DeleteLiveWatermarkRule(DeleteLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a watermarking rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkRuleResponse"/></returns>
        public DeleteLiveWatermarkRuleResponse DeleteLiveWatermarkRuleSync(DeleteLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording task configuration. The deletion does not affect running tasks and takes effect only for new pushes.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordTaskResponse"/></returns>
        public async Task<DeleteRecordTaskResponse> DeleteRecordTask(DeleteRecordTaskRequest req)
        {
             JsonResponseModel<DeleteRecordTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording task configuration. The deletion does not affect running tasks and takes effect only for new pushes.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordTaskResponse"/></returns>
        public DeleteRecordTaskResponse DeleteRecordTaskSync(DeleteRecordTaskRequest req)
        {
             JsonResponseModel<DeleteRecordTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the downstream information of all streams at a specified point in time (at a 1-minute granularity).
        /// </summary>
        /// <param name="req"><see cref="DescribeAllStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeAllStreamPlayInfoListResponse"/></returns>
        public async Task<DescribeAllStreamPlayInfoListResponse> DescribeAllStreamPlayInfoList(DescribeAllStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeAllStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the downstream information of all streams at a specified point in time (at a 1-minute granularity).
        /// </summary>
        /// <param name="req"><see cref="DescribeAllStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeAllStreamPlayInfoListResponse"/></returns>
        public DescribeAllStreamPlayInfoListResponse DescribeAllStreamPlayInfoListSync(DescribeAllStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeAllStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the billable LVB bandwidth and traffic data outside Chinese mainland.
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeAreaBillBandwidthAndFluxListResponse"/></returns>
        public async Task<DescribeAreaBillBandwidthAndFluxListResponse> DescribeAreaBillBandwidthAndFluxList(DescribeAreaBillBandwidthAndFluxListRequest req)
        {
             JsonResponseModel<DescribeAreaBillBandwidthAndFluxListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAreaBillBandwidthAndFluxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAreaBillBandwidthAndFluxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the billable LVB bandwidth and traffic data outside Chinese mainland.
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeAreaBillBandwidthAndFluxListResponse"/></returns>
        public DescribeAreaBillBandwidthAndFluxListResponse DescribeAreaBillBandwidthAndFluxListSync(DescribeAreaBillBandwidthAndFluxListRequest req)
        {
             JsonResponseModel<DescribeAreaBillBandwidthAndFluxListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAreaBillBandwidthAndFluxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAreaBillBandwidthAndFluxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the data of billable LVB bandwidth and traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeBillBandwidthAndFluxListResponse"/></returns>
        public async Task<DescribeBillBandwidthAndFluxListResponse> DescribeBillBandwidthAndFluxList(DescribeBillBandwidthAndFluxListRequest req)
        {
             JsonResponseModel<DescribeBillBandwidthAndFluxListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillBandwidthAndFluxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillBandwidthAndFluxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the data of billable LVB bandwidth and traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeBillBandwidthAndFluxListResponse"/></returns>
        public DescribeBillBandwidthAndFluxListResponse DescribeBillBandwidthAndFluxListSync(DescribeBillBandwidthAndFluxListRequest req)
        {
             JsonResponseModel<DescribeBillBandwidthAndFluxListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillBandwidthAndFluxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillBandwidthAndFluxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the number of concurrent recording channels, which is applicable to LCB and LVB.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentRecordStreamNumRequest"/></param>
        /// <returns><see cref="DescribeConcurrentRecordStreamNumResponse"/></returns>
        public async Task<DescribeConcurrentRecordStreamNumResponse> DescribeConcurrentRecordStreamNum(DescribeConcurrentRecordStreamNumRequest req)
        {
             JsonResponseModel<DescribeConcurrentRecordStreamNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConcurrentRecordStreamNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConcurrentRecordStreamNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the number of concurrent recording channels, which is applicable to LCB and LVB.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentRecordStreamNumRequest"/></param>
        /// <returns><see cref="DescribeConcurrentRecordStreamNumResponse"/></returns>
        public DescribeConcurrentRecordStreamNumResponse DescribeConcurrentRecordStreamNumSync(DescribeConcurrentRecordStreamNumRequest req)
        {
             JsonResponseModel<DescribeConcurrentRecordStreamNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConcurrentRecordStreamNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConcurrentRecordStreamNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the billable bandwidth of live stream relaying in the last 3 months. The query period is up to 31 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverBandwidthListRequest"/></param>
        /// <returns><see cref="DescribeDeliverBandwidthListResponse"/></returns>
        public async Task<DescribeDeliverBandwidthListResponse> DescribeDeliverBandwidthList(DescribeDeliverBandwidthListRequest req)
        {
             JsonResponseModel<DescribeDeliverBandwidthListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeliverBandwidthList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeliverBandwidthListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the billable bandwidth of live stream relaying in the last 3 months. The query period is up to 31 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverBandwidthListRequest"/></param>
        /// <returns><see cref="DescribeDeliverBandwidthListResponse"/></returns>
        public DescribeDeliverBandwidthListResponse DescribeDeliverBandwidthListSync(DescribeDeliverBandwidthListRequest req)
        {
             JsonResponseModel<DescribeDeliverBandwidthListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeliverBandwidthList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeliverBandwidthListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the downstream playback data by district and ISP.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeGroupProIspPlayInfoListResponse"/></returns>
        public async Task<DescribeGroupProIspPlayInfoListResponse> DescribeGroupProIspPlayInfoList(DescribeGroupProIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeGroupProIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupProIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupProIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the downstream playback data by district and ISP.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeGroupProIspPlayInfoListResponse"/></returns>
        public DescribeGroupProIspPlayInfoListResponse DescribeGroupProIspPlayInfoListSync(DescribeGroupProIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeGroupProIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupProIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupProIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the number of each playback HTTP status code at a 5-minute granularity in a certain period of time.
        /// Note: data can be queried one hour after it is generated. For example, data between 10:00 and 10:59 cannot be queried until 12:00.
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns><see cref="DescribeHttpStatusInfoListResponse"/></returns>
        public async Task<DescribeHttpStatusInfoListResponse> DescribeHttpStatusInfoList(DescribeHttpStatusInfoListRequest req)
        {
             JsonResponseModel<DescribeHttpStatusInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHttpStatusInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHttpStatusInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the number of each playback HTTP status code at a 5-minute granularity in a certain period of time.
        /// Note: data can be queried one hour after it is generated. For example, data between 10:00 and 10:59 cannot be queried until 12:00.
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns><see cref="DescribeHttpStatusInfoListResponse"/></returns>
        public DescribeHttpStatusInfoListResponse DescribeHttpStatusInfoListSync(DescribeHttpStatusInfoListRequest req)
        {
             JsonResponseModel<DescribeHttpStatusInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHttpStatusInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHttpStatusInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the callback rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackRulesResponse"/></returns>
        public async Task<DescribeLiveCallbackRulesResponse> DescribeLiveCallbackRules(DescribeLiveCallbackRulesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the callback rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackRulesResponse"/></returns>
        public DescribeLiveCallbackRulesResponse DescribeLiveCallbackRulesSync(DescribeLiveCallbackRulesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCallbackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single callback template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplateResponse"/></returns>
        public async Task<DescribeLiveCallbackTemplateResponse> DescribeLiveCallbackTemplate(DescribeLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single callback template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplateResponse"/></returns>
        public DescribeLiveCallbackTemplateResponse DescribeLiveCallbackTemplateSync(DescribeLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the callback template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplatesResponse"/></returns>
        public async Task<DescribeLiveCallbackTemplatesResponse> DescribeLiveCallbackTemplates(DescribeLiveCallbackTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the callback template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplatesResponse"/></returns>
        public DescribeLiveCallbackTemplatesResponse DescribeLiveCallbackTemplatesSync(DescribeLiveCallbackTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCallbackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertRequest"/></param>
        /// <returns><see cref="DescribeLiveCertResponse"/></returns>
        public async Task<DescribeLiveCertResponse> DescribeLiveCert(DescribeLiveCertRequest req)
        {
             JsonResponseModel<DescribeLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertRequest"/></param>
        /// <returns><see cref="DescribeLiveCertResponse"/></returns>
        public DescribeLiveCertResponse DescribeLiveCertSync(DescribeLiveCertRequest req)
        {
             JsonResponseModel<DescribeLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the certificate information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertsRequest"/></param>
        /// <returns><see cref="DescribeLiveCertsResponse"/></returns>
        public async Task<DescribeLiveCertsResponse> DescribeLiveCerts(DescribeLiveCertsRequest req)
        {
             JsonResponseModel<DescribeLiveCertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the certificate information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertsRequest"/></param>
        /// <returns><see cref="DescribeLiveCertsResponse"/></returns>
        public DescribeLiveCertsResponse DescribeLiveCertsSync(DescribeLiveCertsRequest req)
        {
             JsonResponseModel<DescribeLiveCertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of delayed playbacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDelayInfoListResponse"/></returns>
        public async Task<DescribeLiveDelayInfoListResponse> DescribeLiveDelayInfoList(DescribeLiveDelayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDelayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDelayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDelayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of delayed playbacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDelayInfoListResponse"/></returns>
        public DescribeLiveDelayInfoListResponse DescribeLiveDelayInfoListSync(DescribeLiveDelayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDelayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDelayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDelayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the LVB domain name information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainResponse"/></returns>
        public async Task<DescribeLiveDomainResponse> DescribeLiveDomain(DescribeLiveDomainRequest req)
        {
             JsonResponseModel<DescribeLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the LVB domain name information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainResponse"/></returns>
        public DescribeLiveDomainResponse DescribeLiveDomainSync(DescribeLiveDomainRequest req)
        {
             JsonResponseModel<DescribeLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the domain name certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertResponse"/></returns>
        public async Task<DescribeLiveDomainCertResponse> DescribeLiveDomainCert(DescribeLiveDomainCertRequest req)
        {
             JsonResponseModel<DescribeLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the domain name certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertResponse"/></returns>
        public DescribeLiveDomainCertResponse DescribeLiveDomainCertSync(DescribeLiveDomainCertRequest req)
        {
             JsonResponseModel<DescribeLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time downstream playback data at the domain name level. As it takes certain time to process data, the API queries quasi-real-time data generated 4 minutes ago by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainPlayInfoListResponse"/></returns>
        public async Task<DescribeLiveDomainPlayInfoListResponse> DescribeLiveDomainPlayInfoList(DescribeLiveDomainPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDomainPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomainPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time downstream playback data at the domain name level. As it takes certain time to process data, the API queries quasi-real-time data generated 4 minutes ago by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainPlayInfoListResponse"/></returns>
        public DescribeLiveDomainPlayInfoListResponse DescribeLiveDomainPlayInfoListSync(DescribeLiveDomainPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDomainPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomainPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query domain names by domain name status and type.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainsResponse"/></returns>
        public async Task<DescribeLiveDomainsResponse> DescribeLiveDomains(DescribeLiveDomainsRequest req)
        {
             JsonResponseModel<DescribeLiveDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query domain names by domain name status and type.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainsResponse"/></returns>
        public DescribeLiveDomainsResponse DescribeLiveDomainsSync(DescribeLiveDomainsRequest req)
        {
             JsonResponseModel<DescribeLiveDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the forbidden stream list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns><see cref="DescribeLiveForbidStreamListResponse"/></returns>
        public async Task<DescribeLiveForbidStreamListResponse> DescribeLiveForbidStreamList(DescribeLiveForbidStreamListRequest req)
        {
             JsonResponseModel<DescribeLiveForbidStreamListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveForbidStreamList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveForbidStreamListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the forbidden stream list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns><see cref="DescribeLiveForbidStreamListResponse"/></returns>
        public DescribeLiveForbidStreamListResponse DescribeLiveForbidStreamListSync(DescribeLiveForbidStreamListRequest req)
        {
             JsonResponseModel<DescribeLiveForbidStreamListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveForbidStreamList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveForbidStreamListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePlayAuthKeyResponse"/></returns>
        public async Task<DescribeLivePlayAuthKeyResponse> DescribeLivePlayAuthKey(DescribeLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePlayAuthKeyResponse"/></returns>
        public DescribeLivePlayAuthKeyResponse DescribeLivePlayAuthKeySync(DescribeLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePushAuthKeyResponse"/></returns>
        public async Task<DescribeLivePushAuthKeyResponse> DescribeLivePushAuthKey(DescribeLivePushAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePushAuthKeyResponse"/></returns>
        public DescribeLivePushAuthKeyResponse DescribeLivePushAuthKeySync(DescribeLivePushAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordRulesResponse"/></returns>
        public async Task<DescribeLiveRecordRulesResponse> DescribeLiveRecordRules(DescribeLiveRecordRulesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordRulesResponse"/></returns>
        public DescribeLiveRecordRulesResponse DescribeLiveRecordRulesSync(DescribeLiveRecordRulesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single recording template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplateResponse"/></returns>
        public async Task<DescribeLiveRecordTemplateResponse> DescribeLiveRecordTemplate(DescribeLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single recording template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplateResponse"/></returns>
        public DescribeLiveRecordTemplateResponse DescribeLiveRecordTemplateSync(DescribeLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the recording template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public async Task<DescribeLiveRecordTemplatesResponse> DescribeLiveRecordTemplates(DescribeLiveRecordTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the recording template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public DescribeLiveRecordTemplatesResponse DescribeLiveRecordTemplatesSync(DescribeLiveRecordTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the screencapturing rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotRulesResponse"/></returns>
        public async Task<DescribeLiveSnapshotRulesResponse> DescribeLiveSnapshotRules(DescribeLiveSnapshotRulesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the screencapturing rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotRulesResponse"/></returns>
        public DescribeLiveSnapshotRulesResponse DescribeLiveSnapshotRulesSync(DescribeLiveSnapshotRulesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveSnapshotRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplateResponse"/></returns>
        public async Task<DescribeLiveSnapshotTemplateResponse> DescribeLiveSnapshotTemplate(DescribeLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplateResponse"/></returns>
        public DescribeLiveSnapshotTemplateResponse DescribeLiveSnapshotTemplateSync(DescribeLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the screencapturing template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplatesResponse"/></returns>
        public async Task<DescribeLiveSnapshotTemplatesResponse> DescribeLiveSnapshotTemplates(DescribeLiveSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the screencapturing template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplatesResponse"/></returns>
        public DescribeLiveSnapshotTemplatesResponse DescribeLiveSnapshotTemplatesSync(DescribeLiveSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query streaming events.<br>
        /// 
        /// Note: This API can filter by IsFilter and return the push history.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamEventListResponse"/></returns>
        public async Task<DescribeLiveStreamEventListResponse> DescribeLiveStreamEventList(DescribeLiveStreamEventListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query streaming events.<br>
        /// 
        /// Note: This API can filter by IsFilter and return the push history.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamEventListResponse"/></returns>
        public DescribeLiveStreamEventListResponse DescribeLiveStreamEventListSync(DescribeLiveStreamEventListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return a list of live streams. It queries the information of live streams after they are pushed successfully.
        /// Note: this API can query up to 20,000 streams. If you want to query more than 20,000 streams, please contact after-sales service.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamOnlineListResponse"/></returns>
        public async Task<DescribeLiveStreamOnlineListResponse> DescribeLiveStreamOnlineList(DescribeLiveStreamOnlineListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamOnlineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return a list of live streams. It queries the information of live streams after they are pushed successfully.
        /// Note: this API can query up to 20,000 streams. If you want to query more than 20,000 streams, please contact after-sales service.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamOnlineListResponse"/></returns>
        public DescribeLiveStreamOnlineListResponse DescribeLiveStreamOnlineListSync(DescribeLiveStreamOnlineListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamOnlineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of pushed streams. <br>
        /// Note: Up to 10,000 entries can be queried per page. More data can be obtained by adjusting the query time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPublishedListResponse"/></returns>
        public async Task<DescribeLiveStreamPublishedListResponse> DescribeLiveStreamPublishedList(DescribeLiveStreamPublishedListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPublishedListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamPublishedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPublishedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the list of pushed streams. <br>
        /// Note: Up to 10,000 entries can be queried per page. More data can be obtained by adjusting the query time range.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPublishedListResponse"/></returns>
        public DescribeLiveStreamPublishedListResponse DescribeLiveStreamPublishedListSync(DescribeLiveStreamPublishedListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPublishedListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamPublishedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPublishedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the push information of all real-time streams, including client IP, server IP, frame rate, bitrate, domain name, and push start time.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPushInfoListResponse"/></returns>
        public async Task<DescribeLiveStreamPushInfoListResponse> DescribeLiveStreamPushInfoList(DescribeLiveStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the push information of all real-time streams, including client IP, server IP, frame rate, bitrate, domain name, and push start time.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPushInfoListResponse"/></returns>
        public DescribeLiveStreamPushInfoListResponse DescribeLiveStreamPushInfoListSync(DescribeLiveStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the stream status such as active, inactive, or forbidden.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamStateResponse"/></returns>
        public async Task<DescribeLiveStreamStateResponse> DescribeLiveStreamState(DescribeLiveStreamStateRequest req)
        {
             JsonResponseModel<DescribeLiveStreamStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the stream status such as active, inactive, or forbidden.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamStateResponse"/></returns>
        public DescribeLiveStreamStateResponse DescribeLiveStreamStateSync(DescribeLiveStreamStateRequest req)
        {
             JsonResponseModel<DescribeLiveStreamStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of transcoding on a specified day or in a specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeDetailInfoResponse"/></returns>
        public async Task<DescribeLiveTranscodeDetailInfoResponse> DescribeLiveTranscodeDetailInfo(DescribeLiveTranscodeDetailInfoRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of transcoding on a specified day or in a specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeDetailInfoResponse"/></returns>
        public DescribeLiveTranscodeDetailInfoResponse DescribeLiveTranscodeDetailInfoSync(DescribeLiveTranscodeDetailInfoRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of transcoding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeRulesResponse"/></returns>
        public async Task<DescribeLiveTranscodeRulesResponse> DescribeLiveTranscodeRules(DescribeLiveTranscodeRulesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of transcoding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeRulesResponse"/></returns>
        public DescribeLiveTranscodeRulesResponse DescribeLiveTranscodeRulesSync(DescribeLiveTranscodeRulesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplateResponse"/></returns>
        public async Task<DescribeLiveTranscodeTemplateResponse> DescribeLiveTranscodeTemplate(DescribeLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a single transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplateResponse"/></returns>
        public DescribeLiveTranscodeTemplateResponse DescribeLiveTranscodeTemplateSync(DescribeLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the transcoding template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplatesResponse"/></returns>
        public async Task<DescribeLiveTranscodeTemplatesResponse> DescribeLiveTranscodeTemplates(DescribeLiveTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the transcoding template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplatesResponse"/></returns>
        public DescribeLiveTranscodeTemplatesResponse DescribeLiveTranscodeTemplatesSync(DescribeLiveTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a single watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkResponse"/></returns>
        public async Task<DescribeLiveWatermarkResponse> DescribeLiveWatermark(DescribeLiveWatermarkRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a single watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkResponse"/></returns>
        public DescribeLiveWatermarkResponse DescribeLiveWatermarkSync(DescribeLiveWatermarkRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the watermarking rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkRulesResponse"/></returns>
        public async Task<DescribeLiveWatermarkRulesResponse> DescribeLiveWatermarkRules(DescribeLiveWatermarkRulesRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermarkRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the watermarking rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkRulesResponse"/></returns>
        public DescribeLiveWatermarkRulesResponse DescribeLiveWatermarkRulesSync(DescribeLiveWatermarkRulesRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveWatermarkRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the watermark list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarksResponse"/></returns>
        public async Task<DescribeLiveWatermarksResponse> DescribeLiveWatermarks(DescribeLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the watermark list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarksResponse"/></returns>
        public DescribeLiveWatermarksResponse DescribeLiveWatermarksSync(DescribeLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes, i.e., the occurrences of each HTTP error code (4xx and 5xx) at a 1-minute granularity in a certain period of time.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeDetailInfoListResponse"/></returns>
        public async Task<DescribePlayErrorCodeDetailInfoListResponse> DescribePlayErrorCodeDetailInfoList(DescribePlayErrorCodeDetailInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlayErrorCodeDetailInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes, i.e., the occurrences of each HTTP error code (4xx and 5xx) at a 1-minute granularity in a certain period of time.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeDetailInfoListResponse"/></returns>
        public DescribePlayErrorCodeDetailInfoListResponse DescribePlayErrorCodeDetailInfoListSync(DescribePlayErrorCodeDetailInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlayErrorCodeDetailInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeSumInfoListResponse"/></returns>
        public async Task<DescribePlayErrorCodeSumInfoListResponse> DescribePlayErrorCodeSumInfoList(DescribePlayErrorCodeSumInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlayErrorCodeSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of downstream playback error codes.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeSumInfoListResponse"/></returns>
        public DescribePlayErrorCodeSumInfoListResponse DescribePlayErrorCodeSumInfoListSync(DescribePlayErrorCodeSumInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlayErrorCodeSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the average traffic per second, total traffic, and number of total requests by country/region, district, and ISP in a certain period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeProIspPlaySumInfoListRequest"/></param>
        /// <returns><see cref="DescribeProIspPlaySumInfoListResponse"/></returns>
        public async Task<DescribeProIspPlaySumInfoListResponse> DescribeProIspPlaySumInfoList(DescribeProIspPlaySumInfoListRequest req)
        {
             JsonResponseModel<DescribeProIspPlaySumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProIspPlaySumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProIspPlaySumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the average traffic per second, total traffic, and number of total requests by country/region, district, and ISP in a certain period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeProIspPlaySumInfoListRequest"/></param>
        /// <returns><see cref="DescribeProIspPlaySumInfoListResponse"/></returns>
        public DescribeProIspPlaySumInfoListResponse DescribeProIspPlaySumInfoListSync(DescribeProIspPlaySumInfoListRequest req)
        {
             JsonResponseModel<DescribeProIspPlaySumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProIspPlaySumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProIspPlaySumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the downstream playback data of a specified ISP in a specified district, including bandwidth, traffic, number of requests, and number of concurrent connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeProvinceIspPlayInfoListResponse"/></returns>
        public async Task<DescribeProvinceIspPlayInfoListResponse> DescribeProvinceIspPlayInfoList(DescribeProvinceIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeProvinceIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProvinceIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProvinceIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the downstream playback data of a specified ISP in a specified district, including bandwidth, traffic, number of requests, and number of concurrent connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeProvinceIspPlayInfoListResponse"/></returns>
        public DescribeProvinceIspPlayInfoListResponse DescribeProvinceIspPlayInfoListSync(DescribeProvinceIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeProvinceIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProvinceIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProvinceIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The API is used to query the number of screenshots as an LVB value-added service.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenShotSheetNumListRequest"/></param>
        /// <returns><see cref="DescribeScreenShotSheetNumListResponse"/></returns>
        public async Task<DescribeScreenShotSheetNumListResponse> DescribeScreenShotSheetNumList(DescribeScreenShotSheetNumListRequest req)
        {
             JsonResponseModel<DescribeScreenShotSheetNumListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenShotSheetNumList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenShotSheetNumListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The API is used to query the number of screenshots as an LVB value-added service.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenShotSheetNumListRequest"/></param>
        /// <returns><see cref="DescribeScreenShotSheetNumListResponse"/></returns>
        public DescribeScreenShotSheetNumListResponse DescribeScreenShotSheetNumListSync(DescribeScreenShotSheetNumListRequest req)
        {
             JsonResponseModel<DescribeScreenShotSheetNumListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenShotSheetNumList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenShotSheetNumListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback data of each stream at the day level, including the total traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamDayPlayInfoListResponse"/></returns>
        public async Task<DescribeStreamDayPlayInfoListResponse> DescribeStreamDayPlayInfoList(DescribeStreamDayPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamDayPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamDayPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamDayPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback data of each stream at the day level, including the total traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamDayPlayInfoListResponse"/></returns>
        public DescribeStreamDayPlayInfoListResponse DescribeStreamDayPlayInfoListSync(DescribeStreamDayPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamDayPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamDayPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamDayPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback data. It supports querying the playback details by stream name and aggregated data by playback domain name. Data in the last 4 minutes or so cannot be queried due to delay.
        /// Note: to query by `AppName`, you need to submit a ticket first. After your application succeeds, it will take about 5 business days (subject to the time in the reply) for the configuration to take effect.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public async Task<DescribeStreamPlayInfoListResponse> DescribeStreamPlayInfoList(DescribeStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback data. It supports querying the playback details by stream name and aggregated data by playback domain name. Data in the last 4 minutes or so cannot be queried due to delay.
        /// Note: to query by `AppName`, you need to submit a ticket first. After your application succeeds, it will take about 5 business days (subject to the time in the reply) for the configuration to take effect.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public DescribeStreamPlayInfoListResponse DescribeStreamPlayInfoListSync(DescribeStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the upstream push quality data by stream ID, including frame rate, bitrate, elapsed time, and codec of audio and video files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPushInfoListResponse"/></returns>
        public async Task<DescribeStreamPushInfoListResponse> DescribeStreamPushInfoList(DescribeStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the upstream push quality data by stream ID, including frame rate, bitrate, elapsed time, and codec of audio and video files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPushInfoListResponse"/></returns>
        public DescribeStreamPushInfoListResponse DescribeStreamPushInfoListSync(DescribeStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of the top n client IPs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeTopClientIpSumInfoListResponse"/></returns>
        public async Task<DescribeTopClientIpSumInfoListResponse> DescribeTopClientIpSumInfoList(DescribeTopClientIpSumInfoListRequest req)
        {
             JsonResponseModel<DescribeTopClientIpSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopClientIpSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopClientIpSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of the top n client IPs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeTopClientIpSumInfoListResponse"/></returns>
        public DescribeTopClientIpSumInfoListResponse DescribeTopClientIpSumInfoListSync(DescribeTopClientIpSumInfoListRequest req)
        {
             JsonResponseModel<DescribeTopClientIpSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopClientIpSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopClientIpSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of the top n domain names or stream IDs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeVisitTopSumInfoListResponse"/></returns>
        public async Task<DescribeVisitTopSumInfoListResponse> DescribeVisitTopSumInfoList(DescribeVisitTopSumInfoListRequest req)
        {
             JsonResponseModel<DescribeVisitTopSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVisitTopSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVisitTopSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of the top n domain names or stream IDs in a certain period of time (top 1,000 is supported currently).
        /// </summary>
        /// <param name="req"><see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeVisitTopSumInfoListResponse"/></returns>
        public DescribeVisitTopSumInfoListResponse DescribeVisitTopSumInfoListSync(DescribeVisitTopSumInfoListRequest req)
        {
             JsonResponseModel<DescribeVisitTopSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVisitTopSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVisitTopSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disconnect the push connection, which can be resumed.
        /// </summary>
        /// <param name="req"><see cref="DropLiveStreamRequest"/></param>
        /// <returns><see cref="DropLiveStreamResponse"/></returns>
        public async Task<DropLiveStreamResponse> DropLiveStream(DropLiveStreamRequest req)
        {
             JsonResponseModel<DropLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DropLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disconnect the push connection, which can be resumed.
        /// </summary>
        /// <param name="req"><see cref="DropLiveStreamRequest"/></param>
        /// <returns><see cref="DropLiveStreamResponse"/></returns>
        public DropLiveStreamResponse DropLiveStreamSync(DropLiveStreamRequest req)
        {
             JsonResponseModel<DropLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DropLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a disabled LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="EnableLiveDomainRequest"/></param>
        /// <returns><see cref="EnableLiveDomainResponse"/></returns>
        public async Task<EnableLiveDomainResponse> EnableLiveDomain(EnableLiveDomainRequest req)
        {
             JsonResponseModel<EnableLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a disabled LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="EnableLiveDomainRequest"/></param>
        /// <returns><see cref="EnableLiveDomainResponse"/></returns>
        public EnableLiveDomainResponse EnableLiveDomainSync(EnableLiveDomainRequest req)
        {
             JsonResponseModel<EnableLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveDomainRequest"/></param>
        /// <returns><see cref="ForbidLiveDomainResponse"/></returns>
        public async Task<ForbidLiveDomainResponse> ForbidLiveDomain(ForbidLiveDomainRequest req)
        {
             JsonResponseModel<ForbidLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an LVB domain name.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveDomainRequest"/></param>
        /// <returns><see cref="ForbidLiveDomainResponse"/></returns>
        public ForbidLiveDomainResponse ForbidLiveDomainSync(ForbidLiveDomainRequest req)
        {
             JsonResponseModel<ForbidLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForbidLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to forbid the push of a specific stream. You can preset a time point to resume the stream.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public async Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to forbid the push of a specific stream. You can preset a time point to resume the stream.
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public ForbidLiveStreamResponse ForbidLiveStreamSync(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a callback template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveCallbackTemplateResponse"/></returns>
        public async Task<ModifyLiveCallbackTemplateResponse> ModifyLiveCallbackTemplate(ModifyLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a callback template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveCallbackTemplateResponse"/></returns>
        public ModifyLiveCallbackTemplateResponse ModifyLiveCallbackTemplateSync(ModifyLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCertRequest"/></param>
        /// <returns><see cref="ModifyLiveCertResponse"/></returns>
        public async Task<ModifyLiveCertResponse> ModifyLiveCert(ModifyLiveCertRequest req)
        {
             JsonResponseModel<ModifyLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCertRequest"/></param>
        /// <returns><see cref="ModifyLiveCertResponse"/></returns>
        public ModifyLiveCertResponse ModifyLiveCertSync(ModifyLiveCertRequest req)
        {
             JsonResponseModel<ModifyLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the domain name and certificate binding information.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainCertRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainCertResponse"/></returns>
        public async Task<ModifyLiveDomainCertResponse> ModifyLiveDomainCert(ModifyLiveDomainCertRequest req)
        {
             JsonResponseModel<ModifyLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the domain name and certificate binding information.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainCertRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainCertResponse"/></returns>
        public ModifyLiveDomainCertResponse ModifyLiveDomainCertSync(ModifyLiveDomainCertRequest req)
        {
             JsonResponseModel<ModifyLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePlayAuthKeyResponse"/></returns>
        public async Task<ModifyLivePlayAuthKeyResponse> ModifyLivePlayAuthKey(ModifyLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the playback authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePlayAuthKeyResponse"/></returns>
        public ModifyLivePlayAuthKeyResponse ModifyLivePlayAuthKeySync(ModifyLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a playback domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns><see cref="ModifyLivePlayDomainResponse"/></returns>
        public async Task<ModifyLivePlayDomainResponse> ModifyLivePlayDomain(ModifyLivePlayDomainRequest req)
        {
             JsonResponseModel<ModifyLivePlayDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePlayDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a playback domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns><see cref="ModifyLivePlayDomainResponse"/></returns>
        public ModifyLivePlayDomainResponse ModifyLivePlayDomainSync(ModifyLivePlayDomainRequest req)
        {
             JsonResponseModel<ModifyLivePlayDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLivePlayDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePushAuthKeyResponse"/></returns>
        public async Task<ModifyLivePushAuthKeyResponse> ModifyLivePushAuthKey(ModifyLivePushAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the LVB push authentication key.
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePushAuthKeyResponse"/></returns>
        public ModifyLivePushAuthKeyResponse ModifyLivePushAuthKeySync(ModifyLivePushAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the recording template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public async Task<ModifyLiveRecordTemplateResponse> ModifyLiveRecordTemplate(ModifyLiveRecordTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the recording template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public ModifyLiveRecordTemplateResponse ModifyLiveRecordTemplateSync(ModifyLiveRecordTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the screencapturing template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveSnapshotTemplateResponse"/></returns>
        public async Task<ModifyLiveSnapshotTemplateResponse> ModifyLiveSnapshotTemplate(ModifyLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the screencapturing template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveSnapshotTemplateResponse"/></returns>
        public ModifyLiveSnapshotTemplateResponse ModifyLiveSnapshotTemplateSync(ModifyLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the transcoding template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTranscodeTemplateResponse"/></returns>
        public async Task<ModifyLiveTranscodeTemplateResponse> ModifyLiveTranscodeTemplate(ModifyLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the transcoding template configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTranscodeTemplateResponse"/></returns>
        public ModifyLiveTranscodeTemplateResponse ModifyLiveTranscodeTemplateSync(ModifyLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume a delayed playback.
        /// </summary>
        /// <param name="req"><see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeDelayLiveStreamResponse"/></returns>
        public async Task<ResumeDelayLiveStreamResponse> ResumeDelayLiveStream(ResumeDelayLiveStreamRequest req)
        {
             JsonResponseModel<ResumeDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume a delayed playback.
        /// </summary>
        /// <param name="req"><see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeDelayLiveStreamResponse"/></returns>
        public ResumeDelayLiveStreamResponse ResumeDelayLiveStreamSync(ResumeDelayLiveStreamRequest req)
        {
             JsonResponseModel<ResumeDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume the push of a specific stream.
        /// </summary>
        /// <param name="req"><see cref="ResumeLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeLiveStreamResponse"/></returns>
        public async Task<ResumeLiveStreamResponse> ResumeLiveStream(ResumeLiveStreamRequest req)
        {
             JsonResponseModel<ResumeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume the push of a specific stream.
        /// </summary>
        /// <param name="req"><see cref="ResumeLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeLiveStreamResponse"/></returns>
        public ResumeLiveStreamResponse ResumeLiveStreamSync(ResumeLiveStreamRequest req)
        {
             JsonResponseModel<ResumeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Note: Recording files are stored on the VOD platform. To use the recording feature, you need to activate a VOD account and ensure that it is available. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) will be charged according to the VOD billing method. For more information, please see the corresponding document.
        /// </summary>
        /// <param name="req"><see cref="StopLiveRecordRequest"/></param>
        /// <returns><see cref="StopLiveRecordResponse"/></returns>
        public async Task<StopLiveRecordResponse> StopLiveRecord(StopLiveRecordRequest req)
        {
             JsonResponseModel<StopLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Note: Recording files are stored on the VOD platform. To use the recording feature, you need to activate a VOD account and ensure that it is available. After the recording files are stored, applicable fees (including storage fees and downstream playback traffic fees) will be charged according to the VOD billing method. For more information, please see the corresponding document.
        /// </summary>
        /// <param name="req"><see cref="StopLiveRecordRequest"/></param>
        /// <returns><see cref="StopLiveRecordResponse"/></returns>
        public StopLiveRecordResponse StopLiveRecordSync(StopLiveRecordRequest req)
        {
             JsonResponseModel<StopLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to end a recording prematurely and terminate an ongoing recording task. After the task is successfully terminated, it will not restart.
        /// </summary>
        /// <param name="req"><see cref="StopRecordTaskRequest"/></param>
        /// <returns><see cref="StopRecordTaskResponse"/></returns>
        public async Task<StopRecordTaskResponse> StopRecordTask(StopRecordTaskRequest req)
        {
             JsonResponseModel<StopRecordTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopRecordTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopRecordTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to end a recording prematurely and terminate an ongoing recording task. After the task is successfully terminated, it will not restart.
        /// </summary>
        /// <param name="req"><see cref="StopRecordTaskRequest"/></param>
        /// <returns><see cref="StopRecordTaskResponse"/></returns>
        public StopRecordTaskResponse StopRecordTaskSync(StopRecordTaskRequest req)
        {
             JsonResponseModel<StopRecordTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopRecordTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopRecordTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a domain name certificate.
        /// </summary>
        /// <param name="req"><see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns><see cref="UnBindLiveDomainCertResponse"/></returns>
        public async Task<UnBindLiveDomainCertResponse> UnBindLiveDomainCert(UnBindLiveDomainCertRequest req)
        {
             JsonResponseModel<UnBindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a domain name certificate.
        /// </summary>
        /// <param name="req"><see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns><see cref="UnBindLiveDomainCertResponse"/></returns>
        public UnBindLiveDomainCertResponse UnBindLiveDomainCertSync(UnBindLiveDomainCertRequest req)
        {
             JsonResponseModel<UnBindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a watermark.
        /// </summary>
        /// <param name="req"><see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns><see cref="UpdateLiveWatermarkResponse"/></returns>
        public async Task<UpdateLiveWatermarkResponse> UpdateLiveWatermark(UpdateLiveWatermarkRequest req)
        {
             JsonResponseModel<UpdateLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a watermark.
        /// </summary>
        /// <param name="req"><see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns><see cref="UpdateLiveWatermarkResponse"/></returns>
        public UpdateLiveWatermarkResponse UpdateLiveWatermarkSync(UpdateLiveWatermarkRequest req)
        {
             JsonResponseModel<UpdateLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
