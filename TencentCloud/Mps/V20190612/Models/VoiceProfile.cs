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

    public class VoiceProfile : AbstractModel
    {
        
        /// <summary>
        /// <p>Voice name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Voice description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Gender.</p><p>Enumeration values:</p><ul><li>male: male</li><li>female: female</li><li>unknown: unknown</li></ul>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>Age.</p><p>Enumeration values:</p><ul><li>child: child</li><li>teenager: teenager</li><li>youth: youth</li><li>middle_aged: middle-aged</li><li>senior: senior</li><li>unknown: unknown</li></ul>
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// <p>Language. Supported languages:<br>zh Chinese<br>en English<br>ja Japanese<br>de German<br>fr French<br>ko Korean<br>ru Russian<br>uk Ukrainian<br>pt Portuguese<br>it Italian<br>es Spanish<br>id Indonesian<br>nl Dutch<br>tr Turkish<br>fil Filipino<br>ms Malay<br>el Greek<br>fi Finnish<br>hr Croatian<br>sk Slovak<br>pl Polish<br>sv Swedish<br>hi Hindi<br>bg Bulgarian<br>ro Romanian<br>ar Arabic<br>cs Czech<br>da Danish<br>ta Tamil<br>hun Hungarian<br>vi Vietnamese<br>no Norwegian<br>yue Cantonese<br>th Thai<br>he Hebrew<br>ca Catalan<br>nn Nynorsk<br>af Afrikaans<br>fa Persian<br>sl Slovenian</p>
        /// </summary>
        [JsonProperty("Languages")]
        public string[] Languages{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// <p>Scenario.</p>
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamArraySimple(map, prefix + "Languages.", this.Languages);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
        }
    }
}

