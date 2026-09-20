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

    public class ContentReviewTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of an audio and video review template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Audio/video moderation template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description of the audio and video review template, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Authentication involves control parameters for offensive information.
        /// </summary>
        [JsonProperty("PornConfigure")]
        public PornConfigureInfo PornConfigure{ get; set; }

        /// <summary>
        /// Control parameters for authentication involving unsafe information.
        /// </summary>
        [JsonProperty("TerrorismConfigure")]
        public TerrorismConfigureInfo TerrorismConfigure{ get; set; }

        /// <summary>
        /// Control parameters for identifying inappropriate information.
        /// </summary>
        [JsonProperty("PoliticalConfigure")]
        public PoliticalConfigureInfo PoliticalConfigure{ get; set; }

        /// <summary>
        /// Prohibited control parameters. Restricted content includes:
        /// <li>Abusive language;</li>
        /// <li>Drug-related violation.</li>
        /// </summary>
        [JsonProperty("ProhibitedConfigure")]
        public ProhibitedConfigureInfo ProhibitedConfigure{ get; set; }

        /// <summary>
        /// User-customized control parameters for audio/video moderation.
        /// </summary>
        [JsonProperty("UserDefineConfigure")]
        public UserDefineConfigureInfo UserDefineConfigure{ get; set; }

        /// <summary>
        /// Whether the audio/video moderation result enters the audio/video moderation wall (for manual review of the audio/video moderation result).
        /// <li>ON: Yes;</li>
        /// <li>OFF: No.</li>
        /// </summary>
        [JsonProperty("ReviewWallSwitch")]
        public string ReviewWallSwitch{ get; set; }

        /// <summary>
        /// Frame interception interval in seconds. If not specified, the default frame interval is 1 second, with a minimum value of 0.5 seconds.
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// Template creation time in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Template last modified time, use [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "PornConfigure.", this.PornConfigure);
            this.SetParamObj(map, prefix + "TerrorismConfigure.", this.TerrorismConfigure);
            this.SetParamObj(map, prefix + "PoliticalConfigure.", this.PoliticalConfigure);
            this.SetParamObj(map, prefix + "ProhibitedConfigure.", this.ProhibitedConfigure);
            this.SetParamObj(map, prefix + "UserDefineConfigure.", this.UserDefineConfigure);
            this.SetParamSimple(map, prefix + "ReviewWallSwitch", this.ReviewWallSwitch);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

