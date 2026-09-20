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

    public class ExtractBlindWatermarkRequest : AbstractModel
    {
        
        /// <summary>
        /// Digital watermark type. Valid values: <li>blind-basic: basic copyright digital watermark;</li> <li>blind-trace: traceable AB sequence watermark.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// File input information for the Media Processing Service (MPS) task.
        /// </summary>
        [JsonProperty("InputInfo")]
        public ExtractBlindWatermarkInputInfo InputInfo{ get; set; }

        /// <summary>
        /// VOD application ID used for watermarking. Note that whether you pass in a FILEID or URL, it must match the SubAppId used for watermarking to extract the watermark.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Configuration of the digital watermark extraction task.
        /// </summary>
        [JsonProperty("ExtractBlindWatermarkConfig")]
        public ExtractBlindWatermarkTaskConfig ExtractBlindWatermarkConfig{ get; set; }

        /// <summary>
        /// Identifies source context, used to pass through user request information. This field value will be returned in the ExtractBlindWatermarkComplete callback and task flow status change callback. Up to 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Identification Code for Task Deduplication. If there has been a request with the same identification code within the past 3 days, an error will be returned for the current request. The maximum length is 50 characters. Leaving it blank or using a null string indicates no deduplication.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Task Priority. The higher the value, the higher the priority. The value range is from -10 to 10. If left blank, the default value is 0.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "ExtractBlindWatermarkConfig.", this.ExtractBlindWatermarkConfig);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
        }
    }
}

