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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVulFixTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Repair item list. Each item specifies a vulnerability/KB patch and its hosts requiring fixing<br>Input limit: up to 100 items, and the total number of instances cannot exceed 5000</p>
        /// </summary>
        [JsonProperty("FixItems")]
        public VulFixItem[] FixItems{ get; set; }

        /// <summary>
        /// <p>Maximum repair time<br>Unit: second<br>Default value: 3600</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>Create a disk snapshot before repair<br>Default value: false</p>
        /// </summary>
        [JsonProperty("CreateSnapshot")]
        public bool? CreateSnapshot{ get; set; }

        /// <summary>
        /// <p>Snapshot name. Valid when CreateSnapshot is true. Input limits: up to 60 characters, with automatic truncation for overly long ones.</p>
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// <p>Snapshot retention days. Valid when CreateSnapshot is true</p>
        /// </summary>
        [JsonProperty("SaveDays")]
        public long? SaveDays{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FixItems.", this.FixItems);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "CreateSnapshot", this.CreateSnapshot);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "SaveDays", this.SaveDays);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

