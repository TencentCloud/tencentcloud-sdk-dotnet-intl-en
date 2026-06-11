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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MNPSubscribeMessageTemplateDetailResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Subscription message template ID.</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>Subscription message template title.</p>
        /// </summary>
        [JsonProperty("TemplateTitle")]
        public string TemplateTitle{ get; set; }

        /// <summary>
        /// <p>Subscription message template title in multiple languages.</p>
        /// </summary>
        [JsonProperty("TitleList")]
        public I18nItem[] TitleList{ get; set; }

        /// <summary>
        /// <p>Subscription message template default language.</p>
        /// </summary>
        [JsonProperty("DefaultLang")]
        public string DefaultLang{ get; set; }

        /// <summary>
        /// <p>Subscription message template supported languages.</p>
        /// </summary>
        [JsonProperty("Languages")]
        public string[] Languages{ get; set; }

        /// <summary>
        /// <p>Subscription message template keywords.</p>
        /// </summary>
        [JsonProperty("KeywordList")]
        public DescribeSubscribeMessageTemplateLibraryKeywordData[] KeywordList{ get; set; }

        /// <summary>
        /// <p>Mini program name.</p>
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// <p>Mini program icon.</p>
        /// </summary>
        [JsonProperty("MNPIcon")]
        public string MNPIcon{ get; set; }

        /// <summary>
        /// <p>Template type. Valid values: 2: One-time message; 3: Long-term subscription message.</p>
        /// </summary>
        [JsonProperty("TemplateType")]
        public long? TemplateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateTitle", this.TemplateTitle);
            this.SetParamArrayObj(map, prefix + "TitleList.", this.TitleList);
            this.SetParamSimple(map, prefix + "DefaultLang", this.DefaultLang);
            this.SetParamArraySimple(map, prefix + "Languages.", this.Languages);
            this.SetParamArrayObj(map, prefix + "KeywordList.", this.KeywordList);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPIcon", this.MNPIcon);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
        }
    }
}

