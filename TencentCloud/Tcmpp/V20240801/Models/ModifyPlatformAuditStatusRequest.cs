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

namespace TencentCloud.Tcmpp.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPlatformAuditStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Approval ticket ID
        /// </summary>
        [JsonProperty("AuditNo")]
        public string AuditNo{ get; set; }

        /// <summary>
        /// Approval result
        /// </summary>
        [JsonProperty("AuditResult")]
        public long? AuditResult{ get; set; }

        /// <summary>
        /// Platform ID
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Approval description
        /// </summary>
        [JsonProperty("AuditNote")]
        public string AuditNote{ get; set; }

        /// <summary>
        /// Approval details
        /// </summary>
        [JsonProperty("AuditItems")]
        public AuditInfoReq[] AuditItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditNo", this.AuditNo);
            this.SetParamSimple(map, prefix + "AuditResult", this.AuditResult);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "AuditNote", this.AuditNote);
            this.SetParamArrayObj(map, prefix + "AuditItems.", this.AuditItems);
        }
    }
}

