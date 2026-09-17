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

    public class EventContent : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EventHandle")]
        public string EventHandle{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FileUploadEvent")]
        public FileUploadTask FileUploadEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProcedureStateChangeEvent")]
        public ProcedureTask ProcedureStateChangeEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FileDeleteEvent")]
        public FileDeleteTask FileDeleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PullCompleteEvent")]
        public PullUploadTask PullCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EditMediaCompleteEvent")]
        public EditMediaTask EditMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SplitMediaCompleteEvent")]
        public SplitMediaTask SplitMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ComposeMediaCompleteEvent")]
        public ComposeMediaTask ComposeMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClipCompleteEvent")]
        public ClipTask2017 ClipCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TranscodeCompleteEvent")]
        public TranscodeTask2017 TranscodeCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateImageSpriteCompleteEvent")]
        public CreateImageSpriteTask2017 CreateImageSpriteCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConcatCompleteEvent")]
        public ConcatTask2017 ConcatCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetCompleteEvent")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WechatPublishCompleteEvent")]
        public WechatPublishTask WechatPublishCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishCompleteEvent")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RemoveWatermarkCompleteEvent")]
        public RemoveWatermarkTask RemoveWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RestoreMediaCompleteEvent")]
        public RestoreMediaTask RestoreMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RebuildMediaCompleteEvent")]
        public RebuildMediaTask RebuildMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkCompleteEvent")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtractCopyRightWatermarkCompleteEvent")]
        public ExtractCopyRightWatermarkTask ExtractCopyRightWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReviewAudioVideoCompleteEvent")]
        public ReviewAudioVideoTask ReviewAudioVideoCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReduceMediaBitrateCompleteEvent")]
        public ReduceMediaBitrateTask ReduceMediaBitrateCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DescribeFileAttributesCompleteEvent")]
        public DescribeFileAttributesTask DescribeFileAttributesCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QualityInspectCompleteEvent")]
        public QualityInspectTask QualityInspectCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QualityEnhanceCompleteEvent")]
        public QualityEnhanceTask QualityEnhanceCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MediaCastStatusChangedEvent")]
        public MediaCastEvent MediaCastStatusChangedEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PersistenceCompleteEvent")]
        public PersistenceCompleteTask PersistenceCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ComplexAdaptiveDynamicStreamingCompleteEvent")]
        public ComplexAdaptiveDynamicStreamingTask ComplexAdaptiveDynamicStreamingCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProcessMediaByMPSCompleteEvent")]
        public ProcessMediaByMPS ProcessMediaByMPSCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcImageCompleteEvent")]
        public AigcImageTask AigcImageCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcVideoCompleteEvent")]
        public AigcVideoTask AigcVideoCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtractBlindWatermarkComplete")]
        public ExtractBlindWatermarkTask ExtractBlindWatermarkComplete{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SceneAigcImageCompleteEvent")]
        public SceneAigcImageTask SceneAigcImageCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProcessImageAsyncCompleteEvent")]
        public ProcessImageAsyncTask ProcessImageAsyncCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateAigcAdvancedCustomElementCompleteEvent")]
        public CreateAigcAdvancedCustomElementTask CreateAigcAdvancedCustomElementCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateAigcCustomVoiceCompleteEvent")]
        public CreateAigcCustomVoiceTask CreateAigcCustomVoiceCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DescribeAigcFaceInfoAsyncCompleteEvent")]
        public DescribeAigcFaceInfoAsyncTask DescribeAigcFaceInfoAsyncCompleteEvent{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AigcHunyuan3DCompleteEvent")]
        public AigcHunyuan3DTask AigcHunyuan3DCompleteEvent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventHandle", this.EventHandle);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamObj(map, prefix + "FileUploadEvent.", this.FileUploadEvent);
            this.SetParamObj(map, prefix + "ProcedureStateChangeEvent.", this.ProcedureStateChangeEvent);
            this.SetParamObj(map, prefix + "FileDeleteEvent.", this.FileDeleteEvent);
            this.SetParamObj(map, prefix + "PullCompleteEvent.", this.PullCompleteEvent);
            this.SetParamObj(map, prefix + "EditMediaCompleteEvent.", this.EditMediaCompleteEvent);
            this.SetParamObj(map, prefix + "SplitMediaCompleteEvent.", this.SplitMediaCompleteEvent);
            this.SetParamObj(map, prefix + "ComposeMediaCompleteEvent.", this.ComposeMediaCompleteEvent);
            this.SetParamObj(map, prefix + "ClipCompleteEvent.", this.ClipCompleteEvent);
            this.SetParamObj(map, prefix + "TranscodeCompleteEvent.", this.TranscodeCompleteEvent);
            this.SetParamObj(map, prefix + "CreateImageSpriteCompleteEvent.", this.CreateImageSpriteCompleteEvent);
            this.SetParamObj(map, prefix + "ConcatCompleteEvent.", this.ConcatCompleteEvent);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetCompleteEvent.", this.SnapshotByTimeOffsetCompleteEvent);
            this.SetParamObj(map, prefix + "WechatPublishCompleteEvent.", this.WechatPublishCompleteEvent);
            this.SetParamObj(map, prefix + "WechatMiniProgramPublishCompleteEvent.", this.WechatMiniProgramPublishCompleteEvent);
            this.SetParamObj(map, prefix + "RemoveWatermarkCompleteEvent.", this.RemoveWatermarkCompleteEvent);
            this.SetParamObj(map, prefix + "RestoreMediaCompleteEvent.", this.RestoreMediaCompleteEvent);
            this.SetParamObj(map, prefix + "RebuildMediaCompleteEvent.", this.RebuildMediaCompleteEvent);
            this.SetParamObj(map, prefix + "ExtractTraceWatermarkCompleteEvent.", this.ExtractTraceWatermarkCompleteEvent);
            this.SetParamObj(map, prefix + "ExtractCopyRightWatermarkCompleteEvent.", this.ExtractCopyRightWatermarkCompleteEvent);
            this.SetParamObj(map, prefix + "ReviewAudioVideoCompleteEvent.", this.ReviewAudioVideoCompleteEvent);
            this.SetParamObj(map, prefix + "ReduceMediaBitrateCompleteEvent.", this.ReduceMediaBitrateCompleteEvent);
            this.SetParamObj(map, prefix + "DescribeFileAttributesCompleteEvent.", this.DescribeFileAttributesCompleteEvent);
            this.SetParamObj(map, prefix + "QualityInspectCompleteEvent.", this.QualityInspectCompleteEvent);
            this.SetParamObj(map, prefix + "QualityEnhanceCompleteEvent.", this.QualityEnhanceCompleteEvent);
            this.SetParamObj(map, prefix + "MediaCastStatusChangedEvent.", this.MediaCastStatusChangedEvent);
            this.SetParamObj(map, prefix + "PersistenceCompleteEvent.", this.PersistenceCompleteEvent);
            this.SetParamObj(map, prefix + "ComplexAdaptiveDynamicStreamingCompleteEvent.", this.ComplexAdaptiveDynamicStreamingCompleteEvent);
            this.SetParamObj(map, prefix + "ProcessMediaByMPSCompleteEvent.", this.ProcessMediaByMPSCompleteEvent);
            this.SetParamObj(map, prefix + "AigcImageCompleteEvent.", this.AigcImageCompleteEvent);
            this.SetParamObj(map, prefix + "AigcVideoCompleteEvent.", this.AigcVideoCompleteEvent);
            this.SetParamObj(map, prefix + "ExtractBlindWatermarkComplete.", this.ExtractBlindWatermarkComplete);
            this.SetParamObj(map, prefix + "SceneAigcImageCompleteEvent.", this.SceneAigcImageCompleteEvent);
            this.SetParamObj(map, prefix + "ProcessImageAsyncCompleteEvent.", this.ProcessImageAsyncCompleteEvent);
            this.SetParamObj(map, prefix + "CreateAigcAdvancedCustomElementCompleteEvent.", this.CreateAigcAdvancedCustomElementCompleteEvent);
            this.SetParamObj(map, prefix + "CreateAigcCustomVoiceCompleteEvent.", this.CreateAigcCustomVoiceCompleteEvent);
            this.SetParamObj(map, prefix + "DescribeAigcFaceInfoAsyncCompleteEvent.", this.DescribeAigcFaceInfoAsyncCompleteEvent);
            this.SetParamObj(map, prefix + "AigcHunyuan3DCompleteEvent.", this.AigcHunyuan3DCompleteEvent);
        }
    }
}

