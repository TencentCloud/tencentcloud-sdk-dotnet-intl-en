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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgeRatingItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Age rating standard.</p><p>Valid values:</p><ul><li>apple: Apple</li><li>iarc: Android.</li></ul>
        /// </summary>
        [JsonProperty("StandardId")]
        public string StandardId{ get; set; }

        /// <summary>
        /// <p>Applicable age for age rating.</p>
        /// </summary>
        [JsonProperty("AgeRating")]
        public long? AgeRating{ get; set; }

        /// <summary>
        /// <p>Age rating label.</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StandardId", this.StandardId);
            this.SetParamSimple(map, prefix + "AgeRating", this.AgeRating);
            this.SetParamSimple(map, prefix + "Label", this.Label);
        }
    }
}

