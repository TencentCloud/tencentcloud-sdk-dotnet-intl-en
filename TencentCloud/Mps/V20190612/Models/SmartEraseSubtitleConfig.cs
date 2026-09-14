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

    public class SmartEraseSubtitleConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleEraseMethod")]
        public string SubtitleEraseMethod{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleModel")]
        public string SubtitleModel{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OcrSwitch")]
        public string OcrSwitch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleLang")]
        public string SubtitleLang{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TransSwitch")]
        public string TransSwitch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TransDstLang")]
        public string TransDstLang{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CustomAreas")]
        public EraseTimeArea[] CustomAreas{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public ulong? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UseOriginalPos")]
        public long? UseOriginalPos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UseOriginalSize")]
        public long? UseOriginalSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleEraseMethod", this.SubtitleEraseMethod);
            this.SetParamSimple(map, prefix + "SubtitleModel", this.SubtitleModel);
            this.SetParamSimple(map, prefix + "OcrSwitch", this.OcrSwitch);
            this.SetParamSimple(map, prefix + "SubtitleLang", this.SubtitleLang);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "TransSwitch", this.TransSwitch);
            this.SetParamSimple(map, prefix + "TransDstLang", this.TransDstLang);
            this.SetParamArrayObj(map, prefix + "AutoAreas.", this.AutoAreas);
            this.SetParamArrayObj(map, prefix + "CustomAreas.", this.CustomAreas);
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "UseOriginalPos", this.UseOriginalPos);
            this.SetParamSimple(map, prefix + "UseOriginalSize", this.UseOriginalSize);
        }
    }
}

