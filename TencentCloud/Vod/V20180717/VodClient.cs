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

namespace TencentCloud.Vod.V20180717
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vod.V20180717.Models;

   public class VodClient : AbstractClient{

       private const string endpoint = "vod.tencentcloudapi.com";
       private const string version = "2018-07-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// * This API is used to apply for uploading a media file (and cover file) to VOD and obtain the metadata of file storage (including upload path and upload signature) for subsequent use by the uploading API.
        /// * For the detailed upload process, please see [Overview of Upload from Client](https://intl.cloud.tencent.com/document/product/266/9759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public async Task<ApplyUploadResponse> ApplyUpload(ApplyUploadRequest req)
        {
             JsonResponseModel<ApplyUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to apply for uploading a media file (and cover file) to VOD and obtain the metadata of file storage (including upload path and upload signature) for subsequent use by the uploading API.
        /// * For the detailed upload process, please see [Overview of Upload from Client](https://intl.cloud.tencent.com/document/product/266/9759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public ApplyUploadResponse ApplyUploadSync(ApplyUploadRequest req)
        {
             JsonResponseModel<ApplyUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate/disassociate subtitles with/from a media file of a specific adaptive bitrate streaming template ID.
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public async Task<AttachMediaSubtitlesResponse> AttachMediaSubtitles(AttachMediaSubtitlesRequest req)
        {
             JsonResponseModel<AttachMediaSubtitlesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachMediaSubtitles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachMediaSubtitlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate/disassociate subtitles with/from a media file of a specific adaptive bitrate streaming template ID.
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public AttachMediaSubtitlesResponse AttachMediaSubtitlesSync(AttachMediaSubtitlesRequest req)
        {
             JsonResponseModel<AttachMediaSubtitlesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachMediaSubtitles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachMediaSubtitlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CloneCDNDomain.
        /// </summary>
        /// <param name="req"><see cref="CloneCDNDomainRequest"/></param>
        /// <returns><see cref="CloneCDNDomainResponse"/></returns>
        public async Task<CloneCDNDomainResponse> CloneCDNDomain(CloneCDNDomainRequest req)
        {
             JsonResponseModel<CloneCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CloneCDNDomain.
        /// </summary>
        /// <param name="req"><see cref="CloneCDNDomainRequest"/></param>
        /// <returns><see cref="CloneCDNDomainResponse"/></returns>
        public CloneCDNDomainResponse CloneCDNDomainSync(CloneCDNDomainRequest req)
        {
             JsonResponseModel<CloneCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to confirm the result of uploading a media file (and cover file) to VOD, store the media information, and return the playback address and ID of the file.
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public async Task<CommitUploadResponse> CommitUpload(CommitUploadRequest req)
        {
             JsonResponseModel<CommitUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to confirm the result of uploading a media file (and cover file) to VOD, store the media information, and return the playback address and ID of the file.
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public CommitUploadResponse CommitUploadSync(CommitUploadRequest req)
        {
             JsonResponseModel<CommitUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to compose a media file. You can use it to do the following:
        /// 
        /// 1. **Rotation/Flipping**: Rotate a video or image by a specific angle or flip a video or image.
        /// 2. **Audio control**: Increase/Lower the volume of an audio/video file or mute an audio/video file.
        /// 3. **Overlaying**: Overlay videos/images in a specified sequence to achieve the picture-in-picture effect.
        /// 4. **Audio mixing**: Mix the audios of audio/video files.
        /// 5 **Audio extraction**: Extract audio from a video.
        /// 6. **Clipping**: Clip segments from audio/video files according to a specified start and end time.
        /// 7. **Splicing**: Splice videos/audios/images in a specified sequence.
        /// 8. **Transition**: Add transition effects between video segments or images that are spliced together.
        /// 
        /// The output file is in MP4 or MP3 format. In the callback for media composition, the event type is [ComposeMediaComplete](https://intl.cloud.tencent.com/document/product/266/43000?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public async Task<ComposeMediaResponse> ComposeMedia(ComposeMediaRequest req)
        {
             JsonResponseModel<ComposeMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ComposeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ComposeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to compose a media file. You can use it to do the following:
        /// 
        /// 1. **Rotation/Flipping**: Rotate a video or image by a specific angle or flip a video or image.
        /// 2. **Audio control**: Increase/Lower the volume of an audio/video file or mute an audio/video file.
        /// 3. **Overlaying**: Overlay videos/images in a specified sequence to achieve the picture-in-picture effect.
        /// 4. **Audio mixing**: Mix the audios of audio/video files.
        /// 5 **Audio extraction**: Extract audio from a video.
        /// 6. **Clipping**: Clip segments from audio/video files according to a specified start and end time.
        /// 7. **Splicing**: Splice videos/audios/images in a specified sequence.
        /// 8. **Transition**: Add transition effects between video segments or images that are spliced together.
        /// 
        /// The output file is in MP4 or MP3 format. In the callback for media composition, the event type is [ComposeMediaComplete](https://intl.cloud.tencent.com/document/product/266/43000?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public ComposeMediaResponse ComposeMediaSync(ComposeMediaRequest req)
        {
             JsonResponseModel<ComposeMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ComposeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ComposeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * After the `PullEvents` API is called to get an event, this API must be called to confirm that the message has been received;
        /// * After the event handler is obtained, the validity period of waiting for confirmation is 30 seconds. If the wait exceeds 30 seconds, a parameter error will be reported (4000);
        /// * For more information, please see the [reliable callback](https://intl.cloud.tencent.com/document/product/266/33779?from_cn_redirect=1#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) of event notification.
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public async Task<ConfirmEventsResponse> ConfirmEvents(ConfirmEventsRequest req)
        {
             JsonResponseModel<ConfirmEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ConfirmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * After the `PullEvents` API is called to get an event, this API must be called to confirm that the message has been received;
        /// * After the event handler is obtained, the validity period of waiting for confirmation is 30 seconds. If the wait exceeds 30 seconds, a parameter error will be reported (4000);
        /// * For more information, please see the [reliable callback](https://intl.cloud.tencent.com/document/product/266/33779?from_cn_redirect=1#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) of event notification.
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public ConfirmEventsResponse ConfirmEventsSync(ConfirmEventsRequest req)
        {
             JsonResponseModel<ConfirmEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ConfirmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom video content analysis template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public async Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<CreateAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom video content analysis template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<CreateAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom video content recognition template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public async Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<CreateAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom video content recognition template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public CreateAIRecognitionTemplateResponse CreateAIRecognitionTemplateSync(CreateAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<CreateAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an adaptive bitrate streaming template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<CreateAdaptiveDynamicStreamingTemplateResponse> CreateAdaptiveDynamicStreamingTemplate(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an adaptive bitrate streaming template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public CreateAdaptiveDynamicStreamingTemplateResponse CreateAdaptiveDynamicStreamingTemplateSync(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom animated image generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<CreateAnimatedGraphicsTemplateResponse> CreateAnimatedGraphicsTemplate(CreateAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<CreateAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom animated image generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public CreateAnimatedGraphicsTemplateResponse CreateAnimatedGraphicsTemplateSync(CreateAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<CreateAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This interface is used to add domain names to VOD, and a user can add at most 20 domains. 1. After the domain name is successfully added, VOD will deploy the domain name. It takes about 2 minutes for the domain name to change from the deployed state to the online state.
        /// </summary>
        /// <param name="req"><see cref="CreateCDNDomainRequest"/></param>
        /// <returns><see cref="CreateCDNDomainResponse"/></returns>
        public async Task<CreateCDNDomainResponse> CreateCDNDomain(CreateCDNDomainRequest req)
        {
             JsonResponseModel<CreateCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This interface is used to add domain names to VOD, and a user can add at most 20 domains. 1. After the domain name is successfully added, VOD will deploy the domain name. It takes about 2 minutes for the domain name to change from the deployed state to the online state.
        /// </summary>
        /// <param name="req"><see cref="CreateCDNDomainRequest"/></param>
        /// <returns><see cref="CreateCDNDomainResponse"/></returns>
        public CreateCDNDomainResponse CreateCDNDomainSync(CreateCDNDomainRequest req)
        {
             JsonResponseModel<CreateCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to categorize media assets for management;
        /// * It does not affect the categories of existing media assets. If you want to modify the category of a media asset, call the [ModifyMediaInfo](https://intl.cloud.tencent.com/document/product/266/31762?from_cn_redirect=1) API.
        /// * There can be up to 4 levels of categories.
        /// * One category can have up to 500 subcategories under it.
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public async Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
             JsonResponseModel<CreateClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to categorize media assets for management;
        /// * It does not affect the categories of existing media assets. If you want to modify the category of a media asset, call the [ModifyMediaInfo](https://intl.cloud.tencent.com/document/product/266/31762?from_cn_redirect=1) API.
        /// * There can be up to 4 levels of categories.
        /// * One category can have up to 500 subcategories under it.
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public CreateClassResponse CreateClassSync(CreateClassRequest req)
        {
             JsonResponseModel<CreateClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [CreateReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84391?from_cn_redirect=1).
        /// This API is used to create a custom audio/video moderation template. Up to 50 templates can be created in total.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public async Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
             JsonResponseModel<CreateContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [CreateReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84391?from_cn_redirect=1).
        /// This API is used to create a custom audio/video moderation template. Up to 50 templates can be created in total.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
             JsonResponseModel<CreateContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom image processing template. A template can include at most 10 operations, for example, crop-scale-crop-blur-scale-crop-scale-crop-blur-scale. You can have up to 16 image processing templates.
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public async Task<CreateImageProcessingTemplateResponse> CreateImageProcessingTemplate(CreateImageProcessingTemplateRequest req)
        {
             JsonResponseModel<CreateImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom image processing template. A template can include at most 10 operations, for example, crop-scale-crop-blur-scale-crop-scale-crop-blur-scale. You can have up to 16 image processing templates.
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public CreateImageProcessingTemplateResponse CreateImageProcessingTemplateSync(CreateImageProcessingTemplateRequest req)
        {
             JsonResponseModel<CreateImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom image sprite generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public async Task<CreateImageSpriteTemplateResponse> CreateImageSpriteTemplate(CreateImageSpriteTemplateRequest req)
        {
             JsonResponseModel<CreateImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom image sprite generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public CreateImageSpriteTemplateResponse CreateImageSpriteTemplateSync(CreateImageSpriteTemplateRequest req)
        {
             JsonResponseModel<CreateImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create samples for using facial features positioning and other technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public async Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
             JsonResponseModel<CreatePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create samples for using facial features positioning and other technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
             JsonResponseModel<CreatePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom task flow template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public async Task<CreateProcedureTemplateResponse> CreateProcedureTemplate(CreateProcedureTemplateRequest req)
        {
             JsonResponseModel<CreateProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom task flow template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public CreateProcedureTemplateResponse CreateProcedureTemplateSync(CreateProcedureTemplateRequest req)
        {
             JsonResponseModel<CreateProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a remaster template.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public async Task<CreateRebuildMediaTemplateResponse> CreateRebuildMediaTemplate(CreateRebuildMediaTemplateRequest req)
        {
             JsonResponseModel<CreateRebuildMediaTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRebuildMediaTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRebuildMediaTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a remaster template.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public CreateRebuildMediaTemplateResponse CreateRebuildMediaTemplateSync(CreateRebuildMediaTemplateRequest req)
        {
             JsonResponseModel<CreateRebuildMediaTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRebuildMediaTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRebuildMediaTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom moderation template. Up to 50 templates can be created in total.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public async Task<CreateReviewTemplateResponse> CreateReviewTemplate(CreateReviewTemplateRequest req)
        {
             JsonResponseModel<CreateReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom moderation template. Up to 50 templates can be created in total.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public CreateReviewTemplateResponse CreateReviewTemplateSync(CreateReviewTemplateRequest req)
        {
             JsonResponseModel<CreateReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a playlist. You can create at most 100 playlists.
        /// For each video on the list, you can either use the original file or a transcoding file.
        /// The files must be in HLS format. Preferably, they should have the same bitrate and resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateRoundPlayRequest"/></param>
        /// <returns><see cref="CreateRoundPlayResponse"/></returns>
        public async Task<CreateRoundPlayResponse> CreateRoundPlay(CreateRoundPlayRequest req)
        {
             JsonResponseModel<CreateRoundPlayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoundPlay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoundPlayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a playlist. You can create at most 100 playlists.
        /// For each video on the list, you can either use the original file or a transcoding file.
        /// The files must be in HLS format. Preferably, they should have the same bitrate and resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateRoundPlayRequest"/></param>
        /// <returns><see cref="CreateRoundPlayResponse"/></returns>
        public CreateRoundPlayResponse CreateRoundPlaySync(CreateRoundPlayRequest req)
        {
             JsonResponseModel<CreateRoundPlayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoundPlay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoundPlayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom sampled screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public async Task<CreateSampleSnapshotTemplateResponse> CreateSampleSnapshotTemplate(CreateSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom sampled screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public CreateSampleSnapshotTemplateResponse CreateSampleSnapshotTemplateSync(CreateSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom time point screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<CreateSnapshotByTimeOffsetTemplateResponse> CreateSnapshotByTimeOffsetTemplate(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom time point screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public CreateSnapshotByTimeOffsetTemplateResponse CreateSnapshotByTimeOffsetTemplateSync(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable storage in a region.
        ///   1. When you activate VOD, the system will enable storage for you in certain regions. If you need to store data in another region, you can use this API to enable storage in that region.
        ///   2. You can use the `DescribeStorageRegions` API to query all supported storage regions and the regions you have storage access to currently.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRegionRequest"/></param>
        /// <returns><see cref="CreateStorageRegionResponse"/></returns>
        public async Task<CreateStorageRegionResponse> CreateStorageRegion(CreateStorageRegionRequest req)
        {
             JsonResponseModel<CreateStorageRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStorageRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStorageRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable storage in a region.
        ///   1. When you activate VOD, the system will enable storage for you in certain regions. If you need to store data in another region, you can use this API to enable storage in that region.
        ///   2. You can use the `DescribeStorageRegions` API to query all supported storage regions and the regions you have storage access to currently.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRegionRequest"/></param>
        /// <returns><see cref="CreateStorageRegionResponse"/></returns>
        public CreateStorageRegionResponse CreateStorageRegionSync(CreateStorageRegionRequest req)
        {
             JsonResponseModel<CreateStorageRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStorageRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStorageRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VOD subapplication.
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public async Task<CreateSubAppIdResponse> CreateSubAppId(CreateSubAppIdRequest req)
        {
             JsonResponseModel<CreateSubAppIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubAppId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubAppIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VOD subapplication.
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public CreateSubAppIdResponse CreateSubAppIdSync(CreateSubAppIdRequest req)
        {
             JsonResponseModel<CreateSubAppIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubAppId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubAppIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to create a player configuration. Up to 100 configurations can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public async Task<CreateSuperPlayerConfigResponse> CreateSuperPlayerConfig(CreateSuperPlayerConfigRequest req)
        {
             JsonResponseModel<CreateSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to create a player configuration. Up to 100 configurations can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public CreateSuperPlayerConfigResponse CreateSuperPlayerConfigSync(CreateSuperPlayerConfigRequest req)
        {
             JsonResponseModel<CreateSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom transcoding template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public async Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom transcoding template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an acceleration domain name to VOD. One user can add up to 20 domain names.
        /// 1. After a domain name is added, VOD will deploy it, and it takes about 2 minutes for the domain name status to change from `Deploying` to `Online`.
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public async Task<CreateVodDomainResponse> CreateVodDomain(CreateVodDomainRequest req)
        {
             JsonResponseModel<CreateVodDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVodDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVodDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an acceleration domain name to VOD. One user can add up to 20 domain names.
        /// 1. After a domain name is added, VOD will deploy it, and it takes about 2 minutes for the domain name status to change from `Deploying` to `Online`.
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public CreateVodDomainResponse CreateVodDomainSync(CreateVodDomainRequest req)
        {
             JsonResponseModel<CreateVodDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVodDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVodDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom watermarking template. Up to 1,000 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public async Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplate(CreateWatermarkTemplateRequest req)
        {
             JsonResponseModel<CreateWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom watermarking template. Up to 1,000 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplateSync(CreateWatermarkTemplateRequest req)
        {
             JsonResponseModel<CreateWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create keyword samples in batches for using OCR and ASR technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public async Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
             JsonResponseModel<CreateWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create keyword samples in batches for using OCR and ASR technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public CreateWordSamplesResponse CreateWordSamplesSync(CreateWordSamplesRequest req)
        {
             JsonResponseModel<CreateWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom video content analysis template.
        /// 
        /// Note: templates with an ID below 10000 are preset and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public async Task<DeleteAIAnalysisTemplateResponse> DeleteAIAnalysisTemplate(DeleteAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<DeleteAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom video content analysis template.
        /// 
        /// Note: templates with an ID below 10000 are preset and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public DeleteAIAnalysisTemplateResponse DeleteAIAnalysisTemplateSync(DeleteAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<DeleteAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public async Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<DeleteAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public DeleteAIRecognitionTemplateResponse DeleteAIRecognitionTemplateSync(DeleteAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<DeleteAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<DeleteAdaptiveDynamicStreamingTemplateResponse> DeleteAdaptiveDynamicStreamingTemplate(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public DeleteAdaptiveDynamicStreamingTemplateResponse DeleteAdaptiveDynamicStreamingTemplateSync(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<DeleteAnimatedGraphicsTemplateResponse> DeleteAnimatedGraphicsTemplate(DeleteAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public DeleteAnimatedGraphicsTemplateResponse DeleteAnimatedGraphicsTemplateSync(DeleteAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteCDNDomain.
        /// </summary>
        /// <param name="req"><see cref="DeleteCDNDomainRequest"/></param>
        /// <returns><see cref="DeleteCDNDomainResponse"/></returns>
        public async Task<DeleteCDNDomainResponse> DeleteCDNDomain(DeleteCDNDomainRequest req)
        {
             JsonResponseModel<DeleteCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteCDNDomain.
        /// </summary>
        /// <param name="req"><see cref="DeleteCDNDomainRequest"/></param>
        /// <returns><see cref="DeleteCDNDomainResponse"/></returns>
        public DeleteCDNDomainResponse DeleteCDNDomainSync(DeleteCDNDomainRequest req)
        {
             JsonResponseModel<DeleteCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * A category can be deleted only if it has no subcategories and associated media files;
        /// * Otherwise, [delete the media files](https://intl.cloud.tencent.com/document/product/266/31764?from_cn_redirect=1) and subcategories first before deleting the category.
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public async Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
             JsonResponseModel<DeleteClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * A category can be deleted only if it has no subcategories and associated media files;
        /// * Otherwise, [delete the media files](https://intl.cloud.tencent.com/document/product/266/31764?from_cn_redirect=1) and subcategories first before deleting the category.
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public DeleteClassResponse DeleteClassSync(DeleteClassRequest req)
        {
             JsonResponseModel<DeleteClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DeleteReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84390?from_cn_redirect=1).
        /// This API is used to delete a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public async Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DeleteReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84390?from_cn_redirect=1).
        /// This API is used to delete a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image processing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public async Task<DeleteImageProcessingTemplateResponse> DeleteImageProcessingTemplate(DeleteImageProcessingTemplateRequest req)
        {
             JsonResponseModel<DeleteImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image processing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public DeleteImageProcessingTemplateResponse DeleteImageProcessingTemplateSync(DeleteImageProcessingTemplateRequest req)
        {
             JsonResponseModel<DeleteImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public async Task<DeleteImageSpriteTemplateResponse> DeleteImageSpriteTemplate(DeleteImageSpriteTemplateRequest req)
        {
             JsonResponseModel<DeleteImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public DeleteImageSpriteTemplateResponse DeleteImageSpriteTemplateSync(DeleteImageSpriteTemplateRequest req)
        {
             JsonResponseModel<DeleteImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to delete a media file and its processed files, such as the transcoded video files, image sprites, screenshots, and videos for publishing on WeChat.
        /// * You can delete the original files, transcoded video files, and videos for publishing on WeChat, etc. of videos with specified IDs.
        /// * Note: after the original file of a video is deleted, you cannot transcode the video, publish it on WeChat, or perform other operations on it.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public async Task<DeleteMediaResponse> DeleteMedia(DeleteMediaRequest req)
        {
             JsonResponseModel<DeleteMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to delete a media file and its processed files, such as the transcoded video files, image sprites, screenshots, and videos for publishing on WeChat.
        /// * You can delete the original files, transcoded video files, and videos for publishing on WeChat, etc. of videos with specified IDs.
        /// * Note: after the original file of a video is deleted, you cannot transcode the video, publish it on WeChat, or perform other operations on it.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public DeleteMediaResponse DeleteMediaSync(DeleteMediaRequest req)
        {
             JsonResponseModel<DeleteMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete samples according to sample IDs.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public async Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
             JsonResponseModel<DeletePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete samples according to sample IDs.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
             JsonResponseModel<DeletePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public async Task<DeleteProcedureTemplateResponse> DeleteProcedureTemplate(DeleteProcedureTemplateRequest req)
        {
             JsonResponseModel<DeleteProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public DeleteProcedureTemplateResponse DeleteProcedureTemplateSync(DeleteProcedureTemplateRequest req)
        {
             JsonResponseModel<DeleteProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a remaster template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public async Task<DeleteRebuildMediaTemplateResponse> DeleteRebuildMediaTemplate(DeleteRebuildMediaTemplateRequest req)
        {
             JsonResponseModel<DeleteRebuildMediaTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRebuildMediaTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRebuildMediaTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a remaster template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public DeleteRebuildMediaTemplateResponse DeleteRebuildMediaTemplateSync(DeleteRebuildMediaTemplateRequest req)
        {
             JsonResponseModel<DeleteRebuildMediaTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRebuildMediaTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRebuildMediaTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public async Task<DeleteReviewTemplateResponse> DeleteReviewTemplate(DeleteReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public DeleteReviewTemplateResponse DeleteReviewTemplateSync(DeleteReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a playlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public async Task<DeleteRoundPlayResponse> DeleteRoundPlay(DeleteRoundPlayRequest req)
        {
             JsonResponseModel<DeleteRoundPlayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoundPlay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoundPlayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a playlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public DeleteRoundPlayResponse DeleteRoundPlaySync(DeleteRoundPlayRequest req)
        {
             JsonResponseModel<DeleteRoundPlayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoundPlay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoundPlayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public async Task<DeleteSampleSnapshotTemplateResponse> DeleteSampleSnapshotTemplate(DeleteSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public DeleteSampleSnapshotTemplateResponse DeleteSampleSnapshotTemplateSync(DeleteSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<DeleteSnapshotByTimeOffsetTemplateResponse> DeleteSnapshotByTimeOffsetTemplate(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public DeleteSnapshotByTimeOffsetTemplateResponse DeleteSnapshotByTimeOffsetTemplateSync(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to delete a player configuration.  
        /// *Note: Preset player configurations cannot be deleted.*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public async Task<DeleteSuperPlayerConfigResponse> DeleteSuperPlayerConfig(DeleteSuperPlayerConfigRequest req)
        {
             JsonResponseModel<DeleteSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to delete a player configuration.  
        /// *Note: Preset player configurations cannot be deleted.*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public DeleteSuperPlayerConfigResponse DeleteSuperPlayerConfigSync(DeleteSuperPlayerConfigRequest req)
        {
             JsonResponseModel<DeleteSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public async Task<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplate(DeleteTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public DeleteTranscodeTemplateResponse DeleteTranscodeTemplateSync(DeleteTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an acceleration domain name from VOD.
        /// 1. Before deleting a domain name, disable its acceleration in all regions.
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public async Task<DeleteVodDomainResponse> DeleteVodDomain(DeleteVodDomainRequest req)
        {
             JsonResponseModel<DeleteVodDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVodDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVodDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an acceleration domain name from VOD.
        /// 1. Before deleting a domain name, disable its acceleration in all regions.
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public DeleteVodDomainResponse DeleteVodDomainSync(DeleteVodDomainRequest req)
        {
             JsonResponseModel<DeleteVodDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVodDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVodDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom watermarking template.
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public async Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest req)
        {
             JsonResponseModel<DeleteWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom watermarking template.
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplateSync(DeleteWatermarkTemplateRequest req)
        {
             JsonResponseModel<DeleteWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete keyword samples in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public async Task<DeleteWordSamplesResponse> DeleteWordSamples(DeleteWordSamplesRequest req)
        {
             JsonResponseModel<DeleteWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete keyword samples in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public DeleteWordSamplesResponse DeleteWordSamplesSync(DeleteWordSamplesRequest req)
        {
             JsonResponseModel<DeleteWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of video content analysis templates based on unique template ID. The returned result includes all eligible custom and [preset video content analysis templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public async Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIAnalysisTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAIAnalysisTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIAnalysisTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of video content analysis templates based on unique template ID. The returned result includes all eligible custom and [preset video content analysis templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIAnalysisTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAIAnalysisTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIAnalysisTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of video content recognition templates based on unique template ID. The return result includes all eligible custom and [preset video content recognition templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public async Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIRecognitionTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAIRecognitionTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIRecognitionTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of video content recognition templates based on unique template ID. The return result includes all eligible custom and [preset video content recognition templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public DescribeAIRecognitionTemplatesResponse DescribeAIRecognitionTemplatesSync(DescribeAIRecognitionTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIRecognitionTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAIRecognitionTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIRecognitionTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of transcoding to adaptive bitrate streaming templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public async Task<DescribeAdaptiveDynamicStreamingTemplatesResponse> DescribeAdaptiveDynamicStreamingTemplates(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
             JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAdaptiveDynamicStreamingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of transcoding to adaptive bitrate streaming templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public DescribeAdaptiveDynamicStreamingTemplatesResponse DescribeAdaptiveDynamicStreamingTemplatesSync(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
             JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAdaptiveDynamicStreamingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to get the information of all categories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public async Task<DescribeAllClassResponse> DescribeAllClass(DescribeAllClassRequest req)
        {
             JsonResponseModel<DescribeAllClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to get the information of all categories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public DescribeAllClassResponse DescribeAllClassSync(DescribeAllClassRequest req)
        {
             JsonResponseModel<DescribeAllClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of animated image generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public async Task<DescribeAnimatedGraphicsTemplatesResponse> DescribeAnimatedGraphicsTemplates(DescribeAnimatedGraphicsTemplatesRequest req)
        {
             JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAnimatedGraphicsTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of animated image generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public DescribeAnimatedGraphicsTemplatesResponse DescribeAnimatedGraphicsTemplatesSync(DescribeAnimatedGraphicsTemplatesRequest req)
        {
             JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAnimatedGraphicsTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCDNDomains.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNDomainsRequest"/></param>
        /// <returns><see cref="DescribeCDNDomainsResponse"/></returns>
        public async Task<DescribeCDNDomainsResponse> DescribeCDNDomains(DescribeCDNDomainsRequest req)
        {
             JsonResponseModel<DescribeCDNDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCDNDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCDNDomains.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNDomainsRequest"/></param>
        /// <returns><see cref="DescribeCDNDomainsResponse"/></returns>
        public DescribeCDNDomainsResponse DescribeCDNDomainsSync(DescribeCDNDomainsRequest req)
        {
             JsonResponseModel<DescribeCDNDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCDNDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN bandwidth, traffic, and other data of VOD domain names.
        /// * The query period is up to 90 days.
        /// * You can query data of different service regions.
        /// * You can query data of Chinese mainland by region and ISP.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public async Task<DescribeCDNStatDetailsResponse> DescribeCDNStatDetails(DescribeCDNStatDetailsRequest req)
        {
             JsonResponseModel<DescribeCDNStatDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCDNStatDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNStatDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN bandwidth, traffic, and other data of VOD domain names.
        /// * The query period is up to 90 days.
        /// * You can query data of different service regions.
        /// * You can query data of Chinese mainland by region and ISP.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public DescribeCDNStatDetailsResponse DescribeCDNStatDetailsSync(DescribeCDNStatDetailsRequest req)
        {
             JsonResponseModel<DescribeCDNStatDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCDNStatDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNStatDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CDN statistics of VOD such as traffic and bandwidth.
        ///    1. Only CDN usage data for the last 365 days can be queried.
        ///    2. The query time range cannot be more than 90 days.
        ///    3. The time granularity of usage data can be specified, including 5-minute, 1-hour, and 1-day.
        ///    4. Traffic refers to the total traffic within the query time granularity, while bandwidth the peak bandwidth.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public async Task<DescribeCDNUsageDataResponse> DescribeCDNUsageData(DescribeCDNUsageDataRequest req)
        {
             JsonResponseModel<DescribeCDNUsageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCDNUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CDN statistics of VOD such as traffic and bandwidth.
        ///    1. Only CDN usage data for the last 365 days can be queried.
        ///    2. The query time range cannot be more than 90 days.
        ///    3. The time granularity of usage data can be specified, including 5-minute, 1-hour, and 1-day.
        ///    4. Traffic refers to the total traffic within the query time granularity, while bandwidth the peak bandwidth.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public DescribeCDNUsageDataResponse DescribeCDNUsageDataSync(DescribeCDNUsageDataRequest req)
        {
             JsonResponseModel<DescribeCDNUsageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCDNUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download links of CDN access logs of a VOD domain name.
        ///     1. Only download links of CDN logs for the last 30 days can be queried.
        ///     2. By default, CDN generates a log file every hour. If there is no CDN access for a certain hour, no log file will be generated for the hour.    
        ///     3. A CDN log download link is valid for 24 hours.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public async Task<DescribeCdnLogsResponse> DescribeCdnLogs(DescribeCdnLogsRequest req)
        {
             JsonResponseModel<DescribeCdnLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download links of CDN access logs of a VOD domain name.
        ///     1. Only download links of CDN logs for the last 30 days can be queried.
        ///     2. By default, CDN generates a log file every hour. If there is no CDN access for a certain hour, no log file will be generated for the hour.    
        ///     3. A CDN log download link is valid for 24 hours.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public DescribeCdnLogsResponse DescribeCdnLogsSync(DescribeCdnLogsRequest req)
        {
             JsonResponseModel<DescribeCdnLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the usage of the client upload acceleration service in a specific time period.
        ///    1. You can query the usage of client upload acceleration in the last 365 days.
        ///    2. The maximum time period allowed for query is 90 days.
        ///    3. If the period specified is longer than one day, the statistics returned will be on a daily basis; otherwise, they will be on a 5-minute basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public async Task<DescribeClientUploadAccelerationUsageDataResponse> DescribeClientUploadAccelerationUsageData(DescribeClientUploadAccelerationUsageDataRequest req)
        {
             JsonResponseModel<DescribeClientUploadAccelerationUsageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClientUploadAccelerationUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientUploadAccelerationUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the usage of the client upload acceleration service in a specific time period.
        ///    1. You can query the usage of client upload acceleration in the last 365 days.
        ///    2. The maximum time period allowed for query is 90 days.
        ///    3. If the period specified is longer than one day, the statistics returned will be on a daily basis; otherwise, they will be on a 5-minute basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public DescribeClientUploadAccelerationUsageDataResponse DescribeClientUploadAccelerationUsageDataSync(DescribeClientUploadAccelerationUsageDataRequest req)
        {
             JsonResponseModel<DescribeClientUploadAccelerationUsageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClientUploadAccelerationUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientUploadAccelerationUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DescribeReviewTemplates](https://intl.cloud.tencent.com/document/api/266/84389?from_cn_redirect=1).
        /// This API is used to get the information of custom and [preset](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF) audio/video moderation templates based on template IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public async Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeContentReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContentReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DescribeReviewTemplates](https://intl.cloud.tencent.com/document/api/266/84389?from_cn_redirect=1).
        /// This API is used to get the information of custom and [preset](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF) audio/video moderation templates based on template IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeContentReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContentReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download links of playback statistics files.
        /// * You can query the download links of playback statistics files in the past year. The start and end dates for query cannot be more than 90 days apart.
        /// * Every day, VOD will analyze CDN request logs of the previous day and then generate a playback statistics file.
        /// * A playback statistics file includes playback times and traffic of media files.
        /// * Notes on playback times:
        ///     1. HLS file: VOD counts playback times when M3U8 files are accessed, but not when TS files are accessed.
        ///     2. Other files (MP4 files for example): VOD does not count playback times when the playback request carries the `range` parameter and the `start` parameter in `range` is not `0`. In other cases, VOD counts playback times.
        /// * Statistics on playback devices: VOD counts playback times on mobile clients when the playback request carries the `UserAgent` parameter which includes an identifier such as `Android` or `iPhone`. In other cases, VOD counts playback times on PC clients.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public async Task<DescribeDailyPlayStatFileListResponse> DescribeDailyPlayStatFileList(DescribeDailyPlayStatFileListRequest req)
        {
             JsonResponseModel<DescribeDailyPlayStatFileListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDailyPlayStatFileList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyPlayStatFileListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download links of playback statistics files.
        /// * You can query the download links of playback statistics files in the past year. The start and end dates for query cannot be more than 90 days apart.
        /// * Every day, VOD will analyze CDN request logs of the previous day and then generate a playback statistics file.
        /// * A playback statistics file includes playback times and traffic of media files.
        /// * Notes on playback times:
        ///     1. HLS file: VOD counts playback times when M3U8 files are accessed, but not when TS files are accessed.
        ///     2. Other files (MP4 files for example): VOD does not count playback times when the playback request carries the `range` parameter and the `start` parameter in `range` is not `0`. In other cases, VOD counts playback times.
        /// * Statistics on playback devices: VOD counts playback times on mobile clients when the playback request carries the `UserAgent` parameter which includes an identifier such as `Android` or `iPhone`. In other cases, VOD counts playback times on PC clients.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public DescribeDailyPlayStatFileListResponse DescribeDailyPlayStatFileListSync(DescribeDailyPlayStatFileListRequest req)
        {
             JsonResponseModel<DescribeDailyPlayStatFileListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDailyPlayStatFileList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyPlayStatFileListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query DRM key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public async Task<DescribeDrmKeyProviderInfoResponse> DescribeDrmKeyProviderInfo(DescribeDrmKeyProviderInfoRequest req)
        {
             JsonResponseModel<DescribeDrmKeyProviderInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDrmKeyProviderInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDrmKeyProviderInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query DRM key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public DescribeDrmKeyProviderInfoResponse DescribeDrmKeyProviderInfoSync(DescribeDrmKeyProviderInfoRequest req)
        {
             JsonResponseModel<DescribeDrmKeyProviderInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDrmKeyProviderInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDrmKeyProviderInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get file attributes asynchronously.
        /// - Currently, this API can only get the MD5 hash of a file.
        /// - If the file queried is in HLS or DASH format, the attributes of the index file will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileAttributesRequest"/></param>
        /// <returns><see cref="DescribeFileAttributesResponse"/></returns>
        public async Task<DescribeFileAttributesResponse> DescribeFileAttributes(DescribeFileAttributesRequest req)
        {
             JsonResponseModel<DescribeFileAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get file attributes asynchronously.
        /// - Currently, this API can only get the MD5 hash of a file.
        /// - If the file queried is in HLS or DASH format, the attributes of the index file will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileAttributesRequest"/></param>
        /// <returns><see cref="DescribeFileAttributesResponse"/></returns>
        public DescribeFileAttributesResponse DescribeFileAttributesSync(DescribeFileAttributesRequest req)
        {
             JsonResponseModel<DescribeFileAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query image processing templates. You can specify the filters as well as the offset to start returning records from.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public async Task<DescribeImageProcessingTemplatesResponse> DescribeImageProcessingTemplates(DescribeImageProcessingTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageProcessingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageProcessingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageProcessingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query image processing templates. You can specify the filters as well as the offset to start returning records from.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public DescribeImageProcessingTemplatesResponse DescribeImageProcessingTemplatesSync(DescribeImageProcessingTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageProcessingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageProcessingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageProcessingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query your daily usage of the image recognition feature in a specified time period.
        ///    1. You can query statistics from the last 365 days.
        ///    2. The maximum query period is 90 days.
        ///    3. If the period specified is longer than one day, the statistics returned will be on a daily basis; otherwise, they will be on a 5-minute basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public async Task<DescribeImageReviewUsageDataResponse> DescribeImageReviewUsageData(DescribeImageReviewUsageDataRequest req)
        {
             JsonResponseModel<DescribeImageReviewUsageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageReviewUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageReviewUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query your daily usage of the image recognition feature in a specified time period.
        ///    1. You can query statistics from the last 365 days.
        ///    2. The maximum query period is 90 days.
        ///    3. If the period specified is longer than one day, the statistics returned will be on a daily basis; otherwise, they will be on a 5-minute basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public DescribeImageReviewUsageDataResponse DescribeImageReviewUsageDataSync(DescribeImageReviewUsageDataRequest req)
        {
             JsonResponseModel<DescribeImageReviewUsageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageReviewUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageReviewUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of image sprite generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public async Task<DescribeImageSpriteTemplatesResponse> DescribeImageSpriteTemplates(DescribeImageSpriteTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageSpriteTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageSpriteTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSpriteTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of image sprite generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public DescribeImageSpriteTemplatesResponse DescribeImageSpriteTemplatesSync(DescribeImageSpriteTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageSpriteTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageSpriteTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSpriteTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query daily playback license requests in a specified time period.
        ///    1. You can query statistics from the last 365 days.
        ///    2. The maximum query period is 90 days.
        ///    3. If the period specified is longer than one day, the statistics returned will be on a daily basis; otherwise, they will be on a 5-minute basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public async Task<DescribeLicenseUsageDataResponse> DescribeLicenseUsageData(DescribeLicenseUsageDataRequest req)
        {
             JsonResponseModel<DescribeLicenseUsageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLicenseUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query daily playback license requests in a specified time period.
        ///    1. You can query statistics from the last 365 days.
        ///    2. The maximum query period is 90 days.
        ///    3. If the period specified is longer than one day, the statistics returned will be on a daily basis; otherwise, they will be on a 5-minute basis.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public DescribeLicenseUsageDataResponse DescribeLicenseUsageDataSync(DescribeLicenseUsageDataRequest req)
        {
             JsonResponseModel<DescribeLicenseUsageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLicenseUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. This API is used to get the information of multiple media files. Specifically, the information returned is as follows:
        ///     1. `basicInfo`: Basic information including the file name, category, playback URL, and thumbnail.
        ///     2. `metaData`: Metadata including the file size, duration, video stream information, and audio stream information.
        ///     3. `transcodeInfo`: Transcoding information including the URLs, video stream parameters, and audio stream parameters of transcoding outputs.
        ///     4. `animatedGraphicsInfo`: The information of the animated images (such as GIF images) generated.
        ///     5. `sampleSnapshotInfo`: The information of the sampled screenshots generated.
        ///     6. `imageSpriteInfo`: The information of the image sprites generated.
        ///     7. `snapshotByTimeOffsetInfo`: The information of the time point screenshots generated.
        ///     8. `keyFrameDescInfo`: The video timestamp information.
        ///     9. `adaptiveDynamicStreamingInfo`: Adaptive bitrate information including the specifications, encryption type, and formats of the streams.
        ///     10. `reviewInfo`: Moderation details for audio/video content and thumbnails.
        /// 2. You can specify what information to return.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public async Task<DescribeMediaInfosResponse> DescribeMediaInfos(DescribeMediaInfosRequest req)
        {
             JsonResponseModel<DescribeMediaInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. This API is used to get the information of multiple media files. Specifically, the information returned is as follows:
        ///     1. `basicInfo`: Basic information including the file name, category, playback URL, and thumbnail.
        ///     2. `metaData`: Metadata including the file size, duration, video stream information, and audio stream information.
        ///     3. `transcodeInfo`: Transcoding information including the URLs, video stream parameters, and audio stream parameters of transcoding outputs.
        ///     4. `animatedGraphicsInfo`: The information of the animated images (such as GIF images) generated.
        ///     5. `sampleSnapshotInfo`: The information of the sampled screenshots generated.
        ///     6. `imageSpriteInfo`: The information of the image sprites generated.
        ///     7. `snapshotByTimeOffsetInfo`: The information of the time point screenshots generated.
        ///     8. `keyFrameDescInfo`: The video timestamp information.
        ///     9. `adaptiveDynamicStreamingInfo`: Adaptive bitrate information including the specifications, encryption type, and formats of the streams.
        ///     10. `reviewInfo`: Moderation details for audio/video content and thumbnails.
        /// 2. You can specify what information to return.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public DescribeMediaInfosResponse DescribeMediaInfosSync(DescribeMediaInfosRequest req)
        {
             JsonResponseModel<DescribeMediaInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback statistics of a media file at the specified granularity.
        /// * You can query playback statistics in the past year.
        /// * If the granularity is an hour, the start and end time cannot be more than seven days apart.
        /// * If the granularity is a day, the start and end time cannot be more than 90 days apart.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPlayStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeMediaPlayStatDetailsResponse"/></returns>
        public async Task<DescribeMediaPlayStatDetailsResponse> DescribeMediaPlayStatDetails(DescribeMediaPlayStatDetailsRequest req)
        {
             JsonResponseModel<DescribeMediaPlayStatDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaPlayStatDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaPlayStatDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the playback statistics of a media file at the specified granularity.
        /// * You can query playback statistics in the past year.
        /// * If the granularity is an hour, the start and end time cannot be more than seven days apart.
        /// * If the granularity is a day, the start and end time cannot be more than 90 days apart.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPlayStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeMediaPlayStatDetailsResponse"/></returns>
        public DescribeMediaPlayStatDetailsResponse DescribeMediaPlayStatDetailsSync(DescribeMediaPlayStatDetailsRequest req)
        {
             JsonResponseModel<DescribeMediaPlayStatDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaPlayStatDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaPlayStatDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of video processing usage within the specified time range.
        ///    1. Statistics on video processing for the last 365 days can be queried.
        ///    2. The query time range cannot be more than 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public async Task<DescribeMediaProcessUsageDataResponse> DescribeMediaProcessUsageData(DescribeMediaProcessUsageDataRequest req)
        {
             JsonResponseModel<DescribeMediaProcessUsageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaProcessUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaProcessUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of video processing usage within the specified time range.
        ///    1. Statistics on video processing for the last 365 days can be queried.
        ///    2. The query time range cannot be more than 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public DescribeMediaProcessUsageDataResponse DescribeMediaProcessUsageDataSync(DescribeMediaProcessUsageDataRequest req)
        {
             JsonResponseModel<DescribeMediaProcessUsageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaProcessUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaProcessUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of samples and supports paginated queries by sample ID, name, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public async Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
             JsonResponseModel<DescribePersonSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of samples and supports paginated queries by sample ID, name, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public DescribePersonSamplesResponse DescribePersonSamplesSync(DescribePersonSamplesRequest req)
        {
             JsonResponseModel<DescribePersonSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of task flow template details by task flow template name.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public async Task<DescribeProcedureTemplatesResponse> DescribeProcedureTemplates(DescribeProcedureTemplatesRequest req)
        {
             JsonResponseModel<DescribeProcedureTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcedureTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcedureTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of task flow template details by task flow template name.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public DescribeProcedureTemplatesResponse DescribeProcedureTemplatesSync(DescribeProcedureTemplatesRequest req)
        {
             JsonResponseModel<DescribeProcedureTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProcedureTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcedureTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query remaster templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public async Task<DescribeRebuildMediaTemplatesResponse> DescribeRebuildMediaTemplates(DescribeRebuildMediaTemplatesRequest req)
        {
             JsonResponseModel<DescribeRebuildMediaTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRebuildMediaTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRebuildMediaTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query remaster templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public DescribeRebuildMediaTemplatesResponse DescribeRebuildMediaTemplatesSync(DescribeRebuildMediaTemplatesRequest req)
        {
             JsonResponseModel<DescribeRebuildMediaTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRebuildMediaTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRebuildMediaTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <b>This API is disused and replaced by [DescribeMediaProcessUsageData](https://intl.cloud.tencent.com/document/product/266/41464?from_cn_redirect=1).</b>
        /// 
        /// This API returns the video content duration for intelligent recognition in seconds per day within the queried period.
        /// 
        /// 1. The API is used to query statistics on the video content duration for intelligent recognition in the last 365 days.
        /// 2. The query period is up to 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewDetailsRequest"/></param>
        /// <returns><see cref="DescribeReviewDetailsResponse"/></returns>
        public async Task<DescribeReviewDetailsResponse> DescribeReviewDetails(DescribeReviewDetailsRequest req)
        {
             JsonResponseModel<DescribeReviewDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReviewDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReviewDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <b>This API is disused and replaced by [DescribeMediaProcessUsageData](https://intl.cloud.tencent.com/document/product/266/41464?from_cn_redirect=1).</b>
        /// 
        /// This API returns the video content duration for intelligent recognition in seconds per day within the queried period.
        /// 
        /// 1. The API is used to query statistics on the video content duration for intelligent recognition in the last 365 days.
        /// 2. The query period is up to 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewDetailsRequest"/></param>
        /// <returns><see cref="DescribeReviewDetailsResponse"/></returns>
        public DescribeReviewDetailsResponse DescribeReviewDetailsSync(DescribeReviewDetailsRequest req)
        {
             JsonResponseModel<DescribeReviewDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReviewDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReviewDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of moderation templates.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public async Task<DescribeReviewTemplatesResponse> DescribeReviewTemplates(DescribeReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of moderation templates.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public DescribeReviewTemplatesResponse DescribeReviewTemplatesSync(DescribeReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query playlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public async Task<DescribeRoundPlaysResponse> DescribeRoundPlays(DescribeRoundPlaysRequest req)
        {
             JsonResponseModel<DescribeRoundPlaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoundPlays");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoundPlaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query playlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public DescribeRoundPlaysResponse DescribeRoundPlaysSync(DescribeRoundPlaysRequest req)
        {
             JsonResponseModel<DescribeRoundPlaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoundPlays");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoundPlaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of sampled screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public async Task<DescribeSampleSnapshotTemplatesResponse> DescribeSampleSnapshotTemplates(DescribeSampleSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeSampleSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of sampled screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public DescribeSampleSnapshotTemplatesResponse DescribeSampleSnapshotTemplatesSync(DescribeSampleSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeSampleSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of time point screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public async Task<DescribeSnapshotByTimeOffsetTemplatesResponse> DescribeSnapshotByTimeOffsetTemplates(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
             JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotByTimeOffsetTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of time point screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public DescribeSnapshotByTimeOffsetTemplatesResponse DescribeSnapshotByTimeOffsetTemplatesSync(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
             JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotByTimeOffsetTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the storage capacity usage and number of files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public async Task<DescribeStorageDataResponse> DescribeStorageData(DescribeStorageDataRequest req)
        {
             JsonResponseModel<DescribeStorageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStorageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the storage capacity usage and number of files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public DescribeStorageDataResponse DescribeStorageDataSync(DescribeStorageDataRequest req)
        {
             JsonResponseModel<DescribeStorageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStorageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query VOD storage usage in bytes within the query period.
        ///     1. You can only query storage usage for the last 365 days.
        ///     2. The query period is up to 90 days.
        ///     3. The query period at minute-level granularity is up to 7 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public async Task<DescribeStorageDetailsResponse> DescribeStorageDetails(DescribeStorageDetailsRequest req)
        {
             JsonResponseModel<DescribeStorageDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStorageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query VOD storage usage in bytes within the query period.
        ///     1. You can only query storage usage for the last 365 days.
        ///     2. The query period is up to 90 days.
        ///     3. The query period at minute-level granularity is up to 7 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public DescribeStorageDetailsResponse DescribeStorageDetailsSync(DescribeStorageDetailsRequest req)
        {
             JsonResponseModel<DescribeStorageDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStorageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the following information:
        ///   1. All supported storage regions.
        ///   2. The regions you have storage access to currently.
        ///   3. The default storage region.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRegionsRequest"/></param>
        /// <returns><see cref="DescribeStorageRegionsResponse"/></returns>
        public async Task<DescribeStorageRegionsResponse> DescribeStorageRegions(DescribeStorageRegionsRequest req)
        {
             JsonResponseModel<DescribeStorageRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStorageRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the following information:
        ///   1. All supported storage regions.
        ///   2. The regions you have storage access to currently.
        ///   3. The default storage region.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRegionsRequest"/></param>
        /// <returns><see cref="DescribeStorageRegionsResponse"/></returns>
        public DescribeStorageRegionsResponse DescribeStorageRegionsSync(DescribeStorageRegionsRequest req)
        {
             JsonResponseModel<DescribeStorageRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStorageRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of the primary application and subapplications of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public async Task<DescribeSubAppIdsResponse> DescribeSubAppIds(DescribeSubAppIdsRequest req)
        {
             JsonResponseModel<DescribeSubAppIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubAppIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubAppIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of the primary application and subapplications of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public DescribeSubAppIdsResponse DescribeSubAppIdsSync(DescribeSubAppIdsRequest req)
        {
             JsonResponseModel<DescribeSubAppIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubAppIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubAppIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to query player configurations. It supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public async Task<DescribeSuperPlayerConfigsResponse> DescribeSuperPlayerConfigs(DescribeSuperPlayerConfigsRequest req)
        {
             JsonResponseModel<DescribeSuperPlayerConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSuperPlayerConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSuperPlayerConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to query player configurations. It supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public DescribeSuperPlayerConfigsResponse DescribeSuperPlayerConfigsSync(DescribeSuperPlayerConfigsRequest req)
        {
             JsonResponseModel<DescribeSuperPlayerConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSuperPlayerConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSuperPlayerConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of execution status and result of a task submitted in the last 3 days by task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of execution status and result of a task submitted in the last 3 days by task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to query the task list;
        /// * If there are many data entries in the list, one single call of the API may not be able to pull the entire list. The `ScrollToken` parameter can be used to pull the list in batches;
        /// * Only tasks in the last three days (72 hours) can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to query the task list;
        /// * If there are many data entries in the list, one single call of the API may not be able to pull the entire list. The `ScrollToken` parameter can be used to pull the list in batches;
        /// * Only tasks in the last three days (72 hours) can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of transcoding templates based on unique template ID. The return result includes all eligible custom and [preset transcoding templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public async Task<DescribeTranscodeTemplatesResponse> DescribeTranscodeTemplates(DescribeTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of transcoding templates based on unique template ID. The return result includes all eligible custom and [preset transcoding templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public DescribeTranscodeTemplatesResponse DescribeTranscodeTemplatesSync(DescribeTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of VOD domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public async Task<DescribeVodDomainsResponse> DescribeVodDomains(DescribeVodDomainsRequest req)
        {
             JsonResponseModel<DescribeVodDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVodDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVodDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of VOD domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public DescribeVodDomainsResponse DescribeVodDomainsSync(DescribeVodDomainsRequest req)
        {
             JsonResponseModel<DescribeVodDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVodDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVodDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query custom watermarking templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public async Task<DescribeWatermarkTemplatesResponse> DescribeWatermarkTemplates(DescribeWatermarkTemplatesRequest req)
        {
             JsonResponseModel<DescribeWatermarkTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWatermarkTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWatermarkTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query custom watermarking templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public DescribeWatermarkTemplatesResponse DescribeWatermarkTemplatesSync(DescribeWatermarkTemplatesRequest req)
        {
             JsonResponseModel<DescribeWatermarkTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWatermarkTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWatermarkTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to perform paginated queries of keyword sample information by use case, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public async Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
             JsonResponseModel<DescribeWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to perform paginated queries of keyword sample information by use case, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public DescribeWordSamplesResponse DescribeWordSamplesSync(DescribeWordSamplesRequest req)
        {
             JsonResponseModel<DescribeWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is only used in special scenarios of custom development. Unless requested by VOD customer service, please do not call it.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public async Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
             JsonResponseModel<ExecuteFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is only used in special scenarios of custom development. Unless requested by VOD customer service, please do not call it.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
             JsonResponseModel<ExecuteFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to extract the user ID of a user that distributed a video containing a digital watermark.
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public async Task<ExtractTraceWatermarkResponse> ExtractTraceWatermark(ExtractTraceWatermarkRequest req)
        {
             JsonResponseModel<ExtractTraceWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExtractTraceWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExtractTraceWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to extract the user ID of a user that distributed a video containing a digital watermark.
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public ExtractTraceWatermarkResponse ExtractTraceWatermarkSync(ExtractTraceWatermarkRequest req)
        {
             JsonResponseModel<ExtractTraceWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExtractTraceWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExtractTraceWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * After a media file is forbidden, except previewing it in the VOD Console, accessing the URLs of its various resources (such as source file, output files, and screenshots) in other scenarios will return error 403.
        ///   It takes about 5-10 minutes for a forbidding/unblocking operation to take effect across the entire network.
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public async Task<ForbidMediaDistributionResponse> ForbidMediaDistribution(ForbidMediaDistributionRequest req)
        {
             JsonResponseModel<ForbidMediaDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidMediaDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidMediaDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * After a media file is forbidden, except previewing it in the VOD Console, accessing the URLs of its various resources (such as source file, output files, and screenshots) in other scenarios will return error 403.
        ///   It takes about 5-10 minutes for a forbidding/unblocking operation to take effect across the entire network.
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public ForbidMediaDistributionResponse ForbidMediaDistributionSync(ForbidMediaDistributionRequest req)
        {
             JsonResponseModel<ForbidMediaDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForbidMediaDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidMediaDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public async Task<LiveRealTimeClipResponse> LiveRealTimeClip(LiveRealTimeClipRequest req)
        {
             JsonResponseModel<LiveRealTimeClipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LiveRealTimeClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LiveRealTimeClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public LiveRealTimeClipResponse LiveRealTimeClipSync(LiveRealTimeClipRequest req)
        {
             JsonResponseModel<LiveRealTimeClipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LiveRealTimeClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LiveRealTimeClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage initiated tasks.
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public async Task<ManageTaskResponse> ManageTask(ManageTaskRequest req)
        {
             JsonResponseModel<ManageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage initiated tasks.
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public ManageTaskResponse ManageTaskSync(ManageTaskRequest req)
        {
             JsonResponseModel<ManageTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom video content analysis template.
        /// 
        /// Note: templates with an ID below 10000 are preset and cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public async Task<ModifyAIAnalysisTemplateResponse> ModifyAIAnalysisTemplate(ModifyAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<ModifyAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom video content analysis template.
        /// 
        /// Note: templates with an ID below 10000 are preset and cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public ModifyAIAnalysisTemplateResponse ModifyAIAnalysisTemplateSync(ModifyAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<ModifyAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public async Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<ModifyAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public ModifyAIRecognitionTemplateResponse ModifyAIRecognitionTemplateSync(ModifyAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<ModifyAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<ModifyAdaptiveDynamicStreamingTemplateResponse> ModifyAdaptiveDynamicStreamingTemplate(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public ModifyAdaptiveDynamicStreamingTemplateResponse ModifyAdaptiveDynamicStreamingTemplateSync(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<ModifyAnimatedGraphicsTemplateResponse> ModifyAnimatedGraphicsTemplate(ModifyAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public ModifyAnimatedGraphicsTemplateResponse ModifyAnimatedGraphicsTemplateSync(ModifyAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCDNDomainConfig.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDNDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyCDNDomainConfigResponse"/></returns>
        public async Task<ModifyCDNDomainConfigResponse> ModifyCDNDomainConfig(ModifyCDNDomainConfigRequest req)
        {
             JsonResponseModel<ModifyCDNDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCDNDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDNDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCDNDomainConfig.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDNDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyCDNDomainConfigResponse"/></returns>
        public ModifyCDNDomainConfigResponse ModifyCDNDomainConfigSync(ModifyCDNDomainConfigRequest req)
        {
             JsonResponseModel<ModifyCDNDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCDNDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDNDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the category of a media file.
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public async Task<ModifyClassResponse> ModifyClass(ModifyClassRequest req)
        {
             JsonResponseModel<ModifyClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the category of a media file.
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public ModifyClassResponse ModifyClassSync(ModifyClassRequest req)
        {
             JsonResponseModel<ModifyClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [ModifyReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84388?from_cn_redirect=1).
        /// This API is used to modify a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public async Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [ModifyReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84388?from_cn_redirect=1).
        /// This API is used to modify a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default storage region. A file will be stored in the default region if no region is specified for file upload.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public async Task<ModifyDefaultStorageRegionResponse> ModifyDefaultStorageRegion(ModifyDefaultStorageRegionRequest req)
        {
             JsonResponseModel<ModifyDefaultStorageRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDefaultStorageRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultStorageRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default storage region. A file will be stored in the default region if no region is specified for file upload.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public ModifyDefaultStorageRegionResponse ModifyDefaultStorageRegionSync(ModifyDefaultStorageRegionRequest req)
        {
             JsonResponseModel<ModifyDefaultStorageRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDefaultStorageRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultStorageRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public async Task<ModifyImageSpriteTemplateResponse> ModifyImageSpriteTemplate(ModifyImageSpriteTemplateRequest req)
        {
             JsonResponseModel<ModifyImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public ModifyImageSpriteTemplateResponse ModifyImageSpriteTemplateSync(ModifyImageSpriteTemplateRequest req)
        {
             JsonResponseModel<ModifyImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a media file, including category, name, description, tag, expiration time, timestamp information, video thumbnail, and subtitle information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public async Task<ModifyMediaInfoResponse> ModifyMediaInfo(ModifyMediaInfoRequest req)
        {
             JsonResponseModel<ModifyMediaInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a media file, including category, name, description, tag, expiration time, timestamp information, video thumbnail, and subtitle information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public ModifyMediaInfoResponse ModifyMediaInfoSync(ModifyMediaInfoRequest req)
        {
             JsonResponseModel<ModifyMediaInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the storage class of media files.
        /// If the current storage class is STANDARD, it can be changed to one of the following classes:
        /// <li>STANDARD_IA</li>
        /// <li>ARCHIVE</li>
        /// <li>DEEP ARCHIVE</li>
        /// If the current storage class is STANDARD_IA, it can be changed to one of the following classes:
        /// <li>STANDARD</li>
        /// <li>ARCHIVE</li>
        /// <li>DEEP ARCHIVE</li>
        /// If the current storage class is ARCHIVE, it can be changed to the following class:
        /// <li>STANDARD</li>
        /// If the current storage class is DEEP ARCHIVE, it can be changed to the following class:
        /// <li>STANDARD</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaStorageClassRequest"/></param>
        /// <returns><see cref="ModifyMediaStorageClassResponse"/></returns>
        public async Task<ModifyMediaStorageClassResponse> ModifyMediaStorageClass(ModifyMediaStorageClassRequest req)
        {
             JsonResponseModel<ModifyMediaStorageClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaStorageClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaStorageClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the storage class of media files.
        /// If the current storage class is STANDARD, it can be changed to one of the following classes:
        /// <li>STANDARD_IA</li>
        /// <li>ARCHIVE</li>
        /// <li>DEEP ARCHIVE</li>
        /// If the current storage class is STANDARD_IA, it can be changed to one of the following classes:
        /// <li>STANDARD</li>
        /// <li>ARCHIVE</li>
        /// <li>DEEP ARCHIVE</li>
        /// If the current storage class is ARCHIVE, it can be changed to the following class:
        /// <li>STANDARD</li>
        /// If the current storage class is DEEP ARCHIVE, it can be changed to the following class:
        /// <li>STANDARD</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaStorageClassRequest"/></param>
        /// <returns><see cref="ModifyMediaStorageClassResponse"/></returns>
        public ModifyMediaStorageClassResponse ModifyMediaStorageClassSync(ModifyMediaStorageClassRequest req)
        {
             JsonResponseModel<ModifyMediaStorageClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaStorageClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaStorageClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify sample information according to the sample ID. You can modify the name and description, add, delete, and reset facial features or tags. Leave at least one image after deleting facial features. To leave no image, please use the reset operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public async Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
             JsonResponseModel<ModifyPersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify sample information according to the sample ID. You can modify the name and description, add, delete, and reset facial features or tags. Leave at least one image after deleting facial features. To leave no image, please use the reset operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public ModifyPersonSampleResponse ModifyPersonSampleSync(ModifyPersonSampleRequest req)
        {
             JsonResponseModel<ModifyPersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a remaster template.
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public async Task<ModifyRebuildMediaTemplateResponse> ModifyRebuildMediaTemplate(ModifyRebuildMediaTemplateRequest req)
        {
             JsonResponseModel<ModifyRebuildMediaTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRebuildMediaTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRebuildMediaTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a remaster template.
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public ModifyRebuildMediaTemplateResponse ModifyRebuildMediaTemplateSync(ModifyRebuildMediaTemplateRequest req)
        {
             JsonResponseModel<ModifyRebuildMediaTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRebuildMediaTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRebuildMediaTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public async Task<ModifyReviewTemplateResponse> ModifyReviewTemplate(ModifyReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public ModifyReviewTemplateResponse ModifyReviewTemplateSync(ModifyReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a playlist.
        /// The modification will only take effect for new playback requests. For ongoing playback, the old playlist will be playable for seven days after the modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public async Task<ModifyRoundPlayResponse> ModifyRoundPlay(ModifyRoundPlayRequest req)
        {
             JsonResponseModel<ModifyRoundPlayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRoundPlay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoundPlayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a playlist.
        /// The modification will only take effect for new playback requests. For ongoing playback, the old playlist will be playable for seven days after the modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public ModifyRoundPlayResponse ModifyRoundPlaySync(ModifyRoundPlayRequest req)
        {
             JsonResponseModel<ModifyRoundPlayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRoundPlay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoundPlayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public async Task<ModifySampleSnapshotTemplateResponse> ModifySampleSnapshotTemplate(ModifySampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifySampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public ModifySampleSnapshotTemplateResponse ModifySampleSnapshotTemplateSync(ModifySampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifySampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<ModifySnapshotByTimeOffsetTemplateResponse> ModifySnapshotByTimeOffsetTemplate(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public ModifySnapshotByTimeOffsetTemplateResponse ModifySnapshotByTimeOffsetTemplateSync(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify subapplication information, but it is not allowed to modify primary application information.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public async Task<ModifySubAppIdInfoResponse> ModifySubAppIdInfo(ModifySubAppIdInfoRequest req)
        {
             JsonResponseModel<ModifySubAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify subapplication information, but it is not allowed to modify primary application information.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public ModifySubAppIdInfoResponse ModifySubAppIdInfoSync(ModifySubAppIdInfoRequest req)
        {
             JsonResponseModel<ModifySubAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable/disable a subapplication. After a subapplication is disabled, its corresponding domain name will be blocked and its access to the console will be restricted.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public async Task<ModifySubAppIdStatusResponse> ModifySubAppIdStatus(ModifySubAppIdStatusRequest req)
        {
             JsonResponseModel<ModifySubAppIdStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubAppIdStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable/disable a subapplication. After a subapplication is disabled, its corresponding domain name will be blocked and its access to the console will be restricted.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public ModifySubAppIdStatusResponse ModifySubAppIdStatusSync(ModifySubAppIdStatusRequest req)
        {
             JsonResponseModel<ModifySubAppIdStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubAppIdStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to modify a player configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public async Task<ModifySuperPlayerConfigResponse> ModifySuperPlayerConfig(ModifySuperPlayerConfigRequest req)
        {
             JsonResponseModel<ModifySuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to modify a player configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public ModifySuperPlayerConfigResponse ModifySuperPlayerConfigSync(ModifySuperPlayerConfigRequest req)
        {
             JsonResponseModel<ModifySuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public async Task<ModifyTranscodeTemplateResponse> ModifyTranscodeTemplate(ModifyTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public ModifyTranscodeTemplateResponse ModifyTranscodeTemplateSync(ModifyTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the acceleration region of a domain name on VOD.
        /// 1. You can modify acceleration regions of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public async Task<ModifyVodDomainAccelerateConfigResponse> ModifyVodDomainAccelerateConfig(ModifyVodDomainAccelerateConfigRequest req)
        {
             JsonResponseModel<ModifyVodDomainAccelerateConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVodDomainAccelerateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVodDomainAccelerateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the acceleration region of a domain name on VOD.
        /// 1. You can modify acceleration regions of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public ModifyVodDomainAccelerateConfigResponse ModifyVodDomainAccelerateConfigSync(ModifyVodDomainAccelerateConfigRequest req)
        {
             JsonResponseModel<ModifyVodDomainAccelerateConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVodDomainAccelerateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVodDomainAccelerateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify domain name settings, such as the hotlink protection configuration.
        /// 1. You can modify settings of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public async Task<ModifyVodDomainConfigResponse> ModifyVodDomainConfig(ModifyVodDomainConfigRequest req)
        {
             JsonResponseModel<ModifyVodDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVodDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVodDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify domain name settings, such as the hotlink protection configuration.
        /// 1. You can modify settings of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public ModifyVodDomainConfigResponse ModifyVodDomainConfigSync(ModifyVodDomainConfigRequest req)
        {
             JsonResponseModel<ModifyVodDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVodDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVodDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom watermarking template. The watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public async Task<ModifyWatermarkTemplateResponse> ModifyWatermarkTemplate(ModifyWatermarkTemplateRequest req)
        {
             JsonResponseModel<ModifyWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom watermarking template. The watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public ModifyWatermarkTemplateResponse ModifyWatermarkTemplateSync(ModifyWatermarkTemplateRequest req)
        {
             JsonResponseModel<ModifyWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the use case and tag of a keyword. The keyword itself cannot be modified, but you can delete it and create another one if needed.
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public async Task<ModifyWordSampleResponse> ModifyWordSample(ModifyWordSampleRequest req)
        {
             JsonResponseModel<ModifyWordSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWordSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWordSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the use case and tag of a keyword. The keyword itself cannot be modified, but you can delete it and create another one if needed.
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public ModifyWordSampleResponse ModifyWordSampleSync(ModifyWordSampleRequest req)
        {
             JsonResponseModel<ModifyWordSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWordSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWordSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to parse the index file content and return the list of segment files to be uploaded when an HLS video is uploaded. A segment file path must be a relative path of the current directory or subdirectory instead of a URL or absolute path.
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public async Task<ParseStreamingManifestResponse> ParseStreamingManifest(ParseStreamingManifestRequest req)
        {
             JsonResponseModel<ParseStreamingManifestResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseStreamingManifest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseStreamingManifestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to parse the index file content and return the list of segment files to be uploaded when an HLS video is uploaded. A segment file path must be a relative path of the current directory or subdirectory instead of a URL or absolute path.
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public ParseStreamingManifestResponse ParseStreamingManifestSync(ParseStreamingManifestRequest req)
        {
             JsonResponseModel<ParseStreamingManifestResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ParseStreamingManifest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseStreamingManifestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a task flow on a video.
        /// There are two ways to create a task flow template:
        /// 1. Create and modify a task flow template in the console;
        /// 2. Create a task flow template using the `CreateProcedureTemplate` API.
        /// 
        /// If event notifications are used, the event type for moderation tasks is [ReviewAudioVideoComplete](https://intl.cloud.tencent.com/document/product/266/81258?from_cn_redirect=1), and that for other tasks is [ProcedureStateChanged](https://intl.cloud.tencent.com/document/product/266/9636?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public async Task<ProcessMediaByProcedureResponse> ProcessMediaByProcedure(ProcessMediaByProcedureRequest req)
        {
             JsonResponseModel<ProcessMediaByProcedureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessMediaByProcedure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByProcedureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a task flow on a video.
        /// There are two ways to create a task flow template:
        /// 1. Create and modify a task flow template in the console;
        /// 2. Create a task flow template using the `CreateProcedureTemplate` API.
        /// 
        /// If event notifications are used, the event type for moderation tasks is [ReviewAudioVideoComplete](https://intl.cloud.tencent.com/document/product/266/81258?from_cn_redirect=1), and that for other tasks is [ProcedureStateChanged](https://intl.cloud.tencent.com/document/product/266/9636?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public ProcessMediaByProcedureResponse ProcessMediaByProcedureSync(ProcessMediaByProcedureRequest req)
        {
             JsonResponseModel<ProcessMediaByProcedureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ProcessMediaByProcedure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByProcedureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is <font color='red'>disused</font>, please use [ProcessMedia](https://intl.cloud.tencent.com/document/product/862/37578?from_cn_redirect=1) API of MPS, with the input parameter `InputInfo.UrlInputInfo.Url` set to a video URL.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public async Task<ProcessMediaByUrlResponse> ProcessMediaByUrl(ProcessMediaByUrlRequest req)
        {
             JsonResponseModel<ProcessMediaByUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessMediaByUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is <font color='red'>disused</font>, please use [ProcessMedia](https://intl.cloud.tencent.com/document/product/862/37578?from_cn_redirect=1) API of MPS, with the input parameter `InputInfo.UrlInputInfo.Url` set to a video URL.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public ProcessMediaByUrlResponse ProcessMediaByUrlSync(ProcessMediaByUrlRequest req)
        {
             JsonResponseModel<ProcessMediaByUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ProcessMediaByUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to get event notifications from the business server through [reliable callback](https://intl.cloud.tencent.com/document/product/266/33948).
        /// * The API gets event data through long polling. That is, if there is any unconsumed event on the server, the event notification will be returned to the requester immediately. If there is no unconsumed event on the server, the request will be suspended in the backend until a new event is generated.
        /// * The request can be suspended for up to 5 seconds. It’s recommended to set the request timeout period to 10 seconds.
        /// * Event notifications not pulled will be retained for up to 4 days and may be cleared after this period.
        /// * After the API returns an event, the caller must call the [ConfirmEvents](https://intl.cloud.tencent.com/document/product/266/34184) API within <font color="red">30 seconds</font> to confirm that the event notification has been processed. Otherwise, the event notification will be pulled again after <font color="red">30 seconds</font>.
        /// * This API can get up to 16 event notifications at a time.
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public async Task<PullEventsResponse> PullEvents(PullEventsRequest req)
        {
             JsonResponseModel<PullEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * This API is used to get event notifications from the business server through [reliable callback](https://intl.cloud.tencent.com/document/product/266/33948).
        /// * The API gets event data through long polling. That is, if there is any unconsumed event on the server, the event notification will be returned to the requester immediately. If there is no unconsumed event on the server, the request will be suspended in the backend until a new event is generated.
        /// * The request can be suspended for up to 5 seconds. It’s recommended to set the request timeout period to 10 seconds.
        /// * Event notifications not pulled will be retained for up to 4 days and may be cleared after this period.
        /// * After the API returns an event, the caller must call the [ConfirmEvents](https://intl.cloud.tencent.com/document/product/266/34184) API within <font color="red">30 seconds</font> to confirm that the event notification has been processed. Otherwise, the event notification will be pulled again after <font color="red">30 seconds</font>.
        /// * This API can get up to 16 event notifications at a time.
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public PullEventsResponse PullEventsSync(PullEventsRequest req)
        {
             JsonResponseModel<PullEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull a video on the internet to the VOD platform.
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public async Task<PullUploadResponse> PullUpload(PullUploadRequest req)
        {
             JsonResponseModel<PullUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull a video on the internet to the VOD platform.
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public PullUploadResponse PullUploadSync(PullUploadRequest req)
        {
             JsonResponseModel<PullUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. This API is used to prefetch a list of specified URLs.
        /// 2. The URL domain names must have already been registered with VOD.
        /// 3. Up to 20 URLs can be specified in one request.
        /// 4. By default, the maximum number of URLs that can be refreshed per day is 10,000.
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public async Task<PushUrlCacheResponse> PushUrlCache(PushUrlCacheRequest req)
        {
             JsonResponseModel<PushUrlCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushUrlCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. This API is used to prefetch a list of specified URLs.
        /// 2. The URL domain names must have already been registered with VOD.
        /// 3. Up to 20 URLs can be specified in one request.
        /// 4. By default, the maximum number of URLs that can be refreshed per day is 10,000.
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public PushUrlCacheResponse PushUrlCacheSync(PushUrlCacheRequest req)
        {
             JsonResponseModel<PushUrlCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushUrlCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remaster audio/video.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public async Task<RebuildMediaResponse> RebuildMedia(RebuildMediaRequest req)
        {
             JsonResponseModel<RebuildMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebuildMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebuildMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remaster audio/video.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public RebuildMediaResponse RebuildMediaSync(RebuildMediaRequest req)
        {
             JsonResponseModel<RebuildMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebuildMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebuildMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a remaster task using a template.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public async Task<RebuildMediaByTemplateResponse> RebuildMediaByTemplate(RebuildMediaByTemplateRequest req)
        {
             JsonResponseModel<RebuildMediaByTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebuildMediaByTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebuildMediaByTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a remaster task using a template.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public RebuildMediaByTemplateResponse RebuildMediaByTemplateSync(RebuildMediaByTemplateRequest req)
        {
             JsonResponseModel<RebuildMediaByTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebuildMediaByTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebuildMediaByTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. This API is used to purge URLs.
        /// 2. The URL domain names must have already been registered with VOD.
        /// 3. Up to 20 URLs can be specified in one request.
        /// 4. By default, the maximum number of URLs allowed for purge per day is 100,000.
        /// </summary>
        /// <param name="req"><see cref="RefreshUrlCacheRequest"/></param>
        /// <returns><see cref="RefreshUrlCacheResponse"/></returns>
        public async Task<RefreshUrlCacheResponse> RefreshUrlCache(RefreshUrlCacheRequest req)
        {
             JsonResponseModel<RefreshUrlCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefreshUrlCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshUrlCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. This API is used to purge URLs.
        /// 2. The URL domain names must have already been registered with VOD.
        /// 3. Up to 20 URLs can be specified in one request.
        /// 4. By default, the maximum number of URLs allowed for purge per day is 100,000.
        /// </summary>
        /// <param name="req"><see cref="RefreshUrlCacheRequest"/></param>
        /// <returns><see cref="RefreshUrlCacheResponse"/></returns>
        public RefreshUrlCacheResponse RefreshUrlCacheSync(RefreshUrlCacheRequest req)
        {
             JsonResponseModel<RefreshUrlCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefreshUrlCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshUrlCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove watermarks from a video.
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public async Task<RemoveWatermarkResponse> RemoveWatermark(RemoveWatermarkRequest req)
        {
             JsonResponseModel<RemoveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove watermarks from a video.
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public RemoveWatermarkResponse RemoveWatermarkSync(RemoveWatermarkRequest req)
        {
             JsonResponseModel<RemoveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom task flow template.
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public async Task<ResetProcedureTemplateResponse> ResetProcedureTemplate(ResetProcedureTemplateRequest req)
        {
             JsonResponseModel<ResetProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom task flow template.
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public ResetProcedureTemplateResponse ResetProcedureTemplateSync(ResetProcedureTemplateRequest req)
        {
             JsonResponseModel<ResetProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore files from ARCHIVE or DEEP ARCHIVE. Files stored in ARCHIVE or DEEP ARCHIVE must be restored before they can be accessed. Restored files are available for a limited period of time.
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public async Task<RestoreMediaResponse> RestoreMedia(RestoreMediaRequest req)
        {
             JsonResponseModel<RestoreMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore files from ARCHIVE or DEEP ARCHIVE. Files stored in ARCHIVE or DEEP ARCHIVE must be restored before they can be accessed. Restored files are available for a limited period of time.
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public RestoreMediaResponse RestoreMediaSync(RestoreMediaRequest req)
        {
             JsonResponseModel<RestoreMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a moderation task on a file stored in VOD to detect non-compliant content in images, text, speech, and voice.
        /// 
        /// If event notifications are used, the event type is [ReviewAudioVideoComplete](https://intl.cloud.tencent.com/document/product/266/81258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReviewAudioVideoRequest"/></param>
        /// <returns><see cref="ReviewAudioVideoResponse"/></returns>
        public async Task<ReviewAudioVideoResponse> ReviewAudioVideo(ReviewAudioVideoRequest req)
        {
             JsonResponseModel<ReviewAudioVideoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReviewAudioVideo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReviewAudioVideoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a moderation task on a file stored in VOD to detect non-compliant content in images, text, speech, and voice.
        /// 
        /// If event notifications are used, the event type is [ReviewAudioVideoComplete](https://intl.cloud.tencent.com/document/product/266/81258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReviewAudioVideoRequest"/></param>
        /// <returns><see cref="ReviewAudioVideoResponse"/></returns>
        public ReviewAudioVideoResponse ReviewAudioVideoSync(ReviewAudioVideoRequest req)
        {
             JsonResponseModel<ReviewAudioVideoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReviewAudioVideo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReviewAudioVideoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to moderate an image stored in VOD (detect pornographic and terrorist content).><li>The image file must be smaller than 5 MB.</li> ><li>To ensure the accuracy of moderation results, the image resolution must be higher than 256 x 256 px.</li> ><li>The format must be PNG, JPG, JPEG, BMP, GIF, or WEBP.</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public async Task<ReviewImageResponse> ReviewImage(ReviewImageRequest req)
        {
             JsonResponseModel<ReviewImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReviewImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReviewImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to moderate an image stored in VOD (detect pornographic and terrorist content).><li>The image file must be smaller than 5 MB.</li> ><li>To ensure the accuracy of moderation results, the image resolution must be higher than 256 x 256 px.</li> ><li>The format must be PNG, JPG, JPEG, BMP, GIF, or WEBP.</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public ReviewImageResponse ReviewImageSync(ReviewImageRequest req)
        {
             JsonResponseModel<ReviewImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReviewImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReviewImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for media files by specific criteria. You can sort the results and specify the information to return.
        /// - Specify a list of file IDs (`FileIds`). Any file that matches one of the IDs will be returned.
        /// - Specify one or multiple keywords for `Names` or `Descriptions` for fuzzy search by filename or description.
        /// - Specify multiple filename prefixes (`NamePrefixes`).
        /// - Specify a list of categories (`ClassIds`). Any file that matches one of the categories will be returned. For example, assume that there are categories `Movies`, `TV Series`, and `Variety Shows`, and `Movies` has subcategories including `History`, `Action`, and `Romance`. If `ClassIds` is set to `Movies` and `TV Series`, all media files in `Movies` (including its subcategories) and `TV Series` will be returned. If `ClassIds` is set to `History` and `Action`, only the files in those two subcategories will be returned.
        /// - Specify a list of labels (`Tags`). Any file that matches one or more of the labels will be returned. For example, assume that there are labels `ACG`, `Drama`, and `YTPMV`. If `Tags` is set to `ACG` and `YTPMV`, any media file with either label will be returned.
        /// - Specify the types (`Categories`) of media files. Any file that matches one of the types will be returned. There are three file types: `Video`, `Audio`, and `Image`. If `Categories` is set to `Video` and `Audio`, all audio and video files will be returned.
        /// - Specify the source types (`SourceTypes`). Any file that matches one of the source types specified will be returned. For example, if you set `SourceTypes` to `Record` (live recording) and `Upload` (upload), all recording files and uploaded files will be returned.
        /// - Specify the file formats (`MediaTypes`), such as MP4, AVI, and MP3. All files in the specified formats will be returned. For example, if you set `MediaTypes` to MP4 and MP3, all files in these two formats will be returned.
        /// - Specify the file statuses (`Status`). Files in the specified statuses will be returned. Valid values: `Normal`, `SystemForbidden` (blocked by VOD), `Forbidden` (blocked by you). If you set `Status` to `Normal` and `Forbidden`, files in either status will be returned.
        /// - Specify the types of moderation results (`ReviewResults`). Files that have the specified types of moderation results will be returned. Valid values include `pass`, `block`, and more. If you set `ReviewResults` to `pass` and `block`, files whose moderation result is "pass" or "block" will be returned.
        /// - Specify the stream IDs (`StreamIds`) of live recording files.
        /// - Specify a time range for search by file creation time.
        /// - Specify the TRTC application IDs.
        /// - Specify the TRTC room IDs.
        /// - Specify one keyword for `Text` for fuzzy search by filename or description. (This is not recommended. Please use `Names`, `NamePrefixes` or `Descriptions` instead.)
        /// - Specify one source (`SourceType`). (This is not recommended. Please use `SourceTypes` instead.)
        /// - Specify one stream ID (`StreamId`). (This is not recommended. Please use `StreamIds` instead.)
        /// - Specify the start (`StartTime`) of the time range to search by creation time. (This is not recommended. Please use `CreateTime` instead.)
        /// - Specify the end (`EndTime`) of the time range to search by creation time. (This is not recommended. Please use `CreateTime` instead.)
        /// - You can search by any combination of the parameters above. For example, you can search for media files with the label "Drama" or "Suspense" in the category of "Movies" and "TV Series" created between 12:00:00, December 1, 2018 and 12:00:00, December 8, 2018. Note that for parameters whose data type is array, the search logic between their elements is "OR". The search logic between parameters is "AND".
        /// 
        /// - You can sort the results by creation time and return them in multiple pages by specifying `Offset` and `Limit`.
        /// - You can use `Filters` to specify the types of file information to return (all types are returned by default). Valid values:
        ///     1. `basicInfo`: The file name, category, playback URL, thumbnail, etc.
        ///     2. `metaData`: The file size, duration, video stream information, audio stream information, etc.
        ///     3. `transcodeInfo`: The URLs, video stream parameters, and audio stream parameters of transcoding outputs.
        ///     4. `animatedGraphicsInfo`: The information of the animated images (such as GIF images) generated.
        ///     5. `sampleSnapshotInfo`: The information of the sampled screenshots generated.
        ///     6. `imageSpriteInfo`: The information of the image sprites generated.
        ///     7. `snapshotByTimeOffsetInfo`: The information of the time point screenshots generated.
        ///     8. `keyFrameDescInfo`: The video timestamp information.
        ///     9. `adaptiveDynamicStreamingInfo`: The specification, encryption type, format, etc.
        /// 
        /// <div id="maxResultsDesc">Limits for returned records:</div>
        /// - The <b><a href="#p_offset">Offset</a> and <a href="#p_limit">Limit</a> parameters determine the number of records per page. If neither parameter is passed, this API will return up to 10 records.</b>
        /// - <b>Up to 5,000 records can be returned. If a request returns too many records, we recommend you use more specific search criteria to narrow down the results.</b>
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public async Task<SearchMediaResponse> SearchMedia(SearchMediaRequest req)
        {
             JsonResponseModel<SearchMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for media files by specific criteria. You can sort the results and specify the information to return.
        /// - Specify a list of file IDs (`FileIds`). Any file that matches one of the IDs will be returned.
        /// - Specify one or multiple keywords for `Names` or `Descriptions` for fuzzy search by filename or description.
        /// - Specify multiple filename prefixes (`NamePrefixes`).
        /// - Specify a list of categories (`ClassIds`). Any file that matches one of the categories will be returned. For example, assume that there are categories `Movies`, `TV Series`, and `Variety Shows`, and `Movies` has subcategories including `History`, `Action`, and `Romance`. If `ClassIds` is set to `Movies` and `TV Series`, all media files in `Movies` (including its subcategories) and `TV Series` will be returned. If `ClassIds` is set to `History` and `Action`, only the files in those two subcategories will be returned.
        /// - Specify a list of labels (`Tags`). Any file that matches one or more of the labels will be returned. For example, assume that there are labels `ACG`, `Drama`, and `YTPMV`. If `Tags` is set to `ACG` and `YTPMV`, any media file with either label will be returned.
        /// - Specify the types (`Categories`) of media files. Any file that matches one of the types will be returned. There are three file types: `Video`, `Audio`, and `Image`. If `Categories` is set to `Video` and `Audio`, all audio and video files will be returned.
        /// - Specify the source types (`SourceTypes`). Any file that matches one of the source types specified will be returned. For example, if you set `SourceTypes` to `Record` (live recording) and `Upload` (upload), all recording files and uploaded files will be returned.
        /// - Specify the file formats (`MediaTypes`), such as MP4, AVI, and MP3. All files in the specified formats will be returned. For example, if you set `MediaTypes` to MP4 and MP3, all files in these two formats will be returned.
        /// - Specify the file statuses (`Status`). Files in the specified statuses will be returned. Valid values: `Normal`, `SystemForbidden` (blocked by VOD), `Forbidden` (blocked by you). If you set `Status` to `Normal` and `Forbidden`, files in either status will be returned.
        /// - Specify the types of moderation results (`ReviewResults`). Files that have the specified types of moderation results will be returned. Valid values include `pass`, `block`, and more. If you set `ReviewResults` to `pass` and `block`, files whose moderation result is "pass" or "block" will be returned.
        /// - Specify the stream IDs (`StreamIds`) of live recording files.
        /// - Specify a time range for search by file creation time.
        /// - Specify the TRTC application IDs.
        /// - Specify the TRTC room IDs.
        /// - Specify one keyword for `Text` for fuzzy search by filename or description. (This is not recommended. Please use `Names`, `NamePrefixes` or `Descriptions` instead.)
        /// - Specify one source (`SourceType`). (This is not recommended. Please use `SourceTypes` instead.)
        /// - Specify one stream ID (`StreamId`). (This is not recommended. Please use `StreamIds` instead.)
        /// - Specify the start (`StartTime`) of the time range to search by creation time. (This is not recommended. Please use `CreateTime` instead.)
        /// - Specify the end (`EndTime`) of the time range to search by creation time. (This is not recommended. Please use `CreateTime` instead.)
        /// - You can search by any combination of the parameters above. For example, you can search for media files with the label "Drama" or "Suspense" in the category of "Movies" and "TV Series" created between 12:00:00, December 1, 2018 and 12:00:00, December 8, 2018. Note that for parameters whose data type is array, the search logic between their elements is "OR". The search logic between parameters is "AND".
        /// 
        /// - You can sort the results by creation time and return them in multiple pages by specifying `Offset` and `Limit`.
        /// - You can use `Filters` to specify the types of file information to return (all types are returned by default). Valid values:
        ///     1. `basicInfo`: The file name, category, playback URL, thumbnail, etc.
        ///     2. `metaData`: The file size, duration, video stream information, audio stream information, etc.
        ///     3. `transcodeInfo`: The URLs, video stream parameters, and audio stream parameters of transcoding outputs.
        ///     4. `animatedGraphicsInfo`: The information of the animated images (such as GIF images) generated.
        ///     5. `sampleSnapshotInfo`: The information of the sampled screenshots generated.
        ///     6. `imageSpriteInfo`: The information of the image sprites generated.
        ///     7. `snapshotByTimeOffsetInfo`: The information of the time point screenshots generated.
        ///     8. `keyFrameDescInfo`: The video timestamp information.
        ///     9. `adaptiveDynamicStreamingInfo`: The specification, encryption type, format, etc.
        /// 
        /// <div id="maxResultsDesc">Limits for returned records:</div>
        /// - The <b><a href="#p_offset">Offset</a> and <a href="#p_limit">Limit</a> parameters determine the number of records per page. If neither parameter is passed, this API will return up to 10 records.</b>
        /// - <b>Up to 5,000 records can be returned. If a request returns too many records, we recommend you use more specific search criteria to narrow down the results.</b>
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public SearchMediaResponse SearchMediaSync(SearchMediaRequest req)
        {
             JsonResponseModel<SearchMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure DRM key information.
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public async Task<SetDrmKeyProviderInfoResponse> SetDrmKeyProviderInfo(SetDrmKeyProviderInfoRequest req)
        {
             JsonResponseModel<SetDrmKeyProviderInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetDrmKeyProviderInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDrmKeyProviderInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure DRM key information.
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public SetDrmKeyProviderInfoResponse SetDrmKeyProviderInfoSync(SetDrmKeyProviderInfoRequest req)
        {
             JsonResponseModel<SetDrmKeyProviderInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetDrmKeyProviderInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDrmKeyProviderInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cut a clip from an HLS video to generate a new video (in HLS format). You can either share the new video or save it.
        /// 
        /// VOD supports two types of clipping:
        /// - Clipping for persistent storage: The video clip is saved as an independent video file with its own `FileId`.
        /// - Clipping for temporary sharing: The video clip shares `FileId` with the input file.
        /// 
        /// Notes:
        /// - Clipping is based on the M3U8 file that contains a list of TS segments, so the smallest clipping unit is one TS segment instead of a second or less.
        /// 
        /// 
        /// ### Clipping for persistent storage
        /// In this mode, a video clip is saved as an independent video file with a `FileId`, and its lifecycle is not subject to the input video. Even if the source video is deleted, the video clip still exists. Moreover, the video clip can be transcoded, published on WeChat, and processed in other ways.
        /// 
        /// Suppose you recorded a two-hour football match. You want to save the full video for only two months to save costs, but want to save the highlights for a longer time and perhaps transcode and publish the highlight clip to WeChat. In this case, you can choose clipping for persistent storage.
        /// 
        /// The advantage of clipping for persistent storage is that the video clip has a lifecycle independent of the input video and can be managed independently and stored persistently.
        /// 
        /// ### Clipping for temporary sharing
        /// The video clip (an M3U8 file) shares the same TS segments with the input video instead of being an independent video. It only has a playback URL but has no `FileId`, and its validity period is the same as that of the input video. Once the input video is deleted, the video clip cannot be played back.
        /// 
        /// Because the video clip is not an independent video, it’s not displayed as a media asset in the VOD console, and cannot be transcoded or published to WeChat.
        /// 
        /// Clipping for temporary sharing is lightweight and incurs no additional storage fees. However, the video clip has the same lifecycle as the source recording video and cannot be transcoded or processed in other ways.
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public async Task<SimpleHlsClipResponse> SimpleHlsClip(SimpleHlsClipRequest req)
        {
             JsonResponseModel<SimpleHlsClipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SimpleHlsClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SimpleHlsClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cut a clip from an HLS video to generate a new video (in HLS format). You can either share the new video or save it.
        /// 
        /// VOD supports two types of clipping:
        /// - Clipping for persistent storage: The video clip is saved as an independent video file with its own `FileId`.
        /// - Clipping for temporary sharing: The video clip shares `FileId` with the input file.
        /// 
        /// Notes:
        /// - Clipping is based on the M3U8 file that contains a list of TS segments, so the smallest clipping unit is one TS segment instead of a second or less.
        /// 
        /// 
        /// ### Clipping for persistent storage
        /// In this mode, a video clip is saved as an independent video file with a `FileId`, and its lifecycle is not subject to the input video. Even if the source video is deleted, the video clip still exists. Moreover, the video clip can be transcoded, published on WeChat, and processed in other ways.
        /// 
        /// Suppose you recorded a two-hour football match. You want to save the full video for only two months to save costs, but want to save the highlights for a longer time and perhaps transcode and publish the highlight clip to WeChat. In this case, you can choose clipping for persistent storage.
        /// 
        /// The advantage of clipping for persistent storage is that the video clip has a lifecycle independent of the input video and can be managed independently and stored persistently.
        /// 
        /// ### Clipping for temporary sharing
        /// The video clip (an M3U8 file) shares the same TS segments with the input video instead of being an independent video. It only has a playback URL but has no `FileId`, and its validity period is the same as that of the input video. Once the input video is deleted, the video clip cannot be played back.
        /// 
        /// Because the video clip is not an independent video, it’s not displayed as a media asset in the VOD console, and cannot be transcoded or published to WeChat.
        /// 
        /// Clipping for temporary sharing is lightweight and incurs no additional storage fees. However, the video clip has the same lifecycle as the source recording video and cannot be transcoded or processed in other ways.
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public SimpleHlsClipResponse SimpleHlsClipSync(SimpleHlsClipRequest req)
        {
             JsonResponseModel<SimpleHlsClipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SimpleHlsClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SimpleHlsClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This interface is used to enable/disable CDN accelerated domain names.
        /// </summary>
        /// <param name="req"><see cref="StartCDNDomainRequest"/></param>
        /// <returns><see cref="StartCDNDomainResponse"/></returns>
        public async Task<StartCDNDomainResponse> StartCDNDomain(StartCDNDomainRequest req)
        {
             JsonResponseModel<StartCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This interface is used to enable/disable CDN accelerated domain names.
        /// </summary>
        /// <param name="req"><see cref="StartCDNDomainRequest"/></param>
        /// <returns><see cref="StartCDNDomainResponse"/></returns>
        public StartCDNDomainResponse StartCDNDomainSync(StartCDNDomainRequest req)
        {
             JsonResponseModel<StartCDNDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartCDNDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCDNDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
