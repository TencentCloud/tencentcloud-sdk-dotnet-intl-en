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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedCCRules : AbstractModel
    {
        
        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Detection duration
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DetectionTime")]
        public ulong? DetectionTime{ get; set; }

        /// <summary>
        /// Detection frequency threshold
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FrequencyLimit")]
        public ulong? FrequencyLimit{ get; set; }

        /// <summary>
        /// Whether to enable IP penalty. Valid values: `on` and `off`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PunishmentSwitch")]
        public string PunishmentSwitch{ get; set; }

        /// <summary>
        /// IP penalty duration
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PunishmentTime")]
        public ulong? PunishmentTime{ get; set; }

        /// <summary>
        /// Action. Valid values: `intercept` and `redirect`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// A redirection URL used when Action is `redirect`
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// Layer-7 rule configuration for CC frequency limiting
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Configure")]
        public ScdnSevenLayerRules[] Configure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "DetectionTime", this.DetectionTime);
            this.SetParamSimple(map, prefix + "FrequencyLimit", this.FrequencyLimit);
            this.SetParamSimple(map, prefix + "PunishmentSwitch", this.PunishmentSwitch);
            this.SetParamSimple(map, prefix + "PunishmentTime", this.PunishmentTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamArrayObj(map, prefix + "Configure.", this.Configure);
        }
    }
}

