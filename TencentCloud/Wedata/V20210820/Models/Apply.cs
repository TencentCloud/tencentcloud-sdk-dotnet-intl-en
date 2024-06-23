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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Apply : AbstractModel
    {
        
        /// <summary>
        /// Applicant ID
        /// </summary>
        [JsonProperty("ApplicantId")]
        public string ApplicantId{ get; set; }

        /// <summary>
        /// Applicant Name
        /// </summary>
        [JsonProperty("ApplicantName")]
        public string ApplicantName{ get; set; }

        /// <summary>
        /// Approval Remarks
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Approval Category Key
        /// </summary>
        [JsonProperty("ApproveClassification")]
        public string ApproveClassification{ get; set; }

        /// <summary>
        /// Approval Form ID
        /// </summary>
        [JsonProperty("ApproveId")]
        public string ApproveId{ get; set; }

        /// <summary>
        /// Approval Type Key
        /// </summary>
        [JsonProperty("ApproveType")]
        public string ApproveType{ get; set; }

        /// <summary>
        /// Application Reason
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Creation Time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Approval Time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ApproveTime")]
        public string ApproveTime{ get; set; }

        /// <summary>
        /// Approval Category Name
        /// </summary>
        [JsonProperty("ApproveClassificationName")]
        public string ApproveClassificationName{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Approval Type Name
        /// </summary>
        [JsonProperty("ApproveTypeName")]
        public string ApproveTypeName{ get; set; }

        /// <summary>
        /// Approval Exception or Failure Information
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// Apply for Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ApplyName")]
        public string ApplyName{ get; set; }

        /// <summary>
        /// Approver ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ApproverId")]
        public string ApproverId{ get; set; }

        /// <summary>
        /// Approver Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// Project for Approval
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ApproveProjectName")]
        public string ApproveProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicantId", this.ApplicantId);
            this.SetParamSimple(map, prefix + "ApplicantName", this.ApplicantName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ApproveClassification", this.ApproveClassification);
            this.SetParamSimple(map, prefix + "ApproveId", this.ApproveId);
            this.SetParamSimple(map, prefix + "ApproveType", this.ApproveType);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamSimple(map, prefix + "ApproveClassificationName", this.ApproveClassificationName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApproveTypeName", this.ApproveTypeName);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "ApplyName", this.ApplyName);
            this.SetParamSimple(map, prefix + "ApproverId", this.ApproverId);
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproveProjectName", this.ApproveProjectName);
        }
    }
}

