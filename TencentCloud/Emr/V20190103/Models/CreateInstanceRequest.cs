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

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Product ID. Different product IDs indicate different EMR product versions. Valid values:<br>51: STARROCKS-V1.4.0<br>54: STARROCKS-V2.0.0<br>27: KAFKA-V1.0.0<br>50: KAFKA-V2.0.0<br>16: EMR-V2.3.0<br>20: EMR-V2.5.0<br>30: EMR-V2.6.0<br>38: EMR-V2.7.0<br>25: EMR-V3.1.0<br>33: EMR-V3.2.1<br>34: EMR-V3.3.0<br>37: EMR-V3.4.0<br>44: EMR-V3.5.0<br>53: EMR-V3.6.0<br>58: EMR-3.6.1<br>59: EMR-serverless-1.0.0<br>60: EMR-TKE-1.1.0<br>61: SR-V2.1.0<br>62: SR-V2.1.0-SharedData<br>63: SR-V2.1.0.tlinux<br>64: unified metadata management project<br>65: EMR-TKE-AI-1.0.0<br>66: RSS-1.0.0<br>67: SR-V2.2.0<br>68: SR-V2.2.0.tlinux<br>69: EMR-AI-1.1.0<br>70: SR-V2.2.1<br>71: EMR-3.7.0<br>72: EMR-serverless-1.0.1<br>73: KAFKA-2.0.1<br>74: SR-V2.2.2<br>75: EMR-TKE-AI-1.1.0<br>76: EMR-V3.7.1<br>77: SERVERLESS-TCBASE-1.0.0<br>78: EMR-V3.6.2<br>79: STARROCKS-V2.2.2<br>80: EMR-AI-V1.1.1</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// <p>List of deployed components. Different EMR product IDs correspond to different optional component lists (ProductId: For details about its meaning, see the ProductId request parameter). For details about how to query optional component lists for different product versions, see <a href="https://www.tencentcloud.com/document/product/589/20279?from_cn_redirect=1">Component Version</a>.<br>Example values: hive and flink.</p>
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// <p>Whether to enable high availability for the node. Valid values:</p><li>0: disables high availability for the node.</li><li>1: enables high availability for the node.</li>
        /// </summary>
        [JsonProperty("SupportHA")]
        public ulong? SupportHA{ get; set; }

        /// <summary>
        /// <p>Instance name.</p><li>The value can contain 6 to 36 characters.</li><li>Only Chinese characters, letters, digits, hyphens (-), and underscores (_) are allowed.</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Instance billing mode. Valid values:</p><li>0: pay-as-you-go</li><li>1: yearly/monthly subscription</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>Instance purchase duration, which is used together with TimeUnit.</p><li>When TimeUnit is set to s, this parameter can only be set to 3600, indicating a pay-as-you-go instance.</li><li>When TimeUnit is set to m, the value set for this parameter indicates the subscription duration of the instance. For example, 1 indicates a one-month subscription.</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Time unit for purchasing instances. Valid values:</p><li>s: indicates seconds. When PayMode is set to 0, TimeUnit can only be set to s.</li><li>m: indicates months. When PayMode is set to 1, TimeUnit can only be set to m.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Instance login settings. This parameter is used to set the login method for the purchased node, either the password or key.</p><li>When a key is set, the password is only used to log in to the native WebUI shortcut entry for the component.</li><li>When no key is set, the password is used to log in to the purchased node as well as the native WebUI shortcut entry for the component.</li>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// <p>VPC-related information configuration. This parameter can be used to specify the VPC ID, subnet ID, and so on.</p>
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// <p>Node resource specifications.</p>
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// <p>Specifies the parameters to be set for enabling COS access.</p>
        /// </summary>
        [JsonProperty("COSSettings")]
        public COSSettings COSSettings{ get; set; }

        /// <summary>
        /// <p>Location of the instance. This parameter can be used to specify attributes such as the AZ and associated project of the instance.</p>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// <p>ID of the security group to which the instance belongs, for example, sg-xxxxxxxx. This parameter can be obtained by calling the SecurityGroupId field in the response result of <a href="https://www.tencentcloud.com/document/api/215/15808?from_cn_redirect=1">DescribeSecurityGroups</a>.</p>
        /// </summary>
        [JsonProperty("SgId")]
        public string SgId{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/589/35656?from_cn_redirect=1">Bootstrap operation</a> script settings.</p>
        /// </summary>
        [JsonProperty("PreExecutedFileSettings")]
        public PreExecuteFileSettings[] PreExecutedFileSettings{ get; set; }

        /// <summary>
        /// <p>Whether a yearly/monthly subscription instance is automatically renewed. Valid values:</p><li>0: no</li><li>1: yes</li>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>Unique random identifier, which is valid for five minutes and needs to be specified by the caller. This prevents the client from repeatedly creating resources. Example value: a9a90aa6-<strong><strong>-</strong></strong>-****-fae36063280.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>Whether to enable public network access for the cluster Master node. Valid values:</p><li>NEED_MASTER_WAN: yes</li><li>NOT_NEED_MASTER_WAN: no</li>By default, public network access is enabled for the cluster Master node.
        /// </summary>
        [JsonProperty("NeedMasterWan")]
        public string NeedMasterWan{ get; set; }

        /// <summary>
        /// <p>Whether to enable remote public network login, that is, port 22. If SgId is passed, this parameter is invalid.</p>
        /// </summary>
        [JsonProperty("RemoteLoginAtCreate")]
        public long? RemoteLoginAtCreate{ get; set; }

        /// <summary>
        /// <p>Whether the security cluster is enabled. Valid values: 0 (no) and values other than 0 (yes).</p>
        /// </summary>
        [JsonProperty("CheckSecurity")]
        public long? CheckSecurity{ get; set; }

        /// <summary>
        /// <p>Specifies the external file system to be accessed.</p>
        /// </summary>
        [JsonProperty("ExtendFsField")]
        public string ExtendFsField{ get; set; }

        /// <summary>
        /// <p>List of tag descriptions. When this parameter is specified, tags are bound to the corresponding instance.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>List of dispersed placement group IDs. Currently, only one ID can be specified.<br>This parameter can be obtained by calling the SecurityGroupId field in the response result of <a href="https://www.tencentcloud.com/document/product/213/15486?from_cn_redirect=1">DescribeSecurityGroups</a>.</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>CBS encryption disk at the cluster level. Valid values: 0 (not encrypted) and 1 (encrypted). Default value: 0.</p>
        /// </summary>
        [JsonProperty("CbsEncrypt")]
        public ulong? CbsEncrypt{ get; set; }

        /// <summary>
        /// <p>Hive shared metadata database type. Valid values:</p><li>EMR_DEFAULT_META: created by the cluster by default</li><li>EMR_EXIST_META: EMR-MetaDB specified by the cluster</li><li>USER_CUSTOM_META: custom MetaDB used by the cluster</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>EMR-MetaDB instance.</p>
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }

        /// <summary>
        /// <p>Custom MetaDB information.</p>
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// <p>Custom application role.</p>
        /// </summary>
        [JsonProperty("ApplicationRole")]
        public string ApplicationRole{ get; set; }

        /// <summary>
        /// <p>Scenario-based values:<br>Hadoop-Kudu<br>Hadoop-Zookeeper<br>Hadoop-Presto<br>Hadoop-Hbase</p>
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// <p>Shared component information.</p>
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// <p>If this parameter is set to 0, MultiZone, MultiDeployStrategy, and MultiZoneSettings are disabled. If this parameter is set to 1, ResourceSpec is deprecated and MultiZoneSettings is used.</p>
        /// </summary>
        [JsonProperty("VersionID")]
        public long? VersionID{ get; set; }

        /// <summary>
        /// <p>true: indicates that cross-AZ deployment is enabled. It is only a user parameter for cluster creation and cannot be adjusted subsequently.</p>
        /// </summary>
        [JsonProperty("MultiZone")]
        public bool? MultiZone{ get; set; }

        /// <summary>
        /// <p>Specifications of node resources. Set one for each AZ. The first is the primary AZ, the second is the secondary AZ, and the third is the arbitration AZ. If cross-AZ is disabled, the length only needs to be 1.</p>
        /// </summary>
        [JsonProperty("MultiZoneSettings")]
        public MultiZoneSetting[] MultiZoneSettings{ get; set; }

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
        /// <p>CLB id</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>Database type. Valid values: mysql8/tdsql8.</p>
        /// </summary>
        [JsonProperty("DefaultMetaVersion")]
        public string DefaultMetaVersion{ get; set; }

        /// <summary>
        /// <p>Whether to enable audit. Valid values: 0 (no) and 1 (yes).</p>
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
        /// <p>Whether to enable cluster-level CBS system disk encryption. Valid values: 0 (no) and 1 (yes).</p>
        /// </summary>
        [JsonProperty("CbsSysEncrypt")]
        public long? CbsSysEncrypt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamObj(map, prefix + "COSSettings.", this.COSSettings);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
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
            this.SetParamArrayObj(map, prefix + "ExternalService.", this.ExternalService);
            this.SetParamSimple(map, prefix + "VersionID", this.VersionID);
            this.SetParamSimple(map, prefix + "MultiZone", this.MultiZone);
            this.SetParamArrayObj(map, prefix + "MultiZoneSettings.", this.MultiZoneSettings);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamArrayObj(map, prefix + "NodeMarks.", this.NodeMarks);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "DefaultMetaVersion", this.DefaultMetaVersion);
            this.SetParamSimple(map, prefix + "NeedCdbAudit", this.NeedCdbAudit);
            this.SetParamSimple(map, prefix + "SgIP", this.SgIP);
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
            this.SetParamSimple(map, prefix + "WebUiVersion", this.WebUiVersion);
            this.SetParamSimple(map, prefix + "CbsSysEncrypt", this.CbsSysEncrypt);
        }
    }
}

