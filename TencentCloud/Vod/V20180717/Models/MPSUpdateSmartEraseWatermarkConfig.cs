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

    public class MPSUpdateSmartEraseWatermarkConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Watermark removal method.<br> <strong>Auto removal:</strong> Automatically recognize watermarks in videos through Model A and generate new videos after removal. Suitable for dynamic watermarks. When using auto removal, if you do not specify AutoAreas, it will perform auto removal on the full-screen video; if you specify AutoAreas, it will change to auto removal on your designated regions.<br><strong>Specified area removal:</strong> For static watermarks with fixed positions, it is recommended to directly specify the removal area. When you choose specified area removal, import at least one designated region. - auto Auto removal - custom Specified area removal</p>
        /// </summary>
        [JsonProperty("WatermarkEraseMethod")]
        public string WatermarkEraseMethod{ get; set; }

        /// <summary>
        /// <p>Watermark removal model. basic Edition: provides average effects and high cost performance. It applies to animations or videos with clean backgrounds. advanced Edition: offers better effectiveness and is suitable for mini-dramas or reality-style videos.</p><ul><li>basic Edition</li><li>advanced Edition</li></ul>
        /// </summary>
        [JsonProperty("WatermarkModel")]
        public string WatermarkModel{ get; set; }

        /// <summary>
        /// <p>Automatically erase custom regions. For selected regions, use the AI model to automatically detect and erase existing targets. Note: When the erase method is set to custom, this parameter will not take effect. To clear regions, input []. If not provided, the template region information remains unchanged.</p>
        /// </summary>
        [JsonProperty("AutoAreas")]
        public MPSEraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// <p>Specify the removal of custom regions. For specified regions, directly perform erasure without detection and recognition within a selected time range. Note: Import [] to clear regions. The template region information remains unchanged if not imported.</p>
        /// </summary>
        [JsonProperty("CustomAreas")]
        public MPSEraseTimeArea[] CustomAreas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WatermarkEraseMethod", this.WatermarkEraseMethod);
            this.SetParamSimple(map, prefix + "WatermarkModel", this.WatermarkModel);
            this.SetParamArrayObj(map, prefix + "AutoAreas.", this.AutoAreas);
            this.SetParamArrayObj(map, prefix + "CustomAreas.", this.CustomAreas);
        }
    }
}

