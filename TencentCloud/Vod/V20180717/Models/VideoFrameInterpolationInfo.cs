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

    public class VideoFrameInterpolationInfo : AbstractModel
    {
        
        /// <summary>
        /// Intelligent frame interpolation control switch. Valid values:
        /// <li>ON: enable intelligent frame interpolation;</li>
        /// <li>OFF: disables intelligent frame interpolation.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Intelligent frame interpolation frame rate. Frame rate range: (0, 100]. Valid only when the intelligent frame interpolation control switch is ON. Default: same as the source file frame rate.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
        }
    }
}

