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

    public class ZoneConf : AbstractModel
    {
        
        /// <summary>
        /// AZ deployment mode. Value range: 0 (single-AZ), 1 (multi-AZ)
        /// </summary>
        [JsonProperty("DeployMode")]
        public long?[] DeployMode{ get; set; }

        /// <summary>
        /// AZ where the primary instance is located
        /// </summary>
        [JsonProperty("MasterZone")]
        public string[] MasterZone{ get; set; }

        /// <summary>
        /// AZ where salve database 1 is located when the instance is deployed in multi-AZ mode
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string[] SlaveZone{ get; set; }

        /// <summary>
        /// AZ where salve database 2 is located when the instance is deployed in multi-AZ mode
        /// </summary>
        [JsonProperty("BackupZone")]
        public string[] BackupZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DeployMode.", this.DeployMode);
            this.SetParamArraySimple(map, prefix + "MasterZone.", this.MasterZone);
            this.SetParamArraySimple(map, prefix + "SlaveZone.", this.SlaveZone);
            this.SetParamArraySimple(map, prefix + "BackupZone.", this.BackupZone);
        }
    }
}

