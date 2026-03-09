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

    public class DescribeInvocationTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// List of execution task IDs. Up to 100 IDs are allowed for each request. `InvocationTaskIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("InvocationTaskIds")]
        public string[] InvocationTaskIds{ get; set; }

        /// <summary>
        /// Filter conditions.<br>.
        /// 
        /// -invocation-task-id - String - required: no - (filter condition) filter by executing task id.
        /// - invocation-id - String - required: no - (filter condition) filter by the execution activity id. you can obtain it through the [DescribeInvocations](https://www.tencentcloud.comom/document/api/1340/52679?from_cn_redirect=1) api.
        /// -instance-id - String - required: no - (filtering conditions) filter by instance id. you can get the instance id through the query instance interface of corresponding cloud services. currently supported instance types: CVM, Lighthouse, and managed instances of TAT.
        /// -command-id - String - required: no - (filter criteria) filter by command id. obtain through the api [DescribeCommands (query command details)](https://www.tencentcloud.comom/document/api/1340/52681?from_cn_redirect=1).
        /// 
        /// The maximum number of `Filters` per request is 10, and that of `Filter.Values` is 5. the `InvocationTaskIds` and `Filters` parameters cannot be specified at the same time.
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
        /// Whether to hide the command output result. valid values:.
        /// 
        /// -true: hide output.
        /// - false: do not hide.
        ///  
        /// The default value is true.
        /// </summary>
        [JsonProperty("HideOutput")]
        public bool? HideOutput{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InvocationTaskIds.", this.InvocationTaskIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "HideOutput", this.HideOutput);
        }
    }
}

