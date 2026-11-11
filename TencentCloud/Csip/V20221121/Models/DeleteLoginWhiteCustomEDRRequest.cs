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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteLoginWhiteCustomEDRRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>List of explicitly selected rule IDs, up to 1,000; mutually exclusive with SelectAll</p>
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// <p>Select all across pages: true - Delete all rules that meet Filters (Filters is required at this point). false - Delete only Ids</p>
        /// </summary>
        [JsonProperty("SelectAll")]
        public bool? SelectAll{ get; set; }

        /// <summary>
        /// <p>List of target account AppIds for multi-account, up to 1000; being empty indicates only the current account; returns InvalidParameter when input but no permissions at all</p>
        /// </summary>
        [JsonProperty("TargetAppIDs")]
        public ulong?[] TargetAppIDs{ get; set; }

        /// <summary>
        /// <p>List of excluded rule IDs, up to 1000</p>
        /// </summary>
        [JsonProperty("ExcludeIds")]
        public long?[] ExcludeIds{ get; set; }

        /// <summary>
        /// <p>Filtering criteria under select all</p>
        /// </summary>
        [JsonProperty("Filters")]
        public EDRFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
            this.SetParamArraySimple(map, prefix + "TargetAppIDs.", this.TargetAppIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeIds.", this.ExcludeIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

