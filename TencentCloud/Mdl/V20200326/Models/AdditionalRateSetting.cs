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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdditionalRateSetting : AbstractModel
    {
        
        /// <summary>
        /// The maximum bit rate in a VBR scenario must be a multiple of 1000 and between 50000 - 40000000.
        /// </summary>
        [JsonProperty("VideoMaxBitrate")]
        public ulong? VideoMaxBitrate{ get; set; }

        /// <summary>
        /// Cache configuration supports configuring a Max Bitrate value of 1-4 times.
        /// </summary>
        [JsonProperty("BufferSize")]
        public ulong? BufferSize{ get; set; }

        /// <summary>
        /// VBR scene is valid, video quality level, only supports user input numbers between 1-51.
        /// </summary>
        [JsonProperty("QualityLevel")]
        public ulong? QualityLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoMaxBitrate", this.VideoMaxBitrate);
            this.SetParamSimple(map, prefix + "BufferSize", this.BufferSize);
            this.SetParamSimple(map, prefix + "QualityLevel", this.QualityLevel);
        }
    }
}

