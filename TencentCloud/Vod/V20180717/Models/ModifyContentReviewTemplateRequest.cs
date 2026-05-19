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

    public class ModifyContentReviewTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of a content review template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Content review template name. The length cannot exceed 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Content review template description information, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Control parameters for unsafe information.
        /// </summary>
        [JsonProperty("TerrorismConfigure")]
        public TerrorismConfigureInfoForUpdate TerrorismConfigure{ get; set; }

        /// <summary>
        /// Control parameters for offensive information.
        /// </summary>
        [JsonProperty("PornConfigure")]
        public PornConfigureInfoForUpdate PornConfigure{ get; set; }

        /// <summary>
        /// Control parameter for inappropriate information.
        /// </summary>
        [JsonProperty("PoliticalConfigure")]
        public PoliticalConfigureInfoForUpdate PoliticalConfigure{ get; set; }

        /// <summary>
        /// Prohibited control parameters. Prohibited content includes:
        /// <li>Abuse;</li>
        /// <li>Drug-related violation.</li>
        /// </summary>
        [JsonProperty("ProhibitedConfigure")]
        public ProhibitedConfigureInfoForUpdate ProhibitedConfigure{ get; set; }

        /// <summary>
        /// User-defined content review control parameters.
        /// </summary>
        [JsonProperty("UserDefineConfigure")]
        public UserDefineConfigureInfoForUpdate UserDefineConfigure{ get; set; }

        /// <summary>
        /// Frame interception interval, unit: seconds, minimum value 0.5.
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// Switch for whether the review result enters the review wall (manual recognition performed on the review result).
        /// <li>ON: yes</li>
        /// <li>OFF: No.</li>
        /// </summary>
        [JsonProperty("ReviewWallSwitch")]
        public string ReviewWallSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "TerrorismConfigure.", this.TerrorismConfigure);
            this.SetParamObj(map, prefix + "PornConfigure.", this.PornConfigure);
            this.SetParamObj(map, prefix + "PoliticalConfigure.", this.PoliticalConfigure);
            this.SetParamObj(map, prefix + "ProhibitedConfigure.", this.ProhibitedConfigure);
            this.SetParamObj(map, prefix + "UserDefineConfigure.", this.UserDefineConfigure);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
            this.SetParamSimple(map, prefix + "ReviewWallSwitch", this.ReviewWallSwitch);
        }
    }
}

