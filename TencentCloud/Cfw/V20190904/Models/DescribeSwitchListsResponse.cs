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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSwitchListsResponse : AbstractModel
    {
        
        /// <summary>
        /// Total entries
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// List data
        /// </summary>
        [JsonProperty("Data")]
        public SwitchListsData[] Data{ get; set; }

        /// <summary>
        /// Region list
        /// </summary>
        [JsonProperty("AreaLists")]
        public string[] AreaLists{ get; set; }

        /// <summary>
        /// Number of enabled firewalls
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OnNum")]
        public ulong? OnNum{ get; set; }

        /// <summary>
        /// Number of disabled firewalls
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OffNum")]
        public ulong? OffNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArraySimple(map, prefix + "AreaLists.", this.AreaLists);
            this.SetParamSimple(map, prefix + "OnNum", this.OnNum);
            this.SetParamSimple(map, prefix + "OffNum", this.OffNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

