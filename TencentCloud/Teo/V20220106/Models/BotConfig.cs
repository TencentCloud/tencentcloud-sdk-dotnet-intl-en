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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable bot security configuration
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Preset rules
        /// </summary>
        [JsonProperty("ManagedRule")]
        public BotManagedRule ManagedRule{ get; set; }

        /// <summary>
        /// Not supported currently
        /// </summary>
        [JsonProperty("UaBotRule")]
        public BotManagedRule UaBotRule{ get; set; }

        /// <summary>
        /// Not supported currently
        /// </summary>
        [JsonProperty("IspBotRule")]
        public BotManagedRule IspBotRule{ get; set; }

        /// <summary>
        /// User portrait rules
        /// </summary>
        [JsonProperty("PortraitRule")]
        public BotPortraitRule PortraitRule{ get; set; }

        /// <summary>
        /// Bot intelligence rules
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntelligenceRule")]
        public IntelligenceRule IntelligenceRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "ManagedRule.", this.ManagedRule);
            this.SetParamObj(map, prefix + "UaBotRule.", this.UaBotRule);
            this.SetParamObj(map, prefix + "IspBotRule.", this.IspBotRule);
            this.SetParamObj(map, prefix + "PortraitRule.", this.PortraitRule);
            this.SetParamObj(map, prefix + "IntelligenceRule.", this.IntelligenceRule);
        }
    }
}

