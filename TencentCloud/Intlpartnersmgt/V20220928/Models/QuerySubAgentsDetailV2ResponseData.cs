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

    public class QuerySubAgentsDetailV2ResponseData : AbstractModel
    {
        
        /// <summary>
        /// Second-level reseller UIN.
        /// </summary>
        [JsonProperty("SubAgentUin")]
        public long? SubAgentUin{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Mobile number.
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// Specifies the mailbox.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Number of secondary dealer sub-customers.
        /// </summary>
        [JsonProperty("CountOfCustomers")]
        public long? CountOfCustomers{ get; set; }

        /// <summary>
        /// Binding time.
        /// </summary>
        [JsonProperty("BindTime")]
        public string BindTime{ get; set; }

        /// <summary>
        /// Credit limit pool of second-level reseller.
        /// </summary>
        [JsonProperty("Credit")]
        public float? Credit{ get; set; }

        /// <summary>
        /// Value pool of unconsumed credit limit for second-level reseller.
        /// </summary>
        [JsonProperty("RemainingCredit")]
        public float? RemainingCredit{ get; set; }

        /// <summary>
        /// Cash coupon quota pool for second-level reseller.
        /// </summary>
        [JsonProperty("Voucher")]
        public float? Voucher{ get; set; }

        /// <summary>
        /// Balance of cash coupon quota pool for second-level reseller.
        /// </summary>
        [JsonProperty("RemainingVoucher")]
        public float? RemainingVoucher{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAgentUin", this.SubAgentUin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "CountOfCustomers", this.CountOfCustomers);
            this.SetParamSimple(map, prefix + "BindTime", this.BindTime);
            this.SetParamSimple(map, prefix + "Credit", this.Credit);
            this.SetParamSimple(map, prefix + "RemainingCredit", this.RemainingCredit);
            this.SetParamSimple(map, prefix + "Voucher", this.Voucher);
            this.SetParamSimple(map, prefix + "RemainingVoucher", this.RemainingVoucher);
        }
    }
}

