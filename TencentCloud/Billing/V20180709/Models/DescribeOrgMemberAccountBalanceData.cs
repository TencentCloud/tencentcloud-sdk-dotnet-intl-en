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

    public class DescribeOrgMemberAccountBalanceData : AbstractModel
    {
        
        /// <summary>
        /// <p>Member account Uin</p>
        /// </summary>
        [JsonProperty("MemberUin")]
        public string MemberUin{ get; set; }

        /// <summary>
        /// <p>Member name</p>
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// <p>Whether it is a credit account</p>
        /// </summary>
        [JsonProperty("IsCreditAccount")]
        public bool? IsCreditAccount{ get; set; }

        /// <summary>
        /// <p>Current actual available balance</p><p>Unit: cent</p>
        /// </summary>
        [JsonProperty("RealBalance")]
        public float? RealBalance{ get; set; }

        /// <summary>
        /// <p>Cash account balance</p><p>Unit: cent</p>
        /// </summary>
        [JsonProperty("CashAccountBalance")]
        public float? CashAccountBalance{ get; set; }

        /// <summary>
        /// <p>Credit limit</p><p>Unit: cent</p><p>Credit limit = Basic credit limit + Temporary credit limit</p>
        /// </summary>
        [JsonProperty("CreditAmount")]
        public float? CreditAmount{ get; set; }

        /// <summary>
        /// <p>Temporary credit limit</p><p>Unit: cent</p>
        /// </summary>
        [JsonProperty("TempCredit")]
        public float? TempCredit{ get; set; }

        /// <summary>
        /// <p>Basic credit limit</p><p>Unit: cent</p>
        /// </summary>
        [JsonProperty("BasicCreditAmount")]
        public float? BasicCreditAmount{ get; set; }

        /// <summary>
        /// <p>Overdue payments</p><p>Unit: cent</p>
        /// </summary>
        [JsonProperty("OweAmount")]
        public float? OweAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "IsCreditAccount", this.IsCreditAccount);
            this.SetParamSimple(map, prefix + "RealBalance", this.RealBalance);
            this.SetParamSimple(map, prefix + "CashAccountBalance", this.CashAccountBalance);
            this.SetParamSimple(map, prefix + "CreditAmount", this.CreditAmount);
            this.SetParamSimple(map, prefix + "TempCredit", this.TempCredit);
            this.SetParamSimple(map, prefix + "BasicCreditAmount", this.BasicCreditAmount);
            this.SetParamSimple(map, prefix + "OweAmount", this.OweAmount);
        }
    }
}

