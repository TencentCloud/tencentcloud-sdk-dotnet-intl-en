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

    public class ModifyDocToVideoTaskStatusInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Modification action type.</p><p>Enumeration values:</p><ul><li>confirm: Confirm completion of the stage and advance to the next stage</li><li>regenerate: Regenerate the specified stage</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>Modify the target stage.</p><p>Enumeration values:</p><ul><li>STAGE_1:<br>When Action=confirm: confirm the outline, continue generating subsequent dubbing, animation effects, and subtitles;<br>When Action=regenerate: regenerate the outline.</li></ul><ul><li>STAGE_2:<br>When Action=confirm: confirm the generated dubbing, animation effects, and subtitles, and generate the final video;<br>When Action=regenerate: regenerate the dubbing, animation effects, and subtitles.</li></ul>
        /// </summary>
        [JsonProperty("Stage")]
        public string Stage{ get; set; }

        /// <summary>
        /// <p>ID of the target task that needs to be modified.</p>
        /// </summary>
        [JsonProperty("SourceTaskId")]
        public string SourceTaskId{ get; set; }

        /// <summary>
        /// <p>Regenerate the parameter.</p><p>Required only when Action=regenerate.</p>
        /// </summary>
        [JsonProperty("Regenerate")]
        public DocToVideoRegenerateInput Regenerate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "SourceTaskId", this.SourceTaskId);
            this.SetParamObj(map, prefix + "Regenerate.", this.Regenerate);
        }
    }
}

