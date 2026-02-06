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

    public class BatchCreateAclRequest : AbstractModel
    {
        
        /// <summary>
        /// The ckafka cluster instance Id, which can be obtained through the [DescribeInstances](https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// ACL resource type. Default value: `2` (topic).
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// Resource list array, obtainable through the DescribeTopic API (https://www.tencentcloud.com/document/product/597/40847?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ResourceNames")]
        public string[] ResourceNames{ get; set; }

        /// <summary>
        /// Specifies the set ACL rule list, which can be obtained through the DescribeAclRule API (https://www.tencentcloud.com/document/product/597/89217?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("RuleList")]
        public AclRuleInfo[] RuleList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamArraySimple(map, prefix + "ResourceNames.", this.ResourceNames);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
        }
    }
}

