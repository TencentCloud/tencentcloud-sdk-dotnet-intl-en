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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceNetworkLimitConfig : AbstractModel
    {
        
        /// <summary>
        /// Number of CPU cores
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// ENI quantity limit
        /// </summary>
        [JsonProperty("NetworkInterfaceLimit")]
        public long? NetworkInterfaceLimit{ get; set; }

        /// <summary>
        /// Private IP quantity limit per ENI
        /// </summary>
        [JsonProperty("InnerIpPerNetworkInterface")]
        public long? InnerIpPerNetworkInterface{ get; set; }

        /// <summary>
        /// Public IP limit per instance
        /// </summary>
        [JsonProperty("PublicIpPerInstance")]
        public long? PublicIpPerInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "NetworkInterfaceLimit", this.NetworkInterfaceLimit);
            this.SetParamSimple(map, prefix + "InnerIpPerNetworkInterface", this.InnerIpPerNetworkInterface);
            this.SetParamSimple(map, prefix + "PublicIpPerInstance", this.PublicIpPerInstance);
        }
    }
}

