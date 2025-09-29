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

    public class ModifySmartEraseTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of the smart erasing template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Length limit for the smart erasing template name: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Length limit for the description information of the smart erasing template: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Erasing type.
        /// -subtitle: subtitle removal.
        /// -watermark: watermark removal.
        /// -privacy: privacy protection.
        /// </summary>
        [JsonProperty("EraseType")]
        public string EraseType{ get; set; }

        /// <summary>
        /// Subtitle erasing configuration. It takes effect when the value of EraseType is set to subtitle, or when the value of EraseType is left unspecified but the original EraseType value of the modified template is subtitle.
        /// </summary>
        [JsonProperty("EraseSubtitleConfig")]
        public SmartEraseSubtitleConfig EraseSubtitleConfig{ get; set; }

        /// <summary>
        /// Watermark erasing configuration. The value of EraseType can be set to watermark or left unspecified. This parameter is valid only when the value of EraseType of the corresponding template is set to watermark.
        /// </summary>
        [JsonProperty("EraseWatermarkConfig")]
        public SmartEraseWatermarkConfig EraseWatermarkConfig{ get; set; }

        /// <summary>
        /// Privacy protection configuration. The value of EraseType can be set to privacy or left unspecified. This parameter is valid only when the value of EraseType of the corresponding template is set to privacy.
        /// </summary>
        [JsonProperty("ErasePrivacyConfig")]
        public SmartErasePrivacyConfig ErasePrivacyConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "EraseType", this.EraseType);
            this.SetParamObj(map, prefix + "EraseSubtitleConfig.", this.EraseSubtitleConfig);
            this.SetParamObj(map, prefix + "EraseWatermarkConfig.", this.EraseWatermarkConfig);
            this.SetParamObj(map, prefix + "ErasePrivacyConfig.", this.ErasePrivacyConfig);
        }
    }
}

