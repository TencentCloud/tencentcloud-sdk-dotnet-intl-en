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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiUsagePlan : AbstractModel
    {
        
        /// <summary>
        /// Unique service ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Unique API ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// API name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// API path.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// API method.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Unique usage plan ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsagePlanId")]
        public string UsagePlanId{ get; set; }

        /// <summary>
        /// Usage plan name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsagePlanName")]
        public string UsagePlanName{ get; set; }

        /// <summary>
        /// Usage plan description.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsagePlanDesc")]
        public string UsagePlanDesc{ get; set; }

        /// <summary>
        /// Service environment bound to usage plan.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// Used quota.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InUseRequestNum")]
        public long? InUseRequestNum{ get; set; }

        /// <summary>
        /// Total number of requests allowed. `-1` indicates no limit.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxRequestNum")]
        public long? MaxRequestNum{ get; set; }

        /// <summary>
        /// Request QPS upper limit. `-1` indicates no limit.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxRequestNumPreSec")]
        public long? MaxRequestNumPreSec{ get; set; }

        /// <summary>
        /// Usage plan creation time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Last modified time of usage plan.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// Service name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "UsagePlanId", this.UsagePlanId);
            this.SetParamSimple(map, prefix + "UsagePlanName", this.UsagePlanName);
            this.SetParamSimple(map, prefix + "UsagePlanDesc", this.UsagePlanDesc);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamSimple(map, prefix + "InUseRequestNum", this.InUseRequestNum);
            this.SetParamSimple(map, prefix + "MaxRequestNum", this.MaxRequestNum);
            this.SetParamSimple(map, prefix + "MaxRequestNumPreSec", this.MaxRequestNumPreSec);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
        }
    }
}

