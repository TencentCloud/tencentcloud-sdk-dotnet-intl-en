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

    public class DescribeMPAllStageVersionsResp : AbstractModel
    {
        
        /// <summary>
        /// Mini program ID.
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// Specifies the mini program version primary key id.
        /// </summary>
        [JsonProperty("MNPVersionId")]
        public long? MNPVersionId{ get; set; }

        /// <summary>
        /// Mini program name
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// Specifies the mini program avatar.
        /// </summary>
        [JsonProperty("MNPIcon")]
        public string MNPIcon{ get; set; }

        /// <summary>
        /// Mini program type
        /// </summary>
        [JsonProperty("MNPType")]
        public string MNPType{ get; set; }

        /// <summary>
        /// Mini program introduction
        /// </summary>
        [JsonProperty("MNPIntro")]
        public string MNPIntro{ get; set; }

        /// <summary>
        /// Mini program description
        /// </summary>
        [JsonProperty("MNPDesc")]
        public string MNPDesc{ get; set; }

        /// <summary>
        /// Specifies the developer.
        /// </summary>
        [JsonProperty("CreateUser")]
        public string CreateUser{ get; set; }

        /// <summary>
        /// Developer creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Mini program version.
        /// </summary>
        [JsonProperty("MNPVersion")]
        public string MNPVersion{ get; set; }

        /// <summary>
        /// Describes version features.
        /// </summary>
        [JsonProperty("MNPVersionIntro")]
        public string MNPVersionIntro{ get; set; }

        /// <summary>
        /// Development Platform Online.
        /// </summary>
        [JsonProperty("Phase")]
        public string Phase{ get; set; }

        /// <summary>
        /// 0 pending review; 1 under review; 2 review rejection; 3 pass review; 4 review cancellation.
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// Approval ticket ID
        /// </summary>
        [JsonProperty("ApprovalNo")]
        public string ApprovalNo{ get; set; }

        /// <summary>
        /// Specifies whether it is a trial version.
        /// Specifies the version type. valid values: 0 (non-preview version); 1 (trial version).
        /// </summary>
        [JsonProperty("ShowCase")]
        public long? ShowCase{ get; set; }

        /// <summary>
        /// Version number to roll back to.
        /// </summary>
        [JsonProperty("RollbackVersion")]
        public long? RollbackVersion{ get; set; }

        /// <summary>
        /// Indicates the release status.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Specifies the current main status of the version. valid values: "0" (pending review), "1" (under review), "2" (review rejection), "3" (pass review), "4" (review cancellation).
        /// </summary>
        [JsonProperty("VersionCurrentStatus")]
        public long? VersionCurrentStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "MNPVersionId", this.MNPVersionId);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPIcon", this.MNPIcon);
            this.SetParamSimple(map, prefix + "MNPType", this.MNPType);
            this.SetParamSimple(map, prefix + "MNPIntro", this.MNPIntro);
            this.SetParamSimple(map, prefix + "MNPDesc", this.MNPDesc);
            this.SetParamSimple(map, prefix + "CreateUser", this.CreateUser);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MNPVersion", this.MNPVersion);
            this.SetParamSimple(map, prefix + "MNPVersionIntro", this.MNPVersionIntro);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "ApprovalStatus", this.ApprovalStatus);
            this.SetParamSimple(map, prefix + "ApprovalNo", this.ApprovalNo);
            this.SetParamSimple(map, prefix + "ShowCase", this.ShowCase);
            this.SetParamSimple(map, prefix + "RollbackVersion", this.RollbackVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VersionCurrentStatus", this.VersionCurrentStatus);
        }
    }
}

