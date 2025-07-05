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

    public class AccountDetail : AbstractModel
    {
        
        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Account remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Account creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Account status. 1: creating, 2: normal, 3: modifying, 4: resetting password, -1: deleting
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Account update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Password update time
        /// </summary>
        [JsonProperty("PassTime")]
        public string PassTime{ get; set; }

        /// <summary>
        /// Internal account status, which should be `enable` normally
        /// </summary>
        [JsonProperty("InternalStatus")]
        public string InternalStatus{ get; set; }

        /// <summary>
        /// Information of read and write permissions of this account on relevant databases
        /// </summary>
        [JsonProperty("Dbs")]
        public DBPrivilege[] Dbs{ get; set; }

        /// <summary>
        /// Whether it is an admin account
        /// </summary>
        [JsonProperty("IsAdmin")]
        public bool? IsAdmin{ get; set; }

        /// <summary>
        /// Whether it is a CAM managed account
        /// </summary>
        [JsonProperty("IsCam")]
        public bool? IsCam{ get; set; }

        /// <summary>
        /// Valid values: `win-windows authentication`, `sql-sqlserver authentication`.
        /// </summary>
        [JsonProperty("Authentication")]
        public string Authentication{ get; set; }

        /// <summary>
        /// The host required for `win-windows authentication` account
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Account type. Valid values: `L0` (admin account, only for basic edition), `L1` (privileged account), `L2` (designated account), `L3` (standard account).
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "PassTime", this.PassTime);
            this.SetParamSimple(map, prefix + "InternalStatus", this.InternalStatus);
            this.SetParamArrayObj(map, prefix + "Dbs.", this.Dbs);
            this.SetParamSimple(map, prefix + "IsAdmin", this.IsAdmin);
            this.SetParamSimple(map, prefix + "IsCam", this.IsCam);
            this.SetParamSimple(map, prefix + "Authentication", this.Authentication);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
        }
    }
}

