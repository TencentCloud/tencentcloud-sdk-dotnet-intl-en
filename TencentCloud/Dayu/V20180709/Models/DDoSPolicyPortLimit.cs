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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSPolicyPortLimit : AbstractModel
    {
        
        /// <summary>
        /// Protocol. Valid values: [tcp, udp, all]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Start destination port. Value range: [0,65535]
        /// </summary>
        [JsonProperty("DPortStart")]
        public ulong? DPortStart{ get; set; }

        /// <summary>
        /// End destination port, which must be greater than or equal to the start destination port. Value range: [0,65535]
        /// </summary>
        [JsonProperty("DPortEnd")]
        public ulong? DPortEnd{ get; set; }

        /// <summary>
        /// Start source port. Value range: [0,65535]
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SPortStart")]
        public ulong? SPortStart{ get; set; }

        /// <summary>
        /// End source port, which must be greater than or equal to the start source port. Value range: [0,65535]
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SPortEnd")]
        public ulong? SPortEnd{ get; set; }

        /// <summary>
        /// Action to be executed. Valid values: [drop (discard) , transmit (forward)]
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Type of port to be disabled. Valid values: [0 (destination port range), 1 (source port range), 2 (destination port range and source port range)]
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DPortStart", this.DPortStart);
            this.SetParamSimple(map, prefix + "DPortEnd", this.DPortEnd);
            this.SetParamSimple(map, prefix + "SPortStart", this.SPortStart);
            this.SetParamSimple(map, prefix + "SPortEnd", this.SPortEnd);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
        }
    }
}

