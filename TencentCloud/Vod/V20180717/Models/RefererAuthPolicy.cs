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
        /// [Referer hotlink protection](https://intl.cloud.tencent.com/document/product/266/33985) status. Valid values:
        /// <li>Enabled</li>
        /// <li>Disabled</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Referer authentication method. Valid values:
        /// <li>`Black`: blocklist. Any HTTP request carrying a referer in the `Referers` list will be rejected. </li>
        /// <li>`White`: allowlist. Only HTTP requests carrying referers in the `Referers` list will be accepted.</li>
        /// When `Status` is set to `Enabled`, `AuthType` must be specified.
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// The list of referers (up to 20). When `Status` is set to `Enabled`, `Referers` cannot be empty. Enter domain names as referers.
        /// </summary>
        [JsonProperty("Referers")]
        public string[] Referers{ get; set; }

        /// <summary>
        /// Whether to allow requests with empty referer to access this domain name. Valid values:
        /// <li>`Yes`</li>
        /// <li>`No`</li>
        /// When `Status` is set to `Enabled`, `BlankRefererAllowed` must be specified.
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

