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

    public class SessionRateControl : AbstractModel
    {
        
        /// <summary>
        /// Specifies whether session rate and periodic feature verification are enabled. valid values: <li>on: enable</li><li>off: disable</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Session rate and periodic feature verification high-risk execution actions. SecurityAction Name valid values: <li>Deny: block, where Stall configuration is supported in DenyActionParameters;</li> <li>Monitor: observation;</li> <li>Allow: respond after wait, where MinDelayTime and MaxDelayTime configuration is required in AllowActionParameters.</li>.
        /// </summary>
        [JsonProperty("HighRateSessionAction")]
        public SecurityAction HighRateSessionAction{ get; set; }

        /// <summary>
        /// Session rate and periodic feature verification medium-risk execution action. SecurityAction Name parameter supports: <li>Deny: block, where DenyActionParameters supports Stall configuration;</li><li>Monitor: observe;</li><li>Allow: respond after wait, where AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>.
        /// </summary>
        [JsonProperty("MidRateSessionAction")]
        public SecurityAction MidRateSessionAction{ get; set; }

        /// <summary>
        /// Session rate and periodic feature verification low risk execution action. SecurityAction Name parameter supports: <li>Deny: block, where DenyActionParameters supports Stall configuration;</li><li>Monitor: observe;</li><li>Allow: respond after wait, where AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>.
        /// </summary>
        [JsonProperty("LowRateSessionAction")]
        public SecurityAction LowRateSessionAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "HighRateSessionAction.", this.HighRateSessionAction);
            this.SetParamObj(map, prefix + "MidRateSessionAction.", this.MidRateSessionAction);
            this.SetParamObj(map, prefix + "LowRateSessionAction.", this.LowRateSessionAction);
        }
    }
}

