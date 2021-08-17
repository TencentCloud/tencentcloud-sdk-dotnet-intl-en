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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BriefDomain : AbstractModel
    {
        
        /// <summary>
        /// Domain name ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Tencent Cloud account ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Acceleration domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// CNAME address of domain name
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// Acceleration service status
        /// rejected: the domain name is rejected due to expiration/deregistration of its ICP filing
        /// processing: deploying
        /// online: activated
        /// offline: disabled
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Project ID, which can be viewed on the Tencent Cloud project management page
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Domain name service type
        /// web: static acceleration
        /// download: download acceleration
        /// media: streaming VOD acceleration
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Domain name creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified time of domain name
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Origin server configuration details
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// Domain name block status
        /// normal: normal
        /// overdue: the domain name has been disabled due to account arrears. The acceleration service can be resumed after the account is topped up.
        /// malicious: the acceleration service has been forcibly disabled due to detection of malicious behavior.
        /// ddos: the acceleration service has been disabled due to large-scale DDoS attacks to the domain name
        /// idle: no operations or data has been detected for more than 90 days. The domain name is determined to be inactive which automatically disables the acceleration service. You can restart the service.
        /// unlicensed: the acceleration service has been automatically disabled as the domain name has no ICP filing or its ICP filing is deregistered. Service can be resumed after an ICP filing is obtained.
        /// capping: the configured upper limit for bandwidth has been reached.
        /// readonly: the domain name has a special configuration and has been locked.
        /// </summary>
        [JsonProperty("Disable")]
        public string Disable{ get; set; }

        /// <summary>
        /// Acceleration region
        /// mainland: acceleration in Mainland China
        /// overseas: acceleration outside Mainland China
        /// global: global acceleration
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Domain name lock status
        /// normal: not locked
        /// mainland: locked in Mainland China
        /// overseas: locked outside Mainland China
        /// global: locked globally
        /// </summary>
        [JsonProperty("Readonly")]
        public string Readonly{ get; set; }

        /// <summary>
        /// Product of the domain name, either `cdn` or `ecdn`.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Readonly", this.Readonly);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

