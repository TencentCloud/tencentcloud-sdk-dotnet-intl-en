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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetUserBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// Host private IP address
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Host public IP address
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Operating System Information
        /// </summary>
        [JsonProperty("OsInfo")]
        public string OsInfo{ get; set; }

        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Host QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Account UID
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// Account GID
        /// </summary>
        [JsonProperty("Gid")]
        public string Gid{ get; set; }

        /// <summary>
        /// Account status. 0: disabled; 1: enabled
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Whether there is root permission. 0: no; 1: yes; 999: null (Linux only)
        /// </summary>
        [JsonProperty("IsRoot")]
        public ulong? IsRoot{ get; set; }

        /// <summary>
        /// Log-in method. 0: log-in not allowed; 1: only key-based log-in allowed; 2: only password-based log-in allowed; 3: both key-based log-in and password-based log-in allowed; 999: null (Linux only)
        /// </summary>
        [JsonProperty("LoginType")]
        public ulong? LoginType{ get; set; }

        /// <summary>
        /// Last log-in time
        /// </summary>
        [JsonProperty("LastLoginTime")]
        public string LastLoginTime{ get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Host business group ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Account type. 0: guest user; 1: standard user; 2: administrator user; 999: null (Windows only)
        /// </summary>
        [JsonProperty("UserType")]
        public ulong? UserType{ get; set; }

        /// <summary>
        /// Whether a domain account. 0: no; 1: yes; 2: no; 999: null (Windows only)
        /// </summary>
        [JsonProperty("IsDomain")]
        public ulong? IsDomain{ get; set; }

        /// <summary>
        /// Whether there is sudo permissions: 1: yes; 0: No; 999: null (Linux only)
        /// </summary>
        [JsonProperty("IsSudo")]
        public ulong? IsSudo{ get; set; }

        /// <summary>
        /// Whether ssh log-in allowed. 1: yes; 0: no; 999: null (Linux only)
        /// </summary>
        [JsonProperty("IsSshLogin")]
        public ulong? IsSshLogin{ get; set; }

        /// <summary>
        /// Home directory
        /// </summary>
        [JsonProperty("HomePath")]
        public string HomePath{ get; set; }

        /// <summary>
        /// Shell path (Linux only)
        /// </summary>
        [JsonProperty("Shell")]
        public string Shell{ get; set; }

        /// <summary>
        /// Whether shell log-in allowed. 0: no; 1: yes (Linux only)
        /// </summary>
        [JsonProperty("ShellLoginStatus")]
        public ulong? ShellLoginStatus{ get; set; }

        /// <summary>
        /// Password modification time
        /// </summary>
        [JsonProperty("PasswordChangeTime")]
        public string PasswordChangeTime{ get; set; }

        /// <summary>
        /// Password expiration time (Linux only)
        /// </summary>
        [JsonProperty("PasswordDueTime")]
        public string PasswordDueTime{ get; set; }

        /// <summary>
        /// Password locking time (unit: day): -1 - never locked; 999 - null (Linux only)
        /// </summary>
        [JsonProperty("PasswordLockDays")]
        public long? PasswordLockDays{ get; set; }

        /// <summary>
        /// Password status: 1 - normal; 2 - expiring soon; 3 - expired; 4 - locked; 999 - null (Linux only)
        /// </summary>
        [JsonProperty("PasswordStatus")]
        public long? PasswordStatus{ get; set; }

        /// <summary>
        /// Update time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// First collection time
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// Whether new [0: no|1: yes]
        /// </summary>
        [JsonProperty("IsNew")]
        public long? IsNew{ get; set; }

        /// <summary>
        /// Additional information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "OsInfo", this.OsInfo);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Gid", this.Gid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsRoot", this.IsRoot);
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamSimple(map, prefix + "LastLoginTime", this.LastLoginTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "IsDomain", this.IsDomain);
            this.SetParamSimple(map, prefix + "IsSudo", this.IsSudo);
            this.SetParamSimple(map, prefix + "IsSshLogin", this.IsSshLogin);
            this.SetParamSimple(map, prefix + "HomePath", this.HomePath);
            this.SetParamSimple(map, prefix + "Shell", this.Shell);
            this.SetParamSimple(map, prefix + "ShellLoginStatus", this.ShellLoginStatus);
            this.SetParamSimple(map, prefix + "PasswordChangeTime", this.PasswordChangeTime);
            this.SetParamSimple(map, prefix + "PasswordDueTime", this.PasswordDueTime);
            this.SetParamSimple(map, prefix + "PasswordLockDays", this.PasswordLockDays);
            this.SetParamSimple(map, prefix + "PasswordStatus", this.PasswordStatus);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

