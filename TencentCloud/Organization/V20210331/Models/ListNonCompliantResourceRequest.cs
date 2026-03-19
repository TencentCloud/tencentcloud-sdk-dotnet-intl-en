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

    public class ListNonCompliantResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// Limit. Value range: 1–50.
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }

        /// <summary>
        /// Member UIN.
        /// </summary>
        [JsonProperty("MemberUin")]
        public ulong? MemberUin{ get; set; }

        /// <summary>
        /// Token value obtained from the previous page response.
        /// If it is the first request, set to empty.
        /// </summary>
        [JsonProperty("PaginationToken")]
        public string PaginationToken{ get; set; }

        /// <summary>
        /// Tag key.
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "PaginationToken", this.PaginationToken);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
        }
    }
}

