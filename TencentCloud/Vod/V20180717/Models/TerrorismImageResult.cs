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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TerrorismImageResult : AbstractModel
    {
        
        /// <summary>
        /// Authentication involves scoring unsafe information, with a score from 0 to 100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Authentication result suggestions involving unsafe information. Value range:
        /// <li>pass;</li>
        /// <li>review;</li>
        /// <li>block.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Tag of the authentication result involving unsafe information. Value range:
        /// <li>guns: weapons and firearms;</li>
        /// <li>crowd: crowd gathering;</li>
        /// <li>police: police force;</li>
        /// <li>bloody: graphic violence;</li>
        /// <li>banners: violent and terrorist flags;</li>
        /// <li>explosion: explosions and fires;</li>
        /// <li>scenario: Violent and terrorist visuals.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
        }
    }
}

