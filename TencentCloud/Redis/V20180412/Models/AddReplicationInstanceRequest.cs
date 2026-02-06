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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddReplicationInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Replication group ID. Log in to the [global replication](https://console.tencentcloud.com/redis/replication) page of the Redis console and obtain it.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Instance ID.
        /// - There are region and AZ limitations for adding a replication group instance. For detailed information, see [Use Limits](https://www.tencentcloud.com/document/product/239/71934?from_cn_redirect=1).
        /// - Currently, only Redis 4.0 and 5.0 cluster architecture instances support being added to the replication groups.
        /// - Log in to the [Redis console](https://console.cloud.tencent.com/redis/instance/list), and copy the ID of the instance that needs to be added to the replication group in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Assigns roles to instances added to the replication group. <ul><li>rw: read-write;</li> <li>r: read-only.</li></ul>
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
        }
    }
}

