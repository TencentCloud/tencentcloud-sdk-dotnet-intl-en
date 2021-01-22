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
        /// <li>NewFileUpload: finished video upload</li>
        /// <li>ProcedureStateChanged: task flow status changed</li>
        /// <li>FileDeleted: finished video deletion</li>
        /// <li>PullComplete: finished pulling for upload</li>
        /// <li>EditMediaComplete: finished video editing</li>
        /// <li>SplitMediaComplete: finished video splitting</li>
        /// <li>WechatPublishComplete: finished publishing on WeChat</li>
        /// <li>ComposeMediaComplete: finished producing the media file</li>
        /// <li>WechatMiniProgramPublishComplete: finished publishing on WeChat Mini Program</li>
        /// <b>Support v2017 task types:</b>
        /// <li>TranscodeComplete: finished video transcoding</li>
        /// <li>ConcatComplete: finished video splicing</li>
        /// <li>ClipComplete: finished video clipping</li>
        /// <li>CreateImageSpriteComplete: finished image sprite generation</li>
        /// <li>CreateSnapshotByTimeOffsetComplete: finished point-in-time screencapturing</li>
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
        /// Video splitting completion event, which is valid if the event type is `EditMediaComplete`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
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
        }
    }
}

