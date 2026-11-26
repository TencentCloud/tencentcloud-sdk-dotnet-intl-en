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

    public class DetailHost : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Acceleration service status. Valid values:
        /// <li> process: deploying;</li>
        /// <li> online: started;</li>
        /// <li>offline: closed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Domain name.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Assigned Cname domain name
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Lock status.
        /// </summary>
        [JsonProperty("Lock")]
        public long? Lock{ get; set; }

        /// <summary>
        /// Domain name status type.
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// Domain name acceleration area. Valid values:
        /// <li> global: global;</li>
        /// <li> mainland: Chinese mainland;</li>
        /// <li> overseas: outside the Chinese mainland.</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Acceleration type configuration item.
        /// </summary>
        [JsonProperty("AccelerateType")]
        public AccelerateType AccelerateType{ get; set; }

        /// <summary>
        /// Https configuration item.
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// Cache configuration item.
        /// </summary>
        [JsonProperty("CacheConfig")]
        public CacheConfig CacheConfig{ get; set; }

        /// <summary>
        /// Origin server configuration item.
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// Security type.
        /// </summary>
        [JsonProperty("SecurityType")]
        public SecurityType SecurityType{ get; set; }

        /// <summary>
        /// Cache key configuration item.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// Intelligent compression configuration item.
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// Waf protection configuration item.
        /// </summary>
        [JsonProperty("Waf")]
        public Waf Waf{ get; set; }

        /// <summary>
        /// CC protection configuration item.
        /// </summary>
        [JsonProperty("CC")]
        public CC CC{ get; set; }

        /// <summary>
        /// DDoS protection configuration.
        /// </summary>
        [JsonProperty("DDoS")]
        public DDoS DDoS{ get; set; }

        /// <summary>
        /// Intelligent routing configuration item.
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRouting SmartRouting{ get; set; }

        /// <summary>
        /// Ipv6 access configuration item.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// Configuration of whether to carry the region of the client IP during origin-pull.
        /// </summary>
        [JsonProperty("ClientIpCountry")]
        public ClientIpCountry ClientIpCountry{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Lock", this.Lock);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamObj(map, prefix + "AccelerateType.", this.AccelerateType);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "CacheConfig.", this.CacheConfig);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "SecurityType.", this.SecurityType);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "Waf.", this.Waf);
            this.SetParamObj(map, prefix + "CC.", this.CC);
            this.SetParamObj(map, prefix + "DDoS.", this.DDoS);
            this.SetParamObj(map, prefix + "SmartRouting.", this.SmartRouting);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "ClientIpCountry.", this.ClientIpCountry);
        }
    }
}

