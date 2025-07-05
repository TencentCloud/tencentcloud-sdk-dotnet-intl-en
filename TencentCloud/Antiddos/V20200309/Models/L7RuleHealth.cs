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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L7RuleHealth : AbstractModel
    {
        
        /// <summary>
        /// Configuration status. Values: `0` (normal), `1` (configuration in progress) and `2` (configuration failed).
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Switch. Values: `1`: Enable; `0`: Disable.
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// ID of the rule
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// HTTP request path. The default value is /.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Health check interval. Unit: second.
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// Healthy threshold, which specifies the number of consecutive successful health checks.
        /// </summary>
        [JsonProperty("AliveNum")]
        public ulong? AliveNum{ get; set; }

        /// <summary>
        /// Unhealthy threshold, which specifies the number of consecutive failed health checks.
        /// </summary>
        [JsonProperty("KickNum")]
        public ulong? KickNum{ get; set; }

        /// <summary>
        /// HTTP request method. Values: `HEAD` and `GET`.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Status code that signifies a normal state. Values: `1` (1xx), `2` (2xx), `4` (3xx), `8` (4xx), and `16` (5xx).
        /// </summary>
        [JsonProperty("StatusCode")]
        public ulong? StatusCode{ get; set; }

        /// <summary>
        /// Whether to deploy both HTTP and HTTPS health check rules
        /// </summary>
        [JsonProperty("ProtocolFlag")]
        public ulong? ProtocolFlag{ get; set; }

        /// <summary>
        /// Enables passive detection. Values: `1` (enable) and `0` (disable).
        /// </summary>
        [JsonProperty("PassiveEnable")]
        public ulong? PassiveEnable{ get; set; }

        /// <summary>
        /// Blocking period in the passive detection configuration
        /// </summary>
        [JsonProperty("BlockInter")]
        public ulong? BlockInter{ get; set; }

        /// <summary>
        /// Time interval between passive detections
        /// </summary>
        [JsonProperty("FailedCountInter")]
        public ulong? FailedCountInter{ get; set; }

        /// <summary>
        /// Unhealthy threshold in the passive detection configuration
        /// </summary>
        [JsonProperty("FailedThreshold")]
        public ulong? FailedThreshold{ get; set; }

        /// <summary>
        /// Status code that signals that the passive detection considers the status normal. Values: `1` (1xx), `2` (2xx), `4` (3xx), `8` (4xx), and `16` (5xx).
        /// </summary>
        [JsonProperty("PassiveStatusCode")]
        public ulong? PassiveStatusCode{ get; set; }

        /// <summary>
        /// Configuration status of the passive health check. Values: `0` (Normal), `1` (configuration in progress) and `2` (configuration failed).
        /// </summary>
        [JsonProperty("PassiveStatus")]
        public ulong? PassiveStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "AliveNum", this.AliveNum);
            this.SetParamSimple(map, prefix + "KickNum", this.KickNum);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "ProtocolFlag", this.ProtocolFlag);
            this.SetParamSimple(map, prefix + "PassiveEnable", this.PassiveEnable);
            this.SetParamSimple(map, prefix + "BlockInter", this.BlockInter);
            this.SetParamSimple(map, prefix + "FailedCountInter", this.FailedCountInter);
            this.SetParamSimple(map, prefix + "FailedThreshold", this.FailedThreshold);
            this.SetParamSimple(map, prefix + "PassiveStatusCode", this.PassiveStatusCode);
            this.SetParamSimple(map, prefix + "PassiveStatus", this.PassiveStatus);
        }
    }
}

