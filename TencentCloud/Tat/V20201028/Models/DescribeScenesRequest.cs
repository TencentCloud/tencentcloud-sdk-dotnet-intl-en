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

    public class DescribeScenesRequest : AbstractModel
    {
        
        /// <summary>
        /// Scene ID array.
        /// 
        /// The maximum per request is 100.
        /// 
        /// Parameters must not specify both `SceneIds` and `Filters` simultaneously.
        /// </summary>
        [JsonProperty("SceneIds")]
        public string[] SceneIds{ get; set; }

        /// <summary>
        /// Filter criteria
        /// 
        /// - scene-id - String - required: no - (filter condition) filter by the scene id.
        /// -scene-name - String - required: no - (filtering conditions) filter by scenario name.
        /// -created-by - String - required: no - (filter criteria) filter by scene creator, currently only support TAT, representing public scenarios.
        /// 
        /// The maximum number of `Filters` per request is 10, and that of `Filter.Values` is 5. the `SceneIds` and `Filters` parameters cannot be specified at the same time.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of returned results, defaults to 20 with a maximum value of 100. for further introduction about `Limit`, see relevant sections in the API [overview](https://www.tencentcloud.com/document/API/213/15688?from_cn_redirect=1).
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
            this.SetParamArraySimple(map, prefix + "SceneIds.", this.SceneIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

