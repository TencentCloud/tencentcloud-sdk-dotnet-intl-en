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
        /// Watermark removal method.
        /// **Automatic erasing:** Video watermarks are automatically recognized using an AI model and are erased to generate a new video. It applies to dynamic watermarks.
        /// When using automatic erasing, if AutoAreas is not specified, the full-screen video image area will be erased automatically. If AutoAreas is specified, the specified area will be erased automatically.
        /// **Specified area erasure:** For static watermarks with a relatively fixed position, we recommend you directly specify the area to erase.
        /// When you choose specified area erasure, import at least a specified region.
        /// 
        /// -. auto: automatic removal
        /// - custom: specified area erasing.
        /// </summary>
        [JsonProperty("WatermarkEraseMethod")]
        public string WatermarkEraseMethod{ get; set; }

        /// <summary>
        /// Watermark removal model.
        /// Basic Edition: Provides average effects and high cost performance. Suitable for animations or videos with clean backgrounds.
        /// Advanced edition: Better effectiveness, suitable for reality style videos such as short drama.
        /// -.
        /// - advanced: Advanced Edition.
        /// </summary>
        [JsonProperty("WatermarkModel")]
        public string WatermarkModel{ get; set; }

        /// <summary>
        /// Custom area for automatic erasing.
        /// For the specified area, AI models are used to automatically detect and erase the target objects.
        /// Note: When the erasing method is set to custom, this parameter is invalid. When a template is modified, input [] for the erasing area; if this parameter is unspecified, the template area information will remain unchanged.
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// Specify the custom region for erasing.
        /// For the specified area, erase the target objects directly without detection and recognition within a selected time period.
        /// Note: When a template is modified, input [] for the erasing area; if this parameter is unspecified, the template area information will remain unchanged.
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

