/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RealTimeSpeechStatisticsItem : AbstractModel
    {
        
        /// <summary>
        /// DAU in Mainland China
        /// </summary>
        [JsonProperty("MainLandDau")]
        public ulong? MainLandDau{ get; set; }

        /// <summary>
        /// PCU in Mainland China
        /// </summary>
        [JsonProperty("MainLandPcu")]
        public ulong? MainLandPcu{ get; set; }

        /// <summary>
        /// Total duration of use in Mainland China in minutes
        /// </summary>
        [JsonProperty("MainLandDuration")]
        public ulong? MainLandDuration{ get; set; }

        /// <summary>
        /// DAU outside Mainland China
        /// </summary>
        [JsonProperty("OverseaDau")]
        public ulong? OverseaDau{ get; set; }

        /// <summary>
        /// PCU outside Mainland China
        /// </summary>
        [JsonProperty("OverseaPcu")]
        public ulong? OverseaPcu{ get; set; }

        /// <summary>
        /// Total duration of use outside Mainland China in minutes
        /// </summary>
        [JsonProperty("OverseaDuration")]
        public ulong? OverseaDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MainLandDau", this.MainLandDau);
            this.SetParamSimple(map, prefix + "MainLandPcu", this.MainLandPcu);
            this.SetParamSimple(map, prefix + "MainLandDuration", this.MainLandDuration);
            this.SetParamSimple(map, prefix + "OverseaDau", this.OverseaDau);
            this.SetParamSimple(map, prefix + "OverseaPcu", this.OverseaPcu);
            this.SetParamSimple(map, prefix + "OverseaDuration", this.OverseaDuration);
        }
    }
}

