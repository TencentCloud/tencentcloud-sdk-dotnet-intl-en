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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MsgRecordResult : AbstractModel
    {
        
        /// <summary>
        /// Indicates the call result of the message: 0=CALL_RESULT_UNKNOWN (all/unknown), 1=CALL_RESULT_SUCCESS (success), 2=CALL_RESULT_FAILED (failed). fail_reason (string) describes the failure reason when the call failed.
        /// </summary>
        [JsonProperty("CallResult")]
        public long? CallResult{ get; set; }

        /// <summary>
        /// Custom variable, json string
        /// </summary>
        [JsonProperty("CustomerVariable")]
        public string CustomerVariable{ get; set; }

        /// <summary>
        /// Failure cause.
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// Time to first token
        /// </summary>
        [JsonProperty("FirstTokenLatency")]
        public ulong? FirstTokenLatency{ get; set; }

        /// <summary>
        /// Number of input tokens.
        /// </summary>
        [JsonProperty("InputToken")]
        public ulong? InputToken{ get; set; }

        /// <summary>
        /// Number of output tokens.
        /// </summary>
        [JsonProperty("OutputToken")]
        public ulong? OutputToken{ get; set; }

        /// <summary>
        /// Total number of tokens.
        /// </summary>
        [JsonProperty("TotalToken")]
        public ulong? TotalToken{ get; set; }

        /// <summary>
        /// Total token duration
        /// </summary>
        [JsonProperty("TotalTokenLatency")]
        public ulong? TotalTokenLatency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallResult", this.CallResult);
            this.SetParamSimple(map, prefix + "CustomerVariable", this.CustomerVariable);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "FirstTokenLatency", this.FirstTokenLatency);
            this.SetParamSimple(map, prefix + "InputToken", this.InputToken);
            this.SetParamSimple(map, prefix + "OutputToken", this.OutputToken);
            this.SetParamSimple(map, prefix + "TotalToken", this.TotalToken);
            this.SetParamSimple(map, prefix + "TotalTokenLatency", this.TotalTokenLatency);
        }
    }
}

