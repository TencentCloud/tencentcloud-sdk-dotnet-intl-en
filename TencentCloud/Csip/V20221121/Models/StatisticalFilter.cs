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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StatisticalFilter : AbstractModel
    {
        
        /// <summary>
        /// 0: Not based on statistical testing
        /// 1: Occurrence count higher than a fixed value
        /// 2: Occurrence count exceeds 100 percent of the period average
        /// 3: Occurrences higher than 50 percent of the user average
        /// </summary>
        [JsonProperty("OperatorType")]
        public long? OperatorType{ get; set; }

        /// <summary>
        /// Statistical value
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperatorType", this.OperatorType);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

