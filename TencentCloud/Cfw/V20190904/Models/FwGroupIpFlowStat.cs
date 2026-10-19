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

    public class FwGroupIpFlowStat : AbstractModel
    {
        
        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// VPCID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// Peak traffic
        /// </summary>
        [JsonProperty("FlowMax")]
        public long? FlowMax{ get; set; }

        /// <summary>
        /// Average bandwidth
        /// </summary>
        [JsonProperty("FlowAvg")]
        public float? FlowAvg{ get; set; }

        /// <summary>
        /// Rate limiting status
        /// </summary>
        [JsonProperty("TcRuleStatus")]
        public long? TcRuleStatus{ get; set; }

        /// <summary>
        /// Firewall ID.
        /// </summary>
        [JsonProperty("FwInsId")]
        public string FwInsId{ get; set; }

        /// <summary>
        /// 0 IPV4 , 1 IPV6
        /// </summary>
        [JsonProperty("IpVersion")]
        public long? IpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "FlowMax", this.FlowMax);
            this.SetParamSimple(map, prefix + "FlowAvg", this.FlowAvg);
            this.SetParamSimple(map, prefix + "TcRuleStatus", this.TcRuleStatus);
            this.SetParamSimple(map, prefix + "FwInsId", this.FwInsId);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
        }
    }
}

