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

    public class CreateBackupDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. For example, cmgo-p8vn****. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/MongoDB) and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Sets the backup method.
        /// - 0: logical backup.
        /// - 1: physical backup.
        /// - 3: snapshot backup.
        /// **Note**:
        /// 1. The General Edition instance supports logical and physical backup. The Cloud Disk Edition instance supports physical and snapshot backup, but does not support logical backup currently.
        /// 2. Physical backup is not supported when storage encryption is enabled for the instance.
        /// </summary>
        [JsonProperty("BackupMethod")]
        public long? BackupMethod{ get; set; }

        /// <summary>
        /// Backup remarks information.
        /// </summary>
        [JsonProperty("BackupRemark")]
        public string BackupRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupRemark", this.BackupRemark);
        }
    }
}

