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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceNetworkAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Old IP retention period in minutes. The old IP will be released after the specified time, and both the old and new IPs can be accessed before the release. The value `0` indicates that the old IP will be reclaimed immediately.
        /// </summary>
        [JsonProperty("OldIpExpiredTime")]
        public ulong? OldIpExpiredTime{ get; set; }

        /// <summary>
        /// ID of the VPC to which the new IP belongs after the switch. When it is classic network, this field will be empty.
        /// </summary>
        [JsonProperty("NewUniqVpcId")]
        public string NewUniqVpcId{ get; set; }

        /// <summary>
        /// ID of the subnet to which the new IP belongs after the switch. When it is classic network, this field will be empty.
        /// </summary>
        [JsonProperty("NewUniqSubnetId")]
        public string NewUniqSubnetId{ get; set; }

        /// <summary>
        /// IP information to be modified
        /// </summary>
        [JsonProperty("NetworkAddresses")]
        public ModifyNetworkAddress[] NetworkAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OldIpExpiredTime", this.OldIpExpiredTime);
            this.SetParamSimple(map, prefix + "NewUniqVpcId", this.NewUniqVpcId);
            this.SetParamSimple(map, prefix + "NewUniqSubnetId", this.NewUniqSubnetId);
            this.SetParamArrayObj(map, prefix + "NetworkAddresses.", this.NetworkAddresses);
        }
    }
}

