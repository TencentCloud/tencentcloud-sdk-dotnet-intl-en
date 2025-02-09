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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNPSensitiveAPIPermissionApprovalListData : AbstractModel
    {
        
        /// <summary>
        /// Approval ID
        /// </summary>
        [JsonProperty("ApprovalNo")]
        public string ApprovalNo{ get; set; }

        /// <summary>
        /// Sensitive API ID
        /// </summary>
        [JsonProperty("APIId")]
        public string APIId{ get; set; }

        /// <summary>
        /// API name
        /// </summary>
        [JsonProperty("APIName")]
        public string APIName{ get; set; }

        /// <summary>
        /// API request method
        /// </summary>
        [JsonProperty("APIMethod")]
        public string APIMethod{ get; set; }

        /// <summary>
        /// Mini program ID
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// Mini program name
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

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
        /// Application notes
        /// </summary>
        [JsonProperty("ApplyNote")]
        public string ApplyNote{ get; set; }

        /// <summary>
        /// Approval status. 1: Processing; 20: Rejected; 30: Approved
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// Approver
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApprovalUser")]
        public string ApprovalUser{ get; set; }

        /// <summary>
        /// Approval time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApprovalTime")]
        public string ApprovalTime{ get; set; }

        /// <summary>
        /// Approval notes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApprovalNote")]
        public string ApprovalNote{ get; set; }

        /// <summary>
        /// Application ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Application name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Application icon
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationLogo")]
        public string ApplicationLogo{ get; set; }

        /// <summary>
        /// API type. 1: System; 2: Custom
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIType")]
        public long? APIType{ get; set; }

        /// <summary>
        /// API feature description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIDesc")]
        public string APIDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApprovalNo", this.ApprovalNo);
            this.SetParamSimple(map, prefix + "APIId", this.APIId);
            this.SetParamSimple(map, prefix + "APIName", this.APIName);
            this.SetParamSimple(map, prefix + "APIMethod", this.APIMethod);
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "ApplyUser", this.ApplyUser);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "ApplyNote", this.ApplyNote);
            this.SetParamSimple(map, prefix + "ApprovalStatus", this.ApprovalStatus);
            this.SetParamSimple(map, prefix + "ApprovalUser", this.ApprovalUser);
            this.SetParamSimple(map, prefix + "ApprovalTime", this.ApprovalTime);
            this.SetParamSimple(map, prefix + "ApprovalNote", this.ApprovalNote);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationLogo", this.ApplicationLogo);
            this.SetParamSimple(map, prefix + "APIType", this.APIType);
            this.SetParamSimple(map, prefix + "APIDesc", this.APIDesc);
        }
    }
}

