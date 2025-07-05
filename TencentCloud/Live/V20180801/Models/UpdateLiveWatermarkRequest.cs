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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateLiveWatermarkRequest : AbstractModel
    {
        
        /// <summary>
        /// Watermark ID.
        /// Get the watermark ID in the returned value of the [AddLiveWatermark](https://intl.cloud.tencent.com/document/product/267/30154?from_cn_redirect=1) API call.
        /// </summary>
        [JsonProperty("WatermarkId")]
        public long? WatermarkId{ get; set; }

        /// <summary>
        /// Watermark image URL.
        /// Unallowed characters in the URL:
        ///  ;(){}$>`#"\'|
        /// </summary>
        [JsonProperty("PictureUrl")]
        public string PictureUrl{ get; set; }

        /// <summary>
        /// Display position: X-axis offset in %. Default value: 0.
        /// </summary>
        [JsonProperty("XPosition")]
        public long? XPosition{ get; set; }

        /// <summary>
        /// Display position: Y-axis offset in %. Default value: 0.
        /// </summary>
        [JsonProperty("YPosition")]
        public long? YPosition{ get; set; }

        /// <summary>
        /// Watermark name.
        /// Up to 16 bytes.
        /// </summary>
        [JsonProperty("WatermarkName")]
        public string WatermarkName{ get; set; }

        /// <summary>
        /// Watermark width or its percentage of the live streaming video width. It is recommended to just specify either height or width as the other will be scaled proportionally to avoid distortions. The original width is used by default.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Watermark height or its percentage of the live streaming video width. It is recommended to just specify either height or width as the other will be scaled proportionally to avoid distortions. The original height is used by default.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WatermarkId", this.WatermarkId);
            this.SetParamSimple(map, prefix + "PictureUrl", this.PictureUrl);
            this.SetParamSimple(map, prefix + "XPosition", this.XPosition);
            this.SetParamSimple(map, prefix + "YPosition", this.YPosition);
            this.SetParamSimple(map, prefix + "WatermarkName", this.WatermarkName);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

