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

    public class DescribeDspmIdentifyRuleTestResultRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule type</p><p>Enumeration values:</p><ul><li>structured: Structured rule</li><li>unstructrued: Unstructured rule</li></ul>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// <p>Rule content</p>
        /// </summary>
        [JsonProperty("RuleContent")]
        public string RuleContent{ get; set; }

        /// <summary>
        /// <p>Data item id</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Structured test content</p>
        /// </summary>
        [JsonProperty("StructuredTestContent")]
        public DspmIdentifyRuleStructuredTestItem[] StructuredTestContent{ get; set; }

        /// <summary>
        /// <p>Unstructured test content</p>
        /// </summary>
        [JsonProperty("UnStructuredTestContent")]
        public string UnStructuredTestContent{ get; set; }

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
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "RuleContent", this.RuleContent);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "StructuredTestContent.", this.StructuredTestContent);
            this.SetParamSimple(map, prefix + "UnStructuredTestContent", this.UnStructuredTestContent);
            this.SetParamSimple(map, prefix + "OperationSource", this.OperationSource);
        }
    }
}

