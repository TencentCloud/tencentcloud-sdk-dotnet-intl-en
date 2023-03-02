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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventContent : AbstractModel
    {
        
        /// <summary>
        /// Event handler. The caller must call `ConfirmEvents` to confirm that the message has been received, and the confirmation is valid for 30 seconds. After the confirmation expires, the event can be obtained again.
        /// </summary>
        [JsonProperty("EventHandle")]
        public string EventHandle{ get; set; }

        /// <summary>
        /// <b>Supported event types:</b>
        /// <li>`NewFileUpload`: Video uploaded.</li>
        /// <li>`ProcedureStateChanged`: Task flow status changed.</li>
        /// <li>`FileDeleted`: Video deleted.</li>
        /// <li>`RestoreMediaComplete`: Video retrieved.</li>
        /// <li>`PullComplete`: Finished video pulling.</li>
        /// <li>`EditMediaComplete`: Finished video editing.</li>
        /// <li>`SplitMediaComplete`: Finished video splitting.</li>
        /// <li>`ComposeMediaComplete`: Finished producing the media file.</li>
        /// <li>`WechatMiniProgramPublishComplete`: Finished publishing on Weixin Mini Program.</li>
        /// <li>`RemoveWatermark`: Watermark removed.</li>
        /// <li>`RebuildMediaComplete`: Finished audio/video remastering.</li>
        /// <li>`ReviewAudioVideoComplete`: Finished moderation.</li>
        /// <li>`ExtractTraceWatermarkComplete`: Finished digital watermark extraction.</li>
        /// <li>`DescribeFileAttributesComplete`: Finished getting file attributes.</li>
        /// <b>v2017 task types:</b>
        /// <li>`TranscodeComplete`: Finished video transcoding.</li>
        /// <li>`ConcatComplete`: Finished video splicing.</li>
        /// <li>`ClipComplete`: Finished video clipping.</li>
        /// <li>`CreateImageSpriteComplete`: Finished image sprite generation.</li>
        /// <li>`CreateSnapshotByTimeOffsetComplete`: Finished time point screencapturing.</li>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Video upload completion event, which is valid if the event type is `NewFileUpload`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileUploadEvent")]
        public FileUploadTask FileUploadEvent{ get; set; }

        /// <summary>
        /// Task flow status change event, which is valid if the event type is `ProcedureStateChanged`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcedureStateChangeEvent")]
        public ProcedureTask ProcedureStateChangeEvent{ get; set; }

        /// <summary>
        /// File deletion event, which is valid if the event type is `FileDeleted`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileDeleteEvent")]
        public FileDeleteTask FileDeleteEvent{ get; set; }

        /// <summary>
        /// Video pull for upload completion event, which is valid if the event type is `PullComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PullCompleteEvent")]
        public PullUploadTask PullCompleteEvent{ get; set; }

        /// <summary>
        /// Video editing completion event, which is valid if the event type is `EditMediaComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EditMediaCompleteEvent")]
        public EditMediaTask EditMediaCompleteEvent{ get; set; }

        /// <summary>
        /// The notification for completing video splitting, which is valid if the event type is `SplitMediaComplete`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SplitMediaCompleteEvent")]
        public SplitMediaTask SplitMediaCompleteEvent{ get; set; }

        /// <summary>
        /// Media file composing task completion event, which is valid when the event type is `ComposeMediaComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComposeMediaCompleteEvent")]
        public ComposeMediaTask ComposeMediaCompleteEvent{ get; set; }

        /// <summary>
        /// Video clipping completion event, which is valid if the event type is `ClipComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClipCompleteEvent")]
        public ClipTask2017 ClipCompleteEvent{ get; set; }

        /// <summary>
        /// Video transcoding completion event, which is valid if the event type is `TranscodeComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeCompleteEvent")]
        public TranscodeTask2017 TranscodeCompleteEvent{ get; set; }

        /// <summary>
        /// Image sprite generating completion event, which is valid if the event type is `CreateImageSpriteComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateImageSpriteCompleteEvent")]
        public CreateImageSpriteTask2017 CreateImageSpriteCompleteEvent{ get; set; }

        /// <summary>
        /// Video splicing completion event, which is valid if the event type is `ConcatComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConcatCompleteEvent")]
        public ConcatTask2017 ConcatCompleteEvent{ get; set; }

        /// <summary>
        /// Time point screencapturing completion event, which is valid when the event type is `CreateSnapshotByTimeOffsetComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetCompleteEvent")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetCompleteEvent{ get; set; }

        /// <summary>
        /// Release on WeChat completion event, which is valid if the event type is `WechatPublishComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatPublishCompleteEvent")]
        public WechatPublishTask WechatPublishCompleteEvent{ get; set; }

        /// <summary>
        /// Release on WeChat Mini Program task completion event, which is valid if the event type is `WechatMiniProgramPublishComplete`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishCompleteEvent")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishCompleteEvent{ get; set; }

        /// <summary>
        /// The notification for completing watermark removal. This parameter is valid only if the event type is `RemoveWatermark`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RemoveWatermarkCompleteEvent")]
        public RemoveWatermarkTask RemoveWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// The notification for completing video retrieval. This parameter is valid if the event type is `RestoreMediaComplete`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RestoreMediaCompleteEvent")]
        public RestoreMediaTask RestoreMediaCompleteEvent{ get; set; }

        /// <summary>
        /// The notification for completing audio/video remastering. This parameter is valid only if the event type is `RebuildMediaComplete`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RebuildMediaCompleteEvent")]
        public RebuildMediaTask RebuildMediaCompleteEvent{ get; set; }

        /// <summary>
        /// The notification for completing digital watermark extraction. This parameter is valid only if `EventType` is `ExtractTraceWatermarkComplete`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkCompleteEvent")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// The callback for the completion of the moderation task. This parameter is valid only if `EventType` is `ReviewAudioVideoComplete`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReviewAudioVideoCompleteEvent")]
        public ReviewAudioVideoTask ReviewAudioVideoCompleteEvent{ get; set; }

        /// <summary>
        /// This parameter is invalid now.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReduceMediaBitrateCompleteEvent")]
        public ReduceMediaBitrateTask ReduceMediaBitrateCompleteEvent{ get; set; }

        /// <summary>
        /// The event of finishing getting file attributes. This parameter is valid only if `EventType` is `DescribeFileAttributesComplete`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DescribeFileAttributesCompleteEvent")]
        public DescribeFileAttributesTask DescribeFileAttributesCompleteEvent{ get; set; }


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
            this.SetParamObj(map, prefix + "ReviewAudioVideoCompleteEvent.", this.ReviewAudioVideoCompleteEvent);
            this.SetParamObj(map, prefix + "ReduceMediaBitrateCompleteEvent.", this.ReduceMediaBitrateCompleteEvent);
            this.SetParamObj(map, prefix + "DescribeFileAttributesCompleteEvent.", this.DescribeFileAttributesCompleteEvent);
        }
    }
}

