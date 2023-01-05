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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEventsResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether the log list has come to an end. `true`: Yes. Pagination is not required.
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// Credential for viewing more logs.
        /// </summary>
        [JsonProperty("NextToken")]
        public ulong? NextToken{ get; set; }

        /// <summary>
        /// Logset.
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Events")]
        public Event[] Events{ get; set; }

        /// <summary>
        /// This parameter has been deprecated. Please use `ListOver` and `NextToken` for pagination, and read data of the next page when the value of `ListOver` is `false`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ListOver", this.ListOver);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamArrayObj(map, prefix + "Events.", this.Events);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

