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

    public class DescribeMNPSubscribeMessageTemplateInfoResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Template title.</p>
        /// </summary>
        [JsonProperty("TemplateTitle")]
        public string TemplateTitle{ get; set; }

        /// <summary>
        /// <p>Template title in multiple languages.</p>
        /// </summary>
        [JsonProperty("TemplateTitleI18nList")]
        public I18nItem[] TemplateTitleI18nList{ get; set; }

        /// <summary>
        /// <p>Default language.</p>
        /// </summary>
        [JsonProperty("DefaultLang")]
        public string DefaultLang{ get; set; }

        /// <summary>
        /// <p>Supported languages.</p>
        /// </summary>
        [JsonProperty("SupportLang")]
        public string[] SupportLang{ get; set; }

        /// <summary>
        /// <p>Template ID.</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>Keywords.</p>
        /// </summary>
        [JsonProperty("Keywords")]
        public string Keywords{ get; set; }

        /// <summary>
        /// <p>Template keyword in multiple languages.</p>
        /// </summary>
        [JsonProperty("KeywordI18nList")]
        public SubscribeMessageTemplateLibraryKeywordI18nInfoResp[] KeywordI18nList{ get; set; }

        /// <summary>
        /// <p>Template type. Valid values: 2: One-time message; 3: Long-term subscription message.</p>
        /// </summary>
        [JsonProperty("TemplateType")]
        public long? TemplateType{ get; set; }

        /// <summary>
        /// <p>Creator.</p>
        /// </summary>
        [JsonProperty("CreateUser")]
        public string CreateUser{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Status. Valid values: 1: Active.</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateTitle", this.TemplateTitle);
            this.SetParamArrayObj(map, prefix + "TemplateTitleI18nList.", this.TemplateTitleI18nList);
            this.SetParamSimple(map, prefix + "DefaultLang", this.DefaultLang);
            this.SetParamArraySimple(map, prefix + "SupportLang.", this.SupportLang);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Keywords", this.Keywords);
            this.SetParamArrayObj(map, prefix + "KeywordI18nList.", this.KeywordI18nList);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "CreateUser", this.CreateUser);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

