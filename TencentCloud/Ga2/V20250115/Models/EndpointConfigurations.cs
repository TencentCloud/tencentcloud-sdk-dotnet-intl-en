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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndpointConfigurations : AbstractModel
    {
        
        /// <summary>
        /// <p>Domain type. Available values: 'Domain', 'PublicIp'.</p>
        /// </summary>
        [JsonProperty("EndpointType")]
        public string EndpointType{ get; set; }

        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("EndpointService")]
        public string EndpointService{ get; set; }

        /// <summary>
        /// <p>Weight.</p>
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// <p>Health check status; HEALTH: healthy; UNHEALTH: unhealthy.</p>
        /// </summary>
        [JsonProperty("HealthCheckStatus")]
        public string HealthCheckStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointType", this.EndpointType);
            this.SetParamSimple(map, prefix + "EndpointService", this.EndpointService);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "HealthCheckStatus", this.HealthCheckStatus);
        }
    }
}

