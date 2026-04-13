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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccelerationDomain : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Accelerated domain name
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Accelerated domain name status. valid values:.
        /// <li>online: in effect;</li>.
        /// <li>process: deployment in progress.</li>.
        /// <li>offline: disabled;</li>.
        /// <li>`forbidden`: banned.</li>.
        /// <li>init: not applied, site to be activated.</li>.
        /// </summary>
        [JsonProperty("DomainStatus")]
        public string DomainStatus{ get; set; }

        /// <summary>
        /// The CNAME address.
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// IPv6 status. valid values:.
        /// <li>follow: specifies whether to adhere to the site IPv6 configuration.</li>.
        /// <li>on: enabled status.</li>.
        /// <li>off: disabled.</li>.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }

        /// <summary>
        /// Acceleration domain ownership verification status. valid values:. 
        /// <li>pending: to be verified.</li>.
        /// <li>finished: verified.</li>.	
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("IdentificationStatus")]
        public string IdentificationStatus{ get; set; }

        /// <summary>
        /// Acceleration domain name needs to perform ownership verification to continue providing services. this object carries the required information for the corresponding verification method.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// Details of the origin.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginDetail")]
        public OriginDetail OriginDetail{ get; set; }

        /// <summary>
        /// Origin-Pull protocol. valid values:.
        /// <Li>FOLLOW: follow protocol.</li>.
        /// <Li>HTTP: specifies the http protocol for origin-pull.</li>.
        /// <Li>HTTPS: specifies the https protocol for origin-pull.</li>.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// Specifies the HTTP origin port.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// Specifies the HTTPS origin port.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// Accelerates domain name certificate information.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Certificate")]
        public AccelerationDomainCertificate Certificate{ get; set; }

        /// <summary>
        /// Creation time of the accelerated domain name.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Modification time of the accelerated domain name.
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "IPv6Status", this.IPv6Status);
            this.SetParamSimple(map, prefix + "IdentificationStatus", this.IdentificationStatus);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
            this.SetParamObj(map, prefix + "OriginDetail.", this.OriginDetail);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HttpOriginPort", this.HttpOriginPort);
            this.SetParamSimple(map, prefix + "HttpsOriginPort", this.HttpsOriginPort);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

