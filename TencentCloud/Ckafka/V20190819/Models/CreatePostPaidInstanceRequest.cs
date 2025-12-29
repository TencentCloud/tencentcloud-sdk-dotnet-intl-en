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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePostPaidInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>VPC Id, can be obtained through the <a href="https://www.tencentcloud.comom/document/product/215/15778?from_cn_redirect=1">DescribeVpcs</a> api.</p>.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet Id, which can be obtained through the <a href="https://www.tencentcloud.comom/document/product/215/15784?from_cn_redirect=1">DescribeSubnets</a> api.</p>.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <P>Specifies the cluster instance name of ckafka, with a length not exceeding 128 arbitrary characters.</p>.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <P>Specifies the standard edition instance specification for the international site. currently only the standard edition on the international site uses the current field to distinguish specifications, while the domestic site standard edition uses peak bandwidth. fill in 1 for all instances except the international site standard edition. for international site standard edition instances: [entry-level (general)] fill 1; [standard type (standard)] fill 2; [advanced] fill 3; [capacity type (capacity)] fill 4; [advanced type 1 (specialized-1)] fill 5; [advanced type 2 (specialized-2)] fill 6; [advanced type 3 (specialized-3)] fill 7; [advanced type 4 (specialized-4)] fill 8.</p>.
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// <P>The default maximum retention time for instance logs, in minutes. default value: 1440 minutes (1 day) when this parameter is not input. maximum: 30 days. if the message retention time is explicitly set for a topic, the topic retention time takes precedence.</p>.
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// <p>Specifies the cluster Id when creating an instance. input this parameter to indicate the cluster Id. leave it empty if no cluster is specified.</p>.
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// <P>Instance version. currently supports "2.4.1", "2.4.2", "2.8.1", "3.2.3". default value is "2.4.1". "2.4.1" and "2.4.2" belong to the same version, any one can be passed.</p>.
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// <P>Instance type. "standard": standard version, "profession": professional version. (standard version is only supported on the international site. chinese site currently supports professional version)</p>.
        /// </summary>
        [JsonProperty("SpecificationsType")]
        public string SpecificationsType{ get; set; }

        /// <summary>
        /// <p>Specifies the instance disk type for pro edition. standard edition instances do not require this field. valid values: "CLOUD_SSD" (SSD CLOUD disk), "CLOUD_BASIC" (high-performance CLOUD block storage). default value: "CLOUD_BASIC".</p>.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>The peak bandwidth of the instance private network. the default value is 40 MB/s. for standard edition, input the peak bandwidth corresponding to the current instance specifications. note that if the instance created is a pro edition instance, parameter configurations such as peak bandwidth and number of partitions should meet the billing specification of the pro edition. you can view the billing specification through the following link: https://www.tencentcloud.comom/document/product/597/11745.?from_cn_redirect=1</p>.
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// <P>Instance disk size. default value is 500. step length is set to 100. should meet the billing specification of the current instance. can be accessed through the following link to view billing specifications: https://www.tencentcloud.comom/document/product/597/122562.?from_cn_redirect=1</p>.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <P>Specifies the maximum number of partitions for the instance, which should meet the billing specification of the current instance. default value is 800 with a step length of 100. the billing specification can be viewed through the following link: https://www.tencentcloud.comom/document/product/597/122563.?from_cn_redirect=1</p>.
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// <P>Specifies the maximum number of topics for the instance, which should meet the billing specification of the current instance. default value is 800. step length is set to 100.</p>.
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// Specifies the availability zone where the instance is located. when creating a multi-az instance, this parameter indicates the availability zone id of the subnet where the default access point is created. ZoneId and ZoneIds cannot be empty at the same time. you can obtain this information through the API <a href="https://www.tencentcloud.comom/document/product/597/55246?from_cn_redirect=1">DescribeCkafkaZone</a>.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <P>Specifies whether the current instance is a multi-az instance.</p>.
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// <p>Specifies the multi-availability zone id list when the instance is a multi-az instance. note the corresponding multi-availability zone for parameter ZoneId must be included in the parameter array. ZoneId and ZoneIds cannot be empty at the same time. obtain through the API <a href="https://www.tencentcloud.comom/document/product/597/55246?from_cn_redirect=1">DescribeCkafkaZone</a>.</p>.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>Specifies the number of instances to purchase. optional. default value is 1. when input this parameter, it will create multiple instances with case-sensitive suffixes added to instanceName.</p>.
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// <p>Public bandwidth size in Mbps. the free 3 Mbps bandwidth is not included by default. for example, if the total required public network bandwidth is 3 Mbps, input 0 here; if the total required public network bandwidth is 6 Mbps, input 3 here. ensure the input parameter is a multiple of 3.</p>.
        /// </summary>
        [JsonProperty("PublicNetworkMonthly")]
        public long? PublicNetworkMonthly{ get; set; }

        /// <summary>
        /// <p>Tag.</p>.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <P>Specifies the elastic bandwidth switch. 0: disable (default); 1: enable.</p>.
        /// </summary>
        [JsonProperty("ElasticBandwidthSwitch")]
        public long? ElasticBandwidthSwitch{ get; set; }

        /// <summary>
        /// <p>Specifies the custom certificate Id. this parameter is valid only when SpecificationsType is profession. supports custom certificate capacity.</p><p>can be obtained through the <a href="https://www.tencentcloud.comom/document/product/400/41673?from_cn_redirect=1">DescribeCertificateDetail</a> api.</p>.
        /// </summary>
        [JsonProperty("CustomSSLCertId")]
        public string CustomSSLCertId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "SpecificationsType", this.SpecificationsType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "MultiZoneFlag", this.MultiZoneFlag);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "PublicNetworkMonthly", this.PublicNetworkMonthly);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ElasticBandwidthSwitch", this.ElasticBandwidthSwitch);
            this.SetParamSimple(map, prefix + "CustomSSLCertId", this.CustomSSLCertId);
        }
    }
}

