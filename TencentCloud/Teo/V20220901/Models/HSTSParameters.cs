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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HSTSParameters : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable hsts. values:.
        /// <Li>`On`: enable;</li>
        /// .
        /// <Li>Off: disable.</li>.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Cache hsts header time, unit: seconds. value range: 1-31536000.<br>note: this field is required when switch is on; when switch is off, this field is not required and will not take effect if filled.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Whether to allow other subdomains to inherit the same hsts header. values:.
        /// <Li>On: allows other subdomains to inherit the same hsts header.</li>.
        /// <Li>Off: does not allow other subdomains to inherit the same hsts header.</li> note: when switch is on, this field is required; when switch is off, this field is not required and will not take effect if filled.
        /// </summary>
        [JsonProperty("IncludeSubDomains")]
        public string IncludeSubDomains{ get; set; }

        /// <summary>
        /// Whether to allow the browser to preload the hsts header. valid values:.
        /// <Li>On: allows the browser to preload the hsts header.</li>.
        /// <Li>Off: does not allow the browser to preload the hsts header.</li> note: when switch is on, this field is required; when switch is off, this field is not required and will not take effect if filled.
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

