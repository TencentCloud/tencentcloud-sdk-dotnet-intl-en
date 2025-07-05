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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosBackup : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable auto-backup to COS
        /// </summary>
        [JsonProperty("IsAutoBackup")]
        public bool? IsAutoBackup{ get; set; }

        /// <summary>
        /// Auto-backup time (accurate down to the hour), such as "22:00"
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsAutoBackup", this.IsAutoBackup);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
        }
    }
}

