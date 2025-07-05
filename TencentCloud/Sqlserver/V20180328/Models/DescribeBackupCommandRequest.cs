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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// Backup file type. Full: full backup. FULL_LOG: full backup which needs log increments. FULL_DIFF: full backup which needs differential increments. LOG: log backup. DIFF: differential backup.
        /// </summary>
        [JsonProperty("BackupFileType")]
        public string BackupFileType{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("DataBaseName")]
        public string DataBaseName{ get; set; }

        /// <summary>
        /// Whether restoration is required. No: not required. Yes: required.
        /// </summary>
        [JsonProperty("IsRecovery")]
        public string IsRecovery{ get; set; }

        /// <summary>
        /// Storage path of backup files. If this parameter is left empty, the default storage path will be D:\\.
        /// </summary>
        [JsonProperty("LocalPath")]
        public string LocalPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupFileType", this.BackupFileType);
            this.SetParamSimple(map, prefix + "DataBaseName", this.DataBaseName);
            this.SetParamSimple(map, prefix + "IsRecovery", this.IsRecovery);
            this.SetParamSimple(map, prefix + "LocalPath", this.LocalPath);
        }
    }
}

