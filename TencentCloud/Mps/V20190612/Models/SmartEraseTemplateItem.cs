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

    public class SmartEraseTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of the smart erasing template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Smart erasing template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Smart erasing template description information.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Template type. Valid values:
        /// * Preset: system preset template.
        /// * Custom: user-defined template.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Erasing type.
        /// -subtitle: subtitle removal.
        /// -watermark: watermark removal.
        /// -privacy: privacy protection.
        /// </summary>
        [JsonProperty("EraseType")]
        public string EraseType{ get; set; }

        /// <summary>
        /// Subtitle erasing configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EraseSubtitleConfig")]
        public SmartEraseSubtitleConfig EraseSubtitleConfig{ get; set; }

        /// <summary>
        /// Watermark erasing configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EraseWatermarkConfig")]
        public SmartEraseWatermarkConfig EraseWatermarkConfig{ get; set; }

        /// <summary>
        /// Privacy protection configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErasePrivacyConfig")]
        public SmartErasePrivacyConfig ErasePrivacyConfig{ get; set; }

        /// <summary>
        /// Template creation time in [ISO datetime format](https://www.tencentcloud.comom/document/product/862/37710?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modification time of the template in [ISO datetime format](https://www.tencentcloud.comom/document/product/862/37710?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Alias of the preset smart erasing template.
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "EraseType", this.EraseType);
            this.SetParamObj(map, prefix + "EraseSubtitleConfig.", this.EraseSubtitleConfig);
            this.SetParamObj(map, prefix + "EraseWatermarkConfig.", this.EraseWatermarkConfig);
            this.SetParamObj(map, prefix + "ErasePrivacyConfig.", this.ErasePrivacyConfig);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
        }
    }
}

