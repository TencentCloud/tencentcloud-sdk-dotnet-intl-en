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

    public class ModifyConsoleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>DataSight Console ConsoleId</p>
        /// </summary>
        [JsonProperty("ConsoleId")]
        public string ConsoleId{ get; set; }

        /// <summary>
        /// <p>Access method: public - public network, internal - private network</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string[] AccessMode{ get; set; }

        /// <summary>
        /// <p>Login methods</p><p>Enumeration value:</p><ul><li>0: Account password authentication</li><li>1: Anonymous login</li><li>2: Third-party authentication login</li></ul>
        /// </summary>
        [JsonProperty("LoginMode")]
        public ulong? LoginMode{ get; set; }

        /// <summary>
        /// <p>Custom domain name prefix</p>
        /// </summary>
        [JsonProperty("DomainPrefix")]
        public string DomainPrefix{ get; set; }

        /// <summary>
        /// <p>User account information</p><p>"Account password authentication" is required for login methods.</p>
        /// </summary>
        [JsonProperty("Accounts")]
        public ConsoleAccount[] Accounts{ get; set; }

        /// <summary>
        /// <p>Anonymous login account information</p><p>"Anonymous login" is required for the login method.</p>
        /// </summary>
        [JsonProperty("AnonymousLogin")]
        public AnonymousLoginInfo AnonymousLogin{ get; set; }

        /// <summary>
        /// <p>Private network type, defaults to 0</p>
        /// </summary>
        [JsonProperty("IntranetType")]
        public ulong? IntranetType{ get; set; }

        /// <summary>
        /// <p>Private network region</p>
        /// </summary>
        [JsonProperty("IntranetRegion")]
        public string IntranetRegion{ get; set; }

        /// <summary>
        /// <p>Private network VpcId</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Private subnet SubnetId</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Auth user role information</p><p>"Third-party authentication login" is required for the login method.</p>
        /// </summary>
        [JsonProperty("AuthRoles")]
        public AuthRoleInfo[] AuthRoles{ get; set; }

        /// <summary>
        /// <p>Custom hidden parameter</p>
        /// </summary>
        [JsonProperty("HideParams")]
        public string[] HideParams{ get; set; }

        /// <summary>
        /// <p>Access Control Rule</p><p>The "third-party authentication login" login method requires the AccessMode: internal && Action: ACCEPT rule.</p>
        /// </summary>
        [JsonProperty("AccessControlRules")]
        public AccessControlRule[] AccessControlRules{ get; set; }

        /// <summary>
        /// <p>Remark</p>
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// <p>Custom display menu</p>
        /// </summary>
        [JsonProperty("Menus")]
        public string[] Menus{ get; set; }


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
            this.SetParamObj(map, prefix + "AnonymousLogin.", this.AnonymousLogin);
            this.SetParamSimple(map, prefix + "IntranetType", this.IntranetType);
            this.SetParamSimple(map, prefix + "IntranetRegion", this.IntranetRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "AuthRoles.", this.AuthRoles);
            this.SetParamArraySimple(map, prefix + "HideParams.", this.HideParams);
            this.SetParamArrayObj(map, prefix + "AccessControlRules.", this.AccessControlRules);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamArraySimple(map, prefix + "Menus.", this.Menus);
        }
    }
}

