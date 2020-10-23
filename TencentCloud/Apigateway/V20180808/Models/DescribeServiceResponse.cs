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

    public class DescribeServiceResponse : AbstractModel
    {
        
        /// <summary>
        /// Unique service ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Service environment list.
        /// </summary>
        [JsonProperty("AvailableEnvironments")]
        public string[] AvailableEnvironments{ get; set; }

        /// <summary>
        /// Service name.
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Service description.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceDesc")]
        public string ServiceDesc{ get; set; }

        /// <summary>
        /// Protocol supported by service. Valid values: http, https, http&https.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Service creation time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Service modification time.
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// Dedicated cluster name.
        /// </summary>
        [JsonProperty("ExclusiveSetName")]
        public string ExclusiveSetName{ get; set; }

        /// <summary>
        /// Network type list. INNER: private network access; OUTER: public network access.
        /// </summary>
        [JsonProperty("NetTypes")]
        public string[] NetTypes{ get; set; }

        /// <summary>
        /// Subdomain name for private network access.
        /// </summary>
        [JsonProperty("InternalSubDomain")]
        public string InternalSubDomain{ get; set; }

        /// <summary>
        /// Subdomain name for public network access.
        /// </summary>
        [JsonProperty("OuterSubDomain")]
        public string OuterSubDomain{ get; set; }

        /// <summary>
        /// Service port number for HTTP access over private network.
        /// </summary>
        [JsonProperty("InnerHttpPort")]
        public long? InnerHttpPort{ get; set; }

        /// <summary>
        /// Port number for HTTPS access over private network.
        /// </summary>
        [JsonProperty("InnerHttpsPort")]
        public long? InnerHttpsPort{ get; set; }

        /// <summary>
        /// Total number of APIs.
        /// </summary>
        [JsonProperty("ApiTotalCount")]
        public long? ApiTotalCount{ get; set; }

        /// <summary>
        /// API list.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiIdStatusSet")]
        public ApiIdStatus[] ApiIdStatusSet{ get; set; }

        /// <summary>
        /// Total number of usage plans.
        /// </summary>
        [JsonProperty("UsagePlanTotalCount")]
        public long? UsagePlanTotalCount{ get; set; }

        /// <summary>
        /// Usage plan array.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsagePlanList")]
        public UsagePlan[] UsagePlanList{ get; set; }

        /// <summary>
        /// IP version.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// Service user type.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// Reserved field.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SetId")]
        public long? SetId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamArraySimple(map, prefix + "AvailableEnvironments.", this.AvailableEnvironments);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceDesc", this.ServiceDesc);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "ExclusiveSetName", this.ExclusiveSetName);
            this.SetParamArraySimple(map, prefix + "NetTypes.", this.NetTypes);
            this.SetParamSimple(map, prefix + "InternalSubDomain", this.InternalSubDomain);
            this.SetParamSimple(map, prefix + "OuterSubDomain", this.OuterSubDomain);
            this.SetParamSimple(map, prefix + "InnerHttpPort", this.InnerHttpPort);
            this.SetParamSimple(map, prefix + "InnerHttpsPort", this.InnerHttpsPort);
            this.SetParamSimple(map, prefix + "ApiTotalCount", this.ApiTotalCount);
            this.SetParamArrayObj(map, prefix + "ApiIdStatusSet.", this.ApiIdStatusSet);
            this.SetParamSimple(map, prefix + "UsagePlanTotalCount", this.UsagePlanTotalCount);
            this.SetParamArrayObj(map, prefix + "UsagePlanList.", this.UsagePlanList);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

