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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the clb ID. you can call the [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/214/30685?from_cn_redirect=1) API to obtain the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Specifies the name of the cloned load balancing instance. rule: 1-60 english letters, chinese characters, digits, connecting lines "-", or underscores "_".
        /// Note: if the name is identical to that of an existing load balancing instance in the system, the system will automatically generate a name for the created cloud load balancer instance.
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// ID of the project to which a CLB instance belongs, which can be obtained through the `DescribeProject` API. If this parameter is not passed in, the default project will be used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Sets the primary AZ ID for cross-AZ disaster recovery, such as `100001` or `ap-guangzhou-1`, which is applicable only to public network CLB.
        /// Note: A primary AZ loads traffic, while a secondary AZ does not load traffic by default and will be used only if the primary AZ becomes unavailable. The platform will automatically select the optimal secondary AZ. You can use the `DescribeResource` API to query the primary AZ list of a region.
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// Specifies the secondary AZ ID for cross-AZ disaster recovery, such as `100001` or `ap-guangzhou-1`. It is applicable only to public network CLB.
        /// Note: A secondary AZ will load traffic if the primary AZ is faulty. You can use the `DescribeMasterZones` API to query the primary and secondary AZ list of a region.
        /// </summary>
        [JsonProperty("SlaveZoneId")]
        public string SlaveZoneId{ get; set; }

        /// <summary>
        /// Applicable only to public network clb. AZ ID, both availability zone ID and name are supported. specify availability zone to create a load balancing instance, for example: 100001 or ap-guangzhou-1. if not passed, queries CVM instances in all azs. if needed, call the API for the query DescribeZones (https://www.tencentcloud.comom/document/product/213/15707?from_cn_redirect=1) to specify availability zone.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// CLB network billing mode, applicable only to public network CLB instances.
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// It only applies to public CLB. Currently, the static single-line IP type is supported only for the regions of Guangzhou, Shanghai, Nanjing, Jinan, Hangzhou, Fuzhou, Beijing, Shijiazhuang, Wuhan, Changsha, Chengdu, and Chongqing. If you need to experience it, contact your business manager. After approval, you can select the ISP type as China Mobile (CMCC), China Unicom (CUCC), or China Telecom (CTCC). The network billing mode should be selected as billing by bandwidth package (BANDWIDTH_PACKAGE). If this parameter is not specified, BGP is used by default. You can use the DescribeResources API to query ISPs supported for a region.
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }

        /// <summary>
        /// Specifies the Vip to apply for cloud load balancer.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Proceed to purchase cloud load balancer and Tag it at the same time.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Exclusive cluster information.
        /// </summary>
        [JsonProperty("ExclusiveCluster")]
        public ExclusiveCluster ExclusiveCluster{ get; set; }

        /// <summary>
        /// BANDWIDTH PACKAGE ID, which can be obtained through the [DescribeBandwidthPackages](https://www.tencentcloud.comom/document/api/215/19209?from_cn_redirect=1) api. specifies this parameter indicates the network billing mode (InternetAccessible.InternetChargeType) supports only billing by BANDWIDTH PACKAGE (BANDWIDTH_PACKAGE).
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// Specifies whether the cross-regional or cross-Vpc IP binding feature is supported.
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// Enables cross-regional or cross-Vpc IP binding and creates a SnatIp.
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }

        /// <summary>
        /// Public network exclusive cluster ID or CDCId. can be obtained through the [DescribeExclusiveClusters](https://www.tencentcloud.comom/document/product/214/49278?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// Performance capacity specification. <li>clb.c2.medium (standard type)</li> <li>clb.c3.small (advanced type 1)</li> <li>clb.c3.medium (advanced type 2)</li> <li>clb.c4.small (high-strength type 1)</li> <li>clb.c4.medium (high-strength type 2)</li> <li>clb.c4.large (high-strength type 3)</li> <li>clb.c4.xlarge (high-strength type 4)</li>.
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// Specifies the Tag of the Stgw exclusive cluster.
        /// </summary>
        [JsonProperty("ClusterTag")]
        public string ClusterTag{ get; set; }

        /// <summary>
        /// Applicable only to private network clb. when connected to nearby, select availability zone for deployment. you can call DescribeZones (https://www.tencentcloud.comom/document/product/213/15707?from_cn_redirect=1) to query the availability zone list.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// The unique ID of EIP, such as EIP-qhx8udkc, applicable only to private network clb binding EIP, can be queried through the DescribeAddresses API (https://www.tencentcloud.comom/document/product/215/16702?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("EipAddressId")]
        public string EipAddressId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "MasterZoneId", this.MasterZoneId);
            this.SetParamSimple(map, prefix + "SlaveZoneId", this.SlaveZoneId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ExclusiveCluster.", this.ExclusiveCluster);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamArrayObj(map, prefix + "SnatIps.", this.SnatIps);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "ClusterTag", this.ClusterTag);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "EipAddressId", this.EipAddressId);
        }
    }
}

