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

namespace TencentCloud.Makers.V20261113.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneDomain : AbstractModel
    {
        
        /// <summary>
        /// <p>Custom or Preset</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Domain name status</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Bound environment slug. Default value: Production</p>
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }

        /// <summary>
        /// <p>Site ID</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Acceleration region</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>CNAME</p>
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// <p>Primary domain name.</p>
        /// </summary>
        [JsonProperty("MainDomain")]
        public string MainDomain{ get; set; }

        /// <summary>
        /// <p>IPv6</p>
        /// </summary>
        [JsonProperty("Ipv6")]
        public SwitchConfig Ipv6{ get; set; }

        /// <summary>
        /// <p>HTTP/2</p>
        /// </summary>
        [JsonProperty("Http2")]
        public SwitchConfig Http2{ get; set; }

        /// <summary>
        /// <p>OCSP</p>
        /// </summary>
        [JsonProperty("OcspStapling")]
        public SwitchConfig OcspStapling{ get; set; }

        /// <summary>
        /// <p>Force HTTPS</p>
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirectConfig ForceRedirect{ get; set; }

        /// <summary>
        /// <p>HSTS</p>
        /// </summary>
        [JsonProperty("Hsts")]
        public HstsConfig Hsts{ get; set; }

        /// <summary>
        /// <p>Ownership verification</p>
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Env", this.Env);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "MainDomain", this.MainDomain);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "Http2.", this.Http2);
            this.SetParamObj(map, prefix + "OcspStapling.", this.OcspStapling);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Hsts.", this.Hsts);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
        }
    }
}

