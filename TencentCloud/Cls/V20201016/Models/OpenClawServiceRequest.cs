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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenClawServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Tag type</p><p>Enumeration value:</p><ul><li>OpenClaw: OpenClaw type</li><li>ClawPro: ClawPro type</li></ul>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>Whether to create a trace topic, default to false</p><p>Enumeration value:</p><ul><li>true: Creates a trace topic</li><li>false: Does not create a trace topic</li></ul>
        /// </summary>
        [JsonProperty("EnableTrace")]
        public bool? EnableTrace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "EnableTrace", this.EnableTrace);
        }
    }
}

