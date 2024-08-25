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

    public class DescribeMNPSensitiveAPIPermissionListData : AbstractModel
    {
        
        /// <summary>
        /// API ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIId")]
        public string APIId{ get; set; }

        /// <summary>
        /// API name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIName")]
        public string APIName{ get; set; }

        /// <summary>
        /// API request method
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIMethod")]
        public string APIMethod{ get; set; }

        /// <summary>
        /// API status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIStatus")]
        public long? APIStatus{ get; set; }

        /// <summary>
        /// API application status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIApplyStatus")]
        public long? APIApplyStatus{ get; set; }

        /// <summary>
        /// Reason for rejection
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RejectReason")]
        public string RejectReason{ get; set; }

        /// <summary>
        /// Approval ID
        /// </summary>
        [JsonProperty("ApprovalNo")]
        public string ApprovalNo{ get; set; }

        /// <summary>
        /// Application ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Application icon
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationIcon")]
        public string ApplicationIcon{ get; set; }

        /// <summary>
        /// Application name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

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
            this.SetParamSimple(map, prefix + "APIId", this.APIId);
            this.SetParamSimple(map, prefix + "APIName", this.APIName);
            this.SetParamSimple(map, prefix + "APIMethod", this.APIMethod);
            this.SetParamSimple(map, prefix + "APIStatus", this.APIStatus);
            this.SetParamSimple(map, prefix + "APIApplyStatus", this.APIApplyStatus);
            this.SetParamSimple(map, prefix + "RejectReason", this.RejectReason);
            this.SetParamSimple(map, prefix + "ApprovalNo", this.ApprovalNo);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationIcon", this.ApplicationIcon);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "APIType", this.APIType);
            this.SetParamSimple(map, prefix + "APIDesc", this.APIDesc);
        }
    }
}

