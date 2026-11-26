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

    public class IPSSLConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the site associated with the IP SSL domain name. If the Status value is unbound, this field is empty.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>The domain name associated with the IP SSL. If the Status value is unbound, this field is empty.</p>
        /// </summary>
        [JsonProperty("AssociatedDomain")]
        public string AssociatedDomain{ get; set; }

        /// <summary>
        /// <p>Association status. Values as follows:</p><li>bound: IP SSL configuration bound</li><li>binding: IP SSL configuration binding</li><li>unbinding: IP SSL configuration unbinding</li><li>unbound: IP SSL configuration not bound</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "AssociatedDomain", this.AssociatedDomain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

