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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogContextRequest : AbstractModel
    {
        
        /// <summary>
        /// Log topic Id to query.
        /// -Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// - Obtain the log topic Id through [Create Log Topic](https://www.tencentcloud.com/document/product/614/56456?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Log time, which is the Time in the Results structure in the returned information of the [retrieve and analyze logs](https://www.tencentcloud.com/document/product/614/56447?from_cn_redirect=1) api, should be converted from the millisecond-level Unix timestamp to a string in the YYYY-mm-dd HH:MM:SS.FFF format according to the UTC+8 time zone.
        /// </summary>
        [JsonProperty("BTime")]
        public string BTime{ get; set; }

        /// <summary>
        /// Log package sequence number, which is the PkgId in the Results structure returned by the retrieve and analyze logs api (https://www.tencentcloud.com/document/product/614/56447?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// Sequence number of a log within the log package, which is the PkgLogId in the Results structure returned by the [retrieve and analyze logs](https://www.tencentcloud.com/document/product/614/56447?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("PkgLogId")]
        public long? PkgLogId{ get; set; }

        /// <summary>
        /// The previous ${PrevLogs} logs. Default value: 10.
        /// </summary>
        [JsonProperty("PrevLogs")]
        public long? PrevLogs{ get; set; }

        /// <summary>
        /// The next ${NextLogs} logs. Default value: 10.
        /// </summary>
        [JsonProperty("NextLogs")]
        public long? NextLogs{ get; set; }

        /// <summary>
        /// Query statement, filtering the log context with a maximum length of 12KB
        /// The statement consists of <a href="https://www.tencentcloud.com/document/product/614/47044?from_cn_redirect=1" target="_blank">[retrieval criteria]</a> and does not support SQL statement.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Context search start time, unit: millisecond-level timestamp
        /// Note:
        /// -When From is empty, it means no restrictions on the start time of context search.
        /// -From and To are not empty, From < To
        /// -Currently, the system only supports the Shanghai/Virginia/Singapore region.
        /// </summary>
        [JsonProperty("From")]
        public ulong? From{ get; set; }

        /// <summary>
        /// End time of context search. Measurement unit: millisecond-level timestamp.
        /// Note:
        /// -When To is empty, it means no restrictions on the end time of context search.
        /// -From and To are not empty, From < To
        /// -Currently, the system only supports the Shanghai/Virginia/Singapore region.
        /// </summary>
        [JsonProperty("To")]
        public ulong? To{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "BTime", this.BTime);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "PkgLogId", this.PkgLogId);
            this.SetParamSimple(map, prefix + "PrevLogs", this.PrevLogs);
            this.SetParamSimple(map, prefix + "NextLogs", this.NextLogs);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
        }
    }
}

