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

    public class EditMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// Type of input video. Valid values: `File` and `Stream`.
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Input video file information. Required when InputType is File.
        /// </summary>
        [JsonProperty("FileInfos")]
        public EditMediaFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// Input stream information. Required when `InputType` is `Stream`.
        /// </summary>
        [JsonProperty("StreamInfos")]
        public EditMediaStreamInfo[] StreamInfos{ get; set; }

        /// <summary>
        /// Edit template ID. Valid values: 10 and 20. Default value: 10.
        /// <li>10: During splicing, use the input with the highest resolution as the base;</li>
        /// <li>20: During splicing, use the input with the highest bitrate as the base.</li>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// [Task flow](https://www.tencentcloud.com/document/product/266/33475?from_cn_redirect=1#.E4.BB.BB.E5.8A.A1.E6.B5.81) name. Fill in if you want to execute a task flow on the generated new video.
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// File configuration generated after editing.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public EditMediaOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// Identify source context, used to pass through user request information. This field value will be returned in the EditMediaComplete callback and task flow status change callback. Maximum length: 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Task Priority. The higher the value, the higher the priority. The value range is from -10 to 10. If left blank, the default value is 0.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Identification Code for Task Deduplication. If there has been a request with the same identification code within the past 3 days, an error will be returned for the current request. The maximum length is 50 characters. Leaving it blank or using an empty string indicates no deduplication.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Reserved field, used for special purposes.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

