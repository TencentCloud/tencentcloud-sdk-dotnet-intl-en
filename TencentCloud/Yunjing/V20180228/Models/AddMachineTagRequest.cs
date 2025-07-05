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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddMachineTagRequest : AbstractModel
    {
        
        /// <summary>
        /// Server ID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Tag ID
        /// </summary>
        [JsonProperty("TagId")]
        public ulong? TagId{ get; set; }

        /// <summary>
        /// Server region
        /// </summary>
        [JsonProperty("MRegion")]
        public string MRegion{ get; set; }

        /// <summary>
        /// Server type (`CVM` or `BM`)
        /// </summary>
        [JsonProperty("MArea")]
        public string MArea{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "TagId", this.TagId);
            this.SetParamSimple(map, prefix + "MRegion", this.MRegion);
            this.SetParamSimple(map, prefix + "MArea", this.MArea);
        }
    }
}

