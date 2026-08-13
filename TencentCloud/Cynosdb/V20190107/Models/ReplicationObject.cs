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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplicationObject : AbstractModel
    {
        
        /// <summary>
        /// Source instance type
        /// </summary>
        [JsonProperty("SrcInstanceType")]
        public string SrcInstanceType{ get; set; }

        /// <summary>
        /// Source cluster Id
        /// </summary>
        [JsonProperty("SrcClusterId")]
        public string SrcClusterId{ get; set; }

        /// <summary>
        /// Source instance ID
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// Copy task ID
        /// </summary>
        [JsonProperty("ReplicationJobId")]
        public string ReplicationJobId{ get; set; }

        /// <summary>
        /// Synchronization object details
        /// </summary>
        [JsonProperty("MigrateObjects")]
        public MigrateOpt MigrateObjects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceType", this.SrcInstanceType);
            this.SetParamSimple(map, prefix + "SrcClusterId", this.SrcClusterId);
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "ReplicationJobId", this.ReplicationJobId);
            this.SetParamObj(map, prefix + "MigrateObjects.", this.MigrateObjects);
        }
    }
}

