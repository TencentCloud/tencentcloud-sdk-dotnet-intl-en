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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomModel : AbstractModel
    {
        
        /// <summary>
        /// <p>Gender</p><p>Enumeration value:</p><ul><li>male: man</li><li>female: woman</li><li>any: unlimited</li></ul>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>Age range.</p><p>Enumeration values:</p><ul><li>teen: youth</li><li>young_adult: adulthood</li><li>middle_aged: middle-aged</li><li>mature: mature</li></ul>
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// <p>Appearance</p><p>Enumeration value:</p><ul><li>caucasian: White</li><li>asian: Asian</li><li>latino: Latino</li><li>african: African</li><li>middle_eastern: Middle Eastern</li></ul>
        /// </summary>
        [JsonProperty("Appearance")]
        public string Appearance{ get; set; }

        /// <summary>
        /// <p>Body shape</p><p>Enumeration value:</p><ul><li>slim: Slim</li><li>standard: Standard</li><li>athletic: Healthy</li><li>chubby: Chubby</li></ul>
        /// </summary>
        [JsonProperty("BodyType")]
        public string BodyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Appearance", this.Appearance);
            this.SetParamSimple(map, prefix + "BodyType", this.BodyType);
        }
    }
}

