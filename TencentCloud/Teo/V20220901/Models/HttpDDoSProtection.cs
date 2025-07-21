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

    public class HttpDDoSProtection : AbstractModel
    {
        
        /// <summary>
        /// Specifies the specific configuration of adaptive frequency control.
        /// </summary>
        [JsonProperty("AdaptiveFrequencyControl")]
        public AdaptiveFrequencyControl AdaptiveFrequencyControl{ get; set; }

        /// <summary>
        /// Specifies the intelligent client filter configuration.
        /// </summary>
        [JsonProperty("ClientFiltering")]
        public ClientFiltering ClientFiltering{ get; set; }

        /// <summary>
        /// Specifies the specific configuration for bandwidth abuse protection.
        /// </summary>
        [JsonProperty("BandwidthAbuseDefense")]
        public BandwidthAbuseDefense BandwidthAbuseDefense{ get; set; }

        /// <summary>
        /// Specifies the configuration of slow attack protection.
        /// </summary>
        [JsonProperty("SlowAttackDefense")]
        public SlowAttackDefense SlowAttackDefense{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AdaptiveFrequencyControl.", this.AdaptiveFrequencyControl);
            this.SetParamObj(map, prefix + "ClientFiltering.", this.ClientFiltering);
            this.SetParamObj(map, prefix + "BandwidthAbuseDefense.", this.BandwidthAbuseDefense);
            this.SetParamObj(map, prefix + "SlowAttackDefense.", this.SlowAttackDefense);
        }
    }
}

