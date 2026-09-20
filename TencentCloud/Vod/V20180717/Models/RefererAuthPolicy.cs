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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefererAuthPolicy : AbstractModel
    {
        
        /// <summary>
        /// [Referer hotlink protection](https://www.tencentcloud.com/document/product/266/14046?from_cn_redirect=1) setting status. Available values:
        /// <li>Enabled: enable;</li>
        /// <li>Disabled: disabled.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Referer verification type. Available values:
        /// <li>Black: blocklist verification method. An HTTP request carrying a Referer in the Referers list will be rejected.</li>
        /// <li>White: whitelist method validation. HTTP requests are allowed only when they carry a Referer in the Referers list.</li>
        /// When Status is Enabled, AuthType must be assigned a value.
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// List of Referers used for verification. Supports up to 400 Referers. When Status value is Enabled, Referers cannot be an empty array. For the Referer format, see the format of the domain.
        /// </summary>
        [JsonProperty("Referers")]
        public string[] Referers{ get; set; }

        /// <summary>
        /// Whether to allow access to this domain name with a null Referer. Available values:
        /// <li>Yes: yes.</li>
        /// <li>No: no</li>
        /// When Status is Enabled, BlankRefererAllowed must be assigned a value.
        /// </summary>
        [JsonProperty("BlankRefererAllowed")]
        public string BlankRefererAllowed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamArraySimple(map, prefix + "Referers.", this.Referers);
            this.SetParamSimple(map, prefix + "BlankRefererAllowed", this.BlankRefererAllowed);
        }
    }
}

