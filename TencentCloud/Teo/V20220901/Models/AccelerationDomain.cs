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
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Acceleration domain name.</p>
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// <p>Acceleration domain name status</p><p>Enumeration values:</p><ul><li>online: effective</li><li>process: deploying</li><li>offline: disabled</li><li>init: not applied, site to be activated</li></ul>
        /// </summary>
        [JsonProperty("DomainStatus")]
        public string DomainStatus{ get; set; }

        /// <summary>
        /// <p>CNAME address.</p>
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// <p>IPv6 status. Valid values:</p><li>follow: Follow the site IPv6 configuration;</li><li>on: Enabled;</li><li>off: Disabled.</li>
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }

        /// <summary>
        /// <p>Acceleration domain ownership verification status. Valid values: </p><li>pending: to be verified;</li><li>finished: verified.</li>
        /// </summary>
        [JsonProperty("IdentificationStatus")]
        public string IdentificationStatus{ get; set; }

        /// <summary>
        /// <p>When the acceleration domain name needs to perform ownership verification to continue providing services, this object will carry the information required for the corresponding verification method.</p>
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// <p>Origin server information.</p>
        /// </summary>
        [JsonProperty("OriginDetail")]
        public OriginDetail OriginDetail{ get; set; }

        /// <summary>
        /// <p>Origin-pull protocol. Valid values:</p><li>FOLLOW: follow protocol;</li><li>HTTP: origin-pull over HTTP protocol;</li><li>HTTPS: origin-pull over HTTPS protocol.</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// <p>HTTP origin port.</p>
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// <p>HTTPS origin port.</p>
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// <p>Acceleration domain name certificate information.</p>
        /// </summary>
        [JsonProperty("Certificate")]
        public AccelerationDomainCertificate Certificate{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// <p>Last modified.</p>
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// <p>List of region access restrictions on a domain name due to compliance issues.</p>
        /// </summary>
        [JsonProperty("ComplianceRestrictions")]
        public ComplianceRestriction[] ComplianceRestrictions{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "ComplianceRestrictions.", this.ComplianceRestrictions);
        }
    }
}

