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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateContentReviewTemplateRequest : AbstractModel
    {
        
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
        /// Control parameter for offensive content
        /// </summary>
        [JsonProperty("PornConfigure")]
        public PornConfigureInfo PornConfigure{ get; set; }

        /// <summary>
        /// Control parameter for insecure content
        /// </summary>
        [JsonProperty("TerrorismConfigure")]
        public TerrorismConfigureInfo TerrorismConfigure{ get; set; }

        /// <summary>
        /// Control parameter for inappropriate content
        /// </summary>
        [JsonProperty("PoliticalConfigure")]
        public PoliticalConfigureInfo PoliticalConfigure{ get; set; }

        /// <summary>
        /// Control parameter of prohibited information detection. Prohibited information includes:
        /// <li>Abusive;</li>
        /// <li>Drug-related.</li>
        /// Note: this parameter is not supported yet.
        /// </summary>
        [JsonProperty("ProhibitedConfigure")]
        public ProhibitedConfigureInfo ProhibitedConfigure{ get; set; }

        /// <summary>
        /// Control parameter for custom intelligent content recognition
        /// </summary>
        [JsonProperty("UserDefineConfigure")]
        public UserDefineConfigureInfo UserDefineConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
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

