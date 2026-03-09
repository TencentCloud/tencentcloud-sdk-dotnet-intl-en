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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRegisterInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Managed instance id.
        /// 
        /// The maximum per request is 100.
        /// 
        /// Parameters must not be specified simultaneously `InstanceIds` and `Filters`.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Filter list. the maximum number of `Filters` is 10 per request, and the maximum number of `Filter.Values` is 5. parameters must not be specified simultaneously for `InstanceIds` and `Filters`.
        /// 
        /// 
        /// - instance-name
        /// 
        /// Filter by [managed instance name].
        /// Type: String.
        /// Required: No
        /// 
        /// - instance-id
        /// 
        /// Filter by [managed instance ID].
        /// Type: String.
        /// Required: No
        /// 
        /// - register-status
        /// 
        /// Filter by [managed instance status]. valid values: Online | Offline.
        /// Type: String.
        /// Required: No
        /// 
        /// - local-ip
        /// 
        /// Filter by [managed instance nic IP].
        /// Type: String.
        /// Required: No
        /// 
        /// - register-code-id
        /// 
        /// Filter by [managed instance registration code ID]. call the [DescribeRegisterCodes](https://www.tencentcloud.comom/document/api/1340/96925?from_cn_redirect=1) api to query registration codes.
        /// Type: String.
        /// Required: No
        /// 
        /// - sys-name
        /// 
        /// Filter by [operating system type]. valid values: Linux | Windows.
        /// Type: String.
        /// Required: No
        /// 
        /// - tag-key
        /// 
        /// Filter by [tag key].
        /// Type: String.
        /// Required: No
        /// 
        /// - tag-value
        /// 
        /// Filter by [tag value].
        /// Type: String.
        /// Required: No
        /// 
        /// - tag:tag-key
        /// 
        /// Filter by [tag key-value pair]. replace tag-key with a specific Tag key.
        /// Type: String.
        /// Required: No
        /// 
        /// For example, the Filter is {"Name": "tag:key1", "Values": ["v1", "v2"] }, which queries all resources belonging to tag key1:v1 or key1:v2.
        /// 
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results, defaults to 20, maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

