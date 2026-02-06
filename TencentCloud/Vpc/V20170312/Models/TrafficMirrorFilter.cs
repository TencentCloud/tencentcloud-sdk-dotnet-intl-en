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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficMirrorFilter : AbstractModel
    {
        
        /// <summary>
        /// Source network segment of the filter rule.
        /// </summary>
        [JsonProperty("SrcNet")]
        public string SrcNet{ get; set; }

        /// <summary>
        /// Destination network segment of the filter rule.
        /// </summary>
        [JsonProperty("DstNet")]
        public string DstNet{ get; set; }

        /// <summary>
        /// Protocol of the filter rule.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Source port of the filter rule. Default value: 1–65535.
        /// </summary>
        [JsonProperty("SrcPort")]
        public string SrcPort{ get; set; }

        /// <summary>
        /// Destination port of the filter rule. Default value: 1–65535.
        /// </summary>
        [JsonProperty("DstPort")]
        public string DstPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcNet", this.SrcNet);
            this.SetParamSimple(map, prefix + "DstNet", this.DstNet);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SrcPort", this.SrcPort);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
        }
    }
}

