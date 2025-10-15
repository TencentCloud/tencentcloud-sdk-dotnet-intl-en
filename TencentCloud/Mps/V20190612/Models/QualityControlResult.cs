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
        /// Exception type. valid values:.
        /// Jitter: jitter.
        /// Blur: specifies the blur effect.
        /// LowLighting: specifies low light.
        /// HighLighting: overexposure.
        /// CrashScreen: specifies screen glitch.
        /// BlackWhiteEdge: specifies the black and white edges.
        /// SolidColorScreen: specifies the solid color screen.
        /// Noise: specifies the noise.
        /// Mosaic: mosaic.
        /// QRCode: specifies the qr code.
        /// AppletCode: specifies the mini program code.
        /// BarCode: specifies the barcode.
        /// LowVoice: specifies the bass.
        /// HighVoice: specifies high voice detection.
        /// NoVoice: specifies mute.
        /// LowEvaluation: specifies the video no-reference score (MOS) is below the threshold.
        /// AudioEvaluation: specifies the audio no-reference scoring (MOS) is below the threshold.
        /// AudioNoise: specifies the audio noise.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The information of a checked segment in quality control.
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

