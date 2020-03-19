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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncOption : AbstractModel
    {
        
        /// <summary>
        /// Sync object. 1: entire instance; 2: specified table
        /// </summary>
        [JsonProperty("SyncObject")]
        public ulong? SyncObject{ get; set; }

        /// <summary>
        /// Sync start configuration. 1: start immediately
        /// </summary>
        [JsonProperty("RunMode")]
        public ulong? RunMode{ get; set; }

        /// <summary>
        /// Sync mode. 3: full + incremental sync
        /// </summary>
        [JsonProperty("SyncType")]
        public ulong? SyncType{ get; set; }

        /// <summary>
        /// Data consistency check. 1: no configuration required
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public ulong? ConsistencyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SyncObject", this.SyncObject);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
        }
    }
}

