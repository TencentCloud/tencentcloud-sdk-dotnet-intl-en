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

    public class DescribeInvokersRequest : AbstractModel
    {
        
        /// <summary>
        /// Executor ID list.
        /// 
        /// The maximum per request is 100.
        /// 
        /// Parameters must not be specified simultaneously `InvokerIds` and `Filters`.
        /// </summary>
        [JsonProperty("InvokerIds")]
        public string[] InvokerIds{ get; set; }

        /// <summary>
        /// Filter criteria:.
        /// 
        /// - invoker-id - String - required: no - (filter condition) filter by executor id.
        /// -command-id - String - required: no - (filter condition) filters commands by id. you can obtain the id through the [DescribeCommands (query command details)](https://www.tencentcloud.comom/document/api/1340/52681?from_cn_redirect=1) api.
        /// - invoker-type - String - required: no - (filter condition) filter by the executor type. currently only support SCHEDULE.
        /// 
        /// The maximum number of `Filters` per request is 10, and that of `Filter.Values` is 5. the `InvokerIds` and `Filters` parameters cannot be specified at the same time.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InvokerIds.", this.InvokerIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

