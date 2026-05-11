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

    public class MPSSmartEraseWatermarkConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Watermark removal method. <strong>Auto erasure:</strong> Automatically identify watermarks in the video through Model A and generate a new video after removal. Suitable for dynamic watermarks. When using auto erasure, if you do not specify AutoAreas, the system will perform full-screen auto erasure on the video; if AutoAreas are specified, it will change to auto erasure on your designated regions. <strong>Specified area erasure:</strong> For static watermarks with fixed positions, it is recommended to directly specify the removal area. When you choose specified area erasure, import at least one designated region. - auto Auto erasure - custom Specified area erasure</p>
        /// </summary>
        [JsonProperty("WatermarkEraseMethod")]
        public string WatermarkEraseMethod{ get; set; }

        /// <summary>
        /// <p>Watermark removal model. basic Edition: provides average effects and high cost performance. It applies to animations or videos with clean backgrounds. advanced Edition: offers better effectiveness and is suitable for mini-dramas or reality-style videos. - basic Edition - advanced Edition</p>
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

