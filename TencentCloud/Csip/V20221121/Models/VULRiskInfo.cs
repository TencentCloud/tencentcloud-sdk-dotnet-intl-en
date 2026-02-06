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

    public class VULRiskInfo : AbstractModel
    {
        
        /// <summary>
        /// Fixing suggestion
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// Technology reference/reference link.
        /// </summary>
        [JsonProperty("References")]
        public string References{ get; set; }

        /// <summary>
        /// Vulnerability description
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// Affected component.
        /// </summary>
        [JsonProperty("ImpactComponent")]
        public VulImpactComponentInfo[] ImpactComponent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "References", this.References);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamArrayObj(map, prefix + "ImpactComponent.", this.ImpactComponent);
        }
    }
}

