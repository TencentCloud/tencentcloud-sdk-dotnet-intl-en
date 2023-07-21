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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Full-text index configuration. If the configuration is left empty, full-text indexing is not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FullText")]
        public FullTextInfo FullText{ get; set; }

        /// <summary>
        /// Key-value index configuration. If the configuration is left empty, key-value indexing is not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyValue")]
        public RuleKeyValueInfo KeyValue{ get; set; }

        /// <summary>
        /// Metadata field index configuration. If the configuration is left empty, metadata field indexing is not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public RuleTagInfo Tag{ get; set; }

        /// <summary>
        /// Dynamic index configuration. If the configuration is empty, dynamic indexing is not enabled.
        /// 
        /// Note: This feature is currently in a beta test. To use it, please contact technical support.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DynamicIndex")]
        public DynamicIndex DynamicIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FullText.", this.FullText);
            this.SetParamObj(map, prefix + "KeyValue.", this.KeyValue);
            this.SetParamObj(map, prefix + "Tag.", this.Tag);
            this.SetParamObj(map, prefix + "DynamicIndex.", this.DynamicIndex);
        }
    }
}

