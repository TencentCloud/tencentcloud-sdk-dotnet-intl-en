/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateInstanceAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Custom account name for accessing the database.
        /// - It contains only letters, digits, underscores (_), and hyphens (-).
        /// - The length cannot exceed 32 characters.
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// Password of the custom account. The password complexity requirements are as follows:
        /// - It can contain 8 to 64 characters.
        /// - It should contain at least two of the following types: lowercase letters, uppercase letters, digits, and special characters (such as ()`~!@#$%^&*-+=_|{}[]:;<>,.?/).
        /// - It cannot start with a forward slash (/).
        /// </summary>
        [JsonProperty("AccountPassword")]
        public string AccountPassword{ get; set; }

        /// <summary>
        /// The read requests for the designated account are routed to either the master node or replica nodes. If the Read-Only Replica is not enabled, the selection of replica nodes is not supported.
        /// - master: Master node.- replication: Replica node.
        /// </summary>
        [JsonProperty("ReadonlyPolicy")]
        public string[] ReadonlyPolicy{ get; set; }

        /// <summary>
        /// The read/write permission of the account supports the selection of read-only and read/write permissions.
        /// - r: read-only
        /// - rw: Read/Write permission.
        /// </summary>
        [JsonProperty("Privilege")]
        public string Privilege{ get; set; }

        /// <summary>
        /// Sub-account description information, with a length of [0, 64] bytes, supports Chinese characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountPassword", this.AccountPassword);
            this.SetParamArraySimple(map, prefix + "ReadonlyPolicy.", this.ReadonlyPolicy);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

