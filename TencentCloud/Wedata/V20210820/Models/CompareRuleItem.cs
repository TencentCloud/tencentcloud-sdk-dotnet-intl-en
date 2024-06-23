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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareRuleItem : AbstractModel
    {
        
        /// <summary>
        /// Comparison Type 1. Fixed value  2. Fluctuation Value  3. Numeric Range Comparison  4. Enumeration Range Comparison  5. No Comparison
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompareType")]
        public ulong? CompareType{ get; set; }

        /// <summary>
        /// Comparison Operation Type
        /// <  <=  ==  =>  > !=
        /// IRLCRO: Within the interval (left closed, right open)
        /// IRLORC: Within the interval (left open, right closed)
        /// IRLCRC: Within the interval (left closed, right closed)
        /// IRLORO: Within the interval (left open, right open)
        /// NRLCRO: Not within the range (left-closed, right-open)
        /// NRLORC: Not within the range (left-open, right-closed)
        /// NRLCRC: Not within the range (left-closed, right-closed)
        /// NRLORO: Not within the range (left-open, right-open)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Quality statistical value types 1. Absolute Value 2. Increase 3. Decline 4. _C includes 5. N_C does not include
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ValueComputeType")]
        public ulong? ValueComputeType{ get; set; }

        /// <summary>
        /// Comparison threshold list
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ValueList")]
        public ThresholdValue[] ValueList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompareType", this.CompareType);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "ValueComputeType", this.ValueComputeType);
            this.SetParamArrayObj(map, prefix + "ValueList.", this.ValueList);
        }
    }
}

