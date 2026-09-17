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

    public class CreateMPSTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MPSCreateTemplateParams")]
        public string MPSCreateTemplateParams{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AIAnalysisTemplate")]
        public MPSAIAnalysisTemplate AIAnalysisTemplate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SmartSubtitleTemplate")]
        public MPSSmartSubtitleTemplate SmartSubtitleTemplate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SmartEraseTemplate")]
        public MPSSmartEraseTemplate SmartEraseTemplate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EmbedSubtitleTemplate")]
        public MPSEmbedSubtitleTemplate EmbedSubtitleTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MPSCreateTemplateParams", this.MPSCreateTemplateParams);
            this.SetParamObj(map, prefix + "AIAnalysisTemplate.", this.AIAnalysisTemplate);
            this.SetParamObj(map, prefix + "SmartSubtitleTemplate.", this.SmartSubtitleTemplate);
            this.SetParamObj(map, prefix + "SmartEraseTemplate.", this.SmartEraseTemplate);
            this.SetParamObj(map, prefix + "EmbedSubtitleTemplate.", this.EmbedSubtitleTemplate);
        }
    }
}

