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

    public class AdaptiveFrequencyControl : AbstractModel
    {
        
        /// <summary>
        /// Whether adaptive frequency control is enabled. Valid values: <li>on: enabled;</li><li>off: disabled.</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Rule ID of adaptive frequency control, returned only as an output parameter.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// The limitation level of adaptive frequency control. This field is required when Enabled is on. Valid values: <li>Loose: loose;</li><li>Moderate: moderate;</li><li>Strict: strict.</li>
        /// </summary>
        [JsonProperty("Sensitivity")]
        public string Sensitivity{ get; set; }

        /// <summary>
        /// Handling method of adaptive frequency control. This field is required when Enabled is on. Supported values for SecurityAction Name: <li>Monitor: monitor;</li><li>Deny: block;</li><li>Challenge: challenge. ChallengeActionParameters.Name only supports JSChallenge.</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Sensitivity", this.Sensitivity);
            this.SetParamObj(map, prefix + "Action.", this.Action);
        }
    }
}

