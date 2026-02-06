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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// The ckafka cluster instance Id, which can be obtained through the [DescribeInstances](https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// ACL resource type. Currently, the only valid value is `Topic`.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// ACL rule-based matching type. currently supports prefix match and PRESET policy. valid values: PREFIXED/PRESET.
        /// </summary>
        [JsonProperty("PatternType")]
        public string PatternType{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// ACL rule list
        /// </summary>
        [JsonProperty("RuleList")]
        public AclRuleInfo[] RuleList{ get; set; }

        /// <summary>
        /// Indicates the prefix for prefix match. this parameter is required when PatternType value is PREFIXED.
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// Specifies whether to apply the preset ACL rule to newly-added topics. defaults to 0, which means no. a value of 1 means yes.
        /// </summary>
        [JsonProperty("IsApplied")]
        public long? IsApplied{ get; set; }

        /// <summary>
        /// Remarks for ACL rules
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "PatternType", this.PatternType);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "IsApplied", this.IsApplied);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

