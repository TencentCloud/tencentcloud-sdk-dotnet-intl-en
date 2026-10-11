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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TriggerCondition : AbstractModel
    {
        
        /// <summary>
        /// Condition comparison method. Valid values: 1 for greater than, 2 for less than, 3 for greater than or equal to, and 4 for less than or equal to.
        /// </summary>
        [JsonProperty("CompareMethod")]
        public long? CompareMethod{ get; set; }

        /// <summary>
        /// Condition threshold.
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompareMethod", this.CompareMethod);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

