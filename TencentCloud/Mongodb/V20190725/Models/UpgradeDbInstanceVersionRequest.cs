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

    public class UpgradeDbInstanceVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// List of instance IDs, which are in the format of cmgo-p8vnipr5. It is the same as the format of the instance ID displayed on the TencentDB for MongoDB console page.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The newly upgraded database version. Currently supported versions are as follows. Upgrade from an earlier version to a high version is supported. Cross-version upgrade is not supported.
        /// - MONGO_40_WT: Version 4.0.
        /// - MONGO_42_WT: Version 4.2.
        /// - MONGO_44_WT: Version 4.4.
        /// - MONGO_50_WT: Version 5.0.
        /// - MONGO_60_WT: Version 6.0.
        /// -MONGO_70_WT: Version 7.0.
        /// - MONGO_80_WT: Version 8.0.
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// Specify whether to perform the upgrade during the maintenance period.
        /// -0: Upgrade now.
        /// - 1: Upgrade during the maintenance window.
        /// </summary>
        [JsonProperty("InMaintenance")]
        public long? InMaintenance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "InMaintenance", this.InMaintenance);
        }
    }
}

