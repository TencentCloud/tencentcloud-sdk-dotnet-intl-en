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

    public class AccountCreateInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance username
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Instance password
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// List of database permissions
        /// </summary>
        [JsonProperty("DBPrivileges")]
        public DBPrivilege[] DBPrivileges{ get; set; }

        /// <summary>
        /// Account remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Whether it is an admin account. Valid values: true (it is an admin account when the instance is a single-node type and AccountType is L0; when the instance is a two-node type and AccountType is L1), false (it is a standard account when AccountType is L3)
        /// </summary>
        [JsonProperty("IsAdmin")]
        public bool? IsAdmin{ get; set; }

        /// <summary>
        /// Valid values: `win-windows authentication`, `sql-sqlserver authentication`. Default value: `sql-sqlserver authentication`
        /// </summary>
        [JsonProperty("Authentication")]
        public string Authentication{ get; set; }

        /// <summary>
        /// Account type, which is an extension field of `IsAdmin`. Valid values: `L0` (admin account, only for basic edition), `L1` (privileged account), `L2` (designated account), `L3` (standard account, default)
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// Whether CAM authentication is enabled.
        /// </summary>
        [JsonProperty("IsCam")]
        public bool? IsCam{ get; set; }

        /// <summary>
        /// Encryption key version number. 0: disable encryption.
        /// </summary>
        [JsonProperty("EncryptedVersion")]
        public long? EncryptedVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "DBPrivileges.", this.DBPrivileges);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IsAdmin", this.IsAdmin);
            this.SetParamSimple(map, prefix + "Authentication", this.Authentication);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "IsCam", this.IsCam);
            this.SetParamSimple(map, prefix + "EncryptedVersion", this.EncryptedVersion);
        }
    }
}

