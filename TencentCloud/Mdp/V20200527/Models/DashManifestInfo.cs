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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DashManifestInfo : AbstractModel
    {
        
        /// <summary>
        /// The total duration of each manifest in seconds. [30, 3600], type: integer, default value 60.
        /// </summary>
        [JsonProperty("Windows")]
        public long? Windows{ get; set; }

        /// <summary>
        /// The minimum cache time (in seconds) that the player keeps in the buffer. [2, 60], type: integer, default value 30.
        /// </summary>
        [JsonProperty("MinBufferTime")]
        public long? MinBufferTime{ get; set; }

        /// <summary>
        /// The minimum time (in seconds) that the player should wait before requesting an update to the manifest. [2, 60], type: integer, default value 2.
        /// </summary>
        [JsonProperty("MinUpdatePeriod")]
        public long? MinUpdatePeriod{ get; set; }

        /// <summary>
        /// The time from the latest live broadcast time point when the player starts broadcasting is a rollback amount (in seconds). [2, 60], type: integer, default value 10.
        /// </summary>
        [JsonProperty("SuggestedPresentationDelay")]
        public long? SuggestedPresentationDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Windows", this.Windows);
            this.SetParamSimple(map, prefix + "MinBufferTime", this.MinBufferTime);
            this.SetParamSimple(map, prefix + "MinUpdatePeriod", this.MinUpdatePeriod);
            this.SetParamSimple(map, prefix + "SuggestedPresentationDelay", this.SuggestedPresentationDelay);
        }
    }
}

