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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNetworkInterfaceLimitResponse : AbstractModel
    {
        
        /// <summary>
        /// Quota of ENIs mounted to a CVM instance in a standard way
        /// </summary>
        [JsonProperty("EniQuantity")]
        public long? EniQuantity{ get; set; }

        /// <summary>
        /// Quota of IP addresses that can be allocated to each standard-mounted ENI
        /// </summary>
        [JsonProperty("EniPrivateIpAddressQuantity")]
        public long? EniPrivateIpAddressQuantity{ get; set; }

        /// <summary>
        /// Quota of ENIs mounted to a CVM instance as an extension
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtendEniQuantity")]
        public long? ExtendEniQuantity{ get; set; }

        /// <summary>
        /// Quota of IP addresses that can be allocated to each extension-mounted ENI.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtendEniPrivateIpAddressQuantity")]
        public long? ExtendEniPrivateIpAddressQuantity{ get; set; }

        /// <summary>
        /// The quota of relayed ENIs
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubEniQuantity")]
        public long? SubEniQuantity{ get; set; }

        /// <summary>
        /// The quota of IPs that can be assigned to each relayed ENI.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubEniPrivateIpAddressQuantity")]
        public long? SubEniPrivateIpAddressQuantity{ get; set; }

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
            this.SetParamSimple(map, prefix + "EniQuantity", this.EniQuantity);
            this.SetParamSimple(map, prefix + "EniPrivateIpAddressQuantity", this.EniPrivateIpAddressQuantity);
            this.SetParamSimple(map, prefix + "ExtendEniQuantity", this.ExtendEniQuantity);
            this.SetParamSimple(map, prefix + "ExtendEniPrivateIpAddressQuantity", this.ExtendEniPrivateIpAddressQuantity);
            this.SetParamSimple(map, prefix + "SubEniQuantity", this.SubEniQuantity);
            this.SetParamSimple(map, prefix + "SubEniPrivateIpAddressQuantity", this.SubEniPrivateIpAddressQuantity);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

