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

    public class DescribeSubscribeMessageTemplateLibraryKeywordInfoResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Template keyword ID.</p>
        /// </summary>
        [JsonProperty("KeywordId")]
        public string KeywordId{ get; set; }

        /// <summary>
        /// <p>Template keyword.</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>Template keyword type.</p>
        /// </summary>
        [JsonProperty("KeywordType")]
        public string KeywordType{ get; set; }

        /// <summary>
        /// <p>Template keyword default value.</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>Template keyword in multiple languages.</p>
        /// </summary>
        [JsonProperty("KeywordList")]
        public I18nItem[] KeywordList{ get; set; }

        /// <summary>
        /// <p>Template keyword default values in multiple languages.</p>
        /// </summary>
        [JsonProperty("DefaultValueList")]
        public I18nItem[] DefaultValueList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeywordId", this.KeywordId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "KeywordType", this.KeywordType);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamArrayObj(map, prefix + "KeywordList.", this.KeywordList);
            this.SetParamArrayObj(map, prefix + "DefaultValueList.", this.DefaultValueList);
        }
    }
}

