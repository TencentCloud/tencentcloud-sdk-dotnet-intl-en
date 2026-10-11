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

    public class InquiryPriceCreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Time unit for purchasing instances. Valid values:</p><li>s: indicates seconds. When PayMode is set to 0, TimeUnit can only be set to s.</li><li>m: indicates months. When PayMode is set to 1, TimeUnit can only be set to m.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Instance purchase duration, which is used together with TimeUnit.</p><li>When TimeUnit is set to s, this parameter can only be set to 3600, indicating a pay-as-you-go instance.</li><li>When TimeUnit is set to m, the value set for this parameter indicates the subscription duration of the instance. For example, 1 indicates a one-month subscription.</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Currency type. Valid values:</p><li>CNY: RMB</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// <p>Instance billing mode. Valid values:</p><li>0: pay-as-you-go</li><li>1: yearly/monthly subscription</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>Whether to enable high availability for the node. Valid values:</p><li>0: no</li><li>1: yes</li>
        /// </summary>
        [JsonProperty("SupportHA")]
        public ulong? SupportHA{ get; set; }

        /// <summary>
        /// <p>List of deployed components. For different EMR product IDs, different required component lists need to be set (ProductId: For details about its meaning, see the ProductId parameter). Valid values: <li>When ProductId is set to 2 (EMR-V2.0.1), the required components include hdfs-2.7.3, yarn-2.7.3, zookeeper-3.4.9, and knox-1.2.0.</li><li>When ProductId is set to 16 (EMR-V2.3.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.5.5, and knox-1.2.0.</li><li>When ProductId is set to 20 (EMR-V2.5.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.1, and knox-1.2.0.</li><li>When ProductId is set to 30 (EMR-V2.6.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.1, openldap-2.4.44, and knox-1.2.0.</li><li>When ProductId is set to 38 (EMR-V2.7.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li><li>When ProductId is set to 57 (EMR-V2.8.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li><li>When ProductId is set to 7 (EMR-V3.0.0), the required components include hdfs-3.1.2, yarn-3.1.2, zookeeper-3.4.9, and knox-1.2.0.</li><li>When ProductId is set to 25 (EMR-V3.1.0), the required components include hdfs-3.1.2, yarn-3.1.2, zookeeper-3.6.1, and knox-1.2.0.</li><li>When ProductId is set to 31 (EMR-V3.1.1), the required components include hdfs-3.1.2, yarn-3.1.2, zookeeper-3.6.1, and knox-1.2.0.</li><li>When ProductId is set to 28 (EMR-V3.2.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.1, and knox-1.2.0.</li><li>When ProductId is set to 33 (EMR-V3.2.1), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.1, openldap-2.4.44, and knox-1.2.0.</li><li>When ProductId is set to 34 (EMR-V3.3.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.1, openldap-2.4.44, and knox-1.2.0.</li><li>When ProductId is set to 37 (EMR-V3.4.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li><li>When ProductId is set to 44 (EMR-V3.5.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li><li>When ProductId is set to 53 (EMR-V3.6.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li><li>When ProductId is set to 58 (EMR-V3.6.1), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.46, and knox-1.6.1.</li><li>When ProductId is set to 47 (EMR-V4.0.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li></p>
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// <p>Node specifications for price inquiry.</p>
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// <p>Location of the instance. This parameter can be used to specify attributes such as the AZ and associated project of the instance.</p>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// <p>VPC-related information configuration. This parameter can be used to specify the VPC ID, subnet ID, and so on.</p>
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// <p>Hive shared metadata database type. Valid values:</p><li>EMR_NEW_META: created by the cluster by default</li><li>EMR_EXIT_METE: EMR-MetaDB specified by the cluster</li><li>USER_CUSTOM_META: custom MetaDB used by the cluster</li>
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
        /// <p>Product ID. Different product IDs indicate different EMR product versions. Valid values: <li>2: EMR-V2.0.1</li><li>16: EMR-V2.3.0</li><li>20: EMR-V2.5.0</li><li>30: EMR-V2.6.0</li><li>38: EMR-V2.7.0</li><li>57: EMR-V2.8.0</li><li>7: EMR-V3.0.0</li><li>25: EMR-V3.1.0</li><li>31: EMR-V3.1.1</li><li>28: EMR-V3.2.0</li><li>33: EMR-V3.2.1</li><li>34: EMR-V3.3.0</li><li>37: EMR-V3.4.0</li><li>44: EMR-V3.5.0</li><li>53: EMR-V3.6.0</li><li>58: EMR-V3.6.1</li><li>47: EMR-V4.0.0</li></p>
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// <p>Scenario-based values: Hadoop-Kudu, Hadoop-Zookeeper, Hadoop-Presto, and Hadoop-Hbase.</p>
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// <p>Shared component information.</p>
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// <p>Default value: 0. It is changed to 1 after the cross-AZ feature is supported.</p>
        /// </summary>
        [JsonProperty("VersionID")]
        public ulong? VersionID{ get; set; }

        /// <summary>
        /// <p>Specification information of the AZ.</p>
        /// </summary>
        [JsonProperty("MultiZoneSettings")]
        public MultiZoneSetting[] MultiZoneSettings{ get; set; }

        /// <summary>
        /// <p>Database version.</p>
        /// </summary>
        [JsonProperty("DefaultMetaVersion")]
        public string DefaultMetaVersion{ get; set; }

        /// <summary>
        /// <p>Whether to enable audit. Valid values: 0 (no) and 1 (yes).</p>
        /// </summary>
        [JsonProperty("NeedCdbAudit")]
        public long? NeedCdbAudit{ get; set; }

        /// <summary>
        /// <p>Custom database data.</p>
        /// </summary>
        [JsonProperty("MetaDBGroupInfo")]
        public CustomMetaDBInfo[] MetaDBGroupInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamArrayObj(map, prefix + "ExternalService.", this.ExternalService);
            this.SetParamSimple(map, prefix + "VersionID", this.VersionID);
            this.SetParamArrayObj(map, prefix + "MultiZoneSettings.", this.MultiZoneSettings);
            this.SetParamSimple(map, prefix + "DefaultMetaVersion", this.DefaultMetaVersion);
            this.SetParamSimple(map, prefix + "NeedCdbAudit", this.NeedCdbAudit);
            this.SetParamArrayObj(map, prefix + "MetaDBGroupInfo.", this.MetaDBGroupInfo);
        }
    }
}

