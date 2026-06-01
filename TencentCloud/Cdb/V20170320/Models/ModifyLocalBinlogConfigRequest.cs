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

    public class ModifyLocalBinlogConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, in the format such as cdb-c1nl9rpv. This matches the instance ID displayed on the TencentDB console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Local binlog retention duration. Values for different instances are as follows:
        /// 1. The local binlog retention duration (hr) for cloud disk edition instances, dual-node instances, and three-node instances defaults to 120, with a range of 6 - 168.
        /// 2. The retention duration of local binlog for disaster recovery instance defaults to 120 hr, with a range of 120 - 168.
        /// 3. The retention duration (hr) of local binlog for a single-node cloud disk instance defaults to 120, with a range of 0 - 168.
        /// 4. If a dual-node instance or three-node instance has no disaster recovery instance, the retention duration (hr) of local binlog for the primary instance ranges from 6 to 168. If a dual-node instance or three-node instance has a disaster recovery instance, or you want to add a disaster recovery instance to a dual-node instance or three-node instance, to avoid synchronization exception, the retention duration (hr) of local binlog for the primary instance cannot be set to less than 120 hr, ranging from 120 to 168.
        /// </summary>
        [JsonProperty("SaveHours")]
        public long? SaveHours{ get; set; }

        /// <summary>
        /// Local binlog space utilization. Valid values: [30,50].
        /// </summary>
        [JsonProperty("MaxUsage")]
        public long? MaxUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SaveHours", this.SaveHours);
            this.SetParamSimple(map, prefix + "MaxUsage", this.MaxUsage);
        }
    }
}

