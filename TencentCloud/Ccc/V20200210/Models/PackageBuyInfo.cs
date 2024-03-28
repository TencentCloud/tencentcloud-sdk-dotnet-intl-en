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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackageBuyInfo : AbstractModel
    {
        
        /// <summary>
        /// Package ID.
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// Package type, 0 - Outbound call package | 1 - 400 inbound call package.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Total package.
        /// </summary>
        [JsonProperty("CapacitySize")]
        public long? CapacitySize{ get; set; }

        /// <summary>
        /// Remaining package.
        /// </summary>
        [JsonProperty("CapacityRemain")]
        public long? CapacityRemain{ get; set; }

        /// <summary>
        /// Purchased timestamp.
        /// </summary>
        [JsonProperty("BuyTime")]
        public long? BuyTime{ get; set; }

        /// <summary>
        /// End timestamp.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CapacitySize", this.CapacitySize);
            this.SetParamSimple(map, prefix + "CapacityRemain", this.CapacityRemain);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

