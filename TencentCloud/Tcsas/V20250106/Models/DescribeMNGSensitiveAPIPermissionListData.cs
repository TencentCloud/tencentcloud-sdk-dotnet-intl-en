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

    public class DescribeMNGSensitiveAPIPermissionListData : AbstractModel
    {
        
        /// <summary>
        /// <p>API ID</p>
        /// </summary>
        [JsonProperty("APIId")]
        public string APIId{ get; set; }

        /// <summary>
        /// <p>API name</p>
        /// </summary>
        [JsonProperty("APIName")]
        public string APIName{ get; set; }

        /// <summary>
        /// <p>API method</p>
        /// </summary>
        [JsonProperty("APIMethod")]
        public string APIMethod{ get; set; }

        /// <summary>
        /// <p>API status</p>
        /// </summary>
        [JsonProperty("APIStatus")]
        public long? APIStatus{ get; set; }

        /// <summary>
        /// <p>API request status</p>
        /// </summary>
        [JsonProperty("APIApplyStatus")]
        public long? APIApplyStatus{ get; set; }

        /// <summary>
        /// <p>Reason for rejection</p>
        /// </summary>
        [JsonProperty("RejectReason")]
        public string RejectReason{ get; set; }

        /// <summary>
        /// <p>Approval number</p>
        /// </summary>
        [JsonProperty("ApprovalNo")]
        public string ApprovalNo{ get; set; }

        /// <summary>
        /// <p>Superapp ID</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>Superapp icon</p>
        /// </summary>
        [JsonProperty("ApplicationIcon")]
        public string ApplicationIcon{ get; set; }

        /// <summary>
        /// <p>Superapp name</p>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// <p>API type. Valid values: 1: System; 2: Custom
        /// </summary>
        [JsonProperty("APIType")]
        public long? APIType{ get; set; }

        /// <summary>
        /// <p>API feature description</p>
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

