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
        /// Instance type to refer. Valid values:
        /// <li>edge-function: edge function.</li>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// ID of the referenced instance. Based on the value of ReferenceType, return the corresponding instance ID:
        /// <li>When ReferenceType is edge-function: return the edge function ID in the format of ef-2vc5oe9mzqhm.</li>
        /// </summary>
        [JsonProperty("ReferenceId")]
        public string ReferenceId{ get; set; }

        /// <summary>
        /// Name of the referenced instance. Based on the value of ReferenceType, the corresponding instance name is returned:
        /// <li>When ReferenceType is edge-function: return the edge function name.</li>
        /// </summary>
        [JsonProperty("ReferenceName")]
        public string ReferenceName{ get; set; }

        /// <summary>
        /// Zone ID. Site identifier of the instance that references the namespace.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Site name. The name of the site to which the instances in this namespace belong.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Alias of the site that the instance in the namespace belongs to. If no site alias is set, an empty string is returned.
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

