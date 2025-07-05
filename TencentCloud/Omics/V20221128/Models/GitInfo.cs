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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GitInfo : AbstractModel
    {
        
        /// <summary>
        /// Git URL
        /// </summary>
        [JsonProperty("GitHttpPath")]
        public string GitHttpPath{ get; set; }

        /// <summary>
        /// Git username .
        /// </summary>
        [JsonProperty("GitUserName")]
        public string GitUserName{ get; set; }

        /// <summary>
        /// Git password or Token
        /// </summary>
        [JsonProperty("GitTokenOrPassword")]
        public string GitTokenOrPassword{ get; set; }

        /// <summary>
        /// Branch
        /// </summary>
        [JsonProperty("Branch")]
        public string Branch{ get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GitHttpPath", this.GitHttpPath);
            this.SetParamSimple(map, prefix + "GitUserName", this.GitUserName);
            this.SetParamSimple(map, prefix + "GitTokenOrPassword", this.GitTokenOrPassword);
            this.SetParamSimple(map, prefix + "Branch", this.Branch);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

