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

    public class CheckItem : AbstractModel
    {
        
        /// <summary>
        /// Check item names: CK_CPU - Post-Resizing CPU Risk Check; CK_MASTER_STORAGE - During read-only replica resizing, verify that read-only replica storage space is not less than that of the primary instance; CK_MEMORY - Post-Resizing Memory Risk Check; CK_STORAGE - Post-Resizing Storage Space Risk Check; CK_UPGRATE - Resizing Migration Requirement Check;
        /// </summary>
        [JsonProperty("CheckName")]
        public string CheckName{ get; set; }

        /// <summary>
        /// Check item return values: CK_CPU - Maximum CPU utilization (%) in the last 7 days; CK_MASTER_STORAGE - Disk space of the primary instance (GB); CK_MEMORY - Maximum memory usage (GB) in the last 7 days;
        /// 
        /// CK_STORAGE - Maximum disk usage (GB) in the last 7 days; CK_UPGRATE - Whether the current resizing check requires migration: MIGRATE indicates migration resizing is required, LOCAL indicates local resizing;
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// Check item pass status: 0 - Not passed, resizing not allowed; 1 - Passed, resizing allowed
        /// </summary>
        [JsonProperty("Passed")]
        public long? Passed{ get; set; }

        /// <summary>
        /// Whether this resizing item affects the instance: 0 - No impact; 1 - Impact exists
        /// </summary>
        [JsonProperty("IsAffect")]
        public long? IsAffect{ get; set; }

        /// <summary>
        /// Required description when impact exists or the check is not passed
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// Describe the corresponding code
        /// </summary>
        [JsonProperty("MsgCode")]
        public long? MsgCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckName", this.CheckName);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Passed", this.Passed);
            this.SetParamSimple(map, prefix + "IsAffect", this.IsAffect);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "MsgCode", this.MsgCode);
        }
    }
}

