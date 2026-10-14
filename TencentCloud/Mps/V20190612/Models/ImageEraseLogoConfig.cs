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

    public class ImageEraseLogoConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Capability configuration switch. Available values: </p><li>ON: Enable;</li><li>OFF: Disable.</li>Default value: ON.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>Multiple box selection regions to erase, with up to 16 regions enabled.<br>Note: This field may return null, indicating that no valid value can be obtained.</p>
        /// </summary>
        [JsonProperty("ImageAreaBoxes")]
        public ImageAreaBoxInfo[] ImageAreaBoxes{ get; set; }

        /// <summary>
        /// <p>Watermark removal capacity gear selection. Available values:</p><p>Enumeration values:</p><ul><li>low: quick removal gear</li><li>mid: balanced removal effect and speed gear</li><li>high: advanced removal effect gear</li></ul><p>Note: Select the corresponding removal gear based on the complexity of the removal scenario.</p>
        /// </summary>
        [JsonProperty("EraseStrength")]
        public string EraseStrength{ get; set; }

        /// <summary>
        /// <p>When erasing image watermarks, select a specific watermark type. Available values:</p><p>Enumeration values:</p><ul><li>corner_watermark: Erase a normal fixed-location watermark</li><li>tiled_watermark: Erase a tile watermark across the entire image</li><li>auto_detect_type: Automatically identify the watermark type and erase it</li><li>selected_watermark: Skip automatic removal and perform watermark removal at a specified position</li></ul>
        /// </summary>
        [JsonProperty("WatermarkType")]
        public string WatermarkType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArrayObj(map, prefix + "ImageAreaBoxes.", this.ImageAreaBoxes);
            this.SetParamSimple(map, prefix + "EraseStrength", this.EraseStrength);
            this.SetParamSimple(map, prefix + "WatermarkType", this.WatermarkType);
        }
    }
}

