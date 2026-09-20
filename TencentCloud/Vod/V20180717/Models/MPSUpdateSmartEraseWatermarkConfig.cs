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
        /// <p>Watermark removal method.<br> <strong>Auto removal:</strong> Automatically identify watermarks in the video through model A and generate a new video after removal. Suitable for dynamic watermarks. When using auto removal, if you do not specify AutoAreas, auto removal will be performed on the full screen of the video; if AutoAreas is specified, auto removal will be performed on the specified region instead.<br><strong>Specified area erasure:</strong> For static watermarks with relatively fixed positions, it is recommended to directly specify the erasure area. When you choose specified area erasure, input at least one specified region. - auto: auto removal - custom: specified area erasure</p>
        /// </summary>
        [JsonProperty("WatermarkEraseMethod")]
        public string WatermarkEraseMethod{ get; set; }

        /// <summary>
        /// <p>Watermark removal model. Basic version: average effect, high cost performance, suitable for animation or videos with clean backgrounds. Advanced edition: better effectiveness, suitable for realistic-style videos such as mini-dramas. </p><ul><li>basic basic version </li><li>advanced advanced edition</li></ul>
        /// </summary>
        [JsonProperty("WatermarkModel")]
        public string WatermarkModel{ get; set; }

        /// <summary>
        /// <p>Automatically erase custom regions. For selected regions, use the AI model to automatically detect and erase existing targets. Note: When the erase method is set to custom, this parameter will not take effect. Input [] for region cleanup. If not provided, the template region information remains unchanged.</p>
        /// </summary>
        [JsonProperty("AutoAreas")]
        public MPSEraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// <p>Designate the removal of custom regions. For specified regions, directly perform erasure without detection and recognition within a selected time range. Note: To clear regions, import []. The template region information remains unchanged if not imported.</p>
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

