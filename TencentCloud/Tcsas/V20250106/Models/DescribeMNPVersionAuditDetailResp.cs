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

    public class DescribeMNPVersionAuditDetailResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Approval number.</p>
        /// </summary>
        [JsonProperty("AuditNo")]
        public string AuditNo{ get; set; }

        /// <summary>
        /// <p>Mini program or mini game appid.</p>
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// <p>Mini program or mini game name.</p>
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// <p>Mini program icon.</p>
        /// </summary>
        [JsonProperty("MNPIcon")]
        public string MNPIcon{ get; set; }

        /// <summary>
        /// <p>Mini program category.</p>
        /// </summary>
        [JsonProperty("MNPType")]
        public string MNPType{ get; set; }

        /// <summary>
        /// <p>Mini program introduction.</p>
        /// </summary>
        [JsonProperty("MNPIntro")]
        public string MNPIntro{ get; set; }

        /// <summary>
        /// <p>Mini program version.</p>
        /// </summary>
        [JsonProperty("MNPVersion")]
        public string MNPVersion{ get; set; }

        /// <summary>
        /// <p>Mini program version introduction.</p>
        /// </summary>
        [JsonProperty("MNPVersionIntro")]
        public string MNPVersionIntro{ get; set; }

        /// <summary>
        /// <p>Applicant.</p>
        /// </summary>
        [JsonProperty("ApplyUser")]
        public string ApplyUser{ get; set; }

        /// <summary>
        /// <p>Application time.</p>
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// <p>Approver.</p>
        /// </summary>
        [JsonProperty("AuditUser")]
        public string AuditUser{ get; set; }

        /// <summary>
        /// <p>Approval time.</p>
        /// </summary>
        [JsonProperty("AuditTime")]
        public string AuditTime{ get; set; }

        /// <summary>
        /// <p>Approval status. Valid values: 0: Pending; 1: Processing; 2: Rejected; 3: Approved; 4: Cancelled.</p>
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }

        /// <summary>
        /// <p>Number of associated superapps.</p>
        /// </summary>
        [JsonProperty("MNPRelAppCount")]
        public long? MNPRelAppCount{ get; set; }

        /// <summary>
        /// <p>Information encoded in the mini program QR code.</p>
        /// </summary>
        [JsonProperty("QRCodeContent")]
        public string QRCodeContent{ get; set; }

        /// <summary>
        /// <p>Approval note.</p>
        /// </summary>
        [JsonProperty("AuditNote")]
        public string AuditNote{ get; set; }

        /// <summary>
        /// <p>Mini program version ID.</p>
        /// </summary>
        [JsonProperty("MNPVersionId")]
        public long? MNPVersionId{ get; set; }

        /// <summary>
        /// <p>Age rating information.</p>
        /// </summary>
        [JsonProperty("AgeRatings")]
        public AgeRatingItem[] AgeRatings{ get; set; }

        /// <summary>
        /// <p>Superapp approval information.</p>
        /// </summary>
        [JsonProperty("AppAuditList")]
        public DescribeMNPAuditDetailAppAuditInfo[] AppAuditList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditNo", this.AuditNo);
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPIcon", this.MNPIcon);
            this.SetParamSimple(map, prefix + "MNPType", this.MNPType);
            this.SetParamSimple(map, prefix + "MNPIntro", this.MNPIntro);
            this.SetParamSimple(map, prefix + "MNPVersion", this.MNPVersion);
            this.SetParamSimple(map, prefix + "MNPVersionIntro", this.MNPVersionIntro);
            this.SetParamSimple(map, prefix + "ApplyUser", this.ApplyUser);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "AuditUser", this.AuditUser);
            this.SetParamSimple(map, prefix + "AuditTime", this.AuditTime);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "MNPRelAppCount", this.MNPRelAppCount);
            this.SetParamSimple(map, prefix + "QRCodeContent", this.QRCodeContent);
            this.SetParamSimple(map, prefix + "AuditNote", this.AuditNote);
            this.SetParamSimple(map, prefix + "MNPVersionId", this.MNPVersionId);
            this.SetParamArrayObj(map, prefix + "AgeRatings.", this.AgeRatings);
            this.SetParamArrayObj(map, prefix + "AppAuditList.", this.AppAuditList);
        }
    }
}

