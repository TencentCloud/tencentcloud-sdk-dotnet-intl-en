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
       private const string sdkVersion = "SDK_NET_3.0.1009";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// * This API is used to apply for uploading a media file (and cover file) to VOD and obtain the metadata of file storage (including upload path and upload signature) for subsequent use by the uploading API.
        /// * For the detailed upload process, please see [Overview of Upload from Client](https://intl.cloud.tencent.com/document/product/266/9759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public Task<ApplyUploadResponse> ApplyUpload(ApplyUploadRequest req)
        {
            return InternalRequestAsync<ApplyUploadResponse>(req, "ApplyUpload");
        }

        /// <summary>
        /// * This API is used to apply for uploading a media file (and cover file) to VOD and obtain the metadata of file storage (including upload path and upload signature) for subsequent use by the uploading API.
        /// * For the detailed upload process, please see [Overview of Upload from Client](https://intl.cloud.tencent.com/document/product/266/9759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public ApplyUploadResponse ApplyUploadSync(ApplyUploadRequest req)
        {
            return InternalRequestAsync<ApplyUploadResponse>(req, "ApplyUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate/disassociate subtitles with/from a media file of a specific adaptive bitrate streaming template ID.
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public Task<AttachMediaSubtitlesResponse> AttachMediaSubtitles(AttachMediaSubtitlesRequest req)
        {
            return InternalRequestAsync<AttachMediaSubtitlesResponse>(req, "AttachMediaSubtitles");
        }

        /// <summary>
        /// This API is used to associate/disassociate subtitles with/from a media file of a specific adaptive bitrate streaming template ID.
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public AttachMediaSubtitlesResponse AttachMediaSubtitlesSync(AttachMediaSubtitlesRequest req)
        {
            return InternalRequestAsync<AttachMediaSubtitlesResponse>(req, "AttachMediaSubtitles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Clone CDN Domain.
        /// </summary>
        /// <param name="req"><see cref="CloneCDNDomainRequest"/></param>
        /// <returns><see cref="CloneCDNDomainResponse"/></returns>
        public Task<CloneCDNDomainResponse> CloneCDNDomain(CloneCDNDomainRequest req)
        {
            return InternalRequestAsync<CloneCDNDomainResponse>(req, "CloneCDNDomain");
        }

        /// <summary>
        /// Clone CDN Domain.
        /// </summary>
        /// <param name="req"><see cref="CloneCDNDomainRequest"/></param>
        /// <returns><see cref="CloneCDNDomainResponse"/></returns>
        public CloneCDNDomainResponse CloneCDNDomainSync(CloneCDNDomainRequest req)
        {
            return InternalRequestAsync<CloneCDNDomainResponse>(req, "CloneCDNDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to confirm the result of uploading a media file (and cover file) to VOD, store the media information, and return the playback address and ID of the file.
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public Task<CommitUploadResponse> CommitUpload(CommitUploadRequest req)
        {
            return InternalRequestAsync<CommitUploadResponse>(req, "CommitUpload");
        }

        /// <summary>
        /// This API is used to confirm the result of uploading a media file (and cover file) to VOD, store the media information, and return the playback address and ID of the file.
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public CommitUploadResponse CommitUploadSync(CommitUploadRequest req)
        {
            return InternalRequestAsync<CommitUploadResponse>(req, "CommitUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<ComposeMediaResponse> ComposeMedia(ComposeMediaRequest req)
        {
            return InternalRequestAsync<ComposeMediaResponse>(req, "ComposeMedia");
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
            return InternalRequestAsync<ComposeMediaResponse>(req, "ComposeMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * After the `PullEvents` API is called to get an event, this API must be called to confirm that the message has been received;
        /// * After the event handler is obtained, the validity period of waiting for confirmation is 30 seconds. If the wait exceeds 30 seconds, a parameter error will be reported (4000);
        /// * For more information, please see the [reliable callback](https://intl.cloud.tencent.com/document/product/266/33779?from_cn_redirect=1#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) of event notification.
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public Task<ConfirmEventsResponse> ConfirmEvents(ConfirmEventsRequest req)
        {
            return InternalRequestAsync<ConfirmEventsResponse>(req, "ConfirmEvents");
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
            return InternalRequestAsync<ConfirmEventsResponse>(req, "ConfirmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom video content analysis template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate");
        }

        /// <summary>
        /// This API is used to create a custom video content analysis template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom video content recognition template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to create a custom video content recognition template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public CreateAIRecognitionTemplateResponse CreateAIRecognitionTemplateSync(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an adaptive bitrate streaming template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<CreateAdaptiveDynamicStreamingTemplateResponse> CreateAdaptiveDynamicStreamingTemplate(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<CreateAdaptiveDynamicStreamingTemplateResponse>(req, "CreateAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// This API is used to create an adaptive bitrate streaming template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public CreateAdaptiveDynamicStreamingTemplateResponse CreateAdaptiveDynamicStreamingTemplateSync(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<CreateAdaptiveDynamicStreamingTemplateResponse>(req, "CreateAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom animated image generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public Task<CreateAnimatedGraphicsTemplateResponse> CreateAnimatedGraphicsTemplate(CreateAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<CreateAnimatedGraphicsTemplateResponse>(req, "CreateAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// This API is used to create a custom animated image generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public CreateAnimatedGraphicsTemplateResponse CreateAnimatedGraphicsTemplateSync(CreateAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<CreateAnimatedGraphicsTemplateResponse>(req, "CreateAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for adding domain names to VOD. A user can add up to 20 domain names. 1. After the domain name is added successfully, VOD will carry out the deployment of the domain name. It takes approximately 2 minutes for the domain name to change from the deployment status to the online status.
        /// </summary>
        /// <param name="req"><see cref="CreateCDNDomainRequest"/></param>
        /// <returns><see cref="CreateCDNDomainResponse"/></returns>
        public Task<CreateCDNDomainResponse> CreateCDNDomain(CreateCDNDomainRequest req)
        {
            return InternalRequestAsync<CreateCDNDomainResponse>(req, "CreateCDNDomain");
        }

        /// <summary>
        /// This API is used for adding domain names to VOD. A user can add up to 20 domain names. 1. After the domain name is added successfully, VOD will carry out the deployment of the domain name. It takes approximately 2 minutes for the domain name to change from the deployment status to the online status.
        /// </summary>
        /// <param name="req"><see cref="CreateCDNDomainRequest"/></param>
        /// <returns><see cref="CreateCDNDomainResponse"/></returns>
        public CreateCDNDomainResponse CreateCDNDomainSync(CreateCDNDomainRequest req)
        {
            return InternalRequestAsync<CreateCDNDomainResponse>(req, "CreateCDNDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * This API is used to categorize media assets for management;
        /// * It does not affect the categories of existing media assets. If you want to modify the category of a media asset, call the [ModifyMediaInfo](https://intl.cloud.tencent.com/document/product/266/31762?from_cn_redirect=1) API.
        /// * There can be up to 4 levels of categories.
        /// * One category can have up to 500 subcategories under it.
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass");
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
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [CreateReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84391?from_cn_redirect=1).
        /// This API is used to create a custom audio/video moderation template. Up to 50 templates can be created in total.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate");
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [CreateReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84391?from_cn_redirect=1).
        /// This API is used to create a custom audio/video moderation template. Up to 50 templates can be created in total.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for generating a subdomain resolution, prompting the customer to add it to the domain name resolution, used for wildcard domain and domain name retrieval verification of ownership.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateDomainVerifyRecordResponse"/></returns>
        public Task<CreateDomainVerifyRecordResponse> CreateDomainVerifyRecord(CreateDomainVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateDomainVerifyRecordResponse>(req, "CreateDomainVerifyRecord");
        }

        /// <summary>
        /// This API is used for generating a subdomain resolution, prompting the customer to add it to the domain name resolution, used for wildcard domain and domain name retrieval verification of ownership.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateDomainVerifyRecordResponse"/></returns>
        public CreateDomainVerifyRecordResponse CreateDomainVerifyRecordSync(CreateDomainVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateDomainVerifyRecordResponse>(req, "CreateDomainVerifyRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create enhance media template.
        /// </summary>
        /// <param name="req"><see cref="CreateEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateEnhanceMediaTemplateResponse"/></returns>
        public Task<CreateEnhanceMediaTemplateResponse> CreateEnhanceMediaTemplate(CreateEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateEnhanceMediaTemplateResponse>(req, "CreateEnhanceMediaTemplate");
        }

        /// <summary>
        /// Create enhance media template.
        /// </summary>
        /// <param name="req"><see cref="CreateEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateEnhanceMediaTemplateResponse"/></returns>
        public CreateEnhanceMediaTemplateResponse CreateEnhanceMediaTemplateSync(CreateEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateEnhanceMediaTemplateResponse>(req, "CreateEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create HeadTail Template.
        /// </summary>
        /// <param name="req"><see cref="CreateHeadTailTemplateRequest"/></param>
        /// <returns><see cref="CreateHeadTailTemplateResponse"/></returns>
        public Task<CreateHeadTailTemplateResponse> CreateHeadTailTemplate(CreateHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<CreateHeadTailTemplateResponse>(req, "CreateHeadTailTemplate");
        }

        /// <summary>
        /// Create HeadTail Template.
        /// </summary>
        /// <param name="req"><see cref="CreateHeadTailTemplateRequest"/></param>
        /// <returns><see cref="CreateHeadTailTemplateResponse"/></returns>
        public CreateHeadTailTemplateResponse CreateHeadTailTemplateSync(CreateHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<CreateHeadTailTemplateResponse>(req, "CreateHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom image processing template. A template can include at most 10 operations, for example, crop-scale-crop-blur-scale-crop-scale-crop-blur-scale. You can have up to 16 image processing templates.
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public Task<CreateImageProcessingTemplateResponse> CreateImageProcessingTemplate(CreateImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageProcessingTemplateResponse>(req, "CreateImageProcessingTemplate");
        }

        /// <summary>
        /// This API is used to create a custom image processing template. A template can include at most 10 operations, for example, crop-scale-crop-blur-scale-crop-scale-crop-blur-scale. You can have up to 16 image processing templates.
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public CreateImageProcessingTemplateResponse CreateImageProcessingTemplateSync(CreateImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageProcessingTemplateResponse>(req, "CreateImageProcessingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom image sprite generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public Task<CreateImageSpriteTemplateResponse> CreateImageSpriteTemplate(CreateImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageSpriteTemplateResponse>(req, "CreateImageSpriteTemplate");
        }

        /// <summary>
        /// This API is used to create a custom image sprite generating template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public CreateImageSpriteTemplateResponse CreateImageSpriteTemplateSync(CreateImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageSpriteTemplateResponse>(req, "CreateImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Just In Time Transcode Template.
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<CreateJustInTimeTranscodeTemplateResponse> CreateJustInTimeTranscodeTemplate(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// Create Just In Time Transcode Template.
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public CreateJustInTimeTranscodeTemplateResponse CreateJustInTimeTranscodeTemplateSync(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create samples for using facial features positioning and other technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample");
        }

        /// <summary>
        /// This API is used to create samples for using facial features positioning and other technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom task flow template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public Task<CreateProcedureTemplateResponse> CreateProcedureTemplate(CreateProcedureTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcedureTemplateResponse>(req, "CreateProcedureTemplate");
        }

        /// <summary>
        /// This API is used to create a custom task flow template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public CreateProcedureTemplateResponse CreateProcedureTemplateSync(CreateProcedureTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcedureTemplateResponse>(req, "CreateProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="CreateQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityInspectTemplateResponse"/></returns>
        public Task<CreateQualityInspectTemplateResponse> CreateQualityInspectTemplate(CreateQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityInspectTemplateResponse>(req, "CreateQualityInspectTemplate");
        }

        /// <summary>
        /// Creates media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="CreateQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityInspectTemplateResponse"/></returns>
        public CreateQualityInspectTemplateResponse CreateQualityInspectTemplateSync(CreateQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityInspectTemplateResponse>(req, "CreateQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create rebuild media template.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public Task<CreateRebuildMediaTemplateResponse> CreateRebuildMediaTemplate(CreateRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateRebuildMediaTemplateResponse>(req, "CreateRebuildMediaTemplate");
        }

        /// <summary>
        /// Create rebuild media template.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public CreateRebuildMediaTemplateResponse CreateRebuildMediaTemplateSync(CreateRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateRebuildMediaTemplateResponse>(req, "CreateRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom moderation template. Up to 50 templates can be created in total.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public Task<CreateReviewTemplateResponse> CreateReviewTemplate(CreateReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateReviewTemplateResponse>(req, "CreateReviewTemplate");
        }

        /// <summary>
        /// This API is used to create a custom moderation template. Up to 50 templates can be created in total.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public CreateReviewTemplateResponse CreateReviewTemplateSync(CreateReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateReviewTemplateResponse>(req, "CreateReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a playlist. You can create at most 100 playlists.
        /// For each video on the list, you can either use the original file or a transcoding file.
        /// The files must be in HLS format. Preferably, they should have the same bitrate and resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateRoundPlayRequest"/></param>
        /// <returns><see cref="CreateRoundPlayResponse"/></returns>
        public Task<CreateRoundPlayResponse> CreateRoundPlay(CreateRoundPlayRequest req)
        {
            return InternalRequestAsync<CreateRoundPlayResponse>(req, "CreateRoundPlay");
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
            return InternalRequestAsync<CreateRoundPlayResponse>(req, "CreateRoundPlay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom sampled screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public Task<CreateSampleSnapshotTemplateResponse> CreateSampleSnapshotTemplate(CreateSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateSampleSnapshotTemplateResponse>(req, "CreateSampleSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to create a custom sampled screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public CreateSampleSnapshotTemplateResponse CreateSampleSnapshotTemplateSync(CreateSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateSampleSnapshotTemplateResponse>(req, "CreateSampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom time point screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<CreateSnapshotByTimeOffsetTemplateResponse> CreateSnapshotByTimeOffsetTemplate(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<CreateSnapshotByTimeOffsetTemplateResponse>(req, "CreateSnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// This API is used to create a custom time point screencapturing template. Up to 16 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public CreateSnapshotByTimeOffsetTemplateResponse CreateSnapshotByTimeOffsetTemplateSync(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<CreateSnapshotByTimeOffsetTemplateResponse>(req, "CreateSnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable storage in a region.
        ///   1. When you activate VOD, the system will enable storage for you in certain regions. If you need to store data in another region, you can use this API to enable storage in that region.
        ///   2. You can use the `DescribeStorageRegions` API to query all supported storage regions and the regions you have storage access to currently.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRegionRequest"/></param>
        /// <returns><see cref="CreateStorageRegionResponse"/></returns>
        public Task<CreateStorageRegionResponse> CreateStorageRegion(CreateStorageRegionRequest req)
        {
            return InternalRequestAsync<CreateStorageRegionResponse>(req, "CreateStorageRegion");
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
            return InternalRequestAsync<CreateStorageRegionResponse>(req, "CreateStorageRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a VOD subapplication.
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public Task<CreateSubAppIdResponse> CreateSubAppId(CreateSubAppIdRequest req)
        {
            return InternalRequestAsync<CreateSubAppIdResponse>(req, "CreateSubAppId");
        }

        /// <summary>
        /// This API is used to create a VOD subapplication.
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public CreateSubAppIdResponse CreateSubAppIdSync(CreateSubAppIdRequest req)
        {
            return InternalRequestAsync<CreateSubAppIdResponse>(req, "CreateSubAppId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to create a player configuration. Up to 100 configurations can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public Task<CreateSuperPlayerConfigResponse> CreateSuperPlayerConfig(CreateSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<CreateSuperPlayerConfigResponse>(req, "CreateSuperPlayerConfig");
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to create a player configuration. Up to 100 configurations can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public CreateSuperPlayerConfigResponse CreateSuperPlayerConfigSync(CreateSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<CreateSuperPlayerConfigResponse>(req, "CreateSuperPlayerConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom transcoding template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to create a custom transcoding template. Up to 100 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an acceleration domain name to VOD. One user can add up to 20 domain names.
        /// 1. After a domain name is added, VOD will deploy it, and it takes about 2 minutes for the domain name status to change from `Deploying` to `Online`.
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public Task<CreateVodDomainResponse> CreateVodDomain(CreateVodDomainRequest req)
        {
            return InternalRequestAsync<CreateVodDomainResponse>(req, "CreateVodDomain");
        }

        /// <summary>
        /// This API is used to add an acceleration domain name to VOD. One user can add up to 20 domain names.
        /// 1. After a domain name is added, VOD will deploy it, and it takes about 2 minutes for the domain name status to change from `Deploying` to `Online`.
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public CreateVodDomainResponse CreateVodDomainSync(CreateVodDomainRequest req)
        {
            return InternalRequestAsync<CreateVodDomainResponse>(req, "CreateVodDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom watermarking template. Up to 1,000 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplate(CreateWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateWatermarkTemplateResponse>(req, "CreateWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to create a custom watermarking template. Up to 1,000 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplateSync(CreateWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateWatermarkTemplateResponse>(req, "CreateWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create keyword samples in batches for using OCR and ASR technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples");
        }

        /// <summary>
        /// This API is used to create keyword samples in batches for using OCR and ASR technologies to perform video processing operations such as content recognition and inappropriate information recognition.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public CreateWordSamplesResponse CreateWordSamplesSync(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom video content analysis template.
        /// 
        /// Note: templates with an ID below 10000 are preset and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public Task<DeleteAIAnalysisTemplateResponse> DeleteAIAnalysisTemplate(DeleteAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisTemplateResponse>(req, "DeleteAIAnalysisTemplate");
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
            return InternalRequestAsync<DeleteAIAnalysisTemplateResponse>(req, "DeleteAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public DeleteAIRecognitionTemplateResponse DeleteAIRecognitionTemplateSync(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<DeleteAdaptiveDynamicStreamingTemplateResponse> DeleteAdaptiveDynamicStreamingTemplate(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAdaptiveDynamicStreamingTemplateResponse>(req, "DeleteAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// This API is used to delete an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public DeleteAdaptiveDynamicStreamingTemplateResponse DeleteAdaptiveDynamicStreamingTemplateSync(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAdaptiveDynamicStreamingTemplateResponse>(req, "DeleteAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public Task<DeleteAnimatedGraphicsTemplateResponse> DeleteAnimatedGraphicsTemplate(DeleteAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAnimatedGraphicsTemplateResponse>(req, "DeleteAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public DeleteAnimatedGraphicsTemplateResponse DeleteAnimatedGraphicsTemplateSync(DeleteAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAnimatedGraphicsTemplateResponse>(req, "DeleteAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete CDN Domain
        /// </summary>
        /// <param name="req"><see cref="DeleteCDNDomainRequest"/></param>
        /// <returns><see cref="DeleteCDNDomainResponse"/></returns>
        public Task<DeleteCDNDomainResponse> DeleteCDNDomain(DeleteCDNDomainRequest req)
        {
            return InternalRequestAsync<DeleteCDNDomainResponse>(req, "DeleteCDNDomain");
        }

        /// <summary>
        /// Delete CDN Domain
        /// </summary>
        /// <param name="req"><see cref="DeleteCDNDomainRequest"/></param>
        /// <returns><see cref="DeleteCDNDomainResponse"/></returns>
        public DeleteCDNDomainResponse DeleteCDNDomainSync(DeleteCDNDomainRequest req)
        {
            return InternalRequestAsync<DeleteCDNDomainResponse>(req, "DeleteCDNDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * A category can be deleted only if it has no subcategories and associated media files;
        /// * Otherwise, [delete the media files](https://intl.cloud.tencent.com/document/product/266/31764?from_cn_redirect=1) and subcategories first before deleting the category.
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass");
        }

        /// <summary>
        /// * A category can be deleted only if it has no subcategories and associated media files;
        /// * Otherwise, [delete the media files](https://intl.cloud.tencent.com/document/product/266/31764?from_cn_redirect=1) and subcategories first before deleting the category.
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public DeleteClassResponse DeleteClassSync(DeleteClassRequest req)
        {
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DeleteReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84390?from_cn_redirect=1).
        /// This API is used to delete a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate");
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DeleteReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84390?from_cn_redirect=1).
        /// This API is used to delete a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Enhance Media template
        /// </summary>
        /// <param name="req"><see cref="DeleteEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteEnhanceMediaTemplateResponse"/></returns>
        public Task<DeleteEnhanceMediaTemplateResponse> DeleteEnhanceMediaTemplate(DeleteEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEnhanceMediaTemplateResponse>(req, "DeleteEnhanceMediaTemplate");
        }

        /// <summary>
        /// Delete Enhance Media template
        /// </summary>
        /// <param name="req"><see cref="DeleteEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteEnhanceMediaTemplateResponse"/></returns>
        public DeleteEnhanceMediaTemplateResponse DeleteEnhanceMediaTemplateSync(DeleteEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEnhanceMediaTemplateResponse>(req, "DeleteEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete HeadTail Template
        /// </summary>
        /// <param name="req"><see cref="DeleteHeadTailTemplateRequest"/></param>
        /// <returns><see cref="DeleteHeadTailTemplateResponse"/></returns>
        public Task<DeleteHeadTailTemplateResponse> DeleteHeadTailTemplate(DeleteHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteHeadTailTemplateResponse>(req, "DeleteHeadTailTemplate");
        }

        /// <summary>
        /// Delete HeadTail Template
        /// </summary>
        /// <param name="req"><see cref="DeleteHeadTailTemplateRequest"/></param>
        /// <returns><see cref="DeleteHeadTailTemplateResponse"/></returns>
        public DeleteHeadTailTemplateResponse DeleteHeadTailTemplateSync(DeleteHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteHeadTailTemplateResponse>(req, "DeleteHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an image processing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public Task<DeleteImageProcessingTemplateResponse> DeleteImageProcessingTemplate(DeleteImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageProcessingTemplateResponse>(req, "DeleteImageProcessingTemplate");
        }

        /// <summary>
        /// This API is used to delete an image processing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public DeleteImageProcessingTemplateResponse DeleteImageProcessingTemplateSync(DeleteImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageProcessingTemplateResponse>(req, "DeleteImageProcessingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public Task<DeleteImageSpriteTemplateResponse> DeleteImageSpriteTemplate(DeleteImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageSpriteTemplateResponse>(req, "DeleteImageSpriteTemplate");
        }

        /// <summary>
        /// This API is used to delete an image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public DeleteImageSpriteTemplateResponse DeleteImageSpriteTemplateSync(DeleteImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageSpriteTemplateResponse>(req, "DeleteImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Just In Time Transcode Template.
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<DeleteJustInTimeTranscodeTemplateResponse> DeleteJustInTimeTranscodeTemplate(DeleteJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplateResponse>(req, "DeleteJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// Delete Just In Time Transcode Template.
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplateResponse"/></returns>
        public DeleteJustInTimeTranscodeTemplateResponse DeleteJustInTimeTranscodeTemplateSync(DeleteJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplateResponse>(req, "DeleteJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * This API is used to delete a media file and its processed files, such as the transcoded video files, image sprites, screenshots, and videos for publishing on WeChat.
        /// * You can delete the original files, transcoded video files, and videos for publishing on WeChat, etc. of videos with specified IDs.
        /// * Note: after the original file of a video is deleted, you cannot transcode the video, publish it on WeChat, or perform other operations on it.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public Task<DeleteMediaResponse> DeleteMedia(DeleteMediaRequest req)
        {
            return InternalRequestAsync<DeleteMediaResponse>(req, "DeleteMedia");
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
            return InternalRequestAsync<DeleteMediaResponse>(req, "DeleteMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete samples according to sample IDs.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample");
        }

        /// <summary>
        /// This API is used to delete samples according to sample IDs.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete user-created task flow templates.
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public Task<DeleteProcedureTemplateResponse> DeleteProcedureTemplate(DeleteProcedureTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcedureTemplateResponse>(req, "DeleteProcedureTemplate");
        }

        /// <summary>
        /// Delete user-created task flow templates.
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public DeleteProcedureTemplateResponse DeleteProcedureTemplateSync(DeleteProcedureTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcedureTemplateResponse>(req, "DeleteProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityInspectTemplateResponse"/></returns>
        public Task<DeleteQualityInspectTemplateResponse> DeleteQualityInspectTemplate(DeleteQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityInspectTemplateResponse>(req, "DeleteQualityInspectTemplate");
        }

        /// <summary>
        /// Deletes media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityInspectTemplateResponse"/></returns>
        public DeleteQualityInspectTemplateResponse DeleteQualityInspectTemplateSync(DeleteQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityInspectTemplateResponse>(req, "DeleteQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete rebuild media template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public Task<DeleteRebuildMediaTemplateResponse> DeleteRebuildMediaTemplate(DeleteRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRebuildMediaTemplateResponse>(req, "DeleteRebuildMediaTemplate");
        }

        /// <summary>
        /// Delete rebuild media template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public DeleteRebuildMediaTemplateResponse DeleteRebuildMediaTemplateSync(DeleteRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRebuildMediaTemplateResponse>(req, "DeleteRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public Task<DeleteReviewTemplateResponse> DeleteReviewTemplate(DeleteReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteReviewTemplateResponse>(req, "DeleteReviewTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public DeleteReviewTemplateResponse DeleteReviewTemplateSync(DeleteReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteReviewTemplateResponse>(req, "DeleteReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a playlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public Task<DeleteRoundPlayResponse> DeleteRoundPlay(DeleteRoundPlayRequest req)
        {
            return InternalRequestAsync<DeleteRoundPlayResponse>(req, "DeleteRoundPlay");
        }

        /// <summary>
        /// This API is used to delete a playlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public DeleteRoundPlayResponse DeleteRoundPlaySync(DeleteRoundPlayRequest req)
        {
            return InternalRequestAsync<DeleteRoundPlayResponse>(req, "DeleteRoundPlay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public Task<DeleteSampleSnapshotTemplateResponse> DeleteSampleSnapshotTemplate(DeleteSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSampleSnapshotTemplateResponse>(req, "DeleteSampleSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public DeleteSampleSnapshotTemplateResponse DeleteSampleSnapshotTemplateSync(DeleteSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSampleSnapshotTemplateResponse>(req, "DeleteSampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<DeleteSnapshotByTimeOffsetTemplateResponse> DeleteSnapshotByTimeOffsetTemplate(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotByTimeOffsetTemplateResponse>(req, "DeleteSnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public DeleteSnapshotByTimeOffsetTemplateResponse DeleteSnapshotByTimeOffsetTemplateSync(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotByTimeOffsetTemplateResponse>(req, "DeleteSnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to delete a player configuration.  
        /// *Note: Preset player configurations cannot be deleted.*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public Task<DeleteSuperPlayerConfigResponse> DeleteSuperPlayerConfig(DeleteSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<DeleteSuperPlayerConfigResponse>(req, "DeleteSuperPlayerConfig");
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
            return InternalRequestAsync<DeleteSuperPlayerConfigResponse>(req, "DeleteSuperPlayerConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public Task<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplate(DeleteTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTranscodeTemplateResponse>(req, "DeleteTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public DeleteTranscodeTemplateResponse DeleteTranscodeTemplateSync(DeleteTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTranscodeTemplateResponse>(req, "DeleteTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an acceleration domain name from VOD.
        /// 1. Before deleting a domain name, disable its acceleration in all regions.
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public Task<DeleteVodDomainResponse> DeleteVodDomain(DeleteVodDomainRequest req)
        {
            return InternalRequestAsync<DeleteVodDomainResponse>(req, "DeleteVodDomain");
        }

        /// <summary>
        /// This API is used to delete an acceleration domain name from VOD.
        /// 1. Before deleting a domain name, disable its acceleration in all regions.
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public DeleteVodDomainResponse DeleteVodDomainSync(DeleteVodDomainRequest req)
        {
            return InternalRequestAsync<DeleteVodDomainResponse>(req, "DeleteVodDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom watermarking template.
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWatermarkTemplateResponse>(req, "DeleteWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom watermarking template.
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplateSync(DeleteWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWatermarkTemplateResponse>(req, "DeleteWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete keyword samples in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public Task<DeleteWordSamplesResponse> DeleteWordSamples(DeleteWordSamplesRequest req)
        {
            return InternalRequestAsync<DeleteWordSamplesResponse>(req, "DeleteWordSamples");
        }

        /// <summary>
        /// This API is used to delete keyword samples in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public DeleteWordSamplesResponse DeleteWordSamplesSync(DeleteWordSamplesRequest req)
        {
            return InternalRequestAsync<DeleteWordSamplesResponse>(req, "DeleteWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of video content analysis templates based on unique template ID. The returned result includes all eligible custom and [preset video content analysis templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates");
        }

        /// <summary>
        /// This API is used to get the list of video content analysis templates based on unique template ID. The returned result includes all eligible custom and [preset video content analysis templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of video content recognition templates based on unique template ID. The return result includes all eligible custom and [preset video content recognition templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates");
        }

        /// <summary>
        /// This API is used to get the list of video content recognition templates based on unique template ID. The return result includes all eligible custom and [preset video content recognition templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public DescribeAIRecognitionTemplatesResponse DescribeAIRecognitionTemplatesSync(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of transcoding to adaptive bitrate streaming templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public Task<DescribeAdaptiveDynamicStreamingTemplatesResponse> DescribeAdaptiveDynamicStreamingTemplates(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates");
        }

        /// <summary>
        /// This API is used to query the list of transcoding to adaptive bitrate streaming templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public DescribeAdaptiveDynamicStreamingTemplatesResponse DescribeAdaptiveDynamicStreamingTemplatesSync(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * This API is used to get the information of all categories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public Task<DescribeAllClassResponse> DescribeAllClass(DescribeAllClassRequest req)
        {
            return InternalRequestAsync<DescribeAllClassResponse>(req, "DescribeAllClass");
        }

        /// <summary>
        /// * This API is used to get the information of all categories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public DescribeAllClassResponse DescribeAllClassSync(DescribeAllClassRequest req)
        {
            return InternalRequestAsync<DescribeAllClassResponse>(req, "DescribeAllClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of animated image generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public Task<DescribeAnimatedGraphicsTemplatesResponse> DescribeAnimatedGraphicsTemplates(DescribeAnimatedGraphicsTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAnimatedGraphicsTemplatesResponse>(req, "DescribeAnimatedGraphicsTemplates");
        }

        /// <summary>
        /// This API is used to query the list of animated image generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public DescribeAnimatedGraphicsTemplatesResponse DescribeAnimatedGraphicsTemplatesSync(DescribeAnimatedGraphicsTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAnimatedGraphicsTemplatesResponse>(req, "DescribeAnimatedGraphicsTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe CDN Domains
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNDomainsRequest"/></param>
        /// <returns><see cref="DescribeCDNDomainsResponse"/></returns>
        public Task<DescribeCDNDomainsResponse> DescribeCDNDomains(DescribeCDNDomainsRequest req)
        {
            return InternalRequestAsync<DescribeCDNDomainsResponse>(req, "DescribeCDNDomains");
        }

        /// <summary>
        /// Describe CDN Domains
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNDomainsRequest"/></param>
        /// <returns><see cref="DescribeCDNDomainsResponse"/></returns>
        public DescribeCDNDomainsResponse DescribeCDNDomainsSync(DescribeCDNDomainsRequest req)
        {
            return InternalRequestAsync<DescribeCDNDomainsResponse>(req, "DescribeCDNDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CDN bandwidth, traffic, and other data of VOD domain names.
        /// * The query period is up to 90 days.
        /// * You can query data of different service regions.
        /// * You can query data of Chinese mainland by region and ISP.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public Task<DescribeCDNStatDetailsResponse> DescribeCDNStatDetails(DescribeCDNStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCDNStatDetailsResponse>(req, "DescribeCDNStatDetails");
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
            return InternalRequestAsync<DescribeCDNStatDetailsResponse>(req, "DescribeCDNStatDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeCDNUsageDataResponse> DescribeCDNUsageData(DescribeCDNUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeCDNUsageDataResponse>(req, "DescribeCDNUsageData");
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
            return InternalRequestAsync<DescribeCDNUsageDataResponse>(req, "DescribeCDNUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download links of CDN access logs of a VOD domain name.
        ///     1. Only download links of CDN logs for the last 30 days can be queried.
        ///     2. By default, CDN generates a log file every hour. If there is no CDN access for a certain hour, no log file will be generated for the hour.    
        ///     3. A CDN log download link is valid for 24 hours.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public Task<DescribeCdnLogsResponse> DescribeCdnLogs(DescribeCdnLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnLogsResponse>(req, "DescribeCdnLogs");
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
            return InternalRequestAsync<DescribeCdnLogsResponse>(req, "DescribeCdnLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface returns client upload acceleration statistics within the query time range. 
        ///  1. You can query the client upload acceleration statistics in the last 365 days. 
        ///  2. The query time span does not exceed 90 days. 
        ///  3. If the query time span exceeds 1 day, data with day granularity will be returned. Otherwise, data with 5-minute granularity will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public Task<DescribeClientUploadAccelerationUsageDataResponse> DescribeClientUploadAccelerationUsageData(DescribeClientUploadAccelerationUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeClientUploadAccelerationUsageDataResponse>(req, "DescribeClientUploadAccelerationUsageData");
        }

        /// <summary>
        /// This interface returns client upload acceleration statistics within the query time range. 
        ///  1. You can query the client upload acceleration statistics in the last 365 days. 
        ///  2. The query time span does not exceed 90 days. 
        ///  3. If the query time span exceeds 1 day, data with day granularity will be returned. Otherwise, data with 5-minute granularity will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public DescribeClientUploadAccelerationUsageDataResponse DescribeClientUploadAccelerationUsageDataSync(DescribeClientUploadAccelerationUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeClientUploadAccelerationUsageDataResponse>(req, "DescribeClientUploadAccelerationUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DescribeReviewTemplates](https://intl.cloud.tencent.com/document/api/266/84389?from_cn_redirect=1).
        /// This API is used to get the information of custom and [preset](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF) audio/video moderation templates based on template IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates");
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [DescribeReviewTemplates](https://intl.cloud.tencent.com/document/api/266/84389?from_cn_redirect=1).
        /// This API is used to get the information of custom and [preset](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF) audio/video moderation templates based on template IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeDailyPlayStatFileListResponse> DescribeDailyPlayStatFileList(DescribeDailyPlayStatFileListRequest req)
        {
            return InternalRequestAsync<DescribeDailyPlayStatFileListResponse>(req, "DescribeDailyPlayStatFileList");
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
            return InternalRequestAsync<DescribeDailyPlayStatFileListResponse>(req, "DescribeDailyPlayStatFileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DRM key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public Task<DescribeDrmKeyProviderInfoResponse> DescribeDrmKeyProviderInfo(DescribeDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<DescribeDrmKeyProviderInfoResponse>(req, "DescribeDrmKeyProviderInfo");
        }

        /// <summary>
        /// This API is used to query DRM key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public DescribeDrmKeyProviderInfoResponse DescribeDrmKeyProviderInfoSync(DescribeDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<DescribeDrmKeyProviderInfoResponse>(req, "DescribeDrmKeyProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe Enhance Media Templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnhanceMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEnhanceMediaTemplatesResponse"/></returns>
        public Task<DescribeEnhanceMediaTemplatesResponse> DescribeEnhanceMediaTemplates(DescribeEnhanceMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEnhanceMediaTemplatesResponse>(req, "DescribeEnhanceMediaTemplates");
        }

        /// <summary>
        /// Describe Enhance Media Templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnhanceMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEnhanceMediaTemplatesResponse"/></returns>
        public DescribeEnhanceMediaTemplatesResponse DescribeEnhanceMediaTemplatesSync(DescribeEnhanceMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEnhanceMediaTemplatesResponse>(req, "DescribeEnhanceMediaTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tencent Cloud VOD provides customers with services such as media upload, media management, and media processing. During or after the execution of these services, Tencent Cloud VOD also offers various corresponding event notifications to facilitate developers' awareness of the service processing status and to perform subsequent business operations. Developers can use this interface to query the current configuration of event notification reception methods, reception addresses, and which events have callback notification reception enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConfigRequest"/></param>
        /// <returns><see cref="DescribeEventConfigResponse"/></returns>
        public Task<DescribeEventConfigResponse> DescribeEventConfig(DescribeEventConfigRequest req)
        {
            return InternalRequestAsync<DescribeEventConfigResponse>(req, "DescribeEventConfig");
        }

        /// <summary>
        /// Tencent Cloud VOD provides customers with services such as media upload, media management, and media processing. During or after the execution of these services, Tencent Cloud VOD also offers various corresponding event notifications to facilitate developers' awareness of the service processing status and to perform subsequent business operations. Developers can use this interface to query the current configuration of event notification reception methods, reception addresses, and which events have callback notification reception enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConfigRequest"/></param>
        /// <returns><see cref="DescribeEventConfigResponse"/></returns>
        public DescribeEventConfigResponse DescribeEventConfigSync(DescribeEventConfigRequest req)
        {
            return InternalRequestAsync<DescribeEventConfigResponse>(req, "DescribeEventConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get file attributes asynchronously.
        /// - Currently, this API can only get the MD5 hash of a file.
        /// - If the file queried is in HLS or DASH format, the attributes of the index file will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileAttributesRequest"/></param>
        /// <returns><see cref="DescribeFileAttributesResponse"/></returns>
        public Task<DescribeFileAttributesResponse> DescribeFileAttributes(DescribeFileAttributesRequest req)
        {
            return InternalRequestAsync<DescribeFileAttributesResponse>(req, "DescribeFileAttributes");
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
            return InternalRequestAsync<DescribeFileAttributesResponse>(req, "DescribeFileAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe HeadTail Templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeHeadTailTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHeadTailTemplatesResponse"/></returns>
        public Task<DescribeHeadTailTemplatesResponse> DescribeHeadTailTemplates(DescribeHeadTailTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHeadTailTemplatesResponse>(req, "DescribeHeadTailTemplates");
        }

        /// <summary>
        /// Describe HeadTail Templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeHeadTailTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHeadTailTemplatesResponse"/></returns>
        public DescribeHeadTailTemplatesResponse DescribeHeadTailTemplatesSync(DescribeHeadTailTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHeadTailTemplatesResponse>(req, "DescribeHeadTailTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query image processing templates. You can specify the filters as well as the offset to start returning records from.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public Task<DescribeImageProcessingTemplatesResponse> DescribeImageProcessingTemplates(DescribeImageProcessingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageProcessingTemplatesResponse>(req, "DescribeImageProcessingTemplates");
        }

        /// <summary>
        /// This API is used to query image processing templates. You can specify the filters as well as the offset to start returning records from.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public DescribeImageProcessingTemplatesResponse DescribeImageProcessingTemplatesSync(DescribeImageProcessingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageProcessingTemplatesResponse>(req, "DescribeImageProcessingTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface returns the image review usage information used every day within the query time range.
        ///    1. You can query the image review statistics for the last 365 days.
        ///    2. The query time span does not exceed 90 days.
        ///    3. If the query time span exceeds 1 day, data with a granularity of days will be returned. Otherwise, data with a granularity of 5 minutes will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public Task<DescribeImageReviewUsageDataResponse> DescribeImageReviewUsageData(DescribeImageReviewUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeImageReviewUsageDataResponse>(req, "DescribeImageReviewUsageData");
        }

        /// <summary>
        /// This interface returns the image review usage information used every day within the query time range.
        ///    1. You can query the image review statistics for the last 365 days.
        ///    2. The query time span does not exceed 90 days.
        ///    3. If the query time span exceeds 1 day, data with a granularity of days will be returned. Otherwise, data with a granularity of 5 minutes will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public DescribeImageReviewUsageDataResponse DescribeImageReviewUsageDataSync(DescribeImageReviewUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeImageReviewUsageDataResponse>(req, "DescribeImageReviewUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of image sprite generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public Task<DescribeImageSpriteTemplatesResponse> DescribeImageSpriteTemplates(DescribeImageSpriteTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageSpriteTemplatesResponse>(req, "DescribeImageSpriteTemplates");
        }

        /// <summary>
        /// This API is used to query the list of image sprite generating templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public DescribeImageSpriteTemplatesResponse DescribeImageSpriteTemplatesSync(DescribeImageSpriteTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageSpriteTemplatesResponse>(req, "DescribeImageSpriteTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe Just In Time Transcode Templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeJustInTimeTranscodeTemplatesResponse> DescribeJustInTimeTranscodeTemplates(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates");
        }

        /// <summary>
        /// Describe Just In Time Transcode Templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public DescribeJustInTimeTranscodeTemplatesResponse DescribeJustInTimeTranscodeTemplatesSync(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface returns information about the number of license requests per day within the query time range.
        ///    1. You can query the license request statistics in the last 365 days.
        ///    2. The query time span does not exceed 90 days.
        ///    3. If the query time span exceeds 1 day, data with a granularity of days will be returned. Otherwise, data with a granularity of 5 minutes will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public Task<DescribeLicenseUsageDataResponse> DescribeLicenseUsageData(DescribeLicenseUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeLicenseUsageDataResponse>(req, "DescribeLicenseUsageData");
        }

        /// <summary>
        /// This interface returns information about the number of license requests per day within the query time range.
        ///    1. You can query the license request statistics in the last 365 days.
        ///    2. The query time span does not exceed 90 days.
        ///    3. If the query time span exceeds 1 day, data with a granularity of days will be returned. Otherwise, data with a granularity of 5 minutes will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public DescribeLicenseUsageDataResponse DescribeLicenseUsageDataSync(DescribeLicenseUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeLicenseUsageDataResponse>(req, "DescribeLicenseUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeMediaInfosResponse> DescribeMediaInfos(DescribeMediaInfosRequest req)
        {
            return InternalRequestAsync<DescribeMediaInfosResponse>(req, "DescribeMediaInfos");
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
            return InternalRequestAsync<DescribeMediaInfosResponse>(req, "DescribeMediaInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the playback statistics of a media file at the specified granularity.
        /// * You can query playback statistics in the past year.
        /// * If the granularity is an hour, the start and end time cannot be more than seven days apart.
        /// * If the granularity is a day, the start and end time cannot be more than 90 days apart.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPlayStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeMediaPlayStatDetailsResponse"/></returns>
        public Task<DescribeMediaPlayStatDetailsResponse> DescribeMediaPlayStatDetails(DescribeMediaPlayStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMediaPlayStatDetailsResponse>(req, "DescribeMediaPlayStatDetails");
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
            return InternalRequestAsync<DescribeMediaPlayStatDetailsResponse>(req, "DescribeMediaPlayStatDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of video processing usage within the specified time range.
        ///    1. Statistics on video processing for the last 365 days can be queried.
        ///    2. The query time range cannot be more than 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public Task<DescribeMediaProcessUsageDataResponse> DescribeMediaProcessUsageData(DescribeMediaProcessUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaProcessUsageDataResponse>(req, "DescribeMediaProcessUsageData");
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
            return InternalRequestAsync<DescribeMediaProcessUsageDataResponse>(req, "DescribeMediaProcessUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of samples and supports paginated queries by sample ID, name, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples");
        }

        /// <summary>
        /// This API is used to query the information of samples and supports paginated queries by sample ID, name, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public DescribePersonSamplesResponse DescribePersonSamplesSync(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of task flow template details by task flow template name.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public Task<DescribeProcedureTemplatesResponse> DescribeProcedureTemplates(DescribeProcedureTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcedureTemplatesResponse>(req, "DescribeProcedureTemplates");
        }

        /// <summary>
        /// This API is used to get the list of task flow template details by task flow template name.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public DescribeProcedureTemplatesResponse DescribeProcedureTemplatesSync(DescribeProcedureTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcedureTemplatesResponse>(req, "DescribeProcedureTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get media quality inspection Template List.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityInspectTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityInspectTemplatesResponse"/></returns>
        public Task<DescribeQualityInspectTemplatesResponse> DescribeQualityInspectTemplates(DescribeQualityInspectTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityInspectTemplatesResponse>(req, "DescribeQualityInspectTemplates");
        }

        /// <summary>
        /// Get media quality inspection Template List.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityInspectTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityInspectTemplatesResponse"/></returns>
        public DescribeQualityInspectTemplatesResponse DescribeQualityInspectTemplatesSync(DescribeQualityInspectTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityInspectTemplatesResponse>(req, "DescribeQualityInspectTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe Rebuild Media Templates
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public Task<DescribeRebuildMediaTemplatesResponse> DescribeRebuildMediaTemplates(DescribeRebuildMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRebuildMediaTemplatesResponse>(req, "DescribeRebuildMediaTemplates");
        }

        /// <summary>
        /// Describe Rebuild Media Templates
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public DescribeRebuildMediaTemplatesResponse DescribeRebuildMediaTemplatesSync(DescribeRebuildMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRebuildMediaTemplatesResponse>(req, "DescribeRebuildMediaTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeReviewDetailsResponse> DescribeReviewDetails(DescribeReviewDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReviewDetailsResponse>(req, "DescribeReviewDetails");
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
            return InternalRequestAsync<DescribeReviewDetailsResponse>(req, "DescribeReviewDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of moderation templates.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public Task<DescribeReviewTemplatesResponse> DescribeReviewTemplates(DescribeReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeReviewTemplatesResponse>(req, "DescribeReviewTemplates");
        }

        /// <summary>
        /// This API is used to get the information of moderation templates.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public DescribeReviewTemplatesResponse DescribeReviewTemplatesSync(DescribeReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeReviewTemplatesResponse>(req, "DescribeReviewTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query playlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public Task<DescribeRoundPlaysResponse> DescribeRoundPlays(DescribeRoundPlaysRequest req)
        {
            return InternalRequestAsync<DescribeRoundPlaysResponse>(req, "DescribeRoundPlays");
        }

        /// <summary>
        /// This API is used to query playlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public DescribeRoundPlaysResponse DescribeRoundPlaysSync(DescribeRoundPlaysRequest req)
        {
            return InternalRequestAsync<DescribeRoundPlaysResponse>(req, "DescribeRoundPlays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of sampled screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public Task<DescribeSampleSnapshotTemplatesResponse> DescribeSampleSnapshotTemplates(DescribeSampleSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSampleSnapshotTemplatesResponse>(req, "DescribeSampleSnapshotTemplates");
        }

        /// <summary>
        /// This API is used to query the list of sampled screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public DescribeSampleSnapshotTemplatesResponse DescribeSampleSnapshotTemplatesSync(DescribeSampleSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSampleSnapshotTemplatesResponse>(req, "DescribeSampleSnapshotTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of time point screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public Task<DescribeSnapshotByTimeOffsetTemplatesResponse> DescribeSnapshotByTimeOffsetTemplates(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotByTimeOffsetTemplatesResponse>(req, "DescribeSnapshotByTimeOffsetTemplates");
        }

        /// <summary>
        /// This API is used to query the list of time point screencapturing templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public DescribeSnapshotByTimeOffsetTemplatesResponse DescribeSnapshotByTimeOffsetTemplatesSync(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotByTimeOffsetTemplatesResponse>(req, "DescribeSnapshotByTimeOffsetTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the storage capacity usage and number of files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public Task<DescribeStorageDataResponse> DescribeStorageData(DescribeStorageDataRequest req)
        {
            return InternalRequestAsync<DescribeStorageDataResponse>(req, "DescribeStorageData");
        }

        /// <summary>
        /// This API is used to query the storage capacity usage and number of files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public DescribeStorageDataResponse DescribeStorageDataSync(DescribeStorageDataRequest req)
        {
            return InternalRequestAsync<DescribeStorageDataResponse>(req, "DescribeStorageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query VOD storage usage in bytes within the query period.
        ///     1. You can only query storage usage for the last 365 days.
        ///     2. The query period is up to 90 days.
        ///     3. The query period at minute-level granularity is up to 7 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public Task<DescribeStorageDetailsResponse> DescribeStorageDetails(DescribeStorageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeStorageDetailsResponse>(req, "DescribeStorageDetails");
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
            return InternalRequestAsync<DescribeStorageDetailsResponse>(req, "DescribeStorageDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the following information:
        ///   1. All supported storage regions.
        ///   2. The regions you have storage access to currently.
        ///   3. The default storage region.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRegionsRequest"/></param>
        /// <returns><see cref="DescribeStorageRegionsResponse"/></returns>
        public Task<DescribeStorageRegionsResponse> DescribeStorageRegions(DescribeStorageRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStorageRegionsResponse>(req, "DescribeStorageRegions");
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
            return InternalRequestAsync<DescribeStorageRegionsResponse>(req, "DescribeStorageRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of the primary application and subapplications of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public Task<DescribeSubAppIdsResponse> DescribeSubAppIds(DescribeSubAppIdsRequest req)
        {
            return InternalRequestAsync<DescribeSubAppIdsResponse>(req, "DescribeSubAppIds");
        }

        /// <summary>
        /// This API is used to query the list of the primary application and subapplications of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public DescribeSubAppIdsResponse DescribeSubAppIdsSync(DescribeSubAppIdsRequest req)
        {
            return InternalRequestAsync<DescribeSubAppIdsResponse>(req, "DescribeSubAppIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to query player configurations. It supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public Task<DescribeSuperPlayerConfigsResponse> DescribeSuperPlayerConfigs(DescribeSuperPlayerConfigsRequest req)
        {
            return InternalRequestAsync<DescribeSuperPlayerConfigsResponse>(req, "DescribeSuperPlayerConfigs");
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to query player configurations. It supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public DescribeSuperPlayerConfigsResponse DescribeSuperPlayerConfigsSync(DescribeSuperPlayerConfigsRequest req)
        {
            return InternalRequestAsync<DescribeSuperPlayerConfigsResponse>(req, "DescribeSuperPlayerConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of execution status and result of a task submitted in the last 3 days by task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// This API is used to query the details of execution status and result of a task submitted in the last 3 days by task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * This API is used to query the task list;
        /// * If there are many data entries in the list, one single call of the API may not be able to pull the entire list. The `ScrollToken` parameter can be used to pull the list in batches;
        /// * Only tasks in the last three days (72 hours) can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
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
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of transcoding templates based on unique template ID. The return result includes all eligible custom and [preset transcoding templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeTranscodeTemplatesResponse> DescribeTranscodeTemplates(DescribeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTemplatesResponse>(req, "DescribeTranscodeTemplates");
        }

        /// <summary>
        /// This API is used to get the list of transcoding templates based on unique template ID. The return result includes all eligible custom and [preset transcoding templates](https://intl.cloud.tencent.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public DescribeTranscodeTemplatesResponse DescribeTranscodeTemplatesSync(DescribeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTemplatesResponse>(req, "DescribeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of VOD domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public Task<DescribeVodDomainsResponse> DescribeVodDomains(DescribeVodDomainsRequest req)
        {
            return InternalRequestAsync<DescribeVodDomainsResponse>(req, "DescribeVodDomains");
        }

        /// <summary>
        /// This API is used to query the list of VOD domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public DescribeVodDomainsResponse DescribeVodDomainsSync(DescribeVodDomainsRequest req)
        {
            return InternalRequestAsync<DescribeVodDomainsResponse>(req, "DescribeVodDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query custom watermarking templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public Task<DescribeWatermarkTemplatesResponse> DescribeWatermarkTemplates(DescribeWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWatermarkTemplatesResponse>(req, "DescribeWatermarkTemplates");
        }

        /// <summary>
        /// This API is used to query custom watermarking templates and supports paged queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public DescribeWatermarkTemplatesResponse DescribeWatermarkTemplatesSync(DescribeWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWatermarkTemplatesResponse>(req, "DescribeWatermarkTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform paginated queries of keyword sample information by use case, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples");
        }

        /// <summary>
        /// This API is used to perform paginated queries of keyword sample information by use case, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public DescribeWordSamplesResponse DescribeWordSamplesSync(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit the video (cut, splice, etc.) to generate a new video. The editing functions include:
        /// 
        /// 1. Edit a file in the VOD video to generate a new video;
        /// 2. Splice multiple files to generate a new video;
        /// 3. Edit multiple files and then splice them to generate a new video;
        /// 4. Directly generate a new video for a stream;
        /// 5. Edit a stream to generate a new video. Video;
        /// 6. Splice multiple streams to generate a new video;
        /// 7. Clip and then splice multiple streams to generate a new video. 
        /// 
        /// For the generated new video, you can also specify whether the generated video needs to execute the task flow. 
        /// 
        /// >When editing or splicing live streams, please make sure to do so after the stream is over. Otherwise the resulting video may be incomplete. 
        /// 
        /// If event notification is used, the type of event notification is [Video editing completed](https://intl.cloud.tencent.com/document/product/266/33794?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public Task<EditMediaResponse> EditMedia(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia");
        }

        /// <summary>
        /// Edit the video (cut, splice, etc.) to generate a new video. The editing functions include:
        /// 
        /// 1. Edit a file in the VOD video to generate a new video;
        /// 2. Splice multiple files to generate a new video;
        /// 3. Edit multiple files and then splice them to generate a new video;
        /// 4. Directly generate a new video for a stream;
        /// 5. Edit a stream to generate a new video. Video;
        /// 6. Splice multiple streams to generate a new video;
        /// 7. Clip and then splice multiple streams to generate a new video. 
        /// 
        /// For the generated new video, you can also specify whether the generated video needs to execute the task flow. 
        /// 
        /// >When editing or splicing live streams, please make sure to do so after the stream is over. Otherwise the resulting video may be incomplete. 
        /// 
        /// If event notification is used, the type of event notification is [Video editing completed](https://intl.cloud.tencent.com/document/product/266/33794?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public EditMediaResponse EditMediaSync(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enhance Media By Template.
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaByTemplateRequest"/></param>
        /// <returns><see cref="EnhanceMediaByTemplateResponse"/></returns>
        public Task<EnhanceMediaByTemplateResponse> EnhanceMediaByTemplate(EnhanceMediaByTemplateRequest req)
        {
            return InternalRequestAsync<EnhanceMediaByTemplateResponse>(req, "EnhanceMediaByTemplate");
        }

        /// <summary>
        /// Enhance Media By Template.
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaByTemplateRequest"/></param>
        /// <returns><see cref="EnhanceMediaByTemplateResponse"/></returns>
        public EnhanceMediaByTemplateResponse EnhanceMediaByTemplateSync(EnhanceMediaByTemplateRequest req)
        {
            return InternalRequestAsync<EnhanceMediaByTemplateResponse>(req, "EnhanceMediaByTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate a Remaster task for audio and video media in VOD
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaQualityRequest"/></param>
        /// <returns><see cref="EnhanceMediaQualityResponse"/></returns>
        public Task<EnhanceMediaQualityResponse> EnhanceMediaQuality(EnhanceMediaQualityRequest req)
        {
            return InternalRequestAsync<EnhanceMediaQualityResponse>(req, "EnhanceMediaQuality");
        }

        /// <summary>
        /// Initiate a Remaster task for audio and video media in VOD
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaQualityRequest"/></param>
        /// <returns><see cref="EnhanceMediaQualityResponse"/></returns>
        public EnhanceMediaQualityResponse EnhanceMediaQualitySync(EnhanceMediaQualityRequest req)
        {
            return InternalRequestAsync<EnhanceMediaQualityResponse>(req, "EnhanceMediaQuality")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is only used in special scenarios of custom development. Unless requested by VOD customer service, please do not call it.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction");
        }

        /// <summary>
        /// This API is only used in special scenarios of custom development. Unless requested by VOD customer service, please do not call it.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Extract CopyRight Watermark.
        /// </summary>
        /// <param name="req"><see cref="ExtractCopyRightWatermarkRequest"/></param>
        /// <returns><see cref="ExtractCopyRightWatermarkResponse"/></returns>
        public Task<ExtractCopyRightWatermarkResponse> ExtractCopyRightWatermark(ExtractCopyRightWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractCopyRightWatermarkResponse>(req, "ExtractCopyRightWatermark");
        }

        /// <summary>
        /// Extract CopyRight Watermark.
        /// </summary>
        /// <param name="req"><see cref="ExtractCopyRightWatermarkRequest"/></param>
        /// <returns><see cref="ExtractCopyRightWatermarkResponse"/></returns>
        public ExtractCopyRightWatermarkResponse ExtractCopyRightWatermarkSync(ExtractCopyRightWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractCopyRightWatermarkResponse>(req, "ExtractCopyRightWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to extract the user ID of a user that distributed a video containing a digital watermark.
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public Task<ExtractTraceWatermarkResponse> ExtractTraceWatermark(ExtractTraceWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractTraceWatermarkResponse>(req, "ExtractTraceWatermark");
        }

        /// <summary>
        /// This API is used to extract the user ID of a user that distributed a video containing a digital watermark.
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public ExtractTraceWatermarkResponse ExtractTraceWatermarkSync(ExtractTraceWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractTraceWatermarkResponse>(req, "ExtractTraceWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Implement quick concatenation and quick clipping for Tencent Cloud VOD's HLS videos to generate new media in HLS format. The video generated by quick concatenation or clipping will produce a new FileId and undergo solidification. After successful solidification, the new video file exists independently of the original input video and is not affected by deletions or other actions on the original video. <font color='red'>Note:</font> Enable the reception of persistence completed event notifications through the ModifyEvent config interface, and a PersistenceComplete type event notification will be received after successful solidification. Before receiving this event notification, operations such as deletion or cooling down of the original input video should not be performed, otherwise, abnormal playback may occur in the video generated by the concatenation and clipping.
        /// </summary>
        /// <param name="req"><see cref="FastEditMediaRequest"/></param>
        /// <returns><see cref="FastEditMediaResponse"/></returns>
        public Task<FastEditMediaResponse> FastEditMedia(FastEditMediaRequest req)
        {
            return InternalRequestAsync<FastEditMediaResponse>(req, "FastEditMedia");
        }

        /// <summary>
        /// Implement quick concatenation and quick clipping for Tencent Cloud VOD's HLS videos to generate new media in HLS format. The video generated by quick concatenation or clipping will produce a new FileId and undergo solidification. After successful solidification, the new video file exists independently of the original input video and is not affected by deletions or other actions on the original video. <font color='red'>Note:</font> Enable the reception of persistence completed event notifications through the ModifyEvent config interface, and a PersistenceComplete type event notification will be received after successful solidification. Before receiving this event notification, operations such as deletion or cooling down of the original input video should not be performed, otherwise, abnormal playback may occur in the video generated by the concatenation and clipping.
        /// </summary>
        /// <param name="req"><see cref="FastEditMediaRequest"/></param>
        /// <returns><see cref="FastEditMediaResponse"/></returns>
        public FastEditMediaResponse FastEditMediaSync(FastEditMediaRequest req)
        {
            return InternalRequestAsync<FastEditMediaResponse>(req, "FastEditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * After a media file is forbidden, except previewing it in the VOD Console, accessing the URLs of its various resources (such as source file, output files, and screenshots) in other scenarios will return error 403.
        ///   It takes about 5-10 minutes for a forbidding/unblocking operation to take effect across the entire network.
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public Task<ForbidMediaDistributionResponse> ForbidMediaDistribution(ForbidMediaDistributionRequest req)
        {
            return InternalRequestAsync<ForbidMediaDistributionResponse>(req, "ForbidMediaDistribution");
        }

        /// <summary>
        /// * After a media file is forbidden, except previewing it in the VOD Console, accessing the URLs of its various resources (such as source file, output files, and screenshots) in other scenarios will return error 403.
        ///   It takes about 5-10 minutes for a forbidding/unblocking operation to take effect across the entire network.
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public ForbidMediaDistributionResponse ForbidMediaDistributionSync(ForbidMediaDistributionRequest req)
        {
            return InternalRequestAsync<ForbidMediaDistributionResponse>(req, "ForbidMediaDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate media quality inspection task.
        /// </summary>
        /// <param name="req"><see cref="InspectMediaQualityRequest"/></param>
        /// <returns><see cref="InspectMediaQualityResponse"/></returns>
        public Task<InspectMediaQualityResponse> InspectMediaQuality(InspectMediaQualityRequest req)
        {
            return InternalRequestAsync<InspectMediaQualityResponse>(req, "InspectMediaQuality");
        }

        /// <summary>
        /// Initiate media quality inspection task.
        /// </summary>
        /// <param name="req"><see cref="InspectMediaQualityRequest"/></param>
        /// <returns><see cref="InspectMediaQualityResponse"/></returns>
        public InspectMediaQualityResponse InspectMediaQualitySync(InspectMediaQualityRequest req)
        {
            return InternalRequestAsync<InspectMediaQualityResponse>(req, "InspectMediaQuality")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Live broadcast real-time editing means that during the live broadcast process (that is, before the live broadcast has ended), customers can select a section of past live broadcast content to generate a new video (HLS format) in real time. Developers can share it immediately, or permanently Save it.
        /// 
        /// Tencent Cloud VOD supports two real-time editing modes:
        /// - Editing and solidification: Save the edited video as an independent video with an independent FileId; suitable for scenes where the highlight clips are saved for a long time;
        /// - Editing is not solidified: the edited video is attached to the live broadcast recording file and does not have an independent FileId; it is suitable for scenarios where highlight clips are **temporarily shared**.
        /// 
        /// Notice:
        /// - The prerequisite for using the live broadcast real-time editing function is that the target live stream has the [Time Shift Replay](https://intl.cloud.tencent.com/document/product/267/32742?from_cn_redirect=1) function enabled.
        /// - Live broadcast real-time editing is based on the m3u8 file generated by live broadcast recording, so its minimum editing accuracy is one ts slice, and it is impossible to achieve second-level or more precise editing accuracy.
        /// - Since the stream may be interrupted during the live broadcast, the actual video duration generated by editing may be inconsistent with expectations. For example, the time interval for editing a live stream is from 2018-09-20T10:30:00Z to 2018-09-20T10:40:00Z. If the stream is interrupted during this time interval, the duration of the returned media asset file will be Less than 10 minutes, in which case it can be sensed via the output parameter <a href="#p_segmentset">SegmentSet</a>.
        /// 
        /// ### Clip solidification
        /// Clip solidification means saving the clipped video into an independent video (with an independent FileId). Its life cycle is not affected by the original live broadcast recording video (even if the original recording video is deleted, the editing results will not be affected in any way); it can also be subjected to secondary processing such as transcoding.
        /// 
        /// For example: for a complete football match, the original video recorded live may be as long as 2 hours. To save costs, the customer can store this video for 2 months, but for the "highlight moment" video that is edited in real time during the live broadcast However, you can specify a longer storage period, and at the same time, you can separately transcode the "highlight moments" video and other on-demand operations. At this time, you can choose the solution of real-time editing and solidification of the live broadcast.
        /// 
        /// The advantage of editing and curing is that its life cycle is independent of the original recorded video, and can be managed independently and stored for a long time.
        /// 
        /// <font color='red'>Notice:</font> If solidification is specified during clipping, enable the reception of persistence completed event notifications through the ModifyEventConfig interface. After successful solidification, an event notification of type PersistenceComplete will be received. Before receiving this event notification, operations such as deletion or cooling down of live recording videos should not be performed, otherwise, abnormal playback may occur in the video generated by the clipping.
        /// 
        /// ### Clips are not solidified
        /// The editing is not solidified, which means that the result of editing (m3u8 file) and the live recording video share the same ts fragment. The newly generated video is not an independent and complete video (no independent FileId, only playback URL), and its validity period is the same as the live broadcast. The validity period of the complete recorded video is the same. Once the video recorded during the live broadcast is deleted, the clip will also become unplayable.
        /// 
        /// The clip is not solidified. Because the clip result is not an independent video, it will not be included in on-demand media asset video management (for example, the total number of videos in the console will not count this clip), and this clip cannot be transcoded separately. Video processing operations.
        /// 
        /// The advantage of not solidifying editing is that its editing operation is very "lightweight" and does not generate additional storage overhead. However, its disadvantage is that the life cycle is the same as the original recorded video, and further video processing such as transcoding cannot be performed.
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public Task<LiveRealTimeClipResponse> LiveRealTimeClip(LiveRealTimeClipRequest req)
        {
            return InternalRequestAsync<LiveRealTimeClipResponse>(req, "LiveRealTimeClip");
        }

        /// <summary>
        /// Live broadcast real-time editing means that during the live broadcast process (that is, before the live broadcast has ended), customers can select a section of past live broadcast content to generate a new video (HLS format) in real time. Developers can share it immediately, or permanently Save it.
        /// 
        /// Tencent Cloud VOD supports two real-time editing modes:
        /// - Editing and solidification: Save the edited video as an independent video with an independent FileId; suitable for scenes where the highlight clips are saved for a long time;
        /// - Editing is not solidified: the edited video is attached to the live broadcast recording file and does not have an independent FileId; it is suitable for scenarios where highlight clips are **temporarily shared**.
        /// 
        /// Notice:
        /// - The prerequisite for using the live broadcast real-time editing function is that the target live stream has the [Time Shift Replay](https://intl.cloud.tencent.com/document/product/267/32742?from_cn_redirect=1) function enabled.
        /// - Live broadcast real-time editing is based on the m3u8 file generated by live broadcast recording, so its minimum editing accuracy is one ts slice, and it is impossible to achieve second-level or more precise editing accuracy.
        /// - Since the stream may be interrupted during the live broadcast, the actual video duration generated by editing may be inconsistent with expectations. For example, the time interval for editing a live stream is from 2018-09-20T10:30:00Z to 2018-09-20T10:40:00Z. If the stream is interrupted during this time interval, the duration of the returned media asset file will be Less than 10 minutes, in which case it can be sensed via the output parameter <a href="#p_segmentset">SegmentSet</a>.
        /// 
        /// ### Clip solidification
        /// Clip solidification means saving the clipped video into an independent video (with an independent FileId). Its life cycle is not affected by the original live broadcast recording video (even if the original recording video is deleted, the editing results will not be affected in any way); it can also be subjected to secondary processing such as transcoding.
        /// 
        /// For example: for a complete football match, the original video recorded live may be as long as 2 hours. To save costs, the customer can store this video for 2 months, but for the "highlight moment" video that is edited in real time during the live broadcast However, you can specify a longer storage period, and at the same time, you can separately transcode the "highlight moments" video and other on-demand operations. At this time, you can choose the solution of real-time editing and solidification of the live broadcast.
        /// 
        /// The advantage of editing and curing is that its life cycle is independent of the original recorded video, and can be managed independently and stored for a long time.
        /// 
        /// <font color='red'>Notice:</font> If solidification is specified during clipping, enable the reception of persistence completed event notifications through the ModifyEventConfig interface. After successful solidification, an event notification of type PersistenceComplete will be received. Before receiving this event notification, operations such as deletion or cooling down of live recording videos should not be performed, otherwise, abnormal playback may occur in the video generated by the clipping.
        /// 
        /// ### Clips are not solidified
        /// The editing is not solidified, which means that the result of editing (m3u8 file) and the live recording video share the same ts fragment. The newly generated video is not an independent and complete video (no independent FileId, only playback URL), and its validity period is the same as the live broadcast. The validity period of the complete recorded video is the same. Once the video recorded during the live broadcast is deleted, the clip will also become unplayable.
        /// 
        /// The clip is not solidified. Because the clip result is not an independent video, it will not be included in on-demand media asset video management (for example, the total number of videos in the console will not count this clip), and this clip cannot be transcoded separately. Video processing operations.
        /// 
        /// The advantage of not solidifying editing is that its editing operation is very "lightweight" and does not generate additional storage overhead. However, its disadvantage is that the life cycle is the same as the original recorded video, and further video processing such as transcoding cannot be performed.
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public LiveRealTimeClipResponse LiveRealTimeClipSync(LiveRealTimeClipRequest req)
        {
            return InternalRequestAsync<LiveRealTimeClipResponse>(req, "LiveRealTimeClip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage initiated tasks.
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public Task<ManageTaskResponse> ManageTask(ManageTaskRequest req)
        {
            return InternalRequestAsync<ManageTaskResponse>(req, "ManageTask");
        }

        /// <summary>
        /// This API is used to manage initiated tasks.
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public ManageTaskResponse ManageTaskSync(ManageTaskRequest req)
        {
            return InternalRequestAsync<ManageTaskResponse>(req, "ManageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom video content analysis template.
        /// 
        /// Note: templates with an ID below 10000 are preset and cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public Task<ModifyAIAnalysisTemplateResponse> ModifyAIAnalysisTemplate(ModifyAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIAnalysisTemplateResponse>(req, "ModifyAIAnalysisTemplate");
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
            return InternalRequestAsync<ModifyAIAnalysisTemplateResponse>(req, "ModifyAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public ModifyAIRecognitionTemplateResponse ModifyAIRecognitionTemplateSync(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<ModifyAdaptiveDynamicStreamingTemplateResponse> ModifyAdaptiveDynamicStreamingTemplate(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAdaptiveDynamicStreamingTemplateResponse>(req, "ModifyAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// This API is used to modify an adaptive bitrate streaming template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public ModifyAdaptiveDynamicStreamingTemplateResponse ModifyAdaptiveDynamicStreamingTemplateSync(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAdaptiveDynamicStreamingTemplateResponse>(req, "ModifyAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public Task<ModifyAnimatedGraphicsTemplateResponse> ModifyAnimatedGraphicsTemplate(ModifyAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAnimatedGraphicsTemplateResponse>(req, "ModifyAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public ModifyAnimatedGraphicsTemplateResponse ModifyAnimatedGraphicsTemplateSync(ModifyAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAnimatedGraphicsTemplateResponse>(req, "ModifyAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify CDN Domain Config.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDNDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyCDNDomainConfigResponse"/></returns>
        public Task<ModifyCDNDomainConfigResponse> ModifyCDNDomainConfig(ModifyCDNDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyCDNDomainConfigResponse>(req, "ModifyCDNDomainConfig");
        }

        /// <summary>
        /// Modify CDN Domain Config.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDNDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyCDNDomainConfigResponse"/></returns>
        public ModifyCDNDomainConfigResponse ModifyCDNDomainConfigSync(ModifyCDNDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyCDNDomainConfigResponse>(req, "ModifyCDNDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the category of a media file.
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public Task<ModifyClassResponse> ModifyClass(ModifyClassRequest req)
        {
            return InternalRequestAsync<ModifyClassResponse>(req, "ModifyClass");
        }

        /// <summary>
        /// This API is used to modify the category of a media file.
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public ModifyClassResponse ModifyClassSync(ModifyClassRequest req)
        {
            return InternalRequestAsync<ModifyClassResponse>(req, "ModifyClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [ModifyReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84388?from_cn_redirect=1).
        /// This API is used to modify a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate");
        }

        /// <summary>
        /// We have <font color=red>stopped updating</font> this API. Our new moderation templates can moderate audio/video as well as images. For details, see [ModifyReviewTemplate](https://intl.cloud.tencent.com/document/api/266/84388?from_cn_redirect=1).
        /// This API is used to modify a custom audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the default storage region. A file will be stored in the default region if no region is specified for file upload.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public Task<ModifyDefaultStorageRegionResponse> ModifyDefaultStorageRegion(ModifyDefaultStorageRegionRequest req)
        {
            return InternalRequestAsync<ModifyDefaultStorageRegionResponse>(req, "ModifyDefaultStorageRegion");
        }

        /// <summary>
        /// This API is used to set the default storage region. A file will be stored in the default region if no region is specified for file upload.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public ModifyDefaultStorageRegionResponse ModifyDefaultStorageRegionSync(ModifyDefaultStorageRegionRequest req)
        {
            return InternalRequestAsync<ModifyDefaultStorageRegionResponse>(req, "ModifyDefaultStorageRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify enhance media template.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyEnhanceMediaTemplateResponse"/></returns>
        public Task<ModifyEnhanceMediaTemplateResponse> ModifyEnhanceMediaTemplate(ModifyEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyEnhanceMediaTemplateResponse>(req, "ModifyEnhanceMediaTemplate");
        }

        /// <summary>
        /// Modify enhance media template.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyEnhanceMediaTemplateResponse"/></returns>
        public ModifyEnhanceMediaTemplateResponse ModifyEnhanceMediaTemplateSync(ModifyEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyEnhanceMediaTemplateResponse>(req, "ModifyEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tencent Cloud VOD provides customers with media upload, media management, media processing and other services. During or at the end of the execution of these services, Tencent Cloud On-Demand also provides various corresponding event notifications to facilitate developers to perceive the service processing status and Do the next business operation. 
        /// 
        /// Developers can achieve this by calling this interface:
        /// - Set the type of callback notification received. Currently, there is [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33948) and [reliable notification based on message queue](https://www.tencentcloud.com/document/product/266/33948) two types. 
        /// - For [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33948), you can set the address of the 3.0 format callback. For the description of 3.0 format callback, see [Historical Format Callback](https://intl.cloud.tencent.com/document/product/266/33796?from_cn_redirect=1). 
        /// - Select settings to receive or ignore notification events for specific event services.
        /// </summary>
        /// <param name="req"><see cref="ModifyEventConfigRequest"/></param>
        /// <returns><see cref="ModifyEventConfigResponse"/></returns>
        public Task<ModifyEventConfigResponse> ModifyEventConfig(ModifyEventConfigRequest req)
        {
            return InternalRequestAsync<ModifyEventConfigResponse>(req, "ModifyEventConfig");
        }

        /// <summary>
        /// Tencent Cloud VOD provides customers with media upload, media management, media processing and other services. During or at the end of the execution of these services, Tencent Cloud On-Demand also provides various corresponding event notifications to facilitate developers to perceive the service processing status and Do the next business operation. 
        /// 
        /// Developers can achieve this by calling this interface:
        /// - Set the type of callback notification received. Currently, there is [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33948) and [reliable notification based on message queue](https://www.tencentcloud.com/document/product/266/33948) two types. 
        /// - For [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33948), you can set the address of the 3.0 format callback. For the description of 3.0 format callback, see [Historical Format Callback](https://intl.cloud.tencent.com/document/product/266/33796?from_cn_redirect=1). 
        /// - Select settings to receive or ignore notification events for specific event services.
        /// </summary>
        /// <param name="req"><see cref="ModifyEventConfigRequest"/></param>
        /// <returns><see cref="ModifyEventConfigResponse"/></returns>
        public ModifyEventConfigResponse ModifyEventConfigSync(ModifyEventConfigRequest req)
        {
            return InternalRequestAsync<ModifyEventConfigResponse>(req, "ModifyEventConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify HeadTail Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyHeadTailTemplateRequest"/></param>
        /// <returns><see cref="ModifyHeadTailTemplateResponse"/></returns>
        public Task<ModifyHeadTailTemplateResponse> ModifyHeadTailTemplate(ModifyHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHeadTailTemplateResponse>(req, "ModifyHeadTailTemplate");
        }

        /// <summary>
        /// Modify HeadTail Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyHeadTailTemplateRequest"/></param>
        /// <returns><see cref="ModifyHeadTailTemplateResponse"/></returns>
        public ModifyHeadTailTemplateResponse ModifyHeadTailTemplateSync(ModifyHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHeadTailTemplateResponse>(req, "ModifyHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public Task<ModifyImageSpriteTemplateResponse> ModifyImageSpriteTemplate(ModifyImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<ModifyImageSpriteTemplateResponse>(req, "ModifyImageSpriteTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom image sprite generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public ModifyImageSpriteTemplateResponse ModifyImageSpriteTemplateSync(ModifyImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<ModifyImageSpriteTemplateResponse>(req, "ModifyImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Just In Time Transcode Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<ModifyJustInTimeTranscodeTemplateResponse> ModifyJustInTimeTranscodeTemplate(ModifyJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyJustInTimeTranscodeTemplateResponse>(req, "ModifyJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// Modify Just In Time Transcode Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyJustInTimeTranscodeTemplateResponse"/></returns>
        public ModifyJustInTimeTranscodeTemplateResponse ModifyJustInTimeTranscodeTemplateSync(ModifyJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyJustInTimeTranscodeTemplateResponse>(req, "ModifyJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a media file, including category, name, description, tag, expiration time, timestamp information, video thumbnail, and subtitle information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public Task<ModifyMediaInfoResponse> ModifyMediaInfo(ModifyMediaInfoRequest req)
        {
            return InternalRequestAsync<ModifyMediaInfoResponse>(req, "ModifyMediaInfo");
        }

        /// <summary>
        /// This API is used to modify the attributes of a media file, including category, name, description, tag, expiration time, timestamp information, video thumbnail, and subtitle information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public ModifyMediaInfoResponse ModifyMediaInfoSync(ModifyMediaInfoRequest req)
        {
            return InternalRequestAsync<ModifyMediaInfoResponse>(req, "ModifyMediaInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<ModifyMediaStorageClassResponse> ModifyMediaStorageClass(ModifyMediaStorageClassRequest req)
        {
            return InternalRequestAsync<ModifyMediaStorageClassResponse>(req, "ModifyMediaStorageClass");
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
            return InternalRequestAsync<ModifyMediaStorageClassResponse>(req, "ModifyMediaStorageClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify sample information according to the sample ID. You can modify the name and description, add, delete, and reset facial features or tags. Leave at least one image after deleting facial features. To leave no image, please use the reset operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample");
        }

        /// <summary>
        /// This API is used to modify sample information according to the sample ID. You can modify the name and description, add, delete, and reset facial features or tags. Leave at least one image after deleting facial features. To leave no image, please use the reset operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public ModifyPersonSampleResponse ModifyPersonSampleSync(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityInspectTemplateResponse"/></returns>
        public Task<ModifyQualityInspectTemplateResponse> ModifyQualityInspectTemplate(ModifyQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityInspectTemplateResponse>(req, "ModifyQualityInspectTemplate");
        }

        /// <summary>
        /// Modifies media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityInspectTemplateResponse"/></returns>
        public ModifyQualityInspectTemplateResponse ModifyQualityInspectTemplateSync(ModifyQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityInspectTemplateResponse>(req, "ModifyQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Rebuild Media Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public Task<ModifyRebuildMediaTemplateResponse> ModifyRebuildMediaTemplate(ModifyRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRebuildMediaTemplateResponse>(req, "ModifyRebuildMediaTemplate");
        }

        /// <summary>
        /// Modify Rebuild Media Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public ModifyRebuildMediaTemplateResponse ModifyRebuildMediaTemplateSync(ModifyRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRebuildMediaTemplateResponse>(req, "ModifyRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public Task<ModifyReviewTemplateResponse> ModifyReviewTemplate(ModifyReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyReviewTemplateResponse>(req, "ModifyReviewTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom moderation template.
        /// > The templates can only be used by the APIs [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) and [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public ModifyReviewTemplateResponse ModifyReviewTemplateSync(ModifyReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyReviewTemplateResponse>(req, "ModifyReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a playlist.
        /// The modification will only take effect for new playback requests. For ongoing playback, the old playlist will be playable for seven days after the modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public Task<ModifyRoundPlayResponse> ModifyRoundPlay(ModifyRoundPlayRequest req)
        {
            return InternalRequestAsync<ModifyRoundPlayResponse>(req, "ModifyRoundPlay");
        }

        /// <summary>
        /// This API is used to modify a playlist.
        /// The modification will only take effect for new playback requests. For ongoing playback, the old playlist will be playable for seven days after the modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public ModifyRoundPlayResponse ModifyRoundPlaySync(ModifyRoundPlayRequest req)
        {
            return InternalRequestAsync<ModifyRoundPlayResponse>(req, "ModifyRoundPlay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public Task<ModifySampleSnapshotTemplateResponse> ModifySampleSnapshotTemplate(ModifySampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifySampleSnapshotTemplateResponse>(req, "ModifySampleSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom sampled screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public ModifySampleSnapshotTemplateResponse ModifySampleSnapshotTemplateSync(ModifySampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifySampleSnapshotTemplateResponse>(req, "ModifySampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<ModifySnapshotByTimeOffsetTemplateResponse> ModifySnapshotByTimeOffsetTemplate(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<ModifySnapshotByTimeOffsetTemplateResponse>(req, "ModifySnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom time point screencapturing template.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public ModifySnapshotByTimeOffsetTemplateResponse ModifySnapshotByTimeOffsetTemplateSync(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<ModifySnapshotByTimeOffsetTemplateResponse>(req, "ModifySnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify subapplication information, but it is not allowed to modify primary application information.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public Task<ModifySubAppIdInfoResponse> ModifySubAppIdInfo(ModifySubAppIdInfoRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdInfoResponse>(req, "ModifySubAppIdInfo");
        }

        /// <summary>
        /// This API is used to modify subapplication information, but it is not allowed to modify primary application information.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public ModifySubAppIdInfoResponse ModifySubAppIdInfoSync(ModifySubAppIdInfoRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdInfoResponse>(req, "ModifySubAppIdInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable/disable a subapplication. After a subapplication is disabled, its corresponding domain name will be blocked and its access to the console will be restricted.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public Task<ModifySubAppIdStatusResponse> ModifySubAppIdStatus(ModifySubAppIdStatusRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdStatusResponse>(req, "ModifySubAppIdStatus");
        }

        /// <summary>
        /// This API is used to enable/disable a subapplication. After a subapplication is disabled, its corresponding domain name will be blocked and its access to the console will be restricted.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public ModifySubAppIdStatusResponse ModifySubAppIdStatusSync(ModifySubAppIdStatusRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdStatusResponse>(req, "ModifySubAppIdStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to modify a player configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public Task<ModifySuperPlayerConfigResponse> ModifySuperPlayerConfig(ModifySuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<ModifySuperPlayerConfigResponse>(req, "ModifySuperPlayerConfig");
        }

        /// <summary>
        /// We have <font color='red'>stopped updating</font> this API. Currently, you no longer need a player configuration to use player signatures. For details, see [Player Signature](https://intl.cloud.tencent.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to modify a player configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public ModifySuperPlayerConfigResponse ModifySuperPlayerConfigSync(ModifySuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<ModifySuperPlayerConfigResponse>(req, "ModifySuperPlayerConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public Task<ModifyTranscodeTemplateResponse> ModifyTranscodeTemplate(ModifyTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTranscodeTemplateResponse>(req, "ModifyTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public ModifyTranscodeTemplateResponse ModifyTranscodeTemplateSync(ModifyTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTranscodeTemplateResponse>(req, "ModifyTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the acceleration region of a domain name on VOD.
        /// 1. You can modify acceleration regions of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public Task<ModifyVodDomainAccelerateConfigResponse> ModifyVodDomainAccelerateConfig(ModifyVodDomainAccelerateConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainAccelerateConfigResponse>(req, "ModifyVodDomainAccelerateConfig");
        }

        /// <summary>
        /// This API is used to modify the acceleration region of a domain name on VOD.
        /// 1. You can modify acceleration regions of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public ModifyVodDomainAccelerateConfigResponse ModifyVodDomainAccelerateConfigSync(ModifyVodDomainAccelerateConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainAccelerateConfigResponse>(req, "ModifyVodDomainAccelerateConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify domain name settings, such as the hotlink protection configuration.
        /// 1. You can modify settings of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public Task<ModifyVodDomainConfigResponse> ModifyVodDomainConfig(ModifyVodDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainConfigResponse>(req, "ModifyVodDomainConfig");
        }

        /// <summary>
        /// This API is used to modify domain name settings, such as the hotlink protection configuration.
        /// 1. You can modify settings of only domain names whose status is `Online`.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public ModifyVodDomainConfigResponse ModifyVodDomainConfigSync(ModifyVodDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainConfigResponse>(req, "ModifyVodDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom watermarking template. The watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public Task<ModifyWatermarkTemplateResponse> ModifyWatermarkTemplate(ModifyWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWatermarkTemplateResponse>(req, "ModifyWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom watermarking template. The watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public ModifyWatermarkTemplateResponse ModifyWatermarkTemplateSync(ModifyWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWatermarkTemplateResponse>(req, "ModifyWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the use case and tag of a keyword. The keyword itself cannot be modified, but you can delete it and create another one if needed.
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public Task<ModifyWordSampleResponse> ModifyWordSample(ModifyWordSampleRequest req)
        {
            return InternalRequestAsync<ModifyWordSampleResponse>(req, "ModifyWordSample");
        }

        /// <summary>
        /// This API is used to modify the use case and tag of a keyword. The keyword itself cannot be modified, but you can delete it and create another one if needed.
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public ModifyWordSampleResponse ModifyWordSampleSync(ModifyWordSampleRequest req)
        {
            return InternalRequestAsync<ModifyWordSampleResponse>(req, "ModifyWordSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to parse the index file content and return the list of segment files to be uploaded when an HLS video is uploaded. A segment file path must be a relative path of the current directory or subdirectory instead of a URL or absolute path.
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public Task<ParseStreamingManifestResponse> ParseStreamingManifest(ParseStreamingManifestRequest req)
        {
            return InternalRequestAsync<ParseStreamingManifestResponse>(req, "ParseStreamingManifest");
        }

        /// <summary>
        /// This API is used to parse the index file content and return the list of segment files to be uploaded when an HLS video is uploaded. A segment file path must be a relative path of the current directory or subdirectory instead of a URL or absolute path.
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public ParseStreamingManifestResponse ParseStreamingManifestSync(ParseStreamingManifestRequest req)
        {
            return InternalRequestAsync<ParseStreamingManifestResponse>(req, "ParseStreamingManifest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate processing tasks for media file in VOD, including: 
        /// 1. Video transcoding (with Watermark); 
        /// 2. Video to animated image; 
        /// 3. Screencapturing the video at specified Time point;
        /// 4. Sampled screenshot of the video;
        /// 5. Generated Image sprite template from the video;
        /// 6. Generated a cover image from the video;
        /// 7. Adaptive Bitrate Streaming for the video (with encryption); 
        /// 8. Content Moderation (offensive Information, unsafe Information, inappropriate Information), it is <font color=red>not recommended</font> to use this API, recommend using [Video moderation(ReviewAudioVideo)](https://www.tencentcloud.com/document/api/266/50634) or [Image moderation(ReviewImage)](https://www.tencentcloud.com/document/api/266/47138);
        /// 9. Content analysis (tag, category, cover, frame-by-frame tag);
        /// 10. Content recognition (video intro and outro, face, Text, keyword, voice, Key object).
        /// 
        /// If using event notification, the event notification type is [task flow status change](https://www.tencentcloud.com/document/product/266/33953).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia");
        }

        /// <summary>
        /// Initiate processing tasks for media file in VOD, including: 
        /// 1. Video transcoding (with Watermark); 
        /// 2. Video to animated image; 
        /// 3. Screencapturing the video at specified Time point;
        /// 4. Sampled screenshot of the video;
        /// 5. Generated Image sprite template from the video;
        /// 6. Generated a cover image from the video;
        /// 7. Adaptive Bitrate Streaming for the video (with encryption); 
        /// 8. Content Moderation (offensive Information, unsafe Information, inappropriate Information), it is <font color=red>not recommended</font> to use this API, recommend using [Video moderation(ReviewAudioVideo)](https://www.tencentcloud.com/document/api/266/50634) or [Image moderation(ReviewImage)](https://www.tencentcloud.com/document/api/266/47138);
        /// 9. Content analysis (tag, category, cover, frame-by-frame tag);
        /// 10. Content recognition (video intro and outro, face, Text, keyword, voice, Key object).
        /// 
        /// If using event notification, the event notification type is [task flow status change](https://www.tencentcloud.com/document/product/266/33953).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public ProcessMediaResponse ProcessMediaSync(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<ProcessMediaByProcedureResponse> ProcessMediaByProcedure(ProcessMediaByProcedureRequest req)
        {
            return InternalRequestAsync<ProcessMediaByProcedureResponse>(req, "ProcessMediaByProcedure");
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
            return InternalRequestAsync<ProcessMediaByProcedureResponse>(req, "ProcessMediaByProcedure")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color='red'>disused</font>, please use [ProcessMedia](https://intl.cloud.tencent.com/document/product/862/37578?from_cn_redirect=1) API of MPS, with the input parameter `InputInfo.UrlInputInfo.Url` set to a video URL.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public Task<ProcessMediaByUrlResponse> ProcessMediaByUrl(ProcessMediaByUrlRequest req)
        {
            return InternalRequestAsync<ProcessMediaByUrlResponse>(req, "ProcessMediaByUrl");
        }

        /// <summary>
        /// This API is <font color='red'>disused</font>, please use [ProcessMedia](https://intl.cloud.tencent.com/document/product/862/37578?from_cn_redirect=1) API of MPS, with the input parameter `InputInfo.UrlInputInfo.Url` set to a video URL.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public ProcessMediaByUrlResponse ProcessMediaByUrlSync(ProcessMediaByUrlRequest req)
        {
            return InternalRequestAsync<ProcessMediaByUrlResponse>(req, "ProcessMediaByUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * This API is used to get event notifications from the business server through [reliable callback](https://intl.cloud.tencent.com/document/product/266/33948).
        /// * The API gets event data through long polling. That is, if there is any unconsumed event on the server, the event notification will be returned to the requester immediately. If there is no unconsumed event on the server, the request will be suspended in the backend until a new event is generated.
        /// * The request can be suspended for up to 5 seconds. It's recommended to set the request timeout period to 10 seconds.
        /// * Event notifications not pulled will be retained for up to 4 days and may be cleared after this period.
        /// * After the API returns an event, the caller must call the [ConfirmEvents](https://intl.cloud.tencent.com/document/product/266/34184) API within <font color="red">30 seconds</font> to confirm that the event notification has been processed. Otherwise, the event notification will be pulled again after <font color="red">30 seconds</font>.
        /// * This API can get up to 16 event notifications at a time.
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public Task<PullEventsResponse> PullEvents(PullEventsRequest req)
        {
            return InternalRequestAsync<PullEventsResponse>(req, "PullEvents");
        }

        /// <summary>
        /// * This API is used to get event notifications from the business server through [reliable callback](https://intl.cloud.tencent.com/document/product/266/33948).
        /// * The API gets event data through long polling. That is, if there is any unconsumed event on the server, the event notification will be returned to the requester immediately. If there is no unconsumed event on the server, the request will be suspended in the backend until a new event is generated.
        /// * The request can be suspended for up to 5 seconds. It's recommended to set the request timeout period to 10 seconds.
        /// * Event notifications not pulled will be retained for up to 4 days and may be cleared after this period.
        /// * After the API returns an event, the caller must call the [ConfirmEvents](https://intl.cloud.tencent.com/document/product/266/34184) API within <font color="red">30 seconds</font> to confirm that the event notification has been processed. Otherwise, the event notification will be pulled again after <font color="red">30 seconds</font>.
        /// * This API can get up to 16 event notifications at a time.
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public PullEventsResponse PullEventsSync(PullEventsRequest req)
        {
            return InternalRequestAsync<PullEventsResponse>(req, "PullEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull a video on the internet to the VOD platform.
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public Task<PullUploadResponse> PullUpload(PullUploadRequest req)
        {
            return InternalRequestAsync<PullUploadResponse>(req, "PullUpload");
        }

        /// <summary>
        /// This API is used to pull a video on the internet to the VOD platform.
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public PullUploadResponse PullUploadSync(PullUploadRequest req)
        {
            return InternalRequestAsync<PullUploadResponse>(req, "PullUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. This API is used to prefetch a list of specified URLs.
        /// 2. The URL domain names must have already been registered with VOD.
        /// 3. Up to 20 URLs can be specified in one request.
        /// 4. By default, the maximum number of URLs that can be refreshed per day is 10,000.
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public Task<PushUrlCacheResponse> PushUrlCache(PushUrlCacheRequest req)
        {
            return InternalRequestAsync<PushUrlCacheResponse>(req, "PushUrlCache");
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
            return InternalRequestAsync<PushUrlCacheResponse>(req, "PushUrlCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate rebuild media
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public Task<RebuildMediaResponse> RebuildMedia(RebuildMediaRequest req)
        {
            return InternalRequestAsync<RebuildMediaResponse>(req, "RebuildMedia");
        }

        /// <summary>
        /// Initiate rebuild media
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public RebuildMediaResponse RebuildMediaSync(RebuildMediaRequest req)
        {
            return InternalRequestAsync<RebuildMediaResponse>(req, "RebuildMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rebuild media by template.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public Task<RebuildMediaByTemplateResponse> RebuildMediaByTemplate(RebuildMediaByTemplateRequest req)
        {
            return InternalRequestAsync<RebuildMediaByTemplateResponse>(req, "RebuildMediaByTemplate");
        }

        /// <summary>
        /// Rebuild media by template.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public RebuildMediaByTemplateResponse RebuildMediaByTemplateSync(RebuildMediaByTemplateRequest req)
        {
            return InternalRequestAsync<RebuildMediaByTemplateResponse>(req, "RebuildMediaByTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. This API is used to purge URLs.
        /// 2. The URL domain names must have already been registered with VOD.
        /// 3. Up to 20 URLs can be specified in one request.
        /// 4. By default, the maximum number of URLs allowed for purge per day is 100,000.
        /// </summary>
        /// <param name="req"><see cref="RefreshUrlCacheRequest"/></param>
        /// <returns><see cref="RefreshUrlCacheResponse"/></returns>
        public Task<RefreshUrlCacheResponse> RefreshUrlCache(RefreshUrlCacheRequest req)
        {
            return InternalRequestAsync<RefreshUrlCacheResponse>(req, "RefreshUrlCache");
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
            return InternalRequestAsync<RefreshUrlCacheResponse>(req, "RefreshUrlCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove watermarks from a video.
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public Task<RemoveWatermarkResponse> RemoveWatermark(RemoveWatermarkRequest req)
        {
            return InternalRequestAsync<RemoveWatermarkResponse>(req, "RemoveWatermark");
        }

        /// <summary>
        /// This API is used to remove watermarks from a video.
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public RemoveWatermarkResponse RemoveWatermarkSync(RemoveWatermarkRequest req)
        {
            return InternalRequestAsync<RemoveWatermarkResponse>(req, "RemoveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom task flow template.
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public Task<ResetProcedureTemplateResponse> ResetProcedureTemplate(ResetProcedureTemplateRequest req)
        {
            return InternalRequestAsync<ResetProcedureTemplateResponse>(req, "ResetProcedureTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom task flow template.
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public ResetProcedureTemplateResponse ResetProcedureTemplateSync(ResetProcedureTemplateRequest req)
        {
            return InternalRequestAsync<ResetProcedureTemplateResponse>(req, "ResetProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restore files from ARCHIVE or DEEP ARCHIVE. Files stored in ARCHIVE or DEEP ARCHIVE must be restored before they can be accessed. Restored files are available for a limited period of time.
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public Task<RestoreMediaResponse> RestoreMedia(RestoreMediaRequest req)
        {
            return InternalRequestAsync<RestoreMediaResponse>(req, "RestoreMedia");
        }

        /// <summary>
        /// This API is used to restore files from ARCHIVE or DEEP ARCHIVE. Files stored in ARCHIVE or DEEP ARCHIVE must be restored before they can be accessed. Restored files are available for a limited period of time.
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public RestoreMediaResponse RestoreMediaSync(RestoreMediaRequest req)
        {
            return InternalRequestAsync<RestoreMediaResponse>(req, "RestoreMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a moderation task on a file stored in VOD to detect non-compliant content in images, text, speech, and voice.
        /// 
        /// If event notifications are used, the event type is [ReviewAudioVideoComplete](https://intl.cloud.tencent.com/document/product/266/81258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReviewAudioVideoRequest"/></param>
        /// <returns><see cref="ReviewAudioVideoResponse"/></returns>
        public Task<ReviewAudioVideoResponse> ReviewAudioVideo(ReviewAudioVideoRequest req)
        {
            return InternalRequestAsync<ReviewAudioVideoResponse>(req, "ReviewAudioVideo");
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
            return InternalRequestAsync<ReviewAudioVideoResponse>(req, "ReviewAudioVideo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to moderate an image stored in VOD (detect pornographic and terrorist content).><li>The image file must be smaller than 5 MB.</li> ><li>To ensure the accuracy of moderation results, the image resolution must be higher than 256 x 256 px.</li> ><li>The format must be PNG, JPG, JPEG, BMP, GIF, or WEBP.</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public Task<ReviewImageResponse> ReviewImage(ReviewImageRequest req)
        {
            return InternalRequestAsync<ReviewImageResponse>(req, "ReviewImage");
        }

        /// <summary>
        /// This API is used to moderate an image stored in VOD (detect pornographic and terrorist content).><li>The image file must be smaller than 5 MB.</li> ><li>To ensure the accuracy of moderation results, the image resolution must be higher than 256 x 256 px.</li> ><li>The format must be PNG, JPG, JPEG, BMP, GIF, or WEBP.</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public ReviewImageResponse ReviewImageSync(ReviewImageRequest req)
        {
            return InternalRequestAsync<ReviewImageResponse>(req, "ReviewImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Search for media information, supporting multiple condition filtering, as well as sorting and filtering of returned results. This includes:
        /// - Specify a collection of file IDs (FileIds) to return media with any ID in the collection.
        /// - Fuzzy search based on multiple media file names (Names) or description information (Descriptions).
        /// - Search based on multiple file name prefixes (NamePrefixes).
        /// - Specify a collection of categories (ClassIds, see input parameters) to return media that meets any category in the collection. For example, media categories include movies, TV shows, variety shows, etc., and there are subcategories such as historical films, action films, and romance films under the movie category. If ClassIds specifies movies and TV shows, all subcategories under movies and TV shows will be returned; if ClassIds specifies historical films and action films, only media under these two subcategories will be returned.
        /// - Specify a collection of tags (Tags, see input parameters) to return media that meets any tag in the collection. For example, media tags include ACG, palace fighting, and ghost animal. If Tags specifies ACG and ghost animal, media that meets any of these two tags will be retrieved.
        /// - Specify a collection of file types (Categories, see input parameters) to return media that meets any type in the collection. For example, file types include Video (video), Audio (audio), and Image (image). If Categories specifies Video and Audio, media that meets these types will be retrieved.
        /// - Specify a collection of sources (SourceTypes, see input parameters) to return media that meets any source in the collection. For example, media sources include Record (live recording) and Upload (upload). If SourceTypes specifies Record and Upload, media that meets these sources will be retrieved.
        /// - Specify a collection of file container formats (MediaTypes, see input parameters) to return media that meets any container format in the collection. For example, container formats include MP4, AVI, MP3, etc. If MediaTypes specifies MP4 and MP3, media that meets these container formats will be retrieved.
        /// - Specify a collection of file statuses (Status, see input parameters) to return media that meets any status in the collection. For example, file statuses include Normal (normal), SystemForbidden (platform ban), and Forbidden (active ban). If Status specifies Normal and Forbidden, media that meets these statuses will be retrieved.
        /// - Specify a collection of file moderation results (ReviewResults, see input parameters) to return media that meets any status in the collection. For example, file moderation results include pass (passed) and block (not compliant). If ReviewResults specifies pass and block, media that meets these moderation results will be retrieved.
        /// - Filter live recorded media by specifying a collection of live streaming codes (StreamIds, see input parameters).
        /// - Filter media by specifying the creation time range of the media.
        /// - Filter media by specifying a collection of TRTC application IDs.
        /// - Filter media by specifying a collection of TRTC room IDs.
        /// 
        /// - The above parameters can be combined in any way to search. For example, filter media created between 12:00:00 on December 1, 2018, and 12:00:00 on December 8, 2018, categorized as movies or TV shows, and tagged with palace fighting and suspense. Note that the search logic for elements of any parameter that supports array input is 'or'. The logical relationship between all parameters is 'and'
        /// 
        /// - Allow to control the type of media information returned through Filters (default to return all information). Optional inputs include:
        ///     1. Basic information (basicInfo): including media name, category, playback URL, cover image, etc.
        ///     2. Metadata (metaData): including size, duration, video stream information, audio stream information, etc.
        ///     3. Transcoding result information (transcodeInfo): including the media addresses, video stream parameters, audio stream parameters, etc., generated by transcoding the media into various specifications.
        ///     4.  Animated image result information (animatedGraphicsInfo): information on the animated image (such as gif) generated after converting the video.
        ///     Sampled screenshot information (sampleSnapshotInfo): screenshot information after sampling the video.
        ///     6. Image sprite information (imageSpriteInfo): image sprite information after generating the sprite from the video.
        ///     7. Specified time point screenshot information (snapshotByTimeOffsetInfo): screenshot information after capturing the video at specified time points.
        ///     8. Video timestamp info (keyFrameDescInfo): timestamp information set for the video.
        ///     9. Adaptive Bitrate Streaming information (adaptiveDynamicStreamingInfo): including specifications, encryption types, muxing formats, and other relevant information.
        /// 
        /// - Allow sorting the results by creation time and returning them in pages. Pagination is controlled by Offset and Limit (see input parameters).
        /// 
        /// <div id="maxResultsDesc">API result count limitation:</div>
        /// - <b><a href="#p_offset">Offset</a> and <a href="#p_limit">Limit</a> both affect the number of results returned in a single page query. Please pay special attention: when both of these values are missing, this API will return a maximum of 10 query results.</b>
        /// - <b>Supports up to 5,000 search results, and queries beyond this limit are not supported. If the search result volume is too large, it is recommended to use more refined filtering conditions to reduce search results.</b>
        /// 
        /// <br>Not recommended for conditional filtering:
        /// - (Not recommended: use Names, NamePrefixes, or Descriptions instead) Fuzzy search for media file names or description information with a single text (Text).
        /// - (Not recommended: use SourceTypes instead) Search for media files with a single source (SourceType).
        /// - (Not recommended: use StreamIds instead) Search for media files with a single live streaming code (StreamId).
        /// - (Not recommended: use CreateTime instead) Search for media files with a single start creation time (StartTime).
        /// - (Not recommended: use CreateTime instead) Search for media files with a single end creation time (EndTime).
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public Task<SearchMediaResponse> SearchMedia(SearchMediaRequest req)
        {
            return InternalRequestAsync<SearchMediaResponse>(req, "SearchMedia");
        }

        /// <summary>
        /// Search for media information, supporting multiple condition filtering, as well as sorting and filtering of returned results. This includes:
        /// - Specify a collection of file IDs (FileIds) to return media with any ID in the collection.
        /// - Fuzzy search based on multiple media file names (Names) or description information (Descriptions).
        /// - Search based on multiple file name prefixes (NamePrefixes).
        /// - Specify a collection of categories (ClassIds, see input parameters) to return media that meets any category in the collection. For example, media categories include movies, TV shows, variety shows, etc., and there are subcategories such as historical films, action films, and romance films under the movie category. If ClassIds specifies movies and TV shows, all subcategories under movies and TV shows will be returned; if ClassIds specifies historical films and action films, only media under these two subcategories will be returned.
        /// - Specify a collection of tags (Tags, see input parameters) to return media that meets any tag in the collection. For example, media tags include ACG, palace fighting, and ghost animal. If Tags specifies ACG and ghost animal, media that meets any of these two tags will be retrieved.
        /// - Specify a collection of file types (Categories, see input parameters) to return media that meets any type in the collection. For example, file types include Video (video), Audio (audio), and Image (image). If Categories specifies Video and Audio, media that meets these types will be retrieved.
        /// - Specify a collection of sources (SourceTypes, see input parameters) to return media that meets any source in the collection. For example, media sources include Record (live recording) and Upload (upload). If SourceTypes specifies Record and Upload, media that meets these sources will be retrieved.
        /// - Specify a collection of file container formats (MediaTypes, see input parameters) to return media that meets any container format in the collection. For example, container formats include MP4, AVI, MP3, etc. If MediaTypes specifies MP4 and MP3, media that meets these container formats will be retrieved.
        /// - Specify a collection of file statuses (Status, see input parameters) to return media that meets any status in the collection. For example, file statuses include Normal (normal), SystemForbidden (platform ban), and Forbidden (active ban). If Status specifies Normal and Forbidden, media that meets these statuses will be retrieved.
        /// - Specify a collection of file moderation results (ReviewResults, see input parameters) to return media that meets any status in the collection. For example, file moderation results include pass (passed) and block (not compliant). If ReviewResults specifies pass and block, media that meets these moderation results will be retrieved.
        /// - Filter live recorded media by specifying a collection of live streaming codes (StreamIds, see input parameters).
        /// - Filter media by specifying the creation time range of the media.
        /// - Filter media by specifying a collection of TRTC application IDs.
        /// - Filter media by specifying a collection of TRTC room IDs.
        /// 
        /// - The above parameters can be combined in any way to search. For example, filter media created between 12:00:00 on December 1, 2018, and 12:00:00 on December 8, 2018, categorized as movies or TV shows, and tagged with palace fighting and suspense. Note that the search logic for elements of any parameter that supports array input is 'or'. The logical relationship between all parameters is 'and'
        /// 
        /// - Allow to control the type of media information returned through Filters (default to return all information). Optional inputs include:
        ///     1. Basic information (basicInfo): including media name, category, playback URL, cover image, etc.
        ///     2. Metadata (metaData): including size, duration, video stream information, audio stream information, etc.
        ///     3. Transcoding result information (transcodeInfo): including the media addresses, video stream parameters, audio stream parameters, etc., generated by transcoding the media into various specifications.
        ///     4.  Animated image result information (animatedGraphicsInfo): information on the animated image (such as gif) generated after converting the video.
        ///     Sampled screenshot information (sampleSnapshotInfo): screenshot information after sampling the video.
        ///     6. Image sprite information (imageSpriteInfo): image sprite information after generating the sprite from the video.
        ///     7. Specified time point screenshot information (snapshotByTimeOffsetInfo): screenshot information after capturing the video at specified time points.
        ///     8. Video timestamp info (keyFrameDescInfo): timestamp information set for the video.
        ///     9. Adaptive Bitrate Streaming information (adaptiveDynamicStreamingInfo): including specifications, encryption types, muxing formats, and other relevant information.
        /// 
        /// - Allow sorting the results by creation time and returning them in pages. Pagination is controlled by Offset and Limit (see input parameters).
        /// 
        /// <div id="maxResultsDesc">API result count limitation:</div>
        /// - <b><a href="#p_offset">Offset</a> and <a href="#p_limit">Limit</a> both affect the number of results returned in a single page query. Please pay special attention: when both of these values are missing, this API will return a maximum of 10 query results.</b>
        /// - <b>Supports up to 5,000 search results, and queries beyond this limit are not supported. If the search result volume is too large, it is recommended to use more refined filtering conditions to reduce search results.</b>
        /// 
        /// <br>Not recommended for conditional filtering:
        /// - (Not recommended: use Names, NamePrefixes, or Descriptions instead) Fuzzy search for media file names or description information with a single text (Text).
        /// - (Not recommended: use SourceTypes instead) Search for media files with a single source (SourceType).
        /// - (Not recommended: use StreamIds instead) Search for media files with a single live streaming code (StreamId).
        /// - (Not recommended: use CreateTime instead) Search for media files with a single start creation time (StartTime).
        /// - (Not recommended: use CreateTime instead) Search for media files with a single end creation time (EndTime).
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public SearchMediaResponse SearchMediaSync(SearchMediaRequest req)
        {
            return InternalRequestAsync<SearchMediaResponse>(req, "SearchMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure DRM key information.
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public Task<SetDrmKeyProviderInfoResponse> SetDrmKeyProviderInfo(SetDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<SetDrmKeyProviderInfoResponse>(req, "SetDrmKeyProviderInfo");
        }

        /// <summary>
        /// This API is used to configure DRM key information.
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public SetDrmKeyProviderInfoResponse SetDrmKeyProviderInfoSync(SetDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<SetDrmKeyProviderInfoResponse>(req, "SetDrmKeyProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set Vod Domain Certificate.
        /// </summary>
        /// <param name="req"><see cref="SetVodDomainCertificateRequest"/></param>
        /// <returns><see cref="SetVodDomainCertificateResponse"/></returns>
        public Task<SetVodDomainCertificateResponse> SetVodDomainCertificate(SetVodDomainCertificateRequest req)
        {
            return InternalRequestAsync<SetVodDomainCertificateResponse>(req, "SetVodDomainCertificate");
        }

        /// <summary>
        /// Set Vod Domain Certificate.
        /// </summary>
        /// <param name="req"><see cref="SetVodDomainCertificateRequest"/></param>
        /// <returns><see cref="SetVodDomainCertificateResponse"/></returns>
        public SetVodDomainCertificateResponse SetVodDomainCertificateSync(SetVodDomainCertificateRequest req)
        {
            return InternalRequestAsync<SetVodDomainCertificateResponse>(req, "SetVodDomainCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// <font color='red'>Notice:</font> If solidification is specified during clipping, enable the reception of persistence completed event notifications through the ModifyEventConfig interface. After successful solidification, an event notification of type PersistenceComplete will be received. Before receiving this event notification, operations such as deletion or cooling down of live recording videos should not be performed, otherwise, abnormal playback may occur in the video generated by the clipping.
        /// 
        /// ### Clipping for temporary sharing
        /// The video clip (an M3U8 file) shares the same TS segments with the input video instead of being an independent video. It only has a playback URL but has no `FileId`, and its validity period is the same as that of the input video. Once the input video is deleted, the video clip cannot be played back.
        /// 
        /// Because the video clip is not an independent video, it's not displayed as a media asset in the VOD console, and cannot be transcoded or published to WeChat.
        /// 
        /// Clipping for temporary sharing is lightweight and incurs no additional storage fees. However, the video clip has the same lifecycle as the source recording video and cannot be transcoded or processed in other ways.
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public Task<SimpleHlsClipResponse> SimpleHlsClip(SimpleHlsClipRequest req)
        {
            return InternalRequestAsync<SimpleHlsClipResponse>(req, "SimpleHlsClip");
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
        /// <font color='red'>Notice:</font> If solidification is specified during clipping, enable the reception of persistence completed event notifications through the ModifyEventConfig interface. After successful solidification, an event notification of type PersistenceComplete will be received. Before receiving this event notification, operations such as deletion or cooling down of live recording videos should not be performed, otherwise, abnormal playback may occur in the video generated by the clipping.
        /// 
        /// ### Clipping for temporary sharing
        /// The video clip (an M3U8 file) shares the same TS segments with the input video instead of being an independent video. It only has a playback URL but has no `FileId`, and its validity period is the same as that of the input video. Once the input video is deleted, the video clip cannot be played back.
        /// 
        /// Because the video clip is not an independent video, it's not displayed as a media asset in the VOD console, and cannot be transcoded or published to WeChat.
        /// 
        /// Clipping for temporary sharing is lightweight and incurs no additional storage fees. However, the video clip has the same lifecycle as the source recording video and cannot be transcoded or processed in other ways.
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public SimpleHlsClipResponse SimpleHlsClipSync(SimpleHlsClipRequest req)
        {
            return InternalRequestAsync<SimpleHlsClipResponse>(req, "SimpleHlsClip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Split the video into strips to generate multiple new videos.
        /// </summary>
        /// <param name="req"><see cref="SplitMediaRequest"/></param>
        /// <returns><see cref="SplitMediaResponse"/></returns>
        public Task<SplitMediaResponse> SplitMedia(SplitMediaRequest req)
        {
            return InternalRequestAsync<SplitMediaResponse>(req, "SplitMedia");
        }

        /// <summary>
        /// Split the video into strips to generate multiple new videos.
        /// </summary>
        /// <param name="req"><see cref="SplitMediaRequest"/></param>
        /// <returns><see cref="SplitMediaResponse"/></returns>
        public SplitMediaResponse SplitMediaSync(SplitMediaRequest req)
        {
            return InternalRequestAsync<SplitMediaResponse>(req, "SplitMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for enabling/disabling the CDN acceleration domain.
        /// </summary>
        /// <param name="req"><see cref="StartCDNDomainRequest"/></param>
        /// <returns><see cref="StartCDNDomainResponse"/></returns>
        public Task<StartCDNDomainResponse> StartCDNDomain(StartCDNDomainRequest req)
        {
            return InternalRequestAsync<StartCDNDomainResponse>(req, "StartCDNDomain");
        }

        /// <summary>
        /// This API is used for enabling/disabling the CDN acceleration domain.
        /// </summary>
        /// <param name="req"><see cref="StartCDNDomainRequest"/></param>
        /// <returns><see cref="StartCDNDomainResponse"/></returns>
        public StartCDNDomainResponse StartCDNDomainSync(StartCDNDomainRequest req)
        {
            return InternalRequestAsync<StartCDNDomainResponse>(req, "StartCDNDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify the domain name resolution value.
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public Task<VerifyDomainRecordResponse> VerifyDomainRecord(VerifyDomainRecordRequest req)
        {
            return InternalRequestAsync<VerifyDomainRecordResponse>(req, "VerifyDomainRecord");
        }

        /// <summary>
        /// This API is used to verify the domain name resolution value.
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public VerifyDomainRecordResponse VerifyDomainRecordSync(VerifyDomainRecordRequest req)
        {
            return InternalRequestAsync<VerifyDomainRecordResponse>(req, "VerifyDomainRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
