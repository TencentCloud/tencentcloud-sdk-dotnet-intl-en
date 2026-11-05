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

    public class MetricOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>Metric key. For the value, see the key allowlist in the MetricOverview note.</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>Month-over-month percentage. Enter 0 if there is no month-over-month comparison</p>
        /// </summary>
        [JsonProperty("Mom")]
        public float? Mom{ get; set; }

        /// <summary>
        /// <p>Metric unit, enumeration value DosageUnit; for the mapping between key and unit, see the MetricOverview comment allowlist</p><table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>DOSAGE_UNIT_TOKEN</td><td>0</td><td>token (default)</td></tr><tr><td>DOSAGE_UNIT_PAGE_COUNT</td><td>1</td><td>page_count (page number)</td></tr><tr><td>DOSAGE_UNIT_TIMES</td><td>2</td><td>times (count)</td></tr><tr><td>DOSAGE_UNIT_SECOND</td><td>3</td><td>second</td></tr><tr><td>DOSAGE_UNIT_ITEM</td><td>4</td><td>item</td></tr><tr><td>DOSAGE_UNIT_SHEET</td><td>5</td><td>sheet</td></tr><tr><td>DOSAGE_UNIT_CHARACTER</td><td>6</td><td>character</td></tr><tr><td>DOSAGE_UNIT_GB</td><td>7</td><td>GB</td></tr><tr><td>DOSAGE_UNIT_NUMBER</td><td>8</td><td>number (count)</td></tr><tr><td>DOSAGE_UNIT_MILL_SECOND</td><td>9</td><td>mill_second (ms)</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("Unit")]
        public long? Unit{ get; set; }

        /// <summary>
        /// <p>Metric value.</p>
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Mom", this.Mom);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

