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

    public class PipelineInputStatistics : AbstractModel
    {
        
        /// <summary>
        /// Data timestamp in seconds.
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// Input bandwidth in bps.
        /// </summary>
        [JsonProperty("NetworkIn")]
        public ulong? NetworkIn{ get; set; }

        /// <summary>
        /// Video information array.
        /// For `rtp/udp` input, the quantity is the number of `Pid` of the input video.
        /// For other inputs, the quantity is 1.
        /// </summary>
        [JsonProperty("Video")]
        public VideoPipelineInputStatistics[] Video{ get; set; }

        /// <summary>
        /// Audio information array.
        /// For `rtp/udp` input, the quantity is the number of `Pid` of the input audio.
        /// For other inputs, the quantity is 1.
        /// </summary>
        [JsonProperty("Audio")]
        public AudioPipelineInputStatistics[] Audio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "NetworkIn", this.NetworkIn);
            this.SetParamArrayObj(map, prefix + "Video.", this.Video);
            this.SetParamArrayObj(map, prefix + "Audio.", this.Audio);
        }
    }
}

