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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocImportSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>File ID (file identifier obtained through the file management service, required)</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Ownership category ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>List of rules regarding repeated files</p>
        /// </summary>
        [JsonProperty("DeDuplicateStrategyList")]
        public DeDuplicateStrategy[] DeDuplicateStrategyList{ get; set; }

        /// <summary>
        /// <p>Knowledge effective scope<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_UNKNOWN</td><td>0</td><td></td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_NONE</td><td>1</td><td>Disabled</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_DEV</td><td>2</td><td>Development domain only</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_RELEASE</td><td>3</td><td>Release domain only</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_ALL</td><td>4</td><td>Global</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("EffectiveDomain")]
        public long? EffectiveDomain{ get; set; }

        /// <summary>
        /// <p>Expiration policy (validity time and behavior after the validity period expires)</p>
        /// </summary>
        [JsonProperty("ExpirationPolicy")]
        public ExpirationPolicy ExpirationPolicy{ get; set; }

        /// <summary>
        /// <p>External link</p>
        /// </summary>
        [JsonProperty("ExternalLink")]
        public DocExternalLink ExternalLink{ get; set; }

        /// <summary>
        /// <p>Applicable scope (tag condition).</p>
        /// </summary>
        [JsonProperty("LabelRefList")]
        public LabelRefIdentity[] LabelRefList{ get; set; }

        /// <summary>
        /// <p>Parsing configuration (split rules, content filtering, etc.)</p>
        /// </summary>
        [JsonProperty("ParseConfig")]
        public DocParseConfig ParseConfig{ get; set; }

        /// <summary>
        /// <p>Switch configuration</p>
        /// </summary>
        [JsonProperty("Switch")]
        public DocSwitch Switch{ get; set; }

        /// <summary>
        /// <p>Update cycle</p>
        /// </summary>
        [JsonProperty("UpdatePeriod")]
        public DocUpdatePeriod UpdatePeriod{ get; set; }

        /// <summary>
        /// <p>User access configuration</p>
        /// </summary>
        [JsonProperty("UserAccessConfig")]
        public UserAccessConfig UserAccessConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamArrayObj(map, prefix + "DeDuplicateStrategyList.", this.DeDuplicateStrategyList);
            this.SetParamSimple(map, prefix + "EffectiveDomain", this.EffectiveDomain);
            this.SetParamObj(map, prefix + "ExpirationPolicy.", this.ExpirationPolicy);
            this.SetParamObj(map, prefix + "ExternalLink.", this.ExternalLink);
            this.SetParamArrayObj(map, prefix + "LabelRefList.", this.LabelRefList);
            this.SetParamObj(map, prefix + "ParseConfig.", this.ParseConfig);
            this.SetParamObj(map, prefix + "Switch.", this.Switch);
            this.SetParamObj(map, prefix + "UpdatePeriod.", this.UpdatePeriod);
            this.SetParamObj(map, prefix + "UserAccessConfig.", this.UserAccessConfig);
        }
    }
}

