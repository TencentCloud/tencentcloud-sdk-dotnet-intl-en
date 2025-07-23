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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PayDealsRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies one or more Sub-order No. that need to pay. must pass either this parameter or the BigDealIds field, but not both.
        /// </summary>
        [JsonProperty("OrderIds")]
        public string[] OrderIds{ get; set; }

        /// <summary>
        /// Whether to automatically use a voucher. valid values: 1 (yes), 0 (no). default: 0.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Voucher ID list. currently only supports specifying one voucher.
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// Specifies one or more Order No. that need to pay. must pass either this parameter or the OrderIds field.
        /// </summary>
        [JsonProperty("BigDealIds")]
        public string[] BigDealIds{ get; set; }

        /// <summary>
        /// 0 self pay, 3 group agent, 4 reseller places a product-level payment order for customers. default 0.
        /// </summary>
        [JsonProperty("AgentPay")]
        public long? AgentPay{ get; set; }

        /// <summary>
        /// Disregard it.
        /// </summary>
        [JsonProperty("CpsUin")]
        public string CpsUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "OrderIds.", this.OrderIds);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamArraySimple(map, prefix + "BigDealIds.", this.BigDealIds);
            this.SetParamSimple(map, prefix + "AgentPay", this.AgentPay);
            this.SetParamSimple(map, prefix + "CpsUin", this.CpsUin);
        }
    }
}

