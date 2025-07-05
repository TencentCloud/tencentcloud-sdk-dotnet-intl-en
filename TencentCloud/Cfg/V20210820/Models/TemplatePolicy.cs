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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplatePolicy : AbstractModel
    {
        
        /// <summary>
        /// Protection policy ID list
        /// </summary>
        [JsonProperty("TemplatePolicyIdList")]
        public string[] TemplatePolicyIdList{ get; set; }

        /// <summary>
        /// Policy rules
        /// </summary>
        [JsonProperty("TemplatePolicyRule")]
        public string TemplatePolicyRule{ get; set; }

        /// <summary>
        /// Process method when the guardrail policy takes effect. 1: sequential execution, 2: pausing.
        /// </summary>
        [JsonProperty("TemplatePolicyDealType")]
        public long? TemplatePolicyDealType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TemplatePolicyIdList.", this.TemplatePolicyIdList);
            this.SetParamSimple(map, prefix + "TemplatePolicyRule", this.TemplatePolicyRule);
            this.SetParamSimple(map, prefix + "TemplatePolicyDealType", this.TemplatePolicyDealType);
        }
    }
}

