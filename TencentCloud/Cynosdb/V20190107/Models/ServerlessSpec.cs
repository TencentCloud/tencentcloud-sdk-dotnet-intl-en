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

    public class ServerlessSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>cpu minimum value</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>Maximum value of cpu</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>Maximum storage space</p>
        /// </summary>
        [JsonProperty("MaxStorageSize")]
        public long? MaxStorageSize{ get; set; }

        /// <summary>
        /// <p>Is the default specification</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }

        /// <summary>
        /// <p>Whether there is inventory</p>
        /// </summary>
        [JsonProperty("HasStock")]
        public bool? HasStock{ get; set; }

        /// <summary>
        /// <p>Inventory quantity</p>
        /// </summary>
        [JsonProperty("StockCount")]
        public long? StockCount{ get; set; }

        /// <summary>
        /// <p>Availability zone inventory information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneStockInfos")]
        public ServerlessZoneStockInfo[] ZoneStockInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "MaxStorageSize", this.MaxStorageSize);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "HasStock", this.HasStock);
            this.SetParamSimple(map, prefix + "StockCount", this.StockCount);
            this.SetParamArrayObj(map, prefix + "ZoneStockInfos.", this.ZoneStockInfos);
        }
    }
}

