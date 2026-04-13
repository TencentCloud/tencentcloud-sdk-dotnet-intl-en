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

    public class KVNamespace : AbstractModel
    {
        
        /// <summary>
        /// Namespace name. Has uniqueness in the same site.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Namespace description. Remark information filled in upon creation, used for explaining the purpose or business meaning of the namespace. Supports a maximum of 256 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Available capacity of KV storage space in bytes. It indicates the maximum capacity limit of storable data in namespace, defaulting to 1 GB.
        /// </summary>
        [JsonProperty("Capacity")]
        public long? Capacity{ get; set; }

        /// <summary>
        /// KV storage space used capacity in bytes (Byte). It indicates the currently used storage space size of the namespace.
        /// </summary>
        [JsonProperty("CapacityUsed")]
        public long? CapacityUsed{ get; set; }

        /// <summary>
        /// List of referenced instances in the namespace. Shows which edge function instances reference the current namespace and the site information referenced. Returns an empty array if not referenced.
        /// </summary>
        [JsonProperty("References")]
        public ComponentReference[] References{ get; set; }

        /// <summary>
        /// The creation time of the namespace follows the ISO 8601 standard in the format YYYY-MM-DDThh:mm:ssZ (UTC time).
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// The last modification time of the namespace follows the ISO 8601 standard in the format YYYY-MM-DDThh:mm:ssZ (UTC time).
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamSimple(map, prefix + "CapacityUsed", this.CapacityUsed);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

