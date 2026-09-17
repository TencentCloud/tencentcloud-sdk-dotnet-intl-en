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
        /// 
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProcedureTask")]
        public ProcedureTask ProcedureTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EditMediaTask")]
        public EditMediaTask EditMediaTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WechatPublishTask")]
        public WechatPublishTask WechatPublishTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ComposeMediaTask")]
        public ComposeMediaTask ComposeMediaTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SplitMediaTask")]
        public SplitMediaTask SplitMediaTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishTask")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PullUploadTask")]
        public PullUploadTask PullUploadTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public TranscodeTask2017 TranscodeTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConcatTask")]
        public ConcatTask2017 ConcatTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClipTask")]
        public ClipTask2017 ClipTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateImageSpriteTask")]
        public CreateImageSpriteTask2017 CreateImageSpriteTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RemoveWatermarkTask")]
        public RemoveWatermarkTask RemoveWatermarkTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RebuildMediaTask")]
        public RebuildMediaTask RebuildMediaTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkTask")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtractCopyRightWatermarkTask")]
        public ExtractCopyRightWatermarkTask ExtractCopyRightWatermarkTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReviewAudioVideoTask")]
        public ReviewAudioVideoTask ReviewAudioVideoTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReduceMediaBitrateTask")]
        public ReduceMediaBitrateTask ReduceMediaBitrateTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DescribeFileAttributesTask")]
        public DescribeFileAttributesTask DescribeFileAttributesTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QualityInspectTask")]
        public QualityInspectTask QualityInspectTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QualityEnhanceTask")]
        public QualityEnhanceTask QualityEnhanceTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ComplexAdaptiveDynamicStreamingTask")]
        public ComplexAdaptiveDynamicStreamingTask ComplexAdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProcessMediaByMPSTask")]
        public ProcessMediaByMPS ProcessMediaByMPSTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcImageTask")]
        public AigcImageTask AigcImageTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcVideoTask")]
        public AigcVideoTask AigcVideoTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImportMediaKnowledge")]
        public ImportMediaKnowledgeTask ImportMediaKnowledge{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SceneAigcImageTask")]
        public SceneAigcImageTask SceneAigcImageTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SceneAigcVideoTask")]
        public SceneAigcVideoTask SceneAigcVideoTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProcessImageAsyncTask")]
        public ProcessImageAsync ProcessImageAsyncTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtractBlindWatermarkTask")]
        public ExtractBlindWatermarkTask ExtractBlindWatermarkTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateAigcAdvancedCustomElementTask")]
        public CreateAigcAdvancedCustomElementTask CreateAigcAdvancedCustomElementTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateAigcCustomVoiceTask")]
        public CreateAigcCustomVoiceTask CreateAigcCustomVoiceTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateAigcSubjectTask")]
        public CreateAigcSubjectTask CreateAigcSubjectTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcVideoRedrawTask")]
        public AigcVideoRedrawTask AigcVideoRedrawTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcAudioTask")]
        public AigcAudioTask AigcAudioTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateAigcAudioCloneTask")]
        public CreateAigcAudioCloneTask CreateAigcAudioCloneTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DescribeAigcFaceInfoAsyncTask")]
        public DescribeAigcFaceInfoAsyncTask DescribeAigcFaceInfoAsyncTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcHunyuan3DTask")]
        public AigcHunyuan3DTask AigcHunyuan3DTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DesignVoiceAsyncTask")]
        public DesignVoiceAsyncTask DesignVoiceAsyncTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CloneVoiceAsyncTask")]
        public CloneVoiceAsyncTask CloneVoiceAsyncTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TextToSpeechAsyncTask")]
        public TextToSpeechAsyncTask TextToSpeechAsyncTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoDubbingAsyncTask")]
        public VideoDubbingAsyncTask VideoDubbingAsyncTask{ get; set; }

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
            this.SetParamObj(map, prefix + "AigcHunyuan3DTask.", this.AigcHunyuan3DTask);
            this.SetParamObj(map, prefix + "DesignVoiceAsyncTask.", this.DesignVoiceAsyncTask);
            this.SetParamObj(map, prefix + "CloneVoiceAsyncTask.", this.CloneVoiceAsyncTask);
            this.SetParamObj(map, prefix + "TextToSpeechAsyncTask.", this.TextToSpeechAsyncTask);
            this.SetParamObj(map, prefix + "VideoDubbingAsyncTask.", this.VideoDubbingAsyncTask);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

