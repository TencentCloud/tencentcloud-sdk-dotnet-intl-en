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

    public class UpdateSmartEraseWatermarkConfig : AbstractModel
    {
        
        /// <summary>
        /// Watermark erasing method.
        /// **Automatic erasing: ** Video watermarks are automatically recognized using an AI model and are erased to generate a new video. It applies to dynamic watermarks.
        /// When automatic erasing is used, if AutoAreas is not specified, the full-screen video image area will be erased automatically. If AutoAreas is specified, the specified area will be erased automatically.
        ///  **Specified area erasing: ** For static watermarks in fixed positions, you are recommended to specify the erasing area directly.When you choose specified area erasing, specify at least one area.
        /// - auto: automatic erasing.
        /// - custom: specified area erasing.
        /// </summary>
        [JsonProperty("WatermarkEraseMethod")]
        public string WatermarkEraseMethod{ get; set; }

        /// <summary>
        /// Watermark erasing model.
        /// Basic Edition: provide average effects and high cost performance. It applies to animations or videos with clean backgrounds.
        /// Advanced Edition: provide better effects. It applies to reality-style videos, such as short dramas.
        /// - basic: Basic Edition.
        /// - advanced: Advanced Edition.
        /// </summary>
        [JsonProperty("WatermarkModel")]
        public string WatermarkModel{ get; set; }

        /// <summary>
        /// Custom area for automatic erasing.
        /// For the specified area, AI models are used to automatically detect and erase the target objects.
        /// Note: When the erasing method is set to custom, this parameter is invalid. Input [] for the erasing area; if this parameter is unspecified, the template area information will remain unchanged.
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// Custom area for specified area erasing.
        /// For the specified area, erase the target objects directly without detection and recognition within a selected time period.
        /// Note: Input [] for the erasing area; if this parameter is unspecified, the template area information will remain unchanged.
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

