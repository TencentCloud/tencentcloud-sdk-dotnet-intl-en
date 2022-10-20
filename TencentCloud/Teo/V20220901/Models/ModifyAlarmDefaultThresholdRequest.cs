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

    public class ModifyAlarmDefaultThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// The alarm service type. Values:
        /// <li>`ddos`: DDoS alarm service.</li>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The threshold in Mbps. Maximum value: 10.
        /// </summary>
        [JsonProperty("Threshold")]
        public long? Threshold{ get; set; }

        /// <summary>
        /// The protection entity, which is a proxy ID when layer-4 protection is enabled, or a site name when layer-7 protection is on.
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
        }
    }
}

