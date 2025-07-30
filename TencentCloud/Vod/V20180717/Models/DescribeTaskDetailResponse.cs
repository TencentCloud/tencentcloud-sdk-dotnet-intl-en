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
        /// The task type. Valid values:
        /// <li>`Procedure`: Video processing</li>
        /// <li>`EditMedia`: Video editing</li>
        /// <li>`SplitMedia`: Video splitting</li>
        /// <li>`ComposeMedia`: Media file production</li>
        /// <li>`WechatPublish`: Weixin publishing</li>
        /// <li>`WechatMiniProgramPublish`: Publishing videos on Weixin Mini Program</li>
        /// <li>`PullUpload`: Pulling media files for upload</li>
        /// <li>`FastClipMedia`: Quick clipping</li>
        /// <li>`RemoveWatermarkTask`: Watermark removal</li>
        /// <li>`DescribeFileAttributesTask`: Getting file attributes</li>
        /// <li> `ReviewAudioVideo`: Moderation</li>
        /// <li>`ExtractTraceWatermark`: Digital watermark extraction</li>
        /// <li>`QualityEnhance`: Enhance audio/video</li>
        /// <li>`ComplexAdaptiveDynamicStreaming`: Complex adaptive bitrate streaming processing task</li><li>`ProcessMediaByMPS`: Process media by MPS.</li>
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
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProcedureTask")]
        public ProcedureTask ProcedureTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EditMediaTask")]
        public EditMediaTask EditMediaTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WechatPublishTask")]
        public WechatPublishTask WechatPublishTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ComposeMediaTask")]
        public ComposeMediaTask ComposeMediaTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SplitMediaTask")]
        public SplitMediaTask SplitMediaTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishTask")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PullUploadTask")]
        public PullUploadTask PullUploadTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public TranscodeTask2017 TranscodeTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ConcatTask")]
        public ConcatTask2017 ConcatTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClipTask")]
        public ClipTask2017 ClipTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreateImageSpriteTask")]
        public CreateImageSpriteTask2017 CreateImageSpriteTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RemoveWatermarkTask")]
        public RemoveWatermarkTask RemoveWatermarkTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RebuildMediaTask")]
        public RebuildMediaTask RebuildMediaTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkTask")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExtractCopyRightWatermarkTask")]
        public ExtractCopyRightWatermarkTask ExtractCopyRightWatermarkTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReviewAudioVideoTask")]
        public ReviewAudioVideoTask ReviewAudioVideoTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReduceMediaBitrateTask")]
        public ReduceMediaBitrateTask ReduceMediaBitrateTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DescribeFileAttributesTask")]
        public DescribeFileAttributesTask DescribeFileAttributesTask{ get; set; }

        /// <summary>
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualityInspectTask")]
        public QualityInspectTask QualityInspectTask{ get; set; }

        /// <summary>
        /// Media Quality Enhance task information. This field has a value only when TaskType is QualityEnhance.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualityEnhanceTask")]
        public QualityEnhanceTask QualityEnhanceTask{ get; set; }

        /// <summary>
        /// Complex adaptive bitrate streaming processing task information. This field has a value only when TaskType is ComplexAdaptiveDynamicStreaming. 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ComplexAdaptiveDynamicStreamingTask")]
        public ComplexAdaptiveDynamicStreamingTask ComplexAdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// Media processing by MPS task information. This field contains a value only when TaskType is ProcessMediaByMPS.
        /// </summary>
        [JsonProperty("ProcessMediaByMPSTask")]
        public ProcessMediaByMPS ProcessMediaByMPSTask{ get; set; }

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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

