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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceScaleOutInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// Original price.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginalCost")]
        public string OriginalCost{ get; set; }

        /// <summary>
        /// Discounted price.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiscountCost")]
        public string DiscountCost{ get; set; }

        /// <summary>
        /// Time unit of scale-out. Valid values:
        /// <li>s: seconds.</li>
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Node specification queried for price.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PriceSpec")]
        public PriceResource PriceSpec{ get; set; }

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
            this.SetParamSimple(map, prefix + "OriginalCost", this.OriginalCost);
            this.SetParamSimple(map, prefix + "DiscountCost", this.DiscountCost);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamObj(map, prefix + "PriceSpec.", this.PriceSpec);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

