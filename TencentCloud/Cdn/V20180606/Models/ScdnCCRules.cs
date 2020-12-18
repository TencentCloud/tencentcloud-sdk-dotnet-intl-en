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

    public class ScdnCCRules : AbstractModel
    {
        
        /// <summary>
        /// Rule types:
        /// `all`: effective for all files.
        /// `file`: effective for specified file suffixes.
        /// `directory`: effective for specified paths.
        /// `path`: effective for specified absolute paths.
        /// `index`: effective for web homepages and root directories.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Rule value (blocking condition)
        /// </summary>
        [JsonProperty("RuleValue")]
        public string[] RuleValue{ get; set; }

        /// <summary>
        /// IP access limit rule
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// Detection granularity
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DetectionTime")]
        public ulong? DetectionTime{ get; set; }

        /// <summary>
        /// Frequency threshold
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FrequencyLimit")]
        public ulong? FrequencyLimit{ get; set; }

        /// <summary>
        /// Whether to block or redirect requests from suspicious IPs. Valid values: `on` and `off`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PunishmentSwitch")]
        public string PunishmentSwitch{ get; set; }

        /// <summary>
        /// Suspicious IP restriction duration
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
        /// The redirection target URL used when the `Action` is `redirect`
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RuleValue.", this.RuleValue);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "DetectionTime", this.DetectionTime);
            this.SetParamSimple(map, prefix + "FrequencyLimit", this.FrequencyLimit);
            this.SetParamSimple(map, prefix + "PunishmentSwitch", this.PunishmentSwitch);
            this.SetParamSimple(map, prefix + "PunishmentTime", this.PunishmentTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
        }
    }
}

