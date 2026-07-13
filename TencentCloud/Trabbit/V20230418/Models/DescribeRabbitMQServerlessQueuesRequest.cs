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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRabbitMQServerlessQueuesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance Id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Vhost parameter</p>
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// <p>Pagination offset.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Pagination limit.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Search keyword</p>
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// <p>Queue type filter criteria. Leave blank or use "all" for classic and quorum queues; "classic" for classic queues; "quorum" for quorum queues.</p>
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// <p>Sorting field:<br>messages_ready - message backlog;<br>publish - production rate;<br>deliver - consumption rate;<br>consumers - number of online consumers;</p>
        /// </summary>
        [JsonProperty("SortElement")]
        public string SortElement{ get; set; }

        /// <summary>
        /// <p>Sort order, asc or desc</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "SortElement", this.SortElement);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

