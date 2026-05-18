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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupTotalSize : AbstractModel
    {
        
        /// <summary>
        /// Total size of full backup, in bytes
        /// </summary>
        [JsonProperty("SnapshotSize")]
        public long? SnapshotSize{ get; set; }

        /// <summary>
        /// Incremental backup total size
        /// </summary>
        [JsonProperty("OplogSize")]
        public long? OplogSize{ get; set; }

        /// <summary>
        /// free quota
        /// </summary>
        [JsonProperty("FreeQuota")]
        public long? FreeQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotSize", this.SnapshotSize);
            this.SetParamSimple(map, prefix + "OplogSize", this.OplogSize);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
        }
    }
}

