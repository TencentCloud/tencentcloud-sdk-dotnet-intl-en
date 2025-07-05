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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDefenseSwitchResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the Basic Protection feature
        /// </summary>
        [JsonProperty("BasicRuleSwitch")]
        public long? BasicRuleSwitch{ get; set; }

        /// <summary>
        /// Whether to enable the Security Baseline feature
        /// </summary>
        [JsonProperty("BaselineAllSwitch")]
        public long? BaselineAllSwitch{ get; set; }

        /// <summary>
        /// Whether to enable the Treat Intelligence feature
        /// </summary>
        [JsonProperty("TiSwitch")]
        public long? TiSwitch{ get; set; }

        /// <summary>
        /// Whether to enable the Virtual Patch feature
        /// </summary>
        [JsonProperty("VirtualPatchSwitch")]
        public long? VirtualPatchSwitch{ get; set; }

        /// <summary>
        /// Whether it has been enabled before
        /// </summary>
        [JsonProperty("HistoryOpen")]
        public long? HistoryOpen{ get; set; }

        /// <summary>
        /// Status code. `0`: Succeeded. Others: Failed
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }

        /// <summary>
        /// Status message. `success` and `fail.
        /// </summary>
        [JsonProperty("ReturnMsg")]
        public string ReturnMsg{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BasicRuleSwitch", this.BasicRuleSwitch);
            this.SetParamSimple(map, prefix + "BaselineAllSwitch", this.BaselineAllSwitch);
            this.SetParamSimple(map, prefix + "TiSwitch", this.TiSwitch);
            this.SetParamSimple(map, prefix + "VirtualPatchSwitch", this.VirtualPatchSwitch);
            this.SetParamSimple(map, prefix + "HistoryOpen", this.HistoryOpen);
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMsg", this.ReturnMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

