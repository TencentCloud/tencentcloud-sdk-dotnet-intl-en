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

    public class ImageComposeCanvas : AbstractModel
    {
        
        /// <summary>
        /// <p>Canvas width, value ranges from 1 to 10240. Set both this and Height at the same time.</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>Canvas height, in the range of [1, 10240]. Set it simultaneously with Width.</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>Canvas background color, unified as an 8-digit hexadecimal #RRGGBBAA (including alpha), used as the canvas background color. Default #00000000 (fully transparent). Example: #FFFFFFFF opaque white, #FFFFFF80 semi-transparent white.</p><p>When the output format does not support transparent channel (such as JPEG), transparent areas are collapsed according to the RGB of this background color. The default value will get a black background. If a white background is required, explicitly pass #FFFFFFFF.</p>
        /// </summary>
        [JsonProperty("Background")]
        public string Background{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Background", this.Background);
        }
    }
}

