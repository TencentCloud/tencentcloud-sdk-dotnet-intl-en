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
        /// Media quality inspection template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Media quality inspection template name.Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Frame interval, unit in seconds, minimum value is 1. When not filled, the default frame interval is 1 second.
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// Control parameters for detecting video jitter and ghosting.
        /// </summary>
        [JsonProperty("JitterConfigure")]
        public JitterConfigureInfoForUpdate JitterConfigure{ get; set; }

        /// <summary>
        /// Control parameters for detecting video blur.
        /// </summary>
        [JsonProperty("BlurConfigure")]
        public BlurConfigureInfoForUpdate BlurConfigure{ get; set; }

        /// <summary>
        /// Control parameters for detecting low brightness and overexposure of video.
        /// </summary>
        [JsonProperty("AbnormalLightingConfigure")]
        public AbnormalLightingConfigureInfoForUpdate AbnormalLightingConfigure{ get; set; }

        /// <summary>
        /// Control parameters for detecting video crash.
        /// </summary>
        [JsonProperty("CrashScreenConfigure")]
        public CrashScreenConfigureInfoForUpdate CrashScreenConfigure{ get; set; }

        /// <summary>
        /// Control parameters for detecting video black edges, white edges, black screen, and white screen.
        /// </summary>
        [JsonProperty("BlackWhiteEdgeConfigure")]
        public BlackWhiteEdgeConfigureInfoForUpdate BlackWhiteEdgeConfigure{ get; set; }

        /// <summary>
        /// Control parameters for detecting video noise.
        /// </summary>
        [JsonProperty("NoiseConfigure")]
        public NoiseConfigureInfoForUpdate NoiseConfigure{ get; set; }

        /// <summary>
        /// Control parameters for detecting video mosaic.
        /// </summary>
        [JsonProperty("MosaicConfigure")]
        public MosaicConfigureInfoForUpdate MosaicConfigure{ get; set; }

        /// <summary>
        /// Control parameters for QR code detection in video.
        /// </summary>
        [JsonProperty("QRCodeConfigure")]
        public QRCodeConfigureInfoForUpdate QRCodeConfigure{ get; set; }

        /// <summary>
        /// Control parameters for audio (mutes, bass, blast sound).
        /// </summary>
        [JsonProperty("VoiceConfigure")]
        public VoiceConfigureInfoForUpdate VoiceConfigure{ get; set; }

        /// <summary>
        /// Control parameters for video quality evaluation.
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

