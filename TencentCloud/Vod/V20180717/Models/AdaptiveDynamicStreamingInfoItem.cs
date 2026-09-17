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

    public class AdaptiveDynamicStreamingInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Package")]
        public string Package{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DigitalWatermarkType")]
        public string DigitalWatermarkType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubStreamSet")]
        public MediaSubStreamInfoItem[] SubStreamSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CopyRightWatermarkText")]
        public string CopyRightWatermarkText{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BlindWatermarkDefinition")]
        public long? BlindWatermarkDefinition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleSet")]
        public MediaSubtitleItem[] SubtitleSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DefaultSubtitleId")]
        public string DefaultSubtitleId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DrmEncryptType")]
        public string DrmEncryptType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Package", this.Package);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "DigitalWatermarkType", this.DigitalWatermarkType);
            this.SetParamArrayObj(map, prefix + "SubStreamSet.", this.SubStreamSet);
            this.SetParamSimple(map, prefix + "CopyRightWatermarkText", this.CopyRightWatermarkText);
            this.SetParamSimple(map, prefix + "BlindWatermarkDefinition", this.BlindWatermarkDefinition);
            this.SetParamArrayObj(map, prefix + "SubtitleSet.", this.SubtitleSet);
            this.SetParamSimple(map, prefix + "DefaultSubtitleId", this.DefaultSubtitleId);
            this.SetParamSimple(map, prefix + "DrmEncryptType", this.DrmEncryptType);
        }
    }
}

