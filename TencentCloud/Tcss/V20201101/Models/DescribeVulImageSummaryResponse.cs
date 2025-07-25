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

    public class DescribeVulImageSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of images affected by critical or high-risk vulnerabilities
        /// </summary>
        [JsonProperty("SeriousVulImageCount")]
        public long? SeriousVulImageCount{ get; set; }

        /// <summary>
        /// Number of scanned images
        /// </summary>
        [JsonProperty("ScannedImageCount")]
        public long? ScannedImageCount{ get; set; }

        /// <summary>
        /// Total number of vulnerabilities
        /// </summary>
        [JsonProperty("VulTotalCount")]
        public long? VulTotalCount{ get; set; }

        /// <summary>
        /// Number of system vulnerabilities
        /// </summary>
        [JsonProperty("SysTemVulCount")]
        public long? SysTemVulCount{ get; set; }

        /// <summary>
        /// Number of web application vulnerabilities
        /// </summary>
        [JsonProperty("WebVulCount")]
        public long? WebVulCount{ get; set; }

        /// <summary>
        /// Number of licensed images
        /// </summary>
        [JsonProperty("AllAuthorizedImageCount")]
        public long? AllAuthorizedImageCount{ get; set; }

        /// <summary>
        /// Number of emergency vulnerabilities
        /// </summary>
        [JsonProperty("EmergencyVulCount")]
        public long? EmergencyVulCount{ get; set; }

        /// <summary>
        /// Total number of vulnerabilities that can be scanned for
        /// </summary>
        [JsonProperty("SupportVulTotalCount")]
        public long? SupportVulTotalCount{ get; set; }

        /// <summary>
        /// Vulnerability library update time
        /// </summary>
        [JsonProperty("VulLibraryUpdateTime")]
        public string VulLibraryUpdateTime{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SeriousVulImageCount", this.SeriousVulImageCount);
            this.SetParamSimple(map, prefix + "ScannedImageCount", this.ScannedImageCount);
            this.SetParamSimple(map, prefix + "VulTotalCount", this.VulTotalCount);
            this.SetParamSimple(map, prefix + "SysTemVulCount", this.SysTemVulCount);
            this.SetParamSimple(map, prefix + "WebVulCount", this.WebVulCount);
            this.SetParamSimple(map, prefix + "AllAuthorizedImageCount", this.AllAuthorizedImageCount);
            this.SetParamSimple(map, prefix + "EmergencyVulCount", this.EmergencyVulCount);
            this.SetParamSimple(map, prefix + "SupportVulTotalCount", this.SupportVulTotalCount);
            this.SetParamSimple(map, prefix + "VulLibraryUpdateTime", this.VulLibraryUpdateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

