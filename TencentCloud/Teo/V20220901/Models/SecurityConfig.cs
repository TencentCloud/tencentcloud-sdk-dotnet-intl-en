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

    public class SecurityConfig : AbstractModel
    {
        
        /// <summary>
        /// The settings of the managed rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WafConfig")]
        public WafConfig WafConfig{ get; set; }

        /// <summary>
        /// The settings of the rate limiting rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfig RateLimitConfig{ get; set; }

        /// <summary>
        /// The settings of the custom rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AclConfig")]
        public AclConfig AclConfig{ get; set; }

        /// <summary>
        /// The settings of the bot configuration. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BotConfig")]
        public BotConfig BotConfig{ get; set; }

        /// <summary>
        /// The switch setting of the layer-7 protection. If it is null, the setting that was last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SwitchConfig")]
        public SwitchConfig SwitchConfig{ get; set; }

        /// <summary>
        /// The settings of the basic access control rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpTableConfig")]
        public IpTableConfig IpTableConfig{ get; set; }

        /// <summary>
        /// The settings of the exception rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExceptConfig")]
        public ExceptConfig ExceptConfig{ get; set; }

        /// <summary>
        /// The settings of the custom block page. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DropPageConfig")]
        public DropPageConfig DropPageConfig{ get; set; }

        /// <summary>
        /// Security template settings
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TemplateConfig")]
        public TemplateConfig TemplateConfig{ get; set; }


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
        }
    }
}

