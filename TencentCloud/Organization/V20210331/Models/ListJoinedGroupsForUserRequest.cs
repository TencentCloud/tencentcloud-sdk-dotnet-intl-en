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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListJoinedGroupsForUserRequest : AbstractModel
    {
        
        /// <summary>
        /// Space ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Token for querying the next page of returned results. During use of the API for the first time, NextToken is not needed. When you call the API for the first time, if the total number of returned data entries exceeds the MaxResults limit, the data is truncated and only MaxResults data entries are returned. Meanwhile, the return parameter IsTruncated is true and a NextToken is returned. You can use the NextToken returned last time to continue calling the API with other request parameters unchanged, to query the truncated data. You can use this method for multiple queries until IsTruncated is false, indicating that all data has been queried.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Maximum number of data entries per page. Value range: 1-100. Default value: 10.
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
        }
    }
}

