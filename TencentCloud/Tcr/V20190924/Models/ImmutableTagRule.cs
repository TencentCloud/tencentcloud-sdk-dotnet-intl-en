/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImmutableTagRule : AbstractModel
    {
        
        /// <summary>
        /// Repository matching rule
        /// </summary>
        [JsonProperty("RepositoryPattern")]
        public string RepositoryPattern{ get; set; }

        /// <summary>
        /// Tag matching rule
        /// </summary>
        [JsonProperty("TagPattern")]
        public string TagPattern{ get; set; }

        /// <summary>
        /// repoMatches or repoExcludes
        /// </summary>
        [JsonProperty("RepositoryDecoration")]
        public string RepositoryDecoration{ get; set; }

        /// <summary>
        /// matches or excludes
        /// </summary>
        [JsonProperty("TagDecoration")]
        public string TagDecoration{ get; set; }

        /// <summary>
        /// Disabling rule
        /// </summary>
        [JsonProperty("Disabled")]
        public bool? Disabled{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("NsName")]
        public string NsName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepositoryPattern", this.RepositoryPattern);
            this.SetParamSimple(map, prefix + "TagPattern", this.TagPattern);
            this.SetParamSimple(map, prefix + "RepositoryDecoration", this.RepositoryDecoration);
            this.SetParamSimple(map, prefix + "TagDecoration", this.TagDecoration);
            this.SetParamSimple(map, prefix + "Disabled", this.Disabled);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "NsName", this.NsName);
        }
    }
}

