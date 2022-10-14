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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSnapshotRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the cloud disk for which to create a snapshot, which can be queried through the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Snapshot name. If it is not specified, "Unnamed" will be used by default.
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// Expiration time of the snapshot. It must be in UTC ISO-8601 format, such as 2022-01-08T09:47:55+00:00. The snapshot will be automatically deleted when it expires.
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// ID of the cloud disk backup point. When this parameter is specified, the snapshot will be created from the backup point.
        /// </summary>
        [JsonProperty("DiskBackupId")]
        public string DiskBackupId{ get; set; }

        /// <summary>
        /// Tags bound to the snapshot.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "DiskBackupId", this.DiskBackupId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

