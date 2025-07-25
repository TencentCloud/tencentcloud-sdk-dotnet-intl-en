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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordCountInfo : AbstractModel
    {
        
        /// <summary>
        /// The subdomain count.
        /// </summary>
        [JsonProperty("SubdomainCount")]
        public ulong? SubdomainCount{ get; set; }

        /// <summary>
        /// The count of records returned in the list.
        /// </summary>
        [JsonProperty("ListCount")]
        public ulong? ListCount{ get; set; }

        /// <summary>
        /// The total record count.
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubdomainCount", this.SubdomainCount);
            this.SetParamSimple(map, prefix + "ListCount", this.ListCount);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

