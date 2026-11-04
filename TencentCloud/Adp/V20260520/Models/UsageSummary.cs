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

    public class UsageSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Exclusive to MODEL domain</p>
        /// </summary>
        [JsonProperty("Model")]
        public ModelUsageSummary Model{ get; set; }

        /// <summary>
        /// <p>PLATFORM domain exclusive</p>
        /// </summary>
        [JsonProperty("Platform")]
        public PlatformUsageSummary Platform{ get; set; }

        /// <summary>
        /// <p>Exclusive to PLUGIN domain</p>
        /// </summary>
        [JsonProperty("Plugin")]
        public PluginUsageSummary Plugin{ get; set; }

        /// <summary>
        /// <p>Source ID; CORP view=space_id (corporate view grouped by space), SPACE view=app_id (uint64 string), APP view=app_id</p>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// <p>Source name; CORP view=space_name, SPACE view=app_name, APP view=app_name</p>
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// <p>View type, determines the business meaning of SourceId/SourceName</p><table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>VIEW_TYPE_UNSPECIFIED</td><td>0</td><td>Unspecified (invalid value, do not pass in requests)</td></tr><tr><td>VIEW_TYPE_CORP</td><td>1</td><td>Corporate view</td></tr><tr><td>VIEW_TYPE_SPACE</td><td>2</td><td>Space view</td></tr><tr><td>VIEW_TYPE_APP</td><td>3</td><td>Application view</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("ViewType")]
        public long? ViewType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamObj(map, prefix + "Platform.", this.Platform);
            this.SetParamObj(map, prefix + "Plugin.", this.Plugin);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
        }
    }
}

