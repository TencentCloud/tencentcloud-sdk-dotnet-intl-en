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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVulFixRequest : AbstractModel
    {
        
        /// <summary>
        /// List of hosts for which the vulnerability should be fixed
        /// </summary>
        [JsonProperty("CreateVulFixTaskQuuids")]
        public CreateVulFixTaskQuuids[] CreateVulFixTaskQuuids{ get; set; }

        /// <summary>
        /// Snapshot retention days: 0 days indicates that no snapshot will be created. Hosts without a snapshot for 24 hours must have a snapshot created to be restored.
        /// </summary>
        [JsonProperty("SaveDays")]
        public ulong? SaveDays{ get; set; }

        /// <summary>
        /// Snapshot name
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CreateVulFixTaskQuuids.", this.CreateVulFixTaskQuuids);
            this.SetParamSimple(map, prefix + "SaveDays", this.SaveDays);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
        }
    }
}

