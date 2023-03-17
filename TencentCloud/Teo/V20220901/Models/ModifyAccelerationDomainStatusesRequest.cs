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

    public class ModifyAccelerationDomainStatusesRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site related with the accelerated domain name.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// List of accelerated domain names to be modified.
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }

        /// <summary>
        /// Status of the accelerated domain name. Values:
        /// <li>`online`: Enabled</li>
        /// <li>`offline`: Disabled</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether to force suspension when the domain name has associated resources (such as alias domain names and traffic scheduling policies). Values:
        /// <li>`true`: Suspend the domain name and all associated resources.</li>
        /// <li>`true`: Do not suspend the domain name and all associated resources.</li>Default value: `false`.
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

