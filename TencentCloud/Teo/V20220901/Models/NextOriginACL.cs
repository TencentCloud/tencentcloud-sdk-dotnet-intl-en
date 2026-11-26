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

    public class NextOriginACL : AbstractModel
    {
        
        /// <summary>
        /// Version.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Version effective time, which adopts Beijing time (UTC+8) and follows the date and time format of the ISO 8601 standard.
        /// </summary>
        [JsonProperty("PlannedActiveTime")]
        public string PlannedActiveTime{ get; set; }

        /// <summary>
        /// Origin-pull IP range details.
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// Latest origin-pull IP range newly added compared with the origin-pull IP range in CurrentOrginACL.
        /// </summary>
        [JsonProperty("AddedAddresses")]
        public Addresses AddedAddresses{ get; set; }

        /// <summary>
        /// The part deleted from the latest origin-pull IP range compared with the origin-pull IP range in CurrentOrginACL.
        /// </summary>
        [JsonProperty("RemovedAddresses")]
        public Addresses RemovedAddresses{ get; set; }

        /// <summary>
        /// The part of the latest origin-pull IP range that is unchanged compared with the origin-pull IP range in CurrentOrginACL.
        /// </summary>
        [JsonProperty("NoChangeAddresses")]
        public Addresses NoChangeAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "PlannedActiveTime", this.PlannedActiveTime);
            this.SetParamObj(map, prefix + "EntireAddresses.", this.EntireAddresses);
            this.SetParamObj(map, prefix + "AddedAddresses.", this.AddedAddresses);
            this.SetParamObj(map, prefix + "RemovedAddresses.", this.RemovedAddresses);
            this.SetParamObj(map, prefix + "NoChangeAddresses.", this.NoChangeAddresses);
        }
    }
}

