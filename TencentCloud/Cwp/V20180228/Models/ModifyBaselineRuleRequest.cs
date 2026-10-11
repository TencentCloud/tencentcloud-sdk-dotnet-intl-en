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

    public class ModifyBaselineRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("Data")]
        public BaselineRule Data{ get; set; }

        /// <summary>
        /// Whether to select all based on the filtering criteria
        /// </summary>
        [JsonProperty("SelectAll")]
        public long? SelectAll{ get; set; }

        /// <summary>
        /// <li>ItemName - string - Required: No - Item name</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 0: detection item, 1: detection item category.
        /// </summary>
        [JsonProperty("IdType")]
        public ulong? IdType{ get; set; }

        /// <summary>
        /// ID of the detection item to be excluded.
        /// </summary>
        [JsonProperty("ExcludeIds")]
        public ulong?[] ExcludeIds{ get; set; }

        /// <summary>
        /// Selected detection item category.
        /// </summary>
        [JsonProperty("CategoryIds")]
        public ulong?[] CategoryIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamArraySimple(map, prefix + "ExcludeIds.", this.ExcludeIds);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
        }
    }
}

