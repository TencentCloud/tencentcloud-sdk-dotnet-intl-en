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

    public class ModifyAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance Id</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/597/40835?from_cn_redirect=1">DescribeInstances</a></p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>ACL rule name</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Input when modifying the preset rule, whether to apply to newly-added topics</p><p>Enumeration value:</p><ul><li>0: Not allowed to apply to newly-added topics</li><li>1: Allowed to apply to newly-added topics</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("IsApplied")]
        public long? IsApplied{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "IsApplied", this.IsApplied);
        }
    }
}

