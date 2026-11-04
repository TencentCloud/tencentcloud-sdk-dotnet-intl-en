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

    public class Filter : AbstractModel
    {
        
        /// <summary>
        /// Filter field name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Operator, default IN (backward compatibility)<table><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>FILTER_OPERATOR_IN</td><td>0</td><td>Belongs to value_list (default value, backward compatibility; value_list cannot be empty)</td></tr><tr><td>FILTER_OPERATOR_NOT_IN</td><td>1</td><td>Does not belong to value_list (value_list cannot be empty)</td></tr><tr><td>FILTER_OPERATOR_BETWEEN</td><td>2</td><td>Between (inclusive interval [start, end]; value_list must contain exactly 2 elements, one of which can be empty to indicate a unilateral open interval)</td></tr></table>
        /// </summary>
        [JsonProperty("Operator")]
        public long? Operator{ get; set; }

        /// <summary>
        /// Filter value array
        /// </summary>
        [JsonProperty("ValueList")]
        public string[] ValueList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamArraySimple(map, prefix + "ValueList.", this.ValueList);
        }
    }
}

