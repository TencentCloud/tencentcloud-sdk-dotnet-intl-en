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

    public class PullUploadTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Pull the upload task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task flow status. Valid values: </p><li>PROCESSING: Processing; </li><li>FINISH: Completed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Error code. 0 indicates success, and other values indicate failure:</p><li>40000: invalid input parameters. Check input parameters;</li><li>60000: source file error (for example, video data corruption). Confirm whether the source file is normal;</li><li>70000: internal service error. Retry is recommended.</li>
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// <p>Error message.</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>Pull the video ID generated after upload completion.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Pull basic information of the generated media file after upload completion.</p>
        /// </summary>
        [JsonProperty("MediaBasicInfo")]
        public MediaBasicInfo MediaBasicInfo{ get; set; }

        /// <summary>
        /// <p>Meta information of the output video.</p>
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// <p>Get the playback address generated after upload completion.</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>Task ID of the task type Procedure. If a media subsequent task operation (Procedure) is specified during <a href="https://www.tencentcloud.com/document/api/266/35575?from_cn_redirect=1">pull upload</a>, the task is initiated when the task flow template specifies one or more of MediaProcessTask, AiAnalysisTask, and AiRecognitionTask.</p>
        /// </summary>
        [JsonProperty("ProcedureTaskId")]
        public string ProcedureTaskId{ get; set; }

        /// <summary>
        /// <p>Task ID of the task type ReviewAudioVideo. If a media subsequent task operation (Procedure) is specified during <a href="https://www.tencentcloud.com/document/api/266/35575?from_cn_redirect=1">pull upload</a>, the task is initiated when the task flow template specifies ReviewAudioVideoTask.</p>
        /// </summary>
        [JsonProperty("ReviewAudioVideoTaskId")]
        public string ReviewAudioVideoTaskId{ get; set; }

        /// <summary>
        /// <p>Source context, used to pass through user request information. <a href="https://www.tencentcloud.com/document/product/266/7831?from_cn_redirect=1">URL pull video upload completed</a> will return the value of this field, up to 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past seven days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Pull upload progress, in the range of [0,100].</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }


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
            this.SetParamObj(map, prefix + "MediaBasicInfo.", this.MediaBasicInfo);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "ProcedureTaskId", this.ProcedureTaskId);
            this.SetParamSimple(map, prefix + "ReviewAudioVideoTaskId", this.ReviewAudioVideoTaskId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
        }
    }
}

