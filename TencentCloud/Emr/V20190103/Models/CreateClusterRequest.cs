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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>EMR product version name, for example, EMR-V2.3.0 (EMR 2.3.0). Currently, product version names can be queried. For details, see <a href="https://www.tencentcloud.com/document/product/589/66338?from_cn_redirect=1">Product Version Name</a>.</p>
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// <p>Whether to enable high availability for the node. Valid values:</p><li>true: yes</li><li>false: no</li>
        /// </summary>
        [JsonProperty("EnableSupportHAFlag")]
        public bool? EnableSupportHAFlag{ get; set; }

        /// <summary>
        /// <p>Instance name.</p><li>The value can contain 6 to 36 characters.</li><li>Only Chinese characters, letters, digits, hyphens (-), and underscores (_) are allowed.</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Instance billing mode. Valid values:</p><li>PREPAID: prepaid, that is, yearly/monthly subscription</li><li>POSTPAID_BY_HOUR: pay-as-you-go on an hourly basis</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Instance login settings. This parameter is used to set the login method for the purchased node, either the password or key.</p><li>When a key is set, the password is only used to log in to the native WebUI shortcut entry for the component.</li><li>When no key is set, the password is used to log in to the purchased node as well as the native WebUI shortcut entry for the component.</li>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// <p>Cluster application scenario and supported deployment component configuration.</p>
        /// </summary>
        [JsonProperty("SceneSoftwareConfig")]
        public SceneSoftwareConfig SceneSoftwareConfig{ get; set; }

        /// <summary>
        /// <p>Parameter settings related to yearly/monthly subscription. This parameter can be used to specify the purchase duration of a yearly/monthly subscription instance, whether to enable auto-renewal, and other attributes. This parameter is required if the billing mode of the specified instance is prepaid.</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>ID of the security group to which the instance belongs, for example, sg-xxxxxxxx. This parameter can be obtained by calling the SecurityGroupId field in the response result of <a href="https://www.tencentcloud.com/document/api/215/15808?from_cn_redirect=1">DescribeSecurityGroups</a>.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/589/35656?from_cn_redirect=1">Bootstrap operation</a> script settings.</p>
        /// </summary>
        [JsonProperty("ScriptBootstrapActionConfig")]
        public ScriptBootstrapActionConfig[] ScriptBootstrapActionConfig{ get; set; }

        /// <summary>
        /// <p>Unique random identifier with a time-to-live of 5 minutes, which needs to be specified by the caller to prevent the client from repeatedly creating resources, for example, a9a90aa6-<strong><strong>-</strong></strong>-****-fae360632808.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>Whether to enable public network access for the cluster Master node. Valid values:</p><li>NEED_MASTER_WAN: yes</li><li>NOT_NEED_MASTER_WAN: no</li>By default, public network access is enabled for the cluster Master node.
        /// </summary>
        [JsonProperty("NeedMasterWan")]
        public string NeedMasterWan{ get; set; }

        /// <summary>
        /// <p>Whether to enable remote login in the public network. (When SecurityGroupId is not empty, this parameter is invalid.) If this parameter is left empty, it is disabled by default. Valid values:</p><li>true: enable</li><li>false: disable</li>
        /// </summary>
        [JsonProperty("EnableRemoteLoginFlag")]
        public bool? EnableRemoteLoginFlag{ get; set; }

        /// <summary>
        /// <p>Whether to enable Kerberos authentication. It is disabled by default. Valid values:</p><li>true: enabled</li><li>false: disabled</li>
        /// </summary>
        [JsonProperty("EnableKerberosFlag")]
        public bool? EnableKerberosFlag{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/589/35655?from_cn_redirect=1?from_cn_redirect=1">Custom software configuration.</a></p>
        /// </summary>
        [JsonProperty("CustomConf")]
        public string CustomConf{ get; set; }

        /// <summary>
        /// <p>List of tag descriptions. When this parameter is specified, tags are bound to the corresponding instance.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>List of dispersed placement group IDs. Currently, only one ID can be specified.<br>This parameter can be obtained by calling the DisasterRecoverGroupId field in the response result of <a href="https://www.tencentcloud.com/document/product/213/17810?from_cn_redirect=1">DescribeDisasterRecoverGroups</a>.</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>Whether to enable cluster-level CBS encryption. It is not encrypted by default. Valid values:</p><li>true: encrypted</li><li>false: not encrypted</li>
        /// </summary>
        [JsonProperty("EnableCbsEncryptFlag")]
        public bool? EnableCbsEncryptFlag{ get; set; }

        /// <summary>
        /// <p>MetaDB information. When MetaType is set to EMR_NEW_META, MetaDataJdbcUrl, MetaDataUser, MetaDataPass, and UnifyMetaInstanceId can be left empty.<br>When MetaType is set to EMR_EXIT_META, set UnifyMetaInstanceId.<br>When MetaType is set to USER_CUSTOM_META, set MetaDataJdbcUrl, MetaDataUser, and MetaDataPass.</p>
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaDBInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// <p>Shared component information.</p>
        /// </summary>
        [JsonProperty("DependService")]
        public DependService[] DependService{ get; set; }

        /// <summary>
        /// <p>Specifications of node resources. Set one for each AZ. The first is the primary AZ, the second is the secondary AZ, and the third is the arbitration AZ. If cross-AZ is disabled, the length only needs to be 1.</p>
        /// </summary>
        [JsonProperty("ZoneResourceConfiguration")]
        public ZoneResourceConfiguration[] ZoneResourceConfiguration{ get; set; }

        /// <summary>
        /// <p>COS bucket path, which is used when a StarRocks compute-storage separation cluster is created.</p>
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// <p>Node flag information, which is currently only provided for the Terraform platform.</p>
        /// </summary>
        [JsonProperty("NodeMarks")]
        public NodeMark[] NodeMarks{ get; set; }

        /// <summary>
        /// <p>clb id</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>Database version. Valid values: mysql8/tdsql8/mysql5.</p>
        /// </summary>
        [JsonProperty("DefaultMetaVersion")]
        public string DefaultMetaVersion{ get; set; }

        /// <summary>
        /// <p>Whether database audit is enabled.</p>
        /// </summary>
        [JsonProperty("NeedCdbAudit")]
        public long? NeedCdbAudit{ get; set; }

        /// <summary>
        /// <p>Source IP address, which is specified in the security group.</p>
        /// </summary>
        [JsonProperty("SgIP")]
        public string SgIP{ get; set; }

        /// <summary>
        /// <p>Partition of a partition placement group.</p>
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public long? PartitionNumber{ get; set; }

        /// <summary>
        /// <p>Service UI address.</p><p>Enumeration values:</p><ul><li>0: Service UI address. Only one service UI address is returned.</li><li>1: Service UI address. If the service has multiple UI addresses, all results are returned, such as Impalad, StateStore, and Catalogd of Impala.</li></ul><p>Default value: 0.</p>
        /// </summary>
        [JsonProperty("WebUiVersion")]
        public long? WebUiVersion{ get; set; }

        /// <summary>
        /// <p>Whether the system disk is encrypted.</p>
        /// </summary>
        [JsonProperty("EnableCbsSysEncryptFlag")]
        public bool? EnableCbsSysEncryptFlag{ get; set; }

        /// <summary>
        /// <p>Custom MetaDB data.</p>
        /// </summary>
        [JsonProperty("MetaDBGroupInfo")]
        public CustomMetaDBInfo[] MetaDBGroupInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "EnableSupportHAFlag", this.EnableSupportHAFlag);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "SceneSoftwareConfig.", this.SceneSoftwareConfig);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "ScriptBootstrapActionConfig.", this.ScriptBootstrapActionConfig);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "NeedMasterWan", this.NeedMasterWan);
            this.SetParamSimple(map, prefix + "EnableRemoteLoginFlag", this.EnableRemoteLoginFlag);
            this.SetParamSimple(map, prefix + "EnableKerberosFlag", this.EnableKerberosFlag);
            this.SetParamSimple(map, prefix + "CustomConf", this.CustomConf);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "EnableCbsEncryptFlag", this.EnableCbsEncryptFlag);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamArrayObj(map, prefix + "DependService.", this.DependService);
            this.SetParamArrayObj(map, prefix + "ZoneResourceConfiguration.", this.ZoneResourceConfiguration);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamArrayObj(map, prefix + "NodeMarks.", this.NodeMarks);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "DefaultMetaVersion", this.DefaultMetaVersion);
            this.SetParamSimple(map, prefix + "NeedCdbAudit", this.NeedCdbAudit);
            this.SetParamSimple(map, prefix + "SgIP", this.SgIP);
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
            this.SetParamSimple(map, prefix + "WebUiVersion", this.WebUiVersion);
            this.SetParamSimple(map, prefix + "EnableCbsSysEncryptFlag", this.EnableCbsSysEncryptFlag);
            this.SetParamArrayObj(map, prefix + "MetaDBGroupInfo.", this.MetaDBGroupInfo);
        }
    }
}

