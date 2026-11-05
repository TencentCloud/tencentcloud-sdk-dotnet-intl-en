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

    public class ConsumptionUsage : AbstractModel
    {
        
        /// <summary>
        /// <p>Consume PU</p>
        /// </summary>
        [JsonProperty("ConsumptionPU")]
        public float? ConsumptionPU{ get; set; }

        /// <summary>
        /// <p>Amount value.</p>
        /// </summary>
        [JsonProperty("Usage")]
        public float? Usage{ get; set; }

        /// <summary>
        /// <p>Usage unit. Enumeration value: DosageUnit</p><table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>DOSAGE_UNIT_TOKEN</td><td>0</td><td>token (default)</td></tr><tr><td>DOSAGE_UNIT_PAGE_COUNT</td><td>1</td><td>page_count (page number)</td></tr><tr><td>DOSAGE_UNIT_TIMES</td><td>2</td><td>times (frequency)</td></tr><tr><td>DOSAGE_UNIT_SECOND</td><td>3</td><td>second</td></tr><tr><td>DOSAGE_UNIT_ITEM</td><td>4</td><td>item</td></tr><tr><td>DOSAGE_UNIT_SHEET</td><td>5</td><td>sheet</td></tr><tr><td>DOSAGE_UNIT_CHARACTER</td><td>6</td><td>character</td></tr><tr><td>DOSAGE_UNIT_GB</td><td>7</td><td>GB</td></tr><tr><td>DOSAGE_UNIT_NUMBER</td><td>8</td><td>number (count)</td></tr><tr><td>DOSAGE_UNIT_MILL_SECOND</td><td>9</td><td>mill_second (ms)</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("UsageUnit")]
        public long? UsageUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumptionPU", this.ConsumptionPU);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "UsageUnit", this.UsageUnit);
        }
    }
}

