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

    public class DescribeMNPApprovalListData : AbstractModel
    {
        
        /// <summary>
        /// Approval ticket ID
        /// </summary>
        [JsonProperty("ApprovalNo")]
        public string ApprovalNo{ get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Approval status. valid values: 1 (processing), 2 (rejected), 3 (approved), 4 (cancelled).
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// Mini program ID
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// Mini program version.
        /// </summary>
        [JsonProperty("MNPVersion")]
        public string MNPVersion{ get; set; }

        /// <summary>
        /// Mini program version ID
        /// </summary>
        [JsonProperty("MNPVersionId")]
        public long? MNPVersionId{ get; set; }

        /// <summary>
        /// Applicant
        /// </summary>
        [JsonProperty("ApplyUser")]
        public string ApplyUser{ get; set; }

        /// <summary>
        /// Application time
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// Mini program name
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// Mini program icon
        /// </summary>
        [JsonProperty("MNPIcon")]
        public string MNPIcon{ get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Specifies the application icon.
        /// </summary>
        [JsonProperty("ApplicationLogo")]
        public string ApplicationLogo{ get; set; }

        /// <summary>
        /// Team ID
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// Team name
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// Mini program review qr code.
        /// </summary>
        [JsonProperty("MNPQrCodeUrl")]
        public string MNPQrCodeUrl{ get; set; }

        /// <summary>
        /// Mini program type
        /// </summary>
        [JsonProperty("MNPType")]
        public string MNPType{ get; set; }

        /// <summary>
        /// Specifies the reviewer.
        /// </summary>
        [JsonProperty("ApprovalUser")]
        public string ApprovalUser{ get; set; }

        /// <summary>
        /// Approval time.
        /// </summary>
        [JsonProperty("ApprovalTime")]
        public string ApprovalTime{ get; set; }

        /// <summary>
        /// Approval notes
        /// </summary>
        [JsonProperty("ApprovalNote")]
        public string ApprovalNote{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApprovalNo", this.ApprovalNo);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApprovalStatus", this.ApprovalStatus);
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "MNPVersion", this.MNPVersion);
            this.SetParamSimple(map, prefix + "MNPVersionId", this.MNPVersionId);
            this.SetParamSimple(map, prefix + "ApplyUser", this.ApplyUser);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPIcon", this.MNPIcon);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationLogo", this.ApplicationLogo);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "MNPQrCodeUrl", this.MNPQrCodeUrl);
            this.SetParamSimple(map, prefix + "MNPType", this.MNPType);
            this.SetParamSimple(map, prefix + "ApprovalUser", this.ApprovalUser);
            this.SetParamSimple(map, prefix + "ApprovalTime", this.ApprovalTime);
            this.SetParamSimple(map, prefix + "ApprovalNote", this.ApprovalNote);
        }
    }
}

