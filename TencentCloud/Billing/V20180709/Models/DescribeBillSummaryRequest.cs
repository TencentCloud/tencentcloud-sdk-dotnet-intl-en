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

    public class DescribeBillSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Bill month, formatted as 2023-04</p>
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// <p>Billing dimension type. Enumeration values as follows: business, project, region, payMode, tag</p>
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// <p>Tag key. Pass GroupType=tag when obtaining dimensional billing by tag.</p>
        /// </summary>
        [JsonProperty("TagKey")]
        public string[] TagKey{ get; set; }

        /// <summary>
        /// <p>Operator UIN: Operator account ID (ID of the prepaid resource order or postpaid operation, activate postpaid resource account or role ID)</p>
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// <p>Account ID of the payer (Account ID is the unique account identifier for the user in Tencent Cloud). By default, the query returns the account statement of the current account. If the group management account needs to query the self-pay bills of member accounts, enter the member account UIN in this field.</p>
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamArraySimple(map, prefix + "TagKey.", this.TagKey);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
        }
    }
}

