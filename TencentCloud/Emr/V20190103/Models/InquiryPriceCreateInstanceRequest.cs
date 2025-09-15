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
        /// Time unit of instance purchase duration. Valid values:
        /// <li>s: seconds. When `PayMode` is 0, `TimeUnit` can only be `s`.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Purchase duration of instance, which needs to be used together with `TimeUnit`.
        /// <li>When `TimeUnit` is `s`, this parameter can only be filled with 3600, indicating a pay-as-you-go instance.</li>
        /// <li>When `TimeUnit` is `m`, the number entered in this parameter indicates the purchase duration of the monthly-subscription instance; for example, 1 means one month</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// Currency.
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid values:
        /// <li>0: pay-as-you-go.</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Whether to enable high availability of node. Valid values:
        /// <li>0: does not enable high availability of node.</li>
        /// <li>1: enables high availability of node.</li>
        /// </summary>
        [JsonProperty("SupportHA")]
        public ulong? SupportHA{ get; set; }

        /// <summary>
        /// List of deployed components. Different required components need to be selected for different EMR product IDs (ProductId: For specific meanings, see the ProductId field in the input parameters): <li>When ProductId is 2 (EMR v2.0.1), the required components include hdfs-2.7.3, yarn-2.7.3, zookeeper-3.4.9, and knox-1.2.0.</li> <li>When ProductId is 16 (EMR v2.3.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.5.5, and knox-1.2.0.</li> <li>When ProductId is 20 (EMR v2.5.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.1, and knox-1.2.0.</li> <li>When ProductId is 30 (EMR v2.6.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.1, openldap-2.4.44, and knox-1.2.0.</li> <li>When ProductId is 38 (EMR v2.7.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li> <li>When ProductId is 57 (EMR v2.8.0), the required components include hdfs-2.8.5, yarn-2.8.5, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li> <li>When ProductId is 7 (EMR v3.0.0), the required components include hdfs-3.1.2, yarn-3.1.2, zookeeper-3.4.9, and knox-1.2.0.</li> <li>When ProductId is 25 (EMR v3.1.0), the required components include hdfs-3.1.2, yarn-3.1.2, zookeeper-3.6.1, and knox-1.2.0.</li> <li>When ProductId is 31 (EMR v3.1.1), the required components include hdfs-3.1.2, yarn-3.1.2, zookeeper-3.6.1, and knox-1.2.0.</li> <li>When ProductId is 28 (EMR v3.2.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.1, and knox-1.2.0.</li> <li>When ProductId is 33 (EMR v3.2.1), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.1, openldap-2.4.44, and knox-1.2.0.</li> <li>When ProductId is 34 (EMR v3.3.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.1, openldap-2.4.44, and knox-1.2.0.</li> <li>When ProductId is 37 (EMR v3.4.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li> <li>When ProductId is 44 (EMR v3.5.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li> <li>When ProductId is 53 (EMR v3.6.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li> <li>When ProductId is 58 (EMR v3.6.1), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.46, and knox-1.6.1.</li> <li>When ProductId is 47 (EMR v4.0.0), the required components include hdfs-3.2.2, yarn-3.2.2, zookeeper-3.6.3, openldap-2.4.44, and knox-1.6.1.</li>
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// Node specification queried for price.
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// Instance location. This parameter is used to specify the AZ, project, and other attributes of the instance.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Configuration information of VPC. This parameter is used to specify the VPC ID, subnet ID, etc.
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

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
        /// Product ID. Different product IDs represent different EMR product versions. Valid values: <li>2: EMR v2.0.1;</li> <li>16: EMR v2.3.0;</li> <li>20: EMR v2.5.0;</li> <li>30: EMR v2.6.0;</li> <li>38: EMR v2.7.0;</li> <li>57: EMR v2.8.0;</li> <li>7: EMR v3.0.0;</li> <li>25: EMR v3.1.0;</li> <li>31: EMR v3.1.1;</li> <li>28: EMR v3.2.0</li> <li>33: EMR v3.2.1</li> <li>34: EMR v3.3.0</li> <li>37: EMR v3.4.0;</li> <li>44: EMR v3.5.0;</li> <li>53: EMR v3.6.0;</li> <li>58: EMR v3.6.1;</li> <li>47: EMR v4.0.0.</li>
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// Scenario values: Hadoop-Kudu, Hadoop-ZooKeeper, Hadoop-Presto, and Hadoop-HBase.
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// Shared component information
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VersionID")]
        public ulong? VersionID{ get; set; }

        /// <summary>
        /// AZ specs
        /// </summary>
        [JsonProperty("MultiZoneSettings")]
        public MultiZoneSetting[] MultiZoneSettings{ get; set; }


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
        }
    }
}

