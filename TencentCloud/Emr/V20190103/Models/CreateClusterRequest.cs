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
        /// The EMR version, such as `EMR-V2.3.0` that indicates the version 2.3.0 of EMR. You can query the EMR version [here](https://intl.cloud.tencent.com/document/product/589/66338?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// Whether to enable high availability for nodes. Valid values:
        /// <li>`true`: Enable</li>
        /// <li>`false`: Disable</li>
        /// </summary>
        [JsonProperty("EnableSupportHAFlag")]
        public bool? EnableSupportHAFlag{ get; set; }

        /// <summary>
        /// The instance name.
        /// <li>Length limit: 6-36 characters.</li>
        /// <li>Can contain only Chinese characters, letters, digits, hyphens (-), and underscores (_).</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// The instance billing mode. Valid values:
        /// <li>`POSTPAID_BY_HOUR`: The postpaid mode by hour.</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// The instance login setting. This parameter allows you to set a login password or key for your purchased node.
        /// <li>If a key is set, the password will be used for login to the native component WebUI only.</li>
        /// <li>If no key is set, the password will be used for login to all purchased nodes and the native component WebUI.</li>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// The configuration of cluster application scenario and supported components.
        /// </summary>
        [JsonProperty("SceneSoftwareConfig")]
        public SceneSoftwareConfig SceneSoftwareConfig{ get; set; }

        /// <summary>
        /// The details of the monthly subscription, including the instance period and auto-renewal. It is required if `InstanceChargeType` is `PREPAID`.
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// The ID of the security group to which the instance belongs, in the format of `sg-xxxxxxxx`. You can call the [DescribeSecurityGroups](https://intl.cloud.tencent.com/document/api/215/15808?from_cn_redirect=1) API and obtain this parameter from the `SecurityGroupId` field in the response.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// The [Bootstrap action](https://intl.cloud.tencent.com/document/product/589/35656?from_cn_redirect=1) script settings.
        /// </summary>
        [JsonProperty("ScriptBootstrapActionConfig")]
        public ScriptBootstrapActionConfig[] ScriptBootstrapActionConfig{ get; set; }

        /// <summary>
        /// Unique random identifier with the time efficiency of 5 minutes, which needs to be specified by the caller to prevent the client from repeatedly creating resources, for example, a9a90aa6-****-****-****-fae360632808.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Whether to enable public IP access for master nodes. Valid values:
        /// <li>`NEED_MASTER_WAN`: Enable public IP for master nodes.</li>
        /// <li>`NOT_NEED_MASTER_WAN`: Disable.</li>The public IP is enabled for master nodes by default.
        /// </summary>
        [JsonProperty("NeedMasterWan")]
        public string NeedMasterWan{ get; set; }

        /// <summary>
        /// Whether to enable remote login over the public network. It is invalid if `SecurityGroupId` is passed in. It is disabled by default. Valid values:
        /// <li>`true`: Enable</li>
        /// <li>`false`: Disable</li>
        /// </summary>
        [JsonProperty("EnableRemoteLoginFlag")]
        public bool? EnableRemoteLoginFlag{ get; set; }

        /// <summary>
        /// Whether to enable Kerberos authentication. Valid values:
        /// <li>`true`: Enable</li>
        /// <li>`false` (default): Disable</li>
        /// </summary>
        [JsonProperty("EnableKerberosFlag")]
        public bool? EnableKerberosFlag{ get; set; }

        /// <summary>
        /// [Custom software configuration](https://intl.cloud.tencent.com/document/product/589/35655?from_cn_redirect=1?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("CustomConf")]
        public string CustomConf{ get; set; }

        /// <summary>
        /// The tag description list. This parameter is used to bind a tag to a resource instance.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The list of spread placement group IDs. Only one can be specified.
        /// You can call the [DescribeDisasterRecoverGroups](https://intl.cloud.tencent.com/document/product/213/17810?from_cn_redirect=1) API and obtain this parameter from the `DisasterRecoverGroupId` field in the response.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// Whether to enable the cluster-level CBS encryption. Valid values:
        /// <li>`true`: Enable</li>
        /// <li>`false` (default): Disable</li>
        /// </summary>
        [JsonProperty("EnableCbsEncryptFlag")]
        public bool? EnableCbsEncryptFlag{ get; set; }

        /// <summary>
        /// The metadatabase information. If `MetaType` is `EMR_NEW_META`, `MetaDataJdbcUrl`, `MetaDataUser`, `MetaDataPass`, and `UnifyMetaInstanceId` are not required.
        /// If `MetaType` is `EMR_EXIT_META`, `UnifyMetaInstanceId` is required.
        /// If `MetaType` is `USER_CUSTOM_META`, `MetaDataJdbcUrl`, `MetaDataUser`, and `MetaDataPass` are required.
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaDBInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// The shared component information.
        /// </summary>
        [JsonProperty("DependService")]
        public DependService[] DependService{ get; set; }

        /// <summary>
        /// The node resource specs. A spec is specified for each AZ, with the first spec for the primary AZ, the second for the backup AZ, and the third for the arbitrator AZ. If the multi-AZ mode is not enabled, only one spec is required.
        /// </summary>
        [JsonProperty("ZoneResourceConfiguration")]
        public ZoneResourceConfiguration[] ZoneResourceConfiguration{ get; set; }

        /// <summary>
        /// COS bucket path, which is used when you create StarRocks compute-storage separation clusters.
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// Node identifier information: currently used only in Terraform.
        /// </summary>
        [JsonProperty("NodeMarks")]
        public NodeMark[] NodeMarks{ get; set; }

        /// <summary>
        /// clb id
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }


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
        }
    }
}

