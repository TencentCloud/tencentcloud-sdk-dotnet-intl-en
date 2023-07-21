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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreviewLogStatistic : AbstractModel
    {
        
        /// <summary>
        /// Log content
        /// </summary>
        [JsonProperty("LogContent")]
        public string LogContent{ get; set; }

        /// <summary>
        /// Line number
        /// </summary>
        [JsonProperty("LineNum")]
        public long? LineNum{ get; set; }

        /// <summary>
        /// Target log topic
        /// </summary>
        [JsonProperty("DstTopicId")]
        public string DstTopicId{ get; set; }

        /// <summary>
        /// Error code. An empty string "" indicates no error.
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// Log timestamp
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Target topic name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DstTopicName")]
        public string DstTopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogContent", this.LogContent);
            this.SetParamSimple(map, prefix + "LineNum", this.LineNum);
            this.SetParamSimple(map, prefix + "DstTopicId", this.DstTopicId);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "DstTopicName", this.DstTopicName);
        }
    }
}

