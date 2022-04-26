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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInvocationsRequest : AbstractModel
    {
        
        /// <summary>
        /// List of execution activity IDs. Up to 100 IDs are allowed for each request. `InvocationIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("InvocationIds")]
        public string[] InvocationIds{ get; set; }

        /// <summary>
        /// Filter conditions.<br> <li> `invocation-id` - String - Required: No - (Filter condition) Filter by the execution activity ID.<br> 
        /// <li> `command-id` - String - Required: No - (Filter condition) Filter by the command ID. 
        /// <li> `command-created-by` - String - Required: No - (Filter condition) Filter by the command type. Valid values: `TAT` (public commands) or `USER` (custom commands).
        /// <li> `instance-kind` - String - Required: No - (Filter condition) Filter by the instance type. Valid values: `CVM` or `LIGHTHOUSE`. 
        /// <br>Up to 10 `Filters` are allowed for each request. Each filter can have up to five `Filter.Values`. `InvocationIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of returned results. It defaults to `20`. The maximum is 100. For more information on `Limit`, see the relevant section in the API [Overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. The default value is `0`. For more information on `Offset`, see the relevant section in API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InvocationIds.", this.InvocationIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

