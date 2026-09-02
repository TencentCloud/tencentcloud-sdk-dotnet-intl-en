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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDspmIdentifyRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Data item name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Data item description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Data item enablement status</p><p>Enumeration values:</p><ul><li>0: disabled</li><li>1: enabled</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>Structured rule</p>
        /// </summary>
        [JsonProperty("StructuredRule")]
        public string StructuredRule{ get; set; }

        /// <summary>
        /// <p>Unstructured rule</p>
        /// </summary>
        [JsonProperty("UnStructuredRule")]
        public string UnStructuredRule{ get; set; }

        /// <summary>
        /// <p>Operation source: empty/dspm=database risk monitoring entry, cos=object storage risk monitoring entry</p>
        /// </summary>
        [JsonProperty("OperationSource")]
        public string OperationSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StructuredRule", this.StructuredRule);
            this.SetParamSimple(map, prefix + "UnStructuredRule", this.UnStructuredRule);
            this.SetParamSimple(map, prefix + "OperationSource", this.OperationSource);
        }
    }
}

