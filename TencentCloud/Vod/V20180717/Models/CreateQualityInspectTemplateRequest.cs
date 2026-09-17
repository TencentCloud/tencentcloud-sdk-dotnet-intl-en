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

    public class CreateQualityInspectTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Configs")]
        public QualityInspectConfig[] Configs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Strategy")]
        public QualityInspectStrategy Strategy{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("JitterConfigure")]
        public JitterConfigureInfo JitterConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BlurConfigure")]
        public BlurConfigureInfo BlurConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AbnormalLightingConfigure")]
        public AbnormalLightingConfigureInfo AbnormalLightingConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CrashScreenConfigure")]
        public CrashScreenConfigureInfo CrashScreenConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BlackWhiteEdgeConfigure")]
        public BlackWhiteEdgeConfigureInfo BlackWhiteEdgeConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NoiseConfigure")]
        public NoiseConfigureInfo NoiseConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MosaicConfigure")]
        public MosaicConfigureInfo MosaicConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QRCodeConfigure")]
        public QRCodeConfigureInfo QRCodeConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VoiceConfigure")]
        public VoiceConfigureInfo VoiceConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QualityEvaluationConfigure")]
        public QualityEvaluationConfigureInfo QualityEvaluationConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
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

