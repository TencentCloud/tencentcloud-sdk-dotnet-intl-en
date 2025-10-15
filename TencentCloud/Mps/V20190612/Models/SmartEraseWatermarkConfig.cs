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

    public class SmartEraseWatermarkConfig : AbstractModel
    {
        
        /// <summary>
        /// Specifies the watermark removal method.
        /// **Auto-Removal:** automatically identifies watermarks in the video using model a and generates a new video after removal. suitable for dynamic watermarks.
        /// When using automated removal, if you do not specify AutoAreas, the full-screen video will be erased automatically. if AutoAreas is specified, it will change to erase the designated areas.
        /// **Specified area erasure:** for static watermarks with fixed locations, we recommend you directly specify the erasure area.
        /// When you choose specified area erasure, import at least one specified region.
        /// 
        /// -Automated removal.
        /// -Specifies the custom specified area erasure.
        /// </summary>
        [JsonProperty("WatermarkEraseMethod")]
        public string WatermarkEraseMethod{ get; set; }

        /// <summary>
        /// Specifies the watermark removal model.
        /// Basic version: average effect, cost-effective, suitable for videos with clean backgrounds or animations.
        /// Advanced edition: better effectiveness, suitable for mini-drama and reality style video.
        /// **Supported values**:
        /// - basic
        /// - advanced
        /// </summary>
        [JsonProperty("WatermarkModel")]
        public string WatermarkModel{ get; set; }

        /// <summary>
        /// Automatically erase the custom region.
        /// Automatically detects and erases the targeted removal in the specified region using the AI model.
        /// Note that this parameter will not take effect when the removal method is custom. to modify the template, input [] for the clean-up region. if not provided, the template region information remains unchanged.
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// Specifies the removal of a custom region.
        /// Specifies to directly perform removal without detection and recognition within a selected time range for the specified region.
        /// Note: when modifying the template, pass [] to clear the region. the template region information remains unchanged if not passed.
        /// </summary>
        [JsonProperty("CustomAreas")]
        public EraseTimeArea[] CustomAreas{ get; set; }


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

