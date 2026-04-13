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

    public class ComponentReference : AbstractModel
    {
        
        /// <summary>
        /// Refer to the instance type. Valid values:
        /// <li>edge-function: Edge function.</li>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// Referenced instance ID. According to the value of ReferenceType, return the corresponding instance ID.
        /// <li>When ReferenceType is edge-function: Return the edge function ID in the format of ef-2vc5oe9mzqhm.</li>
        /// </summary>
        [JsonProperty("ReferenceId")]
        public string ReferenceId{ get; set; }

        /// <summary>
        /// Referenced instance name. According to the value of ReferenceType, return the corresponding instance name.
        /// <li>When ReferenceType is edge-function: Returns the edge function name.</li>
        /// </summary>
        [JsonProperty("ReferenceName")]
        public string ReferenceName{ get; set; }

        /// <summary>
        /// Site ID. Site identifier of the instance ownership that refers to the namespace.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Site name. Refer to the site name of the instance ownership in namespace.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Refer to the site alias of the namespace instance. If the site alias is not set, return an empty string.
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ReferenceId", this.ReferenceId);
            this.SetParamSimple(map, prefix + "ReferenceName", this.ReferenceName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
        }
    }
}

