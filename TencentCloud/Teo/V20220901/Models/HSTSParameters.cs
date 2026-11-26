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

    public class HSTSParameters : AbstractModel
    {
        
        /// <summary>
        /// HSTS configuration switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Cache HSTS header time in seconds. Value range: 1-31536000.<br>Note: This field is required when Switch is on. When Switch is off, no need to specify this field, and it does not take effect if specified.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Whether other subdomains are allowed to inherit the same HSTS header. Valid values:
        /// <li>on: Allow other subdomains to inherit the same HSTS header;</li>
        /// <li>off: Other subdomains cannot inherit the same HSTS header.</li>Note: This field is required when Switch is on. When Switch is off, no need to specify this field, and it does not take effect if specified.
        /// </summary>
        [JsonProperty("IncludeSubDomains")]
        public string IncludeSubDomains{ get; set; }

        /// <summary>
        /// Whether the browser is allowed to preload the HSTS header. Valid values:
        /// <li>on: Allow the browser to preload the HSTS header;</li>
        /// <li>off: The browser is not allowed to preload the HSTS header.</li>Note: This field is required when Switch is on. When Switch is off, no need to specify this field, and it does not take effect if specified.
        /// </summary>
        [JsonProperty("Preload")]
        public string Preload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "IncludeSubDomains", this.IncludeSubDomains);
            this.SetParamSimple(map, prefix + "Preload", this.Preload);
        }
    }
}

