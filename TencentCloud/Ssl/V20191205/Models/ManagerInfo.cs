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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagerInfo : AbstractModel
    {
        
        /// <summary>
        /// Status: audit: under review ok: pass invalid: invalid expiring: expiring soon expired: expired
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Manager name
        /// </summary>
        [JsonProperty("ManagerFirstName")]
        public string ManagerFirstName{ get; set; }

        /// <summary>
        /// Manager name
        /// </summary>
        [JsonProperty("ManagerLastName")]
        public string ManagerLastName{ get; set; }

        /// <summary>
        /// manager position
        /// </summary>
        [JsonProperty("ManagerPosition")]
        public string ManagerPosition{ get; set; }

        /// <summary>
        /// Manager phone
        /// </summary>
        [JsonProperty("ManagerPhone")]
        public string ManagerPhone{ get; set; }

        /// <summary>
        /// Manager mailbox
        /// </summary>
        [JsonProperty("ManagerMail")]
        public string ManagerMail{ get; set; }

        /// <summary>
        /// department of the manager
        /// </summary>
        [JsonProperty("ManagerDepartment")]
        public string ManagerDepartment{ get; set; }

        /// <summary>
        /// Creation time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Number of domains for manager
        /// </summary>
        [JsonProperty("DomainCount")]
        public long? DomainCount{ get; set; }

        /// <summary>
        /// Number of manager certificates
        /// </summary>
        [JsonProperty("CertCount")]
        public long? CertCount{ get; set; }

        /// <summary>
        /// Manager ID
        /// </summary>
        [JsonProperty("ManagerId")]
        public long? ManagerId{ get; set; }

        /// <summary>
        /// Review valid expiry time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Last submission review time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubmitAuditTime")]
        public string SubmitAuditTime{ get; set; }

        /// <summary>
        /// Approval Time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyTime")]
        public string VerifyTime{ get; set; }

        /// <summary>
        /// Review status info
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusInfo")]
        public ManagerStatusInfo[] StatusInfo{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ManagerFirstName", this.ManagerFirstName);
            this.SetParamSimple(map, prefix + "ManagerLastName", this.ManagerLastName);
            this.SetParamSimple(map, prefix + "ManagerPosition", this.ManagerPosition);
            this.SetParamSimple(map, prefix + "ManagerPhone", this.ManagerPhone);
            this.SetParamSimple(map, prefix + "ManagerMail", this.ManagerMail);
            this.SetParamSimple(map, prefix + "ManagerDepartment", this.ManagerDepartment);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DomainCount", this.DomainCount);
            this.SetParamSimple(map, prefix + "CertCount", this.CertCount);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "SubmitAuditTime", this.SubmitAuditTime);
            this.SetParamSimple(map, prefix + "VerifyTime", this.VerifyTime);
            this.SetParamArrayObj(map, prefix + "StatusInfo.", this.StatusInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

