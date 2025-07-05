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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCheckParams : AbstractModel
    {
        
        /// <summary>
        /// Time interval of health check
        /// </summary>
        [JsonProperty("DelayLoop")]
        public ulong? DelayLoop{ get; set; }

        /// <summary>
        /// Response timeout of health check
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// Check path of health check
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Health check method: GET/HEAD
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Return code indicting normal origin servers. Value range: [100, 200, 300, 400, 500]
        /// </summary>
        [JsonProperty("StatusCode")]
        public ulong?[] StatusCode{ get; set; }

        /// <summary>
        /// Domain name to be performed health check
        /// You cannot modify this parameter when calling ModifyRuleAttribute API.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Origin server failure check frequency
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FailedCountInter")]
        public ulong? FailedCountInter{ get; set; }

        /// <summary>
        /// Origin server health check threshold. All requests to the origin server will be blocked once the threshold is exceeded.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FailedThreshold")]
        public ulong? FailedThreshold{ get; set; }

        /// <summary>
        /// Duration to block requests targeting the origin server after a failed health check
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BlockInter")]
        public ulong? BlockInter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DelayLoop", this.DelayLoop);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "StatusCode.", this.StatusCode);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "FailedCountInter", this.FailedCountInter);
            this.SetParamSimple(map, prefix + "FailedThreshold", this.FailedThreshold);
            this.SetParamSimple(map, prefix + "BlockInter", this.BlockInter);
        }
    }
}

