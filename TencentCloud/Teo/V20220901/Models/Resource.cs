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

    public class Resource : AbstractModel
    {
        
        /// <summary>
        /// The resource ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Billing mode
        /// `0`: Pay-as-you-go
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The effective time.
        /// </summary>
        [JsonProperty("EnableTime")]
        public string EnableTime{ get; set; }

        /// <summary>
        /// The expiration time.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// The plan status. Values:
        /// <li>`normal`: Normal</li>
        /// <li>`isolated`: Isolated</li>
        /// <li>`destroyed`: Terminated</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Pricing query parameter
        /// </summary>
        [JsonProperty("Sv")]
        public Sv[] Sv{ get; set; }

        /// <summary>
        /// Whether to enable auto-renewal. Values:
        /// <li>`0`: Default status.</li>
        /// <li>`1`: Enable auto-renewal.</li>
        /// <li>`2`: Disable auto-renewal.</li>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// ID of the resource associated with the plan.
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Applicable area. Values:
        /// <li>`mainland`: Chinese mainland</li>
        /// <li>`overseas`: Regions outside the Chinese mainland</li>
        /// <li>`global`: Global</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EnableTime", this.EnableTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Sv.", this.Sv);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

