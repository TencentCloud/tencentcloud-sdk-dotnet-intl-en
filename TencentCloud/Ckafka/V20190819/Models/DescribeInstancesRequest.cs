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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// (Filter) filter by instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// (Filter) filter by instance name. Fuzzy search is supported
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// (Filter) instance status. 0: creating, 1: running, 2: deleting. If this parameter is left empty, all instances will be returned by default
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// Offset. If this parameter is left empty, 0 will be used by default
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned. If this parameter is left empty, 10 will be used by default. The maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Tag key match.
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
        }
    }
}

