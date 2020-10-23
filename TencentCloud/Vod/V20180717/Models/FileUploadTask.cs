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

    public class FileUploadTask : AbstractModel
    {
        
        /// <summary>
        /// Unique file ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Basic information of media file generated after upload is completed.
        /// </summary>
        [JsonProperty("MediaBasicInfo")]
        public MediaBasicInfo MediaBasicInfo{ get; set; }

        /// <summary>
        /// If a video processing flow is specified when a video is uploaded, this field will be the ID of the task flow.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcedureTaskId")]
        public string ProcedureTaskId{ get; set; }

        /// <summary>
        /// Metadata, such as size, duration, video stream information, audio stream information, etc.
        /// Note: this field may return null, indicating that no valid values can be obtained.
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
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
        }
    }
}

