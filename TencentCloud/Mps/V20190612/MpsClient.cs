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

namespace TencentCloud.Mps.V20190612
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mps.V20190612.Models;

   public class MpsClient : AbstractClient{

       private const string endpoint = "mps.tencentcloudapi.com";
       private const string version = "2019-06-12";
       private const string sdkVersion = "SDK_NET_3.0.1050";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MpsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MpsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a custom content analysis template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate");
        }

        /// <summary>
        /// This API is used to create a custom content analysis template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom content recognition template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to create a custom content recognition template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public CreateAIRecognitionTemplateResponse CreateAIRecognitionTemplateSync(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an adaptive bitrate streaming template. Up up to 100 such templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<CreateAdaptiveDynamicStreamingTemplateResponse> CreateAdaptiveDynamicStreamingTemplate(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<CreateAdaptiveDynamicStreamingTemplateResponse>(req, "CreateAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// This API is used to create an adaptive bitrate streaming template. Up up to 100 such templates can be created.
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
        /// This API is used to create a custom content moderation template. Up to 50 templates can be created in total.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate");
        }

        /// <summary>
        /// This API is used to create a custom content moderation template. Up to 50 templates can be created in total.
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate")
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
        /// This API is used to create a live recording template.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate");
        }

        /// <summary>
        /// This API is used to create a live recording template.
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplateSync(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create image samples for video processing operations such as content recognition and inappropriate information detection with the help of technologies such as facial feature positioning.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample");
        }

        /// <summary>
        /// This API is used to create image samples for video processing operations such as content recognition and inappropriate information detection with the help of technologies such as facial feature positioning.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a media quality inspection template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityControlTemplateResponse"/></returns>
        public Task<CreateQualityControlTemplateResponse> CreateQualityControlTemplate(CreateQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityControlTemplateResponse>(req, "CreateQualityControlTemplate");
        }

        /// <summary>
        /// This API is used to create a media quality inspection template. Up to 50 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityControlTemplateResponse"/></returns>
        public CreateQualityControlTemplateResponse CreateQualityControlTemplateSync(CreateQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityControlTemplateResponse>(req, "CreateQualityControlTemplate")
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
        /// This API is used to create a scheme for media files uploaded to a specified COS bucket. A scheme may include the following tasks:
        /// 1. Video transcoding (with watermark)
        /// 2. Animated screenshot generating
        /// 3. Time point screencapturing
        /// 4. Sampled screencapturing
        /// 5. Image sprite generating
        /// 6. Adaptive bitrate streaming
        /// 7. Intelligent content moderation (detection of pornographic and sensitive content)
        /// 8. Intelligent content analysis (labeling, categorization, thumbnail generation, labeling by frame)
        /// 9. Intelligent content recognition (face, full text, text keyword, full speech, and speech keyword)
        /// 
        /// Note: A scheme is disabled upon creation. You need to manually enable it.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduleRequest"/></param>
        /// <returns><see cref="CreateScheduleResponse"/></returns>
        public Task<CreateScheduleResponse> CreateSchedule(CreateScheduleRequest req)
        {
            return InternalRequestAsync<CreateScheduleResponse>(req, "CreateSchedule");
        }

        /// <summary>
        /// This API is used to create a scheme for media files uploaded to a specified COS bucket. A scheme may include the following tasks:
        /// 1. Video transcoding (with watermark)
        /// 2. Animated screenshot generating
        /// 3. Time point screencapturing
        /// 4. Sampled screencapturing
        /// 5. Image sprite generating
        /// 6. Adaptive bitrate streaming
        /// 7. Intelligent content moderation (detection of pornographic and sensitive content)
        /// 8. Intelligent content analysis (labeling, categorization, thumbnail generation, labeling by frame)
        /// 9. Intelligent content recognition (face, full text, text keyword, full speech, and speech keyword)
        /// 
        /// Note: A scheme is disabled upon creation. You need to manually enable it.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduleRequest"/></param>
        /// <returns><see cref="CreateScheduleResponse"/></returns>
        public CreateScheduleResponse CreateScheduleSync(CreateScheduleRequest req)
        {
            return InternalRequestAsync<CreateScheduleResponse>(req, "CreateSchedule")
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
        /// This API is used to create a custom transcoding template. Up to 1,000 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate");
        }

        /// <summary>
        /// This API is used to create a custom transcoding template. Up to 1,000 templates can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate")
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
        /// This API is used to create keyword samples in batches for video processing operations such as content recognition and inappropriate information detection with the help of the OCR and ASR technologies.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples");
        }

        /// <summary>
        /// This API is used to create keyword samples in batches for video processing operations such as content recognition and inappropriate information detection with the help of the OCR and ASR technologies.
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public CreateWordSamplesResponse CreateWordSamplesSync(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a workflow for media files uploaded to a specified COS bucket. A workflow may include the following tasks:
        /// 1. Video transcoding (with watermark)
        /// 2. Animated image generating
        /// 3. Time point screencapturing
        /// 4. Sampled screencapturing
        /// 5. Image sprite generating
        /// 6. Adaptive bitrate streaming
        /// 7. Intelligent content moderation (detection of pornographic and sensitive content)
        /// 8. Intelligent content analysis (labeling, categorization, thumbnail generation, frame-specific labeling)
        /// 9. Intelligent content recognition (face, full text, text keyword, full speech, and speech keyword)
        /// 
        /// Note: A workflow is disabled upon creation. You need to manually enable it.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow");
        }

        /// <summary>
        /// This API is used to create a workflow for media files uploaded to a specified COS bucket. A workflow may include the following tasks:
        /// 1. Video transcoding (with watermark)
        /// 2. Animated image generating
        /// 3. Time point screencapturing
        /// 4. Sampled screencapturing
        /// 5. Image sprite generating
        /// 6. Adaptive bitrate streaming
        /// 7. Intelligent content moderation (detection of pornographic and sensitive content)
        /// 8. Intelligent content analysis (labeling, categorization, thumbnail generation, frame-specific labeling)
        /// 9. Intelligent content recognition (face, full text, text keyword, full speech, and speech keyword)
        /// 
        /// Note: A workflow is disabled upon creation. You need to manually enable it.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom content analysis template.
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
        /// This API is used to delete a custom content analysis template.
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
        /// This API is used to delete a custom content recognition template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom content recognition template.
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
        /// This API is used to delete a custom content moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate");
        }

        /// <summary>
        /// This API is used to delete a custom content moderation template.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate")
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
        /// This API is used to delete a live recording template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate");
        }

        /// <summary>
        /// This API is used to delete a live recording template.
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplateSync(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete image samples by image ID.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample");
        }

        /// <summary>
        /// This API is used to delete image samples by image ID.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityControlTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityControlTemplateResponse"/></returns>
        public Task<DeleteQualityControlTemplateResponse> DeleteQualityControlTemplate(DeleteQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityControlTemplateResponse>(req, "DeleteQualityControlTemplate");
        }

        /// <summary>
        /// This API is used to delete a media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityControlTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityControlTemplateResponse"/></returns>
        public DeleteQualityControlTemplateResponse DeleteQualityControlTemplateSync(DeleteQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityControlTemplateResponse>(req, "DeleteQualityControlTemplate")
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
        /// This API is used to delete a scheme.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduleRequest"/></param>
        /// <returns><see cref="DeleteScheduleResponse"/></returns>
        public Task<DeleteScheduleResponse> DeleteSchedule(DeleteScheduleRequest req)
        {
            return InternalRequestAsync<DeleteScheduleResponse>(req, "DeleteSchedule");
        }

        /// <summary>
        /// This API is used to delete a scheme.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduleRequest"/></param>
        /// <returns><see cref="DeleteScheduleResponse"/></returns>
        public DeleteScheduleResponse DeleteScheduleSync(DeleteScheduleRequest req)
        {
            return InternalRequestAsync<DeleteScheduleResponse>(req, "DeleteSchedule")
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
        /// This API is used to delete a workflow. An enabled workflow must be disabled before it can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public Task<DeleteWorkflowResponse> DeleteWorkflow(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow");
        }

        /// <summary>
        /// This API is used to delete a workflow. An enabled workflow must be disabled before it can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public DeleteWorkflowResponse DeleteWorkflowSync(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of content analysis templates based on unique template ID. The returned result includes all eligible custom and preset video content analysis templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates");
        }

        /// <summary>
        /// This API is used to get the list of content analysis templates based on unique template ID. The returned result includes all eligible custom and preset video content analysis templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of content recognition templates based on unique template ID. The return result includes all eligible custom and preset content recognition templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates");
        }

        /// <summary>
        /// This API is used to get the list of content recognition templates based on unique template ID. The return result includes all eligible custom and preset content recognition templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public DescribeAIRecognitionTemplatesResponse DescribeAIRecognitionTemplatesSync(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of adaptive bitrate streaming templates and supports paginated queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public Task<DescribeAdaptiveDynamicStreamingTemplatesResponse> DescribeAdaptiveDynamicStreamingTemplates(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates");
        }

        /// <summary>
        /// This API is used to query the list of adaptive bitrate streaming templates and supports paginated queries by filters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public DescribeAdaptiveDynamicStreamingTemplatesResponse DescribeAdaptiveDynamicStreamingTemplatesSync(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates")
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
        /// This API is used to query content moderation templates by template ID. Both custom and preset templates that match the template IDs passed in will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates");
        }

        /// <summary>
        /// This API is used to query content moderation templates by template ID. Both custom and preset templates that match the template IDs passed in will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates")
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
        /// This API is used to get a live recording template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public Task<DescribeLiveRecordTemplatesResponse> DescribeLiveRecordTemplates(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates");
        }

        /// <summary>
        /// This API is used to get a live recording template.
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public DescribeLiveRecordTemplatesResponse DescribeLiveRecordTemplatesSync(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the metadata of media, such as video image width/height, codec, length, and frame rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaMetaDataRequest"/></param>
        /// <returns><see cref="DescribeMediaMetaDataResponse"/></returns>
        public Task<DescribeMediaMetaDataResponse> DescribeMediaMetaData(DescribeMediaMetaDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaMetaDataResponse>(req, "DescribeMediaMetaData");
        }

        /// <summary>
        /// This API is used to get the metadata of media, such as video image width/height, codec, length, and frame rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaMetaDataRequest"/></param>
        /// <returns><see cref="DescribeMediaMetaDataResponse"/></returns>
        public DescribeMediaMetaDataResponse DescribeMediaMetaDataSync(DescribeMediaMetaDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaMetaDataResponse>(req, "DescribeMediaMetaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of image samples. It supports paginated queries by image ID, name, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples");
        }

        /// <summary>
        /// This API is used to query the information of image samples. It supports paginated queries by image ID, name, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public DescribePersonSamplesResponse DescribePersonSamplesSync(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query custom media quality inspection templates, supporting paged queries by conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTemplatesResponse"/></returns>
        public Task<DescribeQualityControlTemplatesResponse> DescribeQualityControlTemplates(DescribeQualityControlTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityControlTemplatesResponse>(req, "DescribeQualityControlTemplates");
        }

        /// <summary>
        /// This API is used to query custom media quality inspection templates, supporting paged queries by conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTemplatesResponse"/></returns>
        public DescribeQualityControlTemplatesResponse DescribeQualityControlTemplatesSync(DescribeQualityControlTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityControlTemplatesResponse>(req, "DescribeQualityControlTemplates")
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
        /// This API is used to query a scheme.
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulesRequest"/></param>
        /// <returns><see cref="DescribeSchedulesResponse"/></returns>
        public Task<DescribeSchedulesResponse> DescribeSchedules(DescribeSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeSchedulesResponse>(req, "DescribeSchedules");
        }

        /// <summary>
        /// This API is used to query a scheme.
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulesRequest"/></param>
        /// <returns><see cref="DescribeSchedulesResponse"/></returns>
        public DescribeSchedulesResponse DescribeSchedulesSync(DescribeSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeSchedulesResponse>(req, "DescribeSchedules")
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
        /// * This API is used to query tasks.
        /// * If the data is large, one API call may not be able to obtain all the tasks in the query. You can use the `ScrollToken` parameter to query tasks with multiple calls.
        /// * Only tasks in the last seven days (168 hours) can be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// * This API is used to query tasks.
        /// * If the data is large, one API call may not be able to obtain all the tasks in the query. You can use the `ScrollToken` parameter to query tasks with multiple calls.
        /// * Only tasks in the last seven days (168 hours) can be queried.
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
        /// This API is used to perform paged queries of keyword sample information by use case, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples");
        }

        /// <summary>
        /// This API is used to perform paged queries of keyword sample information by use case, keyword, and tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public DescribeWordSamplesResponse DescribeWordSamplesSync(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of workflow details by workflow ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowsResponse"/></returns>
        public Task<DescribeWorkflowsResponse> DescribeWorkflows(DescribeWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowsResponse>(req, "DescribeWorkflows");
        }

        /// <summary>
        /// This API is used to get the list of workflow details by workflow ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowsResponse"/></returns>
        public DescribeWorkflowsResponse DescribeWorkflowsSync(DescribeWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowsResponse>(req, "DescribeWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a scheme.
        /// </summary>
        /// <param name="req"><see cref="DisableScheduleRequest"/></param>
        /// <returns><see cref="DisableScheduleResponse"/></returns>
        public Task<DisableScheduleResponse> DisableSchedule(DisableScheduleRequest req)
        {
            return InternalRequestAsync<DisableScheduleResponse>(req, "DisableSchedule");
        }

        /// <summary>
        /// This API is used to disable a scheme.
        /// </summary>
        /// <param name="req"><see cref="DisableScheduleRequest"/></param>
        /// <returns><see cref="DisableScheduleResponse"/></returns>
        public DisableScheduleResponse DisableScheduleSync(DisableScheduleRequest req)
        {
            return InternalRequestAsync<DisableScheduleResponse>(req, "DisableSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a workflow.
        /// </summary>
        /// <param name="req"><see cref="DisableWorkflowRequest"/></param>
        /// <returns><see cref="DisableWorkflowResponse"/></returns>
        public Task<DisableWorkflowResponse> DisableWorkflow(DisableWorkflowRequest req)
        {
            return InternalRequestAsync<DisableWorkflowResponse>(req, "DisableWorkflow");
        }

        /// <summary>
        /// This API is used to disable a workflow.
        /// </summary>
        /// <param name="req"><see cref="DisableWorkflowRequest"/></param>
        /// <returns><see cref="DisableWorkflowResponse"/></returns>
        public DisableWorkflowResponse DisableWorkflowSync(DisableWorkflowRequest req)
        {
            return InternalRequestAsync<DisableWorkflowResponse>(req, "DisableWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a video to generate a new one. Editing features include:
        ///  
        /// 
        /// 1. **Editing task**: simple video editing, such as clipping and splicing.
        /// 1) Edit a file to generate a new video.
        /// 2) Splice multiple files to generate a new video.
        /// 3) Edit multiple files and then splice them to generate a new video.
        /// 
        /// 2. **Compositing task**: Generate a new video by describing information through APIs.
        /// 1) Multi-track (video, audio, and subtitles) and multi-type elements (video, image, audio, text, and empty).
        /// 2) Image level: mapping, zoom in/out, arbitrary rotation, mirroring, and more.
        /// 3) Audio level: volume control, fade in/out, mixing, and more.
        /// 4) Video level: transition, playback speed adjustment, splicing, clipping, subtitles, picture-in-picture, audio-video separation, entrance and exit animations, and more.
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public Task<EditMediaResponse> EditMedia(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia");
        }

        /// <summary>
        /// This API is used to edit a video to generate a new one. Editing features include:
        ///  
        /// 
        /// 1. **Editing task**: simple video editing, such as clipping and splicing.
        /// 1) Edit a file to generate a new video.
        /// 2) Splice multiple files to generate a new video.
        /// 3) Edit multiple files and then splice them to generate a new video.
        /// 
        /// 2. **Compositing task**: Generate a new video by describing information through APIs.
        /// 1) Multi-track (video, audio, and subtitles) and multi-type elements (video, image, audio, text, and empty).
        /// 2) Image level: mapping, zoom in/out, arbitrary rotation, mirroring, and more.
        /// 3) Audio level: volume control, fade in/out, mixing, and more.
        /// 4) Video level: transition, playback speed adjustment, splicing, clipping, subtitles, picture-in-picture, audio-video separation, entrance and exit animations, and more.
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public EditMediaResponse EditMediaSync(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a scheme.
        /// </summary>
        /// <param name="req"><see cref="EnableScheduleRequest"/></param>
        /// <returns><see cref="EnableScheduleResponse"/></returns>
        public Task<EnableScheduleResponse> EnableSchedule(EnableScheduleRequest req)
        {
            return InternalRequestAsync<EnableScheduleResponse>(req, "EnableSchedule");
        }

        /// <summary>
        /// This API is used to enable a scheme.
        /// </summary>
        /// <param name="req"><see cref="EnableScheduleRequest"/></param>
        /// <returns><see cref="EnableScheduleResponse"/></returns>
        public EnableScheduleResponse EnableScheduleSync(EnableScheduleRequest req)
        {
            return InternalRequestAsync<EnableScheduleResponse>(req, "EnableSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a workflow.
        /// </summary>
        /// <param name="req"><see cref="EnableWorkflowRequest"/></param>
        /// <returns><see cref="EnableWorkflowResponse"/></returns>
        public Task<EnableWorkflowResponse> EnableWorkflow(EnableWorkflowRequest req)
        {
            return InternalRequestAsync<EnableWorkflowResponse>(req, "EnableWorkflow");
        }

        /// <summary>
        /// This API is used to enable a workflow.
        /// </summary>
        /// <param name="req"><see cref="EnableWorkflowRequest"/></param>
        /// <returns><see cref="EnableWorkflowResponse"/></returns>
        public EnableWorkflowResponse EnableWorkflowSync(EnableWorkflowRequest req)
        {
            return InternalRequestAsync<EnableWorkflowResponse>(req, "EnableWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is reserved for special circumstances. Do not use it unless you are directed to use it by technical support.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction");
        }

        /// <summary>
        /// This API is reserved for special circumstances. Do not use it unless you are directed to use it by technical support.
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction")
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
        /// This API is used to modify a custom content analysis template.
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
        /// This API is used to modify a custom content analysis template.
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
        /// This API is used to modify a custom content recognition template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom content recognition template.
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
        /// This API is used to modify a custom content moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate");
        }

        /// <summary>
        /// This API is used to modify a custom content moderation template.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate")
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
        /// This API is used to modify a live recording template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public Task<ModifyLiveRecordTemplateResponse> ModifyLiveRecordTemplate(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate");
        }

        /// <summary>
        /// This API is used to modify a live recording template.
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public ModifyLiveRecordTemplateResponse ModifyLiveRecordTemplateSync(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify image samples by image ID. You can use it to modify the name and description of an image sample and add/delete/reset facial features or tags. There must be at least one image left after the deletion of facial features; otherwise, please reset instead of delete the facial features.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample");
        }

        /// <summary>
        /// This API is used to modify image samples by image ID. You can use it to modify the name and description of an image sample and add/delete/reset facial features or tags. There must be at least one image left after the deletion of facial features; otherwise, please reset instead of delete the facial features.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public ModifyPersonSampleResponse ModifyPersonSampleSync(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityControlTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityControlTemplateResponse"/></returns>
        public Task<ModifyQualityControlTemplateResponse> ModifyQualityControlTemplate(ModifyQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityControlTemplateResponse>(req, "ModifyQualityControlTemplate");
        }

        /// <summary>
        /// This API is used to modify a media quality inspection template.
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityControlTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityControlTemplateResponse"/></returns>
        public ModifyQualityControlTemplateResponse ModifyQualityControlTemplateSync(ModifyQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityControlTemplateResponse>(req, "ModifyQualityControlTemplate")
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
        /// This API is used to modify a scheme.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduleRequest"/></param>
        /// <returns><see cref="ModifyScheduleResponse"/></returns>
        public Task<ModifyScheduleResponse> ModifySchedule(ModifyScheduleRequest req)
        {
            return InternalRequestAsync<ModifyScheduleResponse>(req, "ModifySchedule");
        }

        /// <summary>
        /// This API is used to modify a scheme.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduleRequest"/></param>
        /// <returns><see cref="ModifyScheduleResponse"/></returns>
        public ModifyScheduleResponse ModifyScheduleSync(ModifyScheduleRequest req)
        {
            return InternalRequestAsync<ModifyScheduleResponse>(req, "ModifySchedule")
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
        /// This API is used to parse the content of an MPS live stream processing event notification from the `msgBody` field in the message received from CMQ.
        /// Instead of initiating a video processing task, this API is used to help generate SDKs for various programming languages. You can parse the event notification based on the analytic function of the SDKs.
        /// </summary>
        /// <param name="req"><see cref="ParseLiveStreamProcessNotificationRequest"/></param>
        /// <returns><see cref="ParseLiveStreamProcessNotificationResponse"/></returns>
        public Task<ParseLiveStreamProcessNotificationResponse> ParseLiveStreamProcessNotification(ParseLiveStreamProcessNotificationRequest req)
        {
            return InternalRequestAsync<ParseLiveStreamProcessNotificationResponse>(req, "ParseLiveStreamProcessNotification");
        }

        /// <summary>
        /// This API is used to parse the content of an MPS live stream processing event notification from the `msgBody` field in the message received from CMQ.
        /// Instead of initiating a video processing task, this API is used to help generate SDKs for various programming languages. You can parse the event notification based on the analytic function of the SDKs.
        /// </summary>
        /// <param name="req"><see cref="ParseLiveStreamProcessNotificationRequest"/></param>
        /// <returns><see cref="ParseLiveStreamProcessNotificationResponse"/></returns>
        public ParseLiveStreamProcessNotificationResponse ParseLiveStreamProcessNotificationSync(ParseLiveStreamProcessNotificationRequest req)
        {
            return InternalRequestAsync<ParseLiveStreamProcessNotificationResponse>(req, "ParseLiveStreamProcessNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to parse the content of an MPS event notification from the `msgBody` field in the message received from CMQ.
        /// Instead of initiating a video processing task, this API is used to help generate SDKs for various programming languages. You can parse the event notification based on the analytic function of the SDKs.
        /// </summary>
        /// <param name="req"><see cref="ParseNotificationRequest"/></param>
        /// <returns><see cref="ParseNotificationResponse"/></returns>
        public Task<ParseNotificationResponse> ParseNotification(ParseNotificationRequest req)
        {
            return InternalRequestAsync<ParseNotificationResponse>(req, "ParseNotification");
        }

        /// <summary>
        /// This API is used to parse the content of an MPS event notification from the `msgBody` field in the message received from CMQ.
        /// Instead of initiating a video processing task, this API is used to help generate SDKs for various programming languages. You can parse the event notification based on the analytic function of the SDKs.
        /// </summary>
        /// <param name="req"><see cref="ParseNotificationRequest"/></param>
        /// <returns><see cref="ParseNotificationResponse"/></returns>
        public ParseNotificationResponse ParseNotificationSync(ParseNotificationRequest req)
        {
            return InternalRequestAsync<ParseNotificationResponse>(req, "ParseNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate image processing. Its features include:
        /// 1. Format conversion;
        /// 2. Image enhancement;
        /// </summary>
        /// <param name="req"><see cref="ProcessImageRequest"/></param>
        /// <returns><see cref="ProcessImageResponse"/></returns>
        public Task<ProcessImageResponse> ProcessImage(ProcessImageRequest req)
        {
            return InternalRequestAsync<ProcessImageResponse>(req, "ProcessImage");
        }

        /// <summary>
        /// This API is used to initiate image processing. Its features include:
        /// 1. Format conversion;
        /// 2. Image enhancement;
        /// </summary>
        /// <param name="req"><see cref="ProcessImageRequest"/></param>
        /// <returns><see cref="ProcessImageResponse"/></returns>
        public ProcessImageResponse ProcessImageSync(ProcessImageRequest req)
        {
            return InternalRequestAsync<ProcessImageResponse>(req, "ProcessImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate live stream processing tasks. Such tasks may include the following:
        /// 
        /// * Intelligent content moderation (detection of pornographic content in images and audio, detection of sensitive information)
        /// * Intelligent content recognition (face, full text, text keyword, full speech, speech keyword, real-time speech translation, object recognition, game event tracking)
        /// * Intelligent content analysis (real-time news splitting)
        /// * Quality control, including recognizing live stream format, checking audio/video content for flickering, blur, low light, overexposure, black bars, white bars, black screen, white screen, noise, pixelation, QR code, etc., and no-reference scoring.
        /// * Recording
        /// 
        /// HTTP callbacks are supported for live stream processing events. Notifications can also be written in real time to and read from a CMQ queue. The output files of processing tasks are saved to the storage you specify.
        /// </summary>
        /// <param name="req"><see cref="ProcessLiveStreamRequest"/></param>
        /// <returns><see cref="ProcessLiveStreamResponse"/></returns>
        public Task<ProcessLiveStreamResponse> ProcessLiveStream(ProcessLiveStreamRequest req)
        {
            return InternalRequestAsync<ProcessLiveStreamResponse>(req, "ProcessLiveStream");
        }

        /// <summary>
        /// This API is used to initiate live stream processing tasks. Such tasks may include the following:
        /// 
        /// * Intelligent content moderation (detection of pornographic content in images and audio, detection of sensitive information)
        /// * Intelligent content recognition (face, full text, text keyword, full speech, speech keyword, real-time speech translation, object recognition, game event tracking)
        /// * Intelligent content analysis (real-time news splitting)
        /// * Quality control, including recognizing live stream format, checking audio/video content for flickering, blur, low light, overexposure, black bars, white bars, black screen, white screen, noise, pixelation, QR code, etc., and no-reference scoring.
        /// * Recording
        /// 
        /// HTTP callbacks are supported for live stream processing events. Notifications can also be written in real time to and read from a CMQ queue. The output files of processing tasks are saved to the storage you specify.
        /// </summary>
        /// <param name="req"><see cref="ProcessLiveStreamRequest"/></param>
        /// <returns><see cref="ProcessLiveStreamResponse"/></returns>
        public ProcessLiveStreamResponse ProcessLiveStreamSync(ProcessLiveStreamRequest req)
        {
            return InternalRequestAsync<ProcessLiveStreamResponse>(req, "ProcessLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate a processing task for video URLs or media files in Cloud Object Storage (COS). Features include:
        /// 1. Video transcoding (standard transcoding, TSC transcoding, and audio/video enhancement);
        /// 2. Animated image generating;
        /// 3. Screenshot taking at specified time points;
        /// 4. Sampled screenshot taking;
        /// 5. Sprite screenshot taking;
        /// 6. Transcoding to adaptive bitrate streaming;
        /// 7. Intelligent auditing (porn detection and sensitive information detection);
        /// 8. Intelligent analysis (tagging, classification, thumbnail generating, frame-by-frame tagging, video splitting, highlights generating, opening and closing segments recognition, and game timestamping);
        /// 9. Intelligent identification (face, full text, text keyword, full speech, speech keyword, speech translation, and object recognition);
        /// 
        /// 10. Media quality inspection (live stream format diagnosis, audio and video content detection (jitter, blur, low light, overexposure, black and white edges, black and white screens, screen glitch, noise, mosaic, QR code, and more), and no-reference scoring).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia");
        }

        /// <summary>
        /// This API is used to initiate a processing task for video URLs or media files in Cloud Object Storage (COS). Features include:
        /// 1. Video transcoding (standard transcoding, TSC transcoding, and audio/video enhancement);
        /// 2. Animated image generating;
        /// 3. Screenshot taking at specified time points;
        /// 4. Sampled screenshot taking;
        /// 5. Sprite screenshot taking;
        /// 6. Transcoding to adaptive bitrate streaming;
        /// 7. Intelligent auditing (porn detection and sensitive information detection);
        /// 8. Intelligent analysis (tagging, classification, thumbnail generating, frame-by-frame tagging, video splitting, highlights generating, opening and closing segments recognition, and game timestamping);
        /// 9. Intelligent identification (face, full text, text keyword, full speech, speech keyword, speech translation, and object recognition);
        /// 
        /// 10. Media quality inspection (live stream format diagnosis, audio and video content detection (jitter, blur, low light, overexposure, black and white edges, black and white screens, screen glitch, noise, mosaic, QR code, and more), and no-reference scoring).
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public ProcessMediaResponse ProcessMediaSync(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset an existing workflow that is disabled.
        /// </summary>
        /// <param name="req"><see cref="ResetWorkflowRequest"/></param>
        /// <returns><see cref="ResetWorkflowResponse"/></returns>
        public Task<ResetWorkflowResponse> ResetWorkflow(ResetWorkflowRequest req)
        {
            return InternalRequestAsync<ResetWorkflowResponse>(req, "ResetWorkflow");
        }

        /// <summary>
        /// This API is used to reset an existing workflow that is disabled.
        /// </summary>
        /// <param name="req"><see cref="ResetWorkflowRequest"/></param>
        /// <returns><see cref="ResetWorkflowResponse"/></returns>
        public ResetWorkflowResponse ResetWorkflowSync(ResetWorkflowRequest req)
        {
            return InternalRequestAsync<ResetWorkflowResponse>(req, "ResetWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
