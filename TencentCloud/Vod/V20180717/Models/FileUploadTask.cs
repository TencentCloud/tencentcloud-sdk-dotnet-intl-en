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

    public class FileUploadTask : AbstractModel
    {
        
        /// <summary>
        /// Unique file ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Basic information of the generated media file after upload completion.
        /// </summary>
        [JsonProperty("MediaBasicInfo")]
        public MediaBasicInfo MediaBasicInfo{ get; set; }

        /// <summary>
        /// Task ID of the `Procedure` type. If A task (Procedure) to execute is specified during video upload, the task is initiated when the task flow template specifies one or more of `MediaProcessTask`, `AiAnalysisTask`, and `AiRecognitionTask`.
        /// </summary>
        [JsonProperty("ProcedureTaskId")]
        public string ProcedureTaskId{ get; set; }

        /// <summary>
        /// Task ID of the `ReviewAudioVideo` task type. If a task procedure is specified during video upload (https://www.tencentcloud.com/document/product/266/33475?from_cn_redirect=1#.E4.BB.BB.E5.8A.A1.E5.8F.91.E8.B5.B7), the task is initiated when the task flow template specifies `ReviewAudioVideoTask`.
        /// </summary>
        [JsonProperty("ReviewAudioVideoTaskId")]
        public string ReviewAudioVideoTaskId{ get; set; }

        /// <summary>
        /// Meta information, including size, duration, video stream information, and audio stream information.
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "MediaBasicInfo.", this.MediaBasicInfo);
            this.SetParamSimple(map, prefix + "ProcedureTaskId", this.ProcedureTaskId);
            this.SetParamSimple(map, prefix + "ReviewAudioVideoTaskId", this.ReviewAudioVideoTaskId);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
        }
    }
}

