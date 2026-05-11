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

    public class QualityInspectItem : AbstractModel
    {
        
        /// <summary>
        /// Offset time of abnormal segment start, in seconds.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of an abnormal fragment, in seconds.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Detected abnormal area coordinates. The array contains 4 elements [x1,y1,x2,y2], sequentially representing the horizontal and vertical coordinates of the top-left corner and bottom-right point.
        /// <font color=red>Note:</font> This field is valid only when the Type value is one of the following:
        /// <li>BlackWhiteEdge: black and white edges.</li>
        /// <li>Mosaic: mosaic.</li>
        /// <li>QRCode: QR code.</li>
        /// <li>AppletCode: mini program code.</li>
        /// <li>BarCode: barcode.</li>
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Confidence degree, value ranges from 0 to 100.
        /// <font color=red>Note:</font> This field is valid only when the Type value is one of the following:
        /// <li>Mosaic: mosaic.</li>
        /// <li>QRCode: QR code.</li>
        /// <li>AppletCode: mini program code.</li>
        /// <li>BarCode: barcode.</li>
        /// </summary>
        [JsonProperty("Confidence")]
        public ulong? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

