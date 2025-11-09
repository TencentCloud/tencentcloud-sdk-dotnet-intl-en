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

    public class MultiPathGatewayCurrentOriginACL : AbstractModel
    {
        
        /// <summary>
        /// Describes the IP range details for origin servers.
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// Specifies the version number.
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// This parameter records whether "i have updated to the latest origin IP range" is completed before taking effect. valid values:.
        /// <li>true: confirms the update to the latest origin IP is completed.</li>.
        /// <li>false: indicates the update to the latest origin IP is not completed.</li>.
        /// Note: when false is returned for this parameter, please confirm in time whether your origin server firewall configuration has been updated to the latest IP range to avoid origin-pull failure.
        /// </summary>
        [JsonProperty("IsPlaned")]
        public string IsPlaned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EntireAddresses.", this.EntireAddresses);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "IsPlaned", this.IsPlaned);
        }
    }
}

