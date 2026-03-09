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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetailPrice : AbstractModel
    {
        
        /// <summary>
        /// <p>Name of a billable item, current parameter.</p><li>"DiskSpace" represents the CBS space charge item.</li><li>"DiskBackupQuota" represents the data disk backup point quota charge item.</li><li>"Instance" represents the Instance charge item.</li><li>"SystemDiskBackupQuota" represents the system disk backup point quota charge item.</li>.
        /// </summary>
        [JsonProperty("PriceName")]
        public string PriceName{ get; set; }

        /// <summary>
        /// <P>Unit price per billing item dimension.</p><p>unit: usd</p>.
        /// </summary>
        [JsonProperty("OriginUnitPrice")]
        public float? OriginUnitPrice{ get; set; }

        /// <summary>
        /// <P>Total price of billing item dimension.</p><p>unit: usd</p>.
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// <P>Dimensional discount for billing items.</p>.
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// <P>Discounted total price by billing item dimension.</p><p>unit: usd</p>.
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PriceName", this.PriceName);
            this.SetParamSimple(map, prefix + "OriginUnitPrice", this.OriginUnitPrice);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
        }
    }
}

