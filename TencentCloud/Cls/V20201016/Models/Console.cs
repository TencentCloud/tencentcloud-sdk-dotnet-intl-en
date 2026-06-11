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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Console : AbstractModel
    {
        
        /// <summary>
        /// <p>DataSight Console Id</p>
        /// </summary>
        [JsonProperty("ConsoleId")]
        public string ConsoleId{ get; set; }

        /// <summary>
        /// <p>Access method: public - internet, internal - intranet</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string[] AccessMode{ get; set; }

        /// <summary>
        /// <p>Log-in methods: 0-account password authentication, 1-anonymous login, 2-third-party authentication login</p>
        /// </summary>
        [JsonProperty("LoginMode")]
        public ulong? LoginMode{ get; set; }

        /// <summary>
        /// <p>Custom domain name prefix</p>
        /// </summary>
        [JsonProperty("DomainPrefix")]
        public string DomainPrefix{ get; set; }

        /// <summary>
        /// <p>User account information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Accounts")]
        public ConsoleAccount[] Accounts{ get; set; }

        /// <summary>
        /// <p>Private network type, defaults to 0</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntranetType")]
        public ulong? IntranetType{ get; set; }

        /// <summary>
        /// <p>Private network region</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntranetRegion")]
        public string IntranetRegion{ get; set; }

        /// <summary>
        /// <p>Private network VpcId</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Private subnet SubnetId</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Anonymous login account information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AnonymousLogin")]
        public AnonymousLoginInfo AnonymousLogin{ get; set; }

        /// <summary>
        /// <p>auth user role information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthRoles")]
        public AuthRoleInfo[] AuthRoles{ get; set; }

        /// <summary>
        /// <p>Bound tag information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Custom hidden parameter</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HideParams")]
        public string[] HideParams{ get; set; }

        /// <summary>
        /// <p>Access Control Rule</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccessControlRules")]
        public AccessControlRule[] AccessControlRules{ get; set; }

        /// <summary>
        /// <p>Remark</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// <p>Customize menu</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Menus")]
        public string[] Menus{ get; set; }

        /// <summary>
        /// <p>Public access domain name</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>private network access domain</p>
        /// </summary>
        [JsonProperty("IntranetDomain")]
        public string IntranetDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsoleId", this.ConsoleId);
            this.SetParamArraySimple(map, prefix + "AccessMode.", this.AccessMode);
            this.SetParamSimple(map, prefix + "LoginMode", this.LoginMode);
            this.SetParamSimple(map, prefix + "DomainPrefix", this.DomainPrefix);
            this.SetParamArrayObj(map, prefix + "Accounts.", this.Accounts);
            this.SetParamSimple(map, prefix + "IntranetType", this.IntranetType);
            this.SetParamSimple(map, prefix + "IntranetRegion", this.IntranetRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamObj(map, prefix + "AnonymousLogin.", this.AnonymousLogin);
            this.SetParamArrayObj(map, prefix + "AuthRoles.", this.AuthRoles);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "HideParams.", this.HideParams);
            this.SetParamArrayObj(map, prefix + "AccessControlRules.", this.AccessControlRules);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamArraySimple(map, prefix + "Menus.", this.Menus);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "IntranetDomain", this.IntranetDomain);
        }
    }
}

