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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCmqQueuesRequest : AbstractModel
    {
        
        /// <summary>
        /// Starting position of the list of queues to be returned on the current page in case of paginated return. If a value is entered, `limit` is required. If this parameter is left empty, 0 will be used by default
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of queues to be returned per page in case of paginated return. If this parameter is not passed in, 20 will be used by default. Maximum value: 50.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter by `QueueName`
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// List of CMQ queue names
        /// </summary>
        [JsonProperty("QueueNameList")]
        public string[] QueueNameList{ get; set; }

        /// <summary>
        /// For filtering by tag, this must be configured to `true`.
        /// </summary>
        [JsonProperty("IsTagFilter")]
        public bool? IsTagFilter{ get; set; }

        /// <summary>
        /// Filter. Currently, you can filter only by tag.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamArraySimple(map, prefix + "QueueNameList.", this.QueueNameList);
            this.SetParamSimple(map, prefix + "IsTagFilter", this.IsTagFilter);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

