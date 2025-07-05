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

    public class ModifyRemoteBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed in the TencentDB console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Remote data backup. Valid values:`off` (disable), `on` (enable).
        /// </summary>
        [JsonProperty("RemoteBackupSave")]
        public string RemoteBackupSave{ get; set; }

        /// <summary>
        /// Remote log backup. Valid values: `off` (disable), `on` (enable). Only when the parameter `RemoteBackupSave` is `on`, the `RemoteBinlogSave` parameter can be set to `on`.
        /// </summary>
        [JsonProperty("RemoteBinlogSave")]
        public string RemoteBinlogSave{ get; set; }

        /// <summary>
        /// The custom backup region list
        /// </summary>
        [JsonProperty("RemoteRegion")]
        public string[] RemoteRegion{ get; set; }

        /// <summary>
        /// Remote backup retention period in days
        /// </summary>
        [JsonProperty("ExpireDays")]
        public long? ExpireDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RemoteBackupSave", this.RemoteBackupSave);
            this.SetParamSimple(map, prefix + "RemoteBinlogSave", this.RemoteBinlogSave);
            this.SetParamArraySimple(map, prefix + "RemoteRegion.", this.RemoteRegion);
            this.SetParamSimple(map, prefix + "ExpireDays", this.ExpireDays);
        }
    }
}

