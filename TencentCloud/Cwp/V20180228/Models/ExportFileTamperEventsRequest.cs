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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportFileTamperEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// Filtering criteria
        /// <li>Status - String - required: no - processing status: 0: pending; 1: added to allowlist; 2: deleted; 3: ignored</li><li>ModifyTime - string - required: no - last occurrence time</li>
        /// <li>Uuid - String - required: no - host UUID for querying</li>
        /// <li>RuleCategory - string - required: no - rule category: 0: system rule; 1: custom rule</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Fields to be exported
        /// </summary>
        [JsonProperty("Fileds")]
        [System.Obsolete]
        public string[] Fileds{ get; set; }

        /// <summary>
        /// Fields to be exported
        /// </summary>
        [JsonProperty("Fields")]
        public string Fields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "Fileds.", this.Fileds);
            this.SetParamSimple(map, prefix + "Fields", this.Fields);
        }
    }
}

