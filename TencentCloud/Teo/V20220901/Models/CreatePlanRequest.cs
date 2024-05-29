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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePlanRequest : AbstractModel
    {
        
        /// <summary>
        /// Type of plan subscribed to. Valid values:<li>personal: Personal Edition Plan, prepaid;</li><li>basic: Basic Edition Plan, prepaid;</li><li>standard: Standard Edition Plan, prepaid;</li><li>enterprise: Enterprise Edition Plan, post-paid. </li>When subscribing to a prepaid plan, ensure there is sufficient balance in the account, as insufficient balance will result in a pending payment order.
        /// For an overview of billing, refer to [Billing Overview](https://intl.cloud.tencent.com/document/product/1552/94156?from_cn_redirect=1).
        /// For differences between plans, refer to [ Comparison of EdgeOne Plan](https://intl.cloud.tencent.com/document/product/1552/94165?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// Whether to automatically use a voucher. Valid values: <li>true: Yes;</li><li>false: No. </li> This parameter is valid only when PlanType is personal, basic, or standard.
        /// If this field is not specified, the default value 'false' will be used.
        /// </summary>
        [JsonProperty("AutoUseVoucher")]
        public string AutoUseVoucher{ get; set; }

        /// <summary>
        /// Parameters for subscribing to prepaid plans. When PlanType is personal, basic, or standard, this parameter can be optionally set to specify the subscription duration and whether to enable auto-renewal for the plan.
        /// If this field is not specified, the default plan duration is 1 month, with auto-renewal disabled.
        /// </summary>
        [JsonProperty("PrepaidPlanParam")]
        public PrepaidPlanParam PrepaidPlanParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "AutoUseVoucher", this.AutoUseVoucher);
            this.SetParamObj(map, prefix + "PrepaidPlanParam.", this.PrepaidPlanParam);
        }
    }
}

