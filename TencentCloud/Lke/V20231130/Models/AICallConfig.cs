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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnableVoiceInteract")]
        public bool? EnableVoiceInteract{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnableVoiceCall")]
        public bool? EnableVoiceCall{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnableDigitalHuman")]
        public bool? EnableDigitalHuman{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Voice")]
        public VoiceConfig Voice{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DigitalHuman")]
        public DigitalHumanConfig DigitalHuman{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableVoiceInteract", this.EnableVoiceInteract);
            this.SetParamSimple(map, prefix + "EnableVoiceCall", this.EnableVoiceCall);
            this.SetParamSimple(map, prefix + "EnableDigitalHuman", this.EnableDigitalHuman);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
            this.SetParamObj(map, prefix + "DigitalHuman.", this.DigitalHuman);
        }
    }
}

