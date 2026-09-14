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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocToVideoRegenerateInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Regeneration scope.</p><p>Enumeration values:</p><ul><li>full: Full regeneration at this stage (for example, modifying the overall number of scenarios)</li><li>scenes: Partial regeneration by scenario (for example, modifying the specific content of a scenario)</li></ul>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// <p>Prompt content for regeneration.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Target page ID array for partial regeneration by page. Required only when Scope=scenes. Not repeatable. Up to 5 pages can be regenerated at a time.</p>
        /// </summary>
        [JsonProperty("SceneIds")]
        public string[] SceneIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamArraySimple(map, prefix + "SceneIds.", this.SceneIds);
        }
    }
}

