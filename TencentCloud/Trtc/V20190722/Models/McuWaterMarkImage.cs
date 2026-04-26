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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuWaterMarkImage : AbstractModel
    {
        
        /// <summary>
        /// Watermark image URL address. supports png, jpg, and jpeg formats. image size limit not more than 5MB.
        /// Note:.
        /// Make sure the image link has data accessibility. the backend download timeout is 10 seconds with a maximum of 3 retries. if the image download fails eventually, the watermark image will not take effect.
        /// 2. supported character sets for urls: ['0-9', 'a-z', 'a-z', '-', '.', '_', '~', ':', '/', '?', '#', '[', ']', '@', '!', '&', '(', ')', '*', '+', ',', '%', '=', ';', '|']. make sure url characters are within the supported character sets. if any characters exist outside the supported character sets, the watermark image will not take effect.
        /// </summary>
        [JsonProperty("WaterMarkUrl")]
        public string WaterMarkUrl{ get; set; }

        /// <summary>
        /// The watermark width (pixels).
        /// </summary>
        [JsonProperty("WaterMarkWidth")]
        public ulong? WaterMarkWidth{ get; set; }

        /// <summary>
        /// The watermark height (pixels).
        /// </summary>
        [JsonProperty("WaterMarkHeight")]
        public ulong? WaterMarkHeight{ get; set; }

        /// <summary>
        /// The horizontal offset (pixels) of the watermark.
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// The vertical offset (pixels) of the watermark.
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }

        /// <summary>
        /// The image layer of the watermark. If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("ZOrder")]
        public ulong? ZOrder{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DynamicPosType")]
        public ulong? DynamicPosType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterMarkUrl", this.WaterMarkUrl);
            this.SetParamSimple(map, prefix + "WaterMarkWidth", this.WaterMarkWidth);
            this.SetParamSimple(map, prefix + "WaterMarkHeight", this.WaterMarkHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "ZOrder", this.ZOrder);
            this.SetParamSimple(map, prefix + "DynamicPosType", this.DynamicPosType);
        }
    }
}

