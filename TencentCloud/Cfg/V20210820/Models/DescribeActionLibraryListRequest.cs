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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeActionLibraryListRequest : AbstractModel
    {
        
        /// <summary>
        /// 0-100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Object type ID
        /// </summary>
        [JsonProperty("ObjectType")]
        public ulong? ObjectType{ get; set; }

        /// <summary>
        /// Keyword value {"action name": "a_title", "description": "a_desc", "action type": "a_type", "creation time": "a_create_time", "level-2 type": "a_resource_type"}
        /// </summary>
        [JsonProperty("Filters")]
        public ActionFilter[] Filters{ get; set; }

        /// <summary>
        /// Action type. 1: fault action; 2: recovery action.
        /// </summary>
        [JsonProperty("Attribute")]
        public long?[] Attribute{ get; set; }

        /// <summary>
        /// Filter item - action ID
        /// </summary>
        [JsonProperty("ActionIds")]
        public ulong?[] ActionIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "Attribute.", this.Attribute);
            this.SetParamArraySimple(map, prefix + "ActionIds.", this.ActionIds);
        }
    }
}

