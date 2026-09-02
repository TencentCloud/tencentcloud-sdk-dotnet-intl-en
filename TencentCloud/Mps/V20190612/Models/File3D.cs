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

    public class File3D : AbstractModel
    {
        
        /// <summary>
        /// <p>File type: OBJ / GLB / FBX / STL / USDZ</p><p>Enumeration values:</p><ul><li>OBJ: common 3D exchange format</li><li>GLB: glTF 2.0 binary ("the JPEG of the 3D world")</li><li>FBX: Autodesk film/gaming industry standard</li><li>STL: 3D print/CAD triangle mesh</li><li>USDZ: Pixar/Apple packaged scenario description</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>File download URL (temporary signature, general TTL 24h)</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Preview image URL (if it exists)</p>
        /// </summary>
        [JsonProperty("PreviewImageUrl")]
        public string PreviewImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "PreviewImageUrl", this.PreviewImageUrl);
        }
    }
}

