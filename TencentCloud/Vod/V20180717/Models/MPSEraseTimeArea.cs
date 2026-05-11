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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MPSEraseTimeArea : AbstractModel
    {
        
        /// <summary>
        /// <p>Start time, unit: ms</p>
        /// </summary>
        [JsonProperty("BeginMs")]
        public ulong? BeginMs{ get; set; }

        /// <summary>
        /// <p>End time, unit: ms</p>
        /// </summary>
        [JsonProperty("EndMs")]
        public ulong? EndMs{ get; set; }

        /// <summary>
        /// <p>Domain list for erasure within the period</p>
        /// </summary>
        [JsonProperty("Areas")]
        public MPSEraseArea[] Areas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginMs", this.BeginMs);
            this.SetParamSimple(map, prefix + "EndMs", this.EndMs);
            this.SetParamArrayObj(map, prefix + "Areas.", this.Areas);
        }
    }
}

