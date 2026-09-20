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

    public class ModifyReviewTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of the review template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services from December 25, 2023, when accessing resources in VOD applications (whether the default application or a newly created application), this field must be set to the app ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Review template name, with a length limit of 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Review template description information, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// List of violation labels to return. Optional values:
        /// <li>Porn: Pornography;</li>
        /// <li>Terror: violence.</li>
        /// <li>Polity: inappropriate information;</li>
        /// <li>Illegal: illegal;</li>
        /// <li>Abuse: verbal abuse;</li>
        /// <li>Ad: advertisement;</li>
        /// <li>Moan: panting.</li>
        /// 
        /// Note: Leaving it blank means it does not update.
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
        }
    }
}

