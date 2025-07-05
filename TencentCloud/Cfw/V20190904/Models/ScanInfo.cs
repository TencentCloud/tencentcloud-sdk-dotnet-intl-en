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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanInfo : AbstractModel
    {
        
        /// <summary>
        /// Scanning result information
        /// </summary>
        [JsonProperty("ScanResultInfo")]
        public ScanResultInfo ScanResultInfo{ get; set; }

        /// <summary>
        /// Scanning status. 0: scanning; 1: completed; 2: auto scanning unselected
        /// </summary>
        [JsonProperty("ScanStatus")]
        public long? ScanStatus{ get; set; }

        /// <summary>
        /// Progress
        /// </summary>
        [JsonProperty("ScanPercent")]
        public float? ScanPercent{ get; set; }

        /// <summary>
        /// Estimated completion time
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ScanResultInfo.", this.ScanResultInfo);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "ScanPercent", this.ScanPercent);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
        }
    }
}

