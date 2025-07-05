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

    public class PolicyDetail : AbstractModel
    {
        
        /// <summary>
        /// User discount.
        /// </summary>
        [JsonProperty("UserDiscount")]
        public long? UserDiscount{ get; set; }

        /// <summary>
        /// Public discount.
        /// </summary>
        [JsonProperty("CommonDiscount")]
        public long? CommonDiscount{ get; set; }

        /// <summary>
        /// Final discount.
        /// </summary>
        [JsonProperty("FinalDiscount")]
        public long? FinalDiscount{ get; set; }

        /// <summary>
        /// Activity discount. The value `null` indicates no discount.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActivityDiscount")]
        public float? ActivityDiscount{ get; set; }

        /// <summary>
        /// Discount type.
        /// Valid values: `user` (user discount), `common` (discount displayed on the official website), `activity` (activity discount), `null` (no discount).
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiscountType")]
        public string DiscountType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserDiscount", this.UserDiscount);
            this.SetParamSimple(map, prefix + "CommonDiscount", this.CommonDiscount);
            this.SetParamSimple(map, prefix + "FinalDiscount", this.FinalDiscount);
            this.SetParamSimple(map, prefix + "ActivityDiscount", this.ActivityDiscount);
            this.SetParamSimple(map, prefix + "DiscountType", this.DiscountType);
        }
    }
}

