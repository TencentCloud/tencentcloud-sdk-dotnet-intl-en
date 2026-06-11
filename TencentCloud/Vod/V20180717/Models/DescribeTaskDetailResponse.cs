/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Task type. Valid values: <li>Procedure: Video processing task;</li><li>EditMedia: Video editing task;</li><li>SplitMedia: Video splitting task;</li><li>ComposeMedia: Media file creation task;</li><li>WechatPublish: WeChat publishing task;</li><li>WechatMiniProgramPublish: WeChat Mini Program Video Publishing Task;</li><li>PullUpload: Pull and upload media files task;</li><li>FastClipMedia: Quick trimming task;</li><li>RemoveWatermarkTask: Intelligent watermark removal task;</li><li>DescribeFileAttributesTask: File attribute retrieval task;</li><li>RebuildMedia: Audio and video quality regeneration task (not recommended);</li><li>ReviewAudioVideo: Audio/video moderation task;</li><li>ExtractTraceWatermark: Source watermark extraction task;</li><li>ExtractCopyRightWatermark: Copyright Watermark Extraction Task;</li><li>QualityInspect: Audio and video quality inspection task;</li><li>QualityEnhance: Audio and video quality regeneration task;</li><li>ComplexAdaptiveDynamicStreaming: Complex adaptive bitstream task;</li><li>ProcessMediaByMPS: MPS video processing task;</li><li>AigcImageTask: AIGC image generation task;</li><li>SceneAigcImageTask: Scenario-based AIGC image generation task;</li><li>AigcVideoTask: AIGC video generation task;</li><li>ImportMediaKnowledge: Import media knowledge task.</li><li>SceneAigcVideoTask: Scenario-based AIGC video generation task;</li><li>ExtractBlindWatermark: Digital watermark extraction task.</li><li>ExtractBlindWatermark: Digital watermark extraction task.</li><li>CreateAigcAdvancedCustomElement: Create custom subject task</li><li>CreateAigcCustomVoice: Create custom voice type task</li><li>CreateAigcSubject: Create subject task</li><li>AigcVideoRedrawTask: AIGC video redraw task</li><li>CreateAigcAudioClone: AIGC voice clone task</li><li>DescribeAigcFaceInfoAsync: Asynchronously fetch AIGC face information task</li></p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>Task status. Value:</p><li>WAITING: Waiting;</li><li>PROCESSING: Processing;</li><li>FINISH: Completed;</li><li>ABORTED: Terminated.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Task creation time in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Task execution start time in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO datetime format</a>.</p>
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// <p>Task execution completion time in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO datetime format</a>.</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>Video processing task information. This field has a value only when TaskType is Procedure.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcedureTask")]
        public ProcedureTask ProcedureTask{ get; set; }

        /// <summary>
        /// <p>Video editing task information. This field has a value only when TaskType is EditMedia.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EditMediaTask")]
        public EditMediaTask EditMediaTask{ get; set; }

        /// <summary>
        /// <p>WeChat publishing task information. This field has a value only when TaskType is WechatPublish.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatPublishTask")]
        public WechatPublishTask WechatPublishTask{ get; set; }

        /// <summary>
        /// <p>Media file production task information. This field has a value only when TaskType is ComposeMedia.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComposeMediaTask")]
        public ComposeMediaTask ComposeMediaTask{ get; set; }

        /// <summary>
        /// <p>Video splitting task information. This field has a value only when TaskType is SplitMedia.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SplitMediaTask")]
        public SplitMediaTask SplitMediaTask{ get; set; }

        /// <summary>
        /// <p>WeChat Mini Program publishing task information. This field has a value only when TaskType is WechatMiniProgramPublish.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishTask")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishTask{ get; set; }

        /// <summary>
        /// <p>Pull and upload media files task information. This field has a value only when TaskType is PullUpload.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PullUploadTask")]
        public PullUploadTask PullUploadTask{ get; set; }

        /// <summary>
        /// <p>Video transcoding task information. This field has a value only when TaskType is Transcode.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public TranscodeTask2017 TranscodeTask{ get; set; }

        /// <summary>
        /// <p>Video splicing task information. This field has a value only when TaskType is Concat.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConcatTask")]
        public ConcatTask2017 ConcatTask{ get; set; }

        /// <summary>
        /// <p>Video editing task information. This field has a value only when TaskType is Clip.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClipTask")]
        public ClipTask2017 ClipTask{ get; set; }

        /// <summary>
        /// <p>Capturing sprite image task information. This field has a value only when TaskType is ImageSprite.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateImageSpriteTask")]
        public CreateImageSpriteTask2017 CreateImageSpriteTask{ get; set; }

        /// <summary>
        /// <p>Video screenshot at specified time task information. This field has a value only when TaskType is SnapshotByTimeOffset.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// <p>Intelligent watermark removal task information. This field has a value only when TaskType is RemoveWatermark.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RemoveWatermarkTask")]
        public RemoveWatermarkTask RemoveWatermarkTask{ get; set; }

        /// <summary>
        /// <p>Audio and video quality revival task information. This field has a value only when TaskType is RebuildMedia.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RebuildMediaTask")]
        public RebuildMediaTask RebuildMediaTask{ get; set; }

        /// <summary>
        /// <p>Information about the traceability watermark extraction task. This field has a value only when TaskType is ExtractTraceWatermark.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkTask")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkTask{ get; set; }

        /// <summary>
        /// <p>Information about the copyright watermark extraction task. This field has a value only when TaskType is ExtractCopyRightWatermark.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtractCopyRightWatermarkTask")]
        public ExtractCopyRightWatermarkTask ExtractCopyRightWatermarkTask{ get; set; }

        /// <summary>
        /// <p>Audio/video moderation task info. This field has a value only when TaskType is ReviewAudioVideo.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReviewAudioVideoTask")]
        public ReviewAudioVideoTask ReviewAudioVideoTask{ get; set; }

        /// <summary>
        /// <p>This field is invalid.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReduceMediaBitrateTask")]
        public ReduceMediaBitrateTask ReduceMediaBitrateTask{ get; set; }

        /// <summary>
        /// <p>File attribute acquisition task information. This field has a value only when TaskType is DescribeFileAttributes.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DescribeFileAttributesTask")]
        public DescribeFileAttributesTask DescribeFileAttributesTask{ get; set; }

        /// <summary>
        /// <p>Audio and video quality detection task information. This field has a value only when TaskType is QualityInspect.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityInspectTask")]
        public QualityInspectTask QualityInspectTask{ get; set; }

        /// <summary>
        /// <p>Audio and video quality revival task information. This field has a value only when TaskType is QualityEnhance.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityEnhanceTask")]
        public QualityEnhanceTask QualityEnhanceTask{ get; set; }

        /// <summary>
        /// <p>Complex adaptive bitrate task information. This field has a value only when TaskType is ComplexAdaptiveDynamicStreaming.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComplexAdaptiveDynamicStreamingTask")]
        public ComplexAdaptiveDynamicStreamingTask ComplexAdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// <p>MPS video processing task information. This field has a value only when TaskType is ProcessMediaByMPS.</p>
        /// </summary>
        [JsonProperty("ProcessMediaByMPSTask")]
        public ProcessMediaByMPS ProcessMediaByMPSTask{ get; set; }

        /// <summary>
        /// <p>AIGC image generation task info. This field has a value only when TaskType is AigcImageTask.</p>
        /// </summary>
        [JsonProperty("AigcImageTask")]
        public AigcImageTask AigcImageTask{ get; set; }

        /// <summary>
        /// <p>AIGC video task information. This field has a value only when TaskType is AigcVideoTask.</p>
        /// </summary>
        [JsonProperty("AigcVideoTask")]
        public AigcVideoTask AigcVideoTask{ get; set; }

        /// <summary>
        /// <p>Media import knowledge base task info. This field has a value only when TaskType is ImportMediaKnowledge.</p>
        /// </summary>
        [JsonProperty("ImportMediaKnowledge")]
        public ImportMediaKnowledgeTask ImportMediaKnowledge{ get; set; }

        /// <summary>
        /// <p>Scenario-based AIGC image generation task info. This field has a value only when TaskType is SceneAigcImageTask.</p>
        /// </summary>
        [JsonProperty("SceneAigcImageTask")]
        public SceneAigcImageTask SceneAigcImageTask{ get; set; }

        /// <summary>
        /// <p>Scenario-based AIGC video task info. This field has a value only when TaskType is SceneAigcVideoTask.</p>
        /// </summary>
        [JsonProperty("SceneAigcVideoTask")]
        public SceneAigcVideoTask SceneAigcVideoTask{ get; set; }

        /// <summary>
        /// <p>Asynchronous image processing task information. This field has a value only when TaskType is ProcessImageAsync.</p>
        /// </summary>
        [JsonProperty("ProcessImageAsyncTask")]
        public ProcessImageAsync ProcessImageAsyncTask{ get; set; }

        /// <summary>
        /// <p>Extract digital watermark task info. This field has a value only when TaskType is ExtractBlindWatermark.</p>
        /// </summary>
        [JsonProperty("ExtractBlindWatermarkTask")]
        public ExtractBlindWatermarkTask ExtractBlindWatermarkTask{ get; set; }

        /// <summary>
        /// <p>Create custom entity information. This field has a value only when TaskType is CreateAigcAdvancedCustomElement.</p>
        /// </summary>
        [JsonProperty("CreateAigcAdvancedCustomElementTask")]
        public CreateAigcAdvancedCustomElementTask CreateAigcAdvancedCustomElementTask{ get; set; }

        /// <summary>
        /// <p>Create custom tone information. This field has a value only when TaskType is CreateAigcCustomVoice.</p>
        /// </summary>
        [JsonProperty("CreateAigcCustomVoiceTask")]
        public CreateAigcCustomVoiceTask CreateAigcCustomVoiceTask{ get; set; }

        /// <summary>
        /// <p>Create entity information. This field has a value only when TaskType is CreateAigcSubject.</p>
        /// </summary>
        [JsonProperty("CreateAigcSubjectTask")]
        public CreateAigcSubjectTask CreateAigcSubjectTask{ get; set; }

        /// <summary>
        /// <p>AIGC video redraw info, valid only when TaskType is AigcVideoRedrawTask and this field has a value.</p>
        /// </summary>
        [JsonProperty("AigcVideoRedrawTask")]
        public AigcVideoRedrawTask AigcVideoRedrawTask{ get; set; }

        /// <summary>
        /// <p>AIGC sound effect information. This field has a value only when TaskType is AigcAudioTask.</p>
        /// </summary>
        [JsonProperty("AigcAudioTask")]
        public AigcAudioTask AigcAudioTask{ get; set; }

        /// <summary>
        /// <p>AIGC voice clone info. This field has a value only when TaskType is CreateAigcAudioClone.</p>
        /// </summary>
        [JsonProperty("CreateAigcAudioCloneTask")]
        public CreateAigcAudioCloneTask CreateAigcAudioCloneTask{ get; set; }

        /// <summary>
        /// <p>Asynchronously fetch AIGC face information. This field has a value only when TaskType is DescribeAigcFaceInfoAsync.</p>
        /// </summary>
        [JsonProperty("DescribeAigcFaceInfoAsyncTask")]
        public DescribeAigcFaceInfoAsyncTask DescribeAigcFaceInfoAsyncTask{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BeginProcessTime", this.BeginProcessTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamObj(map, prefix + "ProcedureTask.", this.ProcedureTask);
            this.SetParamObj(map, prefix + "EditMediaTask.", this.EditMediaTask);
            this.SetParamObj(map, prefix + "WechatPublishTask.", this.WechatPublishTask);
            this.SetParamObj(map, prefix + "ComposeMediaTask.", this.ComposeMediaTask);
            this.SetParamObj(map, prefix + "SplitMediaTask.", this.SplitMediaTask);
            this.SetParamObj(map, prefix + "WechatMiniProgramPublishTask.", this.WechatMiniProgramPublishTask);
            this.SetParamObj(map, prefix + "PullUploadTask.", this.PullUploadTask);
            this.SetParamObj(map, prefix + "TranscodeTask.", this.TranscodeTask);
            this.SetParamObj(map, prefix + "ConcatTask.", this.ConcatTask);
            this.SetParamObj(map, prefix + "ClipTask.", this.ClipTask);
            this.SetParamObj(map, prefix + "CreateImageSpriteTask.", this.CreateImageSpriteTask);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetTask.", this.SnapshotByTimeOffsetTask);
            this.SetParamObj(map, prefix + "RemoveWatermarkTask.", this.RemoveWatermarkTask);
            this.SetParamObj(map, prefix + "RebuildMediaTask.", this.RebuildMediaTask);
            this.SetParamObj(map, prefix + "ExtractTraceWatermarkTask.", this.ExtractTraceWatermarkTask);
            this.SetParamObj(map, prefix + "ExtractCopyRightWatermarkTask.", this.ExtractCopyRightWatermarkTask);
            this.SetParamObj(map, prefix + "ReviewAudioVideoTask.", this.ReviewAudioVideoTask);
            this.SetParamObj(map, prefix + "ReduceMediaBitrateTask.", this.ReduceMediaBitrateTask);
            this.SetParamObj(map, prefix + "DescribeFileAttributesTask.", this.DescribeFileAttributesTask);
            this.SetParamObj(map, prefix + "QualityInspectTask.", this.QualityInspectTask);
            this.SetParamObj(map, prefix + "QualityEnhanceTask.", this.QualityEnhanceTask);
            this.SetParamObj(map, prefix + "ComplexAdaptiveDynamicStreamingTask.", this.ComplexAdaptiveDynamicStreamingTask);
            this.SetParamObj(map, prefix + "ProcessMediaByMPSTask.", this.ProcessMediaByMPSTask);
            this.SetParamObj(map, prefix + "AigcImageTask.", this.AigcImageTask);
            this.SetParamObj(map, prefix + "AigcVideoTask.", this.AigcVideoTask);
            this.SetParamObj(map, prefix + "ImportMediaKnowledge.", this.ImportMediaKnowledge);
            this.SetParamObj(map, prefix + "SceneAigcImageTask.", this.SceneAigcImageTask);
            this.SetParamObj(map, prefix + "SceneAigcVideoTask.", this.SceneAigcVideoTask);
            this.SetParamObj(map, prefix + "ProcessImageAsyncTask.", this.ProcessImageAsyncTask);
            this.SetParamObj(map, prefix + "ExtractBlindWatermarkTask.", this.ExtractBlindWatermarkTask);
            this.SetParamObj(map, prefix + "CreateAigcAdvancedCustomElementTask.", this.CreateAigcAdvancedCustomElementTask);
            this.SetParamObj(map, prefix + "CreateAigcCustomVoiceTask.", this.CreateAigcCustomVoiceTask);
            this.SetParamObj(map, prefix + "CreateAigcSubjectTask.", this.CreateAigcSubjectTask);
            this.SetParamObj(map, prefix + "AigcVideoRedrawTask.", this.AigcVideoRedrawTask);
            this.SetParamObj(map, prefix + "AigcAudioTask.", this.AigcAudioTask);
            this.SetParamObj(map, prefix + "CreateAigcAudioCloneTask.", this.CreateAigcAudioCloneTask);
            this.SetParamObj(map, prefix + "DescribeAigcFaceInfoAsyncTask.", this.DescribeAigcFaceInfoAsyncTask);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

