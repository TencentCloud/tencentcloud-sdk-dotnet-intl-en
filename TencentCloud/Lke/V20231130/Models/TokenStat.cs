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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TokenStat : AbstractModel
    {
        
        /// <summary>
        /// Session ID.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Request ID.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// It corresponds to a session, session id, used for storing messages for answering. It can be generated in advance, used when saving messages.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Number of consumed tokens.
        /// </summary>
        [JsonProperty("UsedCount")]
        public ulong? UsedCount{ get; set; }

        /// <summary>
        /// Number of free tokens.
        /// </summary>
        [JsonProperty("FreeCount")]
        public ulong? FreeCount{ get; set; }

        /// <summary>
        /// Total number of tokens for orders.
        /// </summary>
        [JsonProperty("OrderCount")]
        public ulong? OrderCount{ get; set; }

        /// <summary>
        /// Current execution status summary. Constant: processing, success., failed.
        /// </summary>
        [JsonProperty("StatusSummary")]
        public string StatusSummary{ get; set; }

        /// <summary>
        /// Chinese display after summarizing the current execution status.
        /// </summary>
        [JsonProperty("StatusSummaryTitle")]
        public string StatusSummaryTitle{ get; set; }

        /// <summary>
        /// Current request execution time, in milliseconds.
        /// </summary>
        [JsonProperty("Elapsed")]
        public ulong? Elapsed{ get; set; }

        /// <summary>
        /// Number of tokens consumed by the current request.
        /// </summary>
        [JsonProperty("TokenCount")]
        public ulong? TokenCount{ get; set; }

        /// <summary>
        /// Execution information.
        /// </summary>
        [JsonProperty("Procedures")]
        public Procedure[] Procedures{ get; set; }

        /// <summary>
        /// Execution process information TraceId.
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "UsedCount", this.UsedCount);
            this.SetParamSimple(map, prefix + "FreeCount", this.FreeCount);
            this.SetParamSimple(map, prefix + "OrderCount", this.OrderCount);
            this.SetParamSimple(map, prefix + "StatusSummary", this.StatusSummary);
            this.SetParamSimple(map, prefix + "StatusSummaryTitle", this.StatusSummaryTitle);
            this.SetParamSimple(map, prefix + "Elapsed", this.Elapsed);
            this.SetParamSimple(map, prefix + "TokenCount", this.TokenCount);
            this.SetParamArrayObj(map, prefix + "Procedures.", this.Procedures);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
        }
    }
}

