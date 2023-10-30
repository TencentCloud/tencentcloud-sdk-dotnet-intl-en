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

    public class QualityInspectResultItem : AbstractModel
    {
        
        /// <summary>
        /// Abnormal type, range: <li>Jitter: Jitter;</li> <li>Blur: Blur;</li> <li>LowLighting: Low lighting;</li> <li>HighLighting: Overexposure;</li> <li>CrashScreen: Crash screen;</li> <li>BlackWhiteEdge: Black and white edges;</li> <li>SolidColorScreen: Solid color screen;</li> <li>Noise: Noise;</li> <li>Mosaic: Mosaic;</li> <li>QRCode: QR code;</li> <li>AppletCode: Applet code;</li> <li>BarCode: Bar code;</li> <li>LowVoice: Low voice;</li> <li>HighVoice: High voice;</li> <li>NoVoice: mutes;</li> <li>LowEvaluation: No reference scoring below the threshold.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Abnormal segment List. <font color=red>Pay attention to:</font> This list will only show the first 100 elements at most. If you wish to get the complete result, please get it from the file corresponding to SegmentSetFileUrl.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public QualityInspectItem[] SegmentSet{ get; set; }

        /// <summary>
        /// Abnormal segment List file URL. The file content is JSON, and the data structure is consistent with the SegmentSet Field. (The file will not be permanently stored, and will be deleted after reaching the SegmentSetFileUrlExpireTime Time point).
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// Abnormal segment List file URL expiration time, using [ISO date supported](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
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

