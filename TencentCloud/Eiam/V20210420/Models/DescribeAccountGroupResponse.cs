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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccountGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of records returned for the query.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Application ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Returned list of eligible data.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccountGroupList")]
        public AccountGroupInfo[] AccountGroupList{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamArrayObj(map, prefix + "AccountGroupList.", this.AccountGroupList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

