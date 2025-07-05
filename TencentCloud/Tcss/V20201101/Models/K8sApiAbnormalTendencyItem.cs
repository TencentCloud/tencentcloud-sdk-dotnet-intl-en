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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class K8sApiAbnormalTendencyItem : AbstractModel
    {
        
        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// The number of abnormal UA request events
        /// </summary>
        [JsonProperty("ExceptionUARequestCount")]
        public ulong? ExceptionUARequestCount{ get; set; }

        /// <summary>
        /// The number of anonymous user permission events
        /// </summary>
        [JsonProperty("AnonymousUserRightCount")]
        public ulong? AnonymousUserRightCount{ get; set; }

        /// <summary>
        /// The number of credential information acquisition events
        /// </summary>
        [JsonProperty("CredentialInformationObtainCount")]
        public ulong? CredentialInformationObtainCount{ get; set; }

        /// <summary>
        /// The number of sensitive data mounting events
        /// </summary>
        [JsonProperty("SensitiveDataMountCount")]
        public ulong? SensitiveDataMountCount{ get; set; }

        /// <summary>
        /// The number of command execution events
        /// </summary>
        [JsonProperty("CmdExecCount")]
        public ulong? CmdExecCount{ get; set; }

        /// <summary>
        /// The number of abnormal scheduled task events
        /// </summary>
        [JsonProperty("AbnormalScheduledTaskCount")]
        public ulong? AbnormalScheduledTaskCount{ get; set; }

        /// <summary>
        /// The number of static pods created
        /// </summary>
        [JsonProperty("StaticsPodCreateCount")]
        public ulong? StaticsPodCreateCount{ get; set; }

        /// <summary>
        /// The number of suspicious containers created
        /// </summary>
        [JsonProperty("DoubtfulContainerCreateCount")]
        public ulong? DoubtfulContainerCreateCount{ get; set; }

        /// <summary>
        /// The number of custom rule events
        /// </summary>
        [JsonProperty("UserDefinedRuleCount")]
        public ulong? UserDefinedRuleCount{ get; set; }

        /// <summary>
        /// The number of anonymous access events
        /// </summary>
        [JsonProperty("AnonymousAccessCount")]
        public ulong? AnonymousAccessCount{ get; set; }

        /// <summary>
        /// The number of privilege container events
        /// </summary>
        [JsonProperty("PrivilegeContainerCount")]
        public ulong? PrivilegeContainerCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "ExceptionUARequestCount", this.ExceptionUARequestCount);
            this.SetParamSimple(map, prefix + "AnonymousUserRightCount", this.AnonymousUserRightCount);
            this.SetParamSimple(map, prefix + "CredentialInformationObtainCount", this.CredentialInformationObtainCount);
            this.SetParamSimple(map, prefix + "SensitiveDataMountCount", this.SensitiveDataMountCount);
            this.SetParamSimple(map, prefix + "CmdExecCount", this.CmdExecCount);
            this.SetParamSimple(map, prefix + "AbnormalScheduledTaskCount", this.AbnormalScheduledTaskCount);
            this.SetParamSimple(map, prefix + "StaticsPodCreateCount", this.StaticsPodCreateCount);
            this.SetParamSimple(map, prefix + "DoubtfulContainerCreateCount", this.DoubtfulContainerCreateCount);
            this.SetParamSimple(map, prefix + "UserDefinedRuleCount", this.UserDefinedRuleCount);
            this.SetParamSimple(map, prefix + "AnonymousAccessCount", this.AnonymousAccessCount);
            this.SetParamSimple(map, prefix + "PrivilegeContainerCount", this.PrivilegeContainerCount);
        }
    }
}

