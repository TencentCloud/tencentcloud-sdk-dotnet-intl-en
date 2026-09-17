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

    public class AudioEnhanceConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Denoise")]
        public AudioDenoiseInfo Denoise{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Separate")]
        public AudioSeparateInfo Separate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VolumeBalance")]
        public AudioVolumeBalanceInfo VolumeBalance{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Beautify")]
        public AudioBeautifyInfo Beautify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Denoise.", this.Denoise);
            this.SetParamObj(map, prefix + "Separate.", this.Separate);
            this.SetParamObj(map, prefix + "VolumeBalance.", this.VolumeBalance);
            this.SetParamObj(map, prefix + "Beautify.", this.Beautify);
        }
    }
}

