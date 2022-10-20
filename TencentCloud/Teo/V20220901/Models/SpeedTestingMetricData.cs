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

    public class SpeedTestingMetricData : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// The origin information.
        /// </summary>
        [JsonProperty("OriginSpeedTestingInfo")]
        public SpeedTestingInfo[] OriginSpeedTestingInfo{ get; set; }

        /// <summary>
        /// The EdgeOne information.
        /// </summary>
        [JsonProperty("ProxySpeedTestingInfo")]
        public SpeedTestingInfo[] ProxySpeedTestingInfo{ get; set; }

        /// <summary>
        /// The site status.
        /// </summary>
        [JsonProperty("SpeedTestingStatus")]
        public SpeedTestingStatus SpeedTestingStatus{ get; set; }

        /// <summary>
        /// The optimization suggestions.
        /// </summary>
        [JsonProperty("OptimizeAction")]
        public OptimizeAction[] OptimizeAction{ get; set; }

        /// <summary>
        /// The EdgeOne load time, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyLoadTime")]
        public long? ProxyLoadTime{ get; set; }

        /// <summary>
        /// The origin load time, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginLoadTime")]
        public long? OriginLoadTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamArrayObj(map, prefix + "OriginSpeedTestingInfo.", this.OriginSpeedTestingInfo);
            this.SetParamArrayObj(map, prefix + "ProxySpeedTestingInfo.", this.ProxySpeedTestingInfo);
            this.SetParamObj(map, prefix + "SpeedTestingStatus.", this.SpeedTestingStatus);
            this.SetParamArrayObj(map, prefix + "OptimizeAction.", this.OptimizeAction);
            this.SetParamSimple(map, prefix + "ProxyLoadTime", this.ProxyLoadTime);
            this.SetParamSimple(map, prefix + "OriginLoadTime", this.OriginLoadTime);
        }
    }
}

