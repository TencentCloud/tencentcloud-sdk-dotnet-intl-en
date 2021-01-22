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

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Task type. Valid values:
        /// <li>Procedure: video processing task</li>
        /// <li>EditMedia: video editing task</li>
        /// <li>SplitMedia: video splitting task</li>
        /// <li>ComposeMedia: media file producing task</li>
        /// <li>WechatPublish: WeChat publishing task</li>
        /// <li>WechatMiniProgramPublish: video publishing on WeChat Mini Program</li>
        /// <li>PullUpload: pulling media files for upload</li>
        /// 
        /// Support v2017 task types:
        /// <li>Transcode: transcoding task</li>
        /// <li>SnapshotByTimeOffset: screencapturing task</li>
        /// <li>Concat: video splicing task</li>
        /// <li>Clip: video clipping task</li>
        /// <li>ImageSprites: image sprite generating task</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Task status. Valid values:
        /// <li>WAITING: waiting;</li>
        /// <li>PROCESSING: processing;</li>
        /// <li>FINISH: completed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Creation time of task in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Start time of task execution in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// End time of task execution in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// Video processing task information. This field has a value only when `TaskType` is `Procedure`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcedureTask")]
        public ProcedureTask ProcedureTask{ get; set; }

        /// <summary>
        /// Video editing task information. This field has a value only when `TaskType` is `EditMedia`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EditMediaTask")]
        public EditMediaTask EditMediaTask{ get; set; }

        /// <summary>
        /// Release on WeChat task information. This field has a value only when `TaskType` is `WechatPublish`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatPublishTask")]
        public WechatPublishTask WechatPublishTask{ get; set; }

        /// <summary>
        /// Media file composing task information. This field has a value only when `TaskType` is `ComposeMedia`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComposeMediaTask")]
        public ComposeMediaTask ComposeMediaTask{ get; set; }

        /// <summary>
        /// Video splitting task information. This field has a value only when `TaskType` is `EditMedia`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SplitMediaTask")]
        public SplitMediaTask SplitMediaTask{ get; set; }

        /// <summary>
        /// Release on WeChat Mini Program task information. This field has a value only when `TaskType` is `WechatMiniProgramPublish`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishTask")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishTask{ get; set; }

        /// <summary>
        /// Media file pulling for upload task information. This field has a value only when `TaskType` is `PullUpload`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PullUploadTask")]
        public PullUploadTask PullUploadTask{ get; set; }

        /// <summary>
        /// Video transcoding task information. This field has a value only when `TaskType` is `Transcode`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public TranscodeTask2017 TranscodeTask{ get; set; }

        /// <summary>
        /// Video splicing task information. This field has a value only when `TaskType` is `Concat`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConcatTask")]
        public ConcatTask2017 ConcatTask{ get; set; }

        /// <summary>
        /// Video clipping task information. This field has a value only when `TaskType` is `Clip`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClipTask")]
        public ClipTask2017 ClipTask{ get; set; }

        /// <summary>
        /// Image sprite creating task information. This field has a value only when `TaskType` is `ImageSprite`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateImageSpriteTask")]
        public CreateImageSpriteTask2017 CreateImageSpriteTask{ get; set; }

        /// <summary>
        /// Time point screencapturing task information. This field has a value only when `TaskType` is `SnapshotByTimeOffset`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

