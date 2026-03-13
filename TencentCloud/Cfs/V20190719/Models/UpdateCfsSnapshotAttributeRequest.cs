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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateCfsSnapshotAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Snapshot ID, which can be obtained by querying through the [DescribeCfsSnapshots](https://www.tencentcloud.com/document/api/582/80206?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// File system snapshot name, must fill in either this or AliveDays. snapshot name supports no more than 64 characters in length, supports chinese, numbers, _, and -.
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// File system snapshot retention days. either this or SnapshotName must be specified. if the original setting has permanent retention attribute, it is not allowed to be modified to short-term validity.
        /// </summary>
        [JsonProperty("AliveDays")]
        public ulong? AliveDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "AliveDays", this.AliveDays);
        }
    }
}

