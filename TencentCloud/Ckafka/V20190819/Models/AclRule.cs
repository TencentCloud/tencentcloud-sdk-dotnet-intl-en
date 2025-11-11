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

    public class AclRule : AbstractModel
    {
        
        /// <summary>
        /// ACL rule name.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// The ckafka cluster instance Id.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// ACL rule-based matching type. currently only supports prefix match. valid values: PREFIXED.
        /// </summary>
        [JsonProperty("PatternType")]
        public string PatternType{ get; set; }

        /// <summary>
        /// Indicates the prefix value for prefix match.
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// Acl resource type, currently only support Topic. valid values: Topic.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Specifies the ACL information contained in the rule.
        /// </summary>
        [JsonProperty("AclList")]
        public string AclList{ get; set; }

        /// <summary>
        /// Specifies the time when the rule was created.
        /// </summary>
        [JsonProperty("CreateTimeStamp")]
        public string CreateTimeStamp{ get; set; }

        /// <summary>
        /// Specifies whether to apply the preset ACL rule to newly-added topics.
        /// </summary>
        [JsonProperty("IsApplied")]
        public long? IsApplied{ get; set; }

        /// <summary>
        /// Rule update time.
        /// </summary>
        [JsonProperty("UpdateTimeStamp")]
        public string UpdateTimeStamp{ get; set; }

        /// <summary>
        /// Specifies the remark of the rule.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// One of the displayed corresponding TopicName.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Number of topics to which the ACL rule is applied.
        /// </summary>
        [JsonProperty("TopicCount")]
        public long? TopicCount{ get; set; }

        /// <summary>
        /// Specifies the pattern type.
        /// </summary>
        [JsonProperty("PatternTypeTitle")]
        public string PatternTypeTitle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PatternType", this.PatternType);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "AclList", this.AclList);
            this.SetParamSimple(map, prefix + "CreateTimeStamp", this.CreateTimeStamp);
            this.SetParamSimple(map, prefix + "IsApplied", this.IsApplied);
            this.SetParamSimple(map, prefix + "UpdateTimeStamp", this.UpdateTimeStamp);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "TopicCount", this.TopicCount);
            this.SetParamSimple(map, prefix + "PatternTypeTitle", this.PatternTypeTitle);
        }
    }
}

