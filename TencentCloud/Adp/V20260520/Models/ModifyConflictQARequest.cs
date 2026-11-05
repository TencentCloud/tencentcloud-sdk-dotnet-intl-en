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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyConflictQARequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Knowledge base ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>Conflict group ID (optional if ignored globally)</p>
        /// </summary>
        [JsonProperty("ConflictGroupId")]
        public string ConflictGroupId{ get; set; }

        /// <summary>
        /// <p>Whether to ignore globally (ignore all pending conflict issues under the current KB)</p>
        /// </summary>
        [JsonProperty("IsIgnoreAll")]
        public bool? IsIgnoreAll{ get; set; }

        /// <summary>
        /// <p>QA ID list involved in decision-making (required for KEEP and DELETE)</p>
        /// </summary>
        [JsonProperty("QaIdList")]
        public string[] QaIdList{ get; set; }

        /// <summary>
        /// <p>Conflict resolution policy: 1=reserve, 2=ignore, 3=delete (can be omitted when ignored globally)<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>CONFLICT_RESOLUTION_UNKNOWN</td><td>0</td><td>-</td></tr><tr><td>CONFLICT_RESOLUTION_KEEP</td><td>1</td><td>Reserve</td></tr><tr><td>CONFLICT_RESOLUTION_IGNORE</td><td>2</td><td>Ignore</td></tr><tr><td>CONFLICT_RESOLUTION_DELETE</td><td>3</td><td>Delete</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("Resolution")]
        public long? Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "ConflictGroupId", this.ConflictGroupId);
            this.SetParamSimple(map, prefix + "IsIgnoreAll", this.IsIgnoreAll);
            this.SetParamArraySimple(map, prefix + "QaIdList.", this.QaIdList);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

