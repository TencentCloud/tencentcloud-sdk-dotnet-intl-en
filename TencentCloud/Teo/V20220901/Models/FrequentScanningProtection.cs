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

    public class FrequentScanningProtection : AbstractModel
    {
        
        /// <summary>
        /// Whether the high-frequency scan protection rule is enabled. valid values: <li>on: enable. the high-frequency scan protection rule takes effect.</li><li>off: disable. the high-frequency scan protection rule does not take effect.</li>.	
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// The handling action for high-frequency scan protection. required when Enabled is on. valid values for SecurityAction Name: <li>Deny: block and respond with an interception page;</li> <li>Monitor: observe without processing requests, log security events in logs;</li> <li>JSChallenge: respond with a JavaScript challenge page.</li>.
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// The match mode for request statistics. required when Enabled is on. valid values: <li>http.request.xff_header_ip: client ip (priority match xff header);</li><li>http.request.ip: client ip.</li>.
        /// </summary>
        [JsonProperty("CountBy")]
        public string CountBy{ get; set; }

        /// <summary>
        /// This parameter specifies the threshold for high-frequency scan protection, which is the intercept count of managed rules set to interception within the time range set by CountingPeriod. value range: 1 to 4294967294, for example 100. when exceeding this statistical value, subsequent requests will trigger the handling Action set by Action. required when Enabled is on.
        /// </summary>
        [JsonProperty("BlockThreshold")]
        public long? BlockThreshold{ get; set; }

        /// <summary>
        /// This parameter specifies the statistical time window for high-frequency scan protection, which is the time window for counting requests that hit managed rules configured as block. valid values: 5-1800. measurement unit: seconds (s) only, such as 5s. this field is required when Enabled is on.
        /// </summary>
        [JsonProperty("CountingPeriod")]
        public string CountingPeriod{ get; set; }

        /// <summary>
        /// This parameter specifies the duration of the handling Action set by the high frequency scan protection Action parameter. value range: 60 to 86400. measurement unit: seconds (s) only, for example 60s. this field is required when Enabled is on.
        /// </summary>
        [JsonProperty("ActionDuration")]
        public string ActionDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamSimple(map, prefix + "CountBy", this.CountBy);
            this.SetParamSimple(map, prefix + "BlockThreshold", this.BlockThreshold);
            this.SetParamSimple(map, prefix + "CountingPeriod", this.CountingPeriod);
            this.SetParamSimple(map, prefix + "ActionDuration", this.ActionDuration);
        }
    }
}

