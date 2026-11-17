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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Endpoint : AbstractModel
    {
        
        /// <summary>
        /// <p>Region English name, for example: ap-guangzhou</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Node type. proxy means the node type is host, set means the node type is node. proxy type must be the first item in the array. Source/target configuration for tdsqlmysql type is required.</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>Database kernel type, used in tdsql to differentiate between different kernels: percona, mariadb, mysql. Note that tdsql-C mysql and tdsql PostgreSQL do not need to fill in this field.</p>
        /// </summary>
        [JsonProperty("DbKernel")]
        public string DbKernel{ get; set; }

        /// <summary>
        /// <p>Database instance ID, in the format of: cdb-powiqx8q</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>IP address of the instance. This item is required when the access type is not cdb.</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>Instance port. This item is required when the access type is not cdb.</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>User name, required for accessing instances that need username and password authentication.</p>
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// <p>Password is required for accessing instances that need username and password authentication.</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Database name, required when the database is cdwpg</p>
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// <p>Private network ID. This item is required for private network, Direct Connect, and VPN access methods, in the format of vpc-92jblxto.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID under the private network. This item is required for private network, Direct Connect, and VPN access methods, in the format of subnet-3paxmkdz.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>CVM instance short ID, in the format of: ins-olgl39y8, is identical to the instance ID displayed on the cloud server console page. If it is a CVM self-created instance, this field is required.</p>
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// <p>Direct Connect gateway ID. This item is required for dedicated access type, in the format of: dcg-0rxtqqxb</p>
        /// </summary>
        [JsonProperty("UniqDcgId")]
        public string UniqDcgId{ get; set; }

        /// <summary>
        /// <p>VPN Gateway ID. This item is required for VPN access type, in the format of vpngw-9ghexg7q.</p>
        /// </summary>
        [JsonProperty("UniqVpnGwId")]
        public string UniqVpnGwId{ get; set; }

        /// <summary>
        /// <p>Cloud Connect Network ID. This item is required for the CCN access type, for example: ccn-afp6kltc</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>Cloud vendor type. For RDS instances, fill in aliyun. In other cases, fill in others. Default is others.</p>
        /// </summary>
        [JsonProperty("Supplier")]
        public string Supplier{ get; set; }

        /// <summary>
        /// <p>Database version. Valid only for RDS instances, ignored for other instances, in the format of 5.6 or 5.7, defaults to 5.6.</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// <p>Account of the instance. This item is required if it is a cross-account instance.</p>
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// <p>Associated account is empty, self (means resources within this account), or other (means cross-account resources).</p>
        /// </summary>
        [JsonProperty("AccountMode")]
        public string AccountMode{ get; set; }

        /// <summary>
        /// <p>Role for cross-account sync, only allow [a-zA-Z0-9-_]+. This item is required if it is a cross-account instance.</p>
        /// </summary>
        [JsonProperty("AccountRole")]
        public string AccountRole{ get; set; }

        /// <summary>
        /// <p>External role id</p>
        /// </summary>
        [JsonProperty("RoleExternalId")]
        public string RoleExternalId{ get; set; }

        /// <summary>
        /// <p>Temporary key Id can be obtained by applying for role assumption temporary access credentials https://www.tencentcloud.com/document/product/1312/48197.?from_cn_redirect=1 Among them, the definition of the role resource RoleArn can be found in the DTS cross-account sync document (https://www.tencentcloud.com/document/product/571/68729?from_cn_redirect=1) Section 4 about role-based definition.</p>
        /// </summary>
        [JsonProperty("TmpSecretId")]
        public string TmpSecretId{ get; set; }

        /// <summary>
        /// <p>Temporary key Id can be obtained by applying for role assumption temporary access credentials at https://www.tencentcloud.com/document/product/1312/48197.?from_cn_redirect=1 Among them, the definition of the role resource RoleArn can be found in the DTS cross-account sync document (https://www.tencentcloud.com/document/product/571/68729?from_cn_redirect=1) Section 4 about role definition.</p>
        /// </summary>
        [JsonProperty("TmpSecretKey")]
        public string TmpSecretKey{ get; set; }

        /// <summary>
        /// <p>Temporary key Id can be obtained by applying for role assumption temporary access credentials https://www.tencentcloud.com/document/product/1312/48197.?from_cn_redirect=1 Among them, the definition of the role resource RoleArn can be found in the DTS cross-account sync document (https://www.tencentcloud.com/document/product/571/68729?from_cn_redirect=1) Section 4 about role-based definition.</p>
        /// </summary>
        [JsonProperty("TmpToken")]
        public string TmpToken{ get; set; }

        /// <summary>
        /// <p>Whether to use encrypted transmission. UnEncrypted means no encrypted transmission, Encrypted means encrypted transmission. Default: UnEncrypted</p>
        /// </summary>
        [JsonProperty("EncryptConn")]
        public string EncryptConn{ get; set; }

        /// <summary>
        /// <p>Network environment of the database. Required when AccessType is Cloud Connect Network (ccn). UserIDC refers to User IDC, and TencentVPC refers to Tencent Cloud VPC.</p>
        /// </summary>
        [JsonProperty("DatabaseNetEnv")]
        public string DatabaseNetEnv{ get; set; }

        /// <summary>
        /// <p>When the database is an instance of cross-account cloud networking, it refers to the main account to which the CCN belongs.</p>
        /// </summary>
        [JsonProperty("CcnOwnerUin")]
        public string CcnOwnerUin{ get; set; }

        /// <summary>
        /// <p>When the database is cynos and it is a sub-database instance within the cynos cluster, this parameter is the ID of the sub-instance.</p>
        /// </summary>
        [JsonProperty("ChildInstanceId")]
        public string ChildInstanceId{ get; set; }

        /// <summary>
        /// <p>When the database is cynos and it is a sub-database instance within the cynos cluster, this parameter is the type of the sub-instance, for example: pass ro for a read-only instance, pass rw for a read-write instance.</p>
        /// </summary>
        [JsonProperty("ChildInstanceType")]
        public string ChildInstanceType{ get; set; }

        /// <summary>
        /// <p>Shard id of tdsql. Required if the node type is set.</p>
        /// </summary>
        [JsonProperty("SetId")]
        public string SetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "DbKernel", this.DbKernel);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
            this.SetParamSimple(map, prefix + "UniqDcgId", this.UniqDcgId);
            this.SetParamSimple(map, prefix + "UniqVpnGwId", this.UniqVpnGwId);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "Supplier", this.Supplier);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "AccountMode", this.AccountMode);
            this.SetParamSimple(map, prefix + "AccountRole", this.AccountRole);
            this.SetParamSimple(map, prefix + "RoleExternalId", this.RoleExternalId);
            this.SetParamSimple(map, prefix + "TmpSecretId", this.TmpSecretId);
            this.SetParamSimple(map, prefix + "TmpSecretKey", this.TmpSecretKey);
            this.SetParamSimple(map, prefix + "TmpToken", this.TmpToken);
            this.SetParamSimple(map, prefix + "EncryptConn", this.EncryptConn);
            this.SetParamSimple(map, prefix + "DatabaseNetEnv", this.DatabaseNetEnv);
            this.SetParamSimple(map, prefix + "CcnOwnerUin", this.CcnOwnerUin);
            this.SetParamSimple(map, prefix + "ChildInstanceId", this.ChildInstanceId);
            this.SetParamSimple(map, prefix + "ChildInstanceType", this.ChildInstanceType);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
        }
    }
}

