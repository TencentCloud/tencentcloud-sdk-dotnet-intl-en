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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdditionalRateSetting : AbstractModel
    {
        
        /// <summary>
        /// The maximum bitrate in the VBR scenario must be a multiple of 1000 and between 50000 and 40000000.
        /// </summary>
        [JsonProperty("VideoMaxBitrate")]
        public ulong? VideoMaxBitrate{ get; set; }

        /// <summary>
        /// Cache configuration supports configuration as 1-4x the Max Bitrate value.
        /// </summary>
        [JsonProperty("BufferSize")]
        public ulong? BufferSize{ get; set; }

        /// <summary>
        /// Valid in VBR scenarios. Video quality level. Only supports user input of numbers between 1 and 51.
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

