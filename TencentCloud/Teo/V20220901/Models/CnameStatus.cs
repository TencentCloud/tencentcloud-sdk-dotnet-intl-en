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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CnameStatus : AbstractModel
    {
        
        /// <summary>
        /// Domain name.
        /// </summary>
        [JsonProperty("RecordName")]
        public string RecordName{ get; set; }

        /// <summary>
        /// EdgeOne is assigned to the CNAME of the domain name.
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// CNAME configuration status verification result. valid values:.
        /// <li>active: indicates that the domain name is correctly configured to the designated CNAME assigned by EdgeOne.</li>.
        /// <li>moved: indicates the domain name is not configured to the designated CNAME assigned by EdgeOne;</li>.
        /// <li>invalid: indicates the CNAME in the access domain configuration is assigned by EdgeOne to another domain, which can cause service exception. change it to the CNAME provided by EdgeOne for this domain. you can get the CNAME provided by EdgeOne for this domain from the CNAME field in this struct.</li>.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordName", this.RecordName);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

