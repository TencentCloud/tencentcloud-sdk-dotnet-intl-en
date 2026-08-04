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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceScheduledScalingEffectiveRange : AbstractModel
    {
        
        /// <summary>
        /// <p>Validity period type. Valid values: <li>LongTerm: Permanently valid;</li><li>Custom: Custom start and end date.</li></p>
        /// </summary>
        [JsonProperty("EffectiveType")]
        public string EffectiveType{ get; set; }

        /// <summary>
        /// <p>Start date of the valid period. Required when EffectiveType is Custom. Do not pass this field when EffectiveType is LongTerm.</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>Termination date of the valid period. Required when EffectiveType is Custom, and cannot be earlier than StartDate. Do not pass this field when EffectiveType is LongTerm.</p>
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EffectiveType", this.EffectiveType);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
        }
    }
}

