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

    public class QualityInspectResultItem : AbstractModel
    {
        
        /// <summary>
        /// Exception type. Valid values:
        /// <li>Jitter: jitter.</li>
        /// <li>Blur: blurry;</li>
        /// <li>LowLighting: low light;</li>
        /// <li>HighLighting: overexposure.</li>
        /// <li>CrashScreen: screen glitch;</li>
        /// <li>BlackWhiteEdge: black and white edges.</li>
        /// <li>SolidColorScreen: solid color screen.</li>
        /// <li>Noise: noise.</li>
        /// <li>Mosaic: mosaic.</li>
        /// <li>QRCode: QR code.</li>
        /// <li>AppletCode: mini program code.</li>
        /// <li>BarCode: barcode;</li>
        /// <li>LowVoice: bass;</li>
        /// <li>HighVoice: high voice;</li>
        /// <li>NoVoice: mute;</li>
        /// <li>LowEvaluation: no-reference scoring below threshold.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Abnormal fragment list.
        /// <font color=red>Note:</font> The list only displays the first 100 elements. To obtain the complete result, refer to the corresponding file in SegmentSetFileUrl.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public QualityInspectItem[] SegmentSet{ get; set; }

        /// <summary>
        /// URL of Abnormal Fragment List File. The content of the file is JSON, consistent with the fields of SegmentSet. (The file will not be retained permanently and will be deleted when reaching SegmentSetFileUrlExpireTime.)
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// Expiration time of the Segment List File URL for anomalies, in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("SegmentSetFileUrlExpireTime")]
        public string SegmentSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrl", this.SegmentSetFileUrl);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrlExpireTime", this.SegmentSetFileUrlExpireTime);
        }
    }
}

