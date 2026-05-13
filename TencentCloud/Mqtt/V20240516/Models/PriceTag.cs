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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PriceTag : AbstractModel
    {
        
        /// <summary>
        /// Billing name refers to the category of billable items for specifications. The pricing name for specific specifications can be found in the returned results of the DescribeProductSKUList API.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Billing category, pricing name subclass. For the billing category of specific specifications, see the returned results in DescribeProductSKUList API.
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Billing item tag is a subproject of the billing Category under the pricing Name (Name), representing a specific charge. For the billing item tag of the specification, see 
        /// DescribeProductSKUList API returned results.
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// Billing step length indicates the billing quantity of the billing item tag (Code) under the billing category (Category) for the pricing name (Name). For the field value of specific specifications, refer to DescribeProductSKUList API.
        /// </summary>
        [JsonProperty("Step")]
        public long? Step{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Step", this.Step);
        }
    }
}

