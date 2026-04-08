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

    public class DescribeSubtitleEmbedTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique identifiers of intelligent caption templates for filtering. The array can contain up to 100 unique identifiers.</p>
        /// </summary>
        [JsonProperty("Definitions")]
        public long?[] Definitions{ get; set; }

        /// <summary>
        /// <p>Paging offset. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Number of returned entries. Default value: 10. Maximum value: 100.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Filtering condition for the template type. Leave it blank to return all. Valid values:</p><ul><li>Preset: system preset template;</li><li>Custom: user-defined template.</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Condition for filtering subtitle suppression templates by ID. Length limit: 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Definitions.", this.Definitions);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

