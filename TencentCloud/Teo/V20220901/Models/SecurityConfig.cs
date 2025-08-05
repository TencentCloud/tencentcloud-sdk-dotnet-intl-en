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

    public class SecurityConfig : AbstractModel
    {
        
        /// <summary>
        /// Managed rule. if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("WafConfig")]
        public WafConfig WafConfig{ get; set; }

        /// <summary>
        /// Rate limiting. if the parameter is null or not filled, the configuration last set will be used by default.
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfig RateLimitConfig{ get; set; }

        /// <summary>
        /// Custom rule. specifies if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("AclConfig")]
        public AclConfig AclConfig{ get; set; }

        /// <summary>
        /// Bot configuration. if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("BotConfig")]
        public BotConfig BotConfig{ get; set; }

        /// <summary>
        /// Switch setting of the 7-layer protection. if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("SwitchConfig")]
        public SwitchConfig SwitchConfig{ get; set; }

        /// <summary>
        /// Basic access control. if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("IpTableConfig")]
        public IpTableConfig IpTableConfig{ get; set; }

        /// <summary>
        /// Exception rule configuration. if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("ExceptConfig")]
        public ExceptConfig ExceptConfig{ get; set; }

        /// <summary>
        /// Custom block page settings. if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("DropPageConfig")]
        public DropPageConfig DropPageConfig{ get; set; }

        /// <summary>
        /// Template configuration. specifies parameter usage for output only.
        /// </summary>
        [JsonProperty("TemplateConfig")]
        public TemplateConfig TemplateConfig{ get; set; }

        /// <summary>
        /// Slow attack configuration. if the parameter is null or not filled, use the last set configuration by default.
        /// </summary>
        [JsonProperty("SlowPostConfig")]
        public SlowPostConfig SlowPostConfig{ get; set; }

        /// <summary>
        /// Detect length limit configuration. for output usage only.
        /// </summary>
        [JsonProperty("DetectLengthLimitConfig")]
        public DetectLengthLimitConfig DetectLengthLimitConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "WafConfig.", this.WafConfig);
            this.SetParamObj(map, prefix + "RateLimitConfig.", this.RateLimitConfig);
            this.SetParamObj(map, prefix + "AclConfig.", this.AclConfig);
            this.SetParamObj(map, prefix + "BotConfig.", this.BotConfig);
            this.SetParamObj(map, prefix + "SwitchConfig.", this.SwitchConfig);
            this.SetParamObj(map, prefix + "IpTableConfig.", this.IpTableConfig);
            this.SetParamObj(map, prefix + "ExceptConfig.", this.ExceptConfig);
            this.SetParamObj(map, prefix + "DropPageConfig.", this.DropPageConfig);
            this.SetParamObj(map, prefix + "TemplateConfig.", this.TemplateConfig);
            this.SetParamObj(map, prefix + "SlowPostConfig.", this.SlowPostConfig);
            this.SetParamObj(map, prefix + "DetectLengthLimitConfig.", this.DetectLengthLimitConfig);
        }
    }
}

