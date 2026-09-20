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

    public class PersistenceCompleteTask : AbstractModel
    {
        
        /// <summary>
        /// The generated media ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Sources of clipping solidification include the following three types.
        /// <li>SimpleHlsClip: comes from simple HLS edit;</li>
        /// <li>FastEditMedia: comes from rapid media editing;</li>
        /// <li>LiveRealTimeClip: comes from live stream clipping.</li>
        /// </summary>
        [JsonProperty("PersistenceSource")]
        public string PersistenceSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "PersistenceSource", this.PersistenceSource);
        }
    }
}

