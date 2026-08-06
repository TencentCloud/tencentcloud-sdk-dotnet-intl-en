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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageTranslateLLMRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Base64 string of the image data, no more than 9M after Base64 encoding. A resolution of 600*800 or higher is recommended. PNG, JPG, and JPEG formats are supported.</p>
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// <p>Target language, supported languages:</p><ul><li>Chinese: zh</li><li>Traditional (Taiwan): zh-TW</li><li>Traditional (Hong Kong (China)): zh-HK</li><li>English: en</li><li>Japanese: ja</li><li>Korean: ko</li><li>Thai: th</li><li>Vietnamese: vi</li><li>Russian: ru</li><li>German: de</li><li>French: fr</li><li>Arabic: ar</li><li>Spanish: es</li><li>Italian: it</li><li>Indonesian: id</li><li>Malay language: ms</li><li>Portuguese: pt</li><li>Turkish: tr<br>-</li></ul>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// <p>Enter image Url. When using a Url, the Data parameter requires the input of "". Image restrictions: less than 10MB, resolution recommendation 600*800 or higher, format support jpg, jpeg, png.</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Invocation method.</p><p>Enumeration value:</p><ul><li>0: End-to-end image translation large model pro version</li><li>1: End-to-end image translation large model lite version</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

