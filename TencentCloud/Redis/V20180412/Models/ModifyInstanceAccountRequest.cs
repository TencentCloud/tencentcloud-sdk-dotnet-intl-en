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

    public class ModifyInstanceAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Sub-account name. If you want to change it to the root account, fill in root.
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// Sub-account password.
        /// </summary>
        [JsonProperty("AccountPassword")]
        public string AccountPassword{ get; set; }

        /// <summary>
        /// Sub-account description information
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Account read/write routing policy.
        /// - master: primary node.
        /// - replication: secondary node.
        /// </summary>
        [JsonProperty("ReadonlyPolicy")]
        public string[] ReadonlyPolicy{ get; set; }

        /// <summary>
        /// Sub-account read/write policy.
        /// - r: read-only.
        /// - w: write-only.
        /// - rw: read/write.
        /// </summary>
        [JsonProperty("Privilege")]
        public string Privilege{ get; set; }

        /// <summary>
        /// Whether to switch the root account to a password-free account. This applies only to the root account. Sub-accounts do not support password-free access.
        /// - true: Switch the root account to a password-free account.
        /// - false: Do not switch it.
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountPassword", this.AccountPassword);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "ReadonlyPolicy.", this.ReadonlyPolicy);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
        }
    }
}

