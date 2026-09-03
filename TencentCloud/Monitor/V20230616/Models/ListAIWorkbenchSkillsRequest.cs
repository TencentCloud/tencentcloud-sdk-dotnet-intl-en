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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAIWorkbenchSkillsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of items per page</p>
        /// </summary>
        [JsonProperty("PerPage")]
        public long? PerPage{ get; set; }

        /// <summary>
        /// <p>Page number.</p>
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// <p>Filter by type</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Search keyword</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>Whether to enable filter</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>Skill ID list filter</p>
        /// </summary>
        [JsonProperty("SkillIds")]
        public string[] SkillIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PerPage", this.PerPage);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArraySimple(map, prefix + "SkillIds.", this.SkillIds);
        }
    }
}

