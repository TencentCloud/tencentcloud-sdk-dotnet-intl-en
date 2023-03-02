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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountPrivilegeModifyInfo : AbstractModel
    {
        
        /// <summary>
        /// Database username
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Account permission change information
        /// </summary>
        [JsonProperty("DBPrivileges")]
        public DBPrivilegeModifyInfo[] DBPrivileges{ get; set; }

        /// <summary>
        /// Whether the account has the admin permission. Valid values: `true` (Yes. It is an admin account when the instance is a basic edition type and `AccountType` is `L0`; it is a privileged account when the instance is a dual-server high availability edition type and `AccountType` is `L1`.), `false` (No. The admin permission is disabled by default).
        /// </summary>
        [JsonProperty("IsAdmin")]
        public bool? IsAdmin{ get; set; }

        /// <summary>
        /// Account type, which is an extension field of `IsAdmin`. Valid values: `L0` (admin account, only for basic edition), `L1` (privileged account), `L2` (designated account), `L3` (standard account, default)
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamArrayObj(map, prefix + "DBPrivileges.", this.DBPrivileges);
            this.SetParamSimple(map, prefix + "IsAdmin", this.IsAdmin);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
        }
    }
}

