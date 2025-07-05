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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBasicDeviceThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// Queried IP address, such as 1.1.1.1
        /// </summary>
        [JsonProperty("BasicIp")]
        public string BasicIp{ get; set; }

        /// <summary>
        /// IP region. Valid values: region abbreviations such as gz, bj, sh, and hk
        /// </summary>
        [JsonProperty("BasicRegion")]
        public string BasicRegion{ get; set; }

        /// <summary>
        /// Zone type. Valid values: public (public cloud zone), bm (BM zone), nat (NAT server zone), channel (internet channel).
        /// </summary>
        [JsonProperty("BasicBizType")]
        public string BasicBizType{ get; set; }

        /// <summary>
        /// Device type. Valid values: cvm (CVM), clb (public CLB), lb (BM CLB), nat (NAT server), channel (internet channel).
        /// </summary>
        [JsonProperty("BasicDeviceType")]
        public string BasicDeviceType{ get; set; }

        /// <summary>
        /// Validity check. Valid value: 1
        /// </summary>
        [JsonProperty("BasicCheckFlag")]
        public ulong? BasicCheckFlag{ get; set; }

        /// <summary>
        /// IPInstance Nat gateway, which is optional. (If the device type to be queried is a NAT server, this parameter is required, which can be obtained through the NAT resource query API)
        /// </summary>
        [JsonProperty("BasicIpInstance")]
        public string BasicIpInstance{ get; set; }

        /// <summary>
        /// ISP line, which is optional. (If the device type to be queried is a NAT server, this parameter should be 5)
        /// </summary>
        [JsonProperty("BasicIspCode")]
        public ulong? BasicIspCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BasicIp", this.BasicIp);
            this.SetParamSimple(map, prefix + "BasicRegion", this.BasicRegion);
            this.SetParamSimple(map, prefix + "BasicBizType", this.BasicBizType);
            this.SetParamSimple(map, prefix + "BasicDeviceType", this.BasicDeviceType);
            this.SetParamSimple(map, prefix + "BasicCheckFlag", this.BasicCheckFlag);
            this.SetParamSimple(map, prefix + "BasicIpInstance", this.BasicIpInstance);
            this.SetParamSimple(map, prefix + "BasicIspCode", this.BasicIspCode);
        }
    }
}

