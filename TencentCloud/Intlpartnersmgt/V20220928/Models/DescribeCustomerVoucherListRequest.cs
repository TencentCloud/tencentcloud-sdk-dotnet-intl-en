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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCustomerVoucherListRequest : AbstractModel
    {
        
        /// <summary>
        /// Page number, starts from 1.
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// Number of items per page. value range: 1-100.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Customer UIN.
        /// </summary>
        [JsonProperty("CustomerUin")]
        public long? CustomerUin{ get; set; }

        /// <summary>
        /// Voucher status. valid values: Issued, Used, Expired, Invalidated.
        /// </summary>
        [JsonProperty("VoucherStatus")]
        public string VoucherStatus{ get; set; }

        /// <summary>
        /// Payment mode. valid values: AllPayment, Prepaid, Postpaid.
        /// </summary>
        [JsonProperty("PaymentMode")]
        public string PaymentMode{ get; set; }

        /// <summary>
        /// valid values: ProductTrial, CustomerOffer.
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// Applicable product. valid values: AllProducts, SpecifyProducts, SpecifyProductsBlacklist.
        /// </summary>
        [JsonProperty("ProductScope")]
        public string ProductScope{ get; set; }

        /// <summary>
        /// Voucher ID.
        /// </summary>
        [JsonProperty("VoucherId")]
        public long? VoucherId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "CustomerUin", this.CustomerUin);
            this.SetParamSimple(map, prefix + "VoucherStatus", this.VoucherStatus);
            this.SetParamSimple(map, prefix + "PaymentMode", this.PaymentMode);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "ProductScope", this.ProductScope);
            this.SetParamSimple(map, prefix + "VoucherId", this.VoucherId);
        }
    }
}

