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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayRateLimitDetail : AbstractModel
    {
        
        /// <summary>
        /// Plug-in enable status
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// qps threshold
        /// </summary>
        [JsonProperty("QpsThresholds")]
        public QpsThreshold[] QpsThresholds{ get; set; }

        /// <summary>
        /// Request path that requires traffic control
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Request header Key for traffic control
        /// </summary>
        [JsonProperty("Header")]
        public string Header{ get; set; }

        /// <summary>
        /// Traffic throttling basis
        /// ip service consumer credential path header
        /// </summary>
        [JsonProperty("LimitBy")]
        public string LimitBy{ get; set; }

        /// <summary>
        /// external redis configuration
        /// </summary>
        [JsonProperty("ExternalRedis")]
        public ExternalRedis ExternalRedis{ get; set; }

        /// <summary>
        /// redis configuration in global configuration
        /// </summary>
        [JsonProperty("GlobalConfigId")]
        public string GlobalConfigId{ get; set; }

        /// <summary>
        /// Counter policy 
        /// local standalone
        /// default redis
        /// external redis
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// Response configuration, response policy is text
        /// </summary>
        [JsonProperty("RateLimitResponse")]
        public RateLimitResponse RateLimitResponse{ get; set; }

        /// <summary>
        /// Request forwarding address
        /// </summary>
        [JsonProperty("RateLimitResponseUrl")]
        public string RateLimitResponseUrl{ get; set; }

        /// <summary>
        /// response policy
        /// url request forwarding
        /// Response configuration
        /// default mode: return directly.
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// Whether to hide the traffic throttling client response header
        /// </summary>
        [JsonProperty("HideClientHeaders")]
        public bool? HideClientHeaders{ get; set; }

        /// <summary>
        /// queuing time
        /// </summary>
        [JsonProperty("LineUpTime")]
        public long? LineUpTime{ get; set; }

        /// <summary>
        /// Whether request queuing is enabled
        /// </summary>
        [JsonProperty("IsDelay")]
        public bool? IsDelay{ get; set; }

        /// <summary>
        /// Basic throttling
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BasicLimitQpsThresholds")]
        public QpsThreshold[] BasicLimitQpsThresholds{ get; set; }

        /// <summary>
        /// Parameter throttling policy
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LimitRules")]
        public LimitRule[] LimitRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArrayObj(map, prefix + "QpsThresholds.", this.QpsThresholds);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Header", this.Header);
            this.SetParamSimple(map, prefix + "LimitBy", this.LimitBy);
            this.SetParamObj(map, prefix + "ExternalRedis.", this.ExternalRedis);
            this.SetParamSimple(map, prefix + "GlobalConfigId", this.GlobalConfigId);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamObj(map, prefix + "RateLimitResponse.", this.RateLimitResponse);
            this.SetParamSimple(map, prefix + "RateLimitResponseUrl", this.RateLimitResponseUrl);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "HideClientHeaders", this.HideClientHeaders);
            this.SetParamSimple(map, prefix + "LineUpTime", this.LineUpTime);
            this.SetParamSimple(map, prefix + "IsDelay", this.IsDelay);
            this.SetParamArrayObj(map, prefix + "BasicLimitQpsThresholds.", this.BasicLimitQpsThresholds);
            this.SetParamArrayObj(map, prefix + "LimitRules.", this.LimitRules);
        }
    }
}

