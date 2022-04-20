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

    public class CreateExportRequest : AbstractModel
    {
        
        /// <summary>
        /// Log topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Number of logs to be exported. Maximum value: 50 million
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Search statements for log export. <a href="https://intl.cloud.tencent.com/document/product/614/44061?from_cn_redirect=1" target="_blank">[SQL statements]</a> are not supported.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Start time of the log to be exported, which is a timestamp in milliseconds
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// End time of the log to be exported, which is a timestamp in milliseconds
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// Exported log sorting order by time. Valid values: `asc`: ascending; `desc`: descending. Default value: `desc`
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Exported log data format. Valid values: `json`, `csv`. Default value: `json`
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Format", this.Format);
        }
    }
}

