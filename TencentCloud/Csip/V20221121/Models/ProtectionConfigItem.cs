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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectionConfigItem : AbstractModel
    {
        
        /// <summary>
        /// Configuration item ID
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// Configuration item name.
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// Configuration item description
        /// </summary>
        [JsonProperty("ConfigDescription")]
        public string ConfigDescription{ get; set; }

        /// <summary>
        /// Configuration group
        /// Enumeration value:
        /// auto_risk_discovery: auto risk discovery
        /// auto-defense
        /// client_hardening: Client hardening
        /// </summary>
        [JsonProperty("ConfigGroup")]
        public string ConfigGroup{ get; set; }

        /// <summary>
        /// Whether enabled
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigDescription", this.ConfigDescription);
            this.SetParamSimple(map, prefix + "ConfigGroup", this.ConfigGroup);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

