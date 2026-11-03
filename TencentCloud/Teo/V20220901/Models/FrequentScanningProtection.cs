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
        /// Whether high-frequency scan protection is enabled. Valid values: <li>on: enabled, the high-frequency scan protection rule takes effect;</li><li>off: disabled, the high-frequency scan protection rule does not take effect.</li>	
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Rule ID of high-frequency scan protection, returned only as an output parameter.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Handling action for high frequency scan protection. When Enabled is on, this field is required. The Name parameter of SecurityAction supports: <li>Deny: block and respond with an Interception page;</li><li>Monitor: observe, do not process request records, and log security events;</li><li>JSChallenge: javascript challenge and respond with a JavaScript challenge page.</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// Match mode for request statistics. This field is required when Enabled is on. Valid values: <li>http.request.xff_header_ip: client ip (priority match xff header);</li><li>http.request.ip: client ip.</li>
        /// </summary>
        [JsonProperty("CountBy")]
        public string CountBy{ get; set; }

        /// <summary>
        /// This parameter specifies the threshold for high-frequency scan protection, which is the total interception count when managed rules configured for interception are hit within the time range set by CountingPeriod. The value ranges from 1 to 4294967294, for example, 100. When this statistical value is exceeded, subsequent requests trigger the handling action set by Action. This field is required when Enabled is on.
        /// </summary>
        [JsonProperty("BlockThreshold")]
        public long? BlockThreshold{ get; set; }

        /// <summary>
        /// This parameter specifies the time window for high-frequency scan protection statistics, that is, the statistical time window for requests that hit managed rules configured for interception. Value range: 5-1800. The unit only supports seconds (s), for example, 5s. Required when Enabled is on.
        /// </summary>
        [JsonProperty("CountingPeriod")]
        public string CountingPeriod{ get; set; }

        /// <summary>
        /// This parameter specifies the duration of the handling Action set by the high frequency scan protection Action parameter. The value ranges from 60 to 86400. The unit only supports seconds (s), for example, 60s. This field is required when Enabled is on.
        /// </summary>
        [JsonProperty("ActionDuration")]
        public string ActionDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamSimple(map, prefix + "CountBy", this.CountBy);
            this.SetParamSimple(map, prefix + "BlockThreshold", this.BlockThreshold);
            this.SetParamSimple(map, prefix + "CountingPeriod", this.CountingPeriod);
            this.SetParamSimple(map, prefix + "ActionDuration", this.ActionDuration);
        }
    }
}

