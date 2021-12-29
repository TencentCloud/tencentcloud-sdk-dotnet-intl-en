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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Product ID. Different product IDs represent different EMR product versions. Valid values:
        /// <li>1: EMR v1.3.1</li>
        /// <li>2: EMR v2.0.1</li>
        /// <li>4: EMR v2.1.0</li>
        /// <li>7: EMR v3.0.0</li>
        /// <li>9: EMR v2.2.0</li>
        /// <li>11: ClickHouse v1.0.0</li>
        /// <li>13: Druid v1.0.0</li>
        /// <li>15: EMR v2.2.1</li>
        /// <li>16: EMR v2.3.0</li>
        /// <li>17: ClickHouse v1.1.0</li>
        /// <li>19: EMR v2.4.0</li>
        /// <li>20: EMR v2.5.0</li>
        /// <li>22: ClickHouse v1.2.0</li>
        /// <li>24: EMR TianQiong v1.0.0</li>
        /// <li>25: EMR v3.1.0</li>
        /// <li>26: Doris v1.0.0</li>
        /// <li>27: Kafka v1.0.0</li>
        /// <li>28: EMR v3.2.0</li>
        /// <li>29: EMR v2.5.1</li>
        /// <li>30: EMR v2.6.0</li>
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// Configuration information of VPC. This parameter is used to specify the VPC ID, subnet ID, etc.
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// List of deployed components. The list of component options varies by EMR product ID (i.e., `ProductId`; for specific meanings, please see the `ProductId` input parameter). For more information, please see [Component Version](https://intl.cloud.tencent.com/document/product/589/20279?from_cn_redirect=1).
        /// Enter an instance value: `hive` or `flink`.
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// Node resource specification.
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// Whether to enable high node availability. Valid values:
        /// <li>0: does not enable high availability of node.</li>
        /// <li>1: enables high availability of node.</li>
        /// </summary>
        [JsonProperty("SupportHA")]
        public ulong? SupportHA{ get; set; }

        /// <summary>
        /// Instance name.
        /// <li>Length limit: 6-36 characters.</li>
        /// <li>Only letters, numbers, dashes (-), and underscores (_) are supported.</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid values:
        /// <li>0: pay-as-you-go.</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Instance location. This parameter is used to specify the AZ, project, and other attributes of the instance.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Purchase duration of instance, which needs to be used together with `TimeUnit`.
        /// <li>When `TimeUnit` is `s`, this parameter can only be filled with 3600, indicating a pay-as-you-go instance.</li>
        /// <li>When `TimeUnit` is `m`, the number entered in this parameter indicates the purchase duration of the monthly-subscription instance; for example, 1 means one month</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// Time unit of instance purchase duration. Valid values:
        /// <li>s: seconds. When `PayMode` is 0, `TimeUnit` can only be `s`.</li>
        /// <li>m: month. When `PayMode` is 1, `TimeUnit` can only be `m`.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Instance login settings. This parameter allows you to set the login password or key for your purchased node.
        /// <li>If the key is set, the password will be only used for login to the native component WebUI.</li>
        /// <li>If the key is not set, the password will be used for login to all purchased nodes and the native component WebUI.</li>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// Parameter required for enabling COS access.
        /// </summary>
        [JsonProperty("COSSettings")]
        public COSSettings COSSettings{ get; set; }

        /// <summary>
        /// Security group to which an instance belongs in the format of `sg-xxxxxxxx`. This parameter can be obtained from the `SecurityGroupId` field in the return value of the [DescribeSecurityGroups](https://intl.cloud.tencent.com/document/api/215/15808) API.
        /// </summary>
        [JsonProperty("SgId")]
        public string SgId{ get; set; }

        /// <summary>
        /// [Bootstrap action](https://intl.cloud.tencent.com/document/product/589/35656?from_cn_redirect=1) script settings
        /// </summary>
        [JsonProperty("PreExecutedFileSettings")]
        public PreExecuteFileSettings[] PreExecutedFileSettings{ get; set; }

        /// <summary>
        /// Whether auto-renewal is enabled. Valid values:
        /// <li>0: auto-renewal not enabled.</li>
        /// <li>1: auto-renewal enabled.</li>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// Client token.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Whether to enable public IP access for master node. Valid values:
        /// <li>NEED_MASTER_WAN: enables public IP for master node.</li>
        /// <li>NOT_NEED_MASTER_WAN: does not enable.</li>Public IP is enabled for master node by default.
        /// </summary>
        [JsonProperty("NeedMasterWan")]
        public string NeedMasterWan{ get; set; }

        /// <summary>
        /// Whether to enable remote public network login, i.e., port 22. When `SgId` is not empty, this parameter does not take effect.
        /// </summary>
        [JsonProperty("RemoteLoginAtCreate")]
        public long? RemoteLoginAtCreate{ get; set; }

        /// <summary>
        /// Whether to enable secure cluster. 0: no; other values: yes.
        /// </summary>
        [JsonProperty("CheckSecurity")]
        public long? CheckSecurity{ get; set; }

        /// <summary>
        /// Accesses to external file system.
        /// </summary>
        [JsonProperty("ExtendFsField")]
        public string ExtendFsField{ get; set; }

        /// <summary>
        /// Tag description list. This parameter is used to bind a tag to a resource instance.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// List of spread placement group IDs. Only one can be specified currently.
        /// This parameter can be obtained in the `SecurityGroupId` field in the return value of the [DescribeSecurityGroups](https://intl.cloud.tencent.com/document/product/213/15486?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// CBS disk encryption at the cluster level. 0: not encrypted, 1: encrypted
        /// </summary>
        [JsonProperty("CbsEncrypt")]
        public ulong? CbsEncrypt{ get; set; }

        /// <summary>
        /// Hive-shared metadatabase type. Valid values:
        /// <li>EMR_DEFAULT_META: the cluster creates one by default.</li>
        /// <li>EMR_EXIST_META: the cluster uses the specified EMR-MetaDB instance.</li>
        /// <li>USER_CUSTOM_META: the cluster uses a custom MetaDB instance.</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// EMR-MetaDB instance
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }

        /// <summary>
        /// Custom MetaDB instance information
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// Custom application role.
        /// </summary>
        [JsonProperty("ApplicationRole")]
        public string ApplicationRole{ get; set; }

        /// <summary>
        /// Scenario-based values:
        /// Hadoop-Kudu
        /// Hadoop-Zookeeper
        /// Hadoop-Presto
        /// Hadoop-Hbase
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "COSSettings.", this.COSSettings);
            this.SetParamSimple(map, prefix + "SgId", this.SgId);
            this.SetParamArrayObj(map, prefix + "PreExecutedFileSettings.", this.PreExecutedFileSettings);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "NeedMasterWan", this.NeedMasterWan);
            this.SetParamSimple(map, prefix + "RemoteLoginAtCreate", this.RemoteLoginAtCreate);
            this.SetParamSimple(map, prefix + "CheckSecurity", this.CheckSecurity);
            this.SetParamSimple(map, prefix + "ExtendFsField", this.ExtendFsField);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "CbsEncrypt", this.CbsEncrypt);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamSimple(map, prefix + "ApplicationRole", this.ApplicationRole);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
        }
    }
}

