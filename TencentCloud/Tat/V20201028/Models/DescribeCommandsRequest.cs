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

    public class DescribeCommandsRequest : AbstractModel
    {
        
        /// <summary>
        /// List of command IDs. Up to 100 IDs are allowed for each request. `CommandIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("CommandIds")]
        public string[] CommandIds{ get; set; }

        /// <summary>
        /// Filter criteria
        /// 
        /// - command-id - String - required: no - (filter condition) filter by the command id.
        /// - command-name - String - required: no - (filter condition) filter by the command name.
        /// -command-type - String - required: no - (filtering conditions) filters by command type. valid values: SHELL, POWERSHELL, BAT.
        /// -scene-id - String - required: no - (filter condition) filter by scenario id. obtain scenario id through the [DescribeScenes (query scenario)](https://www.tencentcloud.comom/document/api/1340/109968?from_cn_redirect=1) api.
        /// -created-by - String - required: no - (filter condition) filter by command creator, value is TAT or USER. TAT represents public command, USER represents USER created command.
        /// - tag-key - String - required: no - (filter condition) filter by the tag key.
        /// - tag-value - String - required: no - (filter condition) filter by the tag value.
        /// - tag:tag-key - String - required: no - (filter condition) filter by the tag-key - value pair. replace tag-key with a specific tag key. for usage, see example 4.
        /// 
        /// The maximum number of `Filters` per request is 10, and that of `Filter.Values` is 5. the `CommandIds` and `Filters` parameters cannot be specified at the same time.
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
            this.SetParamArraySimple(map, prefix + "CommandIds.", this.CommandIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

