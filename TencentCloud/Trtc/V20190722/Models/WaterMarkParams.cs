/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class WaterMarkParams : AbstractModel
    {
        
        /// <summary>
        /// Image ID of the watermark, which is generated after the image is uploaded to the TRTC console
        /// </summary>
        [JsonProperty("WaterMarkId")]
        public ulong? WaterMarkId{ get; set; }

        /// <summary>
        /// Width (px) of the watermark for On-Cloud MixTranscoding
        /// </summary>
        [JsonProperty("WaterMarkWidth")]
        public ulong? WaterMarkWidth{ get; set; }

        /// <summary>
        /// Height (px) of the watermark for On-Cloud MixTranscoding
        /// </summary>
        [JsonProperty("WaterMarkHeight")]
        public ulong? WaterMarkHeight{ get; set; }

        /// <summary>
        /// Horizontal offset (px) of the watermark
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// Vertical offset (px) of the watermark
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }

        /// <summary>
        /// URL of the watermark image for the mixed stream, which can be in PNG, JPG, JPEG, or BMP format and does not support the alpha channel. The URL must not exceed 512 bytes. When both `WaterMarkUrl` and `WaterMarkId` are specified, the former will be used. The watermark image cannot exceed 10 MB.
        /// </summary>
        [JsonProperty("WaterMarkUrl")]
        public string WaterMarkUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterMarkId", this.WaterMarkId);
            this.SetParamSimple(map, prefix + "WaterMarkWidth", this.WaterMarkWidth);
            this.SetParamSimple(map, prefix + "WaterMarkHeight", this.WaterMarkHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "WaterMarkUrl", this.WaterMarkUrl);
        }
    }
}

