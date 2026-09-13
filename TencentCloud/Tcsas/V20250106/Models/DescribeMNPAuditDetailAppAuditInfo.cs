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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNPAuditDetailAppAuditInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Approval number.</p>
        /// </summary>
        [JsonProperty("AuditNo")]
        public string AuditNo{ get; set; }

        /// <summary>
        /// <p>Superapp ID.</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>Superapp name.</p>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// <p>Superapp icon.</p>
        /// </summary>
        [JsonProperty("ApplicationLogo")]
        public string ApplicationLogo{ get; set; }

        /// <summary>
        /// <p>Approver.</p>
        /// </summary>
        [JsonProperty("AuditUser")]
        public string AuditUser{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("AuditTime")]
        public string AuditTime{ get; set; }

        /// <summary>
        /// <p>Approval status. Valid values: 0: Pending; 1: Processing; 2: Rejected; 3: Approved; 4: Cancelled.</p>
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }

        /// <summary>
        /// <p>Approval note.</p>
        /// </summary>
        [JsonProperty("AuditNote")]
        public string AuditNote{ get; set; }

        /// <summary>
        /// <p>Team ID.</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// <p>Team name.</p>
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditNo", this.AuditNo);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationLogo", this.ApplicationLogo);
            this.SetParamSimple(map, prefix + "AuditUser", this.AuditUser);
            this.SetParamSimple(map, prefix + "AuditTime", this.AuditTime);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "AuditNote", this.AuditNote);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
        }
    }
}

