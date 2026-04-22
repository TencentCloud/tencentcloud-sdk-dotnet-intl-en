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

    public class DescribeMNGAllStageVersionsResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Mini game appid</p>
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// <p>Mini game version ID</p>
        /// </summary>
        [JsonProperty("MNPVersionId")]
        public long? MNPVersionId{ get; set; }

        /// <summary>
        /// <p>Mini game name</p>
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// <p>Mini game icon</p>
        /// </summary>
        [JsonProperty("MNPIcon")]
        public string MNPIcon{ get; set; }

        /// <summary>
        /// <p>Mini game category</p>
        /// </summary>
        [JsonProperty("MNPType")]
        public string MNPType{ get; set; }

        /// <summary>
        /// <p>Mini game introduction</p>
        /// </summary>
        [JsonProperty("MNPIntro")]
        public string MNPIntro{ get; set; }

        /// <summary>
        /// <p>Mini game description</p>
        /// </summary>
        [JsonProperty("MNPDesc")]
        public string MNPDesc{ get; set; }

        /// <summary>
        /// <p>Developer</p>
        /// </summary>
        [JsonProperty("CreateUser")]
        public string CreateUser{ get; set; }

        /// <summary>
        /// <p>Developer creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Mini game version</p>
        /// </summary>
        [JsonProperty("MNPVersion")]
        public string MNPVersion{ get; set; }

        /// <summary>
        /// <p>Version feature description</p>
        /// </summary>
        [JsonProperty("MNPVersionIntro")]
        public string MNPVersionIntro{ get; set; }

        /// <summary>
        /// <p>Version:</p> Develop, preview, released</p>
        /// </summary>
        [JsonProperty("Phase")]
        public string Phase{ get; set; }

        /// <summary>
        /// <p>Valid values: 0: Pending; 1: Processing; 2: Rejected; 3: Approved; 4: Cancelled</p>
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// <p>Approval number</p>
        /// </summary>
        [JsonProperty("ApprovalNo")]
        public string ApprovalNo{ get; set; }

        /// <summary>
        /// <p>Whether this is a preview. Valid values: 0: No; 1: Yes</p>
        /// </summary>
        [JsonProperty("ShowCase")]
        public long? ShowCase{ get; set; }

        /// <summary>
        /// <p>Rollback version number</p>
        /// </summary>
        [JsonProperty("RollbackVersion")]
        public long? RollbackVersion{ get; set; }

        /// <summary>
        /// <p>Available status</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Primary status of the current version. Valid values: 0: Pending; 1: Processing; 2: Rejected; 3: Approved; 4: Cancelled</p>
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

