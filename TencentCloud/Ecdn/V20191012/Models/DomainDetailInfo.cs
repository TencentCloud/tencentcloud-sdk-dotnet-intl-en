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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// Domain name ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Tencent Cloud account ID.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Acceleration domain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Domain name CNAME.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// Domain name status. Valid values: pending (reviewing), rejected (rejected), processing (deploying after approval), online (enabled), offline (disabled), deleted (deleted).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Domain name creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Domain name update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Origin server configuration.
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpFilter")]
        public IpFilter IpFilter{ get; set; }

        /// <summary>
        /// IP access limit configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpFreqLimit")]
        public IpFreqLimit IpFreqLimit{ get; set; }

        /// <summary>
        /// Origin server response header configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResponseHeader")]
        public ResponseHeader ResponseHeader{ get; set; }

        /// <summary>
        /// Node caching configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// Caching rule configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cache")]
        public Cache Cache{ get; set; }

        /// <summary>
        /// HTTPS configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// Domain name blockage status. Valid values: normal (normal), overdue (service is suspended due to arrears), quota (trial traffic package is used up), malicious (malicious user), ddos (DDoS attack), idle (no traffic), unlicensed (no ICP filing), capping (bandwidth cap reached), readonly (read-only).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Disable")]
        public string Disable{ get; set; }

        /// <summary>
        /// Forced access protocol redirection configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Acceleration region. Valid values: mainland, overseas, global.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Domain name lock status. normal: not locked; global: globally locked.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Readonly")]
        public string Readonly{ get; set; }


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
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "IpFilter.", this.IpFilter);
            this.SetParamObj(map, prefix + "IpFreqLimit.", this.IpFreqLimit);
            this.SetParamObj(map, prefix + "ResponseHeader.", this.ResponseHeader);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Readonly", this.Readonly);
        }
    }
}

