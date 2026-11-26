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

    public class DropPageConfig : AbstractModel
    {
        
        /// <summary>
        /// Configuration switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Interception page configuration of the Waf (managed rule) module. If null, the last set configuration is used by default.
        /// </summary>
        [JsonProperty("WafDropPageDetail")]
        public DropPageDetail WafDropPageDetail{ get; set; }

        /// <summary>
        /// Interception page configuration for custom pages. If it is null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("AclDropPageDetail")]
        public DropPageDetail AclDropPageDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "WafDropPageDetail.", this.WafDropPageDetail);
            this.SetParamObj(map, prefix + "AclDropPageDetail.", this.AclDropPageDetail);
        }
    }
}

