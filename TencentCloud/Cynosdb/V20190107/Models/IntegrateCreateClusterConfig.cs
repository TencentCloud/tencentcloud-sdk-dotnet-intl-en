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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntegrateCreateClusterConfig : AbstractModel
    {
        
        /// <summary>
        /// Retention days of binlog. value range: 7-1830.
        /// </summary>
        [JsonProperty("BinlogSaveDays")]
        public long? BinlogSaveDays{ get; set; }

        /// <summary>
        /// Specifies the backup retention days. value range: 7-1830.
        /// </summary>
        [JsonProperty("BackupSaveDays")]
        public long? BackupSaveDays{ get; set; }

        /// <summary>
        /// Specifies the semi-sync timeout period. value range: [1000,4294967295].
        /// </summary>
        [JsonProperty("SemiSyncTimeout")]
        public long? SemiSyncTimeout{ get; set; }

        /// <summary>
        /// proxy connection address configuration message.
        /// </summary>
        [JsonProperty("ProxyEndPointConfigs")]
        public ProxyEndPointConfigInfo[] ProxyEndPointConfigs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BinlogSaveDays", this.BinlogSaveDays);
            this.SetParamSimple(map, prefix + "BackupSaveDays", this.BackupSaveDays);
            this.SetParamSimple(map, prefix + "SemiSyncTimeout", this.SemiSyncTimeout);
            this.SetParamArrayObj(map, prefix + "ProxyEndPointConfigs.", this.ProxyEndPointConfigs);
        }
    }
}

