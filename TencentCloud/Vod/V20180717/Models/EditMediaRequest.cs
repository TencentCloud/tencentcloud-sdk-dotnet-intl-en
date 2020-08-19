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

    public class EditMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// Input video type. Valid values: File, Stream.
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// Information of input video file, which is required if `InputType` is `File`.
        /// </summary>
        [JsonProperty("FileInfos")]
        public EditMediaFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// Input stream information, which is required if `InputType` is `Stream`.
        /// </summary>
        [JsonProperty("StreamInfos")]
        public EditMediaStreamInfo[] StreamInfos{ get; set; }

        /// <summary>
        /// Editing template ID. Valid values: 10, 20. If this parameter is left empty, template 10 will be used.
        /// <li>10: the input with the highest resolution will be used as the benchmark;</li>
        /// <li>20: the input with the highest bitrate will be used as the benchmark;</li>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// [Task flow template](https://intl.cloud.tencent.com/document/product/266/11700?from_cn_redirect=1#.E4.BB.BB.E5.8A.A1.E6.B5.81.E6.A8.A1.E6.9D.BF) name, which should be entered if you want to perform a task flow on the generated new video.
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// Configuration of file generated after editing.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public EditMediaOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// Identifies the source context which is used to pass through the user request information. The `EditMediaComplete` callback and task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Task priority. The higher the value, the higher the priority. Value range: -10-10. If this parameter is left empty, 0 will be used.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// ID used for task deduplication. If there was a request with the same ID in the last day, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or a blank string is entered, no deduplication will be performed.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// [Subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

