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
        /// Whether session rate and periodic feature verification are enabled. Valid values: <li>on: enable</li><li>off: disable</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Session rate and periodic feature verification for high-risk executed actions. The Name parameter of SecurityAction supports the following values: <li>Deny: block, with Stall configuration supported in DenyActionParameters;</li><li>Monitor: observe;</li><li>Allow: respond after waiting, where AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>
        /// </summary>
        [JsonProperty("HighRateSessionAction")]
        public SecurityAction HighRateSessionAction{ get; set; }

        /// <summary>
        /// Execution action for medium-risk session rate and periodic feature verification. Supported values of SecurityAction Name: <li>Deny: block, where DenyActionParameters supports Stall configuration;</li><li>Monitor: observe;</li><li>Allow: respond after waiting, where AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>
        /// </summary>
        [JsonProperty("MidRateSessionAction")]
        public SecurityAction MidRateSessionAction{ get; set; }

        /// <summary>
        /// Session rate and periodic feature verification are low-risk execution actions. The Name parameter of SecurityAction supports: <li>Deny: block, where DenyActionParameters supports Stall configuration;</li><li>Monitor: observe;</li><li>Allow: wait then respond, where AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>
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

