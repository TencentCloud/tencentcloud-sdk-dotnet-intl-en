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

    public class RaspRule : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Regular expression for a custom request URL range. If this parameter is left blank, saving fails.
        /// </summary>
        [JsonProperty("URLRegexp")]
        public string URLRegexp{ get; set; }

        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulVulsID")]
        public ulong? VulVulsID{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulVulsName")]
        public string VulVulsName{ get; set; }

        /// <summary>
        /// cve_id
        /// </summary>
        [JsonProperty("CveID")]
        public string CveID{ get; set; }

        /// <summary>
        /// Vulnerability defense type, which comes from the vulnerability table. 1: component vulnerability defense supported, with component vulnerabilities not allowlisted through a regular expression; 2: regular expression defense supported.
        /// </summary>
        [JsonProperty("SupportDefense")]
        public ulong? SupportDefense{ get; set; }

        /// <summary>
        /// Allowlisting scope. 0: Allowlist all requests; 1: Allowlist requests within a custom request scope.
        /// </summary>
        [JsonProperty("WhiteType")]
        public ulong? WhiteType{ get; set; }

        /// <summary>
        /// Status. 0: valid.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Modification time.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "URLRegexp", this.URLRegexp);
            this.SetParamSimple(map, prefix + "VulVulsID", this.VulVulsID);
            this.SetParamSimple(map, prefix + "VulVulsName", this.VulVulsName);
            this.SetParamSimple(map, prefix + "CveID", this.CveID);
            this.SetParamSimple(map, prefix + "SupportDefense", this.SupportDefense);
            this.SetParamSimple(map, prefix + "WhiteType", this.WhiteType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

