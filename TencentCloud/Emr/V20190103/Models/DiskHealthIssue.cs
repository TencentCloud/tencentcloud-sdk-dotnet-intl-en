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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskHealthIssue : AbstractModel
    {
        
        /// <summary>
        /// <p>Disk ID.</p>
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// <p>Mounted directory.</p>
        /// </summary>
        [JsonProperty("MountDir")]
        public string MountDir{ get; set; }

        /// <summary>
        /// <p>Device path.</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>Exception type.</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public long? CheckType{ get; set; }

        /// <summary>
        /// <p>Priority.</p>
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// <p>Status.</p>
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>Probe source.</p>
        /// </summary>
        [JsonProperty("DetectSource")]
        public string DetectSource{ get; set; }

        /// <summary>
        /// <p>First probe time.</p>
        /// </summary>
        [JsonProperty("FirstDetectTime")]
        public string FirstDetectTime{ get; set; }

        /// <summary>
        /// <p>Latest probe time.</p>
        /// </summary>
        [JsonProperty("LastDetectTime")]
        public string LastDetectTime{ get; set; }

        /// <summary>
        /// <p>Probe information.</p>
        /// </summary>
        [JsonProperty("DetectDetail")]
        public string DetectDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "MountDir", this.MountDir);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "DetectSource", this.DetectSource);
            this.SetParamSimple(map, prefix + "FirstDetectTime", this.FirstDetectTime);
            this.SetParamSimple(map, prefix + "LastDetectTime", this.LastDetectTime);
            this.SetParamSimple(map, prefix + "DetectDetail", this.DetectDetail);
        }
    }
}

