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

    public class ModifyQualityInspectTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Template ID.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. For customers who activate VOD services from December 25, 2023, if they access resources in VOD applications (whether the default application or a newly created application), this field must be filled in as the application ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Template name. Length limit: 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Transcoding template description. Length limit: 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Configuration parameters for audio and video quality detection.</p>
        /// </summary>
        [JsonProperty("Configs")]
        public QualityInspectConfig[] Configs{ get; set; }

        /// <summary>
        /// <p>Spot check policy for audio and video quality inspection.</p>
        /// </summary>
        [JsonProperty("Strategy")]
        public QualityInspectStrategy Strategy{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Frame interception interval in seconds. Minimum value: 1.</p>
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame jitter and ghosting detection.</p>
        /// </summary>
        [JsonProperty("JitterConfigure")]
        public JitterConfigureInfoForUpdate JitterConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame blur detection.</p>
        /// </summary>
        [JsonProperty("BlurConfigure")]
        public BlurConfigureInfoForUpdate BlurConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for low-light and overexposure detection in video frames.</p>
        /// </summary>
        [JsonProperty("AbnormalLightingConfigure")]
        public AbnormalLightingConfigureInfoForUpdate AbnormalLightingConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video image distortion detection.</p>
        /// </summary>
        [JsonProperty("CrashScreenConfigure")]
        public CrashScreenConfigureInfoForUpdate CrashScreenConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs as an alternative) Control parameters for video picture black edge, white edge, black screen, and white screen detection.</p>
        /// </summary>
        [JsonProperty("BlackWhiteEdgeConfigure")]
        public BlackWhiteEdgeConfigureInfoForUpdate BlackWhiteEdgeConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame noise detection.</p>
        /// </summary>
        [JsonProperty("NoiseConfigure")]
        public NoiseConfigureInfoForUpdate NoiseConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead) Control parameters for video frame mosaic detection.</p>
        /// </summary>
        [JsonProperty("MosaicConfigure")]
        public MosaicConfigureInfoForUpdate MosaicConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame QR code detection.</p>
        /// </summary>
        [JsonProperty("QRCodeConfigure")]
        public QRCodeConfigureInfoForUpdate QRCodeConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for audio (mute, bass, pop) detection.</p>
        /// </summary>
        [JsonProperty("VoiceConfigure")]
        public VoiceConfigureInfoForUpdate VoiceConfigure{ get; set; }

        /// <summary>
        /// <p>(Not recommended. Use Configs instead.) Control parameters for video frame quality evaluation.</p>
        /// </summary>
        [JsonProperty("QualityEvaluationConfigure")]
        public QualityEvaluationConfigureInfoForUpdate QualityEvaluationConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArrayObj(map, prefix + "Configs.", this.Configs);
            this.SetParamObj(map, prefix + "Strategy.", this.Strategy);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
            this.SetParamObj(map, prefix + "JitterConfigure.", this.JitterConfigure);
            this.SetParamObj(map, prefix + "BlurConfigure.", this.BlurConfigure);
            this.SetParamObj(map, prefix + "AbnormalLightingConfigure.", this.AbnormalLightingConfigure);
            this.SetParamObj(map, prefix + "CrashScreenConfigure.", this.CrashScreenConfigure);
            this.SetParamObj(map, prefix + "BlackWhiteEdgeConfigure.", this.BlackWhiteEdgeConfigure);
            this.SetParamObj(map, prefix + "NoiseConfigure.", this.NoiseConfigure);
            this.SetParamObj(map, prefix + "MosaicConfigure.", this.MosaicConfigure);
            this.SetParamObj(map, prefix + "QRCodeConfigure.", this.QRCodeConfigure);
            this.SetParamObj(map, prefix + "VoiceConfigure.", this.VoiceConfigure);
            this.SetParamObj(map, prefix + "QualityEvaluationConfigure.", this.QualityEvaluationConfigure);
        }
    }
}

