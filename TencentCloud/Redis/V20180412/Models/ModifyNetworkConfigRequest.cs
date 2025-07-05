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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetworkConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Network change type. Valid values:
        /// - `changeVip`: VPC change, including the private IPv4 address and port.
        /// - `changeVpc`: Subnet change.
        /// - `changeBaseToVpc`: Change from classic network to VPC.
        /// - `changeVPort`: Port change.
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// Private IPv4 address of the instance, which is required if `Operation` is `changeVip`.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// VPC ID after the modification.
        /// - Configure this parameter when **Operation** is set to **changeVpc** or **changeBaseToVpc**.
        /// - Log in to the [Redis console](https://console.tencentcloud.com/redis/instance), switch to the **Instance Details** page, and click the VPC name next to the associated network in the **Network Information** area to obtain the VPC ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// ID of the subnet to which the VPC belongs after the modification.
        /// - Configure this parameter when **Operation** is set to **changeVpc** or **changeBaseToVpc**.
        /// - Log in to the [Redis console](https://console.tencentcloud.com/redis/instance), switch to the **Instance Details** page, and click the subnet name next to the associated network in the **Network Information** area to obtain the subnet ID.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Retention duration of the original private IPv4 address.
        /// - Unit: day.
        /// - Valid values: 0, 1, 2, 3, 7, and 15.
        /// **Note**: If the retention duration is not set or set to 0, the original network address will be released immediately.
        /// </summary>
        [JsonProperty("Recycle")]
        public long? Recycle{ get; set; }

        /// <summary>
        /// Network port after the change, which is required if `Operation` is `changeVPort` or `changeVip`. Value range: [1024,65535].
        /// </summary>
        [JsonProperty("VPort")]
        public long? VPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Recycle", this.Recycle);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
        }
    }
}

