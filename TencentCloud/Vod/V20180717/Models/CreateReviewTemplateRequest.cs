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

    public class CreateReviewTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// List of violation labels to return. Available values:
        /// <li>Porn: pornography;</li>
        /// <li>Terror: violence.</li>
        /// <li>Polity: inappropriate information;</li>
        /// <li>Illegal: illegal;</li>
        /// <li>Abuse: abusive language;</li>
        /// <li>Ad: advertisement;</li>
        /// <li>Moan: panting.</li>
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// <b>ID of the on-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1). For customers who activate on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// Review template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Review template description information. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

