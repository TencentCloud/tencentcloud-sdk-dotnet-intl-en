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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageOption : AbstractModel
    {
        
        /// <summary>
        /// CFS type. Valid values:
        /// - SD: standard
        /// - HP: high-performance
        /// - TB: standard Turbo
        /// - TP: high-performance Turbo
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// CFS availability zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// CFS capacity in GiB, required for the Turbo series
        /// - Standard Turbo has a minimum capacity of 40 TiB, or 40,960 GiB; the capacity expansion step is 20 TiB, or 20,480 GiB.
        /// - High-performance Turbo has a minimum capacity of 20 TiB, or 20,480 GiB; the capacity expansion step is 10 TiB, or 10,240 GiB.
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
        }
    }
}

