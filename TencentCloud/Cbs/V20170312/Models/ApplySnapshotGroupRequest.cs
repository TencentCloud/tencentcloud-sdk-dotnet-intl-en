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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplySnapshotGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the snapshot group ID rolled back.
        /// </summary>
        [JsonProperty("SnapshotGroupId")]
        public string SnapshotGroupId{ get; set; }

        /// <summary>
        /// Specifies the snapshot ID associated with the rollback snapshot group and the original cloud disk ID list of the corresponding snapshot.
        /// </summary>
        [JsonProperty("ApplyDisks")]
        public ApplyDisk[] ApplyDisks{ get; set; }

        /// <summary>
        /// Specifies whether to perform automatic shutdown before rollback.
        /// </summary>
        [JsonProperty("AutoStopInstance")]
        public bool? AutoStopInstance{ get; set; }

        /// <summary>
        /// Specifies whether to automatically start after completion.
        /// </summary>
        [JsonProperty("AutoStartInstance")]
        public bool? AutoStartInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotGroupId", this.SnapshotGroupId);
            this.SetParamArrayObj(map, prefix + "ApplyDisks.", this.ApplyDisks);
            this.SetParamSimple(map, prefix + "AutoStopInstance", this.AutoStopInstance);
            this.SetParamSimple(map, prefix + "AutoStartInstance", this.AutoStartInstance);
        }
    }
}

