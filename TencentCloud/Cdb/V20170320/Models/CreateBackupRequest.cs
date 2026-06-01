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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackupRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed on the TencentDB Console page.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Target backup method. Valid values: `logical` (logical cold backup), `physical` (physical cold backup), `snapshot` (snapshot backup). Basic Edition instances only support snapshot backups.
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// Database table information to be backed up. If this parameter is not set, the whole instance is backed up by default. This parameter can only be set when BackupMethod=logical. The specified database and tables must exist. Otherwise, backup may fail.
        /// If necessary to back up tables tb1 and tb2 in database db1 and database db2, configure the parameter as [{"Db": "db1", "Table": "tb1"}, {"Db": "db1", "Table": "tb2"}, {"Db": "db2"}].
        /// </summary>
        [JsonProperty("BackupDBTableList")]
        public BackupItem[] BackupDBTableList{ get; set; }

        /// <summary>
        /// Manually back up the alias. Keep the input length within 60 characters.
        /// </summary>
        [JsonProperty("ManualBackupName")]
        public string ManualBackupName{ get; set; }

        /// <summary>
        /// Whether the physical backup needs encryption, optional values: on - yes, off - no. This value is meaningful only when BackupMethod is physical. If not specified, use the default encryption policy of instance backup. Here, the default encryption policy refers to the current instance encryption policy queried via the api for the query [DescribeBackupEncryptionStatus](https://www.tencentcloud.com/document/product/236/86508?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("EncryptionFlag")]
        public string EncryptionFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamArrayObj(map, prefix + "BackupDBTableList.", this.BackupDBTableList);
            this.SetParamSimple(map, prefix + "ManualBackupName", this.ManualBackupName);
            this.SetParamSimple(map, prefix + "EncryptionFlag", this.EncryptionFlag);
        }
    }
}

