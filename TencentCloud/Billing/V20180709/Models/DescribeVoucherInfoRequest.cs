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

    public class DescribeVoucherInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>How many data entries per page, 20 is selected by default, maximum not exceeding 1000</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Page number, starts from 1 by default</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Voucher status: pending use: unUsed, Used: used, delivered: delivered, discarded: cancel, expired: overdue</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Voucher id</p>
        /// </summary>
        [JsonProperty("VoucherId")]
        public string VoucherId{ get; set; }

        /// <summary>
        /// <p>Voucher order id</p>
        /// </summary>
        [JsonProperty("CodeId")]
        public string CodeId{ get; set; }

        /// <summary>
        /// <p>product code</p>
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// <p>Activity id</p>
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// <p>Voucher name</p>
        /// </summary>
        [JsonProperty("VoucherName")]
        public string VoucherName{ get; set; }

        /// <summary>
        /// <p>Start time of delivery. Example: 2021-01-01</p>
        /// </summary>
        [JsonProperty("TimeFrom")]
        public string TimeFrom{ get; set; }

        /// <summary>
        /// <p>Delivery end time. Example: 2021-01-01</p>
        /// </summary>
        [JsonProperty("TimeTo")]
        public string TimeTo{ get; set; }

        /// <summary>
        /// <p>Specified sorting field: BeginTime start time, EndTime expiry time, CreateTime creation time</p>
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// <p>Specify ascending/descending order: desc, asc</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// <p>Payment mode, postPay (postpaid)/prePay (prepaid)/riPay (reserved instance)/"" or "*" means all modes. If payMode is "" or "*", productCode and subProductCode must be empty.</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Payment scenario PayMode=postPay: spotpay - spot instance, "settle account" - standard post-paid. PayMode=prePay: purchase - monthly subscription new purchase, renew - annual and monthly renewal (auto renewal), modify - monthly subscription configuration change. PayMode=riPay: oneOffFee - prepayment of reserved instance, hourlyFee - hourly charge for reserved instance, * - support all payment scenarios.</p>
        /// </summary>
        [JsonProperty("PayScene")]
        public string PayScene{ get; set; }

        /// <summary>
        /// <p>Operator is used by default as user uin</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>The primary types of vouchers are has_price and no_price, which represent the cash voucher with a price and the cash voucher without a price respectively.</p>
        /// </summary>
        [JsonProperty("VoucherMainType")]
        public string VoucherMainType{ get; set; }

        /// <summary>
        /// <p>Voucher subtype: Discount is a discount voucher, and deduct is a deduction voucher.</p>
        /// </summary>
        [JsonProperty("VoucherSubType")]
        public string VoucherSubType{ get; set; }

        /// <summary>
        /// <p>Voucher validity start time</p>
        /// </summary>
        [JsonProperty("StartTimeFrom")]
        public string StartTimeFrom{ get; set; }

        /// <summary>
        /// <p>Voucher validity time end time</p>
        /// </summary>
        [JsonProperty("StartTimeTo")]
        public string StartTimeTo{ get; set; }

        /// <summary>
        /// <p>Voucher expiration time start time</p>
        /// </summary>
        [JsonProperty("EndTimeFrom")]
        public string EndTimeFrom{ get; set; }

        /// <summary>
        /// <p>Voucher expiration time end time</p>
        /// </summary>
        [JsonProperty("EndTimeTo")]
        public string EndTimeTo{ get; set; }

        /// <summary>
        /// <p>Voucher issuance start time</p>
        /// </summary>
        [JsonProperty("CreateTimeFrom")]
        public string CreateTimeFrom{ get; set; }

        /// <summary>
        /// <p>Voucher issuance time end time</p>
        /// </summary>
        [JsonProperty("CreateTimeTo")]
        public string CreateTimeTo{ get; set; }

        /// <summary>
        /// <p>Language parameter</p><p>Default value: zh</p><p>Expect the product name to return in Chinese or other languages. Currently only support Chinese and English. Return in Chinese when "zh" is entered or left blank; return in English in other cases.</p>
        /// </summary>
        [JsonProperty("Lang")]
        public string Lang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VoucherId", this.VoucherId);
            this.SetParamSimple(map, prefix + "CodeId", this.CodeId);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "VoucherName", this.VoucherName);
            this.SetParamSimple(map, prefix + "TimeFrom", this.TimeFrom);
            this.SetParamSimple(map, prefix + "TimeTo", this.TimeTo);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayScene", this.PayScene);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "VoucherMainType", this.VoucherMainType);
            this.SetParamSimple(map, prefix + "VoucherSubType", this.VoucherSubType);
            this.SetParamSimple(map, prefix + "StartTimeFrom", this.StartTimeFrom);
            this.SetParamSimple(map, prefix + "StartTimeTo", this.StartTimeTo);
            this.SetParamSimple(map, prefix + "EndTimeFrom", this.EndTimeFrom);
            this.SetParamSimple(map, prefix + "EndTimeTo", this.EndTimeTo);
            this.SetParamSimple(map, prefix + "CreateTimeFrom", this.CreateTimeFrom);
            this.SetParamSimple(map, prefix + "CreateTimeTo", this.CreateTimeTo);
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
        }
    }
}

