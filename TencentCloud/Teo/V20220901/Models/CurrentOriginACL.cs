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

    public class CurrentOriginACL : AbstractModel
    {
        
        /// <summary>
        /// Origin-pull IP range details.
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// Version.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Version effective time, which adopts Beijing time (UTC+8) and follows the date and time format of the ISO 8601 standard.
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// This parameter is used to record whether "I have updated to the latest origin-pull IP range" is confirmed before the current version takes effect. Valid values:
        /// <li>true: When the version takes effect, the confirmation of updating to the latest origin-pull IP is completed;</li>
        /// <li>false: When the version takes effect, the confirmation of updating to the latest origin-pull IP is not completed, and the origin-pull IP range is forcibly updated to the latest version by the backend.</li>Note: When this parameter returns false, confirm in time whether your origin server firewall configuration has been updated to the latest origin-pull IP range to avoid origin-pull failure.
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
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "IsPlaned", this.IsPlaned);
        }
    }
}

