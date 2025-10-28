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

    public class GoodsPrice : AbstractModel
    {
        
        /// <summary>
        /// Specifies the instance price.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstancePrice")]
        public TradePrice InstancePrice{ get; set; }

        /// <summary>
        /// Specifies the storage price.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StoragePrice")]
        public TradePrice StoragePrice{ get; set; }

        /// <summary>
        /// Specifies the product specification.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GoodsSpec")]
        public GoodsSpec GoodsSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InstancePrice.", this.InstancePrice);
            this.SetParamObj(map, prefix + "StoragePrice.", this.StoragePrice);
            this.SetParamObj(map, prefix + "GoodsSpec.", this.GoodsSpec);
        }
    }
}

