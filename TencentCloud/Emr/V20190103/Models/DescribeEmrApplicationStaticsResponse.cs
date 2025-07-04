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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEmrApplicationStaticsResponse : AbstractModel
    {
        
        /// <summary>
        /// Application statistics
        /// </summary>
        [JsonProperty("Statics")]
        public ApplicationStatics[] Statics{ get; set; }

        /// <summary>
        /// Total count
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Available queue name
        /// </summary>
        [JsonProperty("Queues")]
        public string[] Queues{ get; set; }

        /// <summary>
        /// Available usernames
        /// </summary>
        [JsonProperty("Users")]
        public string[] Users{ get; set; }

        /// <summary>
        /// Available application type
        /// </summary>
        [JsonProperty("ApplicationTypes")]
        public string[] ApplicationTypes{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Statics.", this.Statics);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArraySimple(map, prefix + "Queues.", this.Queues);
            this.SetParamArraySimple(map, prefix + "Users.", this.Users);
            this.SetParamArraySimple(map, prefix + "ApplicationTypes.", this.ApplicationTypes);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

