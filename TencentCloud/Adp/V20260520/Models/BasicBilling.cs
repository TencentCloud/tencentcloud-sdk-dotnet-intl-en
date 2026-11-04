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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BasicBilling : AbstractModel
    {
        
        /// <summary>
        /// <table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>UNKNOW</td><td>0</td><td></td></tr><tr><td>TOKEN</td><td>1</td><td>By token</td></tr><tr><td>PAGE_COUNT</td><td>2</td><td>By page number</td></tr><tr><td>TIMES</td><td>3</td><td>By times</td></tr><tr><td>TIMES_THOUSAND</td><td>4</td><td>By thousand times</td></tr><tr><td>SECOND</td><td>5</td><td>By duration</td></tr><tr><td>CHARACTER</td><td>6</td><td>By number of characters</td></tr><tr><td>CHARACTER_THOUSAND</td><td>7</td><td>By thousand characters</td></tr><tr><td>SHEET</td><td>8</td><td>By sheet</td></tr><tr><td>NUMBER</td><td>9</td><td>By count</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("BillingUnit")]
        public long? BillingUnit{ get; set; }

        /// <summary>
        /// <p>Cash price</p><p>Unit: CNY</p>
        /// </summary>
        [JsonProperty("CashPrice")]
        public float? CashPrice{ get; set; }

        /// <summary>
        /// <p>PU price</p><p>Unit: pu</p>
        /// </summary>
        [JsonProperty("PuPrice")]
        public float? PuPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BillingUnit", this.BillingUnit);
            this.SetParamSimple(map, prefix + "CashPrice", this.CashPrice);
            this.SetParamSimple(map, prefix + "PuPrice", this.PuPrice);
        }
    }
}

