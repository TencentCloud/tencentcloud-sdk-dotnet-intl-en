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

    public class ModelBadge : AbstractModel
    {
        
        /// <summary>
        /// <p>Display copy (rendered as final copy)</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Style theme</p><table><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>MODEL_BADGE_THEME_UNSPECIFIED</td><td>0</td><td>Unspecified</td></tr><tr><td>MODEL_BADGE_THEME_INFO</td><td>1</td><td>Info (blue)</td></tr><tr><td>MODEL_BADGE_THEME_SUCCESS</td><td>2</td><td>Success (green)</td></tr><tr><td>MODEL_BADGE_THEME_WARNING</td><td>3</td><td>Warning (orange)</td></tr><tr><td>MODEL_BADGE_THEME_DANGER</td><td>4</td><td>Danger (red)</td></tr></table>
        /// </summary>
        [JsonProperty("Theme")]
        public long? Theme{ get; set; }

        /// <summary>
        /// <p>tooltip copywriting (rendered as final copywriting). If it is empty, it is not displayed.</p>
        /// </summary>
        [JsonProperty("Tips")]
        public string Tips{ get; set; }

        /// <summary>
        /// <p>Badge type</p><table><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>MODEL_BADGE_TYPE_UNSPECIFIED</td><td>0</td><td>Unspecified</td></tr><tr><td>MODEL_BADGE_TYPE_FREE_TRIAL</td><td>1</td><td>Limited-time free</td></tr><tr><td>MODEL_BADGE_TYPE_DEPRECATING</td><td>2</td><td>About to go offline</td></tr><tr><td>MODEL_BADGE_TYPE_NEW</td><td>3</td><td>New model</td></tr><tr><td>MODEL_BADGE_TYPE_HOT</td><td>4</td><td>Popular</td></tr></table>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Theme", this.Theme);
            this.SetParamSimple(map, prefix + "Tips", this.Tips);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

