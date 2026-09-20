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

    public class QualityInspectTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Template ID.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Template type. Available values:</p><li>Preset: preset template;</li><li>Custom: custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Template name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Template description.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Configuration parameters for audio and video quality detection.</p>
        /// </summary>
        [JsonProperty("Configs")]
        public QualityInspectConfig[] Configs{ get; set; }

        /// <summary>
        /// <p>Spot check policy for audio and video quality detection.</p>
        /// </summary>
        [JsonProperty("Strategy")]
        public QualityInspectStrategy Strategy{ get; set; }

        /// <summary>
        /// <p>Template creation time, in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last template modification time, in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs as an alternative.) Frame interception interval in seconds.</p>
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame jitter and ghosting detection.</p>
        /// </summary>
        [JsonProperty("JitterConfigure")]
        public JitterConfigureInfo JitterConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame blur detection.</p>
        /// </summary>
        [JsonProperty("BlurConfigure")]
        public BlurConfigureInfo BlurConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for detecting low-light and overexposure in video frames.</p>
        /// </summary>
        [JsonProperty("AbnormalLightingConfigure")]
        public AbnormalLightingConfigureInfo AbnormalLightingConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for screen glitch detection in video footage.</p>
        /// </summary>
        [JsonProperty("CrashScreenConfigure")]
        public CrashScreenConfigureInfo CrashScreenConfigure{ get; set; }

        /// <summary>
        /// <p>Control parameters for detecting video picture black edge, white edge, black screen, and white screen.</p>
        /// </summary>
        [JsonProperty("BlackWhiteEdgeConfigure")]
        public BlackWhiteEdgeConfigureInfo BlackWhiteEdgeConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame noise detection.</p>
        /// </summary>
        [JsonProperty("NoiseConfigure")]
        public NoiseConfigureInfo NoiseConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame mosaic detection.</p>
        /// </summary>
        [JsonProperty("MosaicConfigure")]
        public MosaicConfigureInfo MosaicConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame QR code detection.</p>
        /// </summary>
        [JsonProperty("QRCodeConfigure")]
        public QRCodeConfigureInfo QRCodeConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame quality evaluation.</p>
        /// </summary>
        [JsonProperty("QualityEvaluationConfigure")]
        public QualityEvaluationConfigureInfo QualityEvaluationConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for audio (mute, bass, pop) detection.</p>
        /// </summary>
        [JsonProperty("VoiceConfigure")]
        public VoiceConfigureInfo VoiceConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArrayObj(map, prefix + "Configs.", this.Configs);
            this.SetParamObj(map, prefix + "Strategy.", this.Strategy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
            this.SetParamObj(map, prefix + "JitterConfigure.", this.JitterConfigure);
            this.SetParamObj(map, prefix + "BlurConfigure.", this.BlurConfigure);
            this.SetParamObj(map, prefix + "AbnormalLightingConfigure.", this.AbnormalLightingConfigure);
            this.SetParamObj(map, prefix + "CrashScreenConfigure.", this.CrashScreenConfigure);
            this.SetParamObj(map, prefix + "BlackWhiteEdgeConfigure.", this.BlackWhiteEdgeConfigure);
            this.SetParamObj(map, prefix + "NoiseConfigure.", this.NoiseConfigure);
            this.SetParamObj(map, prefix + "MosaicConfigure.", this.MosaicConfigure);
            this.SetParamObj(map, prefix + "QRCodeConfigure.", this.QRCodeConfigure);
            this.SetParamObj(map, prefix + "QualityEvaluationConfigure.", this.QualityEvaluationConfigure);
            this.SetParamObj(map, prefix + "VoiceConfigure.", this.VoiceConfigure);
        }
    }
}

