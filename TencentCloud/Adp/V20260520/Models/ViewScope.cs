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

    public class ViewScope : AbstractModel
    {
        
        /// <summary>
        /// <p>View type; enumeration values: VIEW_TYPE_CORP(1) corporate view, VIEW_TYPE_SPACE(2) space view, VIEW_TYPE_APP(3) application view</p><table><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>VIEW_TYPE_UNSPECIFIED</td><td>0</td><td>Not specified (invalid value, do not pass in requests)</td></tr><tr><td>VIEW_TYPE_CORP</td><td>1</td><td>Corporate view</td></tr><tr><td>VIEW_TYPE_SPACE</td><td>2</td><td>Space view</td></tr><tr><td>VIEW_TYPE_APP</td><td>3</td><td>Application view</td></tr></table>
        /// </summary>
        [JsonProperty("ViewType")]
        public long? ViewType{ get; set; }

        /// <summary>
        /// <p>View scope ID; leave empty for VIEW_TYPE_CORP; enter space_id for VIEW_TYPE_SPACE; enter app_id for VIEW_TYPE_APP (decimal string of uint64 snowflake ID)</p>
        /// </summary>
        [JsonProperty("ScopeId")]
        public string ScopeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
            this.SetParamSimple(map, prefix + "ScopeId", this.ScopeId);
        }
    }
}

