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

    public class ModifyContentReviewTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// The unique ID of the content moderation template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// The name of the content moderation template. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Control parameter for porn information
        /// </summary>
        [JsonProperty("PornConfigure")]
        public PornConfigureInfoForUpdate PornConfigure{ get; set; }

        /// <summary>
        /// Control parameter for terrorism information
        /// </summary>
        [JsonProperty("TerrorismConfigure")]
        public TerrorismConfigureInfoForUpdate TerrorismConfigure{ get; set; }

        /// <summary>
        /// Control parameter for politically sensitive information
        /// </summary>
        [JsonProperty("PoliticalConfigure")]
        public PoliticalConfigureInfoForUpdate PoliticalConfigure{ get; set; }

        /// <summary>
        /// Control parameter of prohibited information detection. Prohibited information includes:
        /// <li>Abusive;</li>
        /// <li>Drug-related.</li>
        /// Note: this parameter is not supported yet.
        /// </summary>
        [JsonProperty("ProhibitedConfigure")]
        public ProhibitedConfigureInfoForUpdate ProhibitedConfigure{ get; set; }

        /// <summary>
        /// Custom content moderation parameters.
        /// </summary>
        [JsonProperty("UserDefineConfigure")]
        public UserDefineConfigureInfoForUpdate UserDefineConfigure{ get; set; }


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
        }
    }
}

