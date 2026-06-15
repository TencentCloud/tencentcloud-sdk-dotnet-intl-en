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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CoverStaffInfo : AbstractModel
    {
        
        /// <summary>
        /// Shift personnel ID group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverStaffIDs")]
        public string[] CoverStaffIDs{ get; set; }

        /// <summary>
        /// Shift start time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverStartTime")]
        public long? CoverStartTime{ get; set; }

        /// <summary>
        /// Shift end time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverEndTime")]
        public long? CoverEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CoverStaffIDs.", this.CoverStaffIDs);
            this.SetParamSimple(map, prefix + "CoverStartTime", this.CoverStartTime);
            this.SetParamSimple(map, prefix + "CoverEndTime", this.CoverEndTime);
        }
    }
}

