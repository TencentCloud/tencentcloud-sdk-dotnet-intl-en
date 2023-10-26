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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillDetailAssociatedOrder : AbstractModel
    {
        
        /// <summary>
        /// Purchase order.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrepayPurchase")]
        public string PrepayPurchase{ get; set; }

        /// <summary>
        /// Renewal order.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrepayRenew")]
        public string PrepayRenew{ get; set; }

        /// <summary>
        /// Upgrade order.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrepayModifyUp")]
        public string PrepayModifyUp{ get; set; }

        /// <summary>
        /// Write-off order.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReverseOrder")]
        public string ReverseOrder{ get; set; }

        /// <summary>
        /// The order after discount.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NewOrder")]
        public string NewOrder{ get; set; }

        /// <summary>
        /// The original order before discount.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Original")]
        public string Original{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrepayPurchase", this.PrepayPurchase);
            this.SetParamSimple(map, prefix + "PrepayRenew", this.PrepayRenew);
            this.SetParamSimple(map, prefix + "PrepayModifyUp", this.PrepayModifyUp);
            this.SetParamSimple(map, prefix + "ReverseOrder", this.ReverseOrder);
            this.SetParamSimple(map, prefix + "NewOrder", this.NewOrder);
            this.SetParamSimple(map, prefix + "Original", this.Original);
        }
    }
}

