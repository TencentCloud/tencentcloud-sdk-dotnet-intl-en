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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyZoneStockInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>AZ.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>CPU inventory</p><p>This field is not a judgment standard for whether there are resources for delivery. For resources, refer to CheckProxyStockInfos</p>
        /// </summary>
        [JsonProperty("CpuStock")]
        public long? CpuStock{ get; set; }

        /// <summary>
        /// <p>Memory inventory</p><p>This field is not used as a judgment standard for whether there are resources for delivery. For resources, see CheckProxyStockInfos</p>
        /// </summary>
        [JsonProperty("MemStock")]
        public long? MemStock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CpuStock", this.CpuStock);
            this.SetParamSimple(map, prefix + "MemStock", this.MemStock);
        }
    }
}

