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

    public class InstanceSpec : AbstractModel
    {
        
        /// <summary>
        /// Number of instance CPU cores
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Instance memory in GB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Maximum instance storage capacity GB
        /// </summary>
        [JsonProperty("MaxStorageSize")]
        public ulong? MaxStorageSize{ get; set; }

        /// <summary>
        /// Minimum instance storage capacity GB
        /// </summary>
        [JsonProperty("MinStorageSize")]
        public ulong? MinStorageSize{ get; set; }

        /// <summary>
        /// Whether there is an inventory.
        /// </summary>
        [JsonProperty("HasStock")]
        public bool? HasStock{ get; set; }

        /// <summary>
        /// Machine type
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Maximum IOPS
        /// </summary>
        [JsonProperty("MaxIops")]
        public long? MaxIops{ get; set; }

        /// <summary>
        /// Maximum bandwidth
        /// </summary>
        [JsonProperty("MaxIoBandWidth")]
        public long? MaxIoBandWidth{ get; set; }

        /// <summary>
        /// Regional inventory information.
        /// </summary>
        [JsonProperty("ZoneStockInfos")]
        public ZoneStockInfo[] ZoneStockInfos{ get; set; }

        /// <summary>
        /// Inventory quantity.
        /// </summary>
        [JsonProperty("StockCount")]
        public long? StockCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "MaxStorageSize", this.MaxStorageSize);
            this.SetParamSimple(map, prefix + "MinStorageSize", this.MinStorageSize);
            this.SetParamSimple(map, prefix + "HasStock", this.HasStock);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MaxIops", this.MaxIops);
            this.SetParamSimple(map, prefix + "MaxIoBandWidth", this.MaxIoBandWidth);
            this.SetParamArrayObj(map, prefix + "ZoneStockInfos.", this.ZoneStockInfos);
            this.SetParamSimple(map, prefix + "StockCount", this.StockCount);
        }
    }
}

