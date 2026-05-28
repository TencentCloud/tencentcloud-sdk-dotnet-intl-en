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

    public class CostAnalyzeFilterDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Product key-value pair.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Business")]
        public BillQueryFilterMsg[] Business{ get; set; }

        /// <summary>
        /// <p>Region key-value pair</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public BillQueryFilterMsg[] Region{ get; set; }

        /// <summary>
        /// <p>Availability zone key-value pair</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Zone")]
        public BillQueryFilterMsg[] Zone{ get; set; }

        /// <summary>
        /// <p>Transaction type key-value pair</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionType")]
        public BillQueryFilterMsg[] ActionType{ get; set; }

        /// <summary>
        /// <p>Key-value pair of payment mode</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayMode")]
        public BillQueryFilterMsg[] PayMode{ get; set; }

        /// <summary>
        /// <p>Project key-value pair</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Project")]
        public BillQueryFilterMsg[] Project{ get; set; }

        /// <summary>
        /// <p>Payer uin information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayerUin")]
        public BillQueryFilterMsg[] PayerUin{ get; set; }

        /// <summary>
        /// <p>Sub-account uin information</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public BillQueryFilterMsg[] OwnerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Business.", this.Business);
            this.SetParamArrayObj(map, prefix + "Region.", this.Region);
            this.SetParamArrayObj(map, prefix + "Zone.", this.Zone);
            this.SetParamArrayObj(map, prefix + "ActionType.", this.ActionType);
            this.SetParamArrayObj(map, prefix + "PayMode.", this.PayMode);
            this.SetParamArrayObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "PayerUin.", this.PayerUin);
            this.SetParamArrayObj(map, prefix + "OwnerUin.", this.OwnerUin);
        }
    }
}

