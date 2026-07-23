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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPNetwork : AbstractModel
    {
        
        /// <summary>
        /// <p>Internet service provider</p>
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// <p>Autonomous system number</p>
        /// </summary>
        [JsonProperty("ASN")]
        public string ASN{ get; set; }

        /// <summary>
        /// <p>IP registration organization name</p>
        /// </summary>
        [JsonProperty("Organization")]
        public string Organization{ get; set; }

        /// <summary>
        /// <p>Whether it is a reserved IP address</p>
        /// </summary>
        [JsonProperty("IsReserved")]
        public bool? IsReserved{ get; set; }

        /// <summary>
        /// <p>Whether it is a gateway IP address</p>
        /// </summary>
        [JsonProperty("IsGateway")]
        public bool? IsGateway{ get; set; }

        /// <summary>
        /// <p>Whether it belongs to an anycast network</p>
        /// </summary>
        [JsonProperty("IsAnycast")]
        public bool? IsAnycast{ get; set; }

        /// <summary>
        /// <p>Whether it is from a mobile network</p>
        /// </summary>
        [JsonProperty("IsMobile")]
        public bool? IsMobile{ get; set; }

        /// <summary>
        /// <p>Whether it is a dynamic IP address</p>
        /// </summary>
        [JsonProperty("IsDynamic")]
        public bool? IsDynamic{ get; set; }

        /// <summary>
        /// <p>Whether it is a network egress</p>
        /// </summary>
        [JsonProperty("IsEgress")]
        public bool? IsEgress{ get; set; }

        /// <summary>
        /// <p>Whether it is used for domain name resolution</p>
        /// </summary>
        [JsonProperty("IsDNS")]
        public bool? IsDNS{ get; set; }

        /// <summary>
        /// <p>Whether it is an educational institution</p>
        /// </summary>
        [JsonProperty("IsEducation")]
        public bool? IsEducation{ get; set; }

        /// <summary>
        /// <p>Whether it is an organization</p>
        /// </summary>
        [JsonProperty("IsInstitution")]
        public bool? IsInstitution{ get; set; }

        /// <summary>
        /// <p>Whether it is an enterprise dedicated line</p>
        /// </summary>
        [JsonProperty("IsCompany")]
        public bool? IsCompany{ get; set; }

        /// <summary>
        /// <p>Whether it is a residence broadband connection</p>
        /// </summary>
        [JsonProperty("IsResidence")]
        public bool? IsResidence{ get; set; }

        /// <summary>
        /// <p>Whether it is cloud service</p>
        /// </summary>
        [JsonProperty("IsCloudService")]
        public bool? IsCloudService{ get; set; }

        /// <summary>
        /// <p>Whether it is infrastructure</p>
        /// </summary>
        [JsonProperty("IsInfrastructure")]
        public bool? IsInfrastructure{ get; set; }

        /// <summary>
        /// <p>Whether it is an mail exchange service</p>
        /// </summary>
        [JsonProperty("IsMXServer")]
        public bool? IsMXServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamSimple(map, prefix + "ASN", this.ASN);
            this.SetParamSimple(map, prefix + "Organization", this.Organization);
            this.SetParamSimple(map, prefix + "IsReserved", this.IsReserved);
            this.SetParamSimple(map, prefix + "IsGateway", this.IsGateway);
            this.SetParamSimple(map, prefix + "IsAnycast", this.IsAnycast);
            this.SetParamSimple(map, prefix + "IsMobile", this.IsMobile);
            this.SetParamSimple(map, prefix + "IsDynamic", this.IsDynamic);
            this.SetParamSimple(map, prefix + "IsEgress", this.IsEgress);
            this.SetParamSimple(map, prefix + "IsDNS", this.IsDNS);
            this.SetParamSimple(map, prefix + "IsEducation", this.IsEducation);
            this.SetParamSimple(map, prefix + "IsInstitution", this.IsInstitution);
            this.SetParamSimple(map, prefix + "IsCompany", this.IsCompany);
            this.SetParamSimple(map, prefix + "IsResidence", this.IsResidence);
            this.SetParamSimple(map, prefix + "IsCloudService", this.IsCloudService);
            this.SetParamSimple(map, prefix + "IsInfrastructure", this.IsInfrastructure);
            this.SetParamSimple(map, prefix + "IsMXServer", this.IsMXServer);
        }
    }
}

