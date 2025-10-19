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

    public class CreateBackupDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Name of the backup file to be downloaded. The [DescribeDBBackups](https://www.tencentcloud.comom/document/product/240/38574?from_cn_redirect=1) API can be called to obtain it.
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// Specifies the node ID of the replica set to be downloaded or the shard node ID list of the sharded cluster.
        /// - If the replica set instance ID is cmgo-p8vnipr5, for example, BackupSets.0=cmgo-p8vnipr5_0, full data can be downloaded.
        /// - If the sharded cluster instance ID is cmgo-p8vnipr5, for example, BackupSets.0=cmgo-p8vnipr5_0&BackupSets.1=cmgo-p8vnipr5_1, download the data of Shard 0 and Shard 1. If a full download is needed for the sharded cluster, import all shard names as shown in the example.
        /// </summary>
        [JsonProperty("BackupSets")]
        public ReplicaSetInfo[] BackupSets{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamArrayObj(map, prefix + "BackupSets.", this.BackupSets);
        }
    }
}

