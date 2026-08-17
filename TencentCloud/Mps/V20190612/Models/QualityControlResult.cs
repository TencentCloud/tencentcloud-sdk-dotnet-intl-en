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

    public class QualityControlResult : AbstractModel
    {
        
        /// <summary>
        /// Exception type. Valid values:
        /// Jitter: jitter.
        /// Blur: blurry.
        /// LowLighting: low light.
        /// HighLighting: overexposure.
        /// CrashScreen: screen glitch.
        /// BlackWhiteEdge: Black and white edges
        /// SolidColorScreen: solid color screen.
        /// Noise: noise.
        /// Mosaic: Mosaic
        /// QRCode: QR code.
        /// AppletCode: Mini program code.
        /// BarCode: barcode.
        /// LowVoice: bass.
        /// HighVoice: high voice detection.
        /// NoVoice: mute.
        /// LowEvaluation: The video no-reference score (MOS) is below the threshold.
        /// AudioEvaluation: The audio no-reference scoring (MOS) is below the threshold.
        /// AudioNoise: Audio noise.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Quality inspection result item.
        /// </summary>
        [JsonProperty("QualityControlItems")]
        public QualityControlItem[] QualityControlItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "QualityControlItems.", this.QualityControlItems);
        }
    }
}

