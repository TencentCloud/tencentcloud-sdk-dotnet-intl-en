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

namespace TencentCloud.Vod.V20180717
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vod.V20180717.Models;

   public class VodClient : AbstractClient{

       private const string endpoint = "vod.intl.tencentcloudapi.com";
       private const string version = "2018-07-17";
       private const string sdkVersion = "SDK_NET_3.0.1396";

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
        /// We strongly recommend that you use the [server-side upload SDK](https://www.tencentcloud.comhttps://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1?from_cn_redirect=1#1.-.E5.8F.91.E8.B5.B7.E4.B8.8A.E4.BC.A0) provided by VOD to upload files. Directly invoking the API for upload is significantly more difficult and requires a larger workload than using the SDK.
        /// * This API is used to apply for upload of media files (and cover files), obtain meta information for file upload to VOD (including upload path, upload signature), for subsequent upload API.
        /// For the upload process, see [Server-Side Upload Overview](https://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public Task<ApplyUploadResponse> ApplyUpload(ApplyUploadRequest req)
        {
            return InternalRequestAsync<ApplyUploadResponse>(req, "ApplyUpload");
        }

        /// <summary>
        /// We strongly recommend that you use the [server-side upload SDK](https://www.tencentcloud.comhttps://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1?from_cn_redirect=1#1.-.E5.8F.91.E8.B5.B7.E4.B8.8A.E4.BC.A0) provided by VOD to upload files. Directly invoking the API for upload is significantly more difficult and requires a larger workload than using the SDK.
        /// * This API is used to apply for upload of media files (and cover files), obtain meta information for file upload to VOD (including upload path, upload signature), for subsequent upload API.
        /// For the upload process, see [Server-Side Upload Overview](https://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public ApplyUploadResponse ApplyUploadSync(ApplyUploadRequest req)
        {
            return InternalRequestAsync<ApplyUploadResponse>(req, "ApplyUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Associate media asset subtitles with the media output file corresponding to the adaptive bitrate streaming template ID (or disassociate them).
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public Task<AttachMediaSubtitlesResponse> AttachMediaSubtitles(AttachMediaSubtitlesRequest req)
        {
            return InternalRequestAsync<AttachMediaSubtitlesResponse>(req, "AttachMediaSubtitles");
        }

        /// <summary>
        /// Associate media asset subtitles with the media output file corresponding to the adaptive bitrate streaming template ID (or disassociate them).
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
        /// This API is used to initiate a voice cloning task. It generates an exclusive voice based on reference audio. The generated voice can be used for subsequent text to speech. Voice cloning is an asynchronous task. The voice ID and audio audition are generated after task completion.
        /// </summary>
        /// <param name="req"><see cref="CloneVoiceAsyncRequest"/></param>
        /// <returns><see cref="CloneVoiceAsyncResponse"/></returns>
        public Task<CloneVoiceAsyncResponse> CloneVoiceAsync(CloneVoiceAsyncRequest req)
        {
            return InternalRequestAsync<CloneVoiceAsyncResponse>(req, "CloneVoiceAsync");
        }

        /// <summary>
        /// This API is used to initiate a voice cloning task. It generates an exclusive voice based on reference audio. The generated voice can be used for subsequent text to speech. Voice cloning is an asynchronous task. The voice ID and audio audition are generated after task completion.
        /// </summary>
        /// <param name="req"><see cref="CloneVoiceAsyncRequest"/></param>
        /// <returns><see cref="CloneVoiceAsyncResponse"/></returns>
        public CloneVoiceAsyncResponse CloneVoiceAsyncSync(CloneVoiceAsyncRequest req)
        {
            return InternalRequestAsync<CloneVoiceAsyncResponse>(req, "CloneVoiceAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate a voice cloning task to clone an exclusive voice based on reference audio. The generated voice can be used for subsequent text to speech.
        /// </summary>
        /// <param name="req"><see cref="CloneVoiceSyncRequest"/></param>
        /// <returns><see cref="CloneVoiceSyncResponse"/></returns>
        public Task<CloneVoiceSyncResponse> CloneVoiceSync(CloneVoiceSyncRequest req)
        {
            return InternalRequestAsync<CloneVoiceSyncResponse>(req, "CloneVoiceSync");
        }

        /// <summary>
        /// This API is used to initiate a voice cloning task to clone an exclusive voice based on reference audio. The generated voice can be used for subsequent text to speech.
        /// </summary>
        /// <param name="req"><see cref="CloneVoiceSyncRequest"/></param>
        /// <returns><see cref="CloneVoiceSyncResponse"/></returns>
        public CloneVoiceSyncResponse CloneVoiceSyncSync(CloneVoiceSyncRequest req)
        {
            return InternalRequestAsync<CloneVoiceSyncResponse>(req, "CloneVoiceSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to confirm the result of uploading media files and cover files to Tencent Cloud VOD, store media information, and return the playback addresses and file IDs.
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public Task<CommitUploadResponse> CommitUpload(CommitUploadRequest req)
        {
            return InternalRequestAsync<CommitUploadResponse>(req, "CommitUpload");
        }

        /// <summary>
        /// This API is used to confirm the result of uploading media files and cover files to Tencent Cloud VOD, store media information, and return the playback addresses and file IDs.
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public CommitUploadResponse CommitUploadSync(CommitUploadRequest req)
        {
            return InternalRequestAsync<CommitUploadResponse>(req, "CommitUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to compose media files to achieve the following effects:
        /// 
        /// 1. **Image rotation**: Rotate the image of a video or picture by a certain degree, or flip it in a certain direction.
        /// 2. **Audio control**: Increase or reduce the volume of video and audio, or mute the video.
        /// 3. **Screen overlay**: Overlay frames from videos and images in sequence, for example, to achieve a Picture-in-Picture effect.
        /// 4. **Audio mixing**: Mix the sound in video and audio together.
        /// 5. **Audio extraction**: Extract the audio from the video (the visual is not retained).
        /// 6. **Crop**: Crop a specified time period from a video or audio.
        /// 7. **Splicing**: Splice videos, audio, and images in chronological order.
        /// 8. **Transitions**: When stitching multiple videos or images, you can add transition effects between paragraphs.
        /// 
        /// The muxing format of the synthesized media can be MP4 (video) or MP3 (audio). If event notification is used, its type is [Video synthesis completed](https://www.tencentcloud.com/document/product/266/43000?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public Task<ComposeMediaResponse> ComposeMedia(ComposeMediaRequest req)
        {
            return InternalRequestAsync<ComposeMediaResponse>(req, "ComposeMedia");
        }

        /// <summary>
        /// This API is used to compose media files to achieve the following effects:
        /// 
        /// 1. **Image rotation**: Rotate the image of a video or picture by a certain degree, or flip it in a certain direction.
        /// 2. **Audio control**: Increase or reduce the volume of video and audio, or mute the video.
        /// 3. **Screen overlay**: Overlay frames from videos and images in sequence, for example, to achieve a Picture-in-Picture effect.
        /// 4. **Audio mixing**: Mix the sound in video and audio together.
        /// 5. **Audio extraction**: Extract the audio from the video (the visual is not retained).
        /// 6. **Crop**: Crop a specified time period from a video or audio.
        /// 7. **Splicing**: Splice videos, audio, and images in chronological order.
        /// 8. **Transitions**: When stitching multiple videos or images, you can add transition effects between paragraphs.
        /// 
        /// The muxing format of the synthesized media can be MP4 (video) or MP3 (audio). If event notification is used, its type is [Video synthesis completed](https://www.tencentcloud.com/document/product/266/43000?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public ComposeMediaResponse ComposeMediaSync(ComposeMediaRequest req)
        {
            return InternalRequestAsync<ComposeMediaResponse>(req, "ComposeMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * Developers call the event notification pull API. After obtaining an event, they must call this API to acknowledge that the message has been received.
        /// * After the developer obtains the event handler, the validity time for pending confirmation is 30 seconds. If it exceeds 30 seconds, a parameter error (4000) is reported.
        /// * For more references on reliable callback for event notification, see [Reliable Callback](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83).
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public Task<ConfirmEventsResponse> ConfirmEvents(ConfirmEventsRequest req)
        {
            return InternalRequestAsync<ConfirmEventsResponse>(req, "ConfirmEvents");
        }

        /// <summary>
        /// * Developers call the event notification pull API. After obtaining an event, they must call this API to acknowledge that the message has been received.
        /// * After the developer obtains the event handler, the validity time for pending confirmation is 30 seconds. If it exceeds 30 seconds, a parameter error (4000) is reported.
        /// * For more references on reliable callback for event notification, see [Reliable Callback](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83).
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public ConfirmEventsResponse ConfirmEventsSync(ConfirmEventsRequest req)
        {
            return InternalRequestAsync<ConfirmEventsResponse>(req, "ConfirmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user-defined audio and video content analysis template. Maximum quantity: 50. HLS format is not supported currently.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate");
        }

        /// <summary>
        /// This API is used to create a user-defined audio and video content analysis template. Maximum quantity: 50. HLS format is not supported currently.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user-defined audio and video content recognition template. Maximum quantity: 50.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to create a user-defined audio and video content recognition template. Maximum quantity: 50.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public CreateAIRecognitionTemplateResponse CreateAIRecognitionTemplateSync(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create adaptive bitrate streaming templates. Maximum quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<CreateAdaptiveDynamicStreamingTemplateResponse> CreateAdaptiveDynamicStreamingTemplate(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<CreateAdaptiveDynamicStreamingTemplateResponse>(req, "CreateAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// Create adaptive bitrate streaming templates. Maximum quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public CreateAdaptiveDynamicStreamingTemplateResponse CreateAdaptiveDynamicStreamingTemplateSync(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<CreateAdaptiveDynamicStreamingTemplateResponse>(req, "CreateAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create advanced custom AIGC subjects.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcAdvancedCustomElementRequest"/></param>
        /// <returns><see cref="CreateAigcAdvancedCustomElementResponse"/></returns>
        public Task<CreateAigcAdvancedCustomElementResponse> CreateAigcAdvancedCustomElement(CreateAigcAdvancedCustomElementRequest req)
        {
            return InternalRequestAsync<CreateAigcAdvancedCustomElementResponse>(req, "CreateAigcAdvancedCustomElement");
        }

        /// <summary>
        /// This API is used to create advanced custom AIGC subjects.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcAdvancedCustomElementRequest"/></param>
        /// <returns><see cref="CreateAigcAdvancedCustomElementResponse"/></returns>
        public CreateAigcAdvancedCustomElementResponse CreateAigcAdvancedCustomElementSync(CreateAigcAdvancedCustomElementRequest req)
        {
            return InternalRequestAsync<CreateAigcAdvancedCustomElementResponse>(req, "CreateAigcAdvancedCustomElement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Token for AIGC API calls. Data sync may delay after creation. It can be queried or deleted after about 30 seconds.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcApiTokenRequest"/></param>
        /// <returns><see cref="CreateAigcApiTokenResponse"/></returns>
        public Task<CreateAigcApiTokenResponse> CreateAigcApiToken(CreateAigcApiTokenRequest req)
        {
            return InternalRequestAsync<CreateAigcApiTokenResponse>(req, "CreateAigcApiToken");
        }

        /// <summary>
        /// This API is used to create a Token for AIGC API calls. Data sync may delay after creation. It can be queried or deleted after about 30 seconds.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcApiTokenRequest"/></param>
        /// <returns><see cref="CreateAigcApiTokenResponse"/></returns>
        public CreateAigcApiTokenResponse CreateAigcApiTokenSync(CreateAigcApiTokenRequest req)
        {
            return InternalRequestAsync<CreateAigcApiTokenResponse>(req, "CreateAigcApiToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create AIGC voice replication. Note that calling this API incurs fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="CreateAigcAudioCloneRequest"/></param>
        /// <returns><see cref="CreateAigcAudioCloneResponse"/></returns>
        public Task<CreateAigcAudioCloneResponse> CreateAigcAudioClone(CreateAigcAudioCloneRequest req)
        {
            return InternalRequestAsync<CreateAigcAudioCloneResponse>(req, "CreateAigcAudioClone");
        }

        /// <summary>
        /// This API is used to create AIGC voice replication. Note that calling this API incurs fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="CreateAigcAudioCloneRequest"/></param>
        /// <returns><see cref="CreateAigcAudioCloneResponse"/></returns>
        public CreateAigcAudioCloneResponse CreateAigcAudioCloneSync(CreateAigcAudioCloneRequest req)
        {
            return InternalRequestAsync<CreateAigcAudioCloneResponse>(req, "CreateAigcAudioClone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create AI audio generation tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcAudioTaskRequest"/></param>
        /// <returns><see cref="CreateAigcAudioTaskResponse"/></returns>
        public Task<CreateAigcAudioTaskResponse> CreateAigcAudioTask(CreateAigcAudioTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcAudioTaskResponse>(req, "CreateAigcAudioTask");
        }

        /// <summary>
        /// This API is used to create AI audio generation tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcAudioTaskRequest"/></param>
        /// <returns><see cref="CreateAigcAudioTaskResponse"/></returns>
        public CreateAigcAudioTaskResponse CreateAigcAudioTaskSync(CreateAigcAudioTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcAudioTaskResponse>(req, "CreateAigcAudioTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Call this API to create a subject for a specified model.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcCustomElementRequest"/></param>
        /// <returns><see cref="CreateAigcCustomElementResponse"/></returns>
        public Task<CreateAigcCustomElementResponse> CreateAigcCustomElement(CreateAigcCustomElementRequest req)
        {
            return InternalRequestAsync<CreateAigcCustomElementResponse>(req, "CreateAigcCustomElement");
        }

        /// <summary>
        /// Call this API to create a subject for a specified model.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcCustomElementRequest"/></param>
        /// <returns><see cref="CreateAigcCustomElementResponse"/></returns>
        public CreateAigcCustomElementResponse CreateAigcCustomElementSync(CreateAigcCustomElementRequest req)
        {
            return InternalRequestAsync<CreateAigcCustomElementResponse>(req, "CreateAigcCustomElement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create AIGC custom voice types. Note that calling this API incurs custom voice type creation fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#5e5217e8-29fc-467e-ac2d-853648f988b7).
        /// </summary>
        /// <param name="req"><see cref="CreateAigcCustomVoiceRequest"/></param>
        /// <returns><see cref="CreateAigcCustomVoiceResponse"/></returns>
        public Task<CreateAigcCustomVoiceResponse> CreateAigcCustomVoice(CreateAigcCustomVoiceRequest req)
        {
            return InternalRequestAsync<CreateAigcCustomVoiceResponse>(req, "CreateAigcCustomVoice");
        }

        /// <summary>
        /// This API is used to create AIGC custom voice types. Note that calling this API incurs custom voice type creation fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#5e5217e8-29fc-467e-ac2d-853648f988b7).
        /// </summary>
        /// <param name="req"><see cref="CreateAigcCustomVoiceRequest"/></param>
        /// <returns><see cref="CreateAigcCustomVoiceResponse"/></returns>
        public CreateAigcCustomVoiceResponse CreateAigcCustomVoiceSync(CreateAigcCustomVoiceRequest req)
        {
            return InternalRequestAsync<CreateAigcCustomVoiceResponse>(req, "CreateAigcCustomVoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate AIGC Hunyuan 3D Files.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcHunyuan3DTaskRequest"/></param>
        /// <returns><see cref="CreateAigcHunyuan3DTaskResponse"/></returns>
        public Task<CreateAigcHunyuan3DTaskResponse> CreateAigcHunyuan3DTask(CreateAigcHunyuan3DTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcHunyuan3DTaskResponse>(req, "CreateAigcHunyuan3DTask");
        }

        /// <summary>
        /// This API is used to generate AIGC Hunyuan 3D Files.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcHunyuan3DTaskRequest"/></param>
        /// <returns><see cref="CreateAigcHunyuan3DTaskResponse"/></returns>
        public CreateAigcHunyuan3DTaskResponse CreateAigcHunyuan3DTaskSync(CreateAigcHunyuan3DTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcHunyuan3DTaskResponse>(req, "CreateAigcHunyuan3DTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate AIGC images. The default limit is 1 concurrent processing. API calls incur actual fees. Refer to the VOD AIGC image generation billing documentation. The settlement mode for this feature is pay-as-you-go. For daily billing customers, usage on the day is billed on the second day. For monthly billing customers, the previous month's usage fees are billed on the 1st of the next month.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcImageTaskRequest"/></param>
        /// <returns><see cref="CreateAigcImageTaskResponse"/></returns>
        public Task<CreateAigcImageTaskResponse> CreateAigcImageTask(CreateAigcImageTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcImageTaskResponse>(req, "CreateAigcImageTask");
        }

        /// <summary>
        /// This API is used to generate AIGC images. The default limit is 1 concurrent processing. API calls incur actual fees. Refer to the VOD AIGC image generation billing documentation. The settlement mode for this feature is pay-as-you-go. For daily billing customers, usage on the day is billed on the second day. For monthly billing customers, the previous month's usage fees are billed on the 1st of the next month.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcImageTaskRequest"/></param>
        /// <returns><see cref="CreateAigcImageTaskResponse"/></returns>
        public CreateAigcImageTaskResponse CreateAigcImageTaskSync(CreateAigcImageTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcImageTaskResponse>(req, "CreateAigcImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create and enable AIGC quota configuration. Quota usage starts accumulating when the quota feature is enabled. Once the quota is reached, AIGC features will no longer be usable.
        /// 
        /// If the quota is deleted and re-enabled, the amount will be cleared and recalculated.
        /// 
        /// Since AGC content generation is an async task, real-time usage data cannot be obtained. Therefore, quota limits result in some errors, and full precise control over the set limit cannot be achieved.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcQuotaRequest"/></param>
        /// <returns><see cref="CreateAigcQuotaResponse"/></returns>
        public Task<CreateAigcQuotaResponse> CreateAigcQuota(CreateAigcQuotaRequest req)
        {
            return InternalRequestAsync<CreateAigcQuotaResponse>(req, "CreateAigcQuota");
        }

        /// <summary>
        /// This API is used to create and enable AIGC quota configuration. Quota usage starts accumulating when the quota feature is enabled. Once the quota is reached, AIGC features will no longer be usable.
        /// 
        /// If the quota is deleted and re-enabled, the amount will be cleared and recalculated.
        /// 
        /// Since AGC content generation is an async task, real-time usage data cannot be obtained. Therefore, quota limits result in some errors, and full precise control over the set limit cannot be achieved.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcQuotaRequest"/></param>
        /// <returns><see cref="CreateAigcQuotaResponse"/></returns>
        public CreateAigcQuotaResponse CreateAigcQuotaSync(CreateAigcQuotaRequest req)
        {
            return InternalRequestAsync<CreateAigcQuotaResponse>(req, "CreateAigcQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create AIGC custom subjects (Vidu). Note that calling this API incurs fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="CreateAigcSubjectRequest"/></param>
        /// <returns><see cref="CreateAigcSubjectResponse"/></returns>
        public Task<CreateAigcSubjectResponse> CreateAigcSubject(CreateAigcSubjectRequest req)
        {
            return InternalRequestAsync<CreateAigcSubjectResponse>(req, "CreateAigcSubject");
        }

        /// <summary>
        /// This API is used to create AIGC custom subjects (Vidu). Note that calling this API incurs fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="CreateAigcSubjectRequest"/></param>
        /// <returns><see cref="CreateAigcSubjectResponse"/></returns>
        public CreateAigcSubjectResponse CreateAigcSubjectSync(CreateAigcSubjectRequest req)
        {
            return InternalRequestAsync<CreateAigcSubjectResponse>(req, "CreateAigcSubject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate AIGC videos. API calls incur actual fees. Refer to the VOD AIGC video generation billing documentation. The settlement mode for this feature is pay-as-you-go. For daily billing customers, usage on the day is billed on the second day. For monthly billing customers, usage fees for the previous month are billed on the 1st of the next month.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcVideoRedrawTaskRequest"/></param>
        /// <returns><see cref="CreateAigcVideoRedrawTaskResponse"/></returns>
        public Task<CreateAigcVideoRedrawTaskResponse> CreateAigcVideoRedrawTask(CreateAigcVideoRedrawTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcVideoRedrawTaskResponse>(req, "CreateAigcVideoRedrawTask");
        }

        /// <summary>
        /// This API is used to generate AIGC videos. API calls incur actual fees. Refer to the VOD AIGC video generation billing documentation. The settlement mode for this feature is pay-as-you-go. For daily billing customers, usage on the day is billed on the second day. For monthly billing customers, usage fees for the previous month are billed on the 1st of the next month.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcVideoRedrawTaskRequest"/></param>
        /// <returns><see cref="CreateAigcVideoRedrawTaskResponse"/></returns>
        public CreateAigcVideoRedrawTaskResponse CreateAigcVideoRedrawTaskSync(CreateAigcVideoRedrawTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcVideoRedrawTaskResponse>(req, "CreateAigcVideoRedrawTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate AIGC videos. The default limit is 1 concurrent processing. API calls incur actual fees. Refer to the VOD AIGC video generation billing documentation. The feature uses postpaid settlement mode. Daily billing customers are billed on the second day after usage. Monthly settlement customers are billed on the 1st of the next month for the previous month's usage fees.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcVideoTaskRequest"/></param>
        /// <returns><see cref="CreateAigcVideoTaskResponse"/></returns>
        public Task<CreateAigcVideoTaskResponse> CreateAigcVideoTask(CreateAigcVideoTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcVideoTaskResponse>(req, "CreateAigcVideoTask");
        }

        /// <summary>
        /// This API is used to generate AIGC videos. The default limit is 1 concurrent processing. API calls incur actual fees. Refer to the VOD AIGC video generation billing documentation. The feature uses postpaid settlement mode. Daily billing customers are billed on the second day after usage. Monthly settlement customers are billed on the 1st of the next month for the previous month's usage fees.
        /// </summary>
        /// <param name="req"><see cref="CreateAigcVideoTaskRequest"/></param>
        /// <returns><see cref="CreateAigcVideoTaskResponse"/></returns>
        public CreateAigcVideoTaskResponse CreateAigcVideoTaskSync(CreateAigcVideoTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcVideoTaskResponse>(req, "CreateAigcVideoTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create custom animated image generating templates. Maximum quantity: 16.
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public Task<CreateAnimatedGraphicsTemplateResponse> CreateAnimatedGraphicsTemplate(CreateAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<CreateAnimatedGraphicsTemplateResponse>(req, "CreateAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// This API is used to create custom animated image generating templates. Maximum quantity: 16.
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public CreateAnimatedGraphicsTemplateResponse CreateAnimatedGraphicsTemplateSync(CreateAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<CreateAnimatedGraphicsTemplateResponse>(req, "CreateAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user-defined digital watermark template.
        /// </summary>
        /// <param name="req"><see cref="CreateBlindWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateBlindWatermarkTemplateResponse"/></returns>
        public Task<CreateBlindWatermarkTemplateResponse> CreateBlindWatermarkTemplate(CreateBlindWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateBlindWatermarkTemplateResponse>(req, "CreateBlindWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to create a user-defined digital watermark template.
        /// </summary>
        /// <param name="req"><see cref="CreateBlindWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateBlindWatermarkTemplateResponse"/></returns>
        public CreateBlindWatermarkTemplateResponse CreateBlindWatermarkTemplateSync(CreateBlindWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateBlindWatermarkTemplateResponse>(req, "CreateBlindWatermarkTemplate")
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
        /// Create a logset via VOD.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogsetRequest"/></param>
        /// <returns><see cref="CreateCLSLogsetResponse"/></returns>
        public Task<CreateCLSLogsetResponse> CreateCLSLogset(CreateCLSLogsetRequest req)
        {
            return InternalRequestAsync<CreateCLSLogsetResponse>(req, "CreateCLSLogset");
        }

        /// <summary>
        /// Create a logset via VOD.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogsetRequest"/></param>
        /// <returns><see cref="CreateCLSLogsetResponse"/></returns>
        public CreateCLSLogsetResponse CreateCLSLogsetSync(CreateCLSLogsetRequest req)
        {
            return InternalRequestAsync<CreateCLSLogsetResponse>(req, "CreateCLSLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CLS log topic for VOD.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSTopicRequest"/></param>
        /// <returns><see cref="CreateCLSTopicResponse"/></returns>
        public Task<CreateCLSTopicResponse> CreateCLSTopic(CreateCLSTopicRequest req)
        {
            return InternalRequestAsync<CreateCLSTopicResponse>(req, "CreateCLSTopic");
        }

        /// <summary>
        /// This API is used to create a CLS log topic for VOD.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSTopicRequest"/></param>
        /// <returns><see cref="CreateCLSTopicResponse"/></returns>
        public CreateCLSTopicResponse CreateCLSTopicSync(CreateCLSTopicRequest req)
        {
            return InternalRequestAsync<CreateCLSTopicResponse>(req, "CreateCLSTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * Used to categorize and manage media;
        /// * This API does not affect the existing media categories. To modify media categories, call the [ModifyMediaInfo](https://www.tencentcloud.com/document/product/266/31762?from_cn_redirect=1) API.
        /// * The classification hierarchy cannot exceed 4 levels.
        /// The number of subcategories in each category cannot exceed 500.
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass");
        }

        /// <summary>
        /// * Used to categorize and manage media;
        /// * This API does not affect the existing media categories. To modify media categories, call the [ModifyMediaInfo](https://www.tencentcloud.com/document/product/266/31762?from_cn_redirect=1) API.
        /// * The classification hierarchy cannot exceed 4 levels.
        /// The number of subcategories in each category cannot exceed 500.
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public CreateClassResponse CreateClassSync(CreateClassRequest req)
        {
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiates a complex adaptive bitstream processing task. Features include:
        /// 1. Output HLS and DASH adaptive bitrate streams based on the designated adaptive bitrate template;
        /// 2. Content protection solutions for adaptive bitrate streams can be unencrypted, Widevine, or FairPlay.
        /// 3. Support adding opening and ending segments;
        /// 4. The output adaptive bitrate stream can contain multilingual audio streams, each language comes from a different media file;
        /// 5. The output adaptive bitrate stream can include multilingual subtitle streams.
        /// 
        /// Notes:
        /// 1. When using an opening scene, the video stream in the opening scene media needs to align with the audio stream; otherwise, the output content will have audio and video synchronization issues.
        /// 2. If the output adaptive bitrate stream needs to include the audio of the main media, the FileId of the main media needs to be specified in the AudioSet parameter.
        /// 3. To use subtitles, add them to the main media first via the ModifyMediaInfo API or the audio and video details page in the console;
        /// 4. Top speed Codec and watermark are not currently supported.
        /// </summary>
        /// <param name="req"><see cref="CreateComplexAdaptiveDynamicStreamingTaskRequest"/></param>
        /// <returns><see cref="CreateComplexAdaptiveDynamicStreamingTaskResponse"/></returns>
        public Task<CreateComplexAdaptiveDynamicStreamingTaskResponse> CreateComplexAdaptiveDynamicStreamingTask(CreateComplexAdaptiveDynamicStreamingTaskRequest req)
        {
            return InternalRequestAsync<CreateComplexAdaptiveDynamicStreamingTaskResponse>(req, "CreateComplexAdaptiveDynamicStreamingTask");
        }

        /// <summary>
        /// Initiates a complex adaptive bitstream processing task. Features include:
        /// 1. Output HLS and DASH adaptive bitrate streams based on the designated adaptive bitrate template;
        /// 2. Content protection solutions for adaptive bitrate streams can be unencrypted, Widevine, or FairPlay.
        /// 3. Support adding opening and ending segments;
        /// 4. The output adaptive bitrate stream can contain multilingual audio streams, each language comes from a different media file;
        /// 5. The output adaptive bitrate stream can include multilingual subtitle streams.
        /// 
        /// Notes:
        /// 1. When using an opening scene, the video stream in the opening scene media needs to align with the audio stream; otherwise, the output content will have audio and video synchronization issues.
        /// 2. If the output adaptive bitrate stream needs to include the audio of the main media, the FileId of the main media needs to be specified in the AudioSet parameter.
        /// 3. To use subtitles, add them to the main media first via the ModifyMediaInfo API or the audio and video details page in the console;
        /// 4. Top speed Codec and watermark are not currently supported.
        /// </summary>
        /// <param name="req"><see cref="CreateComplexAdaptiveDynamicStreamingTaskRequest"/></param>
        /// <returns><see cref="CreateComplexAdaptiveDynamicStreamingTaskResponse"/></returns>
        public CreateComplexAdaptiveDynamicStreamingTaskResponse CreateComplexAdaptiveDynamicStreamingTaskSync(CreateComplexAdaptiveDynamicStreamingTaskRequest req)
        {
            return InternalRequestAsync<CreateComplexAdaptiveDynamicStreamingTaskResponse>(req, "CreateComplexAdaptiveDynamicStreamingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the moderation template supports video moderation and image moderation. For details, please see [Create Moderation Template](https://www.tencentcloud.com/document/api/266/84391?from_cn_redirect=1).
        /// This API is used to create a user-customized audio/video moderation template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the moderation template supports video moderation and image moderation. For details, please see [Create Moderation Template](https://www.tencentcloud.com/document/api/266/84391?from_cn_redirect=1).
        /// This API is used to create a user-customized audio/video moderation template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a subdomain name resolution and prompt customers to add it to the domain name resolution for wildcard domain name and domain name retrieval ownership verification.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateDomainVerifyRecordResponse"/></returns>
        public Task<CreateDomainVerifyRecordResponse> CreateDomainVerifyRecord(CreateDomainVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateDomainVerifyRecordResponse>(req, "CreateDomainVerifyRecord");
        }

        /// <summary>
        /// This API is used to generate a subdomain name resolution and prompt customers to add it to the domain name resolution for wildcard domain name and domain name retrieval ownership verification.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateDomainVerifyRecordResponse"/></returns>
        public CreateDomainVerifyRecordResponse CreateDomainVerifyRecordSync(CreateDomainVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateDomainVerifyRecordResponse>(req, "CreateDomainVerifyRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to create an audio and video quality rebirth template.
        /// </summary>
        /// <param name="req"><see cref="CreateEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateEnhanceMediaTemplateResponse"/></returns>
        public Task<CreateEnhanceMediaTemplateResponse> CreateEnhanceMediaTemplate(CreateEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateEnhanceMediaTemplateResponse>(req, "CreateEnhanceMediaTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to create an audio and video quality rebirth template.
        /// </summary>
        /// <param name="req"><see cref="CreateEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateEnhanceMediaTemplateResponse"/></returns>
        public CreateEnhanceMediaTemplateResponse CreateEnhanceMediaTemplateSync(CreateEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateEnhanceMediaTemplateResponse>(req, "CreateEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a title and trailer template.
        /// -Maximum supported template quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateHeadTailTemplateRequest"/></param>
        /// <returns><see cref="CreateHeadTailTemplateResponse"/></returns>
        public Task<CreateHeadTailTemplateResponse> CreateHeadTailTemplate(CreateHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<CreateHeadTailTemplateResponse>(req, "CreateHeadTailTemplate");
        }

        /// <summary>
        /// This API is used to create a title and trailer template.
        /// -Maximum supported template quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateHeadTailTemplateRequest"/></param>
        /// <returns><see cref="CreateHeadTailTemplateResponse"/></returns>
        public CreateHeadTailTemplateResponse CreateHeadTailTemplateSync(CreateHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<CreateHeadTailTemplateResponse>(req, "CreateHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a custom image processing template. Maximum quantity: 16. Supports up to ten operations, for example: crop-thumbnail-crop-blur-thumbnail-crop-thumbnail-crop-blur-thumbnail.
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public Task<CreateImageProcessingTemplateResponse> CreateImageProcessingTemplate(CreateImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageProcessingTemplateResponse>(req, "CreateImageProcessingTemplate");
        }

        /// <summary>
        /// Create a custom image processing template. Maximum quantity: 16. Supports up to ten operations, for example: crop-thumbnail-crop-blur-thumbnail-crop-thumbnail-crop-blur-thumbnail.
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public CreateImageProcessingTemplateResponse CreateImageProcessingTemplateSync(CreateImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageProcessingTemplateResponse>(req, "CreateImageProcessingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user-customized image sprite template. Maximum number: 16.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public Task<CreateImageSpriteTemplateResponse> CreateImageSpriteTemplate(CreateImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageSpriteTemplateResponse>(req, "CreateImageSpriteTemplate");
        }

        /// <summary>
        /// This API is used to create a user-customized image sprite template. Maximum number: 16.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public CreateImageSpriteTemplateResponse CreateImageSpriteTemplateSync(CreateImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageSpriteTemplateResponse>(req, "CreateImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a just in time transcoding template.
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<CreateJustInTimeTranscodeTemplateResponse> CreateJustInTimeTranscodeTemplate(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to create a just in time transcoding template.
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public CreateJustInTimeTranscodeTemplateResponse CreateJustInTimeTranscodeTemplateSync(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a knowledge base. This API is used to create a new knowledge base for Intelligent Media Assets. Each user can create up to 20 knowledge bases.
        /// </summary>
        /// <param name="req"><see cref="CreateKnowledgeBaseRequest"/></param>
        /// <returns><see cref="CreateKnowledgeBaseResponse"/></returns>
        public Task<CreateKnowledgeBaseResponse> CreateKnowledgeBase(CreateKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<CreateKnowledgeBaseResponse>(req, "CreateKnowledgeBase");
        }

        /// <summary>
        /// Create a knowledge base. This API is used to create a new knowledge base for Intelligent Media Assets. Each user can create up to 20 knowledge bases.
        /// </summary>
        /// <param name="req"><see cref="CreateKnowledgeBaseRequest"/></param>
        /// <returns><see cref="CreateKnowledgeBaseResponse"/></returns>
        public CreateKnowledgeBaseResponse CreateKnowledgeBaseSync(CreateKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<CreateKnowledgeBaseResponse>(req, "CreateKnowledgeBase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a large model parsing template.
        /// </summary>
        /// <param name="req"><see cref="CreateLLMComprehendTemplateRequest"/></param>
        /// <returns><see cref="CreateLLMComprehendTemplateResponse"/></returns>
        public Task<CreateLLMComprehendTemplateResponse> CreateLLMComprehendTemplate(CreateLLMComprehendTemplateRequest req)
        {
            return InternalRequestAsync<CreateLLMComprehendTemplateResponse>(req, "CreateLLMComprehendTemplate");
        }

        /// <summary>
        /// This API is used to create a large model parsing template.
        /// </summary>
        /// <param name="req"><see cref="CreateLLMComprehendTemplateRequest"/></param>
        /// <returns><see cref="CreateLLMComprehendTemplateResponse"/></returns>
        public CreateLLMComprehendTemplateResponse CreateLLMComprehendTemplateSync(CreateLLMComprehendTemplateRequest req)
        {
            return InternalRequestAsync<CreateLLMComprehendTemplateResponse>(req, "CreateLLMComprehendTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom template for partial features of the ProcessMediaByMPS API.
        /// When creating a template, fill in the MPS related parameters in JSON format in the MPSCreateTemplateParams parameter. For specific task parameter configuration methods, refer to the MPS task template documentation.
        /// Currently supported MPS features for creating custom templates:
        /// 1. [Audio and video enhancement](https://www.tencentcloud.com/document/product/862/118703?from_cn_redirect=1).
        /// 2. [Media AI](https://www.tencentcloud.com/document/product/862/113756?from_cn_redirect=1)
        /// 
        /// > Template for tasks created this way:
        /// > 1. Template management is still done in the VOD platform.
        /// > 2. The feature is currently in beta test. If needed, you can contact us for support to get testing experience.
        /// </summary>
        /// <param name="req"><see cref="CreateMPSTemplateRequest"/></param>
        /// <returns><see cref="CreateMPSTemplateResponse"/></returns>
        public Task<CreateMPSTemplateResponse> CreateMPSTemplate(CreateMPSTemplateRequest req)
        {
            return InternalRequestAsync<CreateMPSTemplateResponse>(req, "CreateMPSTemplate");
        }

        /// <summary>
        /// This API is used to create a custom template for partial features of the ProcessMediaByMPS API.
        /// When creating a template, fill in the MPS related parameters in JSON format in the MPSCreateTemplateParams parameter. For specific task parameter configuration methods, refer to the MPS task template documentation.
        /// Currently supported MPS features for creating custom templates:
        /// 1. [Audio and video enhancement](https://www.tencentcloud.com/document/product/862/118703?from_cn_redirect=1).
        /// 2. [Media AI](https://www.tencentcloud.com/document/product/862/113756?from_cn_redirect=1)
        /// 
        /// > Template for tasks created this way:
        /// > 1. Template management is still done in the VOD platform.
        /// > 2. The feature is currently in beta test. If needed, you can contact us for support to get testing experience.
        /// </summary>
        /// <param name="req"><see cref="CreateMPSTemplateRequest"/></param>
        /// <returns><see cref="CreateMPSTemplateResponse"/></returns>
        public CreateMPSTemplateResponse CreateMPSTemplateSync(CreateMPSTemplateRequest req)
        {
            return InternalRequestAsync<CreateMPSTemplateResponse>(req, "CreateMPSTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create material samples for video processing such as content recognition and inappropriate video recognition through technologies like facial feature positioning.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample");
        }

        /// <summary>
        /// This API is used to create material samples for video processing such as content recognition and inappropriate video recognition through technologies like facial feature positioning.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create user-defined task flow templates. Template capacity limit: 50.
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public Task<CreateProcedureTemplateResponse> CreateProcedureTemplate(CreateProcedureTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcedureTemplateResponse>(req, "CreateProcedureTemplate");
        }

        /// <summary>
        /// This API is used to create user-defined task flow templates. Template capacity limit: 50.
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public CreateProcedureTemplateResponse CreateProcedureTemplateSync(CreateProcedureTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcedureTemplateResponse>(req, "CreateProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a user-customized async image processing template. Maximum number: 50. HLS format is not supported currently.
        /// </summary>
        /// <param name="req"><see cref="CreateProcessImageAsyncTemplateRequest"/></param>
        /// <returns><see cref="CreateProcessImageAsyncTemplateResponse"/></returns>
        public Task<CreateProcessImageAsyncTemplateResponse> CreateProcessImageAsyncTemplate(CreateProcessImageAsyncTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcessImageAsyncTemplateResponse>(req, "CreateProcessImageAsyncTemplate");
        }

        /// <summary>
        /// Create a user-customized async image processing template. Maximum number: 50. HLS format is not supported currently.
        /// </summary>
        /// <param name="req"><see cref="CreateProcessImageAsyncTemplateRequest"/></param>
        /// <returns><see cref="CreateProcessImageAsyncTemplateResponse"/></returns>
        public CreateProcessImageAsyncTemplateResponse CreateProcessImageAsyncTemplateSync(CreateProcessImageAsyncTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcessImageAsyncTemplateResponse>(req, "CreateProcessImageAsyncTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates an audio-visual quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="CreateQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityInspectTemplateResponse"/></returns>
        public Task<CreateQualityInspectTemplateResponse> CreateQualityInspectTemplate(CreateQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityInspectTemplateResponse>(req, "CreateQualityInspectTemplate");
        }

        /// <summary>
        /// Creates an audio-visual quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="CreateQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityInspectTemplateResponse"/></returns>
        public CreateQualityInspectTemplateResponse CreateQualityInspectTemplateSync(CreateQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityInspectTemplateResponse>(req, "CreateQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to create a video rebirth template.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public Task<CreateRebuildMediaTemplateResponse> CreateRebuildMediaTemplate(CreateRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateRebuildMediaTemplateResponse>(req, "CreateRebuildMediaTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to create a video rebirth template.
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public CreateRebuildMediaTemplateResponse CreateRebuildMediaTemplateSync(CreateRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateRebuildMediaTemplateResponse>(req, "CreateRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user-customized moderation template. Up to 50 templates can be created.
        /// >Template is applicable only to the ReviewAudioVideo (https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and ReviewImage (https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public Task<CreateReviewTemplateResponse> CreateReviewTemplate(CreateReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateReviewTemplateResponse>(req, "CreateReviewTemplate");
        }

        /// <summary>
        /// This API is used to create a user-customized moderation template. Up to 50 templates can be created.
        /// >Template is applicable only to the ReviewAudioVideo (https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and ReviewImage (https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public CreateReviewTemplateResponse CreateReviewTemplateSync(CreateReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateReviewTemplateResponse>(req, "CreateReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a carousel playlist. Maximum quantity: 100.
        /// Each file in a carousel playlist can specify a source file or a transcoded file.
        /// The specified file must be in hls format. All playlist files should have the same bitrate and resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateRoundPlayRequest"/></param>
        /// <returns><see cref="CreateRoundPlayResponse"/></returns>
        public Task<CreateRoundPlayResponse> CreateRoundPlay(CreateRoundPlayRequest req)
        {
            return InternalRequestAsync<CreateRoundPlayResponse>(req, "CreateRoundPlay");
        }

        /// <summary>
        /// This API is used to create a carousel playlist. Maximum quantity: 100.
        /// Each file in a carousel playlist can specify a source file or a transcoded file.
        /// The specified file must be in hls format. All playlist files should have the same bitrate and resolution.
        /// </summary>
        /// <param name="req"><see cref="CreateRoundPlayRequest"/></param>
        /// <returns><see cref="CreateRoundPlayResponse"/></returns>
        public CreateRoundPlayResponse CreateRoundPlaySync(CreateRoundPlayRequest req)
        {
            return InternalRequestAsync<CreateRoundPlayResponse>(req, "CreateRoundPlay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create custom sampled screenshot templates. Maximum quantity: 16.
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public Task<CreateSampleSnapshotTemplateResponse> CreateSampleSnapshotTemplate(CreateSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateSampleSnapshotTemplateResponse>(req, "CreateSampleSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to create custom sampled screenshot templates. Maximum quantity: 16.
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public CreateSampleSnapshotTemplateResponse CreateSampleSnapshotTemplateSync(CreateSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateSampleSnapshotTemplateResponse>(req, "CreateSampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate scenario-based AIGC images. API calls incur actual fees. Refer to the VOD AIGC image generation billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#9c4dc6ff-4b3f-4b25-bf2d-393889dfb9ac). The feature uses pay-as-you-go settlement mode (https://www.tencentcloud.com/document/product/266/2838?from_cn_redirect=1). For daily billing customers, usage on the day is billed on the second day. For monthly settlement customers, the previous month's usage fees are billed on the 1st of the next month.
        /// </summary>
        /// <param name="req"><see cref="CreateSceneAigcImageTaskRequest"/></param>
        /// <returns><see cref="CreateSceneAigcImageTaskResponse"/></returns>
        public Task<CreateSceneAigcImageTaskResponse> CreateSceneAigcImageTask(CreateSceneAigcImageTaskRequest req)
        {
            return InternalRequestAsync<CreateSceneAigcImageTaskResponse>(req, "CreateSceneAigcImageTask");
        }

        /// <summary>
        /// This API is used to generate scenario-based AIGC images. API calls incur actual fees. Refer to the VOD AIGC image generation billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#9c4dc6ff-4b3f-4b25-bf2d-393889dfb9ac). The feature uses pay-as-you-go settlement mode (https://www.tencentcloud.com/document/product/266/2838?from_cn_redirect=1). For daily billing customers, usage on the day is billed on the second day. For monthly settlement customers, the previous month's usage fees are billed on the 1st of the next month.
        /// </summary>
        /// <param name="req"><see cref="CreateSceneAigcImageTaskRequest"/></param>
        /// <returns><see cref="CreateSceneAigcImageTaskResponse"/></returns>
        public CreateSceneAigcImageTaskResponse CreateSceneAigcImageTaskSync(CreateSceneAigcImageTaskRequest req)
        {
            return InternalRequestAsync<CreateSceneAigcImageTaskResponse>(req, "CreateSceneAigcImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate scenario-based AIGC images. <b>The API is in beta. To use it, please [contact us](https://www.tencentcloud.com/online?from_cn_redirect=1-service?from=sales_sales&source=PRESALE). API calls will incur actual fees.</b>
        /// </summary>
        /// <param name="req"><see cref="CreateSceneAigcVideoTaskRequest"/></param>
        /// <returns><see cref="CreateSceneAigcVideoTaskResponse"/></returns>
        public Task<CreateSceneAigcVideoTaskResponse> CreateSceneAigcVideoTask(CreateSceneAigcVideoTaskRequest req)
        {
            return InternalRequestAsync<CreateSceneAigcVideoTaskResponse>(req, "CreateSceneAigcVideoTask");
        }

        /// <summary>
        /// This API is used to generate scenario-based AIGC images. <b>The API is in beta. To use it, please [contact us](https://www.tencentcloud.com/online?from_cn_redirect=1-service?from=sales_sales&source=PRESALE). API calls will incur actual fees.</b>
        /// </summary>
        /// <param name="req"><see cref="CreateSceneAigcVideoTaskRequest"/></param>
        /// <returns><see cref="CreateSceneAigcVideoTaskResponse"/></returns>
        public CreateSceneAigcVideoTaskResponse CreateSceneAigcVideoTaskSync(CreateSceneAigcVideoTaskRequest req)
        {
            return InternalRequestAsync<CreateSceneAigcVideoTaskResponse>(req, "CreateSceneAigcVideoTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user-customized specified time point screenshot template. Maximum quantity: 16.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<CreateSnapshotByTimeOffsetTemplateResponse> CreateSnapshotByTimeOffsetTemplate(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<CreateSnapshotByTimeOffsetTemplateResponse>(req, "CreateSnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// This API is used to create a user-customized specified time point screenshot template. Maximum quantity: 16.
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
        /// 1. When a user enables the VOD service, storage in partial regions is enabled by default. If the user needs storage in other regions, they can use this API to enable it.
        /// 2. The DescribeStorageRegions API can be used to query all storage regions and regions that are already opened.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRegionRequest"/></param>
        /// <returns><see cref="CreateStorageRegionResponse"/></returns>
        public Task<CreateStorageRegionResponse> CreateStorageRegion(CreateStorageRegionRequest req)
        {
            return InternalRequestAsync<CreateStorageRegionResponse>(req, "CreateStorageRegion");
        }

        /// <summary>
        /// This API is used to enable storage in a region.
        /// 1. When a user enables the VOD service, storage in partial regions is enabled by default. If the user needs storage in other regions, they can use this API to enable it.
        /// 2. The DescribeStorageRegions API can be used to query all storage regions and regions that are already opened.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRegionRequest"/></param>
        /// <returns><see cref="CreateStorageRegionResponse"/></returns>
        public CreateStorageRegionResponse CreateStorageRegionSync(CreateStorageRegionRequest req)
        {
            return InternalRequestAsync<CreateStorageRegionResponse>(req, "CreateStorageRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a VOD application.
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public Task<CreateSubAppIdResponse> CreateSubAppId(CreateSubAppIdRequest req)
        {
            return InternalRequestAsync<CreateSubAppIdResponse>(req, "CreateSubAppId");
        }

        /// <summary>
        /// This API is used to create a VOD application.
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public CreateSubAppIdResponse CreateSubAppIdSync(CreateSubAppIdRequest req)
        {
            return InternalRequestAsync<CreateSubAppIdResponse>(req, "CreateSubAppId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to create player configurations. Maximum quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public Task<CreateSuperPlayerConfigResponse> CreateSuperPlayerConfig(CreateSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<CreateSuperPlayerConfigResponse>(req, "CreateSuperPlayerConfig");
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to create player configurations. Maximum quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public CreateSuperPlayerConfigResponse CreateSuperPlayerConfigSync(CreateSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<CreateSuperPlayerConfigResponse>(req, "CreateSuperPlayerConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create custom transcoding templates. Maximum quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate");
        }

        /// <summary>
        /// Create custom transcoding templates. Maximum quantity: 100.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add acceleration domain names to VOD. A user can add up to 20 acceleration domain names.
        /// 1. After the domain name is successfully added, VOD will deploy the domain name. It takes about 2 minutes for the domain name to change from deployment status to online status.
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public Task<CreateVodDomainResponse> CreateVodDomain(CreateVodDomainRequest req)
        {
            return InternalRequestAsync<CreateVodDomainResponse>(req, "CreateVodDomain");
        }

        /// <summary>
        /// This API is used to add acceleration domain names to VOD. A user can add up to 20 acceleration domain names.
        /// 1. After the domain name is successfully added, VOD will deploy the domain name. It takes about 2 minutes for the domain name to change from deployment status to online status.
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public CreateVodDomainResponse CreateVodDomainSync(CreateVodDomainRequest req)
        {
            return InternalRequestAsync<CreateVodDomainResponse>(req, "CreateVodDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user-defined watermark template with an upper limit of 1000.
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplate(CreateWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateWatermarkTemplateResponse>(req, "CreateWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to create a user-defined watermark template with an upper limit of 1000.
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplateSync(CreateWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateWatermarkTemplateResponse>(req, "CreateWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create keyword samples in batches. Samples are used for video processing such as inappropriate content recognition and content recognition through OCR and ASR technologies.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples");
        }

        /// <summary>
        /// This API is used to create keyword samples in batches. Samples are used for video processing such as inappropriate content recognition and content recognition through OCR and ASR technologies.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public CreateWordSamplesResponse CreateWordSamplesSync(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-defined audio and video content analysis template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public Task<DeleteAIAnalysisTemplateResponse> DeleteAIAnalysisTemplate(DeleteAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisTemplateResponse>(req, "DeleteAIAnalysisTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-defined audio and video content analysis template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public DeleteAIAnalysisTemplateResponse DeleteAIAnalysisTemplateSync(DeleteAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisTemplateResponse>(req, "DeleteAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-defined audio and video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-defined audio and video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public DeleteAIRecognitionTemplateResponse DeleteAIRecognitionTemplateSync(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an adaptive bitrate streaming template
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<DeleteAdaptiveDynamicStreamingTemplateResponse> DeleteAdaptiveDynamicStreamingTemplate(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAdaptiveDynamicStreamingTemplateResponse>(req, "DeleteAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// Delete an adaptive bitrate streaming template
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public DeleteAdaptiveDynamicStreamingTemplateResponse DeleteAdaptiveDynamicStreamingTemplateSync(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAdaptiveDynamicStreamingTemplateResponse>(req, "DeleteAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete AIGC advanced custom subjects.
        /// </summary>
        /// <param name="req"><see cref="DeleteAigcAdvancedCustomElementRequest"/></param>
        /// <returns><see cref="DeleteAigcAdvancedCustomElementResponse"/></returns>
        public Task<DeleteAigcAdvancedCustomElementResponse> DeleteAigcAdvancedCustomElement(DeleteAigcAdvancedCustomElementRequest req)
        {
            return InternalRequestAsync<DeleteAigcAdvancedCustomElementResponse>(req, "DeleteAigcAdvancedCustomElement");
        }

        /// <summary>
        /// This API is used to delete AIGC advanced custom subjects.
        /// </summary>
        /// <param name="req"><see cref="DeleteAigcAdvancedCustomElementRequest"/></param>
        /// <returns><see cref="DeleteAigcAdvancedCustomElementResponse"/></returns>
        public DeleteAigcAdvancedCustomElementResponse DeleteAigcAdvancedCustomElementSync(DeleteAigcAdvancedCustomElementRequest req)
        {
            return InternalRequestAsync<DeleteAigcAdvancedCustomElementResponse>(req, "DeleteAigcAdvancedCustomElement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an AIGC API Token. The AIGC quota associated with the Token will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAigcApiTokenRequest"/></param>
        /// <returns><see cref="DeleteAigcApiTokenResponse"/></returns>
        public Task<DeleteAigcApiTokenResponse> DeleteAigcApiToken(DeleteAigcApiTokenRequest req)
        {
            return InternalRequestAsync<DeleteAigcApiTokenResponse>(req, "DeleteAigcApiToken");
        }

        /// <summary>
        /// Delete an AIGC API Token. The AIGC quota associated with the Token will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAigcApiTokenRequest"/></param>
        /// <returns><see cref="DeleteAigcApiTokenResponse"/></returns>
        public DeleteAigcApiTokenResponse DeleteAigcApiTokenSync(DeleteAigcApiTokenRequest req)
        {
            return InternalRequestAsync<DeleteAigcApiTokenResponse>(req, "DeleteAigcApiToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete AIGC quota configurations. Once deleted, AIGC task initiation will no longer be limited.
        /// 
        /// If the quota is deleted and re-enabled, the amount will be cleared and recalculated.
        /// </summary>
        /// <param name="req"><see cref="DeleteAigcQuotaRequest"/></param>
        /// <returns><see cref="DeleteAigcQuotaResponse"/></returns>
        public Task<DeleteAigcQuotaResponse> DeleteAigcQuota(DeleteAigcQuotaRequest req)
        {
            return InternalRequestAsync<DeleteAigcQuotaResponse>(req, "DeleteAigcQuota");
        }

        /// <summary>
        /// This API is used to delete AIGC quota configurations. Once deleted, AIGC task initiation will no longer be limited.
        /// 
        /// If the quota is deleted and re-enabled, the amount will be cleared and recalculated.
        /// </summary>
        /// <param name="req"><see cref="DeleteAigcQuotaRequest"/></param>
        /// <returns><see cref="DeleteAigcQuotaResponse"/></returns>
        public DeleteAigcQuotaResponse DeleteAigcQuotaSync(DeleteAigcQuotaRequest req)
        {
            return InternalRequestAsync<DeleteAigcQuotaResponse>(req, "DeleteAigcQuota")
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
        /// This API is used to delete a user-defined digital watermark template.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlindWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteBlindWatermarkTemplateResponse"/></returns>
        public Task<DeleteBlindWatermarkTemplateResponse> DeleteBlindWatermarkTemplate(DeleteBlindWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<DeleteBlindWatermarkTemplateResponse>(req, "DeleteBlindWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-defined digital watermark template.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlindWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteBlindWatermarkTemplateResponse"/></returns>
        public DeleteBlindWatermarkTemplateResponse DeleteBlindWatermarkTemplateSync(DeleteBlindWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<DeleteBlindWatermarkTemplateResponse>(req, "DeleteBlindWatermarkTemplate")
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
        /// Delete the log topic enabled for VOD.
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSTopicRequest"/></param>
        /// <returns><see cref="DeleteCLSTopicResponse"/></returns>
        public Task<DeleteCLSTopicResponse> DeleteCLSTopic(DeleteCLSTopicRequest req)
        {
            return InternalRequestAsync<DeleteCLSTopicResponse>(req, "DeleteCLSTopic");
        }

        /// <summary>
        /// Delete the log topic enabled for VOD.
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSTopicRequest"/></param>
        /// <returns><see cref="DeleteCLSTopicResponse"/></returns>
        public DeleteCLSTopicResponse DeleteCLSTopicSync(DeleteCLSTopicRequest req)
        {
            return InternalRequestAsync<DeleteCLSTopicResponse>(req, "DeleteCLSTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * A category can be deleted only when it has no subcategories and no associated media.
        /// * Otherwise, execute [delete media](https://www.tencentcloud.com/document/product/266/31764?from_cn_redirect=1) and subcategories first, then delete the category;
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass");
        }

        /// <summary>
        /// * A category can be deleted only when it has no subcategories and no associated media.
        /// * Otherwise, execute [delete media](https://www.tencentcloud.com/document/product/266/31764?from_cn_redirect=1) and subcategories first, then delete the category;
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public DeleteClassResponse DeleteClassSync(DeleteClassRequest req)
        {
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the moderation template supports video moderation and image moderation. For details, please see [Deleting a Moderation Template](https://www.tencentcloud.com/document/api/266/84390?from_cn_redirect=1).
        /// Delete a user-customized audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the moderation template supports video moderation and image moderation. For details, please see [Deleting a Moderation Template](https://www.tencentcloud.com/document/api/266/84390?from_cn_redirect=1).
        /// Delete a user-customized audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) interface uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to delete an audio and video quality rebirth template.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteEnhanceMediaTemplateResponse"/></returns>
        public Task<DeleteEnhanceMediaTemplateResponse> DeleteEnhanceMediaTemplate(DeleteEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEnhanceMediaTemplateResponse>(req, "DeleteEnhanceMediaTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) interface uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to delete an audio and video quality rebirth template.
        /// </summary>
        /// <param name="req"><see cref="DeleteEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteEnhanceMediaTemplateResponse"/></returns>
        public DeleteEnhanceMediaTemplateResponse DeleteEnhanceMediaTemplateSync(DeleteEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEnhanceMediaTemplateResponse>(req, "DeleteEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a title and trailer template.
        /// </summary>
        /// <param name="req"><see cref="DeleteHeadTailTemplateRequest"/></param>
        /// <returns><see cref="DeleteHeadTailTemplateResponse"/></returns>
        public Task<DeleteHeadTailTemplateResponse> DeleteHeadTailTemplate(DeleteHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteHeadTailTemplateResponse>(req, "DeleteHeadTailTemplate");
        }

        /// <summary>
        /// Delete a title and trailer template.
        /// </summary>
        /// <param name="req"><see cref="DeleteHeadTailTemplateRequest"/></param>
        /// <returns><see cref="DeleteHeadTailTemplateResponse"/></returns>
        public DeleteHeadTailTemplateResponse DeleteHeadTailTemplateSync(DeleteHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteHeadTailTemplateResponse>(req, "DeleteHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-customized image processing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public Task<DeleteImageProcessingTemplateResponse> DeleteImageProcessingTemplate(DeleteImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageProcessingTemplateResponse>(req, "DeleteImageProcessingTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-customized image processing template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public DeleteImageProcessingTemplateResponse DeleteImageProcessingTemplateSync(DeleteImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageProcessingTemplateResponse>(req, "DeleteImageProcessingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an image sprite template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public Task<DeleteImageSpriteTemplateResponse> DeleteImageSpriteTemplate(DeleteImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageSpriteTemplateResponse>(req, "DeleteImageSpriteTemplate");
        }

        /// <summary>
        /// Delete an image sprite template.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public DeleteImageSpriteTemplateResponse DeleteImageSpriteTemplateSync(DeleteImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageSpriteTemplateResponse>(req, "DeleteImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a just in time transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<DeleteJustInTimeTranscodeTemplateResponse> DeleteJustInTimeTranscodeTemplate(DeleteJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplateResponse>(req, "DeleteJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// Delete a just in time transcoding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplateResponse"/></returns>
        public DeleteJustInTimeTranscodeTemplateResponse DeleteJustInTimeTranscodeTemplateSync(DeleteJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplateResponse>(req, "DeleteJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a knowledge base.
        /// After the API is called, the knowledge base is in the "Deleting" status, and the deletion operation is performed in the backend.
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeBaseRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeBaseResponse"/></returns>
        public Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBase(DeleteKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeBaseResponse>(req, "DeleteKnowledgeBase");
        }

        /// <summary>
        /// Delete a knowledge base.
        /// After the API is called, the knowledge base is in the "Deleting" status, and the deletion operation is performed in the backend.
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeBaseRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeBaseResponse"/></returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBaseSync(DeleteKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeBaseResponse>(req, "DeleteKnowledgeBase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a user-customized large model parsing template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteLLMComprehendTemplateRequest"/></param>
        /// <returns><see cref="DeleteLLMComprehendTemplateResponse"/></returns>
        public Task<DeleteLLMComprehendTemplateResponse> DeleteLLMComprehendTemplate(DeleteLLMComprehendTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLLMComprehendTemplateResponse>(req, "DeleteLLMComprehendTemplate");
        }

        /// <summary>
        /// Delete a user-customized large model parsing template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteLLMComprehendTemplateRequest"/></param>
        /// <returns><see cref="DeleteLLMComprehendTemplateResponse"/></returns>
        public DeleteLLMComprehendTemplateResponse DeleteLLMComprehendTemplateSync(DeleteLLMComprehendTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLLMComprehendTemplateResponse>(req, "DeleteLLMComprehendTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-defined MPS task template.
        /// </summary>
        /// <param name="req"><see cref="DeleteMPSTemplateRequest"/></param>
        /// <returns><see cref="DeleteMPSTemplateResponse"/></returns>
        public Task<DeleteMPSTemplateResponse> DeleteMPSTemplate(DeleteMPSTemplateRequest req)
        {
            return InternalRequestAsync<DeleteMPSTemplateResponse>(req, "DeleteMPSTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-defined MPS task template.
        /// </summary>
        /// <param name="req"><see cref="DeleteMPSTemplateRequest"/></param>
        /// <returns><see cref="DeleteMPSTemplateResponse"/></returns>
        public DeleteMPSTemplateResponse DeleteMPSTemplateSync(DeleteMPSTemplateRequest req)
        {
            return InternalRequestAsync<DeleteMPSTemplateResponse>(req, "DeleteMPSTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * Delete media and its corresponding video processing files (raw files, such as transcoded videos, sprite sheets, screenshots, WeChat video releases, etc.);
        /// * You can separately delete the original file, transcoded video, and WeChat-published video under a specified video file ID.
        /// * Note: After the original file is deleted, you cannot initiate any video processing operations such as transcoding or WeChat publishing.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public Task<DeleteMediaResponse> DeleteMedia(DeleteMediaRequest req)
        {
            return InternalRequestAsync<DeleteMediaResponse>(req, "DeleteMedia");
        }

        /// <summary>
        /// * Delete media and its corresponding video processing files (raw files, such as transcoded videos, sprite sheets, screenshots, WeChat video releases, etc.);
        /// * You can separately delete the original file, transcoded video, and WeChat-published video under a specified video file ID.
        /// * Note: After the original file is deleted, you cannot initiate any video processing operations such as transcoding or WeChat publishing.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public DeleteMediaResponse DeleteMediaSync(DeleteMediaRequest req)
        {
            return InternalRequestAsync<DeleteMediaResponse>(req, "DeleteMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete material samples based on person ID.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample");
        }

        /// <summary>
        /// This API is used to delete material samples based on person ID.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-defined task flow template.
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public Task<DeleteProcedureTemplateResponse> DeleteProcedureTemplate(DeleteProcedureTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcedureTemplateResponse>(req, "DeleteProcedureTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-defined task flow template.
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public DeleteProcedureTemplateResponse DeleteProcedureTemplateSync(DeleteProcedureTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcedureTemplateResponse>(req, "DeleteProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-customized image asynchronous processing template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteProcessImageAsyncTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcessImageAsyncTemplateResponse"/></returns>
        public Task<DeleteProcessImageAsyncTemplateResponse> DeleteProcessImageAsyncTemplate(DeleteProcessImageAsyncTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcessImageAsyncTemplateResponse>(req, "DeleteProcessImageAsyncTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-customized image asynchronous processing template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteProcessImageAsyncTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcessImageAsyncTemplateResponse"/></returns>
        public DeleteProcessImageAsyncTemplateResponse DeleteProcessImageAsyncTemplateSync(DeleteProcessImageAsyncTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcessImageAsyncTemplateResponse>(req, "DeleteProcessImageAsyncTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an audio-visual quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityInspectTemplateResponse"/></returns>
        public Task<DeleteQualityInspectTemplateResponse> DeleteQualityInspectTemplate(DeleteQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityInspectTemplateResponse>(req, "DeleteQualityInspectTemplate");
        }

        /// <summary>
        /// This API is used to delete an audio-visual quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityInspectTemplateResponse"/></returns>
        public DeleteQualityInspectTemplateResponse DeleteQualityInspectTemplateSync(DeleteQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityInspectTemplateResponse>(req, "DeleteQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to delete a video rebirth template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public Task<DeleteRebuildMediaTemplateResponse> DeleteRebuildMediaTemplate(DeleteRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRebuildMediaTemplateResponse>(req, "DeleteRebuildMediaTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to delete a video rebirth template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public DeleteRebuildMediaTemplateResponse DeleteRebuildMediaTemplateSync(DeleteRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRebuildMediaTemplateResponse>(req, "DeleteRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-customized moderation template.
        /// >Template is applicable only to the ReviewAudioVideo (https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and ReviewImage (https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public Task<DeleteReviewTemplateResponse> DeleteReviewTemplate(DeleteReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteReviewTemplateResponse>(req, "DeleteReviewTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-customized moderation template.
        /// >Template is applicable only to the ReviewAudioVideo (https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and ReviewImage (https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public DeleteReviewTemplateResponse DeleteReviewTemplateSync(DeleteReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteReviewTemplateResponse>(req, "DeleteReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a carousel playlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public Task<DeleteRoundPlayResponse> DeleteRoundPlay(DeleteRoundPlayRequest req)
        {
            return InternalRequestAsync<DeleteRoundPlayResponse>(req, "DeleteRoundPlay");
        }

        /// <summary>
        /// This API is used to delete a carousel playlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public DeleteRoundPlayResponse DeleteRoundPlaySync(DeleteRoundPlayRequest req)
        {
            return InternalRequestAsync<DeleteRoundPlayResponse>(req, "DeleteRoundPlay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-customized sampled screenshot template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public Task<DeleteSampleSnapshotTemplateResponse> DeleteSampleSnapshotTemplate(DeleteSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSampleSnapshotTemplateResponse>(req, "DeleteSampleSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-customized sampled screenshot template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public DeleteSampleSnapshotTemplateResponse DeleteSampleSnapshotTemplateSync(DeleteSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSampleSnapshotTemplateResponse>(req, "DeleteSampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-defined specified time point screenshot template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<DeleteSnapshotByTimeOffsetTemplateResponse> DeleteSnapshotByTimeOffsetTemplate(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotByTimeOffsetTemplateResponse>(req, "DeleteSnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-defined specified time point screenshot template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public DeleteSnapshotByTimeOffsetTemplateResponse DeleteSnapshotByTimeOffsetTemplateSync(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotByTimeOffsetTemplateResponse>(req, "DeleteSnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to delete player configurations.  
        /// *Note: System preset player configurations cannot be deleted.*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public Task<DeleteSuperPlayerConfigResponse> DeleteSuperPlayerConfig(DeleteSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<DeleteSuperPlayerConfigResponse>(req, "DeleteSuperPlayerConfig");
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to delete player configurations.  
        /// *Note: System preset player configurations cannot be deleted.*
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
        /// This API is used to delete VOD acceleration domains.
        /// 1. Before domain deletion, acceleration in all regions needs to be disabled.
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public Task<DeleteVodDomainResponse> DeleteVodDomain(DeleteVodDomainRequest req)
        {
            return InternalRequestAsync<DeleteVodDomainResponse>(req, "DeleteVodDomain");
        }

        /// <summary>
        /// This API is used to delete VOD acceleration domains.
        /// 1. Before domain deletion, acceleration in all regions needs to be disabled.
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public DeleteVodDomainResponse DeleteVodDomainSync(DeleteVodDomainRequest req)
        {
            return InternalRequestAsync<DeleteVodDomainResponse>(req, "DeleteVodDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a specified voice by voice ID. Deletion is irreversible and the voice cannot be used for subsequent APIs. It only supports deletion of voices for this account. System preset voices cannot be deleted.
        /// 
        /// Note: Newly designed or cloned voice types cannot be deleted before activation (not found means non-operational). They are activated only after the newly created voice type is used for TTS once.
        /// </summary>
        /// <param name="req"><see cref="DeleteVoiceRequest"/></param>
        /// <returns><see cref="DeleteVoiceResponse"/></returns>
        public Task<DeleteVoiceResponse> DeleteVoice(DeleteVoiceRequest req)
        {
            return InternalRequestAsync<DeleteVoiceResponse>(req, "DeleteVoice");
        }

        /// <summary>
        /// This API is used to delete a specified voice by voice ID. Deletion is irreversible and the voice cannot be used for subsequent APIs. It only supports deletion of voices for this account. System preset voices cannot be deleted.
        /// 
        /// Note: Newly designed or cloned voice types cannot be deleted before activation (not found means non-operational). They are activated only after the newly created voice type is used for TTS once.
        /// </summary>
        /// <param name="req"><see cref="DeleteVoiceRequest"/></param>
        /// <returns><see cref="DeleteVoiceResponse"/></returns>
        public DeleteVoiceResponse DeleteVoiceSync(DeleteVoiceRequest req)
        {
            return InternalRequestAsync<DeleteVoiceResponse>(req, "DeleteVoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user-customized watermark template.
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWatermarkTemplateResponse>(req, "DeleteWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to delete a user-customized watermark template.
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
        /// This API is used to retrieve the detail list of audio and video content analysis templates based on the unique identifier of an audio and video content analysis template. The returned results include all eligible user-defined audio and video content analysis templates and [system preset audio/video content analysis templates](https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates");
        }

        /// <summary>
        /// This API is used to retrieve the detail list of audio and video content analysis templates based on the unique identifier of an audio and video content analysis template. The returned results include all eligible user-defined audio and video content analysis templates and [system preset audio/video content analysis templates](https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of details of audio/video content recognition templates by unique identifier. The returned results include all eligible user-defined audio/video content recognition templates and system preset audio/video content recognition templates (https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates");
        }

        /// <summary>
        /// This API is used to get the list of details of audio/video content recognition templates by unique identifier. The returned results include all eligible user-defined audio/video content recognition templates and system preset audio/video content recognition templates (https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public DescribeAIRecognitionTemplatesResponse DescribeAIRecognitionTemplatesSync(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query adaptive bitrate streaming templates, and the pagination query is supported based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public Task<DescribeAdaptiveDynamicStreamingTemplatesResponse> DescribeAdaptiveDynamicStreamingTemplates(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates");
        }

        /// <summary>
        /// This API is used to query adaptive bitrate streaming templates, and the pagination query is supported based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public DescribeAdaptiveDynamicStreamingTemplatesResponse DescribeAdaptiveDynamicStreamingTemplatesSync(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain advanced custom AIGC subjects.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcAdvancedCustomElementsRequest"/></param>
        /// <returns><see cref="DescribeAigcAdvancedCustomElementsResponse"/></returns>
        public Task<DescribeAigcAdvancedCustomElementsResponse> DescribeAigcAdvancedCustomElements(DescribeAigcAdvancedCustomElementsRequest req)
        {
            return InternalRequestAsync<DescribeAigcAdvancedCustomElementsResponse>(req, "DescribeAigcAdvancedCustomElements");
        }

        /// <summary>
        /// This API is used to obtain advanced custom AIGC subjects.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcAdvancedCustomElementsRequest"/></param>
        /// <returns><see cref="DescribeAigcAdvancedCustomElementsResponse"/></returns>
        public DescribeAigcAdvancedCustomElementsResponse DescribeAigcAdvancedCustomElementsSync(DescribeAigcAdvancedCustomElementsRequest req)
        {
            return InternalRequestAsync<DescribeAigcAdvancedCustomElementsResponse>(req, "DescribeAigcAdvancedCustomElements")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of AIGC API tokens. Data sync may delay after creation or deletion. You can query the latest data after about 30 seconds.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcApiTokensRequest"/></param>
        /// <returns><see cref="DescribeAigcApiTokensResponse"/></returns>
        public Task<DescribeAigcApiTokensResponse> DescribeAigcApiTokens(DescribeAigcApiTokensRequest req)
        {
            return InternalRequestAsync<DescribeAigcApiTokensResponse>(req, "DescribeAigcApiTokens");
        }

        /// <summary>
        /// Query the list of AIGC API tokens. Data sync may delay after creation or deletion. You can query the latest data after about 30 seconds.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcApiTokensRequest"/></param>
        /// <returns><see cref="DescribeAigcApiTokensResponse"/></returns>
        public DescribeAigcApiTokensResponse DescribeAigcApiTokensSync(DescribeAigcApiTokensRequest req)
        {
            return InternalRequestAsync<DescribeAigcApiTokensResponse>(req, "DescribeAigcApiTokens")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve AIGC face information. Note that calling this API will incur face recognition fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcFaceInfoRequest"/></param>
        /// <returns><see cref="DescribeAigcFaceInfoResponse"/></returns>
        public Task<DescribeAigcFaceInfoResponse> DescribeAigcFaceInfo(DescribeAigcFaceInfoRequest req)
        {
            return InternalRequestAsync<DescribeAigcFaceInfoResponse>(req, "DescribeAigcFaceInfo");
        }

        /// <summary>
        /// This API is used to retrieve AIGC face information. Note that calling this API will incur face recognition fees. Refer to the billing documentation (https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcFaceInfoRequest"/></param>
        /// <returns><see cref="DescribeAigcFaceInfoResponse"/></returns>
        public DescribeAigcFaceInfoResponse DescribeAigcFaceInfoSync(DescribeAigcFaceInfoRequest req)
        {
            return InternalRequestAsync<DescribeAigcFaceInfoResponse>(req, "DescribeAigcFaceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to asynchronously fetch AIGC face information. Note that calling this API will incur face recognition fees. Refer to the [billing documentation](https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcFaceInfoAsyncRequest"/></param>
        /// <returns><see cref="DescribeAigcFaceInfoAsyncResponse"/></returns>
        public Task<DescribeAigcFaceInfoAsyncResponse> DescribeAigcFaceInfoAsync(DescribeAigcFaceInfoAsyncRequest req)
        {
            return InternalRequestAsync<DescribeAigcFaceInfoAsyncResponse>(req, "DescribeAigcFaceInfoAsync");
        }

        /// <summary>
        /// This API is used to asynchronously fetch AIGC face information. Note that calling this API will incur face recognition fees. Refer to the [billing documentation](https://www.tencentcloud.com/document/product/266/95125?from_cn_redirect=1#96b3b59a-f9e1-49e9-966a-bedb70a4bf12).
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcFaceInfoAsyncRequest"/></param>
        /// <returns><see cref="DescribeAigcFaceInfoAsyncResponse"/></returns>
        public DescribeAigcFaceInfoAsyncResponse DescribeAigcFaceInfoAsyncSync(DescribeAigcFaceInfoAsyncRequest req)
        {
            return InternalRequestAsync<DescribeAigcFaceInfoAsyncResponse>(req, "DescribeAigcFaceInfoAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query AIGC quota configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcQuotasRequest"/></param>
        /// <returns><see cref="DescribeAigcQuotasResponse"/></returns>
        public Task<DescribeAigcQuotasResponse> DescribeAigcQuotas(DescribeAigcQuotasRequest req)
        {
            return InternalRequestAsync<DescribeAigcQuotasResponse>(req, "DescribeAigcQuotas");
        }

        /// <summary>
        /// This API is used to query AIGC quota configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcQuotasRequest"/></param>
        /// <returns><see cref="DescribeAigcQuotasResponse"/></returns>
        public DescribeAigcQuotasResponse DescribeAigcQuotasSync(DescribeAigcQuotasRequest req)
        {
            return InternalRequestAsync<DescribeAigcQuotasResponse>(req, "DescribeAigcQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return AIGC statistical information within a specified time range.
        /// 1. AIGC statistical data from the last 365 days can be queried.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data of day granularity is returned. Otherwise, the data of 5-minute granularity is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcUsageDataRequest"/></param>
        /// <returns><see cref="DescribeAigcUsageDataResponse"/></returns>
        public Task<DescribeAigcUsageDataResponse> DescribeAigcUsageData(DescribeAigcUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeAigcUsageDataResponse>(req, "DescribeAigcUsageData");
        }

        /// <summary>
        /// This API is used to return AIGC statistical information within a specified time range.
        /// 1. AIGC statistical data from the last 365 days can be queried.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data of day granularity is returned. Otherwise, the data of 5-minute granularity is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcUsageDataRequest"/></param>
        /// <returns><see cref="DescribeAigcUsageDataResponse"/></returns>
        public DescribeAigcUsageDataResponse DescribeAigcUsageDataSync(DescribeAigcUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeAigcUsageDataResponse>(req, "DescribeAigcUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * Obtain all classification information of the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public Task<DescribeAllClassResponse> DescribeAllClass(DescribeAllClassRequest req)
        {
            return InternalRequestAsync<DescribeAllClassResponse>(req, "DescribeAllClass");
        }

        /// <summary>
        /// * Obtain all classification information of the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public DescribeAllClassResponse DescribeAllClassSync(DescribeAllClassRequest req)
        {
            return InternalRequestAsync<DescribeAllClassResponse>(req, "DescribeAllClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of rotating image templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public Task<DescribeAnimatedGraphicsTemplatesResponse> DescribeAnimatedGraphicsTemplates(DescribeAnimatedGraphicsTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAnimatedGraphicsTemplatesResponse>(req, "DescribeAnimatedGraphicsTemplates");
        }

        /// <summary>
        /// Queries the list of rotating image templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public DescribeAnimatedGraphicsTemplatesResponse DescribeAnimatedGraphicsTemplatesSync(DescribeAnimatedGraphicsTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAnimatedGraphicsTemplatesResponse>(req, "DescribeAnimatedGraphicsTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries user-customized digital watermark templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlindWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeBlindWatermarkTemplatesResponse"/></returns>
        public Task<DescribeBlindWatermarkTemplatesResponse> DescribeBlindWatermarkTemplates(DescribeBlindWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeBlindWatermarkTemplatesResponse>(req, "DescribeBlindWatermarkTemplates");
        }

        /// <summary>
        /// Queries user-customized digital watermark templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlindWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeBlindWatermarkTemplatesResponse"/></returns>
        public DescribeBlindWatermarkTemplatesResponse DescribeBlindWatermarkTemplatesSync(DescribeBlindWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeBlindWatermarkTemplatesResponse>(req, "DescribeBlindWatermarkTemplates")
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
        /// This API is used to query CDN bandwidth, traffic, and other stats of an on-demand domain name.
        /// * The time span between the query start time and end time should not exceed 90 days.
        /// * Data in different service regions can be queried.
        /// * Data support within the Chinese mainland for querying stats by specified region and carrier.
        /// Playback statistics only target VOD domains. Distribution through EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public Task<DescribeCDNStatDetailsResponse> DescribeCDNStatDetails(DescribeCDNStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCDNStatDetailsResponse>(req, "DescribeCDNStatDetails");
        }

        /// <summary>
        /// This API is used to query CDN bandwidth, traffic, and other stats of an on-demand domain name.
        /// * The time span between the query start time and end time should not exceed 90 days.
        /// * Data in different service regions can be queried.
        /// * Data support within the Chinese mainland for querying stats by specified region and carrier.
        /// Playback statistics only target VOD domains. Distribution through EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public DescribeCDNStatDetailsResponse DescribeCDNStatDetailsSync(DescribeCDNStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCDNStatDetailsResponse>(req, "DescribeCDNStatDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query VOD CDN stats such as traffic and bandwidth.
        /// 1. CDN usage data is retained on the system side for 13 months. You can only query usage data from the most recent 365 days through the API. If you need to retrieve historical usage data beyond 365 days, contact us.
        ///    2. The query time span should not exceed 90 days.
        /// 3. You can specify the time granularity of usage data. Supported granularities: 5 minutes, 1 hour, and 1 day.
        /// 4. Traffic is the total traffic within the query time granularity, and bandwidth is the peak bandwidth within the query time granularity.
        /// 5. Playback statistics only target VOD domains. Distribution through EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public Task<DescribeCDNUsageDataResponse> DescribeCDNUsageData(DescribeCDNUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeCDNUsageDataResponse>(req, "DescribeCDNUsageData");
        }

        /// <summary>
        /// This API is used to query VOD CDN stats such as traffic and bandwidth.
        /// 1. CDN usage data is retained on the system side for 13 months. You can only query usage data from the most recent 365 days through the API. If you need to retrieve historical usage data beyond 365 days, contact us.
        ///    2. The query time span should not exceed 90 days.
        /// 3. You can specify the time granularity of usage data. Supported granularities: 5 minutes, 1 hour, and 1 day.
        /// 4. Traffic is the total traffic within the query time granularity, and bandwidth is the peak bandwidth within the query time granularity.
        /// 5. Playback statistics only target VOD domains. Distribution through EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public DescribeCDNUsageDataResponse DescribeCDNUsageDataSync(DescribeCDNUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeCDNUsageDataResponse>(req, "DescribeCDNUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries CLS log sets created by VOD.
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogsetsRequest"/></param>
        /// <returns><see cref="DescribeCLSLogsetsResponse"/></returns>
        public Task<DescribeCLSLogsetsResponse> DescribeCLSLogsets(DescribeCLSLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSLogsetsResponse>(req, "DescribeCLSLogsets");
        }

        /// <summary>
        /// Queries CLS log sets created by VOD.
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogsetsRequest"/></param>
        /// <returns><see cref="DescribeCLSLogsetsResponse"/></returns>
        public DescribeCLSLogsetsResponse DescribeCLSLogsetsSync(DescribeCLSLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSLogsetsResponse>(req, "DescribeCLSLogsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the destination topic for log delivery under an on-demand domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSPushTargetsRequest"/></param>
        /// <returns><see cref="DescribeCLSPushTargetsResponse"/></returns>
        public Task<DescribeCLSPushTargetsResponse> DescribeCLSPushTargets(DescribeCLSPushTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSPushTargetsResponse>(req, "DescribeCLSPushTargets");
        }

        /// <summary>
        /// Queries the destination topic for log delivery under an on-demand domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSPushTargetsRequest"/></param>
        /// <returns><see cref="DescribeCLSPushTargetsResponse"/></returns>
        public DescribeCLSPushTargetsResponse DescribeCLSPushTargetsSync(DescribeCLSPushTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSPushTargetsResponse>(req, "DescribeCLSPushTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of CLS log topics created by VOD.
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSTopicsRequest"/></param>
        /// <returns><see cref="DescribeCLSTopicsResponse"/></returns>
        public Task<DescribeCLSTopicsResponse> DescribeCLSTopics(DescribeCLSTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCLSTopicsResponse>(req, "DescribeCLSTopics");
        }

        /// <summary>
        /// Queries the list of CLS log topics created by VOD.
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSTopicsRequest"/></param>
        /// <returns><see cref="DescribeCLSTopicsResponse"/></returns>
        public DescribeCLSTopicsResponse DescribeCLSTopicsSync(DescribeCLSTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCLSTopicsResponse>(req, "DescribeCLSTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download URL of CDN access logs for a VOD domain, excluding logs where EdgeOne pulls from the VOD domain.
        /// 1. Can query CDN log download links from the most recent 30 days.
        /// 2. By default, CDN generates a log file per hour. If there is no CDN access in an hour, no log file is generated.    
        /// 3. The CDN log download link has a validity of 24 hours.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public Task<DescribeCdnLogsResponse> DescribeCdnLogs(DescribeCdnLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnLogsResponse>(req, "DescribeCdnLogs");
        }

        /// <summary>
        /// This API is used to query the download URL of CDN access logs for a VOD domain, excluding logs where EdgeOne pulls from the VOD domain.
        /// 1. Can query CDN log download links from the most recent 30 days.
        /// 2. By default, CDN generates a log file per hour. If there is no CDN access in an hour, no log file is generated.    
        /// 3. The CDN log download link has a validity of 24 hours.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public DescribeCdnLogsResponse DescribeCdnLogsSync(DescribeCdnLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnLogsResponse>(req, "DescribeCdnLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API returns client upload acceleration statistics within a specified time range.
        /// 1. Can query client upload acceleration statistics data for the most recent 365 days.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data is returned at a granularity of 1 day. Otherwise, the data is returned at a granularity of 5 minutes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public Task<DescribeClientUploadAccelerationUsageDataResponse> DescribeClientUploadAccelerationUsageData(DescribeClientUploadAccelerationUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeClientUploadAccelerationUsageDataResponse>(req, "DescribeClientUploadAccelerationUsageData");
        }

        /// <summary>
        /// This API returns client upload acceleration statistics within a specified time range.
        /// 1. Can query client upload acceleration statistics data for the most recent 365 days.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data is returned at a granularity of 1 day. Otherwise, the data is returned at a granularity of 5 minutes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public DescribeClientUploadAccelerationUsageDataResponse DescribeClientUploadAccelerationUsageDataSync(DescribeClientUploadAccelerationUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeClientUploadAccelerationUsageDataResponse>(req, "DescribeClientUploadAccelerationUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of moderation template supports video moderation and image moderation. For details, please see [Get Moderation Template List](https://www.tencentcloud.com/document/api/266/84389?from_cn_redirect=1).
        /// This API is used to retrieve the list of audio/video moderation template details based on the unique identifier of an audio/video moderation template. The returned results include all eligible custom templates and system preset content review templates (https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of moderation template supports video moderation and image moderation. For details, please see [Get Moderation Template List](https://www.tencentcloud.com/document/api/266/84389?from_cn_redirect=1).
        /// This API is used to retrieve the list of audio/video moderation template details based on the unique identifier of an audio/video moderation template. The returned results include all eligible custom templates and system preset content review templates (https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the carousel current playlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentPlaylistRequest"/></param>
        /// <returns><see cref="DescribeCurrentPlaylistResponse"/></returns>
        public Task<DescribeCurrentPlaylistResponse> DescribeCurrentPlaylist(DescribeCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<DescribeCurrentPlaylistResponse>(req, "DescribeCurrentPlaylist");
        }

        /// <summary>
        /// Query the carousel current playlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentPlaylistRequest"/></param>
        /// <returns><see cref="DescribeCurrentPlaylistResponse"/></returns>
        public DescribeCurrentPlaylistResponse DescribeCurrentPlaylistSync(DescribeCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<DescribeCurrentPlaylistResponse>(req, "DescribeCurrentPlaylist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the daily playback statistics within the specified date range.
        /// * Playback statistics from the past one year can be queried.
        /// * The time span between the start date and end date can be up to 90 days.
        /// Playback statistics only target VOD domains. Distribution of EdgeOne domain names is not included in playback statistics.
        /// * Due to data delay, you are advised to query the usage data of the previous day after 12:00 noon the next day.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMediaPlayStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMediaPlayStatResponse"/></returns>
        public Task<DescribeDailyMediaPlayStatResponse> DescribeDailyMediaPlayStat(DescribeDailyMediaPlayStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMediaPlayStatResponse>(req, "DescribeDailyMediaPlayStat");
        }

        /// <summary>
        /// This API is used to query the daily playback statistics within the specified date range.
        /// * Playback statistics from the past one year can be queried.
        /// * The time span between the start date and end date can be up to 90 days.
        /// Playback statistics only target VOD domains. Distribution of EdgeOne domain names is not included in playback statistics.
        /// * Due to data delay, you are advised to query the usage data of the previous day after 12:00 noon the next day.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMediaPlayStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMediaPlayStatResponse"/></returns>
        public DescribeDailyMediaPlayStatResponse DescribeDailyMediaPlayStatSync(DescribeDailyMediaPlayStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMediaPlayStatResponse>(req, "DescribeDailyMediaPlayStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query playback statistics of the Top 100 daily played media files.
        /// * Playback statistics from the past one year can be queried.
        /// * You can query by number of plays or playback traffic.
        /// * Playback count statistics description:
        /// 1. HLS file: The number of plays is counted when an M3U8 file is accessed, but not when a TS file is accessed.
        /// 2. Other files (for example, MP4 files): If a playback request includes the range parameter and the start parameter of range is not equal to 0, the number of plays is not counted. In other cases, the number of plays is counted.
        /// * Playback statistics only target VOD domains. Distribution through EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMostPlayedStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMostPlayedStatResponse"/></returns>
        public Task<DescribeDailyMostPlayedStatResponse> DescribeDailyMostPlayedStat(DescribeDailyMostPlayedStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMostPlayedStatResponse>(req, "DescribeDailyMostPlayedStat");
        }

        /// <summary>
        /// This API is used to query playback statistics of the Top 100 daily played media files.
        /// * Playback statistics from the past one year can be queried.
        /// * You can query by number of plays or playback traffic.
        /// * Playback count statistics description:
        /// 1. HLS file: The number of plays is counted when an M3U8 file is accessed, but not when a TS file is accessed.
        /// 2. Other files (for example, MP4 files): If a playback request includes the range parameter and the start parameter of range is not equal to 0, the number of plays is not counted. In other cases, the number of plays is counted.
        /// * Playback statistics only target VOD domains. Distribution through EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMostPlayedStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMostPlayedStatResponse"/></returns>
        public DescribeDailyMostPlayedStatResponse DescribeDailyMostPlayedStatSync(DescribeDailyMostPlayedStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMostPlayedStatResponse>(req, "DescribeDailyMostPlayedStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download address of playback statistics files.
        /// * You can query the download link for playback statistics files from the past one year. The time span between the start date and end date cannot exceed 90 days.
        /// VOD analyzes and processes the CDN request logs of the previous day to generate playback statistics files.
        /// * The playback statistics file contains statistical information such as the number of plays and total traffic of media files.
        /// * Statistical description of the number of plays:
        /// 1. HLS file: The number of plays is counted when accessing M3U8 files, but not when accessing TS files.
        /// 2. Other files (for example, MP4 files): If the playback request includes the range parameter and the start parameter of range is not equal to 0, the number of plays is not counted. In other cases, the number of plays is counted.
        /// * Statistics of playback devices: If a playback request includes the UserAgent parameter and the UserAgent contains identifiers such as Android or iPhone, it is counted as a mobile playback count. Otherwise, it is counted as a PC playback count.
        /// Playback statistics only target VOD domain names. Distribution of EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public Task<DescribeDailyPlayStatFileListResponse> DescribeDailyPlayStatFileList(DescribeDailyPlayStatFileListRequest req)
        {
            return InternalRequestAsync<DescribeDailyPlayStatFileListResponse>(req, "DescribeDailyPlayStatFileList");
        }

        /// <summary>
        /// This API is used to query the download address of playback statistics files.
        /// * You can query the download link for playback statistics files from the past one year. The time span between the start date and end date cannot exceed 90 days.
        /// VOD analyzes and processes the CDN request logs of the previous day to generate playback statistics files.
        /// * The playback statistics file contains statistical information such as the number of plays and total traffic of media files.
        /// * Statistical description of the number of plays:
        /// 1. HLS file: The number of plays is counted when accessing M3U8 files, but not when accessing TS files.
        /// 2. Other files (for example, MP4 files): If the playback request includes the range parameter and the start parameter of range is not equal to 0, the number of plays is not counted. In other cases, the number of plays is counted.
        /// * Statistics of playback devices: If a playback request includes the UserAgent parameter and the UserAgent contains identifiers such as Android or iPhone, it is counted as a mobile playback count. Otherwise, it is counted as a PC playback count.
        /// Playback statistics only target VOD domain names. Distribution of EdgeOne domain names is not included in playback statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public DescribeDailyPlayStatFileListResponse DescribeDailyPlayStatFileListSync(DescribeDailyPlayStatFileListRequest req)
        {
            return InternalRequestAsync<DescribeDailyPlayStatFileListResponse>(req, "DescribeDailyPlayStatFileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the default distribution configuration.
        /// * Distribution domain name and distribution protocol, i.e., the domain name and protocol in the media file distribution URL. Media files are distributed based on the default distribution configuration.
        /// Playback key, used to calculate player signature.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="DescribeDefaultDistributionConfigResponse"/></returns>
        public Task<DescribeDefaultDistributionConfigResponse> DescribeDefaultDistributionConfig(DescribeDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<DescribeDefaultDistributionConfigResponse>(req, "DescribeDefaultDistributionConfig");
        }

        /// <summary>
        /// This API is used to query the default distribution configuration.
        /// * Distribution domain name and distribution protocol, i.e., the domain name and protocol in the media file distribution URL. Media files are distributed based on the default distribution configuration.
        /// Playback key, used to calculate player signature.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="DescribeDefaultDistributionConfigResponse"/></returns>
        public DescribeDefaultDistributionConfigResponse DescribeDefaultDistributionConfigSync(DescribeDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<DescribeDefaultDistributionConfigResponse>(req, "DescribeDefaultDistributionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DRM key provider information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public Task<DescribeDrmKeyProviderInfoResponse> DescribeDrmKeyProviderInfo(DescribeDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<DescribeDrmKeyProviderInfoResponse>(req, "DescribeDrmKeyProviderInfo");
        }

        /// <summary>
        /// This API is used to query DRM key provider information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public DescribeDrmKeyProviderInfoResponse DescribeDrmKeyProviderInfoSync(DescribeDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<DescribeDrmKeyProviderInfoResponse>(req, "DescribeDrmKeyProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to retrieve the audio and video quality regeneration template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnhanceMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEnhanceMediaTemplatesResponse"/></returns>
        public Task<DescribeEnhanceMediaTemplatesResponse> DescribeEnhanceMediaTemplates(DescribeEnhanceMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEnhanceMediaTemplatesResponse>(req, "DescribeEnhanceMediaTemplates");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// This API is used to retrieve the audio and video quality regeneration template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnhanceMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEnhanceMediaTemplatesResponse"/></returns>
        public DescribeEnhanceMediaTemplatesResponse DescribeEnhanceMediaTemplatesSync(DescribeEnhanceMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEnhanceMediaTemplatesResponse>(req, "DescribeEnhanceMediaTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tencent Cloud Video on Demand (VOD) provides customers with media upload, media management, media processing, and other services. During or after the execution of these services, VOD also provides various event notifications, helping developers detect service processing status and perform next business operations.
        /// 
        /// Developers can use this API to query the current configuration of event notification receiving methods, recipient addresses, and which events have callback notifications enabled.
        /// 
        /// Default API request rate limit: 100 requests/second.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConfigRequest"/></param>
        /// <returns><see cref="DescribeEventConfigResponse"/></returns>
        public Task<DescribeEventConfigResponse> DescribeEventConfig(DescribeEventConfigRequest req)
        {
            return InternalRequestAsync<DescribeEventConfigResponse>(req, "DescribeEventConfig");
        }

        /// <summary>
        /// Tencent Cloud Video on Demand (VOD) provides customers with media upload, media management, media processing, and other services. During or after the execution of these services, VOD also provides various event notifications, helping developers detect service processing status and perform next business operations.
        /// 
        /// Developers can use this API to query the current configuration of event notification receiving methods, recipient addresses, and which events have callback notifications enabled.
        /// 
        /// Default API request rate limit: 100 requests/second.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConfigRequest"/></param>
        /// <returns><see cref="DescribeEventConfigResponse"/></returns>
        public DescribeEventConfigResponse DescribeEventConfigSync(DescribeEventConfigRequest req)
        {
            return InternalRequestAsync<DescribeEventConfigResponse>(req, "DescribeEventConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to asynchronously fetch file attributes.
        /// -Currently only support getting the Md5 and Sha1 of the source file.
        /// -For HLS or DASH input files, only get the attributes of the index file.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileAttributesRequest"/></param>
        /// <returns><see cref="DescribeFileAttributesResponse"/></returns>
        public Task<DescribeFileAttributesResponse> DescribeFileAttributes(DescribeFileAttributesRequest req)
        {
            return InternalRequestAsync<DescribeFileAttributesResponse>(req, "DescribeFileAttributes");
        }

        /// <summary>
        /// Used to asynchronously fetch file attributes.
        /// -Currently only support getting the Md5 and Sha1 of the source file.
        /// -For HLS or DASH input files, only get the attributes of the index file.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileAttributesRequest"/></param>
        /// <returns><see cref="DescribeFileAttributesResponse"/></returns>
        public DescribeFileAttributesResponse DescribeFileAttributesSync(DescribeFileAttributesRequest req)
        {
            return InternalRequestAsync<DescribeFileAttributesResponse>(req, "DescribeFileAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of title and trailer templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeHeadTailTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHeadTailTemplatesResponse"/></returns>
        public Task<DescribeHeadTailTemplatesResponse> DescribeHeadTailTemplates(DescribeHeadTailTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHeadTailTemplatesResponse>(req, "DescribeHeadTailTemplates");
        }

        /// <summary>
        /// This API is used to get the list of title and trailer templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeHeadTailTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHeadTailTemplatesResponse"/></returns>
        public DescribeHeadTailTemplatesResponse DescribeHeadTailTemplatesSync(DescribeHeadTailTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHeadTailTemplatesResponse>(req, "DescribeHeadTailTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of image processing templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public Task<DescribeImageProcessingTemplatesResponse> DescribeImageProcessingTemplates(DescribeImageProcessingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageProcessingTemplatesResponse>(req, "DescribeImageProcessingTemplates");
        }

        /// <summary>
        /// This API is used to query the list of image processing templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public DescribeImageProcessingTemplatesResponse DescribeImageProcessingTemplatesSync(DescribeImageProcessingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageProcessingTemplatesResponse>(req, "DescribeImageProcessingTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the daily image moderation usage information within the specified query time range.
        /// 1. Image moderation statistics data from the last 365 days can be queried.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data is returned at a granularity of 1 day. Otherwise, the data is returned at a granularity of 5 minutes.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public Task<DescribeImageReviewUsageDataResponse> DescribeImageReviewUsageData(DescribeImageReviewUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeImageReviewUsageDataResponse>(req, "DescribeImageReviewUsageData");
        }

        /// <summary>
        /// This API is used to return the daily image moderation usage information within the specified query time range.
        /// 1. Image moderation statistics data from the last 365 days can be queried.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data is returned at a granularity of 1 day. Otherwise, the data is returned at a granularity of 5 minutes.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public DescribeImageReviewUsageDataResponse DescribeImageReviewUsageDataSync(DescribeImageReviewUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeImageReviewUsageDataResponse>(req, "DescribeImageReviewUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sprite sheet templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public Task<DescribeImageSpriteTemplatesResponse> DescribeImageSpriteTemplates(DescribeImageSpriteTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageSpriteTemplatesResponse>(req, "DescribeImageSpriteTemplates");
        }

        /// <summary>
        /// This API is used to query sprite sheet templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public DescribeImageSpriteTemplatesResponse DescribeImageSpriteTemplatesSync(DescribeImageSpriteTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageSpriteTemplatesResponse>(req, "DescribeImageSpriteTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of instant transcoding templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeJustInTimeTranscodeTemplatesResponse> DescribeJustInTimeTranscodeTemplates(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates");
        }

        /// <summary>
        /// Queries the list of instant transcoding templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public DescribeJustInTimeTranscodeTemplatesResponse DescribeJustInTimeTranscodeTemplatesSync(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the knowledge base list. Return all knowledge base information under the specified user.
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeBasesRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeBasesResponse"/></returns>
        public Task<DescribeKnowledgeBasesResponse> DescribeKnowledgeBases(DescribeKnowledgeBasesRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeBasesResponse>(req, "DescribeKnowledgeBases");
        }

        /// <summary>
        /// Query the knowledge base list. Return all knowledge base information under the specified user.
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeBasesRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeBasesResponse"/></returns>
        public DescribeKnowledgeBasesResponse DescribeKnowledgeBasesSync(DescribeKnowledgeBasesRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeBasesResponse>(req, "DescribeKnowledgeBases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the template detail list of large model parsing templates based on the Template Unique Identifier. The returned results include all eligible user-customized large model parsing templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLLMComprehendTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLLMComprehendTemplatesResponse"/></returns>
        public Task<DescribeLLMComprehendTemplatesResponse> DescribeLLMComprehendTemplates(DescribeLLMComprehendTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLLMComprehendTemplatesResponse>(req, "DescribeLLMComprehendTemplates");
        }

        /// <summary>
        /// This API is used to obtain the template detail list of large model parsing templates based on the Template Unique Identifier. The returned results include all eligible user-customized large model parsing templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeLLMComprehendTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLLMComprehendTemplatesResponse"/></returns>
        public DescribeLLMComprehendTemplatesResponse DescribeLLMComprehendTemplatesSync(DescribeLLMComprehendTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLLMComprehendTemplatesResponse>(req, "DescribeLLMComprehendTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the daily License request count within the specified query time range.
        /// 1. License request count stats from the last 365 days can be queried.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data returned is at day granularity. Otherwise, the data returned is at 5-minute granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public Task<DescribeLicenseUsageDataResponse> DescribeLicenseUsageData(DescribeLicenseUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeLicenseUsageDataResponse>(req, "DescribeLicenseUsageData");
        }

        /// <summary>
        /// This API is used to return the daily License request count within the specified query time range.
        /// 1. License request count stats from the last 365 days can be queried.
        ///    2. The query time span should not exceed 90 days.
        /// 3. If the query time span exceeds 1 day, the data returned is at day granularity. Otherwise, the data returned is at 5-minute granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public DescribeLicenseUsageDataResponse DescribeLicenseUsageDataSync(DescribeLicenseUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeLicenseUsageDataResponse>(req, "DescribeLicenseUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain user-customized media processing service task templates.
        /// When querying the template list, fill in MPS-related parameters in MPSDescribeTemplateParams in JSON format. For task parameter configuration, refer to the MPS task template documentation.
        /// </summary>
        /// <param name="req"><see cref="DescribeMPSTemplatesRequest"/></param>
        /// <returns><see cref="DescribeMPSTemplatesResponse"/></returns>
        public Task<DescribeMPSTemplatesResponse> DescribeMPSTemplates(DescribeMPSTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeMPSTemplatesResponse>(req, "DescribeMPSTemplates");
        }

        /// <summary>
        /// This API is used to obtain user-customized media processing service task templates.
        /// When querying the template list, fill in MPS-related parameters in MPSDescribeTemplateParams in JSON format. For task parameter configuration, refer to the MPS task template documentation.
        /// </summary>
        /// <param name="req"><see cref="DescribeMPSTemplatesRequest"/></param>
        /// <returns><see cref="DescribeMPSTemplatesResponse"/></returns>
        public DescribeMPSTemplatesResponse DescribeMPSTemplatesSync(DescribeMPSTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeMPSTemplatesResponse>(req, "DescribeMPSTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. This API can obtain multiple types of info of multiple media files, including:
        /// 1. Basic information (basicInfo): including media name, categorization, playback address, cover image, and more.
        /// 2. Meta information (metaData): including size, duration, video stream information, and audio stream information.
        /// 3. Transcode result information (transcodeInfo): includes media addresses of various specifications generated by transcoding the media, video stream parameters, audio stream parameters, etc.
        /// 4. Animated graphics info (animatedGraphicsInfo): the animated graphics info after converting a video to gif (for example, gif).
        /// 5. sampleSnapshotInfo: sampling screenshot information.
        /// 6. Sprite image information (imageSpriteInfo): sprite image information after capturing sprite image files from a video.
        /// 7. snapshotByTimeOffsetInfo: screenshot information after taking screenshots of a video at specified time points.
        /// 8. Video timestamp information (keyFrameDescInfo): Dotting information set for a video.
        /// 9. Adaptive Bitrate Streaming information (adaptiveDynamicStreamingInfo): information including specification, encryption type, and packaging format.
        /// 10. Review information (reviewInfo): includes media moderation and media cover review information.
        /// 2. You can specify to only return partial information in the response.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public Task<DescribeMediaInfosResponse> DescribeMediaInfos(DescribeMediaInfosRequest req)
        {
            return InternalRequestAsync<DescribeMediaInfosResponse>(req, "DescribeMediaInfos");
        }

        /// <summary>
        /// 1. This API can obtain multiple types of info of multiple media files, including:
        /// 1. Basic information (basicInfo): including media name, categorization, playback address, cover image, and more.
        /// 2. Meta information (metaData): including size, duration, video stream information, and audio stream information.
        /// 3. Transcode result information (transcodeInfo): includes media addresses of various specifications generated by transcoding the media, video stream parameters, audio stream parameters, etc.
        /// 4. Animated graphics info (animatedGraphicsInfo): the animated graphics info after converting a video to gif (for example, gif).
        /// 5. sampleSnapshotInfo: sampling screenshot information.
        /// 6. Sprite image information (imageSpriteInfo): sprite image information after capturing sprite image files from a video.
        /// 7. snapshotByTimeOffsetInfo: screenshot information after taking screenshots of a video at specified time points.
        /// 8. Video timestamp information (keyFrameDescInfo): Dotting information set for a video.
        /// 9. Adaptive Bitrate Streaming information (adaptiveDynamicStreamingInfo): information including specification, encryption type, and packaging format.
        /// 10. Review information (reviewInfo): includes media moderation and media cover review information.
        /// 2. You can specify to only return partial information in the response.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public DescribeMediaInfosResponse DescribeMediaInfosSync(DescribeMediaInfosRequest req)
        {
            return InternalRequestAsync<DescribeMediaInfosResponse>(req, "DescribeMediaInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query playback data of media files by specified time granularity.
        /// * Playback statistics from the past one year can be queried.
        /// Time granularity: hour. The maximum span between start time and end time is 7 days.
        /// Time granularity: day. The maximum span between the end time and start time is 90 days.
        /// * Playback statistics only target VOD domains (distribution from EdgeOne domain names is not included in playback statistics).
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPlayStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeMediaPlayStatDetailsResponse"/></returns>
        public Task<DescribeMediaPlayStatDetailsResponse> DescribeMediaPlayStatDetails(DescribeMediaPlayStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMediaPlayStatDetailsResponse>(req, "DescribeMediaPlayStatDetails");
        }

        /// <summary>
        /// This API is used to query playback data of media files by specified time granularity.
        /// * Playback statistics from the past one year can be queried.
        /// Time granularity: hour. The maximum span between start time and end time is 7 days.
        /// Time granularity: day. The maximum span between the end time and start time is 90 days.
        /// * Playback statistics only target VOD domains (distribution from EdgeOne domain names is not included in playback statistics).
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPlayStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeMediaPlayStatDetailsResponse"/></returns>
        public DescribeMediaPlayStatDetailsResponse DescribeMediaPlayStatDetailsSync(DescribeMediaPlayStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMediaPlayStatDetailsResponse>(req, "DescribeMediaPlayStatDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the daily video processing usage information within the specified query time range.
        /// 1. Video processing usage data is retained in the data system for 13 months. You can query usage data from the most recent 365 days through the API. To call historical usage data beyond 365 days, contact us.
        ///    2. The query time span should not exceed 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public Task<DescribeMediaProcessUsageDataResponse> DescribeMediaProcessUsageData(DescribeMediaProcessUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaProcessUsageDataResponse>(req, "DescribeMediaProcessUsageData");
        }

        /// <summary>
        /// This API is used to return the daily video processing usage information within the specified query time range.
        /// 1. Video processing usage data is retained in the data system for 13 months. You can query usage data from the most recent 365 days through the API. To call historical usage data beyond 365 days, contact us.
        ///    2. The query time span should not exceed 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public DescribeMediaProcessUsageDataResponse DescribeMediaProcessUsageDataSync(DescribeMediaProcessUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaProcessUsageDataResponse>(req, "DescribeMediaProcessUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query material sample information by material ID, name, or tag with pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples");
        }

        /// <summary>
        /// This API is used to query material sample information by material ID, name, or tag with pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public DescribePersonSamplesResponse DescribePersonSamplesSync(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search the task flow template detail list based on the task flow template name.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public Task<DescribeProcedureTemplatesResponse> DescribeProcedureTemplates(DescribeProcedureTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcedureTemplatesResponse>(req, "DescribeProcedureTemplates");
        }

        /// <summary>
        /// This API is used to search the task flow template detail list based on the task flow template name.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public DescribeProcedureTemplatesResponse DescribeProcedureTemplatesSync(DescribeProcedureTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcedureTemplatesResponse>(req, "DescribeProcedureTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the template details list based on the template unique identifier. The returned results include all eligible user-customized image asynchronous processing templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessImageAsyncTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcessImageAsyncTemplatesResponse"/></returns>
        public Task<DescribeProcessImageAsyncTemplatesResponse> DescribeProcessImageAsyncTemplates(DescribeProcessImageAsyncTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcessImageAsyncTemplatesResponse>(req, "DescribeProcessImageAsyncTemplates");
        }

        /// <summary>
        /// This API is used to obtain the template details list based on the template unique identifier. The returned results include all eligible user-customized image asynchronous processing templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessImageAsyncTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcessImageAsyncTemplatesResponse"/></returns>
        public DescribeProcessImageAsyncTemplatesResponse DescribeProcessImageAsyncTemplatesSync(DescribeProcessImageAsyncTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcessImageAsyncTemplatesResponse>(req, "DescribeProcessImageAsyncTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the audio and video quality detection template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityInspectTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityInspectTemplatesResponse"/></returns>
        public Task<DescribeQualityInspectTemplatesResponse> DescribeQualityInspectTemplates(DescribeQualityInspectTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityInspectTemplatesResponse>(req, "DescribeQualityInspectTemplates");
        }

        /// <summary>
        /// This API is used to query the audio and video quality detection template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityInspectTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityInspectTemplatesResponse"/></returns>
        public DescribeQualityInspectTemplatesResponse DescribeQualityInspectTemplatesSync(DescribeQualityInspectTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityInspectTemplatesResponse>(req, "DescribeQualityInspectTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// Queries the video rebirth template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public Task<DescribeRebuildMediaTemplatesResponse> DescribeRebuildMediaTemplates(DescribeRebuildMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRebuildMediaTemplatesResponse>(req, "DescribeRebuildMediaTemplates");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// Queries the video rebirth template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public DescribeRebuildMediaTemplatesResponse DescribeRebuildMediaTemplatesSync(DescribeRebuildMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRebuildMediaTemplatesResponse>(req, "DescribeRebuildMediaTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <b>This API is not recommended. Use [DescribeMediaProcessUsageData](https://www.tencentcloud.com/document/product/266/41464?from_cn_redirect=1) as an alternative.</b>
        /// 
        /// This API is used to return the daily video content intelligent identification duration data within the specified query time range. Unit: seconds.
        /// 
        /// 1. Video content intelligent identification duration stats from the last 365 days can be queried.
        /// 2. The query time span should not exceed 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewDetailsRequest"/></param>
        /// <returns><see cref="DescribeReviewDetailsResponse"/></returns>
        public Task<DescribeReviewDetailsResponse> DescribeReviewDetails(DescribeReviewDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReviewDetailsResponse>(req, "DescribeReviewDetails");
        }

        /// <summary>
        /// <b>This API is not recommended. Use [DescribeMediaProcessUsageData](https://www.tencentcloud.com/document/product/266/41464?from_cn_redirect=1) as an alternative.</b>
        /// 
        /// This API is used to return the daily video content intelligent identification duration data within the specified query time range. Unit: seconds.
        /// 
        /// 1. Video content intelligent identification duration stats from the last 365 days can be queried.
        /// 2. The query time span should not exceed 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewDetailsRequest"/></param>
        /// <returns><see cref="DescribeReviewDetailsResponse"/></returns>
        public DescribeReviewDetailsResponse DescribeReviewDetailsSync(DescribeReviewDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReviewDetailsResponse>(req, "DescribeReviewDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the moderation template list.
        /// >Template is applicable only to the [audio/video moderation (ReviewAudioVideo)](https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and [image moderation (ReviewImage)](https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public Task<DescribeReviewTemplatesResponse> DescribeReviewTemplates(DescribeReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeReviewTemplatesResponse>(req, "DescribeReviewTemplates");
        }

        /// <summary>
        /// This API is used to query the moderation template list.
        /// >Template is applicable only to the [audio/video moderation (ReviewAudioVideo)](https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and [image moderation (ReviewImage)](https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public DescribeReviewTemplatesResponse DescribeReviewTemplatesSync(DescribeReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeReviewTemplatesResponse>(req, "DescribeReviewTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the carousel playlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public Task<DescribeRoundPlaysResponse> DescribeRoundPlays(DescribeRoundPlaysRequest req)
        {
            return InternalRequestAsync<DescribeRoundPlaysResponse>(req, "DescribeRoundPlays");
        }

        /// <summary>
        /// This API is used to get the carousel playlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public DescribeRoundPlaysResponse DescribeRoundPlaysSync(DescribeRoundPlaysRequest req)
        {
            return InternalRequestAsync<DescribeRoundPlaysResponse>(req, "DescribeRoundPlays")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sampled screenshot templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public Task<DescribeSampleSnapshotTemplatesResponse> DescribeSampleSnapshotTemplates(DescribeSampleSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSampleSnapshotTemplatesResponse>(req, "DescribeSampleSnapshotTemplates");
        }

        /// <summary>
        /// This API is used to query sampled screenshot templates based on conditions with paging.
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public DescribeSampleSnapshotTemplatesResponse DescribeSampleSnapshotTemplatesSync(DescribeSampleSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSampleSnapshotTemplatesResponse>(req, "DescribeSampleSnapshotTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries specified time point screenshot templates and supports paging query based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public Task<DescribeSnapshotByTimeOffsetTemplatesResponse> DescribeSnapshotByTimeOffsetTemplates(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotByTimeOffsetTemplatesResponse>(req, "DescribeSnapshotByTimeOffsetTemplates");
        }

        /// <summary>
        /// Queries specified time point screenshot templates and supports paging query based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public DescribeSnapshotByTimeOffsetTemplatesResponse DescribeSnapshotByTimeOffsetTemplatesSync(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotByTimeOffsetTemplatesResponse>(req, "DescribeSnapshotByTimeOffsetTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries storage space usage and number of files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public Task<DescribeStorageDataResponse> DescribeStorageData(DescribeStorageDataRequest req)
        {
            return InternalRequestAsync<DescribeStorageDataResponse>(req, "DescribeStorageData");
        }

        /// <summary>
        /// Queries storage space usage and number of files.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public DescribeStorageDataResponse DescribeStorageDataSync(DescribeStorageDataRequest req)
        {
            return InternalRequestAsync<DescribeStorageDataResponse>(req, "DescribeStorageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the VOD storage space used within a specified time range, in bytes.
        /// 1. Storage usage data is retained for 13 months in the data system. You can only query usage data from the most recent 365 days through the API. If you need to access historical usage data beyond 365 days, contact us;
        /// 2. The query time span should not exceed 90 days.
        /// 3. The query span at a minute granularity should not exceed 7 days;
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public Task<DescribeStorageDetailsResponse> DescribeStorageDetails(DescribeStorageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeStorageDetailsResponse>(req, "DescribeStorageDetails");
        }

        /// <summary>
        /// This API is used to return the VOD storage space used within a specified time range, in bytes.
        /// 1. Storage usage data is retained for 13 months in the data system. You can only query usage data from the most recent 365 days through the API. If you need to access historical usage data beyond 365 days, contact us;
        /// 2. The query time span should not exceed 90 days.
        /// 3. The query span at a minute granularity should not exceed 7 days;
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public DescribeStorageDetailsResponse DescribeStorageDetailsSync(DescribeStorageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeStorageDetailsResponse>(req, "DescribeStorageDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to:
        /// 1. Query the list of all storage campuses available for on-demand activation.
        /// 2. Query the list of opened parks.
        /// 3. Query the storage campus used by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRegionsRequest"/></param>
        /// <returns><see cref="DescribeStorageRegionsResponse"/></returns>
        public Task<DescribeStorageRegionsResponse> DescribeStorageRegions(DescribeStorageRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStorageRegionsResponse>(req, "DescribeStorageRegions");
        }

        /// <summary>
        /// This API is used to:
        /// 1. Query the list of all storage campuses available for on-demand activation.
        /// 2. Query the list of opened parks.
        /// 3. Query the storage campus used by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRegionsRequest"/></param>
        /// <returns><see cref="DescribeStorageRegionsResponse"/></returns>
        public DescribeStorageRegionsResponse DescribeStorageRegionsSync(DescribeStorageRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStorageRegionsResponse>(req, "DescribeStorageRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the application list of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public Task<DescribeSubAppIdsResponse> DescribeSubAppIds(DescribeSubAppIdsRequest req)
        {
            return InternalRequestAsync<DescribeSubAppIdsResponse>(req, "DescribeSubAppIds");
        }

        /// <summary>
        /// This API is used to get the application list of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public DescribeSubAppIdsResponse DescribeSubAppIdsSync(DescribeSubAppIdsRequest req)
        {
            return InternalRequestAsync<DescribeSubAppIdsResponse>(req, "DescribeSubAppIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// Queries player configurations and supports paging query based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public Task<DescribeSuperPlayerConfigsResponse> DescribeSuperPlayerConfigs(DescribeSuperPlayerConfigsRequest req)
        {
            return InternalRequestAsync<DescribeSuperPlayerConfigsResponse>(req, "DescribeSuperPlayerConfigs");
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// Queries player configurations and supports paging query based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public DescribeSuperPlayerConfigsResponse DescribeSuperPlayerConfigsSync(DescribeSuperPlayerConfigsRequest req)
        {
            return InternalRequestAsync<DescribeSuperPlayerConfigsResponse>(req, "DescribeSuperPlayerConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of the task execution status and results by task ID (tasks submitted within the last 3 days can be queried).
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// This API is used to query the details of the task execution status and results by task ID (tasks submitted within the last 3 days can be queried).
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * This API is used to query the task list.
        /// * When the list contains a large amount of data, a single API call cannot pull the entire list. You can use the ScrollToken parameter to pull in batches.
        /// * Only tasks from the last three days (72 hours) can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// * This API is used to query the task list.
        /// * When the list contains a large amount of data, a single API call cannot pull the entire list. You can use the ScrollToken parameter to pull in batches.
        /// * Only tasks from the last three days (72 hours) can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the transcoding template detail list based on the transcoding template unique identifier. The returned results include all eligible custom templates and [system preset transcoding templates](https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeTranscodeTemplatesResponse> DescribeTranscodeTemplates(DescribeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTemplatesResponse>(req, "DescribeTranscodeTemplates");
        }

        /// <summary>
        /// This API is used to retrieve the transcoding template detail list based on the transcoding template unique identifier. The returned results include all eligible custom templates and [system preset transcoding templates](https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public DescribeTranscodeTemplatesResponse DescribeTranscodeTemplatesSync(DescribeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTemplatesResponse>(req, "DescribeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of on-demand video domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public Task<DescribeVodDomainsResponse> DescribeVodDomains(DescribeVodDomainsRequest req)
        {
            return InternalRequestAsync<DescribeVodDomainsResponse>(req, "DescribeVodDomains");
        }

        /// <summary>
        /// This API is used to query the list of on-demand video domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public DescribeVodDomainsResponse DescribeVodDomainsSync(DescribeVodDomainsRequest req)
        {
            return InternalRequestAsync<DescribeVodDomainsResponse>(req, "DescribeVodDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the available timbre list under the current account. It supports filtering by optional conditions such as voice ID, kind, name, gender, age, language, tag, and scenario.
        /// 
        /// Note: Newly designed or cloned voice types cannot be queried before activation. They are activated only after the newly created voice type is used for TTS once.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoicesRequest"/></param>
        /// <returns><see cref="DescribeVoicesResponse"/></returns>
        public Task<DescribeVoicesResponse> DescribeVoices(DescribeVoicesRequest req)
        {
            return InternalRequestAsync<DescribeVoicesResponse>(req, "DescribeVoices");
        }

        /// <summary>
        /// Query the available timbre list under the current account. It supports filtering by optional conditions such as voice ID, kind, name, gender, age, language, tag, and scenario.
        /// 
        /// Note: Newly designed or cloned voice types cannot be queried before activation. They are activated only after the newly created voice type is used for TTS once.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoicesRequest"/></param>
        /// <returns><see cref="DescribeVoicesResponse"/></returns>
        public DescribeVoicesResponse DescribeVoicesSync(DescribeVoicesRequest req)
        {
            return InternalRequestAsync<DescribeVoicesResponse>(req, "DescribeVoices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user-defined watermark templates, and paging query is supported based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public Task<DescribeWatermarkTemplatesResponse> DescribeWatermarkTemplates(DescribeWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWatermarkTemplatesResponse>(req, "DescribeWatermarkTemplates");
        }

        /// <summary>
        /// This API is used to query user-defined watermark templates, and paging query is supported based on conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public DescribeWatermarkTemplatesResponse DescribeWatermarkTemplatesSync(DescribeWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWatermarkTemplatesResponse>(req, "DescribeWatermarkTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to paginate keyword sample information by scenario, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples");
        }

        /// <summary>
        /// This API is used to paginate keyword sample information by scenario, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public DescribeWordSamplesResponse DescribeWordSamplesSync(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate a voice design task. It generates a custom voice based on a natural language description. You can also specify a voice profile, such as name, gender, age, language, tag, and scenario. If trial text is attached upon submission, an audio audition is generated after task completion. Voice design is an asynchronous task, and the voice ID is generated after task completion.
        /// </summary>
        /// <param name="req"><see cref="DesignVoiceAsyncRequest"/></param>
        /// <returns><see cref="DesignVoiceAsyncResponse"/></returns>
        public Task<DesignVoiceAsyncResponse> DesignVoiceAsync(DesignVoiceAsyncRequest req)
        {
            return InternalRequestAsync<DesignVoiceAsyncResponse>(req, "DesignVoiceAsync");
        }

        /// <summary>
        /// This API is used to initiate a voice design task. It generates a custom voice based on a natural language description. You can also specify a voice profile, such as name, gender, age, language, tag, and scenario. If trial text is attached upon submission, an audio audition is generated after task completion. Voice design is an asynchronous task, and the voice ID is generated after task completion.
        /// </summary>
        /// <param name="req"><see cref="DesignVoiceAsyncRequest"/></param>
        /// <returns><see cref="DesignVoiceAsyncResponse"/></returns>
        public DesignVoiceAsyncResponse DesignVoiceAsyncSync(DesignVoiceAsyncRequest req)
        {
            return InternalRequestAsync<DesignVoiceAsyncResponse>(req, "DesignVoiceAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a video, such as clipping and concatenation, to generate a new on-demand video. Editing features include:
        /// 
        /// 1) Edit a file in on-demand playback to generate a new video.
        /// 2) Splice multiple on-demand files to generate a new video.
        /// 3) Edit multiple on-demand video files and then splice them to generate a new video;
        /// 4. Directly generate a new video for one stream in VOD;
        /// 5. Edit one stream in VOD to generate a new video;
        /// 6) Splice multiple on-demand streams to generate a new video.
        /// 7) Edit multiple streams in VOD and then splice them to generate a new video.
        /// 
        /// For the generated new video, you can also specify whether to execute task flow for the generated video.
        /// 
        /// When editing or splicing a live stream, please ensure the stream ended before you operate. Otherwise, the generated video may be incomplete.
        /// 
        /// If event notification is used, its type is [video editing completed](https://www.tencentcloud.com/document/product/266/33794?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public Task<EditMediaResponse> EditMedia(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia");
        }

        /// <summary>
        /// This API is used to edit a video, such as clipping and concatenation, to generate a new on-demand video. Editing features include:
        /// 
        /// 1) Edit a file in on-demand playback to generate a new video.
        /// 2) Splice multiple on-demand files to generate a new video.
        /// 3) Edit multiple on-demand video files and then splice them to generate a new video;
        /// 4. Directly generate a new video for one stream in VOD;
        /// 5. Edit one stream in VOD to generate a new video;
        /// 6) Splice multiple on-demand streams to generate a new video.
        /// 7) Edit multiple streams in VOD and then splice them to generate a new video.
        /// 
        /// For the generated new video, you can also specify whether to execute task flow for the generated video.
        /// 
        /// When editing or splicing a live stream, please ensure the stream ended before you operate. Otherwise, the generated video may be incomplete.
        /// 
        /// If event notification is used, its type is [video editing completed](https://www.tencentcloud.com/document/product/266/33794?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public EditMediaResponse EditMediaSync(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. Please use the new version of APIs [audio and video quality revival](https://www.tencentcloud.com/document/api/266/102571?from_cn_redirect=1).
        /// Use a template to initiate audio and video quality revival.
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaByTemplateRequest"/></param>
        /// <returns><see cref="EnhanceMediaByTemplateResponse"/></returns>
        public Task<EnhanceMediaByTemplateResponse> EnhanceMediaByTemplate(EnhanceMediaByTemplateRequest req)
        {
            return InternalRequestAsync<EnhanceMediaByTemplateResponse>(req, "EnhanceMediaByTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. Please use the new version of APIs [audio and video quality revival](https://www.tencentcloud.com/document/api/266/102571?from_cn_redirect=1).
        /// Use a template to initiate audio and video quality revival.
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaByTemplateRequest"/></param>
        /// <returns><see cref="EnhanceMediaByTemplateResponse"/></returns>
        public EnhanceMediaByTemplateResponse EnhanceMediaByTemplateSync(EnhanceMediaByTemplateRequest req)
        {
            return InternalRequestAsync<EnhanceMediaByTemplateResponse>(req, "EnhanceMediaByTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate an audio and video quality regeneration task for on-demand audio-video media.
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaQualityRequest"/></param>
        /// <returns><see cref="EnhanceMediaQualityResponse"/></returns>
        public Task<EnhanceMediaQualityResponse> EnhanceMediaQuality(EnhanceMediaQualityRequest req)
        {
            return InternalRequestAsync<EnhanceMediaQualityResponse>(req, "EnhanceMediaQuality");
        }

        /// <summary>
        /// This API is used to initiate an audio and video quality regeneration task for on-demand audio-video media.
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaQualityRequest"/></param>
        /// <returns><see cref="EnhanceMediaQualityResponse"/></returns>
        public EnhanceMediaQualityResponse EnhanceMediaQualitySync(EnhanceMediaQualityRequest req)
        {
            return InternalRequestAsync<EnhanceMediaQualityResponse>(req, "EnhanceMediaQuality")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is only used for special scenarios of customized development. Do not call this API unless VOD customer service proactively informs you to use it.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction");
        }

        /// <summary>
        /// This API is only used for special scenarios of customized development. Do not call this API unless VOD customer service proactively informs you to use it.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate a digital watermark extraction task for a video. The extraction result can be queried through DescribeTaskDetail.
        /// </summary>
        /// <param name="req"><see cref="ExtractBlindWatermarkRequest"/></param>
        /// <returns><see cref="ExtractBlindWatermarkResponse"/></returns>
        public Task<ExtractBlindWatermarkResponse> ExtractBlindWatermark(ExtractBlindWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractBlindWatermarkResponse>(req, "ExtractBlindWatermark");
        }

        /// <summary>
        /// This API is used to initiate a digital watermark extraction task for a video. The extraction result can be queried through DescribeTaskDetail.
        /// </summary>
        /// <param name="req"><see cref="ExtractBlindWatermarkRequest"/></param>
        /// <returns><see cref="ExtractBlindWatermarkResponse"/></returns>
        public ExtractBlindWatermarkResponse ExtractBlindWatermarkSync(ExtractBlindWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractBlindWatermarkResponse>(req, "ExtractBlindWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// If you need source tracing for piracy, see Ghost Watermark (https://www.tencentcloud.com/document/product/266/94228?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ExtractCopyRightWatermarkRequest"/></param>
        /// <returns><see cref="ExtractCopyRightWatermarkResponse"/></returns>
        public Task<ExtractCopyRightWatermarkResponse> ExtractCopyRightWatermark(ExtractCopyRightWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractCopyRightWatermarkResponse>(req, "ExtractCopyRightWatermark");
        }

        /// <summary>
        /// If you need source tracing for piracy, see Ghost Watermark (https://www.tencentcloud.com/document/product/266/94228?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ExtractCopyRightWatermarkRequest"/></param>
        /// <returns><see cref="ExtractCopyRightWatermarkResponse"/></returns>
        public ExtractCopyRightWatermarkResponse ExtractCopyRightWatermarkSync(ExtractCopyRightWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractCopyRightWatermarkResponse>(req, "ExtractCopyRightWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// If source tracing for piracy is required, ghost watermark is recommended for use (https://www.tencentcloud.com/document/product/266/94228?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public Task<ExtractTraceWatermarkResponse> ExtractTraceWatermark(ExtractTraceWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractTraceWatermarkResponse>(req, "ExtractTraceWatermark");
        }

        /// <summary>
        /// If source tracing for piracy is required, ghost watermark is recommended for use (https://www.tencentcloud.com/document/product/266/94228?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public ExtractTraceWatermarkResponse ExtractTraceWatermarkSync(ExtractTraceWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractTraceWatermarkResponse>(req, "ExtractTraceWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Quickly splice and edit HLS videos in VOD to generate new media in HLS format.
        /// 
        /// Quickly splice or edit the generated video to create a new FileId and solidify it. After successful solidification, the new video file exists independently of the original input video and is not affected by deletion of the original video.
        /// 
        /// <font color='red'>Note:</font> Enable reception of editing solidification event notifications through the ModifyEventConfig API. After successful solidification, you will receive a PersistenceComplete event notification. Before receiving this event notification, you should not delete or transition the original input video to colder storage. Otherwise, playback of the video generated by splicing and clipping may be abnormal.
        /// </summary>
        /// <param name="req"><see cref="FastEditMediaRequest"/></param>
        /// <returns><see cref="FastEditMediaResponse"/></returns>
        public Task<FastEditMediaResponse> FastEditMedia(FastEditMediaRequest req)
        {
            return InternalRequestAsync<FastEditMediaResponse>(req, "FastEditMedia");
        }

        /// <summary>
        /// Quickly splice and edit HLS videos in VOD to generate new media in HLS format.
        /// 
        /// Quickly splice or edit the generated video to create a new FileId and solidify it. After successful solidification, the new video file exists independently of the original input video and is not affected by deletion of the original video.
        /// 
        /// <font color='red'>Note:</font> Enable reception of editing solidification event notifications through the ModifyEventConfig API. After successful solidification, you will receive a PersistenceComplete event notification. Before receiving this event notification, you should not delete or transition the original input video to colder storage. Otherwise, playback of the video generated by splicing and clipping may be abnormal.
        /// </summary>
        /// <param name="req"><see cref="FastEditMediaRequest"/></param>
        /// <returns><see cref="FastEditMediaResponse"/></returns>
        public FastEditMediaResponse FastEditMediaSync(FastEditMediaRequest req)
        {
            return InternalRequestAsync<FastEditMediaResponse>(req, "FastEditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * After media blocking, except for VOD console preview, accessing URLs of various video resources (original files, transcoding output files, screenshots, etc.) for other scenarios will return 403.
        /// It takes about 5 to 10 minutes for the block or unblock operation to take effect across the entire network.
        /// * Note: Media blocking can only be performed on media stored in standard storage and infrequent storage. Media stored in infrequent storage must be stored for at least 30 days. If it is deleted early or its storage class is changed, it will still be billed for 30 days. If media stored in infrequent storage is blocked and its infrequent storage duration is less than 30 days, early deletion billing will occur. In addition, after blocking, the infrequent storage duration of the media will restart from the current time. If the media is deleted or its storage class is changed before reaching 30 days, early deletion billing will also occur. For example, media 001 has been stored in infrequent storage for 10 days. If 001 is blocked at this point, infrequent storage billing is still calculated based on 30 days (early deletion billing duration: 30 - 10 = 20 days). After blocking, the infrequent storage duration of 001 restarts. If 001 is deleted on the 5th day after blocking, infrequent storage billing is also calculated based on 30 days (early deletion billing duration: 30 - 5 = 25 days). The actual infrequent storage duration of 001 is 10 + 5 = 15 days, while the infrequent storage billing duration is 10 + 20 (early deletion billing) + 5 + 25 (early deletion billing) = 60 days.
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public Task<ForbidMediaDistributionResponse> ForbidMediaDistribution(ForbidMediaDistributionRequest req)
        {
            return InternalRequestAsync<ForbidMediaDistributionResponse>(req, "ForbidMediaDistribution");
        }

        /// <summary>
        /// * After media blocking, except for VOD console preview, accessing URLs of various video resources (original files, transcoding output files, screenshots, etc.) for other scenarios will return 403.
        /// It takes about 5 to 10 minutes for the block or unblock operation to take effect across the entire network.
        /// * Note: Media blocking can only be performed on media stored in standard storage and infrequent storage. Media stored in infrequent storage must be stored for at least 30 days. If it is deleted early or its storage class is changed, it will still be billed for 30 days. If media stored in infrequent storage is blocked and its infrequent storage duration is less than 30 days, early deletion billing will occur. In addition, after blocking, the infrequent storage duration of the media will restart from the current time. If the media is deleted or its storage class is changed before reaching 30 days, early deletion billing will also occur. For example, media 001 has been stored in infrequent storage for 10 days. If 001 is blocked at this point, infrequent storage billing is still calculated based on 30 days (early deletion billing duration: 30 - 10 = 20 days). After blocking, the infrequent storage duration of 001 restarts. If 001 is deleted on the 5th day after blocking, infrequent storage billing is also calculated based on 30 days (early deletion billing duration: 30 - 5 = 25 days). The actual infrequent storage duration of 001 is 10 + 5 = 15 days, while the infrequent storage billing duration is 10 + 20 (early deletion billing) + 5 + 25 (early deletion billing) = 60 days.
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public ForbidMediaDistributionResponse ForbidMediaDistributionSync(ForbidMediaDistributionRequest req)
        {
            return InternalRequestAsync<ForbidMediaDistributionResponse>(req, "ForbidMediaDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Manipulate the carousel current playlist. Supported operations: <li> Insert: Insert a program into the current playlist.</li><li> Delete: Delete a program from the playlist.</li>
        /// </summary>
        /// <param name="req"><see cref="HandleCurrentPlaylistRequest"/></param>
        /// <returns><see cref="HandleCurrentPlaylistResponse"/></returns>
        public Task<HandleCurrentPlaylistResponse> HandleCurrentPlaylist(HandleCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<HandleCurrentPlaylistResponse>(req, "HandleCurrentPlaylist");
        }

        /// <summary>
        /// Manipulate the carousel current playlist. Supported operations: <li> Insert: Insert a program into the current playlist.</li><li> Delete: Delete a program from the playlist.</li>
        /// </summary>
        /// <param name="req"><see cref="HandleCurrentPlaylistRequest"/></param>
        /// <returns><see cref="HandleCurrentPlaylistResponse"/></returns>
        public HandleCurrentPlaylistResponse HandleCurrentPlaylistSync(HandleCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<HandleCurrentPlaylistResponse>(req, "HandleCurrentPlaylist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to import AI analysis results into the knowledge base.
        /// </summary>
        /// <param name="req"><see cref="ImportMediaKnowledgeRequest"/></param>
        /// <returns><see cref="ImportMediaKnowledgeResponse"/></returns>
        public Task<ImportMediaKnowledgeResponse> ImportMediaKnowledge(ImportMediaKnowledgeRequest req)
        {
            return InternalRequestAsync<ImportMediaKnowledgeResponse>(req, "ImportMediaKnowledge");
        }

        /// <summary>
        /// Used to import AI analysis results into the knowledge base.
        /// </summary>
        /// <param name="req"><see cref="ImportMediaKnowledgeRequest"/></param>
        /// <returns><see cref="ImportMediaKnowledgeResponse"/></returns>
        public ImportMediaKnowledgeResponse ImportMediaKnowledgeSync(ImportMediaKnowledgeRequest req)
        {
            return InternalRequestAsync<ImportMediaKnowledgeResponse>(req, "ImportMediaKnowledge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate an audio and video quality inspection task for on-demand audio-video media.
        /// </summary>
        /// <param name="req"><see cref="InspectMediaQualityRequest"/></param>
        /// <returns><see cref="InspectMediaQualityResponse"/></returns>
        public Task<InspectMediaQualityResponse> InspectMediaQuality(InspectMediaQualityRequest req)
        {
            return InternalRequestAsync<InspectMediaQualityResponse>(req, "InspectMediaQuality");
        }

        /// <summary>
        /// This API is used to initiate an audio and video quality inspection task for on-demand audio-video media.
        /// </summary>
        /// <param name="req"><see cref="InspectMediaQualityRequest"/></param>
        /// <returns><see cref="InspectMediaQualityResponse"/></returns>
        public InspectMediaQualityResponse InspectMediaQualitySync(InspectMediaQualityRequest req)
        {
            return InternalRequestAsync<InspectMediaQualityResponse>(req, "InspectMediaQuality")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list stored file entries under a sub-application.
        /// 
        /// **This API is only available in "FileID+Path mode"**
        /// </summary>
        /// <param name="req"><see cref="ListFilesRequest"/></param>
        /// <returns><see cref="ListFilesResponse"/></returns>
        public Task<ListFilesResponse> ListFiles(ListFilesRequest req)
        {
            return InternalRequestAsync<ListFilesResponse>(req, "ListFiles");
        }

        /// <summary>
        /// This API is used to list stored file entries under a sub-application.
        /// 
        /// **This API is only available in "FileID+Path mode"**
        /// </summary>
        /// <param name="req"><see cref="ListFilesRequest"/></param>
        /// <returns><see cref="ListFilesResponse"/></returns>
        public ListFilesResponse ListFilesSync(ListFilesRequest req)
        {
            return InternalRequestAsync<ListFilesResponse>(req, "ListFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Live stream clipping refers to the ability for customers to select a segment from the live stream content during live streaming (that is, before the live stream has ended), and generate a new video in HLS format in real time. Developers can share it immediately or save it for long-term preservation.
        /// 
        /// Tencent Cloud VOD supports two real-time clipping modes:
        /// - Edit and save: Save the edited video as a standalone video with an independent FileId. This is suitable for long-term preservation of highlights.
        /// - Editing is not solidified: The edited video is attached to the live streaming recording file and has no standalone FileId. This is suitable for scenarios where highlights are shared temporarily.
        /// 
        /// Note:
        /// - The premise for using the live stream clipping feature is that the target live stream has the time shifting and playback (https://www.tencentcloud.com/document/product/267/32742?from_cn_redirect=1) feature enabled.
        /// -Live streaming Instant Editing is based on the m3u8 file generated by live recording, so its minimum editing precision is one ts slice. Second-level or more precise editing precision cannot be achieved.
        /// -Since stream disconnection may occur during live streaming, the actual video duration generated by editing may differ from the expected duration. For example, if you edit a live stream from 2018-09-20T10:30:00Z to 2018-09-20T10:40:00Z, and stream disconnection occurred during this time interval, the returned media file duration will be less than 10 minutes. In such cases, you can perceive it through the output parameter <a href="#p_segmentset">SegmentSet</a>.
        /// 
        /// ### Edit solidification
        /// Clipping persistence refers to saving an edited video as an independent video with its own FileId. Its lifecycle is not subject to any impact from the original live recorded video. Even if the original recorded video is deleted, the clipping result is not affected. You can also transcode it or publish it on WeChat for secondary processing.
        /// 
        /// For example, a complete football match live recording may produce raw video lasting for over 2 hours. For cost savings, a customer can store this video for 2 months, but can specify longer storage for highlight videos from live stream clipping. You can also perform additional on-demand operations on highlight videos separately, such as transcoding and publishing on WeChat. In this case, you can choose a live stream clipping and persistent solution.
        /// 
        /// The advantage of solidified editing is that its lifecycle is independent of the original recorded video, allowing for separate management and long-term preservation.
        /// 
        /// <font color='red'>Note:</font> If solidification is specified when editing, enable reception of editing solidification event notifications through the ModifyEventConfig API. After successful solidification, you will receive a PersistenceComplete event notification. Before receiving this event notification, you should not delete or transition the live video recording to colder storage. Otherwise, playback of the generated video may be abnormal.
        /// 
        /// ### Editing is not solidified
        /// So-called non-solidified editing means that the result of editing (m3u8 file) shares the same TS segments with the live video recording. The newly generated video is not an independent and complete video (no standalone FileId, only a playback URL), and its valid period is consistent with that of the full live recording video. Once the live recording video is deleted, the clip will also become unplayable.
        /// 
        /// Editing is not solidified. Since the clipping result is not an independent video, it is not included in video management of on-demand media assets (for example, the total number of videos in the console does not count this clip), and no video processing operation such as transcoding or publishing on WeChat can be performed against this clip separately.
        /// 
        /// The advantage of non-solidified editing is that the editing operation is relatively "lightweight" and will not generate additional storage overhead. However, its shortcoming is that the lifecycle is identical to the original recorded video, and it is unable to further transcode or perform other video processing.
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public Task<LiveRealTimeClipResponse> LiveRealTimeClip(LiveRealTimeClipRequest req)
        {
            return InternalRequestAsync<LiveRealTimeClipResponse>(req, "LiveRealTimeClip");
        }

        /// <summary>
        /// Live stream clipping refers to the ability for customers to select a segment from the live stream content during live streaming (that is, before the live stream has ended), and generate a new video in HLS format in real time. Developers can share it immediately or save it for long-term preservation.
        /// 
        /// Tencent Cloud VOD supports two real-time clipping modes:
        /// - Edit and save: Save the edited video as a standalone video with an independent FileId. This is suitable for long-term preservation of highlights.
        /// - Editing is not solidified: The edited video is attached to the live streaming recording file and has no standalone FileId. This is suitable for scenarios where highlights are shared temporarily.
        /// 
        /// Note:
        /// - The premise for using the live stream clipping feature is that the target live stream has the time shifting and playback (https://www.tencentcloud.com/document/product/267/32742?from_cn_redirect=1) feature enabled.
        /// -Live streaming Instant Editing is based on the m3u8 file generated by live recording, so its minimum editing precision is one ts slice. Second-level or more precise editing precision cannot be achieved.
        /// -Since stream disconnection may occur during live streaming, the actual video duration generated by editing may differ from the expected duration. For example, if you edit a live stream from 2018-09-20T10:30:00Z to 2018-09-20T10:40:00Z, and stream disconnection occurred during this time interval, the returned media file duration will be less than 10 minutes. In such cases, you can perceive it through the output parameter <a href="#p_segmentset">SegmentSet</a>.
        /// 
        /// ### Edit solidification
        /// Clipping persistence refers to saving an edited video as an independent video with its own FileId. Its lifecycle is not subject to any impact from the original live recorded video. Even if the original recorded video is deleted, the clipping result is not affected. You can also transcode it or publish it on WeChat for secondary processing.
        /// 
        /// For example, a complete football match live recording may produce raw video lasting for over 2 hours. For cost savings, a customer can store this video for 2 months, but can specify longer storage for highlight videos from live stream clipping. You can also perform additional on-demand operations on highlight videos separately, such as transcoding and publishing on WeChat. In this case, you can choose a live stream clipping and persistent solution.
        /// 
        /// The advantage of solidified editing is that its lifecycle is independent of the original recorded video, allowing for separate management and long-term preservation.
        /// 
        /// <font color='red'>Note:</font> If solidification is specified when editing, enable reception of editing solidification event notifications through the ModifyEventConfig API. After successful solidification, you will receive a PersistenceComplete event notification. Before receiving this event notification, you should not delete or transition the live video recording to colder storage. Otherwise, playback of the generated video may be abnormal.
        /// 
        /// ### Editing is not solidified
        /// So-called non-solidified editing means that the result of editing (m3u8 file) shares the same TS segments with the live video recording. The newly generated video is not an independent and complete video (no standalone FileId, only a playback URL), and its valid period is consistent with that of the full live recording video. Once the live recording video is deleted, the clip will also become unplayable.
        /// 
        /// Editing is not solidified. Since the clipping result is not an independent video, it is not included in video management of on-demand media assets (for example, the total number of videos in the console does not count this clip), and no video processing operation such as transcoding or publishing on WeChat can be performed against this clip separately.
        /// 
        /// The advantage of non-solidified editing is that the editing operation is relatively "lightweight" and will not generate additional storage overhead. However, its shortcoming is that the lifecycle is identical to the original recorded video, and it is unable to further transcode or perform other video processing.
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public LiveRealTimeClipResponse LiveRealTimeClipSync(LiveRealTimeClipRequest req)
        {
            return InternalRequestAsync<LiveRealTimeClipResponse>(req, "LiveRealTimeClip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Manage initiated tasks.
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public Task<ManageTaskResponse> ManageTask(ManageTaskRequest req)
        {
            return InternalRequestAsync<ManageTaskResponse>(req, "ManageTask");
        }

        /// <summary>
        /// Manage initiated tasks.
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public ManageTaskResponse ManageTaskSync(ManageTaskRequest req)
        {
            return InternalRequestAsync<ManageTaskResponse>(req, "ManageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a user-defined audio and video content analysis template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public Task<ModifyAIAnalysisTemplateResponse> ModifyAIAnalysisTemplate(ModifyAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIAnalysisTemplateResponse>(req, "ModifyAIAnalysisTemplate");
        }

        /// <summary>
        /// This API is used to modify a user-defined audio and video content analysis template.
        /// 
        /// Note: Templates with IDs below 10000 are system-preset templates and cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public ModifyAIAnalysisTemplateResponse ModifyAIAnalysisTemplateSync(ModifyAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIAnalysisTemplateResponse>(req, "ModifyAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a user-defined audio and video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to modify a user-defined audio and video content recognition template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public ModifyAIRecognitionTemplateResponse ModifyAIRecognitionTemplateSync(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifying an Adaptive Bitrate Streaming Template
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<ModifyAdaptiveDynamicStreamingTemplateResponse> ModifyAdaptiveDynamicStreamingTemplate(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAdaptiveDynamicStreamingTemplateResponse>(req, "ModifyAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// Modifying an Adaptive Bitrate Streaming Template
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public ModifyAdaptiveDynamicStreamingTemplateResponse ModifyAdaptiveDynamicStreamingTemplateSync(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAdaptiveDynamicStreamingTemplateResponse>(req, "ModifyAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to edit AIGC quota configuration. Quota usage starts accumulating when the quota feature is enabled. Once the quota is reached, AIGC features will no longer be usable.
        /// 
        /// Since AGC content generation is an async task, real-time usage data cannot be obtained. Therefore, quota limits result in some errors, and complete precise control with the set limit cannot be achieved.
        /// </summary>
        /// <param name="req"><see cref="ModifyAigcQuotaRequest"/></param>
        /// <returns><see cref="ModifyAigcQuotaResponse"/></returns>
        public Task<ModifyAigcQuotaResponse> ModifyAigcQuota(ModifyAigcQuotaRequest req)
        {
            return InternalRequestAsync<ModifyAigcQuotaResponse>(req, "ModifyAigcQuota");
        }

        /// <summary>
        /// Used to edit AIGC quota configuration. Quota usage starts accumulating when the quota feature is enabled. Once the quota is reached, AIGC features will no longer be usable.
        /// 
        /// Since AGC content generation is an async task, real-time usage data cannot be obtained. Therefore, quota limits result in some errors, and complete precise control with the set limit cannot be achieved.
        /// </summary>
        /// <param name="req"><see cref="ModifyAigcQuotaRequest"/></param>
        /// <returns><see cref="ModifyAigcQuotaResponse"/></returns>
        public ModifyAigcQuotaResponse ModifyAigcQuotaSync(ModifyAigcQuotaRequest req)
        {
            return InternalRequestAsync<ModifyAigcQuotaResponse>(req, "ModifyAigcQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public Task<ModifyAnimatedGraphicsTemplateResponse> ModifyAnimatedGraphicsTemplate(ModifyAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAnimatedGraphicsTemplateResponse>(req, "ModifyAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// Modify a custom animated image generating template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public ModifyAnimatedGraphicsTemplateResponse ModifyAnimatedGraphicsTemplateSync(ModifyAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAnimatedGraphicsTemplateResponse>(req, "ModifyAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a user-defined digital watermark template. The digital watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlindWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyBlindWatermarkTemplateResponse"/></returns>
        public Task<ModifyBlindWatermarkTemplateResponse> ModifyBlindWatermarkTemplate(ModifyBlindWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyBlindWatermarkTemplateResponse>(req, "ModifyBlindWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to modify a user-defined digital watermark template. The digital watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlindWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyBlindWatermarkTemplateResponse"/></returns>
        public ModifyBlindWatermarkTemplateResponse ModifyBlindWatermarkTemplateSync(ModifyBlindWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyBlindWatermarkTemplateResponse>(req, "ModifyBlindWatermarkTemplate")
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
        /// Modify media classification attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public Task<ModifyClassResponse> ModifyClass(ModifyClassRequest req)
        {
            return InternalRequestAsync<ModifyClassResponse>(req, "ModifyClass");
        }

        /// <summary>
        /// Modify media classification attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public ModifyClassResponse ModifyClassSync(ModifyClassRequest req)
        {
            return InternalRequestAsync<ModifyClassResponse>(req, "ModifyClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of moderation template supports audio/video moderation and image moderation. For details, please see [Modify Moderation Template](https://www.tencentcloud.com/document/api/266/84388?from_cn_redirect=1).
        /// Modify a user-customized audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of moderation template supports audio/video moderation and image moderation. For details, please see [Modify Moderation Template](https://www.tencentcloud.com/document/api/266/84388?from_cn_redirect=1).
        /// Modify a user-customized audio/video moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the default distribution configuration.
        /// * Distribution domain name and distribution protocol, i.e., the domain name and protocol in the media file distribution URL. Media files are distributed based on the default distribution configuration.
        /// Playback key, used to calculate player signature.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="ModifyDefaultDistributionConfigResponse"/></returns>
        public Task<ModifyDefaultDistributionConfigResponse> ModifyDefaultDistributionConfig(ModifyDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<ModifyDefaultDistributionConfigResponse>(req, "ModifyDefaultDistributionConfig");
        }

        /// <summary>
        /// This API is used to modify the default distribution configuration.
        /// * Distribution domain name and distribution protocol, i.e., the domain name and protocol in the media file distribution URL. Media files are distributed based on the default distribution configuration.
        /// Playback key, used to calculate player signature.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="ModifyDefaultDistributionConfigResponse"/></returns>
        public ModifyDefaultDistributionConfigResponse ModifyDefaultDistributionConfigSync(ModifyDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<ModifyDefaultDistributionConfigResponse>(req, "ModifyDefaultDistributionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the default storage region. If no region is specified during file upload, files will be uploaded to the default region.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public Task<ModifyDefaultStorageRegionResponse> ModifyDefaultStorageRegion(ModifyDefaultStorageRegionRequest req)
        {
            return InternalRequestAsync<ModifyDefaultStorageRegionResponse>(req, "ModifyDefaultStorageRegion");
        }

        /// <summary>
        /// This API is used to set the default storage region. If no region is specified during file upload, files will be uploaded to the default region.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public ModifyDefaultStorageRegionResponse ModifyDefaultStorageRegionSync(ModifyDefaultStorageRegionRequest req)
        {
            return InternalRequestAsync<ModifyDefaultStorageRegionResponse>(req, "ModifyDefaultStorageRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is no longer maintained. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// Modify an audio and video quality rebirth template.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyEnhanceMediaTemplateResponse"/></returns>
        public Task<ModifyEnhanceMediaTemplateResponse> ModifyEnhanceMediaTemplate(ModifyEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyEnhanceMediaTemplateResponse>(req, "ModifyEnhanceMediaTemplate");
        }

        /// <summary>
        /// This API is no longer maintained. The new version of the [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) API uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// Modify an audio and video quality rebirth template.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyEnhanceMediaTemplateResponse"/></returns>
        public ModifyEnhanceMediaTemplateResponse ModifyEnhanceMediaTemplateSync(ModifyEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyEnhanceMediaTemplateResponse>(req, "ModifyEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tencent Cloud VOD provides customers with media upload, media management, media processing, and other services. During or after the execution of these services, Tencent Cloud VOD also offers various corresponding event notifications, allowing developers to detect the service processing status and perform the next business operation.
        /// 
        /// Developers can call this interface to:
        /// - Set the type for receiving callback notifications. Currently, there are two types: [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1) and [reliable notification based on message queue](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1).
        /// - For [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1), you can set the address for 3.0 format callback. For 3.0 format callback details, see [historical format callback](https://www.tencentcloud.com/document/product/266/33796?from_cn_redirect=1).
        /// -Select to receive or ignore notification events for a specific event service.
        /// </summary>
        /// <param name="req"><see cref="ModifyEventConfigRequest"/></param>
        /// <returns><see cref="ModifyEventConfigResponse"/></returns>
        public Task<ModifyEventConfigResponse> ModifyEventConfig(ModifyEventConfigRequest req)
        {
            return InternalRequestAsync<ModifyEventConfigResponse>(req, "ModifyEventConfig");
        }

        /// <summary>
        /// Tencent Cloud VOD provides customers with media upload, media management, media processing, and other services. During or after the execution of these services, Tencent Cloud VOD also offers various corresponding event notifications, allowing developers to detect the service processing status and perform the next business operation.
        /// 
        /// Developers can call this interface to:
        /// - Set the type for receiving callback notifications. Currently, there are two types: [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1) and [reliable notification based on message queue](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1).
        /// - For [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1), you can set the address for 3.0 format callback. For 3.0 format callback details, see [historical format callback](https://www.tencentcloud.com/document/product/266/33796?from_cn_redirect=1).
        /// -Select to receive or ignore notification events for a specific event service.
        /// </summary>
        /// <param name="req"><see cref="ModifyEventConfigRequest"/></param>
        /// <returns><see cref="ModifyEventConfigResponse"/></returns>
        public ModifyEventConfigResponse ModifyEventConfigSync(ModifyEventConfigRequest req)
        {
            return InternalRequestAsync<ModifyEventConfigResponse>(req, "ModifyEventConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a title and trailer template.
        /// </summary>
        /// <param name="req"><see cref="ModifyHeadTailTemplateRequest"/></param>
        /// <returns><see cref="ModifyHeadTailTemplateResponse"/></returns>
        public Task<ModifyHeadTailTemplateResponse> ModifyHeadTailTemplate(ModifyHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHeadTailTemplateResponse>(req, "ModifyHeadTailTemplate");
        }

        /// <summary>
        /// Modify a title and trailer template.
        /// </summary>
        /// <param name="req"><see cref="ModifyHeadTailTemplateRequest"/></param>
        /// <returns><see cref="ModifyHeadTailTemplateResponse"/></returns>
        public ModifyHeadTailTemplateResponse ModifyHeadTailTemplateSync(ModifyHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHeadTailTemplateResponse>(req, "ModifyHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a user-customized image sprite template.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public Task<ModifyImageSpriteTemplateResponse> ModifyImageSpriteTemplate(ModifyImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<ModifyImageSpriteTemplateResponse>(req, "ModifyImageSpriteTemplate");
        }

        /// <summary>
        /// Modify a user-customized image sprite template.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public ModifyImageSpriteTemplateResponse ModifyImageSpriteTemplateSync(ModifyImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<ModifyImageSpriteTemplateResponse>(req, "ModifyImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a just in time transcoding template.
        /// -Note: Once a just in time transcoding template is created, modification is not recommended. If parameter modification is needed, adding a template is recommended.
        /// </summary>
        /// <param name="req"><see cref="ModifyJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<ModifyJustInTimeTranscodeTemplateResponse> ModifyJustInTimeTranscodeTemplate(ModifyJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyJustInTimeTranscodeTemplateResponse>(req, "ModifyJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// Modify a just in time transcoding template.
        /// -Note: Once a just in time transcoding template is created, modification is not recommended. If parameter modification is needed, adding a template is recommended.
        /// </summary>
        /// <param name="req"><see cref="ModifyJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyJustInTimeTranscodeTemplateResponse"/></returns>
        public ModifyJustInTimeTranscodeTemplateResponse ModifyJustInTimeTranscodeTemplateSync(ModifyJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyJustInTimeTranscodeTemplateResponse>(req, "ModifyJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a knowledge base. The name and/or description of the knowledge base can be modified. At least one of the Name or Description fields is required.
        /// </summary>
        /// <param name="req"><see cref="ModifyKnowledgeBaseRequest"/></param>
        /// <returns><see cref="ModifyKnowledgeBaseResponse"/></returns>
        public Task<ModifyKnowledgeBaseResponse> ModifyKnowledgeBase(ModifyKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<ModifyKnowledgeBaseResponse>(req, "ModifyKnowledgeBase");
        }

        /// <summary>
        /// This API is used to modify a knowledge base. The name and/or description of the knowledge base can be modified. At least one of the Name or Description fields is required.
        /// </summary>
        /// <param name="req"><see cref="ModifyKnowledgeBaseRequest"/></param>
        /// <returns><see cref="ModifyKnowledgeBaseResponse"/></returns>
        public ModifyKnowledgeBaseResponse ModifyKnowledgeBaseSync(ModifyKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<ModifyKnowledgeBaseResponse>(req, "ModifyKnowledgeBase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a large model parsing template
        /// </summary>
        /// <param name="req"><see cref="ModifyLLMComprehendTemplateRequest"/></param>
        /// <returns><see cref="ModifyLLMComprehendTemplateResponse"/></returns>
        public Task<ModifyLLMComprehendTemplateResponse> ModifyLLMComprehendTemplate(ModifyLLMComprehendTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLLMComprehendTemplateResponse>(req, "ModifyLLMComprehendTemplate");
        }

        /// <summary>
        /// Modify a large model parsing template
        /// </summary>
        /// <param name="req"><see cref="ModifyLLMComprehendTemplateRequest"/></param>
        /// <returns><see cref="ModifyLLMComprehendTemplateResponse"/></returns>
        public ModifyLLMComprehendTemplateResponse ModifyLLMComprehendTemplateSync(ModifyLLMComprehendTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLLMComprehendTemplateResponse>(req, "ModifyLLMComprehendTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a user-customized MPS task template.
        /// When modifying a template, fill in the MPS related parameters in JSON format into the MPSModifyTemplateParams parameter. For specific task parameter configuration methods, see the MPS task template related documentation.
        /// </summary>
        /// <param name="req"><see cref="ModifyMPSTemplateRequest"/></param>
        /// <returns><see cref="ModifyMPSTemplateResponse"/></returns>
        public Task<ModifyMPSTemplateResponse> ModifyMPSTemplate(ModifyMPSTemplateRequest req)
        {
            return InternalRequestAsync<ModifyMPSTemplateResponse>(req, "ModifyMPSTemplate");
        }

        /// <summary>
        /// Modify a user-customized MPS task template.
        /// When modifying a template, fill in the MPS related parameters in JSON format into the MPSModifyTemplateParams parameter. For specific task parameter configuration methods, see the MPS task template related documentation.
        /// </summary>
        /// <param name="req"><see cref="ModifyMPSTemplateRequest"/></param>
        /// <returns><see cref="ModifyMPSTemplateResponse"/></returns>
        public ModifyMPSTemplateResponse ModifyMPSTemplateSync(ModifyMPSTemplateRequest req)
        {
            return InternalRequestAsync<ModifyMPSTemplateResponse>(req, "ModifyMPSTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a media file, including category, name, description, tag, expiration time, dotting information, video cover, and subtitle information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public Task<ModifyMediaInfoResponse> ModifyMediaInfo(ModifyMediaInfoRequest req)
        {
            return InternalRequestAsync<ModifyMediaInfoResponse>(req, "ModifyMediaInfo");
        }

        /// <summary>
        /// This API is used to modify the attributes of a media file, including category, name, description, tag, expiration time, dotting information, video cover, and subtitle information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public ModifyMediaInfoResponse ModifyMediaInfoSync(ModifyMediaInfoRequest req)
        {
            return InternalRequestAsync<ModifyMediaInfoResponse>(req, "ModifyMediaInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the storage type of media files.
        /// When the storage type of a media file is standard storage, it can be modified to the following types:
        /// <li>Infrequent storage</li>
        /// <li>Archive storage</li>
        /// <li>DEEP_ARCHIVE</li>
        /// When the current storage type of a media file is infrequent storage, it can be modified to the following types:
        /// <li>Standard storage</li>
        /// <li>Archive storage</li>
        /// <li>DEEP_ARCHIVE</li>
        /// When the current storage type of a media file is archive storage, it can be modified to the following types:
        /// <li>Standard storage</li>
        /// When the current storage type of a media file is DEEP_ARCHIVE, it can be modified to the following types:
        /// <li>Standard storage</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaStorageClassRequest"/></param>
        /// <returns><see cref="ModifyMediaStorageClassResponse"/></returns>
        public Task<ModifyMediaStorageClassResponse> ModifyMediaStorageClass(ModifyMediaStorageClassRequest req)
        {
            return InternalRequestAsync<ModifyMediaStorageClassResponse>(req, "ModifyMediaStorageClass");
        }

        /// <summary>
        /// Modifies the storage type of media files.
        /// When the storage type of a media file is standard storage, it can be modified to the following types:
        /// <li>Infrequent storage</li>
        /// <li>Archive storage</li>
        /// <li>DEEP_ARCHIVE</li>
        /// When the current storage type of a media file is infrequent storage, it can be modified to the following types:
        /// <li>Standard storage</li>
        /// <li>Archive storage</li>
        /// <li>DEEP_ARCHIVE</li>
        /// When the current storage type of a media file is archive storage, it can be modified to the following types:
        /// <li>Standard storage</li>
        /// When the current storage type of a media file is DEEP_ARCHIVE, it can be modified to the following types:
        /// <li>Standard storage</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaStorageClassRequest"/></param>
        /// <returns><see cref="ModifyMediaStorageClassResponse"/></returns>
        public ModifyMediaStorageClassResponse ModifyMediaStorageClassSync(ModifyMediaStorageClassRequest req)
        {
            return InternalRequestAsync<ModifyMediaStorageClassResponse>(req, "ModifyMediaStorageClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify material sample information based on the material ID, including modification of the name and description, as well as addition, deletion, and reset of facial features and tags. Ensure at least 1 image remains after facial feature deletion. Otherwise, use the reset operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample");
        }

        /// <summary>
        /// This API is used to modify material sample information based on the material ID, including modification of the name and description, as well as addition, deletion, and reset of facial features and tags. Ensure at least 1 image remains after facial feature deletion. Otherwise, use the reset operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public ModifyPersonSampleResponse ModifyPersonSampleSync(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a user-customized image async processing template.
        /// 
        /// Note: Templates with IDs below 10000 are preset templates and are not allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyProcessImageAsyncTemplateRequest"/></param>
        /// <returns><see cref="ModifyProcessImageAsyncTemplateResponse"/></returns>
        public Task<ModifyProcessImageAsyncTemplateResponse> ModifyProcessImageAsyncTemplate(ModifyProcessImageAsyncTemplateRequest req)
        {
            return InternalRequestAsync<ModifyProcessImageAsyncTemplateResponse>(req, "ModifyProcessImageAsyncTemplate");
        }

        /// <summary>
        /// This API is used to modify a user-customized image async processing template.
        /// 
        /// Note: Templates with IDs below 10000 are preset templates and are not allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyProcessImageAsyncTemplateRequest"/></param>
        /// <returns><see cref="ModifyProcessImageAsyncTemplateResponse"/></returns>
        public ModifyProcessImageAsyncTemplateResponse ModifyProcessImageAsyncTemplateSync(ModifyProcessImageAsyncTemplateRequest req)
        {
            return InternalRequestAsync<ModifyProcessImageAsyncTemplateResponse>(req, "ModifyProcessImageAsyncTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an audio and video quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityInspectTemplateResponse"/></returns>
        public Task<ModifyQualityInspectTemplateResponse> ModifyQualityInspectTemplate(ModifyQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityInspectTemplateResponse>(req, "ModifyQualityInspectTemplate");
        }

        /// <summary>
        /// This API is used to modify an audio and video quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityInspectTemplateResponse"/></returns>
        public ModifyQualityInspectTemplateResponse ModifyQualityInspectTemplateSync(ModifyQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityInspectTemplateResponse>(req, "ModifyQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) interface uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// Modifying a Video Rebirth Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public Task<ModifyRebuildMediaTemplateResponse> ModifyRebuildMediaTemplate(ModifyRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRebuildMediaTemplateResponse>(req, "ModifyRebuildMediaTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. The new version of [audio and video quality revival](https://www.tencentcloud.com/document/product/266/102571?from_cn_redirect=1) interface uses preset templates. For details, see [Audio and Video Quality Rebirth Template](https://www.tencentcloud.com/document/product/266/102586?from_cn_redirect=1#50604b3f-0286-4a10-a3f7-18218116aff7).
        /// Modifying a Video Rebirth Template.
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public ModifyRebuildMediaTemplateResponse ModifyRebuildMediaTemplateSync(ModifyRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRebuildMediaTemplateResponse>(req, "ModifyRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies a user-customized moderation template.
        /// >Template is applicable only to the ReviewAudioVideo (https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and ReviewImage (https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public Task<ModifyReviewTemplateResponse> ModifyReviewTemplate(ModifyReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyReviewTemplateResponse>(req, "ModifyReviewTemplate");
        }

        /// <summary>
        /// Modifies a user-customized moderation template.
        /// >Template is applicable only to the ReviewAudioVideo (https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) and ReviewImage (https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1) APIs.
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public ModifyReviewTemplateResponse ModifyReviewTemplateSync(ModifyReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyReviewTemplateResponse>(req, "ModifyReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a carousel playlist.
        /// After modification, only new playback requests will take effect. Users already playing can still play the previous playlist within 7 days.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public Task<ModifyRoundPlayResponse> ModifyRoundPlay(ModifyRoundPlayRequest req)
        {
            return InternalRequestAsync<ModifyRoundPlayResponse>(req, "ModifyRoundPlay");
        }

        /// <summary>
        /// This API is used to modify a carousel playlist.
        /// After modification, only new playback requests will take effect. Users already playing can still play the previous playlist within 7 days.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public ModifyRoundPlayResponse ModifyRoundPlaySync(ModifyRoundPlayRequest req)
        {
            return InternalRequestAsync<ModifyRoundPlayResponse>(req, "ModifyRoundPlay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a user-customized sampled screenshot template.
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public Task<ModifySampleSnapshotTemplateResponse> ModifySampleSnapshotTemplate(ModifySampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifySampleSnapshotTemplateResponse>(req, "ModifySampleSnapshotTemplate");
        }

        /// <summary>
        /// Modify a user-customized sampled screenshot template.
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public ModifySampleSnapshotTemplateResponse ModifySampleSnapshotTemplateSync(ModifySampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifySampleSnapshotTemplateResponse>(req, "ModifySampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a user-customized specified time point screenshot template.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<ModifySnapshotByTimeOffsetTemplateResponse> ModifySnapshotByTimeOffsetTemplate(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<ModifySnapshotByTimeOffsetTemplateResponse>(req, "ModifySnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// Modify a user-customized specified time point screenshot template.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public ModifySnapshotByTimeOffsetTemplateResponse ModifySnapshotByTimeOffsetTemplateSync(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<ModifySnapshotByTimeOffsetTemplateResponse>(req, "ModifySnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change application information, but default application information is not allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public Task<ModifySubAppIdInfoResponse> ModifySubAppIdInfo(ModifySubAppIdInfoRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdInfoResponse>(req, "ModifySubAppIdInfo");
        }

        /// <summary>
        /// This API is used to change application information, but default application information is not allowed to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public ModifySubAppIdInfoResponse ModifySubAppIdInfoSync(ModifySubAppIdInfoRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdInfoResponse>(req, "ModifySubAppIdInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable applications. Disabled applications will have their corresponding domains blocked and console access restricted.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public Task<ModifySubAppIdStatusResponse> ModifySubAppIdStatus(ModifySubAppIdStatusRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdStatusResponse>(req, "ModifySubAppIdStatus");
        }

        /// <summary>
        /// This API is used to enable or disable applications. Disabled applications will have their corresponding domains blocked and console access restricted.
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public ModifySubAppIdStatusResponse ModifySubAppIdStatusSync(ModifySubAppIdStatusRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdStatusResponse>(req, "ModifySubAppIdStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to modify player configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public Task<ModifySuperPlayerConfigResponse> ModifySuperPlayerConfig(ModifySuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<ModifySuperPlayerConfigResponse>(req, "ModifySuperPlayerConfig");
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. The new version of player signature no longer uses player configuration templates. For details, please see [Player Signature](https://www.tencentcloud.com/document/product/266/45554?from_cn_redirect=1).
        /// This API is used to modify player configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public ModifySuperPlayerConfigResponse ModifySuperPlayerConfigSync(ModifySuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<ModifySuperPlayerConfigResponse>(req, "ModifySuperPlayerConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the information of a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public Task<ModifyTranscodeTemplateResponse> ModifyTranscodeTemplate(ModifyTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTranscodeTemplateResponse>(req, "ModifyTranscodeTemplate");
        }

        /// <summary>
        /// Modify the information of a custom transcoding template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public ModifyTranscodeTemplateResponse ModifyTranscodeTemplateSync(ModifyTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTranscodeTemplateResponse>(req, "ModifyTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the acceleration region of a VOD domain.
        /// 1. The acceleration region can be modified only when the domain name deployment state is Online.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public Task<ModifyVodDomainAccelerateConfigResponse> ModifyVodDomainAccelerateConfig(ModifyVodDomainAccelerateConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainAccelerateConfigResponse>(req, "ModifyVodDomainAccelerateConfig");
        }

        /// <summary>
        /// This API is used to modify the acceleration region of a VOD domain.
        /// 1. The acceleration region can be modified only when the domain name deployment state is Online.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public ModifyVodDomainAccelerateConfigResponse ModifyVodDomainAccelerateConfigSync(ModifyVodDomainAccelerateConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainAccelerateConfigResponse>(req, "ModifyVodDomainAccelerateConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify domain name configuration, including hotlink protection configuration.
        /// 1. The domain name configuration can be modified only when the domain name deployment state is Online.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public Task<ModifyVodDomainConfigResponse> ModifyVodDomainConfig(ModifyVodDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainConfigResponse>(req, "ModifyVodDomainConfig");
        }

        /// <summary>
        /// This API is used to modify domain name configuration, including hotlink protection configuration.
        /// 1. The domain name configuration can be modified only when the domain name deployment state is Online.
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public ModifyVodDomainConfigResponse ModifyVodDomainConfigSync(ModifyVodDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainConfigResponse>(req, "ModifyVodDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a user-defined watermark template. The watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public Task<ModifyWatermarkTemplateResponse> ModifyWatermarkTemplate(ModifyWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWatermarkTemplateResponse>(req, "ModifyWatermarkTemplate");
        }

        /// <summary>
        /// This API is used to modify a user-defined watermark template. The watermark type cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public ModifyWatermarkTemplateResponse ModifyWatermarkTemplateSync(ModifyWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWatermarkTemplateResponse>(req, "ModifyWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the application scenario and tags of a keyword. The keyword itself cannot be modified. If modification is needed, delete and rebuild it.
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public Task<ModifyWordSampleResponse> ModifyWordSample(ModifyWordSampleRequest req)
        {
            return InternalRequestAsync<ModifyWordSampleResponse>(req, "ModifyWordSample");
        }

        /// <summary>
        /// This API is used to modify the application scenario and tags of a keyword. The keyword itself cannot be modified. If modification is needed, delete and rebuild it.
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public ModifyWordSampleResponse ModifyWordSampleSync(ModifyWordSampleRequest req)
        {
            return InternalRequestAsync<ModifyWordSampleResponse>(req, "ModifyWordSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When uploading HLS videos, this API parses the index file content and returns a list of shard files to be uploaded. The shard file path must be a relative path in the current directory or subdirectory. It cannot be a URL or an absolute path.
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public Task<ParseStreamingManifestResponse> ParseStreamingManifest(ParseStreamingManifestRequest req)
        {
            return InternalRequestAsync<ParseStreamingManifestResponse>(req, "ParseStreamingManifest");
        }

        /// <summary>
        /// When uploading HLS videos, this API parses the index file content and returns a list of shard files to be uploaded. The shard file path must be a relative path in the current directory or subdirectory. It cannot be a URL or an absolute path.
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public ParseStreamingManifestResponse ParseStreamingManifestSync(ParseStreamingManifestRequest req)
        {
            return InternalRequestAsync<ParseStreamingManifestResponse>(req, "ParseStreamingManifest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to process image tasks.
        /// </summary>
        /// <param name="req"><see cref="ProcessImageAsyncRequest"/></param>
        /// <returns><see cref="ProcessImageAsyncResponse"/></returns>
        public Task<ProcessImageAsyncResponse> ProcessImageAsync(ProcessImageAsyncRequest req)
        {
            return InternalRequestAsync<ProcessImageAsyncResponse>(req, "ProcessImageAsync");
        }

        /// <summary>
        /// This API is used to process image tasks.
        /// </summary>
        /// <param name="req"><see cref="ProcessImageAsyncRequest"/></param>
        /// <returns><see cref="ProcessImageAsyncResponse"/></returns>
        public ProcessImageAsyncResponse ProcessImageAsyncSync(ProcessImageAsyncRequest req)
        {
            return InternalRequestAsync<ProcessImageAsyncResponse>(req, "ProcessImageAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate processing tasks for audio-video media in VOD, with features including:
        /// 1. Watermarked video transcoding;
        /// 2. Animated image generating;
        /// 3. Screenshot taking at specified time points;
        /// 4. Sampled screenshot taking;
        /// 5. Capture CSS sprites for videos;
        /// 6. Capture a frame from a video as the cover.
        /// 7. Transcoding to adaptive bitrate streaming (and encrypting);
        /// 8. Content review (offensive content, unsafe information, inappropriate information), it is <font color=red>not recommended</font> to use this API to initiate. It is recommended to use [Audio/Video Moderation (ReviewAudioVideo)](https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) or [Image Moderation (ReviewImage)](https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1);
        /// 9. Content analysis (tag, categorization, cover, frame tagging), HLS format not supported currently.
        /// 10. Content recognition (video intro and outro, human face, full text, text keyword, full speech, speech keyword, object).
        /// 
        /// If event notification is used, the event notification type is task flow status change (https://www.tencentcloud.com/document/product/266/9636?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia");
        }

        /// <summary>
        /// This API is used to initiate processing tasks for audio-video media in VOD, with features including:
        /// 1. Watermarked video transcoding;
        /// 2. Animated image generating;
        /// 3. Screenshot taking at specified time points;
        /// 4. Sampled screenshot taking;
        /// 5. Capture CSS sprites for videos;
        /// 6. Capture a frame from a video as the cover.
        /// 7. Transcoding to adaptive bitrate streaming (and encrypting);
        /// 8. Content review (offensive content, unsafe information, inappropriate information), it is <font color=red>not recommended</font> to use this API to initiate. It is recommended to use [Audio/Video Moderation (ReviewAudioVideo)](https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1) or [Image Moderation (ReviewImage)](https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1);
        /// 9. Content analysis (tag, categorization, cover, frame tagging), HLS format not supported currently.
        /// 10. Content recognition (video intro and outro, human face, full text, text keyword, full speech, speech keyword, object).
        /// 
        /// If event notification is used, the event notification type is task flow status change (https://www.tencentcloud.com/document/product/266/9636?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public ProcessMediaResponse ProcessMediaSync(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Use the media processing capability of Media Processing Service (MPS) to initiate media processing for videos in VOD.
        /// Currently supported MPS features:
        /// 1. Smart subtitling: The feature supports processing offline audio files, video files, and live streams. It can extract subtitles in the video source language through ASR speech recognition or OCR text recognition, and implement multilingual translation. View details in the integration guide (https://www.tencentcloud.com/document/product/266/131210?from_cn_redirect=1).
        /// 2. Intelligent erasure: It can blur, mosaic, or seamlessly process elements such as logos, subtitles, human faces, and license plates in video footage, making it easy to spread and share content. The new video generated by this task will be assigned a new FileId and stored in a subapplication of the VOD platform. For details, see the Access Guide (https://www.tencentcloud.com/document/product/266/131211?from_cn_redirect=1).
        /// 3. AI analysis: This feature supports all-in-one translation (https://www.tencentcloud.com/document/product/266/131212?from_cn_redirect=1), highlights (https://www.tencentcloud.com/document/product/266/131213?from_cn_redirect=1), LLM video summary (https://www.tencentcloud.com/document/product/266/131214?from_cn_redirect=1), LLM audio/video understanding (https://www.tencentcloud.com/document/product/266/131215?from_cn_redirect=1), intelligent splitting (https://www.tencentcloud.com/document/product/266/131216?from_cn_redirect=1), intelligent landscape-to-portrait (https://www.tencentcloud.com/document/product/266/131217?from_cn_redirect=1), video deduplication (https://www.tencentcloud.com/document/product/266/131218?from_cn_redirect=1), and other features.
        /// 
        /// 
        /// > Video processing tasks initiated this method:
        /// > 1. Query of task status and results is still completed in the VOD platform. Use [DescribeTaskDetail](https://www.tencentcloud.com/document/product/266/33431?from_cn_redirect=1) or [DescribeTasks](https://www.tencentcloud.com/document/product/266/33430?from_cn_redirect=1) to query tasks.
        /// > 2. The amount and bills of related features will be provided on the PS platform. Before using this feature, first enable Media Processing Service (MPS) in the console. For the activation method, see the preliminary operations in the access documentation.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByMPSRequest"/></param>
        /// <returns><see cref="ProcessMediaByMPSResponse"/></returns>
        public Task<ProcessMediaByMPSResponse> ProcessMediaByMPS(ProcessMediaByMPSRequest req)
        {
            return InternalRequestAsync<ProcessMediaByMPSResponse>(req, "ProcessMediaByMPS");
        }

        /// <summary>
        /// Use the media processing capability of Media Processing Service (MPS) to initiate media processing for videos in VOD.
        /// Currently supported MPS features:
        /// 1. Smart subtitling: The feature supports processing offline audio files, video files, and live streams. It can extract subtitles in the video source language through ASR speech recognition or OCR text recognition, and implement multilingual translation. View details in the integration guide (https://www.tencentcloud.com/document/product/266/131210?from_cn_redirect=1).
        /// 2. Intelligent erasure: It can blur, mosaic, or seamlessly process elements such as logos, subtitles, human faces, and license plates in video footage, making it easy to spread and share content. The new video generated by this task will be assigned a new FileId and stored in a subapplication of the VOD platform. For details, see the Access Guide (https://www.tencentcloud.com/document/product/266/131211?from_cn_redirect=1).
        /// 3. AI analysis: This feature supports all-in-one translation (https://www.tencentcloud.com/document/product/266/131212?from_cn_redirect=1), highlights (https://www.tencentcloud.com/document/product/266/131213?from_cn_redirect=1), LLM video summary (https://www.tencentcloud.com/document/product/266/131214?from_cn_redirect=1), LLM audio/video understanding (https://www.tencentcloud.com/document/product/266/131215?from_cn_redirect=1), intelligent splitting (https://www.tencentcloud.com/document/product/266/131216?from_cn_redirect=1), intelligent landscape-to-portrait (https://www.tencentcloud.com/document/product/266/131217?from_cn_redirect=1), video deduplication (https://www.tencentcloud.com/document/product/266/131218?from_cn_redirect=1), and other features.
        /// 
        /// 
        /// > Video processing tasks initiated this method:
        /// > 1. Query of task status and results is still completed in the VOD platform. Use [DescribeTaskDetail](https://www.tencentcloud.com/document/product/266/33431?from_cn_redirect=1) or [DescribeTasks](https://www.tencentcloud.com/document/product/266/33430?from_cn_redirect=1) to query tasks.
        /// > 2. The amount and bills of related features will be provided on the PS platform. Before using this feature, first enable Media Processing Service (MPS) in the console. For the activation method, see the preliminary operations in the access documentation.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByMPSRequest"/></param>
        /// <returns><see cref="ProcessMediaByMPSResponse"/></returns>
        public ProcessMediaByMPSResponse ProcessMediaByMPSSync(ProcessMediaByMPSRequest req)
        {
            return InternalRequestAsync<ProcessMediaByMPSResponse>(req, "ProcessMediaByMPS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Use a task flow template to initiate processing tasks for videos in VOD.
        /// There are two ways to create a task flow template:
        /// 1. Create and modify a task flow template in the console;
        /// 2. Create a task flow template through the task flow template API.
        /// 
        /// If event notification is used, the type of event notification for tasks other than audio/video moderation tasks is task flow status change (https://www.tencentcloud.com/document/product/266/9636?from_cn_redirect=1); the type of event notification for audio/video moderation tasks is audio/video moderation completed (https://www.tencentcloud.com/document/product/266/81258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public Task<ProcessMediaByProcedureResponse> ProcessMediaByProcedure(ProcessMediaByProcedureRequest req)
        {
            return InternalRequestAsync<ProcessMediaByProcedureResponse>(req, "ProcessMediaByProcedure");
        }

        /// <summary>
        /// Use a task flow template to initiate processing tasks for videos in VOD.
        /// There are two ways to create a task flow template:
        /// 1. Create and modify a task flow template in the console;
        /// 2. Create a task flow template through the task flow template API.
        /// 
        /// If event notification is used, the type of event notification for tasks other than audio/video moderation tasks is task flow status change (https://www.tencentcloud.com/document/product/266/9636?from_cn_redirect=1); the type of event notification for audio/video moderation tasks is audio/video moderation completed (https://www.tencentcloud.com/document/product/266/81258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public ProcessMediaByProcedureResponse ProcessMediaByProcedureSync(ProcessMediaByProcedureRequest req)
        {
            return InternalRequestAsync<ProcessMediaByProcedureResponse>(req, "ProcessMediaByProcedure")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. Please use the [ProcessMedia](https://www.tencentcloud.com/document/product/862/37578?from_cn_redirect=1) API of MPS and specify the video URL in the input parameter InputInfo.UrlInputInfo.Url.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public Task<ProcessMediaByUrlResponse> ProcessMediaByUrl(ProcessMediaByUrlRequest req)
        {
            return InternalRequestAsync<ProcessMediaByUrlResponse>(req, "ProcessMediaByUrl");
        }

        /// <summary>
        /// This API is <font color='red'>no longer maintained</font>. Please use the [ProcessMedia](https://www.tencentcloud.com/document/product/862/37578?from_cn_redirect=1) API of MPS and specify the video URL in the input parameter InputInfo.UrlInputInfo.Url.
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public ProcessMediaByUrlResponse ProcessMediaByUrlSync(ProcessMediaByUrlRequest req)
        {
            return InternalRequestAsync<ProcessMediaByUrlResponse>(req, "ProcessMediaByUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * This API is used for the business server to get event notifications via reliable callback (https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83);
        /// * The API uses long polling mode. If there are unconsumed events on the server, they will be returned to the requester immediately. If there are no unconsumed events, the request will be suspended in the background until a new event occurs.
        /// * The request can be suspended for up to 5 seconds. It is advisable to set the timeout to 10 seconds for the requester.
        /// * Event notifications that are not pulled are retained for up to 4 days. Notifications exceeding this time limit may be purged.
        /// * If this API returns an event, the caller must call the [Confirm Event Notification](https://www.tencentcloud.com/document/product/266/33434?from_cn_redirect=1) API within <font color="red">30 seconds</font> to confirm that the event notification has been processed. Otherwise, the event notification will be pulled again after <font color="red">30 seconds</font>.
        /// * Currently, a maximum of 16 event notifications can be obtained per API call.
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public Task<PullEventsResponse> PullEvents(PullEventsRequest req)
        {
            return InternalRequestAsync<PullEventsResponse>(req, "PullEvents");
        }

        /// <summary>
        /// * This API is used for the business server to get event notifications via reliable callback (https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83);
        /// * The API uses long polling mode. If there are unconsumed events on the server, they will be returned to the requester immediately. If there are no unconsumed events, the request will be suspended in the background until a new event occurs.
        /// * The request can be suspended for up to 5 seconds. It is advisable to set the timeout to 10 seconds for the requester.
        /// * Event notifications that are not pulled are retained for up to 4 days. Notifications exceeding this time limit may be purged.
        /// * If this API returns an event, the caller must call the [Confirm Event Notification](https://www.tencentcloud.com/document/product/266/33434?from_cn_redirect=1) API within <font color="red">30 seconds</font> to confirm that the event notification has been processed. Otherwise, the event notification will be pulled again after <font color="red">30 seconds</font>.
        /// * Currently, a maximum of 16 event notifications can be obtained per API call.
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public PullEventsResponse PullEventsSync(PullEventsRequest req)
        {
            return InternalRequestAsync<PullEventsResponse>(req, "PullEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull a video from the network to the VOD platform.
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public Task<PullUploadResponse> PullUpload(PullUploadRequest req)
        {
            return InternalRequestAsync<PullUploadResponse>(req, "PullUpload");
        }

        /// <summary>
        /// This API is used to pull a video from the network to the VOD platform.
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public PullUploadResponse PullUploadSync(PullUploadRequest req)
        {
            return InternalRequestAsync<PullUploadResponse>(req, "PullUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. Preheat the specified URL list.
        /// 2. The domain name of the URL must be registered in VOD.
        /// 3. Specify up to 20 URLs per request.
        /// 4. The default prefetch quota is 10,000 URLs per day.
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public Task<PushUrlCacheResponse> PushUrlCache(PushUrlCacheRequest req)
        {
            return InternalRequestAsync<PushUrlCacheResponse>(req, "PushUrlCache");
        }

        /// <summary>
        /// 1. Preheat the specified URL list.
        /// 2. The domain name of the URL must be registered in VOD.
        /// 3. Specify up to 20 URLs per request.
        /// 4. The default prefetch quota is 10,000 URLs per day.
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public PushUrlCacheResponse PushUrlCacheSync(PushUrlCacheRequest req)
        {
            return InternalRequestAsync<PushUrlCacheResponse>(req, "PushUrlCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. Please use the new version of APIs [audio and video quality revival](https://www.tencentcloud.com/document/api/266/102571?from_cn_redirect=1).
        /// This API is used to initiate audio and video quality revival.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public Task<RebuildMediaResponse> RebuildMedia(RebuildMediaRequest req)
        {
            return InternalRequestAsync<RebuildMediaResponse>(req, "RebuildMedia");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. Please use the new version of APIs [audio and video quality revival](https://www.tencentcloud.com/document/api/266/102571?from_cn_redirect=1).
        /// This API is used to initiate audio and video quality revival.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public RebuildMediaResponse RebuildMediaSync(RebuildMediaRequest req)
        {
            return InternalRequestAsync<RebuildMediaResponse>(req, "RebuildMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. Please use the new version of APIs for [audio and video quality revival](https://www.tencentcloud.com/document/api/266/102571?from_cn_redirect=1).
        /// Use a template to initiate video rebirth.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public Task<RebuildMediaByTemplateResponse> RebuildMediaByTemplate(RebuildMediaByTemplateRequest req)
        {
            return InternalRequestAsync<RebuildMediaByTemplateResponse>(req, "RebuildMediaByTemplate");
        }

        /// <summary>
        /// This API is <font color=red>no longer maintained</font>. Please use the new version of APIs for [audio and video quality revival](https://www.tencentcloud.com/document/api/266/102571?from_cn_redirect=1).
        /// Use a template to initiate video rebirth.
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public RebuildMediaByTemplateResponse RebuildMediaByTemplateSync(RebuildMediaByTemplateRequest req)
        {
            return InternalRequestAsync<RebuildMediaByTemplateResponse>(req, "RebuildMediaByTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. Refresh a specified URL list.
        /// 2. The domain name of the URL must be registered in VOD.
        /// 3. A maximum of 20 URLs can be specified per request.
        /// 4. The default refresh quota is 100,000 URLs per day.
        /// </summary>
        /// <param name="req"><see cref="RefreshUrlCacheRequest"/></param>
        /// <returns><see cref="RefreshUrlCacheResponse"/></returns>
        public Task<RefreshUrlCacheResponse> RefreshUrlCache(RefreshUrlCacheRequest req)
        {
            return InternalRequestAsync<RefreshUrlCacheResponse>(req, "RefreshUrlCache");
        }

        /// <summary>
        /// 1. Refresh a specified URL list.
        /// 2. The domain name of the URL must be registered in VOD.
        /// 3. A maximum of 20 URLs can be specified per request.
        /// 4. The default refresh quota is 100,000 URLs per day.
        /// </summary>
        /// <param name="req"><see cref="RefreshUrlCacheRequest"/></param>
        /// <returns><see cref="RefreshUrlCacheResponse"/></returns>
        public RefreshUrlCacheResponse RefreshUrlCacheSync(RefreshUrlCacheRequest req)
        {
            return InternalRequestAsync<RefreshUrlCacheResponse>(req, "RefreshUrlCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Watermark removal
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public Task<RemoveWatermarkResponse> RemoveWatermark(RemoveWatermarkRequest req)
        {
            return InternalRequestAsync<RemoveWatermarkResponse>(req, "RemoveWatermark");
        }

        /// <summary>
        /// Watermark removal
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public RemoveWatermarkResponse RemoveWatermarkSync(RemoveWatermarkRequest req)
        {
            return InternalRequestAsync<RemoveWatermarkResponse>(req, "RemoveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reset the content of the user-defined task flow template.
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public Task<ResetProcedureTemplateResponse> ResetProcedureTemplate(ResetProcedureTemplateRequest req)
        {
            return InternalRequestAsync<ResetProcedureTemplateResponse>(req, "ResetProcedureTemplate");
        }

        /// <summary>
        /// Reset the content of the user-defined task flow template.
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public ResetProcedureTemplateResponse ResetProcedureTemplateSync(ResetProcedureTemplateRequest req)
        {
            return InternalRequestAsync<ResetProcedureTemplateResponse>(req, "ResetProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// If the storage type of a media file is archive storage or deep archive storage, it is inaccessible. If you need access, call this API to unfreeze it. After unfreezing, the accessible media file is temporary and becomes inaccessible after the validity period expires.
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public Task<RestoreMediaResponse> RestoreMedia(RestoreMediaRequest req)
        {
            return InternalRequestAsync<RestoreMediaResponse>(req, "RestoreMedia");
        }

        /// <summary>
        /// If the storage type of a media file is archive storage or deep archive storage, it is inaccessible. If you need access, call this API to unfreeze it. After unfreezing, the accessible media file is temporary and becomes inaccessible after the validity period expires.
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public RestoreMediaResponse RestoreMediaSync(RestoreMediaRequest req)
        {
            return InternalRequestAsync<RestoreMediaResponse>(req, "RestoreMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate a moderation task for on-demand audio-video media, intelligently detecting violative content in video footage, text in images, text in speech, and sound.
        /// 
        /// If event notification is used, the event notification type is [audio/video moderation completed](https://www.tencentcloud.com/document/product/266/81258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReviewAudioVideoRequest"/></param>
        /// <returns><see cref="ReviewAudioVideoResponse"/></returns>
        public Task<ReviewAudioVideoResponse> ReviewAudioVideo(ReviewAudioVideoRequest req)
        {
            return InternalRequestAsync<ReviewAudioVideoResponse>(req, "ReviewAudioVideo");
        }

        /// <summary>
        /// This API is used to initiate a moderation task for on-demand audio-video media, intelligently detecting violative content in video footage, text in images, text in speech, and sound.
        /// 
        /// If event notification is used, the event notification type is [audio/video moderation completed](https://www.tencentcloud.com/document/product/266/81258?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReviewAudioVideoRequest"/></param>
        /// <returns><see cref="ReviewAudioVideoResponse"/></returns>
        public ReviewAudioVideoResponse ReviewAudioVideoSync(ReviewAudioVideoRequest req)
        {
            return InternalRequestAsync<ReviewAudioVideoResponse>(req, "ReviewAudioVideo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate a review task for image files in VOD to detect offensive, unsafe, and inappropriate content.
        /// 
        /// <li>Supported image file size: file < 5M;</li>
        /// <li>Image file resolution support: recommended resolution above 256x256, otherwise it may affect review effectiveness;</li>
        /// <li>Supported image file formats: PNG, JPG, JPEG, BMP, GIF, WEBP.</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public Task<ReviewImageResponse> ReviewImage(ReviewImageRequest req)
        {
            return InternalRequestAsync<ReviewImageResponse>(req, "ReviewImage");
        }

        /// <summary>
        /// Initiate a review task for image files in VOD to detect offensive, unsafe, and inappropriate content.
        /// 
        /// <li>Supported image file size: file < 5M;</li>
        /// <li>Image file resolution support: recommended resolution above 256x256, otherwise it may affect review effectiveness;</li>
        /// <li>Supported image file formats: PNG, JPG, JPEG, BMP, GIF, WEBP.</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public ReviewImageResponse ReviewImageSync(ReviewImageRequest req)
        {
            return InternalRequestAsync<ReviewImageResponse>(req, "ReviewImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search media information with multiple filter criteria, sort and filter returned results, and other features. This includes:
        /// -Specify the file ID collection FileIds to return media matching any ID in the collection.
        /// -Perform fuzzy search by multiple media file names (Names) or descriptions (Descriptions).
        /// -Search by multiple filename prefixes NamePrefixes.
        /// - Specify the category collection ClassIds (see input parameter), and media that meet any category in the collection will be returned. For example, media categories include movies, TV series, and variety shows. The movie category has subcategories such as historical films, action films, and romance films. If ClassIds specifies movies and TV series, all subcategories under movies and TV series will be returned. If ClassIds specifies historical films and action films, only media under these two subcategories will be returned.
        /// - Specify tag collection Tags (see input parameters) to return media that match any tag in the collection. For example, if media tags include ACG, palace intrigue, and parody remix, and Tags specifies ACG and parody remix, any media that meets either of these two tags will be retrieved.
        /// -Specified file type collection Categories (see input parameter). Returns media that meet any type in the collection. For example, file types include Video, Audio, and Image. If Categories specifies Video and Audio, media that meet these types will be retrieved.
        /// -Specify the source collection SourceTypes (see input parameters) to return media that meets any source in the collection. For example, media sources include Record (live recording), Upload, and so on. If SourceTypes specifies Record and Upload, media that meets these sources will be retrieved.
        /// -Specify the file packaging format set MediaTypes (see input parameters), and return media that meets any packaging format in the collection. For example, packaging formats include MP4, AVI, MP3, and so on. If MediaTypes specifies MP4 and MP3, then media that complies with these packaging formats will be retrieved.
        /// -Specify the file status collection Status (see input parameters) to return media that meet any status in the collection. For example, file statuses include Normal, SystemForbidden (Platform Ban), and Forbidden (proactive ban). If Status specifies Normal and Forbidden, media that meet these statuses will be retrieved.
        /// -Specify the file review result set ReviewResults (see input parameters) to return media that meets any status in the collection. For example, file review results include pass and block. If ReviewResults specifies both pass and block, media that complies with these review results will be retrieved.
        /// -Filter the media of live recording service by specifying the collection of live streaming codes StreamIds (see input parameter).
        /// -Filter media by the create time range of the specified media.
        /// -Specify a TRTC application ID collection to filter media.
        /// -Specify a TRTC room ID collection to filter media.
        /// 
        /// - The above parameters can be combined in any way for retrieval. For example: filter media with a creation time between 2018-12-01 12:00:00 and 2018-12-08 12:00:00, categorized as movie or TV series, and tagged with palace intrigue and suspense. Note that for any parameter that supports array input, the search logic between its elements is "OR". The logical relationship between all parameters is "AND".
        /// 
        /// -Allow passage of Filters to control the type of media information returned (default return all information). Selectable inputs include:
        /// 1. Basic information (basicInfo): including media name, category, playback address, cover image, etc.
        /// 2. Meta information (metaData): including size, duration, video stream information, and audio stream information.
        /// 3. transcodeInfo: includes media addresses, video stream parameters, and audio stream parameters of various specifications generated for the transcoded media.
        /// 4. animatedGraphicsInfo: The animated graphics info after converting a video to gif (for example, gif).
        /// 5. sampleSnapshotInfo: screenshot information after sampling screenshots from the video.
        /// 6. Sprite image information (imageSpriteInfo): sprite image information after capturing sprite images from a video.
        /// 7. snapshotByTimeOffsetInfo: screenshot information after taking screenshots of a video at specified time points.
        /// 8. Video timestamp information (keyFrameDescInfo): Dotting information set for the video.
        /// 9. Adaptive Bitrate Streaming information (adaptiveDynamicStreamingInfo): information including specification, encryption type, and packaging format.
        /// 
        /// -Permission to sort results by creation time and return in pages. Use Offset and Limit (see input parameters) to control pagination.
        /// 
        /// <div id="maxResultsDesc">API return result count limit:</div>
        /// 
        /// -<b><a href="#p_offset">Offset</a> and <a href="#p_limit">Limit</a> impact the number of results per pagination query. Special attention: when both are omitted, this interface returns up to 10 query results by default.</b>
        /// -<b>Supports returning up to 5,000 search results. Results beyond this limit can no longer be queried. If the search result volume is too large, recommend using more granular criteria to reduce the search results.</b>
        /// 
        /// <br>Conditional filtering not recommended:
        /// - (Not recommended: use Names, NamePrefixes, or Descriptions instead) Specify single text Text for fuzzy search on media file name or description.
        /// -(Not recommended: use SourceTypes instead) Specify a single media file source SourceType for search.
        /// -(Not recommended: Use StreamIds instead) Specify a single push stream live code StreamId to search.
        /// -(Not recommended: use CreateTime as an alternative) Specify a single starting creation time StartTime to search.
        /// -(Not recommended: use CreateTime instead) Specify a single end time EndTime to search.
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public Task<SearchMediaResponse> SearchMedia(SearchMediaRequest req)
        {
            return InternalRequestAsync<SearchMediaResponse>(req, "SearchMedia");
        }

        /// <summary>
        /// This API is used to search media information with multiple filter criteria, sort and filter returned results, and other features. This includes:
        /// -Specify the file ID collection FileIds to return media matching any ID in the collection.
        /// -Perform fuzzy search by multiple media file names (Names) or descriptions (Descriptions).
        /// -Search by multiple filename prefixes NamePrefixes.
        /// - Specify the category collection ClassIds (see input parameter), and media that meet any category in the collection will be returned. For example, media categories include movies, TV series, and variety shows. The movie category has subcategories such as historical films, action films, and romance films. If ClassIds specifies movies and TV series, all subcategories under movies and TV series will be returned. If ClassIds specifies historical films and action films, only media under these two subcategories will be returned.
        /// - Specify tag collection Tags (see input parameters) to return media that match any tag in the collection. For example, if media tags include ACG, palace intrigue, and parody remix, and Tags specifies ACG and parody remix, any media that meets either of these two tags will be retrieved.
        /// -Specified file type collection Categories (see input parameter). Returns media that meet any type in the collection. For example, file types include Video, Audio, and Image. If Categories specifies Video and Audio, media that meet these types will be retrieved.
        /// -Specify the source collection SourceTypes (see input parameters) to return media that meets any source in the collection. For example, media sources include Record (live recording), Upload, and so on. If SourceTypes specifies Record and Upload, media that meets these sources will be retrieved.
        /// -Specify the file packaging format set MediaTypes (see input parameters), and return media that meets any packaging format in the collection. For example, packaging formats include MP4, AVI, MP3, and so on. If MediaTypes specifies MP4 and MP3, then media that complies with these packaging formats will be retrieved.
        /// -Specify the file status collection Status (see input parameters) to return media that meet any status in the collection. For example, file statuses include Normal, SystemForbidden (Platform Ban), and Forbidden (proactive ban). If Status specifies Normal and Forbidden, media that meet these statuses will be retrieved.
        /// -Specify the file review result set ReviewResults (see input parameters) to return media that meets any status in the collection. For example, file review results include pass and block. If ReviewResults specifies both pass and block, media that complies with these review results will be retrieved.
        /// -Filter the media of live recording service by specifying the collection of live streaming codes StreamIds (see input parameter).
        /// -Filter media by the create time range of the specified media.
        /// -Specify a TRTC application ID collection to filter media.
        /// -Specify a TRTC room ID collection to filter media.
        /// 
        /// - The above parameters can be combined in any way for retrieval. For example: filter media with a creation time between 2018-12-01 12:00:00 and 2018-12-08 12:00:00, categorized as movie or TV series, and tagged with palace intrigue and suspense. Note that for any parameter that supports array input, the search logic between its elements is "OR". The logical relationship between all parameters is "AND".
        /// 
        /// -Allow passage of Filters to control the type of media information returned (default return all information). Selectable inputs include:
        /// 1. Basic information (basicInfo): including media name, category, playback address, cover image, etc.
        /// 2. Meta information (metaData): including size, duration, video stream information, and audio stream information.
        /// 3. transcodeInfo: includes media addresses, video stream parameters, and audio stream parameters of various specifications generated for the transcoded media.
        /// 4. animatedGraphicsInfo: The animated graphics info after converting a video to gif (for example, gif).
        /// 5. sampleSnapshotInfo: screenshot information after sampling screenshots from the video.
        /// 6. Sprite image information (imageSpriteInfo): sprite image information after capturing sprite images from a video.
        /// 7. snapshotByTimeOffsetInfo: screenshot information after taking screenshots of a video at specified time points.
        /// 8. Video timestamp information (keyFrameDescInfo): Dotting information set for the video.
        /// 9. Adaptive Bitrate Streaming information (adaptiveDynamicStreamingInfo): information including specification, encryption type, and packaging format.
        /// 
        /// -Permission to sort results by creation time and return in pages. Use Offset and Limit (see input parameters) to control pagination.
        /// 
        /// <div id="maxResultsDesc">API return result count limit:</div>
        /// 
        /// -<b><a href="#p_offset">Offset</a> and <a href="#p_limit">Limit</a> impact the number of results per pagination query. Special attention: when both are omitted, this interface returns up to 10 query results by default.</b>
        /// -<b>Supports returning up to 5,000 search results. Results beyond this limit can no longer be queried. If the search result volume is too large, recommend using more granular criteria to reduce the search results.</b>
        /// 
        /// <br>Conditional filtering not recommended:
        /// - (Not recommended: use Names, NamePrefixes, or Descriptions instead) Specify single text Text for fuzzy search on media file name or description.
        /// -(Not recommended: use SourceTypes instead) Specify a single media file source SourceType for search.
        /// -(Not recommended: Use StreamIds instead) Specify a single push stream live code StreamId to search.
        /// -(Not recommended: use CreateTime as an alternative) Specify a single starting creation time StartTime to search.
        /// -(Not recommended: use CreateTime instead) Specify a single end time EndTime to search.
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public SearchMediaResponse SearchMediaSync(SearchMediaRequest req)
        {
            return InternalRequestAsync<SearchMediaResponse>(req, "SearchMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Use natural language to conduct semantic search on media.
        /// </summary>
        /// <param name="req"><see cref="SearchMediaBySemanticsRequest"/></param>
        /// <returns><see cref="SearchMediaBySemanticsResponse"/></returns>
        public Task<SearchMediaBySemanticsResponse> SearchMediaBySemantics(SearchMediaBySemanticsRequest req)
        {
            return InternalRequestAsync<SearchMediaBySemanticsResponse>(req, "SearchMediaBySemantics");
        }

        /// <summary>
        /// Use natural language to conduct semantic search on media.
        /// </summary>
        /// <param name="req"><see cref="SearchMediaBySemanticsRequest"/></param>
        /// <returns><see cref="SearchMediaBySemanticsResponse"/></returns>
        public SearchMediaBySemanticsResponse SearchMediaBySemanticsSync(SearchMediaBySemanticsRequest req)
        {
            return InternalRequestAsync<SearchMediaBySemanticsResponse>(req, "SearchMediaBySemantics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set a delivery destination in CLS for a vod domain.
        /// </summary>
        /// <param name="req"><see cref="SetCLSPushTargetRequest"/></param>
        /// <returns><see cref="SetCLSPushTargetResponse"/></returns>
        public Task<SetCLSPushTargetResponse> SetCLSPushTarget(SetCLSPushTargetRequest req)
        {
            return InternalRequestAsync<SetCLSPushTargetResponse>(req, "SetCLSPushTarget");
        }

        /// <summary>
        /// Set a delivery destination in CLS for a vod domain.
        /// </summary>
        /// <param name="req"><see cref="SetCLSPushTargetRequest"/></param>
        /// <returns><see cref="SetCLSPushTargetResponse"/></returns>
        public SetCLSPushTargetResponse SetCLSPushTargetSync(SetCLSPushTargetRequest req)
        {
            return InternalRequestAsync<SetCLSPushTargetResponse>(req, "SetCLSPushTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Sets DRM key provider information.
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public Task<SetDrmKeyProviderInfoResponse> SetDrmKeyProviderInfo(SetDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<SetDrmKeyProviderInfoResponse>(req, "SetDrmKeyProviderInfo");
        }

        /// <summary>
        /// Sets DRM key provider information.
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public SetDrmKeyProviderInfoResponse SetDrmKeyProviderInfoSync(SetDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<SetDrmKeyProviderInfoResponse>(req, "SetDrmKeyProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set the HTTPS certificate for a vod domain.
        /// </summary>
        /// <param name="req"><see cref="SetVodDomainCertificateRequest"/></param>
        /// <returns><see cref="SetVodDomainCertificateResponse"/></returns>
        public Task<SetVodDomainCertificateResponse> SetVodDomainCertificate(SetVodDomainCertificateRequest req)
        {
            return InternalRequestAsync<SetVodDomainCertificateResponse>(req, "SetVodDomainCertificate");
        }

        /// <summary>
        /// Set the HTTPS certificate for a vod domain.
        /// </summary>
        /// <param name="req"><see cref="SetVodDomainCertificateRequest"/></param>
        /// <returns><see cref="SetVodDomainCertificateResponse"/></returns>
        public SetVodDomainCertificateResponse SetVodDomainCertificateSync(SetVodDomainCertificateRequest req)
        {
            return InternalRequestAsync<SetVodDomainCertificateResponse>(req, "SetVodDomainCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Crop HLS video by time period and generate a new HLS video in real time. Developers can share it immediately or save it for long-term preservation.
        /// 
        /// Tencent Cloud VOD supports two editing modes:
        /// - Clip solidification: Save the edited video as a standalone video with an independent FileId; suitable for long-term preservation of highlights.
        /// - Editing is not solidified: The edited video is attached to the input file and has no standalone FileId. This is suitable for scenarios where highlight clips are shared temporarily.
        /// 
        /// This API is used to crop an input m3u8 file. The minimum editing precision is one ts slice, so second-level or more precise editing precision cannot be achieved.
        /// 
        /// ### Edit solidification
        /// Clip solidification refers to saving an edited video as an independent video with its own FileId. Its lifecycle is not subject to any impact from the original input video. Even if the original input video is deleted, the clipping result is not affected. You can also transcode it or publish it on WeChat.
        /// 
        /// For example, a complete football match may have raw video lasting over 2 hours. For cost savings, a customer can store this video for 2 months, but specify longer storage for the edited highlights video. You can also perform additional on-demand operations on the highlights video separately, such as transcoding and publishing on WeChat. In this case, you can choose the edit and solidify solution.
        /// 
        /// The advantage of solidified edits is that their lifecycle is independent of the original input video, allowing them to be managed separately and preserved long-term.
        /// 
        /// <font color='red'>Note:</font> If solidification is specified when editing, enable reception of editing solidification event notifications through the ModifyEventConfig API. After successful solidification, you will receive a PersistenceComplete event notification. Before receiving this event notification, you should not delete or transition the original input video to colder storage. Otherwise, playback of the generated video may be abnormal.
        /// 
        /// ### Editing is not solidified
        /// Editing is not solidified, meaning the result of editing (m3u8 file) shares the same TS segments with the original input video. The newly generated video is not a standalone complete video (no independent FileId, only a playback URL), and its valid period is consistent with that of the original input full video. Once the original input video is deleted, the clip will also become unplayable.
        /// 
        /// Editing is not solidified. Since the clipping result is not an independent video, it is not included in the video management of on-demand media assets (for example, the total number of videos in the console does not count this clip). It is also unable to separately perform any video processing operations such as transcoding or WeChat publishing on this clip.
        /// 
        /// The advantage of non-solidified editing is that the editing operation is Relatively "lightweight" and will not generate additional storage overhead. However, its shortcoming is that the lifecycle is identical to the original recorded video, and it is unable to further transcode or perform other video processing.
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public Task<SimpleHlsClipResponse> SimpleHlsClip(SimpleHlsClipRequest req)
        {
            return InternalRequestAsync<SimpleHlsClipResponse>(req, "SimpleHlsClip");
        }

        /// <summary>
        /// Crop HLS video by time period and generate a new HLS video in real time. Developers can share it immediately or save it for long-term preservation.
        /// 
        /// Tencent Cloud VOD supports two editing modes:
        /// - Clip solidification: Save the edited video as a standalone video with an independent FileId; suitable for long-term preservation of highlights.
        /// - Editing is not solidified: The edited video is attached to the input file and has no standalone FileId. This is suitable for scenarios where highlight clips are shared temporarily.
        /// 
        /// This API is used to crop an input m3u8 file. The minimum editing precision is one ts slice, so second-level or more precise editing precision cannot be achieved.
        /// 
        /// ### Edit solidification
        /// Clip solidification refers to saving an edited video as an independent video with its own FileId. Its lifecycle is not subject to any impact from the original input video. Even if the original input video is deleted, the clipping result is not affected. You can also transcode it or publish it on WeChat.
        /// 
        /// For example, a complete football match may have raw video lasting over 2 hours. For cost savings, a customer can store this video for 2 months, but specify longer storage for the edited highlights video. You can also perform additional on-demand operations on the highlights video separately, such as transcoding and publishing on WeChat. In this case, you can choose the edit and solidify solution.
        /// 
        /// The advantage of solidified edits is that their lifecycle is independent of the original input video, allowing them to be managed separately and preserved long-term.
        /// 
        /// <font color='red'>Note:</font> If solidification is specified when editing, enable reception of editing solidification event notifications through the ModifyEventConfig API. After successful solidification, you will receive a PersistenceComplete event notification. Before receiving this event notification, you should not delete or transition the original input video to colder storage. Otherwise, playback of the generated video may be abnormal.
        /// 
        /// ### Editing is not solidified
        /// Editing is not solidified, meaning the result of editing (m3u8 file) shares the same TS segments with the original input video. The newly generated video is not a standalone complete video (no independent FileId, only a playback URL), and its valid period is consistent with that of the original input full video. Once the original input video is deleted, the clip will also become unplayable.
        /// 
        /// Editing is not solidified. Since the clipping result is not an independent video, it is not included in the video management of on-demand media assets (for example, the total number of videos in the console does not count this clip). It is also unable to separately perform any video processing operations such as transcoding or WeChat publishing on this clip.
        /// 
        /// The advantage of non-solidified editing is that the editing operation is Relatively "lightweight" and will not generate additional storage overhead. However, its shortcoming is that the lifecycle is identical to the original recorded video, and it is unable to further transcode or perform other video processing.
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public SimpleHlsClipResponse SimpleHlsClipSync(SimpleHlsClipRequest req)
        {
            return InternalRequestAsync<SimpleHlsClipResponse>(req, "SimpleHlsClip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to split an on-demand video into multiple new on-demand videos.
        /// </summary>
        /// <param name="req"><see cref="SplitMediaRequest"/></param>
        /// <returns><see cref="SplitMediaResponse"/></returns>
        public Task<SplitMediaResponse> SplitMedia(SplitMediaRequest req)
        {
            return InternalRequestAsync<SplitMediaResponse>(req, "SplitMedia");
        }

        /// <summary>
        /// This API is used to split an on-demand video into multiple new on-demand videos.
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
        /// Initiate a speech synthesis task to convert text into speech, oriented towards long text scenarios (maximum 200,000 characters), supporting specified timbre and synthesis parameters such as speaking rate, volume, pitch, sampling rate, and output format. Speech synthesis is an asynchronous task, and audio results are generated upon completion.
        /// </summary>
        /// <param name="req"><see cref="TextToSpeechAsyncRequest"/></param>
        /// <returns><see cref="TextToSpeechAsyncResponse"/></returns>
        public Task<TextToSpeechAsyncResponse> TextToSpeechAsync(TextToSpeechAsyncRequest req)
        {
            return InternalRequestAsync<TextToSpeechAsyncResponse>(req, "TextToSpeechAsync");
        }

        /// <summary>
        /// Initiate a speech synthesis task to convert text into speech, oriented towards long text scenarios (maximum 200,000 characters), supporting specified timbre and synthesis parameters such as speaking rate, volume, pitch, sampling rate, and output format. Speech synthesis is an asynchronous task, and audio results are generated upon completion.
        /// </summary>
        /// <param name="req"><see cref="TextToSpeechAsyncRequest"/></param>
        /// <returns><see cref="TextToSpeechAsyncResponse"/></returns>
        public TextToSpeechAsyncResponse TextToSpeechAsyncSync(TextToSpeechAsyncRequest req)
        {
            return InternalRequestAsync<TextToSpeechAsyncResponse>(req, "TextToSpeechAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate a speech synthesis task to convert text into speech.
        /// </summary>
        /// <param name="req"><see cref="TextToSpeechSyncRequest"/></param>
        /// <returns><see cref="TextToSpeechSyncResponse"/></returns>
        public Task<TextToSpeechSyncResponse> TextToSpeechSync(TextToSpeechSyncRequest req)
        {
            return InternalRequestAsync<TextToSpeechSyncResponse>(req, "TextToSpeechSync");
        }

        /// <summary>
        /// Initiate a speech synthesis task to convert text into speech.
        /// </summary>
        /// <param name="req"><see cref="TextToSpeechSyncRequest"/></param>
        /// <returns><see cref="TextToSpeechSyncResponse"/></returns>
        public TextToSpeechSyncResponse TextToSpeechSyncSync(TextToSpeechSyncRequest req)
        {
            return InternalRequestAsync<TextToSpeechSyncResponse>(req, "TextToSpeechSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Token for AIGC API calls. Data sync may delay after creation. It can be queried or deleted after about 30 seconds.
        /// </summary>
        /// <param name="req"><see cref="UpdateAigcApiTokenRequest"/></param>
        /// <returns><see cref="UpdateAigcApiTokenResponse"/></returns>
        public Task<UpdateAigcApiTokenResponse> UpdateAigcApiToken(UpdateAigcApiTokenRequest req)
        {
            return InternalRequestAsync<UpdateAigcApiTokenResponse>(req, "UpdateAigcApiToken");
        }

        /// <summary>
        /// This API is used to create a Token for AIGC API calls. Data sync may delay after creation. It can be queried or deleted after about 30 seconds.
        /// </summary>
        /// <param name="req"><see cref="UpdateAigcApiTokenRequest"/></param>
        /// <returns><see cref="UpdateAigcApiTokenResponse"/></returns>
        public UpdateAigcApiTokenResponse UpdateAigcApiTokenSync(UpdateAigcApiTokenRequest req)
        {
            return InternalRequestAsync<UpdateAigcApiTokenResponse>(req, "UpdateAigcApiToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the profile of a voice by voice ID, including its name, description, gender, age, language, tags, and scenarios, and returns the complete voice information after the update. Only voices under this account can be updated. System preset voices do not support update.
        /// 
        /// Note: Newly designed or cloned voice types cannot be updated before activation. They are activated only after the newly created voice type is used for TTS once.
        /// </summary>
        /// <param name="req"><see cref="UpdateVoiceRequest"/></param>
        /// <returns><see cref="UpdateVoiceResponse"/></returns>
        public Task<UpdateVoiceResponse> UpdateVoice(UpdateVoiceRequest req)
        {
            return InternalRequestAsync<UpdateVoiceResponse>(req, "UpdateVoice");
        }

        /// <summary>
        /// This API is used to update the profile of a voice by voice ID, including its name, description, gender, age, language, tags, and scenarios, and returns the complete voice information after the update. Only voices under this account can be updated. System preset voices do not support update.
        /// 
        /// Note: Newly designed or cloned voice types cannot be updated before activation. They are activated only after the newly created voice type is used for TTS once.
        /// </summary>
        /// <param name="req"><see cref="UpdateVoiceRequest"/></param>
        /// <returns><see cref="UpdateVoiceResponse"/></returns>
        public UpdateVoiceResponse UpdateVoiceSync(UpdateVoiceRequest req)
        {
            return InternalRequestAsync<UpdateVoiceResponse>(req, "UpdateVoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify domain name resolution values.
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public Task<VerifyDomainRecordResponse> VerifyDomainRecord(VerifyDomainRecordRequest req)
        {
            return InternalRequestAsync<VerifyDomainRecordResponse>(req, "VerifyDomainRecord");
        }

        /// <summary>
        /// This API is used to verify domain name resolution values.
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
