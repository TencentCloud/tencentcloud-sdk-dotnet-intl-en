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

    public class ProcedureTask : AbstractModel
    {
        
        /// <summary>
        /// Media processing task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task stream status. Valid values:
        /// <li>PROCESSING: Processing;</li>
        /// <li>FINISH: completed</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Deprecated. Please use the ErrCode of each specific task.
        /// </summary>
        [JsonProperty("ErrCode")]
        [System.Obsolete]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// Deprecated. Please use the Message of each specific task.
        /// </summary>
        [JsonProperty("Message")]
        [System.Obsolete]
        public string Message{ get; set; }

        /// <summary>
        /// Media file ID.
        /// <li>If the process is initiated by [ProcessMedia](https://www.tencentcloud.com/document/product/266/33427?from_cn_redirect=1), this field represents the FileId of [MediaInfo](https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaInfo);</li>
        /// <li>If the process is initiated by [ProcessMediaByUrl](https://www.tencentcloud.com/document/product/266/33426?from_cn_redirect=1), this field represents the Id of [MediaInputInfo](https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaInputInfo).</li>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Media file name
        /// <li>If the process is triggered by [ProcessMedia](https://www.tencentcloud.com/document/product/266/33427?from_cn_redirect=1), this field represents BasicInfo.Name of [MediaInfo](https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaInfo);</li>
        /// <li>If the process is initiated by [ProcessMediaByUrl](https://www.tencentcloud.com/document/product/266/33426?from_cn_redirect=1), this field represents the Name of [MediaInputInfo](https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaInputInfo).</li>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Media file address.
        /// <li>If the process is initiated by [ProcessMedia](https://www.tencentcloud.com/document/product/266/33427?from_cn_redirect=1), this field represents BasicInfo.MediaUrl of [MediaInfo](https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaInfo);</li>
        /// <li>If the process is initiated by [ProcessMediaByUrl](https://www.tencentcloud.com/document/product/266/33426?from_cn_redirect=1), this field represents the URL of [MediaInputInfo](https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaInputInfo).</li>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// Metadata of the original audio/video.
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// Execution status and results of the audio/video processing task.
        /// </summary>
        [JsonProperty("MediaProcessResultSet")]
        public MediaProcessTaskResult[] MediaProcessResultSet{ get; set; }

        /// <summary>
        /// Execution status and results of an audio/video moderation task.
        /// </summary>
        [JsonProperty("AiContentReviewResultSet")]
        public AiContentReviewResult[] AiContentReviewResultSet{ get; set; }

        /// <summary>
        /// Execution status and results of an audio/video content analysis task.
        /// </summary>
        [JsonProperty("AiAnalysisResultSet")]
        public AiAnalysisResult[] AiAnalysisResultSet{ get; set; }

        /// <summary>
        /// Execution status and results of an audio/video content recognition task.
        /// </summary>
        [JsonProperty("AiRecognitionResultSet")]
        public AiRecognitionResult[] AiRecognitionResultSet{ get; set; }

        /// <summary>
        /// Priority of the task flow, with a value range of [-10, 10].
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Task flow status change notification mode.
        /// <li>Finish: Initiate an event notification only when all task flows are completed;</li>
        /// <li>Change: Event notification will be sent as long as the state of each subtask in the task flow changes;</li>
        /// <li>None: non-acceptance of the task flow callback.</li>
        /// </summary>
        [JsonProperty("TasksNotifyMode")]
        public string TasksNotifyMode{ get; set; }

        /// <summary>
        /// Source context, which is used to pass through the user request information. The callback for task flow status changes will return the value of this field. The maximum length is 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// An identifier for deduplication. If there has been a request with the same identifier within the past seven days, an error will be returned for the current request. The maximum length is 50 characters. Leaving it blank or using a null string indicates no deduplication is required.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Operator. Valid values:
        /// <li>System: indicates a system trigger.</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Operation type. Valid values:
        /// <li>TSC: indicates usage of top speed Codec for smart bitrate reduction.</li>
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamArrayObj(map, prefix + "MediaProcessResultSet.", this.MediaProcessResultSet);
            this.SetParamArrayObj(map, prefix + "AiContentReviewResultSet.", this.AiContentReviewResultSet);
            this.SetParamArrayObj(map, prefix + "AiAnalysisResultSet.", this.AiAnalysisResultSet);
            this.SetParamArrayObj(map, prefix + "AiRecognitionResultSet.", this.AiRecognitionResultSet);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "TasksNotifyMode", this.TasksNotifyMode);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
        }
    }
}

