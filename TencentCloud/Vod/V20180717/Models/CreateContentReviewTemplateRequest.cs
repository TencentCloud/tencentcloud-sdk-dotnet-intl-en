/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateContentReviewTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to allow the recognition result to enter the intelligent recognition platform (for human recognition).
        /// <li>ON: yes</li>
        /// <li>OFF: no</li>
        /// </summary>
        [JsonProperty("ReviewWallSwitch")]
        public string ReviewWallSwitch{ get; set; }

        /// <summary>
        /// Name of an intelligent content recognition template. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description of an intelligent content recognition template. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Control parameter for porn information.
        /// </summary>
        [JsonProperty("PornConfigure")]
        public PornConfigureInfo PornConfigure{ get; set; }

        /// <summary>
        /// Control parameter for terrorism information.
        /// </summary>
        [JsonProperty("TerrorismConfigure")]
        public TerrorismConfigureInfo TerrorismConfigure{ get; set; }

        /// <summary>
        /// Control parameter for politically sensitive information.
        /// </summary>
        [JsonProperty("PoliticalConfigure")]
        public PoliticalConfigureInfo PoliticalConfigure{ get; set; }

        /// <summary>
        /// Control parameter of prohibited information detection. Prohibited information includes:
        /// <li>Abusive;</li>
        /// <li>Drug-related.</li>
        /// </summary>
        [JsonProperty("ProhibitedConfigure")]
        public ProhibitedConfigureInfo ProhibitedConfigure{ get; set; }

        /// <summary>
        /// Control parameter for custom intelligent content recognition.
        /// </summary>
        [JsonProperty("UserDefineConfigure")]
        public UserDefineConfigureInfo UserDefineConfigure{ get; set; }

        /// <summary>
        /// Frame capturing interval in seconds. If this parameter is left empty, 1 second will be used by default. Minimum value: 0.5 seconds.
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// [Subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReviewWallSwitch", this.ReviewWallSwitch);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "PornConfigure.", this.PornConfigure);
            this.SetParamObj(map, prefix + "TerrorismConfigure.", this.TerrorismConfigure);
            this.SetParamObj(map, prefix + "PoliticalConfigure.", this.PoliticalConfigure);
            this.SetParamObj(map, prefix + "ProhibitedConfigure.", this.ProhibitedConfigure);
            this.SetParamObj(map, prefix + "UserDefineConfigure.", this.UserDefineConfigure);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

