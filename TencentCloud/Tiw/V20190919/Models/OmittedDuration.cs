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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OmittedDuration : AbstractModel
    {
        
        /// <summary>
        /// Offset of the paused time in the spliced video, in milliseconds
        /// </summary>
        [JsonProperty("VideoTime")]
        public long? VideoTime{ get; set; }

        /// <summary>
        /// Recording pause timestamp, in milliseconds
        /// </summary>
        [JsonProperty("PauseTime")]
        public long? PauseTime{ get; set; }

        /// <summary>
        /// Recording resumption timestamp, in milliseconds
        /// </summary>
        [JsonProperty("ResumeTime")]
        public long? ResumeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoTime", this.VideoTime);
            this.SetParamSimple(map, prefix + "PauseTime", this.PauseTime);
            this.SetParamSimple(map, prefix + "ResumeTime", this.ResumeTime);
        }
    }
}

