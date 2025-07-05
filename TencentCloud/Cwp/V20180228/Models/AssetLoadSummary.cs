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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetLoadSummary : AbstractModel
    {
        
        /// <summary>
        /// Load amount array, in ascending order:
        /// [
        /// 0% or unknown quantity
        /// 0%～20%
        /// 20%～50%
        /// 50%～80%
        /// 80%～100%
        /// ]
        /// </summary>
        [JsonProperty("Counts")]
        public ulong?[] Counts{ get; set; }

        /// <summary>
        /// Top 5 Load
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Top5")]
        public AssetLoadDetail[] Top5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Counts.", this.Counts);
            this.SetParamArrayObj(map, prefix + "Top5.", this.Top5);
        }
    }
}

