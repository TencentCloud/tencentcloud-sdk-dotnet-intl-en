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

    public class UsagePlanInfo : AbstractModel
    {
        
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
        /// Number of initialization calls.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InitQuota")]
        public long? InitQuota{ get; set; }

        /// <summary>
        /// Limit of requests per second.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxRequestNumPreSec")]
        public long? MaxRequestNumPreSec{ get; set; }

        /// <summary>
        /// Maximum number of calls.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxRequestNum")]
        public long? MaxRequestNum{ get; set; }

        /// <summary>
        /// Whether to hide.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsHide")]
        public long? IsHide{ get; set; }

        /// <summary>
        /// Creation time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Last modified time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// Number of bound keys.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindSecretIdTotalCount")]
        public long? BindSecretIdTotalCount{ get; set; }

        /// <summary>
        /// Details of bound keys.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindSecretIds")]
        public string[] BindSecretIds{ get; set; }

        /// <summary>
        /// Number of bound environments.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindEnvironmentTotalCount")]
        public long? BindEnvironmentTotalCount{ get; set; }

        /// <summary>
        /// Details of bound environments.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindEnvironments")]
        public UsagePlanBindEnvironment[] BindEnvironments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsagePlanId", this.UsagePlanId);
            this.SetParamSimple(map, prefix + "UsagePlanName", this.UsagePlanName);
            this.SetParamSimple(map, prefix + "UsagePlanDesc", this.UsagePlanDesc);
            this.SetParamSimple(map, prefix + "InitQuota", this.InitQuota);
            this.SetParamSimple(map, prefix + "MaxRequestNumPreSec", this.MaxRequestNumPreSec);
            this.SetParamSimple(map, prefix + "MaxRequestNum", this.MaxRequestNum);
            this.SetParamSimple(map, prefix + "IsHide", this.IsHide);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "BindSecretIdTotalCount", this.BindSecretIdTotalCount);
            this.SetParamArraySimple(map, prefix + "BindSecretIds.", this.BindSecretIds);
            this.SetParamSimple(map, prefix + "BindEnvironmentTotalCount", this.BindEnvironmentTotalCount);
            this.SetParamArrayObj(map, prefix + "BindEnvironments.", this.BindEnvironments);
        }
    }
}

