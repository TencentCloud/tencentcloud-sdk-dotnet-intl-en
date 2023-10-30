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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityInspectItem : AbstractModel
    {
        
        /// <summary>
        /// Abnormal segment start offset time, unit: seconds.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// Abnormal segment termination's offset time, unit: seconds.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Detect abnormality in the area coordinates. The array contains 4 elements [x1, y1, x2, y2], which indicate the horizontal and vertical coordinates of the upper left and lower right points of the area in sequence. <font color=red>Pay attention to:</font> The value of this field is valid only when Type is one of the following: <li>BlackWhiteEdge: black and white edge;</li> <li>Mosaic: mosaic;</li> <li>QRCode: QR code;</li> <li>AppletCode: Mini Program code;</li> <li>BarCode: bar code.</li>
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Confidence threshold, range: [0, 100]. <font color=red>Pay attention to:</font> This field is valid only when Type has one of the following values: <li>Mosaic: Mosaic;</li> <li>QRCode: QR code;</li> <li>AppletCode: Mini Program code;</li> <li>BarCode: Bar code.</li>
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

