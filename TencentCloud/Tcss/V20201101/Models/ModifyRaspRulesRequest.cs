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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRaspRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// Rule ID. (Leave it blank during addition, and specify it during editing.)
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Vulnerability ID array.
        /// </summary>
        [JsonProperty("VulVulsIDs")]
        public ulong?[] VulVulsIDs{ get; set; }

        /// <summary>
        /// Base64-encoded regular expression for allowlisting requests within a custom request scope. It cannot be left blank unless all requests are to be allowlisted.
        /// </summary>
        [JsonProperty("URLRegexp")]
        public string URLRegexp{ get; set; }

        /// <summary>
        /// Allowlisting method. 0: allowlist requests within a custom request scope; 1: allowlist all requests.
        /// </summary>
        [JsonProperty("WhiteType")]
        public ulong? WhiteType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "VulVulsIDs.", this.VulVulsIDs);
            this.SetParamSimple(map, prefix + "URLRegexp", this.URLRegexp);
            this.SetParamSimple(map, prefix + "WhiteType", this.WhiteType);
        }
    }
}

