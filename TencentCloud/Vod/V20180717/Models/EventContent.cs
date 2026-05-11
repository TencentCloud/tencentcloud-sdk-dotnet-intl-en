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
        /// Event handler. The caller must call ConfirmEvents to acknowledge the message has been received. Confirmed Valid Time is 30 seconds. After expiration, the event can be retrieved again.
        /// </summary>
        [JsonProperty("EventHandle")]
        public string EventHandle{ get; set; }

        /// <summary>
        /// <b>Supported event types:</b>
        /// <li>NewFileUpload: Video upload completed;</li>
        /// <li>ProcedureStateChanged: Task flow status change.</li>
        /// <li>FileDeleted: Video deletion completed;</li>
        /// <li>RestoreMediaComplete: Video retrieval completion;</li>
        /// <li>PullComplete: Video conversion pull completed.</li>
        /// <li>EditMediaComplete: Video editing completed;</li>
        /// <li>SplitMediaComplete: Video splitting completed;</li>
        /// <li>ComposeMediaComplete: Media file creation completion;</li>
        /// <li>WechatMiniProgramPublishComplete: WeChat Mini Program Publishing Completed.</li>
        /// <li>RemoveWatermark: Intelligent watermark removal completion.</li>
        /// <li>RebuildMediaComplete: Audio and video quality rebirth completion event (This is not recommended).</li>
        /// <li>ReviewAudioVideoComplete: Audio/video moderation completed;</li>
        /// <li>ExtractTraceWatermarkComplete: Traceability watermark extraction completed;</li>
        /// <li>ExtractCopyRightWatermarkComplete: Extracting copyright watermark completion.</li>
        /// <li>DescribeFileAttributesComplete: File attribute acquisition completion.</li>
        /// <li>QualityInspectComplete: Audio and video quality inspection completed;</li>
        /// <li>QualityEnhanceComplete: Audio and video quality rebirth task completion;</li>
        /// <li>PersistenceComplete: Edit completed.</li>
        /// <li>ComplexAdaptiveDynamicStreamingComplete: complex adaptive bitstream task completed.</li>
        /// <li>ProcessMediaByMPSComplete: MPS video processing is completed.</li>
        /// <li>AigcImageTaskComplete: AIGC image generation task complete.</li>
        /// <li>AigcVideoTaskComplete: AIGC video generation task completed.</li>
        /// <b>Event types compatible with the 2017 version:</b>
        /// <li>TranscodeComplete: video transcoding completion;</li>
        /// <li>ConcatComplete: Video splicing completion.</li>
        /// <li>ClipComplete: Video editing completed;</li>
        /// <li>CreateImageSpriteComplete: Video thumbnail capture completion.</li>
        /// <li>CreateSnapshotByTimeOffsetComplete: Video screenshot by time point.</li>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Video upload completion event. Valid when the event type is NewFileUpload.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileUploadEvent")]
        public FileUploadTask FileUploadEvent{ get; set; }

        /// <summary>
        /// Task flow status change event. Valid when the event type is ProcedureStateChanged.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcedureStateChangeEvent")]
        public ProcedureTask ProcedureStateChangeEvent{ get; set; }

        /// <summary>
        /// File deletion event. Valid when the event type is FileDeleted.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileDeleteEvent")]
        public FileDeleteTask FileDeleteEvent{ get; set; }

        /// <summary>
        /// Video pull completion event. Valid when the event type is PullComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PullCompleteEvent")]
        public PullUploadTask PullCompleteEvent{ get; set; }

        /// <summary>
        /// Video editing completion event. Valid when the event type is EditMediaComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EditMediaCompleteEvent")]
        public EditMediaTask EditMediaCompleteEvent{ get; set; }

        /// <summary>
        /// Video splitting completion event. Valid when the event type is SplitMediaComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SplitMediaCompleteEvent")]
        public SplitMediaTask SplitMediaCompleteEvent{ get; set; }

        /// <summary>
        /// Media file creation task completion event. Valid when the event type is ComposeMediaComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComposeMediaCompleteEvent")]
        public ComposeMediaTask ComposeMediaCompleteEvent{ get; set; }

        /// <summary>
        /// Video editing completion event. Valid when the event type is ClipComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClipCompleteEvent")]
        public ClipTask2017 ClipCompleteEvent{ get; set; }

        /// <summary>
        /// Video transcoding completion event, valid when the event type is TranscodeComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeCompleteEvent")]
        public TranscodeTask2017 TranscodeCompleteEvent{ get; set; }

        /// <summary>
        /// Video thumbnail capture completion event. Valid when the event type is CreateImageSpriteComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateImageSpriteCompleteEvent")]
        public CreateImageSpriteTask2017 CreateImageSpriteCompleteEvent{ get; set; }

        /// <summary>
        /// Video splicing completion event. Valid when the event type is ConcatComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConcatCompleteEvent")]
        public ConcatTask2017 ConcatCompleteEvent{ get; set; }

        /// <summary>
        /// Video screenshot by time point completion event. Valid when the event type is CreateSnapshotByTimeOffsetComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetCompleteEvent")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetCompleteEvent{ get; set; }

        /// <summary>
        /// WeChat Publishing Completion Event. Valid when the event type is WechatPublishComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatPublishCompleteEvent")]
        public WechatPublishTask WechatPublishCompleteEvent{ get; set; }

        /// <summary>
        /// WeChat Mini Program Publishing Task Completion Event. Valid when the event type is WechatMiniProgramPublishComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishCompleteEvent")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishCompleteEvent{ get; set; }

        /// <summary>
        /// Intelligent Watermark Removal Completion Event is valid when the event type is RemoveWatermark.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RemoveWatermarkCompleteEvent")]
        public RemoveWatermarkTask RemoveWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// Video retrieval completion event. Valid when the event type is RestoreMediaComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RestoreMediaCompleteEvent")]
        public RestoreMediaTask RestoreMediaCompleteEvent{ get; set; }

        /// <summary>
        /// Audio and video quality rebirth completion event. Valid when the event type is RebuildMediaComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RebuildMediaCompleteEvent")]
        public RebuildMediaTask RebuildMediaCompleteEvent{ get; set; }

        /// <summary>
        /// Traceability watermark extraction completion event. Valid when the event type is ExtractTraceWatermarkComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkCompleteEvent")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// Copyright watermark extraction completion event. Valid when the event type is ExtractCopyRightWatermarkComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtractCopyRightWatermarkCompleteEvent")]
        public ExtractCopyRightWatermarkTask ExtractCopyRightWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// Audio/video moderation completed event. Valid when the event type is ReviewAudioVideoComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReviewAudioVideoCompleteEvent")]
        public ReviewAudioVideoTask ReviewAudioVideoCompleteEvent{ get; set; }

        /// <summary>
        /// This field is invalid.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReduceMediaBitrateCompleteEvent")]
        public ReduceMediaBitrateTask ReduceMediaBitrateCompleteEvent{ get; set; }

        /// <summary>
        /// File attribute acquisition completion event. Valid when the event type is DescribeFileAttributesComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DescribeFileAttributesCompleteEvent")]
        public DescribeFileAttributesTask DescribeFileAttributesCompleteEvent{ get; set; }

        /// <summary>
        /// Audio and video quality detection completion event. Valid when the event type is QualityInspectComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityInspectCompleteEvent")]
        public QualityInspectTask QualityInspectCompleteEvent{ get; set; }

        /// <summary>
        /// Audio and video quality rebirth completion event. Valid when the event type is QualityEnhanceComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityEnhanceCompleteEvent")]
        public QualityEnhanceTask QualityEnhanceCompleteEvent{ get; set; }

        /// <summary>
        /// MediaCastStatus changed event, valid when the event type is MediaCastStatusChanged.
        /// Pay attention to: this field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MediaCastStatusChangedEvent")]
        public MediaCastEvent MediaCastStatusChangedEvent{ get; set; }

        /// <summary>
        /// Editing solidification completion event. Valid when the event type is PersistenceComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PersistenceCompleteEvent")]
        public PersistenceCompleteTask PersistenceCompleteEvent{ get; set; }

        /// <summary>
        /// Adaptive bitrate task information, valid only when EventType is ComplexAdaptiveDynamicStreamingComplete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComplexAdaptiveDynamicStreamingCompleteEvent")]
        public ComplexAdaptiveDynamicStreamingTask ComplexAdaptiveDynamicStreamingCompleteEvent{ get; set; }

        /// <summary>
        /// MPS video processing task information. Valid only when EventType is ProcessMediaByMPSComplete.
        /// </summary>
        [JsonProperty("ProcessMediaByMPSCompleteEvent")]
        public ProcessMediaByMPS ProcessMediaByMPSCompleteEvent{ get; set; }

        /// <summary>
        /// AIGC image generation task info. Valid only when EventType is AigcImageTaskComplete.
        /// </summary>
        [JsonProperty("AigcImageCompleteEvent")]
        public AigcImageTask AigcImageCompleteEvent{ get; set; }

        /// <summary>
        /// AIGC video task info. Valid only when EventType is AigcVideoTaskComplete.
        /// </summary>
        [JsonProperty("AigcVideoCompleteEvent")]
        public AigcVideoTask AigcVideoCompleteEvent{ get; set; }

        /// <summary>
        /// Extract digital watermark information. Valid at that time only when EventType is ExtractBlindWatermarkComplete.
        /// </summary>
        [JsonProperty("ExtractBlindWatermarkComplete")]
        public ExtractBlindWatermarkTask ExtractBlindWatermarkComplete{ get; set; }

        /// <summary>
        /// AIGC scenario-based image generation task info, valid only when EventType is SceneAigcImageCompleteEvent.
        /// </summary>
        [JsonProperty("SceneAigcImageCompleteEvent")]
        public SceneAigcImageTask SceneAigcImageCompleteEvent{ get; set; }

        /// <summary>
        /// Image asynchronous task processing info, valid only when EventType is ProcessImageAsyncCompleteEvent.
        /// </summary>
        [JsonProperty("ProcessImageAsyncCompleteEvent")]
        public ProcessImageAsyncTask ProcessImageAsyncCompleteEvent{ get; set; }


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
        }
    }
}

