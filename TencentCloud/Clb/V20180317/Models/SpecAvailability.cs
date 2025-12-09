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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpecAvailability : AbstractModel
    {
        
        /// <summary>
        /// Specifies the specification type.
        /// <Li>Clb.C2.Medium (standard type)</li><li>clb.c3.small (advanced type 1)</li><li>clb.c3.medium (advanced type 2)</li>.
        /// <li>clb.c4.small (high-strength type 1)</li> <li>clb.c4.medium (high-strength type 2)</li> <li>clb.c4.large (high-strength type 3)</li> <li>clb.c4.xlarge (high-strength type 4)</li> <li>shared (shared type)</li>.
        /// </summary>
        [JsonProperty("SpecType")]
        public string SpecType{ get; set; }

        /// <summary>
        /// Specification availability. resource availability, "Available": Available, "Unavailable": Unavailable.
        /// </summary>
        [JsonProperty("Availability")]
        public string Availability{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecType", this.SpecType);
            this.SetParamSimple(map, prefix + "Availability", this.Availability);
        }
    }
}

