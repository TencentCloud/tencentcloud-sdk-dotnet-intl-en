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

    public class MPSEraseArea : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LeftTopX")]
        public float? LeftTopX{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LeftTopY")]
        public float? LeftTopY{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RightBottomX")]
        public float? RightBottomX{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RightBottomY")]
        public float? RightBottomY{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Unit")]
        public ulong? Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LeftTopX", this.LeftTopX);
            this.SetParamSimple(map, prefix + "LeftTopY", this.LeftTopY);
            this.SetParamSimple(map, prefix + "RightBottomX", this.RightBottomX);
            this.SetParamSimple(map, prefix + "RightBottomY", this.RightBottomY);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

