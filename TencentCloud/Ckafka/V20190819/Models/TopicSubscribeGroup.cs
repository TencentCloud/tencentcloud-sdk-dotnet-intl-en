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

    public class TopicSubscribeGroup : AbstractModel
    {
        
        /// <summary>
        /// Total number
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Number of consumer group status
        /// </summary>
        [JsonProperty("StatusCountInfo")]
        public string StatusCountInfo{ get; set; }

        /// <summary>
        /// Consumer group information.
        /// </summary>
        [JsonProperty("GroupsInfo")]
        public GroupInfoResponse[] GroupsInfo{ get; set; }

        /// <summary>
        /// Indicates whether the request is asynchronous. instances with fewer groups will return results directly with Status as 1. when there are more groups, the cache will be updated asynchronously. no group information will be returned when Status is 0 until the update is complete and results are returned with Status as 1.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "StatusCountInfo", this.StatusCountInfo);
            this.SetParamArrayObj(map, prefix + "GroupsInfo.", this.GroupsInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

